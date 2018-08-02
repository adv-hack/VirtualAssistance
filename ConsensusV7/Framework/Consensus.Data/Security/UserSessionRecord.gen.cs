using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents the "User_Session" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class UserSessionRecord : Record<Guid>, Cloneable<UserSessionRecord>, IEquatable<UserSessionRecord>
    {
        #region fields

        /// <summary>
        ///     the user account that has successfully authenticated.
        /// </summary>
        private Int32 _userId;

        /// <summary>
        ///     the date and time on which the session became active.
        /// </summary>
        private DateTime _active;

        /// <summary>
        ///     the date and time on which the session automatically expires, or was terminated.
        /// </summary>
        private DateTime _expiry;

        /// <summary>
        ///     the status which indicates how the session has been terminated.
        /// </summary>
        private Int32? _status;

        #endregion

        #region properties

        /// <summary>
        ///     the user account that has successfully authenticated.
        /// </summary>
        public Int32 UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        /// <summary>
        ///     the date and time on which the session became active.
        /// </summary>
        public DateTime Active
        {
            get { return _active; }
            set { _active = value; }
        }

        /// <summary>
        ///     the date and time on which the session automatically expires, or was terminated.
        /// </summary>
        public DateTime Expiry
        {
            get { return _expiry; }
            set { _expiry = value; }
        }

        /// <summary>
        ///     the status which indicates how the session has been terminated.
        /// </summary>
        public Int32? Status
        {
            get { return _status; }
            set { _status = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="UserSessionRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="UserSessionRecord" /> object instance.
        /// </returns>
        public UserSessionRecord Clone()
        {
            UserSessionRecord record = new UserSessionRecord();
            record.Id = this.Id;
            record.UserId = this.UserId;
            record.Active = this.Active;
            record.Expiry = this.Expiry;
            record.Status = this.Status;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="UserSessionRecord" /> instance is equal to another <see cref="UserSessionRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="UserSessionRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(UserSessionRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.UserId == that.UserId);
            result = result && (this.Active == that.Active);
            result = result && (this.Expiry == that.Expiry);
            result = result && (this.Status == that.Status);
            return result;
        }

        #endregion
    }
}
