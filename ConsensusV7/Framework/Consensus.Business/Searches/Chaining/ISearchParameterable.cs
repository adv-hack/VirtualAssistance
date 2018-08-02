using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface ISearchParameterable : ISearchesRunnable
    {
        /// <summary>
        ///     Adds a parameter to search.
        /// </summary>
        /// <param name="parameterName">
        ///     The name of the parameter to be added.
        /// </param>
        /// <param name="value">
        ///     The value of the parameter to be added.
        /// </param>
        ISearchParameterable AddParameter(String parameterName, Object value);
    }
}
