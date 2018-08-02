using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Business.Logic
{
    /// <summary>
    ///     Generates the base class for model implementations
    /// </summary>
    public class GeneratedModel : TypeClass
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
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return "Model"; }
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
                    XmlSummary = "The locally-executable business logic provider.",
                    MemberModifier = CSharpModifier.Private,
                    MemberType = "LocalBusinessProvider",
                    MemberName = "_provider",
                };
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets the locally-executable business logic provider.",
                    MemberType = "LocalBusinessProvider",
                    MemberName = "Provider",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected, Code = new String[] { "return _provider;" } },
                    SetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected, Code = new String[] { "_provider = value;" } }
                };
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets whether the underlying data has been persisted within the the persistence mechanism.",
                    MemberAbstraction = CSharpAbstraction.Abstract,
                    MemberType = "Boolean",
                    MemberName = "IsPersisted",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected }
                };
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets whether the underlying data has been modified since instantiation.",
                    MemberAbstraction = CSharpAbstraction.Abstract,
                    MemberType = "Boolean",
                    MemberName = "IsModified",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected }
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Saves the business model.",
                    MemberAbstraction = CSharpAbstraction.Abstract,
                    MemberModifier = CSharpModifier.Public,
                    MemberName = "Save",
                    MemberType = "void"
                };
            }
        }
    }
}
