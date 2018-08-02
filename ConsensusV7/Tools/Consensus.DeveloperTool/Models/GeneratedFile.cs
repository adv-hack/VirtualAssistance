using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Represents a generation task that is responsible for creating a file.
    /// </summary>
    public abstract class GeneratedFile : Task
    {
        #region properties

        /// <summary>
        ///     Gets or sets whether the task is enabled.
        /// </summary>
        public override Boolean Enabled
        {
            get 
            {
                if (!base.Enabled)
                    return false;
                
                return !File.Exists(this.FilePath) || new FileInfo(this.FilePath).Length == 0 || this.FileIsEditable;
            }
        }

        /// <summary>
        ///     Gets the name of the task
        /// </summary>
        public override String Name
        {
            get { return "Generating " + this.FilePath; }
        }

        /// <summary>
        ///     Gets the full path of the generated file.
        /// </summary>
        public String FilePath
        {
            get { return Path.Combine(this.FileFolder, String.Format("{0}.{1}", this.FileName, this.FileExtension)); }
        }

        /// <summary>
        ///     Gets the name of the generated file
        /// </summary>
        public abstract String FileName
        {
            get;
        }

        /// <summary>
        ///     Gets the extension of the generated file
        /// </summary>
        public abstract String FileExtension
        {
            get;
        }

        /// <summary>
        ///     Gets the folder in which the file is generated.
        /// </summary>
        public abstract String FileFolder
        {
            get;
        }

        /// <summary>
        ///     Gets whether the file should be overwritten, if the file already exists.
        /// </summary>
        public virtual Boolean FileIsEditable
        {
            get { return true; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Executes the task.
        /// </summary>
        protected override void ExecuteTask()
        {
            if (!Directory.Exists(this.FileFolder))
                Directory.CreateDirectory(this.FileFolder);

            using (Stream stream = new FileStream(this.FilePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                using (StreamWriter writer = new StreamWriter(stream))
                    this.GenerateContent(writer);
        }

        /// <summary>
        ///     Generates the content for the file.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        protected abstract void GenerateContent(StreamWriter writer);

        #endregion
    }
}
