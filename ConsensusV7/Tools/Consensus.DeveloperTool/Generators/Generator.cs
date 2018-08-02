using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class Generator : TaskList
    {
        #region fields

        /// <summary>
        ///     The domain being generated.
        /// </summary>
        private Domain _domain;
        
        /// <summary>
        ///     Gets the temporary directory in which code is generated and compiled.
        /// </summary>
        private String _workingDirectory;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the domain being generated.
        /// </summary>
        public Domain Domain
        {
            get { return _domain; }
        }
        
        /// <summary>
        ///     Gets the name of the task list.
        /// </summary>
        public override String Name
        {
            get { return this.Domain.DomainName; }
        }

        /// <summary>
        ///    Gets or sets the temporary directory in which code
        /// </summary>
        public String WorkingDirectory
        {
            get
            {
                if (_workingDirectory == null)
                    _workingDirectory = Path.Combine(Path.GetTempPath(), "codegen");

                return _workingDirectory;
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Creates a new consensus generator.
        /// </summary>
        public Generator(Domain domain)
        {
            _domain = domain;
        }
        
        #endregion

        #region methods

        protected override IEnumerable<Task> GetSubTasks()
        {
            if (this.Domain.GenerationLayer == DomainGenerationLayers.All || this.Domain.GenerationLayer == DomainGenerationLayers.StoredProcedures)
            {
                yield return new StoredProcProject(this.WorkingDirectory, this.Domain);
            }
            if (this.Domain.GenerationLayer == DomainGenerationLayers.All || this.Domain.GenerationLayer == DomainGenerationLayers.DataAccessLayer)
            {
                yield return new GenericDataProject(this.WorkingDirectory, this.Domain);
                yield return new SqlServerProject(this.WorkingDirectory, this.Domain);
                yield return new TaskIsolator<SqlServerInjector>(this.WorkingDirectory, this.Domain);
            }
            if (this.Domain.GenerationLayer == DomainGenerationLayers.All || this.Domain.GenerationLayer == DomainGenerationLayers.BusinessLogicLayer)
            {
                yield return new GenericBusinessProject(this.WorkingDirectory, this.Domain);
                yield return new LocalBusinessProject(this.WorkingDirectory, this.Domain);
                yield return new TaskIsolator<LocalBusinessInjector>(this.WorkingDirectory, this.Domain);
            }
            if (this.Domain.GenerationLayer == DomainGenerationLayers.All || this.Domain.GenerationLayer == DomainGenerationLayers.ClientConsumerLayer)
            {
                yield return new ClientConsumerProject(this.WorkingDirectory, this.Domain);
                yield return new TaskIsolator<ClientConsumerInjector>(this.WorkingDirectory, this.Domain);
            }
        }

        #endregion
    }
}
