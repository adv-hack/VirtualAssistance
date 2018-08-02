using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Represents a method.
    /// </summary>
    public class MemberMethod : MemberConstructor
    {
        #region properties

        /// <summary>
        ///     Gets or sets the returns section of the xml documentation.
        /// </summary>
        public String XmlReturns { get; set; }

        /// <summary>
        ///     Gets or sets the abstraction of the method.
        /// </summary>
        public CSharpAbstraction MemberAbstraction { get; set; }

        /// <summary>
        ///     Gets or sets the data type that is returned by the method
        /// </summary>
        public String MemberType { get; set; }

        /// <summary>
        ///     Gets or sets the name of the member.
        /// </summary>
        public String MemberName { get; set; }

        /// <summary>
        ///     Gets or sets the generic parameters for the method.
        /// </summary>
        public MemberGeneric[] MemberGenerics { get; set; }

        #endregion

        #region constructor

        /// <summary>
        ///     Creates a new <see cref="MemberMethod" /> instance.
        /// </summary>
        /// <param name="parent">
        ///     Sets the parent <see cref="Type" /> in which, this member is defined.
        /// </param>
        public MemberMethod(Type parent) : base(parent)
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

            // Append the generic parameter documentation
            if (this.MemberGenerics != null)
            {
                foreach (MemberGeneric generic in this.MemberGenerics)
                {
                    output.AppendLine("        /// <typeparam name=\"" + generic.MemberName + "\">");
                    output.AppendLine("        ///     " + generic.XmlSummary);
                    output.AppendLine("        /// </typeparam>");
                }
            }

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

            // Append the xml return information
            if (!String.IsNullOrEmpty(this.MemberType) && !String.Equals(this.MemberType, "void"))
            {
                output.AppendLine("        /// <returns>");
                output.AppendLine("        ///     " + this.XmlReturns);
                output.AppendLine("        /// </returns>");
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
            output.Append(this.ParentType.GetType().BaseType != typeof(TypeInterface) ? this.MemberModifier.ToString().ToLower() + " " : "");
            output.Append(this.MemberAbstraction == CSharpAbstraction.None ? "" : this.MemberAbstraction.ToString().ToLower() + " ");
            output.Append(this.MemberType + " ");
            output.Append(this.MemberName);
            output.Append(this.MemberGenerics == null || !this.MemberGenerics.Any() ? "" : "<" + String.Join(", ", this.MemberGenerics.Select(gen => gen.MemberName)) + ">");
            output.Append("(");
            output.Append(this.MemberParameters == null ? "" : String.Join(", ", this.MemberParameters.Select(param => (param.MemberKeyword == CSharpKeyword.None ? "" : param.MemberKeyword.ToString().ToLower() + " ") + param.MemberType + " " + param.MemberName)));
            output.Append(")");
            output.Append(this.MemberGenerics == null || !this.MemberGenerics.Any(gen => gen.MemberConstraint != null && gen.MemberConstraint.Length != 0) ? "" : String.Join("", this.MemberGenerics.Select(gen => " where " + gen.MemberName + " : " + String.Join(", ", gen.MemberConstraint))));
            if (this.ParentType.GetType().BaseType != typeof(TypeInterface) && this.MemberAbstraction != CSharpAbstraction.Abstract)
            {
                output.AppendLine();
                output.AppendLine("        {");
                if (this.Code != null && this.Code.Any())
                    output.AppendLine(String.Join(Environment.NewLine, this.Code.Select(code => "            " + code)));
                output.AppendLine("        }");
            }
            else
            {
                output.AppendLine(";");
            }
        }

        #endregion
    }
}
