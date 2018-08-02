using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     A named member within a type.
    /// </summary>
    public abstract class MemberNamed : Member
    {
        #region properties

        /// <summary>
        ///     Gets or sets the name of the member.
        /// </summary>
        public String MemberName{ get; set; }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="MemberNamed" />.
        /// </summary>
        /// <param name="parent">
        ///     Sets the parent <see cref="Type" /> in which, this member is defined.
        /// </param>
        public MemberNamed(Type parent) : base(parent)
        {
        }

        #endregion
    }
}
