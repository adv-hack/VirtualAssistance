using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class LocalBusinessFactoryCollectionFromContainerDynamic : GeneratedClass
    {
        #region fields

        /// <summary>
        ///     The domain container from which the repository collection is generated.
        /// </summary>
        private DomainContainer _container;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the domain container from which the repository collection is generated.
        /// </summary>
        public DomainContainer Container
        {
            get { return _container; }
        }

        /// <summary>
        ///     Gets whether the file should be overwritten, if the file already exists.
        /// </summary>
        public override Boolean FileIsEditable
        {
            get { return true; }
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
            get { return "Represents a collection of factory instances which are responsible for the instantiation of the business models " + (String.IsNullOrEmpty(this.Container.ContainerDescription) ? "in the " + this.Container.ContainerName + " namespace" : "pertaining to " + this.Container.ContainerDescription.ToLower()); }
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
        ///     Gets the scoping namespace of the runtime type.
        /// </summary>
        public override String TypeNamespace
        {
            get { return this.Container.ContainerName; }
        }

        /// <summary>
        ///     Gets the name of the runtime type.
        /// </summary>
        public override String TypeName
        {
            get { return "Local" + this.Container.ContainerName + "FactoryCollection"; }
        }

        /// <summary>
        ///     Gets the base class of the generated runtime type.
        /// </summary>
        public override String TypeBase
        {
            get
            {
                return "LocalFactoryCollection";
            }
        }

        /// <summary>
        ///     Gets whether the generated runtime type is defined over multiple files.
        /// </summary>
        public override Boolean TypeIsPartial
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets the interfaces implemented by the generated type.
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get
            {
                yield return "I" + this.Container.ContainerName + "FactoryCollection";
            }
        }

        /// <summary>
        ///     Gets the members that are defined within the generated type.
        /// </summary>
        public override IEnumerable<CSharpMember> TypeMembers
        {
            get
            {
                DomainEntity[] entities = this.Container.ContainerEntities.Where(entity => entity.Exists).ToArray();
                foreach (DomainEntity entity in entities)
                {
                    yield return new CSharpField(this)
                    {
                        XmlSummary = "The locally executable factory which is responsible for instantiating <see cref=\"" + entity.EntityName + "Model\" /> objects.",
                        FieldModifier = CSharpModifiers.Private,
                        FieldType = "Local" + entity.EntityName + "Factory",
                        Name = "_" + entity.EntityName.Substring(0, 1).ToLower() + entity.EntityName.Substring(1)
                    };
                    yield return new CSharpProperty(this)
                    {
                        XmlSummary = "Gets the locally executable factory which is responsible for instantiating <see cref=\"" + entity.EntityName + "Model\" /> objects.",
                        PropertyType = "Local" + entity.EntityName + "Factory",
                        Name = entity.EntityName,
                        PropertyGetter = new CSharpAccessor() { AccessorCode = new String[] { "return LocalFactory.Create(this.Provider, ref _" + entity.EntityName.Substring(0, 1).ToLower() + entity.EntityName.Substring(1) + ");", } }
                    };
                }
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="LocalBusinessFactoryCollectionFromContainerDynamic" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="container">
        ///     Sets the domain container from which the factory collection is generated.
        /// </param>
        public LocalBusinessFactoryCollectionFromContainerDynamic(GeneratedProject project, DomainContainer container) : base(project)
        {
            _container = container;
        }

        #endregion
    }
}
