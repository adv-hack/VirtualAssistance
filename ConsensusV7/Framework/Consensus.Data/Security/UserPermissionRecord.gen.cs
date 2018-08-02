using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents the "User_Permission" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class UserPermissionRecord : Record<Int32>, Cloneable<UserPermissionRecord>, IEquatable<UserPermissionRecord>
    {
        #region fields

        /// <summary>
        ///     the security principal to whom the permission is applied.
        /// </summary>
        private Int32 _principalId;

        /// <summary>
        ///     the data type to which the permission is applied.
        /// </summary>
        private String _dataType;

        /// <summary>
        ///     the type of action that is either permitted or prohibited.
        /// </summary>
        private Int32 _action;

        /// <summary>
        ///     the value which indicates if the permission is granted (true) or denied (false).
        /// </summary>
        private Boolean _allow;

        #endregion

        #region properties

        /// <summary>
        ///     the security principal to whom the permission is applied.
        /// </summary>
        public Int32 PrincipalId
        {
            get { return _principalId; }
            set { _principalId = value; }
        }

        /// <summary>
        ///     the data type to which the permission is applied.
        /// </summary>
        public String DataType
        {
            get { return _dataType; }
            set { _dataType = value; }
        }

        /// <summary>
        ///     the type of action that is either permitted or prohibited.
        /// </summary>
        public Int32 Action
        {
            get { return _action; }
            set { _action = value; }
        }

        /// <summary>
        ///     the value which indicates if the permission is granted (true) or denied (false).
        /// </summary>
        public Boolean Allow
        {
            get { return _allow; }
            set { _allow = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="UserPermissionRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="UserPermissionRecord" /> object instance.
        /// </returns>
        public UserPermissionRecord Clone()
        {
            UserPermissionRecord record = new UserPermissionRecord();
            record.Id = this.Id;
            record.PrincipalId = this.PrincipalId;
            record.DataType = this.DataType;
            record.Action = this.Action;
            record.Allow = this.Allow;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="UserPermissionRecord" /> instance is equal to another <see cref="UserPermissionRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="UserPermissionRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(UserPermissionRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.PrincipalId == that.PrincipalId);
            result = result && (this.DataType.TrimOrNullify() == that.DataType.TrimOrNullify());
            result = result && (this.Action == that.Action);
            result = result && (this.Allow == that.Allow);
            return result;
        }

        #endregion
    }
}
