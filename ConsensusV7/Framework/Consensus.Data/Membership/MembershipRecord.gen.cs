using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Represents the "Membership" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class MembershipRecord : Record<String>, Cloneable<MembershipRecord>, IEquatable<MembershipRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "MEM_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "MEM_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "MEM_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "MEM_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "MEM_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "MEM_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "MEM_REF" field.
        /// </summary>
        private String _ref;

        /// <summary>
        ///     the value of the "MEM_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "MEM_PM_ID" field.
        /// </summary>
        private String _pmId;

        /// <summary>
        ///     the value of the "MEM_START" field.
        /// </summary>
        private DateTime? _start;

        /// <summary>
        ///     the value of the "MEM_CUST_ORDER_NO" field.
        /// </summary>
        private String _custOrderNo;

        /// <summary>
        ///     the value of the "MEM_USERNAME" field.
        /// </summary>
        private String _username;

        /// <summary>
        ///     the value of the "MEM_PASSWORD" field.
        /// </summary>
        private String _password;

        /// <summary>
        ///     the value of the "MEM_REG_STATUS" field.
        /// </summary>
        private String _regStatus;

        /// <summary>
        ///     the value of the "MEM_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "MEM_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "MEM_GRADE" field.
        /// </summary>
        private String _grade;

        /// <summary>
        ///     the value of the "MEM_SUB_ONLY" field.
        /// </summary>
        private Int32? _subOnly;

        /// <summary>
        ///     the value of the "MEM_BIOG_HTML" field.
        /// </summary>
        private String _biogHtml;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "MEM_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "MEM_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "MEM_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "MEM_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "MEM_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "MEM_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "MEM_REF" field.
        /// </summary>
        public String Ref
        {
            get { return _ref; }
            set { _ref = value; }
        }

        /// <summary>
        ///     the value of the "MEM_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "MEM_PM_ID" field.
        /// </summary>
        public String PmId
        {
            get { return _pmId; }
            set { _pmId = value; }
        }

        /// <summary>
        ///     the value of the "MEM_START" field.
        /// </summary>
        public DateTime? Start
        {
            get { return _start; }
            set { _start = value; }
        }

        /// <summary>
        ///     the value of the "MEM_CUST_ORDER_NO" field.
        /// </summary>
        public String CustOrderNo
        {
            get { return _custOrderNo; }
            set { _custOrderNo = value; }
        }

        /// <summary>
        ///     the value of the "MEM_USERNAME" field.
        /// </summary>
        public String Username
        {
            get { return _username; }
            set { _username = value; }
        }

        /// <summary>
        ///     the value of the "MEM_PASSWORD" field.
        /// </summary>
        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        /// <summary>
        ///     the value of the "MEM_REG_STATUS" field.
        /// </summary>
        public String RegStatus
        {
            get { return _regStatus; }
            set { _regStatus = value; }
        }

        /// <summary>
        ///     the value of the "MEM_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "MEM_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "MEM_GRADE" field.
        /// </summary>
        public String Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        /// <summary>
        ///     the value of the "MEM_SUB_ONLY" field.
        /// </summary>
        public Int32? SubOnly
        {
            get { return _subOnly; }
            set { _subOnly = value; }
        }

        /// <summary>
        ///     the value of the "MEM_BIOG_HTML" field.
        /// </summary>
        public String BiogHtml
        {
            get { return _biogHtml; }
            set { _biogHtml = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="MembershipRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="MembershipRecord" /> object instance.
        /// </returns>
        public MembershipRecord Clone()
        {
            MembershipRecord record = new MembershipRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.RcvFrom = this.RcvFrom;
            record.RcvDate = this.RcvDate;
            record.Ref = this.Ref;
            record.Notes = this.Notes;
            record.PmId = this.PmId;
            record.Start = this.Start;
            record.CustOrderNo = this.CustOrderNo;
            record.Username = this.Username;
            record.Password = this.Password;
            record.RegStatus = this.RegStatus;
            record.Type = this.Type;
            record.Status = this.Status;
            record.Grade = this.Grade;
            record.SubOnly = this.SubOnly;
            record.BiogHtml = this.BiogHtml;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="MembershipRecord" /> instance is equal to another <see cref="MembershipRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="MembershipRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(MembershipRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Ref.TrimOrNullify() == that.Ref.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.PmId.TrimOrNullify() == that.PmId.TrimOrNullify());
            result = result && (this.Start == that.Start);
            result = result && (this.CustOrderNo.TrimOrNullify() == that.CustOrderNo.TrimOrNullify());
            result = result && (this.Username.TrimOrNullify() == that.Username.TrimOrNullify());
            result = result && (this.Password.TrimOrNullify() == that.Password.TrimOrNullify());
            result = result && (this.RegStatus.TrimOrNullify() == that.RegStatus.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.Grade.TrimOrNullify() == that.Grade.TrimOrNullify());
            result = result && (this.SubOnly == that.SubOnly);
            result = result && (this.BiogHtml.TrimOrNullify() == that.BiogHtml.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
