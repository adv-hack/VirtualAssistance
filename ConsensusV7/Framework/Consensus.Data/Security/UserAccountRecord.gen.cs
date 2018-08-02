using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents the "User_Account" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class UserAccountRecord : Record<Int32>, Cloneable<UserAccountRecord>, IEquatable<UserAccountRecord>
    {
        #region fields

        /// <summary>
        ///     the security principal referenced by the account.
        /// </summary>
        private Int32 _principalId;

        /// <summary>
        ///     the person to whom the user account belongs.
        /// </summary>
        private String _personId;

        /// <summary>
        ///     the selling company settings to be applied for the user.
        /// </summary>
        private String _selcoId;

        /// <summary>
        ///     the enumerated status of the user account.
        /// </summary>
        private Int32 _status;

        /// <summary>
        ///     the number of login attempts that have failed since the user last logged on successfully.
        /// </summary>
        private Int32 _failCount;

        /// <summary>
        ///     the date and time of the last successful authentication.
        /// </summary>
        private DateTime? _lastLogin;

        /// <summary>
        ///     the name of the authentication provider.
        /// </summary>
        private String _provider;

        /// <summary>
        ///     sys admin flag.
        /// </summary>
        private Byte? _sysAdmin;

        /// <summary>
        ///     determines whether user is  in Pool A or Pool B.
        /// </summary>
        private Int32 _licenseType;

        /// <summary>
        ///     it's use for set the Home page dashboard report id.
        /// </summary>
        private String _repId;

        #endregion

        #region properties

        /// <summary>
        ///     the security principal referenced by the account.
        /// </summary>
        public Int32 PrincipalId
        {
            get { return _principalId; }
            set { _principalId = value; }
        }

        /// <summary>
        ///     the person to whom the user account belongs.
        /// </summary>
        public String PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }

        /// <summary>
        ///     the selling company settings to be applied for the user.
        /// </summary>
        public String SelcoId
        {
            get { return _selcoId; }
            set { _selcoId = value; }
        }

        /// <summary>
        ///     the enumerated status of the user account.
        /// </summary>
        public Int32 Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the number of login attempts that have failed since the user last logged on successfully.
        /// </summary>
        public Int32 FailCount
        {
            get { return _failCount; }
            set { _failCount = value; }
        }

        /// <summary>
        ///     the date and time of the last successful authentication.
        /// </summary>
        public DateTime? LastLogin
        {
            get { return _lastLogin; }
            set { _lastLogin = value; }
        }

        /// <summary>
        ///     the name of the authentication provider.
        /// </summary>
        public String Provider
        {
            get { return _provider; }
            set { _provider = value; }
        }

        /// <summary>
        ///     sys admin flag.
        /// </summary>
        public Byte? SysAdmin
        {
            get { return _sysAdmin; }
            set { _sysAdmin = value; }
        }

        /// <summary>
        ///     determines whether user is  in Pool A or Pool B.
        /// </summary>
        public Int32 LicenseType
        {
            get { return _licenseType; }
            set { _licenseType = value; }
        }

        /// <summary>
        ///     it's use for set the Home page dashboard report id.
        /// </summary>
        public String RepId
        {
            get { return _repId; }
            set { _repId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="UserAccountRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="UserAccountRecord" /> object instance.
        /// </returns>
        public UserAccountRecord Clone()
        {
            UserAccountRecord record = new UserAccountRecord();
            record.Id = this.Id;
            record.PrincipalId = this.PrincipalId;
            record.PersonId = this.PersonId;
            record.SelcoId = this.SelcoId;
            record.Status = this.Status;
            record.FailCount = this.FailCount;
            record.LastLogin = this.LastLogin;
            record.Provider = this.Provider;
            record.SysAdmin = this.SysAdmin;
            record.LicenseType = this.LicenseType;
            record.RepId = this.RepId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="UserAccountRecord" /> instance is equal to another <see cref="UserAccountRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="UserAccountRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(UserAccountRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.PrincipalId == that.PrincipalId);
            result = result && (this.PersonId.TrimOrNullify() == that.PersonId.TrimOrNullify());
            result = result && (this.SelcoId.TrimOrNullify() == that.SelcoId.TrimOrNullify());
            result = result && (this.Status == that.Status);
            result = result && (this.FailCount == that.FailCount);
            result = result && (this.LastLogin == that.LastLogin);
            result = result && (this.Provider.TrimOrNullify() == that.Provider.TrimOrNullify());
            result = result && (this.SysAdmin == that.SysAdmin);
            result = result && (this.LicenseType == that.LicenseType);
            result = result && (this.RepId.TrimOrNullify() == that.RepId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
