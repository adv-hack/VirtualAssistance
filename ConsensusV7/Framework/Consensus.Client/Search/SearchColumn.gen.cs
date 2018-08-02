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
    public partial class SearchColumn : Proxy<ISearchColumnModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SearchType" /> member.
        /// </summary>
        private Consensus.Search.SearchType _searchType;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_OUTPUT_TYPE" field.
        /// </summary>
        public Consensus.Search.SearchColumnOutputTypes OutputType
        {
            get { return this.Model.OutputType; }
            set { this.Model.OutputType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "SYSSC_SYSS_ID" field.
        /// </summary>
        public Consensus.Search.SearchType SearchType
        {
            get
            {
                if (_searchType == null && this.Model.SearchType != null)
                    _searchType = new Consensus.Search.SearchType(this.Model.SearchType);
                if (_searchType == null)
                    _searchType = Consensus.Search.SearchType.Create();
                return _searchType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SYSSC_SYSS_ID" field.
        /// </summary>
        public System.Int32 SearchTypeId
        {
            get { return this.Model.SearchTypeId; }
            set { this.Model.SearchTypeId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_DISPLAY_ORDER" field.
        /// </summary>
        public System.Int32 Order
        {
            get { return this.Model.Order; }
            set { this.Model.Order = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_FIELD_MAPPING" field.
        /// </summary>
        public System.String FieldName
        {
            get { return this.Model.FieldName; }
            set { this.Model.FieldName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_LABEL" field.
        /// </summary>
        public System.String Label
        {
            get { return this.Model.Label; }
            set { this.Model.Label = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_TOOLTIP_TEXT" field.
        /// </summary>
        public System.String ToolTip
        {
            get { return this.Model.ToolTip; }
            set { this.Model.ToolTip = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_VISIBLE" field.
        /// </summary>
        public System.Boolean Visible
        {
            get { return this.Model.Visible; }
            set { this.Model.Visible = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_SHOW_IN_BASIC_RESULTS" field.
        /// </summary>
        public System.Boolean ShowInBasicResults
        {
            get { return this.Model.ShowInBasicResults; }
            set { this.Model.ShowInBasicResults = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_TYPE" field.
        /// </summary>
        public System.String ColumnType
        {
            get { return this.Model.ColumnType; }
            set { this.Model.ColumnType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_HTML" field.
        /// </summary>
        public System.String ColumnHtml
        {
            get { return this.Model.ColumnHtml; }
            set { this.Model.ColumnHtml = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_LINK_TEXT" field.
        /// </summary>
        public System.String ColumnLinkText
        {
            get { return this.Model.ColumnLinkText; }
            set { this.Model.ColumnLinkText = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_LINK_HREF" field.
        /// </summary>
        public System.String ColumnLinkHref
        {
            get { return this.Model.ColumnLinkHref; }
            set { this.Model.ColumnLinkHref = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_TRUE_ICON" field.
        /// </summary>
        public System.String ColumnIconTrueIcon
        {
            get { return this.Model.ColumnIconTrueIcon; }
            set { this.Model.ColumnIconTrueIcon = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_TRUE_TEXT" field.
        /// </summary>
        public System.String ColumnIconTrueText
        {
            get { return this.Model.ColumnIconTrueText; }
            set { this.Model.ColumnIconTrueText = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_TRUE_CSS" field.
        /// </summary>
        public System.String ColumnIconTrueCss
        {
            get { return this.Model.ColumnIconTrueCss; }
            set { this.Model.ColumnIconTrueCss = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_FALSE_ICON" field.
        /// </summary>
        public System.String ColumnIconFalseIcon
        {
            get { return this.Model.ColumnIconFalseIcon; }
            set { this.Model.ColumnIconFalseIcon = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_FALSE_TEXT" field.
        /// </summary>
        public System.String ColumnIconFalseText
        {
            get { return this.Model.ColumnIconFalseText; }
            set { this.Model.ColumnIconFalseText = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_FALSE_CSS" field.
        /// </summary>
        public System.String ColumnIconFalseCss
        {
            get { return this.Model.ColumnIconFalseCss; }
            set { this.Model.ColumnIconFalseCss = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SearchColumn(ISearchColumnModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:SearchColumnModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SearchColumnModel" /> instance.
        /// </returns>
        public static Consensus.Search.SearchColumn Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SearchColumn.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SearchColumnModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SearchColumnModel" /> instance.
        /// </returns>
        public static Consensus.Search.SearchColumn Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Search.ISearchColumnModel model = provider.Search.SearchColumn.Create();
            return model == null ? null : new Consensus.Search.SearchColumn(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SearchColumnModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SearchColumnModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Search.SearchColumn> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SearchColumn.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SearchColumnModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SearchColumnModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Search.SearchColumn> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Search.ISearchColumnModel> collection = provider.Search.SearchColumn.FetchAll();
            return collection.Select(model => new Consensus.Search.SearchColumn(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SearchColumnModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SearchColumnModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchColumnModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Search.SearchColumn FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SearchColumn.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SearchColumnModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SearchColumnModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchColumnModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Search.SearchColumn FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Search.ISearchColumnModel model = provider.Search.SearchColumn.FetchById(id);
            return model == null ? null : new Consensus.Search.SearchColumn(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SearchColumn.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Search.SearchColumn.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SearchColumnModel" /> instances.
        /// </summary>
        /// <param name="searchTypeId">
        ///     The value which identifies the <see cref="!:SearchColumnModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchColumnModel" /> instances that match the specified <paramref name="searchTypeId" />.
        /// </returns>
        public static IEnumerable<Consensus.Search.SearchColumn> FetchAllBySearchTypeId(System.Int32 searchTypeId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SearchColumn.FetchAllBySearchTypeId(site,searchTypeId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SearchColumnModel" /> instances.
        /// </summary>
        /// <param name="searchTypeId">
        ///     The value which identifies the <see cref="!:SearchColumnModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchColumnModel" /> instances that match the specified <paramref name="searchTypeId" />.
        /// </returns>
        public static IEnumerable<Consensus.Search.SearchColumn> FetchAllBySearchTypeId(ConsensusSite site, System.Int32 searchTypeId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Search.ISearchColumnModel> collection = provider.Search.SearchColumn.FetchAllBySearchTypeId(searchTypeId);
            return collection.Select(model => new Consensus.Search.SearchColumn(model));
        }

        #endregion
    }
}
