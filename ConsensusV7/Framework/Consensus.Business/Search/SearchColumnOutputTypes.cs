using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Search
{
    [Flags]
    public enum SearchColumnOutputTypes
    {
        Screen = 1,

        Export = 2,

        Both = SearchColumnOutputTypes.Screen | SearchColumnOutputTypes.Export
    }
}
