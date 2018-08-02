namespace CodeGenerator
{
    partial class FieldSettings
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
            this.FieldNameLabel = new System.Windows.Forms.Label();
            this.FieldNameTextbox = new System.Windows.Forms.TextBox();
            this.RelatedEntityDropdown = new System.Windows.Forms.ComboBox();
            this.RelatedEntityLabel = new System.Windows.Forms.Label();
            this.RelatedFieldLabel = new System.Windows.Forms.Label();
            this.RelatedFieldTextbox = new System.Windows.Forms.TextBox();
            this.ExposureDropdown = new System.Windows.Forms.ComboBox();
            this.ExposureLabel = new System.Windows.Forms.Label();
            this.OkayButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RelatedFieldDropdown = new System.Windows.Forms.ComboBox();
            this.IsUniqueLabel = new System.Windows.Forms.Label();
            this.IsUniqueCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FieldNameLabel
            // 
            this.FieldNameLabel.AutoSize = true;
            this.FieldNameLabel.Location = new System.Drawing.Point(12, 15);
            this.FieldNameLabel.Name = "FieldNameLabel";
            this.FieldNameLabel.Size = new System.Drawing.Size(91, 15);
            this.FieldNameLabel.TabIndex = 42;
            this.FieldNameLabel.Text = "Database Prefix:";
            // 
            // FieldNameTextbox
            // 
            this.FieldNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldNameTextbox.BackColor = System.Drawing.Color.White;
            this.FieldNameTextbox.ForeColor = System.Drawing.Color.Gray;
            this.FieldNameTextbox.Location = new System.Drawing.Point(125, 12);
            this.FieldNameTextbox.Name = "FieldNameTextbox";
            this.FieldNameTextbox.ReadOnly = true;
            this.FieldNameTextbox.Size = new System.Drawing.Size(224, 22);
            this.FieldNameTextbox.TabIndex = 41;
            // 
            // RelatedEntityDropdown
            // 
            this.RelatedEntityDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RelatedEntityDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RelatedEntityDropdown.Enabled = false;
            this.RelatedEntityDropdown.FormattingEnabled = true;
            this.RelatedEntityDropdown.Location = new System.Drawing.Point(125, 69);
            this.RelatedEntityDropdown.Name = "RelatedEntityDropdown";
            this.RelatedEntityDropdown.Size = new System.Drawing.Size(224, 23);
            this.RelatedEntityDropdown.TabIndex = 48;
            this.RelatedEntityDropdown.SelectedIndexChanged += new System.EventHandler(this.RelationshipDropdown_SelectedIndexChanged);
            // 
            // RelatedEntityLabel
            // 
            this.RelatedEntityLabel.AutoSize = true;
            this.RelatedEntityLabel.Location = new System.Drawing.Point(12, 72);
            this.RelatedEntityLabel.Name = "RelatedEntityLabel";
            this.RelatedEntityLabel.Size = new System.Drawing.Size(61, 15);
            this.RelatedEntityLabel.TabIndex = 49;
            this.RelatedEntityLabel.Text = "Relates to:";
            // 
            // RelatedFieldLabel
            // 
            this.RelatedFieldLabel.AutoSize = true;
            this.RelatedFieldLabel.Location = new System.Drawing.Point(12, 101);
            this.RelatedFieldLabel.Name = "RelatedFieldLabel";
            this.RelatedFieldLabel.Size = new System.Drawing.Size(77, 15);
            this.RelatedFieldLabel.TabIndex = 50;
            this.RelatedFieldLabel.Text = "Related Field:";
            this.RelatedFieldLabel.Visible = false;
            // 
            // RelatedFieldTextbox
            // 
            this.RelatedFieldTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RelatedFieldTextbox.BackColor = System.Drawing.Color.White;
            this.RelatedFieldTextbox.ForeColor = System.Drawing.Color.Black;
            this.RelatedFieldTextbox.Location = new System.Drawing.Point(125, 98);
            this.RelatedFieldTextbox.Name = "RelatedFieldTextbox";
            this.RelatedFieldTextbox.Size = new System.Drawing.Size(224, 22);
            this.RelatedFieldTextbox.TabIndex = 51;
            this.RelatedFieldTextbox.Visible = false;
            // 
            // ExposureDropdown
            // 
            this.ExposureDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExposureDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExposureDropdown.FormattingEnabled = true;
            this.ExposureDropdown.Items.AddRange(new object[] {
            "Excluded",
            "Read Only",
            "Write Only",
            "Included"});
            this.ExposureDropdown.Location = new System.Drawing.Point(125, 40);
            this.ExposureDropdown.Name = "ExposureDropdown";
            this.ExposureDropdown.Size = new System.Drawing.Size(224, 23);
            this.ExposureDropdown.TabIndex = 55;
            this.ExposureDropdown.SelectedIndexChanged += new System.EventHandler(this.ExposureDropdown_SelectedIndexChanged);
            // 
            // ExposureLabel
            // 
            this.ExposureLabel.AutoSize = true;
            this.ExposureLabel.Location = new System.Drawing.Point(12, 43);
            this.ExposureLabel.Name = "ExposureLabel";
            this.ExposureLabel.Size = new System.Drawing.Size(58, 15);
            this.ExposureLabel.TabIndex = 54;
            this.ExposureLabel.Text = "Exposure:";
            // 
            // OkayButton
            // 
            this.OkayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkayButton.Location = new System.Drawing.Point(294, 129);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(55, 24);
            this.OkayButton.TabIndex = 56;
            this.OkayButton.Text = "OK";
            this.OkayButton.UseVisualStyleBackColor = true;
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(233, 129);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(55, 24);
            this.CancelButton.TabIndex = 57;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RelatedFieldDropdown
            // 
            this.RelatedFieldDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RelatedFieldDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RelatedFieldDropdown.FormattingEnabled = true;
            this.RelatedFieldDropdown.Location = new System.Drawing.Point(125, 98);
            this.RelatedFieldDropdown.Name = "RelatedFieldDropdown";
            this.RelatedFieldDropdown.Size = new System.Drawing.Size(224, 23);
            this.RelatedFieldDropdown.TabIndex = 58;
            this.RelatedFieldDropdown.Visible = false;
            // 
            // IsUniqueLabel
            // 
            this.IsUniqueLabel.AutoSize = true;
            this.IsUniqueLabel.Location = new System.Drawing.Point(12, 132);
            this.IsUniqueLabel.Name = "IsUniqueLabel";
            this.IsUniqueLabel.Size = new System.Drawing.Size(59, 15);
            this.IsUniqueLabel.TabIndex = 59;
            this.IsUniqueLabel.Text = "Is Unique:";
            this.IsUniqueLabel.Visible = false;
            // 
            // IsUniqueCheckbox
            // 
            this.IsUniqueCheckbox.AutoSize = true;
            this.IsUniqueCheckbox.Location = new System.Drawing.Point(125, 133);
            this.IsUniqueCheckbox.Name = "IsUniqueCheckbox";
            this.IsUniqueCheckbox.Size = new System.Drawing.Size(15, 14);
            this.IsUniqueCheckbox.TabIndex = 60;
            this.IsUniqueCheckbox.UseVisualStyleBackColor = true;
            // 
            // FieldSettings
            // 
            this.AcceptButton = this.OkayButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(361, 165);
            this.ControlBox = false;
            this.Controls.Add(this.IsUniqueCheckbox);
            this.Controls.Add(this.IsUniqueLabel);
            this.Controls.Add(this.RelatedFieldDropdown);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.ExposureDropdown);
            this.Controls.Add(this.ExposureLabel);
            this.Controls.Add(this.RelatedFieldTextbox);
            this.Controls.Add(this.RelatedFieldLabel);
            this.Controls.Add(this.RelatedEntityLabel);
            this.Controls.Add(this.RelatedEntityDropdown);
            this.Controls.Add(this.FieldNameLabel);
            this.Controls.Add(this.FieldNameTextbox);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FieldSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FieldSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FieldNameLabel;
        private System.Windows.Forms.Label RelatedEntityLabel;
        private System.Windows.Forms.Label RelatedFieldLabel;
        private System.Windows.Forms.Label ExposureLabel;
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.TextBox FieldNameTextbox;
        public System.Windows.Forms.ComboBox RelatedEntityDropdown;
        public System.Windows.Forms.TextBox RelatedFieldTextbox;
        public System.Windows.Forms.ComboBox ExposureDropdown;
        public System.Windows.Forms.ComboBox RelatedFieldDropdown;
        private System.Windows.Forms.Label IsUniqueLabel;
        public System.Windows.Forms.CheckBox IsUniqueCheckbox;
    }
}