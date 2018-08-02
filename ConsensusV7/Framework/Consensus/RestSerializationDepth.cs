using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus
{
    public enum RestSerializationDepth
    {
        Root = 1,
        Child = 2,
        GrandChild = 3,
        None = 0
    }
}
