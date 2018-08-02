using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface IQueryJoinableAnd : IQueryJoinable
    {
        IQueryJoinableAnd And(String correlation, QueryConditionTypes type, Object value);

        IQueryJoinableAnd AndCorrelation(String correlation, QueryConditionTypes type, String matchCorrelation);

    }
}
