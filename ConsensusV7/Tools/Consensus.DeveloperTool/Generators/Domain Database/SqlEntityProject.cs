using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator.Generators.Domain_Database
{
    public class SqlEntityProject : GeneratedProject
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
        protected Domain Domain
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
            get { return "Consensus.Entity"; }
        }

        /// <summary>
        ///     Gets the extension of the generated file
        /// </summary>
        public override String FileExtension
        {
            get { return "sqlproj"; }
        }

        /// <summary>
        ///     Gets the root namespace for the project
        /// </summary>
        public override String ProjectNamespace
        {
            get { return ""; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="SqlEntityProject" /> instance.
        /// </summary>
        /// <param name="domain">
        ///     Sets the business domain from which the project is generated.
        /// </param>
        public SqlEntityProject(Domain domain)
        {
            _domain = domain;
        }

        #endregion

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

            // Generate the "FetchById" procedures
            foreach (DomainEntity entity in entities)
                yield return new SqlEntityFetchById(this, entity);

            // Generate the "FetchAll" procedures

            // Generate the "FetchAllByAttribute" procedures

        }

    }
}
