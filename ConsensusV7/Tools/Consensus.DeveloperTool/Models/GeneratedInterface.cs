using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public abstract class GeneratedInterface : GeneratedType
    {
        #region properties

        /// <summary>
        ///     Gets the name of the generated file
        /// </summary>
        public override String FileName
        {
            get
            {
                String fileName = base.FileName;
                if (this.TypeGenerics != null && this.TypeGenerics.Any())
                    fileName += "Of" + String.Join(String.Empty, this.TypeGenerics.Select(gen => gen.GenericName));

                return fileName;
            }
        }

        /// <summary>
        ///     Gets the declaration type of the generated runtime type.
        /// </summary>
        public override CSharpTypes DeclarationType
        {
            get { return CSharpTypes.Interface; }
        }

        /// <summary>
        ///     Gets the declaration name of the generated runtime type.
        /// </summary>
        public override String DeclarationName
        {
            get
            {
                String declarationName = this.TypeName;
                if (this.TypeGenerics != null && this.TypeGenerics.Any())
                    declarationName += "<" + String.Join(", ", this.TypeGenerics.Select(gen => gen.GenericName)) + ">";

                return declarationName;
            }
        }

        /// <summary>
        ///     Gets whether the generated runtime type is defined over multiple files.
        /// </summary>
        public virtual Boolean TypeIsPartial
        {
            get { return false; }
        }

        /// <summary>
        ///     Gets the generic parameters for the type.
        /// </summary>
        public virtual IEnumerable<CSharpGeneric> TypeGenerics
        {
            get { return null; }
        }

        /// <summary>
        ///     Gets the interfaces implemented by the generated type.
        /// </summary>
        public virtual IEnumerable<String> TypeInterfaces
        {
            get { return null; }
        }

        /// <summary>
        ///     Gets the members that are defined within the generated type.
        /// </summary>
        public virtual IEnumerable<CSharpMember> TypeMembers
        {
            get { return new CSharpMember[] { }; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="GeneratedInterface" /> instance.
        /// </summary>
        /// <param name="taskList">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        public GeneratedInterface(GeneratedProject project) : base(project)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Generates the xml documentation for the runtime type.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        protected override void GenerateDocumentation(StreamWriter writer)
        {
            this.GenerateDocumentation(writer, false, "summary", this.XmlSummary);
            this.GenerateDocumentation(writer, false, this.TypeGenerics);
            this.GenerateDocumentation(writer, false, "remarks", this.XmlRemarks);
        }

        /// <summary>
        ///     Generates the type declaration signature.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        protected override void GenerateDeclaration(StreamWriter writer)
        {
            writer.Write("    ");
            writer.Write(this.TypeModifier.ToString().ToLower().Replace("_", " ") + " ");
            writer.Write(this.TypeIsPartial ? "partial " : "");
            writer.Write(this.DeclarationType.ToString().ToLower() + " ");
            writer.Write(this.DeclarationName);
            writer.Write(this.TypeInterfaces != null && this.TypeInterfaces.Any() ? " : " + String.Join(", ", this.TypeInterfaces) : "");
            writer.Write(this.TypeGenerics == null || !this.TypeGenerics.Any() ? "" : String.Join("", this.TypeGenerics.Select(generic => generic.GenericConstraints == null || !generic.GenericConstraints.Any() ? "" : " where " + generic.GenericName + " : " + String.Join(", ", generic.GenericConstraints))));
        }

        /// <summary>
        ///     Generates the members within the runtime type.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        protected override void GenerateMembers(StreamWriter writer)
        {
            using (MemoryStream regionStream = new MemoryStream())
            using (StreamWriter regionWriter = new StreamWriter(regionStream))
            using (MemoryStream resultStream = new MemoryStream())
            using (StreamReader resultReader = new StreamReader(resultStream))
            {
                regionWriter.AutoFlush = true;
                this.GenerateRegions(regionWriter);
                regionStream.Position = 0;
                regionStream.CopyTo(resultStream);
                resultStream.Position = 0;
                writer.Write(resultReader.ReadToEnd());
            }
            //this.GenerateRegions(writer);
        }

        /// <summary>
        ///     Generates the members within the runtime type, using region directives.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        protected virtual void GenerateRegions(StreamWriter writer)
        {
            CSharpMember[] members = this.TypeMembers.ToArray();
            this.GenerateRegion<CSharpProperty>(writer, members, "properties", this.GenerateMember);
            this.GenerateRegion<CSharpMethod>(writer, members, "methods", this.GenerateMember);
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
        protected virtual void GenerateMember(StreamWriter writer, CSharpProperty member)
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
            writer.Write(member.Name);
            writer.WriteLine();

            // Generate the accessors
            writer.WriteLine("        {");
            if (member.PropertyGetter != null)
                writer.WriteLine("            get;");
            if (member.PropertySetter != null)
                writer.WriteLine("            set;");
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
        protected virtual void GenerateMember(StreamWriter writer, CSharpMethod member)
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
            writer.Write(String.IsNullOrEmpty(member.MethodType) ? "void" : member.MethodType);
            writer.Write(" ");
            writer.Write(member.Name);
            writer.Write(member.MethodGenerics == null || !member.MethodGenerics.Any() ? "" : "<" + String.Join(", ", member.MethodGenerics.Select(generic => generic.GenericName)) + ">");
            writer.Write("(");
            writer.Write(member.MethodParameters == null || !member.MethodParameters.Any() ? "" : String.Join(", ", member.MethodParameters.Select(parameter => (parameter.ParameterReference == CSharpReference.None ? "" : parameter.ParameterReference.ConvertTo<String>().ToLower() + " ") + parameter.ParameterType + " " + parameter.ParameterName)));
            writer.Write(")");
            writer.Write(member.MethodGenerics == null || !member.MethodGenerics.Any() ? "" : String.Join("", member.MethodGenerics.Select(generic => generic.GenericConstraints == null || !generic.GenericConstraints.Any() ? "" : " where " + generic.GenericName + " : " + String.Join(", ", generic.GenericConstraints))));
            writer.Write(";");
            writer.WriteLine();
        }

        /// <summary>
        ///     Generates members of a specific type, within a region directive (if neccesary).
        /// </summary>
        /// <typeparam name="MemberType">
        ///     The type of members to be generated.
        /// </typeparam>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        /// <param name="region">
        ///     The name of the region
        /// </param>
        /// <param name="generator">
        ///     The delegated method which handles the generation of the specified type.
        /// </param>
        protected void GenerateRegion<MemberType>(StreamWriter writer, CSharpMember[] members, String region, Action<StreamWriter, MemberType> generator)
        {
            // Determine whether region directives are required.
            MemberType[] regionMembers = members.OfType<MemberType>().ToArray();
            CSharpMember[] otherMembers = members.Where(member => !(member is MemberType)).ToArray();

            // Output the region header.
            if (regionMembers.Length != 0 && otherMembers.Length != 0)
            {
                writer.Write(writer.BaseStream.Length == 0 ? String.Empty : Environment.NewLine);
                writer.WriteLine("        #region " + region);
                writer.WriteLine();
            }

            // Output the members
            for (Int32 index = 0; index < regionMembers.Length; index++)
            {
                generator.Invoke(writer, regionMembers[index]);
                writer.Write(index == regionMembers.Length - 1 ? "" : Environment.NewLine);
            }

            // Output the region footer.
            if (regionMembers.Length != 0 && otherMembers.Length != 0)
            {
                writer.WriteLine();
                writer.WriteLine("        #endregion");
            }
        }
        
        #endregion
    }
}
