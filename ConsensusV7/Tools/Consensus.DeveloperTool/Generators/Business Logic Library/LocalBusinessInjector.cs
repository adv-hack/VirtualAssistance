using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class LocalBusinessInjector : GeneratedInjectorTaskList<GenericBusinessProject, LocalBusinessProject>
    {
        #region constructors

        /// <summary>
        ///     Creates the injectors for the data access library
        /// </summary>
        public LocalBusinessInjector(String workingDirectory, Domain domain) : base(workingDirectory, domain)
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
                    entities = this.Domain.Containers.SelectMany(container => container.ContainerEntities).Where(entity => entity.Exists).ToArray();
                    break;
            }

            // Inject the base classes and interfaces
            if (this.Domain.GenerationMode == DomainGenerationModes.Complete)
            {
                yield return new GeneratedInjector<GenericBusinessFactoryDynamic, LocalBusinessFactoryDynamic>(this, this.Domain);
                yield return new GeneratedInjector<GenericBusinessModelDynamic, LocalBusinessModelDynamic>(this, this.Domain);
            }
            
            // Generate the domain-driven classes and interfaces
            yield return new GeneratedInjector<GenericBusinessProviderDynamic, LocalBusinessProviderDynamic>(this, containers);
            foreach (DomainContainer container in containers)
                yield return new GeneratedInjector<GenericBusinessFactoryCollectionFromContainerDynamic, LocalBusinessFactoryCollectionFromContainerDynamic>(this, container);
            foreach (DomainEntity entity in entities)
                yield return new GeneratedInjector<GenericBusinessFactoryFromEntityDynamic, LocalBusinessFactoryFromEntityDynamic>(this, entity);
            foreach (DomainEntity entity in entities)
                yield return new GeneratedInjector<GenericBusinessModelFromEntityDynamic, LocalBusinessModelFromEntityDynamic>(this, entity);
        }

        #endregion
    }
}
