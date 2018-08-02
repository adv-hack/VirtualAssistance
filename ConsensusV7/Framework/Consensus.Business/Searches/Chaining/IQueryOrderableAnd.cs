using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface IQueryOrderableAnd : ISearchesRunnable
    {
        IQueryOrderableAnd ThenBy(String correlation);

        IQueryOrderableAnd ThenBy(String correlation, Boolean ascending);
    }
}
