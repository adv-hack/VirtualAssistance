﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class LocalBusinessFactoryDynamic : GeneratedClass
    {
        #region fields

        /// <summary>
        ///     The domain within which the interface is defined.
        /// </summary>
        private Domain _domain;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the domain within which the interface is defined.
        /// </summary>
        public Domain Domain
        {
            get { return _domain; }
        }

        /// <summary>
        ///     Gets the name of the generated file.
        /// </summary>
        public override String FileName
        {
            get { return base.FileName + ".gen"; }
        }

        /// <summary>
        ///     Gets the name of the project item that this item is nested beneath.
        /// </summary>
        public override String FileNesting
        {
            get { return base.FileName + "." + base.FileExtension; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Provides the abstraction for locally-executable business factories which support business model instantiation"; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlRemarks
        {
            get { return "THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.\r\nDO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION."; }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get
            {
                yield return "System.Collections.Generic";
                yield return "System.Linq";
            }
        }

        /// <summary>
        ///     Gets the abstraction of the generated runtime type.
        /// </summary>
        public override CSharpAbstractions TypeAbstraction
        {
            get { return CSharpAbstractions.Abstract; }
        }

        /// <summary>
        ///     Gets whether the generated runtime type is defined over multiple files.
        /// </summary>
        public override Boolean TypeIsPartial
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets the name of the runtime type.
        /// </summary>
        public override String TypeName
        {
            get { return "LocalFactory"; }
        }

        /// <summary>
        ///     Gets the interfaces implemented by the generated type.
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get
            {
                yield return "IFactory";
            }
        }

        /// <summary>
        ///     Gets the members that are defined within the generated type.
        /// </summary>
        public override IEnumerable<CSharpMember> TypeMembers
        {
            get
            {
                yield return new CSharpField(this)
                {
                    XmlSummary = "The <see cref=\"LocalProvider\" /> which exposes thiis factory.",
                    FieldModifier = CSharpModifiers.Private,
                    FieldType = "LocalProvider",
                    Name = "_provider"
                };

                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets <see cref=\"LocalProvider\" /> which exposes thiis factory.",
                    PropertyType = "LocalProvider",
                    Name = "Provider",
                    PropertyGetter = new CSharpAccessor()
                    {
                        AccessorModifier = CSharpModifiers.Protected,
                        AccessorCode = new String[] { "return _provider;" }
                    },
                    PropertySetter = new CSharpAccessor()
                    {
                        AccessorModifier = CSharpModifiers.Private,
                        AccessorCode = new String[] { "_provider = value;" }
                    },
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Creates a new <typeparamref name=\"TFactory\" /> instance and stores the instance within the specified <paramref name=\"reference\" />, unless the reference has already been initialised with a <typeparamref name=\"TFactory\" /> instance.",
                    XmlReturns = "The newly initialised instance, or the pre-existing instance, of the <typeparamref name=\"TFactory\" /> class.",
                    XmlRemarks = "The use of an internal static instantiation method, combined with a protected constructor, allows common initialisation code to be centralised\r\nwithin an abstract class without creating a requirement for constructor implementation within the derived classes.",
                    MethodModifier = CSharpModifiers.Internal,
                    MethodAbstraction = CSharpAbstractions.Static,
                    MethodType = "TFactory",
                    Name = "Create",
                    MethodGenerics = new CSharpGeneric[] 
                    {
                        new CSharpGeneric()
                        {
                            XmlSummary = "The type of factory to be checked and if required, instantiated and initialised.",
                            GenericName = "TFactory",
                            GenericConstraints = new String[] { "LocalFactory", "new()" }
                        }
                    },
                    MethodParameters = new CSharpParameter[]
                    {
                        new CSharpParameter()
                        {
                            XmlSummary = "The business logic provider which programmatically exposes the factory.",
                            ParameterType = "LocalProvider",
                            ParameterName = "provider"
                        },
                        new CSharpParameter()
                        {
                            XmlSummary = "The reference to the field which persists the instance of the factory within memory.",
                            ParameterReference = CSharpReference.Ref,
                            ParameterType = "TFactory",
                            ParameterName = "reference"
                        }
                    },
                    MethodCode = new String[] { 
                        "if (reference == null)", 
                        "    reference = new TFactory() { Provider = provider };",
                        "",
                        "return reference;"
                    }
                };
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="LocalBusinessFactoryCollectionDynamic" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain entity from which the repository is generated.
        /// </param>
        public LocalBusinessFactoryDynamic(GeneratedProject project, Domain domain) : base(project)
        {
            _domain = domain;
        }

        #endregion
    }
}
