namespace Consensus.CodeGenerator
{
    partial class IndexEditor
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.DetailTab = new System.Windows.Forms.TabPage();
            this.UniqueCheckbox = new System.Windows.Forms.CheckBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ColumnTab = new System.Windows.Forms.TabPage();
            this.ColumnGrid = new System.Windows.Forms.DataGridView();
            this.MainTabControl.SuspendLayout();
            this.DetailTab.SuspendLayout();
            this.ColumnTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.DetailTab);
            this.MainTabControl.Controls.Add(this.ColumnTab);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(560, 208);
            this.MainTabControl.TabIndex = 10000;
            // 
            // DetailTab
            // 
            this.DetailTab.Controls.Add(this.UniqueCheckbox);
            this.DetailTab.Controls.Add(this.DescriptionLabel);
            this.DetailTab.Controls.Add(this.DescriptionTextbox);
            this.DetailTab.Controls.Add(this.NameTextbox);
            this.DetailTab.Controls.Add(this.NameLabel);
            this.DetailTab.Location = new System.Drawing.Point(4, 22);
            this.DetailTab.Name = "DetailTab";
            this.DetailTab.Padding = new System.Windows.Forms.Padding(10);
            this.DetailTab.Size = new System.Drawing.Size(552, 182);
            this.DetailTab.TabIndex = 0;
            this.DetailTab.Text = "Details";
            this.DetailTab.UseVisualStyleBackColor = true;
            // 
            // UniqueCheckbox
            // 
            this.UniqueCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UniqueCheckbox.AutoSize = true;
            this.UniqueCheckbox.Location = new System.Drawing.Point(13, 152);
            this.UniqueCheckbox.Name = "UniqueCheckbox";
            this.UniqueCheckbox.Size = new System.Drawing.Size(95, 17);
            this.UniqueCheckbox.TabIndex = 10013;
            this.UniqueCheckbox.Text = "Unique Index";
            this.UniqueCheckbox.UseVisualStyleBackColor = true;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(10, 44);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(69, 13);
            this.DescriptionLabel.TabIndex = 10015;
            this.DescriptionLabel.Text = "Description:";
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextbox.Location = new System.Drawing.Point(88, 41);
            this.DescriptionTextbox.Multiline = true;
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.Size = new System.Drawing.Size(451, 97);
            this.DescriptionTextbox.TabIndex = 10012;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextbox.Location = new System.Drawing.Point(88, 13);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(451, 22);
            this.NameTextbox.TabIndex = 10011;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(10, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 13);
            this.NameLabel.TabIndex = 10014;
            this.NameLabel.Text = "Name:";
            // 
            // ColumnTab
            // 
            this.ColumnTab.Controls.Add(this.ColumnGrid);
            this.ColumnTab.Location = new System.Drawing.Point(4, 22);
            this.ColumnTab.Name = "ColumnTab";
            this.ColumnTab.Padding = new System.Windows.Forms.Padding(1);
            this.ColumnTab.Size = new System.Drawing.Size(552, 182);
            this.ColumnTab.TabIndex = 1;
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
            this.ColumnGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnGrid.Location = new System.Drawing.Point(1, 1);
            this.ColumnGrid.Name = "ColumnGrid";
            this.ColumnGrid.ReadOnly = true;
            this.ColumnGrid.RowHeadersVisible = false;
            this.ColumnGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ColumnGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ColumnGrid.Size = new System.Drawing.Size(550, 180);
            this.ColumnGrid.TabIndex = 2;
            // 
            // IndexEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.MainTabControl);
            this.Name = "IndexEditor";
            this.Text = "Index";
            this.Controls.SetChildIndex(this.MainTabControl, 0);
            this.MainTabControl.ResumeLayout(false);
            this.DetailTab.ResumeLayout(false);
            this.DetailTab.PerformLayout();
            this.ColumnTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColumnGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage DetailTab;
        private System.Windows.Forms.CheckBox UniqueCheckbox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TabPage ColumnTab;
        private System.Windows.Forms.DataGridView ColumnGrid;
    }
}