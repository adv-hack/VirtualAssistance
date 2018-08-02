using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Represents the "Promotion" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PromotionRecord : Record<String>, Cloneable<PromotionRecord>, IEquatable<PromotionRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PM_CMP_ID" field.
        /// </summary>
        private String _cmpId;

        /// <summary>
        ///     the value of the "PM_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "PM_START_DATE" field.
        /// </summary>
        private DateTime? _startDate;

        /// <summary>
        ///     the value of the "PM_CHANNEL" field.
        /// </summary>
        private String _channel;

        /// <summary>
        ///     the value of the "PM_TEXT_ID" field.
        /// </summary>
        private String _textId;

        /// <summary>
        ///     the value of the "PM_DM_NUMBER" field.
        /// </summary>
        private Double? _dmNumber;

        /// <summary>
        ///     the value of the "PM_REPLIES" field.
        /// </summary>
        private Double? _replies;

        /// <summary>
        ///     the value of the "PM_ORDERS" field.
        /// </summary>
        private Double? _orders;

        /// <summary>
        ///     the value of the "PM_ORDER_VAL" field.
        /// </summary>
        private Double? _orderVal;

        /// <summary>
        ///     the value of the "PM_BUDGET_COST" field.
        /// </summary>
        private Double? _budgetCost;

        /// <summary>
        ///     the value of the "PM_ACTUAL_COST" field.
        /// </summary>
        private Double? _actualCost;

        /// <summary>
        ///     the value of the "PM_UPDATED" field.
        /// </summary>
        private DateTime? _updated;

        /// <summary>
        ///     the value of the "PM_CURRENT" field.
        /// </summary>
        private Byte? _current;

        /// <summary>
        ///     the value of the "PM_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PM_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PM_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PM_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PM_MOD_BY_SYS" field.
        /// </summary>
        private String _modBySys;

        /// <summary>
        ///     the value of the "PM_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "PM_ORDER_VALUE_BC" field.
        /// </summary>
        private Double? _orderValueBc;

        /// <summary>
        ///     the value of the "PM_BUDGET_COST_BC" field.
        /// </summary>
        private Double? _budgetCostBc;

        /// <summary>
        ///     the value of the "PM_ACTUAL_COST_BC" field.
        /// </summary>
        private Double? _actualCostBc;

        /// <summary>
        ///     the value of the "PM_CURRENCY_TYPE" field.
        /// </summary>
        private String _currencyType;

        /// <summary>
        ///     the value of the "PM_MEDIA_NAME" field.
        /// </summary>
        private String _mediaName;

        /// <summary>
        ///     the value of the "PM_SCHEME_ID" field.
        /// </summary>
        private String _schemeId;

        /// <summary>
        ///     the value of the "PM_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PM_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PM_TELESALES" field.
        /// </summary>
        private Int32? _telesales;

        /// <summary>
        ///     the value of the "PM_BOOKING" field.
        /// </summary>
        private Int32? _booking;

        /// <summary>
        ///     the value of the "PM_BOOK_VALUE" field.
        /// </summary>
        private Double? _bookValue;

        /// <summary>
        ///     the value of the "PM_OPP_TOT" field.
        /// </summary>
        private Int32? _oppTot;

        /// <summary>
        ///     the value of the "PM_QUOTES" field.
        /// </summary>
        private Int32? _quotes;

        /// <summary>
        ///     the value of the "PM_QUO_VALUE" field.
        /// </summary>
        private Double? _quoValue;

        /// <summary>
        ///     the value of the "PM_SALES" field.
        /// </summary>
        private Int32? _sales;

        /// <summary>
        ///     the value of the "PM_SALE_VALUE" field.
        /// </summary>
        private Double? _saleValue;

        /// <summary>
        ///     the value of the "PM_USERNUM_1" field.
        /// </summary>
        private Double? _usernum1;

        /// <summary>
        ///     the value of the "PM_USERNUM_2" field.
        /// </summary>
        private Double? _usernum2;

        /// <summary>
        ///     the value of the "PM_CODE" field.
        /// </summary>
        private String _code;

        /// <summary>
        ///     the value of the "PM_PACK_ID" field.
        /// </summary>
        private String _packId;

        /// <summary>
        ///     the value of the "PM_OUT_DATE" field.
        /// </summary>
        private DateTime? _outDate;

        /// <summary>
        ///     the value of the "PM_FOOTER" field.
        /// </summary>
        private String _footer;

        /// <summary>
        ///     the value of the "PM_UNSUBSCRIBE" field.
        /// </summary>
        private String _unsubscribe;

        /// <summary>
        ///     the value of the "PM_HEADER" field.
        /// </summary>
        private String _header;

        /// <summary>
        ///     the value of the "PM_BODY" field.
        /// </summary>
        private String _body;

        /// <summary>
        ///     the value of the "PM_APPROVE" field.
        /// </summary>
        private String _approve;

        /// <summary>
        ///     the value of the "PM_REPLY" field.
        /// </summary>
        private String _reply;

        /// <summary>
        ///     the value of the "PM_TIME" field.
        /// </summary>
        private DateTime? _time;

        /// <summary>
        ///     the value of the "PM_E_STATUS" field.
        /// </summary>
        private Byte? _eStatus;

        /// <summary>
        ///     the value of the "PM_JOB_TITLE" field.
        /// </summary>
        private String _jobTitle;

        /// <summary>
        ///     the value of the "PM_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "PM_E_TYPE" field.
        /// </summary>
        private String _eType;

        /// <summary>
        ///     the value of the "PM_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "PM_APP_PROLE_ID" field.
        /// </summary>
        private String _appProleId;

        /// <summary>
        ///     the value of the "PM_RUN_TIME" field.
        /// </summary>
        private DateTime? _runTime;

        /// <summary>
        ///     the value of the "PM_FINISH_TIME" field.
        /// </summary>
        private DateTime? _finishTime;

        /// <summary>
        ///     the value of the "PM_GOOD_MAIL" field.
        /// </summary>
        private Int32? _goodMail;

        /// <summary>
        ///     the value of the "PM_BAD_MAIL" field.
        /// </summary>
        private Int32? _badMail;

        /// <summary>
        ///     the value of the "PM_SMTP_HOST" field.
        /// </summary>
        private String _smtpHost;

        /// <summary>
        ///     the value of the "PM_EMAIL_DESC" field.
        /// </summary>
        private String _emailDesc;

        /// <summary>
        ///     the value of the "PM_ACTUAL_VAR_COST" field.
        /// </summary>
        private Double? _actualVarCost;

        /// <summary>
        ///     the value of the "PM_ACTUAL_FIX_COST" field.
        /// </summary>
        private Double? _actualFixCost;

        /// <summary>
        ///     the value of the "PM_BUDGET_VAR_COST" field.
        /// </summary>
        private Double? _budgetVarCost;

        /// <summary>
        ///     the value of the "PM_BUDGET_FIX_COST" field.
        /// </summary>
        private Double? _budgetFixCost;

        /// <summary>
        ///     the value of the "PM_TARGET_OPP" field.
        /// </summary>
        private Int32? _targetOpp;

        /// <summary>
        ///     the value of the "PM_TARGET_REPLIES" field.
        /// </summary>
        private Int32? _targetReplies;

        /// <summary>
        ///     the value of the "PM_TARGET_OPP_VAL" field.
        /// </summary>
        private Double? _targetOppVal;

        /// <summary>
        ///     the value of the "PM_TARGET_BOOK_VAL" field.
        /// </summary>
        private Double? _targetBookVal;

        /// <summary>
        ///     the value of the "PM_TARGET_COMPLAINTS" field.
        /// </summary>
        private Int32? _targetComplaints;

        /// <summary>
        ///     the value of the "PM_TARGET_INFO_REQ" field.
        /// </summary>
        private Int32? _targetInfoReq;

        /// <summary>
        ///     the value of the "PM_TARGET_HELPCALLS" field.
        /// </summary>
        private Int32? _targetHelpcalls;

        /// <summary>
        ///     the value of the "PM_TARGET_MEMBERSHIPS" field.
        /// </summary>
        private Int32? _targetMemberships;

        /// <summary>
        ///     the value of the "PM_TARGET_MEMBERSHIPS_VAL" field.
        /// </summary>
        private Double? _targetMembershipsVal;

        /// <summary>
        ///     the value of the "PM_TARGET_SUBSCRIPTIONS" field.
        /// </summary>
        private Int32? _targetSubscriptions;

        /// <summary>
        ///     the value of the "PM_TARGET_SUBSCRIPTIONS_VAL" field.
        /// </summary>
        private Double? _targetSubscriptionsVal;

        /// <summary>
        ///     the value of the "PM_ACTUAL_COMPLAINTS" field.
        /// </summary>
        private Int32? _actualComplaints;

        /// <summary>
        ///     the value of the "PM_ACTUAL_INFO_REQ" field.
        /// </summary>
        private Int32? _actualInfoReq;

        /// <summary>
        ///     the value of the "PM_ACTUAL_HELPCALLS" field.
        /// </summary>
        private Int32? _actualHelpcalls;

        /// <summary>
        ///     the value of the "PM_ACTUAL_MEMBERSHIPS" field.
        /// </summary>
        private Int32? _actualMemberships;

        /// <summary>
        ///     the value of the "PM_ACTUAL_MEMBERSHIPS_VAL" field.
        /// </summary>
        private Double? _actualMembershipsVal;

        /// <summary>
        ///     the value of the "PM_ACTUAL_SUBSCRIPTIONS" field.
        /// </summary>
        private Int32? _actualSubscriptions;

        /// <summary>
        ///     the value of the "PM_ACTUAL_SUBSCRIPTIONS_VAL" field.
        /// </summary>
        private Double? _actualSubscriptionsVal;

        /// <summary>
        ///     the value of the "PM_WEB" field.
        /// </summary>
        private Byte _web;

        /// <summary>
        ///     the value of the "PM_EMAIL_CAMPAIGN" field.
        /// </summary>
        private Byte _emailCampaign;

        /// <summary>
        ///     the value of the "PM_CAMPAIGN_TYPE" field.
        /// </summary>
        private Int32 _campaignType;

        /// <summary>
        ///     the value of the "PM_SEND_CONTACTS" field.
        /// </summary>
        private Byte _sendContacts;

        /// <summary>
        ///     the value of the "PM_CONTACTS_SENT" field.
        /// </summary>
        private DateTime? _contactsSent;

        /// <summary>
        ///     the value of the "PM_EMAILS_SENT" field.
        /// </summary>
        private Int32 _emailsSent;

        /// <summary>
        ///     the value of the "PM_EMAILS_OPENED" field.
        /// </summary>
        private Int32 _emailsOpened;

        /// <summary>
        ///     the value of the "PM_LINKS_CLICKED" field.
        /// </summary>
        private Int32 _linksClicked;

        /// <summary>
        ///     the value of the "PM_LZ_CLICKED" field.
        /// </summary>
        private Int32 _lzClicked;

        /// <summary>
        ///     the value of the "PM_SURVEYS_COMPLETED" field.
        /// </summary>
        private Int32 _surveysCompleted;

        /// <summary>
        ///     the value of the "PM_GLOBAL_UNSUBSCRIBES" field.
        /// </summary>
        private Int32 _globalUnsubscribes;

        /// <summary>
        ///     the value of the "PM_LIST_UNSUBSCRIBES" field.
        /// </summary>
        private Int32 _listUnsubscribes;

        /// <summary>
        ///     the value of the "PM_DOCS_DOWNLOADS" field.
        /// </summary>
        private Int32 _docsDownloads;

        /// <summary>
        ///     the value of the "PM_BOUNCE_BACKS" field.
        /// </summary>
        private Int32 _bounceBacks;

        /// <summary>
        ///     the value of the "PM_EMAILS_SENT_TARGET" field.
        /// </summary>
        private Int32 _emailsSentTarget;

        /// <summary>
        ///     the value of the "PM_EMAILS_OPENED_TARGET" field.
        /// </summary>
        private Int32 _emailsOpenedTarget;

        /// <summary>
        ///     the value of the "PM_LINKS_CLICKED_TARGET" field.
        /// </summary>
        private Int32 _linksClickedTarget;

        /// <summary>
        ///     the value of the "PM_LZ_CLICKED_TARGET" field.
        /// </summary>
        private Int32 _lzClickedTarget;

        /// <summary>
        ///     the value of the "PM_SURVEYS_COMPLETED_TARGET" field.
        /// </summary>
        private Int32 _surveysCompletedTarget;

        /// <summary>
        ///     the value of the "PM_GLOBAL_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        private Int32 _globalUnsubscribesTarget;

        /// <summary>
        ///     the value of the "PM_LIST_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        private Int32 _listUnsubscribesTarget;

        /// <summary>
        ///     the value of the "PM_DOCS_DOWNLOADS_TARGET" field.
        /// </summary>
        private Int32 _docsDownloadsTarget;

        /// <summary>
        ///     the value of the "PM_BOUNCE_BACKS_TARGET" field.
        /// </summary>
        private Int32 _bounceBacksTarget;

        /// <summary>
        ///     the value of the "PM_QCODE" field.
        /// </summary>
        private String _qcode;

        /// <summary>
        ///     the value of the "PM_FQCODE" field.
        /// </summary>
        private String _fqcode;

        /// <summary>
        ///     the value of the "PM_FOLLOW_ON_PM_ID" field.
        /// </summary>
        private String _followOnPmId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PM_CMP_ID" field.
        /// </summary>
        public String CmpId
        {
            get { return _cmpId; }
            set { _cmpId = value; }
        }

        /// <summary>
        ///     the value of the "PM_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "PM_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        ///     the value of the "PM_CHANNEL" field.
        /// </summary>
        public String Channel
        {
            get { return _channel; }
            set { _channel = value; }
        }

        /// <summary>
        ///     the value of the "PM_TEXT_ID" field.
        /// </summary>
        public String TextId
        {
            get { return _textId; }
            set { _textId = value; }
        }

        /// <summary>
        ///     the value of the "PM_DM_NUMBER" field.
        /// </summary>
        public Double? DmNumber
        {
            get { return _dmNumber; }
            set { _dmNumber = value; }
        }

        /// <summary>
        ///     the value of the "PM_REPLIES" field.
        /// </summary>
        public Double? Replies
        {
            get { return _replies; }
            set { _replies = value; }
        }

        /// <summary>
        ///     the value of the "PM_ORDERS" field.
        /// </summary>
        public Double? Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        ///     the value of the "PM_ORDER_VAL" field.
        /// </summary>
        public Double? OrderVal
        {
            get { return _orderVal; }
            set { _orderVal = value; }
        }

        /// <summary>
        ///     the value of the "PM_BUDGET_COST" field.
        /// </summary>
        public Double? BudgetCost
        {
            get { return _budgetCost; }
            set { _budgetCost = value; }
        }

        /// <summary>
        ///     the value of the "PM_ACTUAL_COST" field.
        /// </summary>
        public Double? ActualCost
        {
            get { return _actualCost; }
            set { _actualCost = value; }
        }

        /// <summary>
        ///     the value of the "PM_UPDATED" field.
        /// </summary>
        public DateTime? Updated
        {
            get { return _updated; }
            set { _updated = value; }
        }

        /// <summary>
        ///     the value of the "PM_CURRENT" field.
        /// </summary>
        public Byte? Current
        {
            get { return _current; }
            set { _current = value; }
        }

        /// <summary>
        ///     the value of the "PM_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PM_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PM_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PM_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PM_MOD_BY_SYS" field.
        /// </summary>
        public String ModBySys
        {
            get { return _modBySys; }
            set { _modBySys = value; }
        }

        /// <summary>
        ///     the value of the "PM_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "PM_ORDER_VALUE_BC" field.
        /// </summary>
        public Double? OrderValueBc
        {
            get { return _orderValueBc; }
            set { _orderValueBc = value; }
        }

        /// <summary>
        ///     the value of the "PM_BUDGET_COST_BC" field.
        /// </summary>
        public Double? BudgetCostBc
        {
            get { return _budgetCostBc; }
            set { _budgetCostBc = value; }
        }

        /// <summary>
        ///     the value of the "PM_ACTUAL_COST_BC" field.
        /// </summary>
        public Double? ActualCostBc
        {
            get { return _actualCostBc; }
            set { _actualCostBc = value; }
        }

        /// <summary>
        ///     the value of the "PM_CURRENCY_TYPE" field.
        /// </summary>
        public String CurrencyType
        {
            get { return _currencyType; }
            set { _currencyType = value; }
        }

        /// <summary>
        ///     the value of the "PM_MEDIA_NAME" field.
        /// </summary>
        public String MediaName
        {
            get { return _mediaName; }
            set { _mediaName = value; }
        }

        /// <summary>
        ///     the value of the "PM_SCHEME_ID" field.
        /// </summary>
        public String SchemeId
        {
            get { return _schemeId; }
            set { _schemeId = value; }
        }

        /// <summary>
        ///     the value of the "PM_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PM_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PM_TELESALES" field.
        /// </summary>
        public Int32? Telesales
        {
            get { return _telesales; }
            set { _telesales = value; }
        }

        /// <summary>
        ///     the value of the "PM_BOOKING" field.
        /// </summary>
        public Int32? Booking
        {
            get { return _booking; }
            set { _booking = value; }
        }

        /// <summary>
        ///     the value of the "PM_BOOK_VALUE" field.
        /// </summary>
        public Double? BookValue
        {
            get { return _bookValue; }
            set { _bookValue = value; }
        }

        /// <summary>
        ///     the value of the "PM_OPP_TOT" field.
        /// </summary>
        public Int32? OppTot
        {
            get { return _oppTot; }
            set { _oppTot = value; }
        }

        /// <summary>
        ///     the value of the "PM_QUOTES" field.
        /// </summary>
        public Int32? Quotes
        {
            get { return _quotes; }
            set { _quotes = value; }
        }

        /// <summary>
        ///     the value of the "PM_QUO_VALUE" field.
        /// </summary>
        public Double? QuoValue
        {
            get { return _quoValue; }
            set { _quoValue = value; }
        }

        /// <summary>
        ///     the value of the "PM_SALES" field.
        /// </summary>
        public Int32? Sales
        {
            get { return _sales; }
            set { _sales = value; }
        }

        /// <summary>
        ///     the value of the "PM_SALE_VALUE" field.
        /// </summary>
        public Double? SaleValue
        {
            get { return _saleValue; }
            set { _saleValue = value; }
        }

        /// <summary>
        ///     the value of the "PM_USERNUM_1" field.
        /// </summary>
        public Double? Usernum1
        {
            get { return _usernum1; }
            set { _usernum1 = value; }
        }

        /// <summary>
        ///     the value of the "PM_USERNUM_2" field.
        /// </summary>
        public Double? Usernum2
        {
            get { return _usernum2; }
            set { _usernum2 = value; }
        }

        /// <summary>
        ///     the value of the "PM_CODE" field.
        /// </summary>
        public String Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        ///     the value of the "PM_PACK_ID" field.
        /// </summary>
        public String PackId
        {
            get { return _packId; }
            set { _packId = value; }
        }

        /// <summary>
        ///     the value of the "PM_OUT_DATE" field.
        /// </summary>
        public DateTime? OutDate
        {
            get { return _outDate; }
            set { _outDate = value; }
        }

        /// <summary>
        ///     the value of the "PM_FOOTER" field.
        /// </summary>
        public String Footer
        {
            get { return _footer; }
            set { _footer = value; }
        }

        /// <summary>
        ///     the value of the "PM_UNSUBSCRIBE" field.
        /// </summary>
        public String Unsubscribe
        {
            get { return _unsubscribe; }
            set { _unsubscribe = value; }
        }

        /// <summary>
        ///     the value of the "PM_HEADER" field.
        /// </summary>
        public String Header
        {
            get { return _header; }
            set { _header = value; }
        }

        /// <summary>
        ///     the value of the "PM_BODY" field.
        /// </summary>
        public String Body
        {
            get { return _body; }
            set { _body = value; }
        }

        /// <summary>
        ///     the value of the "PM_APPROVE" field.
        /// </summary>
        public String Approve
        {
            get { return _approve; }
            set { _approve = value; }
        }

        /// <summary>
        ///     the value of the "PM_REPLY" field.
        /// </summary>
        public String Reply
        {
            get { return _reply; }
            set { _reply = value; }
        }

        /// <summary>
        ///     the value of the "PM_TIME" field.
        /// </summary>
        public DateTime? Time
        {
            get { return _time; }
            set { _time = value; }
        }

        /// <summary>
        ///     the value of the "PM_E_STATUS" field.
        /// </summary>
        public Byte? EStatus
        {
            get { return _eStatus; }
            set { _eStatus = value; }
        }

        /// <summary>
        ///     the value of the "PM_JOB_TITLE" field.
        /// </summary>
        public String JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

        /// <summary>
        ///     the value of the "PM_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "PM_E_TYPE" field.
        /// </summary>
        public String EType
        {
            get { return _eType; }
            set { _eType = value; }
        }

        /// <summary>
        ///     the value of the "PM_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "PM_APP_PROLE_ID" field.
        /// </summary>
        public String AppProleId
        {
            get { return _appProleId; }
            set { _appProleId = value; }
        }

        /// <summary>
        ///     the value of the "PM_RUN_TIME" field.
        /// </summary>
        public DateTime? RunTime
        {
            get { return _runTime; }
            set { _runTime = value; }
        }

        /// <summary>
        ///     the value of the "PM_FINISH_TIME" field.
        /// </summary>
        public DateTime? FinishTime
        {
            get { return _finishTime; }
            set { _finishTime = value; }
        }

        /// <summary>
        ///     the value of the "PM_GOOD_MAIL" field.
        /// </summary>
        public Int32? GoodMail
        {
            get { return _goodMail; }
            set { _goodMail = value; }
        }

        /// <summary>
        ///     the value of the "PM_BAD_MAIL" field.
        /// </summary>
        public Int32? BadMail
        {
            get { return _badMail; }
            set { _badMail = value; }
        }

        /// <summary>
        ///     the value of the "PM_SMTP_HOST" field.
        /// </summary>
        public String SmtpHost
        {
            get { return _smtpHost; }
            set { _smtpHost = value; }
        }

        /// <summary>
        ///     the value of the "PM_EMAIL_DESC" field.
        /// </summary>
        public String EmailDesc
        {
            get { return _emailDesc; }
            set { _emailDesc = value; }
        }

        /// <summary>
        ///     the value of the "PM_ACTUAL_VAR_COST" field.
        /// </summary>
        public Double? ActualVarCost
        {
            get { return _actualVarCost; }
            set { _actualVarCost = value; }
        }

        /// <summary>
        ///     the value of the "PM_ACTUAL_FIX_COST" field.
        /// </summary>
        public Double? ActualFixCost
        {
            get { return _actualFixCost; }
            set { _actualFixCost = value; }
        }

        /// <summary>
        ///     the value of the "PM_BUDGET_VAR_COST" field.
        /// </summary>
        public Double? BudgetVarCost
        {
            get { return _budgetVarCost; }
            set { _budgetVarCost = value; }
        }

        /// <summary>
        ///     the value of the "PM_BUDGET_FIX_COST" field.
        /// </summary>
        public Double? BudgetFixCost
        {
            get { return _budgetFixCost; }
            set { _budgetFixCost = value; }
        }

        /// <summary>
        ///     the value of the "PM_TARGET_OPP" field.
        /// </summary>
        public Int32? TargetOpp
        {
            get { return _targetOpp; }
            set { _targetOpp = value; }
        }

        /// <summary>
        ///     the value of the "PM_TARGET_REPLIES" field.
        /// </summary>
        public Int32? TargetReplies
        {
            get { return _targetReplies; }
            set { _targetReplies = value; }
        }

        /// <summary>
        ///     the value of the "PM_TARGET_OPP_VAL" field.
        /// </summary>
        public Double? TargetOppVal
        {
            get { return _targetOppVal; }
            set { _targetOppVal = value; }
        }

        /// <summary>
        ///     the value of the "PM_TARGET_BOOK_VAL" field.
        /// </summary>
        public Double? TargetBookVal
        {
            get { return _targetBookVal; }
            set { _targetBookVal = value; }
        }

        /// <summary>
        ///     the value of the "PM_TARGET_COMPLAINTS" field.
        /// </summary>
        public Int32? TargetComplaints
        {
            get { return _targetComplaints; }
            set { _targetComplaints = value; }
        }

        /// <summary>
        ///     the value of the "PM_TARGET_INFO_REQ" field.
        /// </summary>
        public Int32? TargetInfoReq
        {
            get { return _targetInfoReq; }
            set { _targetInfoReq = value; }
        }

        /// <summary>
        ///     the value of the "PM_TARGET_HELPCALLS" field.
        /// </summary>
        public Int32? TargetHelpcalls
        {
            get { return _targetHelpcalls; }
            set { _targetHelpcalls = value; }
        }

        /// <summary>
        ///     the value of the "PM_TARGET_MEMBERSHIPS" field.
        /// </summary>
        public Int32? TargetMemberships
        {
            get { return _targetMemberships; }
            set { _targetMemberships = value; }
        }

        /// <summary>
        ///     the value of the "PM_TARGET_MEMBERSHIPS_VAL" field.
        /// </summary>
        public Double? TargetMembershipsVal
        {
            get { return _targetMembershipsVal; }
            set { _targetMembershipsVal = value; }
        }

        /// <summary>
        ///     the value of the "PM_TARGET_SUBSCRIPTIONS" field.
        /// </summary>
        public Int32? TargetSubscriptions
        {
            get { return _targetSubscriptions; }
            set { _targetSubscriptions = value; }
        }

        /// <summary>
        ///     the value of the "PM_TARGET_SUBSCRIPTIONS_VAL" field.
        /// </summary>
        public Double? TargetSubscriptionsVal
        {
            get { return _targetSubscriptionsVal; }
            set { _targetSubscriptionsVal = value; }
        }

        /// <summary>
        ///     the value of the "PM_ACTUAL_COMPLAINTS" field.
        /// </summary>
        public Int32? ActualComplaints
        {
            get { return _actualComplaints; }
            set { _actualComplaints = value; }
        }

        /// <summary>
        ///     the value of the "PM_ACTUAL_INFO_REQ" field.
        /// </summary>
        public Int32? ActualInfoReq
        {
            get { return _actualInfoReq; }
            set { _actualInfoReq = value; }
        }

        /// <summary>
        ///     the value of the "PM_ACTUAL_HELPCALLS" field.
        /// </summary>
        public Int32? ActualHelpcalls
        {
            get { return _actualHelpcalls; }
            set { _actualHelpcalls = value; }
        }

        /// <summary>
        ///     the value of the "PM_ACTUAL_MEMBERSHIPS" field.
        /// </summary>
        public Int32? ActualMemberships
        {
            get { return _actualMemberships; }
            set { _actualMemberships = value; }
        }

        /// <summary>
        ///     the value of the "PM_ACTUAL_MEMBERSHIPS_VAL" field.
        /// </summary>
        public Double? ActualMembershipsVal
        {
            get { return _actualMembershipsVal; }
            set { _actualMembershipsVal = value; }
        }

        /// <summary>
        ///     the value of the "PM_ACTUAL_SUBSCRIPTIONS" field.
        /// </summary>
        public Int32? ActualSubscriptions
        {
            get { return _actualSubscriptions; }
            set { _actualSubscriptions = value; }
        }

        /// <summary>
        ///     the value of the "PM_ACTUAL_SUBSCRIPTIONS_VAL" field.
        /// </summary>
        public Double? ActualSubscriptionsVal
        {
            get { return _actualSubscriptionsVal; }
            set { _actualSubscriptionsVal = value; }
        }

        /// <summary>
        ///     the value of the "PM_WEB" field.
        /// </summary>
        public Byte Web
        {
            get { return _web; }
            set { _web = value; }
        }

        /// <summary>
        ///     the value of the "PM_EMAIL_CAMPAIGN" field.
        /// </summary>
        public Byte EmailCampaign
        {
            get { return _emailCampaign; }
            set { _emailCampaign = value; }
        }

        /// <summary>
        ///     the value of the "PM_CAMPAIGN_TYPE" field.
        /// </summary>
        public Int32 CampaignType
        {
            get { return _campaignType; }
            set { _campaignType = value; }
        }

        /// <summary>
        ///     the value of the "PM_SEND_CONTACTS" field.
        /// </summary>
        public Byte SendContacts
        {
            get { return _sendContacts; }
            set { _sendContacts = value; }
        }

        /// <summary>
        ///     the value of the "PM_CONTACTS_SENT" field.
        /// </summary>
        public DateTime? ContactsSent
        {
            get { return _contactsSent; }
            set { _contactsSent = value; }
        }

        /// <summary>
        ///     the value of the "PM_EMAILS_SENT" field.
        /// </summary>
        public Int32 EmailsSent
        {
            get { return _emailsSent; }
            set { _emailsSent = value; }
        }

        /// <summary>
        ///     the value of the "PM_EMAILS_OPENED" field.
        /// </summary>
        public Int32 EmailsOpened
        {
            get { return _emailsOpened; }
            set { _emailsOpened = value; }
        }

        /// <summary>
        ///     the value of the "PM_LINKS_CLICKED" field.
        /// </summary>
        public Int32 LinksClicked
        {
            get { return _linksClicked; }
            set { _linksClicked = value; }
        }

        /// <summary>
        ///     the value of the "PM_LZ_CLICKED" field.
        /// </summary>
        public Int32 LzClicked
        {
            get { return _lzClicked; }
            set { _lzClicked = value; }
        }

        /// <summary>
        ///     the value of the "PM_SURVEYS_COMPLETED" field.
        /// </summary>
        public Int32 SurveysCompleted
        {
            get { return _surveysCompleted; }
            set { _surveysCompleted = value; }
        }

        /// <summary>
        ///     the value of the "PM_GLOBAL_UNSUBSCRIBES" field.
        /// </summary>
        public Int32 GlobalUnsubscribes
        {
            get { return _globalUnsubscribes; }
            set { _globalUnsubscribes = value; }
        }

        /// <summary>
        ///     the value of the "PM_LIST_UNSUBSCRIBES" field.
        /// </summary>
        public Int32 ListUnsubscribes
        {
            get { return _listUnsubscribes; }
            set { _listUnsubscribes = value; }
        }

        /// <summary>
        ///     the value of the "PM_DOCS_DOWNLOADS" field.
        /// </summary>
        public Int32 DocsDownloads
        {
            get { return _docsDownloads; }
            set { _docsDownloads = value; }
        }

        /// <summary>
        ///     the value of the "PM_BOUNCE_BACKS" field.
        /// </summary>
        public Int32 BounceBacks
        {
            get { return _bounceBacks; }
            set { _bounceBacks = value; }
        }

        /// <summary>
        ///     the value of the "PM_EMAILS_SENT_TARGET" field.
        /// </summary>
        public Int32 EmailsSentTarget
        {
            get { return _emailsSentTarget; }
            set { _emailsSentTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_EMAILS_OPENED_TARGET" field.
        /// </summary>
        public Int32 EmailsOpenedTarget
        {
            get { return _emailsOpenedTarget; }
            set { _emailsOpenedTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_LINKS_CLICKED_TARGET" field.
        /// </summary>
        public Int32 LinksClickedTarget
        {
            get { return _linksClickedTarget; }
            set { _linksClickedTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_LZ_CLICKED_TARGET" field.
        /// </summary>
        public Int32 LzClickedTarget
        {
            get { return _lzClickedTarget; }
            set { _lzClickedTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_SURVEYS_COMPLETED_TARGET" field.
        /// </summary>
        public Int32 SurveysCompletedTarget
        {
            get { return _surveysCompletedTarget; }
            set { _surveysCompletedTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_GLOBAL_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        public Int32 GlobalUnsubscribesTarget
        {
            get { return _globalUnsubscribesTarget; }
            set { _globalUnsubscribesTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_LIST_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        public Int32 ListUnsubscribesTarget
        {
            get { return _listUnsubscribesTarget; }
            set { _listUnsubscribesTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_DOCS_DOWNLOADS_TARGET" field.
        /// </summary>
        public Int32 DocsDownloadsTarget
        {
            get { return _docsDownloadsTarget; }
            set { _docsDownloadsTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_BOUNCE_BACKS_TARGET" field.
        /// </summary>
        public Int32 BounceBacksTarget
        {
            get { return _bounceBacksTarget; }
            set { _bounceBacksTarget = value; }
        }

        /// <summary>
        ///     the value of the "PM_QCODE" field.
        /// </summary>
        public String Qcode
        {
            get { return _qcode; }
            set { _qcode = value; }
        }

        /// <summary>
        ///     the value of the "PM_FQCODE" field.
        /// </summary>
        public String Fqcode
        {
            get { return _fqcode; }
            set { _fqcode = value; }
        }

        /// <summary>
        ///     the value of the "PM_FOLLOW_ON_PM_ID" field.
        /// </summary>
        public String FollowOnPmId
        {
            get { return _followOnPmId; }
            set { _followOnPmId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PromotionRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PromotionRecord" /> object instance.
        /// </returns>
        public PromotionRecord Clone()
        {
            PromotionRecord record = new PromotionRecord();
            record.Id = this.Id;
            record.CmpId = this.CmpId;
            record.Name = this.Name;
            record.StartDate = this.StartDate;
            record.Channel = this.Channel;
            record.TextId = this.TextId;
            record.DmNumber = this.DmNumber;
            record.Replies = this.Replies;
            record.Orders = this.Orders;
            record.OrderVal = this.OrderVal;
            record.BudgetCost = this.BudgetCost;
            record.ActualCost = this.ActualCost;
            record.Updated = this.Updated;
            record.Current = this.Current;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.ModBySys = this.ModBySys;
            record.Lock = this.Lock;
            record.OrderValueBc = this.OrderValueBc;
            record.BudgetCostBc = this.BudgetCostBc;
            record.ActualCostBc = this.ActualCostBc;
            record.CurrencyType = this.CurrencyType;
            record.MediaName = this.MediaName;
            record.SchemeId = this.SchemeId;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Telesales = this.Telesales;
            record.Booking = this.Booking;
            record.BookValue = this.BookValue;
            record.OppTot = this.OppTot;
            record.Quotes = this.Quotes;
            record.QuoValue = this.QuoValue;
            record.Sales = this.Sales;
            record.SaleValue = this.SaleValue;
            record.Usernum1 = this.Usernum1;
            record.Usernum2 = this.Usernum2;
            record.Code = this.Code;
            record.PackId = this.PackId;
            record.OutDate = this.OutDate;
            record.Footer = this.Footer;
            record.Unsubscribe = this.Unsubscribe;
            record.Header = this.Header;
            record.Body = this.Body;
            record.Approve = this.Approve;
            record.Reply = this.Reply;
            record.Time = this.Time;
            record.EStatus = this.EStatus;
            record.JobTitle = this.JobTitle;
            record.Type = this.Type;
            record.EType = this.EType;
            record.ProleId = this.ProleId;
            record.AppProleId = this.AppProleId;
            record.RunTime = this.RunTime;
            record.FinishTime = this.FinishTime;
            record.GoodMail = this.GoodMail;
            record.BadMail = this.BadMail;
            record.SmtpHost = this.SmtpHost;
            record.EmailDesc = this.EmailDesc;
            record.ActualVarCost = this.ActualVarCost;
            record.ActualFixCost = this.ActualFixCost;
            record.BudgetVarCost = this.BudgetVarCost;
            record.BudgetFixCost = this.BudgetFixCost;
            record.TargetOpp = this.TargetOpp;
            record.TargetReplies = this.TargetReplies;
            record.TargetOppVal = this.TargetOppVal;
            record.TargetBookVal = this.TargetBookVal;
            record.TargetComplaints = this.TargetComplaints;
            record.TargetInfoReq = this.TargetInfoReq;
            record.TargetHelpcalls = this.TargetHelpcalls;
            record.TargetMemberships = this.TargetMemberships;
            record.TargetMembershipsVal = this.TargetMembershipsVal;
            record.TargetSubscriptions = this.TargetSubscriptions;
            record.TargetSubscriptionsVal = this.TargetSubscriptionsVal;
            record.ActualComplaints = this.ActualComplaints;
            record.ActualInfoReq = this.ActualInfoReq;
            record.ActualHelpcalls = this.ActualHelpcalls;
            record.ActualMemberships = this.ActualMemberships;
            record.ActualMembershipsVal = this.ActualMembershipsVal;
            record.ActualSubscriptions = this.ActualSubscriptions;
            record.ActualSubscriptionsVal = this.ActualSubscriptionsVal;
            record.Web = this.Web;
            record.EmailCampaign = this.EmailCampaign;
            record.CampaignType = this.CampaignType;
            record.SendContacts = this.SendContacts;
            record.ContactsSent = this.ContactsSent;
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
            record.FollowOnPmId = this.FollowOnPmId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PromotionRecord" /> instance is equal to another <see cref="PromotionRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PromotionRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PromotionRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.CmpId.TrimOrNullify() == that.CmpId.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.StartDate == that.StartDate);
            result = result && (this.Channel.TrimOrNullify() == that.Channel.TrimOrNullify());
            result = result && (this.TextId.TrimOrNullify() == that.TextId.TrimOrNullify());
            result = result && (this.DmNumber == that.DmNumber);
            result = result && (this.Replies == that.Replies);
            result = result && (this.Orders == that.Orders);
            result = result && (this.OrderVal == that.OrderVal);
            result = result && (this.BudgetCost == that.BudgetCost);
            result = result && (this.ActualCost == that.ActualCost);
            result = result && (this.Updated == that.Updated);
            result = result && (this.Current == that.Current);
            result = result && (this.ModBySys.TrimOrNullify() == that.ModBySys.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.OrderValueBc == that.OrderValueBc);
            result = result && (this.BudgetCostBc == that.BudgetCostBc);
            result = result && (this.ActualCostBc == that.ActualCostBc);
            result = result && (this.CurrencyType.TrimOrNullify() == that.CurrencyType.TrimOrNullify());
            result = result && (this.MediaName.TrimOrNullify() == that.MediaName.TrimOrNullify());
            result = result && (this.SchemeId.TrimOrNullify() == that.SchemeId.TrimOrNullify());
            result = result && (this.Telesales == that.Telesales);
            result = result && (this.Booking == that.Booking);
            result = result && (this.BookValue == that.BookValue);
            result = result && (this.OppTot == that.OppTot);
            result = result && (this.Quotes == that.Quotes);
            result = result && (this.QuoValue == that.QuoValue);
            result = result && (this.Sales == that.Sales);
            result = result && (this.SaleValue == that.SaleValue);
            result = result && (this.Usernum1 == that.Usernum1);
            result = result && (this.Usernum2 == that.Usernum2);
            result = result && (this.Code.TrimOrNullify() == that.Code.TrimOrNullify());
            result = result && (this.PackId.TrimOrNullify() == that.PackId.TrimOrNullify());
            result = result && (this.OutDate == that.OutDate);
            result = result && (this.Footer.TrimOrNullify() == that.Footer.TrimOrNullify());
            result = result && (this.Unsubscribe.TrimOrNullify() == that.Unsubscribe.TrimOrNullify());
            result = result && (this.Header.TrimOrNullify() == that.Header.TrimOrNullify());
            result = result && (this.Body.TrimOrNullify() == that.Body.TrimOrNullify());
            result = result && (this.Approve.TrimOrNullify() == that.Approve.TrimOrNullify());
            result = result && (this.Reply.TrimOrNullify() == that.Reply.TrimOrNullify());
            result = result && (this.Time == that.Time);
            result = result && (this.EStatus == that.EStatus);
            result = result && (this.JobTitle.TrimOrNullify() == that.JobTitle.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.EType.TrimOrNullify() == that.EType.TrimOrNullify());
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.AppProleId.TrimOrNullify() == that.AppProleId.TrimOrNullify());
            result = result && (this.RunTime == that.RunTime);
            result = result && (this.FinishTime == that.FinishTime);
            result = result && (this.GoodMail == that.GoodMail);
            result = result && (this.BadMail == that.BadMail);
            result = result && (this.SmtpHost.TrimOrNullify() == that.SmtpHost.TrimOrNullify());
            result = result && (this.EmailDesc.TrimOrNullify() == that.EmailDesc.TrimOrNullify());
            result = result && (this.ActualVarCost == that.ActualVarCost);
            result = result && (this.ActualFixCost == that.ActualFixCost);
            result = result && (this.BudgetVarCost == that.BudgetVarCost);
            result = result && (this.BudgetFixCost == that.BudgetFixCost);
            result = result && (this.TargetOpp == that.TargetOpp);
            result = result && (this.TargetReplies == that.TargetReplies);
            result = result && (this.TargetOppVal == that.TargetOppVal);
            result = result && (this.TargetBookVal == that.TargetBookVal);
            result = result && (this.TargetComplaints == that.TargetComplaints);
            result = result && (this.TargetInfoReq == that.TargetInfoReq);
            result = result && (this.TargetHelpcalls == that.TargetHelpcalls);
            result = result && (this.TargetMemberships == that.TargetMemberships);
            result = result && (this.TargetMembershipsVal == that.TargetMembershipsVal);
            result = result && (this.TargetSubscriptions == that.TargetSubscriptions);
            result = result && (this.TargetSubscriptionsVal == that.TargetSubscriptionsVal);
            result = result && (this.ActualComplaints == that.ActualComplaints);
            result = result && (this.ActualInfoReq == that.ActualInfoReq);
            result = result && (this.ActualHelpcalls == that.ActualHelpcalls);
            result = result && (this.ActualMemberships == that.ActualMemberships);
            result = result && (this.ActualMembershipsVal == that.ActualMembershipsVal);
            result = result && (this.ActualSubscriptions == that.ActualSubscriptions);
            result = result && (this.ActualSubscriptionsVal == that.ActualSubscriptionsVal);
            result = result && (this.Web == that.Web);
            result = result && (this.EmailCampaign == that.EmailCampaign);
            result = result && (this.CampaignType == that.CampaignType);
            result = result && (this.SendContacts == that.SendContacts);
            result = result && (this.ContactsSent == that.ContactsSent);
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
            result = result && (this.FollowOnPmId.TrimOrNullify() == that.FollowOnPmId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
