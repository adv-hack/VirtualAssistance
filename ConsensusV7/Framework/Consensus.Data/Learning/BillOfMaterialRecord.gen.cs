using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Represents the "Bill_Of_Material" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class BillOfMaterialRecord : Record<String>, Cloneable<BillOfMaterialRecord>, IEquatable<BillOfMaterialRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "BOM_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "BOM_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "BOM_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "BOM_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "BOM_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "BOM_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "BOM_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "BOM_PARENT_ID" field.
        /// </summary>
        private String _parentId;

        /// <summary>
        ///     the value of the "BOM_SYLLABUS_ID" field.
        /// </summary>
        private String _syllabusId;

        /// <summary>
        ///     the value of the "BOM_LOCATION_ID" field.
        /// </summary>
        private String _locationId;

        /// <summary>
        ///     the value of the "BOM_RESOURCE_ID" field.
        /// </summary>
        private String _resourceId;

        /// <summary>
        ///     the value of the "BOM_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "BOM_REAL" field.
        /// </summary>
        private Byte? _real;

        /// <summary>
        ///     the value of the "BOM_SESSION" field.
        /// </summary>
        private Byte? _session;

        /// <summary>
        ///     the value of the "BOM_ELEMENT" field.
        /// </summary>
        private Byte? _element;

        /// <summary>
        ///     the value of the "BOM_START_DAY" field.
        /// </summary>
        private Double? _startDay;

        /// <summary>
        ///     the value of the "BOM_END_DAY" field.
        /// </summary>
        private Double? _endDay;

        /// <summary>
        ///     the value of the "BOM_START_TIME" field.
        /// </summary>
        private DateTime? _startTime;

        /// <summary>
        ///     the value of the "BOM_END_TIME" field.
        /// </summary>
        private DateTime? _endTime;

        /// <summary>
        ///     the value of the "BOM_QUANTITY" field.
        /// </summary>
        private Double? _quantity;

        /// <summary>
        ///     the value of the "BOM_MANDATORY" field.
        /// </summary>
        private Byte? _mandatory;

        /// <summary>
        ///     the value of the "BOM_STREAM" field.
        /// </summary>
        private String _stream;

        /// <summary>
        ///     the value of the "BOM_CHARGEABLE" field.
        /// </summary>
        private Byte? _chargeable;

        /// <summary>
        ///     the value of the "BOM_INVOICE_PRINT" field.
        /// </summary>
        private Byte? _invoicePrint;

        /// <summary>
        ///     the value of the "BOM_ACT_TYPE" field.
        /// </summary>
        private String _actType;

        /// <summary>
        ///     the value of the "BOM_SHOW_SALES" field.
        /// </summary>
        private Byte? _showSales;

        /// <summary>
        ///     the value of the "BOM_ACT_NOTE" field.
        /// </summary>
        private String _actNote;

        /// <summary>
        ///     the value of the "BOM_SUBJECT" field.
        /// </summary>
        private String _subject;

        /// <summary>
        ///     the value of the "BOM_VAL_TO_REV" field.
        /// </summary>
        private Double? _valToRev;

        /// <summary>
        ///     the value of the "BOM_MAIN_SESSION" field.
        /// </summary>
        private Byte? _mainSession;

        /// <summary>
        ///     the value of the "BOM_TYPE_SUB" field.
        /// </summary>
        private String _typeSub;

        /// <summary>
        ///     the value of the "BOM_ROOM_LAYOUT" field.
        /// </summary>
        private Int32? _roomLayout;

        /// <summary>
        ///     the value of the "BOM_INC_IN_BUDGET" field.
        /// </summary>
        private Byte _incInBudget;

        /// <summary>
        ///     the value of the "BOM_TEACH_HRS" field.
        /// </summary>
        private Decimal? _teachHrs;

        /// <summary>
        ///     the value of the "BOM_STUD_WKS" field.
        /// </summary>
        private Decimal? _studWks;

        /// <summary>
        ///     the value of the "BOM_NOTINUSE_START" field.
        /// </summary>
        private Int32? _notinuseStart;

        /// <summary>
        ///     the value of the "BOM_NOTINUSE_END" field.
        /// </summary>
        private Int32? _notinuseEnd;

        /// <summary>
        ///     the value of the "BOM_ACT_SESSION_NAME" field.
        /// </summary>
        private String _actSessionName;

        /// <summary>
        ///     the value of the "BOM_NO_SLOTS" field.
        /// </summary>
        private Int32? _noSlots;

        /// <summary>
        ///     the value of the "BOM_START_SLOT" field.
        /// </summary>
        private Int32? _startSlot;

        /// <summary>
        ///     the value of the "BOM_PREDELIV" field.
        /// </summary>
        private Byte _predeliv;

        /// <summary>
        ///     the value of the "BOM_CODE" field.
        /// </summary>
        private String _code;

        /// <summary>
        ///     the value of the "BOM_PROV_PACK" field.
        /// </summary>
        private String _provPack;

        /// <summary>
        ///     the value of the "BOM_CONF_PACK" field.
        /// </summary>
        private String _confPack;

        /// <summary>
        ///     the value of the "BOM_JOINING_PACK" field.
        /// </summary>
        private String _joiningPack;

        /// <summary>
        ///     the value of the "BOM_POST_PACK" field.
        /// </summary>
        private String _postPack;

        /// <summary>
        ///     the value of the "BOM_PROV_SEND_TO_BOOK" field.
        /// </summary>
        private Byte _provSendToBook;

        /// <summary>
        ///     the value of the "BOM_PROV_SEND_TO_DEL" field.
        /// </summary>
        private Byte _provSendToDel;

        /// <summary>
        ///     the value of the "BOM_CONF_SEND_TO_BOOK" field.
        /// </summary>
        private Byte _confSendToBook;

        /// <summary>
        ///     the value of the "BOM_CONF_SEND_TO_DEL" field.
        /// </summary>
        private Byte _confSendToDel;

        /// <summary>
        ///     the value of the "BOM_JOINING_SEND_TO_BOOK" field.
        /// </summary>
        private Byte _joiningSendToBook;

        /// <summary>
        ///     the value of the "BOM_JOINING_SEND_TO_DEL" field.
        /// </summary>
        private Byte _joiningSendToDel;

        /// <summary>
        ///     the value of the "BOM_POST_SEND_TO_BOOK" field.
        /// </summary>
        private Byte _postSendToBook;

        /// <summary>
        ///     the value of the "BOM_POST_SEND_TO_DEL" field.
        /// </summary>
        private Byte _postSendToDel;

        /// <summary>
        ///     the value of the "BOM_PSG_ID" field.
        /// </summary>
        private Int32? _productSelectGroup;

        /// <summary>
        ///     the value of the "BOM_ACT_REVENUE_SPLIT" field.
        /// </summary>
        private Double _actRevenueSplit;

        /// <summary>
        ///     the value of the "BOM_ACT_HOURS_SPLIT" field.
        /// </summary>
        private Double _actHoursSplit;

        /// <summary>
        ///     the value of the "BOM_EXP_OCCUPANCY" field.
        /// </summary>
        private Int32? _expOccupancy;

        /// <summary>
        ///     the value of the "BOM_SHOW_ATT_LOG" field.
        /// </summary>
        private Byte? _showAttLog;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "BOM_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "BOM_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "BOM_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "BOM_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "BOM_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "BOM_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "BOM_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "BOM_PARENT_ID" field.
        /// </summary>
        public String ParentId
        {
            get { return _parentId; }
            set { _parentId = value; }
        }

        /// <summary>
        ///     the value of the "BOM_SYLLABUS_ID" field.
        /// </summary>
        public String SyllabusId
        {
            get { return _syllabusId; }
            set { _syllabusId = value; }
        }

        /// <summary>
        ///     the value of the "BOM_LOCATION_ID" field.
        /// </summary>
        public String LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>
        ///     the value of the "BOM_RESOURCE_ID" field.
        /// </summary>
        public String ResourceId
        {
            get { return _resourceId; }
            set { _resourceId = value; }
        }

        /// <summary>
        ///     the value of the "BOM_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "BOM_REAL" field.
        /// </summary>
        public Byte? Real
        {
            get { return _real; }
            set { _real = value; }
        }

        /// <summary>
        ///     the value of the "BOM_SESSION" field.
        /// </summary>
        public Byte? Session
        {
            get { return _session; }
            set { _session = value; }
        }

        /// <summary>
        ///     the value of the "BOM_ELEMENT" field.
        /// </summary>
        public Byte? Element
        {
            get { return _element; }
            set { _element = value; }
        }

        /// <summary>
        ///     the value of the "BOM_START_DAY" field.
        /// </summary>
        public Double? StartDay
        {
            get { return _startDay; }
            set { _startDay = value; }
        }

        /// <summary>
        ///     the value of the "BOM_END_DAY" field.
        /// </summary>
        public Double? EndDay
        {
            get { return _endDay; }
            set { _endDay = value; }
        }

        /// <summary>
        ///     the value of the "BOM_START_TIME" field.
        /// </summary>
        public DateTime? StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        /// <summary>
        ///     the value of the "BOM_END_TIME" field.
        /// </summary>
        public DateTime? EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        /// <summary>
        ///     the value of the "BOM_QUANTITY" field.
        /// </summary>
        public Double? Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        /// <summary>
        ///     the value of the "BOM_MANDATORY" field.
        /// </summary>
        public Byte? Mandatory
        {
            get { return _mandatory; }
            set { _mandatory = value; }
        }

        /// <summary>
        ///     the value of the "BOM_STREAM" field.
        /// </summary>
        public String Stream
        {
            get { return _stream; }
            set { _stream = value; }
        }

        /// <summary>
        ///     the value of the "BOM_CHARGEABLE" field.
        /// </summary>
        public Byte? Chargeable
        {
            get { return _chargeable; }
            set { _chargeable = value; }
        }

        /// <summary>
        ///     the value of the "BOM_INVOICE_PRINT" field.
        /// </summary>
        public Byte? InvoicePrint
        {
            get { return _invoicePrint; }
            set { _invoicePrint = value; }
        }

        /// <summary>
        ///     the value of the "BOM_ACT_TYPE" field.
        /// </summary>
        public String ActType
        {
            get { return _actType; }
            set { _actType = value; }
        }

        /// <summary>
        ///     the value of the "BOM_SHOW_SALES" field.
        /// </summary>
        public Byte? ShowSales
        {
            get { return _showSales; }
            set { _showSales = value; }
        }

        /// <summary>
        ///     the value of the "BOM_ACT_NOTE" field.
        /// </summary>
        public String ActNote
        {
            get { return _actNote; }
            set { _actNote = value; }
        }

        /// <summary>
        ///     the value of the "BOM_SUBJECT" field.
        /// </summary>
        public String Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        /// <summary>
        ///     the value of the "BOM_VAL_TO_REV" field.
        /// </summary>
        public Double? ValToRev
        {
            get { return _valToRev; }
            set { _valToRev = value; }
        }

        /// <summary>
        ///     the value of the "BOM_MAIN_SESSION" field.
        /// </summary>
        public Byte? MainSession
        {
            get { return _mainSession; }
            set { _mainSession = value; }
        }

        /// <summary>
        ///     the value of the "BOM_TYPE_SUB" field.
        /// </summary>
        public String TypeSub
        {
            get { return _typeSub; }
            set { _typeSub = value; }
        }

        /// <summary>
        ///     the value of the "BOM_ROOM_LAYOUT" field.
        /// </summary>
        public Int32? RoomLayout
        {
            get { return _roomLayout; }
            set { _roomLayout = value; }
        }

        /// <summary>
        ///     the value of the "BOM_INC_IN_BUDGET" field.
        /// </summary>
        public Byte IncInBudget
        {
            get { return _incInBudget; }
            set { _incInBudget = value; }
        }

        /// <summary>
        ///     the value of the "BOM_TEACH_HRS" field.
        /// </summary>
        public Decimal? TeachHrs
        {
            get { return _teachHrs; }
            set { _teachHrs = value; }
        }

        /// <summary>
        ///     the value of the "BOM_STUD_WKS" field.
        /// </summary>
        public Decimal? StudWks
        {
            get { return _studWks; }
            set { _studWks = value; }
        }

        /// <summary>
        ///     the value of the "BOM_NOTINUSE_START" field.
        /// </summary>
        public Int32? NotinuseStart
        {
            get { return _notinuseStart; }
            set { _notinuseStart = value; }
        }

        /// <summary>
        ///     the value of the "BOM_NOTINUSE_END" field.
        /// </summary>
        public Int32? NotinuseEnd
        {
            get { return _notinuseEnd; }
            set { _notinuseEnd = value; }
        }

        /// <summary>
        ///     the value of the "BOM_ACT_SESSION_NAME" field.
        /// </summary>
        public String ActSessionName
        {
            get { return _actSessionName; }
            set { _actSessionName = value; }
        }

        /// <summary>
        ///     the value of the "BOM_NO_SLOTS" field.
        /// </summary>
        public Int32? NoSlots
        {
            get { return _noSlots; }
            set { _noSlots = value; }
        }

        /// <summary>
        ///     the value of the "BOM_START_SLOT" field.
        /// </summary>
        public Int32? StartSlot
        {
            get { return _startSlot; }
            set { _startSlot = value; }
        }

        /// <summary>
        ///     the value of the "BOM_PREDELIV" field.
        /// </summary>
        public Byte Predeliv
        {
            get { return _predeliv; }
            set { _predeliv = value; }
        }

        /// <summary>
        ///     the value of the "BOM_CODE" field.
        /// </summary>
        public String Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        ///     the value of the "BOM_PROV_PACK" field.
        /// </summary>
        public String ProvPack
        {
            get { return _provPack; }
            set { _provPack = value; }
        }

        /// <summary>
        ///     the value of the "BOM_CONF_PACK" field.
        /// </summary>
        public String ConfPack
        {
            get { return _confPack; }
            set { _confPack = value; }
        }

        /// <summary>
        ///     the value of the "BOM_JOINING_PACK" field.
        /// </summary>
        public String JoiningPack
        {
            get { return _joiningPack; }
            set { _joiningPack = value; }
        }

        /// <summary>
        ///     the value of the "BOM_POST_PACK" field.
        /// </summary>
        public String PostPack
        {
            get { return _postPack; }
            set { _postPack = value; }
        }

        /// <summary>
        ///     the value of the "BOM_PROV_SEND_TO_BOOK" field.
        /// </summary>
        public Byte ProvSendToBook
        {
            get { return _provSendToBook; }
            set { _provSendToBook = value; }
        }

        /// <summary>
        ///     the value of the "BOM_PROV_SEND_TO_DEL" field.
        /// </summary>
        public Byte ProvSendToDel
        {
            get { return _provSendToDel; }
            set { _provSendToDel = value; }
        }

        /// <summary>
        ///     the value of the "BOM_CONF_SEND_TO_BOOK" field.
        /// </summary>
        public Byte ConfSendToBook
        {
            get { return _confSendToBook; }
            set { _confSendToBook = value; }
        }

        /// <summary>
        ///     the value of the "BOM_CONF_SEND_TO_DEL" field.
        /// </summary>
        public Byte ConfSendToDel
        {
            get { return _confSendToDel; }
            set { _confSendToDel = value; }
        }

        /// <summary>
        ///     the value of the "BOM_JOINING_SEND_TO_BOOK" field.
        /// </summary>
        public Byte JoiningSendToBook
        {
            get { return _joiningSendToBook; }
            set { _joiningSendToBook = value; }
        }

        /// <summary>
        ///     the value of the "BOM_JOINING_SEND_TO_DEL" field.
        /// </summary>
        public Byte JoiningSendToDel
        {
            get { return _joiningSendToDel; }
            set { _joiningSendToDel = value; }
        }

        /// <summary>
        ///     the value of the "BOM_POST_SEND_TO_BOOK" field.
        /// </summary>
        public Byte PostSendToBook
        {
            get { return _postSendToBook; }
            set { _postSendToBook = value; }
        }

        /// <summary>
        ///     the value of the "BOM_POST_SEND_TO_DEL" field.
        /// </summary>
        public Byte PostSendToDel
        {
            get { return _postSendToDel; }
            set { _postSendToDel = value; }
        }

        /// <summary>
        ///     the value of the "BOM_PSG_ID" field.
        /// </summary>
        public Int32? ProductSelectGroup
        {
            get { return _productSelectGroup; }
            set { _productSelectGroup = value; }
        }

        /// <summary>
        ///     the value of the "BOM_ACT_REVENUE_SPLIT" field.
        /// </summary>
        public Double ActRevenueSplit
        {
            get { return _actRevenueSplit; }
            set { _actRevenueSplit = value; }
        }

        /// <summary>
        ///     the value of the "BOM_ACT_HOURS_SPLIT" field.
        /// </summary>
        public Double ActHoursSplit
        {
            get { return _actHoursSplit; }
            set { _actHoursSplit = value; }
        }

        /// <summary>
        ///     the value of the "BOM_EXP_OCCUPANCY" field.
        /// </summary>
        public Int32? ExpOccupancy
        {
            get { return _expOccupancy; }
            set { _expOccupancy = value; }
        }

        /// <summary>
        ///     the value of the "BOM_SHOW_ATT_LOG" field.
        /// </summary>
        public Byte? ShowAttLog
        {
            get { return _showAttLog; }
            set { _showAttLog = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="BillOfMaterialRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="BillOfMaterialRecord" /> object instance.
        /// </returns>
        public BillOfMaterialRecord Clone()
        {
            BillOfMaterialRecord record = new BillOfMaterialRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.ParentId = this.ParentId;
            record.SyllabusId = this.SyllabusId;
            record.LocationId = this.LocationId;
            record.ResourceId = this.ResourceId;
            record.Type = this.Type;
            record.Real = this.Real;
            record.Session = this.Session;
            record.Element = this.Element;
            record.StartDay = this.StartDay;
            record.EndDay = this.EndDay;
            record.StartTime = this.StartTime;
            record.EndTime = this.EndTime;
            record.Quantity = this.Quantity;
            record.Mandatory = this.Mandatory;
            record.Stream = this.Stream;
            record.Chargeable = this.Chargeable;
            record.InvoicePrint = this.InvoicePrint;
            record.ActType = this.ActType;
            record.ShowSales = this.ShowSales;
            record.ActNote = this.ActNote;
            record.Subject = this.Subject;
            record.ValToRev = this.ValToRev;
            record.MainSession = this.MainSession;
            record.TypeSub = this.TypeSub;
            record.RoomLayout = this.RoomLayout;
            record.IncInBudget = this.IncInBudget;
            record.TeachHrs = this.TeachHrs;
            record.StudWks = this.StudWks;
            record.NotinuseStart = this.NotinuseStart;
            record.NotinuseEnd = this.NotinuseEnd;
            record.ActSessionName = this.ActSessionName;
            record.NoSlots = this.NoSlots;
            record.StartSlot = this.StartSlot;
            record.Predeliv = this.Predeliv;
            record.Code = this.Code;
            record.ProvPack = this.ProvPack;
            record.ConfPack = this.ConfPack;
            record.JoiningPack = this.JoiningPack;
            record.PostPack = this.PostPack;
            record.ProvSendToBook = this.ProvSendToBook;
            record.ProvSendToDel = this.ProvSendToDel;
            record.ConfSendToBook = this.ConfSendToBook;
            record.ConfSendToDel = this.ConfSendToDel;
            record.JoiningSendToBook = this.JoiningSendToBook;
            record.JoiningSendToDel = this.JoiningSendToDel;
            record.PostSendToBook = this.PostSendToBook;
            record.PostSendToDel = this.PostSendToDel;
            record.ProductSelectGroup = this.ProductSelectGroup;
            record.ActRevenueSplit = this.ActRevenueSplit;
            record.ActHoursSplit = this.ActHoursSplit;
            record.ExpOccupancy = this.ExpOccupancy;
            record.ShowAttLog = this.ShowAttLog;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="BillOfMaterialRecord" /> instance is equal to another <see cref="BillOfMaterialRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="BillOfMaterialRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(BillOfMaterialRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.ParentId.TrimOrNullify() == that.ParentId.TrimOrNullify());
            result = result && (this.SyllabusId.TrimOrNullify() == that.SyllabusId.TrimOrNullify());
            result = result && (this.LocationId.TrimOrNullify() == that.LocationId.TrimOrNullify());
            result = result && (this.ResourceId.TrimOrNullify() == that.ResourceId.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.Real == that.Real);
            result = result && (this.Session == that.Session);
            result = result && (this.Element == that.Element);
            result = result && (this.StartDay == that.StartDay);
            result = result && (this.EndDay == that.EndDay);
            result = result && (this.StartTime == that.StartTime);
            result = result && (this.EndTime == that.EndTime);
            result = result && (this.Quantity == that.Quantity);
            result = result && (this.Mandatory == that.Mandatory);
            result = result && (this.Stream.TrimOrNullify() == that.Stream.TrimOrNullify());
            result = result && (this.Chargeable == that.Chargeable);
            result = result && (this.InvoicePrint == that.InvoicePrint);
            result = result && (this.ActType.TrimOrNullify() == that.ActType.TrimOrNullify());
            result = result && (this.ShowSales == that.ShowSales);
            result = result && (this.ActNote.TrimOrNullify() == that.ActNote.TrimOrNullify());
            result = result && (this.Subject.TrimOrNullify() == that.Subject.TrimOrNullify());
            result = result && (this.ValToRev == that.ValToRev);
            result = result && (this.MainSession == that.MainSession);
            result = result && (this.TypeSub.TrimOrNullify() == that.TypeSub.TrimOrNullify());
            result = result && (this.RoomLayout == that.RoomLayout);
            result = result && (this.IncInBudget == that.IncInBudget);
            result = result && (this.TeachHrs == that.TeachHrs);
            result = result && (this.StudWks == that.StudWks);
            result = result && (this.NotinuseStart == that.NotinuseStart);
            result = result && (this.NotinuseEnd == that.NotinuseEnd);
            result = result && (this.ActSessionName.TrimOrNullify() == that.ActSessionName.TrimOrNullify());
            result = result && (this.NoSlots == that.NoSlots);
            result = result && (this.StartSlot == that.StartSlot);
            result = result && (this.Predeliv == that.Predeliv);
            result = result && (this.Code.TrimOrNullify() == that.Code.TrimOrNullify());
            result = result && (this.ProvPack.TrimOrNullify() == that.ProvPack.TrimOrNullify());
            result = result && (this.ConfPack.TrimOrNullify() == that.ConfPack.TrimOrNullify());
            result = result && (this.JoiningPack.TrimOrNullify() == that.JoiningPack.TrimOrNullify());
            result = result && (this.PostPack.TrimOrNullify() == that.PostPack.TrimOrNullify());
            result = result && (this.ProvSendToBook == that.ProvSendToBook);
            result = result && (this.ProvSendToDel == that.ProvSendToDel);
            result = result && (this.ConfSendToBook == that.ConfSendToBook);
            result = result && (this.ConfSendToDel == that.ConfSendToDel);
            result = result && (this.JoiningSendToBook == that.JoiningSendToBook);
            result = result && (this.JoiningSendToDel == that.JoiningSendToDel);
            result = result && (this.PostSendToBook == that.PostSendToBook);
            result = result && (this.PostSendToDel == that.PostSendToDel);
            result = result && (this.ProductSelectGroup == that.ProductSelectGroup);
            result = result && (this.ActRevenueSplit == that.ActRevenueSplit);
            result = result && (this.ActHoursSplit == that.ActHoursSplit);
            result = result && (this.ExpOccupancy == that.ExpOccupancy);
            result = result && (this.ShowAttLog == that.ShowAttLog);
            return result;
        }

        #endregion
    }
}
