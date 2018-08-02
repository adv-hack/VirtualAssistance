using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Represents a constructor.
    /// </summary>
    public class MemberConstructor : Member
    {
        #region properties

        /// <summary>
        ///     Gets or sets the access modifier for the field.
        /// </summary>
        public CSharpModifier MemberModifier { get; set; }

        /// <summary>
        ///     Gets or sets the parameters for the constructor/method.
        /// </summary>
        public MemberParameter[] MemberParameters { get; set; }

        /// <summary>
        ///     Gets or sets the call to the base constructor
        /// </summary>
        public String MemberInvocation { get; set; } 

        /// <summary>
        ///     Gets or sets the method code.
        /// </summary>
        public String[] Code { get; set; }

        #endregion
        
        #region constructor

        /// <summary>
        ///     Creates a new <see cref="MemberConstructor" /> instance.
        /// </summary>
        /// <param name="parent">
        ///     Sets the parent <see cref="Type" /> in which, this member is defined.
        /// </param>
        public MemberConstructor(Type parent) : base(parent)
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
            // Output the xml documentation
            output.AppendLine("        /// <summary>");
            output.AppendLine("        ///     " + this.XmlSummary);
            output.AppendLine("        /// </summary>");

            // Append the parameter documentation
            if (this.MemberParameters != null)
            {
                foreach (MemberParameter parameter in this.MemberParameters)
                {
                    // Output the xml documentation
                    output.AppendLine("        /// <param name=\"" + parameter.MemberName + "\">");
                    output.AppendLine("        ///     " + parameter.XmlSummary);
                    output.AppendLine("        /// </param>");
                }
            }

            // Append any xml remarks
            if (!String.IsNullOrEmpty(this.XmlRemarks))
            {
                output.AppendLine("        /// <remarks>");
                output.AppendLine("        ///     " + this.XmlRemarks);
                output.AppendLine("        /// </remarks>");
            }

            // Append the constructor declaration
            output.Append("        ");
            output.Append(this.MemberModifier.ToString().ToLower() + " ");
            output.Append(this.ParentType.TypeName + "(");
            output.Append(this.MemberParameters == null ? "" : String.Join(", ", this.MemberParameters.Select(param => param.MemberType + " " + param.MemberName)));
            output.Append(")");
            if (!String.IsNullOrEmpty(this.MemberInvocation))
                output.Append(" : base(" + this.MemberInvocation + ")");
            output.AppendLine("");
            output.AppendLine("        {");
            if (this.Code != null && this.Code.Any())
                output.AppendLine(String.Join(Environment.NewLine, this.Code.Select(code => "            " + code)));
            output.Append("        }");
            output.AppendLine();
        }

        #endregion
    }
}
