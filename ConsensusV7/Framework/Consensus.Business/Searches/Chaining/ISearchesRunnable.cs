using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface ISearchesRunnable : IRunnable
    {
        /// <summary>
        ///     Run the query or search call and return the data.
        ///     Query and search objects that are runnable can also be serialised.
        /// </summary>
        /// <returns></returns>
        new Dictionary<string, object>[] Run();
        
        IDictionary<string, object> Serialize();
    }
}
