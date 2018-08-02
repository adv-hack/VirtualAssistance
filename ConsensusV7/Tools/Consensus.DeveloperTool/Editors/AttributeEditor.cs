using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consensus.CodeGenerator
{
    public partial class AttributeEditor : BaseEditor
    {
        #region fields

        /// <summary>
        ///     The database index instance that is being created or modified.
        /// </summary>
        private DomainEntityAttribute DomainEntityAttribute;

        /// <summary>
        ///     The text displayed in the inheritence dropdown when no entity is inherited.
        /// </summary>
        private const String NONE = "(none)";

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="AttributeEditor" /> instance.
        /// </summary>
        public AttributeEditor(DomainEntityAttribute domainEntityAttribute)
        {
            this.InitializeComponent();
            this.DomainEntityAttribute = domainEntityAttribute;
        }

        #endregion

        #region event handlers

        private void EntityDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            DomainEntity selectedEntity = this.EntityDropdown.SelectedValue as DomainEntity;
            this.CodeTextbox.Enabled = (selectedEntity != null && selectedEntity.ReferencedTable != null && String.Equals(selectedEntity.ReferencedTable.TableName, DomainTable.CODE_TABLE, StringComparison.OrdinalIgnoreCase));
            this.RelatedNameTextbox.Enabled = (selectedEntity != null && selectedEntity.ReferencedTable != null);
        }

        #endregion

        #region methods

        protected override void OnInit()
        {
            // Get the list of entities that can be referenced (including a null value)
            IEnumerable<DomainEntity> fullEntityList = this.DomainEntityAttribute.Entity.Container.Domain.Containers.SelectMany(c => c.ContainerEntities);
            IEnumerable<DomainEntity> sortEntityList = fullEntityList.Where(e => e.Exists).OrderBy(e => e.Container.ContainerName).ThenBy(e => e.EntityName);
            List<KeyValuePair<DomainEntity, String>> entities = sortEntityList.ToDictionary(e => e, e => e.Container.ContainerName + "." + e.EntityName).ToList();
            entities.Insert(0, new KeyValuePair<DomainEntity, String>(null, AttributeEditor.NONE));

            // Populate the entity dropdown
            this.EntityDropdown.DisplayMember = "Value";
            this.EntityDropdown.ValueMember = "Key";
            this.EntityDropdown.DataSource = entities.ToArray();

            // Populate the form controls
            this.ColumnTextbox.Text = this.DomainEntityAttribute.Column.ColumnName;
            this.InternalTextbox.Text = this.DomainEntityAttribute.Column.ProgrammaticName;
            this.NameTextbox.Text = this.DomainEntityAttribute.AttributeName;
            this.DescriptionTextbox.Text = this.DomainEntityAttribute.AttributeDescription;
            this.EntityDropdown.SelectedItem = entities.FirstOrDefault(kvp => kvp.Key == this.DomainEntityAttribute.ReferencedEntity);
            this.CodeTextbox.Text = this.DomainEntityAttribute.AttributeCode;
            this.RelatedNameTextbox.Text = this.DomainEntityAttribute.ReferencedName;
            this.SerialiserCheckbox.Checked = this.DomainEntityAttribute.ReferenceExcludeSerialisation;
            this.Size = new Size(500, 285);
        }

        protected override bool ValidateForm()
        {
            DomainEntity selectedEntity = this.EntityDropdown.SelectedValue as DomainEntity;
            
            Boolean result = base.ValidateForm();
            result = result && this.ValidateForm(this.InternalTextbox, !String.IsNullOrEmpty(this.InternalTextbox.Text), "Please specify the internal name for the property", false);
            result = result && this.ValidateForm(this.NameTextbox, !String.IsNullOrEmpty(this.NameTextbox.Text), "Please specify a name for the property", false);
            result = result && this.ValidateForm(this.RelatedNameTextbox, !String.IsNullOrEmpty(this.RelatedNameTextbox.Text) || this.EntityDropdown.SelectedValue == null, "Please specify a referencing name for the property", false);
            if (selectedEntity != null && selectedEntity.Guid == Guid.Parse("071e71b8-1ff3-473e-a9b9-3187b1c9421e"))
                result = result && this.ValidateForm(this.CodeTextbox, !String.IsNullOrEmpty(this.CodeTextbox.Text), "Please specify the code type", false);

            return result;
        }

        protected override void OnConfirm()
        {
            DomainEntity selectedEntity = this.EntityDropdown.SelectedValue as DomainEntity;
            this.DomainEntityAttribute.Column.ProgrammaticName = this.InternalTextbox.Text;
            this.DomainEntityAttribute.AttributeName = this.NameTextbox.Text;
            this.DomainEntityAttribute.AttributeDescription = this.DescriptionTextbox.Text;
            this.DomainEntityAttribute.ReferencedEntity = selectedEntity;
            this.DomainEntityAttribute.AttributeCode = (selectedEntity != null && String.Equals(selectedEntity.ReferencedTable.TableName, DomainTable.CODE_TABLE, StringComparison.OrdinalIgnoreCase)) ? this.CodeTextbox.Text : null;
            this.DomainEntityAttribute.ReferencedName = this.RelatedNameTextbox.Text;
            this.DomainEntityAttribute.ReferenceExcludeSerialisation = this.SerialiserCheckbox.Checked;
        }

        #endregion
    }
}
