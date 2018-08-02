using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     A property accessor
    /// </summary>
    public class MemberAccessor
    {
        #region properties

        /// <summary>
        ///     Gets or sets the modifier for the accessor.
        /// </summary>
        public CSharpModifier Modifier { get; set; }

        /// <summary>
        ///     Gets or sets the accessor code.
        /// </summary>
        public String[] Code { get; set; }

        #endregion
    }
}
