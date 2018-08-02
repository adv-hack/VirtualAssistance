using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface QueryJoin : QuerySource
    {
        QueryJoinTypes Type
        {
            get;
        }

        QueryCondition[] Conditions
        {
            get;
        }
    }
}
