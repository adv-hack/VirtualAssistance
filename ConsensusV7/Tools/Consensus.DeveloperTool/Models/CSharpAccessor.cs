using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class CSharpAccessor
    {
        /// <summary>
        ///     Gets or sets the modifier for the accessor.
        /// </summary>
        public CSharpModifiers AccessorModifier { get; set; }

        /// <summary>
        ///     Gets or sets the code for the accessor.
        /// </summary>
        public String[] AccessorCode { get; set; }
    }
}
