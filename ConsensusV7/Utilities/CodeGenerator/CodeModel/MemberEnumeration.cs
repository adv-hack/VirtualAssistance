using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Represents an enumeration value.
    /// </summary>
    public class MemberEnumeration : MemberNamed
    {
        #region constructor

        /// <summary>
        ///     Creates a new <see cref="MemberEnumeration" /> instance.
        /// </summary>
        /// <param name="parent">
        ///     Sets the parent <see cref="Type" /> in which, this member is defined.
        /// </param>
        public MemberEnumeration(Type parent) : base(parent)
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
        public override void Generate(StringBuilder output)
        {
            output.AppendLine("        /// <summary>");
            output.AppendLine("        ///     " + this.XmlSummary);
            output.AppendLine("        /// </summary>");
            if (!String.IsNullOrEmpty(this.XmlRemarks))
            {
                output.AppendLine("        /// <remarks>");
                output.AppendLine("        ///     " + this.XmlRemarks);
                output.AppendLine("        /// </remarks>");
            }
            output.AppendLine("        " + this.MemberName);
        }

        #endregion
    }
}
