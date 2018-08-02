using CodeGenerator.CodeModel;
using CodeGenerator.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Type = System.Type;
using CodeType = CodeGenerator.CodeModel.Type;

namespace CodeGenerator.Consensus.Business
{
    public class GeneratedModelX : TypeInterface
    {
        /// <summary>
        ///     Gets the underlying runtime type that is used to generate this interface
        /// </summary>
        public Type Type
        {
            get { return base.DataSource as Type; }
        }

        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get
            {
                XmlNode xmlDocumentation = this.GetDocumentation(this.Type);
                return xmlDocumentation == null || xmlDocumentation.SelectSingleNode("summary") == null ? null : xmlDocumentation.SelectSingleNode("summary").InnerXml.Trim().Trim('\r', '\n');
            }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get
            {
                // Get the namespaces for all values returned by the properties and methods
                List<String> references = new List<String>();
                references.AddRange(this.Type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).Select(prop => prop.PropertyType.Namespace));
                references.AddRange(this.Type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(method => !method.IsSpecialName).Select(method => method.ReturnType.Namespace));
                references.Add("System.ComponentModel");

                // Exclude the system namespace (this is always included) and the current namespace
                return references
                    .Where(reference => reference != this.TypeNamespace)
                    .Where(reference => reference != "System")
                    .OrderBy(reference => reference)
                    .Distinct();
            }
        }

        /// <summary>
        ///     Gets the sub-namespace for the type, relative to the project namespace.
        /// </summary>
        public override String TypeNamespace
        {
            get { return this.Type.Namespace.Substring(this.ParentProject.ProjectNamespace.Length + 1); }
        }

        /// <summary>
        ///     Gets the access modifier for the type.
        /// </summary>
        public override CSharpModifier TypeModifier
        {
            get { return CSharpModifier.Public; }
        }

        /// <summary>
        ///     Gets the name of the type.
        /// </summary>
        public override String TypeName
        {
            get { return this.Type.GetInterfaces().Where(iface => iface.Implements("Model") && iface.GetGenericArguments().Length == 0).Select(iface => iface.Name).FirstOrDefault(); }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get
            {
                Type keyType = this.Type.BaseType.GetGenericArguments()[1];
                yield return "Model<" + keyType.Name + ">";
            }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                // Generate the interface properties
                foreach (PropertyInfo property in this.Type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                {
                    XmlNode xmlDocumentation = this.GetDocumentation(property);
                    yield return new MemberProperty(this)
                    {
                        XmlSummary = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("summary") == null ? null : xmlDocumentation.SelectSingleNode("summary").InnerXml.Trim().Trim('\r', '\n'),
                        MemberType = CodeType.GetTypeName(property.PropertyType),
                        MemberName = property.Name,
                        GetAccessor = property.CanRead ? new MemberAccessor() : null,
                        SetAccessor = property.CanWrite ? new MemberAccessor() : null
                    };
                }

                // Generate the interface methods
                foreach (MethodInfo method in this.Type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(m => !m.IsSpecialName))
                {
                    XmlNode xmlDocumentation = this.GetDocumentation(method);
                    List<MemberParameter> parameterList = new List<MemberParameter>();
                    foreach (ParameterInfo parameterInfo in method.GetParameters())
                    {
                        XmlNode xmlParameter = this.GetDocumentation(parameterInfo);
                        parameterList.Add(new MemberParameter()
                        {
                            MemberName = parameterInfo.Name,
                            MemberType = parameterInfo.ParameterType.Name,
                            MemberKeyword =
                                parameterInfo.GetCustomAttributes<ParamArrayAttribute>().Any() ? CSharpKeyword.Params :
                                parameterInfo.IsOut ? CSharpKeyword.Out :
                                parameterInfo.ParameterType.IsByRef ? CSharpKeyword.Ref :
                                CSharpKeyword.None,
                            XmlSummary = xmlParameter == null ? null : xmlParameter.InnerXml.Trim().Trim('\r', '\n'),
                        });
                    }

                    yield return new MemberMethod(this)
                    {
                        XmlSummary = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("summary") == null ? null : xmlDocumentation.SelectSingleNode("summary").InnerXml.Trim().Trim('\r', '\n'),
                        XmlReturns = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("returns") == null ? null : xmlDocumentation.SelectSingleNode("returns").InnerXml.Trim().Trim('\r', '\n'),
                        MemberParameters = parameterList.ToArray(),
                        MemberName = method.Name,
                        MemberType = CodeType.GetTypeName(method.ReturnType)
                    };
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
            output.AppendLine("    [EditorBrowsable(EditorBrowsableState.Never)]");
            base.GenerateDeclaration(output);
        }
    }
}
