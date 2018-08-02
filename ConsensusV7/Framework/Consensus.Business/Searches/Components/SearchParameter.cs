using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface SearchParameter
    {
        String Parameter { get; }

        Object Value { get; set; }
    }
}
