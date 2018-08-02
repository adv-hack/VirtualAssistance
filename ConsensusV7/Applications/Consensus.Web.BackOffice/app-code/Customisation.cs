using Consensus.Security;
using Consensus.UserInterface;
using Consensus.Web.Controls;
using Consensus.Web.Customisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice
{
    /// <summary>
    ///     Represents a configurable customisation for a control.
    /// </summary>
    public class Customisation
    {
        #region fields

        /// <summary>
        ///     The context cached collection of screen objects.
        /// </summary>
        private static ScreenObject[] _cache;

        /// <summary>
        ///     The control to which customisation is applied.
        /// </summary>
        private Control _control;

        /// <summary>
        ///     The user-friendly identifier for the control.
        /// </summary>
        private String _controlName;

        /// <summary>
        ///     The configuration that is applied to the control
        /// </summary>
        private Dictionary<String, Object> _configuration;

        /// <summary>
        ///     The cleaned up URL for the screen.
        /// </summary>
        private string _screenUrl;

        /// <summary>
        ///     The database-persisted customisation settings that correspond to the control.
        /// </summary>
        private ScreenObject _screenObject;

        /// <summary>
        ///     Gets the customisation capabilities for the control
        /// </summary>
        private List<String> _capabilities;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the context cached collection of screen objects.
        /// </summary>
        public static ScreenObject[] Cache
        {
            get
            {
                if (_cache == null)
                    _cache = HttpContext.Current.Cache["ScreenObjects"] as ScreenObject[];
                if (_cache == null)
                    _cache = (HttpContext.Current.Cache["ScreenObjects"] = ScreenObject.FetchAll().ToArray()) as ScreenObject[];
                return _cache;
            }
            set
            {
                _cache = value;
                if (value == null)
                    HttpContext.Current.Cache.Remove("ScreenObjects");
                else
                    HttpContext.Current.Cache["ScreenObjects"] = value;
            }
        }

        public int Ordinal { get; set; }

        /// <summary>
        ///     Gets or sets the control to which customisation is applied.
        /// </summary>
        private Control Control
        {
            get { return _control; }
            set { _control = value; }
        }

        /// <summary>
        ///     Gets the unique identifier for the control.
        /// </summary>
        public String ControlId
        {
            get { return _control.UniqueID; }
        }

        /// <summary>
        ///     Gets the unique identifier for the control.
        /// </summary>
        public String ClientId
        {
            get { return _control.ClientID; }
        }

        /// <summary>
        ///     Gets the type of the control.
        /// </summary>
        public String ControlType
        {
            get { return _control is Page ? "Page" : _control.GetType().Name; }
        }

        /// <summary>
        ///     Gets the user-friendly identifier for the control.
        /// </summary>
        public String ControlName
        {
            get { return _controlName; }
            set { _controlName = value; }
        }

        /// <summary>
        ///     Gets the screenObjectDisplay text for the control.
        /// </summary>
        public String ControlText
        {
            get { return _control is IHaveCustomTitle ? (_control as IHaveCustomTitle).Title : null; }
        }

        /// <summary>
        ///     Gets the customisation capabilities for the control
        /// </summary>
        public List<String> Capabilities
        {
            get
            {
                if (_capabilities == null)
                {
                    List<Type> interfaces = _control.GetType().GetInterfaces().Where(i => i.GetInterfaces().Any(si => si == typeof(ICustomisationCapability))).ToList();
                    if (this.Control is IHaveListItems && (this.Control as IHaveListItems).HasDataSource)
                        interfaces.Remove(typeof(IHaveListItems));

                    _capabilities = interfaces.Select(i => i.Name).ToList();
                }
                return _capabilities;
            }
        }

        /// <summary>
        ///     Gets the configuration that is applied to the control
        /// </summary>
        public Dictionary<String, Object> Configuration
        {
            get
            {
                if (_configuration == null)
                    _configuration = new Dictionary<String, Object>();

                return _configuration;
            }
        }

        /// <summary>
        ///    Gets the database-persisted customisation settings that correspond to the control. 
        /// </summary>
        public ScreenObject ScreenObject
        {
            get
            {
                if (_screenObject == null)
                {
                    _screenObject = Customisation.Cache.FirstOrDefault(obj => String.Equals(obj.Url, ScreenUrl, StringComparison.OrdinalIgnoreCase) && String.Equals(obj.Control, _control.UniqueID, StringComparison.OrdinalIgnoreCase));
                }
                return _screenObject;
            }
        }

        public string ScreenUrl { get; set; }

        #endregion

        #region constructor

        private Customisation(Control control, string screenUrl, CustomisationSecurity[] customisationSecurities)
        {
            this.Control = control;
            this.ScreenUrl = screenUrl;
            this.InitialiseDefault(customisationSecurities);
            if (this.ScreenObject != null)
                this.InitialiseCustom();
        }

        #endregion

        #region methods

        /// <summary>
        ///     Updates the control using the entries in the configuration table.
        /// </summary>
        public void InitialiseControl(UserGroup[] groupMembership)
        {
            // Update the control with either the default setting or the customised and database-persisted setting
            this.Initialise<IHaveCustomIcon>("Icon", (config, control) => control.Icon = config.ApplicableValue.ConvertTo<String>());
            this.Initialise<IHaveCustomTitle>("Title", (config, control) => control.Title = config.ApplicableValue.ConvertTo<String>());
            this.Initialise<IHaveDefaultValue>("DefaultValue", (config, control) => control.DefaultValue = config.ApplicableValue);
            this.Initialise<ICanBeValidated>("ValidatorCritical", (config, control) => control.ValidatorCritical = config.ApplicableValue.ConvertTo<Boolean>());
            this.Initialise<ICanBeValidated>("ValidatorExpression", (config, control) => control.ValidatorExpression = config.ApplicableValue.ConvertTo<String>());
            this.Initialise<ICanBeValidated>("ValidatorMessage", (config, control) => control.ValidatorMessage = config.ApplicableValue.ConvertTo<String>());
            this.Initialise<IHaveMaxLength>("MaximumLength", (config, control) => control.MaximumLength = config.ApplicableValue.ConvertTo<Int32>());
            this.Initialise<ICanBeMandatory>("Requirement", (config, control) => control.Requirement = (control.Requirement == ScreenObjectRequirement.OptionalEnforced || control.Requirement == ScreenObjectRequirement.RecommendedEnforced || control.Requirement == ScreenObjectRequirement.MandatoryEnforced ? control.Requirement : config.ApplicableValue.ConvertTo<Int32>().ConvertTo<ScreenObjectRequirement>()));
            this.Initialise<ICanBeReadOnly>("IsReadOnly", (config, control) => control.IsReadOnly = (control.IsReadOnly == ConfigurableBoolean.TrueEnforced || control.IsReadOnly == ConfigurableBoolean.FalseEnforced ? control.IsReadOnly : config.ApplicableValue.ConvertTo<ConfigurableBoolean>()));
            this.Initialise<ICanBeHidden>("IsHidden", (config, control) => control.IsHidden = (control.IsHidden == ConfigurableBoolean.TrueEnforced || control.IsHidden == ConfigurableBoolean.FalseEnforced ? control.IsHidden : config.ApplicableValue.ConvertTo<ConfigurableBoolean>()));
            this.Initialise<ICanBeSwitched>("OnText", (config, control) => control.OnText = config.ApplicableValue.ConvertTo<String>());
            this.Initialise<ICanBeSwitched>("OnColour", (config, control) => control.OnColour = config.ApplicableValue.ConvertTo<String>());
            this.Initialise<ICanBeSwitched>("OffText", (config, control) => control.OffText = config.ApplicableValue.ConvertTo<String>());
            this.Initialise<ICanBeSwitched>("OffColour", (config, control) => control.OffColour = config.ApplicableValue.ConvertTo<String>());

            if (this.Control is IHaveListItems && !(this.Control as IHaveListItems).HasDataSource)
                this.InitialiseControlItems();
            if (this.Control is ICanBeReadOnly || this.Control is ICanBeHidden)
                this.InitialiseControlSecurity(groupMembership);
            if (this.Control is IHaveColumns)
                this.InitialiseControlColumns();

            // Ensure validators are re-initialised, based upon the customisation
            if (this.Control is BaseInputControl)
                (this.Control as BaseInputControl).InitialiseValidators();
        }

        private void InitialiseControlItems()
        {
            ListItemCollection collection = (this.Control as IHaveListItems).Items;
            for (Int32 i = collection.Count - 1; i >= 0; i--)
            {
                CustomisationItem item = (this.Configuration["Items"] as CustomisationItem[]).FirstOrDefault(x => x.Value == collection[i].Value);
                if (item != null && item.Displayed)
                    collection[i].Text = item.CustomText.TrimOrNullify() ?? collection[i].Text;
                if (item != null && !item.Displayed)
                    collection.RemoveAt(i);
            }
        }

        private void InitialiseControlSecurity(UserGroup[] groupMembership)
        {
            UserSession session = (HttpContext.Current.Handler is BasePage) ? (HttpContext.Current.Handler as BasePage).CurrentSession : null;
            if (session != null && session.Expiry > DateTime.Now)
            {
                ScreenObjectVisibility[] groupVisibility = (this.Configuration["Security"] as CustomisationSecurity[]).Where(security => security.Visibility != null 
                  && groupMembership.Any(mem => mem.Principal.Id == security.PrincipalId)).Select(security => security.Visibility.Value).ToArray();
                if (groupVisibility.Length != 0)
                {
                    if (this.Control is ICanBeReadOnly 
                      && (this.Control as ICanBeReadOnly).IsReadOnly != ConfigurableBoolean.TrueEnforced 
                      && (this.Control as ICanBeReadOnly).IsReadOnly != ConfigurableBoolean.FalseEnforced)
                        if (groupVisibility.Min() == ScreenObjectVisibility.ReadOnly)
                            (this.Control as ICanBeReadOnly).IsReadOnly = ConfigurableBoolean.True;
                        else if (groupVisibility.Min() == ScreenObjectVisibility.Visible)
                            (this.Control as ICanBeReadOnly).IsReadOnly = ConfigurableBoolean.False;

                    if (this.Control is ICanBeHidden 
                      && (this.Control as ICanBeHidden).IsHidden != ConfigurableBoolean.TrueEnforced 
                      && (this.Control as ICanBeHidden).IsHidden != ConfigurableBoolean.FalseEnforced)
                        if (groupVisibility.Min() == ScreenObjectVisibility.Hidden)
                            (this.Control as ICanBeHidden).IsHidden = ConfigurableBoolean.True;
                        else if (groupVisibility.Min() == ScreenObjectVisibility.Visible || groupVisibility.Min() == ScreenObjectVisibility.ReadOnly)
                            (this.Control as ICanBeHidden).IsHidden = ConfigurableBoolean.False;
                }
            }
        }

        private void InitialiseControlColumns()
        {
            IHaveColumns control = (this.Control as IHaveColumns);
            if (control != null && control.Columns != null)
            {
                for (Int32 i = 0; i < control.Columns.Count; i++)
                {
                    CustomisationColumn customColumn = (this.Configuration["Columns"] as CustomisationColumn[]).FirstOrDefault(x => x.Ordinal == i);
                    if (customColumn != null)
                    {
                        control.Columns[i].Title = customColumn.CustomTitle ?? customColumn.DefaultTitle;
                        control.Columns[i].Exportable = customColumn.Exportable;
                        control.Columns[i].Visible = customColumn.Visible;
                    }
                }
            }
        }

        /// <summary>
        ///     Initialises the configuration table with default settings.
        /// </summary>
        private void InitialiseDefault(CustomisationSecurity[] customisationSecurities)
        {
            // Get the initial settings from the control and apply these as default configurations
            this.Initialise<IHaveCustomIcon>("Icon", (config, control) => config.DefaultValue = control.Icon);
            this.Initialise<IHaveCustomTitle>("Title", (config, control) => config.DefaultValue = control.Title);
            this.Initialise<IHaveDefaultValue>("DefaultValue", (config, control) => config.DefaultValue = control.DefaultValue);
            this.Initialise<ICanBeValidated>("ValidatorCritical", (config, control) => config.DefaultValue = control.ValidatorCritical.ToString().ToLower());
            this.Initialise<ICanBeValidated>("ValidatorExpression", (config, control) => config.DefaultValue = control.ValidatorExpression);
            this.Initialise<ICanBeValidated>("ValidatorMessage", (config, control) => config.DefaultValue = control.ValidatorMessage);
            this.Initialise<IHaveMaxLength>("MaximumLength", (config, control) => config.DefaultValue = control.MaximumLength);
            this.Initialise<ICanBeMandatory>("Requirement", (config, control) => config.DefaultValue = control.Requirement.ConvertTo<Int32>().ToString());
            this.Initialise<ICanBeReadOnly>("IsReadOnly", (config, control) => config.DefaultValue = control.IsReadOnly.ToString().ToLower());
            this.Initialise<ICanBeHidden>("IsHidden", (config, control) => config.DefaultValue = control.IsHidden.ToString().ToLower());
            this.Initialise<ICanBeSwitched>("OnText", (config, control) => config.DefaultValue = control.OnText);
            this.Initialise<ICanBeSwitched>("OnColour", (config, control) => config.DefaultValue = control.OnColour);
            this.Initialise<ICanBeSwitched>("OffText", (config, control) => config.DefaultValue = control.OffText);
            this.Initialise<ICanBeSwitched>("OffColour", (config, control) => config.DefaultValue = control.OffColour);
            this.Initialise<ICanBeACustomField>("IsCustomField", (config, control) => config.DefaultValue = control.IsCustomField);
            this.Initialise<ICanBeACustomField>("CustomFieldId", (config, control) => config.DefaultValue = control.CustomFieldId);
            if (this.Control is ICustomFieldContainer)
            {
                if (((ICustomFieldContainer)this.Control).BlockCustomFields)
                {
                    Capabilities.Remove("ICustomFieldContainer");
                }
                else
                {
                    this.Initialise<ICustomFieldContainer>("CustomFieldContainer", (config, control) => config.DefaultValue = true);
                    this.Initialise<ICustomFieldContainer>("Title", (config, control) => config.DefaultValue = control.Title);
                }
            }

            // Include the code type and item list for dropdown controls.
            if (this.Control is IHaveCodeItems)
                this.Configuration.Add("CodeType", (this.Control as IHaveCodeItems).CodeType);
            if (this.Control is IHaveListItems && !(this.Control as IHaveListItems).HasDataSource)
                this.Configuration.Add("Items", (this.Control as IHaveListItems).Items.OfType<ListItem>().Select(item => new CustomisationItem(item)).ToArray());
            if (this.Control is ICanBeReadOnly || this.Control is ICanBeHidden)
                this.Configuration.Add("Security", customisationSecurities);
            if (this.Control is IHaveColumns && (this.Control as IHaveColumns).Columns != null)
                this.Configuration.Add("Columns", Enumerable.Range(0, (this.Control as IHaveColumns).Columns.Count).Select(ordinal => new CustomisationColumn(ordinal, (this.Control as IHaveColumns).Columns[ordinal])).ToArray());
        }

        /// <summary>
        ///     Updates the configuration table with database-persisted customisations.
        /// </summary>
        private void InitialiseCustom()
        {
            // Get the custom settings from the database and apply these as customised configurations
            this.Initialise<IHaveCustomIcon>("Icon", (config, control) => config.ConfiguredValue = this.ScreenObject.Icon);
            this.Initialise<IHaveCustomTitle>("Title", (config, control) => config.ConfiguredValue = this.ScreenObject.Title);
            this.Initialise<IHaveDefaultValue>("DefaultValue", (config, control) => config.ConfiguredValue = this.ScreenObject.Default);
            this.Initialise<ICanBeValidated>("ValidatorCritical", (config, control) => config.ConfiguredValue = this.ScreenObject.ValidatorCritical.ToString().ToLower());
            this.Initialise<ICanBeValidated>("ValidatorExpression", (config, control) => config.ConfiguredValue = this.ScreenObject.ValidatorExpression);
            this.Initialise<ICanBeValidated>("ValidatorMessage", (config, control) => config.ConfiguredValue = this.ScreenObject.ValidatorMessage);
            this.Initialise<IHaveMaxLength>("MaximumLength", (config, control) => config.ConfiguredValue = this.ScreenObject.MaximumLength);
            this.Initialise<ICanBeMandatory>("Requirement", (config, control) => config.ConfiguredValue = control.Requirement.ConvertTo<Int32>() % 2 == 1 ? control.Requirement.ConvertTo<Int32>().ToString() : this.ScreenObject.Requirement.ConvertTo<Int32>().ToString());
            this.Initialise<ICanBeReadOnly>("IsReadOnly", (config, control) => config.ConfiguredValue = Math.Abs(control.IsReadOnly.ConvertTo<Int32>()) == 2 ? null : (this.ScreenObject.Visibility == ScreenObjectVisibility.ReadOnly).ToString().ToLower());
            this.Initialise<ICanBeHidden>("IsHidden", (config, control) => config.ConfiguredValue = Math.Abs(control.IsHidden.ConvertTo<Int32>()) == 2 ? null : (this.ScreenObject.Visibility == ScreenObjectVisibility.Hidden).ToString().ToLower());
            this.Initialise<ICanBeSwitched>("OnText", (config, control) => config.ConfiguredValue = this.ScreenObject.OnText);
            this.Initialise<ICanBeSwitched>("OnColour", (config, control) => config.ConfiguredValue = this.ScreenObject.OnColour);
            this.Initialise<ICanBeSwitched>("OffText", (config, control) => config.ConfiguredValue = this.ScreenObject.OffText);
            this.Initialise<ICanBeSwitched>("OffColour", (config, control) => config.ConfiguredValue = this.ScreenObject.OffColour);

            // Get the item customisations for dropdown controls
            if (this.Control is IHaveListItems && !(this.Control as IHaveListItems).HasDataSource)
            {
                foreach (CustomisationItem item in this.Configuration["Items"] as CustomisationItem[])
                {
                    ScreenObjectEntry entry = this.ScreenObject.Entries.OfType<ScreenObjectEntry>().FirstOrDefault(e => e.Normal == item.Value);
                    item.CustomText = (entry == null) ? null : entry.Custom;
                    item.Displayed = (entry == null) ? true : !entry.Hide;
                }
            }

            // Get the security customisations
            if (this.Control is ICanBeReadOnly || this.Control is ICanBeHidden)
            {
                foreach (CustomisationSecurity security in this.Configuration["Security"] as CustomisationSecurity[])
                {
                    ScreenObjectDisplay display = this.ScreenObject.DisplayRules.OfType<ScreenObjectDisplay>().FirstOrDefault(e => e.PrincipalId == security.PrincipalId);
                    security.Visibility = display == null ? null : display.Visibility as ScreenObjectVisibility?;
                }
            }

            // Get the column customisations
            if (this.Control is IHaveColumns)
            {
                foreach (CustomisationColumn customColumn in this.Configuration["Columns"] as CustomisationColumn[])
                {
                    ScreenObjectColumn column = this.ScreenObject.Columns.OfType<ScreenObjectColumn>().FirstOrDefault(c => c.Ordinal == customColumn.Ordinal);
                    customColumn.CustomTitle = column == null ? null : column.CustomTitle;
                    customColumn.Exportable = column == null ? customColumn.Exportable : column.Exportable;
                    customColumn.Visible = column == null ? customColumn.Visible : column.Visible;
                }
            }
        }

        /// <summary>
        ///     Initialises the control/configuration, dependent upon the capabilities that are supported by the control
        /// </summary>
        private void Initialise<Capability>(String name, Action<CustomisationValue, Capability> action)
        {
            // Do not execute for controls which do not support the specified capability
            if (this.Control is Capability == false)
                return;

            // Ensure that the configuration table includes an entry for the supported capability
            if (!this.Configuration.ContainsKey(name))
                this.Configuration.Add(name, new CustomisationValue());

            // Invoke the specified action to initialise the configuration entry
            action.Invoke(this.Configuration[name] as CustomisationValue, this.Control.ConvertTo<Capability>());
        }
        
        /// <summary>
        ///     Gets the collection of customisations for the specified control.
        /// </summary>
        public static IEnumerable<Customisation> GetFromUI(Page page, string screenUrl, UserGroup[] groupMembership, CustomisationSecurity[] customisationSecurities)
        {
            // Get the applicable customisations
            Customisation[] controlCustomisations = GetFromUI(page as Control, screenUrl, customisationSecurities).ToArray();
            Customisation[] capableCustomisations = controlCustomisations.Where(customisation => customisation.Capabilities.Count() != 0).ToArray();
            String commonControlIdentifierPrefix = capableCustomisations.Where(custom => custom._control is Page == false).Select(cust => cust.ControlId).GetPrefix();

            int ordinal = 1;
            // Set a user-friendly identifier for each control
            foreach (Customisation customisation in capableCustomisations)
            {
                customisation.Ordinal = ordinal++;

                if (customisation._control is Page == false)
                    customisation.ControlName = String.Join(" ", customisation.ControlId.Substring(commonControlIdentifierPrefix.Length).Split('_', '$').Select(element => element.Substring(0, 1).ToUpper() + element.Substring(1).ToLower()));
                else
                    customisation.ControlName = "Page";

                if (customisation.Configuration.ContainsKey("IsCustomField") && (customisation.Configuration["IsCustomField"] as CustomisationValue).ApplicableValue.ConvertTo<bool>())
                {
                    customisation.Capabilities.Add("IsCustomField");
                }
            }

            return capableCustomisations;
        }

        /// <summary>
        ///     Gets the collection of customisations for the specified control.
        /// </summary>
        private static IEnumerable<Customisation> GetFromUI(Control control, string screenUrl, CustomisationSecurity[] customisationSecurities)
        {
            // Create the customisation for the specified control
            IEnumerable<Customisation> result = new Customisation[] { new Customisation(control, screenUrl, cloneSecurities(customisationSecurities)) };
            
                //result = result.Concat(control.Controls.OfType<Control>().SelectMany(GetFromUI, customisationSecurities));
            foreach(Control childControl in control.Controls)
            {
                if (control is IHaveNoChildren == false || childControl is CustomFieldInsertPointDiv)
                {
                    result = result.Concat(GetFromUI(childControl, screenUrl, customisationSecurities));
                }
            }
            return result;
        }

        public static IEnumerable<UserGroup> GetUserGroups(UserPrincipal principal)
        {
            IEnumerable<UserGroup> userGroups = UserGroupMember.FetchAllByPrincipalId(principal.Id).Select(mem => mem.Group);
            userGroups = userGroups.Concat(userGroups.SelectMany(group => Customisation.GetUserGroups(group.Principal)));
            return userGroups;
        }

        private static CustomisationSecurity[] cloneSecurities(CustomisationSecurity[] orig)
        {
            CustomisationSecurity[] clone = new CustomisationSecurity[orig.Length];
            int i = 0;

            foreach (CustomisationSecurity sec in orig)
            {
                clone[i] = new CustomisationSecurity(sec);
                i++;
            }

            return clone;
        }

        #endregion
    }

    /// <summary>
    ///     Represents a customisation configuration
    /// </summary>
    public class CustomisationValue
    {
        #region fields

        /// <summary>
        ///     The default value that is applied to the control.
        /// </summary>
        private Object _defaultValue;

        /// <summary>
        ///     The customised value that is applied to the control.
        /// </summary>
        private Object _configuredValue;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the default value that is applied to the control.
        /// </summary>
        public Object DefaultValue
        {
            get { return _defaultValue; }
            set { _defaultValue = value; }
        }

        /// <summary>
        ///    Gets or sets the customised value that is applied to the control.
        /// </summary>
        public Object ConfiguredValue
        {
            get { return _configuredValue; }
            set { _configuredValue = value; }
        }

        /// <summary>
        ///     Gets the applicable value for the configuration.
        /// </summary>
        internal Object ApplicableValue
        {
            get { return this.ConfiguredValue ?? this.DefaultValue; }
        }

        #endregion
    }

    /// <summary>
    ///     Stores customisation data for dropdown items.
    /// </summary>
    public class CustomisationItem
    {
        #region fields

        /// <summary>
        ///     The value of the item.
        /// </summary>
        private String _value;

        /// <summary>
        ///     The default text of the item.
        /// </summary>
        private String _defaultText;

        /// <summary>
        ///     The custom text for the item.
        /// </summary>
        private String _customText;

        /// <summary>
        ///     Specifies if the item is displayed.
        /// </summary>
        private Boolean _displayed;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the value of the item.
        /// </summary>
        public String Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        ///    Gets or sets the default text of the item.
        /// </summary>
        public String DefaultText
        {
            get { return _defaultText; }
            set { _defaultText = value; }
        }

        /// <summary>
        ///    Gets or sets the custom text for the item.
        /// </summary>
        public String CustomText
        {
            get { return _customText; }
            set { _customText = value; }
        }

        /// <summary>
        ///    Gets or sets whether  the item is displayed.
        /// </summary>
        public Boolean Displayed
        {
            get { return _displayed; }
            set { _displayed = value; }
        }

        #endregion

        #region constructors

        public CustomisationItem(ListItem source)
        {
            this.Value = source.Value;
            this.DefaultText = source.Text;
            this.CustomText = null;
            this.Displayed = true;
        }

        #endregion
    }

    /// <summary>
    ///     Stores customisation data for securable items.
    /// </summary>
    public class CustomisationSecurity
    {
        #region fields

        /// <summary>
        ///     The id of the security principal.
        /// </summary>
        private Int32 _principalId;

        /// <summary>
        ///     The name of the security principal.
        /// </summary>
        private String _principalName;

        /// <summary>
        ///     The overriding visibility for the security principal.
        /// </summary>
        private ScreenObjectVisibility? _visibility;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the id of the security principal.
        /// </summary>
        public Int32 PrincipalId
        {
            get { return _principalId; }
        }

        /// <summary>
        ///    Gets the name of the security principal.
        /// </summary>
        public String PrincipalName
        {
            get { return _principalName; }
        }

        /// <summary>
        ///    Gets or sets the overriding visibility for the security principal.
        /// </summary>
        public ScreenObjectVisibility? Visibility
        {
            get { return _visibility; }
            set { _visibility = value; }
        }

        #endregion

        #region constructors

        public CustomisationSecurity(UserPrincipal principal)
        {
            _principalId = principal.Id;
            _principalName = principal.Name;
            _visibility = null;
        }

        public CustomisationSecurity(CustomisationSecurity orig)
        {
            _principalId = orig.PrincipalId;
            _principalName = orig.PrincipalName;
            _visibility = orig.Visibility;
        }

        #endregion
    }

    /// <summary>
    ///     Stores customisation data for data table columns.
    /// </summary>
    public class CustomisationColumn
    {
        #region fields

        /// <summary>
        ///     The ordinal number of the column.
        /// </summary>
        private Int32 _ordinal;

        /// <summary>
        ///     The default title of the column.
        /// </summary>
        private String _defaultTitle;

        /// <summary>
        ///     The custom title of the column.
        /// </summary>
        private String _customTitle;

        /// <summary>
        ///     The exportable state of the column.
        /// </summary>
        private Boolean _exportable;

        /// <summary>
        ///     The visible state of the column.
        /// </summary>
        private Boolean _visible;

        #endregion

        #region properties
        /// <summary>
        ///    Gets the ordinal number of the column.
        /// </summary>
        public Int32 Ordinal
        {
            get { return _ordinal; }
        }

        /// <summary>
        ///    Gets the default title of the column
        /// </summary>
        public String DefaultTitle
        {
            get { return _defaultTitle; }
        }

        /// <summary>
        ///    Gets or sets the custom title of the column.
        /// </summary>
        public String CustomTitle
        {
            get { return _customTitle; }
            set { _customTitle = value; }
        }

        /// <summary>
        ///    Gets or sets the exportable state of the column.
        /// </summary>
        public Boolean Exportable
        {
            get { return _exportable; }
            set { _exportable = value; }
        }

        /// <summary>
        ///    Gets or sets the visible state of the column.
        /// </summary>
        public Boolean Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        #endregion

        #region constructors

        public CustomisationColumn(Int32 ordinal, DataTableColumn column)
        {
            _ordinal = ordinal;
            _defaultTitle = column.Title;
            _exportable = column.Exportable;
            _visible = column.Visible;
        }

        #endregion
    }

    // 4 - IHaveTableColumns
    // 5 - Security-Driven Visibility
}