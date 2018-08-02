using Consensus.CodeGenerator.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Consensus.CodeGenerator
{
    public partial class MainForm : Form
    {
        #region enums

        /// <summary>
        ///     Enumerates the generation execution states
        /// </summary>
        private enum GenerationState
        {
            /// <summary>
            ///     Code generation is not running.
            /// </summary>
            Stopped = 0,

            /// <summary>
            ///     Code generation is running.
            /// </summary>
            Started = 1,

            /// <summary>
            ///     Code generation is running, application will close upon completion (if successful).
            /// </summary>
            Shutdown = 2
        }

        #endregion

        #region fields

        /// <summary>
        ///     Specifies whether database indexes are supported.
        /// </summary>
        /// <remarks>
        ///     This constant will be removed once database index support has been added.
        /// </remarks>
        public const Boolean SupportsIndex = false;

        /// <summary>
        ///     Specifies whether database constraints are supported.
        /// </summary>
        /// <remarks>
        ///     This constant will be removed once database constraint support has been added.
        /// </remarks>
        public const Boolean SupportsConstraints = false;

        /// <summary>
        ///     Specifies the state of code generation.
        /// </summary>
        private GenerationState _currentState;

        /// <summary>
        ///     The collection of images used within the form.
        /// </summary>
        private ImageList _imageLibrary;

        /// <summary>
        ///     The path of the business domain file being modified.
        /// </summary>
        private String _currentFile;

        /// <summary>
        ///     The instance of the business domain file being modified.
        /// </summary>
        private Domain _currentDomain;

        /// <summary>
        ///     The collection of task lists currently being executed.
        /// </summary>
        private Generator _currentTasks;

        /// <summary>
        ///     The control for passing a cancellation request to the background task.
        /// </summary>
        private CancellationTokenSource _cancelSource;

        /// <summary>
        ///     A static object that can be seen by the background thread, for co-ordination, caching, etc.
        /// </summary>
        private static RuntimeControl _runtime;

        /// <summary>
        ///     Track update of progress/status, to prevent costly updating too often
        /// </summary>
        private DateTime _lastProgress = DateTime.MinValue;

        /// <summary>
        ///     Track update of progress/status, to prevent costly updating too often
        /// </summary>
        private string _lastProgressMessage = "";

        /// <summary>
        ///     The total tasks to be run - for driving the progress bar
        /// </summary>
        private int _totalTasks;

        /// <summary>
        ///     The completed task count - for driving the progress bar
        /// </summary>
        private int _completedTasks;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the collection of images used within the form.
        /// </summary>
        public ImageList ImageLibrary
        {
            get
            {
                if (_imageLibrary == null)
                {
                    _imageLibrary = new ImageList();
                    _imageLibrary.ColorDepth = ColorDepth.Depth32Bit;
                    _imageLibrary.ImageSize = new Size(16, 16);
                    _imageLibrary.Images.Add("Folder", Resources.Folder);
                    _imageLibrary.Images.Add("FolderCode", Resources.FolderCode);
                    _imageLibrary.Images.Add("FolderData", Resources.FolderData);
                    _imageLibrary.Images.Add("FolderSources", Resources.FolderSources);
                    _imageLibrary.Images.Add("Container", Resources.Container);
                    _imageLibrary.Images.Add("Entity", Resources.Entity);
                    _imageLibrary.Images.Add("Table", Resources.Table);
                    _imageLibrary.Images.Add("Database", Resources.Database);
                }

                return _imageLibrary;
            }
        }

        /// <summary>
        ///     Gets or sets the path of the business domain file being modified.
        /// </summary>
        public String CurrentFile
        {
            get { return _currentFile ?? Path.Combine(new DirectoryInfo(".").Parent.Parent.Parent.Parent.FullName, "ConsensusV7.domain"); }
            set { _currentFile = value; _currentDomain = null; }
        }

        /// <summary>
        ///     Gets the path of the business domain file being modified.
        /// </summary>
        public Domain CurrentDomain
        {
            get
            {
                if (_currentDomain == null)
                {
                    _currentDomain = Domain.Load(this.CurrentFile);
                }

                return _currentDomain;
            }
        }

        /// <summary>
        ///     Gets the collection of task lists currently being executed.
        /// </summary>
        public Generator CurrentTasks
        {
            get
            {
                if (_currentTasks == null)
                {
                    _currentTasks = new Generator(this.CurrentDomain);
                    _currentTasks.OnMessage += this.Generator_OnMessage;
                    _currentTasks.OnProgress += this.Generator_OnProgress;
                    _currentTasks.OnStart += this.Generator_OnStart;
                    _currentTasks.OnFinish += this.Generator_OnFinish;
                    _currentTasks.OnError += this.Generator_OnError;
                }

                return _currentTasks;
            }
        }

        /// <summary>
        ///     Gets or sets the state of code generation.
        /// </summary>
        private GenerationState CurrentState
        {
            get { return _currentState; }
            set { _currentState = value; }
        }

        /// <summary>
        ///     Gets the currently selected database table
        /// </summary>
        public DomainTable SelectedTable
        {
            get { return (this.MainTree.SelectedNode == null ? null : this.MainTree.SelectedNode.Tag as DomainTable); }
        }

        /// <summary>
        ///     Gets the currently selected database table column
        /// </summary>
        public DomainTableColumn SelectedColumn
        {
            get { return this.SelectedTable == null || this.MainTabControl.SelectedTab != this.ColumnTab || this.ColumnGrid.SelectedCells.Count == 0 ? null : this.ColumnGrid.SelectedCells[0].OwningRow.DataBoundItem as DomainTableColumn; }
        }

        /// <summary>
        ///     Gets the currently selected database index
        /// </summary>
        public DomainTableIndex SelectedIndex
        {
            get { return this.SelectedTable == null || this.MainTabControl.SelectedTab != this.IndexTab || this.IndexGrid.SelectedCells.Count == 0 ? null : this.IndexGrid.SelectedCells[0].OwningRow.DataBoundItem as DomainTableIndex; }
        }

        /// <summary>
        ///     Gets the currently selected database constraint
        /// </summary>
        public DomainTableConstraint SelectedConstraint
        {
            get { return this.SelectedTable == null || this.MainTabControl.SelectedTab != this.ConstraintTab || this.ConstraintGrid.SelectedCells.Count == 0 ? null : this.ConstraintGrid.SelectedCells[0].OwningRow.DataBoundItem as DomainTableConstraint; }
        }

        /// <summary>
        ///     Gets the currently selected domain container
        /// </summary>
        public DomainContainer SelectedContainer
        {
            get { return (SelectedEntity != null ? SelectedEntity.Container : (this.MainTree.SelectedNode == null ? null : this.MainTree.SelectedNode.Tag as DomainContainer)); }
        }

        /// <summary>
        ///     Gets the currently selected domain entity
        /// </summary>
        public DomainEntity SelectedEntity
        {
            get { return (this.MainTree.SelectedNode == null ? null : this.MainTree.SelectedNode.Tag as DomainEntity); }
        }

        /// <summary>
        ///     Gets the currently selected data source
        /// </summary>
        public DomainDataSource SelectedDataSource
        {
            get { return (this.MainTree.SelectedNode == null ? null : this.MainTree.SelectedNode.Tag as DomainDataSource); }
        }

        /// <summary>
        ///     Object to coordinate between the UI and background threads when running, and to hold caches, etc.
        /// </summary>
        public static RuntimeControl Runtime
        {
            get
            {
                return _runtime;
            }
        }

        /// <summary>
        ///     Flag for is the read method for the status/console update queue active
        /// </summary>
        public bool QueueReaderActive { get; set; }

        #endregion

        #region constructor

        /// <summary>
        ///     Provides the entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new MainForm());
        }

        /// <summary>
        ///     Creates a new instance of the main user interface.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            this.InitialiseUI();
            this.InitialiseGridColumn<DomainDataType>(this.ColumnType);
            this.InitialiseGridColumn<DomainEntityAttributeExposure>(this.PropertyExposureType);
            this.MainTree.ImageList = this.ImageLibrary;
        }

        #endregion

        #region event handlers

        /// <summary>
        ///     Occurs when the application form is closed.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.CurrentState == GenerationState.Started)
            {
                e.Cancel = true;
                this.CurrentState = GenerationState.Shutdown;
                if (_cancelSource != null)
                    _cancelSource.Cancel();
                this.ControlBox = false;
            }
        }

        /// <summary>
        ///     Occurs when a new node is selected in the navigation tree.
        /// </summary>
        private void MainTree_AfterSelect(Object sender, TreeViewEventArgs e)
        {
            if (this.MainTree.Enabled)
                this.InitialiseTab();
        }

        /// <summary>
        ///     Occurs when the tab control is switched between different tabs.
        /// </summary>
        private void MainTabControl_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (this.MainTabControl.Enabled)
                this.InitialiseToolbar();
        }

        /// <summary>
        ///     Occurs when the selection in the column grid is changed.
        /// </summary>
        private void ColumnGrid_SelectionChanged(Object sender, EventArgs e)
        {
            if (this.MainToolBar.Enabled)
                this.InitialiseToolbar();
        }

        /// <summary>
        ///     Occurs when a cell is no longer being edited.
        /// </summary>
        private void ColumnGrid_CellEndEdit(Object sender, DataGridViewCellEventArgs e)
        {
            this.CurrentDomain.Save(this.CurrentFile);
        }

        /// <summary>
        ///     Occurs when the data source for the attribute grid is changed.
        /// </summary>
        private void AttributeGrid_DataSourceChanged(Object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.AttributeGrid.Rows)
                this.InitialiseGridRow(row);
        }

        /// <summary>
        ///     Occurs when a cell is no longer being edited.
        /// </summary>
        private void AttributeGrid_CellEndEdit(Object sender, DataGridViewCellEventArgs e)
        {
            this.InitialiseGridRow(this.AttributeGrid.Rows[e.RowIndex]);
            this.CurrentDomain.Save(this.CurrentFile);
        }

        /// <summary>
        ///     Occurs when a cell is clicked
        /// </summary>
        private void AttributeGrid_CellContentClick(Object sender, DataGridViewCellEventArgs e)
        {
            if (this.AttributeGrid.Columns[e.ColumnIndex] == this.PropertyIsExposed)
            {
                this.AttributeGrid.EndEdit();
                this.InitialiseGridRow(this.AttributeGrid.Rows[e.RowIndex]);
            }

            else if (this.AttributeGrid.Columns[e.ColumnIndex] == this.PropertyButton)
            {
                DomainEntityAttribute attribute = this.AttributeGrid.Rows[e.RowIndex].DataBoundItem as DomainEntityAttribute;
                if (attribute.AttributeExposed)
                {
                    AttributeEditor editor = new AttributeEditor(attribute);
                    if (editor.ShowDialog() == DialogResult.OK)
                    {
                        this.InitialiseGridRow(this.AttributeGrid.Rows[e.RowIndex]);
                        this.CurrentDomain.Save(this.CurrentFile);
                    }
                }
            }
        }

        #endregion

        #region toolbar handlers

        /// <summary>
        ///     Occurs when the generate button is clicked.
        /// </summary>
        private void GenerateSql_Click(Object sender, EventArgs e)
        {
            this.Generator_Init(DomainGenerationLayers.StoredProcedures);
        }

        /// <summary>
        ///     Occurs when the generate button is clicked.
        /// </summary>
        private void ToolGenerateDAL_Click(object sender, EventArgs e)
        {
            this.Generator_Init(DomainGenerationLayers.DataAccessLayer);
        }

        /// <summary>
        ///     Occurs when the generate button is clicked.
        /// </summary>
        private void ToolGenerateBLL_Click(object sender, EventArgs e)
        {
            this.Generator_Init(DomainGenerationLayers.BusinessLogicLayer);
        }

        /// <summary>
        ///     Occurs when the generate button is clicked.
        /// </summary>
        private void ToolGenerateCCL_Click(object sender, EventArgs e)
        {
            this.Generator_Init(DomainGenerationLayers.ClientConsumerLayer);
        }

        /// <summary>
        ///     Occurs when the generate button is clicked.
        /// </summary>
        private void ToolGenerateAll_Click(object sender, EventArgs e)
        {
            this.Generator_Init(DomainGenerationLayers.All);
        }

        /// <summary>
        ///     Occurs when the toolbar button is clicked.
        /// </summary>
        private void ToolTableCreate_Click(object sender, EventArgs e)
        {
            DomainTable dataTable = this.CurrentDomain.CreateTable();
            TableEditor editor = new TableEditor(dataTable);
            if (editor.ShowDialog() != DialogResult.OK)
                dataTable.Delete();
            else
                this.Save();
        }

        /// <summary>
        ///     Occurs when the toolbar button is clicked.
        /// </summary>
        private void ToolTableImport_Click(object sender, EventArgs e)
        {
            TableImporter importer = new TableImporter(this.CurrentDomain);
            if (importer.ShowDialog() == DialogResult.OK)
                this.Save();
        }

        /// <summary>
        ///     Occurs when the toolbar button is clicked.
        /// </summary>
        private void ToolTableDelete_Click(object sender, EventArgs e)
        {
            if (this.SelectedTable != null && MessageBox.Show("Are you sure you want to delete this table?", this.SelectedTable.TableName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.SelectedTable.Delete();
                this.Save();
            }
        }

        /// <summary>
        ///     Occurs when the toolbar button is clicked.
        /// </summary>
        private void ToolColumnCreate_Click(object sender, EventArgs e)
        {
            DomainTableColumn column = this.SelectedTable.CreateColumn();
            column.ColumnOrdinal = this.SelectedTable.TableColumns.Length == 0 ? 1 : this.SelectedTable.TableColumns.Max(c => c.ColumnOrdinal) + 1;
            column.ColumnType = DomainDataType.Varchar;
            column.ColumnLength = 40;
            column.ColumnNullable = true;
            this.Save();

            this.InitialiseGrid(this.ColumnGrid, this.SelectedTable.TableColumns);
            this.ColumnGrid.Rows[this.ColumnGrid.Rows.Count - 1].Cells[0].Selected = true;
            this.ColumnGrid.BeginEdit(false);
        }

        /// <summary>
        ///     Occurs when the toolbar button is clicked.
        /// </summary>
        private void ToolColumnDelete_Click(object sender, EventArgs e)
        {
            if (this.SelectedColumn != null && MessageBox.Show("Are you sure you want to delete this column?", this.SelectedColumn.ColumnName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.SelectedColumn.Delete();
                this.Save();
            }
        }

        /// <summary>
        ///     Occurs when the toolbar button is clicked.
        /// </summary>
        private void ToolIndexCreate_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("NOT_SUPPORTED");
        }

        /// <summary>
        ///     Occurs when the toolbar button is clicked.
        /// </summary>
        private void ToolIndexDelete_Click(Object sender, EventArgs e)
        {
            if (this.SelectedIndex != null && MessageBox.Show("Are you sure you want to delete this index?", this.SelectedIndex.IndexName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.SelectedIndex.Delete();
                this.Save();
            }
        }

        /// <summary>
        ///     Occurs when the toolbar button is clicked.
        /// </summary>
        private void ToolConstraintCreate_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("NOT_SUPPORTED");
        }

        /// <summary>
        ///     Occurs when the toolbar button is clicked.
        /// </summary>
        private void ToolConstraintDelete_Click(Object sender, EventArgs e)
        {
            if (this.SelectedConstraint != null && MessageBox.Show("Are you sure you want to delete this constraint?", this.SelectedConstraint.ConstraintName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.SelectedConstraint.Delete();
                this.Save();
            }
        }

        /// <summary>
        ///     Occurs when the toolbar button is clicked.
        /// </summary>
        private void ToolContainerCreate_Click(object sender, EventArgs e)
        {
            DomainContainer domainContainer = this.CurrentDomain.CreateContainer();
            ContainerEditor containerEditor = new ContainerEditor(domainContainer);
            if (containerEditor.ShowDialog() != DialogResult.OK)
                domainContainer.Delete();
            else
                this.Save();
        }

        /// <summary>
        ///     Occurs when the toolbar button is clicked.
        /// </summary>
        private void ToolContainerDelete_Click(object sender, EventArgs e)
        {
            if (this.SelectedContainer != null && MessageBox.Show("Are you sure you want to delete this container and all entities defined within the container?", this.SelectedContainer.ContainerName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.SelectedContainer.ContainerEntities.Execute(entity => entity.Delete());
                this.SelectedContainer.Delete();
                this.Save();
            }
        }

        /// <summary>
        ///     Occurs when the toolbar button is clicked.
        /// </summary>
        private void ToolEntityCreate_Click(object sender, EventArgs e)
        {
            DomainEntity domainEntity = this.SelectedContainer.CreateEntity();
            EntityEditor entityEditor = new EntityEditor(domainEntity);
            if (entityEditor.ShowDialog() != DialogResult.OK)
                domainEntity.Delete();
            else
                this.Save();
        }

        /// <summary>
        ///     Occurs when the toolbar button is clicked.
        /// </summary>
        private void ToolEntityDelete_Click(object sender, EventArgs e)
        {
            if (this.SelectedEntity != null && MessageBox.Show("Are you sure you want to delete this entity?", this.SelectedEntity.EntityName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.SelectedEntity.Delete();
                this.Save();
            }
        }

        /// <summary>
        ///     Occurs when the toolbar button is clicked.
        /// </summary>
        private void ToolSourceCreate_Click(object sender, EventArgs e)
        {
            DomainDataSource dataSource = this.CurrentDomain.CreateDataSource(typeof(SqlDataSource));
            DataSourceEditor editor = new DataSourceEditor(dataSource);
            if (editor.ShowDialog() != DialogResult.OK)
                this.CurrentDomain.Delete(dataSource);
            else
                this.Save();
        }

        /// <summary>
        ///     Occurs when the toolbar button is clicked.
        /// </summary>
        private void ToolSourceDelete_Click(object sender, EventArgs e)
        {
            if (this.SelectedDataSource != null && MessageBox.Show("Are you sure you want to delete this data source?", this.SelectedDataSource.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.CurrentDomain.Delete(this.SelectedDataSource);
                this.Save();
            }
        }

        /// <summary>
        ///     Occurs when the toolbar button is clicked.
        /// </summary>
        private void ToolProperties_Click(object sender, EventArgs e)
        {
            if (this.SelectedEntity != null)
            {
                EntityEditor entityEditor = new EntityEditor(this.SelectedEntity);
                if (entityEditor.ShowDialog() == DialogResult.OK)
                    this.Save();
            }
            else if (this.SelectedContainer != null)
            {
                ContainerEditor editor = new ContainerEditor(this.SelectedContainer);
                if (editor.ShowDialog() == DialogResult.OK)
                    this.Save();
            }
            else if (this.SelectedDataSource != null)
            {
                DataSourceEditor editor = new DataSourceEditor(this.SelectedDataSource);
                if (editor.ShowDialog() == DialogResult.OK)
                    this.Save();
            }
            else if (this.SelectedIndex != null)
            {
                MessageBox.Show("NOT_SUPPORTED");
            }
            else if (this.SelectedConstraint != null)
            {
                MessageBox.Show("NOT_SUPPORTED");
            }
            else if (this.SelectedTable != null)
            {
                TableEditor editor = new TableEditor(this.SelectedTable);
                if (editor.ShowDialog() == DialogResult.OK)
                    this.Save();
            }
        }

        #endregion

        #region generators

        private void Generator_Init(DomainGenerationLayers layer)
        {
            this.MainTree.SelectedNode = null;
            this.CurrentDomain.GenerationMode = DomainGenerationModes.Complete;
            this.CurrentDomain.GenerationLayer = layer;

            _cancelSource = new CancellationTokenSource();
            _runtime = new RuntimeControl(this, _cancelSource.Token);
            _totalTasks = this.CurrentTasks.AllTasks.Count();
            _completedTasks = 0;

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += this.Generator_RunAsync;
            worker.RunWorkerAsync();
        }

        private void Generator_RunAsync(Object sender, DoWorkEventArgs e)
        {
            new GeneratorTransfer(this.CurrentTasks.WorkingDirectory, true).Execute();
            this.CurrentTasks.Execute();
        }

        private void Generator_OnStart()
        {
            Action action = delegate ()
            {
                this.CurrentState = GenerationState.Started;
                this.MainTabControl.Enabled = false;
                this.MainTree.Enabled = false;
                this.MainToolBar.Enabled = false;
                this.InitialiseTab(this.MainTabControl, this.ColumnTab, false);
                this.InitialiseTab(this.MainTabControl, this.IndexTab, false);
                this.InitialiseTab(this.MainTabControl, this.ConstraintTab, false);
                this.InitialiseTab(this.MainTabControl, this.AttributeTab, false);
                this.InitialiseTab(this.MainTabControl, this.GeneratorTab, true);
                this.InitialiseConsole();
            };
            this.Invoke(action);
        }

        private void Generator_OnFinish()
        {
            new GeneratorTransfer(this.CurrentTasks.WorkingDirectory, false).Execute();
            this.InitialiseConsole("------------------------------------------------------------------------------------");
            this.InitialiseConsole(" Completed ");
            this.InitialiseConsole("------------------------------------------------------------------------------------");
            Action action = delegate ()
            {
                // Shutdown if requested.
                if (this.CurrentState == GenerationState.Shutdown)
                {
                    this.Close();
                    return;
                }

                // Reset the user interface.
                this.CurrentState = GenerationState.Stopped;
                this.ControlBox = true;
                this.MainTabControl.Enabled = true;
                this.MainTree.Enabled = true;
                this.MainToolBar.Enabled = true;
                this.InitialiseUI();
            };
            this.Invoke(action);
            this.Generator_Finalize();
            this.CurrentDomain.ChangeVersion(this.CurrentDomain.Version.Major, this.CurrentDomain.Version.Minor, this.CurrentDomain.Version.Month, this.CurrentDomain.Version.Patch, this.CurrentDomain.Version.Build + 1);
            this.CurrentDomain.Save(this.CurrentFile);
        }

        private void Generator_OnError(Exception error)
        {
            new GeneratorTransfer(this.CurrentTasks.WorkingDirectory, false).Execute();
            this.InitialiseConsole("------------------------------------------------------------------------------------");
            this.InitialiseConsole(" Failed : " + error.Message);
            this.InitialiseConsole("------------------------------------------------------------------------------------");
            this.InitialiseConsole(error.StackTrace);
            this.InitialiseConsole("");
            Action action = delegate ()
            {
                // Reset the user interface.
                this.CurrentState = GenerationState.Stopped;
                this.ControlBox = true;
                this.MainTabControl.Enabled = true;
                this.MainTree.Enabled = true;
                this.MainToolBar.Enabled = true;
                this.InitialiseUI();
            };
            this.Invoke(action);
            this.Generator_Finalize();
        }

        private void Generator_OnProgress(String name)
        {
            //this.Invoke((Action<String>)this.InitialiseConsole, name);
            //this.Invoke((Action<String>)this.InitialiseStatus, name);
            InitialiseConsole(name);
            InitialiseStatus(name);
        }

        private void Generator_OnMessage(String message)
        {
            //this.Invoke((Action<String>)this.InitialiseConsole, message);
            InitialiseConsole(message);
        }

        private void Generator_Finalize()
        {
            _currentTasks.OnMessage -= this.Generator_OnMessage;
            _currentTasks.OnProgress -= this.Generator_OnProgress;
            _currentTasks.OnStart -= this.Generator_OnStart;
            _currentTasks.OnFinish -= this.Generator_OnFinish;
            _currentTasks.OnError -= this.Generator_OnError;
            _currentTasks = null;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Initialises the content of the user interface.
        /// </summary>
        public void InitialiseUI()
        {
            this.Text = this.CurrentDomain.DomainName;
            this.InitialiseToolbar();
            this.InitialiseStatus();
            this.InitialiseTree();
        }

        /// <summary>
        ///     Initialises the content of the user interface.
        /// </summary>
        public void InitialiseTab()
        {
            this.InitialiseTab(this.MainTabControl, this.GeneratorTab, true);
            this.InitialiseTab(this.MainTabControl, this.ColumnTab, this.SelectedTable != null);
            this.InitialiseTab(this.MainTabControl, this.IndexTab, this.SelectedTable != null && MainForm.SupportsIndex);
            this.InitialiseTab(this.MainTabControl, this.ConstraintTab, this.SelectedTable != null && MainForm.SupportsConstraints);
            this.InitialiseTab(this.MainTabControl, this.AttributeTab, this.SelectedEntity != null);
            this.InitialiseGrid(this.ColumnGrid, this.SelectedTable == null ? null : this.SelectedTable.TableColumns);
            this.InitialiseGrid(this.AttributeGrid, this.SelectedEntity == null ? null : this.SelectedEntity.EntityAttributes);
            this.InitialiseToolbar();
        }

        /// <summary>
        ///     Initialises the visibility of a tab within a tab control.
        /// </summary>
        public void InitialiseTab(TabControl control, TabPage page, Boolean predicate)
        {
            TabPage currentPage = control.SelectedTab;
            Boolean pageisAdded = !control.TabPages.Contains(page) && predicate;

            // Add or remove the specified page, based upon the predicate value
            if (control.TabPages.Contains(page) != predicate)
                if (control.TabPages.Contains(page))
                    control.TabPages.Remove(page);
                else
                    control.TabPages.Add(page);

            // Reselect the previously selected tab, if the tab is still present (or reselect the first tab, other than the generator tab)
            if (currentPage != null && currentPage != this.GeneratorTab && control.TabPages.Contains(currentPage))
                control.SelectedTab = currentPage;
            else
                control.SelectedTab = control.TabPages.OfType<TabPage>().Where(tab => tab != this.GeneratorTab).FirstOrDefault() ?? this.GeneratorTab;
        }

        /// <summary>
        ///     Initialises the content of the toolbar
        /// </summary>
        public void InitialiseToolbar()
        {
            // Initialise the toolbar button visibility
            this.InitialiseToolbar(this.ToolTableCreate, this.SelectedTable, "::data", true);
            this.InitialiseToolbar(this.ToolTableImport, this.SelectedTable, "::data", this.CurrentDomain.DataSources.Length != 0);
            this.InitialiseToolbar(this.ToolTableDelete, this.SelectedTable, "::data");
            this.InitialiseToolbar(this.ToolTableSeparator, this.SelectedTable, "::data");
            this.InitialiseToolbar(this.ToolColumnCreate, this.SelectedTable, this.SelectedColumn, this.ColumnTab, true);
            this.InitialiseToolbar(this.ToolColumnDelete, this.SelectedTable, this.SelectedColumn, this.ColumnTab);
            this.InitialiseToolbar(this.ToolColumnSeparator, this.SelectedTable, this.SelectedColumn, this.ColumnTab);
            this.InitialiseToolbar(this.ToolIndexCreate, this.SelectedTable, this.SelectedIndex, this.IndexTab, true);
            this.InitialiseToolbar(this.ToolIndexDelete, this.SelectedTable, this.SelectedIndex, this.IndexTab);
            this.InitialiseToolbar(this.ToolIndexSeparator, this.SelectedTable, this.SelectedIndex, this.IndexTab);
            this.InitialiseToolbar(this.ToolConstraintCreate, this.SelectedTable, this.SelectedConstraint, this.ConstraintTab, true);
            this.InitialiseToolbar(this.ToolConstraintDelete, this.SelectedTable, this.SelectedConstraint, this.ConstraintTab);
            this.InitialiseToolbar(this.ToolConstraintSeparator, this.SelectedTable, this.SelectedConstraint, this.ConstraintTab);
            this.InitialiseToolbar(this.ToolContainerCreate, this.SelectedContainer, "::code", true);
            this.InitialiseToolbar(this.ToolContainerDelete, this.SelectedContainer, "::code");
            this.InitialiseToolbar(this.ToolContainerSeparator, this.SelectedContainer, "::code");
            this.InitialiseToolbar(this.ToolEntityCreate, this.SelectedContainer, this.SelectedEntity, true);
            this.InitialiseToolbar(this.ToolEntityDelete, this.SelectedContainer, this.SelectedEntity);
            this.InitialiseToolbar(this.ToolEntitySeparator, this.SelectedContainer, this.SelectedEntity);
            this.InitialiseToolbar(this.ToolSourceCreate, this.SelectedDataSource, "::source", true);
            this.InitialiseToolbar(this.ToolSourceDelete, this.SelectedDataSource, "::source");
            this.InitialiseToolbar(this.ToolSourceSeparator, this.SelectedDataSource, "::source");
            this.ToolProperties.Enabled = (this.SelectedTable != null || this.SelectedIndex != null || this.SelectedConstraint != null || this.SelectedContainer != null || this.SelectedEntity != null || this.SelectedDataSource != null);
        }

        /// <summary>
        ///     Initialises a single item in the toolbar
        /// </summary>
        public void InitialiseToolbar(ToolStripItem item, Object selection, String parentNode)
        {
            this.InitialiseToolbar(item, selection, parentNode, selection != null);
        }

        /// <summary>
        ///     Initialises a single item in the toolbar
        /// </summary>
        public void InitialiseToolbar(ToolStripItem item, Object selection, String parentNode, Boolean enabled)
        {
            item.Visible = (selection != null || (this.MainTree.SelectedNode != null && this.MainTree.SelectedNode.Name == parentNode));
            item.Enabled = enabled;
        }

        /// <summary>
        ///     Initialises a single item in the toolbar
        /// </summary>
        public void InitialiseToolbar(ToolStripItem item, Object parentObject, Object childObject, TabPage tabPage)
        {
            this.InitialiseToolbar(item, parentObject, childObject, tabPage, childObject != null);
        }

        /// <summary>
        ///     Initialises a single item in the toolbar
        /// </summary>
        public void InitialiseToolbar(ToolStripItem item, Object parentObject, Object childObject, TabPage tabPage, Boolean alwaysEnabled)
        {
            item.Visible = parentObject != null && this.MainTabControl.SelectedTab == tabPage;
            item.Enabled = alwaysEnabled || childObject != null;
        }

        /// <summary>
        ///     Initialises a single item in the toolbar
        /// </summary>
        public void InitialiseToolbar(ToolStripItem item, Object parentObject, Object childObject)
        {
            this.InitialiseToolbar(item, parentObject, childObject, childObject != null);
        }

        /// <summary>
        ///     Initialises a single item in the toolbar
        /// </summary>
        public void InitialiseToolbar(ToolStripItem item, Object parentObject, Object childObject, Boolean enabled)
        {
            item.Visible = parentObject != null;
            item.Enabled = enabled;
        }

        /// <summary>
        ///     Initialises the content of the navigational tree.
        /// </summary>
        public void InitialiseTree()
        {
            if (this.MainTree.Tag == null)
            {
                // Initialise the root nodes.
                TreeNode code = this.MainTree.Nodes["::code"] ?? this.MainTree.Nodes.Add("::code", "Code", "FolderCode", "FolderCode");
                TreeNode data = this.MainTree.Nodes["::data"] ?? this.MainTree.Nodes.Add("::data", "Tables", "FolderData", "FolderData");
                TreeNode source = this.MainTree.Nodes["::source"] ?? this.MainTree.Nodes.Add("::source", "Databases", "FolderSources", "FolderSources");

                // Initialise the tables and containers.
                this.InitialiseTree(data.Nodes, this.CurrentDomain.Tables);
                this.InitialiseTree(code.Nodes, this.CurrentDomain.Containers);
                this.InitialiseTree(source.Nodes, this.CurrentDomain.DataSources);

                // Re-order the items within the tree.
                TreeNode selectedNode = this.MainTree.SelectedNode;
                this.MainTree.Tag = new Object();
                this.MainTree.Sort();
                this.MainTree.SelectedNode = selectedNode;
                this.MainTree.Tag = null;
            }
        }

        /// <summary>
        ///     Initialises the content of the navigational tree with the collection of database tables.
        /// </summary>
        public void InitialiseTree(TreeNodeCollection nodes, DomainTable[] tables)
        {
            // Remove tree nodes that do not correspond to a table
            TreeNode[] removes = nodes.OfType<TreeNode>().Where(node => !tables.Any(table => table.Exists && table.Guid.ToString() == node.Name)).ToArray();
            removes.Execute(node => node.Remove());

            // Create or update the tree node that correspond to the specified tables
            foreach (DomainTable table in tables.Where(item => item.Exists))
            {
                TreeNode node = nodes[table.Guid.ToString()] ?? nodes.Add(String.Empty);
                node.Name = table.Guid.ToString();
                node.Text = table.TableName;
                node.ToolTipText = table.TableDescription;
                node.ImageKey = "Table";
                node.SelectedImageKey = "Table";
                node.Tag = table;
            }
        }

        /// <summary>
        ///     Initialises the content of the navigational tree with the collection of domain containers.
        /// </summary>
        public void InitialiseTree(TreeNodeCollection nodes, DomainContainer[] containers)
        {
            // Remove tree nodes that do not correspond to a container
            TreeNode[] removes = nodes.OfType<TreeNode>().Where(node => !containers.Any(container => container.Exists && container.Guid.ToString() == node.Name)).ToArray();
            removes.Execute(node => node.Remove());

            // Create or update the tree nodes that correspond to the specified containers
            foreach (DomainContainer container in containers.Where(item => item.Exists))
            {
                TreeNode node = nodes[container.Guid.ToString()] ?? nodes.Add(String.Empty);
                node.Name = container.Guid.ToString();
                node.Text = container.ContainerName;
                node.ToolTipText = container.ContainerDescription;
                node.ImageKey = "Container";
                node.SelectedImageKey = "Container";
                node.Tag = container;
                this.InitialiseTree(node.Nodes, container.ContainerEntities);
            }
        }

        /// <summary>
        ///     Initialises the content of the navigational tree with the collection of domain entities.
        /// </summary>
        public void InitialiseTree(TreeNodeCollection nodes, DomainEntity[] entities)
        {
            // Remove tree nodes that do not correspond to a entity
            TreeNode[] removes = nodes.OfType<TreeNode>().Where(node => !entities.Any(entity => entity.Exists && entity.Guid.ToString() == node.Name)).ToArray();
            removes.Execute(node => node.Remove());

            // Create or update the tree nodes that correspond to the specified entities
            foreach (DomainEntity entity in entities.Where(item => item.Exists))
            {
                TreeNode node = nodes[entity.Guid.ToString()] ?? nodes.Add(String.Empty);
                node.Name = entity.Guid.ToString();
                node.Text = entity.EntityName;
                node.ToolTipText = entity.EntityDescription;
                node.ImageKey = "Entity";
                node.SelectedImageKey = "Entity";
                node.Tag = entity;
            }
        }

        /// <summary>
        ///     Initialises the content of the navigational tree with the collection of domain entities.
        /// </summary>
        public void InitialiseTree(TreeNodeCollection nodes, DomainDataSource[] sources)
        {
            // Remove tree nodes that do not correspond to a entity
            TreeNode[] removes = nodes.OfType<TreeNode>().Where(node => !sources.Any(source => source.Guid.ToString() == node.Name)).ToArray();
            removes.Execute(node => node.Remove());

            // Create or update the tree nodes that correspond to the specified entities
            foreach (DomainDataSource source in sources)
            {
                TreeNode node = nodes[source.Guid.ToString()] ?? nodes.Add(String.Empty);
                node.Name = source.Guid.ToString();
                node.Text = source.Name;
                node.ImageKey = "Database";
                node.SelectedImageKey = "Database";
                node.Tag = source;
            }
        }

        /// <summary>
        ///     Clears the generator console.
        /// </summary>
        public void InitialiseConsole()
        {
            this.GeneratorConsole.Text = String.Empty;
        }

        /// <summary>
        ///     Appends a message to the generator console.
        /// </summary>
        public void InitialiseConsole(String message)
        {
            if (Runtime != null)
            {
                Runtime.QueueConsoleMessage(message);
            }
            else
            {
                AppendToConsole(message);
            }
        }

        /// <summary>
        ///     Initialises the content of the status bar
        /// </summary>
        public void InitialiseStatus(String text)
        {
            // This is assuming we get one OnProgress call fired per item.
            // This works fine for the current model (and is much faster then 
            // the previous way of doing it). It's only for the progress bar,
            // so it doesn't matter if it is not 100% accurate.
            _completedTasks++;

            if (Runtime != null)
            {
                Runtime.QueueStatusUpdate(text);
            }
            else
            {
                SetProgress(text, false);
            }
        }

        /// <summary>
        ///     Initialises the content of the status bar
        /// </summary>
        public void ResetStatus(String text)
        {
            if (Runtime != null)
            {
                Runtime.QueueResetStatus(text);
            }
            else
            {
                SetProgress(text, true);
            }
        }

        public void AppendToConsole(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendToConsole), new object[] { value });
                return;
            }

            this.GeneratorConsole.AppendText(value);
            this.GeneratorConsole.AppendText(Environment.NewLine);
            this.GeneratorConsole.SelectionStart = this.GeneratorConsole.TextLength;

            //this.GeneratorConsole.Text = this.GeneratorConsole.Text + value + Environment.NewLine;
            //this.GeneratorConsole.ScrollToCaret();
        }
        
        public void SetProgress(String text, bool reset)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string, bool>(SetProgress), new object[] { text, reset });
                return;
            }

            int progress;
            if (reset)
            {
                progress = 0;
            }
            else
            {
                //Decimal ended = 1;
                //Decimal total = 1;
                //try
                //{
                //    ended = this.CurrentTasks.AllTasks.Count(subtask => subtask.State == TaskState.Completed);
                //    total = this.CurrentTasks.AllTasks.Count();
                //}
                //catch { }
                //progress = (int)((ended * 100) / total);
                progress = (int)((_completedTasks * 100) / _totalTasks);
                progress = Math.Max(Math.Min(progress, 100), 0);
            }

            // Initialise the status bar.
            this.StatusLabel.Text = text ?? this.StatusLabel.Text;
            
            this.StatusProgress.Value = progress;
            this.StatusProgress.Visible = progress >= 0;
        }

        public void ProcessQueue(Queue<RuntimeControl.ConsoleWriteItem> oQueue)
        {
            QueueReaderActive = true;

            if (InvokeRequired)
            {
                this.BeginInvoke(new Action<Queue<RuntimeControl.ConsoleWriteItem>>(ProcessQueue), new object[] { oQueue });
                return;
            }

            bool timedout = false;
            string[] msgs = new string[10];
            int iMsg = -1;

            try
            {
                while (!timedout)
                {
                    if (oQueue.Count > 0)
                    {
                        while (oQueue.Count > 0)
                        {
                            RuntimeControl.ConsoleWriteItem oItem;
                            lock (oQueue)
                            {
                                oItem = oQueue.Dequeue();
                            }
                            if (oItem.IsProgress)
                            {
                                _lastProgressMessage = oItem.ResetProgress ? "" : oItem.Message;

                                if (oItem.ResetProgress
                                    || (DateTime.Now - _lastProgress) > TimeSpan.FromSeconds(2))
                                {
                                    SetProgress(oItem.Message, oItem.ResetProgress);
                                    _lastProgress = DateTime.Now;
                                }
                            }
                            else
                            {
                                if (iMsg < 9)
                                {
                                    iMsg++;
                                    msgs[iMsg] = oItem.Message;
                                }
                                else
                                {
                                    AppendToConsole(string.Join(Environment.NewLine, msgs));
                                    // AppendToConsole(oItem.Message);
                                    iMsg = -1;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (iMsg >= 0)
                        {
                            AppendToConsole(string.Join(Environment.NewLine, msgs.Take(iMsg+1)));
                            iMsg = -1;
                        }
                        if (_lastProgressMessage != "")
                        {
                            SetProgress(_lastProgressMessage, false);
                            _lastProgress = DateTime.Now;
                        }

                        Thread.Sleep(1000);
                        if (oQueue.Count == 0)
                            timedout = true;
                    }
                }

                QueueReaderActive = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        /// <summary>
        ///     Initialises the content of the status bar
        /// </summary>
        public void InitialiseStatus()
        {
            String statusText = String.Format("{0} v{1}", this.CurrentDomain.DomainName, this.CurrentDomain.Version.ToString(4));
            this.ResetStatus(statusText);
        }


        /// <summary>
        ///     Populates the data source of a dropdown grid column with the values available from an enumerator.
        /// </summary>
        public void InitialiseGridColumn<T>(DataGridViewComboBoxColumn column)
        {
            column.ValueMember = "Key";
            column.DisplayMember = "Value";
            column.DataSource = Enum.GetValues(typeof(T)).OfType<T>().ToDictionary(e => e, e => e.ConvertTo<String>()).ToList();
        }

        /// <summary>
        ///     Repopulates the columns grid control.
        /// </summary>
        public void InitialiseGrid<T>(DataGridView control, T[] dataSource) where T : VersionData
        {
            // Ensure the grid is not double-bufferred and all auto-sizing is disabled.
            if (!SystemInformation.TerminalServerSession)
            {
                PropertyInfo doubleBuffered = typeof(DataGridView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
                doubleBuffered.SetValue(control, false, null);
                control.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                control.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            }

            // Identify row and column index before the datasource is changed
            Int32 rowIndex = control.SelectedCells.Count == 0 ? -1 : control.SelectedCells[0].RowIndex;
            Int32 colIndex = control.SelectedCells.Count == 0 ? -1 : control.SelectedCells[0].ColumnIndex;

            // Update the grid with the columns from the selected table
            control.AutoGenerateColumns = false;
            control.DataSource = dataSource == null ? null : dataSource.Where(item => item.Exists).ToList();

            // Validate that the row index and column index remain valid and reselect the original cell
            rowIndex = (rowIndex < control.Rows.Count) ? rowIndex : control.Rows.Count - 1;
            colIndex = (colIndex < control.Columns.Count) ? colIndex : 0;
            if (rowIndex > -1 && colIndex > -1)
                control.Rows[rowIndex].Cells[colIndex].Selected = true;
        }

        /// <summary>
        ///     Repopulates the attributes grid control.
        /// </summary>
        public void InitialiseGridRow(DataGridViewRow row)
        {
            DomainEntityAttribute attribute = row.DataBoundItem as DomainEntityAttribute;
            if (attribute.Entity != this.SelectedEntity)
            {
                // Make all cells readonly (values inherited from base entity)
                row.DefaultCellStyle.ForeColor = Color.FromArgb(120, 110, 100);
                row.DefaultCellStyle.BackColor = Color.FromArgb(250, 245, 240);
                row.Cells.OfType<DataGridViewCell>().Execute(cell => cell.ReadOnly = true);
            }
            else if (!attribute.AttributeExposed)
            {
                // Make all cells readonly (except for the exposure)
                row.DefaultCellStyle.ForeColor = Color.FromArgb(160, 160, 160);
                row.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
                row.Cells.OfType<DataGridViewCell>().Execute(cell => cell.ReadOnly = (cell.OwningColumn != this.PropertyIsExposed));
            }
            else
            {
                // Make all cells editable (except for the column name)
                row.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                row.Cells.OfType<DataGridViewCell>().Execute(cell => cell.ReadOnly = (cell.OwningColumn == this.PropertyColumnName));
            }
        }

        /// <summary>
        ///     Saves the current business domain and reinitialises the user interface.
        /// </summary>
        public void Save()
        {
            this.CurrentDomain.Save(this.CurrentFile);
            this.InitialiseUI();
        }

        #endregion
    }
}
