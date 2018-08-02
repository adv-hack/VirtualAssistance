using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Enumerates the different types of attribute exposure.
    /// </summary>
    public enum DomainEntityAttributeExposure
    {
        /// <summary>
        ///     The attribute includes a get accessor and a set accessor.
        /// </summary>
        Normal = 0,

        /// <summary>
        ///     The attribute includes a get accessor.
        /// </summary>
        ReadOnly = 1,

        /// <summary>
        ///     The attribute includes a set accessor.
        /// </summary>
        WriteOnly = 2
    }
}
