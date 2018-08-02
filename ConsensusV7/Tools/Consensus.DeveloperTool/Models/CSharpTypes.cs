using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Enumerates the different types of runtime types that are supported.
    /// </summary>
    public enum CSharpTypes
    {
        /// <summary>
        ///     The generated type is an enumerator.
        /// </summary>
        Enum,

        /// <summary>
        ///     The generated type is an interface.
        /// </summary>
        Interface,

        /// <summary>
        ///     The generated type is a struct.
        /// </summary>
        Struct,

        /// <summary>
        ///     The generated type is a class.
        /// </summary>
        Class
    }
}
