using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Represents Provides the definition for each type of search that is available within the application.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SearchType : Proxy<ISearchTypeModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Columns" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Search.SearchColumn, Consensus.Search.ISearchColumnModel> _columns;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Parameters" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Search.SearchParameter, Consensus.Search.ISearchParameterModel> _parameters;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "SYSS_TYPE" field.
        /// </summary>
        public System.String Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_PAGE_TITLE" field.
        /// </summary>
        public System.String PageTitle
        {
            get { return this.Model.PageTitle; }
            set { this.Model.PageTitle = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_DB_VIEW_NAME" field.
        /// </summary>
        public System.String DatabaseView
        {
            get { return this.Model.DatabaseView; }
            set { this.Model.DatabaseView = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_NEW_BUTTON" field.
        /// </summary>
        public System.String NewButton
        {
            get { return this.Model.NewButton; }
            set { this.Model.NewButton = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSS_SAVE_JSON" field.
        /// </summary>
        public System.String SaveJson
        {
            get { return this.Model.SaveJson; }
            set { this.Model.SaveJson = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SearchColumnModel" /> instances that reference this <see cref="!:SearchTypeModel" />.
        /// </summary>
        public Collection<Consensus.Search.SearchColumn> Columns
        {
            get
            {
                if (_columns == null)
                    _columns = new ProxyCollection<Consensus.Search.SearchColumn, Consensus.Search.ISearchColumnModel>(this.Model.Columns, model => new Consensus.Search.SearchColumn(model));
                return _columns;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SearchParameterModel" /> instances that reference this <see cref="!:SearchTypeModel" />.
        /// </summary>
        public Collection<Consensus.Search.SearchParameter> Parameters
        {
            get
            {
                if (_parameters == null)
                    _parameters = new ProxyCollection<Consensus.Search.SearchParameter, Consensus.Search.ISearchParameterModel>(this.Model.Parameters, model => new Consensus.Search.SearchParameter(model));
                return _parameters;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SearchType(ISearchTypeModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:SearchTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SearchTypeModel" /> instance.
        /// </returns>
        public static Consensus.Search.SearchType Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SearchType.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SearchTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SearchTypeModel" /> instance.
        /// </returns>
        public static Consensus.Search.SearchType Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Search.ISearchTypeModel model = provider.Search.SearchType.Create();
            return model == null ? null : new Consensus.Search.SearchType(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SearchTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SearchTypeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Search.SearchType> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SearchType.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SearchTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SearchTypeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Search.SearchType> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Search.ISearchTypeModel> collection = provider.Search.SearchType.FetchAll();
            return collection.Select(model => new Consensus.Search.SearchType(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SearchTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SearchTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Search.SearchType FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SearchType.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SearchTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SearchTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Search.SearchType FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Search.ISearchTypeModel model = provider.Search.SearchType.FetchById(id);
            return model == null ? null : new Consensus.Search.SearchType(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SearchType.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Search.SearchType.GetTableName();
        }

        #endregion
    }
}
