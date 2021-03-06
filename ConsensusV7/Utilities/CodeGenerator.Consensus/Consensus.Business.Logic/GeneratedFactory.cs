﻿using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Business.Logic
{
    public class GeneratedFactory : TypeClass
    {
        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Provides the abstraction for locally-executable business factories which handle model instantiation within the Consensus solution."; }
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
            get { return "LocalFactory"; }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return "Factory"; }
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
                    SetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Private, Code = new String[] { "_provider = value;" } }
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Creates a new <typeparamref name='TFactory' /> instance and stores the instance within the specified <paramref name='reference' />, unless the reference has already been initialised with a <typeparamref name='TFactory' /> instance.",
                    XmlReturns = "The new or existing instance of the <typeparamref name='TFactory' />.",
                    MemberModifier = CSharpModifier.Internal,
                    MemberAbstraction = CSharpAbstraction.Static,
                    MemberType = "TFactory",
                    MemberName = "Create",
                    MemberGenerics = new MemberGeneric[]
                    { 
                        new MemberGeneric() 
                        { 
                            MemberName = "TFactory",
                            MemberConstraint = new String[] { "LocalFactory", "new()" },
                            XmlSummary = "The type of factory to be validated and/or instantiated."
                        },
                    },
                    MemberParameters = new MemberParameter[]
                    {
                        new MemberParameter() 
                        {
                            MemberType = "LocalBusinessProvider",
                            MemberName = "provider",
                            XmlSummary = "The business logic provider which programmatically exposes this factory."
                        },
                        new MemberParameter()
                        {
                            MemberKeyword = CSharpKeyword.Ref,
                            MemberType = "TFactory",
                            MemberName = "reference",
                            XmlSummary = "The reference to the field which persists the instance of the factory within memory."
                        }
                    },
                    Code = new String[]
                    {
                        "if (reference == null)",
                        "    reference = new TFactory() { Provider = provider };",
                        "",
                        "return reference;"
                    }
                };
            }
        }
    }
}
