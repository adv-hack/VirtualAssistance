using Consensus.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     Provides the abstraction for all encapsulated input controls within the web application.
    /// </summary>
    /// <typeparam name="TControl">
    ///     The type of control that has been encapsulated.
    /// </typeparam>
    [ParseChildren(true)]
    public abstract class BaseInputControl<TControl> : BaseInputControl where TControl : Control, new()
    {
        #region fields

        /// <summary>
        ///     The instance of the input control.
        /// </summary>
        private TControl _field;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the instance of the input control
        /// </summary>
        protected TControl Field
        {
            get
            {
                if (_field == null)
                    _field = new TControl();

                return _field;
            }
        }

        /// <summary>
        ///     Gets the collection of attributes that are rendered for the field.
        /// </summary>
        protected AttributeCollection FieldAttributes
        {
            get
            {
                if (this.Field is CheckBox)
                    return (this.Field as CheckBox).InputAttributes;
                if (this.Field is WebControl)
                    return (this.Field as WebControl).Attributes;
                if (this.Field is HtmlControl)
                    return (this.Field as HtmlControl).Attributes;
                return null;
            }
        }

        /// <summary>
        ///     Gets or sets the CSS class used to style the input control
        /// </summary>
        public String FieldClass
        {
            get { return this.FieldAttributes["class"]; }
            set { this.FieldAttributes["class"] = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }

        /// <summary>
        ///     Gets or sets the state information that the input control presents.
        /// </summary>
        public override String DataBoundValue
        {
            get { return this.FieldAttributes["data-bound-value"]; }
            set { this.FieldAttributes["data-bound-value"] = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Initialises the control.
        /// </summary>
        protected override void InitialiseControlTree()
        {
            // Add the field to the control framework
            this.Field.ID = String.Format("{0}Field", this.ID);
            this.FieldClass = this.GroupControls ? "form-control" : "";
            this.Group.Controls.Add(this.Field);
            base.InitialiseControlTree();
        }

        /// <summary>
        ///     Initialises the control state.
        /// </summary>
        protected override void InitialiseControlState()
        {
            base.InitialiseControlState();
            this.Label.Attributes.Add("for", this.Field.ClientID);
            this.FieldAttributes["aria-label"] = !String.IsNullOrEmpty(this.LabelText) ? this.LabelText : !String.IsNullOrEmpty(this.DataBoundValue) ? this.DataBoundValue : this.ID;

            // Apply or remove the disabled attribute
            if (this.IsEditable < 0 || this.IsReadOnly > 0)
            {
                this.Group.Attributes.Add("disabled", "disabled");
                this.Group.Controls.OfType<WebControl>().Execute(ctrl => ctrl.Attributes.Add("disabled", "disabled"));
                this.Group.Controls.OfType<HtmlInputControl>().Execute(ctrl => ctrl.Attributes.Add("disabled", "disabled"));
                this.Group.Controls.OfType<CheckBox>().Execute(ctrl => ctrl.InputAttributes.Add("disabled", "disabled"));
                this.Addons.Execute(ctrl => ctrl.Attributes.Add("disabled", "disabled"));
            }
            else
            {
                this.Group.Attributes.Remove("disabled");
                this.Group.Controls.OfType<WebControl>().Execute(ctrl => ctrl.Attributes.Remove("disabled"));
                this.Group.Controls.OfType<HtmlInputControl>().Execute(ctrl => ctrl.Attributes.Remove("disabled"));
                this.Group.Controls.OfType<CheckBox>().Execute(ctrl => ctrl.InputAttributes.Remove("disabled"));
                this.Addons.Execute(ctrl => ctrl.Attributes.Remove("disabled"));
            }

            // Apply or remove the readonly attribute
            if (this.IsReadOnly > 0)
            {
                this.Group.Attributes.Add("readonly", "readonly");
                this.Group.Controls.OfType<WebControl>().Execute(ctrl => ctrl.Attributes.Add("readonly", "readonly"));
                this.Group.Controls.OfType<HtmlInputControl>().Execute(ctrl => ctrl.Attributes.Add("readonly", "readonly"));
                this.Group.Controls.OfType<CheckBox>().Execute(ctrl => ctrl.InputAttributes.Add("readonly", "readonly"));
            }
            else
            {
                this.Group.Attributes.Remove("readonly");
                this.Group.Controls.OfType<WebControl>().Execute(ctrl => ctrl.Attributes.Remove("readonly"));
                this.Group.Controls.OfType<HtmlInputControl>().Execute(ctrl => ctrl.Attributes.Remove("readonly"));
                this.Group.Controls.OfType<CheckBox>().Execute(ctrl => ctrl.InputAttributes.Remove("readonly"));
            }

            // Apply or remove the hidden attribute
            if (this.IsHidden == ConfigurableBoolean.True || this.IsHidden == ConfigurableBoolean.TrueEnforced)
                this.Attributes.Add("hidden", "hidden");
            else
                this.Attributes.Remove("hidden");
        }

        /// <summary>
        ///     Initialises the control validators.
        /// </summary>
        public override void InitialiseValidators()
        {
            base.InitialiseValidators();
            this.RequiredFieldValidator.ControlToValidate = this.Field.ID;
            this.RegularExpressionValidator.ControlToValidate = this.Field.ID;
            foreach (Validator validator in this.Validators)
                validator.ControlToValidate = this.Field.ID;

        }

        #endregion
    }
}
