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

namespace CodeGenerator.Consensus.Data
{
    public class GeneratedRepositoryX : TypeInterface
    {
        /// <summary>
        ///     Gets the entity/type tuple
        /// </summary>
        public Tuple<DataEntity, Type> Tuple
        {
            get { return this.DataSource as Tuple<DataEntity, Type>; }
        }

        /// <summary>
        ///     Gets the sub-namespace for the type, relative to the project namespace.
        /// </summary>
        public override String TypeNamespace
        {
            get { return this.Tuple.Item1.CodeDomain.Name; }
        }

        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Supports the persistence and retrieval operations that relate to the <see cref='" + this.Tuple.Item1.CodeName + "Record' /> data structure."; }
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
            get { return this.Tuple.Item1.CodeName + "Repository"; }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return "Repository<" + this.Tuple.Item1.CodeName + "Record, " + this.Tuple.Item1.KeyField.CodeTypeName + ">"; }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                PropertyInfo[] properties = this.Tuple.Item2.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo property in properties)
                {
                    XmlNode xmlDocumentation = this.GetDocumentation(property);
                    yield return new MemberProperty(this)
                    {
                        XmlSummary = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("summary") == null ? null : xmlDocumentation.SelectSingleNode("summary").InnerXml.Trim().Trim('\r', '\n'),
                        MemberType = property.PropertyType.ToString(),
                        MemberName = property.Name,
                        GetAccessor = property.CanRead ? new MemberAccessor() : null,
                        SetAccessor = property.CanWrite ? new MemberAccessor() : null
                    };
                }

                MethodInfo[] methods = this.Tuple.Item2.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (MethodInfo method in methods.Where(m => !m.IsSpecialName))
                {
                    // Get the xml node for the method
                    XmlNode xmlDocumentation = this.GetDocumentation(method);

                    // Get the parameters for the method
                    List<MemberParameter> parameters = new List<MemberParameter>();
                    foreach (ParameterInfo parameter in method.GetParameters())
                    {
                        MemberParameter memberParameter = new MemberParameter();
                        if (Attribute.IsDefined(parameter, typeof(ParamArrayAttribute)))
                            memberParameter.MemberKeyword = CSharpKeyword.Params;
                        else if (parameter.ParameterType.IsByRef && parameter.IsOut)
                            memberParameter.MemberKeyword = CSharpKeyword.Out;
                        else if (parameter.ParameterType.IsByRef)
                            memberParameter.MemberKeyword = CSharpKeyword.Ref;
                        memberParameter.MemberType = parameter.ParameterType.Name;
                        memberParameter.MemberName = parameter.Name;
                        memberParameter.XmlSummary = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("param[@name='" + parameter.Name + "']") == null ? null : xmlDocumentation.SelectSingleNode("param[@name='" + parameter.Name + "']").InnerXml.Trim().Trim('\r', '\n');
                        parameters.Add(memberParameter);
                    }

                    // Return the method information
                    yield return new MemberMethod(this)
                    {
                        XmlSummary = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("summary") == null ? null : xmlDocumentation.SelectSingleNode("summary").InnerXml.Trim().Trim('\r', '\n'),
                        XmlReturns = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("returns") == null ? null : xmlDocumentation.SelectSingleNode("returns").InnerXml.Trim().Trim('\r', '\n'),
                        MemberType = method.ReturnType == typeof(void) ? "void" : method.ReturnType.Name,
                        MemberName = method.Name,
                        MemberParameters = parameters.ToArray()
                    };
                }
            }
        }
    }
}
