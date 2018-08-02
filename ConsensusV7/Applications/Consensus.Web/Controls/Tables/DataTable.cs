using Consensus.Searches;
using Consensus.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;

namespace Consensus.Web.Controls
{
    [ParseChildren(true)]
    public class DataTable : BaseControl, ICanBeHidden, IHaveColumns
    {
        #region fields

        /// <summary>
        ///     The modification mode used by the table.
        /// </summary>
        private DataTableModes _mode;

        /// <summary>
        ///     The data source used by the table.
        /// </summary>
        /// <remarks>
        ///     This can be either a <see cref="String" /> property which binds the grid to an object property, or a <see cref="QueryModel" />, <see cref="SearchModel" /> or <see cref="RestCall"/> 
        ///     for dynamic database query construction and execution.
        /// </remarks>
        private Object _data;

        /// <summary>
        ///     The url of the user control or page that is used to modify an instance of the data.
        /// </summary>
        private String _url;

        /// <summary>
        ///     The creation mode used by the table.
        /// </summary>
        private DataTableModes? _createMode;

        /// <summary>
        ///     The url of the user control or page that is used to create an instance of the data.
        /// </summary>
        private String _createUrl;

        /// <summary>
        ///     The json-formatted object used when creating a new object instance.
        /// </summary>
        private String _json;

        /// <summary>
        ///     The collection of programmatically defined buttons.
        /// </summary>
        private List<DataTableTool> _toolbarItems;

        /// <summary>
        ///     The collection of programmatically defined columns.
        /// </summary>
        private List<DataTableColumn> _columns;

        /// <summary>
        ///     The number of rows to display per page or zero to show all rows.
        /// </summary>
        private Int32 _pageSize = 25;

        /// <summary>
        ///     Specifies whether the page size can be selected 
        /// </summary>
        private Boolean _showPageSize = false;

        /// <summary>
        ///     Specifies whether the standard export options are displayed
        /// </summary>
        private Boolean _showButtons = true;

        /// <summary>
        ///     Specifies if the filter functionality is enabled.
        /// </summary>
        private Boolean _showFilter = true;

        /// <summary>
        ///     Specifies records can be created in edit mode.
        /// </summary>
        private Boolean _canCreateInEditMode = false;

        /// <summary>
        ///     Specifies records can be modified in edit mode.
        /// </summary>
        private bool _canModifyInEditMode = false;

        /// <summary>
        ///     Specifies whether the field is hidden.
        /// </summary>
        private ConfigurableBoolean _isHidden = ConfigurableBoolean.False;

        /// <summary>
        ///     The name of the property by which rows are grouped.
        /// </summary>
        private String _groupBy;

        private RestSerializationDepth _serializeListsAtDepth = RestSerializationDepth.None;
        private RestSerializationDepth _serializeGoToDepth = RestSerializationDepth.Child;
        private RestSerializationDepth _serializeListsToDepth = RestSerializationDepth.Root;
        private ConfigurableBoolean _clientSideRefresh = ConfigurableBoolean.True;
        private ConfigurableBoolean _clientSideInitialise = ConfigurableBoolean.False;

        #endregion

        #region properties

        /// <summary>
        ///     Specifies whether new records can be added to the table.
        /// </summary>
        public Boolean CanCreate
        {
            get;
            set;
        }

        /// <summary>
        ///     Specifies whether existing records can be modified within the table.
        /// </summary>
        public Boolean CanModify
        {
            get;
            set;
        }

        /// <summary>
        ///     Specifies whether filter functionality is enabled
        /// </summary>
        public Boolean CanSearch
        {
            get;
            set;
        }

        /// <summary>
        ///     Specifies whether export functionality is enabled
        /// </summary>
        public Boolean CanExport
        {
            get;
            set;
        }

        /// <summary>
        ///     Specifies whether print functionality is enabled
        /// </summary>
        public Boolean CanPrint
        {
            get;
            set;
        }

        /// <summary>
        ///     Specifies whether page size can be modified by the user
        /// </summary>
        public Boolean CanResize
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the initial page size, i.e. the number of rows displayed per page (zero to disable paging)
        /// </summary>
        public Int32 PageSize
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the hight in pixels. This is only used if PageSize is 0, i.e. we are scrolling, not paging.
        /// </summary>
        public int ScrollHeight { get; set; }

        /// <summary>
        ///     Gets the HTML element that is rendered for this control.
        /// </summary>
        protected override HtmlTextWriterTag TagKey
        {
            get { return HtmlTextWriterTag.Table; }
        }

        /// <summary>
        ///    Gets or sets the modification mode used by the table.
        /// </summary>
        public DataTableModes Mode
        {
            get { return _mode; }
            set { _mode = value; }
        }

        /// <summary>
        ///    Gets or sets the data source used by the table.
        /// </summary>
        /// <remarks>
        ///     This can be either a <see cref="String" /> property which binds the grid to an object property, or a <see cref="QueryModel" /> / <see cref="SearchModel" />
        ///     for dynamic database query construction and execution.
        /// </remarks>
        public Object Data
        {
            get { return _data; }
            set { _data = value; }
        }

        /// <summary>
        ///     Gets or sets the url of the user control or page that is used to modify an instance of the data.
        /// </summary>
        public String Url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        ///     Gets or sets the url of the user control or page that is used to create an instance of the data.
        /// </summary>
        public String CreateUrl
        {
            get { return _createUrl == String.Empty ? null : _createUrl; }
            set { _createUrl = value; }
        }

        /// <summary>
        ///    Gets or sets the creation mode used by the table.
        /// </summary>
        public DataTableModes? CreateMode
        {
            get { return _createMode; }
            set { _createMode = value; }
        }

        /// <summary>
        ///    Gets or sets the json-formatted object used when creating a new object instance.
        /// </summary>
        /// <remarks>
        ///     This property is required when using <see cref="DataTableModes.RealTime" /> to ensure that
        ///     the reference to the parent object is defined, along with the uri to which the REST call is made to 
        ///     create the new object.
        /// </remarks>
        public String Json
        {
            get { return _json; }
            set { _json = value; }
        }

        public string DataBoundValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Is the table populated client side? Defaults to true, but only takes effect if we are not using Stateless or Redirect modes.
        /// </summary>
        public ConfigurableBoolean ClientSideRefresh { get { return _clientSideRefresh; } set { _clientSideRefresh = value; } }
        public ConfigurableBoolean ClientSideInitialise { get { return _clientSideInitialise; } set { _clientSideInitialise = value; } }

        protected bool CreatingPopulator
        {
            get
            {
                return (ClientSideRefresh == ConfigurableBoolean.TrueEnforced 
                    || ClientSideInitialise == ConfigurableBoolean.TrueEnforced
                    || (
                        (ClientSideRefresh == ConfigurableBoolean.True || ClientSideInitialise == ConfigurableBoolean.True)
                        && this._data != null 
                        && this._data is IRunnable
                        && (CreateMode == null || CreateMode == DataTableModes.RealTime) 
                        && Mode == DataTableModes.RealTime)
                    );
            }
        }

        /// <summary>
        ///    Gets the collection of programmatically defined buttons.
        /// </summary>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public List<DataTableTool> ToolbarItems
        {
            get
            {
                if (_toolbarItems == null)
                    _toolbarItems = new List<DataTableTool>();

                return _toolbarItems;
            }
        }

        /// <summary>
        ///    Gets the collection of programmatically defined columns.
        /// </summary>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public List<DataTableColumn> Columns
        {
            get
            {
                if (_columns == null)
                    _columns = new List<DataTableColumn>();

                return _columns;
            }
        }

        /// <summary>
        ///    Gets or sets the can create in edit mode, so that records can be created from search popups.
        /// </summary>
        public Boolean CanCreateInEditMode
        {
            get { return _canCreateInEditMode; }
            set { _canCreateInEditMode = value; }
        }
        
        /// <summary>
        ///    Gets or sets the can modify in edit mode, so that records on popups can be edited.
        /// </summary>
        public Boolean CanModifyInEditMode
        {
            get { return _canModifyInEditMode; }
            set { _canModifyInEditMode = value; }
        }

        /// <summary>
        ///     Gets or sets the client-side handler for the oncreate event.
        /// </summary>
        public String OnCreate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the client-side handler for the onmodify event.
        /// </summary>
        public String OnModify
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the client-side handler for the ondelete event.
        /// </summary>
        public String OnDelete
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the client-side handler for the onchange event.
        /// </summary>
        public String OnChange
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets whether the page is hidden.
        /// </summary>
        public ConfigurableBoolean IsHidden
        {
            get { return _isHidden; }
            set { _isHidden = value; }
        }

        /// <summary>
        ///    Gets or sets the name of the property by which rows are grouped.
        /// </summary>
        public String GroupBy
        {
            get { return _groupBy; }
            set { _groupBy = value; }
        }

        public RestSerializationDepth SerializeListsAtDepth
        {
            get { return _serializeListsAtDepth; }
            set { _serializeListsAtDepth = value; }
        }

        public RestSerializationDepth SerializeGoToDepth
        {
            get { return _serializeGoToDepth; }
            set { _serializeGoToDepth = value; }
        }

        public RestSerializationDepth SerializeListsToDepth
        {
            get { return _serializeListsToDepth; }
            set { _serializeListsToDepth = value; }
        }

        

        #endregion

        #region constructor

        public DataTable()
        {
            // Apply the required grid styles
            this.Style[HtmlTextWriterStyle.Width] = "100%";
            this.CssClass = "table table-striped table-bordered";

            // Apply default options
            this.CanCreate = true;
            this.CanModify = true;
            this.CanSearch = true;
            this.CanExport = true;
            this.CanPrint = true;
            this.CanResize = false;
            this.PageSize = 15;
            this.ScrollHeight = 600;
        }

        #endregion

        #region page cycle

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            // Initialise the data columns, if required.
            if (this.Columns.Count == 0 && this.Data is QueryModel)
                this.Columns.AddRange((this.Data as QueryModel).Selects.Select(column => new DataTableTextColumn() { Title = column.Alias.TrimOrNullify() ?? column.Column, FieldName = column.Column }));

            // Initialise the button columns, if required.
            if (!this.Columns.OfType<DataTableButtonColumn>().Any())
            {
               
                DataTableButtonColumn buttonColumn = new DataTableButtonColumn();
                buttonColumn.CssClass = (this.Mode == DataTableModes.Stateful || this.CanModifyInEditMode) ? "consensus-visible-edit" : "consensus-visible-read";

                if (this.CanModify && this.Mode == DataTableModes.Redirect)
                    buttonColumn.Buttons.Add(new DataTableButtonColumnItem() { Icon = "view_file", Tooltip = "View", OnClick = this.ClientID + ".modify(this);" });
                if (this.CanModify && this.Mode != DataTableModes.Redirect)
                    buttonColumn.Buttons.Add(new DataTableButtonColumnItem() { Icon = "edit_row", Tooltip = "Edit", OnClick = this.ClientID + ".modify(this);" });
                if (buttonColumn.Buttons.Count > 0)
                    this.Columns.Insert(0,buttonColumn);

                buttonColumn.Width = new System.Web.UI.WebControls.Unit(buttonColumn.Buttons.Count * 20, System.Web.UI.WebControls.UnitType.Pixel);
            }

            // Initialise the toolbar items
            Int32[] exportColumns = Enumerable.Range(0, this.Columns.Count).Where(i => this.Columns[i].Exportable).ToArray();
            if (this.CanCreate)
                this.ToolbarItems.Add(new DataTableToolCustom() { Text = "Add", CssClass = "btn btn-success mr-2 consensus-visible-" + (this.CanCreateInEditMode ? "edit" : (this.CreateMode ?? this.Mode) == DataTableModes.Stateful ? "edit" : "read"), Action = this.ClientID + ".create();" });
            if (this.CanExport && !this.ToolbarItems.OfType<DataTableToolExport>().Any(button => button.Type == DataTableToolExportTypes.Copy))
                this.ToolbarItems.Add(new DataTableToolExport() { Type = DataTableToolExportTypes.Copy, Text = "Copy", CssClass = "btn btn-outline-secondary", ColumnIndices = exportColumns });
            if (this.CanExport && !this.ToolbarItems.OfType<DataTableToolExport>().Any(button => button.Type == DataTableToolExportTypes.PDF))
                this.ToolbarItems.Add(new DataTableToolExport() { Type = DataTableToolExportTypes.PDF, Text = "PDF", CssClass = "btn btn-outline-secondary", ColumnIndices = exportColumns });
            if (this.CanExport && !this.ToolbarItems.OfType<DataTableToolExport>().Any(button => button.Type == DataTableToolExportTypes.CSV))
                this.ToolbarItems.Add(new DataTableToolExport() { Type = DataTableToolExportTypes.Excel, Text = "Excel", CssClass = "btn btn-outline-secondary", ColumnIndices = exportColumns });
            if (this.CanPrint && !this.ToolbarItems.OfType<DataTableToolPrint>().Any())
                this.ToolbarItems.Add(new DataTableToolPrint() { Text = "Print", CssClass = "btn btn-outline-secondary", ColumnIndices = exportColumns });

            // Serialize the grid information
            String data = CreatingPopulator && (ClientSideInitialise == ConfigurableBoolean.True || ClientSideInitialise == ConfigurableBoolean.TrueEnforced) ? "[]" : this.SerializeData();
            String buttons = String.Join(", ", this.ToolbarItems.Select(tool => tool.Definition));
            String columns = String.Join(", ", this.Columns.Select(column => column.Definition));
            int pageSize = this.PageSize;

            DataTableReorderColumn reorderCol = null;
            if (this.Columns.Any(column => column is DataTableReorderColumn))
            {
                reorderCol = (DataTableReorderColumn)this.Columns.First(column => column is DataTableReorderColumn);
                pageSize = 0; // Paging and drag/drop reordering do not mix.
            }
            

            // Register the javascript to initialise the grid
            StringBuilder javascript = new StringBuilder();
            javascript.AppendFormat("var {0} = new consensus.web.dataTable({{", this.ClientID);
            javascript.AppendLine();
            javascript.AppendFormat("  modifyMode: {0},", HttpUtility.JavaScriptStringEncode(this.Mode.ToString(), true)); javascript.AppendLine();
            javascript.AppendFormat("  modifyHref: {0},", HttpUtility.JavaScriptStringEncode(this.Url, true)); javascript.AppendLine();
            javascript.AppendFormat("  createMode: {0},", HttpUtility.JavaScriptStringEncode((this.CreateMode ?? this.Mode).ToString(), true)); javascript.AppendLine();
            javascript.AppendFormat("  createHref: {0},", HttpUtility.JavaScriptStringEncode(this.CreateUrl ?? this.Url, true)); javascript.AppendLine();
            javascript.AppendFormat("  createJson: {0},", this.Json ?? "null"); javascript.AppendLine();
            javascript.AppendFormat("  sourceData: {0},", data); javascript.AppendLine();
            javascript.AppendFormat("  sourceType: {0}, ", HttpUtility.JavaScriptStringEncode(this.Data is String ? "binding" : "object", true)); javascript.AppendLine();
            javascript.AppendFormat("  clientSideInit: {0},", (ClientSideInitialise == ConfigurableBoolean.True || ClientSideInitialise == ConfigurableBoolean.TrueEnforced) ? "true" : "false"); javascript.AppendLine();
            javascript.AppendFormat("  listsAtDepth: '{0}',", this.SerializeListsAtDepth); javascript.AppendLine();
            javascript.AppendFormat("  goToDepth: '{0}',", this.SerializeGoToDepth); javascript.AppendLine();
            javascript.AppendFormat("  listsToDepth: '{0}',", this.SerializeListsToDepth); javascript.AppendLine();    
                    
            javascript.AppendFormat("  tableElement: {0},", HttpUtility.JavaScriptStringEncode(this.ClientID, true)); javascript.AppendLine();
            if (!string.IsNullOrEmpty(this.DataBoundValue))
            {
                javascript.AppendFormat("  dataBoundValue: {0},", HttpUtility.JavaScriptStringEncode(this.DataBoundValue, true)); javascript.AppendLine();
            }
            javascript.AppendFormat("  reorderable: {0},", (reorderCol == null) ? "false" : "true"); javascript.AppendLine();
            if (reorderCol != null)
            {
                javascript.AppendFormat("  orderField: '{0}',", reorderCol.ModelFieldName);
                javascript.AppendFormat("  orderColumnIx: {0},", this.Columns.FindIndex(column => column is DataTableReorderColumn)); javascript.AppendLine();
            }
            javascript.AppendFormat("  tableOptions: {{"); javascript.AppendLine();
            javascript.AppendFormat("    info: false,"); javascript.AppendLine();
            javascript.AppendFormat("    select: false,"); javascript.AppendLine();
            javascript.AppendFormat("    searching: {0},", this.CanSearch.ToString().ToLower()); javascript.AppendLine();
            javascript.AppendFormat("    lengthChange: {0},", this.CanResize.ToString().ToLower()); javascript.AppendLine();
            javascript.AppendFormat("    paging: {0},", pageSize > 0 ? "true" : "false"); javascript.AppendLine();
            if (PageSize > 0)
            {
                javascript.AppendFormat("    pageLength: {0},", pageSize); javascript.AppendLine();
            }
            else
            {
                javascript.AppendFormat("    scrollY: {0}, ", this.ScrollHeight); javascript.AppendLine();
                javascript.AppendFormat("    scrollCollapse: true,"); javascript.AppendLine();            
            }
            javascript.AppendFormat("    responsive: true,"); javascript.AppendLine();
            if (reorderCol != null)
            {
                javascript.AppendFormat("    rowReorder: {{"); javascript.AppendLine();
                javascript.AppendFormat("       dataSrc: '{0}',", reorderCol.FieldName); javascript.AppendLine();
                javascript.AppendFormat("       selector: 'td:not(.datatable-buttons):not(:has(a))',"); javascript.AppendLine();
                javascript.AppendFormat("       update: true"); javascript.AppendLine();
                javascript.AppendFormat("    }},"); javascript.AppendLine();
            }
            if (!String.IsNullOrEmpty(this.GroupBy))
            {
                javascript.AppendFormat("    rowGroup: {{"); javascript.AppendLine();
                javascript.AppendFormat("       dataSrc: '{0}'", this.GroupBy); javascript.AppendLine();
                javascript.AppendFormat("    }},"); javascript.AppendLine();
            }
            javascript.AppendFormat("    buttons: [{0}],", buttons); javascript.AppendLine();
            javascript.AppendFormat("    columns: [{0}],", columns); javascript.AppendLine();
            if (reorderCol != null)
            {
                javascript.AppendFormat("    orderFixed: [[{0}, 'asc']],", this.Columns.FindIndex(column => column is DataTableReorderColumn)); javascript.AppendLine(); 
            }
            else
            {
                javascript.AppendFormat("    order: []"); javascript.AppendLine();
            }
            javascript.AppendFormat("  }}"); javascript.AppendLine();
            javascript.AppendFormat("}}); "); javascript.AppendLine();

            if (CreatingPopulator)
            {
                string JSON = serialiseDataSource();

                string sourceType = "";
                if (this._data is QueryModel || this._data is Query)
                    sourceType = "Searches/Query";
                else if (this._data is SearchModel || this._data is Searches.Search)
                    sourceType = "Searches/Search";
                else
                    sourceType = this._data.GetType().FullName.Replace("Consensus.", "").Replace(".", "/");                

                javascript.AppendFormat("{0}.setPopulator(new consensus.populator({{", this.ClientID); javascript.AppendLine();
                javascript.AppendFormat("       dataSource: {0}", JSON); javascript.AppendLine();
                javascript.AppendFormat("       ,sourceType: {0}", System.Web.HttpUtility.JavaScriptStringEncode(sourceType, true)); javascript.AppendLine();
                javascript.AppendLine(" }));");
            }

            applyEventHandler(javascript, "onCreate", this.OnCreate);
            applyEventHandler(javascript, "onModify", this.OnModify);
            applyEventHandler(javascript, "onDelete", this.OnDelete);

            this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, javascript.ToString(), true);

            if (this.IsHidden == ConfigurableBoolean.True || this.IsHidden == ConfigurableBoolean.TrueEnforced)
                this.Attributes.Add("hidden", "hidden");
            else
                this.Attributes.Remove("hidden");
        }

        #endregion

        #region methods

        private String SerializeData()
        {
            if (this.Data is String)
                return HttpUtility.JavaScriptStringEncode(this.Data as String, true);
            else if (this.Data is ISearchesRunnable)
                return RestHandler.Serializer.Serialize((this.Data as ISearchesRunnable).Run());
            //else if (this.Data is ISearchRunnable)
            //    return RestHandler.Serializer.Serialize((this.Data as ISearchRunnable).Run());
            else
                return RestHandler.Serializer.Serialize(this.Data);
        }

        private void applyEventHandler(StringBuilder javascript, string clientHandler, string propertyValue)
        {
            string handler = "null";

            if (!string.IsNullOrEmpty(propertyValue) || !string.IsNullOrEmpty(this.OnChange))
            {
                if (string.IsNullOrEmpty(this.OnChange) || string.IsNullOrEmpty(propertyValue))
                    handler = string.Format("function(data) {{ {0}; }}", string.IsNullOrEmpty(this.OnChange) ? propertyValue : this.OnChange);
                else
                    handler = string.Format("function(data) {{ var fP = function(data){{ {0}; }}; if (fP(data) !== false) {{ {1}; }} else {{ return false; }} }}", propertyValue, this.OnChange);
            }

            javascript.AppendFormat("{0}.{1} = ", this.ClientID, clientHandler);
            javascript.Append(handler);
            javascript.AppendLine(";");
        }

        private string serialiseDataSource()
        {
            string JSON = "";

            if (CreatingPopulator)
            {
                Type dataSourceType = Data.GetType();
                object ldata = this.Data;
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
    }
}
