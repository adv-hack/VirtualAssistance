using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class SqlServerInjector : GeneratedInjectorTaskList<GenericDataProject, SqlServerProject>
    {
        #region constructors

        /// <summary>
        ///     Creates the injectors for the data access library
        /// </summary>
        public SqlServerInjector(String workingDirectory, Domain domain) : base(workingDirectory, domain)
        {
        }

        #endregion

        #region methods

        protected override IEnumerable<GeneratedInjector> GetInjectors()
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

            // Inject the base classes and interfaces
            if (this.Domain.GenerationMode == DomainGenerationModes.Complete)
            {
                yield return new GeneratedInjector<GenericDataRepositoryDynamic, SqlServerRepositoryDynamic>(this);
                yield return new GeneratedInjector<GenericDataRepositoryOfTRecordDynamic, SqlServerRepositoryOfTRecordDynamic>(this);
                yield return new GeneratedInjector<GenericDataRepositoryOfTRecordTIdDynamic, SqlServerRepositoryOfTRecordTIdDynamic>(this);
                yield return new GeneratedInjector<GenericDataRepositoryCollectionDynamic, SqlServerRepositoryCollectionDynamic>(this);
            }
            
            // Generate the domain-driven classes and interfaces
            yield return new GeneratedInjector<GenericDataProviderDynamic, SqlServerProviderDynamic>(this, containers);
            foreach (DomainEntity entity in entities)
                yield return new GeneratedInjector<GenericDataRepositoryFromEntityDynamic, SqlServerRepositoryFromEntityDynamic>(this, entity);
            foreach (DomainContainer container in containers)
                yield return new GeneratedInjector<GenericDataRepositoryCollectionFromContainerDynamic, SqlServerRepositoryCollectionFromContainerDynamic>(this, container);
        }

        #endregion
    }
}
