using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface IQueryOrderable : ISearchesRunnable
    {
        IQueryOrderableAnd OrderBy(String correlation);

        IQueryOrderableAnd OrderBy(String correlation, Boolean ascending);
    }
}
