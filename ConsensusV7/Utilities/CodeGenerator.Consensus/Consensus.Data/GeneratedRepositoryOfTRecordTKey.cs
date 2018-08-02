using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Data
{
    /// <summary>
    ///     Generates the generically-typed base repository interface.
    /// </summary>
    public class GeneratedRepositoryOfTRecordTKey : TypeInterface
    {
        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Supports the persistence and retrieval operations that relate to a specific data structure, that is distinctly identifiable by a unique key."; }
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
            get { return "Repository"; }
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
                    MemberName = "TRecord",
                    MemberConstraint = new String[] { "Record<TKey>" },
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
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get
            {
                yield return "Repository<TRecord>";
            }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Retrieves a single <typeparamref name='TRecord' /> instance from the repository.",
                    XmlReturns = "The <typeparamref name='TRecord' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.",
                    MemberType = "TRecord",
                    MemberName = "SelectById",
                    MemberParameters = new MemberParameter[] { new MemberParameter() { MemberName = "id", MemberType = "TKey", XmlSummary = "The unique key which distinctly identifies the <typeparamref name='TRecord' /> instance to be returned." } }
                };
            }
        }
    }
}
