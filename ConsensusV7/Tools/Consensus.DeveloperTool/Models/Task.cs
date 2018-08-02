using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Represents a task within the generation processFile
    /// </summary>
    public abstract class Task : MarshalByRefObject
    {
        #region fields

        /// <summary>
        ///     The execution state of the task.
        /// </summary>
        private TaskState _state;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the execution state of the task.
        /// </summary>
        public TaskState State
        {
            get { return _state; }
            protected set { _state = value; }
        }

        /// <summary>
        ///     Gets whether the task should be executed.
        /// </summary>
        public virtual Boolean Enabled
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets the name of the task
        /// </summary>
        public abstract String Name
        {
            get;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Executes the task.
        /// </summary>
        public void Execute()
        {
            try
            {
                if (this.OnStart != null)
                    this.OnStart.Invoke();

                this.State = TaskState.Running;
                this.ExecuteTask();
                this.State = TaskState.Completed;

                if (this.OnFinish != null)
                    this.OnFinish.Invoke();
            }
            catch (Exception exception)
            {
                this.State = TaskState.Failed;
                if (this.OnError != null)
                    this.OnError.Invoke(exception);

                throw;
            }
        }

        /// <summary>
        ///     Executes the logic of the task
        /// </summary>
        protected abstract void ExecuteTask();
        
        /// <summary>
        ///     Outputs a message from the task
        /// </summary>
        /// <param name="message">
        ///     The message to be outputted.
        /// </param>
        protected void Message(String message)
        {
            if (this.OnMessage != null)
                this.OnMessage.Invoke(message);
        }

        /// <summary>
        ///     Obtains a lifetime service object to control the lifetime policy for this instance.
        /// </summary>
        /// <returns>
        ///     Returns null.
        /// </returns>
        [SecurityPermissionAttribute(SecurityAction.Demand, Flags = SecurityPermissionFlag.Infrastructure)]
        public override Object InitializeLifetimeService()
        {
            return null;
        }

        #endregion

        #region events

        /// <summary>
        ///     Occurs when the task has started
        /// </summary>
        public event TaskEvent OnStart;

        /// <summary>
        ///     Occurs when the task has finished
        /// </summary>
        public event TaskEvent OnFinish;

        /// <summary>
        ///     Occurs when the task outputs a message.
        /// </summary>
        public event TaskEvent<String> OnMessage;

        /// <summary>
        ///     Occurs when the task fails.
        /// </summary>
        public event TaskEvent<Exception> OnError;

        #endregion
    }
}
