using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public enum QueryConditionTypes
    {
        Equal,

        NotEqual,

        LessThan,

        LessThanOrEqual,

        GreaterThan,

        GreaterThanOrEqual,

        Contains,

        StartsWith,

        EndsWith,

        DoesNotContain,

        DoesNotStartWith,

        DoesNotEndWith
    }
}
