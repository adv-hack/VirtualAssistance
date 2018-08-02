using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class ClientConsumerProxyFromEntityDynamic : GeneratedClass, IHaveEntity
    {
        #region fields

        /// <summary>
        ///     The domain entity from which the repository is generated.
        /// </summary>
        private DomainEntity _entity;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the domain entity from which the repository is generated.
        /// </summary>
        public DomainEntity Entity
        {
            get { return _entity; }
        }

        /// <summary>
        ///     Gets the name of the generated file.
        /// </summary>
        public override String FileName
        {
            get { return this.Entity.EntityName + ".gen"; }
        }

        /// <summary>
        ///     Gets whether the file should be overwritten, if the file already exists.
        /// </summary>
        public override Boolean FileIsEditable
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return (String.IsNullOrEmpty(this.Entity.EntityDescription) ? "" : "Represents " + this.Entity.EntityDescription); }
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
                List<String> references = new List<String>();
                references.Add("System.Collections.Generic");
                references.Add("System.Linq");
                references.AddRange(ClientConsumerProxyFromEntityDynamic.GetReferences(this.Entity).Select(reference => this.Project.ProjectNamespace + "." + reference).Distinct());
                return references;
            }
        }

        /// <summary>
        ///     Gets the scoping namespace of the runtime type.
        /// </summary>
        public override String TypeNamespace
        {
            get { return this.Entity.Container.ContainerName; }
        }

        /// <summary>
        ///     Gets the name of the runtime type.
        /// </summary>
        public override String TypeName
        {
            get { return this.Entity.EntityName; }
        }

        /// <summary>
        ///     Gets the base class of the generated runtime type.
        /// </summary>
        public override String TypeBase
        {
            get
            {
                return "Proxy<I" + this.Entity.EntityName + "Model, " + this.Entity.ReferencedTable.TableKey.ProgrammaticType + ">";
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
        ///     Gets the members that are defined within the generated type.
        /// </summary>
        public override IEnumerable<CSharpMember> TypeMembers
        {
            get
            {
                yield return new CSharpConstructor(this)
                {
                    XmlSummary = "Initialises a new instance of the client-consumable class.",
                    ConstructorModifier = CSharpModifiers.Internal,
                    ConstructorParameters = new CSharpParameter[] 
                    {
                        new CSharpParameter() 
                        {
                            ParameterName = "model",
                            ParameterType = "I" + this.Entity.EntityName + "Model"
                        }
                    },
                    ConstructorBase = new String[] { "model" }
                };
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="SqlServerRepositoryFromEntityUser" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain entity from which the repository is generated.
        /// </param>
        public ClientConsumerProxyFromEntityDynamic(GeneratedProject project, DomainEntity entity) : base(project)
        {
            _entity = entity;
        }

        #endregion

        #region methods

        private static IEnumerable<String> GetReferences(DomainEntity entity)
        {
            List<String> namespaces = new List<String>();

            // If an attribute is exposed and references an entity that is defined within another namespace, the namespace will need to be referenced.
            namespaces.AddRange(entity.EntityAttributes.Where(attr =>
                attr.Exists &&
                attr.Entity == entity &&
                attr.AttributeExposed &&
                attr.ReferencedEntity != null &&
                attr.ReferencedEntity.Container != entity.Container).Select(attr => attr.ReferencedEntity.Container.ContainerName));

            // If an attribute is exposed within another entity that is defined within another namespace, the attribute references this entity, the namespace will need to be referenced.
            namespaces.AddRange(entity.Container.Domain.Containers
                .Where(cont => cont.Exists)
                .SelectMany(cont => cont.ContainerEntities)
                .Where(ent => ent.Exists)
                .SelectMany(ent => ent.EntityAttributes)
                .Where(attr => attr.Exists && attr.ReferencedEntity == entity && attr.Entity.Container != entity.Container)
                .Select(attr => attr.Entity.Container.ContainerName));

            // If this entity extends another, and the base entity is in another namespace, the namespace will need to be referenced.
            DomainEntityExtender extender = entity as DomainEntityExtender;
            if (extender != null && extender.Container != extender.ReferencedEntity.Container)
                namespaces.Add(extender.ReferencedEntity.Container.ContainerName);

            // If this entity extends another, the namespaces required for that entity will also need to be references
            if (extender != null)
                namespaces.AddRange(ClientConsumerProxyFromEntityDynamic.GetReferences(extender.ReferencedEntity));

            return namespaces;
        }

        #endregion
    }
}
