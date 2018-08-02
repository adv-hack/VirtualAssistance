using CodeGenerator.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class FieldSettings : Form
    {
        public Type FieldType;

        public FieldSettings()
        {
            this.InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OkayButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ExposureDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RelatedEntityDropdown.Enabled = this.ExposureDropdown.SelectedIndex > 0;
        }

        private void RelationshipDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataEntity entity = this.RelatedEntityDropdown.SelectedItem as DataEntity;
            if (entity == null)
            {
                this.RelatedFieldDropdown.Visible = false;
                this.RelatedFieldTextbox.Visible = false;
                this.RelatedFieldLabel.Visible = false;
            }
            else if (String.Equals(entity.ObjectName, "Code", StringComparison.OrdinalIgnoreCase))
            {
                this.RelatedFieldDropdown.Visible = false;
                this.RelatedFieldTextbox.Visible = true;
                this.RelatedFieldLabel.Visible = true;
                this.RelatedFieldLabel.Text = "Code Type:";
            }
            else
            {
                this.RelatedFieldDropdown.Visible = true;
                this.RelatedFieldTextbox.Visible = false;
                this.RelatedFieldLabel.Visible = true;
                this.RelatedFieldLabel.Text = "Related Field:";
                this.RelatedFieldDropdown.DisplayMember = "ObjectName";
                this.RelatedFieldDropdown.DataSource = entity.Fields.Where(field => field.CodeType == this.FieldType).ToArray();
            }
        }
    }
}
