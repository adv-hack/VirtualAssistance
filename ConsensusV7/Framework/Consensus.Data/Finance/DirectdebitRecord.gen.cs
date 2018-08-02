using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Represents the "DirectDebit" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class DirectdebitRecord : Record<String>, Cloneable<DirectdebitRecord>, IEquatable<DirectdebitRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "DD_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "DD_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "DD_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "DD_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "DD_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "DD_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "DD_TABLE_NUM" field.
        /// </summary>
        private Double? _tableNum;

        /// <summary>
        ///     the value of the "DD_REC_ID" field.
        /// </summary>
        private String _recId;

        /// <summary>
        ///     the value of the "DD_TYPE" field.
        /// </summary>
        private Int32? _type;

        /// <summary>
        ///     the value of the "DD_OIN" field.
        /// </summary>
        private String _oin;

        /// <summary>
        ///     the value of the "DD_REC_DATE" field.
        /// </summary>
        private DateTime? _recDate;

        /// <summary>
        ///     the value of the "DD_REC_METHOD" field.
        /// </summary>
        private Int32? _recMethod;

        /// <summary>
        ///     the value of the "DD_TO_BANK_DATE" field.
        /// </summary>
        private DateTime? _toBankDate;

        /// <summary>
        ///     the value of the "DD_EFFECTIVE_DATE" field.
        /// </summary>
        private DateTime? _effectiveDate;

        /// <summary>
        ///     the value of the "DD_END_DATE" field.
        /// </summary>
        private DateTime? _endDate;

        /// <summary>
        ///     the value of the "DD_STATUS" field.
        /// </summary>
        private Int32? _status;

        /// <summary>
        ///     the value of the "DD_FREQUENCY" field.
        /// </summary>
        private Int32? _frequency;

        /// <summary>
        ///     the value of the "DD_DAY_OF_MONTH" field.
        /// </summary>
        private Int32? _dayOfMonth;

        /// <summary>
        ///     the value of the "DD_VARIABLE" field.
        /// </summary>
        private Int32? _variable;

        /// <summary>
        ///     the value of the "DD_MAX_VALUE" field.
        /// </summary>
        private Decimal? _maxValue;

        /// <summary>
        ///     the value of the "DD_CURRENCY_TYPE" field.
        /// </summary>
        private String _currencyType;

        /// <summary>
        ///     the value of the "DD_BANK_NAME" field.
        /// </summary>
        private String _bankName;

        /// <summary>
        ///     the value of the "DD_BANK_ADD_1" field.
        /// </summary>
        private String _bankAdd1;

        /// <summary>
        ///     the value of the "DD_BANK_ADD_2" field.
        /// </summary>
        private String _bankAdd2;

        /// <summary>
        ///     the value of the "DD_BANK_ADD_3" field.
        /// </summary>
        private String _bankAdd3;

        /// <summary>
        ///     the value of the "DD_BANK_ADD_4" field.
        /// </summary>
        private String _bankAdd4;

        /// <summary>
        ///     the value of the "DD_BANK_POSTCODE" field.
        /// </summary>
        private String _bankPostcode;

        /// <summary>
        ///     the value of the "DD_CORE_REF" field.
        /// </summary>
        private String _coreRef;

        /// <summary>
        ///     the value of the "DD_BANK_ACC_NAME" field.
        /// </summary>
        private String _bankAccName;

        /// <summary>
        ///     the value of the "DD_BANK_ACC_CODE" field.
        /// </summary>
        private String _bankAccCode;

        /// <summary>
        ///     the value of the "DD_SORT_CODE" field.
        /// </summary>
        private String _sortCode;

        /// <summary>
        ///     the value of the "DD_CCARD_TYPE" field.
        /// </summary>
        private String _ccardType;

        /// <summary>
        ///     the value of the "DD_NAME_ON_CARD" field.
        /// </summary>
        private String _nameOnCard;

        /// <summary>
        ///     the value of the "DD_CCARD_NUMBER" field.
        /// </summary>
        private String _ccardNumber;

        /// <summary>
        ///     the value of the "DD_CCARD_ISSUE" field.
        /// </summary>
        private String _ccardIssue;

        /// <summary>
        ///     the value of the "DD_CCARD_SEC_ID" field.
        /// </summary>
        private String _ccardSecId;

        /// <summary>
        ///     the value of the "DD_CCARD_START_MTH" field.
        /// </summary>
        private String _ccardStartMth;

        /// <summary>
        ///     the value of the "DD_CCARD_START_YR" field.
        /// </summary>
        private String _ccardStartYr;

        /// <summary>
        ///     the value of the "DD_CCARD_EXPY_MTH" field.
        /// </summary>
        private String _ccardExpyMth;

        /// <summary>
        ///     the value of the "DD_CCARD_EXPY_YR" field.
        /// </summary>
        private String _ccardExpyYr;

        /// <summary>
        ///     the value of the "DD_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "DD_BANK_ORG_ID" field.
        /// </summary>
        private String _bankOrgId;

        /// <summary>
        ///     the value of the "DD_BANK_ADD_ID" field.
        /// </summary>
        private String _bankAddId;

        /// <summary>
        ///     the value of the "DD_RECORD_STATUS" field.
        /// </summary>
        private Byte _recordStatus;

        /// <summary>
        ///     the value of the "DD_BAT_ID" field.
        /// </summary>
        private String _batId;

        /// <summary>
        ///     the value of the "DD_TOTAL" field.
        /// </summary>
        private Decimal? _total;

        /// <summary>
        ///     the value of the "DD_STATUS_NOTES" field.
        /// </summary>
        private String _statusNotes;

        /// <summary>
        ///     the value of the "DD_STATUS_LAST_DATE" field.
        /// </summary>
        private DateTime? _statusLastDate;

        /// <summary>
        ///     the value of the "DD_STATUS_PREVIOUS" field.
        /// </summary>
        private Byte? _statusPrevious;

        /// <summary>
        ///     the value of the "DD_NO_OF_INSTALLMENTS" field.
        /// </summary>
        private Int32? _noOfInstallments;

        /// <summary>
        ///     the value of the "DD_DUE_DATE" field.
        /// </summary>
        private DateTime? _dueDate;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "DD_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "DD_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "DD_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "DD_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "DD_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "DD_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "DD_TABLE_NUM" field.
        /// </summary>
        public Double? TableNum
        {
            get { return _tableNum; }
            set { _tableNum = value; }
        }

        /// <summary>
        ///     the value of the "DD_REC_ID" field.
        /// </summary>
        public String RecId
        {
            get { return _recId; }
            set { _recId = value; }
        }

        /// <summary>
        ///     the value of the "DD_TYPE" field.
        /// </summary>
        public Int32? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "DD_OIN" field.
        /// </summary>
        public String Oin
        {
            get { return _oin; }
            set { _oin = value; }
        }

        /// <summary>
        ///     the value of the "DD_REC_DATE" field.
        /// </summary>
        public DateTime? RecDate
        {
            get { return _recDate; }
            set { _recDate = value; }
        }

        /// <summary>
        ///     the value of the "DD_REC_METHOD" field.
        /// </summary>
        public Int32? RecMethod
        {
            get { return _recMethod; }
            set { _recMethod = value; }
        }

        /// <summary>
        ///     the value of the "DD_TO_BANK_DATE" field.
        /// </summary>
        public DateTime? ToBankDate
        {
            get { return _toBankDate; }
            set { _toBankDate = value; }
        }

        /// <summary>
        ///     the value of the "DD_EFFECTIVE_DATE" field.
        /// </summary>
        public DateTime? EffectiveDate
        {
            get { return _effectiveDate; }
            set { _effectiveDate = value; }
        }

        /// <summary>
        ///     the value of the "DD_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        /// <summary>
        ///     the value of the "DD_STATUS" field.
        /// </summary>
        public Int32? Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "DD_FREQUENCY" field.
        /// </summary>
        public Int32? Frequency
        {
            get { return _frequency; }
            set { _frequency = value; }
        }

        /// <summary>
        ///     the value of the "DD_DAY_OF_MONTH" field.
        /// </summary>
        public Int32? DayOfMonth
        {
            get { return _dayOfMonth; }
            set { _dayOfMonth = value; }
        }

        /// <summary>
        ///     the value of the "DD_VARIABLE" field.
        /// </summary>
        public Int32? Variable
        {
            get { return _variable; }
            set { _variable = value; }
        }

        /// <summary>
        ///     the value of the "DD_MAX_VALUE" field.
        /// </summary>
        public Decimal? MaxValue
        {
            get { return _maxValue; }
            set { _maxValue = value; }
        }

        /// <summary>
        ///     the value of the "DD_CURRENCY_TYPE" field.
        /// </summary>
        public String CurrencyType
        {
            get { return _currencyType; }
            set { _currencyType = value; }
        }

        /// <summary>
        ///     the value of the "DD_BANK_NAME" field.
        /// </summary>
        public String BankName
        {
            get { return _bankName; }
            set { _bankName = value; }
        }

        /// <summary>
        ///     the value of the "DD_BANK_ADD_1" field.
        /// </summary>
        public String BankAdd1
        {
            get { return _bankAdd1; }
            set { _bankAdd1 = value; }
        }

        /// <summary>
        ///     the value of the "DD_BANK_ADD_2" field.
        /// </summary>
        public String BankAdd2
        {
            get { return _bankAdd2; }
            set { _bankAdd2 = value; }
        }

        /// <summary>
        ///     the value of the "DD_BANK_ADD_3" field.
        /// </summary>
        public String BankAdd3
        {
            get { return _bankAdd3; }
            set { _bankAdd3 = value; }
        }

        /// <summary>
        ///     the value of the "DD_BANK_ADD_4" field.
        /// </summary>
        public String BankAdd4
        {
            get { return _bankAdd4; }
            set { _bankAdd4 = value; }
        }

        /// <summary>
        ///     the value of the "DD_BANK_POSTCODE" field.
        /// </summary>
        public String BankPostcode
        {
            get { return _bankPostcode; }
            set { _bankPostcode = value; }
        }

        /// <summary>
        ///     the value of the "DD_CORE_REF" field.
        /// </summary>
        public String CoreRef
        {
            get { return _coreRef; }
            set { _coreRef = value; }
        }

        /// <summary>
        ///     the value of the "DD_BANK_ACC_NAME" field.
        /// </summary>
        public String BankAccName
        {
            get { return _bankAccName; }
            set { _bankAccName = value; }
        }

        /// <summary>
        ///     the value of the "DD_BANK_ACC_CODE" field.
        /// </summary>
        public String BankAccCode
        {
            get { return _bankAccCode; }
            set { _bankAccCode = value; }
        }

        /// <summary>
        ///     the value of the "DD_SORT_CODE" field.
        /// </summary>
        public String SortCode
        {
            get { return _sortCode; }
            set { _sortCode = value; }
        }

        /// <summary>
        ///     the value of the "DD_CCARD_TYPE" field.
        /// </summary>
        public String CcardType
        {
            get { return _ccardType; }
            set { _ccardType = value; }
        }

        /// <summary>
        ///     the value of the "DD_NAME_ON_CARD" field.
        /// </summary>
        public String NameOnCard
        {
            get { return _nameOnCard; }
            set { _nameOnCard = value; }
        }

        /// <summary>
        ///     the value of the "DD_CCARD_NUMBER" field.
        /// </summary>
        public String CcardNumber
        {
            get { return _ccardNumber; }
            set { _ccardNumber = value; }
        }

        /// <summary>
        ///     the value of the "DD_CCARD_ISSUE" field.
        /// </summary>
        public String CcardIssue
        {
            get { return _ccardIssue; }
            set { _ccardIssue = value; }
        }

        /// <summary>
        ///     the value of the "DD_CCARD_SEC_ID" field.
        /// </summary>
        public String CcardSecId
        {
            get { return _ccardSecId; }
            set { _ccardSecId = value; }
        }

        /// <summary>
        ///     the value of the "DD_CCARD_START_MTH" field.
        /// </summary>
        public String CcardStartMth
        {
            get { return _ccardStartMth; }
            set { _ccardStartMth = value; }
        }

        /// <summary>
        ///     the value of the "DD_CCARD_START_YR" field.
        /// </summary>
        public String CcardStartYr
        {
            get { return _ccardStartYr; }
            set { _ccardStartYr = value; }
        }

        /// <summary>
        ///     the value of the "DD_CCARD_EXPY_MTH" field.
        /// </summary>
        public String CcardExpyMth
        {
            get { return _ccardExpyMth; }
            set { _ccardExpyMth = value; }
        }

        /// <summary>
        ///     the value of the "DD_CCARD_EXPY_YR" field.
        /// </summary>
        public String CcardExpyYr
        {
            get { return _ccardExpyYr; }
            set { _ccardExpyYr = value; }
        }

        /// <summary>
        ///     the value of the "DD_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "DD_BANK_ORG_ID" field.
        /// </summary>
        public String BankOrgId
        {
            get { return _bankOrgId; }
            set { _bankOrgId = value; }
        }

        /// <summary>
        ///     the value of the "DD_BANK_ADD_ID" field.
        /// </summary>
        public String BankAddId
        {
            get { return _bankAddId; }
            set { _bankAddId = value; }
        }

        /// <summary>
        ///     the value of the "DD_RECORD_STATUS" field.
        /// </summary>
        public Byte RecordStatus
        {
            get { return _recordStatus; }
            set { _recordStatus = value; }
        }

        /// <summary>
        ///     the value of the "DD_BAT_ID" field.
        /// </summary>
        public String BatId
        {
            get { return _batId; }
            set { _batId = value; }
        }

        /// <summary>
        ///     the value of the "DD_TOTAL" field.
        /// </summary>
        public Decimal? Total
        {
            get { return _total; }
            set { _total = value; }
        }

        /// <summary>
        ///     the value of the "DD_STATUS_NOTES" field.
        /// </summary>
        public String StatusNotes
        {
            get { return _statusNotes; }
            set { _statusNotes = value; }
        }

        /// <summary>
        ///     the value of the "DD_STATUS_LAST_DATE" field.
        /// </summary>
        public DateTime? StatusLastDate
        {
            get { return _statusLastDate; }
            set { _statusLastDate = value; }
        }

        /// <summary>
        ///     the value of the "DD_STATUS_PREVIOUS" field.
        /// </summary>
        public Byte? StatusPrevious
        {
            get { return _statusPrevious; }
            set { _statusPrevious = value; }
        }

        /// <summary>
        ///     the value of the "DD_NO_OF_INSTALLMENTS" field.
        /// </summary>
        public Int32? NoOfInstallments
        {
            get { return _noOfInstallments; }
            set { _noOfInstallments = value; }
        }

        /// <summary>
        ///     the value of the "DD_DUE_DATE" field.
        /// </summary>
        public DateTime? DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="DirectdebitRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="DirectdebitRecord" /> object instance.
        /// </returns>
        public DirectdebitRecord Clone()
        {
            DirectdebitRecord record = new DirectdebitRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.TableNum = this.TableNum;
            record.RecId = this.RecId;
            record.Type = this.Type;
            record.Oin = this.Oin;
            record.RecDate = this.RecDate;
            record.RecMethod = this.RecMethod;
            record.ToBankDate = this.ToBankDate;
            record.EffectiveDate = this.EffectiveDate;
            record.EndDate = this.EndDate;
            record.Status = this.Status;
            record.Frequency = this.Frequency;
            record.DayOfMonth = this.DayOfMonth;
            record.Variable = this.Variable;
            record.MaxValue = this.MaxValue;
            record.CurrencyType = this.CurrencyType;
            record.BankName = this.BankName;
            record.BankAdd1 = this.BankAdd1;
            record.BankAdd2 = this.BankAdd2;
            record.BankAdd3 = this.BankAdd3;
            record.BankAdd4 = this.BankAdd4;
            record.BankPostcode = this.BankPostcode;
            record.CoreRef = this.CoreRef;
            record.BankAccName = this.BankAccName;
            record.BankAccCode = this.BankAccCode;
            record.SortCode = this.SortCode;
            record.CcardType = this.CcardType;
            record.NameOnCard = this.NameOnCard;
            record.CcardNumber = this.CcardNumber;
            record.CcardIssue = this.CcardIssue;
            record.CcardSecId = this.CcardSecId;
            record.CcardStartMth = this.CcardStartMth;
            record.CcardStartYr = this.CcardStartYr;
            record.CcardExpyMth = this.CcardExpyMth;
            record.CcardExpyYr = this.CcardExpyYr;
            record.Notes = this.Notes;
            record.BankOrgId = this.BankOrgId;
            record.BankAddId = this.BankAddId;
            record.RecordStatus = this.RecordStatus;
            record.BatId = this.BatId;
            record.Total = this.Total;
            record.StatusNotes = this.StatusNotes;
            record.StatusLastDate = this.StatusLastDate;
            record.StatusPrevious = this.StatusPrevious;
            record.NoOfInstallments = this.NoOfInstallments;
            record.DueDate = this.DueDate;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="DirectdebitRecord" /> instance is equal to another <see cref="DirectdebitRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="DirectdebitRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(DirectdebitRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.TableNum == that.TableNum);
            result = result && (this.RecId.TrimOrNullify() == that.RecId.TrimOrNullify());
            result = result && (this.Type == that.Type);
            result = result && (this.Oin.TrimOrNullify() == that.Oin.TrimOrNullify());
            result = result && (this.RecDate == that.RecDate);
            result = result && (this.RecMethod == that.RecMethod);
            result = result && (this.ToBankDate == that.ToBankDate);
            result = result && (this.EffectiveDate == that.EffectiveDate);
            result = result && (this.EndDate == that.EndDate);
            result = result && (this.Status == that.Status);
            result = result && (this.Frequency == that.Frequency);
            result = result && (this.DayOfMonth == that.DayOfMonth);
            result = result && (this.Variable == that.Variable);
            result = result && (this.MaxValue == that.MaxValue);
            result = result && (this.CurrencyType.TrimOrNullify() == that.CurrencyType.TrimOrNullify());
            result = result && (this.BankName.TrimOrNullify() == that.BankName.TrimOrNullify());
            result = result && (this.BankAdd1.TrimOrNullify() == that.BankAdd1.TrimOrNullify());
            result = result && (this.BankAdd2.TrimOrNullify() == that.BankAdd2.TrimOrNullify());
            result = result && (this.BankAdd3.TrimOrNullify() == that.BankAdd3.TrimOrNullify());
            result = result && (this.BankAdd4.TrimOrNullify() == that.BankAdd4.TrimOrNullify());
            result = result && (this.BankPostcode.TrimOrNullify() == that.BankPostcode.TrimOrNullify());
            result = result && (this.CoreRef.TrimOrNullify() == that.CoreRef.TrimOrNullify());
            result = result && (this.BankAccName.TrimOrNullify() == that.BankAccName.TrimOrNullify());
            result = result && (this.BankAccCode.TrimOrNullify() == that.BankAccCode.TrimOrNullify());
            result = result && (this.SortCode.TrimOrNullify() == that.SortCode.TrimOrNullify());
            result = result && (this.CcardType.TrimOrNullify() == that.CcardType.TrimOrNullify());
            result = result && (this.NameOnCard.TrimOrNullify() == that.NameOnCard.TrimOrNullify());
            result = result && (this.CcardNumber.TrimOrNullify() == that.CcardNumber.TrimOrNullify());
            result = result && (this.CcardIssue.TrimOrNullify() == that.CcardIssue.TrimOrNullify());
            result = result && (this.CcardSecId.TrimOrNullify() == that.CcardSecId.TrimOrNullify());
            result = result && (this.CcardStartMth.TrimOrNullify() == that.CcardStartMth.TrimOrNullify());
            result = result && (this.CcardStartYr.TrimOrNullify() == that.CcardStartYr.TrimOrNullify());
            result = result && (this.CcardExpyMth.TrimOrNullify() == that.CcardExpyMth.TrimOrNullify());
            result = result && (this.CcardExpyYr.TrimOrNullify() == that.CcardExpyYr.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.BankOrgId.TrimOrNullify() == that.BankOrgId.TrimOrNullify());
            result = result && (this.BankAddId.TrimOrNullify() == that.BankAddId.TrimOrNullify());
            result = result && (this.RecordStatus == that.RecordStatus);
            result = result && (this.BatId.TrimOrNullify() == that.BatId.TrimOrNullify());
            result = result && (this.Total == that.Total);
            result = result && (this.StatusNotes.TrimOrNullify() == that.StatusNotes.TrimOrNullify());
            result = result && (this.StatusLastDate == that.StatusLastDate);
            result = result && (this.StatusPrevious == that.StatusPrevious);
            result = result && (this.NoOfInstallments == that.NoOfInstallments);
            result = result && (this.DueDate == that.DueDate);
            return result;
        }

        #endregion
    }
}
