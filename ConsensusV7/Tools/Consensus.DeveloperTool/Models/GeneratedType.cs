using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Represents a generated type.
    /// </summary>
    public abstract class GeneratedType : GeneratedProjectItem
    {
        #region properties

        /// <summary>
        ///     Gets the extension of the generated file
        /// </summary>
        public override String FileExtension
        {
            get { return "cs"; }
        }

        /// <summary>
        ///     Gets the name of the generated file
        /// </summary>
        public override String FileName
        {
            get { return this.TypeName; }
        }

        /// <summary>
        ///     Gets the folder in which the file is generated.
        /// </summary>
        public override String FileFolder
        {
            get 
            {
                List<String> folders = new List<String>();
                folders.Add(base.FileFolder);
                if (!String.IsNullOrEmpty(this.TypeNamespace))
                    folders.AddRange(this.TypeNamespace.Split('.'));

                return Path.Combine(folders.ToArray()); 
            }
        }

        /// <summary>
        ///     Gets the declaration type of the generated runtime type.
        /// </summary>
        public abstract CSharpTypes DeclarationType
        {
            get;
        }

        /// <summary>
        ///     Gets the declaration name of the generated runtime type.
        /// </summary>
        public virtual String DeclarationName
        {
            get { return this.TypeName; }
        }

        /// <summary>
        ///     Gets the access modifier for the runtime type.
        /// </summary>
        public virtual CSharpModifiers TypeModifier
        {
            get { return CSharpModifiers.Public; }
        }

        /// <summary>
        ///     Gets the name of the runtime type.
        /// </summary>
        public abstract String TypeName
        {
            get;
        }

        /// <summary>
        ///     Gets the scoping namespace of the runtime type.
        /// </summary>
        public virtual String TypeNamespace
        {
            get { return String.Empty; }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public virtual IEnumerable<String> TypeReferences
        {
            get { return null; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public abstract String XmlSummary
        {
            get;
        }

        /// <summary>
        ///     Gets the xml documentation remarks for the type.
        /// </summary>
        public virtual String XmlRemarks
        {
            get { return null; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="GeneratedType" /> instance.
        /// </summary>
        /// <param name="taskList">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        public GeneratedType(GeneratedProject project) : base(project)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Generates the content for the file.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        protected override void GenerateContent(StreamWriter writer)
        {
            // Identify the references required
            List<String> references = new List<String>();
            references.Add("System");
            IEnumerable<string> typeReferences = this.TypeReferences;
            if (typeReferences != null)
                references.AddRange(typeReferences);

            // Output the using statements
            references.OrderBy(reference => reference.StartsWith(this.Project.ProjectNamespace + ".") ? 1 : 0).ThenBy(reference => reference).Execute(reference => writer.WriteLine("using " + reference + ";"));
            writer.WriteLine();

            // Output the namespace
            writer.Write("namespace ");
            writer.Write(this.Project.ProjectNamespace);
            writer.Write(String.IsNullOrEmpty(this.TypeNamespace) ? "" : ".");
            writer.WriteLine(this.TypeNamespace);
            writer.WriteLine("{");

            // Output the type declaration
            this.GenerateDocumentation(writer);
            this.GenerateDeclaration(writer);
            writer.WriteLine();
            writer.WriteLine("    {");

            // Output the type content
            this.GenerateMembers(writer);

            // Output the type footer
            writer.WriteLine("    }");
            writer.WriteLine("}");
        }

        /// <summary>
        ///     Generates the type declaration signature.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        protected virtual void GenerateDeclaration(StreamWriter writer)
        {
            writer.Write("    ");
            writer.Write(this.TypeModifier.ToString().ToLower().Replace("_", " ") + " ");
            writer.Write(this.DeclarationType.ToString().ToLower() + " ");
            writer.Write(this.DeclarationName);
        }

        /// <summary>
        ///     Generates the members within the runtime type.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        protected abstract void GenerateMembers(StreamWriter writer);

        /// <summary>
        ///     Generates the xml documentation for the runtime type.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        protected virtual void GenerateDocumentation(StreamWriter writer)
        {
            this.GenerateDocumentation(writer, false, "summary", this.XmlSummary);
            this.GenerateDocumentation(writer, false, "remarks", this.XmlRemarks);
        }

        /// <summary>
        ///     Generates the xml documentation for the collection of generic parameters.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        /// <param name="indent">
        ///     Specifies whether additional identation is required for member documentation.
        /// </param>
        /// <param name="generics">
        ///     The collection of generic parameters.
        /// </param>
        protected void GenerateDocumentation(StreamWriter writer, Boolean indent, IEnumerable<CSharpGeneric> generics)
        {
            if (generics != null)
                foreach (CSharpGeneric generic in generics)
                    this.GenerateDocumentation(writer, indent, "typeparam", generic.XmlSummary, "name", generic.GenericName);
        }

        /// <summary>
        ///     Generates the xml documentation for the collection of parameters.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        /// <param name="indent">
        ///     Specifies whether additional identation is required for member documentation.
        /// </param>
        /// <param name="generics">
        ///     The collection of parameters.
        /// </param>
        protected void GenerateDocumentation(StreamWriter writer, Boolean indent, IEnumerable<CSharpParameter> parameters)
        {
            if (parameters != null)
                foreach (CSharpParameter parameter in parameters)
                    this.GenerateDocumentation(writer, indent, "param", parameter.XmlSummary, "name", parameter.ParameterName);
        }

        /// <summary>
        ///     Generates the xml documentation for a type of member.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        /// <param name="indent">
        ///     Specifies whether additional identation is required for member documentation.
        /// </param>
        /// <param name="nodeName">
        ///     The name of the xml documentation node.
        /// </param>
        /// <param name="nodeValue">
        ///     The value of the xml documentation node.
        /// </param>
        protected void GenerateDocumentation(StreamWriter writer, Boolean indent, String nodeName, String nodeValue)
        {
            this.GenerateDocumentation(writer, indent, nodeName, nodeValue, null, null);
        }

        /// <summary>
        ///     Generates the xml documentation for a type of member.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        /// <param name="indent">
        ///     Specifies whether additional identation is required for member documentation.
        /// </param>
        /// <param name="nodeName">
        ///     The name of the xml documentation node.
        /// </param>
        /// <param name="nodeValue">
        ///     The value of the xml documentation node.
        /// </param>
        /// <param name="parameterName">
        ///     The name of the xml documentation parameter.
        /// </param>
        /// <param name="parameterValue">
        ///     The value of the xml documentation parameter.
        /// </param>
        protected void GenerateDocumentation(StreamWriter writer, Boolean indent, String nodeName, String nodeValue, String parameterName, String parameterValue)
        {
            if (!String.IsNullOrEmpty(nodeValue))
            {
                String indentation = String.Join("", Enumerable.Range(0, indent ? 2 : 1).Select(i => "    "));
                String nodeAttribute = String.IsNullOrEmpty(parameterName) ? "" : " " + parameterName + "=\"" + parameterValue + "\"";
                String nodeInnerText = String.Join(Environment.NewLine + indentation + "///     ", nodeValue.Split(new String[] { Environment.NewLine }, StringSplitOptions.None));
                writer.WriteLine(indentation + "/// <" + nodeName + nodeAttribute + ">");
                writer.WriteLine(indentation + "///     " + nodeInnerText + (nodeInnerText.EndsWith(".") ? "" : "."));
                writer.WriteLine(indentation + "/// </" + nodeName + ">");
            }
        }

        /// <summary>
        ///     Get the documentation for a member from a compiled assembly document.
        /// </summary>
        /// <param name="document">
        ///     The compiled assembly document from which the documentation is obtained.
        /// </param>
        /// <param name="signature">
        ///     The member signature used to find the member within the documentation.
        /// </param>
        /// <param name="name">
        ///     The name of the xml documentation line that should be returned for the identified member.
        /// </param>
        /// <returns>
        ///     The xml documentation for the specified member.
        /// </returns>
        private String GenerateDocumentation(XmlDocument document, String signature, String name)
        {
            XmlNode node = document.SelectSingleNode("doc/members/member[@name='" + signature + "']/" + name);
            String result = node == null ? String.Empty : node.InnerXml.Trim().Trim('\r', '\n');
            return result;
        }

        /// <summary>
        ///     Get the documentation for a member from a compiled assembly document.
        /// </summary>
        /// <param name="document">
        ///     The member signature used to find the member within the documentation.
        /// </param>
        /// <param name="field">
        ///     The member whose documentation will be returned.
        /// </param>
        /// <param name="name">
        ///     The name of the xml documentation line that should be returned for the identified member.
        /// </param>
        /// <returns>
        ///     The xml documentation for the specified member.
        /// </returns>
        protected String GenerateDocumentation(XmlDocument document, FieldInfo field, String name)
        {
            return this.GenerateDocumentation(document, "F:" + field.DeclaringType.FullName + "." + field.Name, name);
        }

        /// <summary>
        ///     Get the documentation for a member from a compiled assembly document.
        /// </summary>
        /// <param name="document">
        ///     The member signature used to find the member within the documentation.
        /// </param>
        /// <param name="field">
        ///     The member whose documentation will be returned.
        /// </param>
        /// <param name="name">
        ///     The name of the xml documentation line that should be returned for the identified member.
        /// </param>
        /// <returns>
        ///     The xml documentation for the specified member.
        /// </returns>
        protected String GenerateDocumentation(XmlDocument document, PropertyInfo property, String name)
        {
            return this.GenerateDocumentation(document, "P:" + property.DeclaringType.FullName + "." + property.Name, name);
        }

        /// <summary>
        ///     Get the documentation for a member from a compiled assembly document.
        /// </summary>
        /// <param name="document">
        ///     The member signature used to find the member within the documentation.
        /// </param>
        /// <param name="field">
        ///     The member whose documentation will be returned.
        /// </param>
        /// <param name="name">
        ///     The name of the xml documentation line that should be returned for the identified member.
        /// </param>
        /// <returns>
        ///     The xml documentation for the specified member.
        /// </returns>
        protected String GenerateDocumentation(XmlDocument document, MethodInfo method, String name)
        {
            ParameterInfo[] parameters = method.GetParameters();
            String memberName = "M:" + method.DeclaringType.FullName + "." + method.Name + (parameters.Length == 0 ? String.Empty : "(" + String.Join(",", parameters.Select(param => param.ParameterType.IsGenericParameter ? "`" + method.DeclaringType.GetGenericArguments().IndexOf(param.ParameterType).ToString() : param.ParameterType.FullName)) + ")");
            return this.GenerateDocumentation(document, memberName, name);
        }

        /// <summary>
        ///     Get the documentation for a member from a compiled assembly document.
        /// </summary>
        /// <param name="document">
        ///     The member signature used to find the member within the documentation.
        /// </param>
        /// <param name="field">
        ///     The member whose documentation will be returned.
        /// </param>
        /// <param name="name">
        ///     The name of the xml documentation line that should be returned for the identified member.
        /// </param>
        /// <returns>
        ///     The xml documentation for the specified member.
        /// </returns>
        protected String GenerateDocumentation(XmlDocument document, ParameterInfo parameter, String name)
        {
            MethodInfo method = parameter.Member as MethodInfo;
            ParameterInfo[] parameters = method.GetParameters();
            String memberName = "M:" + method.DeclaringType.FullName + "." + method.Name + (parameters.Length == 0 ? String.Empty : "(" + String.Join(",", parameters.Select(param => param.ParameterType.IsGenericParameter ? "`" + method.DeclaringType.GetGenericArguments().IndexOf(param.ParameterType).ToString() : param.ParameterType.FullName)) + ")");
            return this.GenerateDocumentation(document, memberName, "param[@name='" + parameter.Name + "']");
        }

        /// <summary>
        ///     Get the documentation for a member from a compiled assembly document.
        /// </summary>
        /// <param name="document">
        ///     The member signature used to find the member within the documentation.
        /// </param>
        /// <param name="type">
        ///     The member whose documentation will be returned.
        /// </param>
        /// <param name="name">
        ///     The name of the xml documentation line that should be returned for the identified member.
        /// </param>
        /// <returns>
        ///     The xml documentation for the specified member.
        /// </returns>
        protected String GenerateDocumentation(XmlDocument document, Type genericType, String name)
        {
            MethodInfo method = genericType.DeclaringMethod as MethodInfo;
            ParameterInfo[] parameters = method.GetParameters();
            String memberName = "M:" + method.DeclaringType.FullName + "." + method.Name + (parameters.Length == 0 ? String.Empty : "(" + String.Join(",", parameters.Select(param => param.ParameterType.FullName)) + ")");
            return this.GenerateDocumentation(document, memberName, "typeparamref[@name='" + genericType.Name + "']");
        }

        #endregion
    }
}
