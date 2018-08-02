using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Enumerates the different abstractions available for a class, method or property
    /// </summary>
    public enum CSharpAbstraction
    {
        /// <summary>
        ///     No abstraction.
        /// </summary>
        None, 

        /// <summary>
        ///     An abstract type or member that is implemented by a derived type
        /// </summary>
        Abstract,

        /// <summary>
        ///     A virtual member that can be overridden by a derived type
        /// </summary>
        Virtual,

        /// <summary>
        ///     An overriding method or property within a derived type
        /// </summary>
        Override,

        /// <summary>
        ///     A static type, property or method
        /// </summary>
        Static
    }
}
