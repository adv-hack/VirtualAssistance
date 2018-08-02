using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public abstract class TaskList : Task
    {
        #region fields

        /// <summary>
        ///     The collection of sub-tasks that are included in this task list.
        /// </summary>
        private Task[] _subTasks;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the collection of sub-tasks that are included in this task list.
        /// </summary>
        public Task[] SubTasks
        {
            get
            {
                if (_subTasks == null)
                    _subTasks = this.GetSubTasks().ToArray();

                return _subTasks.Where(task => task.Enabled).ToArray();
            }
        }

        /// <summary>
        ///     Gets the recursive collection of all tasks within the task list
        /// </summary>
        internal virtual Task[] AllTasks
        {
            get { 
                return 
                    this.SubTasks.Where(task => task.Enabled && task is TaskList == false).Concat(
                    this.SubTasks.Where(task => task.Enabled).OfType<TaskList>().SelectMany(taskList => taskList.AllTasks)
                ).ToArray();
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Executes the subtasks in the task list
        /// </summary>
        protected override void ExecuteTask()
        {
            foreach (Task task in this.SubTasks)
            {
                if (MainForm.Runtime != null && MainForm.Runtime.CancelToken != null)
                    MainForm.Runtime.CancelToken.ThrowIfCancellationRequested();

                TaskList taskList = task as TaskList;
                if (taskList != null)
                {
                    taskList.OnProgress += this.Progress;
                    taskList.OnMessage += this.Message;
                    taskList.Execute();
                    taskList.OnMessage -= this.Message;
                    taskList.OnProgress -= this.Progress;
                }
                else
                {
                    this.OnProgress(task.Name);

                    task.OnMessage += this.Message;
                    task.Execute();
                    task.OnMessage -= this.Message;
                }
            }
        }

        /// <summary>
        ///     Constructs the collection of sub-tasks that are included in this task list.
        /// <returns></returns>
        protected abstract IEnumerable<Task> GetSubTasks();

        /// <summary>
        ///     Outputs a message from the task
        /// </summary>
        protected void Progress(String name)
        {
            if (this.OnProgress != null)
                this.OnProgress.Invoke(name);
        }

        #endregion

        #region events

        /// <summary>
        ///     Occurs when the task has progressed but not completed.
        /// </summary>
        public event TaskEvent<String> OnProgress;

        #endregion
    }
}
