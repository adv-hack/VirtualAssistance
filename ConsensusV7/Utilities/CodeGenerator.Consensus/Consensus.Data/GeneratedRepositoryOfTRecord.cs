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
    public class GeneratedRepositoryOfTRecord : TypeInterface
    {
        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Supports the persistence and retrieval operations that relate to a specific data structure."; }
        }

        /// <summary>
        ///     Gets the access modifier for the type.
        /// </summary>
        public override CSharpModifier TypeModifier
        {
            get { return CSharpModifier.Public; }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get { yield return "System.Collections.Generic"; }
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
                    MemberConstraint = new String[] { "Record" },
                    XmlSummary = "The type of data structure which is persisted within the repository."
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
                yield return "Repository";
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
                    XmlSummary = "Retrieves all existing <typeparamref name='TRecord' /> instances from the repository.",
                    XmlReturns = "The enumerable collection of <typeparamref name='TRecord' /> instances that are persisted within the repository.",
                    MemberType = "IEnumerable<TRecord>",
                    MemberName = "SelectAll"
                };

                yield return new MemberMethod(this)
                {
                    XmlSummary = "Creates a new <typeparamref name='TRecord' /> instance within the repository.",
                    MemberType = "void",
                    MemberName = "Create",
                    MemberParameters = new MemberParameter[] { new MemberParameter() { MemberName = "record", MemberType = "TRecord", XmlSummary = "The data structure to be created within the repository." } }
                };

                yield return new MemberMethod(this)
                {
                    XmlSummary = "Modifies an existing <typeparamref name='TRecord' /> instance within the repository.",
                    MemberType = "void",
                    MemberName = "Modify",
                    MemberParameters = new MemberParameter[] { new MemberParameter() { MemberName = "record", MemberType = "TRecord", XmlSummary = "The data structure to be modified within the repository." } }
                };

                yield return new MemberMethod(this)
                {
                    XmlSummary = "Removes an existing <typeparamref name='TRecord' /> instance from the repository.",
                    MemberType = "void",
                    MemberName = "Remove",
                    MemberParameters = new MemberParameter[] { new MemberParameter() { MemberName = "record", MemberType = "TRecord", XmlSummary = "The data structure to be removed from the repository." } }
                };
            }
        }
    }
}
