using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface IRunnable
    {
        /// <summary>
        ///     Run the query, search or rest call and return the data.
        /// </summary>
        /// <returns></returns>
        object Run();
    }
}
