using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Data
{
    /// <summary>
    ///     Generates the enumerator which specifies the standard data operations.
    /// </summary>
    public class GeneratedDataOperation : TypeEnumerator
    {
        #region properties

        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Enumerates the standard data operations."; }
        }

        /// <summary>
        ///     Gets the access modifier for the type.
        /// </summary>
        public override CSharpModifier TypeModifier
        {
            get { return CSharpModifier.Public; }
        }

        /// <summary>
        ///     Gets the name of the type.
        /// </summary>
        public override String TypeName
        {
            get { return "DataOperation"; }
        }

        /// <summary>
        ///     Gets the enumerations defined within this type.
        /// </summary>
        public override IEnumerable<MemberEnumeration> MemberEnumerations
        {
            get
            {
                yield return new MemberEnumeration(this)
                {
                    MemberName = "Create",
                    XmlSummary = "Creates a new record within the repository."
                };
                yield return new MemberEnumeration(this)
                {
                    MemberName = "Modify",
                    XmlSummary = "Modifies an existing record within the repository."
                };
                yield return new MemberEnumeration(this)
                {
                    MemberName = "Remove",
                    XmlSummary = "Removes an existing record from the repository."
                };
                yield return new MemberEnumeration(this)
                {
                    MemberName = "Select",
                    XmlSummary = "Retrieves a single record from the repository."
                };
                yield return new MemberEnumeration(this)
                {
                    MemberName = "SelectAll",
                    XmlSummary = "Retrieves multiple records from the repository."
                };
            }
        }

        #endregion
    }
}
