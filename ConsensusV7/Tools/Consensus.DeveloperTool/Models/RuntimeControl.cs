using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Reflection;

namespace Consensus.CodeGenerator
{
    public class RuntimeControl
    {
        #region fields

        private static Queue<ConsoleWriteItem> _oQueue = null;

        #endregion

        #region properties

        /// <summary>
        ///     The cancellation token to check if the user is trying to cancel or close the form.
        /// </summary>
        public CancellationToken CancelToken { get; set; }

        /// <summary>
        ///     A cache of mappings of entities to referenced attributes
        /// </summary>
        //public static Dictionary<DomainEntity, String[]> ContainersMap { get; set; }
        public Dictionary<Guid, string[]> ContainersMap { get; set; }

        /// <summary>
        ///     The main form, containing the display.
        /// </summary>
        public MainForm MainForm { get; set; }

        public Queue<ConsoleWriteItem> ConsoleQueue
        {
            get { return _oQueue; }
        }

        #endregion

        #region constructor

        public RuntimeControl(MainForm mainForm, CancellationToken cancelToken)
        {
            MainForm = mainForm;
            CancelToken = cancelToken;
            ContainersMap = new Dictionary<Guid, string[]>();
        }

        #endregion



        /// <summary>
        ///     Appends a message to the generator console.
        /// </summary>
        public void QueueConsoleMessage(String message)
        {
            if (!String.IsNullOrEmpty(message))
            {
                try
                {
                    Queue<ConsoleWriteItem> oQ = GetConsoleWriteQueue();

                    //if (message.Length > 1000)
                    //{
                    //    // Compilation o/p can overflow the queue.
                    //    // Split into several messages by counting lines.
                    //    string[] messageLines = message.Split('\n');
                    //    for (int i = 0; i < messageLines.Length; i+=1000)
                    //    {
                    //        messageLines.Join()
                    //    }                  
                    //}
                    //else
                    //{
                    lock (oQ)
                    {
                        oQ.Enqueue(new ConsoleWriteItem(message));
                    }
                    //}
                    ActivateQueueReader(oQ, MainForm);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
            }
        }

        /// <summary>
        ///     Initialises the content of the status bar
        /// </summary>
        public void QueueStatusUpdate(String text)
        {
            QueueStatusUpdate(text, false);
        }

        /// <summary>
        ///     Reset the status bar
        /// </summary>
        public void QueueResetStatus(String text)
        {
            QueueStatusUpdate(text, true);
        }

        /// <summary>
        ///     Initialises the content of the status bar
        /// </summary>
        private void QueueStatusUpdate(String text, bool reset)
        {
            try
            {
                Queue<ConsoleWriteItem> oQ = GetConsoleWriteQueue();

                lock (oQ)
                {
                    oQ.Enqueue(new ConsoleWriteItem(text, reset));
                }
                ActivateQueueReader(oQ, MainForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        /// <summary>
        ///     Gets the queue into which status and console updates are put.
        /// </summary>
        /// <returns></returns>
        public Queue<ConsoleWriteItem> GetConsoleWriteQueue()
        {
            if (_oQueue == null)
                _oQueue = new Queue<ConsoleWriteItem>();
            return _oQueue;
        }

        /// <summary>
        ///     Sets of a method to read the queue and update the console, if none currently running.
        /// </summary>
        /// <param name="oQ"></param>
        /// <param name="frm"></param>
        public void ActivateQueueReader(Queue<ConsoleWriteItem> oQ, MainForm frm)
        {
            if (!MainForm.QueueReaderActive)
            {
                MainForm.ProcessQueue(oQ);
            }
        }

        /// <summary>
        ///     Definition of the object that is put into the queue.
        /// </summary>
        public class ConsoleWriteItem
        {
            public string Message { get; private set; }
            public bool IsProgress { get; private set; }
            public bool ResetProgress { get; private set; }

            public ConsoleWriteItem(string Message)
            {
                this.Message = Message;
                this.IsProgress = false;
                this.ResetProgress = false;
            }

            public ConsoleWriteItem(string Message, bool reset)
            {
                this.Message = Message;
                this.IsProgress = true;
                this.ResetProgress = reset;
            }
        }
    }
}
