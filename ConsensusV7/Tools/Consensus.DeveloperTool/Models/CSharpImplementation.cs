using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public abstract class CSharpImplementation : CSharpMember
    {
        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="CSharpImplementation" /> instance
        /// </summary>
        /// <param name="type">
        ///     Sets the generated runtime type, in which this member is defined.
        /// </param>
        public CSharpImplementation(GeneratedType type) : base(type)
        {
        }

        #endregion
    }
}
