using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Represents the "Activity_Xref" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ActivityXrefRecord : Record<String>, Cloneable<ActivityXrefRecord>, IEquatable<ActivityXrefRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ACTXREF_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "ACTXREF_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "ACTXREF_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "ACTXREF_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "ACTXREF_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "ACTXREF_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "ACTXREF_ACT_ID" field.
        /// </summary>
        private String _actId;

        /// <summary>
        ///     the value of the "ACTXREF_PERSON_ID" field.
        /// </summary>
        private String _personId;

        /// <summary>
        ///     the value of the "ACTXREF_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "ACTXREF_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "ACTXREF_DIARY_TYPE" field.
        /// </summary>
        private Byte? _diaryType;

        /// <summary>
        ///     the value of the "ACTXREF_CLOSER" field.
        /// </summary>
        private Byte? _closer;

        /// <summary>
        ///     the value of the "ACTXREF_PASS_FROM" field.
        /// </summary>
        private Byte? _passFrom;

        /// <summary>
        ///     the value of the "ACTXREF_ORIGINATOR" field.
        /// </summary>
        private Byte? _originator;

        /// <summary>
        ///     the value of the "ACTXREF_ORG_NAME" field.
        /// </summary>
        private String _orgName;

        /// <summary>
        ///     the value of the "ACTXREF_PN_NAME" field.
        /// </summary>
        private String _pnName;

        /// <summary>
        ///     the value of the "ACTXREF_ORG_PHONE" field.
        /// </summary>
        private String _orgPhone;

        /// <summary>
        ///     the value of the "ACTXREF_PN_PHONE" field.
        /// </summary>
        private String _pnPhone;

        /// <summary>
        ///     the value of the "ACTXREF_TYPE" field.
        /// </summary>
        private Byte? _type;

        /// <summary>
        ///     the value of the "ACTXREF_READ" field.
        /// </summary>
        private Byte? _read;

        /// <summary>
        ///     the value of the "ACTXREF_TRAINER" field.
        /// </summary>
        private Byte? _trainer;

        /// <summary>
        ///     the value of the "ACTXREF_ADMIN" field.
        /// </summary>
        private Byte? _admin;

        /// <summary>
        ///     the value of the "ACTXREF_SESSION" field.
        /// </summary>
        private Byte? _session;

        /// <summary>
        ///     the value of the "ACTXREF_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "ACTXREF_TERR_ID" field.
        /// </summary>
        private String _terrId;

        /// <summary>
        ///     the value of the "ACTXREF_SCHED_ID" field.
        /// </summary>
        private String _schedId;

        /// <summary>
        ///     the value of the "ACTXREF_SL_DT_ID" field.
        /// </summary>
        private String _slDtId;

        /// <summary>
        ///     the value of the "ACTXREF_USAGE" field.
        /// </summary>
        private Byte? _usage;

        /// <summary>
        ///     the value of the "ACTXREF_QTY" field.
        /// </summary>
        private Double? _qty;

        /// <summary>
        ///     the value of the "ACTXREF_DEL_QTY" field.
        /// </summary>
        private Double? _delQty;

        /// <summary>
        ///     the value of the "ACTXREF_USERNUM_1" field.
        /// </summary>
        private Double? _usernum1;

        /// <summary>
        ///     the value of the "ACTXREF_USERDATE_1" field.
        /// </summary>
        private DateTime? _userdate1;

        /// <summary>
        ///     the value of the "ACTXREF_INTERNAL" field.
        /// </summary>
        private Byte? _internal;

        /// <summary>
        ///     the value of the "ACTXREF_HOUR_RATE" field.
        /// </summary>
        private Double? _hourRate;

        /// <summary>
        ///     the value of the "ACTXREF_DAY_RATE" field.
        /// </summary>
        private Double? _dayRate;

        /// <summary>
        ///     the value of the "ACTXREF_CURRENCY" field.
        /// </summary>
        private String _currency;

        /// <summary>
        ///     the value of the "ACTXREF_PAY_METHOD" field.
        /// </summary>
        private String _payMethod;

        /// <summary>
        ///     the value of the "ACTXREF_PO_NUMBER" field.
        /// </summary>
        private String _poNumber;

        /// <summary>
        ///     the value of the "ACTXREF_TEACH_HOUR" field.
        /// </summary>
        private Double? _teachHour;

        /// <summary>
        ///     the value of the "ACTXREF_CST_AC" field.
        /// </summary>
        private Double? _cstAc;

        /// <summary>
        ///     the value of the "ACTXREF_CST_AC_BC" field.
        /// </summary>
        private Double? _cstAcBc;

        /// <summary>
        ///     the value of the "ACTXREF_CST_AC_BC2" field.
        /// </summary>
        private Double? _cstAcBc2;

        /// <summary>
        ///     the value of the "ACTXREF_PER_DAY" field.
        /// </summary>
        private Byte? _perDay;

        /// <summary>
        ///     the value of the "ACTXREF_BAT_ID" field.
        /// </summary>
        private String _batId;

        /// <summary>
        ///     the value of the "ACTXREF_RECHARGE" field.
        /// </summary>
        private Byte? _recharge;

        /// <summary>
        ///     the value of the "ACTXREF_CANCELLED" field.
        /// </summary>
        private Byte? _cancelled;

        /// <summary>
        ///     the value of the "ACTXREF_TRAINER_T" field.
        /// </summary>
        private String _trainerT;

        /// <summary>
        ///     the value of the "ACTXREF_ADMIN_T" field.
        /// </summary>
        private String _adminT;

        /// <summary>
        ///     the value of the "ACTXREF_GUID" field.
        /// </summary>
        private String _guid;

        /// <summary>
        ///     the value of the "ACTXREF_NOTACCEPTED" field.
        /// </summary>
        private Byte? _notaccepted;

        /// <summary>
        ///     the value of the "ACTXREF_EXCL_CERT_DEL" field.
        /// </summary>
        private Byte? _exclCertDel;

        /// <summary>
        ///     the value of the "ACTXREF_REMIND_DATE" field.
        /// </summary>
        private DateTime? _remindDate;

        /// <summary>
        ///     the value of the "ACTXREF_ALLOC_STATUS" field.
        /// </summary>
        private Byte? _allocStatus;

        /// <summary>
        ///     the value of the "ACTXREF_PROF_KEY" field.
        /// </summary>
        private String _profKey;

        /// <summary>
        ///     the value of the "ACTXREF_PROF_VALUE" field.
        /// </summary>
        private String _profValue;

        /// <summary>
        ///     the value of the "ACTXREF_PROF_VALUE2" field.
        /// </summary>
        private String _profValue2;

        /// <summary>
        ///     the value of the "ACTXREF_UNT_TYPE" field.
        /// </summary>
        private String _untType;

        /// <summary>
        ///     the value of the "ACTXREF_ROOM_TYPE" field.
        /// </summary>
        private String _roomType;

        /// <summary>
        ///     the value of the "ACTXREF_INC_IN_BUDGET" field.
        /// </summary>
        private Byte _incInBudget;

        /// <summary>
        ///     the value of the "ACTXREF_PROLE_EMAIL" field.
        /// </summary>
        private String _proleEmail;

        /// <summary>
        ///     the value of the "ACTXREF_OUTLOOK_STATUS" field.
        /// </summary>
        private String _outlookStatus;

        /// <summary>
        ///     the value of the "ACTXREF_CEM_ORGANIZER" field.
        /// </summary>
        private Byte? _cemOrganizer;

        /// <summary>
        ///     the value of the "ACTXREF_OUTLOOK_ID" field.
        /// </summary>
        private String _outlookId;

        /// <summary>
        ///     the value of the "ACTXREF_DELETE" field.
        /// </summary>
        private Byte _delete;

        /// <summary>
        ///     the value of the "ACTXREF_BOM_ID" field.
        /// </summary>
        private String _bomId;

        /// <summary>
        ///     the value of the "ACTXREF_PROD_NAME" field.
        /// </summary>
        private String _prodName;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ACTXREF_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_ACT_ID" field.
        /// </summary>
        public String ActId
        {
            get { return _actId; }
            set { _actId = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_PERSON_ID" field.
        /// </summary>
        public String PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_DIARY_TYPE" field.
        /// </summary>
        public Byte? DiaryType
        {
            get { return _diaryType; }
            set { _diaryType = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_CLOSER" field.
        /// </summary>
        public Byte? Closer
        {
            get { return _closer; }
            set { _closer = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_PASS_FROM" field.
        /// </summary>
        public Byte? PassFrom
        {
            get { return _passFrom; }
            set { _passFrom = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_ORIGINATOR" field.
        /// </summary>
        public Byte? Originator
        {
            get { return _originator; }
            set { _originator = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_ORG_NAME" field.
        /// </summary>
        public String OrgName
        {
            get { return _orgName; }
            set { _orgName = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_PN_NAME" field.
        /// </summary>
        public String PnName
        {
            get { return _pnName; }
            set { _pnName = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_ORG_PHONE" field.
        /// </summary>
        public String OrgPhone
        {
            get { return _orgPhone; }
            set { _orgPhone = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_PN_PHONE" field.
        /// </summary>
        public String PnPhone
        {
            get { return _pnPhone; }
            set { _pnPhone = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_READ" field.
        /// </summary>
        public Byte? Read
        {
            get { return _read; }
            set { _read = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_TRAINER" field.
        /// </summary>
        public Byte? Trainer
        {
            get { return _trainer; }
            set { _trainer = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_ADMIN" field.
        /// </summary>
        public Byte? Admin
        {
            get { return _admin; }
            set { _admin = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_SESSION" field.
        /// </summary>
        public Byte? Session
        {
            get { return _session; }
            set { _session = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_TERR_ID" field.
        /// </summary>
        public String TerrId
        {
            get { return _terrId; }
            set { _terrId = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_SCHED_ID" field.
        /// </summary>
        public String SchedId
        {
            get { return _schedId; }
            set { _schedId = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_SL_DT_ID" field.
        /// </summary>
        public String SlDtId
        {
            get { return _slDtId; }
            set { _slDtId = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_USAGE" field.
        /// </summary>
        public Byte? Usage
        {
            get { return _usage; }
            set { _usage = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_QTY" field.
        /// </summary>
        public Double? Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_DEL_QTY" field.
        /// </summary>
        public Double? DelQty
        {
            get { return _delQty; }
            set { _delQty = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_USERNUM_1" field.
        /// </summary>
        public Double? Usernum1
        {
            get { return _usernum1; }
            set { _usernum1 = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_USERDATE_1" field.
        /// </summary>
        public DateTime? Userdate1
        {
            get { return _userdate1; }
            set { _userdate1 = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_INTERNAL" field.
        /// </summary>
        public Byte? Internal
        {
            get { return _internal; }
            set { _internal = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_HOUR_RATE" field.
        /// </summary>
        public Double? HourRate
        {
            get { return _hourRate; }
            set { _hourRate = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_DAY_RATE" field.
        /// </summary>
        public Double? DayRate
        {
            get { return _dayRate; }
            set { _dayRate = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_CURRENCY" field.
        /// </summary>
        public String Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_PAY_METHOD" field.
        /// </summary>
        public String PayMethod
        {
            get { return _payMethod; }
            set { _payMethod = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_PO_NUMBER" field.
        /// </summary>
        public String PoNumber
        {
            get { return _poNumber; }
            set { _poNumber = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_TEACH_HOUR" field.
        /// </summary>
        public Double? TeachHour
        {
            get { return _teachHour; }
            set { _teachHour = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_CST_AC" field.
        /// </summary>
        public Double? CstAc
        {
            get { return _cstAc; }
            set { _cstAc = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_CST_AC_BC" field.
        /// </summary>
        public Double? CstAcBc
        {
            get { return _cstAcBc; }
            set { _cstAcBc = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_CST_AC_BC2" field.
        /// </summary>
        public Double? CstAcBc2
        {
            get { return _cstAcBc2; }
            set { _cstAcBc2 = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_PER_DAY" field.
        /// </summary>
        public Byte? PerDay
        {
            get { return _perDay; }
            set { _perDay = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_BAT_ID" field.
        /// </summary>
        public String BatId
        {
            get { return _batId; }
            set { _batId = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_RECHARGE" field.
        /// </summary>
        public Byte? Recharge
        {
            get { return _recharge; }
            set { _recharge = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_CANCELLED" field.
        /// </summary>
        public Byte? Cancelled
        {
            get { return _cancelled; }
            set { _cancelled = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_TRAINER_T" field.
        /// </summary>
        public String TrainerT
        {
            get { return _trainerT; }
            set { _trainerT = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_ADMIN_T" field.
        /// </summary>
        public String AdminT
        {
            get { return _adminT; }
            set { _adminT = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_GUID" field.
        /// </summary>
        public String Guid
        {
            get { return _guid; }
            set { _guid = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_NOTACCEPTED" field.
        /// </summary>
        public Byte? Notaccepted
        {
            get { return _notaccepted; }
            set { _notaccepted = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_EXCL_CERT_DEL" field.
        /// </summary>
        public Byte? ExclCertDel
        {
            get { return _exclCertDel; }
            set { _exclCertDel = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_REMIND_DATE" field.
        /// </summary>
        public DateTime? RemindDate
        {
            get { return _remindDate; }
            set { _remindDate = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_ALLOC_STATUS" field.
        /// </summary>
        public Byte? AllocStatus
        {
            get { return _allocStatus; }
            set { _allocStatus = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_PROF_KEY" field.
        /// </summary>
        public String ProfKey
        {
            get { return _profKey; }
            set { _profKey = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_PROF_VALUE" field.
        /// </summary>
        public String ProfValue
        {
            get { return _profValue; }
            set { _profValue = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_PROF_VALUE2" field.
        /// </summary>
        public String ProfValue2
        {
            get { return _profValue2; }
            set { _profValue2 = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_UNT_TYPE" field.
        /// </summary>
        public String UntType
        {
            get { return _untType; }
            set { _untType = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_ROOM_TYPE" field.
        /// </summary>
        public String RoomType
        {
            get { return _roomType; }
            set { _roomType = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_INC_IN_BUDGET" field.
        /// </summary>
        public Byte IncInBudget
        {
            get { return _incInBudget; }
            set { _incInBudget = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_PROLE_EMAIL" field.
        /// </summary>
        public String ProleEmail
        {
            get { return _proleEmail; }
            set { _proleEmail = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_OUTLOOK_STATUS" field.
        /// </summary>
        public String OutlookStatus
        {
            get { return _outlookStatus; }
            set { _outlookStatus = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_CEM_ORGANIZER" field.
        /// </summary>
        public Byte? CemOrganizer
        {
            get { return _cemOrganizer; }
            set { _cemOrganizer = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_OUTLOOK_ID" field.
        /// </summary>
        public String OutlookId
        {
            get { return _outlookId; }
            set { _outlookId = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_DELETE" field.
        /// </summary>
        public Byte Delete
        {
            get { return _delete; }
            set { _delete = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_BOM_ID" field.
        /// </summary>
        public String BomId
        {
            get { return _bomId; }
            set { _bomId = value; }
        }

        /// <summary>
        ///     the value of the "ACTXREF_PROD_NAME" field.
        /// </summary>
        public String ProdName
        {
            get { return _prodName; }
            set { _prodName = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ActivityXrefRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ActivityXrefRecord" /> object instance.
        /// </returns>
        public ActivityXrefRecord Clone()
        {
            ActivityXrefRecord record = new ActivityXrefRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.ActId = this.ActId;
            record.PersonId = this.PersonId;
            record.OrgId = this.OrgId;
            record.ProleId = this.ProleId;
            record.DiaryType = this.DiaryType;
            record.Closer = this.Closer;
            record.PassFrom = this.PassFrom;
            record.Originator = this.Originator;
            record.OrgName = this.OrgName;
            record.PnName = this.PnName;
            record.OrgPhone = this.OrgPhone;
            record.PnPhone = this.PnPhone;
            record.Type = this.Type;
            record.Read = this.Read;
            record.Trainer = this.Trainer;
            record.Admin = this.Admin;
            record.Session = this.Session;
            record.ProdId = this.ProdId;
            record.TerrId = this.TerrId;
            record.SchedId = this.SchedId;
            record.SlDtId = this.SlDtId;
            record.Usage = this.Usage;
            record.Qty = this.Qty;
            record.DelQty = this.DelQty;
            record.Usernum1 = this.Usernum1;
            record.Userdate1 = this.Userdate1;
            record.Internal = this.Internal;
            record.HourRate = this.HourRate;
            record.DayRate = this.DayRate;
            record.Currency = this.Currency;
            record.PayMethod = this.PayMethod;
            record.PoNumber = this.PoNumber;
            record.TeachHour = this.TeachHour;
            record.CstAc = this.CstAc;
            record.CstAcBc = this.CstAcBc;
            record.CstAcBc2 = this.CstAcBc2;
            record.PerDay = this.PerDay;
            record.BatId = this.BatId;
            record.Recharge = this.Recharge;
            record.Cancelled = this.Cancelled;
            record.TrainerT = this.TrainerT;
            record.AdminT = this.AdminT;
            record.Guid = this.Guid;
            record.Notaccepted = this.Notaccepted;
            record.ExclCertDel = this.ExclCertDel;
            record.RemindDate = this.RemindDate;
            record.AllocStatus = this.AllocStatus;
            record.ProfKey = this.ProfKey;
            record.ProfValue = this.ProfValue;
            record.ProfValue2 = this.ProfValue2;
            record.UntType = this.UntType;
            record.RoomType = this.RoomType;
            record.IncInBudget = this.IncInBudget;
            record.ProleEmail = this.ProleEmail;
            record.OutlookStatus = this.OutlookStatus;
            record.CemOrganizer = this.CemOrganizer;
            record.OutlookId = this.OutlookId;
            record.Delete = this.Delete;
            record.BomId = this.BomId;
            record.ProdName = this.ProdName;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ActivityXrefRecord" /> instance is equal to another <see cref="ActivityXrefRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ActivityXrefRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ActivityXrefRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.ActId.TrimOrNullify() == that.ActId.TrimOrNullify());
            result = result && (this.PersonId.TrimOrNullify() == that.PersonId.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.DiaryType == that.DiaryType);
            result = result && (this.Closer == that.Closer);
            result = result && (this.PassFrom == that.PassFrom);
            result = result && (this.Originator == that.Originator);
            result = result && (this.OrgName.TrimOrNullify() == that.OrgName.TrimOrNullify());
            result = result && (this.PnName.TrimOrNullify() == that.PnName.TrimOrNullify());
            result = result && (this.OrgPhone.TrimOrNullify() == that.OrgPhone.TrimOrNullify());
            result = result && (this.PnPhone.TrimOrNullify() == that.PnPhone.TrimOrNullify());
            result = result && (this.Type == that.Type);
            result = result && (this.Read == that.Read);
            result = result && (this.Trainer == that.Trainer);
            result = result && (this.Admin == that.Admin);
            result = result && (this.Session == that.Session);
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.TerrId.TrimOrNullify() == that.TerrId.TrimOrNullify());
            result = result && (this.SchedId.TrimOrNullify() == that.SchedId.TrimOrNullify());
            result = result && (this.SlDtId.TrimOrNullify() == that.SlDtId.TrimOrNullify());
            result = result && (this.Usage == that.Usage);
            result = result && (this.Qty == that.Qty);
            result = result && (this.DelQty == that.DelQty);
            result = result && (this.Usernum1 == that.Usernum1);
            result = result && (this.Userdate1 == that.Userdate1);
            result = result && (this.Internal == that.Internal);
            result = result && (this.HourRate == that.HourRate);
            result = result && (this.DayRate == that.DayRate);
            result = result && (this.Currency.TrimOrNullify() == that.Currency.TrimOrNullify());
            result = result && (this.PayMethod.TrimOrNullify() == that.PayMethod.TrimOrNullify());
            result = result && (this.PoNumber.TrimOrNullify() == that.PoNumber.TrimOrNullify());
            result = result && (this.TeachHour == that.TeachHour);
            result = result && (this.CstAc == that.CstAc);
            result = result && (this.CstAcBc == that.CstAcBc);
            result = result && (this.CstAcBc2 == that.CstAcBc2);
            result = result && (this.PerDay == that.PerDay);
            result = result && (this.BatId.TrimOrNullify() == that.BatId.TrimOrNullify());
            result = result && (this.Recharge == that.Recharge);
            result = result && (this.Cancelled == that.Cancelled);
            result = result && (this.TrainerT.TrimOrNullify() == that.TrainerT.TrimOrNullify());
            result = result && (this.AdminT.TrimOrNullify() == that.AdminT.TrimOrNullify());
            result = result && (this.Guid.TrimOrNullify() == that.Guid.TrimOrNullify());
            result = result && (this.Notaccepted == that.Notaccepted);
            result = result && (this.ExclCertDel == that.ExclCertDel);
            result = result && (this.RemindDate == that.RemindDate);
            result = result && (this.AllocStatus == that.AllocStatus);
            result = result && (this.ProfKey.TrimOrNullify() == that.ProfKey.TrimOrNullify());
            result = result && (this.ProfValue.TrimOrNullify() == that.ProfValue.TrimOrNullify());
            result = result && (this.ProfValue2.TrimOrNullify() == that.ProfValue2.TrimOrNullify());
            result = result && (this.UntType.TrimOrNullify() == that.UntType.TrimOrNullify());
            result = result && (this.RoomType.TrimOrNullify() == that.RoomType.TrimOrNullify());
            result = result && (this.IncInBudget == that.IncInBudget);
            result = result && (this.ProleEmail.TrimOrNullify() == that.ProleEmail.TrimOrNullify());
            result = result && (this.OutlookStatus.TrimOrNullify() == that.OutlookStatus.TrimOrNullify());
            result = result && (this.CemOrganizer == that.CemOrganizer);
            result = result && (this.OutlookId.TrimOrNullify() == that.OutlookId.TrimOrNullify());
            result = result && (this.Delete == that.Delete);
            result = result && (this.BomId.TrimOrNullify() == that.BomId.TrimOrNullify());
            result = result && (this.ProdName.TrimOrNullify() == that.ProdName.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
