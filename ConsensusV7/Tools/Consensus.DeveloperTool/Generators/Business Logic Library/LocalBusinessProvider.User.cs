using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class LocalBusinessProviderUser : GeneratedClass
    {
        #region properties

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Provides the programmatic access to the locally-executable factory collections."; }
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
        ///     Gets the name of the runtime type.
        /// </summary>
        public override String TypeName
        {
            get { return "LocalProvider"; }
        }

        /// <summary>
        ///     Gets whether the generated runtime type is defined over multiple files.
        /// </summary>
        public override Boolean TypeIsPartial
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets whether the file should be overwritten, if the file already exists.
        /// </summary>
        public override bool FileIsEditable
        {
            get { return false; }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="LocalBusinessProviderUser" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain containers whose repository collections are exposed by the generated provider.
        /// </param>
        public LocalBusinessProviderUser(GeneratedProject project) : base(project)
        {
        }

        #endregion
    }
}
