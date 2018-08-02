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

namespace CodeGenerator.Consensus.Business
{
    public class GeneratedFactoryCollectionX : TypeInterface
    {

        /// <summary>
        ///     Gets the underlying runtime type that is used to generate this interface
        /// </summary>
        public Type Type
        {
            get { return base.DataSource as Type; }
        }

        /// <summary>
        ///     Gets the sub-namespace for the type, relative to the project namespace.
        /// </summary>
        public override String TypeNamespace
        {
            get { return this.Type.Namespace.Substring(this.ParentProject.ProjectNamespace.Length + 1); }
        }

        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get
            {
                XmlNode xmlDocumentation = this.GetDocumentation(this.Type);
                return xmlDocumentation == null && xmlDocumentation.SelectSingleNode("summary") != null ? null : xmlDocumentation.SelectSingleNode("summary").InnerXml.Trim().Trim('\r', '\n');
            }
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
            get { return this.Type.GetInterfaces().Where(iface => iface.Implements("FactoryCollection")).Select(iface => iface.Name).FirstOrDefault(); }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return "FactoryCollection"; }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                foreach (PropertyInfo property in this.Type.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(prop => prop.PropertyType.Implements("Factory")))
                {
                    XmlNode xmlDocumentation = this.GetDocumentation(property);
                    yield return new MemberProperty(this)
                    {
                        XmlSummary = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("summary") == null ? null : xmlDocumentation.SelectSingleNode("summary").InnerXml.Trim().Trim('\r', '\n'),
                        MemberType = property.PropertyType.GetInterfaces().Where(iface => iface.Implements("Factory")).Select(iface => iface.Name).FirstOrDefault(),
                        MemberName = property.Name,
                        GetAccessor = new MemberAccessor()
                    };
                }
            }
        }
    }
}
