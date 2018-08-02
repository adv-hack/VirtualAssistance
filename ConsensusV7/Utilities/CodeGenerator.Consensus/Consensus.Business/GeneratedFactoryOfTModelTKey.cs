using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Business
{
    /// <summary>
    ///     Generates the generically-typed base factory interface.
    /// </summary>
    public class GeneratedFactoryOfTModelTKey : TypeInterface
    {
        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Supports the instantiation of the <typeparamref name='TModel' /> business model, that is distinctly identifiable by a unique key."; }
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
            get { return "Factory"; }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return "Factory<TModel>"; }
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
                    XmlSummary = "The type of business model which is instantiated by the factory.",
                    MemberName = "TModel",
                    MemberConstraint = new String[] { "Model<TKey>" }
                };
                yield return new MemberGeneric()
                {
                    XmlSummary = "The data type of the unique identifier which distinctly identifies an instance of the business model.",
                    MemberName = "TKey"
                };
            }
        }
    }
}
