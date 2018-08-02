using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface IQueryConditionableAnd : IQueryOrderable
    {
        IQueryConditionableAnd And(String correlation, QueryConditionTypes type, Object value);

        IQueryConditionableAnd AndCorrelation(String correlation, QueryConditionTypes type, String matchCorrelation);

        IQueryConditionableAnd AndRaw(String sql, Object value);
    }
}
