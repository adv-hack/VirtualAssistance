using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Represents the "Master_Club" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class MasterClubRecord : Record<String>, Cloneable<MasterClubRecord>, IEquatable<MasterClubRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "MSTC_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "MSTC_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "MSTC_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "MSTC_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "MSTC_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "MSTC_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "MSTC_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "MSTC_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "MSTC_DAYS_NO" field.
        /// </summary>
        private Byte? _daysNo;

        /// <summary>
        ///     the value of the "MSTC_PERIOD" field.
        /// </summary>
        private Double? _period;

        /// <summary>
        ///     the value of the "MSTC_MEMB_VAL" field.
        /// </summary>
        private Decimal _membVal;

        /// <summary>
        ///     the value of the "MSTC_EXP_DATE" field.
        /// </summary>
        private DateTime? _expDate;

        /// <summary>
        ///     the value of the "MSTC_CONTACT" field.
        /// </summary>
        private String _contact;

        /// <summary>
        ///     the value of the "MSTC_MEMB_NO" field.
        /// </summary>
        private String _membNo;

        /// <summary>
        ///     the value of the "MSTC_START_DATE" field.
        /// </summary>
        private DateTime? _startDate;

        /// <summary>
        ///     the value of the "MSTC_FINISH_DATE" field.
        /// </summary>
        private DateTime? _finishDate;

        /// <summary>
        ///     the value of the "MSTC_PAY_DATE" field.
        /// </summary>
        private DateTime? _payDate;

        /// <summary>
        ///     the value of the "MSTC_TOT_POINTS" field.
        /// </summary>
        private Decimal _totPoints;

        /// <summary>
        ///     the value of the "MSTC_REMAIN_PTS" field.
        /// </summary>
        private Decimal _remainPts;

        /// <summary>
        ///     the value of the "MSTC_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "MSTC_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "MSTC_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "MSTC_USED_VALUE" field.
        /// </summary>
        private Double? _usedValue;

        /// <summary>
        ///     the value of the "MSTC_RESTRICT" field.
        /// </summary>
        private Byte? _restrict;

        /// <summary>
        ///     the value of the "MSTC_DELEGATE" field.
        /// </summary>
        private String _delegate;

        /// <summary>
        ///     the value of the "MSTC_PL_ID" field.
        /// </summary>
        private String _plId;

        /// <summary>
        ///     the value of the "MSTC_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "MSTC_PROD_TYPE" field.
        /// </summary>
        private String _prodType;

        /// <summary>
        ///     the value of the "MSTC_STOP_FLAG" field.
        /// </summary>
        private Byte? _stopFlag;

        /// <summary>
        ///     the value of the "MSTC_NAMED_USERS" field.
        /// </summary>
        private Byte? _namedUsers;

        /// <summary>
        ///     the value of the "MSTC_CURRENCY_TYPE" field.
        /// </summary>
        private String _currencyType;

        /// <summary>
        ///     the value of the "MSTC_CEN_ID" field.
        /// </summary>
        private String _cenId;

        /// <summary>
        ///     the value of the "MSTC_MEP_ID" field.
        /// </summary>
        private String _mepId;

        /// <summary>
        ///     the value of the "MSTC_NAMED_BOOKERS" field.
        /// </summary>
        private Byte? _namedBookers;

        /// <summary>
        ///     the value of the "MSTC_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "MSTC_UNIQUE_REF" field.
        /// </summary>
        private String _uniqueRef;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "MSTC_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_DAYS_NO" field.
        /// </summary>
        public Byte? DaysNo
        {
            get { return _daysNo; }
            set { _daysNo = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_PERIOD" field.
        /// </summary>
        public Double? Period
        {
            get { return _period; }
            set { _period = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_MEMB_VAL" field.
        /// </summary>
        public Decimal MembVal
        {
            get { return _membVal; }
            set { _membVal = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_EXP_DATE" field.
        /// </summary>
        public DateTime? ExpDate
        {
            get { return _expDate; }
            set { _expDate = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_CONTACT" field.
        /// </summary>
        public String Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_MEMB_NO" field.
        /// </summary>
        public String MembNo
        {
            get { return _membNo; }
            set { _membNo = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_FINISH_DATE" field.
        /// </summary>
        public DateTime? FinishDate
        {
            get { return _finishDate; }
            set { _finishDate = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_PAY_DATE" field.
        /// </summary>
        public DateTime? PayDate
        {
            get { return _payDate; }
            set { _payDate = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_TOT_POINTS" field.
        /// </summary>
        public Decimal TotPoints
        {
            get { return _totPoints; }
            set { _totPoints = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_REMAIN_PTS" field.
        /// </summary>
        public Decimal RemainPts
        {
            get { return _remainPts; }
            set { _remainPts = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_USED_VALUE" field.
        /// </summary>
        public Double? UsedValue
        {
            get { return _usedValue; }
            set { _usedValue = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_RESTRICT" field.
        /// </summary>
        public Byte? Restrict
        {
            get { return _restrict; }
            set { _restrict = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_DELEGATE" field.
        /// </summary>
        public String Delegate
        {
            get { return _delegate; }
            set { _delegate = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_PL_ID" field.
        /// </summary>
        public String PlId
        {
            get { return _plId; }
            set { _plId = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_PROD_TYPE" field.
        /// </summary>
        public String ProdType
        {
            get { return _prodType; }
            set { _prodType = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_STOP_FLAG" field.
        /// </summary>
        public Byte? StopFlag
        {
            get { return _stopFlag; }
            set { _stopFlag = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_NAMED_USERS" field.
        /// </summary>
        public Byte? NamedUsers
        {
            get { return _namedUsers; }
            set { _namedUsers = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_CURRENCY_TYPE" field.
        /// </summary>
        public String CurrencyType
        {
            get { return _currencyType; }
            set { _currencyType = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_CEN_ID" field.
        /// </summary>
        public String CenId
        {
            get { return _cenId; }
            set { _cenId = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_MEP_ID" field.
        /// </summary>
        public String MepId
        {
            get { return _mepId; }
            set { _mepId = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_NAMED_BOOKERS" field.
        /// </summary>
        public Byte? NamedBookers
        {
            get { return _namedBookers; }
            set { _namedBookers = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "MSTC_UNIQUE_REF" field.
        /// </summary>
        public String UniqueRef
        {
            get { return _uniqueRef; }
            set { _uniqueRef = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="MasterClubRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="MasterClubRecord" /> object instance.
        /// </returns>
        public MasterClubRecord Clone()
        {
            MasterClubRecord record = new MasterClubRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.OrgId = this.OrgId;
            record.DaysNo = this.DaysNo;
            record.Period = this.Period;
            record.MembVal = this.MembVal;
            record.ExpDate = this.ExpDate;
            record.Contact = this.Contact;
            record.MembNo = this.MembNo;
            record.StartDate = this.StartDate;
            record.FinishDate = this.FinishDate;
            record.PayDate = this.PayDate;
            record.TotPoints = this.TotPoints;
            record.RemainPts = this.RemainPts;
            record.Status = this.Status;
            record.Notes = this.Notes;
            record.Type = this.Type;
            record.UsedValue = this.UsedValue;
            record.Restrict = this.Restrict;
            record.Delegate = this.Delegate;
            record.PlId = this.PlId;
            record.ProdId = this.ProdId;
            record.ProdType = this.ProdType;
            record.StopFlag = this.StopFlag;
            record.NamedUsers = this.NamedUsers;
            record.CurrencyType = this.CurrencyType;
            record.CenId = this.CenId;
            record.MepId = this.MepId;
            record.NamedBookers = this.NamedBookers;
            record.Name = this.Name;
            record.UniqueRef = this.UniqueRef;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="MasterClubRecord" /> instance is equal to another <see cref="MasterClubRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="MasterClubRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(MasterClubRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.DaysNo == that.DaysNo);
            result = result && (this.Period == that.Period);
            result = result && (this.MembVal == that.MembVal);
            result = result && (this.ExpDate == that.ExpDate);
            result = result && (this.Contact.TrimOrNullify() == that.Contact.TrimOrNullify());
            result = result && (this.MembNo.TrimOrNullify() == that.MembNo.TrimOrNullify());
            result = result && (this.StartDate == that.StartDate);
            result = result && (this.FinishDate == that.FinishDate);
            result = result && (this.PayDate == that.PayDate);
            result = result && (this.TotPoints == that.TotPoints);
            result = result && (this.RemainPts == that.RemainPts);
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.UsedValue == that.UsedValue);
            result = result && (this.Restrict == that.Restrict);
            result = result && (this.Delegate.TrimOrNullify() == that.Delegate.TrimOrNullify());
            result = result && (this.PlId.TrimOrNullify() == that.PlId.TrimOrNullify());
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.ProdType.TrimOrNullify() == that.ProdType.TrimOrNullify());
            result = result && (this.StopFlag == that.StopFlag);
            result = result && (this.NamedUsers == that.NamedUsers);
            result = result && (this.CurrencyType.TrimOrNullify() == that.CurrencyType.TrimOrNullify());
            result = result && (this.CenId.TrimOrNullify() == that.CenId.TrimOrNullify());
            result = result && (this.MepId.TrimOrNullify() == that.MepId.TrimOrNullify());
            result = result && (this.NamedBookers == that.NamedBookers);
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.UniqueRef.TrimOrNullify() == that.UniqueRef.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
