using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Represents a runtime type 
    /// </summary>
    public abstract class Type : ProjectItem
    {
        #region properties

        /// <summary>
        ///     Gets the build action for the type.
        /// </summary>
        public override ProjectBuildAction BuildAction
        {
            get { return ProjectBuildAction.Compile; }
        }

        /// <summary>
        ///     Gets the name of the file that this file is nested under.
        /// </summary>
        public override String FileNesting
        {
            get { return null; }
        }
        
        /// <summary>
        ///     Gets the name of the file.
        /// </summary>
        public override String FileName
        {
            get { return this.TypeName + ".cs"; }
        }

        /// <summary>
        ///     Gets the type of code object being declared (class, struct, interface, etc).
        /// </summary>
        public abstract String DeclarationType
        {
            get;
        }

        /// <summary>
        ///     Gets the declared name of the type.
        /// </summary>
        public abstract String DeclarationName { get; }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public virtual IEnumerable<String> TypeReferences
        {
            get { return null; }
        }

        /// <summary>
        ///     Gets the sub-namespace for the type, relative to the project namespace.
        /// </summary>
        public virtual String TypeNamespace
        {
            get { return ""; }
        }

        /// <summary>
        ///     Gets the access modifier for the type.
        /// </summary>
        public abstract CSharpModifier TypeModifier { get; }

        /// <summary>
        ///     Gets the name of the type.
        /// </summary>
        public abstract String TypeName { get; }

        /// <summary>
        ///     Gets the folder in which the type is stored.
        /// </summary>
        public override String FileFolder
        {
            get { return TypeNamespace.Replace('.', '\\'); }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public virtual IEnumerable<Member> Members
        {
            get { return null; }
        }

        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public abstract String XmlSummary { get; }

        /// <summary>
        ///     Gets the remarks section of the xml documentation.
        /// </summary>
        public virtual String XmlRemarks
        {
            get { return null; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Generates the code for the runtime type and saves the code to the code file.
        /// </summary>
        public void Generate()
        {
            // Ensure the type folder exists
            if (!Directory.Exists(Path.Combine(this.ParentProject.ProjectFolder, this.FileFolder)))
                Directory.CreateDirectory(Path.Combine(this.ParentProject.ProjectFolder, this.FileFolder));

            // Generate the code for the file
            if (this.TypeGeneration == ProjectGeneration.Always || !File.Exists(this.FilePath))
            {
                StringBuilder codeContent = new StringBuilder();
                this.Generate(codeContent);
                File.WriteAllText(this.FilePath, codeContent.ToString());
            }
        }

        /// <summary>
        ///     Generates the code for the runtime type and appends the code to the specified string builder
        /// </summary>
        /// <param name="output">
        ///     The string builder instance to which all generated code is appended.
        /// </param>
        protected override void Generate(StringBuilder output)
        {
            // Generate the using statements
            output.AppendLine("using System;");
            if (this.TypeReferences != null && this.TypeReferences.Any())
                foreach (String reference in this.TypeReferences)
                    output.AppendLine("using " + reference + ";");

            // Generate the type namespace
            output.AppendLine();
            output.AppendLine("namespace " + this.ParentProject.ProjectNamespace + (String.IsNullOrEmpty(this.TypeNamespace) ? "" : "." + this.TypeNamespace));
            output.AppendLine("{");

            // Append the comments
            output.AppendLine("    /// <summary>");
            output.AppendLine("    ///     " + this.XmlSummary);
            output.AppendLine("    /// </summary>");
            this.GenerateHeader(output);
            if (!String.IsNullOrEmpty(this.XmlRemarks))
            {
                output.AppendLine("    /// <remarks>");
                output.AppendLine("    ///     " + this.XmlRemarks);
                output.AppendLine("    /// </remarks>");
            }

            // Append the type declaration and content
            this.GenerateDeclaration(output);
            output.AppendLine("    {");
            this.GenerateContent(output);

            // Complete with the type footer
            output.AppendLine("    }");
            output.AppendLine("}");
        }

        /// <summary>
        ///     Generates additional xml comments for the runtime type
        /// </summary>
        /// <param name="output">
        ///     The string builder instance to which all generated code is appended.
        /// </param>
        protected virtual void GenerateHeader(StringBuilder output)
        {
        }

        /// <summary>
        ///     Generates the runtime type declaration
        /// </summary>
        /// <param name="output">
        ///     The string builder instance to which all generated code is appended.
        /// </param>
        protected virtual void GenerateDeclaration(StringBuilder output)
        {
            output.Append("    ");
            output.Append(this.TypeModifier.ToString().ToLower() + " ");
            output.Append(this.DeclarationType.ToLower() + " ");
            output.Append(this.DeclarationName);
            output.AppendLine();
        }

        /// <summary>
        ///     Generates the body of the runtime type
        /// </summary>
        /// <param name="output">
        ///     The string builder instance to which all generated code is appended.
        /// </param>
        protected abstract void GenerateContent(StringBuilder output);

        /// <summary>
        ///     Gets the public name for the specified type
        /// </summary>
        public static String GetTypeName(System.Type type)
        {
            if (type.IsClass)
                type = type.GetInterfaces().FirstOrDefault(iface =>
                    iface.GetGenericArguments().Length == 0 &&
                    iface.Namespace == type.Namespace && 
                    type.Assembly.GetName().Name.StartsWith(iface.Assembly.GetName().Name) &&
                    type.Assembly.GetName().Name != iface.Assembly.GetName().Name) ?? type;

            if (type == typeof(void))
                return "void";
            else if (Nullable.GetUnderlyingType(type) == null)
                return type.Name;
            else
                return Nullable.GetUnderlyingType(type).Name + "?";
        }

        /// <summary>
        ///     Loads the xml documentation for the specified assembly
        /// </summary>
        private XmlDocument GetDocumentation(Assembly assembly)
        {
            // Identify the documentation that corresponds to the types assembly
            String filePath = Path.Combine(Path.GetDirectoryName(this.ParentProject.FilePath), "..", "..", "Documentation", assembly.GetName().Name + ".xml");
            
            // Load the documentation
            XmlDocument document = new XmlDocument();
            document.Load(filePath);
            return document;
        }

        /// <summary>
        ///     Gets the xml documentation for the specified type
        /// </summary>
        public XmlNode GetDocumentation(System.Type type)
        {
            return this.GetDocumentation(type.Assembly).SelectSingleNode("doc/members/member[@name='T:" + type.FullName + "']");
        }

        /// <summary>
        ///     Gets the xml documentation for the specified property
        /// </summary>
        public XmlNode GetDocumentation(PropertyInfo property)
        {
            return this.GetDocumentation(property.DeclaringType.Assembly).SelectSingleNode("doc/members/member[@name='P:" + property.DeclaringType.FullName + "." + property.Name + "']");
        }

        /// <summary>
        ///     Gets the xml documentation for the specified method
        /// </summary>
        public XmlNode GetDocumentation(MethodInfo method)
        {
            String xmlParameters = String.Join(",", method.GetParameters().Select(param => param.ParameterType.FullName));
            xmlParameters = xmlParameters.Length != 0 ? "(" + xmlParameters + ")" : xmlParameters;
            return this.GetDocumentation(method.DeclaringType.Assembly).SelectSingleNode("doc/members/member[@name='M:" + method.DeclaringType.FullName + "." + method.Name + xmlParameters + "']");
        }

        /// <summary>
        ///     Gets the xml documentation for the specified parameter
        /// </summary>
        public XmlNode GetDocumentation(ParameterInfo parameter)
        {
            MethodInfo method = parameter.Member as MethodInfo;

            String xmlParameters = String.Join(",", method.GetParameters().Select(param => param.ParameterType.FullName));
            xmlParameters = xmlParameters.Length != 0 ? "(" + xmlParameters + ")" : xmlParameters;
            return this.GetDocumentation(method.DeclaringType.Assembly).SelectSingleNode("doc/members/member[@name='M:" + method.DeclaringType.FullName + "." + method.Name + xmlParameters + "']/param[@name='" + parameter.Name + "']");
        }


        #endregion
    }
}
