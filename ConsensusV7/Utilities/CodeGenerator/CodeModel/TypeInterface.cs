using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Represents an interface runtime type 
    /// </summary>
    public abstract class TypeInterface : Type
    {
        #region properties

        /// <summary>
        ///     Gets the name of the file.
        /// </summary>
        public override String FileName
        {
            get { return this.TypeName + (this.TypeGenerics == null || !this.TypeGenerics.Any() ? "" : "Of" + String.Join("", this.TypeGenerics.Select(gen => gen.MemberName))) + ".cs"; }
        }

        /// <summary>
        ///     Gets the type of code object being declared (class, struct, interface, etc).
        /// </summary>
        public override String DeclarationType
        {
            get { return "interface"; }
        }

        /// <summary>
        ///     Gets the declared name of the type.
        /// </summary>
        public sealed override String DeclarationName
        {
            get { return this.TypeName + (this.TypeGenerics == null || !this.TypeGenerics.Any() ? "" : "<" + String.Join(", ", this.TypeGenerics.Select(gen => gen.MemberName)) + ">"); }
        }

        /// <summary>
        ///     Gets the inheritence chain defined within the type declaration
        /// </summary>
        public virtual String DeclarationInheritence
        {
            get { return this.TypeInterfaces == null || !this.TypeInterfaces.Any() ? "" : String.Join(", ", this.TypeInterfaces); }
        }

        /// <summary>
        ///     Gets the generic parameter constraints that are defined within the type declaration
        /// </summary>
        public String DeclarationConstraint
        {
            get
            {

                String constraint = "";
                if (this.TypeGenerics != null)
                {
                    IEnumerable<MemberGeneric> constraints = this.TypeGenerics.Where(gen => gen.MemberConstraint != null && gen.MemberConstraint.Length != 0);
                    IEnumerable<String> constraintStrings = constraints.Select(gen => " where " + gen.MemberName + " : " + String.Join(", ", gen.MemberConstraint));
                    constraint = String.Join("", constraintStrings);
                }
                return constraint;
            }
        }

        /// <summary>
        ///     Gets whether the interface, struct or class definition is spread over multiple files.
        /// </summary>
        public virtual Boolean TypePartial
        {
            get { return false; }
        }

        /// <summary>
        ///     Gets the generic parameters for the type.
        /// </summary>
        public virtual IEnumerable<MemberGeneric> TypeGenerics
        {
            get { return null; }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public virtual IEnumerable<String> TypeInterfaces
        {
            get { return null; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Generates additional xml comments for the runtime type
        /// </summary>
        /// <param name="output">
        ///     The string builder instance to which all generated code is appended.
        /// </param>
        protected override void GenerateHeader(StringBuilder output)
        {
            if (this.TypeGenerics != null && this.TypeGenerics.Any())
            {
                foreach (MemberGeneric generic in this.TypeGenerics)
                {
                    output.AppendLine("    /// <typeparam name=\"" + generic.MemberName + "\">");
                    output.AppendLine("    ///     " + generic.XmlSummary);
                    output.AppendLine("    /// </typeparam>");
                }
            }
        }

        /// <summary>
        ///     Generates the runtime type declaration
        /// </summary>
        /// <param name="output">
        ///     The string builder instance to which all generated code is appended.
        /// </param>
        protected override void GenerateDeclaration(StringBuilder output)
        {
            output.Append("    ");
            output.Append(this.TypeModifier.ToString().ToLower() + " ");
            if (this.TypePartial) { output.Append("partial "); }
            output.Append(this.DeclarationType.ToLower() + " ");
            output.Append(this.DeclarationName);
            output.Append(String.IsNullOrEmpty(this.DeclarationInheritence) ? "" : " : " + this.DeclarationInheritence);
            output.Append(this.DeclarationConstraint);
            output.AppendLine();
        }

        /// <summary>
        ///     Generates the body of the runtime type
        /// </summary>
        /// <param name="output">
        ///     The string builder instance to which all generated code is appended.
        /// </param>
        protected override void GenerateContent(StringBuilder output)
        {
            StringBuilder regionBuilder = new StringBuilder();
            this.GenerateRegion<MemberProperty>(regionBuilder, "properties");
            this.GenerateRegion<MemberMethod>(regionBuilder, "methods");
            output.Append(regionBuilder.ToString());
        }

        /// <summary>
        ///     Generates a regionalised section of code within the body of the runtime type
        /// </summary>
        /// <param name="output">
        ///     The string builder instance to which all generated code is appended.
        /// </param>
        /// <param name="regionName">
        ///     The name of the region
        /// </param>
        protected void GenerateRegion<MemberType>(StringBuilder output, String regionName) where MemberType : Member
        {
            Member[] membersRegion = (this.Members == null ? null : this.Members.Where(member => member.GetType() == typeof(MemberType)).ToArray());
            Member[] membersOthers = (this.Members == null ? null : this.Members.Where(member => member.GetType() != typeof(MemberType)).ToArray());
            if (membersRegion != null && membersRegion.Length != 0)
            {
                Boolean useRegions = (membersOthers != null && membersOthers.Length != 0);

                // Append the region header
                if (useRegions)
                {
                    output.Append(output.Length == 0 ? "" : Environment.NewLine);
                    output.AppendLine("        #region " + regionName);
                }

                // Append the region content                
                foreach (Member member in membersRegion)
                {
                    output.Append(output.Length == 0 ? "" : Environment.NewLine);
                    member.Generate(output);
                }

                // Append the region footer
                if (useRegions)
                {
                    output.AppendLine();
                    output.AppendLine("        #endregion");
                }
            }
        }

        #endregion
    }
}

