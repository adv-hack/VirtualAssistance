using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Enumerates the special keywords for a parameter
    /// </summary>
    public enum CSharpKeyword
    {
        /// <summary>
        ///     A standardised parameter.
        /// </summary>
        None = 0,

        /// <summary>
        ///     An output parameter which must be initialised before method execution is completed.
        /// </summary>
        Out = 1,

        /// <summary>
        ///     A referenced parameter which allows an existing instance of a type to be manipulated within the method.
        /// </summary>
        Ref = 2,

        /// <summary>
        ///     An optional and variable-length collection of values.
        /// </summary>
        Params = 3
    }
}
