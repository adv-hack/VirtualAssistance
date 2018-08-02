using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Represents a generic type parameter.
    /// </summary>
    public class MemberGeneric : MemberNamed
    {
        #region properties

        /// <summary>
        ///     Gets or sets the constraints applicable to the generic parameter
        /// </summary>
        public String[] MemberConstraint { get; set; }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="MemberGeneric"/> instance.
        /// </summary>
        public MemberGeneric() : base(null)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Generates the C-Sharp code for the member.
        /// </summary>
        /// <param name="output">
        ///     The string builder, to which the generated code is written.
        /// </param>
        /// <remarks>
        ///     Code generation for generic parameters must be completed within the method or type code generation routine.
        /// </remarks>
        public override void Generate(StringBuilder output)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
