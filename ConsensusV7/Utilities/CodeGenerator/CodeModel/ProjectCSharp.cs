using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Represents a generated project.
    /// </summary>
    public abstract class ProjectCSharp : Project
    {
        #region properties

        /// <summary>
        ///     Gets the extension used for the project file
        /// </summary>
        public sealed override String FileExtension
        {
            get { return "csproj"; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="ProjectCSharp"/> instance.
        /// </summary>
        /// <param name="solution">
        ///     Sets the parent solution within which, the project is location.
        /// </param>
        public ProjectCSharp(ProjectSolution solution) : base(solution)
        {
        }

        #endregion
    }
}
