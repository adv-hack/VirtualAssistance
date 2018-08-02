using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Represents a generated Visual Studio project
    /// </summary>
    public abstract class GeneratedProject : TaskList
    {
        #region fields

        /// <summary>
        ///     The working directory in which the files are generated.
        /// </summary>
        private String _workingDirectory;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the working directory in which the files are generated.
        /// </summary>
        public String WorkingDirectory
        {
            get { return _workingDirectory; }
        }

        /// <summary>
        ///     Gets the full path of the generated project file.
        /// </summary>
        public String FilePath
        {
            get { return Path.Combine(this.FileFolder, String.Format("{0}.{1}", this.FileName, this.FileExtension)); }
        }

        /// <summary>
        ///     Gets the name of the generated project file.
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
        ///     Gets the folder in which the project is generated.
        /// </summary>
        public virtual String FileFolder
        {
            get { return Path.Combine(this.WorkingDirectory, "Framework", this.FileName); }
        }

        /// <summary>
        ///     Gets the root namespace for the project
        /// </summary>
        public abstract String ProjectNamespace
        {
            get;
        }

        public abstract Domain Domain
        {
            get;
        }
        #endregion

        #region constructor

        public GeneratedProject(String workingDirectory)
        {
            _workingDirectory = workingDirectory;
        }

        #endregion
    }
}
