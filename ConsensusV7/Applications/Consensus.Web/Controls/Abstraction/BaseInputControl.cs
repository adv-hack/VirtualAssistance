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
    ///     Provides the abstraction for all input controls within the web application.
    /// </summary>
    [ParseChildren(true)]
    public abstract class BaseInputControl : BaseControl
    {
        #region fields

        /// <summary>
        ///     The control used to display text above the input control.
        /// </summary>
        private HtmlGenericControl _label;

        /// <summary>
        ///     The control used to display text above the input control.
        /// </summary>
        private HtmlGenericControl _group;

        /// <summary>
        ///    The wrapping control which contains validation errors and informative help text below the input control.
        /// </summary>
        private HtmlGenericControl _error;

        /// <summary>
        ///    The control used to informative instructions below the input control.
        /// </summary>
        private HtmlGenericControl _help;

        /// <summary>
        ///     The collection of addons included within the control.
        /// </summary>
        private List<AddOn> _addons;

        /// <summary>
        ///     The collection of custom validators to be included within the control.
        /// </summary>
        private List<Validator> _validators;

        /// <summary>
        ///     Specifies whether the field is editable.
        /// </summary>
        private ConfigurableBoolean _isEditable;

        /// <summary>
        ///     Specifies whether the field is read-only.
        /// </summary>
        private ConfigurableBoolean _isReadOnly;

        /// <summary>
        ///     Specifies whether the field is hidden.
        /// </summary>
        private ConfigurableBoolean _isHidden;

        /// <summary>
        ///     Specifies whether the field is mandatory.
        /// </summary>
        private ScreenObjectRequirement _requirement;

        /// <summary>
        ///     The validator which ensures that the field value is specified.
        /// </summary>
        private RequiredFieldValidator _requiredFieldValidator;

        /// <summary>
        ///     The validator which ensures that the field value specified is valid.
        /// </summary>
        private RegularExpressionValidator _regularExpressionValidator;

        /// <summary>
        ///     Specifies whether whether the validation is deemed critical and should prevent data changes.
        /// </summary>
        private Boolean _validatorCritical;

        /// <summary>
        ///     The default value for the control, which is applied automatically when creating a new record.
        /// </summary>
        private Object _defaultValue;

        /// <summary>
        ///     Tracks whether the default value needs to be applied.
        /// </summary>
        private Boolean _applyDefaultValue = true;

        #endregion

        #region properties

        /// <summary>
        ///     Gets whether the input elements are grouped into a single input element.
        /// </summary>
        protected virtual Boolean GroupControls
        {
            get { return true; }
        }

        /// <summary>
        ///    Gets the control used to display text above the input control.
        /// </summary>
        protected HtmlGenericControl Label
        {
            get
            {
                if (_label == null)
                {
                    _label = new HtmlGenericControl("label");
                    _label.EnableViewState = false; // The default is true, which give problems on the customisation screen after a postback. Have also disabled ViewState globally...
                }

                return _label;
            }
        }

        /// <summary>
        ///     Gets the control used to display text above the input control.
        /// </summary>
        protected HtmlGenericControl Group
        {
            get
            {
                if (_group == null)
                    _group = new HtmlGenericControl("div");

                return _group;
            }
        }

        /// <summary>
        ///    Gets the wrapping control which contains validation errors and informative help text below the input control.
        /// </summary>
        protected HtmlGenericControl Error
        {
            get
            {
                if (_error == null)
                    _error = new HtmlGenericControl("small");

                return _error;
            }
        }

        /// <summary>
        ///    Gets the control used to informative instructions below the input control.
        /// </summary>
        protected HtmlGenericControl Help
        {
            get
            {
                if (_help == null)
                    _help = new HtmlGenericControl("span");

                return _help;
            }
        }

        /// <summary>
        ///    Gets the validator which ensures that the field value is specified.
        /// </summary>
        protected RequiredFieldValidator RequiredFieldValidator
        {
            get
            {
                if (_requiredFieldValidator == null)
                    _requiredFieldValidator = new RequiredFieldValidator();

                return _requiredFieldValidator;
            }
        }

        /// <summary>
        ///    Gets the validator which ensures that the field value specified is valid.
        /// </summary>
        protected RegularExpressionValidator RegularExpressionValidator
        {
            get
            {
                if (_regularExpressionValidator == null)
                    _regularExpressionValidator = new RegularExpressionValidator();

                return _regularExpressionValidator;
            }
        }

        /// <summary>
        ///    Gets or sets the collection of addons included within the control.
        /// </summary>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public List<AddOn> Addons
        {
            get
            {
                if (_addons == null)
                    _addons = new List<AddOn>();

                return _addons;
            }
        }

        /// <summary>
        ///    Gets or sets the collection of custom validators to be included within the control.
        /// </summary>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public List<Validator> Validators
        {
            get
            {
                if (_validators == null)
                    _validators = new List<Validator>();

                return _validators;
            }
        }
                
        /// <summary>
        ///     Gets or sets the text to display above the input control.
        /// </summary>
        public String LabelText
        {
            get { return this.Label.InnerText; }
            set { this.Label.InnerText = value; }
        }

        /// <summary>
        ///     Gets or sets the CSS class used to display text above the input control.
        /// </summary>
        public String LabelClass
        {
            get { return this.Label.Attributes["class"]; }
            set { this.Label.Attributes["class"] = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }

        /// <summary>
        ///     Gets or sets the text to display below the input control.
        /// </summary>
        public String HelpText
        {
            get { return this.Help.InnerText; }
            set { this.Help.InnerText = value; }
        }

        /// <summary>
        ///     Gets or sets the CSS class used to display text below the input control.
        /// </summary>
        public String HelpClass
        {
            get { return this.Help.Attributes["class"]; }
            set { this.Help.Attributes["class"] = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }

        /// <summary>
        ///     Gets or sets the CSS class used to group the input elements 
        /// </summary>
        public String GroupClass
        {
            get { return this.Group.Attributes["class"]; }
            set { this.Group.Attributes["class"] = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }

        /// <summary>
        ///     Gets or sets whether the field is editable.
        /// </summary>
        public ConfigurableBoolean IsEditable
        {
            get { return _isEditable; }
            set { _isEditable = value; }
        }

        /// <summary>
        ///     Gets or sets whether the field is read-only.
        /// </summary>
        public ConfigurableBoolean IsReadOnly
        {
            get { return _isReadOnly; }
            set { _isReadOnly = value; }
        }

        /// <summary>
        ///     Gets or sets whether the field is hidden.
        /// </summary>
        public ConfigurableBoolean IsHidden
        {
            get { return _isHidden; }
            set { _isHidden = value; }
        }

        /// <summary>
        ///     Gets or sets whether the field is mandatory.
        /// </summary>
        public ScreenObjectRequirement Requirement
        {
            get { return _requirement; }
            set { _requirement = value; }
        }

        /// <summary>
        ///     Gets or sets the regular expression used to validate the field
        /// </summary>
        public String ValidatorExpression
        {
            get { return this.RegularExpressionValidator.ValidationExpression; }
            set { this.RegularExpressionValidator.ValidationExpression = value ?? String.Empty; }
        }

        /// <summary>
        ///     Gets or sets the message to display when the control value fails validation.
        /// </summary>
        public String ValidatorMessage
        {
            get { return this.RegularExpressionValidator.ErrorMessage; }
            set { this.RegularExpressionValidator.ErrorMessage = value; }
        }

        /// <summary>
        ///     Gets or sets whether the validation is deemed critical and should prevent data changes.
        /// </summary>
        public Boolean ValidatorCritical
        {
            get { return _validatorCritical; }
            set { _validatorCritical = value; }
        }

        /// <summary>
        ///     Gets or sets the state information that the input control presents.
        /// </summary>
        public abstract String DataBoundValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the control.
        /// </summary>
        public abstract Object FieldValueRaw
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the runtime type of the value that can be get/set for this control.
        /// </summary>
        public abstract Type FieldType
        {
            get;
        }

        /// <summary>
        ///    Gets or sets the default value for the control, which is applied automatically when creating a new record.
        /// </summary>
        public Object DefaultValue
        {
            get { return _defaultValue; }
            set { _defaultValue = value; }
        }

        /// <summary>
        ///    Gets or sets whether the default value needs to be applied.
        /// </summary>
        public Boolean ApplyDefaultValue
        {
            get { return _applyDefaultValue; }
            set { _applyDefaultValue = value; }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new input control.
        /// </summary>
        public BaseInputControl()
        {
            this.CssClass = "consensus-input";
            this.IsReadOnly = ConfigurableBoolean.False;
            this.IsEditable = ConfigurableBoolean.False;
            this.IsHidden = ConfigurableBoolean.False;
            this.Requirement = ScreenObjectRequirement.Optional;
        }

        #endregion

        #region page cycle

        protected override void OnInit(EventArgs e)
        {
            this.ID = this.ID ?? this.DataBoundValue.ToPascal();
            base.OnInit(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.InitialiseValidators();
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            // Add the validators
            if (this.Requirement != ScreenObjectRequirement.Optional && this.Requirement != ScreenObjectRequirement.OptionalEnforced)
                this.Error.Controls.Add(this.RequiredFieldValidator);
            if (!String.IsNullOrEmpty(this.ValidatorExpression))
                this.Error.Controls.Add(this.RegularExpressionValidator);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            if (this.ApplyDefaultValue && this.DefaultValue != null)
                this.FieldValueRaw = this.DefaultValue;
           
            base.Render(writer);
        }

        #endregion

        #region methods

        /// <summary>
        ///     Initialises the control.
        /// </summary>
        protected override void InitialiseControlTree()
        {
            base.InitialiseControlTree();
            this.InitialiseIdentifiers();
            this.InitialiseControlContent();

            Control parent = this.NamingContainer;
            while (parent != null && parent is IIsEditable == false)
                parent = parent.NamingContainer;

            // If the parent has an editable flag and this has an editable value which is not enforced, use the parents editable flag.
            if (parent is IIsEditable && (this.IsEditable == ConfigurableBoolean.True || this.IsEditable == ConfigurableBoolean.False))
                this.IsEditable = (parent as IIsEditable).IsEditable ? ConfigurableBoolean.True : ConfigurableBoolean.False;
        }

        /// <summary>
        ///     Initialises the control state
        /// </summary>
        protected override void InitialiseControlState()
        {
            // Add the control add-ons
            base.InitialiseControlState();
            foreach (AddOn addon in this.Addons)
                this.Group.Controls.AddAt(this.Group.Controls.Count, addon);
            foreach (CustomValidator validator in this.Validators)
                this.Error.Controls.Add(validator);
        }

        /// <summary>
        ///     Initialises the identifiers of the controls in the tree.
        /// </summary>
        private void InitialiseIdentifiers()
        {
            this.Label.ID = String.Format("{0}Label", this.ID);
            this.Group.ID = String.Format("{0}Group", this.ID);
            this.Error.ID = String.Format("{0}Error", this.ID);
        }

        /// <summary>
        ///     Initialises the control content.
        /// </summary>
        private void InitialiseControlContent()
        {
            // Move the child controls into the group
            while (this.Controls.Count > 0)
                this.Group.Controls.Add(this.Controls[0]);

            // Construct the control framework
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.Error);
            this.Error.Controls.Add(this.Help);
            this.GroupClass = "input-group";
        }

        /// <summary>
        ///     Initialises the validators for the control.
        /// </summary>
        public virtual void InitialiseValidators()
        {
            switch (this.Requirement)
            {
                case ScreenObjectRequirement.Mandatory:
                case ScreenObjectRequirement.MandatoryEnforced:
                    this.RequiredFieldValidator.Attributes.Add("data-validation-critical", "yes");
                    this.RequiredFieldValidator.CssClass = "consensus-validator text-danger";
                    this.RequiredFieldValidator.Display = ValidatorDisplay.Dynamic;
                    this.RequiredFieldValidator.ErrorMessage = "This is a required field";
                    this.RequiredFieldValidator.ValidationGroup = this.ClientID;
                    break;
                case ScreenObjectRequirement.Recommended:
                case ScreenObjectRequirement.RecommendedEnforced:
                    this.RequiredFieldValidator.Attributes.Add("data-validation-critical", "no");
                    this.RequiredFieldValidator.CssClass = "consensus-validator text-warning";
                    this.RequiredFieldValidator.Display = ValidatorDisplay.Dynamic;
                    this.RequiredFieldValidator.ErrorMessage = "This is a recommended field";
                    this.RequiredFieldValidator.ValidationGroup = this.ClientID;
                    break;
            }

            this.RegularExpressionValidator.Attributes.Add("data-validation-critical", this.ValidatorCritical ? "yes" : "no");
            this.RegularExpressionValidator.CssClass = "consensus-validator " + (this.ValidatorCritical ? "text-danger" : "text-warning");
            this.RegularExpressionValidator.Display = ValidatorDisplay.Dynamic;
            this.RegularExpressionValidator.ValidationGroup = this.ClientID;

            foreach (Validator validator in this.Validators)
            {
                validator.Attributes.Add("data-validation-critical", validator.Critical ? "yes" : "no");
                validator.CssClass = "consensus-validator " + (validator.Critical ? "text-danger" : "text-warning");
                validator.Display = ValidatorDisplay.Dynamic;
                validator.ValidationGroup = this.ClientID;
            }
        }

        #endregion
    }
}
