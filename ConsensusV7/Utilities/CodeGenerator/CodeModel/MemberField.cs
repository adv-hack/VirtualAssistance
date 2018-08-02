using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Represents a field.
    /// </summary>
    public class MemberField : MemberEnumeration
    {
        #region properties

        /// <summary>
        ///     Gets or sets the type of field.
        /// </summary>
        public MemberFieldType MemberFieldType { get; set; }

        /// <summary>
        ///     Gets or sets the access modifier for the field.
        /// </summary>
        public CSharpModifier MemberModifier { get; set; }

        /// <summary>
        ///     Gets or sets the data type for the field.
        /// </summary>
        public String MemberType { get; set; }

        /// <summary>
        ///     Gets or sets the value initialiser for the member.
        /// </summary>
        public String MemberValue { get; set; }

        #endregion

        #region constructor

        /// <summary>
        ///     Creates a new <see cref="MemberField" /> instance.
        /// </summary>
        /// <param name="parent">
        ///     Sets the parent <see cref="Type" /> in which, this member is defined.
        /// </param>
        public MemberField(Type parent) : base(parent)
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
            if (!String.IsNullOrEmpty(this.XmlRemarks))
            {
                output.AppendLine("        /// <remarks>");
                output.AppendLine("        ///     " + this.XmlRemarks);
                output.AppendLine("        /// </remarks>");
            }

            // Output the field declaration
            output.Append("        ");
            output.Append(this.MemberModifier.ToString().ToLower() + " ");
            output.Append(this.MemberFieldType == MemberFieldType.Instance ? "" : this.MemberFieldType.ToString().ToLower().Replace("_", " ") + " ");
            output.Append(this.MemberType + " ");
            output.Append(this.MemberName);
            output.Append(String.IsNullOrEmpty(this.MemberValue) ? "" : " = " + this.MemberValue);
            output.Append(";");
            output.AppendLine();
        }

        #endregion
    }
}
