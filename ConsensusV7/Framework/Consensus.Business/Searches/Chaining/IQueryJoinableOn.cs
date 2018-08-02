using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface IQueryJoinableOn
    {
        IQueryJoinableAnd On(String correlation, QueryConditionTypes type, Object value);

        IQueryJoinableAnd OnCorrelation(String correlation, QueryConditionTypes type, String matchCorrelation);
    }
}
