using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Represents the "Activity" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ActivityRecord : Record<String>, Cloneable<ActivityRecord>, IEquatable<ActivityRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ACT_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "ACT_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "ACT_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "ACT_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "ACT_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "ACT_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "ACT_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "ACT_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "ACT_DONE_IT" field.
        /// </summary>
        private Byte? _doneIt;

        /// <summary>
        ///     the value of the "ACT_KEY_NOTE" field.
        /// </summary>
        private String _keyNote;

        /// <summary>
        ///     the value of the "ACT_ACTION_DATE" field.
        /// </summary>
        private DateTime? _actionDate;

        /// <summary>
        ///     the value of the "ACT_TIME" field.
        /// </summary>
        private DateTime? _time;

        /// <summary>
        ///     the value of the "ACT_NEXT_DATE" field.
        /// </summary>
        private DateTime? _nextDate;

        /// <summary>
        ///     the value of the "ACT_END_DATE" field.
        /// </summary>
        private DateTime? _endDate;

        /// <summary>
        ///     the value of the "ACT_END_TIME" field.
        /// </summary>
        private DateTime? _endTime;

        /// <summary>
        ///     the value of the "ACT_LOC_ID" field.
        /// </summary>
        private String _locId;

        /// <summary>
        ///     the value of the "ACT_RESULT" field.
        /// </summary>
        private String _result;

        /// <summary>
        ///     the value of the "ACT_PREV_ACTIV" field.
        /// </summary>
        private String _prevActiv;

        /// <summary>
        ///     the value of the "ACT_PROMOTION_ID" field.
        /// </summary>
        private String _promotionId;

        /// <summary>
        ///     the value of the "ACT_BOOK_ID" field.
        /// </summary>
        private String _bookId;

        /// <summary>
        ///     the value of the "ACT_COURSE_ID" field.
        /// </summary>
        private String _courseId;

        /// <summary>
        ///     the value of the "ACT_TRAINER_ID" field.
        /// </summary>
        private String _trainerId;

        /// <summary>
        ///     the value of the "ACT_TEXT_ID" field.
        /// </summary>
        private String _textId;

        /// <summary>
        ///     the value of the "ACT_NOTE" field.
        /// </summary>
        private String _note;

        /// <summary>
        ///     the value of the "ACT_DONE_IT_DATE" field.
        /// </summary>
        private DateTime? _doneItDate;

        /// <summary>
        ///     the value of the "ACT_SOURCE_CODE" field.
        /// </summary>
        private String _sourceCode;

        /// <summary>
        ///     the value of the "ACT_LAST_NO" field.
        /// </summary>
        private String _lastNo;

        /// <summary>
        ///     the value of the "ACT_HIERARCHY" field.
        /// </summary>
        private String _hierarchy;

        /// <summary>
        ///     the value of the "ACT_LEVEL" field.
        /// </summary>
        private String _level;

        /// <summary>
        ///     the value of the "ACT_INITIATED_BY" field.
        /// </summary>
        private Double? _initiatedBy;

        /// <summary>
        ///     the value of the "ACT_MAN_ISSUES" field.
        /// </summary>
        private String _manIssues;

        /// <summary>
        ///     the value of the "ACT_VISIT_OBJ" field.
        /// </summary>
        private String _visitObj;

        /// <summary>
        ///     the value of the "ACT_CB_1" field.
        /// </summary>
        private Double? _cb1;

        /// <summary>
        ///     the value of the "ACT_CB_2" field.
        /// </summary>
        private Double? _cb2;

        /// <summary>
        ///     the value of the "ACT_CB_3" field.
        /// </summary>
        private Double? _cb3;

        /// <summary>
        ///     the value of the "ACT_CB_4" field.
        /// </summary>
        private Double? _cb4;

        /// <summary>
        ///     the value of the "ACT_CB_5" field.
        /// </summary>
        private Double? _cb5;

        /// <summary>
        ///     the value of the "ACT_CB_6" field.
        /// </summary>
        private Double? _cb6;

        /// <summary>
        ///     the value of the "ACT_CB_7" field.
        /// </summary>
        private Double? _cb7;

        /// <summary>
        ///     the value of the "ACT_CB_8" field.
        /// </summary>
        private Double? _cb8;

        /// <summary>
        ///     the value of the "ACT_CB_9" field.
        /// </summary>
        private Double? _cb9;

        /// <summary>
        ///     the value of the "ACT_CB_10" field.
        /// </summary>
        private Double? _cb10;

        /// <summary>
        ///     the value of the "ACT_OPP_ID" field.
        /// </summary>
        private String _oppId;

        /// <summary>
        ///     the value of the "ACT_HELP_TYPE" field.
        /// </summary>
        private String _helpType;

        /// <summary>
        ///     the value of the "ACT_PRODUCT_CODE" field.
        /// </summary>
        private String _productCode;

        /// <summary>
        ///     the value of the "ACT_PRODUCT_GROUP" field.
        /// </summary>
        private String _productGroup;

        /// <summary>
        ///     the value of the "ACT_PIC_ID" field.
        /// </summary>
        private String _picId;

        /// <summary>
        ///     the value of the "ACT_CLOS_CAT" field.
        /// </summary>
        private String _closCat;

        /// <summary>
        ///     the value of the "ACT_CLOS_DATA" field.
        /// </summary>
        private String _closData;

        /// <summary>
        ///     the value of the "ACT_SOURCE" field.
        /// </summary>
        private String _source;

        /// <summary>
        ///     the value of the "ACT_SUBJECT" field.
        /// </summary>
        private String _subject;

        /// <summary>
        ///     the value of the "ACT_SUB_TEXT" field.
        /// </summary>
        private String _subText;

        /// <summary>
        ///     the value of the "ACT_SERVICE_TYPE" field.
        /// </summary>
        private String _serviceType;

        /// <summary>
        ///     the value of the "ACT_PROBLEM_CAT" field.
        /// </summary>
        private String _problemCat;

        /// <summary>
        ///     the value of the "ACT_IN_ID" field.
        /// </summary>
        private String _inId;

        /// <summary>
        ///     the value of the "ACT_INVOICED" field.
        /// </summary>
        private Byte? _invoiced;

        /// <summary>
        ///     the value of the "ACT_SUP_CONT_REF" field.
        /// </summary>
        private String _supContRef;

        /// <summary>
        ///     the value of the "ACT_CHARGE_TYPE" field.
        /// </summary>
        private String _chargeType;

        /// <summary>
        ///     the value of the "ACT_MINUTES" field.
        /// </summary>
        private Int32? _minutes;

        /// <summary>
        ///     the value of the "ACT_VALUE" field.
        /// </summary>
        private Double? _value;

        /// <summary>
        ///     the value of the "ACT_VALUE_BC" field.
        /// </summary>
        private Double? _valueBc;

        /// <summary>
        ///     the value of the "ACT_CURRENCY_TYPE" field.
        /// </summary>
        private String _currencyType;

        /// <summary>
        ///     the value of the "ACT_SCHEME_ID" field.
        /// </summary>
        private String _schemeId;

        /// <summary>
        ///     the value of the "ACT_NXT_STAGE" field.
        /// </summary>
        private String _nxtStage;

        /// <summary>
        ///     the value of the "ACT_NXT_STGE_DATE" field.
        /// </summary>
        private DateTime? _nxtStgeDate;

        /// <summary>
        ///     the value of the "ACT_ALARMDATE" field.
        /// </summary>
        private DateTime? _alarmdate;

        /// <summary>
        ///     the value of the "ACT_ALARMTIME" field.
        /// </summary>
        private DateTime? _alarmtime;

        /// <summary>
        ///     the value of the "ACT_SYLLABUS_ID" field.
        /// </summary>
        private String _syllabusId;

        /// <summary>
        ///     the value of the "ACT_SESSION_NAME" field.
        /// </summary>
        private String _sessionName;

        /// <summary>
        ///     the value of the "ACT_RESOURCE_ID" field.
        /// </summary>
        private String _resourceId;

        /// <summary>
        ///     the value of the "ACT_REAL" field.
        /// </summary>
        private Byte? _real;

        /// <summary>
        ///     the value of the "ACT_ELEMENT" field.
        /// </summary>
        private Byte? _element;

        /// <summary>
        ///     the value of the "ACT_MANDATORY" field.
        /// </summary>
        private Byte? _mandatory;

        /// <summary>
        ///     the value of the "ACT_INVOICE_PRINT" field.
        /// </summary>
        private Byte? _invoicePrint;

        /// <summary>
        ///     the value of the "ACT_MAX_PLACES" field.
        /// </summary>
        private Double? _maxPlaces;

        /// <summary>
        ///     the value of the "ACT_MIN_PLACES" field.
        /// </summary>
        private Double? _minPlaces;

        /// <summary>
        ///     the value of the "ACT_FREE_PLACES" field.
        /// </summary>
        private Double? _freePlaces;

        /// <summary>
        ///     the value of the "ACT_PRICE" field.
        /// </summary>
        private Double? _price;

        /// <summary>
        ///     the value of the "ACT_BLOCK_PRICE" field.
        /// </summary>
        private Double? _blockPrice;

        /// <summary>
        ///     the value of the "ACT_PRICE_BC" field.
        /// </summary>
        private Double? _priceBc;

        /// <summary>
        ///     the value of the "ACT_BLOCK_PRICE_BC" field.
        /// </summary>
        private Double? _blockPriceBc;

        /// <summary>
        ///     the value of the "ACT_VATCD" field.
        /// </summary>
        private String _vatcd;

        /// <summary>
        ///     the value of the "ACT_REV_CODE" field.
        /// </summary>
        private String _revCode;

        /// <summary>
        ///     the value of the "ACT_COST_CODE" field.
        /// </summary>
        private String _costCode;

        /// <summary>
        ///     the value of the "ACT_DO_NOT_INVOICE" field.
        /// </summary>
        private Byte? _doNotInvoice;

        /// <summary>
        ///     the value of the "ACT_FROM_BOM_TYPE" field.
        /// </summary>
        private String _fromBomType;

        /// <summary>
        ///     the value of the "ACT_ROOM_GRADE" field.
        /// </summary>
        private String _roomGrade;

        /// <summary>
        ///     the value of the "ACT_TASK_NAME" field.
        /// </summary>
        private String _taskName;

        /// <summary>
        ///     the value of the "ACT_TASK_STATUS" field.
        /// </summary>
        private String _taskStatus;

        /// <summary>
        ///     the value of the "ACT_EST_HOURS" field.
        /// </summary>
        private Double? _estHours;

        /// <summary>
        ///     the value of the "ACT_ACTUAL_HOURS" field.
        /// </summary>
        private Double? _actualHours;

        /// <summary>
        ///     the value of the "ACT_USERNUM_1" field.
        /// </summary>
        private Double? _usernum1;

        /// <summary>
        ///     the value of the "ACT_USERNUM_2" field.
        /// </summary>
        private Double? _usernum2;

        /// <summary>
        ///     the value of the "ACT_USERNUM_3" field.
        /// </summary>
        private Double? _usernum3;

        /// <summary>
        ///     the value of the "ACT_REVIEW_DATE" field.
        /// </summary>
        private DateTime? _reviewDate;

        /// <summary>
        ///     the value of the "ACT_REVIEW_TIME" field.
        /// </summary>
        private DateTime? _reviewTime;

        /// <summary>
        ///     the value of the "ACT_PROJ_ID" field.
        /// </summary>
        private String _projId;

        /// <summary>
        ///     the value of the "ACT_FILE_PATH" field.
        /// </summary>
        private String _filePath;

        /// <summary>
        ///     the value of the "ACT_BIP" field.
        /// </summary>
        private Double? _bip;

        /// <summary>
        ///     the value of the "ACT_PART_NOTE" field.
        /// </summary>
        private String _partNote;

        /// <summary>
        ///     the value of the "ACT_PERIOD" field.
        /// </summary>
        private String _period;

        /// <summary>
        ///     the value of the "ACT_OVERBOOK" field.
        /// </summary>
        private Double? _overbook;

        /// <summary>
        ///     the value of the "ACT_SESSION_NAME2" field.
        /// </summary>
        private String _sessionName2;

        /// <summary>
        ///     the value of the "ACT_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "ACT_ADDRESS" field.
        /// </summary>
        private String _address;

        /// <summary>
        ///     the value of the "ACT_PQ_ID" field.
        /// </summary>
        private String _pqId;

        /// <summary>
        ///     the value of the "ACT_PQ_STATUS" field.
        /// </summary>
        private String _pqStatus;

        /// <summary>
        ///     the value of the "ACT_PQ_STATUS_TEXT" field.
        /// </summary>
        private String _pqStatusText;

        /// <summary>
        ///     the value of the "ACT_PQ_SEND_TYPE" field.
        /// </summary>
        private String _pqSendType;

        /// <summary>
        ///     the value of the "ACT_PQ_SENT_DATE" field.
        /// </summary>
        private DateTime? _pqSentDate;

        /// <summary>
        ///     the value of the "ACT_PQ_KEEP" field.
        /// </summary>
        private Byte? _pqKeep;

        /// <summary>
        ///     the value of the "ACT_MEP_ID" field.
        /// </summary>
        private String _mepId;

        /// <summary>
        ///     the value of the "ACT_TYPE_SUB" field.
        /// </summary>
        private String _typeSub;

        /// <summary>
        ///     the value of the "ACT_AUTO_ALLOCATE" field.
        /// </summary>
        private Byte? _autoAllocate;

        /// <summary>
        ///     the value of the "ACT_WF_ID" field.
        /// </summary>
        private String _wfId;

        /// <summary>
        ///     the value of the "ACT_EVR_INC_TOT" field.
        /// </summary>
        private Byte? _evrIncTot;

        /// <summary>
        ///     the value of the "ACT_EVR_INC_QUO" field.
        /// </summary>
        private Byte? _evrIncQuo;

        /// <summary>
        ///     the value of the "ACT_ADD_ID" field.
        /// </summary>
        private String _addId;

        /// <summary>
        ///     the value of the "ACT_ATTENDEES" field.
        /// </summary>
        private String _attendees;

        /// <summary>
        ///     the value of the "ACT_CEN_ID" field.
        /// </summary>
        private String _cenId;

        /// <summary>
        ///     the value of the "ACT_ROOM_LAYOUT" field.
        /// </summary>
        private Int32? _roomLayout;

        /// <summary>
        ///     the value of the "ACT_NOTE_HTML" field.
        /// </summary>
        private String _noteHtml;

        /// <summary>
        ///     the value of the "ACT_LAYOUT" field.
        /// </summary>
        private Byte? _layout;

        /// <summary>
        ///     the value of the "ACT_PLACES_TO_SET" field.
        /// </summary>
        private Int32? _placesToSet;

        /// <summary>
        ///     the value of the "ACT_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "ACT_STAFF_NEEDED" field.
        /// </summary>
        private Byte? _staffNeeded;

        /// <summary>
        ///     the value of the "ACT_TIME_PREP" field.
        /// </summary>
        private Double? _timePrep;

        /// <summary>
        ///     the value of the "ACT_TIME_CLEAN" field.
        /// </summary>
        private Double? _timeClean;

        /// <summary>
        ///     the value of the "ACT_TRN_ID" field.
        /// </summary>
        private String _trnId;

        /// <summary>
        ///     the value of the "ACT_PRIORITY" field.
        /// </summary>
        private String _priority;

        /// <summary>
        ///     the value of the "ACT_FLOAT" field.
        /// </summary>
        private Byte? _float;

        /// <summary>
        ///     the value of the "ACT_ALLOC_STATUS" field.
        /// </summary>
        private Byte? _allocStatus;

        /// <summary>
        ///     the value of the "ACT_DEPT_ID" field.
        /// </summary>
        private String _deptId;

        /// <summary>
        ///     the value of the "ACT_ROOM_BOOKING" field.
        /// </summary>
        private Byte? _roomBooking;

        /// <summary>
        ///     the value of the "ACT_CONTPROL_ID" field.
        /// </summary>
        private String _contprolId;

        /// <summary>
        ///     the value of the "ACT_RES_TYPE" field.
        /// </summary>
        private String _resType;

        /// <summary>
        ///     the value of the "ACT_DURATION" field.
        /// </summary>
        private Double _duration;

        /// <summary>
        ///     the value of the "ACT_PD_ID" field.
        /// </summary>
        private String _pdId;

        /// <summary>
        ///     the value of the "ACT_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "ACT_INC_IN_BUDGET" field.
        /// </summary>
        private Byte _incInBudget;

        /// <summary>
        ///     the value of the "ACT_VER_CAT" field.
        /// </summary>
        private String _verCat;

        /// <summary>
        ///     the value of the "ACT_PDPEMP_ID" field.
        /// </summary>
        private Int32? _pdpempId;

        /// <summary>
        ///     the value of the "ACT_APP_BY" field.
        /// </summary>
        private String _appBy;

        /// <summary>
        ///     the value of the "ACT_APP_DATE" field.
        /// </summary>
        private DateTime? _appDate;

        /// <summary>
        ///     the value of the "ACT_NEXT_REVIEW" field.
        /// </summary>
        private DateTime? _nextReview;

        /// <summary>
        ///     the value of the "ACT_INV_ID" field.
        /// </summary>
        private String _invId;

        /// <summary>
        ///     the value of the "ACT_CODE" field.
        /// </summary>
        private String _code;

        /// <summary>
        ///     the value of the "ACT_SESSION_TYPE" field.
        /// </summary>
        private String _sessionType;

        /// <summary>
        ///     the value of the "ACT_TEACH_HRS" field.
        /// </summary>
        private Decimal? _teachHrs;

        /// <summary>
        ///     the value of the "ACT_STUD_WKS" field.
        /// </summary>
        private Decimal? _studWks;

        /// <summary>
        ///     the value of the "ACT_NOTINUSE_START" field.
        /// </summary>
        private DateTime? _notinuseStart;

        /// <summary>
        ///     the value of the "ACT_NOTINUSE_END" field.
        /// </summary>
        private DateTime? _notinuseEnd;

        /// <summary>
        ///     the value of the "ACT_CONF_SESSION_ORDER" field.
        /// </summary>
        private Int32? _confSessionOrder;

        /// <summary>
        ///     the value of the "ACT_ADDED_BY" field.
        /// </summary>
        private Byte _addedBy;

        /// <summary>
        ///     the value of the "ACT_OUTLOOK_UID" field.
        /// </summary>
        private String _outlookUid;

        /// <summary>
        ///     the value of the "ACT_UNIQUE_REF" field.
        /// </summary>
        private String _uniqueRef;

        /// <summary>
        ///     the value of the "ACT_NO_SLOTS" field.
        /// </summary>
        private Int32? _noSlots;

        /// <summary>
        ///     the value of the "ACT_CANCELLED" field.
        /// </summary>
        private Byte _cancelled;

        /// <summary>
        ///     the value of the "ACT_DELETE" field.
        /// </summary>
        private Byte _delete;

        /// <summary>
        ///     the value of the "ACT_BOM_ID" field.
        /// </summary>
        private String _bomId;

        /// <summary>
        ///     the value of the "ACT_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "ACT_OUTCOME" field.
        /// </summary>
        private String _outcome;

        /// <summary>
        ///     the value of the "ACT_QUEST_ID" field.
        /// </summary>
        private String _questId;

        /// <summary>
        ///     the value of the "ACT_BUILD_VERSION" field.
        /// </summary>
        private String _buildVersion;

        /// <summary>
        ///     the value of the "ACT_LOCKED_DATE" field.
        /// </summary>
        private DateTime? _lockedDate;

        /// <summary>
        ///     the value of the "ACT_TIMEOUT" field.
        /// </summary>
        private DateTime? _timeout;

        /// <summary>
        ///     the value of the "ACT_CG_CODE" field.
        /// </summary>
        private String _cgCode;

        /// <summary>
        ///     the value of the "ACT_PROV_PACK" field.
        /// </summary>
        private String _provPack;

        /// <summary>
        ///     the value of the "ACT_CONF_PACK" field.
        /// </summary>
        private String _confPack;

        /// <summary>
        ///     the value of the "ACT_JOINING_PACK" field.
        /// </summary>
        private String _joiningPack;

        /// <summary>
        ///     the value of the "ACT_POST_PACK" field.
        /// </summary>
        private String _postPack;

        /// <summary>
        ///     the value of the "ACT_PREJOIN_PACK" field.
        /// </summary>
        private String _prejoinPack;

        /// <summary>
        ///     the value of the "ACT_PSTJOIN_PACK" field.
        /// </summary>
        private String _pstjoinPack;

        /// <summary>
        ///     the value of the "ACT_PROV_SENT_DTE" field.
        /// </summary>
        private DateTime? _provSentDte;

        /// <summary>
        ///     the value of the "ACT_CONF_SENT_DTE" field.
        /// </summary>
        private DateTime? _confSentDte;

        /// <summary>
        ///     the value of the "ACT_JOIN_SENT_DTE" field.
        /// </summary>
        private DateTime? _joinSentDte;

        /// <summary>
        ///     the value of the "ACT_PP_SENT_DTE" field.
        /// </summary>
        private DateTime? _ppSentDte;

        /// <summary>
        ///     the value of the "ACT_PRJOIN_SENT_DTE" field.
        /// </summary>
        private DateTime? _prjoinSentDte;

        /// <summary>
        ///     the value of the "ACT_POJOIN_SENT_DTE" field.
        /// </summary>
        private DateTime? _pojoinSentDte;

        /// <summary>
        ///     the value of the "ACT_DROPDOWN_1" field.
        /// </summary>
        private String _dropdown1;

        /// <summary>
        ///     the value of the "ACT_DROPDOWN_2" field.
        /// </summary>
        private String _dropdown2;

        /// <summary>
        ///     the value of the "ACT_REVENUE_SPLIT" field.
        /// </summary>
        private Double _revenueSplit;

        /// <summary>
        ///     the value of the "ACT_HOURS_SPLIT" field.
        /// </summary>
        private Double _hoursSplit;

        /// <summary>
        ///     the value of the "ACT_ARRIVED" field.
        /// </summary>
        private Byte? _arrived;

        /// <summary>
        ///     the value of the "ACT_EXP_OCCUPANCY" field.
        /// </summary>
        private Int32? _expOccupancy;

        /// <summary>
        ///     the value of the "ACT_RESERVE" field.
        /// </summary>
        private Byte? _reserve;

        /// <summary>
        ///     the value of the "ACT_VISIT_OUTCOME" field.
        /// </summary>
        private String _visitOutcome;

        /// <summary>
        ///     the value of the "ACT_TRNP_ID" field.
        /// </summary>
        private Int32? _trnpId;

        /// <summary>
        ///     the value of the "ACT_SHOW_ATT_LOG" field.
        /// </summary>
        private Byte? _showAttLog;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ACT_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "ACT_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "ACT_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "ACT_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "ACT_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "ACT_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "ACT_DONE_IT" field.
        /// </summary>
        public Byte? DoneIt
        {
            get { return _doneIt; }
            set { _doneIt = value; }
        }

        /// <summary>
        ///     the value of the "ACT_KEY_NOTE" field.
        /// </summary>
        public String KeyNote
        {
            get { return _keyNote; }
            set { _keyNote = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ACTION_DATE" field.
        /// </summary>
        public DateTime? ActionDate
        {
            get { return _actionDate; }
            set { _actionDate = value; }
        }

        /// <summary>
        ///     the value of the "ACT_TIME" field.
        /// </summary>
        public DateTime? Time
        {
            get { return _time; }
            set { _time = value; }
        }

        /// <summary>
        ///     the value of the "ACT_NEXT_DATE" field.
        /// </summary>
        public DateTime? NextDate
        {
            get { return _nextDate; }
            set { _nextDate = value; }
        }

        /// <summary>
        ///     the value of the "ACT_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        /// <summary>
        ///     the value of the "ACT_END_TIME" field.
        /// </summary>
        public DateTime? EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        /// <summary>
        ///     the value of the "ACT_LOC_ID" field.
        /// </summary>
        public String LocId
        {
            get { return _locId; }
            set { _locId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_RESULT" field.
        /// </summary>
        public String Result
        {
            get { return _result; }
            set { _result = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PREV_ACTIV" field.
        /// </summary>
        public String PrevActiv
        {
            get { return _prevActiv; }
            set { _prevActiv = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PROMOTION_ID" field.
        /// </summary>
        public String PromotionId
        {
            get { return _promotionId; }
            set { _promotionId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_BOOK_ID" field.
        /// </summary>
        public String BookId
        {
            get { return _bookId; }
            set { _bookId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_COURSE_ID" field.
        /// </summary>
        public String CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_TRAINER_ID" field.
        /// </summary>
        public String TrainerId
        {
            get { return _trainerId; }
            set { _trainerId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_TEXT_ID" field.
        /// </summary>
        public String TextId
        {
            get { return _textId; }
            set { _textId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_NOTE" field.
        /// </summary>
        public String Note
        {
            get { return _note; }
            set { _note = value; }
        }

        /// <summary>
        ///     the value of the "ACT_DONE_IT_DATE" field.
        /// </summary>
        public DateTime? DoneItDate
        {
            get { return _doneItDate; }
            set { _doneItDate = value; }
        }

        /// <summary>
        ///     the value of the "ACT_SOURCE_CODE" field.
        /// </summary>
        public String SourceCode
        {
            get { return _sourceCode; }
            set { _sourceCode = value; }
        }

        /// <summary>
        ///     the value of the "ACT_LAST_NO" field.
        /// </summary>
        public String LastNo
        {
            get { return _lastNo; }
            set { _lastNo = value; }
        }

        /// <summary>
        ///     the value of the "ACT_HIERARCHY" field.
        /// </summary>
        public String Hierarchy
        {
            get { return _hierarchy; }
            set { _hierarchy = value; }
        }

        /// <summary>
        ///     the value of the "ACT_LEVEL" field.
        /// </summary>
        public String Level
        {
            get { return _level; }
            set { _level = value; }
        }

        /// <summary>
        ///     the value of the "ACT_INITIATED_BY" field.
        /// </summary>
        public Double? InitiatedBy
        {
            get { return _initiatedBy; }
            set { _initiatedBy = value; }
        }

        /// <summary>
        ///     the value of the "ACT_MAN_ISSUES" field.
        /// </summary>
        public String ManIssues
        {
            get { return _manIssues; }
            set { _manIssues = value; }
        }

        /// <summary>
        ///     the value of the "ACT_VISIT_OBJ" field.
        /// </summary>
        public String VisitObj
        {
            get { return _visitObj; }
            set { _visitObj = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CB_1" field.
        /// </summary>
        public Double? Cb1
        {
            get { return _cb1; }
            set { _cb1 = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CB_2" field.
        /// </summary>
        public Double? Cb2
        {
            get { return _cb2; }
            set { _cb2 = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CB_3" field.
        /// </summary>
        public Double? Cb3
        {
            get { return _cb3; }
            set { _cb3 = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CB_4" field.
        /// </summary>
        public Double? Cb4
        {
            get { return _cb4; }
            set { _cb4 = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CB_5" field.
        /// </summary>
        public Double? Cb5
        {
            get { return _cb5; }
            set { _cb5 = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CB_6" field.
        /// </summary>
        public Double? Cb6
        {
            get { return _cb6; }
            set { _cb6 = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CB_7" field.
        /// </summary>
        public Double? Cb7
        {
            get { return _cb7; }
            set { _cb7 = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CB_8" field.
        /// </summary>
        public Double? Cb8
        {
            get { return _cb8; }
            set { _cb8 = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CB_9" field.
        /// </summary>
        public Double? Cb9
        {
            get { return _cb9; }
            set { _cb9 = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CB_10" field.
        /// </summary>
        public Double? Cb10
        {
            get { return _cb10; }
            set { _cb10 = value; }
        }

        /// <summary>
        ///     the value of the "ACT_OPP_ID" field.
        /// </summary>
        public String OppId
        {
            get { return _oppId; }
            set { _oppId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_HELP_TYPE" field.
        /// </summary>
        public String HelpType
        {
            get { return _helpType; }
            set { _helpType = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PRODUCT_CODE" field.
        /// </summary>
        public String ProductCode
        {
            get { return _productCode; }
            set { _productCode = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PRODUCT_GROUP" field.
        /// </summary>
        public String ProductGroup
        {
            get { return _productGroup; }
            set { _productGroup = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PIC_ID" field.
        /// </summary>
        public String PicId
        {
            get { return _picId; }
            set { _picId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CLOS_CAT" field.
        /// </summary>
        public String ClosCat
        {
            get { return _closCat; }
            set { _closCat = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CLOS_DATA" field.
        /// </summary>
        public String ClosData
        {
            get { return _closData; }
            set { _closData = value; }
        }

        /// <summary>
        ///     the value of the "ACT_SOURCE" field.
        /// </summary>
        public String Source
        {
            get { return _source; }
            set { _source = value; }
        }

        /// <summary>
        ///     the value of the "ACT_SUBJECT" field.
        /// </summary>
        public String Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        /// <summary>
        ///     the value of the "ACT_SUB_TEXT" field.
        /// </summary>
        public String SubText
        {
            get { return _subText; }
            set { _subText = value; }
        }

        /// <summary>
        ///     the value of the "ACT_SERVICE_TYPE" field.
        /// </summary>
        public String ServiceType
        {
            get { return _serviceType; }
            set { _serviceType = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PROBLEM_CAT" field.
        /// </summary>
        public String ProblemCat
        {
            get { return _problemCat; }
            set { _problemCat = value; }
        }

        /// <summary>
        ///     the value of the "ACT_IN_ID" field.
        /// </summary>
        public String InId
        {
            get { return _inId; }
            set { _inId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_INVOICED" field.
        /// </summary>
        public Byte? Invoiced
        {
            get { return _invoiced; }
            set { _invoiced = value; }
        }

        /// <summary>
        ///     the value of the "ACT_SUP_CONT_REF" field.
        /// </summary>
        public String SupContRef
        {
            get { return _supContRef; }
            set { _supContRef = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CHARGE_TYPE" field.
        /// </summary>
        public String ChargeType
        {
            get { return _chargeType; }
            set { _chargeType = value; }
        }

        /// <summary>
        ///     the value of the "ACT_MINUTES" field.
        /// </summary>
        public Int32? Minutes
        {
            get { return _minutes; }
            set { _minutes = value; }
        }

        /// <summary>
        ///     the value of the "ACT_VALUE" field.
        /// </summary>
        public Double? Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        ///     the value of the "ACT_VALUE_BC" field.
        /// </summary>
        public Double? ValueBc
        {
            get { return _valueBc; }
            set { _valueBc = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CURRENCY_TYPE" field.
        /// </summary>
        public String CurrencyType
        {
            get { return _currencyType; }
            set { _currencyType = value; }
        }

        /// <summary>
        ///     the value of the "ACT_SCHEME_ID" field.
        /// </summary>
        public String SchemeId
        {
            get { return _schemeId; }
            set { _schemeId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_NXT_STAGE" field.
        /// </summary>
        public String NxtStage
        {
            get { return _nxtStage; }
            set { _nxtStage = value; }
        }

        /// <summary>
        ///     the value of the "ACT_NXT_STGE_DATE" field.
        /// </summary>
        public DateTime? NxtStgeDate
        {
            get { return _nxtStgeDate; }
            set { _nxtStgeDate = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ALARMDATE" field.
        /// </summary>
        public DateTime? Alarmdate
        {
            get { return _alarmdate; }
            set { _alarmdate = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ALARMTIME" field.
        /// </summary>
        public DateTime? Alarmtime
        {
            get { return _alarmtime; }
            set { _alarmtime = value; }
        }

        /// <summary>
        ///     the value of the "ACT_SYLLABUS_ID" field.
        /// </summary>
        public String SyllabusId
        {
            get { return _syllabusId; }
            set { _syllabusId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_SESSION_NAME" field.
        /// </summary>
        public String SessionName
        {
            get { return _sessionName; }
            set { _sessionName = value; }
        }

        /// <summary>
        ///     the value of the "ACT_RESOURCE_ID" field.
        /// </summary>
        public String ResourceId
        {
            get { return _resourceId; }
            set { _resourceId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_REAL" field.
        /// </summary>
        public Byte? Real
        {
            get { return _real; }
            set { _real = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ELEMENT" field.
        /// </summary>
        public Byte? Element
        {
            get { return _element; }
            set { _element = value; }
        }

        /// <summary>
        ///     the value of the "ACT_MANDATORY" field.
        /// </summary>
        public Byte? Mandatory
        {
            get { return _mandatory; }
            set { _mandatory = value; }
        }

        /// <summary>
        ///     the value of the "ACT_INVOICE_PRINT" field.
        /// </summary>
        public Byte? InvoicePrint
        {
            get { return _invoicePrint; }
            set { _invoicePrint = value; }
        }

        /// <summary>
        ///     the value of the "ACT_MAX_PLACES" field.
        /// </summary>
        public Double? MaxPlaces
        {
            get { return _maxPlaces; }
            set { _maxPlaces = value; }
        }

        /// <summary>
        ///     the value of the "ACT_MIN_PLACES" field.
        /// </summary>
        public Double? MinPlaces
        {
            get { return _minPlaces; }
            set { _minPlaces = value; }
        }

        /// <summary>
        ///     the value of the "ACT_FREE_PLACES" field.
        /// </summary>
        public Double? FreePlaces
        {
            get { return _freePlaces; }
            set { _freePlaces = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PRICE" field.
        /// </summary>
        public Double? Price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        ///     the value of the "ACT_BLOCK_PRICE" field.
        /// </summary>
        public Double? BlockPrice
        {
            get { return _blockPrice; }
            set { _blockPrice = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PRICE_BC" field.
        /// </summary>
        public Double? PriceBc
        {
            get { return _priceBc; }
            set { _priceBc = value; }
        }

        /// <summary>
        ///     the value of the "ACT_BLOCK_PRICE_BC" field.
        /// </summary>
        public Double? BlockPriceBc
        {
            get { return _blockPriceBc; }
            set { _blockPriceBc = value; }
        }

        /// <summary>
        ///     the value of the "ACT_VATCD" field.
        /// </summary>
        public String Vatcd
        {
            get { return _vatcd; }
            set { _vatcd = value; }
        }

        /// <summary>
        ///     the value of the "ACT_REV_CODE" field.
        /// </summary>
        public String RevCode
        {
            get { return _revCode; }
            set { _revCode = value; }
        }

        /// <summary>
        ///     the value of the "ACT_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return _costCode; }
            set { _costCode = value; }
        }

        /// <summary>
        ///     the value of the "ACT_DO_NOT_INVOICE" field.
        /// </summary>
        public Byte? DoNotInvoice
        {
            get { return _doNotInvoice; }
            set { _doNotInvoice = value; }
        }

        /// <summary>
        ///     the value of the "ACT_FROM_BOM_TYPE" field.
        /// </summary>
        public String FromBomType
        {
            get { return _fromBomType; }
            set { _fromBomType = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ROOM_GRADE" field.
        /// </summary>
        public String RoomGrade
        {
            get { return _roomGrade; }
            set { _roomGrade = value; }
        }

        /// <summary>
        ///     the value of the "ACT_TASK_NAME" field.
        /// </summary>
        public String TaskName
        {
            get { return _taskName; }
            set { _taskName = value; }
        }

        /// <summary>
        ///     the value of the "ACT_TASK_STATUS" field.
        /// </summary>
        public String TaskStatus
        {
            get { return _taskStatus; }
            set { _taskStatus = value; }
        }

        /// <summary>
        ///     the value of the "ACT_EST_HOURS" field.
        /// </summary>
        public Double? EstHours
        {
            get { return _estHours; }
            set { _estHours = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ACTUAL_HOURS" field.
        /// </summary>
        public Double? ActualHours
        {
            get { return _actualHours; }
            set { _actualHours = value; }
        }

        /// <summary>
        ///     the value of the "ACT_USERNUM_1" field.
        /// </summary>
        public Double? Usernum1
        {
            get { return _usernum1; }
            set { _usernum1 = value; }
        }

        /// <summary>
        ///     the value of the "ACT_USERNUM_2" field.
        /// </summary>
        public Double? Usernum2
        {
            get { return _usernum2; }
            set { _usernum2 = value; }
        }

        /// <summary>
        ///     the value of the "ACT_USERNUM_3" field.
        /// </summary>
        public Double? Usernum3
        {
            get { return _usernum3; }
            set { _usernum3 = value; }
        }

        /// <summary>
        ///     the value of the "ACT_REVIEW_DATE" field.
        /// </summary>
        public DateTime? ReviewDate
        {
            get { return _reviewDate; }
            set { _reviewDate = value; }
        }

        /// <summary>
        ///     the value of the "ACT_REVIEW_TIME" field.
        /// </summary>
        public DateTime? ReviewTime
        {
            get { return _reviewTime; }
            set { _reviewTime = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PROJ_ID" field.
        /// </summary>
        public String ProjId
        {
            get { return _projId; }
            set { _projId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_FILE_PATH" field.
        /// </summary>
        public String FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        /// <summary>
        ///     the value of the "ACT_BIP" field.
        /// </summary>
        public Double? Bip
        {
            get { return _bip; }
            set { _bip = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PART_NOTE" field.
        /// </summary>
        public String PartNote
        {
            get { return _partNote; }
            set { _partNote = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PERIOD" field.
        /// </summary>
        public String Period
        {
            get { return _period; }
            set { _period = value; }
        }

        /// <summary>
        ///     the value of the "ACT_OVERBOOK" field.
        /// </summary>
        public Double? Overbook
        {
            get { return _overbook; }
            set { _overbook = value; }
        }

        /// <summary>
        ///     the value of the "ACT_SESSION_NAME2" field.
        /// </summary>
        public String SessionName2
        {
            get { return _sessionName2; }
            set { _sessionName2 = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ADDRESS" field.
        /// </summary>
        public String Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PQ_ID" field.
        /// </summary>
        public String PqId
        {
            get { return _pqId; }
            set { _pqId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PQ_STATUS" field.
        /// </summary>
        public String PqStatus
        {
            get { return _pqStatus; }
            set { _pqStatus = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PQ_STATUS_TEXT" field.
        /// </summary>
        public String PqStatusText
        {
            get { return _pqStatusText; }
            set { _pqStatusText = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PQ_SEND_TYPE" field.
        /// </summary>
        public String PqSendType
        {
            get { return _pqSendType; }
            set { _pqSendType = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PQ_SENT_DATE" field.
        /// </summary>
        public DateTime? PqSentDate
        {
            get { return _pqSentDate; }
            set { _pqSentDate = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PQ_KEEP" field.
        /// </summary>
        public Byte? PqKeep
        {
            get { return _pqKeep; }
            set { _pqKeep = value; }
        }

        /// <summary>
        ///     the value of the "ACT_MEP_ID" field.
        /// </summary>
        public String MepId
        {
            get { return _mepId; }
            set { _mepId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_TYPE_SUB" field.
        /// </summary>
        public String TypeSub
        {
            get { return _typeSub; }
            set { _typeSub = value; }
        }

        /// <summary>
        ///     the value of the "ACT_AUTO_ALLOCATE" field.
        /// </summary>
        public Byte? AutoAllocate
        {
            get { return _autoAllocate; }
            set { _autoAllocate = value; }
        }

        /// <summary>
        ///     the value of the "ACT_WF_ID" field.
        /// </summary>
        public String WfId
        {
            get { return _wfId; }
            set { _wfId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_EVR_INC_TOT" field.
        /// </summary>
        public Byte? EvrIncTot
        {
            get { return _evrIncTot; }
            set { _evrIncTot = value; }
        }

        /// <summary>
        ///     the value of the "ACT_EVR_INC_QUO" field.
        /// </summary>
        public Byte? EvrIncQuo
        {
            get { return _evrIncQuo; }
            set { _evrIncQuo = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ADD_ID" field.
        /// </summary>
        public String AddId
        {
            get { return _addId; }
            set { _addId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ATTENDEES" field.
        /// </summary>
        public String Attendees
        {
            get { return _attendees; }
            set { _attendees = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CEN_ID" field.
        /// </summary>
        public String CenId
        {
            get { return _cenId; }
            set { _cenId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ROOM_LAYOUT" field.
        /// </summary>
        public Int32? RoomLayout
        {
            get { return _roomLayout; }
            set { _roomLayout = value; }
        }

        /// <summary>
        ///     the value of the "ACT_NOTE_HTML" field.
        /// </summary>
        public String NoteHtml
        {
            get { return _noteHtml; }
            set { _noteHtml = value; }
        }

        /// <summary>
        ///     the value of the "ACT_LAYOUT" field.
        /// </summary>
        public Byte? Layout
        {
            get { return _layout; }
            set { _layout = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PLACES_TO_SET" field.
        /// </summary>
        public Int32? PlacesToSet
        {
            get { return _placesToSet; }
            set { _placesToSet = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_STAFF_NEEDED" field.
        /// </summary>
        public Byte? StaffNeeded
        {
            get { return _staffNeeded; }
            set { _staffNeeded = value; }
        }

        /// <summary>
        ///     the value of the "ACT_TIME_PREP" field.
        /// </summary>
        public Double? TimePrep
        {
            get { return _timePrep; }
            set { _timePrep = value; }
        }

        /// <summary>
        ///     the value of the "ACT_TIME_CLEAN" field.
        /// </summary>
        public Double? TimeClean
        {
            get { return _timeClean; }
            set { _timeClean = value; }
        }

        /// <summary>
        ///     the value of the "ACT_TRN_ID" field.
        /// </summary>
        public String TrnId
        {
            get { return _trnId; }
            set { _trnId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PRIORITY" field.
        /// </summary>
        public String Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        /// <summary>
        ///     the value of the "ACT_FLOAT" field.
        /// </summary>
        public Byte? Float
        {
            get { return _float; }
            set { _float = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ALLOC_STATUS" field.
        /// </summary>
        public Byte? AllocStatus
        {
            get { return _allocStatus; }
            set { _allocStatus = value; }
        }

        /// <summary>
        ///     the value of the "ACT_DEPT_ID" field.
        /// </summary>
        public String DeptId
        {
            get { return _deptId; }
            set { _deptId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ROOM_BOOKING" field.
        /// </summary>
        public Byte? RoomBooking
        {
            get { return _roomBooking; }
            set { _roomBooking = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CONTPROL_ID" field.
        /// </summary>
        public String ContprolId
        {
            get { return _contprolId; }
            set { _contprolId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_RES_TYPE" field.
        /// </summary>
        public String ResType
        {
            get { return _resType; }
            set { _resType = value; }
        }

        /// <summary>
        ///     the value of the "ACT_DURATION" field.
        /// </summary>
        public Double Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PD_ID" field.
        /// </summary>
        public String PdId
        {
            get { return _pdId; }
            set { _pdId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_INC_IN_BUDGET" field.
        /// </summary>
        public Byte IncInBudget
        {
            get { return _incInBudget; }
            set { _incInBudget = value; }
        }

        /// <summary>
        ///     the value of the "ACT_VER_CAT" field.
        /// </summary>
        public String VerCat
        {
            get { return _verCat; }
            set { _verCat = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PDPEMP_ID" field.
        /// </summary>
        public Int32? PdpempId
        {
            get { return _pdpempId; }
            set { _pdpempId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_APP_BY" field.
        /// </summary>
        public String AppBy
        {
            get { return _appBy; }
            set { _appBy = value; }
        }

        /// <summary>
        ///     the value of the "ACT_APP_DATE" field.
        /// </summary>
        public DateTime? AppDate
        {
            get { return _appDate; }
            set { _appDate = value; }
        }

        /// <summary>
        ///     the value of the "ACT_NEXT_REVIEW" field.
        /// </summary>
        public DateTime? NextReview
        {
            get { return _nextReview; }
            set { _nextReview = value; }
        }

        /// <summary>
        ///     the value of the "ACT_INV_ID" field.
        /// </summary>
        public String InvId
        {
            get { return _invId; }
            set { _invId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CODE" field.
        /// </summary>
        public String Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        ///     the value of the "ACT_SESSION_TYPE" field.
        /// </summary>
        public String SessionType
        {
            get { return _sessionType; }
            set { _sessionType = value; }
        }

        /// <summary>
        ///     the value of the "ACT_TEACH_HRS" field.
        /// </summary>
        public Decimal? TeachHrs
        {
            get { return _teachHrs; }
            set { _teachHrs = value; }
        }

        /// <summary>
        ///     the value of the "ACT_STUD_WKS" field.
        /// </summary>
        public Decimal? StudWks
        {
            get { return _studWks; }
            set { _studWks = value; }
        }

        /// <summary>
        ///     the value of the "ACT_NOTINUSE_START" field.
        /// </summary>
        public DateTime? NotinuseStart
        {
            get { return _notinuseStart; }
            set { _notinuseStart = value; }
        }

        /// <summary>
        ///     the value of the "ACT_NOTINUSE_END" field.
        /// </summary>
        public DateTime? NotinuseEnd
        {
            get { return _notinuseEnd; }
            set { _notinuseEnd = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CONF_SESSION_ORDER" field.
        /// </summary>
        public Int32? ConfSessionOrder
        {
            get { return _confSessionOrder; }
            set { _confSessionOrder = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ADDED_BY" field.
        /// </summary>
        public Byte AddedBy
        {
            get { return _addedBy; }
            set { _addedBy = value; }
        }

        /// <summary>
        ///     the value of the "ACT_OUTLOOK_UID" field.
        /// </summary>
        public String OutlookUid
        {
            get { return _outlookUid; }
            set { _outlookUid = value; }
        }

        /// <summary>
        ///     the value of the "ACT_UNIQUE_REF" field.
        /// </summary>
        public String UniqueRef
        {
            get { return _uniqueRef; }
            set { _uniqueRef = value; }
        }

        /// <summary>
        ///     the value of the "ACT_NO_SLOTS" field.
        /// </summary>
        public Int32? NoSlots
        {
            get { return _noSlots; }
            set { _noSlots = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CANCELLED" field.
        /// </summary>
        public Byte Cancelled
        {
            get { return _cancelled; }
            set { _cancelled = value; }
        }

        /// <summary>
        ///     the value of the "ACT_DELETE" field.
        /// </summary>
        public Byte Delete
        {
            get { return _delete; }
            set { _delete = value; }
        }

        /// <summary>
        ///     the value of the "ACT_BOM_ID" field.
        /// </summary>
        public String BomId
        {
            get { return _bomId; }
            set { _bomId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "ACT_OUTCOME" field.
        /// </summary>
        public String Outcome
        {
            get { return _outcome; }
            set { _outcome = value; }
        }

        /// <summary>
        ///     the value of the "ACT_QUEST_ID" field.
        /// </summary>
        public String QuestId
        {
            get { return _questId; }
            set { _questId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_BUILD_VERSION" field.
        /// </summary>
        public String BuildVersion
        {
            get { return _buildVersion; }
            set { _buildVersion = value; }
        }

        /// <summary>
        ///     the value of the "ACT_LOCKED_DATE" field.
        /// </summary>
        public DateTime? LockedDate
        {
            get { return _lockedDate; }
            set { _lockedDate = value; }
        }

        /// <summary>
        ///     the value of the "ACT_TIMEOUT" field.
        /// </summary>
        public DateTime? Timeout
        {
            get { return _timeout; }
            set { _timeout = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CG_CODE" field.
        /// </summary>
        public String CgCode
        {
            get { return _cgCode; }
            set { _cgCode = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PROV_PACK" field.
        /// </summary>
        public String ProvPack
        {
            get { return _provPack; }
            set { _provPack = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CONF_PACK" field.
        /// </summary>
        public String ConfPack
        {
            get { return _confPack; }
            set { _confPack = value; }
        }

        /// <summary>
        ///     the value of the "ACT_JOINING_PACK" field.
        /// </summary>
        public String JoiningPack
        {
            get { return _joiningPack; }
            set { _joiningPack = value; }
        }

        /// <summary>
        ///     the value of the "ACT_POST_PACK" field.
        /// </summary>
        public String PostPack
        {
            get { return _postPack; }
            set { _postPack = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PREJOIN_PACK" field.
        /// </summary>
        public String PrejoinPack
        {
            get { return _prejoinPack; }
            set { _prejoinPack = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PSTJOIN_PACK" field.
        /// </summary>
        public String PstjoinPack
        {
            get { return _pstjoinPack; }
            set { _pstjoinPack = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PROV_SENT_DTE" field.
        /// </summary>
        public DateTime? ProvSentDte
        {
            get { return _provSentDte; }
            set { _provSentDte = value; }
        }

        /// <summary>
        ///     the value of the "ACT_CONF_SENT_DTE" field.
        /// </summary>
        public DateTime? ConfSentDte
        {
            get { return _confSentDte; }
            set { _confSentDte = value; }
        }

        /// <summary>
        ///     the value of the "ACT_JOIN_SENT_DTE" field.
        /// </summary>
        public DateTime? JoinSentDte
        {
            get { return _joinSentDte; }
            set { _joinSentDte = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PP_SENT_DTE" field.
        /// </summary>
        public DateTime? PpSentDte
        {
            get { return _ppSentDte; }
            set { _ppSentDte = value; }
        }

        /// <summary>
        ///     the value of the "ACT_PRJOIN_SENT_DTE" field.
        /// </summary>
        public DateTime? PrjoinSentDte
        {
            get { return _prjoinSentDte; }
            set { _prjoinSentDte = value; }
        }

        /// <summary>
        ///     the value of the "ACT_POJOIN_SENT_DTE" field.
        /// </summary>
        public DateTime? PojoinSentDte
        {
            get { return _pojoinSentDte; }
            set { _pojoinSentDte = value; }
        }

        /// <summary>
        ///     the value of the "ACT_DROPDOWN_1" field.
        /// </summary>
        public String Dropdown1
        {
            get { return _dropdown1; }
            set { _dropdown1 = value; }
        }

        /// <summary>
        ///     the value of the "ACT_DROPDOWN_2" field.
        /// </summary>
        public String Dropdown2
        {
            get { return _dropdown2; }
            set { _dropdown2 = value; }
        }

        /// <summary>
        ///     the value of the "ACT_REVENUE_SPLIT" field.
        /// </summary>
        public Double RevenueSplit
        {
            get { return _revenueSplit; }
            set { _revenueSplit = value; }
        }

        /// <summary>
        ///     the value of the "ACT_HOURS_SPLIT" field.
        /// </summary>
        public Double HoursSplit
        {
            get { return _hoursSplit; }
            set { _hoursSplit = value; }
        }

        /// <summary>
        ///     the value of the "ACT_ARRIVED" field.
        /// </summary>
        public Byte? Arrived
        {
            get { return _arrived; }
            set { _arrived = value; }
        }

        /// <summary>
        ///     the value of the "ACT_EXP_OCCUPANCY" field.
        /// </summary>
        public Int32? ExpOccupancy
        {
            get { return _expOccupancy; }
            set { _expOccupancy = value; }
        }

        /// <summary>
        ///     the value of the "ACT_RESERVE" field.
        /// </summary>
        public Byte? Reserve
        {
            get { return _reserve; }
            set { _reserve = value; }
        }

        /// <summary>
        ///     the value of the "ACT_VISIT_OUTCOME" field.
        /// </summary>
        public String VisitOutcome
        {
            get { return _visitOutcome; }
            set { _visitOutcome = value; }
        }

        /// <summary>
        ///     the value of the "ACT_TRNP_ID" field.
        /// </summary>
        public Int32? TrnpId
        {
            get { return _trnpId; }
            set { _trnpId = value; }
        }

        /// <summary>
        ///     the value of the "ACT_SHOW_ATT_LOG" field.
        /// </summary>
        public Byte? ShowAttLog
        {
            get { return _showAttLog; }
            set { _showAttLog = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ActivityRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ActivityRecord" /> object instance.
        /// </returns>
        public ActivityRecord Clone()
        {
            ActivityRecord record = new ActivityRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Type = this.Type;
            record.DoneIt = this.DoneIt;
            record.KeyNote = this.KeyNote;
            record.ActionDate = this.ActionDate;
            record.Time = this.Time;
            record.NextDate = this.NextDate;
            record.EndDate = this.EndDate;
            record.EndTime = this.EndTime;
            record.LocId = this.LocId;
            record.Result = this.Result;
            record.PrevActiv = this.PrevActiv;
            record.PromotionId = this.PromotionId;
            record.BookId = this.BookId;
            record.CourseId = this.CourseId;
            record.TrainerId = this.TrainerId;
            record.TextId = this.TextId;
            record.Note = this.Note;
            record.DoneItDate = this.DoneItDate;
            record.SourceCode = this.SourceCode;
            record.LastNo = this.LastNo;
            record.Hierarchy = this.Hierarchy;
            record.Level = this.Level;
            record.InitiatedBy = this.InitiatedBy;
            record.ManIssues = this.ManIssues;
            record.VisitObj = this.VisitObj;
            record.Cb1 = this.Cb1;
            record.Cb2 = this.Cb2;
            record.Cb3 = this.Cb3;
            record.Cb4 = this.Cb4;
            record.Cb5 = this.Cb5;
            record.Cb6 = this.Cb6;
            record.Cb7 = this.Cb7;
            record.Cb8 = this.Cb8;
            record.Cb9 = this.Cb9;
            record.Cb10 = this.Cb10;
            record.OppId = this.OppId;
            record.HelpType = this.HelpType;
            record.ProductCode = this.ProductCode;
            record.ProductGroup = this.ProductGroup;
            record.PicId = this.PicId;
            record.ClosCat = this.ClosCat;
            record.ClosData = this.ClosData;
            record.Source = this.Source;
            record.Subject = this.Subject;
            record.SubText = this.SubText;
            record.ServiceType = this.ServiceType;
            record.ProblemCat = this.ProblemCat;
            record.InId = this.InId;
            record.Invoiced = this.Invoiced;
            record.SupContRef = this.SupContRef;
            record.ChargeType = this.ChargeType;
            record.Minutes = this.Minutes;
            record.Value = this.Value;
            record.ValueBc = this.ValueBc;
            record.CurrencyType = this.CurrencyType;
            record.SchemeId = this.SchemeId;
            record.NxtStage = this.NxtStage;
            record.NxtStgeDate = this.NxtStgeDate;
            record.Alarmdate = this.Alarmdate;
            record.Alarmtime = this.Alarmtime;
            record.SyllabusId = this.SyllabusId;
            record.SessionName = this.SessionName;
            record.ResourceId = this.ResourceId;
            record.Real = this.Real;
            record.Element = this.Element;
            record.Mandatory = this.Mandatory;
            record.InvoicePrint = this.InvoicePrint;
            record.MaxPlaces = this.MaxPlaces;
            record.MinPlaces = this.MinPlaces;
            record.FreePlaces = this.FreePlaces;
            record.Price = this.Price;
            record.BlockPrice = this.BlockPrice;
            record.PriceBc = this.PriceBc;
            record.BlockPriceBc = this.BlockPriceBc;
            record.Vatcd = this.Vatcd;
            record.RevCode = this.RevCode;
            record.CostCode = this.CostCode;
            record.DoNotInvoice = this.DoNotInvoice;
            record.FromBomType = this.FromBomType;
            record.RoomGrade = this.RoomGrade;
            record.TaskName = this.TaskName;
            record.TaskStatus = this.TaskStatus;
            record.EstHours = this.EstHours;
            record.ActualHours = this.ActualHours;
            record.Usernum1 = this.Usernum1;
            record.Usernum2 = this.Usernum2;
            record.Usernum3 = this.Usernum3;
            record.ReviewDate = this.ReviewDate;
            record.ReviewTime = this.ReviewTime;
            record.ProjId = this.ProjId;
            record.FilePath = this.FilePath;
            record.Bip = this.Bip;
            record.PartNote = this.PartNote;
            record.Period = this.Period;
            record.Overbook = this.Overbook;
            record.SessionName2 = this.SessionName2;
            record.OrgId = this.OrgId;
            record.Address = this.Address;
            record.PqId = this.PqId;
            record.PqStatus = this.PqStatus;
            record.PqStatusText = this.PqStatusText;
            record.PqSendType = this.PqSendType;
            record.PqSentDate = this.PqSentDate;
            record.PqKeep = this.PqKeep;
            record.MepId = this.MepId;
            record.TypeSub = this.TypeSub;
            record.AutoAllocate = this.AutoAllocate;
            record.WfId = this.WfId;
            record.EvrIncTot = this.EvrIncTot;
            record.EvrIncQuo = this.EvrIncQuo;
            record.AddId = this.AddId;
            record.Attendees = this.Attendees;
            record.CenId = this.CenId;
            record.RoomLayout = this.RoomLayout;
            record.NoteHtml = this.NoteHtml;
            record.Layout = this.Layout;
            record.PlacesToSet = this.PlacesToSet;
            record.ProdId = this.ProdId;
            record.StaffNeeded = this.StaffNeeded;
            record.TimePrep = this.TimePrep;
            record.TimeClean = this.TimeClean;
            record.TrnId = this.TrnId;
            record.Priority = this.Priority;
            record.Float = this.Float;
            record.AllocStatus = this.AllocStatus;
            record.DeptId = this.DeptId;
            record.RoomBooking = this.RoomBooking;
            record.ContprolId = this.ContprolId;
            record.ResType = this.ResType;
            record.Duration = this.Duration;
            record.PdId = this.PdId;
            record.SelcoSpId = this.SelcoSpId;
            record.IncInBudget = this.IncInBudget;
            record.VerCat = this.VerCat;
            record.PdpempId = this.PdpempId;
            record.AppBy = this.AppBy;
            record.AppDate = this.AppDate;
            record.NextReview = this.NextReview;
            record.InvId = this.InvId;
            record.Code = this.Code;
            record.SessionType = this.SessionType;
            record.TeachHrs = this.TeachHrs;
            record.StudWks = this.StudWks;
            record.NotinuseStart = this.NotinuseStart;
            record.NotinuseEnd = this.NotinuseEnd;
            record.ConfSessionOrder = this.ConfSessionOrder;
            record.AddedBy = this.AddedBy;
            record.OutlookUid = this.OutlookUid;
            record.UniqueRef = this.UniqueRef;
            record.NoSlots = this.NoSlots;
            record.Cancelled = this.Cancelled;
            record.Delete = this.Delete;
            record.BomId = this.BomId;
            record.Status = this.Status;
            record.Outcome = this.Outcome;
            record.QuestId = this.QuestId;
            record.BuildVersion = this.BuildVersion;
            record.LockedDate = this.LockedDate;
            record.Timeout = this.Timeout;
            record.CgCode = this.CgCode;
            record.ProvPack = this.ProvPack;
            record.ConfPack = this.ConfPack;
            record.JoiningPack = this.JoiningPack;
            record.PostPack = this.PostPack;
            record.PrejoinPack = this.PrejoinPack;
            record.PstjoinPack = this.PstjoinPack;
            record.ProvSentDte = this.ProvSentDte;
            record.ConfSentDte = this.ConfSentDte;
            record.JoinSentDte = this.JoinSentDte;
            record.PpSentDte = this.PpSentDte;
            record.PrjoinSentDte = this.PrjoinSentDte;
            record.PojoinSentDte = this.PojoinSentDte;
            record.Dropdown1 = this.Dropdown1;
            record.Dropdown2 = this.Dropdown2;
            record.RevenueSplit = this.RevenueSplit;
            record.HoursSplit = this.HoursSplit;
            record.Arrived = this.Arrived;
            record.ExpOccupancy = this.ExpOccupancy;
            record.Reserve = this.Reserve;
            record.VisitOutcome = this.VisitOutcome;
            record.TrnpId = this.TrnpId;
            record.ShowAttLog = this.ShowAttLog;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ActivityRecord" /> instance is equal to another <see cref="ActivityRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ActivityRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ActivityRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.DoneIt == that.DoneIt);
            result = result && (this.KeyNote.TrimOrNullify() == that.KeyNote.TrimOrNullify());
            result = result && (this.ActionDate == that.ActionDate);
            result = result && (this.Time == that.Time);
            result = result && (this.NextDate == that.NextDate);
            result = result && (this.EndDate == that.EndDate);
            result = result && (this.EndTime == that.EndTime);
            result = result && (this.LocId.TrimOrNullify() == that.LocId.TrimOrNullify());
            result = result && (this.Result.TrimOrNullify() == that.Result.TrimOrNullify());
            result = result && (this.PrevActiv.TrimOrNullify() == that.PrevActiv.TrimOrNullify());
            result = result && (this.PromotionId.TrimOrNullify() == that.PromotionId.TrimOrNullify());
            result = result && (this.BookId.TrimOrNullify() == that.BookId.TrimOrNullify());
            result = result && (this.CourseId.TrimOrNullify() == that.CourseId.TrimOrNullify());
            result = result && (this.TrainerId.TrimOrNullify() == that.TrainerId.TrimOrNullify());
            result = result && (this.TextId.TrimOrNullify() == that.TextId.TrimOrNullify());
            result = result && (this.Note.TrimOrNullify() == that.Note.TrimOrNullify());
            result = result && (this.DoneItDate == that.DoneItDate);
            result = result && (this.SourceCode.TrimOrNullify() == that.SourceCode.TrimOrNullify());
            result = result && (this.LastNo.TrimOrNullify() == that.LastNo.TrimOrNullify());
            result = result && (this.Hierarchy.TrimOrNullify() == that.Hierarchy.TrimOrNullify());
            result = result && (this.Level.TrimOrNullify() == that.Level.TrimOrNullify());
            result = result && (this.InitiatedBy == that.InitiatedBy);
            result = result && (this.ManIssues.TrimOrNullify() == that.ManIssues.TrimOrNullify());
            result = result && (this.VisitObj.TrimOrNullify() == that.VisitObj.TrimOrNullify());
            result = result && (this.Cb1 == that.Cb1);
            result = result && (this.Cb2 == that.Cb2);
            result = result && (this.Cb3 == that.Cb3);
            result = result && (this.Cb4 == that.Cb4);
            result = result && (this.Cb5 == that.Cb5);
            result = result && (this.Cb6 == that.Cb6);
            result = result && (this.Cb7 == that.Cb7);
            result = result && (this.Cb8 == that.Cb8);
            result = result && (this.Cb9 == that.Cb9);
            result = result && (this.Cb10 == that.Cb10);
            result = result && (this.OppId.TrimOrNullify() == that.OppId.TrimOrNullify());
            result = result && (this.HelpType.TrimOrNullify() == that.HelpType.TrimOrNullify());
            result = result && (this.ProductCode.TrimOrNullify() == that.ProductCode.TrimOrNullify());
            result = result && (this.ProductGroup.TrimOrNullify() == that.ProductGroup.TrimOrNullify());
            result = result && (this.PicId.TrimOrNullify() == that.PicId.TrimOrNullify());
            result = result && (this.ClosCat.TrimOrNullify() == that.ClosCat.TrimOrNullify());
            result = result && (this.ClosData.TrimOrNullify() == that.ClosData.TrimOrNullify());
            result = result && (this.Source.TrimOrNullify() == that.Source.TrimOrNullify());
            result = result && (this.Subject.TrimOrNullify() == that.Subject.TrimOrNullify());
            result = result && (this.SubText.TrimOrNullify() == that.SubText.TrimOrNullify());
            result = result && (this.ServiceType.TrimOrNullify() == that.ServiceType.TrimOrNullify());
            result = result && (this.ProblemCat.TrimOrNullify() == that.ProblemCat.TrimOrNullify());
            result = result && (this.InId.TrimOrNullify() == that.InId.TrimOrNullify());
            result = result && (this.Invoiced == that.Invoiced);
            result = result && (this.SupContRef.TrimOrNullify() == that.SupContRef.TrimOrNullify());
            result = result && (this.ChargeType.TrimOrNullify() == that.ChargeType.TrimOrNullify());
            result = result && (this.Minutes == that.Minutes);
            result = result && (this.Value == that.Value);
            result = result && (this.ValueBc == that.ValueBc);
            result = result && (this.CurrencyType.TrimOrNullify() == that.CurrencyType.TrimOrNullify());
            result = result && (this.SchemeId.TrimOrNullify() == that.SchemeId.TrimOrNullify());
            result = result && (this.NxtStage.TrimOrNullify() == that.NxtStage.TrimOrNullify());
            result = result && (this.NxtStgeDate == that.NxtStgeDate);
            result = result && (this.Alarmdate == that.Alarmdate);
            result = result && (this.Alarmtime == that.Alarmtime);
            result = result && (this.SyllabusId.TrimOrNullify() == that.SyllabusId.TrimOrNullify());
            result = result && (this.SessionName.TrimOrNullify() == that.SessionName.TrimOrNullify());
            result = result && (this.ResourceId.TrimOrNullify() == that.ResourceId.TrimOrNullify());
            result = result && (this.Real == that.Real);
            result = result && (this.Element == that.Element);
            result = result && (this.Mandatory == that.Mandatory);
            result = result && (this.InvoicePrint == that.InvoicePrint);
            result = result && (this.MaxPlaces == that.MaxPlaces);
            result = result && (this.MinPlaces == that.MinPlaces);
            result = result && (this.FreePlaces == that.FreePlaces);
            result = result && (this.Price == that.Price);
            result = result && (this.BlockPrice == that.BlockPrice);
            result = result && (this.PriceBc == that.PriceBc);
            result = result && (this.BlockPriceBc == that.BlockPriceBc);
            result = result && (this.Vatcd.TrimOrNullify() == that.Vatcd.TrimOrNullify());
            result = result && (this.RevCode.TrimOrNullify() == that.RevCode.TrimOrNullify());
            result = result && (this.CostCode.TrimOrNullify() == that.CostCode.TrimOrNullify());
            result = result && (this.DoNotInvoice == that.DoNotInvoice);
            result = result && (this.FromBomType.TrimOrNullify() == that.FromBomType.TrimOrNullify());
            result = result && (this.RoomGrade.TrimOrNullify() == that.RoomGrade.TrimOrNullify());
            result = result && (this.TaskName.TrimOrNullify() == that.TaskName.TrimOrNullify());
            result = result && (this.TaskStatus.TrimOrNullify() == that.TaskStatus.TrimOrNullify());
            result = result && (this.EstHours == that.EstHours);
            result = result && (this.ActualHours == that.ActualHours);
            result = result && (this.Usernum1 == that.Usernum1);
            result = result && (this.Usernum2 == that.Usernum2);
            result = result && (this.Usernum3 == that.Usernum3);
            result = result && (this.ReviewDate == that.ReviewDate);
            result = result && (this.ReviewTime == that.ReviewTime);
            result = result && (this.ProjId.TrimOrNullify() == that.ProjId.TrimOrNullify());
            result = result && (this.FilePath.TrimOrNullify() == that.FilePath.TrimOrNullify());
            result = result && (this.Bip == that.Bip);
            result = result && (this.PartNote.TrimOrNullify() == that.PartNote.TrimOrNullify());
            result = result && (this.Period.TrimOrNullify() == that.Period.TrimOrNullify());
            result = result && (this.Overbook == that.Overbook);
            result = result && (this.SessionName2.TrimOrNullify() == that.SessionName2.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.Address.TrimOrNullify() == that.Address.TrimOrNullify());
            result = result && (this.PqId.TrimOrNullify() == that.PqId.TrimOrNullify());
            result = result && (this.PqStatus.TrimOrNullify() == that.PqStatus.TrimOrNullify());
            result = result && (this.PqStatusText.TrimOrNullify() == that.PqStatusText.TrimOrNullify());
            result = result && (this.PqSendType.TrimOrNullify() == that.PqSendType.TrimOrNullify());
            result = result && (this.PqSentDate == that.PqSentDate);
            result = result && (this.PqKeep == that.PqKeep);
            result = result && (this.MepId.TrimOrNullify() == that.MepId.TrimOrNullify());
            result = result && (this.TypeSub.TrimOrNullify() == that.TypeSub.TrimOrNullify());
            result = result && (this.AutoAllocate == that.AutoAllocate);
            result = result && (this.WfId.TrimOrNullify() == that.WfId.TrimOrNullify());
            result = result && (this.EvrIncTot == that.EvrIncTot);
            result = result && (this.EvrIncQuo == that.EvrIncQuo);
            result = result && (this.AddId.TrimOrNullify() == that.AddId.TrimOrNullify());
            result = result && (this.Attendees.TrimOrNullify() == that.Attendees.TrimOrNullify());
            result = result && (this.CenId.TrimOrNullify() == that.CenId.TrimOrNullify());
            result = result && (this.RoomLayout == that.RoomLayout);
            result = result && (this.NoteHtml.TrimOrNullify() == that.NoteHtml.TrimOrNullify());
            result = result && (this.Layout == that.Layout);
            result = result && (this.PlacesToSet == that.PlacesToSet);
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.StaffNeeded == that.StaffNeeded);
            result = result && (this.TimePrep == that.TimePrep);
            result = result && (this.TimeClean == that.TimeClean);
            result = result && (this.TrnId.TrimOrNullify() == that.TrnId.TrimOrNullify());
            result = result && (this.Priority.TrimOrNullify() == that.Priority.TrimOrNullify());
            result = result && (this.Float == that.Float);
            result = result && (this.AllocStatus == that.AllocStatus);
            result = result && (this.DeptId.TrimOrNullify() == that.DeptId.TrimOrNullify());
            result = result && (this.RoomBooking == that.RoomBooking);
            result = result && (this.ContprolId.TrimOrNullify() == that.ContprolId.TrimOrNullify());
            result = result && (this.ResType.TrimOrNullify() == that.ResType.TrimOrNullify());
            result = result && (this.Duration == that.Duration);
            result = result && (this.PdId.TrimOrNullify() == that.PdId.TrimOrNullify());
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.IncInBudget == that.IncInBudget);
            result = result && (this.VerCat.TrimOrNullify() == that.VerCat.TrimOrNullify());
            result = result && (this.PdpempId == that.PdpempId);
            result = result && (this.AppBy.TrimOrNullify() == that.AppBy.TrimOrNullify());
            result = result && (this.AppDate == that.AppDate);
            result = result && (this.NextReview == that.NextReview);
            result = result && (this.InvId.TrimOrNullify() == that.InvId.TrimOrNullify());
            result = result && (this.Code.TrimOrNullify() == that.Code.TrimOrNullify());
            result = result && (this.SessionType.TrimOrNullify() == that.SessionType.TrimOrNullify());
            result = result && (this.TeachHrs == that.TeachHrs);
            result = result && (this.StudWks == that.StudWks);
            result = result && (this.NotinuseStart == that.NotinuseStart);
            result = result && (this.NotinuseEnd == that.NotinuseEnd);
            result = result && (this.ConfSessionOrder == that.ConfSessionOrder);
            result = result && (this.AddedBy == that.AddedBy);
            result = result && (this.OutlookUid.TrimOrNullify() == that.OutlookUid.TrimOrNullify());
            result = result && (this.UniqueRef.TrimOrNullify() == that.UniqueRef.TrimOrNullify());
            result = result && (this.NoSlots == that.NoSlots);
            result = result && (this.Cancelled == that.Cancelled);
            result = result && (this.Delete == that.Delete);
            result = result && (this.BomId.TrimOrNullify() == that.BomId.TrimOrNullify());
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.Outcome.TrimOrNullify() == that.Outcome.TrimOrNullify());
            result = result && (this.QuestId.TrimOrNullify() == that.QuestId.TrimOrNullify());
            result = result && (this.BuildVersion.TrimOrNullify() == that.BuildVersion.TrimOrNullify());
            result = result && (this.LockedDate == that.LockedDate);
            result = result && (this.Timeout == that.Timeout);
            result = result && (this.CgCode.TrimOrNullify() == that.CgCode.TrimOrNullify());
            result = result && (this.ProvPack.TrimOrNullify() == that.ProvPack.TrimOrNullify());
            result = result && (this.ConfPack.TrimOrNullify() == that.ConfPack.TrimOrNullify());
            result = result && (this.JoiningPack.TrimOrNullify() == that.JoiningPack.TrimOrNullify());
            result = result && (this.PostPack.TrimOrNullify() == that.PostPack.TrimOrNullify());
            result = result && (this.PrejoinPack.TrimOrNullify() == that.PrejoinPack.TrimOrNullify());
            result = result && (this.PstjoinPack.TrimOrNullify() == that.PstjoinPack.TrimOrNullify());
            result = result && (this.ProvSentDte == that.ProvSentDte);
            result = result && (this.ConfSentDte == that.ConfSentDte);
            result = result && (this.JoinSentDte == that.JoinSentDte);
            result = result && (this.PpSentDte == that.PpSentDte);
            result = result && (this.PrjoinSentDte == that.PrjoinSentDte);
            result = result && (this.PojoinSentDte == that.PojoinSentDte);
            result = result && (this.Dropdown1.TrimOrNullify() == that.Dropdown1.TrimOrNullify());
            result = result && (this.Dropdown2.TrimOrNullify() == that.Dropdown2.TrimOrNullify());
            result = result && (this.RevenueSplit == that.RevenueSplit);
            result = result && (this.HoursSplit == that.HoursSplit);
            result = result && (this.Arrived == that.Arrived);
            result = result && (this.ExpOccupancy == that.ExpOccupancy);
            result = result && (this.Reserve == that.Reserve);
            result = result && (this.VisitOutcome.TrimOrNullify() == that.VisitOutcome.TrimOrNullify());
            result = result && (this.TrnpId == that.TrnpId);
            result = result && (this.ShowAttLog == that.ShowAttLog);
            return result;
        }

        #endregion
    }
}
