namespace Consensus.CodeGenerator
{
    partial class AttributeEditor
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
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EntityDropdown = new System.Windows.Forms.ComboBox();
            this.EntityLabel = new System.Windows.Forms.Label();
            this.ColumnTextbox = new System.Windows.Forms.TextBox();
            this.ColumnLabel = new System.Windows.Forms.Label();
            this.InternalTextbox = new System.Windows.Forms.TextBox();
            this.InternalLabel = new System.Windows.Forms.Label();
            this.CodeTextbox = new System.Windows.Forms.TextBox();
            this.RelatedNameTextbox = new System.Windows.Forms.TextBox();
            this.RelatedNameLabel = new System.Windows.Forms.Label();
            this.SerialiserCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 99);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(69, 13);
            this.DescriptionLabel.TabIndex = 10019;
            this.DescriptionLabel.Text = "Description:";
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextbox.Location = new System.Drawing.Point(100, 96);
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.Size = new System.Drawing.Size(472, 22);
            this.DescriptionTextbox.TabIndex = 3;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextbox.Location = new System.Drawing.Point(100, 68);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(472, 22);
            this.NameTextbox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 71);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 13);
            this.NameLabel.TabIndex = 10018;
            this.NameLabel.Text = "Name:";
            // 
            // EntityDropdown
            // 
            this.EntityDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntityDropdown.FormattingEnabled = true;
            this.EntityDropdown.Location = new System.Drawing.Point(100, 124);
            this.EntityDropdown.Name = "EntityDropdown";
            this.EntityDropdown.Size = new System.Drawing.Size(310, 21);
            this.EntityDropdown.TabIndex = 4;
            this.EntityDropdown.SelectedIndexChanged += new System.EventHandler(this.EntityDropdown_SelectedIndexChanged);
            // 
            // EntityLabel
            // 
            this.EntityLabel.AutoSize = true;
            this.EntityLabel.Location = new System.Drawing.Point(12, 127);
            this.EntityLabel.Name = "EntityLabel";
            this.EntityLabel.Size = new System.Drawing.Size(62, 13);
            this.EntityLabel.TabIndex = 10021;
            this.EntityLabel.Text = "Relates To:";
            // 
            // ColumnTextbox
            // 
            this.ColumnTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnTextbox.BackColor = System.Drawing.Color.White;
            this.ColumnTextbox.Location = new System.Drawing.Point(100, 12);
            this.ColumnTextbox.Name = "ColumnTextbox";
            this.ColumnTextbox.ReadOnly = true;
            this.ColumnTextbox.Size = new System.Drawing.Size(472, 22);
            this.ColumnTextbox.TabIndex = 0;
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.AutoSize = true;
            this.ColumnLabel.Location = new System.Drawing.Point(12, 15);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(50, 13);
            this.ColumnLabel.TabIndex = 10023;
            this.ColumnLabel.Text = "Column:";
            // 
            // InternalTextbox
            // 
            this.InternalTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InternalTextbox.Location = new System.Drawing.Point(100, 40);
            this.InternalTextbox.Name = "InternalTextbox";
            this.InternalTextbox.Size = new System.Drawing.Size(472, 22);
            this.InternalTextbox.TabIndex = 1;
            // 
            // InternalLabel
            // 
            this.InternalLabel.AutoSize = true;
            this.InternalLabel.Location = new System.Drawing.Point(12, 43);
            this.InternalLabel.Name = "InternalLabel";
            this.InternalLabel.Size = new System.Drawing.Size(82, 13);
            this.InternalLabel.TabIndex = 10025;
            this.InternalLabel.Text = "Internal Name:";
            // 
            // CodeTextbox
            // 
            this.CodeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeTextbox.Enabled = false;
            this.CodeTextbox.Location = new System.Drawing.Point(416, 123);
            this.CodeTextbox.Name = "CodeTextbox";
            this.CodeTextbox.Size = new System.Drawing.Size(156, 22);
            this.CodeTextbox.TabIndex = 5;
            // 
            // RelatedNameTextbox
            // 
            this.RelatedNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RelatedNameTextbox.Enabled = false;
            this.RelatedNameTextbox.Location = new System.Drawing.Point(100, 151);
            this.RelatedNameTextbox.Name = "RelatedNameTextbox";
            this.RelatedNameTextbox.Size = new System.Drawing.Size(472, 22);
            this.RelatedNameTextbox.TabIndex = 10026;
            // 
            // RelatedNameLabel
            // 
            this.RelatedNameLabel.AutoSize = true;
            this.RelatedNameLabel.Location = new System.Drawing.Point(12, 154);
            this.RelatedNameLabel.Name = "RelatedNameLabel";
            this.RelatedNameLabel.Size = new System.Drawing.Size(81, 13);
            this.RelatedNameLabel.TabIndex = 10027;
            this.RelatedNameLabel.Text = "Related Name:";
            // 
            // SerialiserCheckbox
            // 
            this.SerialiserCheckbox.AutoSize = true;
            this.SerialiserCheckbox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SerialiserCheckbox.Location = new System.Drawing.Point(100, 175);
            this.SerialiserCheckbox.Name = "SerialiserCheckbox";
            this.SerialiserCheckbox.Size = new System.Drawing.Size(366, 17);
            this.SerialiserCheckbox.TabIndex = 10029;
            this.SerialiserCheckbox.Text = "Exclude the collection property when serializing the related object";
            this.SerialiserCheckbox.UseVisualStyleBackColor = true;
            // 
            // AttributeEditor
            // 
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.SerialiserCheckbox);
            this.Controls.Add(this.RelatedNameLabel);
            this.Controls.Add(this.RelatedNameTextbox);
            this.Controls.Add(this.CodeTextbox);
            this.Controls.Add(this.InternalTextbox);
            this.Controls.Add(this.InternalLabel);
            this.Controls.Add(this.ColumnTextbox);
            this.Controls.Add(this.ColumnLabel);
            this.Controls.Add(this.EntityLabel);
            this.Controls.Add(this.EntityDropdown);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.NameLabel);
            this.Name = "AttributeEditor";
            this.Text = "Property";
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.NameTextbox, 0);
            this.Controls.SetChildIndex(this.DescriptionTextbox, 0);
            this.Controls.SetChildIndex(this.DescriptionLabel, 0);
            this.Controls.SetChildIndex(this.EntityDropdown, 0);
            this.Controls.SetChildIndex(this.EntityLabel, 0);
            this.Controls.SetChildIndex(this.ColumnLabel, 0);
            this.Controls.SetChildIndex(this.ColumnTextbox, 0);
            this.Controls.SetChildIndex(this.InternalLabel, 0);
            this.Controls.SetChildIndex(this.InternalTextbox, 0);
            this.Controls.SetChildIndex(this.CodeTextbox, 0);
            this.Controls.SetChildIndex(this.RelatedNameTextbox, 0);
            this.Controls.SetChildIndex(this.RelatedNameLabel, 0);
            this.Controls.SetChildIndex(this.SerialiserCheckbox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox EntityDropdown;
        private System.Windows.Forms.Label EntityLabel;
        private System.Windows.Forms.TextBox ColumnTextbox;
        private System.Windows.Forms.Label ColumnLabel;
        private System.Windows.Forms.TextBox InternalTextbox;
        private System.Windows.Forms.Label InternalLabel;
        private System.Windows.Forms.TextBox CodeTextbox;
        private System.Windows.Forms.TextBox RelatedNameTextbox;
        private System.Windows.Forms.Label RelatedNameLabel;
        private System.Windows.Forms.CheckBox SerialiserCheckbox;
    }
}