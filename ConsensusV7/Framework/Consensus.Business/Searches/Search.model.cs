using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface SearchModel : IModel, ISearchParameterable
    {
        /// <summary>
        ///     Gets the type of search.
        /// </summary>
        SearchTypes Type { get; }

        /// <summary>
        ///     Gets the parameters defined for the search.
        /// </summary>
        SearchParameter[] Parameters { get; }
    }
}
