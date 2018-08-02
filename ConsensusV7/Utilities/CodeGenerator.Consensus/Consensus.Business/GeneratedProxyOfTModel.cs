using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Business
{
    /// <summary>
    ///     Generates the generically-typed base proxy class.
    /// </summary>
    public class GeneratedProxyOfTModel : TypeClass
    {
        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Provides the abstraction for consumable client classes which provide composition of the business model and business factory instances."; }
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
            get { return "Proxy"; }
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
                    XmlSummary = "The type of business model which is encapsulated by this consumable client class.",
                    MemberName = "TModel",
                    MemberConstraint = new String[] { "Model" }
                };
            }
        }

        /// <summary>
        ///     Gets the name of the base-type from which, this type is derived.
        /// </summary>
        public override String TypeInheritence
        {
            get { return "Proxy"; }
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
                    XmlSummary = "The business model which is encapsulated by this consumable client class.",
                    MemberModifier = CSharpModifier.Private,
                    MemberType = "TModel",
                    MemberName = "_model"
                };
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets the underlying business model which is encapsulated by this consumable client class.",
                    MemberType = "TModel",
                    MemberName = "Model",
                    GetAccessor = new MemberAccessor()
                    {
                        Modifier = CSharpModifier.Protected,
                        Code = new String[] { "return _model;" }
                    }
                };
                yield return new MemberConstructor(this)
                {
                    XmlSummary = "Initialises a new instance of the client-consumable class.",
                    MemberModifier = CSharpModifier.Protected,
                    MemberParameters = new MemberParameter[] 
                    { 
                        new MemberParameter() 
                        { 
                            XmlSummary = "Sets underlying business model which is encapsulated by this consumable client class.",
                            MemberType = "TModel",
                            MemberName = "model",
                        }
                    },
                    Code = new String[] { "_model = model;" }
                };
            }
        }
    }
}
