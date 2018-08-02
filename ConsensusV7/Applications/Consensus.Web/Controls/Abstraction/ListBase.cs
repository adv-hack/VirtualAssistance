using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Searches;

namespace Consensus.Web.Controls
{
    [ParseChildren(true)]
    public class ListBase : BaseInputControl<DropDownListNoValidate, String>, ICanBeMandatory, IHaveDefaultValue, ICanBeHidden, ICanBeReadOnly, IHaveCustomTitle
    {
        #region fields

        /// <summary>
        ///     The in-memory persisted field value.
        /// </summary>
        private String _fieldValue;

        /// <summary>
        ///     Tracks whether an external data source has been loaded into the list.
        /// </summary>
        private Boolean _hasDataSource;

        /// <summary>
        ///     The data source definition, if runnable.
        /// </summary>
        private IRunnable _dataSource;

        private bool _clientSideInitialise;
        private bool _clientSideRefresh;

        private string _displayMember;
        private string _valueMember;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the in-memory persisted field value.
        /// </summary>
        public override String FieldValue
        {
            get
            {
                if (this.Field.SelectedIndex != -1)
                    return this.Field.SelectedValue;
                else if (this.Field.Items.Count == 0 || this.Field.Items.OfType<ListItem>().Any(item => String.Equals(item.Value, _fieldValue, StringComparison.OrdinalIgnoreCase)))
                    return _fieldValue;
                else
                    return null;
            }
            set
            {
                _fieldValue = value;

                if (this._dataSource != null && ClientSideInitialise && !string.IsNullOrEmpty(_fieldValue) && (this.Field.Items.Count == 0 || this.Field.Items[0].Value == ""))
                    this.Field.Items.Insert(0, new ListItem("", _fieldValue)); // The description will be resolved client side on page load (we assume). 

                Int32 index = Enumerable.Range(0, this.Field.Items.Count).Where(i => String.Equals(this.Field.Items[i].Value, value, StringComparison.OrdinalIgnoreCase)).Select(i => i + 1).FirstOrDefault() - 1;
                this.Field.SelectedIndex = index;
            }
        }

        /// <summary>
        ///     Gets or sets the list of custom attributes to be included in the dropdown list. Each attribute
        ///     set will cause an attribute to be generated on each option named "data-" + attribute.Name
        ///     and attribute.Value is the field name in the data which will be fetched and applied to the option
        ///     attribute value. Thus Attributes.Add(new ListAttribute() { Name = "next-exists", Value = "NEXT_EXISTS" })
        ///     might cause options to be generated like:
        ///     </option><option value="Ageing" data-next-exists="1">Ageing</option>
        ///     <option value="RNA" data-next-exists="0">RNA</option>
        /// </summary>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public new List<ListAttribute> Attributes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the data source of the dropdown control, which can either be the actual data as understood by the contained DropDownList control
        ///     (generally a List of data items with a display member of the item set by DisplayMember and optional value member set by ValueMember) 
        ///     or it can be an instance of Consensus.Searches.IRunnable (generally, a Query, a Search or a RestData instance).
        ///     If it is IRunnable, then if ClientSidePopulation is not set then the definition will be run and applied to the DropDownList data source.
        ///     If ClientSidePopulation is set then the IRunnable source will be serialised to the client OnPreRender, populating the list on
        ///     the client side when the list is dropped down. DisplayMember and (optionally) ValueMember must be set to field names in the 
        ///     returned data.
        /// </summary>
        public Object DataSource
        {
            get
            {
                if (this._dataSource != null)
                    return this._dataSource;
                else
                    return this.Field.DataSource;
            }
            set
            {
                this.HasDataSource = (value != null);

                if (value is IRunnable)
                {
                    this._dataSource = (IRunnable)value;
                }
                else
                {
                    this._dataSource = null;
                    this.Field.DataSource = value;
                }
                populate();
            }
        }

        private void populate()
        {
            String originalValue = this.FieldValue;
            String originalText = this.Field.SelectedIndex >= 0 ? this.Field.SelectedItem.Text : "";
            String valueMember = this.ValueMember;
            String displayMember = this.DisplayMember;

            this.Field.Items.Clear();
            this.Field.SelectedIndex = -1;
            this.Field.SelectedValue = null;
            this.Field.ClearSelection();

            this.Field.DataTextField = displayMember;
            this.Field.DataValueField = valueMember;

            IEnumerable sourceData = (this.Field.DataSource is IEnumerable) ? (IEnumerable)this.Field.DataSource : null;

            if (this._dataSource is IRunnable)
            {
                if (ClientSideInitialise)
                {
                    this.Field.DataSource = null;
                    sourceData = null;
                    if (!string.IsNullOrEmpty(originalText))
                        this.Field.Items.Insert(0, new ListItem(originalText, originalValue));
                }
                else
                {
                    if (this._dataSource is ISearchesRunnable)
                    {
                        // Have to change the type of the collection to prevent DataBind from blowing up.
                        Dictionary<string, object>[] data = ((ISearchesRunnable)this._dataSource).Run();
                        sourceData = data;
                        List<ListItem> listData = new List<ListItem>();
                        foreach (var row in data)
                        {
                            object text = null;
                            object val = null;
                            if (row.TryGetValue(this.DisplayMember, out text))
                            {
                                if (!string.IsNullOrEmpty(this.ValueMember))
                                    row.TryGetValue(this.ValueMember, out val);

                                listData.Add(new ListItem(text.ToString(), val == null ? text.ToString() : val.ToString()));
                            }
                        }

                        this.Field.DataTextField = "";
                        this.Field.DataValueField = "";
                        this.Field.DataSource = listData;
                    }
                    else
                    {
                        this.Field.DataSource = this._dataSource.Run();
                    }
                }
            }

            this.Field.DataBind();
            if (sourceData != null)
                applyAttributes(sourceData);
            this.Field.Items.Insert(0, new ListItem());

            this.FieldValue = originalValue;
        }

        private void applyAttributes(IEnumerable sourceData)
        {
            // Append the required attributes to the items in the list
            if (this.Attributes != null && this.Attributes.Count != 0)
            {
                foreach (Object dataItem in sourceData)
                {
                    string fieldName = string.IsNullOrEmpty(this.ValueMember) ? this.DisplayMember : this.ValueMember;

                    object dataItemValue = null;
                    if (dataItem is IDictionary)
                        dataItemValue = ((IDictionary)dataItem)[fieldName];
                    else
                        dataItemValue = ListBase.GetPropertyValue(dataItem, fieldName);
                    if (dataItemValue != null)
                    {
                        ListItem item = this.Field.Items.OfType<ListItem>().FirstOrDefault(listItem => listItem.Value == dataItemValue.ToString());
                        if (item != null)
                        {
                            foreach (ListAttribute attribute in this.Attributes)
                            {
                                object attrValue = null;
                                if (dataItem is IDictionary)
                                {
                                    if (((IDictionary)dataItem).Contains(attribute.Value))
                                        attrValue = ((IDictionary)dataItem)[attribute.Value];
                                }
                                else
                                {
                                    attrValue = ListBase.GetPropertyValue(dataItem, attribute.Value);
                                }

                                if (attrValue != null)
                                {
                                    item.Attributes.Add("data-" + attribute.Name.ToLower(), attrValue.ToString());
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        ///    Gets whether an external data source has been loaded into the list.
        /// </summary>
        public Boolean HasDataSource
        {
            get { return _hasDataSource; }
            private set { _hasDataSource = value; }
        }

        /// <summary>
        ///     Gets or sets the field of the data source that provides the text content of the list items.
        /// </summary>
        public String DisplayMember
        {
            get { return this._displayMember; }
            set {
                this._displayMember = value;
                this.Field.DataTextField = value;
            }
        }

        /// <summary>
        ///     Gets or sets the field of the data source that provides the value of the list items.
        /// </summary>
        public String ValueMember
        {
            get { return this._valueMember; }
            set {
                this._valueMember = value;
                this.Field.DataValueField = value;
            }
        }

        public bool ClientSideInitialise {
            get { return _clientSideInitialise; }
            set
            {
                _clientSideInitialise = value;
                populate();
            }
        }

        public bool ClientSideRefresh
        {
            get { return _clientSideRefresh; }
            set { _clientSideRefresh = value; }
        }

        #endregion

        #region methods
        
        protected override void InitialiseControlState()
        {
            // Ensure that the value member has been specified
            base.InitialiseControlState();
            if (String.IsNullOrEmpty(this.ValueMember))
                this.ValueMember = this.DisplayMember;

        }

        private static Object GetPropertyValue(Object source, String propertyName)
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

        private string serialiseDataSource()
        {
            string JSON = "";

            if (this.DataSource != null && (ClientSideInitialise || ClientSideRefresh)) {
                Type dataSourceType = DataSource.GetType();
                object ldata = this.DataSource;
                if (ldata is SearchModel || ldata is QueryModel || SearchesSerializer.Instance.SupportedTypes.Any(t => t.IsAssignableFrom(dataSourceType)))
                {
                    if (ldata is SearchModel)
                        ldata = new Searches.Search((SearchModel)ldata);
                    else if (ldata is QueryModel)
                        ldata = new Query((QueryModel)ldata);
                    JSON = SearchesSerializer.Serializer.Serialize(ldata);
                }
            }
            return JSON;
        }
        #endregion

        #region page cycle

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            if (this._dataSource != null && (ClientSideInitialise || ClientSideRefresh))
            {
                string JSON = serialiseDataSource();

                StringBuilder script = new StringBuilder();

                string sourceType = "";
                if (this._dataSource is QueryModel || this._dataSource is Query)
                    sourceType = "Searches/Query";
                else if (this._dataSource is SearchModel || this._dataSource is Searches.Search)
                    sourceType = "Searches/Search";
                else
                    sourceType = this._dataSource.GetType().FullName.Replace("Consensus.", "").Replace(".", "/");

                string rowAttributes = "";
                if (Attributes != null && Attributes.Count > 0)
                {
                    System.Web.Script.Serialization.JavaScriptSerializer szr = new System.Web.Script.Serialization.JavaScriptSerializer();
                    rowAttributes = szr.Serialize(Attributes);
                }

                script.AppendFormat("var {0} = new consensus.web.list({1}, {{", this.ClientID, System.Web.HttpUtility.JavaScriptStringEncode(this.ClientID, true)); script.AppendLine();
                script.AppendFormat("       displayMember: {0}", System.Web.HttpUtility.JavaScriptStringEncode(this.DisplayMember, true)); script.AppendLine();
                script.AppendFormat("       ,valueMember: {0}", System.Web.HttpUtility.JavaScriptStringEncode(this.ValueMember, true)); script.AppendLine();
                if (!string.IsNullOrWhiteSpace(rowAttributes))
                    script.AppendFormat("       ,rowAttributes: {0}", rowAttributes); script.AppendLine();
                script.AppendFormat("       ,clientSideInit: {0}", ClientSideInitialise ? "true" : "false");
                script.AppendLine(  "});");
                script.AppendFormat("{0}.setPopulator(new consensus.populator({{", this.ClientID); script.AppendLine();
                script.AppendFormat("       dataSource: {0}", JSON); script.AppendLine();
                script.AppendFormat("       ,sourceType: {0}", System.Web.HttpUtility.JavaScriptStringEncode(sourceType, true)); script.AppendLine();
                script.AppendLine(" }));");

                Page.ClientScript.RegisterStartupScript(Page.GetType(), this.ClientID + "_dd", script.ToString(), true);

                Field.ValidateRequestMode = ValidateRequestMode.Disabled;
            }
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


