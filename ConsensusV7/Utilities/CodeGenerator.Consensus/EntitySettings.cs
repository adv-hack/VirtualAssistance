using CodeGenerator.CodeModel;
using CodeGenerator.DataModel;
using CodeGenerator.Properties;
using Microsoft.Build.Execution;
using Microsoft.Build.Framework;
using Microsoft.Build.Logging;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Type = System.Type;
using CodeType = CodeGenerator.CodeModel.Type;
using System.Threading;

namespace CodeGenerator.Consensus
{
    /// <summary>
    ///     The main user interface for the code generator.
    /// </summary>
    public partial class EntitySettings : Form
    {
        #region fields

        /// <summary>
        ///     The databases which can be manipulated with this code generator.
        /// </summary>
        private Database[] _databases;

        /// <summary>
        ///     The solution in which the projects are generated.
        /// </summary>
        private ProjectSolution _currentSolution;

        /// <summary>
        ///     The collection of temporary files that have been created during code generation.
        /// </summary>
        private List<String> _temporaryFiles;

        /// <summary>
        ///     A post-processing action to be completed.
        /// </summary>
        private Action _postProcess;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the databases which can be manipulated with this code generator.
        /// </summary>
        public Database[] Databases
        {
            get
            {
                if (_databases == null)
                    _databases = Database.GetAll().ToArray();

                return _databases;
            }
        }

        /// <summary>
        ///     Gets the currently selected database
        /// </summary>
        public Database CurrentDatabase
        {
            get
            {
                Database result;

                if (this.InvokeRequired)
                {
                    Func<Object> delegatedAccessor = delegate() { return this.DatabaseDropdown.SelectedItem; };
                    result = this.Invoke(delegatedAccessor) as Database;
                }
                else
                {
                    result = this.DatabaseDropdown.SelectedItem as Database;
                }
                return result;
            }
        }

        /// <summary>
        ///     Gets the solution in which the projects are generated.
        /// </summary>
        public ProjectSolution CurrentSolution
        {
            get
            {
                if (_currentSolution == null)
                    _currentSolution = new ProjectSolution(this.CurrentDatabase.Name);

                return _currentSolution;
            }
        }

        /// <summary>
        ///     Gets the collection of temporary files that have been created during code generation.
        /// </summary>
        public List<String> TemporaryFiles
        {
            get
            {
                if (_temporaryFiles == null)
                    _temporaryFiles = new List<String>();

                return _temporaryFiles;
            }
        }

        /// <summary>
        ///     The root node which contains the entities that have not been added to a domain.
        /// </summary>
        public TreeNode RootNode
        {
            get; private set;
        }

        /// <summary>
        ///     Gets or sets the post-processing action to be executed upon completion.
        /// </summary>
        protected Action PostProcess
        {
            get { return _postProcess; }
            set { _postProcess = value; }
        }

        #endregion

        #region constructors

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new EntitySettings());
        }

        private EntitySettings()
        {
            this.InitializeComponent();            
            
            // Set the icons for the interface
            this.Icon = Resources.Advanced;
            this.DomainAddButton.Image = EntitySettings.GetImage(Resources.Add, 16);
            this.DomainRemoveButton.Image = EntitySettings.GetImage(Resources.Remove, 16);

            // Set the icons for the domain tree
            this.DomainTree.ImageList = new ImageList();
            this.DomainTree.ImageList.ImageSize = new Size(16, 16);
            this.DomainTree.ImageList.ColorDepth = ColorDepth.Depth32Bit;
            this.DomainTree.ImageList.Images.Add(Resources.Folder);
            this.DomainTree.ImageList.Images.Add(Resources.Table);

            // Define the top node for the domain tree
            this.RootNode = new TreeNode("[no namespace]", 0, 0);
            this.RootNode.Name = "";
        }

        #endregion

        #region event handlers

        private void MainInterface_Load(Object sender, EventArgs e)
        {
            // Initialise the database dropdown
            this.DatabaseDropdown.DataSource = this.Databases;
            this.DatabaseDropdown.DisplayMember = "Name";
            this.DatabaseDropdown.SelectedItem = this.Databases.FirstOrDefault();
        }

        private void DatabaseDropdown_SelectedIndexChanged(Object sender, EventArgs e)
        {
            _currentSolution = null;

            this.SuspendLayout();
            this.GeneratorDalButton.Enabled = (this.CurrentDatabase != null);
            if (this.CurrentDatabase != null)
            {
                // Populate the domain dropdown within the entity details
                this.EntityDomainDropdown.Items.Clear();
                this.EntityDomainDropdown.Items.Add(new { Name = "" });
                this.EntityDomainDropdown.Items.AddRange(this.CurrentDatabase.Domains);
                this.EntityDomainDropdown.DisplayMember = "Name";

                // Populate the generator options with the solution information
                this.GeneratorSolutionNameTextbox.Text = this.CurrentSolution.SolutionName;
                this.GeneratorSolutionVersionTextbox.Text = this.CurrentSolution.SolutionVersion.ToString();
                this.GeneratorSolutionDirectoryTextbox.Text = this.CurrentSolution.SolutionPath.ToString();

                // Remove all nodes from the tree
                this.DomainTree.Nodes.Clear();
                this.DomainTree.Nodes.Add(this.RootNode);

                // Add a node to contain the entities that have not been added to a domain
                this.RootNode.Nodes.Clear();
                foreach (DataEntity entity in this.CurrentDatabase.Entities)
                    this.AddTreeNode(this.RootNode.Nodes, entity);

                // Add a node for each of the domains
                foreach (DataDomain domain in this.CurrentDatabase.Domains)
                {
                    this.AddTreeNode(this.DomainTree.Nodes, domain);
                    foreach (DataEntity entity in domain.Entities)
                        this.AddTreeNode(this.DomainTree.Nodes[domain.Identifier].Nodes, entity);
                }

                // Ensure all nodes are collapsed then select the first available entity
                this.DomainTree.CollapseAll();
                this.DomainTree.SelectedNode = this.DomainTree.Nodes.OfType<TreeNode>().Where(node => node != this.RootNode && node.Nodes.Count > 0).Select(node => node.Nodes[0]).FirstOrDefault() ?? this.RootNode.Nodes.OfType<TreeNode>().FirstOrDefault();
                this.DomainTree.Focus();
            }
            this.ResumeLayout(true);
        }

        private void DomainTree_AfterSelect(Object sender, TreeViewEventArgs e)
        {
            this.SuspendLayout();
            this.DomainRemoveButton.Enabled = (e.Node.Tag is DataDomain);

            this.EntityTitleLabel.Visible = (e.Node.Tag is DataEntity);
            this.EntityDomainLabel.Visible = (e.Node.Tag is DataEntity);
            this.EntityDomainDropdown.Visible = (e.Node.Tag is DataEntity);
            this.EntityPrefixLabel.Visible = (e.Node.Tag is DataEntity);
            this.EntityPrefixTextbox.Visible = (e.Node.Tag is DataEntity);
            this.EntityNameLabel.Visible = (e.Node.Tag is DataEntity);
            this.EntityNameTextbox.Visible = (e.Node.Tag is DataEntity);
            this.EntityDescriptionLabel.Visible = (e.Node.Tag is DataEntity);
            this.EntityDescriptionTextbox.Visible = (e.Node.Tag is DataEntity);
            this.FieldGrid.Visible = (e.Node.Tag is DataEntity);
            this.EntityAllowCreate.Visible = (e.Node.Tag is DataEntity);
            this.EntityAllowModify.Visible = (e.Node.Tag is DataEntity);
            this.EntityAllowRemove.Visible = (e.Node.Tag is DataEntity);
                 
            DataEntity entity = e.Node.Tag as DataEntity;
            if (entity != null)
            {
                this.EntityTitleLabel.Text = entity.ObjectName;
                this.EntityDomainDropdown.SelectedItem = entity.CodeDomain;
                this.EntityPrefixTextbox.Text = entity.ObjectPrefix;
                this.EntityNameTextbox.Text = entity.CodeName;
                this.EntityDescriptionTextbox.Text = entity.CodeDescription;
                this.EntityAllowCreate.Checked = entity.CanCreate;
                this.EntityAllowModify.Checked = entity.CanModify;
                this.EntityAllowRemove.Checked = entity.CanRemove;

                this.FieldGrid.AutoGenerateColumns = false;
                this.FieldGrid.DataSource = entity.Fields;

                // Ensure primary key columns are readonly
                foreach (DataGridViewRow row in this.FieldGrid.Rows)
                    if ((row.DataBoundItem as DataEntityField).IsPrimaryKey)
                        row.ReadOnly = true;
            }
            this.ResumeLayout(true);
        }

        private void DomainNameTextbox_TextChanged(Object sender, EventArgs e)
        {
            this.DomainAddButton.Enabled = !String.IsNullOrEmpty(this.DomainNameTextbox.Text);
        }

        private void DomainAddButton_Click(Object sender, EventArgs e)
        {
            this.AddDomain(this.DomainNameTextbox.Text);
            this.DomainNameTextbox.Text = "";
            this.DomainTree.Focus();

            this.EntityDomainDropdown.Items.Clear();
            this.EntityDomainDropdown.Items.Add(new { Name = "" });
            this.EntityDomainDropdown.Items.AddRange(this.CurrentDatabase.Domains);
            this.EntityDomainDropdown.DisplayMember = "Name";
        }

        private void DomainRemoveButton_Click(Object sender, EventArgs e)
        {
            DataDomain domain = this.DomainTree.SelectedNode.Tag as DataDomain;
            this.DomainNameTextbox.Text = domain.Identifier;
            this.RemoveDomain(domain);
            this.DomainTree.Focus();

            this.EntityDomainDropdown.Items.Clear();
            this.EntityDomainDropdown.Items.Add(new { Name = "" });
            this.EntityDomainDropdown.Items.AddRange(this.CurrentDatabase.Domains);
            this.EntityDomainDropdown.DisplayMember = "Name";
        }

        private void EntityDomainDropdown_SelectedIndexChanged(Object sender, EventArgs e)
        {
            // Get the entity being edited
            DataEntity entity = this.DomainTree.SelectedNode.Tag as DataEntity;
            if (entity == null)
                return;

            // Update the entity
            entity.CodeDomain = this.EntityDomainDropdown.SelectedItem as DataDomain;
            entity.Save();

            // Move the tree node for the entity
            TreeNode entityNode = this.DomainTree.SelectedNode;
            this.AddTreeNode(entity.CodeDomain == null ? this.RootNode.Nodes : this.DomainTree.Nodes[entity.CodeDomain.Identifier].Nodes, entityNode);
            this.DomainTree.SelectedNode = entityNode;
        }

        private void EntityNameTextbox_Leave(Object sender, EventArgs e)
        {
            // Get the entity being edited
            DataEntity entity = this.DomainTree.SelectedNode.Tag as DataEntity;
            if (entity == null)
                return;

            // Update the entity
            entity.CodeName = this.EntityNameTextbox.Text;
            entity.Save();
        }

        private void EntityDescriptionTextbox_Leave(Object sender, EventArgs e)
        {
            // Get the entity being edited
            DataEntity entity = this.DomainTree.SelectedNode.Tag as DataEntity;
            if (entity == null)
                return;

            // Update the entity
            entity.CodeDescription = this.EntityDescriptionTextbox.Text;
            entity.Save();
        }

        private void EntityAllowCreate_CheckedChanged(Object sender, EventArgs e)
        {
            // Get the entity being edited
            DataEntity entity = this.DomainTree.SelectedNode.Tag as DataEntity;
            if (entity == null)
                return;

            // Update the entity
            entity.CanCreate = this.EntityAllowCreate.Checked;
            entity.Save();
        }

        private void EntityAllowModify_CheckedChanged(Object sender, EventArgs e)
        {
            // Get the entity being edited
            DataEntity entity = this.DomainTree.SelectedNode.Tag as DataEntity;
            if (entity == null)
                return;

            // Update the entity
            entity.CanModify = this.EntityAllowModify.Checked;
            entity.Save();
        }

        private void EntityAllowRemove_CheckedChanged(Object sender, EventArgs e)
        {
            // Get the entity being edited
            DataEntity entity = this.DomainTree.SelectedNode.Tag as DataEntity;
            if (entity == null)
                return;

            // Update the entity
            entity.CanRemove = this.EntityAllowRemove.Checked;
            entity.Save();
        }

        private void FieldGrid_CellEndEdit(Object sender, DataGridViewCellEventArgs e)
        {
            DataEntityField field = this.FieldGrid.Rows[e.RowIndex].DataBoundItem as DataEntityField;
            if (field != null)
                field.Save();
        }

        private void FieldGrid_CellContentClick(Object sender, DataGridViewCellEventArgs e)
        {
            DataEntityField field = this.FieldGrid.Rows[e.RowIndex].DataBoundItem as DataEntityField;
            if (e.RowIndex >= 0 && e.ColumnIndex == this.FieldEllipsisColumn.Index && !field.IsPrimaryKey)
            {
                FieldSettings fieldSettings = new FieldSettings();
                fieldSettings.RelatedEntityDropdown.Items.Add(new { CodeName = "" });
                fieldSettings.RelatedEntityDropdown.Items.AddRange(this.CurrentDatabase.Domains.SelectMany(domain => domain.Entities).OrderBy(ent => ent.ObjectName).ToArray());
                fieldSettings.RelatedEntityDropdown.DisplayMember = "CodeName";
                
                // Display the current settings in the UI
                fieldSettings.FieldType = field.CodeType;
                fieldSettings.FieldNameTextbox.Text = field.ObjectName;
                fieldSettings.ExposureDropdown.SelectedIndex = (Int32)field.CodeExposure;
                fieldSettings.RelatedEntityDropdown.SelectedItem = field.RelatedEntity;
                fieldSettings.RelatedFieldDropdown.SelectedItem = field.RelatedField;
                fieldSettings.RelatedFieldTextbox.Text = field.CodeHeader;
                fieldSettings.IsUniqueCheckbox.Checked = field.IsUnique;

                if (fieldSettings.ShowDialog() == DialogResult.OK)
                {
                    field.CodeExposure = (DataEntityField.Exposure)fieldSettings.ExposureDropdown.SelectedIndex;
                    field.IsUnique = fieldSettings.IsUniqueCheckbox.Checked;
                    field.RelatedEntity = fieldSettings.RelatedEntityDropdown.SelectedIndex < 1 ? null : fieldSettings.RelatedEntityDropdown.SelectedItem as DataEntity;
                    if (field.RelatedEntity == null)
                    {
                        field.RelatedField = null;
                        field.CodeHeader = null;
                    }
                    else if (String.Equals(field.RelatedEntity.ObjectName, "Code", StringComparison.OrdinalIgnoreCase))
                    {
                        field.RelatedField = null;
                        field.CodeHeader = fieldSettings.RelatedFieldTextbox.Text;
                    }
                    else
                    {
                        field.RelatedField = fieldSettings.RelatedEntityDropdown.SelectedIndex < 1 ? null : fieldSettings.RelatedFieldDropdown.SelectedItem as DataEntityField;
                        field.CodeHeader = null;
                    }
                    field.Save();
                }
            }
        }

        private void GeneratorSolutionNameTextbox_Enter(object sender, EventArgs e)
        {
            this.GeneratorSolutionNameTextbox.Tag = this.CurrentSolution.SolutionName;
        }

        private void GeneratorSolutionVersionTextbox_Enter(object sender, EventArgs e)
        {
            this.GeneratorSolutionVersionTextbox.Tag = this.CurrentSolution.SolutionVersion;
        }

        private void GeneratorSolutionDirectoryTextbox_Enter(object sender, EventArgs e)
        {
            this.GeneratorSolutionDirectoryTextbox.Tag = this.CurrentSolution.SolutionPath;
        }

        private void GeneratorSolutionNameTextbox_Leave(object sender, EventArgs e)
        {
            String result = this.GeneratorSolutionNameTextbox.Text;
            if (String.IsNullOrEmpty(result))
                result = this.GeneratorSolutionNameTextbox.Tag as String;

            this.CurrentSolution.SolutionName = result;
            this.GeneratorSolutionNameTextbox.Text = this.CurrentSolution.SolutionName;
            this.GeneratorSolutionNameTextbox.Tag = null;
            this.CurrentSolution.Save();
        }

        private void GeneratorSolutionVersionTextbox_Leave(object sender, EventArgs e)
        {
            Version result;
            if (!Version.TryParse(this.GeneratorSolutionVersionTextbox.Text, out result))
                result = this.GeneratorSolutionVersionTextbox.Tag as Version;

            this.CurrentSolution.SolutionVersion = result;
            this.GeneratorSolutionVersionTextbox.Text = this.CurrentSolution.SolutionVersion.ToString();
            this.GeneratorSolutionVersionTextbox.Tag = null;
            this.CurrentSolution.Save();
        }

        private void GeneratorSolutionDirectoryTextbox_Leave(object sender, EventArgs e)
        {
            String result = this.GeneratorSolutionDirectoryTextbox.Text;
            if (String.IsNullOrEmpty(result))
                result = this.GeneratorSolutionDirectoryTextbox.Tag as String;
            else if (!Directory.Exists(result))
                result = this.GeneratorSolutionDirectoryTextbox.Tag as String;

            this.CurrentSolution.SolutionPath = result;
            this.GeneratorSolutionDirectoryTextbox.Text = this.CurrentSolution.SolutionPath;
            this.GeneratorSolutionDirectoryTextbox.Tag = null;
            this.CurrentSolution.Save();
        }

        private void GeneratorSqlButton_Click(object sender, EventArgs e)
        {
            CodeGenerator codeGenerator = this.CreateCodeGenerator();
            codeGenerator.ExecuteEntity = true;

            this.StartCodeGenerator(codeGenerator.GenerateConsensusEntity);
        }

        private void GeneratorDalButton_Click(Object sender, EventArgs e)
        {
            CodeGenerator codeGenerator = this.CreateCodeGenerator();
            this.StartCodeGenerator(
                codeGenerator.GenerateConsensusData,
                codeGenerator.GenerateConsensusDataSqlServer,
                codeGenerator.GenerateConsensusDataInterfaces
            );
        }

        private void GeneratorBllButton_Click(Object sender, EventArgs e)
        {
            CodeGenerator codeGenerator = this.CreateCodeGenerator();
            this.StartCodeGenerator(
                codeGenerator.GenerateConsensusBusiness,
                codeGenerator.GenerateConsensusBusinessLogic,
                codeGenerator.GenerateConsensusBusinessInterfaces,
                codeGenerator.GenerateConsensusBusinessImplementors
            );
        }
        
        #endregion

        #region methods

        private void AddDomain(String name)
        {
            // Create a new domain within the database
            DataDomain domain = new DataDomain(this.CurrentDatabase);
            domain.Identifier = name;
            domain.Name = name;
            domain.Save();

            // Add the tree node to the tree
            this.AddTreeNode(this.DomainTree.Nodes, domain);
            this.DomainTree.SelectedNode = this.DomainTree.Nodes[domain.Identifier];

            // Refresh the current database
            this.CurrentDatabase.Refresh();
        }

        private void AddTreeNode(TreeNodeCollection collection, DataEntity entity)
        {
            TreeNode node = new TreeNode();
            node.Name = entity.ObjectId.ToString();
            node.Text = entity.CodeName;
            node.ImageIndex = 1;
            node.SelectedImageIndex = 1;
            node.Tag = entity;

            this.AddTreeNode(collection, node);
        }

        private void AddTreeNode(TreeNodeCollection collection, DataDomain domain)
        {
            TreeNode node = new TreeNode();
            node.Name = domain.Identifier;
            node.Text = domain.Name;
            node.ImageIndex = 0;
            node.SelectedImageIndex = 0;
            node.Tag = domain;

            this.AddTreeNode(collection, node);
        }

        private void AddTreeNode(TreeNodeCollection collection, TreeNode newNode)
        {
            if (newNode.Parent != null)
                newNode.Remove();

            Int32 index = Enumerable.Range(0, collection.Count).Where(i => collection[i].Name == "" || String.Compare(collection[i].Text, newNode.Text) == -1).Select(i => i + 1).LastOrDefault();
            collection.Insert(index, newNode);
        }

        private void RemoveDomain(DataDomain domain)
        {
            if (domain.Entities.Length != 0)
                if (MessageBox.Show(domain.Entities.Length.ToString() + " " + (domain.Entities.Length == 1 ? "entity" : "entities") + " exists within this namespace and will removed from scope." + Environment.NewLine + "No further code will be generated for " + (domain.Entities.Length == 1 ? "this entity" : "these entities") + "." + Environment.NewLine + Environment.NewLine + "Are you sure you want to continue?", "Remove Namespace", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;

            // Remove the entities from the domain
            List<DataEntity> entities = domain.Entities.ToList();
            entities.ForEach(entity => entity.CodeDomain = null);
            entities.ForEach(entity => entity.Save());

            // Remove the entities from the domain tree
            foreach (TreeNode entity in this.DomainTree.SelectedNode.Nodes)
                this.AddTreeNode(this.RootNode.Nodes, entity);

            // Remove the domain from the database
            this.DomainTree.SelectedNode.Remove();
            domain.Name = null;
            domain.Save();

            // Refresh the current database
            this.CurrentDatabase.Refresh();
        }

        private static Image GetImage(Icon icon, Int32 size)
        {
            Icon source = new Icon(icon, size, size);
            Image result = Bitmap.FromHicon(source.Handle);
            return result;
        }

        private void EnableButtons(Boolean enabled)
        {
            this.GeneratorSqlButton.Enabled = enabled;
            this.GeneratorSqlButton.Enabled = enabled;
            this.GeneratorDalButton.Enabled = enabled;
            this.GeneratorBllButton.Enabled = enabled;
            this.GenerateBaseCheckbox.Enabled = enabled;
            this.GeneratorSolutionNameTextbox.Enabled = enabled;
            this.GeneratorSolutionDirectoryTextbox.Enabled = enabled;
            this.GeneratorSolutionVersionTextbox.Enabled = enabled;
            this.MainTabControl.SelectedTab = this.GeneratorTab;
        }

        private void LogMessage(TextBox textbox, String message)
        {
            Action delegatedMethod = delegate() { this.LogMessage(textbox, message); };

            if (!this.InvokeRequired)
                textbox.AppendText(message + Environment.NewLine);
            else
                this.Invoke(delegatedMethod);
        }

        private CodeGenerator CreateCodeGenerator()
        {
            CodeGenerator generator = new CodeGenerator(this.CurrentDatabase, this.CurrentSolution, this.GenerateBaseCheckbox.Checked);
            generator.LogGenerator += delegate(String message) { this.LogMessage(this.GeneratorLog, message); };
            generator.LogCompiler += delegate(String message) { this.LogMessage(this.GeneratorConsole, message); };
            generator.LogFile += delegate(String path) { this.TemporaryFiles.Add(path); };
            return generator;
        }

        private void StartCodeGenerator(params Action[] actions)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += this.ExecuteCodeGenerator;
            worker.RunWorkerCompleted += this.FinalizeCodeGenerator;
            worker.RunWorkerAsync(actions);

            this.EnableButtons(false);
        }

        private void ExecuteCodeGenerator(Object sender, DoWorkEventArgs arguments)
        {
            Action[] actions = arguments.Argument as Action[];
            foreach (Action action in actions)
            {
                CrossAppDomainDelegate delegatedAction = new CrossAppDomainDelegate(action);

                // Create a temporary application domain, in which the code generation process can be executed
                AppDomainSetup temporarySetup = new AppDomainSetup();
                temporarySetup.LoaderOptimization = LoaderOptimization.SingleDomain;
                temporarySetup.ShadowCopyFiles = "true";
                temporarySetup.ApplicationBase = AppDomain.CurrentDomain.BaseDirectory;
                AppDomain temporaryDomain = AppDomain.CreateDomain("Temp" + Path.GetRandomFileName(), AppDomain.CurrentDomain.Evidence, temporarySetup);

                // Execute the code generation process within the temporary application domain and then unload, to release the assembly files
                try { temporaryDomain.DoCallBack(delegatedAction); }
                finally { AppDomain.Unload(temporaryDomain); }

                // Remove all temporary files
                this.TemporaryFiles.ForEach(File.Delete);
                this.TemporaryFiles.Clear();
            }
        }

        private void FinalizeCodeGenerator(object sender, RunWorkerCompletedEventArgs e)
        {
            // Detail any exceptions
            Exception exception = e.Error;
            while (exception != null)
            {
                this.GeneratorConsole.AppendText(Environment.NewLine + "Error: " + exception.Message);
                this.GeneratorConsole.AppendText(Environment.NewLine + "Source: " + exception.Source);
                this.GeneratorConsole.AppendText(Environment.NewLine + "Stack: " + exception.StackTrace);
                this.GeneratorConsole.AppendText(Environment.NewLine);
                exception = exception.InnerException;
            }

            // Dispose the background worker
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.Dispose();

            // Reset the user interface
            if (this.PostProcess != null)
                this.PostProcess.Invoke();

            this.EnableButtons(true);
            this.PostProcess = null;
        }

        #endregion

        private void GeneratorSolutionNameTextbox_TextChanged(object sender, EventArgs e)
        {
            this.CurrentSolution.SolutionName = this.GeneratorSolutionNameTextbox.Text;
            this.CurrentSolution.Save();
        }

        private void GeneratorSolutionVersionTextbox_TextChanged(object sender, EventArgs e)
        {
            this.CurrentSolution.SolutionVersion = Version.Parse(this.GeneratorSolutionVersionTextbox.Text);
            this.CurrentSolution.Save();
        }

        private void GeneratorSolutionDirectoryTextbox_TextChanged(object sender, EventArgs e)
        {
            this.CurrentSolution.SolutionPath = this.GeneratorSolutionDirectoryTextbox.Text;
            this.CurrentSolution.Save();
        }
    }
}