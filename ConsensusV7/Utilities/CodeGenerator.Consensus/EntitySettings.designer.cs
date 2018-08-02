namespace CodeGenerator.Consensus
{
    partial class EntitySettings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.GeneratorTab = new System.Windows.Forms.TabPage();
            this.GeneratorContainer = new System.Windows.Forms.SplitContainer();
            this.GeneratorLog = new System.Windows.Forms.TextBox();
            this.GeneratorSpacer = new System.Windows.Forms.Panel();
            this.GeneratorGroup = new System.Windows.Forms.GroupBox();
            this.GeneratorSolutionDirectoryTextbox = new System.Windows.Forms.TextBox();
            this.GeneratorSolutionDirectoryLabel = new System.Windows.Forms.Label();
            this.GeneratorSolutionVersionTextbox = new System.Windows.Forms.TextBox();
            this.GeneratorSolutionVersionLabel = new System.Windows.Forms.Label();
            this.GeneratorSolutionNameLabel = new System.Windows.Forms.Label();
            this.GeneratorSolutionNameTextbox = new System.Windows.Forms.TextBox();
            this.GenerateBaseCheckbox = new System.Windows.Forms.CheckBox();
            this.GeneratorConsole = new System.Windows.Forms.TextBox();
            this.EntityTab = new System.Windows.Forms.TabPage();
            this.EntityAllowRemove = new System.Windows.Forms.CheckBox();
            this.EntityAllowModify = new System.Windows.Forms.CheckBox();
            this.EntityAllowCreate = new System.Windows.Forms.CheckBox();
            this.DomainNameTextbox = new System.Windows.Forms.TextBox();
            this.DomainAddButton = new System.Windows.Forms.Button();
            this.DomainTree = new System.Windows.Forms.TreeView();
            this.DomainRemoveButton = new System.Windows.Forms.Button();
            this.EntityPrefixLabel = new System.Windows.Forms.Label();
            this.EntityPrefixTextbox = new System.Windows.Forms.TextBox();
            this.EntityTitleLabel = new System.Windows.Forms.Label();
            this.FieldGrid = new System.Windows.Forms.DataGridView();
            this.FieldObjectNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldObjectTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldObjectNullableColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FieldCodeNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldCodeDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldEllipsisColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EntityDescriptionLabel = new System.Windows.Forms.Label();
            this.EntityDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.EntityNameLabel = new System.Windows.Forms.Label();
            this.EntityNameTextbox = new System.Windows.Forms.TextBox();
            this.EntityDomainLabel = new System.Windows.Forms.Label();
            this.EntityDomainDropdown = new System.Windows.Forms.ComboBox();
            this.DatabaseDropdown = new System.Windows.Forms.ComboBox();
            this.GeneratorDalButton = new System.Windows.Forms.Button();
            this.GeneratorBllButton = new System.Windows.Forms.Button();
            this.GeneratorSqlButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.GeneratorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratorContainer)).BeginInit();
            this.GeneratorContainer.Panel1.SuspendLayout();
            this.GeneratorContainer.Panel2.SuspendLayout();
            this.GeneratorContainer.SuspendLayout();
            this.GeneratorGroup.SuspendLayout();
            this.EntityTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FieldGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.GeneratorTab);
            this.MainTabControl.Controls.Add(this.EntityTab);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1160, 592);
            this.MainTabControl.TabIndex = 0;
            // 
            // GeneratorTab
            // 
            this.GeneratorTab.Controls.Add(this.GeneratorContainer);
            this.GeneratorTab.Location = new System.Drawing.Point(4, 24);
            this.GeneratorTab.Name = "GeneratorTab";
            this.GeneratorTab.Padding = new System.Windows.Forms.Padding(10);
            this.GeneratorTab.Size = new System.Drawing.Size(1152, 564);
            this.GeneratorTab.TabIndex = 1;
            this.GeneratorTab.Text = "Code Generation";
            this.GeneratorTab.UseVisualStyleBackColor = true;
            // 
            // GeneratorContainer
            // 
            this.GeneratorContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratorContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.GeneratorContainer.Location = new System.Drawing.Point(13, 13);
            this.GeneratorContainer.Name = "GeneratorContainer";
            // 
            // GeneratorContainer.Panel1
            // 
            this.GeneratorContainer.Panel1.Controls.Add(this.GeneratorLog);
            this.GeneratorContainer.Panel1.Controls.Add(this.GeneratorSpacer);
            this.GeneratorContainer.Panel1.Controls.Add(this.GeneratorGroup);
            // 
            // GeneratorContainer.Panel2
            // 
            this.GeneratorContainer.Panel2.Controls.Add(this.GeneratorConsole);
            this.GeneratorContainer.Size = new System.Drawing.Size(1126, 528);
            this.GeneratorContainer.SplitterDistance = 475;
            this.GeneratorContainer.SplitterWidth = 8;
            this.GeneratorContainer.TabIndex = 31;
            // 
            // GeneratorLog
            // 
            this.GeneratorLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneratorLog.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratorLog.Location = new System.Drawing.Point(0, 0);
            this.GeneratorLog.Multiline = true;
            this.GeneratorLog.Name = "GeneratorLog";
            this.GeneratorLog.ReadOnly = true;
            this.GeneratorLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GeneratorLog.Size = new System.Drawing.Size(475, 360);
            this.GeneratorLog.TabIndex = 40;
            // 
            // GeneratorSpacer
            // 
            this.GeneratorSpacer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GeneratorSpacer.Location = new System.Drawing.Point(0, 360);
            this.GeneratorSpacer.Name = "GeneratorSpacer";
            this.GeneratorSpacer.Size = new System.Drawing.Size(475, 18);
            this.GeneratorSpacer.TabIndex = 38;
            // 
            // GeneratorGroup
            // 
            this.GeneratorGroup.Controls.Add(this.GeneratorSolutionDirectoryTextbox);
            this.GeneratorGroup.Controls.Add(this.GeneratorSolutionDirectoryLabel);
            this.GeneratorGroup.Controls.Add(this.GeneratorSolutionVersionTextbox);
            this.GeneratorGroup.Controls.Add(this.GeneratorSolutionVersionLabel);
            this.GeneratorGroup.Controls.Add(this.GeneratorSolutionNameLabel);
            this.GeneratorGroup.Controls.Add(this.GeneratorSolutionNameTextbox);
            this.GeneratorGroup.Controls.Add(this.GenerateBaseCheckbox);
            this.GeneratorGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GeneratorGroup.Font = new System.Drawing.Font("Open Sans Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratorGroup.Location = new System.Drawing.Point(0, 378);
            this.GeneratorGroup.Name = "GeneratorGroup";
            this.GeneratorGroup.Padding = new System.Windows.Forms.Padding(10);
            this.GeneratorGroup.Size = new System.Drawing.Size(475, 150);
            this.GeneratorGroup.TabIndex = 37;
            this.GeneratorGroup.TabStop = false;
            this.GeneratorGroup.Text = "Code Generator Options";
            // 
            // GeneratorSolutionDirectoryTextbox
            // 
            this.GeneratorSolutionDirectoryTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratorSolutionDirectoryTextbox.Location = new System.Drawing.Point(129, 84);
            this.GeneratorSolutionDirectoryTextbox.Name = "GeneratorSolutionDirectoryTextbox";
            this.GeneratorSolutionDirectoryTextbox.Size = new System.Drawing.Size(328, 22);
            this.GeneratorSolutionDirectoryTextbox.TabIndex = 40;
            this.GeneratorSolutionDirectoryTextbox.TextChanged += new System.EventHandler(this.GeneratorSolutionDirectoryTextbox_TextChanged);
            // 
            // GeneratorSolutionDirectoryLabel
            // 
            this.GeneratorSolutionDirectoryLabel.AutoSize = true;
            this.GeneratorSolutionDirectoryLabel.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratorSolutionDirectoryLabel.Location = new System.Drawing.Point(13, 87);
            this.GeneratorSolutionDirectoryLabel.Name = "GeneratorSolutionDirectoryLabel";
            this.GeneratorSolutionDirectoryLabel.Size = new System.Drawing.Size(104, 15);
            this.GeneratorSolutionDirectoryLabel.TabIndex = 39;
            this.GeneratorSolutionDirectoryLabel.Text = "Solution Directory:";
            // 
            // GeneratorSolutionVersionTextbox
            // 
            this.GeneratorSolutionVersionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratorSolutionVersionTextbox.Location = new System.Drawing.Point(129, 56);
            this.GeneratorSolutionVersionTextbox.Name = "GeneratorSolutionVersionTextbox";
            this.GeneratorSolutionVersionTextbox.Size = new System.Drawing.Size(328, 22);
            this.GeneratorSolutionVersionTextbox.TabIndex = 38;
            this.GeneratorSolutionVersionTextbox.TextChanged += new System.EventHandler(this.GeneratorSolutionVersionTextbox_TextChanged);
            // 
            // GeneratorSolutionVersionLabel
            // 
            this.GeneratorSolutionVersionLabel.AutoSize = true;
            this.GeneratorSolutionVersionLabel.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratorSolutionVersionLabel.Location = new System.Drawing.Point(13, 59);
            this.GeneratorSolutionVersionLabel.Name = "GeneratorSolutionVersionLabel";
            this.GeneratorSolutionVersionLabel.Size = new System.Drawing.Size(96, 15);
            this.GeneratorSolutionVersionLabel.TabIndex = 37;
            this.GeneratorSolutionVersionLabel.Text = "Solution Version:";
            // 
            // GeneratorSolutionNameLabel
            // 
            this.GeneratorSolutionNameLabel.AutoSize = true;
            this.GeneratorSolutionNameLabel.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratorSolutionNameLabel.Location = new System.Drawing.Point(13, 31);
            this.GeneratorSolutionNameLabel.Name = "GeneratorSolutionNameLabel";
            this.GeneratorSolutionNameLabel.Size = new System.Drawing.Size(87, 15);
            this.GeneratorSolutionNameLabel.TabIndex = 36;
            this.GeneratorSolutionNameLabel.Text = "Solution Name:";
            // 
            // GeneratorSolutionNameTextbox
            // 
            this.GeneratorSolutionNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratorSolutionNameTextbox.Location = new System.Drawing.Point(129, 28);
            this.GeneratorSolutionNameTextbox.Name = "GeneratorSolutionNameTextbox";
            this.GeneratorSolutionNameTextbox.Size = new System.Drawing.Size(328, 22);
            this.GeneratorSolutionNameTextbox.TabIndex = 35;
            this.GeneratorSolutionNameTextbox.TextChanged += new System.EventHandler(this.GeneratorSolutionNameTextbox_TextChanged);
            // 
            // GenerateBaseCheckbox
            // 
            this.GenerateBaseCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GenerateBaseCheckbox.AutoSize = true;
            this.GenerateBaseCheckbox.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBaseCheckbox.Location = new System.Drawing.Point(16, 118);
            this.GenerateBaseCheckbox.Name = "GenerateBaseCheckbox";
            this.GenerateBaseCheckbox.Size = new System.Drawing.Size(149, 19);
            this.GenerateBaseCheckbox.TabIndex = 34;
            this.GenerateBaseCheckbox.Text = "Regenerate base classes";
            this.GenerateBaseCheckbox.UseVisualStyleBackColor = true;
            // 
            // GeneratorConsole
            // 
            this.GeneratorConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneratorConsole.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratorConsole.Location = new System.Drawing.Point(0, 0);
            this.GeneratorConsole.Multiline = true;
            this.GeneratorConsole.Name = "GeneratorConsole";
            this.GeneratorConsole.ReadOnly = true;
            this.GeneratorConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GeneratorConsole.Size = new System.Drawing.Size(643, 528);
            this.GeneratorConsole.TabIndex = 31;
            // 
            // EntityTab
            // 
            this.EntityTab.Controls.Add(this.EntityAllowRemove);
            this.EntityTab.Controls.Add(this.EntityAllowModify);
            this.EntityTab.Controls.Add(this.EntityAllowCreate);
            this.EntityTab.Controls.Add(this.DomainNameTextbox);
            this.EntityTab.Controls.Add(this.DomainAddButton);
            this.EntityTab.Controls.Add(this.DomainTree);
            this.EntityTab.Controls.Add(this.DomainRemoveButton);
            this.EntityTab.Controls.Add(this.EntityPrefixLabel);
            this.EntityTab.Controls.Add(this.EntityPrefixTextbox);
            this.EntityTab.Controls.Add(this.EntityTitleLabel);
            this.EntityTab.Controls.Add(this.FieldGrid);
            this.EntityTab.Controls.Add(this.EntityDescriptionLabel);
            this.EntityTab.Controls.Add(this.EntityDescriptionTextbox);
            this.EntityTab.Controls.Add(this.EntityNameLabel);
            this.EntityTab.Controls.Add(this.EntityNameTextbox);
            this.EntityTab.Controls.Add(this.EntityDomainLabel);
            this.EntityTab.Controls.Add(this.EntityDomainDropdown);
            this.EntityTab.Location = new System.Drawing.Point(4, 22);
            this.EntityTab.Name = "EntityTab";
            this.EntityTab.Padding = new System.Windows.Forms.Padding(10);
            this.EntityTab.Size = new System.Drawing.Size(1152, 566);
            this.EntityTab.TabIndex = 0;
            this.EntityTab.Text = "Entity Management";
            this.EntityTab.UseVisualStyleBackColor = true;
            // 
            // EntityAllowRemove
            // 
            this.EntityAllowRemove.AutoSize = true;
            this.EntityAllowRemove.Checked = true;
            this.EntityAllowRemove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EntityAllowRemove.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntityAllowRemove.Location = new System.Drawing.Point(767, 114);
            this.EntityAllowRemove.Name = "EntityAllowRemove";
            this.EntityAllowRemove.Size = new System.Drawing.Size(101, 19);
            this.EntityAllowRemove.TabIndex = 47;
            this.EntityAllowRemove.Text = "Allow deletion";
            this.EntityAllowRemove.UseVisualStyleBackColor = true;
            // 
            // EntityAllowModify
            // 
            this.EntityAllowModify.AutoSize = true;
            this.EntityAllowModify.Checked = true;
            this.EntityAllowModify.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EntityAllowModify.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntityAllowModify.Location = new System.Drawing.Point(767, 88);
            this.EntityAllowModify.Name = "EntityAllowModify";
            this.EntityAllowModify.Size = new System.Drawing.Size(124, 19);
            this.EntityAllowModify.TabIndex = 46;
            this.EntityAllowModify.Text = "Allow modification";
            this.EntityAllowModify.UseVisualStyleBackColor = true;
            // 
            // EntityAllowCreate
            // 
            this.EntityAllowCreate.AutoSize = true;
            this.EntityAllowCreate.Checked = true;
            this.EntityAllowCreate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EntityAllowCreate.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntityAllowCreate.Location = new System.Drawing.Point(767, 63);
            this.EntityAllowCreate.Name = "EntityAllowCreate";
            this.EntityAllowCreate.Size = new System.Drawing.Size(124, 19);
            this.EntityAllowCreate.TabIndex = 45;
            this.EntityAllowCreate.Text = "Allow instantiation";
            this.EntityAllowCreate.UseVisualStyleBackColor = true;
            this.EntityAllowCreate.CheckedChanged += new System.EventHandler(this.EntityAllowCreate_CheckedChanged);
            // 
            // DomainNameTextbox
            // 
            this.DomainNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DomainNameTextbox.Location = new System.Drawing.Point(13, 523);
            this.DomainNameTextbox.Name = "DomainNameTextbox";
            this.DomainNameTextbox.Size = new System.Drawing.Size(260, 22);
            this.DomainNameTextbox.TabIndex = 44;
            this.DomainNameTextbox.TextChanged += new System.EventHandler(this.DomainNameTextbox_TextChanged);
            // 
            // DomainAddButton
            // 
            this.DomainAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DomainAddButton.Enabled = false;
            this.DomainAddButton.Location = new System.Drawing.Point(275, 522);
            this.DomainAddButton.Name = "DomainAddButton";
            this.DomainAddButton.Size = new System.Drawing.Size(24, 24);
            this.DomainAddButton.TabIndex = 43;
            this.DomainAddButton.UseVisualStyleBackColor = true;
            this.DomainAddButton.Click += new System.EventHandler(this.DomainAddButton_Click);
            // 
            // DomainTree
            // 
            this.DomainTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DomainTree.Location = new System.Drawing.Point(13, 13);
            this.DomainTree.Name = "DomainTree";
            this.DomainTree.Size = new System.Drawing.Size(310, 504);
            this.DomainTree.TabIndex = 42;
            this.DomainTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DomainTree_AfterSelect);
            // 
            // DomainRemoveButton
            // 
            this.DomainRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DomainRemoveButton.Enabled = false;
            this.DomainRemoveButton.Location = new System.Drawing.Point(300, 522);
            this.DomainRemoveButton.Name = "DomainRemoveButton";
            this.DomainRemoveButton.Size = new System.Drawing.Size(24, 24);
            this.DomainRemoveButton.TabIndex = 41;
            this.DomainRemoveButton.UseVisualStyleBackColor = true;
            this.DomainRemoveButton.Click += new System.EventHandler(this.DomainRemoveButton_Click);
            // 
            // EntityPrefixLabel
            // 
            this.EntityPrefixLabel.AutoSize = true;
            this.EntityPrefixLabel.Location = new System.Drawing.Point(339, 89);
            this.EntityPrefixLabel.Name = "EntityPrefixLabel";
            this.EntityPrefixLabel.Size = new System.Drawing.Size(91, 15);
            this.EntityPrefixLabel.TabIndex = 40;
            this.EntityPrefixLabel.Text = "Database Prefix:";
            // 
            // EntityPrefixTextbox
            // 
            this.EntityPrefixTextbox.BackColor = System.Drawing.Color.White;
            this.EntityPrefixTextbox.ForeColor = System.Drawing.Color.Gray;
            this.EntityPrefixTextbox.Location = new System.Drawing.Point(473, 86);
            this.EntityPrefixTextbox.Name = "EntityPrefixTextbox";
            this.EntityPrefixTextbox.ReadOnly = true;
            this.EntityPrefixTextbox.Size = new System.Drawing.Size(255, 22);
            this.EntityPrefixTextbox.TabIndex = 39;
            // 
            // EntityTitleLabel
            // 
            this.EntityTitleLabel.AutoSize = true;
            this.EntityTitleLabel.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntityTitleLabel.Location = new System.Drawing.Point(338, 16);
            this.EntityTitleLabel.Name = "EntityTitleLabel";
            this.EntityTitleLabel.Size = new System.Drawing.Size(108, 26);
            this.EntityTitleLabel.TabIndex = 38;
            this.EntityTitleLabel.Text = "Entity Title";
            // 
            // FieldGrid
            // 
            this.FieldGrid.AllowUserToAddRows = false;
            this.FieldGrid.AllowUserToDeleteRows = false;
            this.FieldGrid.AllowUserToOrderColumns = true;
            this.FieldGrid.AllowUserToResizeRows = false;
            this.FieldGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FieldGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FieldObjectNameColumn,
            this.FieldObjectTypeColumn,
            this.FieldObjectNullableColumn,
            this.FieldCodeNameColumn,
            this.FieldCodeDescriptionColumn,
            this.FieldEllipsisColumn});
            this.FieldGrid.Location = new System.Drawing.Point(342, 177);
            this.FieldGrid.MultiSelect = false;
            this.FieldGrid.Name = "FieldGrid";
            this.FieldGrid.RowHeadersVisible = false;
            this.FieldGrid.Size = new System.Drawing.Size(797, 369);
            this.FieldGrid.TabIndex = 37;
            this.FieldGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FieldGrid_CellContentClick);
            this.FieldGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.FieldGrid_CellEndEdit);
            // 
            // FieldObjectNameColumn
            // 
            this.FieldObjectNameColumn.DataPropertyName = "ObjectName";
            this.FieldObjectNameColumn.HeaderText = "Name";
            this.FieldObjectNameColumn.Name = "FieldObjectNameColumn";
            this.FieldObjectNameColumn.ReadOnly = true;
            this.FieldObjectNameColumn.Width = 180;
            // 
            // FieldObjectTypeColumn
            // 
            this.FieldObjectTypeColumn.DataPropertyName = "CodeTypeName";
            this.FieldObjectTypeColumn.HeaderText = "Type";
            this.FieldObjectTypeColumn.Name = "FieldObjectTypeColumn";
            this.FieldObjectTypeColumn.ReadOnly = true;
            this.FieldObjectTypeColumn.Width = 75;
            // 
            // FieldObjectNullableColumn
            // 
            this.FieldObjectNullableColumn.DataPropertyName = "ObjectNull";
            this.FieldObjectNullableColumn.HeaderText = "Null";
            this.FieldObjectNullableColumn.Name = "FieldObjectNullableColumn";
            this.FieldObjectNullableColumn.ReadOnly = true;
            this.FieldObjectNullableColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FieldObjectNullableColumn.Width = 35;
            // 
            // FieldCodeNameColumn
            // 
            this.FieldCodeNameColumn.DataPropertyName = "CodeName";
            this.FieldCodeNameColumn.HeaderText = "Code Name";
            this.FieldCodeNameColumn.Name = "FieldCodeNameColumn";
            this.FieldCodeNameColumn.Width = 120;
            // 
            // FieldCodeDescriptionColumn
            // 
            this.FieldCodeDescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FieldCodeDescriptionColumn.DataPropertyName = "CodeDescription";
            this.FieldCodeDescriptionColumn.HeaderText = "Description";
            this.FieldCodeDescriptionColumn.Name = "FieldCodeDescriptionColumn";
            // 
            // FieldEllipsisColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldEllipsisColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.FieldEllipsisColumn.HeaderText = "";
            this.FieldEllipsisColumn.Name = "FieldEllipsisColumn";
            this.FieldEllipsisColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FieldEllipsisColumn.Text = "…";
            this.FieldEllipsisColumn.UseColumnTextForButtonValue = true;
            this.FieldEllipsisColumn.Width = 24;
            // 
            // EntityDescriptionLabel
            // 
            this.EntityDescriptionLabel.AutoSize = true;
            this.EntityDescriptionLabel.Location = new System.Drawing.Point(340, 145);
            this.EntityDescriptionLabel.Name = "EntityDescriptionLabel";
            this.EntityDescriptionLabel.Size = new System.Drawing.Size(69, 15);
            this.EntityDescriptionLabel.TabIndex = 36;
            this.EntityDescriptionLabel.Text = "Description:";
            // 
            // EntityDescriptionTextbox
            // 
            this.EntityDescriptionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntityDescriptionTextbox.Location = new System.Drawing.Point(473, 142);
            this.EntityDescriptionTextbox.Name = "EntityDescriptionTextbox";
            this.EntityDescriptionTextbox.Size = new System.Drawing.Size(666, 22);
            this.EntityDescriptionTextbox.TabIndex = 35;
            this.EntityDescriptionTextbox.Leave += new System.EventHandler(this.EntityDescriptionTextbox_Leave);
            // 
            // EntityNameLabel
            // 
            this.EntityNameLabel.AutoSize = true;
            this.EntityNameLabel.Location = new System.Drawing.Point(340, 117);
            this.EntityNameLabel.Name = "EntityNameLabel";
            this.EntityNameLabel.Size = new System.Drawing.Size(115, 15);
            this.EntityNameLabel.TabIndex = 34;
            this.EntityNameLabel.Text = "Programmatic Name:";
            // 
            // EntityNameTextbox
            // 
            this.EntityNameTextbox.Location = new System.Drawing.Point(473, 114);
            this.EntityNameTextbox.Name = "EntityNameTextbox";
            this.EntityNameTextbox.Size = new System.Drawing.Size(255, 22);
            this.EntityNameTextbox.TabIndex = 33;
            this.EntityNameTextbox.Leave += new System.EventHandler(this.EntityNameTextbox_Leave);
            // 
            // EntityDomainLabel
            // 
            this.EntityDomainLabel.AutoSize = true;
            this.EntityDomainLabel.Location = new System.Drawing.Point(340, 60);
            this.EntityDomainLabel.Name = "EntityDomainLabel";
            this.EntityDomainLabel.Size = new System.Drawing.Size(69, 15);
            this.EntityDomainLabel.TabIndex = 32;
            this.EntityDomainLabel.Text = "Namespace:";
            // 
            // EntityDomainDropdown
            // 
            this.EntityDomainDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EntityDomainDropdown.FormattingEnabled = true;
            this.EntityDomainDropdown.Location = new System.Drawing.Point(473, 57);
            this.EntityDomainDropdown.Name = "EntityDomainDropdown";
            this.EntityDomainDropdown.Size = new System.Drawing.Size(255, 23);
            this.EntityDomainDropdown.TabIndex = 31;
            this.EntityDomainDropdown.SelectedIndexChanged += new System.EventHandler(this.EntityDomainDropdown_SelectedIndexChanged);
            // 
            // DatabaseDropdown
            // 
            this.DatabaseDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DatabaseDropdown.FormattingEnabled = true;
            this.DatabaseDropdown.Location = new System.Drawing.Point(966, 6);
            this.DatabaseDropdown.Name = "DatabaseDropdown";
            this.DatabaseDropdown.Size = new System.Drawing.Size(204, 23);
            this.DatabaseDropdown.TabIndex = 0;
            this.DatabaseDropdown.SelectedIndexChanged += new System.EventHandler(this.DatabaseDropdown_SelectedIndexChanged);
            // 
            // GeneratorDalButton
            // 
            this.GeneratorDalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GeneratorDalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GeneratorDalButton.Location = new System.Drawing.Point(145, 610);
            this.GeneratorDalButton.Name = "GeneratorDalButton";
            this.GeneratorDalButton.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.GeneratorDalButton.Size = new System.Drawing.Size(127, 28);
            this.GeneratorDalButton.TabIndex = 15;
            this.GeneratorDalButton.Text = "Data Access Layer";
            this.GeneratorDalButton.UseVisualStyleBackColor = true;
            this.GeneratorDalButton.Click += new System.EventHandler(this.GeneratorDalButton_Click);
            // 
            // GeneratorBllButton
            // 
            this.GeneratorBllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GeneratorBllButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GeneratorBllButton.Location = new System.Drawing.Point(278, 610);
            this.GeneratorBllButton.Name = "GeneratorBllButton";
            this.GeneratorBllButton.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.GeneratorBllButton.Size = new System.Drawing.Size(127, 28);
            this.GeneratorBllButton.TabIndex = 16;
            this.GeneratorBllButton.Text = "Business Logic Layer";
            this.GeneratorBllButton.UseVisualStyleBackColor = true;
            this.GeneratorBllButton.Click += new System.EventHandler(this.GeneratorBllButton_Click);
            // 
            // GeneratorSqlButton
            // 
            this.GeneratorSqlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GeneratorSqlButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GeneratorSqlButton.Location = new System.Drawing.Point(12, 610);
            this.GeneratorSqlButton.Name = "GeneratorSqlButton";
            this.GeneratorSqlButton.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.GeneratorSqlButton.Size = new System.Drawing.Size(127, 28);
            this.GeneratorSqlButton.TabIndex = 18;
            this.GeneratorSqlButton.Text = "SQL Entity Scripts";
            this.GeneratorSqlButton.UseVisualStyleBackColor = true;
            this.GeneratorSqlButton.Click += new System.EventHandler(this.GeneratorSqlButton_Click);
            // 
            // EntitySettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 650);
            this.Controls.Add(this.GeneratorSqlButton);
            this.Controls.Add(this.GeneratorBllButton);
            this.Controls.Add(this.GeneratorDalButton);
            this.Controls.Add(this.DatabaseDropdown);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(779, 468);
            this.Name = "EntitySettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Generator";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.MainTabControl.ResumeLayout(false);
            this.GeneratorTab.ResumeLayout(false);
            this.GeneratorContainer.Panel1.ResumeLayout(false);
            this.GeneratorContainer.Panel1.PerformLayout();
            this.GeneratorContainer.Panel2.ResumeLayout(false);
            this.GeneratorContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratorContainer)).EndInit();
            this.GeneratorContainer.ResumeLayout(false);
            this.GeneratorGroup.ResumeLayout(false);
            this.GeneratorGroup.PerformLayout();
            this.EntityTab.ResumeLayout(false);
            this.EntityTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FieldGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage EntityTab;
        private System.Windows.Forms.ComboBox DatabaseDropdown;
        private System.Windows.Forms.Label EntityDomainLabel;
        private System.Windows.Forms.ComboBox EntityDomainDropdown;
        private System.Windows.Forms.Label EntityNameLabel;
        private System.Windows.Forms.TextBox EntityNameTextbox;
        private System.Windows.Forms.Label EntityDescriptionLabel;
        private System.Windows.Forms.TextBox EntityDescriptionTextbox;
        private System.Windows.Forms.DataGridView FieldGrid;
        private System.Windows.Forms.Label EntityTitleLabel;
        private System.Windows.Forms.Label EntityPrefixLabel;
        private System.Windows.Forms.TextBox EntityPrefixTextbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldObjectNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldObjectTypeColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FieldObjectNullableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldCodeNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldCodeDescriptionColumn;
        private System.Windows.Forms.DataGridViewButtonColumn FieldEllipsisColumn;
        private System.Windows.Forms.TextBox DomainNameTextbox;
        private System.Windows.Forms.Button DomainAddButton;
        private System.Windows.Forms.TreeView DomainTree;
        private System.Windows.Forms.Button DomainRemoveButton;
        private System.Windows.Forms.TabPage GeneratorTab;
        private System.Windows.Forms.Button GeneratorDalButton;
        private System.Windows.Forms.CheckBox EntityAllowRemove;
        private System.Windows.Forms.CheckBox EntityAllowModify;
        private System.Windows.Forms.CheckBox EntityAllowCreate;
        private System.Windows.Forms.Button GeneratorBllButton;
        private System.Windows.Forms.Button GeneratorSqlButton;
        private System.Windows.Forms.SplitContainer GeneratorContainer;
        private System.Windows.Forms.GroupBox GeneratorGroup;
        private System.Windows.Forms.TextBox GeneratorSolutionDirectoryTextbox;
        private System.Windows.Forms.Label GeneratorSolutionDirectoryLabel;
        private System.Windows.Forms.TextBox GeneratorSolutionVersionTextbox;
        private System.Windows.Forms.Label GeneratorSolutionVersionLabel;
        private System.Windows.Forms.Label GeneratorSolutionNameLabel;
        private System.Windows.Forms.TextBox GeneratorSolutionNameTextbox;
        private System.Windows.Forms.CheckBox GenerateBaseCheckbox;
        private System.Windows.Forms.TextBox GeneratorConsole;
        private System.Windows.Forms.TextBox GeneratorLog;
        private System.Windows.Forms.Panel GeneratorSpacer;
    }
}