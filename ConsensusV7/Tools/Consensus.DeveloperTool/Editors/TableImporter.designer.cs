namespace Consensus.CodeGenerator
{
    partial class TableImporter
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
            this.DataSourceLabel = new System.Windows.Forms.Label();
            this.DataSourceDropdown = new System.Windows.Forms.ComboBox();
            this.TableDropdown = new System.Windows.Forms.ComboBox();
            this.TableLabel = new System.Windows.Forms.Label();
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DataSourceLabel
            // 
            this.DataSourceLabel.AutoSize = true;
            this.DataSourceLabel.Location = new System.Drawing.Point(12, 15);
            this.DataSourceLabel.Name = "DataSourceLabel";
            this.DataSourceLabel.Size = new System.Drawing.Size(72, 13);
            this.DataSourceLabel.TabIndex = 10001;
            this.DataSourceLabel.Text = "Data Source:";
            // 
            // DataSourceDropdown
            // 
            this.DataSourceDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataSourceDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataSourceDropdown.FormattingEnabled = true;
            this.DataSourceDropdown.Location = new System.Drawing.Point(96, 12);
            this.DataSourceDropdown.Name = "DataSourceDropdown";
            this.DataSourceDropdown.Size = new System.Drawing.Size(476, 21);
            this.DataSourceDropdown.TabIndex = 10000;
            this.DataSourceDropdown.SelectedIndexChanged += new System.EventHandler(this.DataSourceDropdown_SelectedIndexChanged);
            // 
            // TableDropdown
            // 
            this.TableDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableDropdown.FormattingEnabled = true;
            this.TableDropdown.Location = new System.Drawing.Point(96, 39);
            this.TableDropdown.Name = "TableDropdown";
            this.TableDropdown.Size = new System.Drawing.Size(476, 21);
            this.TableDropdown.TabIndex = 10002;
            this.TableDropdown.Leave += new System.EventHandler(this.TableDropdown_Leave);
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Location = new System.Drawing.Point(12, 42);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(37, 13);
            this.TableLabel.TabIndex = 10003;
            this.TableLabel.Text = "Table:";
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextbox.Location = new System.Drawing.Point(96, 66);
            this.DescriptionTextbox.Multiline = true;
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.Size = new System.Drawing.Size(476, 154);
            this.DescriptionTextbox.TabIndex = 10004;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 69);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(69, 13);
            this.DescriptionLabel.TabIndex = 10005;
            this.DescriptionLabel.Text = "Description:";
            // 
            // TableImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionTextbox);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.TableDropdown);
            this.Controls.Add(this.DataSourceLabel);
            this.Controls.Add(this.DataSourceDropdown);
            this.Name = "TableImporter";
            this.Text = "Import Table";
            this.Controls.SetChildIndex(this.DataSourceDropdown, 0);
            this.Controls.SetChildIndex(this.DataSourceLabel, 0);
            this.Controls.SetChildIndex(this.TableDropdown, 0);
            this.Controls.SetChildIndex(this.TableLabel, 0);
            this.Controls.SetChildIndex(this.DescriptionTextbox, 0);
            this.Controls.SetChildIndex(this.DescriptionLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DataSourceLabel;
        private System.Windows.Forms.ComboBox DataSourceDropdown;
        private System.Windows.Forms.ComboBox TableDropdown;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.TextBox DescriptionTextbox;
        private System.Windows.Forms.Label DescriptionLabel;
    }
}