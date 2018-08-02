using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface IQueryJoinable : IQueryConditionable
    {
        IQueryJoinableOn Join(QuerySources source);

        IQueryJoinableOn Join(QuerySources source, String alias);

        IQueryJoinableOn Join(QueryJoinTypes type, QuerySources source);

        IQueryJoinableOn Join(QueryJoinTypes type, QuerySources source, String alias);

         
    }
}
