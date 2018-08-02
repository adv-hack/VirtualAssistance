using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents the "User_Group_Member" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class UserGroupMemberRecord : Record<Int32>, Cloneable<UserGroupMemberRecord>, IEquatable<UserGroupMemberRecord>
    {
        #region fields

        /// <summary>
        ///     the security principal that is a member of the group.
        /// </summary>
        private Int32 _principalId;

        /// <summary>
        ///     the user group in which the member is included.
        /// </summary>
        private Int32 _groupId;

        #endregion

        #region properties

        /// <summary>
        ///     the security principal that is a member of the group.
        /// </summary>
        public Int32 PrincipalId
        {
            get { return _principalId; }
            set { _principalId = value; }
        }

        /// <summary>
        ///     the user group in which the member is included.
        /// </summary>
        public Int32 GroupId
        {
            get { return _groupId; }
            set { _groupId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="UserGroupMemberRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="UserGroupMemberRecord" /> object instance.
        /// </returns>
        public UserGroupMemberRecord Clone()
        {
            UserGroupMemberRecord record = new UserGroupMemberRecord();
            record.Id = this.Id;
            record.PrincipalId = this.PrincipalId;
            record.GroupId = this.GroupId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="UserGroupMemberRecord" /> instance is equal to another <see cref="UserGroupMemberRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="UserGroupMemberRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(UserGroupMemberRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.PrincipalId == that.PrincipalId);
            result = result && (this.GroupId == that.GroupId);
            return result;
        }

        #endregion
    }
}
