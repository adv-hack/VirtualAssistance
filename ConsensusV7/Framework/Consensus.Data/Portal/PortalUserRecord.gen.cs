using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Represents the "PORTAL_USER" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PortalUserRecord : Record<Int32>, Cloneable<PortalUserRecord>, IEquatable<PortalUserRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PU_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PU_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PU_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PU_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PU_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PU_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PU_PR_ID" field.
        /// </summary>
        private Int32? _prId;

        /// <summary>
        ///     the value of the "PU_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "PU_LOGIN_ID" field.
        /// </summary>
        private String _loginId;

        /// <summary>
        ///     the value of the "PU_PASSWORD" field.
        /// </summary>
        private String _password;

        /// <summary>
        ///     the value of the "PU_BARRED" field.
        /// </summary>
        private Byte? _barred;

        /// <summary>
        ///     the value of the "PU_SYS_ADMIN" field.
        /// </summary>
        private Byte? _sysAdmin;

        /// <summary>
        ///     the value of the "PU_SHT_LOGIN_ID" field.
        /// </summary>
        private String _shtLoginId;

        /// <summary>
        ///     the value of the "PU_CREATE" field.
        /// </summary>
        private String _create;

        /// <summary>
        ///     the value of the "PU_READ" field.
        /// </summary>
        private String _read;

        /// <summary>
        ///     the value of the "PU_UPDATE" field.
        /// </summary>
        private String _update;

        /// <summary>
        ///     the value of the "PU_DELETE" field.
        /// </summary>
        private String _delete;

        /// <summary>
        ///     the value of the "PU_NTUSERNAME" field.
        /// </summary>
        private String _ntusername;

        /// <summary>
        ///     the value of the "PU_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "PU_INC_MYORG" field.
        /// </summary>
        private Byte _incMyorg;

        /// <summary>
        ///     the value of the "PU_ATTEMPT_COUNT" field.
        /// </summary>
        private Byte? _attemptCount;

        /// <summary>
        ///     the value of the "PU_LOCKED_UNTIL" field.
        /// </summary>
        private DateTime? _lockedUntil;

        /// <summary>
        ///     the value of the "PU_RESET_CODE" field.
        /// </summary>
        private String _resetCode;

        /// <summary>
        ///     the value of the "PU_PARTNER_SYS_REF" field.
        /// </summary>
        private String _partnerSysRef;

        /// <summary>
        ///     the value of the "PU_SECRET_QUEST" field.
        /// </summary>
        private String _secretQuest;

        /// <summary>
        ///     the value of the "PU_SECRET_ANSWER" field.
        /// </summary>
        private String _secretAnswer;

        /// <summary>
        ///     the value of the "PU_FIRST_LOGIN" field.
        /// </summary>
        private DateTime? _firstLogin;

        /// <summary>
        ///     the value of the "PU_LAST_LOGIN" field.
        /// </summary>
        private DateTime? _lastLogin;

        /// <summary>
        ///     the value of the "PU_NO_LOGINS" field.
        /// </summary>
        private Int64 _noLogins;

        /// <summary>
        ///     the value of the "PU_RESET_VALID_UNTIL" field.
        /// </summary>
        private DateTime? _resetValidUntil;

        /// <summary>
        ///     the value of the "PU_RESET_URL" field.
        /// </summary>
        private String _resetUrl;

        /// <summary>
        ///     the value of the "PU_GUID" field.
        /// </summary>
        private Guid _guid;

        /// <summary>
        ///     the value of the "PU_AUTH_PROVIDER" field.
        /// </summary>
        private String _authProvider;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PU_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PU_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PU_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PU_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PU_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PU_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PU_PR_ID" field.
        /// </summary>
        public Int32? PrId
        {
            get { return _prId; }
            set { _prId = value; }
        }

        /// <summary>
        ///     the value of the "PU_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "PU_LOGIN_ID" field.
        /// </summary>
        public String LoginId
        {
            get { return _loginId; }
            set { _loginId = value; }
        }

        /// <summary>
        ///     the value of the "PU_PASSWORD" field.
        /// </summary>
        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        /// <summary>
        ///     the value of the "PU_BARRED" field.
        /// </summary>
        public Byte? Barred
        {
            get { return _barred; }
            set { _barred = value; }
        }

        /// <summary>
        ///     the value of the "PU_SYS_ADMIN" field.
        /// </summary>
        public Byte? SysAdmin
        {
            get { return _sysAdmin; }
            set { _sysAdmin = value; }
        }

        /// <summary>
        ///     the value of the "PU_SHT_LOGIN_ID" field.
        /// </summary>
        public String ShtLoginId
        {
            get { return _shtLoginId; }
            set { _shtLoginId = value; }
        }

        /// <summary>
        ///     the value of the "PU_CREATE" field.
        /// </summary>
        public String Create
        {
            get { return _create; }
            set { _create = value; }
        }

        /// <summary>
        ///     the value of the "PU_READ" field.
        /// </summary>
        public String Read
        {
            get { return _read; }
            set { _read = value; }
        }

        /// <summary>
        ///     the value of the "PU_UPDATE" field.
        /// </summary>
        public String Update
        {
            get { return _update; }
            set { _update = value; }
        }

        /// <summary>
        ///     the value of the "PU_DELETE" field.
        /// </summary>
        public String Delete
        {
            get { return _delete; }
            set { _delete = value; }
        }

        /// <summary>
        ///     the value of the "PU_NTUSERNAME" field.
        /// </summary>
        public String Ntusername
        {
            get { return _ntusername; }
            set { _ntusername = value; }
        }

        /// <summary>
        ///     the value of the "PU_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "PU_INC_MYORG" field.
        /// </summary>
        public Byte IncMyorg
        {
            get { return _incMyorg; }
            set { _incMyorg = value; }
        }

        /// <summary>
        ///     the value of the "PU_ATTEMPT_COUNT" field.
        /// </summary>
        public Byte? AttemptCount
        {
            get { return _attemptCount; }
            set { _attemptCount = value; }
        }

        /// <summary>
        ///     the value of the "PU_LOCKED_UNTIL" field.
        /// </summary>
        public DateTime? LockedUntil
        {
            get { return _lockedUntil; }
            set { _lockedUntil = value; }
        }

        /// <summary>
        ///     the value of the "PU_RESET_CODE" field.
        /// </summary>
        public String ResetCode
        {
            get { return _resetCode; }
            set { _resetCode = value; }
        }

        /// <summary>
        ///     the value of the "PU_PARTNER_SYS_REF" field.
        /// </summary>
        public String PartnerSysRef
        {
            get { return _partnerSysRef; }
            set { _partnerSysRef = value; }
        }

        /// <summary>
        ///     the value of the "PU_SECRET_QUEST" field.
        /// </summary>
        public String SecretQuest
        {
            get { return _secretQuest; }
            set { _secretQuest = value; }
        }

        /// <summary>
        ///     the value of the "PU_SECRET_ANSWER" field.
        /// </summary>
        public String SecretAnswer
        {
            get { return _secretAnswer; }
            set { _secretAnswer = value; }
        }

        /// <summary>
        ///     the value of the "PU_FIRST_LOGIN" field.
        /// </summary>
        public DateTime? FirstLogin
        {
            get { return _firstLogin; }
            set { _firstLogin = value; }
        }

        /// <summary>
        ///     the value of the "PU_LAST_LOGIN" field.
        /// </summary>
        public DateTime? LastLogin
        {
            get { return _lastLogin; }
            set { _lastLogin = value; }
        }

        /// <summary>
        ///     the value of the "PU_NO_LOGINS" field.
        /// </summary>
        public Int64 NoLogins
        {
            get { return _noLogins; }
            set { _noLogins = value; }
        }

        /// <summary>
        ///     the value of the "PU_RESET_VALID_UNTIL" field.
        /// </summary>
        public DateTime? ResetValidUntil
        {
            get { return _resetValidUntil; }
            set { _resetValidUntil = value; }
        }

        /// <summary>
        ///     the value of the "PU_RESET_URL" field.
        /// </summary>
        public String ResetUrl
        {
            get { return _resetUrl; }
            set { _resetUrl = value; }
        }

        /// <summary>
        ///     the value of the "PU_GUID" field.
        /// </summary>
        public Guid Guid
        {
            get { return _guid; }
            set { _guid = value; }
        }

        /// <summary>
        ///     the value of the "PU_AUTH_PROVIDER" field.
        /// </summary>
        public String AuthProvider
        {
            get { return _authProvider; }
            set { _authProvider = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PortalUserRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PortalUserRecord" /> object instance.
        /// </returns>
        public PortalUserRecord Clone()
        {
            PortalUserRecord record = new PortalUserRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.PrId = this.PrId;
            record.ProleId = this.ProleId;
            record.LoginId = this.LoginId;
            record.Password = this.Password;
            record.Barred = this.Barred;
            record.SysAdmin = this.SysAdmin;
            record.ShtLoginId = this.ShtLoginId;
            record.Create = this.Create;
            record.Read = this.Read;
            record.Update = this.Update;
            record.Delete = this.Delete;
            record.Ntusername = this.Ntusername;
            record.SelcoSpId = this.SelcoSpId;
            record.IncMyorg = this.IncMyorg;
            record.AttemptCount = this.AttemptCount;
            record.LockedUntil = this.LockedUntil;
            record.ResetCode = this.ResetCode;
            record.PartnerSysRef = this.PartnerSysRef;
            record.SecretQuest = this.SecretQuest;
            record.SecretAnswer = this.SecretAnswer;
            record.FirstLogin = this.FirstLogin;
            record.LastLogin = this.LastLogin;
            record.NoLogins = this.NoLogins;
            record.ResetValidUntil = this.ResetValidUntil;
            record.ResetUrl = this.ResetUrl;
            record.Guid = this.Guid;
            record.AuthProvider = this.AuthProvider;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PortalUserRecord" /> instance is equal to another <see cref="PortalUserRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PortalUserRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PortalUserRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.PrId == that.PrId);
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.LoginId.TrimOrNullify() == that.LoginId.TrimOrNullify());
            result = result && (this.Password.TrimOrNullify() == that.Password.TrimOrNullify());
            result = result && (this.Barred == that.Barred);
            result = result && (this.SysAdmin == that.SysAdmin);
            result = result && (this.ShtLoginId.TrimOrNullify() == that.ShtLoginId.TrimOrNullify());
            result = result && (this.Create.TrimOrNullify() == that.Create.TrimOrNullify());
            result = result && (this.Read.TrimOrNullify() == that.Read.TrimOrNullify());
            result = result && (this.Update.TrimOrNullify() == that.Update.TrimOrNullify());
            result = result && (this.Delete.TrimOrNullify() == that.Delete.TrimOrNullify());
            result = result && (this.Ntusername.TrimOrNullify() == that.Ntusername.TrimOrNullify());
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.IncMyorg == that.IncMyorg);
            result = result && (this.AttemptCount == that.AttemptCount);
            result = result && (this.LockedUntil == that.LockedUntil);
            result = result && (this.ResetCode.TrimOrNullify() == that.ResetCode.TrimOrNullify());
            result = result && (this.PartnerSysRef.TrimOrNullify() == that.PartnerSysRef.TrimOrNullify());
            result = result && (this.SecretQuest.TrimOrNullify() == that.SecretQuest.TrimOrNullify());
            result = result && (this.SecretAnswer.TrimOrNullify() == that.SecretAnswer.TrimOrNullify());
            result = result && (this.FirstLogin == that.FirstLogin);
            result = result && (this.LastLogin == that.LastLogin);
            result = result && (this.NoLogins == that.NoLogins);
            result = result && (this.ResetValidUntil == that.ResetValidUntil);
            result = result && (this.ResetUrl.TrimOrNullify() == that.ResetUrl.TrimOrNullify());
            result = result && (this.Guid == that.Guid);
            result = result && (this.AuthProvider.TrimOrNullify() == that.AuthProvider.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
