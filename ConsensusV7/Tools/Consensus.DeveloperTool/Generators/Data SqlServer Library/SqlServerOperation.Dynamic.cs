using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Generates the user-code file for the operation enumerator.
    /// </summary>
    public class SqlServerOperationDynamic : GeneratedEnumerator
    {
        #region properties

        /// <summary>
        ///     Gets the name of the generated file.
        /// </summary>
        public override String FileName
        {
            get { return base.FileName + ".gen"; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Enumerates the standard data access operations that can be executed against the Microsoft SQL Server database."; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlRemarks
        {
            get { return "THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.\r\nDO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION."; }
        }

        /// <summary>
        ///     Gets the name of the runtime type.
        /// </summary>
        public override String TypeName
        {
            get { return "SqlServerOperation"; }
        }

        /// <summary>
        ///     Gets the enumerations that are defined within the enumerator.
        /// </summary>
        public override IEnumerable<CSharpEnumeration> TypeMembers
        {
            get
            {
                yield return new CSharpEnumeration(this)
                {
                    XmlSummary = "Creates a new record within the repository.",
                    Name = "Create"
                };
                yield return new CSharpEnumeration(this)
                {
                    XmlSummary = "Modifies an existing record within the repository.",
                    Name = "Modify"
                };
                yield return new CSharpEnumeration(this)
                {
                    XmlSummary = "Removes an existing record from the repository.",
                    Name = "Remove"
                };
                yield return new CSharpEnumeration(this)
                {
                    XmlSummary = "Retrieves a single record from the repository.",
                    Name = "Fetch"
                };
                yield return new CSharpEnumeration(this)
                {
                    XmlSummary = "Retrieves multiple records from the repository.",
                    Name = "FetchAll"
                };
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="GenericDataOperationDynamic" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        public SqlServerOperationDynamic(GeneratedProject project) : base(project)
        {
        }

        #endregion
    }
}
