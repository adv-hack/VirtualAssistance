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
    public partial class EntityEditor : BaseEditor
    {        
        #region fields

        /// <summary>
        ///     The text displayed in the inheritence dropdown when no entity is inherited.
        /// </summary>
        private const String NONE = "(none)";

        /// <summary>
        ///     The domain entity instance that is being created or modified.
        /// </summary>
        private DomainEntity DomainEntity;

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="EntityEditor" /> instance.
        /// </summary>
        public EntityEditor(DomainEntity domainEntity)
        {
            this.InitializeComponent();
            this.DomainEntity = domainEntity;
        }

        #endregion

        #region event handlers

        private void InheritenceDropdown_SelectedIndexChanged(Object sender, EventArgs eventArguments)
        {
            this.InheritenceDropdown.ForeColor = (this.InheritenceDropdown.SelectedIndex == 0) ? Color.Gray : Color.Black;

            DomainEntity selectedEntity = this.InheritenceDropdown.SelectedValue as DomainEntity;
            if (!(this.TableDropdown.Enabled = (selectedEntity == null)))
                this.TableDropdown.SelectedItem = selectedEntity.ReferencedTable;
        }

        private void InheritenceDropdown_Leave(Object sender, EventArgs eventArguments)
        {
            if (this.InheritenceDropdown.Text.Length != 0 && this.InheritenceDropdown.Text != EntityEditor.NONE)
            {
                DomainEntity bestMatch = null;
                for (Int32 i = this.InheritenceDropdown.Text.Length; i > 0 && bestMatch == null; i--)
                    bestMatch = (this.InheritenceDropdown.DataSource as KeyValuePair<DomainEntity, String>[]).Select(kvp => kvp.Key).Where(e => e != null && (e.Container.ContainerName + "." + e.EntityName).StartsWith(this.InheritenceDropdown.Text.Substring(0, i))).FirstOrDefault();
                if (bestMatch != null)
                    this.InheritenceDropdown.SelectedValue = bestMatch;
            }
            else
            {
                this.InheritenceDropdown.SelectedIndex = 0;
            }
        }

        private void TableDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            DomainTable selectedValue = this.TableDropdown.SelectedValue as DomainTable;
            List<KeyValuePair<DomainTableColumn, String>> columns = null;
            if (selectedValue != null)
            {
                if (String.IsNullOrEmpty(this.NameTextbox.Text) || (this.NameTextbox.Tag is Boolean && ((Boolean)this.NameTextbox.Tag)))
                    this.NameTextbox.Text = selectedValue.TableName.ToPascal();

                columns = selectedValue.TableColumns.ToDictionary(c => c, c => c.ColumnName).ToList();
                columns.Insert(0, new KeyValuePair<DomainTableColumn, String>(null, EntityEditor.NONE));
            }

            this.FilterDropdown.DisplayMember = "Value";
            this.FilterDropdown.ValueMember = "Key";
            this.FilterDropdown.DataSource = columns;
            this.FilterDropdown.Enabled = columns != null;
            this.FilterDropdown.SelectedItem = columns == null ? null : (Object)columns.FirstOrDefault(kvp => kvp.Key == this.DomainEntity.FilterColumn);
        }

        private void TableDropdown_Leave(Object sender, EventArgs eventArguments)
        {
            DomainTable bestMatch = (this.TableDropdown.DataSource as DomainTable[]).FirstOrDefault(t => String.Equals(t.TableName, this.TableDropdown.Text, StringComparison.OrdinalIgnoreCase));
            for (Int32 i = this.TableDropdown.Text.Length; i > 0 && bestMatch == null; i--)
                bestMatch = (this.TableDropdown.DataSource as DomainTable[]).Where(t => t.TableName.StartsWith(this.TableDropdown.Text.Substring(0, i), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            if (bestMatch != null)
                this.TableDropdown.SelectedItem = bestMatch;
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            DomainTable selectedValue = this.TableDropdown.SelectedValue as DomainTable;
            this.NameTextbox.Tag = selectedValue == null || String.IsNullOrEmpty(this.NameTextbox.Text) || String.Equals(selectedValue.TableName.ToPascal(), this.NameTextbox.Text);
        }

        private void FilterDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FilterTextbox.Enabled = (this.FilterDropdown.SelectedValue as DomainTableColumn) != null;
        }
        
        #endregion

        #region methods

        protected override void OnInit()
        {
            // Get the list of columns that can be filtered by (including a null value)
            List<KeyValuePair<DomainTableColumn, String>> columns = null;
            if (this.DomainEntity.ReferencedTable != null)
            {
                columns = this.DomainEntity.ReferencedTable.TableColumns.Where(c => c.Exists).ToDictionary(c => c, c => c.ColumnName).ToList();
                columns.Insert(0, new KeyValuePair<DomainTableColumn, String>(null, EntityEditor.NONE));
            }

            // Get the list of entities that can be inherited (including a null value)
            IEnumerable<DomainEntity> fullEntityList = this.DomainEntity.Container.Domain.Containers.SelectMany(c => c.ContainerEntities);
            IEnumerable<DomainEntity> okayEntityList = fullEntityList.Where(e => e.Exists && e != this.DomainEntity && !e.Inherits(this.DomainEntity));
            IEnumerable<DomainEntity> sortEntityList = okayEntityList.OrderBy(e => e.Container.ContainerName).ThenBy(e => e.EntityName);
            List<KeyValuePair<DomainEntity, String>> entities = sortEntityList.ToDictionary(e => e, e => e.Container.ContainerName + "." + e.EntityName).ToList();
            entities.Insert(0, new KeyValuePair<DomainEntity, String>(null, EntityEditor.NONE));

            // Populate the container dropdown
            this.ContainerDropdown.DisplayMember = "ContainerName";
            this.ContainerDropdown.DataSource = this.DomainEntity.Container.Domain.Containers.Where(c => c.Exists).ToArray();
            
            // Populate the table dropdown
            this.TableDropdown.DisplayMember = "TableName";
            this.TableDropdown.DataSource = this.DomainEntity.Container.Domain.Tables.Where(t => t.Exists).ToArray();

            // Populate the inheritence dropdown
            this.InheritenceDropdown.DisplayMember = "Value";
            this.InheritenceDropdown.ValueMember = "Key";
            this.InheritenceDropdown.DataSource = entities.ToArray();

            // Populate the filter dropdown
            this.FilterDropdown.DisplayMember = "Value";
            this.FilterDropdown.ValueMember = "Key";
            this.FilterDropdown.DataSource = columns;
            this.FilterDropdown.Enabled = columns != null;

            // Populate the filter type dropdown
            this.FilterTypeDropdown.ValueMember = "Key";
            this.FilterTypeDropdown.DisplayMember = "Value";
            this.FilterTypeDropdown.DataSource = Enum.GetValues(typeof(DomainEntityFilterType)).OfType<DomainEntityFilterType>().ToDictionary(e => e, e => e.ConvertTo<String>()).ToList();

            // Populate the form controls
            DomainEntityExtender extender = this.DomainEntity as DomainEntityExtender;
            this.ContainerDropdown.SelectedItem = this.DomainEntity.Container;
            this.NameTextbox.Text = this.DomainEntity.EntityName;
            this.DescriptionTextbox.Text = this.DomainEntity.EntityDescription;
            this.TableDropdown.SelectedItem = this.DomainEntity.ReferencedTable;
            this.InheritenceDropdown.SelectedItem = entities.FirstOrDefault(kvp => kvp.Key == (extender == null ? null : extender.ReferencedEntity));
            this.FilterDropdown.SelectedItem = columns == null ? null : (Object)columns.FirstOrDefault(kvp => kvp.Key == this.DomainEntity.FilterColumn);
            this.FilterTypeDropdown.SelectedItem = this.DomainEntity.FilterType;
            this.FilterTextbox.Text = this.DomainEntity.FilterValue;
            this.AbstractCheckbox.Checked = this.DomainEntity.EntityIsAbstract;
            this.CreateCheckbox.Checked = this.DomainEntity.EntityIsCreatable;
            this.ModifyCheckbox.Checked = this.DomainEntity.EntityIsModifiable;
            this.RemoveCheckbox.Checked = this.DomainEntity.EntityIsRemovable;
        }

        protected override Boolean ValidateForm()
        {
            Boolean result = base.ValidateForm();
            result = result && this.ValidateForm(this.ContainerDropdown, this.ContainerDropdown.SelectedIndex >= 0, "Please select a container", false);
            result = result && this.ValidateForm(this.NameTextbox, !String.IsNullOrEmpty(this.NameTextbox.Text), "Please provide a name for the model", false);
            result = result && this.ValidateForm(this.TableDropdown, this.InheritenceDropdown.SelectedIndex >= 1 || this.TableDropdown.SelectedIndex >= 0, "Please select a table", false);
            result = result && this.ValidateForm(this.FilterTextbox, this.FilterDropdown.SelectedValue == null || !String.IsNullOrEmpty(this.FilterTextbox.Text), "A filter has been applied but no value has been specified", false);
            return result;
        }

        protected override void OnConfirm()
        {
            // Ensure that the entity exists in the correct container.
            Boolean isExtender = this.InheritenceDropdown.SelectedValue != null;
            if (this.DomainEntity.Container != this.ContainerDropdown.SelectedItem)
            {
                DomainContainer container = this.ContainerDropdown.SelectedItem as DomainContainer;
                this.DomainEntity.Delete();
                this.DomainEntity = isExtender ? container.CreateEntityExtender() : container.CreateEntity();
            }

            // Ensure that the entity is of the required type
            if ((this.DomainEntity is DomainEntityExtender) != isExtender)
            {
                this.DomainEntity.Delete();
                this.DomainEntity = isExtender ? this.DomainEntity.Container.CreateEntityExtender() : this.DomainEntity.Container.CreateEntity();
            }

            // Update the standard properties
            this.DomainEntity.EntityName = this.NameTextbox.Text;
            this.DomainEntity.EntityDescription = this.DescriptionTextbox.Text;
            this.DomainEntity.ReferencedTable = this.TableDropdown.SelectedItem as DomainTable;
            this.DomainEntity.FilterColumn = this.FilterDropdown.SelectedValue as DomainTableColumn;
            this.DomainEntity.FilterType = (DomainEntityFilterType)this.FilterTypeDropdown.SelectedValue;
            this.DomainEntity.FilterValue = (this.FilterDropdown.SelectedValue == null) ? null : this.FilterTextbox.Text;
            if (isExtender)
                (this.DomainEntity as DomainEntityExtender).ReferencedEntity = this.InheritenceDropdown.SelectedValue as DomainEntity;
        }

        #endregion
    }
}

