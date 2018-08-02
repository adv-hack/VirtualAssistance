using Consensus.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     Renders a text/value field which is driven from a popup dialog.
    /// </summary>
    [ParseChildren(true)]
    public class PopupField : TextBase, ICanBeACustomField
    {
        #region fields

        /// <summary>
        ///     The url of the popup window that is used to select a value.
        /// </summary>
        private String _popupUrl;

        /// <summary>
        ///     The hidden field which persists the selected value from the popup.
        /// </summary>
        private HtmlInputHidden _hidden;

        /// <summary>
        ///     The collection of filters that are applied to the popup.
        /// </summary>
        private List<PopupFieldFilter> _filters;

        /// <summary>
        ///     Specifies the type of object that is represented by the popup.
        /// </summary>
        private String _valueUrlType;

        /// <summary>
        ///     Specifies the property that is displayed for the poup field text.
        /// </summary>
        private String _valueUrlText;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the control.
        /// </summary>
        public override String FieldValue
        {
            get { return this.Hidden.Value; }
            set { this.Hidden.Value = value; }
        }

        /// <summary>
        ///     Gets or sets the text of the control.
        /// </summary>
        public String FieldText
        {
            get { return this.Field.Text; }
            set { this.Field.Text = value; }
        }

        /// <summary>
        ///    Gets or sets the url of the popup window that is used to select a value.
        /// </summary>
        public String PopupUrl
        {
            get { return _popupUrl; }
            set { _popupUrl = value; }
        }

        /// <summary>
        ///    Gets the hidden field which persists the selected value from the popup.
        /// </summary>
        protected HtmlInputHidden Hidden
        {
            get
            {
                if (_hidden == null)
                    _hidden = new HtmlInputHidden();

                return _hidden;
            }
        }

        /// <summary>
        ///     Gets or sets the state information that the input control presents.
        /// </summary>
        public String DataBoundText
        {
            get { return this.FieldAttributes["data-bound-text"]; }
            set { this.FieldAttributes["data-bound-text"] = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }

        /// <summary>
        ///     Gets or sets the state information that the input control presents.
        /// </summary>
        public override String DataBoundValue
        {
            get { return this.Hidden.Attributes["data-bound-value"]; }
            set { this.Hidden.Attributes["data-bound-value"] = String.IsNullOrEmpty(value) ? null : value.Trim(); }
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
                string fieldId = this.Hidden.Attributes["custom-field-id"];
                return string.IsNullOrEmpty(fieldId) ? 0 : fieldId.ConvertTo<int>();
            }
            set
            {
                this.Hidden.Attributes["custom-field-id"] = value.ToString();
            }
        }

        /// <summary>
        ///     Gets the collection of filters that are applied to the popup.
        /// </summary>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public List<PopupFieldFilter> Filters
        {
            get
            {
                if (_filters == null)
                    _filters = new List<PopupFieldFilter>();

                return _filters;
            }
        }

        /// <summary>
        ///    Gets or sets the type of object that is represented by the popup. 
        /// </summary>
        public String ValueUrlType
        {
            get { return _valueUrlType; }
            set { _valueUrlType = value; }
        }

        /// <summary>
        ///    Gets or sets the property that is displayed for the poup field text. 
        /// </summary>
        public String ValueUrlText
        {
            get { return _valueUrlText; }
            set { _valueUrlText = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Initialises the control tree.
        /// </summary>
        protected override void InitialiseControlTree()
        {
            // Add the hidden field to the control tree and create the search add-on.
            base.InitialiseControlTree();
            this.Hidden.ID = String.Format("{0}Value", this.ID);
            this.Controls.Add(this.Hidden);
            this.GroupClass += " consensus-popup";
            this.Addons.Add(new AddOn() { Icon = "search" });
        }

        /// <summary>
        ///     Sets the initial value of the control.
        /// </summary>
        protected override void InitialiseControlValue()
        {
            if (String.IsNullOrEmpty(this.ValueUrlParameter) || !HttpContext.Current.Request.QueryString.AllKeys.Contains(this.ValueUrlParameter) || String.IsNullOrEmpty(HttpContext.Current.Request.QueryString[this.ValueUrlParameter]) || String.IsNullOrEmpty(this.ValueUrlType) || String.IsNullOrEmpty(this.ValueUrlText))
                return;

            Type type = Type.GetType(this.ValueUrlType + ", Consensus.Client", false);
            if (type == null)
                return;
            MethodInfo method = type.GetMethods(BindingFlags.Static | BindingFlags.Public).FirstOrDefault(m => m.Name == "FetchById" && m.GetParameters().Length == 1);
            if (method == null)
                return;

            Object result = method.Invoke(null, new Object[] { HttpContext.Current.Request.QueryString[this.ValueUrlParameter] });
            if (result == null)
                return;
            
            this.FieldValue = HttpContext.Current.Request.QueryString[this.ValueUrlParameter];
            this.FieldText = GetPropertyValue(result, this.ValueUrlText).ConvertTo<String>();
            this.IsReadOnly = this.ValueUrlIsEnforced ? ConfigurableBoolean.TrueEnforced : this.IsReadOnly;
        }
        
        /// <summary>
        ///     Initialises the control state.
        /// </summary>
        protected override void InitialiseControlState()
        {
            base.InitialiseControlState();
            
            // Construct the configuration for the popup
            StringBuilder javascript = new StringBuilder();
            javascript.AppendFormat("var {0} = new consensus.web.popupField('{0}', {{" + Environment.NewLine, this.ClientID);
            javascript.AppendFormat("  url: {0}", HttpUtility.JavaScriptStringEncode(VirtualPathUtility.ToAbsolute(this.PopupUrl), true) + ", ");
            javascript.Append("  onChange: function() { " + this.ClientOnChange + "},");
            javascript.Append("  filters: [" + String.Join(", ", this.Filters.Select(SerialiseFilter)) + "],");
            javascript.AppendFormat("}});");
            
            // Register the javascript
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, javascript.ToString(), true);
        }

        /// <summary>
        ///     Sets the onchange attribute of the underlying field.
        /// </summary>
        /// <remarks>
        ///     This attribute is no set on the popup field as onchange events are handled by the client-side control.
        /// </remarks>
        protected override void SetOnChangeAttribute()
        {
        }

        /// <summary>
        ///     Initialises the hyperlink attributes for the control.
        /// </summary>
        protected override void InitialiseHyperlink()
        {
            if (this.Hyperlink.Visible = !String.IsNullOrEmpty(this.HyperlinkUrl))
            {
                String absoluteUrl = this.HyperlinkUrl.StartsWith("~") ? VirtualPathUtility.ToAbsolute(this.HyperlinkUrl) : this.HyperlinkUrl;
                this.Attributes.Add("consensus-input-link", absoluteUrl);
                this.Hyperlink.Attributes.Add("class", "consensus-input-link");
                this.Hyperlink.Attributes.Add("href", absoluteUrl.Replace("{id}", this.FieldValue).Replace("{text}", this.FieldText));
                this.Hyperlink.InnerText = this.FieldText;
            }
        }

        private String SerialiseFilter(PopupFieldFilter filter)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("{");
            builder.AppendFormat("  parameter: '{0}',", HttpUtility.JavaScriptStringEncode(filter.ParameterName, false));
            builder.AppendFormat("  type: '{0}',", HttpUtility.JavaScriptStringEncode(filter.Type.ToString(), false));
            if (filter.Type == PopupFieldFilterTypes.Control)
            {
                Control control = this.GetControlTree(this.Page).FirstOrDefault(ctrl => String.Equals(ctrl.ID, filter.Value, StringComparison.OrdinalIgnoreCase));
                if (control != null)
                    builder.AppendFormat("  control: '{0}'", HttpUtility.JavaScriptStringEncode(control.ClientID, false));
            }
            else
            {
                builder.AppendFormat("  value: '{0}'", HttpUtility.JavaScriptStringEncode(filter.Value, false));
            }

            builder.Append("}");
            return builder.ToString();
        }

        private IEnumerable<Control> GetControlTree(Control parent)
        {
            List<Control> controls = new List<Control>();
            foreach (Control child in parent.Controls)
            {
                controls.Add(child);
                controls.AddRange(this.GetControlTree(child));
            }
            return controls;
        }

        private Object GetPropertyValue(Object source, String propertyName)
        {
            Object result = null;
            if (source != null)
            {
                String[] elements = propertyName.Split('.');
                PropertyInfo property = source.GetType().GetProperty(elements[0]);
                if (property != null)
                {
                    result = property.GetValue(source);
                    if (elements.Length > 1)
                        result = GetPropertyValue(result, String.Join(".", elements.Skip(1)));
                }
            }

            return result;
        }

        #endregion
    }
}
