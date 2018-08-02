using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Represents Defines the parameters that are displayed and used to perform a search within the application.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SearchParameter : Proxy<ISearchParameterModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SearchType" /> member.
        /// </summary>
        private Consensus.Search.SearchType _searchType;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the type of search parameter.
        /// </summary>
        public Consensus.Search.SearchParameterTypes Type
        {
            get { return this.Model.Type; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_VISIBLE" field.
        /// </summary>
        public System.Boolean Visible
        {
            get { return this.Model.Visible; }
            set { this.Model.Visible = value; }
        }

        /// <summary>
        ///     Gets the The value of the "SYSSP_SYSS_ID" field.
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
        ///     Gets or sets the unique code for the value of the "SYSSP_SYSS_ID" field.
        /// </summary>
        public System.Int32 SearchTypeId
        {
            get { return this.Model.SearchTypeId; }
            set { this.Model.SearchTypeId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_DISPLAY_ORDER" field.
        /// </summary>
        public System.Int32 Order
        {
            get { return this.Model.Order; }
            set { this.Model.Order = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_FIELD_NAME" field.
        /// </summary>
        public System.String FieldName
        {
            get { return this.Model.FieldName; }
            set { this.Model.FieldName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_DEFAULT_LABEL" field.
        /// </summary>
        public System.String DefaultLabel
        {
            get { return this.Model.DefaultLabel; }
            set { this.Model.DefaultLabel = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_LABEL" field.
        /// </summary>
        public System.String CustomLabel
        {
            get { return this.Model.CustomLabel; }
            set { this.Model.CustomLabel = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_FIELD_TYPE" field.
        /// </summary>
        public System.String FieldType
        {
            get { return this.Model.FieldType; }
            set { this.Model.FieldType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_WHERE_CLAUSE_OPERATOR" field.
        /// </summary>
        public System.String Condition
        {
            get { return this.Model.Condition; }
            set { this.Model.Condition = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_DEFAULT_VALUE" field.
        /// </summary>
        public System.String DefaultValue
        {
            get { return this.Model.DefaultValue; }
            set { this.Model.DefaultValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_CODE_LIST" field.
        /// </summary>
        public System.String CodeType
        {
            get { return this.Model.CodeType; }
            set { this.Model.CodeType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_DATA" field.
        /// </summary>
        public System.String ListData
        {
            get { return this.Model.ListData; }
            set { this.Model.ListData = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_WHERE_CLAUSE_OVERRIDE" field.
        /// </summary>
        public System.String ConditionSql
        {
            get { return this.Model.ConditionSql; }
            set { this.Model.ConditionSql = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SearchParameter(ISearchParameterModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:SearchParameterModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SearchParameterModel" /> instance.
        /// </returns>
        public static Consensus.Search.SearchParameter Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SearchParameter.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SearchParameterModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SearchParameterModel" /> instance.
        /// </returns>
        public static Consensus.Search.SearchParameter Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Search.ISearchParameterModel model = provider.Search.SearchParameter.Create();
            return model == null ? null : new Consensus.Search.SearchParameter(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SearchParameterModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SearchParameterModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Search.SearchParameter> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SearchParameter.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SearchParameterModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SearchParameterModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Search.SearchParameter> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Search.ISearchParameterModel> collection = provider.Search.SearchParameter.FetchAll();
            return collection.Select(model => new Consensus.Search.SearchParameter(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SearchParameterModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SearchParameterModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchParameterModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Search.SearchParameter FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SearchParameter.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SearchParameterModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SearchParameterModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchParameterModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Search.SearchParameter FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Search.ISearchParameterModel model = provider.Search.SearchParameter.FetchById(id);
            return model == null ? null : new Consensus.Search.SearchParameter(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SearchParameter.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Search.SearchParameter.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SearchParameterModel" /> instances.
        /// </summary>
        /// <param name="searchTypeId">
        ///     The value which identifies the <see cref="!:SearchParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchParameterModel" /> instances that match the specified <paramref name="searchTypeId" />.
        /// </returns>
        public static IEnumerable<Consensus.Search.SearchParameter> FetchAllBySearchTypeId(System.Int32 searchTypeId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SearchParameter.FetchAllBySearchTypeId(site,searchTypeId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SearchParameterModel" /> instances.
        /// </summary>
        /// <param name="searchTypeId">
        ///     The value which identifies the <see cref="!:SearchParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchParameterModel" /> instances that match the specified <paramref name="searchTypeId" />.
        /// </returns>
        public static IEnumerable<Consensus.Search.SearchParameter> FetchAllBySearchTypeId(ConsensusSite site, System.Int32 searchTypeId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Search.ISearchParameterModel> collection = provider.Search.SearchParameter.FetchAllBySearchTypeId(searchTypeId);
            return collection.Select(model => new Consensus.Search.SearchParameter(model));
        }

        #endregion
    }
}
