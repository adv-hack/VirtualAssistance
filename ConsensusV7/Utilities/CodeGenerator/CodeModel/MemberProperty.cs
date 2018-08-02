using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Represents a property.
    /// </summary>
    public class MemberProperty : MemberNamed
    {
        #region properties

        /// <summary>
        ///     Gets or sets the abstraction of the property.
        /// </summary>
        public CSharpAbstraction MemberAbstraction { get; set; }

        /// <summary>
        ///     Gets or sets the data type for the property.
        /// </summary>
        public String MemberType { get; set; }

        /// <summary>
        ///     Gets or sets the accessor which reads the property value.
        /// </summary>
        public MemberAccessor GetAccessor { get; set; }

        /// <summary>
        ///     Gets or sets the accessor which writes the property value.
        /// </summary>
        public MemberAccessor SetAccessor { get; set; }

        #endregion

        #region constructor

        /// <summary>
        ///     Creates a new <see cref="MemberProperty" /> instance.
        /// </summary>
        /// <param name="parent">
        ///     Sets the parent <see cref="Type" /> in which, this member is defined.
        /// </param>
        public MemberProperty(Type parent) : base(parent)
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
            // Identify the modifies that are applicable to this property
            List<CSharpModifier> modifiers = new List<CSharpModifier>();
            if (this.GetAccessor != null) { modifiers.Add(this.GetAccessor.Modifier); }
            if (this.SetAccessor != null) { modifiers.Add(this.SetAccessor.Modifier); }

            // Output the property comments
            output.AppendLine("        /// <summary>");
            output.AppendLine("        ///     " + this.XmlSummary);
            output.AppendLine("        /// </summary>");
            if (!String.IsNullOrEmpty(this.XmlRemarks))
            {
                output.AppendLine("        /// <remarks>");
                output.AppendLine("        ///     " + this.XmlRemarks);
                output.AppendLine("        /// </remarks>");
            }

            // Output the property declaration
            output.Append("        ");
            output.Append(this.ParentType.GetType().BaseType != typeof(TypeInterface) ? modifiers.Min().ToString().ToLower() + " " : "");
            output.Append(this.MemberAbstraction == CSharpAbstraction.None ? "" : this.MemberAbstraction.ToString().ToLower() + " ");
            output.Append(this.MemberType + " ");
            output.Append(this.MemberName);
            
            // Output the accessors
            if (this.ParentType.GetType().BaseType != typeof(TypeInterface))
            {
                output.AppendLine();
                output.AppendLine("        {");
                this.Generate(output, this.GetAccessor, "get", modifiers.Min());
                this.Generate(output, this.SetAccessor, "set", modifiers.Min());
                output.AppendLine("        }");
            }
            else
            {
                output.Append(" { ");
                output.Append(this.GetAccessor != null ? "get; " : "");
                output.Append(this.SetAccessor != null ? "set; " : "");
                output.AppendLine("}");
            }
        }

        private void Generate(StringBuilder output, MemberAccessor accessor, String accessorName, CSharpModifier propertyModifier)
        {
            if (accessor != null)
            {
                output.Append("            ");
                output.Append(accessor.Modifier == propertyModifier ? null : accessor.Modifier.ToString().ToLower() + " ");
                output.Append(accessorName);

                if (accessor.Code == null || accessor.Code.Length == 0)
                {
                    output.AppendLine(";");
                }
                else if (accessor.Code.Length == 1)
                {
                    output.AppendLine(" { " + accessor.Code[0] + " }");
                }
                else
                {
                    output.AppendLine();
                    output.AppendLine("            {");
                    output.AppendLine(String.Join(Environment.NewLine, accessor.Code.Select(code => "                " + code)));
                    output.AppendLine("            }");
                }
            }
        }

        #endregion
    }
}
