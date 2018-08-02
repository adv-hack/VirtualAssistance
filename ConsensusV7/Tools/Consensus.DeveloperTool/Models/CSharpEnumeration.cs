using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Represents an enumeration member.
    /// </summary>
    public class CSharpEnumeration : CSharpMember
    {
        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="CSharpEnumeration" /> instance
        /// </summary>
        /// <param name="type">
        ///     Sets the generated runtime type, in which this member is defined.
        /// </param>
        public CSharpEnumeration(GeneratedEnumerator type) : base(type)
        {
        }

        #endregion
    }
}
