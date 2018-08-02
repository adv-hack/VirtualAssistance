using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Generates the user-code file for the repository collection base class.
    /// </summary>
    public class SqlServerRepositoryCollectionUser : GeneratedClass
    {
        #region properties

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Provides the abstraction for the repository collections that expose the repositories in a Microsoft SQL Server database"; }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get
            {
                yield return "System.Collections.Generic";
                yield return "System.Data";
                yield return "System.Linq";
            }
        }

        /// <summary>
        ///     Gets the abstraction of the generated runtime type.
        /// </summary>
        public override CSharpAbstractions TypeAbstraction
        {
            get { return CSharpAbstractions.Abstract; }
        }

        /// <summary>
        ///     Gets whether the generated runtime type is defined over multiple files.
        /// </summary>
        public override Boolean TypeIsPartial
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets the name of the runtime type.
        /// </summary>
        public override String TypeName
        {
            get { return "SqlServerRepositoryCollection"; }
        }

        /// <summary>
        ///     Gets whether the file should be overwritten, if the file already exists.
        /// </summary>
        public override Boolean FileIsEditable
        {
            get { return false; }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="SqlServerRepositoryCollectionUser" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain entity from which the repository is generated.
        /// </param>
        public SqlServerRepositoryCollectionUser(GeneratedProject project) : base(project)
        {
        }

        #endregion
    }
}
