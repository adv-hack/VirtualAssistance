using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Enumerates the accessibility modifiers
    /// </summary>
    public enum CSharpModifier
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
        ///     The member or types is accessibly within the same class only.
        /// </summary>
        Private,
    }
}
