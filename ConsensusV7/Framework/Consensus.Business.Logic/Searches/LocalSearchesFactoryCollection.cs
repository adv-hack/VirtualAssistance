using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public class LocalSearchesFactoryCollection : LocalFactoryCollection, SearchesFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="QueryModel" /> objects.
        /// </summary>
        private LocalQueryFactory _query;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SearchModel" /> objects.
        /// </summary>
        private LocalSearchFactory _search;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="RestCallModel" /> objects.
        /// </summary>
        private LocalRestCallFactory _restCall;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="QueryModel" /> objects.
        /// </summary>
        public LocalQueryFactory Query
        {
            get { return LocalFactory.Create(this.Provider, ref _query); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="RestCallModel" /> objects.
        /// </summary>
        public RestCallFactory RestCall
        {
            get { return LocalFactory.Create(this.Provider, ref _restCall); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SearchModel" /> objects.
        /// </summary>
        public SearchFactory Search
        {
            get { return LocalFactory.Create(this.Provider, ref _search); }
        }

        #endregion

        #region implementation

        QueryFactory SearchesFactoryCollection.Query
        {
            get { return this.Query; }
        }

        #endregion
    }
}
