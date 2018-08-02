using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Represents a method or constructor parameter
    /// </summary>
    public class MemberParameter : MemberNamed
    {
        #region properties

        /// <summary>
        ///     Gets or sets the data type for the parameter.
        /// </summary>
        public String MemberType { get; set; }

        /// <summary>
        ///     Gets or sets the keyword for the parameter.
        /// </summary>
        public CSharpKeyword MemberKeyword { get; set; }

        #endregion

        #region constructor

        /// <summary>
        ///     Creates a new <see cref="MemberParameter" /> instance.
        /// </summary>
        public MemberParameter() : base(null)
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
        ///     Code generation for parameters must be completed within the method or type code generation routine.
        /// </remarks>
        public override void Generate(StringBuilder output)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
