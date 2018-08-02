using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public abstract class GeneratedEncapsulatorTaskList : TaskList
    {
        #region fields

        /// <summary>
        ///     The business domain from which the injectors are generated.
        /// </summary>
        private Domain _domain;

        /// <summary>
        ///     The generated project containing the model.
        /// </summary>
        private GeneratedProject _modelLibrary;

        /// <summary>
        ///     The generated project containing the proxy.
        /// </summary>
        private GeneratedProject _proxyLibrary;

        /// <summary>
        ///     The task which performs the compilation of the model library.
        /// </summary>
        private GeneratedBuildTask _modelBuilder;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the business domain from which the injectors are generated.
        /// </summary>
        public Domain Domain
        {
            get { return _domain; }
        }

        /// <summary>
        ///     Gets the generated project containing the model.
        /// </summary>
        public GeneratedProject ModelLibrary
        {
            get { return _modelLibrary; }
        }

        /// <summary>
        ///     Gets the generated project containing the proxy.
        /// </summary>
        public GeneratedProject ProxyLibrary
        {
            get { return _proxyLibrary; }
        }

        /// <summary>
        ///     Gets the task which performs the compilation of the model library.
        /// </summary>
        public GeneratedBuildTask ModelBuilder
        {
            get
            {
                if (_modelBuilder == null)
                    _modelBuilder = new GeneratedBuildTask(this.ModelLibrary.FilePath);

                return _modelBuilder;
            }
        }

        /// <summary>
        ///     Gets the name of the task
        /// </summary>
        public override sealed String Name
        {
            get { return String.Format("Injecting {0} into {1}", this.ModelLibrary.Name, this.ProxyLibrary.Name); }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Creates a class-interface injector task list.
        /// </summary>
        /// <param name="ifaceLibrary">
        ///     Sets the generated project containing the interfaces. 
        /// </param>
        /// <param name="classLibrary">
        ///     Sets the generated project containing the classes.
        /// </param>
        public GeneratedEncapsulatorTaskList(Domain domain, GeneratedProject modelLibrary, GeneratedProject proxyLibrary)
        {
            _domain = domain;
            _modelLibrary = modelLibrary;
            _proxyLibrary = proxyLibrary;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Constructs the collection of sub-tasks that are included in this task list.
        /// <returns></returns>
        protected override sealed IEnumerable<Task> GetSubTasks()
        {
            yield return this.ModelBuilder;
            foreach (GeneratedEncapsulator injector in this.GetInjectors())
                yield return injector;

        }

        /// <summary>
        ///     Constructs the collection of injectors that are executed in this task list.
        /// </summary>
        protected abstract IEnumerable<GeneratedEncapsulator> GetInjectors();

        #endregion
    }

    public abstract class GeneratedEncapsulatorTaskList<TModelLibrary, TProxyLibrary> : GeneratedEncapsulatorTaskList where TModelLibrary : GeneratedProject where TProxyLibrary : GeneratedProject
    {
        #region constructors

        /// <summary>
        ///     Creates a class-interface injector task list.
        /// </summary>
        /// <param name="ifaceLibrary">
        ///     Sets the generated project containing the interfaces. 
        /// </param>
        /// <param name="classLibrary">
        ///     Sets the generated project containing the classes.
        /// </param>
        public GeneratedEncapsulatorTaskList(String workingDirectory, Domain domain) : base(domain, Activator.CreateInstance(typeof(TModelLibrary), new Object[] { workingDirectory, domain }) as TModelLibrary, Activator.CreateInstance(typeof(TProxyLibrary), new Object[] { workingDirectory, domain }) as TProxyLibrary)
        {
        }

        #endregion
    }
}
