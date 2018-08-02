using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public abstract class GeneratedInjectorTaskList : TaskList
    {
        #region fields

        /// <summary>
        ///     The business domain from which the injectors are generated.
        /// </summary>
        private Domain _domain;

        /// <summary>
        ///     The generated project containing the interfaces.
        /// </summary>
        private GeneratedProject _ifaceLibrary;

        /// <summary>
        ///     The generated project containing the classes.
        /// </summary>
        private GeneratedProject _classLibrary;

        /// <summary>
        ///     The task which performs the compilation of the class library.
        /// </summary>
        private GeneratedBuildTask _buildTask;

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
        ///     Gets the generated project containing the interfaces.
        /// </summary>
        public GeneratedProject IfaceLibrary
        {
            get { return _ifaceLibrary; }
        }

        /// <summary>
        ///     Gets the generated project containing the classes.
        /// </summary>
        public GeneratedProject ClassLibrary
        {
            get { return _classLibrary; }
        }

        /// <summary>
        ///     Gets the task which performs the compilation of the class library.
        /// </summary>
        public GeneratedBuildTask BuildTask
        {
            get
            {
                if (_buildTask == null)
                    _buildTask = new GeneratedBuildTask(this.ClassLibrary.FilePath);
                return _buildTask;
            }
        }

        /// <summary>
        ///     Gets the name of the task
        /// </summary>
        public override sealed String Name
        {
            get { return String.Format("Injecting {0} into {1}", this.ClassLibrary.Name, this.IfaceLibrary.Name); }
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
        public GeneratedInjectorTaskList(Domain domain, GeneratedProject ifaceLibrary, GeneratedProject classLibrary)
        {
            _domain = domain;
            _ifaceLibrary = ifaceLibrary;
            _classLibrary = classLibrary;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Constructs the collection of sub-tasks that are included in this task list.
        /// <returns></returns>
        protected override sealed IEnumerable<Task> GetSubTasks()
        {
            yield return this.BuildTask;
            foreach (GeneratedInjector injector in this.GetInjectors())
                yield return injector;

        }

        /// <summary>
        ///     Constructs the collection of injectors that are executed in this task list.
        /// </summary>
        protected abstract IEnumerable<GeneratedInjector> GetInjectors();

        #endregion
    }

    public abstract class GeneratedInjectorTaskList<TLibraryI, TLibraryC> : GeneratedInjectorTaskList where TLibraryI : GeneratedProject where TLibraryC : GeneratedProject
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
        public GeneratedInjectorTaskList(String workingDirectory, Domain domain) : base(domain, Activator.CreateInstance(typeof(TLibraryI), new Object[] { workingDirectory, domain }) as TLibraryI, Activator.CreateInstance(typeof(TLibraryC), new Object[] { workingDirectory, domain }) as TLibraryC)
        {
        }

        #endregion
    }
}
