using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Entity
{
    public class GeneratedProject : Project
    {
        #region properties

        /// <summary>
        ///     Gets the full path of the project folder.
        /// </summary>
        public override String ProjectFolder
        {
            get { return Path.Combine(this.Solution.SolutionPath, "Framework", this.ProjectName); }
        }

        /// <summary>
        ///     Gets the name of the project
        /// </summary>
        public override String ProjectName
        {
            get { return "Consensus.Entity"; }
        }

        /// <summary>
        ///     Gets the namespace for the project
        /// </summary>
        public override String ProjectNamespace
        {
            get { return "Consensus.Entity"; }
        }

        /// <summary>
        ///     Gets the extension used for the project file.
        /// </summary>
        public override String FileExtension
        {
            get { return "sqlproj"; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="Entity.GeneratedProject"/> instance.
        /// </summary>
        /// <param name="solution">
        ///     Sets the parent solution within which, the project is location.
        /// </param>
        public GeneratedProject(ProjectSolution solution) : base(solution)
        {
        }

        #endregion
    }
}
