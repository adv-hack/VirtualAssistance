using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Represents Defines the columns that are displayed when performing a search within the application.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSearchColumnModel : LocalModel<SystemSearchesGridColumnsRecord, Int32>, ISearchColumnModel
    {
        #region fields

        /// <summary>
        ///     The value of the "SYSSC_SYSS_ID" field.
        /// </summary>
        private LocalSearchTypeModel _searchType;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SystemSearchesGridColumnsRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Search.SearchColumn.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SystemSearchesGridColumnsRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Search.SearchColumn.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SystemSearchesGridColumnsRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Search.SearchColumn.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "SYSSC_SYSS_ID" field.
        /// </summary>
        public LocalSearchTypeModel SearchType
        {
            get
            {
                if (_searchType == null)
                    _searchType = this.Provider.Search.SearchType.FetchById(this.SearchTypeId);
                if (_searchType == null)
                    _searchType = this.Provider.Search.SearchType.Create();
                
                return _searchType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SYSSC_SYSS_ID" field.
        /// </summary>
        public Int32 SearchTypeId
        {
            get { return this.ModifiedData.SyssId; }
            set
            {
                if (this.ModifiedData.SyssId != value)
                     _searchType = null;
                this.ModifiedData.SyssId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_DISPLAY_ORDER" field.
        /// </summary>
        public Int32 Order
        {
            get { return this.ModifiedData.DisplayOrder; }
            set { this.ModifiedData.DisplayOrder = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_FIELD_MAPPING" field.
        /// </summary>
        public String FieldName
        {
            get { return this.ModifiedData.FieldMapping; }
            set { this.ModifiedData.FieldMapping = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_LABEL" field.
        /// </summary>
        public String Label
        {
            get { return this.ModifiedData.Label; }
            set { this.ModifiedData.Label = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_TOOLTIP_TEXT" field.
        /// </summary>
        public String ToolTip
        {
            get { return this.ModifiedData.TooltipText; }
            set { this.ModifiedData.TooltipText = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_VISIBLE" field.
        /// </summary>
        public Boolean Visible
        {
            get { return this.ModifiedData.Visible; }
            set { this.ModifiedData.Visible = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_SHOW_IN_BASIC_RESULTS" field.
        /// </summary>
        public Boolean ShowInBasicResults
        {
            get { return this.ModifiedData.ShowInBasicResults; }
            set { this.ModifiedData.ShowInBasicResults = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_TYPE" field.
        /// </summary>
        public String ColumnType
        {
            get { return this.ModifiedData.ColumnType; }
            set { this.ModifiedData.ColumnType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_HTML" field.
        /// </summary>
        public String ColumnHtml
        {
            get { return this.ModifiedData.ColumnHtml; }
            set { this.ModifiedData.ColumnHtml = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_LINK_TEXT" field.
        /// </summary>
        public String ColumnLinkText
        {
            get { return this.ModifiedData.ColumnLinkText; }
            set { this.ModifiedData.ColumnLinkText = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_LINK_HREF" field.
        /// </summary>
        public String ColumnLinkHref
        {
            get { return this.ModifiedData.ColumnLinkHref; }
            set { this.ModifiedData.ColumnLinkHref = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_TRUE_ICON" field.
        /// </summary>
        public String ColumnIconTrueIcon
        {
            get { return this.ModifiedData.ColumnIconTrueIcon; }
            set { this.ModifiedData.ColumnIconTrueIcon = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_TRUE_TEXT" field.
        /// </summary>
        public String ColumnIconTrueText
        {
            get { return this.ModifiedData.ColumnIconTrueText; }
            set { this.ModifiedData.ColumnIconTrueText = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_TRUE_CSS" field.
        /// </summary>
        public String ColumnIconTrueCss
        {
            get { return this.ModifiedData.ColumnIconTrueCss; }
            set { this.ModifiedData.ColumnIconTrueCss = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_FALSE_ICON" field.
        /// </summary>
        public String ColumnIconFalseIcon
        {
            get { return this.ModifiedData.ColumnIconFalseIcon; }
            set { this.ModifiedData.ColumnIconFalseIcon = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_FALSE_TEXT" field.
        /// </summary>
        public String ColumnIconFalseText
        {
            get { return this.ModifiedData.ColumnIconFalseText; }
            set { this.ModifiedData.ColumnIconFalseText = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_FALSE_CSS" field.
        /// </summary>
        public String ColumnIconFalseCss
        {
            get { return this.ModifiedData.ColumnIconFalseCss; }
            set { this.ModifiedData.ColumnIconFalseCss = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSearchColumnModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSearchColumnModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSearchColumnModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSearchColumnModel(LocalProvider provider, SystemSearchesGridColumnsRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
            if (_searchType != null)
            {
                _searchType.Save();
                this.ModifiedData.SyssId = _searchType.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_OUTPUT_TYPE" field.
        /// </summary>
        Consensus.Search.SearchColumnOutputTypes ISearchColumnModel.OutputType
        {
            get { return this.OutputType; }
            set { this.OutputType = (Consensus.Search.SearchColumnOutputTypes)value; }
        }

        /// <summary>
        ///     Gets the The value of the "SYSSC_SYSS_ID" field.
        /// </summary>
        Consensus.Search.ISearchTypeModel ISearchColumnModel.SearchType
        {
            get { return this.SearchType; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SYSSC_SYSS_ID" field.
        /// </summary>
        System.Int32 ISearchColumnModel.SearchTypeId
        {
            get { return this.SearchTypeId; }
            set { this.SearchTypeId = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_DISPLAY_ORDER" field.
        /// </summary>
        System.Int32 ISearchColumnModel.Order
        {
            get { return this.Order; }
            set { this.Order = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_FIELD_MAPPING" field.
        /// </summary>
        System.String ISearchColumnModel.FieldName
        {
            get { return this.FieldName; }
            set { this.FieldName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_LABEL" field.
        /// </summary>
        System.String ISearchColumnModel.Label
        {
            get { return this.Label; }
            set { this.Label = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_TOOLTIP_TEXT" field.
        /// </summary>
        System.String ISearchColumnModel.ToolTip
        {
            get { return this.ToolTip; }
            set { this.ToolTip = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_VISIBLE" field.
        /// </summary>
        System.Boolean ISearchColumnModel.Visible
        {
            get { return this.Visible; }
            set { this.Visible = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_SHOW_IN_BASIC_RESULTS" field.
        /// </summary>
        System.Boolean ISearchColumnModel.ShowInBasicResults
        {
            get { return this.ShowInBasicResults; }
            set { this.ShowInBasicResults = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_TYPE" field.
        /// </summary>
        System.String ISearchColumnModel.ColumnType
        {
            get { return this.ColumnType; }
            set { this.ColumnType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_HTML" field.
        /// </summary>
        System.String ISearchColumnModel.ColumnHtml
        {
            get { return this.ColumnHtml; }
            set { this.ColumnHtml = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_LINK_TEXT" field.
        /// </summary>
        System.String ISearchColumnModel.ColumnLinkText
        {
            get { return this.ColumnLinkText; }
            set { this.ColumnLinkText = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_LINK_HREF" field.
        /// </summary>
        System.String ISearchColumnModel.ColumnLinkHref
        {
            get { return this.ColumnLinkHref; }
            set { this.ColumnLinkHref = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_TRUE_ICON" field.
        /// </summary>
        System.String ISearchColumnModel.ColumnIconTrueIcon
        {
            get { return this.ColumnIconTrueIcon; }
            set { this.ColumnIconTrueIcon = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_TRUE_TEXT" field.
        /// </summary>
        System.String ISearchColumnModel.ColumnIconTrueText
        {
            get { return this.ColumnIconTrueText; }
            set { this.ColumnIconTrueText = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_TRUE_CSS" field.
        /// </summary>
        System.String ISearchColumnModel.ColumnIconTrueCss
        {
            get { return this.ColumnIconTrueCss; }
            set { this.ColumnIconTrueCss = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_FALSE_ICON" field.
        /// </summary>
        System.String ISearchColumnModel.ColumnIconFalseIcon
        {
            get { return this.ColumnIconFalseIcon; }
            set { this.ColumnIconFalseIcon = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_FALSE_TEXT" field.
        /// </summary>
        System.String ISearchColumnModel.ColumnIconFalseText
        {
            get { return this.ColumnIconFalseText; }
            set { this.ColumnIconFalseText = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_FALSE_CSS" field.
        /// </summary>
        System.String ISearchColumnModel.ColumnIconFalseCss
        {
            get { return this.ColumnIconFalseCss; }
            set { this.ColumnIconFalseCss = (System.String)value; }
        }

        #endregion
    }
}
