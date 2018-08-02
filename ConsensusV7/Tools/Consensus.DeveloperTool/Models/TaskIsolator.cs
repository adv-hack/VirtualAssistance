using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class TaskIsolator<TaskListType> : TaskList where TaskListType : TaskList
    {
        #region fields

        /// <summary>
        ///     The application domain in which the proxy is created.
        /// </summary>
        private AppDomain _appDomain;

        /// <summary>
        ///     The parameters used to initialise the remoting proxy.
        /// </summary>
        private Object[] _parameters;

        /// <summary>
        ///     The remoting proxy to the task list instance
        /// </summary>
        private TaskListType _proxy;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the application domain in which the proxy is created.
        /// </summary>
        public AppDomain AppDomain
        {
            get
            {
                if (_appDomain == null)
                {
                    AppDomainSetup temporarySetup = new AppDomainSetup();
                    temporarySetup.ApplicationBase = AppDomain.CurrentDomain.BaseDirectory;
                    temporarySetup.LoaderOptimization = LoaderOptimization.SingleDomain;
                    temporarySetup.ShadowCopyFiles = "true";
                    
                    _appDomain = AppDomain.CreateDomain(String.Format("app_{0}", Path.GetRandomFileName()), AppDomain.CurrentDomain.Evidence, temporarySetup);
                    _appDomain.InitializeLifetimeService();
                }
                return _appDomain;
            }
        }

        /// <summary>
        ///     Gets the parameters used to initialise the remoting proxy.
        /// </summary>
        public Object[] Parameters
        {
            get { return _parameters; }
        }

        /// <summary>
        ///     Gets the remoting proxy to the task list instance
        /// </summary>
        public TaskListType Proxy
        {
            get
            {
                if (_proxy == null)
                    _proxy = this.AppDomain.CreateInstanceAndUnwrap(typeof(TaskListType).Assembly.FullName, typeof(TaskListType).FullName, false, BindingFlags.Public | BindingFlags.Instance, null, this.Parameters, null, null) as TaskListType;

                return _proxy;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new isolated task
        /// </summary>
        public TaskIsolator(params Object[] parameters)
        {
            _parameters = parameters;
        }

        #endregion

        #region methods

        public override String Name
        {
            get { return this.Proxy.Name; }
        }

        public override Boolean Enabled
        {
            get { return this.Proxy.Enabled; }
        }

        internal override Task[] AllTasks
        {
            get { return this.Proxy.AllTasks; }
        }

        protected override void ExecuteTask()
        {
            try
            {
                this.Proxy.OnProgress += this.Progress;
                this.Proxy.OnMessage += this.Message; 
                this.Proxy.Execute();
            }
            finally
            {
                this.Proxy.OnMessage -= this.Message;
                this.Proxy.OnProgress -= this.Progress;

                // Unload the application domain
                AppDomain.Unload(this.AppDomain);
                _appDomain = null;
                _proxy = null;
            }
        }

        protected override IEnumerable<Task> GetSubTasks()
        {
            throw new NotSupportedException("The task isolator should execute sub-tasks defined within the remoting proxy and therefore does not include tasks of its own");
        }

        #endregion
    }
}
