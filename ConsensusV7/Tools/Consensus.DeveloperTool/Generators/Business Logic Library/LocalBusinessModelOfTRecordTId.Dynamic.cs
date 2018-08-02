using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class LocalBusinessModelOfTIdTRecordDynamic : GeneratedClass
    {
        #region properties

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
            get { return "LocalModel"; }
        }

        /// <summary>
        ///     Gets the generic parameters for the type.
        /// </summary>
        public override IEnumerable<CSharpGeneric> TypeGenerics
        {
            get
            {
                yield return new CSharpGeneric()
                {
                    GenericName = "TRecord",
                    XmlSummary = "The data type of the record that is encapsulated by the business model.",
                    GenericConstraints = new String[] { "Record<TId>", "Cloneable<TRecord>", "IEquatable<TRecord>", "new()" }
                };
                yield return new CSharpGeneric()
                {
                    GenericName = "TId",
                    XmlSummary = "The data type of the unique identifier which distinctly identifies an instance of the business model.",
                    GenericConstraints = new String[] { "IComparable<TId>", "IEquatable<TId>" }
                };
            }
        }

        /// <summary>
        ///     Gets the base class of the generated runtime type.
        /// </summary>
        public override String TypeBase
        {
            get { return "LocalModel<TRecord>"; }
        }

        /// <summary>
        ///     Gets the interfaces implemented by the generated type.
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return "IModel<TId>"; }
        }

        /// <summary>
        ///     Gets the members that are defined within the generated type.
        /// </summary>
        public override IEnumerable<CSharpMember> TypeMembers
        {
            get
            {
                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the unique id distinctly identifies the instance of the data structure.",
                    PropertyType = "TId",
                    Name = "Id",
                    PropertyGetter = new CSharpAccessor()
                    {
                        AccessorModifier = CSharpModifiers.Public,
                        AccessorCode = new String[] { "return base.ModifiedData.Id;" }
                    }
                };

                yield return new CSharpConstructor(this)
                {
                    XmlSummary = "Initialises a new <see cref=\"LocalModel{TModel, TId}\" /> instance.",
                    ConstructorModifier = CSharpModifiers.Internal,
                    ConstructorParameters = new CSharpParameter[]
                    {
                        new CSharpParameter() 
                        { 
                            XmlSummary = "The business provider to which the business model is bound.",
                            ParameterType = "LocalProvider", 
                            ParameterName = "provider" 
                        },
                    },
                    ConstructorBase = new String[] 
                    {
                        "provider"
                    }
                };

                yield return new CSharpConstructor(this)
                {
                    XmlSummary = "Initialises a new <see cref=\"LocalModel{TModel, TId}\" /> instance.",
                    ConstructorModifier = CSharpModifiers.Internal,
                    ConstructorParameters = new CSharpParameter[]
                    {
                        new CSharpParameter() 
                        { 
                            XmlSummary = "The business provider to which the business model is bound.",
                            ParameterType = "LocalProvider", 
                            ParameterName = "provider" 
                        },
                        new CSharpParameter() 
                        { 
                            XmlSummary = "The data record which is encapsulated by the business model.",
                            ParameterType = "TRecord", 
                            ParameterName = "record" 
                        }
                    },
                    ConstructorBase = new String[] 
                    {
                        "provider",
                        "record"
                    }
                };
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="LocalBusinessModelDynamic" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain entity from which the repository is generated.
        /// </param>
        public LocalBusinessModelOfTIdTRecordDynamic(GeneratedProject project) : base(project)
        {
        }

        #endregion
    }
}
