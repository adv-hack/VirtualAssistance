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
    public class GeneratedFactoryCollectionX : TypeClass
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
        public DataDomain Domain
        {
            get { return base.DataSource as DataDomain; }
        }

        /// <summary>
        ///     Gets the sub-namespace for the type, relative to the project namespace.
        /// </summary>
        public override String TypeNamespace
        {
            get { return this.Domain.Name; }
        }

        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Represents the collection of locally-executed factory instances which provide instantiation of business models pertaining to " + this.Domain.Description + "."; }
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
            get { return "Local" + this.Domain.Name + "FactoryCollection"; }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return this.Domain.Name + "FactoryCollection"; }
        }

        /// <summary>
        ///     Gets the name of the base-type from which, this type is derived.
        /// </summary>
        public override String TypeInheritence
        {
            get { return "LocalFactoryCollection"; }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                foreach (DataEntity entity in this.Domain.Entities)
                {
                    yield return new MemberField(this)
                    {
                        XmlSummary = "The locally-executed factory which instantiates the <see cref='" + entity.CodeName + "Model' /> business model class.",
                        MemberModifier = CSharpModifier.Private,
                        MemberType = "Local" + entity.CodeName + "Factory",
                        MemberName = "_" + Char.ToLower(entity.CodeName[0]) + entity.CodeName.Substring(1),
                    };

                    yield return new MemberProperty(this)
                    {
                        XmlSummary = "Gets the factory which instantiates the <see cref='" + entity.CodeName + "Model' /> business model class.",
                        MemberType = "Local" + entity.CodeName + "Factory",
                        MemberName = entity.CodeName,
                        GetAccessor = new MemberAccessor()
                        {
                            Modifier = CSharpModifier.Public,
                            Code = new String[] { "return LocalFactory.Create(this.Provider, ref _" + Char.ToLower(entity.CodeName[0]) + entity.CodeName.Substring(1) + ");" }
                        }
                    };
                }

                if (this.InterfaceLibrary != null)
                {
                    System.Type interfaceType = this.InterfaceLibrary.FirstOrDefault(type => type.Name == String.Format("{0}FactoryCollection", this.Domain.Name));
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
