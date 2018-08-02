using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface IQueryConditionable : IQueryOrderable
    {
        IQueryConditionableAnd Where(String correlation, QueryConditionTypes type, Object value);

        IQueryConditionableAnd WhereCorrelation(String correlation, QueryConditionTypes type, String matchCorrelation);

        IQueryConditionableAnd WhereRaw(String sql, Object value);
    }
}
