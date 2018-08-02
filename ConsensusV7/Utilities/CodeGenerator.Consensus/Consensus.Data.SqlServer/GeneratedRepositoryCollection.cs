using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Data.SqlServer
{
    /// <summary>
    ///     Generates the repository collection abstract class.
    /// </summary>
    public class GeneratedRepositoryCollection : TypeClass
    {
        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Provides the abstraction for all collections of repository instances."; }
        }

        /// <summary>
        ///     Gets the access modifier for the type.
        /// </summary>
        public override CSharpModifier TypeModifier
        {
            get { return CSharpModifier.Public; }
        }

        /// <summary>
        ///     Gets the abstraction of the class.
        /// </summary>
        public override CSharpAbstraction TypeAbstraction
        {
            get { return CSharpAbstraction.Abstract; }
        }

        /// <summary>
        ///     Gets the name of the type.
        /// </summary>
        public override String TypeName
        {
            get { return "SqlServerRepositoryCollection"; }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return "RepositoryCollection"; }
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
                    MemberType = "SqlServerDataProvider",
                    MemberName = "_provider",
                    XmlSummary = "The Microsoft SQL Server data provider which exposes this repository collection."
                };
                yield return new MemberProperty(this)
                {
                    MemberType = "SqlServerDataProvider",
                    MemberName = "Provider",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected, Code = new String[] { "return _provider;" } },
                    SetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Private, Code = new String[] { "_provider = value;" } },
                    XmlSummary = "Gets the Microsoft SQL Server data provider which exposes this repository."
                };
                yield return new MemberConstructor(this)
                {
                    MemberModifier = CSharpModifier.Protected,
                    XmlSummary = "Initialises a new <see cref='SqlServerRepository' /> instance."
                };
                yield return new MemberMethod(this)
                {
                    MemberModifier = CSharpModifier.Internal,
                    MemberAbstraction = CSharpAbstraction.Static,
                    MemberType = "TRepositoryCollection",
                    MemberName = "Create",
                    MemberGenerics = new MemberGeneric[]
                    { 
                        new MemberGeneric() 
                        { 
                            MemberName = "TRepositoryCollection",
                            MemberConstraint = new String[] { "SqlServerRepositoryCollection", "new()" },
                            XmlSummary = "The type of repository collection to be validated and/or instantiated."
                        },
                    },
                    MemberParameters = new MemberParameter[]
                    {
                        new MemberParameter() 
                        {
                            MemberType = "SqlServerDataProvider",
                            MemberName = "provider",
                            XmlSummary = "The data provider which programmatically exposes the repository collection."
                        },
                        new MemberParameter()
                        {
                            MemberKeyword = CSharpKeyword.Ref,
                            MemberType = "TRepositoryCollection",
                            MemberName = "reference",
                            XmlSummary = "The reference to the field which persists the instance of the repository collection within memory."
                        }
                    },
                    XmlSummary = "Creates a new <typeparamref name='TRepositoryCollection' /> instance and stores the instance within the specified <paramref name='reference' />, unless the reference has already been initialised with a <typeparamref name='TRepositoryCollection' /> instance.",
                    XmlReturns = "The new or existing instance of the <typeparamref name='TRepositoryCollection' />.",
                    Code = new String[]
                    {
                        "if (reference == null)",
                        "    reference = new TRepositoryCollection() { Provider = provider };",
                        "",
                        "return reference;"
                    }
                };
            }
        }
    }
}