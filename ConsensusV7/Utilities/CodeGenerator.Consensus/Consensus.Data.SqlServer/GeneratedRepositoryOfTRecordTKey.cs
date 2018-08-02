using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Data.SqlServer
{
    /// <summary>
    ///     Generates a generically-types repository abstract.
    /// </summary>
    public class GeneratedRepositoryOfTRecordTKey : TypeClass
    {
        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get
            {
                yield return "System.Collections.Generic";
                yield return "System.Data";
                yield return "System.Data.Common";
                yield return "System.Linq";
            }
        }

        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Provides the abstraction for repositories, which handle the persistence and retrieval operations for Microsoft SQL Server and relate to the <typeparamref name='TRecord' /> data structure that is distinctly identifiable by a unique key."; }
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
            get { return "SqlServerRepository"; }
        }

        /// <summary>
        ///     Gets the generic parameters for the type.
        /// </summary>
        public override IEnumerable<MemberGeneric> TypeGenerics
        {
            get
            {
                yield return new MemberGeneric()
                {
                    MemberConstraint = new String[] { "Record<TKey>", "new()" },
                    MemberName = "TRecord",
                    XmlSummary = "The type of data structure which is persisted within the repository."
                };
                yield return new MemberGeneric()
                {
                    MemberName = "TKey",
                    XmlSummary = "The data type of the unique key which distinctly identifies an instance of the data structure."
                };
            }
        }

        /// <summary>
        ///     Gets the name of the base-type from which, this type is derived.
        /// </summary>
        public override String TypeInheritence
        {
            get { return "SqlServerRepository<TRecord>"; }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return "Repository<TRecord, TKey>"; }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets the name of the parameter which is used to specify the unique key.",
                    MemberAbstraction = CSharpAbstraction.Abstract,
                    MemberType = "String",
                    MemberName = "KeyParameter",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected }
                };

                yield return new MemberMethod(this)
                {
                    XmlSummary = "Retrieves a single <typeparamref name='TRecord' /> instance from the data store.",
                    XmlReturns = "The <typeparamref name='TRecord' /> instance that matches the specified <paramref name='key' />; or null, if no matching instance can be found.",
                    MemberModifier = CSharpModifier.Public,
                    MemberType = "TRecord",
                    MemberName = "SelectById",
                    MemberParameters = new MemberParameter[]
                    {
                        new MemberParameter()
                        {
                            MemberType = "TKey",
                            MemberName = "key",
                            XmlSummary = "The unique key which distinctly identifies the <typeparamref name='TRecord' /> instance to be returned."
                        }
                    },
                    Code = new String[] 
                    { 
                        "DbCommand command = this.GetStoredProcedure(DataOperation.Select, \"Id\");",
                        "this.MapParameter(command, this.KeyParameter, key);",
                        "return this.Execute(command).FirstOrDefault();"
                    }
                };
            }
        }
    }
}
