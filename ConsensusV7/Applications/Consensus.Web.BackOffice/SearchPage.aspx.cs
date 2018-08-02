using Consensus.Search;
using Consensus.Searches;
using Consensus.Web.Controls;
using Consensus.Web.Controls.Tables;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice
{
    public partial class SearchPage : BaseStandardPage
    {
        #region fields

        /// <summary>
        ///    The type of search being performed.
        /// </summary>
        private SearchType _searchType;

        /// <summary>
        ///     Specifies whether basic results should be displayed.
        /// </summary>
        private Boolean _basicResult;

        /// <summary>
        ///     The number of parameters rendered on each bootstrap row.
        /// </summary>
        private const Int32 _parametersPerRow = 4;

        /// <summary>
        ///     The number of checkbox parameters rendered on each bootstrap row.
        /// </summary>
        private const Int32 _checkboxesPerRow = 6;

        /// <summary>
        ///     The number of profile parameters rendered on each bootstrap row.
        /// </summary>
        private const Int32 _profilesPerRow = 1;

        private string _personSurname;
        #endregion

        #region properties

        /// <summary>
        ///    Gets the type of search being performed.
        /// </summary>
        public SearchType SearchType
        {
            get
            {
                if (_searchType == null)
                    _searchType = SearchType.FetchAll().FirstOrDefault(type => String.Equals(type.Type, this.Context.Items["type"].ConvertTo<String>(), StringComparison.OrdinalIgnoreCase));

                return _searchType;
            }
        }

        /// <summary>
        ///    Gets or sets whether basic results should be displayed. 
        /// </summary>
        public Boolean BasicResult
        {
            get { return _basicResult; }
            set { _basicResult = value; }
        }

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return this.SearchType == null ? "Search" : this.SearchType.PageTitle; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "search"; }
        }

        /// <summary>
        ///     Gets whether the page is initially rendered in editing mode.
        /// </summary>
        public override Boolean IsEditable
        {
            get { return true; }
        }

        public string PersonSurname
        {
            get
            {
                if (string.IsNullOrEmpty(_personSurname))
                    _personSurname = (Request.QueryString["Surname"] == null) ? null : Request.QueryString["Surname"].ToString();
                return _personSurname;
            }
            set { _personSurname = value; }
        }
        
        #endregion

        #region page cycle

        protected void Page_Init(object sender, EventArgs e)
        {
            this.BlockCustomFields = true;

            this.SearchButton.Enabled = (this.SearchType != null);
            this.ResetButton.Enabled = (this.SearchType != null);
            this.CreateButton.Enabled = (this.SearchType != null);
            this.BasicResult = this.Request.QueryString["basic"].ConvertTo<Boolean>(true);
            if (this.SearchType != null)
            {
                // Initialise the screen content
                this.Title = this.SearchType.PageTitle;
                this.InitialiseFields();
                this.InitialiseResult();

                // Initialise the search parameters
                if (!this.IsPostBack)
                    this.ResetButton_Click(null, null);

                // Initialise the create button
                if (String.IsNullOrEmpty(this.SearchType.NewButton))
                    this.CreateButton.Visible = false;
                else if (this.SearchType.NewButton.StartsWith("javascript:", StringComparison.OrdinalIgnoreCase))
                    this.CreateButton.OnClientClick = this.SearchType.NewButton.Substring(11) + ";return false;";
                else if (!String.IsNullOrEmpty(this.SearchType.SaveJson))
                  this.CreateButton.OnClientClick = "consensus.web.dataTable.all[0].create();return false;";
                else
                    this.CreateButton.OnClientClick = "window.location.href='" + VirtualPathUtility.ToAbsolute(this.SearchType.NewButton) + "';return false;";

                if (!string.IsNullOrEmpty(PersonSurname)) SearchButton_Click(null, null);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.SearchType != null)
            {
                this.SearchResult.Url += this.SearchType.NewButton;
                this.SearchResult.Json = this.SearchType.SaveJson;
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            if (IsPostBack)
            {
                Search.SearchParameter profileParameter = this.SearchType.Parameters.OfType<Search.SearchParameter>().Where(param => param.FieldType.Equals("profile", StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

                if (profileParameter != null)
                {
                    setProfileFieldsStatus(profileParameter);
                }
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Adds the search fields to the criteria panel
        /// </summary>
        private void InitialiseFields()
        {
            HtmlGenericControl fieldRow = null;
            IEnumerable<Search.SearchParameter> searchParameters = this.SearchType.Parameters.OfType<Search.SearchParameter>().Where(param => param.Visible && (param.Type == SearchParameterTypes.Standard || param.Type == SearchParameterTypes.Exclusion)).OrderBy(param => param.Order);
            foreach (Search.SearchParameter parameter in searchParameters.Where(param => !String.Equals(param.FieldType, "checkbox", StringComparison.OrdinalIgnoreCase) && !String.Equals(param.FieldType, "profile", StringComparison.OrdinalIgnoreCase)))
            {
                this.InitialiseFieldRow(ref fieldRow, _parametersPerRow);
                this.InitialiseField(fieldRow, parameter, 12 / _parametersPerRow);
            }

            HtmlGenericControl profileRow = null;
            foreach (Search.SearchParameter parameter in searchParameters.Where(param => String.Equals(param.FieldType, "profile", StringComparison.OrdinalIgnoreCase)))
            {
                this.InitialiseFieldRow(ref profileRow, _profilesPerRow);
                this.InitialiseProfileFields(profileRow, parameter);
            }

            HtmlGenericControl checkRow = null;
            foreach (Search.SearchParameter parameter in searchParameters.Where(param => String.Equals(param.FieldType, "checkbox", StringComparison.OrdinalIgnoreCase)))
            {
                this.InitialiseFieldRow(ref checkRow, _checkboxesPerRow);
                this.InitialiseField(checkRow, parameter, 12 / _checkboxesPerRow);
            }
        }

        /// <summary>
        ///     Adds the search fields to the criteria panel
        /// </summary>
        private void InitialiseField(HtmlGenericControl row, Search.SearchParameter parameter, Int32 width)
        {
            BaseInputControl control = null;
            switch (parameter.FieldType)
            {
                case "textbox":
                case "jslookup":control = new TextField();break;
                case "datepicker": control = new DateField(); break;
                case "checkbox": control = new CheckField(); break;
                case "select": control = this.InitialiseListField(parameter); break;
            }

            // Add the control to the parameter panel
            if (control != null)
            {
                control.ID = parameter.FieldName;
                control.LabelText = parameter.CustomLabel.TrimOrNullify() ?? parameter.DefaultLabel;
                control.DataBoundValue = parameter.FieldName;
                control.CssClass += " col-md-" + width.ToString();
                if (parameter.FieldName == "PN_SURNAME")
                    control.FieldValueRaw = (object)(string.IsNullOrEmpty(PersonSurname) ? "" : PersonSurname);
                row.Controls.Add(control);
            }
        }

        /// <summary>
        ///     Adds a dropdown field to the criteria panel
        /// </summary>
        private ListBase InitialiseListField(Search.SearchParameter parameter)
        {
            if (!String.IsNullOrEmpty(parameter.CodeType))
            {
                CodeField codeField = new CodeField();
                codeField.CodeType = parameter.CodeType.Contains(":") ? parameter.CodeType.Substring(0, parameter.CodeType.IndexOf(":")) : parameter.CodeType;
                return codeField;
            }
            
            if (!String.IsNullOrEmpty(parameter.ListData))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                Dictionary<String, Object> jsonData = serializer.Deserialize<Dictionary<String, Object>>(parameter.ListData);

                ListField listField = null; 
                if (jsonData.Keys.Count >= 1 && String.Equals(jsonData.Keys.ElementAt(0), "SQL", StringComparison.OrdinalIgnoreCase))
                    listField = this.InitialiseSqlField(jsonData.Values.ElementAt(0) as String);
                if (jsonData.Keys.Count >= 1 && String.Equals(jsonData.Keys.ElementAt(0), "CODE", StringComparison.OrdinalIgnoreCase))
                    listField = this.InitialiseJsonField(jsonData.Values.ElementAt(0) as ArrayList);
                if (listField != null && !listField.Items.OfType<ListItem>().Any(item => String.IsNullOrEmpty(item.Value)))
                    listField.Items.Insert(0, new ListItem("", ""));
                return listField;
            }

            return null;
        }

        private void InitialiseProfileFields(HtmlGenericControl row, Search.SearchParameter parameter)
        {
            if (!String.IsNullOrEmpty(parameter.ListData))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                Dictionary<String, Object> jsonData = serializer.Deserialize<Dictionary<String, Object>>(parameter.ListData);

                if (jsonData.Keys.Count >= 1 && String.Equals(jsonData.Keys.ElementAt(0), "PROFILES", StringComparison.OrdinalIgnoreCase)) {
                    ArrayList profileTypes = jsonData.Values.ElementAt(0) as ArrayList;
                    
                    if (profileTypes != null && profileTypes.Count > 0)
                    {

                        ListField paramTypeField = new ListField();
                        paramTypeField.ID = parameter.FieldName + "_0";
                        row.Controls.Add(paramTypeField);

                        HtmlInputHidden hidProfSearchField = new HtmlInputHidden();
                        hidProfSearchField.ID = parameter.FieldName + "_SearchCol";
                        row.Controls.Add(hidProfSearchField);

                        HtmlInputHidden hidProfExtraWhere= new HtmlInputHidden();
                        hidProfExtraWhere.ID = parameter.FieldName + "_ExtraWhere";
                        row.Controls.Add(hidProfExtraWhere);

                        HtmlInputHidden hidProfLevel2Exists = new HtmlInputHidden();
                        hidProfLevel2Exists.ID = parameter.FieldName + "_Level2Exists";
                        row.Controls.Add(hidProfLevel2Exists);

                        HtmlInputHidden hidProfLevel3Exists = new HtmlInputHidden();
                        hidProfLevel3Exists.ID = parameter.FieldName + "_Level3Exists";
                        row.Controls.Add(hidProfLevel3Exists);

                        paramTypeField.ClientOnChange = string.Format("if (typeof ({2}) != 'undefined') {{ setNextProfileField({0}, '{1}', {2}, '{3}', '{4}'); }}",
                            0,
                            paramTypeField.ClientID,
                            paramTypeField.ClientID.Substring(0, paramTypeField.ClientID.Length - 1) + "1", // The client ID of the next list, passed without quotes as a variable, to get the instance of consensus.web.list, see ListBase
                            hidProfSearchField.ClientID,
                            hidProfExtraWhere.ClientID);

                        paramTypeField.LabelText = parameter.CustomLabel.TrimOrNullify() ?? parameter.DefaultLabel;
                        paramTypeField.CssClass += " col-md-3";

                        List<object> profileTypeItems = new List<object>();                        
                        foreach (IDictionary<string, object> profileType in profileTypes)
                        {
                            object item = new {
                                Text = profileType.ContainsKey("name") ? profileType["name"].ToString() : "",
                                Value = profileType.ContainsKey("profileField") ? profileType["profileField"].ToString() : "",
                                SearchField = profileType.ContainsKey("searchField") ? profileType["searchField"].ToString() : "",
                                ExtraWhere = profileType.ContainsKey("extraWhere") ? profileType["extraWhere"].ToString() : ""
                            };

                            profileTypeItems.Add(item);
                        }
                        paramTypeField.DisplayMember = "Text";
                        paramTypeField.ValueMember = "Value";
                        if (paramTypeField.Attributes == null)
                            paramTypeField.Attributes = new List<ListAttribute>();
                        paramTypeField.Attributes.Add(new ListAttribute() { Name = "search-field", Value = "SearchField" });
                        paramTypeField.Attributes.Add(new ListAttribute() { Name = "extra-where", Value = "ExtraWhere" });
                        paramTypeField.DataSource = profileTypeItems;

                        for (var i = 1; i <= 3; i++) // Then we create three more interdependent dependent list controls for the three levels.
                        {
                            ListField listField = new ListField();
                            listField.ID = parameter.FieldName + "_" + i.ToString();
                            row.Controls.Add(listField);
                            listField.Enabled = false;
                            listField.ClientSideRefresh = true;

                            ISearchParameterable searchDef = Searches.Search.Create(SearchTypes.SearchProfileSearchOptions)
                                .AddParameter("@PA_PROFILE_TYPE", "")
                                .AddParameter("@PA_EXTRA_WHERE", "");

                            if (i >= 2)
                            {
                                searchDef = searchDef.AddParameter("@PA_LEVEL_1", "");
                            }
                            if (i == 3)
                            {
                                searchDef = searchDef.AddParameter("@PA_LEVEL_2", "");
                            }
                            if (i < 3)
                            {
                                listField.ClientOnChange = string.Format("if (typeof ({2}) != 'undefined') {{ setNextProfileField({0}, '{1}', {2}, '', '', '{3}', '{4}'); }}",
                                    i,
                                    listField.ClientID,
                                    listField.ClientID.Substring(0, listField.ClientID.Length - 1) + (i + 1).ToString(),
                                    hidProfLevel2Exists.ClientID,
                                    hidProfLevel3Exists.ClientID); 
                            }
                            listField.DisplayMember = "PROFILE_DESC";
                            if (listField.Attributes == null)
                                listField.Attributes = new List<ListAttribute>();
                            listField.Attributes.Add(new ListAttribute() { Name = "next-exists", Value = "NEXT_EXISTS" });
                            listField.DataSource = searchDef;
                            listField.LabelText = "Level " + i.ToString();
                            //listField.DataBoundValue = parameter.FieldName;
                            listField.CssClass += " col-md-3";
                        }
                    }
                }
            }
        }

        private void setProfileFieldsStatus(Search.SearchParameter parameter)
        {
            ListField paramTypeField = SearchCriteria.Controls.OfType<HtmlGenericControl>().Select(row => row.FindControl(parameter.FieldName + "_0")).OfType<ListField>().FirstOrDefault();

            if (paramTypeField != null && !string.IsNullOrEmpty(paramTypeField.FieldValue))
            {
                IEnumerable<ListField> lists = paramTypeField.Parent.Controls.OfType<ListField>();
                IEnumerable<HtmlInputHidden> hids = paramTypeField.Parent.Controls.OfType<HtmlInputHidden>();

                ListField level1Field = lists.Where(l => l.ID.EndsWith("_1")).FirstOrDefault();
                Searches.SearchParameter[] procParams = ((SearchModel)level1Field.DataSource).Parameters;
                HtmlInputHidden hidExtraWhere = hids.Where(h => h.ID.EndsWith("_ExtraWhere")).FirstOrDefault();

                level1Field.Enabled = true;
                level1Field.ClientSideInitialise = true;
                Searches.SearchParameter paramType = procParams.FirstOrDefault(p => p.Parameter == "@PA_PROFILE_TYPE");
                if (paramType != null)
                    paramType.Value = paramTypeField.FieldValue;

                if (!string.IsNullOrEmpty(hidExtraWhere.Value))
                {
                    paramType = procParams.FirstOrDefault(p => p.Parameter == "@PA_EXTRA_WHERE");
                    if (paramType != null)
                        paramType.Value = hidExtraWhere.Value;
                }

                if (!string.IsNullOrEmpty(level1Field.FieldValue))
                {
                    ListField level2Field = lists.Where(l => l.ID.EndsWith("_2")).FirstOrDefault();
                    procParams = ((SearchModel)level2Field.DataSource).Parameters;
                    HtmlInputHidden hidLevelExists = hids.Where(h => h.ID.EndsWith("_Level2Exists")).FirstOrDefault();
                    level2Field.Enabled = (hidLevelExists == null || hidLevelExists.Value != "0");
                    if (level2Field.Enabled)
                        level2Field.ClientSideInitialise = true;

                    paramType = procParams.FirstOrDefault(p => p.Parameter == "@PA_PROFILE_TYPE");
                    if (paramType != null)
                        paramType.Value = paramTypeField.FieldValue;

                    if (!string.IsNullOrEmpty(hidExtraWhere.Value))
                    {
                        paramType = procParams.FirstOrDefault(p => p.Parameter == "@PA_EXTRA_WHERE");
                        if (paramType != null)
                            paramType.Value = hidExtraWhere.Value;
                    }

                    paramType = procParams.FirstOrDefault(p => p.Parameter == "@PA_LEVEL_1");
                    if (paramType != null)
                        paramType.Value = level1Field.FieldValue;


                    if (!string.IsNullOrEmpty(level2Field.FieldValue))
                    {
                        ListField level3Field = lists.Where(l => l.ID.EndsWith("_3")).FirstOrDefault();
                        procParams = ((SearchModel)level3Field.DataSource).Parameters;
                        hidLevelExists = hids.Where(h => h.ID.EndsWith("_Level3Exists")).FirstOrDefault();
                        level3Field.Enabled = (hidLevelExists == null || hidLevelExists.Value != "0");
                        if (level3Field.Enabled)
                            level3Field.ClientSideInitialise = true;


                        paramType = procParams.FirstOrDefault(p => p.Parameter == "@PA_PROFILE_TYPE");
                        if (paramType != null)
                            paramType.Value = paramTypeField.FieldValue;

                        if (!string.IsNullOrEmpty(hidExtraWhere.Value))
                        {
                            paramType = procParams.FirstOrDefault(p => p.Parameter == "@PA_EXTRA_WHERE");
                            if (paramType != null)
                                paramType.Value = hidExtraWhere.Value;
                        }

                        paramType = procParams.FirstOrDefault(p => p.Parameter == "@PA_LEVEL_1");
                        if (paramType != null)
                            paramType.Value = level1Field.FieldValue;

                        paramType = procParams.FirstOrDefault(p => p.Parameter == "@PA_LEVEL_2");
                        if (paramType != null)
                            paramType.Value = level2Field.FieldValue;
                    }
                }
            }
        }

        /// <summary>
        ///     Adds a SQL-driven dropdown field to the criteria panel
        /// </summary>
        private ListField InitialiseSqlField(String sql)
        {
            ListField listField = new ListField();
            listField.Items.Add(new ListItem("", ""));

            // Execute the SQL to obtain the list of items to screenObjectDisplay in the dropdown
            IDataProvider dataProvider = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite].GetService<IDataProvider>();
            Dictionary<String, Object>[] records = dataProvider.ExecuteQuery(sql as String);
            foreach (Dictionary<String, Object> record in records)
            {
                String value = record.Values.ElementAt(0).ConvertTo<String>();
                String text = record.Values.ElementAt(record.Values.Count > 1 ? 1 : 0).ConvertTo<String>();
                ListItem item = new ListItem(text, value);
                listField.Items.Add(item);
            }

            return listField;
        }

        /// <summary>
        ///     Adds a JSON-driven dropdown field to the criteria panel
        /// </summary>        
        private ListField InitialiseJsonField(ArrayList records)
        {
            // Iterate through the data-defined list of values
            ListField listField = new ListField();
            foreach (Dictionary<String, Object> record in records)
            {
                String value = record.Values.ElementAt(0).ConvertTo<String>();
                String text = record.Values.ElementAt(1).ConvertTo<String>();
                ListItem item = new ListItem(text, value);
                listField.Items.Add(item);
            }

            return listField;
        }

        /// <summary>
        ///     Initialises the bootstrap row
        /// </summary>
        private void InitialiseFieldRow(ref HtmlGenericControl row, Int32 maxControlsPerRow)
        {
            if (row == null || row.Controls.Count == maxControlsPerRow)
            {
                row = new HtmlGenericControl("div");
                row.Attributes["class"] = "row";
                this.SearchCriteria.Controls.AddAt(this.SearchCriteria.Controls.Count - 1, row);
            }
        }

        /// <summary>
        ///     Adds the columns to the grid and defines the data source for restful searching
        /// </summary>
        private void InitialiseResult()
        {
            IEnumerable<SearchColumn> searchColumns = this.SearchType.Columns.OfType<SearchColumn>().OrderBy(col => col.Order);
            foreach (SearchColumn column in searchColumns)
            {
                DataTableColumn tableColumn = this.InitialiseResult(column);
                if (tableColumn != null)
                {
                    tableColumn.Title = column.Label;
                    tableColumn.Tooltip = column.ToolTip;
                    tableColumn.Visible = column.Visible && (column.ShowInBasicResults || !this.BasicResult) && ((column.OutputType & SearchColumnOutputTypes.Screen) == SearchColumnOutputTypes.Screen);
                    tableColumn.Exportable = ((column.OutputType & SearchColumnOutputTypes.Export) == SearchColumnOutputTypes.Export);
                    this.SearchResult.Columns.Add(tableColumn);
                }
            }
        }

        /// <summary>
        ///     Adds the columns to the grid and defines the data source for restful searching
        /// </summary>
        private DataTableColumn InitialiseResult(SearchColumn column)
        {
            switch (column.ColumnType)
            {
                case "text":
                    DataTableTextColumn textColumn = new DataTableTextColumn();
                    textColumn.FieldName = column.FieldName;
                    return textColumn;
                case "date":
                    DataTableDateColumn dateColumn = new DataTableDateColumn();
                    dateColumn.FieldName = column.FieldName;
                    return dateColumn;
                case "icon":
                    DataTableIconColumn iconColumn = new DataTableIconColumn();
                    iconColumn.FieldName = column.FieldName;
                    iconColumn.TrueIcon = column.ColumnIconTrueIcon;
                    iconColumn.TrueTooltip = column.ColumnIconTrueText;
                    iconColumn.TrueClass = column.ColumnIconTrueCss;
                    iconColumn.FalseIcon = column.ColumnIconFalseIcon;
                    iconColumn.FalseTooltip = column.ColumnIconFalseText;
                    iconColumn.FalseClass = column.ColumnIconFalseCss;
                    return iconColumn;
                case "link":
                    DataTableLinkColumn linkColumn = new DataTableLinkColumn();
                    linkColumn.LinkText = column.ColumnLinkText;
                    linkColumn.LinkHref = column.ColumnLinkHref;
                    return linkColumn;
                case "html":
                    DataTableCustomColumn customColumn = new DataTableCustomColumn();
                    customColumn.Controls.Add(new LiteralControl() { Text = column.ColumnHtml });
                    return customColumn;
                case "time":
                    DataTableDateTimeColumn datetimeColumn = new DataTableDateTimeColumn();
                    datetimeColumn.FieldName = column.FieldName;
                    return datetimeColumn;
            }

            return null;
        }

        /// <summary>
        ///     Constructs the query that will execute the search.
        /// </summary>
        private IQuerySourceable ConstructSelection(IQuerySelectable query)
        {
            foreach (Search.SearchColumn column in this.SearchType.Columns)
                query = query.Select(column.FieldName);

            return query as IQuerySourceable;
        }

        /// <summary>
        ///     Constructs the query that will execute the search.
        /// </summary>
        private IQueryConditionable ConstructSource(IQuerySourceable query)
        {
            String sourceName = this.SearchType.DatabaseView;
            String sourceEnum = sourceName.StartsWith("dbo.", StringComparison.OrdinalIgnoreCase) ? sourceName.Substring(4) : sourceName;
            QuerySources source = (QuerySources)Enum.Parse(typeof(QuerySources), sourceEnum);
            return query.From(source) as IQueryConditionable;
        }

        /// <summary>
        ///     Constructs the query that will execute the search.
        /// </summary>
        private ISearchesRunnable ConstructCondition(IQueryConditionable query)
        {
            IEnumerable<HtmlGenericControl> criteriaRows = this.SearchCriteria.Controls.OfType<HtmlGenericControl>();
            IQueryConditionableAnd conditions = null;
            IEnumerable<Search.SearchParameter> parameters = this.SearchType.Parameters.OfType<Search.SearchParameter>().Where(param => param.Type == SearchParameterTypes.Standard || param.Type == SearchParameterTypes.Exclusion);
            foreach (Search.SearchParameter parameter in parameters)
            {
                Object conditionValue = null;
                string searchFieldName = parameter.FieldName;
                switch (parameter.FieldType)
                {
                    case "textbox": case "jslookup": conditionValue = this.ConstructCondition<TextField, String>(criteriaRows, parameter.FieldName, value => value.TrimOrNullify()); break;
                    case "datepicker": conditionValue = this.ConstructCondition<DateField, DateTime?>(criteriaRows, parameter.FieldName); break;
                    case "checkbox":
                        if (parameter.Type == SearchParameterTypes.Standard)
                            conditionValue = this.ConstructCondition<CheckField, Boolean>(criteriaRows, parameter.FieldName);
                        else if (parameter.Type == SearchParameterTypes.Exclusion && this.ConstructCondition<CheckField, Boolean>(criteriaRows, parameter.FieldName))
                            conditionValue = true;
                        break;
                    case "select":
                        if (parameter.CodeType != null)
                            conditionValue = this.ConstructCondition<CodeField, String>(criteriaRows, parameter.FieldName, value => value.TrimOrNullify());
                        else
                            conditionValue = this.ConstructCondition<ListField, String>(criteriaRows, parameter.FieldName, value => value.TrimOrNullify());
                        break;
                    case "profile":
                        conditionValue = ConstuctProfileCondition(criteriaRows, parameter, out searchFieldName);
                        break;
                }
                
                if (conditionValue != null)
                {
                    if (String.IsNullOrEmpty(parameter.ConditionSql))
                    {
                        QueryConditionTypes conditionType = QueryConditionTypes.Equal;
                        switch (parameter.Condition)
                        {
                            case "EQ": conditionType = QueryConditionTypes.Equal; break;
                            case "NOT EQ": conditionType = QueryConditionTypes.NotEqual; break;
                            case "GT": conditionType = QueryConditionTypes.GreaterThan; break;
                            case "GTE": conditionType = QueryConditionTypes.GreaterThanOrEqual; break;
                            case "LT": conditionType = QueryConditionTypes.LessThan; break;
                            case "LTE": conditionType = QueryConditionTypes.LessThanOrEqual; break;
                            case "STARTS": conditionType = QueryConditionTypes.StartsWith; break;
                            case "CONTAINS": conditionType = QueryConditionTypes.Contains; break;
                            case "ENDS": conditionType = QueryConditionTypes.EndsWith; break;
                        }
                        if (conditions == null)
                            conditions = query.Where(searchFieldName, conditionType, conditionValue);
                        else
                            conditions = conditions.And(searchFieldName, conditionType, conditionValue);
                    }
                    else
                    {
                        if (conditions == null)
                            conditions = query.WhereRaw(parameter.ConditionSql.Replace("[[[VALUE]]]", "' + @value + '"), conditionValue);
                        else
                            conditions = conditions.AndRaw(parameter.ConditionSql.Replace("[[[VALUE]]]", "' + @value + '"), conditionValue);
                    }
                }
            }
            return (ISearchesRunnable)conditions ?? (ISearchesRunnable)query;
        }

        /// <summary>
        ///     Constructs the query that will execute the search.
        /// </summary>
        private TValue ConstructCondition<TControl, TValue>(IEnumerable<HtmlGenericControl> criteriaRows, String fieldName) where TControl : BaseInputControl
        {
            return this.ConstructCondition<TControl, TValue>(criteriaRows, fieldName, null);
        }

        /// <summary>
        ///     Constructs the query that will execute the search.
        /// </summary>
        private TValue ConstructCondition<TControl, TValue>(IEnumerable<HtmlGenericControl> criteriaRows, String fieldName, Func<TValue, TValue> modifier) where TControl : BaseInputControl
        {
            TControl control = criteriaRows.Select(row => row.FindControl(fieldName)).OfType<TControl>().FirstOrDefault();
            var xcontrol = criteriaRows.Select(x => x.FindControl(fieldName)).FirstOrDefault();
            TValue value = (control == null) ? default(TValue) : value = (TValue)control.FieldValueRaw;
            if (modifier != null && value != null)
                value = modifier.Invoke(value);
            if (fieldName == "PN_SURNAME" && !string.IsNullOrEmpty(PersonSurname) && value == null)
            {
                value = (TValue)Convert.ChangeType(PersonSurname, typeof(TValue));
                control.FieldValueRaw = value;
            }
            return value;
        }

        private string ConstuctProfileCondition(IEnumerable<HtmlGenericControl> criteriaRows, Search.SearchParameter parameter, out string searchFieldName)
        {
            searchFieldName = parameter.FieldName;
            HtmlInputHidden hidSearchField = criteriaRows.Select(row => row.FindControl(parameter.FieldName + "_SearchCol")).OfType<HtmlInputHidden>().FirstOrDefault();
            if (hidSearchField != null)
            {
                searchFieldName = hidSearchField.Value;

                if (!string.IsNullOrEmpty(searchFieldName))
                {
                    parameter.Condition = "CONTAINS";
                    string condition = "";

                    ListField level1 = criteriaRows.Select(row => row.FindControl(parameter.FieldName + "_1")).OfType<ListField>().FirstOrDefault();
                    if (level1 != null && !string.IsNullOrEmpty(level1.FieldValue))
                    {
                        condition = "|" + level1.FieldValue + "|"; // Do Html format, e.g. @amp; for & ??

                        ListField level2 = criteriaRows.Select(row => row.FindControl(parameter.FieldName + "_2")).OfType<ListField>().FirstOrDefault();
                        if (level2 != null && !string.IsNullOrEmpty(level2.FieldValue))
                        {
                            condition += level2.FieldValue + "|";

                            ListField level3 = criteriaRows.Select(row => row.FindControl(parameter.FieldName + "_3")).OfType<ListField>().FirstOrDefault();
                            if (level3 != null && !string.IsNullOrEmpty(level3.FieldValue))
                            {
                                condition += level3.FieldValue + "|";
                            }
                        }

                        return condition;
                    }
                }
            }

            return null;
        }

        #endregion

        #region events

        /// <summary>
        ///     Occurs when the search button is clicked.
        /// </summary>
        protected void SearchButton_Click(object sender, EventArgs e)
        {
            Query query = Query.Create();
            query.Top = 5000;
            query.Distinct = true;

            Object basic = query;
            basic = this.ConstructSelection(basic as IQuerySelectable);
            basic = this.ConstructSource(basic as IQuerySourceable);
            basic = this.ConstructCondition(basic as IQueryConditionable);

            this.SearchResult.Data = (basic as ISearchesRunnable).Run();
            this.SearchResult.IsHidden = UserInterface.ConfigurableBoolean.FalseEnforced;
        }

        /// <summary>
        ///     Occurs when the reset button is clicked.
        /// </summary>
        protected void ResetButton_Click(object sender, EventArgs e)
        {
            this.SearchResult.IsHidden = UserInterface.ConfigurableBoolean.TrueEnforced; 
            foreach (Search.SearchParameter parameter in this.SearchType.Parameters)
            {
                BaseInputControl control = this.SearchCriteria.Controls.OfType<HtmlGenericControl>().Select(row => row.FindControl(parameter.FieldName)).OfType<BaseInputControl>().FirstOrDefault();
                if (control != null)
                {
                    if (String.Equals(parameter.DefaultValue, "now", StringComparison.OrdinalIgnoreCase))
                        control.FieldValueRaw = DateTime.Now;
                    else if (!String.IsNullOrEmpty(parameter.DefaultValue)) 
                        control.FieldValueRaw = parameter.DefaultValue;
                    else
                        control.FieldValueRaw = null;
                }
            }
        }

        #endregion
    }
}