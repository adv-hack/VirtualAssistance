using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Enumerates the different types of field
    /// </summary>
    public enum MemberFieldType 
    {
        /// <summary>
        ///     A standard modifiable field defined on the instance.
        /// </summary>
        Instance,

        /// <summary>
        ///     A readonly field which can be initialised using either a default value or within the constructor only.
        /// </summary>
        ReadOnly,

        /// <summary>
        ///     A static field.
        /// </summary>
        Static,

        /// <summary>
        ///     A static, readonly field which must be initialised using a default value or a reference to the required default.
        /// </summary>
        Static_ReadOnly
    }
}
