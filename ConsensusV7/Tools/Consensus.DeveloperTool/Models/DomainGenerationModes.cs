using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Enumerates the different generation modes.
    /// </summary>
    public enum DomainGenerationModes
    {
        /// <summary>
        ///     Generate all types
        /// </summary>
        Complete,

        /// <summary>
        ///     Generate all types that have changed since the last build.
        /// </summary>
        BuildChanges,

        /// <summary>
        ///     Generate all types that have changed since the last patch.
        /// </summary>
        PatchChanges
    }
}
