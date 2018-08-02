using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     A member within a type.
    /// </summary>
    public abstract class Member
    {
        #region fields

        /// <summary>
        ///     Gets the parent <see cref="Type" /> in which, this member is defined.
        /// </summary>
        public readonly Type ParentType;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the summary section of the xml documentation.
        /// </summary>
        public String XmlSummary { get; set; }

        /// <summary>
        ///     Gets or sets the remarks section of the xml documentation.
        /// </summary>
        public String XmlRemarks { get; set; }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="Member" />.
        /// </summary>
        /// <param name="parent">
        ///     Sets the parent <see cref="Type" /> in which, this member is defined.
        /// </param>
        public Member(Type parent)
        {
            this.ParentType = parent;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Generates the C-Sharp code for the member.
        /// </summary>
        /// <param name="output">
        ///     The string builder, to which the generated code is written.
        /// </param>
        public abstract void Generate(StringBuilder output);

        #endregion
    }
}
