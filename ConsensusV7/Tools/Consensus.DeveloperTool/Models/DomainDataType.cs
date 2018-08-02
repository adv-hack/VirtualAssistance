using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Enumerates the database types that are supported within a business domain.
    /// </summary>
    public enum DomainDataType
    {
        /// <summary>
        ///     A boolean value.
        /// </summary>
        Boolean,

        /// <summary>
        ///     A tinyint value, ranging between 0 and 255.
        /// </summary>
        Byte,

        /// <summary>
        ///     A fixed length ASCII string value
        /// </summary>
        Char,

        /// <summary>
        ///     A date, time or date-time value.
        /// </summary>
        DateTime,

        /// <summary>
        ///     A decimal value.
        /// </summary>
        Decimal,

        /// <summary>
        ///     A floating point or double precision number.
        /// </summary>
        Double,

        /// <summary>
        ///     A globally unique identifier.
        /// </summary>
        Guid,

        /// <summary>
        ///     A 16-bit integer ranging from -32768 and 32767.
        /// </summary>
        Int16,

        /// <summary>
        ///     A 32-bit integer ranging from -2147483648 and 2147483647.
        /// </summary>
        Int32,

        /// <summary>
        ///     A 64-bit integer ranging from -9223372036854775808 and 9223372036854775807.
        /// </summary>
        Int64,

        /// <summary>
        ///     A fixed length UTF8 string value.
        /// </summary>
        NChar,

        /// <summary>
        ///     A variable length UTF8 string value.
        /// </summary>
        NVarchar,

        /// <summary>
        ///     A real or single precision number.
        /// </summary>
        Single,

        /// <summary>
        ///     A binary value, such as cryptographic data or the content of a file.
        /// </summary>
        VarBinary,

        /// <summary>
        ///     A variable length ASCII string value.
        /// </summary>
        Varchar
    }
}
