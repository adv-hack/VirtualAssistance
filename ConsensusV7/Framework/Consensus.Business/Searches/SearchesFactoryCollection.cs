using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface SearchesFactoryCollection
    {
        /// <summary>
        ///     Gets the executable factory which is responsible for instantiating <see cref="T:Consensus.Searches.QueryModel" /> objects.
        /// </summary>
        QueryFactory Query
        {
            get;
        }
        /// <summary>
        ///     Gets the executable factory which is responsible for instantiating <see cref="T:Consensus.Searches.SearchModel" /> objects.
        /// </summary>
        SearchFactory Search
        {
            get;
        }
        /// <summary>
        ///     Gets the executable factory which is responsible for instantiating <see cref="T:Consensus.Searches.RestCallModel" /> objects.
        /// </summary>
        RestCallFactory RestCall
        {
            get;
        }
    }
}
