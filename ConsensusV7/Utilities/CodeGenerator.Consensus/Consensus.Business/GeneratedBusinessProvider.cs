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
    /// <summary>
    ///     Generates the dependency-injectable data provider.
    /// </summary>
    public class GeneratedBusinessProvider : TypeInterface
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
            get { return "Supports programmatic access to the factories which handle the business model instantiation."; }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get 
            {
                return this.Type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(prop => prop.PropertyType.Implements("FactoryCollection")).Select(prop => prop.PropertyType.Namespace);
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
            get { return "BusinessProvider"; }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                foreach (PropertyInfo property in this.Type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(prop => prop.PropertyType.Implements("FactoryCollection")))
                {
                    XmlNode xmlDocumentation = this.GetDocumentation(property);
                    yield return new MemberProperty(this)
                    {
                        XmlSummary = xmlDocumentation == null && xmlDocumentation.SelectSingleNode("summary") != null ? null : xmlDocumentation.SelectSingleNode("summary").InnerXml.Trim().Trim('\r', '\n'),
                        MemberType = property.PropertyType.GetInterfaces().Where(iface => iface.Implements("FactoryCollection")).Select(iface => iface.Name).FirstOrDefault(),
                        MemberName = property.Name,
                        GetAccessor = new MemberAccessor()
                    };
                }
            }
        }
    }
}
