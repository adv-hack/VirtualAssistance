using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Represents the "Promotion_Master" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PromotionMasterRecord : Record<String>, Cloneable<PromotionMasterRecord>, IEquatable<PromotionMasterRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PM_MST_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "PM_MST_START_DATE" field.
        /// </summary>
        private DateTime? _startDate;

        /// <summary>
        ///     the value of the "PM_MST_END_DATE" field.
        /// </summary>
        private DateTime? _endDate;

        /// <summary>
        ///     the value of the "PM_MST_REGION" field.
        /// </summary>
        private String _region;

        /// <summary>
        ///     the value of the "PM_MST_OBJ_TEXT_ID" field.
        /// </summary>
        private String _objTextId;

        /// <summary>
        ///     the value of the "PM_MST_SEL_TEXT_ID" field.
        /// </summary>
        private String _selTextId;

        /// <summary>
        ///     the value of the "PM_MST_RVW_TEXT_ID" field.
        /// </summary>
        private String _rvwTextId;

        /// <summary>
        ///     the value of the "PM_MST_BUDGET_COST" field.
        /// </summary>
        private Double? _budgetCost;

        /// <summary>
        ///     the value of the "PM_MST_ACTUAL_COST" field.
        /// </summary>
        private Double? _actualCost;

        /// <summary>
        ///     the value of the "PM_MST_REPLIES" field.
        /// </summary>
        private Double? _replies;

        /// <summary>
        ///     the value of the "PM_MST_ORDERS" field.
        /// </summary>
        private Double? _orders;

        /// <summary>
        ///     the value of the "PM_MST_ORDER_VALUE" field.
        /// </summary>
        private Double? _orderValue;

        /// <summary>
        ///     the value of the "PM_MST_UPDATED" field.
        /// </summary>
        private DateTime? _updated;

        /// <summary>
        ///     the value of the "PM_MST_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PM_MST_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PM_MST_MOD_BY_SYS" field.
        /// </summary>
        private String _modBySys;

        /// <summary>
        ///     the value of the "PM_MST_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PM_MST_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PM_MST_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "PM_MST_BDGT_CST_BC" field.
        /// </summary>
        private Double? _bdgtCstBc;

        /// <summary>
        ///     the value of the "PM_MST_ACTL_CST_BC" field.
        /// </summary>
        private Double? _actlCstBc;

        /// <summary>
        ///     the value of the "PM_MST_ORDR_VAL_BC" field.
        /// </summary>
        private Double? _ordrValBc;

        /// <summary>
        ///     the value of the "PM_MST_CURR_TYPE" field.
        /// </summary>
        private String _currType;

        /// <summary>
        ///     the value of the "PM_MST_CMP_ID" field.
        /// </summary>
        private String _cmpId;

        /// <summary>
        ///     the value of the "PM_MST_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PM_MST_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PM_MST_MAILINGS" field.
        /// </summary>
        private Int32? _mailings;

        /// <summary>
        ///     the value of the "PM_MST_TELESALES" field.
        /// </summary>
        private Int32? _telesales;

        /// <summary>
        ///     the value of the "PM_MST_BOOKINGS" field.
        /// </summary>
        private Int32? _bookings;

        /// <summary>
        ///     the value of the "PM_MST_OPP_TOT" field.
        /// </summary>
        private Int32? _oppTot;

        /// <summary>
        ///     the value of the "PM_MST_QUOTES" field.
        /// </summary>
        private Int32? _quotes;

        /// <summary>
        ///     the value of the "PM_MST_QUO_VAL" field.
        /// </summary>
        private Double? _quoVal;

        /// <summary>
        ///     the value of the "PM_MST_SALES" field.
        /// </summary>
        private Int32? _sales;

        /// <summary>
        ///     the value of the "PM_MST_SALE_VAL" field.
        /// </summary>
        private Double? _saleVal;

        /// <summary>
        ///     the value of the "PM_MST_CALC_ACT" field.
        /// </summary>
        private Double? _calcAct;

        /// <summary>
        ///     the value of the "PM_MST_CALC_EST" field.
        /// </summary>
        private Double? _calcEst;

        /// <summary>
        ///     the value of the "PM_MST_BOOK_VAL" field.
        /// </summary>
        private Double? _bookVal;

        /// <summary>
        ///     the value of the "PM_MST_COURSE_ID" field.
        /// </summary>
        private String _courseId;

        /// <summary>
        ///     the value of the "PM_MST_CODE" field.
        /// </summary>
        private String _code;

        /// <summary>
        ///     the value of the "PM_MST_TYPE" field.
        /// </summary>
        private Byte? _type;

        /// <summary>
        ///     the value of the "PM_MST_TARGET_OPP" field.
        /// </summary>
        private Int32? _targetOpp;

        /// <summary>
        ///     the value of the "PM_MST_TARGET_REPLIES" field.
        /// </summary>
        private Int32? _targetReplies;

        /// <summary>
        ///     the value of the "PM_MST_TARGET_OPP_VAL" field.
        /// </summary>
        private Double? _targetOppVal;

        /// <summary>
        ///     the value of the "PM_MST_TARGET_BOOK_VAL" field.
        /// </summary>
        private Double? _targetBookVal;

        /// <summary>
        ///     the value of the "PM_MST_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "PM_MST_APP_PROLE_ID" field.
        /// </summary>
        private String _appProleId;

        /// <summary>
        ///     the value of the "PM_MST_EMAILS_SENT" field.
        /// </summary>
        private Int32 _emailsSent;

        /// <summary>
        ///     the value of the "PM_MST_EMAILS_OPENED" field.
        /// </summary>
        private Int32 _emailsOpened;

        /// <summary>
        ///     the value of the "PM_MST_LINKS_CLICKED" field.
        /// </summary>
        private Int32 _linksClicked;

        /// <summary>
        ///     the value of the "PM_MST_LZ_CLICKED" field.
        /// </summary>
        private Int32 _lzClicked;

        /// <summary>
        ///     the value of the "PM_MST_SURVEYS_COMPLETED" field.
        /// </summary>
        private Int32 _surveysCompleted;

        /// <summary>
        ///     the value of the "PM_MST_GLOBAL_UNSUBSCRIBES" field.
        /// </summary>
        private Int32 _globalUnsubscribes;

        /// <summary>
        ///     the value of the "PM_MST_LIST_UNSUBSCRIBES" field.
        /// </summary>
        private Int32 _listUnsubscribes;

        /// <summary>
        ///     the value of the "PM_MST_DOCS_DOWNLOADS" field.
        /// </summary>
        private Int32 _docsDownloads;

        /// <summary>
        ///     the value of the "PM_MST_BOUNCE_BACKS" field.
        /// </summary>
        private Int32 _bounceBacks;

        /// <summary>
        ///     the value of the "PM_MST_EMAILS_SENT_TARGET" field.
        /// </summary>
        private Int32 _emailsSentTarget;

        /// <summary>
        ///     the value of the "PM_MST_EMAILS_OPENED_TARGET" field.
        /// </summary>
        private Int32 _emailsOpenedTarget;

        /// <summary>
        ///     the value of the "PM_MST_LINKS_CLICKED_TARGET" field.
        /// </summary>
        private Int32 _linksClickedTarget;

        /// <summary>
        ///     the value of the "PM_MST_LZ_CLICKED_TARGET" field.
        /// </summary>
        private Int32 _lzClickedTarget;

        /// <summary>
        ///     the value of the "PM_MST_SURVEYS_COMPLETED_TARGET" field.
        /// </summary>
        private Int32 _surveysCompletedTarget;

        /// <summary>
        ///     the value of the "PM_MST_GLOBAL_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        private Int32 _globalUnsubscribesTarget;

        /// <summary>
        ///     the value of the "PM_MST_LIST_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        private Int32 _listUnsubscribesTarget;

        /// <summary>
        ///     the value of the "PM_MST_DOCS_DOWNLOADS_TARGET" field.
        /// </summary>
        private Int32 _docsDownloadsTarget;

        /// <summary>
        ///     the value of the "PM_MST_BOUNCE_BACKS_TARGET" field.
        /// </summary>
        private Int32 _bounceBacksTarget;

        /// <summary>
        ///     the value of the "PM_MST_QCODE" field.
        /// </summary>
        private String _qcode;

        /// <summary>
        ///     the value of the "PM_MST_FQCODE" field.
        /// </summary>
        private String _fqcode;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PM_MST_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_REGION" field.
        /// </summary>
        public String Region
        {
            get { return _region; }
            set { _region = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_OBJ_TEXT_ID" field.
        /// </summary>
        public String ObjTextId
        {
            get { return _objTextId; }
            set { _objTextId = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_SEL_TEXT_ID" field.
        /// </summary>
        public String SelTextId
        {
            get { return _selTextId; }
            set { _selTextId = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_RVW_TEXT_ID" field.
        /// </summary>
        public String RvwTextId
        {
            get { return _rvwTextId; }
            set { _rvwTextId = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_BUDGET_COST" field.
        /// </summary>
        public Double? BudgetCost
        {
            get { return _budgetCost; }
            set { _budgetCost = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_ACTUAL_COST" field.
        /// </summary>
        public Double? ActualCost
        {
            get { return _actualCost; }
            set { _actualCost = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_REPLIES" field.
        /// </summary>
        public Double? Replies
        {
            get { return _replies; }
            set { _replies = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_ORDERS" field.
        /// </summary>
        public Double? Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_ORDER_VALUE" field.
        /// </summary>
        public Double? OrderValue
        {
            get { return _orderValue; }
            set { _orderValue = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_UPDATED" field.
        /// </summary>
        public DateTime? Updated
        {
            get { return _updated; }
            set { _updated = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_MOD_BY_SYS" field.
        /// </summary>
        public String ModBySys
        {
            get { return _modBySys; }
            set { _modBySys = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_BDGT_CST_BC" field.
        /// </summary>
        public Double? BdgtCstBc
        {
            get { return _bdgtCstBc; }
            set { _bdgtCstBc = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_ACTL_CST_BC" field.
        /// </summary>
        public Double? ActlCstBc
        {
            get { return _actlCstBc; }
            set { _actlCstBc = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_ORDR_VAL_BC" field.
        /// </summary>
        public Double? OrdrValBc
        {
            get { return _ordrValBc; }
            set { _ordrValBc = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_CURR_TYPE" field.
        /// </summary>
        public String CurrType
        {
            get { return _currType; }
            set { _currType = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_CMP_ID" field.
        /// </summary>
        public String CmpId
        {
            get { return _cmpId; }
            set { _cmpId = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_MAILINGS" field.
        /// </summary>
        public Int32? Mailings
        {
            get { return _mailings; }
            set { _mailings = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_TELESALES" field.
        /// </summary>
        public Int32? Telesales
        {
            get { return _telesales; }
            set { _telesales = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_BOOKINGS" field.
        /// </summary>
        public Int32? Bookings
        {
            get { return _bookings; }
            set { _bookings = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_OPP_TOT" field.
        /// </summary>
        public Int32? OppTot
        {
            get { return _oppTot; }
            set { _oppTot = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_QUOTES" field.
        /// </summary>
        public Int32? Quotes
        {
            get { return _quotes; }
            set { _quotes = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_QUO_VAL" field.
        /// </summary>
        public Double? QuoVal
        {
            get { return _quoVal; }
            set { _quoVal = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_SALES" field.
        /// </summary>
        public Int32? Sales
        {
            get { return _sales; }
            set { _sales = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_SALE_VAL" field.
        /// </summary>
        public Double? SaleVal
        {
            get { return _saleVal; }
            set { _saleVal = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_CALC_ACT" field.
        /// </summary>
        public Double? CalcAct
        {
            get { return _calcAct; }
            set { _calcAct = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_CALC_EST" field.
        /// </summary>
        public Double? CalcEst
        {
            get { return _calcEst; }
            set { _calcEst = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_BOOK_VAL" field.
        /// </summary>
        public Double? BookVal
        {
            get { return _bookVal; }
            set { _bookVal = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_COURSE_ID" field.
        /// </summary>
        public String CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_CODE" field.
        /// </summary>
        public String Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_TARGET_OPP" field.
        /// </summary>
        public Int32? TargetOpp
        {
            get { return _targetOpp; }
            set { _targetOpp = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_TARGET_REPLIES" field.
        /// </summary>
        public Int32? TargetReplies
        {
            get { return _targetReplies; }
            set { _targetReplies = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_TARGET_OPP_VAL" field.
        /// </summary>
        public Double? TargetOppVal
        {
            get { return _targetOppVal; }
            set { _targetOppVal = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_TARGET_BOOK_VAL" field.
        /// </summary>
        public Double? TargetBookVal
        {
            get { return _targetBookVal; }
            set { _targetBookVal = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_APP_PROLE_ID" field.
        /// </summary>
        public String AppProleId
        {
            get { return _appProleId; }
            set { _appProleId = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_EMAILS_SENT" field.
        /// </summary>
        public Int32 EmailsSent
        {
            get { return _emailsSent; }
            set { _emailsSent = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_EMAILS_OPENED" field.
        /// </summary>
        public Int32 EmailsOpened
        {
            get { return _emailsOpened; }
            set { _emailsOpened = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_LINKS_CLICKED" field.
        /// </summary>
        public Int32 LinksClicked
        {
            get { return _linksClicked; }
            set { _linksClicked = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_LZ_CLICKED" field.
        /// </summary>
        public Int32 LzClicked
        {
            get { return _lzClicked; }
            set { _lzClicked = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_SURVEYS_COMPLETED" field.
        /// </summary>
        public Int32 SurveysCompleted
        {
            get { return _surveysCompleted; }
            set { _surveysCompleted = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_GLOBAL_UNSUBSCRIBES" field.
        /// </summary>
        public Int32 GlobalUnsubscribes
        {
            get { return _globalUnsubscribes; }
            set { _globalUnsubscribes = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_LIST_UNSUBSCRIBES" field.
        /// </summary>
        public Int32 ListUnsubscribes
        {
            get { return _listUnsubscribes; }
            set { _listUnsubscribes = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_DOCS_DOWNLOADS" field.
        /// </summary>
        public Int32 DocsDownloads
        {
            get { return _docsDownloads; }
            set { _docsDownloads = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_BOUNCE_BACKS" field.
        /// </summary>
        public Int32 BounceBacks
        {
            get { return _bounceBacks; }
            set { _bounceBacks = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_EMAILS_SENT_TARGET" field.
        /// </summary>
        public Int32 EmailsSentTarget
        {
            get { return _emailsSentTarget; }
            set { _emailsSentTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_EMAILS_OPENED_TARGET" field.
        /// </summary>
        public Int32 EmailsOpenedTarget
        {
            get { return _emailsOpenedTarget; }
            set { _emailsOpenedTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_LINKS_CLICKED_TARGET" field.
        /// </summary>
        public Int32 LinksClickedTarget
        {
            get { return _linksClickedTarget; }
            set { _linksClickedTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_LZ_CLICKED_TARGET" field.
        /// </summary>
        public Int32 LzClickedTarget
        {
            get { return _lzClickedTarget; }
            set { _lzClickedTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_SURVEYS_COMPLETED_TARGET" field.
        /// </summary>
        public Int32 SurveysCompletedTarget
        {
            get { return _surveysCompletedTarget; }
            set { _surveysCompletedTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_GLOBAL_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        public Int32 GlobalUnsubscribesTarget
        {
            get { return _globalUnsubscribesTarget; }
            set { _globalUnsubscribesTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_LIST_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        public Int32 ListUnsubscribesTarget
        {
            get { return _listUnsubscribesTarget; }
            set { _listUnsubscribesTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_DOCS_DOWNLOADS_TARGET" field.
        /// </summary>
        public Int32 DocsDownloadsTarget
        {
            get { return _docsDownloadsTarget; }
            set { _docsDownloadsTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_BOUNCE_BACKS_TARGET" field.
        /// </summary>
        public Int32 BounceBacksTarget
        {
            get { return _bounceBacksTarget; }
            set { _bounceBacksTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_QCODE" field.
        /// </summary>
        public String Qcode
        {
            get { return _qcode; }
            set { _qcode = value; }
        }

        /// <summary>
        ///     the value of the "PM_MST_FQCODE" field.
        /// </summary>
        public String Fqcode
        {
            get { return _fqcode; }
            set { _fqcode = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PromotionMasterRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PromotionMasterRecord" /> object instance.
        /// </returns>
        public PromotionMasterRecord Clone()
        {
            PromotionMasterRecord record = new PromotionMasterRecord();
            record.Id = this.Id;
            record.Name = this.Name;
            record.StartDate = this.StartDate;
            record.EndDate = this.EndDate;
            record.Region = this.Region;
            record.ObjTextId = this.ObjTextId;
            record.SelTextId = this.SelTextId;
            record.RvwTextId = this.RvwTextId;
            record.BudgetCost = this.BudgetCost;
            record.ActualCost = this.ActualCost;
            record.Replies = this.Replies;
            record.Orders = this.Orders;
            record.OrderValue = this.OrderValue;
            record.Updated = this.Updated;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.ModBySys = this.ModBySys;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.Lock = this.Lock;
            record.BdgtCstBc = this.BdgtCstBc;
            record.ActlCstBc = this.ActlCstBc;
            record.OrdrValBc = this.OrdrValBc;
            record.CurrType = this.CurrType;
            record.CmpId = this.CmpId;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Mailings = this.Mailings;
            record.Telesales = this.Telesales;
            record.Bookings = this.Bookings;
            record.OppTot = this.OppTot;
            record.Quotes = this.Quotes;
            record.QuoVal = this.QuoVal;
            record.Sales = this.Sales;
            record.SaleVal = this.SaleVal;
            record.CalcAct = this.CalcAct;
            record.CalcEst = this.CalcEst;
            record.BookVal = this.BookVal;
            record.CourseId = this.CourseId;
            record.Code = this.Code;
            record.Type = this.Type;
            record.TargetOpp = this.TargetOpp;
            record.TargetReplies = this.TargetReplies;
            record.TargetOppVal = this.TargetOppVal;
            record.TargetBookVal = this.TargetBookVal;
            record.ProleId = this.ProleId;
            record.AppProleId = this.AppProleId;
            record.EmailsSent = this.EmailsSent;
            record.EmailsOpened = this.EmailsOpened;
            record.LinksClicked = this.LinksClicked;
            record.LzClicked = this.LzClicked;
            record.SurveysCompleted = this.SurveysCompleted;
            record.GlobalUnsubscribes = this.GlobalUnsubscribes;
            record.ListUnsubscribes = this.ListUnsubscribes;
            record.DocsDownloads = this.DocsDownloads;
            record.BounceBacks = this.BounceBacks;
            record.EmailsSentTarget = this.EmailsSentTarget;
            record.EmailsOpenedTarget = this.EmailsOpenedTarget;
            record.LinksClickedTarget = this.LinksClickedTarget;
            record.LzClickedTarget = this.LzClickedTarget;
            record.SurveysCompletedTarget = this.SurveysCompletedTarget;
            record.GlobalUnsubscribesTarget = this.GlobalUnsubscribesTarget;
            record.ListUnsubscribesTarget = this.ListUnsubscribesTarget;
            record.DocsDownloadsTarget = this.DocsDownloadsTarget;
            record.BounceBacksTarget = this.BounceBacksTarget;
            record.Qcode = this.Qcode;
            record.Fqcode = this.Fqcode;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PromotionMasterRecord" /> instance is equal to another <see cref="PromotionMasterRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PromotionMasterRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PromotionMasterRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.StartDate == that.StartDate);
            result = result && (this.EndDate == that.EndDate);
            result = result && (this.Region.TrimOrNullify() == that.Region.TrimOrNullify());
            result = result && (this.ObjTextId.TrimOrNullify() == that.ObjTextId.TrimOrNullify());
            result = result && (this.SelTextId.TrimOrNullify() == that.SelTextId.TrimOrNullify());
            result = result && (this.RvwTextId.TrimOrNullify() == that.RvwTextId.TrimOrNullify());
            result = result && (this.BudgetCost == that.BudgetCost);
            result = result && (this.ActualCost == that.ActualCost);
            result = result && (this.Replies == that.Replies);
            result = result && (this.Orders == that.Orders);
            result = result && (this.OrderValue == that.OrderValue);
            result = result && (this.Updated == that.Updated);
            result = result && (this.ModBySys.TrimOrNullify() == that.ModBySys.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.BdgtCstBc == that.BdgtCstBc);
            result = result && (this.ActlCstBc == that.ActlCstBc);
            result = result && (this.OrdrValBc == that.OrdrValBc);
            result = result && (this.CurrType.TrimOrNullify() == that.CurrType.TrimOrNullify());
            result = result && (this.CmpId.TrimOrNullify() == that.CmpId.TrimOrNullify());
            result = result && (this.Mailings == that.Mailings);
            result = result && (this.Telesales == that.Telesales);
            result = result && (this.Bookings == that.Bookings);
            result = result && (this.OppTot == that.OppTot);
            result = result && (this.Quotes == that.Quotes);
            result = result && (this.QuoVal == that.QuoVal);
            result = result && (this.Sales == that.Sales);
            result = result && (this.SaleVal == that.SaleVal);
            result = result && (this.CalcAct == that.CalcAct);
            result = result && (this.CalcEst == that.CalcEst);
            result = result && (this.BookVal == that.BookVal);
            result = result && (this.CourseId.TrimOrNullify() == that.CourseId.TrimOrNullify());
            result = result && (this.Code.TrimOrNullify() == that.Code.TrimOrNullify());
            result = result && (this.Type == that.Type);
            result = result && (this.TargetOpp == that.TargetOpp);
            result = result && (this.TargetReplies == that.TargetReplies);
            result = result && (this.TargetOppVal == that.TargetOppVal);
            result = result && (this.TargetBookVal == that.TargetBookVal);
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.AppProleId.TrimOrNullify() == that.AppProleId.TrimOrNullify());
            result = result && (this.EmailsSent == that.EmailsSent);
            result = result && (this.EmailsOpened == that.EmailsOpened);
            result = result && (this.LinksClicked == that.LinksClicked);
            result = result && (this.LzClicked == that.LzClicked);
            result = result && (this.SurveysCompleted == that.SurveysCompleted);
            result = result && (this.GlobalUnsubscribes == that.GlobalUnsubscribes);
            result = result && (this.ListUnsubscribes == that.ListUnsubscribes);
            result = result && (this.DocsDownloads == that.DocsDownloads);
            result = result && (this.BounceBacks == that.BounceBacks);
            result = result && (this.EmailsSentTarget == that.EmailsSentTarget);
            result = result && (this.EmailsOpenedTarget == that.EmailsOpenedTarget);
            result = result && (this.LinksClickedTarget == that.LinksClickedTarget);
            result = result && (this.LzClickedTarget == that.LzClickedTarget);
            result = result && (this.SurveysCompletedTarget == that.SurveysCompletedTarget);
            result = result && (this.GlobalUnsubscribesTarget == that.GlobalUnsubscribesTarget);
            result = result && (this.ListUnsubscribesTarget == that.ListUnsubscribesTarget);
            result = result && (this.DocsDownloadsTarget == that.DocsDownloadsTarget);
            result = result && (this.BounceBacksTarget == that.BounceBacksTarget);
            result = result && (this.Qcode.TrimOrNullify() == that.Qcode.TrimOrNullify());
            result = result && (this.Fqcode.TrimOrNullify() == that.Fqcode.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
