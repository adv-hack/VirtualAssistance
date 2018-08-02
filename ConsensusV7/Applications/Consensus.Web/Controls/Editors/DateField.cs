using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     Renders a date picker control.
    /// </summary>
    public class DateField : BaseInputControl<TextBox, DateTime?>, ICanBeMandatory, IHaveDefaultValue, ICanBeHidden, ICanBeReadOnly, IHaveCustomTitle, ICanBeACustomField
    {
        #region properties

        /// <summary>
        ///     Gets or sets the value of the control.
        /// </summary>
        public override DateTime? FieldValue
        {
            get { return this.Field.Text.ConvertTo<DateTime?>(); }
            set { this.Field.Text = value.ConvertTo<String>(); }
        }

        /// <summary>
        ///     Gets or sets whether the field is a custom field
        /// </summary>
        public bool IsCustomField { get; set; }

        /// <summary>
        ///     The field Id for a custom field.
        /// </summary>
        public int CustomFieldId
        {
            get
            {
                string fieldId = this.FieldAttributes["custom-field-id"];
                return string.IsNullOrEmpty(fieldId) ? 0 : fieldId.ConvertTo<int>();
            }
            set
            {
                this.FieldAttributes["custom-field-id"] = value.ToString();
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Initialises the control tree.
        /// </summary>
        protected override void InitialiseControlTree()
        {
            // Apply initial css styles and create the calendar add-on
            base.InitialiseControlTree();
            this.Group.Attributes["class"] += " date";
            this.Addons.Add(new AddOn() { Icon = "calendar_plus" });
            this.Field.Attributes["data-type"] = "date";
        }

        /// <summary>
        ///     Initialises the control state.
        /// </summary>
        protected override void InitialiseControlState()
        {
            // Initialise the bootstrap date picker attributes
            base.InitialiseControlState();            
            this.Group.Attributes.Add("data-date-format", "dd MM yyyy");
            this.Group.Attributes.Add("data-provide", "datepicker");
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the title or display text for the control.
        /// </summary>
        String IHaveCustomTitle.Title
        {
            get { return this.LabelText; }
            set { this.LabelText = value; }
        }

        #endregion
    }
}
