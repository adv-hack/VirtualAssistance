using CodeGenerator.CodeModel;
using CodeGenerator.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Business.Logic
{
    /// <summary>
    ///     Generates the dependency-injectable data provider.
    /// </summary>
    public class GeneratedBusinessProvider : TypeClass
    {
        /// <summary>
        ///     The collection of types which are compiled from the interfacing library
        /// </summary>
        public System.Type[] InterfaceLibrary
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the underlying data source for this class
        /// </summary>
        public DataDomain[] Domains
        {
            get { return base.DataSource as DataDomain[]; }
        }

        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Supports the programmatic access of the repositories within the Microsoft SQL Server."; }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get
            {
                List<String> references = new List<String>();
                references.Add("System.Collections.Generic");

                foreach (DataDomain domain in this.Domains)
                    references.Add(this.ParentProject.ProjectNamespace + "." + domain.Name);

                return references;
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
            get { return "LocalBusinessProvider"; }
        }

        /// <summary>
        ///     Gets the name of the base-type from which, this type is derived.
        /// </summary>
        public override String TypeInheritence
        {
            get { return "ConsensusProvider"; }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return "BusinessProvider"; }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                yield return new MemberField(this)
                {
                    MemberModifier = CSharpModifier.Private,
                    MemberType = "DataProvider",
                    MemberName = "_dataProvider",
                    XmlSummary = "The data provider which exposes programmatic access to the repositories within the persistence mechanism."
                };
                foreach (DataDomain domain in this.DataSource as DataDomain[])
                {
                    yield return new MemberField(this)
                    {
                        MemberModifier = CSharpModifier.Private,
                        MemberType = "Local" + domain.Name + "FactoryCollection",
                        MemberName = "_" + domain.Name.Substring(0, 1).ToLower() + domain.Name.Substring(1),
                        XmlSummary = "The collection of locally-executed factory instances which instantiate business models pertaining to " + domain.Description + "."
                    };
                }
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets the data provider which exposes programmatic access to the repositories within the persistence mechanism.",
                    MemberType = "DataProvider",
                    MemberName = "DataProvider",
                    GetAccessor = new MemberAccessor()
                    {
                        Modifier = CSharpModifier.Internal,
                        Code = new String[] { 
                            "if (_dataProvider == null)",
                            "    _dataProvider = this.Site.GetService<DataProvider>();",
                            "",
                            "return _dataProvider;"
                        }
                    }
                };
                foreach (DataDomain domain in this.DataSource as DataDomain[])
                {
                    yield return new MemberProperty(this)
                    {
                        XmlSummary = "Gets the collection of locally-executed factory instances which instantiate business models pertaining to " + domain.Description + ".",
                        MemberType = "Local" + domain.Name + "FactoryCollection",
                        MemberName = domain.Name,
                        GetAccessor = new MemberAccessor() { Code = new String[] { "return LocalFactoryCollection.Create(this, ref _" + domain.Name.Substring(0, 1).ToLower() + domain.Name.Substring(1) + ");" } }
                    };
                }

                if (this.InterfaceLibrary != null)
                {
                    System.Type interfaceType = this.InterfaceLibrary.FirstOrDefault(type => type.Name == "BusinessProvider");
                    if (interfaceType != null)
                    {
                        foreach (PropertyInfo property in interfaceType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
                            yield return new MemberImplementor(this, property, this.GetDocumentation(property));
                        foreach (MethodInfo method in interfaceType.GetMethods(BindingFlags.Public | BindingFlags.Instance))
                            if (!method.IsSpecialName)
                                yield return new MemberImplementor(this, method, this.GetDocumentation(method));
                    }
                }
            }
        }
    }
}
