using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class LocalBusinessProject : GeneratedProject
    {
        #region fields

        /// <summary>
        ///     The business domain from which the project is generated.
        /// </summary>
        private Domain _domain;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the business domain from which the project is generated.
        /// </summary>
        public override Domain Domain
        {
            get { return _domain; }
        }

        /// <summary>
        ///     Gets the name of the generation project.
        /// </summary>
        public override String Name
        {
            get { return "Generating: " + this.FileName; }
        }

        /// <summary>
        ///     Gets the name of the generated project file.
        /// </summary>
        public override String FileName
        {
            get { return "Consensus.Business.Logic"; }
        }

        /// <summary>
        ///     Gets the extension of the generated file
        /// </summary>
        public override String FileExtension
        {
            get { return "csproj"; }
        }

        /// <summary>
        ///     Gets the root namespace for the project
        /// </summary>
        public override String ProjectNamespace
        {
            get { return "Consensus"; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="GenericBusinessProject" /> instance.
        /// </summary>
        /// <param name="domain">
        ///     Sets the business domain from which the project is generated.
        /// </param>
        public LocalBusinessProject(String workingDirectory, Domain domain) : base(workingDirectory)
        {
            _domain = domain;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Gets the collection of tasks within the project.
        /// </summary>
        protected override IEnumerable<Task> GetSubTasks()
        {
            // Identify the objects requiring generation.
            DomainContainer[] containers;
            DomainEntity[] entities;
            switch (this.Domain.GenerationMode)
            {
                default:
                    containers = this.Domain.Containers.Where(container => container.Exists).ToArray();
                    entities = this.Domain.Containers.SelectMany(container => container.ContainerEntities).Where(entity => entity.Exists).ToArray();
                    break;
            }

            // Generate the base classes and interfaces
            if (this.Domain.GenerationMode == DomainGenerationModes.Complete)
            {
                yield return new LocalBusinessModelDynamic(this, this.Domain);
                yield return new LocalBusinessModelUser(this);
                yield return new LocalBusinessModelOfTRecordDynamic(this);
                yield return new LocalBusinessModelOfTRecordUser(this);
                yield return new LocalBusinessModelOfTIdTRecordDynamic(this);
                yield return new LocalBusinessModelOfTIdTRecordUser(this);
                yield return new LocalBusinessFactoryUser(this);
                yield return new LocalBusinessFactoryDynamic(this, this.Domain);
                yield return new LocalBusinessFactoryOfTModelUser(this);
                yield return new LocalBusinessFactoryOfTModelDynamic(this);
                yield return new LocalBusinessFactoryOfTModelTRecordUser(this);
                yield return new LocalBusinessFactoryOfTModelTRecordDynamic(this);
                yield return new LocalBusinessFactoryOfTModelTRecordTIdUser(this);
                yield return new LocalBusinessFactoryOfTModelTRecordTIdDynamic(this);
                yield return new LocalBusinessFactoryCollectionUser(this);
                yield return new LocalBusinessFactoryCollectionDynamic(this);
            }

            // Generate the domain-driven classes and interfaces
            yield return new LocalBusinessProviderUser(this);
            yield return new LocalBusinessProviderDynamic(this, containers);

            foreach (DomainContainer container in containers)
                yield return new LocalBusinessFactoryCollectionFromContainerUser(this, container);
            foreach (DomainContainer container in containers)
                yield return new LocalBusinessFactoryCollectionFromContainerDynamic(this, container);
            foreach (DomainEntity entity in entities)
                yield return new LocalBusinessFactoryFromEntityUser(this, entity); 
            foreach (DomainEntity entity in entities)
                yield return new LocalBusinessFactoryFromEntityDynamic(this, entity);
            foreach (DomainEntity entity in entities)
                yield return new LocalBusinessModelFromEntityUser(this, entity);
            foreach (DomainEntity entity in entities)
                yield return new LocalBusinessModelFromEntityDynamic(this, entity);
        }

        #endregion
    }
}
