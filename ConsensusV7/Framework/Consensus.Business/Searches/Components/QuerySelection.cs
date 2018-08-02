using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface QuerySelection
    {
        String Column { get; }

        String Alias { get; }
    }
}
