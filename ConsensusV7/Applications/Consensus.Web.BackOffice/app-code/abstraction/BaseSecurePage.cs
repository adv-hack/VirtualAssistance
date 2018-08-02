using Consensus.Security;
using Consensus.UserInterface;
using Consensus.Web.BackOffice.assets.templates;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;

namespace Consensus.Web.BackOffice
{
    public abstract class BaseSecurePage : BasePage
    {
        #region fields

        /// <summary>
        ///     The collection of customisations that have been applied to this screen.
        /// </summary>
        private Dictionary<String, Dictionary<String, Object>> _customisations;

        /// <summary>
        ///     The custom fields for the page
        /// </summary>
        private IEnumerable<ScreenCustomField> _customFields;

        #endregion

        #region properties

        /// <summary>
        ///     The custom fields for the page
        /// </summary>
        public IEnumerable<ScreenCustomField> CustomFields
        {
            get { return _customFields; }
            set { _customFields = value; }
        }

        /// <summary>
        ///     If set to true, prevents custom fields from being shown or defined for the page.
        /// </summary>
        public virtual bool BlockCustomFields { get; set; }

        #endregion

        #region constructor

        public BaseSecurePage()
        {
            this.PreInit += BaseSecurePage_PreInit;
            this.PreRender += BaseSecurePage_PreRender;
        }

        #endregion

        #region page cycle
        
        private void BaseSecurePage_PreInit(Object sender, EventArgs e)
        {
            // Validate the authentication session.
            if (this.CurrentSession == null)
                this.TerminateRequest(401, "Unauthorised");

            // Validate the current license
            License license = License.GetCurrent();
            if (license.Status != LicenseStatus.OK && !String.Equals(this.Request.Url.AbsolutePath, VirtualPathUtility.ToAbsolute(WebGlobals.LicenseUrl)) && !this.Request.Url.PathAndQuery.Contains("context=security&control=licensekey"))
                this.TerminateRequest(428, "License Error");

            // Update the authentication session
            UserSession.Update();
        }

        protected override void OnInitComplete(EventArgs e)
        {
            base.OnInitComplete(e);

            if (!BlockCustomFields)
            {
                this.CustomFields = Consensus.UserInterface.ScreenCustomField.FetchAllByPage(GetPageLocation());
                CreateCustomFields();
            }
            // We are not making use of ViewState, so turning it off to save page space and processing time. 
            // Of the various places in which it can be turned off globally, this place seems to give the smallest residual __VIEWSTATE value.
            this.EnableViewState = false;
        }

        private void BaseSecurePage_PreRender(Object sender, EventArgs e)
        {
            if (this.CurrentSession.User.SysAdmin.ConvertTo<Boolean>())
            {
                // Get all of the controls on the page and apply customisations.
                Customisation.Cache = null;
                UserGroup[] groupMembership = { };
                if (this.CurrentSession != null && this.CurrentSession.Expiry > DateTime.Now)
                {
                    groupMembership = Customisation.GetUserGroups(this.CurrentSession.User.Principal).ToArray();
                }
                CustomisationSecurity[] customisationSecurities = UserGroup.FetchAll().Select(group => new CustomisationSecurity(group.Principal)).ToArray();

                string pageLoc = GetPageLocation();

                Customisation[] customisations = Customisation.GetFromUI(this, pageLoc, groupMembership, customisationSecurities).ToArray();
                customisations.Execute(customisation => customisation.InitialiseControl(groupMembership));

                // Register the customisations with the client-side script.
                
                string sScript = @"    
                    consensus.web.customisation.data = " + RestHandler.Serializer.Serialize(customisations) + @";
                    consensus.web.customisation.url = " + HttpUtility.JavaScriptStringEncode(pageLoc, true) + @";
                    consensus.web.customisation.blockCustomFields = " + BlockCustomFields.ToString().ToLower() + @";
                ";

                // Get custom fields and prepare serialisation to exclude the CustomFieldValues element (which would get values for all records)
                if (!BlockCustomFields)
                {
                    object baseObject;
                    PropertyInfo dataInfo = getDataInfo(out baseObject);
                    string dataURL = GetDataUrl(dataInfo);
                    string tableName = GetTableName(dataInfo, baseObject);

                    Dictionary<Type, List<string>> exclude = new Dictionary<Type, List<string>>();
                    exclude.Add(typeof(UserInterface.ScreenCustomField), new List<string>() { "CustomFieldValues" });
                    var excludingSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                    excludingSerializer.RegisterConverters(new System.Web.Script.Serialization.JavaScriptConverter[] { new RestSerializer() { Ignore = exclude } });

                    sScript += @"
                    consensus.web.customisation.customFields = " + excludingSerializer.Serialize(CustomFields) + @";
                    consensus.web.customisation.page = " + HttpUtility.JavaScriptStringEncode(pageLoc, true) + @";
                    consensus.web.customisation.dataurl = " + HttpUtility.JavaScriptStringEncode(dataURL, true) + @";
                    consensus.web.customisation.tableName = " + HttpUtility.JavaScriptStringEncode(tableName, true) + @";
                    ";
                }

                this.ClientScript.RegisterClientScriptBlock(this.GetType(), "CustomisationJS", sScript, true);
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Populates the control fields.
        /// </summary>
        //protected virtual void PopulateControl()
        //{
        //    Object value;

        //    if (!BlockCustomFields)
        //    {
        //        if (this.GetControlValue(this.DataSource, "Id", out value) && value != null)
        //            PopulateCustomFields(value.ToString());
        //    }
        //}

        //public string GetDataUrl()
        //{
        //    PropertyInfo dataInfo = getDataInfo();
        //    return GetDataUrl(dataInfo);
        //}
        private string GetDataUrl(PropertyInfo dataInfo)
        {
            if (dataInfo != null)
            {
                return dataInfo.PropertyType.FullName.Replace("Consensus.", "").Replace(".", "/");
            }
            else
            {
                return "";
            }
            //string _screenUrl = HttpContext.Current.Request.Url.PathAndQuery.Substring(VirtualPathUtility.ToAbsolute("~").Length);

            //if (_screenUrl.IndexOf("GenericPopup.aspx", StringComparison.InvariantCultureIgnoreCase) >= 0)
            //{
            //    _screenUrl = string.Format("/{0}/controls/{1}", HttpContext.Current.Request.QueryString["context"], HttpContext.Current.Request.QueryString["control"]);
            //}
            //else
            //{
            //    if (!_screenUrl.StartsWith("/"))
            //        _screenUrl = "/" + _screenUrl;
            //    if (_screenUrl.EndsWith("page.aspx", StringComparison.InvariantCultureIgnoreCase) || _screenUrl.IndexOf("page.aspx?", StringComparison.InvariantCultureIgnoreCase) > 0)
            //        _screenUrl = _screenUrl.Substring(0, _screenUrl.IndexOf("page.aspx", StringComparison.InvariantCultureIgnoreCase));
            //    else if (_screenUrl.EndsWith(".aspx", StringComparison.InvariantCultureIgnoreCase) || _screenUrl.IndexOf(".aspx?", StringComparison.InvariantCultureIgnoreCase) > 0)
            //        _screenUrl = _screenUrl.Substring(0, _screenUrl.IndexOf(".aspx", StringComparison.InvariantCultureIgnoreCase));
            //    else if (_screenUrl.IndexOf("?", StringComparison.InvariantCultureIgnoreCase) > 0)
            //        _screenUrl = _screenUrl.Substring(0, _screenUrl.IndexOf("?", StringComparison.InvariantCultureIgnoreCase));
            //}

            //return _screenUrl;
        }

        //public string GetTableName()
        //{
        //    object baseObject;
        //    PropertyInfo dataInfo = getDataInfo(out baseObject);
        //    return GetTableName(dataInfo, baseObject);
        //}

        private string GetTableName(PropertyInfo dataInfo, object baseObject)
        {
            if (dataInfo != null)
            {
                MethodInfo getTableInfo = dataInfo.PropertyType.GetMethod("GetTableName", new Type[0]);
                if (getTableInfo != null && baseObject != null)
                {
                    object oTableName = getTableInfo.Invoke(baseObject, new object[] { });
                    return (oTableName is string) ? (string)oTableName : "";
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }

        //private PropertyInfo getDataInfo()
        //{
        //    object baseObject;
        //    return getDataInfo(out baseObject);
        //}

        private PropertyInfo getDataInfo(out object baseObject)
        {
            baseObject = null;
            PropertyInfo dataInfo = null;
            if (this is BaseStandardPage)
            {
                dataInfo = this.GetType().GetProperty("Data");
                baseObject = this;
            }
            else if (this is BasePopupPage)
            {
                PropertyInfo controlInfo = this.GetType().GetProperty("Control");
                if (controlInfo != null)
                {
                    BaseControl popupControl = controlInfo.GetValue(this) as BaseControl;
                    baseObject = popupControl;

                    if (popupControl != null)
                    {
                        dataInfo = popupControl.GetType().GetProperty("DataSource");
                    }
                }
            }
            return dataInfo;
        }

        public string GetPageLocation()
        {
            string pageLoc = this.Page.AppRelativeVirtualPath.Replace("~/", "");
            if (pageLoc.Equals("GenericPopup.aspx", StringComparison.InvariantCultureIgnoreCase))
            {
                pageLoc += string.Format("?context={0}&control={1}", HttpUtility.UrlEncode(Request.QueryString["context"]), HttpUtility.UrlEncode(Request.QueryString["control"]));
            }
            return pageLoc;
        }


        protected virtual void CreateCustomFields()
        {
            if (CustomFields != null)
            {
                foreach (ScreenCustomField field in CustomFields)
                {
                    Control root = this; // this.Parent.ID == "ControlContainer" ? this.Parent.Parent : this;

                    ICustomFieldContainer container = GetControlTree<ICustomFieldContainer>(root).Where(control => control is Control && ((Control)control).ClientID == field.ParentControl).FirstOrDefault();
                    if (container == null)
                    {
                        container = GetControlTree<CustomFieldContainer>(root).FirstOrDefault();
                    }

                    BaseInputControl customField = null;
                    if (container != null)
                    {
                        switch (field.CftypeId)
                        {
                            case "Text":
                                customField = CreateCustomTextField(field);
                                break;
                            case "MultiLine":
                                customField = CreateCustomMultilineField(field);
                                break;
                            case "Checkbox":
                                customField = CreateCustomCheckboxField(field);
                                break;
                            case "Date":
                                customField = CreateCustomDateField(field);
                                break;
                            case "List":
                                customField = CreateCustomListField(field);
                                break;
                            case "Number":
                                customField = CreateCustomNumberField(field);
                                break;
                            case "PopupSearch":
                                customField = CreateCustomPopupField(field);
                                break;
                        }

                        if (customField != null && customField is ICanBeACustomField)
                        {
                            customField.LabelText = field.Label;
                            customField.ID = field.Name;
                            customField.DataBoundValue = "_customFields." + field.Name;
                            ((ICanBeACustomField)customField).CustomFieldId = field.Id;
                            ((ICanBeACustomField)customField).IsCustomField = true;

                            InjectCustomField(container, customField);
                        }
                    }
                }
            }
        }

        protected virtual void PopulateCustomFields(string recordId)
        {
            if (CustomFields != null)
            {
                foreach (ScreenCustomField field in CustomFields)
                {
                    // field.CustomFieldValues // don't access this directly - it will fetch the values for all records for this field.
                    ScreenCustomFieldValue fieldValue = ScreenCustomFieldValue.FetchByFieldIdAndRecordId(field.Id, recordId);
                    if (fieldValue != null)
                    {
                        //Control customField = FindControl(field.Name);
                        Control root = this; // this.Parent.ID == "ControlContainer" ? this.Parent.Parent : this;
                        BaseInputControl customField = this.GetControlTree<BaseInputControl>(root).Where(control => control.ID == field.Name).FirstOrDefault();
                        if (customField != null)
                        {
                            switch (field.CftypeId)
                            {
                                case "Text":
                                case "MultiLine":
                                    customField.FieldValueRaw = fieldValue.Text;
                                    break;
                                case "Checkbox":
                                    customField.FieldValueRaw = fieldValue.Number == 1;
                                    break;
                                case "Date":
                                    customField.FieldValueRaw = fieldValue.Date;
                                    break;
                                case "List":
                                    customField.FieldValueRaw = fieldValue.IdValue;
                                    break;
                                case "Number":
                                    customField.FieldValueRaw = fieldValue.Number;
                                    break;
                                case "PopupSearch":
                                    PopupField popup = (customField as PopupField);
                                    if (popup != null)
                                    {
                                        popup.FieldValueRaw = fieldValue.IdValue;
                                        popup.FieldText = fieldValue.Text;
                                        // Better to go and get the row from the database to ensure we get an up to date description on read - otherwise we are potentially showing stale data?
                                        // Abandoned this - there is no way of making it self-maintaining, i.e. no way of getting the object and description field returned by a particular search 
                                        // using just the Url.
                                        //popup.FieldText = resolvePopupText(field, fieldValue);
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private BaseInputControl CreateCustomTextField(ScreenCustomField field)
        {
            TextField textField = new TextField();
            return textField;
        }
        private BaseInputControl CreateCustomMultilineField(ScreenCustomField field)
        {
            TextField textField = new TextField();
            textField.TextMode = TextBoxMode.MultiLine;
            return textField;
        }
        private BaseInputControl CreateCustomCheckboxField(ScreenCustomField field)
        {
            return new CheckField();
        }
        private BaseInputControl CreateCustomDateField(ScreenCustomField field)
        {
            return new DateField();
        }
        private BaseInputControl CreateCustomNumberField(ScreenCustomField field)
        {
            TextField textField = new TextField();
            textField.TextMode = TextBoxMode.Number;
            return textField;
        }

        private BaseInputControl CreateCustomPopupField(ScreenCustomField field)
        {
            PopupField popupField = new PopupField();
            popupField.PopupUrl = field.PopupUrl;
            popupField.DataBoundText = "_customFields." + field.Name + ".Text";
            return popupField;
        }

        private BaseInputControl CreateCustomListField(ScreenCustomField field)
        {
            ListField listField = new ListField();
            listField.DisplayMember = "Text";
            listField.ValueMember = "IdValue";
            listField.DataSource = ScreenCustomFieldListitem.FetchAllByCfieldId(field.Id).ToList();
            return listField;
        }

        private void InjectCustomField(ICustomFieldContainer container, Control customField)
        {
            Panel rowDiv = new Panel();
            rowDiv.CssClass = "row";
            Panel colDiv = new Panel();
            colDiv.CssClass = "col-xs-12"; // Put each custom field on its own row for now. Working out the no of columns already used in a container is fiddly..
            colDiv.Controls.Add(customField);
            rowDiv.Controls.Add(colDiv);
            container.CustomFieldInsertPoint.Controls.Add(rowDiv);
        }
        
        //private string resolvePopupText(ScreenCustomField field, ScreenCustomFieldValue fieldValue)
        //{
        //    string retText = fieldValue.Text;
        //    
        //    switch(field.PopupUrl) // would need to extend this each time we add a new popup. don't want to do that...
        //    {
        //
        //    }
        //   OR:
        //      field.PopupUrl is, e.g.  ~/crm/popups/PersonSearch.aspx
        //      We could derive the popup class, e.g. Consensus.Web.BackOffice.crm.popups.PersonSearch from that, and instantiate it,
        //      but it doesn't directly tell us what we want to know, i.e. what is the client model class and what field in that class 
        //      holds the description.

        //    return retText;
        //}

        protected IEnumerable<OfType> GetControlTree<OfType>(Control parent)
        {
            List<Control> controls = new List<Control>();
            foreach (Control child in parent.Controls)
            {
                if (child is OfType)
                {
                    controls.Add(child);
                }
                controls.AddRange(GetControlTree<OfType>(child).ToList().ConvertAll<Control>(new Converter<OfType, Control>(o => o.ConvertTo<Control>())));
            }
            return controls.ConvertAll<OfType>(c => c.ConvertTo<OfType>());
        }

        protected Boolean GetControlValue(Object source, String memberName, out Object result)
        {
            Boolean success = false;
            result = null;

            if (source != null)
            {
                String dotPrefix = memberName.Contains('.') ? memberName.Substring(0, memberName.IndexOf('.')) : memberName;
                String dotSuffix = memberName.Contains('.') ? memberName.Substring(memberName.IndexOf('.') + 1) : null;
                MemberInfo member = source.GetType().GetMember(dotPrefix, BindingFlags.Public | BindingFlags.Instance).FirstOrDefault();
                if (success = (member is FieldInfo))
                    result = (member as FieldInfo).GetValue(source);
                else if (success = (member is PropertyInfo && (member as PropertyInfo).CanRead))
                    result = (member as PropertyInfo).GetValue(source);
                if (success && result != null && dotSuffix != null)
                    success = GetControlValue(result, dotSuffix, out result);
            }
            return success;
        }

        #endregion
    }
}