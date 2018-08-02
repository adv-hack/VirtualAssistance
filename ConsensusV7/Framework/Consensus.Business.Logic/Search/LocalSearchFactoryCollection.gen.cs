using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Search namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSearchFactoryCollection : LocalFactoryCollection, ISearchFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SearchTypeModel" /> objects.
        /// </summary>
        private LocalSearchTypeFactory _searchType;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SearchColumnModel" /> objects.
        /// </summary>
        private LocalSearchColumnFactory _searchColumn;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SearchParameterModel" /> objects.
        /// </summary>
        private LocalSearchParameterFactory _searchParameter;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SearchTypeModel" /> objects.
        /// </summary>
        public LocalSearchTypeFactory SearchType
        {
            get { return LocalFactory.Create(this.Provider, ref _searchType); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SearchColumnModel" /> objects.
        /// </summary>
        public LocalSearchColumnFactory SearchColumn
        {
            get { return LocalFactory.Create(this.Provider, ref _searchColumn); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SearchParameterModel" /> objects.
        /// </summary>
        public LocalSearchParameterFactory SearchParameter
        {
            get { return LocalFactory.Create(this.Provider, ref _searchParameter); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SearchTypeModel" /> objects.
        /// </summary>
        Consensus.Search.ISearchTypeFactory ISearchFactoryCollection.SearchType
        {
            get { return this.SearchType; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SearchColumnModel" /> objects.
        /// </summary>
        Consensus.Search.ISearchColumnFactory ISearchFactoryCollection.SearchColumn
        {
            get { return this.SearchColumn; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SearchParameterModel" /> objects.
        /// </summary>
        Consensus.Search.ISearchParameterFactory ISearchFactoryCollection.SearchParameter
        {
            get { return this.SearchParameter; }
        }

        #endregion
    }
}
