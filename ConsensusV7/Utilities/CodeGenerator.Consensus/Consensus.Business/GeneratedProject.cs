using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Business
{
    /// <summary>
    ///     Generates the Microsoft Visual Studio project.
    /// </summary>
    public class GeneratedProject : ProjectCSharp
    {
        #region properties

        /// <summary>
        ///     Gets the name of the project
        /// </summary>
        public override String ProjectName
        {
            get { return String.Format("{0}.Business", this.Solution.SolutionName); }
        }

        /// <summary>
        ///     Gets the namespace for the project
        /// </summary>
        public override String ProjectNamespace
        {
            get { return "Consensus"; }
        }

        /// <summary>
        ///     Gets the full path of the project folder.
        /// </summary>
        public override String ProjectFolder
        {
            get { return Path.Combine(this.Solution.SolutionPath, "Framework", this.ProjectName); }
        }

        /// <summary>
        ///     Gets the collection of project references.
        /// </summary>
        public override IEnumerable<String> ProjectReferences
        {
            get
            {
                yield return "../Consensus/Consensus.csproj";
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="Data.GeneratedProject"/> instance.
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
