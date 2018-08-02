using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class GenericBusinessModelFromEntityDynamic : GeneratedInterface
    {
        #region fields

        /// <summary>
        ///     The domain entity from which the repository is generated.
        /// </summary>
        private DomainEntity _entity;

        /// <summary>
        ///     The domain for which the repository is being generated.
        /// </summary>
        //private Domain _domain;

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
        ///     Gets the domain entity from which the repository is generated.
        /// </summary>
        //public Domain Domain
        //{
        //    get { return _domain; }
        //}

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
            get { return this.Entity.EntityName + ".model.gen"; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return String.IsNullOrEmpty(this.Entity.EntityDescription) ? "Encapsulates the <see cref=\"" + this.Entity.ReferencedTable.ProgrammaticName + "Record\" /> data structure" : "Represents " + this.Entity.EntityDescription.ToLower(); }
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

                String[] containers = this.Entity.EntityAttributes.Where(attr => attr.Exists && attr.Entity == this.Entity && attr.AttributeExposed && attr.Column != this.Entity.ReferencedTable.TableKey && attr.ReferencedEntity != null && attr.ReferencedEntity.Container != this.Entity.Container).Select(attr => attr.ReferencedEntity.Container.ContainerName).Distinct().ToArray();
                foreach (String container in containers)
                    references.Add(this.Project.ProjectNamespace + "." + container);

                DomainEntityExtender extender = this.Entity as DomainEntityExtender;
                if (extender != null && extender.Container != extender.ReferencedEntity.Container && !references.Contains(this.Project.ProjectNamespace + "." + extender.ReferencedEntity.Container.ContainerName))
                    references.Add(this.Project.ProjectNamespace + "." + extender.ReferencedEntity.Container.ContainerName);

                if (!String.Equals(this.Entity.ReferencedTable.TableName, DomainTable.CODE_TABLE, StringComparison.OrdinalIgnoreCase))
                {
                    //DomainEntityAttribute[] referenceAttributes = this.Entity.Container.Domain.Containers
                    //    .SelectMany(container => container.ContainerEntities)
                    //    .Where(entity => entity.Exists)
                    //    .SelectMany(entity => entity.EntityAttributes)
                    //    .Where(attr => attr.Exists && attr.ReferencedEntity == this.Entity)
                    //    .ToArray();
                    //String[] attrContainers = referenceAttributes.Select(attr => attr.Entity.Container.ContainerName).Distinct().ToArray();

                    String[] attrContainers;

                    if (MainForm.Runtime != null && MainForm.Runtime.ContainersMap.ContainsKey(this.Entity.Guid))
                    {
                        attrContainers = MainForm.Runtime.ContainersMap[this.Entity.Guid];
                    }
                    else
                    {
                        DomainEntityAttribute[] referenceAttributes = this.Entity.Container.Domain.Containers
                            .SelectMany(container => container.ContainerEntities)
                            .Where(entity => entity.Exists)
                            .SelectMany(entity => entity.EntityAttributes)
                            .Where(attr => attr.Exists && attr.ReferencedEntity == this.Entity)
                            .ToArray();

                        attrContainers = referenceAttributes.Select(attr => attr.Entity.Container.ContainerName).Distinct().ToArray();

                        if (MainForm.Runtime != null)
                        {
                            MainForm.Runtime.ContainersMap.Add(this.Entity.Guid, attrContainers);
                        }
                    }

                    foreach (String container in attrContainers)
                        if (!String.Equals(container, this.Entity.Container.ContainerName, StringComparison.OrdinalIgnoreCase) && !references.Contains(this.Project.ProjectNamespace + "." + container))
                            references.Add(this.Project.ProjectNamespace + "." + container);
                }

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
            get { return "I" + this.Entity.EntityName + "Model"; }
        }

        /// <summary>
        ///     Gets the interfaces implemented by the generated type.
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get
            {
                if (this.Entity is DomainEntityExtender)
                    yield return "I" + (this.Entity as DomainEntityExtender).ReferencedEntity.EntityName + "Model";
                else
                    yield return "IModel<" + this.Entity.ReferencedTable.TableKey.ProgrammaticType + ">";
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="GenericBusinessModelFromEntityDynamic" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain entity from which the repository is generated.
        /// </param>
        public GenericBusinessModelFromEntityDynamic(GeneratedProject project, DomainEntity entity) : base(project)
        {
            _entity = entity;
            //_domain = domain;
        }

        #endregion
    }
}
