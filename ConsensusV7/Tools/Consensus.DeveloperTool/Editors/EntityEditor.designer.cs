namespace Consensus.CodeGenerator
{
    partial class EntityEditor
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.DetailTab = new System.Windows.Forms.TabPage();
            this.OptionTab = new System.Windows.Forms.TabPage();
            this.AbstractCheckbox = new System.Windows.Forms.CheckBox();
            this.FilterTypeDropdown = new System.Windows.Forms.ComboBox();
            this.FilterTextbox = new System.Windows.Forms.TextBox();
            this.FilterDropdown = new System.Windows.Forms.ComboBox();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.ContainerLabel = new System.Windows.Forms.Label();
            this.ContainerDropdown = new System.Windows.Forms.ComboBox();
            this.InheritenceLabel = new System.Windows.Forms.Label();
            this.InheritenceDropdown = new System.Windows.Forms.ComboBox();
            this.TableLabel = new System.Windows.Forms.Label();
            this.TableDropdown = new System.Windows.Forms.ComboBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CreateCheckbox = new System.Windows.Forms.CheckBox();
            this.ModifyCheckbox = new System.Windows.Forms.CheckBox();
            this.RemoveCheckbox = new System.Windows.Forms.CheckBox();
            this.TabControl.SuspendLayout();
            this.DetailTab.SuspendLayout();
            this.OptionTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.DetailTab);
            this.TabControl.Controls.Add(this.OptionTab);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(560, 208);
            this.TabControl.TabIndex = 10012;
            // 
            // DetailTab
            // 
            this.DetailTab.Controls.Add(this.FilterTypeDropdown);
            this.DetailTab.Controls.Add(this.FilterTextbox);
            this.DetailTab.Controls.Add(this.FilterDropdown);
            this.DetailTab.Controls.Add(this.FilterLabel);
            this.DetailTab.Controls.Add(this.ContainerLabel);
            this.DetailTab.Controls.Add(this.ContainerDropdown);
            this.DetailTab.Controls.Add(this.InheritenceLabel);
            this.DetailTab.Controls.Add(this.InheritenceDropdown);
            this.DetailTab.Controls.Add(this.TableLabel);
            this.DetailTab.Controls.Add(this.TableDropdown);
            this.DetailTab.Controls.Add(this.DescriptionLabel);
            this.DetailTab.Controls.Add(this.DescriptionTextbox);
            this.DetailTab.Controls.Add(this.NameTextbox);
            this.DetailTab.Controls.Add(this.NameLabel);
            this.DetailTab.Location = new System.Drawing.Point(4, 22);
            this.DetailTab.Name = "DetailTab";
            this.DetailTab.Padding = new System.Windows.Forms.Padding(10);
            this.DetailTab.Size = new System.Drawing.Size(552, 182);
            this.DetailTab.TabIndex = 0;
            this.DetailTab.Text = "Detail";
            this.DetailTab.UseVisualStyleBackColor = true;
            // 
            // OptionTab
            // 
            this.OptionTab.Controls.Add(this.RemoveCheckbox);
            this.OptionTab.Controls.Add(this.ModifyCheckbox);
            this.OptionTab.Controls.Add(this.CreateCheckbox);
            this.OptionTab.Controls.Add(this.AbstractCheckbox);
            this.OptionTab.Location = new System.Drawing.Point(4, 22);
            this.OptionTab.Name = "OptionTab";
            this.OptionTab.Padding = new System.Windows.Forms.Padding(10);
            this.OptionTab.Size = new System.Drawing.Size(552, 182);
            this.OptionTab.TabIndex = 1;
            this.OptionTab.Text = "Options";
            this.OptionTab.UseVisualStyleBackColor = true;
            // 
            // AbstractCheckbox
            // 
            this.AbstractCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AbstractCheckbox.AutoSize = true;
            this.AbstractCheckbox.Location = new System.Drawing.Point(13, 13);
            this.AbstractCheckbox.Name = "AbstractCheckbox";
            this.AbstractCheckbox.Size = new System.Drawing.Size(104, 17);
            this.AbstractCheckbox.TabIndex = 10013;
            this.AbstractCheckbox.Text = "Abstract Model";
            this.AbstractCheckbox.UseVisualStyleBackColor = true;
            // 
            // FilterTypeDropdown
            // 
            this.FilterTypeDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilterTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterTypeDropdown.FormattingEnabled = true;
            this.FilterTypeDropdown.Location = new System.Drawing.Point(329, 147);
            this.FilterTypeDropdown.Name = "FilterTypeDropdown";
            this.FilterTypeDropdown.Size = new System.Drawing.Size(61, 21);
            this.FilterTypeDropdown.TabIndex = 10039;
            // 
            // FilterTextbox
            // 
            this.FilterTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTextbox.Enabled = false;
            this.FilterTextbox.Location = new System.Drawing.Point(396, 147);
            this.FilterTextbox.Name = "FilterTextbox";
            this.FilterTextbox.Size = new System.Drawing.Size(143, 22);
            this.FilterTextbox.TabIndex = 10032;
            // 
            // FilterDropdown
            // 
            this.FilterDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilterDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterDropdown.FormattingEnabled = true;
            this.FilterDropdown.Location = new System.Drawing.Point(94, 147);
            this.FilterDropdown.Name = "FilterDropdown";
            this.FilterDropdown.Size = new System.Drawing.Size(229, 21);
            this.FilterDropdown.TabIndex = 10031;
			this.FilterDropdown.SelectedIndexChanged += this.FilterDropdown_SelectedIndexChanged;
            // 
            // FilterLabel
            // 
            this.FilterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(13, 150);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(36, 13);
            this.FilterLabel.TabIndex = 10038;
            this.FilterLabel.Text = "Filter:";
            // 
            // ContainerLabel
            // 
            this.ContainerLabel.AutoSize = true;
            this.ContainerLabel.Location = new System.Drawing.Point(13, 16);
            this.ContainerLabel.Name = "ContainerLabel";
            this.ContainerLabel.Size = new System.Drawing.Size(61, 13);
            this.ContainerLabel.TabIndex = 10037;
            this.ContainerLabel.Text = "Container:";
            // 
            // ContainerDropdown
            // 
            this.ContainerDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContainerDropdown.FormattingEnabled = true;
            this.ContainerDropdown.Location = new System.Drawing.Point(94, 13);
            this.ContainerDropdown.Name = "ContainerDropdown";
            this.ContainerDropdown.Size = new System.Drawing.Size(229, 21);
            this.ContainerDropdown.TabIndex = 10026;
            // 
            // InheritenceLabel
            // 
            this.InheritenceLabel.AutoSize = true;
            this.InheritenceLabel.Location = new System.Drawing.Point(341, 16);
            this.InheritenceLabel.Name = "InheritenceLabel";
            this.InheritenceLabel.Size = new System.Drawing.Size(49, 13);
            this.InheritenceLabel.TabIndex = 10036;
            this.InheritenceLabel.Text = "Inherits:";
            // 
            // InheritenceDropdown
            // 
            this.InheritenceDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InheritenceDropdown.FormattingEnabled = true;
            this.InheritenceDropdown.Location = new System.Drawing.Point(396, 13);
            this.InheritenceDropdown.Name = "InheritenceDropdown";
            this.InheritenceDropdown.Size = new System.Drawing.Size(143, 21);
            this.InheritenceDropdown.TabIndex = 10028;
			this.InheritenceDropdown.Leave += this.InheritenceDropdown_Leave;
			this.InheritenceDropdown.SelectedIndexChanged += this.InheritenceDropdown_SelectedIndexChanged;
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Location = new System.Drawing.Point(341, 43);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(37, 13);
            this.TableLabel.TabIndex = 10035;
            this.TableLabel.Text = "Table:";
            // 
            // TableDropdown
            // 
            this.TableDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableDropdown.FormattingEnabled = true;
            this.TableDropdown.Location = new System.Drawing.Point(396, 40);
            this.TableDropdown.Name = "TableDropdown";
            this.TableDropdown.Size = new System.Drawing.Size(143, 21);
            this.TableDropdown.TabIndex = 10029;
			this.TableDropdown.SelectedIndexChanged += this.TableDropdown_SelectedIndexChanged;
			this.TableDropdown.Leave += this.TableDropdown_Leave;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(13, 71);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(69, 13);
            this.DescriptionLabel.TabIndex = 10034;
            this.DescriptionLabel.Text = "Description:";
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextbox.Location = new System.Drawing.Point(94, 68);
            this.DescriptionTextbox.Multiline = true;
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.Size = new System.Drawing.Size(445, 73);
            this.DescriptionTextbox.TabIndex = 10030;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(94, 40);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(229, 22);
            this.NameTextbox.TabIndex = 10027;
			this.NameTextbox.TextChanged += this.NameTextbox_TextChanged;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 43);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 13);
            this.NameLabel.TabIndex = 10033;
            this.NameLabel.Text = "Name:";
            // 
            // CreateCheckbox
            // 
            this.CreateCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateCheckbox.AutoSize = true;
            this.CreateCheckbox.Location = new System.Drawing.Point(13, 36);
            this.CreateCheckbox.Name = "CreateCheckbox";
            this.CreateCheckbox.Size = new System.Drawing.Size(109, 17);
            this.CreateCheckbox.TabIndex = 10014;
            this.CreateCheckbox.Text = "Expose Creation";
            this.CreateCheckbox.UseVisualStyleBackColor = true;
            // 
            // ModifyCheckbox
            // 
            this.ModifyCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ModifyCheckbox.AutoSize = true;
            this.ModifyCheckbox.Location = new System.Drawing.Point(13, 59);
            this.ModifyCheckbox.Name = "ModifyCheckbox";
            this.ModifyCheckbox.Size = new System.Drawing.Size(131, 17);
            this.ModifyCheckbox.TabIndex = 10015;
            this.ModifyCheckbox.Text = "Expose Modification";
            this.ModifyCheckbox.UseVisualStyleBackColor = true;
            // 
            // RemoveCheckbox
            // 
            this.RemoveCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveCheckbox.AutoSize = true;
            this.RemoveCheckbox.Location = new System.Drawing.Point(13, 82);
            this.RemoveCheckbox.Name = "RemoveCheckbox";
            this.RemoveCheckbox.Size = new System.Drawing.Size(108, 17);
            this.RemoveCheckbox.TabIndex = 10016;
            this.RemoveCheckbox.Text = "Expose Removal";
            this.RemoveCheckbox.UseVisualStyleBackColor = true;
            // 
            // EntityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.TabControl);
            this.Name = "EntityEditor";
            this.Text = "Model";
            this.Controls.SetChildIndex(this.TabControl, 0);
            this.TabControl.ResumeLayout(false);
            this.DetailTab.ResumeLayout(false);
            this.DetailTab.PerformLayout();
            this.OptionTab.ResumeLayout(false);
            this.OptionTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage DetailTab;
        private System.Windows.Forms.ComboBox FilterTypeDropdown;
        private System.Windows.Forms.TextBox FilterTextbox;
        private System.Windows.Forms.ComboBox FilterDropdown;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Label ContainerLabel;
        private System.Windows.Forms.ComboBox ContainerDropdown;
        private System.Windows.Forms.Label InheritenceLabel;
        private System.Windows.Forms.ComboBox InheritenceDropdown;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.ComboBox TableDropdown;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TabPage OptionTab;
        private System.Windows.Forms.CheckBox RemoveCheckbox;
        private System.Windows.Forms.CheckBox ModifyCheckbox;
        private System.Windows.Forms.CheckBox CreateCheckbox;
        private System.Windows.Forms.CheckBox AbstractCheckbox;



    }
}