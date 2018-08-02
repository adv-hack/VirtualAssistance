using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents the "User_Credential" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class UserCredentialRecord : Record<Int32>, Cloneable<UserCredentialRecord>, IEquatable<UserCredentialRecord>
    {
        #region fields

        /// <summary>
        ///     the user to whom the password belongs.
        /// </summary>
        private Int32 _user;

        /// <summary>
        ///     the salting value for the password,.
        /// </summary>
        private Byte[] _salt;

        /// <summary>
        ///     the verifier for the password.
        /// </summary>
        private Byte[] _pass;

        /// <summary>
        ///     the date and time on which the password was set.
        /// </summary>
        private DateTime _modified;

        #endregion

        #region properties

        /// <summary>
        ///     the user to whom the password belongs.
        /// </summary>
        public Int32 User
        {
            get { return _user; }
            set { _user = value; }
        }

        /// <summary>
        ///     the salting value for the password,.
        /// </summary>
        public Byte[] Salt
        {
            get { return _salt; }
            set { _salt = value; }
        }

        /// <summary>
        ///     the verifier for the password.
        /// </summary>
        public Byte[] Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }

        /// <summary>
        ///     the date and time on which the password was set.
        /// </summary>
        public DateTime Modified
        {
            get { return _modified; }
            set { _modified = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="UserCredentialRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="UserCredentialRecord" /> object instance.
        /// </returns>
        public UserCredentialRecord Clone()
        {
            UserCredentialRecord record = new UserCredentialRecord();
            record.Id = this.Id;
            record.User = this.User;
            record.Salt = this.Salt;
            record.Pass = this.Pass;
            record.Modified = this.Modified;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="UserCredentialRecord" /> instance is equal to another <see cref="UserCredentialRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="UserCredentialRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(UserCredentialRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.User == that.User);
            result = result && (this.Salt == that.Salt);
            result = result && (this.Pass == that.Pass);
            result = result && (this.Modified == that.Modified);
            return result;
        }

        #endregion
    }
}
