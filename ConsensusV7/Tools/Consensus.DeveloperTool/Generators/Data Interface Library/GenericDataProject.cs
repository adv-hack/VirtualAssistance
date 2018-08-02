using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Generates the interface library for the generic data access layer
    /// </summary>
    public class GenericDataProject : GeneratedProject
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
            get { return "Consensus.Data"; }
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
        ///     Initialises a new <see cref="GenericDataProject" /> instance.
        /// </summary>
        /// <param name="domain">
        ///     Sets the business domain from which the project is generated.
        /// </param>
        public GenericDataProject(String workingDirectory, Domain domain) : base(workingDirectory)
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
                    entities = this.Domain.Containers.SelectMany(container => container.ContainerEntities).Where(entity => entity.Exists && entity.GetType() == typeof(DomainEntity)).ToArray();
                    break;
            }

            // Generate the base classes and interfaces
            if (this.Domain.GenerationMode == DomainGenerationModes.Complete)
            {
                yield return new GenericDataRecordUser(this);
                yield return new GenericDataRecordDynamic(this);
                yield return new GenericDataRecordOfTIdUser(this);
                yield return new GenericDataRecordOfTIdDynamic(this);
                yield return new GenericDataRepositoryDynamic(this);
                yield return new GenericDataRepositoryOfTRecordDynamic(this);
                yield return new GenericDataRepositoryOfTRecordTIdDynamic(this);
                yield return new GenericDataRepositoryCollectionDynamic(this);
            }

            // Generate the domain-driven classes and interfaces
            yield return new GenericDataProviderDynamic(this, containers);
            foreach (DomainEntity entity in entities)
                yield return new GenericDataRecordFromEntityDynamic(this, entity); 
            foreach (DomainEntity entity in entities)
                yield return new GenericDataRepositoryFromEntityDynamic(this, entity);
            foreach (DomainContainer container in containers)
                yield return new GenericDataRepositoryCollectionFromContainerDynamic(this, container);
        }

        #endregion
    }
}
