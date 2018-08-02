using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    [Flags]
    public enum CSharpFieldFlags
    {
        Normal = 0,

        ReadOnly = 1,

        Static = 2,
    }
}
