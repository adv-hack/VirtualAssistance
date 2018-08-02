using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface IQuerySelectable
    {
        IQuerySourceable Select(String column);

        IQuerySourceable Select(String column, String alias);
    }
}
