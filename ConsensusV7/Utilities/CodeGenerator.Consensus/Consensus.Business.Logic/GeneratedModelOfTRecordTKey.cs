using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Business.Logic
{
    /// <summary>
    ///     Generates the generically-typed base class for model implementations
    /// </summary>
    public class GeneratedModelOfTRecordTKey : TypeClass
    {
        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Provides the abstraction for locally-executable business model instance which implements the standardised rules for the Consensus solution."; }
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
            get { return "LocalModel"; }
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
                    XmlSummary = "The type of the data record which is encapsulated by this business model.",
                    MemberName = "TRecord",
                    MemberConstraint = new String[] { "Record<TKey>", "Cloneable<TRecord>", "IEquatable<TRecord>", "new()" }
                };
                yield return new MemberGeneric()
                {
                    XmlSummary = "The data type of the unique id distinctly identifies the instance of the data structure.",
                    MemberName = "TKey"
                };
            }
        }

        /// <summary>
        ///     Gets the name of the base-type from which, this type is derived.
        /// </summary>
        public override String TypeInheritence
        {
            get { return "LocalModel<TRecord>"; }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return "Model<TKey>"; }
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
                    XmlSummary = "Gets the unique id distinctly identifies the instance of the data structure.",
                    MemberType = "TKey",
                    MemberName = "Id",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Public, Code = new String[] { "return base.ModifiedData.Id;" } }
                };
            }
        }
    }
}
