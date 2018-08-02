using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Enumerates the supported access modifiers.
    /// </summary>
    public enum CSharpModifiers
    {
        /// <summary>
        ///     The member or type is globally accessible.
        /// </summary>
        Public,

        /// <summary>
        ///     The member or type is accessible within the same library only.
        /// </summary>
        Internal,

        /// <summary>
        ///     The member or type is accessible only by derived types.
        /// </summary>
        Protected,

        /// <summary>
        ///     The member or type is accessibly within the same class only.
        /// </summary>
        Private,

        /// <summary>
        ///     The member or type is accessible only by derived types or by types in the same library.
        /// </summary>
        Protected_Internal,

        /// <summary>
        ///     The method is declared as partial in the generated file, and has no implementation (it may be implemented in the user file). Method must return void and have no out parameters.
        /// </summary>
        Partial
    }
}
