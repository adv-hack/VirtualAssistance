using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    public abstract class ProjectItem
    {
        #region fields

        /// <summary>
        ///     Gets the parent <see cref="ProjectCSharp" /> in which, this member is defined.
        /// </summary>
        public Project ParentProject;

        /// <summary>
        ///     Gets the data source which drives the code generation for this type
        /// </summary>
        public Object DataSource;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the build action for the type.
        /// </summary>
        public abstract ProjectBuildAction BuildAction
        {
            get;
        }

        /// <summary>
        ///     Gets whether the type will be generated.
        /// </summary>
        public virtual ProjectGeneration TypeGeneration
        {
            get { return ProjectGeneration.Always; }
        }

        /// <summary>
        ///     Gets the name of the file that this file is nested under.
        /// </summary>
        public abstract String FileNesting
        {
            get;
        }

        /// <summary>
        ///     Gets the folder in which the file is stored.
        /// </summary>
        public abstract String FileFolder
        {
            get;
        }

        /// <summary>
        ///     Gets the name of the file.
        /// </summary>
        public abstract String FileName
        {
            get;
        }

        /// <summary>
        ///     Gets the full path of the file.
        /// </summary>
        public String FilePath
        {
            get { return Path.Combine(this.ParentProject.ProjectFolder, this.FileFolder, this.FileName); }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Generates the code for the runtime type and saves the code to the code file.
        /// </summary>
        public void Generate()
        {
            // Ensure the type folder exists
            if (!Directory.Exists(Path.Combine(this.ParentProject.ProjectFolder, this.FileFolder)))
                Directory.CreateDirectory(Path.Combine(this.ParentProject.ProjectFolder, this.FileFolder));

            // Generate the code for the file
            if (this.TypeGeneration == ProjectGeneration.Always || !File.Exists(this.FilePath))
            {
                StringBuilder codeContent = new StringBuilder();
                this.Generate(codeContent);
                File.WriteAllText(this.FilePath, codeContent.ToString());
            }
        }

        /// <summary>
        ///     Generates the code for the runtime type and appends the code to the specified string builder
        /// </summary>
        /// <param name="output">
        ///     The string builder instance to which all generated code is appended.
        /// </param>
        protected abstract void Generate(StringBuilder output);

        #endregion
    }
}
