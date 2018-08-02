using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public abstract class GeneratedStruct : GeneratedInterface
    {
        #region properties

        /// <summary>
        ///     Gets the declaration type of the generated runtime type.
        /// </summary>
        public override CSharpTypes DeclarationType
        {
            get { return CSharpTypes.Struct; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="GeneratedStruct" /> instance.
        /// </summary>
        /// <param name="taskList">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        public GeneratedStruct(GeneratedProject project) : base(project)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Generates the members within the runtime type.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        protected override void GenerateRegions(StreamWriter writer)
        {
            Boolean isModel = this.FileName.Contains(".model.");

            // Generate the members in the interface
            CSharpMember[] members = this.TypeMembers.ToArray();
            this.GenerateRegion<CSharpField>(writer, members, "fields", this.GenerateMember);
            this.GenerateRegion<CSharpProperty>(writer, members, "properties", this.GenerateMember);
            this.GenerateRegion<CSharpConstructor>(writer, members, "constructors", this.GenerateMember);
            this.GenerateRegion<CSharpMethod>(writer, members, "methods", this.GenerateMember);
            this.GenerateRegion<CSharpImplementation>(writer, members, "implementations", this.GenerateMember);
        }

        /// <summary>
        ///     Generates a field member within the runtime type.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        /// <param name="member">
        ///     The field to be generated.
        /// </param>
        protected virtual void GenerateMember(StreamWriter writer, CSharpField member)
        {
            // Generate the documentation
            this.GenerateDocumentation(writer, true, "summary", member.XmlSummary);
            this.GenerateDocumentation(writer, true, "remarks", member.XmlRemarks);

            // Generate the signature
            if (member.Attributes != null && member.Attributes.Length != 0)
                writer.WriteLine("        [" + String.Join(", ", member.Attributes) + "]");
            writer.Write("        ");
            writer.Write(member.FieldModifier.ToString().ToLower().Replace("_", " ") + " ");
            switch (member.FieldFlags)
            {
                case CSharpFieldFlags.Static: writer.Write("static "); break;
                case CSharpFieldFlags.ReadOnly: writer.Write("readonly "); break;
                case CSharpFieldFlags.Static | CSharpFieldFlags.ReadOnly: writer.Write("const "); break;
            }
            writer.Write(member.FieldType + " ");
            writer.Write(member.Name);
            writer.Write(String.IsNullOrEmpty(member.FieldValue) ? "" : " = " + member.FieldValue);
            writer.Write(";");
            writer.WriteLine();
        }

        /// <summary>
        ///     Generates a property member within the runtime type.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        /// <param name="member">
        ///     The property to be generated.
        /// </param>
        protected override void GenerateMember(StreamWriter writer, CSharpProperty member)
        {
            List<CSharpModifiers> modifiers = new List<CSharpModifiers>();
            if (member.PropertyGetter != null) { modifiers.Add(member.PropertyGetter.AccessorModifier); }
            if (member.PropertySetter != null) { modifiers.Add(member.PropertySetter.AccessorModifier); }
            
            // Generate the documentation
            this.GenerateDocumentation(writer, true, "summary", member.XmlSummary);
            this.GenerateDocumentation(writer, true, "remarks", member.XmlRemarks);

            // Generate the signature
            if (member.Attributes != null && member.Attributes.Length != 0)
                writer.WriteLine("        [" + String.Join(", ", member.Attributes) + "]");
            writer.Write("        ");
            writer.Write(modifiers.Min().ConvertTo<String>().ToLower().Replace("_", " "));
            writer.Write(" ");
            writer.Write(member.PropertyAbstraction == CSharpAbstractions.None ? "" : member.PropertyAbstraction.ConvertTo<String>().ToLower() + " ");
            writer.Write(member.PropertyType);
            writer.Write(" ");
            writer.Write(member.Name);
            writer.WriteLine();

            // Generate the accessors
            writer.WriteLine("        {");
            this.GenerateMember(writer, member.PropertyGetter, "get", modifiers.Min());
            this.GenerateMember(writer, member.PropertySetter, "set", modifiers.Min());
            writer.WriteLine("        }");
        }

        /// <summary>
        ///     Generates a constructor member within the runtime type.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        /// <param name="member">
        ///     The constructor to be generated.
        /// </param>
        protected virtual void GenerateMember(StreamWriter writer, CSharpConstructor member)
        {
            // Generate the documentation
            this.GenerateDocumentation(writer, true, "summary", member.XmlSummary);
            this.GenerateDocumentation(writer, true, member.ConstructorParameters);
            this.GenerateDocumentation(writer, true, "remarks", member.XmlRemarks);

            // Generate the signature
            if (member.Attributes != null && member.Attributes.Length != 0)
                writer.WriteLine("        [" + String.Join(", ", member.Attributes) + "]");
            writer.Write("        ");
            writer.Write(member.ConstructorModifier.ConvertTo<String>().ToLower().Replace("_", " "));
            writer.Write(" ");
            writer.Write(this.TypeName);
            writer.Write("(");
            writer.Write(member.ConstructorParameters == null || !member.ConstructorParameters.Any() ? "" : String.Join(", ", member.ConstructorParameters.Select(parameter => (parameter.ParameterReference == CSharpReference.None ? "" : parameter.ParameterReference.ConvertTo<String>().ToLower() + " ") + parameter.ParameterType + " " + parameter.ParameterName)));
            writer.Write(")");
            
            // Generate the call to the base constructor
            if (member.ConstructorBase != null && member.ConstructorBase.Any())
                writer.Write(" : base(" + String.Join(", ", member.ConstructorBase) + ")");
            
            // Generate the code
            writer.WriteLine();
            writer.WriteLine("        {");
            member.ConstructorCode.Execute(code => writer.WriteLine("            " + code));
            writer.WriteLine("        }");
        }

        /// <summary>
        ///     Generates a method member within the runtime type.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        /// <param name="member">
        ///     The method to be generated.
        /// </param>
        protected override void GenerateMember(StreamWriter writer, CSharpMethod member)
        {
            // Generate the documentation
            this.GenerateDocumentation(writer, true, "summary", member.XmlSummary);
            this.GenerateDocumentation(writer, true, member.MethodGenerics);
            this.GenerateDocumentation(writer, true, member.MethodParameters);
            this.GenerateDocumentation(writer, true, "returns", member.XmlReturns);
            this.GenerateDocumentation(writer, true, "remarks", member.XmlRemarks);

            // Generate the signature
            if (member.Attributes != null && member.Attributes.Length != 0)
                writer.WriteLine("        [" + String.Join(", ", member.Attributes) + "]");
            writer.Write("        ");
            writer.Write(member.MethodModifier.ConvertTo<String>().ToLower().Replace("_", " "));
            writer.Write(" ");
            writer.Write(member.MethodAbstraction == CSharpAbstractions.None ? "" : member.MethodAbstraction.ConvertTo<String>().ToLower() + " ");
            writer.Write(String.IsNullOrEmpty(member.MethodType) ? "void" : member.MethodType);
            writer.Write(" ");
            writer.Write(member.Name);
            writer.Write(member.MethodGenerics == null || !member.MethodGenerics.Any() ? "" : "<" + String.Join(", ", member.MethodGenerics.Select(generic => generic.GenericName)) + ">");
            writer.Write("(");
            writer.Write(member.MethodParameters == null || !member.MethodParameters.Any() ? "" : String.Join(", ", member.MethodParameters.Select(parameter => (parameter.ParameterReference == CSharpReference.None ? "" : parameter.ParameterReference.ConvertTo<String>().ToLower() + " ") + parameter.ParameterType + " " + parameter.ParameterName)));
            writer.Write(")");
            writer.Write(member.MethodGenerics == null || !member.MethodGenerics.Any() ? "" : String.Join("", member.MethodGenerics.Select(generic => generic.GenericConstraints == null || !generic.GenericConstraints.Any() ? "" : " where " + generic.GenericName + " : " + String.Join(", ", generic.GenericConstraints))));

            // Generate the code
            if (member.MethodAbstraction == CSharpAbstractions.Abstract || member.MethodModifier == CSharpModifiers.Partial)
            {
                writer.WriteLine(";");
            }
            else
            {
                writer.WriteLine();
                writer.WriteLine("        {");
                member.MethodCode.Execute(code => writer.WriteLine("            " + code));
                writer.WriteLine("        }");
            }
        }

        /// <summary>
        ///     Generates an implementor within the runtime type.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        /// <param name="member">
        ///     The implementor to be generated.
        /// </param>
        protected virtual void GenerateMember(StreamWriter writer, CSharpImplementation member)
        {
            if (member is CSharpImplementationProperty)
                this.GenerateMember(writer, member as CSharpImplementationProperty);
            if (member is CSharpImplementationMethod)
                this.GenerateMember(writer, member as CSharpImplementationMethod);
        }

        /// <summary>
        ///     Generates a property implementor within the runtime type.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        /// <param name="member">
        ///     The property implementor to be generated.
        /// </param>
        protected virtual void GenerateMember(StreamWriter writer, CSharpImplementationProperty member)
        {
            // Generate the documentation
            this.GenerateDocumentation(writer, true, "summary", member.XmlSummary);
            this.GenerateDocumentation(writer, true, "remarks", member.XmlRemarks);

            // Generate the signature
            if (member.Attributes != null && member.Attributes.Length != 0)
                writer.WriteLine("        [" + String.Join(", ", member.Attributes) + "]");
            writer.Write("        ");
            writer.Write(member.PropertyType);
            writer.Write(" ");
            writer.Write(member.PropertyInterface);
            writer.Write(".");
            writer.Write(member.Name);
            writer.WriteLine();

            // Generate the accessors
            writer.WriteLine("        {");
            if (member.PropertyGetter)
                writer.WriteLine("            get { return this." + member.Name + "; }");
            if (member.PropertySetter)
                writer.WriteLine("            set { this." + member.Name + " = (" + member.OriginalType + ")value; }");
            writer.WriteLine("        }");
        }

        /// <summary>
        ///     Generates a method implementor within the runtime type.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        /// <param name="member">
        ///     The method implementor to be generated.
        /// </param>
        protected virtual void GenerateMember(StreamWriter writer, CSharpImplementationMethod member)
        {
            Boolean isHasPermission = member.Name == "HasPermission";

            // Generate the documentation
            this.GenerateDocumentation(writer, true, "summary", member.XmlSummary);
            this.GenerateDocumentation(writer, true, member.MethodGenerics);
            this.GenerateDocumentation(writer, true, member.MethodParameters);
            this.GenerateDocumentation(writer, true, "returns", member.XmlReturns);
            this.GenerateDocumentation(writer, true, "remarks", member.XmlRemarks);


            // Generate the signature
            if (member.Attributes != null && member.Attributes.Length != 0)
                writer.WriteLine("        [" + String.Join(", ", member.Attributes) + "]");
            writer.Write("        ");
            writer.Write(String.IsNullOrEmpty(member.MethodType) ? "void" : member.MethodType);
            writer.Write(" ");
            writer.Write(member.MethodInterface);
            writer.Write(".");
            writer.Write(member.Name);
            writer.Write(member.MethodGenerics == null || !member.MethodGenerics.Any() ? "" : "<" + String.Join(", ", member.MethodGenerics.Select(generic => generic.GenericName)) + ">");
            writer.Write("(");
            writer.Write(member.MethodParameters == null || !member.MethodParameters.Any() ? "" : String.Join(", ", member.MethodParameters.Select(parameter => (parameter.ParameterReference == CSharpReference.None ? "" : parameter.ParameterReference.ConvertTo<String>().ToLower() + " ") + parameter.ParameterType + " " + parameter.ParameterName)));
            writer.Write(")");
            writer.Write(member.MethodGenerics == null || !member.MethodGenerics.Any() ? "" : String.Join("", member.MethodGenerics.Select(generic => generic.GenericConstraints == null || !generic.GenericConstraints.Any() ? "" : " where " + generic.GenericName + " : " + String.Join(", ", generic.GenericConstraints))));

            // Generate the code
            writer.WriteLine();
            writer.WriteLine("        {");
            writer.Write("            ");
            writer.Write(String.IsNullOrEmpty(member.MethodType) || String.Equals(member.MethodType, "void", StringComparison.OrdinalIgnoreCase) ? "" : "return ");
            writer.Write("this." + member.Name);
            writer.Write(member.MethodGenerics == null || !member.MethodGenerics.Any() ? "" : "<" + String.Join(", ", member.MethodGenerics.Select(generic => generic.GenericName)) + ">");
            writer.Write("(");
            writer.Write(member.MethodParameters == null || !member.MethodParameters.Any() ? "" : String.Join(", ", member.MethodParameters.Select(parameter => parameter.ParameterName)));
            writer.WriteLine(");");
            writer.WriteLine("        }");
        }

        /// <summary>
        ///     Generates a property accessor within the runtime type.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        /// <param name="accessor">
        ///     The accessor to be generated.
        /// </param>
        /// <param name="accessorType">
        ///     The type of accessor to be generated.
        /// </param>
        /// <param name="modifier">
        ///     The property modifier.
        /// </param>
        protected virtual void GenerateMember(StreamWriter writer, CSharpAccessor accessor, String accessorType, CSharpModifiers modifier)
        {
            // Validate that the accessor has been defined
            if (accessor == null)
                return;
            
            // Output the accessor modifier and type
            writer.Write("            ");
            writer.Write(accessor.AccessorModifier == modifier ? null : accessor.AccessorModifier.ConvertTo<String>().ToLower().Replace("_", " ") + " ");
            writer.Write(accessorType);

            // Output the accessor code
            if (accessor.AccessorCode == null || accessor.AccessorCode.Length == 0)
                writer.WriteLine(";");
            if (accessor.AccessorCode != null && accessor.AccessorCode.Length == 1)
                writer.WriteLine(" { " + accessor.AccessorCode[0] + " }");
            if (accessor.AccessorCode != null && accessor.AccessorCode.Length >= 2)
            {
                writer.WriteLine();
                writer.WriteLine("            {");
                writer.WriteLine(String.Join(Environment.NewLine, accessor.AccessorCode.Select(code => "                " + code)));
                writer.WriteLine("            }");
            }
        }

        #endregion
    }
}
