using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     Renders a checkbox which is stylised to display a switch that can be turned on or off.
    /// </summary>
    public class CheckField : BaseInputControl<CheckBox, Boolean>, ICanBeSwitched, IHaveDefaultValue, ICanBeHidden, ICanBeReadOnly, IHaveCustomTitle, ICanBeACustomField
    {
        #region fields

        /// <summary>
        ///     The text to display when the switch is on.
        /// </summary>
        private String _onText;

        /// <summary>
        ///     The bootstrap colour that is used when the switch is on.
        /// </summary>
        private String _onColour;

        /// <summary>
        ///     The text to display when the switch is off.
        /// </summary>
        private String _offText;

        /// <summary>
        ///     The bootstrap colour that is used when the switch is off.
        /// </summary>
        private String _offColour;

        #endregion

        #region properties

        /// <summary>
        ///     Gets whether the input elements are grouped into a single input element.
        /// </summary>
        protected override Boolean GroupControls
        {
            get { return false; }
        }

        /// <summary>
        ///     Gets or sets the value of the control.
        /// </summary>
        public override Boolean FieldValue
        {
            get { return this.Field.Checked; }
            set { this.Field.Checked = value; }
        }

        /// <summary>
        ///    Gets or sets the text to display when the switch is on.
        /// </summary>
        public String OnText
        {
            get { return _onText ?? "Yes"; }
            set { _onText = String.IsNullOrEmpty(value) ? null : value; }
        }

        /// <summary>
        ///    Gets or sets the bootstrap colour that is used when the switch is on.
        /// </summary>
        public String OnColour
        {
            get { return _onColour ?? "primary"; }
            set { _onColour = String.IsNullOrEmpty(value) ? null : value; }
        }

        /// <summary>
        ///    Gets or sets the text to display when the switch is off.
        /// </summary>
        public String OffText
        {
            get { return _offText ?? "No"; }
            set { _offText = String.IsNullOrEmpty(value) ? null : value; }
        }

        /// <summary>
        ///    Gets or sets the bootstrap colour that is used when the switch is off.
        /// </summary>
        public String OffColour
        {
            get { return _offColour ?? "default"; }
            set { _offColour = String.IsNullOrEmpty(value) ? null : value; }
        }

        /// <summary>
        ///     Gets or sets the state information that the input control presents.
        /// </summary>
        public override String DataBoundValue
        {
            get { return this.Field.InputAttributes["data-bound-value"]; }
            set { this.Field.InputAttributes["data-bound-value"] = String.IsNullOrEmpty(value) ? null : value.Trim(); }
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
        ///     Initialises the control state.
        /// </summary>
        protected override void InitialiseControlState()
        {
            // Apply the bootstrap switch attributes
            base.InitialiseControlState();
            this.Field.InputAttributes.Add("data-on-color", this.OnColour);
            this.Field.InputAttributes.Add("data-on-text", this.OnText);
            this.Field.InputAttributes.Add("data-off-color", this.OffColour);
            this.Field.InputAttributes.Add("data-off-text", this.OffText);
            this.Field.InputAttributes.Add("data-provide", "bootstrapswitch");
        }

        protected override void SetOnChangeAttribute()
        {
            this.FieldAttributes["onclick"] = this.ClientOnChange;
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
