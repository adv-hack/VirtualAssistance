using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface IQuerySourceable : IQuerySelectable
    {
        IQueryJoinable From(QuerySources source);

        IQueryJoinable From(QuerySources source, String alias);
    }
}
