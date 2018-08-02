using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Enumerates the different build actions for a generated project item.
    /// </summary>
    public enum GeneratedProjectAction
    {
        /// <summary>
        ///     The item is included in the project but is not processed by the build engine.
        /// </summary>
        None = 0,

        /// <summary>
        ///     The item is compiled.
        /// </summary>
        Compile = 1
    }
}
