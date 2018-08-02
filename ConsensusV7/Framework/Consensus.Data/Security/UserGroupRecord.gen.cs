using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents the "User_Group" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class UserGroupRecord : Record<Int32>, Cloneable<UserGroupRecord>, IEquatable<UserGroupRecord>
    {
        #region fields

        /// <summary>
        ///     the security principal referenced by the group.
        /// </summary>
        private Int32 _principalId;

        #endregion

        #region properties

        /// <summary>
        ///     the security principal referenced by the group.
        /// </summary>
        public Int32 PrincipalId
        {
            get { return _principalId; }
            set { _principalId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="UserGroupRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="UserGroupRecord" /> object instance.
        /// </returns>
        public UserGroupRecord Clone()
        {
            UserGroupRecord record = new UserGroupRecord();
            record.Id = this.Id;
            record.PrincipalId = this.PrincipalId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="UserGroupRecord" /> instance is equal to another <see cref="UserGroupRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="UserGroupRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(UserGroupRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.PrincipalId == that.PrincipalId);
            return result;
        }

        #endregion
    }
}
