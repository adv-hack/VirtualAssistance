
namespace Consensus.CodeGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainToolBar = new System.Windows.Forms.ToolStrip();
            this.ToolGenerate = new System.Windows.Forms.ToolStripDropDownButton();
            this.GenerateSql = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolGenerateDAL = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolGenerateBLL = new System.Windows.Forms.ToolStripMenuItem();
            this.TooGenerateSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolGenerateAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTableSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolTableCreate = new System.Windows.Forms.ToolStripButton();
            this.ToolTableImport = new System.Windows.Forms.ToolStripButton();
            this.ToolTableDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolColumnSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolColumnCreate = new System.Windows.Forms.ToolStripButton();
            this.ToolColumnDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolIndexSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolIndexCreate = new System.Windows.Forms.ToolStripButton();
            this.ToolIndexDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolConstraintSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolConstraintCreate = new System.Windows.Forms.ToolStripButton();
            this.ToolConstraintDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolContainerSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolContainerCreate = new System.Windows.Forms.ToolStripButton();
            this.ToolContainerDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolEntitySeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolEntityCreate = new System.Windows.Forms.ToolStripButton();
            this.ToolEntityDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolSourceSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolSourceCreate = new System.Windows.Forms.ToolStripButton();
            this.ToolSourceDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolPropertiesSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolProperties = new System.Windows.Forms.ToolStripButton();
            this.MainStatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.MainTree = new System.Windows.Forms.TreeView();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ColumnTab = new System.Windows.Forms.TabPage();
            this.ColumnGrid = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnScale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNullable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnDefault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProgrammaticName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexTab = new System.Windows.Forms.TabPage();
            this.IndexGrid = new System.Windows.Forms.DataGridView();
            this.ConstraintTab = new System.Windows.Forms.TabPage();
            this.ConstraintGrid = new System.Windows.Forms.DataGridView();
            this.AttributeTab = new System.Windows.Forms.TabPage();
            this.AttributeGrid = new System.Windows.Forms.DataGridView();
            this.PropertyIsExposed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PropertyColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyExposureType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PropertyExternalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttributeReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GeneratorTab = new System.Windows.Forms.TabPage();
            this.GeneratorConsole = new System.Windows.Forms.TextBox();
            this.ToolGenerateCCL = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolBar.SuspendLayout();
            this.MainStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.ColumnTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnGrid)).BeginInit();
            this.IndexTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndexGrid)).BeginInit();
            this.ConstraintTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConstraintGrid)).BeginInit();
            this.AttributeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttributeGrid)).BeginInit();
            this.GeneratorTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolBar
            // 
            this.MainToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolGenerate,
            this.ToolTableSeparator,
            this.ToolTableCreate,
            this.ToolTableImport,
            this.ToolTableDelete,
            this.ToolColumnSeparator,
            this.ToolColumnCreate,
            this.ToolColumnDelete,
            this.ToolIndexSeparator,
            this.ToolIndexCreate,
            this.ToolIndexDelete,
            this.ToolConstraintSeparator,
            this.ToolConstraintCreate,
            this.ToolConstraintDelete,
            this.ToolContainerSeparator,
            this.ToolContainerCreate,
            this.ToolContainerDelete,
            this.ToolEntitySeparator,
            this.ToolEntityCreate,
            this.ToolEntityDelete,
            this.ToolSourceSeparator,
            this.ToolSourceCreate,
            this.ToolSourceDelete,
            this.ToolPropertiesSeparator,
            this.ToolProperties});
            this.MainToolBar.Location = new System.Drawing.Point(0, 0);
            this.MainToolBar.Name = "MainToolBar";
            this.MainToolBar.Padding = new System.Windows.Forms.Padding(2, 0, 1, 0);
            this.MainToolBar.Size = new System.Drawing.Size(1184, 25);
            this.MainToolBar.TabIndex = 4;
            // 
            // ToolGenerate
            // 
            this.ToolGenerate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateSql,
            this.ToolGenerateDAL,
            this.ToolGenerateBLL,
            this.ToolGenerateCCL,
            this.TooGenerateSeparator,
            this.ToolGenerateAll});
            this.ToolGenerate.Image = global::Consensus.CodeGenerator.Properties.Resources.GenerateCode;
            this.ToolGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolGenerate.Name = "ToolGenerate";
            this.ToolGenerate.Size = new System.Drawing.Size(83, 22);
            this.ToolGenerate.Text = "Generate";
            // 
            // GenerateSql
            // 
            this.GenerateSql.Name = "GenerateSql";
            this.GenerateSql.Size = new System.Drawing.Size(194, 22);
            this.GenerateSql.Text = "Stored Procedures";
            this.GenerateSql.Click += new System.EventHandler(this.GenerateSql_Click);
            // 
            // ToolGenerateDAL
            // 
            this.ToolGenerateDAL.Name = "ToolGenerateDAL";
            this.ToolGenerateDAL.Size = new System.Drawing.Size(194, 22);
            this.ToolGenerateDAL.Text = "Data Access Layer";
            this.ToolGenerateDAL.Click += new System.EventHandler(this.ToolGenerateDAL_Click);
            // 
            // ToolGenerateBLL
            // 
            this.ToolGenerateBLL.Name = "ToolGenerateBLL";
            this.ToolGenerateBLL.Size = new System.Drawing.Size(194, 22);
            this.ToolGenerateBLL.Text = "Business Logic Layer";
            this.ToolGenerateBLL.Click += new System.EventHandler(this.ToolGenerateBLL_Click);
            // 
            // TooGenerateSeparator
            // 
            this.TooGenerateSeparator.Name = "TooGenerateSeparator";
            this.TooGenerateSeparator.Size = new System.Drawing.Size(191, 6);
            // 
            // ToolGenerateAll
            // 
            this.ToolGenerateAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolGenerateAll.Name = "ToolGenerateAll";
            this.ToolGenerateAll.Size = new System.Drawing.Size(194, 22);
            this.ToolGenerateAll.Text = "All Layers";
            this.ToolGenerateAll.Click += new System.EventHandler(this.ToolGenerateAll_Click);
            // 
            // ToolTableSeparator
            // 
            this.ToolTableSeparator.Name = "ToolTableSeparator";
            this.ToolTableSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolTableCreate
            // 
            this.ToolTableCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolTableCreate.Image = global::Consensus.CodeGenerator.Properties.Resources.TableCreate;
            this.ToolTableCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolTableCreate.Name = "ToolTableCreate";
            this.ToolTableCreate.Size = new System.Drawing.Size(23, 22);
            this.ToolTableCreate.Text = "Create Table";
            this.ToolTableCreate.Click += new System.EventHandler(this.ToolTableCreate_Click);
            // 
            // ToolTableImport
            // 
            this.ToolTableImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolTableImport.Image = global::Consensus.CodeGenerator.Properties.Resources.TableImport;
            this.ToolTableImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolTableImport.Name = "ToolTableImport";
            this.ToolTableImport.Size = new System.Drawing.Size(23, 22);
            this.ToolTableImport.Text = "Import Table";
            this.ToolTableImport.Click += new System.EventHandler(this.ToolTableImport_Click);
            // 
            // ToolTableDelete
            // 
            this.ToolTableDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolTableDelete.Image = global::Consensus.CodeGenerator.Properties.Resources.TableDelete;
            this.ToolTableDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolTableDelete.Name = "ToolTableDelete";
            this.ToolTableDelete.Size = new System.Drawing.Size(23, 22);
            this.ToolTableDelete.Text = "Delete Table";
            this.ToolTableDelete.Click += new System.EventHandler(this.ToolTableDelete_Click);
            // 
            // ToolColumnSeparator
            // 
            this.ToolColumnSeparator.Name = "ToolColumnSeparator";
            this.ToolColumnSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolColumnCreate
            // 
            this.ToolColumnCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolColumnCreate.Image = global::Consensus.CodeGenerator.Properties.Resources.ColumnCreate;
            this.ToolColumnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolColumnCreate.Name = "ToolColumnCreate";
            this.ToolColumnCreate.Size = new System.Drawing.Size(23, 22);
            this.ToolColumnCreate.Text = "Create Column";
            this.ToolColumnCreate.Click += new System.EventHandler(this.ToolColumnCreate_Click);
            // 
            // ToolColumnDelete
            // 
            this.ToolColumnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolColumnDelete.Image = global::Consensus.CodeGenerator.Properties.Resources.ColumnDelete;
            this.ToolColumnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolColumnDelete.Name = "ToolColumnDelete";
            this.ToolColumnDelete.Size = new System.Drawing.Size(23, 22);
            this.ToolColumnDelete.Text = "Delete Column";
            this.ToolColumnDelete.Click += new System.EventHandler(this.ToolColumnDelete_Click);
            // 
            // ToolIndexSeparator
            // 
            this.ToolIndexSeparator.Name = "ToolIndexSeparator";
            this.ToolIndexSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolIndexCreate
            // 
            this.ToolIndexCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolIndexCreate.Image = global::Consensus.CodeGenerator.Properties.Resources.IndexCreate;
            this.ToolIndexCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolIndexCreate.Name = "ToolIndexCreate";
            this.ToolIndexCreate.Size = new System.Drawing.Size(23, 22);
            this.ToolIndexCreate.Text = "Create Index";
            this.ToolIndexCreate.Click += new System.EventHandler(this.ToolIndexCreate_Click);
            // 
            // ToolIndexDelete
            // 
            this.ToolIndexDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolIndexDelete.Image = global::Consensus.CodeGenerator.Properties.Resources.IndexDelete;
            this.ToolIndexDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolIndexDelete.Name = "ToolIndexDelete";
            this.ToolIndexDelete.Size = new System.Drawing.Size(23, 22);
            this.ToolIndexDelete.Text = "Delete Index";
            this.ToolIndexDelete.Click += new System.EventHandler(this.ToolIndexDelete_Click);
            // 
            // ToolConstraintSeparator
            // 
            this.ToolConstraintSeparator.Name = "ToolConstraintSeparator";
            this.ToolConstraintSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolConstraintCreate
            // 
            this.ToolConstraintCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolConstraintCreate.Image = global::Consensus.CodeGenerator.Properties.Resources.ConstraintCreate;
            this.ToolConstraintCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolConstraintCreate.Name = "ToolConstraintCreate";
            this.ToolConstraintCreate.Size = new System.Drawing.Size(23, 22);
            this.ToolConstraintCreate.Text = "Create Constraint";
            this.ToolConstraintCreate.Click += new System.EventHandler(this.ToolConstraintCreate_Click);
            // 
            // ToolConstraintDelete
            // 
            this.ToolConstraintDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolConstraintDelete.Image = global::Consensus.CodeGenerator.Properties.Resources.ConstraintDelete;
            this.ToolConstraintDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolConstraintDelete.Name = "ToolConstraintDelete";
            this.ToolConstraintDelete.Size = new System.Drawing.Size(23, 22);
            this.ToolConstraintDelete.Text = "Delete Constraint";
            this.ToolConstraintDelete.Click += new System.EventHandler(this.ToolConstraintDelete_Click);
            // 
            // ToolContainerSeparator
            // 
            this.ToolContainerSeparator.Name = "ToolContainerSeparator";
            this.ToolContainerSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolContainerCreate
            // 
            this.ToolContainerCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolContainerCreate.Image = global::Consensus.CodeGenerator.Properties.Resources.ContainerCreate;
            this.ToolContainerCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolContainerCreate.Name = "ToolContainerCreate";
            this.ToolContainerCreate.Size = new System.Drawing.Size(23, 22);
            this.ToolContainerCreate.Text = "Create Container";
            this.ToolContainerCreate.Click += new System.EventHandler(this.ToolContainerCreate_Click);
            // 
            // ToolContainerDelete
            // 
            this.ToolContainerDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolContainerDelete.Image = global::Consensus.CodeGenerator.Properties.Resources.ContainerDelete;
            this.ToolContainerDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolContainerDelete.Name = "ToolContainerDelete";
            this.ToolContainerDelete.Size = new System.Drawing.Size(23, 22);
            this.ToolContainerDelete.Text = "Delete Container";
            this.ToolContainerDelete.Click += new System.EventHandler(this.ToolContainerDelete_Click);
            // 
            // ToolEntitySeparator
            // 
            this.ToolEntitySeparator.Name = "ToolEntitySeparator";
            this.ToolEntitySeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolEntityCreate
            // 
            this.ToolEntityCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolEntityCreate.Image = global::Consensus.CodeGenerator.Properties.Resources.EntityCreate;
            this.ToolEntityCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolEntityCreate.Name = "ToolEntityCreate";
            this.ToolEntityCreate.Size = new System.Drawing.Size(23, 22);
            this.ToolEntityCreate.Text = "Create Model";
            this.ToolEntityCreate.Click += new System.EventHandler(this.ToolEntityCreate_Click);
            // 
            // ToolEntityDelete
            // 
            this.ToolEntityDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolEntityDelete.Image = global::Consensus.CodeGenerator.Properties.Resources.EntityDelete;
            this.ToolEntityDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolEntityDelete.Name = "ToolEntityDelete";
            this.ToolEntityDelete.Size = new System.Drawing.Size(23, 22);
            this.ToolEntityDelete.Text = "Delete Model";
            this.ToolEntityDelete.Click += new System.EventHandler(this.ToolEntityDelete_Click);
            // 
            // ToolSourceSeparator
            // 
            this.ToolSourceSeparator.Name = "ToolSourceSeparator";
            this.ToolSourceSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolSourceCreate
            // 
            this.ToolSourceCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolSourceCreate.Image = global::Consensus.CodeGenerator.Properties.Resources.DatabaseCreate;
            this.ToolSourceCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSourceCreate.Name = "ToolSourceCreate";
            this.ToolSourceCreate.Size = new System.Drawing.Size(23, 22);
            this.ToolSourceCreate.Text = "Create Data Source";
            this.ToolSourceCreate.Click += new System.EventHandler(this.ToolSourceCreate_Click);
            // 
            // ToolSourceDelete
            // 
            this.ToolSourceDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolSourceDelete.Image = global::Consensus.CodeGenerator.Properties.Resources.DatabaseDelete;
            this.ToolSourceDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSourceDelete.Name = "ToolSourceDelete";
            this.ToolSourceDelete.Size = new System.Drawing.Size(23, 22);
            this.ToolSourceDelete.Text = "Delete Data Source";
            this.ToolSourceDelete.Click += new System.EventHandler(this.ToolSourceDelete_Click);
            // 
            // ToolPropertiesSeparator
            // 
            this.ToolPropertiesSeparator.Name = "ToolPropertiesSeparator";
            this.ToolPropertiesSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolProperties
            // 
            this.ToolProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolProperties.Image = global::Consensus.CodeGenerator.Properties.Resources.Properties;
            this.ToolProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolProperties.Name = "ToolProperties";
            this.ToolProperties.Size = new System.Drawing.Size(23, 22);
            this.ToolProperties.Text = "Properties";
            this.ToolProperties.Click += new System.EventHandler(this.ToolProperties_Click);
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.StatusProgress});
            this.MainStatusBar.Location = new System.Drawing.Point(0, 739);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Size = new System.Drawing.Size(1184, 22);
            this.MainStatusBar.SizingGrip = false;
            this.MainStatusBar.TabIndex = 3;
            // 
            // StatusLabel
            // 
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(917, 17);
            this.StatusLabel.Spring = true;
            this.StatusLabel.Text = "Status Label";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusProgress
            // 
            this.StatusProgress.Name = "StatusProgress";
            this.StatusProgress.Size = new System.Drawing.Size(250, 16);
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainContainer.Location = new System.Drawing.Point(0, 25);
            this.MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.MainTree);
            this.MainContainer.Panel1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MainContainer.Panel1MinSize = 200;
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.Controls.Add(this.MainTabControl);
            this.MainContainer.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MainContainer.Size = new System.Drawing.Size(1184, 714);
            this.MainContainer.SplitterDistance = 275;
            this.MainContainer.SplitterWidth = 2;
            this.MainContainer.TabIndex = 2;
            // 
            // MainTree
            // 
            this.MainTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTree.Location = new System.Drawing.Point(2, 2);
            this.MainTree.Name = "MainTree";
            this.MainTree.Size = new System.Drawing.Size(273, 710);
            this.MainTree.TabIndex = 0;
            this.MainTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTree_AfterSelect);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ColumnTab);
            this.MainTabControl.Controls.Add(this.IndexTab);
            this.MainTabControl.Controls.Add(this.ConstraintTab);
            this.MainTabControl.Controls.Add(this.AttributeTab);
            this.MainTabControl.Controls.Add(this.GeneratorTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(907, 713);
            this.MainTabControl.TabIndex = 1;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // ColumnTab
            // 
            this.ColumnTab.Controls.Add(this.ColumnGrid);
            this.ColumnTab.Location = new System.Drawing.Point(4, 22);
            this.ColumnTab.Name = "ColumnTab";
            this.ColumnTab.Padding = new System.Windows.Forms.Padding(3);
            this.ColumnTab.Size = new System.Drawing.Size(899, 687);
            this.ColumnTab.TabIndex = 0;
            this.ColumnTab.Text = "Columns";
            this.ColumnTab.UseVisualStyleBackColor = true;
            // 
            // ColumnGrid
            // 
            this.ColumnGrid.AllowUserToAddRows = false;
            this.ColumnGrid.AllowUserToDeleteRows = false;
            this.ColumnGrid.AllowUserToOrderColumns = true;
            this.ColumnGrid.AllowUserToResizeRows = false;
            this.ColumnGrid.BackgroundColor = System.Drawing.Color.White;
            this.ColumnGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ColumnGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ColumnGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ColumnGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnType,
            this.ColumnLength,
            this.ColumnScale,
            this.ColumnNullable,
            this.ColumnDefault,
            this.ColumnProgrammaticName,
            this.ColumnDescription});
            this.ColumnGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ColumnGrid.Location = new System.Drawing.Point(3, 3);
            this.ColumnGrid.MultiSelect = false;
            this.ColumnGrid.Name = "ColumnGrid";
            this.ColumnGrid.RowHeadersVisible = false;
            this.ColumnGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ColumnGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ColumnGrid.Size = new System.Drawing.Size(893, 681);
            this.ColumnGrid.TabIndex = 0;
            this.ColumnGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ColumnGrid_CellEndEdit);
            this.ColumnGrid.SelectionChanged += new System.EventHandler(this.ColumnGrid_SelectionChanged);
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "ColumnName";
            this.ColumnName.HeaderText = "Column Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 200;
            // 
            // ColumnType
            // 
            this.ColumnType.DataPropertyName = "ColumnType";
            this.ColumnType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.Width = 80;
            // 
            // ColumnLength
            // 
            this.ColumnLength.DataPropertyName = "ColumnLengthText";
            this.ColumnLength.HeaderText = "Length";
            this.ColumnLength.Name = "ColumnLength";
            this.ColumnLength.Width = 55;
            // 
            // ColumnScale
            // 
            this.ColumnScale.DataPropertyName = "ColumnScaleText";
            this.ColumnScale.HeaderText = "Scale";
            this.ColumnScale.Name = "ColumnScale";
            this.ColumnScale.Width = 55;
            // 
            // ColumnNullable
            // 
            this.ColumnNullable.DataPropertyName = "ColumnNullable";
            this.ColumnNullable.HeaderText = "Null";
            this.ColumnNullable.Name = "ColumnNullable";
            this.ColumnNullable.Width = 35;
            // 
            // ColumnDefault
            // 
            this.ColumnDefault.DataPropertyName = "ColumnDefaultValue";
            this.ColumnDefault.HeaderText = "Default";
            this.ColumnDefault.Name = "ColumnDefault";
            this.ColumnDefault.Width = 55;
            // 
            // ColumnProgrammaticName
            // 
            this.ColumnProgrammaticName.DataPropertyName = "ProgrammaticName";
            this.ColumnProgrammaticName.HeaderText = "Internal Name";
            this.ColumnProgrammaticName.Name = "ColumnProgrammaticName";
            this.ColumnProgrammaticName.Width = 150;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDescription.DataPropertyName = "ColumnDescription";
            this.ColumnDescription.HeaderText = "Description";
            this.ColumnDescription.Name = "ColumnDescription";
            // 
            // IndexTab
            // 
            this.IndexTab.Controls.Add(this.IndexGrid);
            this.IndexTab.Location = new System.Drawing.Point(4, 22);
            this.IndexTab.Name = "IndexTab";
            this.IndexTab.Padding = new System.Windows.Forms.Padding(3);
            this.IndexTab.Size = new System.Drawing.Size(899, 687);
            this.IndexTab.TabIndex = 1;
            this.IndexTab.Text = "Indexes";
            this.IndexTab.UseVisualStyleBackColor = true;
            // 
            // IndexGrid
            // 
            this.IndexGrid.AllowUserToAddRows = false;
            this.IndexGrid.AllowUserToDeleteRows = false;
            this.IndexGrid.AllowUserToOrderColumns = true;
            this.IndexGrid.AllowUserToResizeRows = false;
            this.IndexGrid.BackgroundColor = System.Drawing.Color.White;
            this.IndexGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IndexGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.IndexGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.IndexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndexGrid.Location = new System.Drawing.Point(3, 3);
            this.IndexGrid.MultiSelect = false;
            this.IndexGrid.Name = "IndexGrid";
            this.IndexGrid.ReadOnly = true;
            this.IndexGrid.RowHeadersVisible = false;
            this.IndexGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.IndexGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IndexGrid.Size = new System.Drawing.Size(893, 681);
            this.IndexGrid.TabIndex = 1;
            // 
            // ConstraintTab
            // 
            this.ConstraintTab.Controls.Add(this.ConstraintGrid);
            this.ConstraintTab.Location = new System.Drawing.Point(4, 22);
            this.ConstraintTab.Name = "ConstraintTab";
            this.ConstraintTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConstraintTab.Size = new System.Drawing.Size(899, 687);
            this.ConstraintTab.TabIndex = 2;
            this.ConstraintTab.Text = "Constraints";
            this.ConstraintTab.UseVisualStyleBackColor = true;
            // 
            // ConstraintGrid
            // 
            this.ConstraintGrid.AllowUserToAddRows = false;
            this.ConstraintGrid.AllowUserToDeleteRows = false;
            this.ConstraintGrid.AllowUserToOrderColumns = true;
            this.ConstraintGrid.AllowUserToResizeRows = false;
            this.ConstraintGrid.BackgroundColor = System.Drawing.Color.White;
            this.ConstraintGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConstraintGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ConstraintGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ConstraintGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConstraintGrid.Location = new System.Drawing.Point(3, 3);
            this.ConstraintGrid.MultiSelect = false;
            this.ConstraintGrid.Name = "ConstraintGrid";
            this.ConstraintGrid.ReadOnly = true;
            this.ConstraintGrid.RowHeadersVisible = false;
            this.ConstraintGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ConstraintGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConstraintGrid.Size = new System.Drawing.Size(893, 681);
            this.ConstraintGrid.TabIndex = 2;
            // 
            // AttributeTab
            // 
            this.AttributeTab.Controls.Add(this.AttributeGrid);
            this.AttributeTab.Location = new System.Drawing.Point(4, 22);
            this.AttributeTab.Name = "AttributeTab";
            this.AttributeTab.Padding = new System.Windows.Forms.Padding(3);
            this.AttributeTab.Size = new System.Drawing.Size(899, 687);
            this.AttributeTab.TabIndex = 3;
            this.AttributeTab.Text = "Properties";
            this.AttributeTab.UseVisualStyleBackColor = true;
            // 
            // AttributeGrid
            // 
            this.AttributeGrid.AllowUserToAddRows = false;
            this.AttributeGrid.AllowUserToDeleteRows = false;
            this.AttributeGrid.AllowUserToOrderColumns = true;
            this.AttributeGrid.AllowUserToResizeRows = false;
            this.AttributeGrid.BackgroundColor = System.Drawing.Color.White;
            this.AttributeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AttributeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AttributeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AttributeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyIsExposed,
            this.PropertyColumnName,
            this.PropertyExposureType,
            this.PropertyExternalName,
            this.AttributeReference,
            this.PropertyDescription,
            this.PropertyButton});
            this.AttributeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttributeGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.AttributeGrid.Location = new System.Drawing.Point(3, 3);
            this.AttributeGrid.MultiSelect = false;
            this.AttributeGrid.Name = "AttributeGrid";
            this.AttributeGrid.RowHeadersVisible = false;
            this.AttributeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AttributeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AttributeGrid.Size = new System.Drawing.Size(893, 681);
            this.AttributeGrid.TabIndex = 1;
            this.AttributeGrid.DataSourceChanged += new System.EventHandler(this.AttributeGrid_DataSourceChanged);
            this.AttributeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttributeGrid_CellContentClick);
            this.AttributeGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttributeGrid_CellEndEdit);
            // 
            // PropertyIsExposed
            // 
            this.PropertyIsExposed.DataPropertyName = "AttributeExposed";
            this.PropertyIsExposed.HeaderText = "";
            this.PropertyIsExposed.MinimumWidth = 30;
            this.PropertyIsExposed.Name = "PropertyIsExposed";
            this.PropertyIsExposed.Width = 30;
            // 
            // PropertyColumnName
            // 
            this.PropertyColumnName.DataPropertyName = "ColumnName";
            this.PropertyColumnName.HeaderText = "Column";
            this.PropertyColumnName.Name = "PropertyColumnName";
            this.PropertyColumnName.ReadOnly = true;
            this.PropertyColumnName.Width = 200;
            // 
            // PropertyExposureType
            // 
            this.PropertyExposureType.DataPropertyName = "AttributeExposure";
            this.PropertyExposureType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.PropertyExposureType.HeaderText = "Exposure";
            this.PropertyExposureType.Name = "PropertyExposureType";
            this.PropertyExposureType.Width = 75;
            // 
            // PropertyExternalName
            // 
            this.PropertyExternalName.DataPropertyName = "AttributeName";
            this.PropertyExternalName.HeaderText = "External Name";
            this.PropertyExternalName.Name = "PropertyExternalName";
            this.PropertyExternalName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PropertyExternalName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PropertyExternalName.Width = 140;
            // 
            // AttributeReference
            // 
            this.AttributeReference.DataPropertyName = "ReferencedEntityName";
            this.AttributeReference.HeaderText = "References";
            this.AttributeReference.Name = "AttributeReference";
            this.AttributeReference.ReadOnly = true;
            this.AttributeReference.Width = 140;
            // 
            // PropertyDescription
            // 
            this.PropertyDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PropertyDescription.DataPropertyName = "AttributeDescription";
            this.PropertyDescription.HeaderText = "Description";
            this.PropertyDescription.Name = "PropertyDescription";
            // 
            // PropertyButton
            // 
            this.PropertyButton.HeaderText = "";
            this.PropertyButton.Name = "PropertyButton";
            this.PropertyButton.Text = "?";
            this.PropertyButton.Width = 25;
            // 
            // GeneratorTab
            // 
            this.GeneratorTab.Controls.Add(this.GeneratorConsole);
            this.GeneratorTab.Location = new System.Drawing.Point(4, 22);
            this.GeneratorTab.Name = "GeneratorTab";
            this.GeneratorTab.Size = new System.Drawing.Size(899, 687);
            this.GeneratorTab.TabIndex = 4;
            this.GeneratorTab.Text = "Generator";
            this.GeneratorTab.UseVisualStyleBackColor = true;
            // 
            // GeneratorConsole
            // 
            this.GeneratorConsole.BackColor = System.Drawing.Color.White;
            this.GeneratorConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GeneratorConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneratorConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratorConsole.ForeColor = System.Drawing.Color.DimGray;
            this.GeneratorConsole.Location = new System.Drawing.Point(0, 0);
            this.GeneratorConsole.Multiline = true;
            this.GeneratorConsole.Name = "GeneratorConsole";
            this.GeneratorConsole.ReadOnly = true;
            this.GeneratorConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GeneratorConsole.Size = new System.Drawing.Size(899, 687);
            this.GeneratorConsole.TabIndex = 0;
            // 
            // ToolGenerateCCL
            // 
            this.ToolGenerateCCL.Name = "ToolGenerateCCL";
            this.ToolGenerateCCL.Size = new System.Drawing.Size(194, 22);
            this.ToolGenerateCCL.Text = "Client Consumer Layer";
            this.ToolGenerateCCL.Click += new System.EventHandler(this.ToolGenerateCCL_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.MainStatusBar);
            this.Controls.Add(this.MainToolBar);
            this.Icon = global::Consensus.CodeGenerator.Properties.Resources.Advanced;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainToolBar.ResumeLayout(false);
            this.MainToolBar.PerformLayout();
            this.MainStatusBar.ResumeLayout(false);
            this.MainStatusBar.PerformLayout();
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.ColumnTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColumnGrid)).EndInit();
            this.IndexTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IndexGrid)).EndInit();
            this.ConstraintTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConstraintGrid)).EndInit();
            this.AttributeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttributeGrid)).EndInit();
            this.GeneratorTab.ResumeLayout(false);
            this.GeneratorTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolBar;
        private System.Windows.Forms.StatusStrip MainStatusBar;
        private System.Windows.Forms.SplitContainer MainContainer;
        private System.Windows.Forms.TreeView MainTree;
        private System.Windows.Forms.ToolStripSeparator ToolTableSeparator;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripProgressBar StatusProgress;
        private System.Windows.Forms.ToolStripButton ToolTableCreate;
        private System.Windows.Forms.ToolStripButton ToolTableImport;
        private System.Windows.Forms.ToolStripButton ToolTableDelete;
        private System.Windows.Forms.ToolStripSeparator ToolColumnSeparator;
        private System.Windows.Forms.ToolStripButton ToolColumnCreate;
        private System.Windows.Forms.ToolStripButton ToolColumnDelete;
        private System.Windows.Forms.ToolStripSeparator ToolIndexSeparator;
        private System.Windows.Forms.ToolStripButton ToolIndexCreate;
        private System.Windows.Forms.ToolStripButton ToolIndexDelete;
        private System.Windows.Forms.ToolStripSeparator ToolConstraintSeparator;
        private System.Windows.Forms.ToolStripButton ToolConstraintCreate;
        private System.Windows.Forms.ToolStripButton ToolConstraintDelete;
        private System.Windows.Forms.ToolStripSeparator ToolContainerSeparator;
        private System.Windows.Forms.ToolStripButton ToolContainerCreate;
        private System.Windows.Forms.ToolStripButton ToolContainerDelete;
        private System.Windows.Forms.ToolStripSeparator ToolEntitySeparator;
        private System.Windows.Forms.ToolStripButton ToolEntityCreate;
        private System.Windows.Forms.ToolStripButton ToolEntityDelete;
        private System.Windows.Forms.ToolStripSeparator ToolSourceSeparator;
        private System.Windows.Forms.ToolStripButton ToolSourceCreate;
        private System.Windows.Forms.ToolStripButton ToolSourceDelete;
        private System.Windows.Forms.ToolStripSeparator ToolPropertiesSeparator;
        private System.Windows.Forms.ToolStripButton ToolProperties;
        private System.Windows.Forms.TabPage ColumnTab;
        private System.Windows.Forms.DataGridView ColumnGrid;
        private System.Windows.Forms.TabPage IndexTab;
        private System.Windows.Forms.TabPage ConstraintTab;
        private System.Windows.Forms.DataGridView IndexGrid;
        private System.Windows.Forms.DataGridView ConstraintGrid;
        private System.Windows.Forms.TabPage AttributeTab;
        private System.Windows.Forms.DataGridView AttributeGrid;
        private System.Windows.Forms.TabPage GeneratorTab;
        private System.Windows.Forms.TextBox GeneratorConsole;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScale;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnNullable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProgrammaticName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PropertyIsExposed;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyColumnName;
        private System.Windows.Forms.DataGridViewComboBoxColumn PropertyExposureType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyExternalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttributeReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyDescription;
        private System.Windows.Forms.DataGridViewButtonColumn PropertyButton;
        private System.Windows.Forms.ToolStripDropDownButton ToolGenerate;
        private System.Windows.Forms.ToolStripMenuItem ToolGenerateDAL;
        private System.Windows.Forms.ToolStripMenuItem ToolGenerateBLL;
        private System.Windows.Forms.ToolStripSeparator TooGenerateSeparator;
        private System.Windows.Forms.ToolStripMenuItem ToolGenerateAll;
        private System.Windows.Forms.ToolStripMenuItem GenerateSql;
        private System.Windows.Forms.ToolStripMenuItem ToolGenerateCCL;
    }
}