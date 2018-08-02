using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Data.SqlServer
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
            get { return String.Format("{0}.Data.SqlServer", this.Solution.SolutionName); }
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
                yield return "../Consensus.Data/Consensus.Data.csproj";
                yield return "../../Libraries/Microsoft.Practices.EnterpriseLibrary.Common.dll";
                yield return "../../Libraries/Microsoft.Practices.EnterpriseLibrary.Data.dll";
                yield return "../../Libraries/Microsoft.Practices.ServiceLocation.dll";
                yield return "../../Libraries/Microsoft.Practices.Unity.dll";
                yield return "../../Libraries/Microsoft.Practices.Unity.Interception.dll";
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
