using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class ClientConsumerInjector : GeneratedEncapsulatorTaskList<LocalBusinessProject, ClientConsumerProject>
    {
        #region constructors

        /// <summary>
        ///     Creates the injectors for the client consumers
        /// </summary>
        public ClientConsumerInjector(String workingDirectory, Domain domain) : base(workingDirectory, domain)
        {
        }

        #endregion

        #region methods

        protected override IEnumerable<GeneratedEncapsulator> GetInjectors()
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
            }
            
            // Generate the domain-driven classes and interfaces
            foreach (DomainEntity entity in entities)
                yield return new GeneratedEncapsulator<LocalBusinessModelFromEntityDynamic, LocalBusinessFactoryFromEntityDynamic, ClientConsumerProxyFromEntityDynamic>(this, entity);
        }

        #endregion
    }
}
