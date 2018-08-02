using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Represents the "InvHeader" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class InvheaderRecord : Record<String>, Cloneable<InvheaderRecord>, IEquatable<InvheaderRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "INV_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "INV_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "INV_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "INV_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "INV_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "INV_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "INV_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "INV_BOOK_ID" field.
        /// </summary>
        private String _bookId;

        /// <summary>
        ///     the value of the "INV_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "INV_PERSON_ID" field.
        /// </summary>
        private String _personId;

        /// <summary>
        ///     the value of the "INV_SALESMAN_ID" field.
        /// </summary>
        private String _salesmanId;

        /// <summary>
        ///     the value of the "INV_DELVRY_REF" field.
        /// </summary>
        private String _delvryRef;

        /// <summary>
        ///     the value of the "INV_CARRIER" field.
        /// </summary>
        private String _carrier;

        /// <summary>
        ///     the value of the "INV_DELVRY_DATE" field.
        /// </summary>
        private DateTime? _delvryDate;

        /// <summary>
        ///     the value of the "INV_ORDER_DATE" field.
        /// </summary>
        private DateTime? _orderDate;

        /// <summary>
        ///     the value of the "INV_CUST_ORDER_NO" field.
        /// </summary>
        private String _custOrderNo;

        /// <summary>
        ///     the value of the "INV_DELVRY_ADD" field.
        /// </summary>
        private String _delvryAdd;

        /// <summary>
        ///     the value of the "INV_REF" field.
        /// </summary>
        private String _ref;

        /// <summary>
        ///     the value of the "INV_DATE" field.
        /// </summary>
        private DateTime? _date;

        /// <summary>
        ///     the value of the "INV_STATUS" field.
        /// </summary>
        private Byte? _status;

        /// <summary>
        ///     the value of the "INV_ADD" field.
        /// </summary>
        private String _add;

        /// <summary>
        ///     the value of the "INV_CREDIT_NTE_REF" field.
        /// </summary>
        private String _creditNteRef;

        /// <summary>
        ///     the value of the "INV_CREDIT_NTE_DTE" field.
        /// </summary>
        private DateTime? _creditNteDte;

        /// <summary>
        ///     the value of the "INV_CREDIT_NTE_STA" field.
        /// </summary>
        private Byte? _creditNteSta;

        /// <summary>
        ///     the value of the "INV_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "INV_NET_TOTAL" field.
        /// </summary>
        private Decimal _netTotal;

        /// <summary>
        ///     the value of the "INV_VAT_TOTAL" field.
        /// </summary>
        private Decimal _vatTotal;

        /// <summary>
        ///     the value of the "INV_GROSS_TOTAL" field.
        /// </summary>
        private Decimal _grossTotal;

        /// <summary>
        ///     the value of the "INV_NET_TOTAL_BC" field.
        /// </summary>
        private Decimal _netTotalBc;

        /// <summary>
        ///     the value of the "INV_VAT_TOTAL_BC" field.
        /// </summary>
        private Decimal _vatTotalBc;

        /// <summary>
        ///     the value of the "INV_GROSS_TOTAL_BC" field.
        /// </summary>
        private Decimal _grossTotalBc;

        /// <summary>
        ///     the value of the "INV_CURRENCY_TYPE" field.
        /// </summary>
        private String _currencyType;

        /// <summary>
        ///     the value of the "INV_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "INV_ACCOUNT_TYPE" field.
        /// </summary>
        private String _accountType;

        /// <summary>
        ///     the value of the "INV_IN_RESPECT_OF" field.
        /// </summary>
        private String _inRespectOf;

        /// <summary>
        ///     the value of the "INV_FOOTER" field.
        /// </summary>
        private String _footer;

        /// <summary>
        ///     the value of the "INV_CREDIT_PERCENT" field.
        /// </summary>
        private Double? _creditPercent;

        /// <summary>
        ///     the value of the "INV_COURSE_ID" field.
        /// </summary>
        private String _courseId;

        /// <summary>
        ///     the value of the "INV_COURSE_NAME" field.
        /// </summary>
        private String _courseName;

        /// <summary>
        ///     the value of the "INV_CORS_STRT_DTE" field.
        /// </summary>
        private DateTime? _corsStrtDte;

        /// <summary>
        ///     the value of the "INV_COURSE_END_DTE" field.
        /// </summary>
        private DateTime? _courseEndDte;

        /// <summary>
        ///     the value of the "INV_CORS_COST_CODE" field.
        /// </summary>
        private String _corsCostCode;

        /// <summary>
        ///     the value of the "INV_BOOK_REF" field.
        /// </summary>
        private String _bookRef;

        /// <summary>
        ///     the value of the "INV_BOOKER" field.
        /// </summary>
        private String _booker;

        /// <summary>
        ///     the value of the "INV_BOOK_ORG_NAME" field.
        /// </summary>
        private String _bookOrgName;

        /// <summary>
        ///     the value of the "INV_ADD_MAILSTRING" field.
        /// </summary>
        private String _addMailstring;

        /// <summary>
        ///     the value of the "INV_BK_ORG_CUST_AC" field.
        /// </summary>
        private String _bkOrgCustAc;

        /// <summary>
        ///     the value of the "INV_VENUE_ORG_NAME" field.
        /// </summary>
        private String _venueOrgName;

        /// <summary>
        ///     the value of the "INV_PENALTY" field.
        /// </summary>
        private Byte? _penalty;

        /// <summary>
        ///     the value of the "INV_BOOK_ORG_REGI" field.
        /// </summary>
        private String _bookOrgRegi;

        /// <summary>
        ///     the value of the "INV_PRINT_BOOKER" field.
        /// </summary>
        private Byte? _printBooker;

        /// <summary>
        ///     the value of the "INV_INV_ORG_NAME" field.
        /// </summary>
        private String _invOrgName;

        /// <summary>
        ///     the value of the "INV_EXTRA_NOTES" field.
        /// </summary>
        private String _extraNotes;

        /// <summary>
        ///     the value of the "INV_BAT_ID" field.
        /// </summary>
        private String _batId;

        /// <summary>
        ///     the value of the "INV_SALES_ID" field.
        /// </summary>
        private String _salesId;

        /// <summary>
        ///     the value of the "INV_TEXT" field.
        /// </summary>
        private String _text;

        /// <summary>
        ///     the value of the "INV_PAY_DATE" field.
        /// </summary>
        private DateTime? _payDate;

        /// <summary>
        ///     the value of the "INV_PAY_STATUS" field.
        /// </summary>
        private String _payStatus;

        /// <summary>
        ///     the value of the "INV_PROJ_ID" field.
        /// </summary>
        private String _projId;

        /// <summary>
        ///     the value of the "INV_CCARD_ID" field.
        /// </summary>
        private String _ccardId;

        /// <summary>
        ///     the value of the "INV_RECVD" field.
        /// </summary>
        private Double? _recvd;

        /// <summary>
        ///     the value of the "INV_RECVD_BC" field.
        /// </summary>
        private Double? _recvdBc;

        /// <summary>
        ///     the value of the "INV_PERIOD" field.
        /// </summary>
        private String _period;

        /// <summary>
        ///     the value of the "INV_DUE_DATE" field.
        /// </summary>
        private DateTime? _dueDate;

        /// <summary>
        ///     the value of the "INV_UNPAID_VAL" field.
        /// </summary>
        private Decimal _unpaidVal;

        /// <summary>
        ///     the value of the "INV_UNPAID_VAL_BC" field.
        /// </summary>
        private Decimal _unpaidValBc;

        /// <summary>
        ///     the value of the "INV_NOTES_ID" field.
        /// </summary>
        private String _notesId;

        /// <summary>
        ///     the value of the "INV_CRYSTAL_RPT" field.
        /// </summary>
        private String _crystalRpt;

        /// <summary>
        ///     the value of the "INV_APP_BY" field.
        /// </summary>
        private String _appBy;

        /// <summary>
        ///     the value of the "INV_APP_DATE" field.
        /// </summary>
        private DateTime? _appDate;

        /// <summary>
        ///     the value of the "INV_FOR_ATTN_OF" field.
        /// </summary>
        private String _forAttnOf;

        /// <summary>
        ///     the value of the "INV_PRINTED" field.
        /// </summary>
        private Byte? _printed;

        /// <summary>
        ///     the value of the "INV_CURR_RATE_BC" field.
        /// </summary>
        private Decimal _currRateBc;

        /// <summary>
        ///     the value of the "INV_CURR_RATE_BC2" field.
        /// </summary>
        private Decimal _currRateBc2;

        /// <summary>
        ///     the value of the "INV_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "INV_MEP_ID" field.
        /// </summary>
        private String _mepId;

        /// <summary>
        ///     the value of the "INV_LT_ID" field.
        /// </summary>
        private String _ltId;

        /// <summary>
        ///     the value of the "INV_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "INV_ACC_STATUS" field.
        /// </summary>
        private String _accStatus;

        /// <summary>
        ///     the value of the "INV_ACC_REF" field.
        /// </summary>
        private String _accRef;

        /// <summary>
        ///     the value of the "INV_ACC_NOTES" field.
        /// </summary>
        private String _accNotes;

        /// <summary>
        ///     the value of the "INV_ACC_MOD_BY" field.
        /// </summary>
        private String _accModBy;

        /// <summary>
        ///     the value of the "INV_ACC_MOD_DATE" field.
        /// </summary>
        private DateTime? _accModDate;

        /// <summary>
        ///     the value of the "INV_NET_TOTAL_BC2" field.
        /// </summary>
        private Decimal _netTotalBc2;

        /// <summary>
        ///     the value of the "INV_VAT_TOTAL_BC2" field.
        /// </summary>
        private Decimal _vatTotalBc2;

        /// <summary>
        ///     the value of the "INV_GROSS_TOTAL_BC2" field.
        /// </summary>
        private Decimal _grossTotalBc2;

        /// <summary>
        ///     the value of the "INV_UNPAID_TOTAL_BC2" field.
        /// </summary>
        private Decimal _unpaidTotalBc2;

        /// <summary>
        ///     the value of the "INV_PRINT_BAT_ID" field.
        /// </summary>
        private String _printBatId;

        /// <summary>
        ///     the value of the "INV_PERSON_PHONE" field.
        /// </summary>
        private String _personPhone;

        /// <summary>
        ///     the value of the "INV_ACC_ID" field.
        /// </summary>
        private String _accId;

        /// <summary>
        ///     the value of the "INV_BAT_ERROR" field.
        /// </summary>
        private Byte _batError;

        /// <summary>
        ///     the value of the "INV_SALES_PROLE_ID" field.
        /// </summary>
        private String _salesProleId;

        /// <summary>
        ///     the value of the "INV_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "INV_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "INV_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "INV_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "INV_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "INV_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "INV_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "INV_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "INV_BOOK_ID" field.
        /// </summary>
        public String BookId
        {
            get { return _bookId; }
            set { _bookId = value; }
        }

        /// <summary>
        ///     the value of the "INV_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "INV_PERSON_ID" field.
        /// </summary>
        public String PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }

        /// <summary>
        ///     the value of the "INV_SALESMAN_ID" field.
        /// </summary>
        public String SalesmanId
        {
            get { return _salesmanId; }
            set { _salesmanId = value; }
        }

        /// <summary>
        ///     the value of the "INV_DELVRY_REF" field.
        /// </summary>
        public String DelvryRef
        {
            get { return _delvryRef; }
            set { _delvryRef = value; }
        }

        /// <summary>
        ///     the value of the "INV_CARRIER" field.
        /// </summary>
        public String Carrier
        {
            get { return _carrier; }
            set { _carrier = value; }
        }

        /// <summary>
        ///     the value of the "INV_DELVRY_DATE" field.
        /// </summary>
        public DateTime? DelvryDate
        {
            get { return _delvryDate; }
            set { _delvryDate = value; }
        }

        /// <summary>
        ///     the value of the "INV_ORDER_DATE" field.
        /// </summary>
        public DateTime? OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }

        /// <summary>
        ///     the value of the "INV_CUST_ORDER_NO" field.
        /// </summary>
        public String CustOrderNo
        {
            get { return _custOrderNo; }
            set { _custOrderNo = value; }
        }

        /// <summary>
        ///     the value of the "INV_DELVRY_ADD" field.
        /// </summary>
        public String DelvryAdd
        {
            get { return _delvryAdd; }
            set { _delvryAdd = value; }
        }

        /// <summary>
        ///     the value of the "INV_REF" field.
        /// </summary>
        public String Ref
        {
            get { return _ref; }
            set { _ref = value; }
        }

        /// <summary>
        ///     the value of the "INV_DATE" field.
        /// </summary>
        public DateTime? Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        ///     the value of the "INV_STATUS" field.
        /// </summary>
        public Byte? Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "INV_ADD" field.
        /// </summary>
        public String Add
        {
            get { return _add; }
            set { _add = value; }
        }

        /// <summary>
        ///     the value of the "INV_CREDIT_NTE_REF" field.
        /// </summary>
        public String CreditNteRef
        {
            get { return _creditNteRef; }
            set { _creditNteRef = value; }
        }

        /// <summary>
        ///     the value of the "INV_CREDIT_NTE_DTE" field.
        /// </summary>
        public DateTime? CreditNteDte
        {
            get { return _creditNteDte; }
            set { _creditNteDte = value; }
        }

        /// <summary>
        ///     the value of the "INV_CREDIT_NTE_STA" field.
        /// </summary>
        public Byte? CreditNteSta
        {
            get { return _creditNteSta; }
            set { _creditNteSta = value; }
        }

        /// <summary>
        ///     the value of the "INV_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "INV_NET_TOTAL" field.
        /// </summary>
        public Decimal NetTotal
        {
            get { return _netTotal; }
            set { _netTotal = value; }
        }

        /// <summary>
        ///     the value of the "INV_VAT_TOTAL" field.
        /// </summary>
        public Decimal VatTotal
        {
            get { return _vatTotal; }
            set { _vatTotal = value; }
        }

        /// <summary>
        ///     the value of the "INV_GROSS_TOTAL" field.
        /// </summary>
        public Decimal GrossTotal
        {
            get { return _grossTotal; }
            set { _grossTotal = value; }
        }

        /// <summary>
        ///     the value of the "INV_NET_TOTAL_BC" field.
        /// </summary>
        public Decimal NetTotalBc
        {
            get { return _netTotalBc; }
            set { _netTotalBc = value; }
        }

        /// <summary>
        ///     the value of the "INV_VAT_TOTAL_BC" field.
        /// </summary>
        public Decimal VatTotalBc
        {
            get { return _vatTotalBc; }
            set { _vatTotalBc = value; }
        }

        /// <summary>
        ///     the value of the "INV_GROSS_TOTAL_BC" field.
        /// </summary>
        public Decimal GrossTotalBc
        {
            get { return _grossTotalBc; }
            set { _grossTotalBc = value; }
        }

        /// <summary>
        ///     the value of the "INV_CURRENCY_TYPE" field.
        /// </summary>
        public String CurrencyType
        {
            get { return _currencyType; }
            set { _currencyType = value; }
        }

        /// <summary>
        ///     the value of the "INV_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "INV_ACCOUNT_TYPE" field.
        /// </summary>
        public String AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }
        }

        /// <summary>
        ///     the value of the "INV_IN_RESPECT_OF" field.
        /// </summary>
        public String InRespectOf
        {
            get { return _inRespectOf; }
            set { _inRespectOf = value; }
        }

        /// <summary>
        ///     the value of the "INV_FOOTER" field.
        /// </summary>
        public String Footer
        {
            get { return _footer; }
            set { _footer = value; }
        }

        /// <summary>
        ///     the value of the "INV_CREDIT_PERCENT" field.
        /// </summary>
        public Double? CreditPercent
        {
            get { return _creditPercent; }
            set { _creditPercent = value; }
        }

        /// <summary>
        ///     the value of the "INV_COURSE_ID" field.
        /// </summary>
        public String CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }

        /// <summary>
        ///     the value of the "INV_COURSE_NAME" field.
        /// </summary>
        public String CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }

        /// <summary>
        ///     the value of the "INV_CORS_STRT_DTE" field.
        /// </summary>
        public DateTime? CorsStrtDte
        {
            get { return _corsStrtDte; }
            set { _corsStrtDte = value; }
        }

        /// <summary>
        ///     the value of the "INV_COURSE_END_DTE" field.
        /// </summary>
        public DateTime? CourseEndDte
        {
            get { return _courseEndDte; }
            set { _courseEndDte = value; }
        }

        /// <summary>
        ///     the value of the "INV_CORS_COST_CODE" field.
        /// </summary>
        public String CorsCostCode
        {
            get { return _corsCostCode; }
            set { _corsCostCode = value; }
        }

        /// <summary>
        ///     the value of the "INV_BOOK_REF" field.
        /// </summary>
        public String BookRef
        {
            get { return _bookRef; }
            set { _bookRef = value; }
        }

        /// <summary>
        ///     the value of the "INV_BOOKER" field.
        /// </summary>
        public String Booker
        {
            get { return _booker; }
            set { _booker = value; }
        }

        /// <summary>
        ///     the value of the "INV_BOOK_ORG_NAME" field.
        /// </summary>
        public String BookOrgName
        {
            get { return _bookOrgName; }
            set { _bookOrgName = value; }
        }

        /// <summary>
        ///     the value of the "INV_ADD_MAILSTRING" field.
        /// </summary>
        public String AddMailstring
        {
            get { return _addMailstring; }
            set { _addMailstring = value; }
        }

        /// <summary>
        ///     the value of the "INV_BK_ORG_CUST_AC" field.
        /// </summary>
        public String BkOrgCustAc
        {
            get { return _bkOrgCustAc; }
            set { _bkOrgCustAc = value; }
        }

        /// <summary>
        ///     the value of the "INV_VENUE_ORG_NAME" field.
        /// </summary>
        public String VenueOrgName
        {
            get { return _venueOrgName; }
            set { _venueOrgName = value; }
        }

        /// <summary>
        ///     the value of the "INV_PENALTY" field.
        /// </summary>
        public Byte? Penalty
        {
            get { return _penalty; }
            set { _penalty = value; }
        }

        /// <summary>
        ///     the value of the "INV_BOOK_ORG_REGI" field.
        /// </summary>
        public String BookOrgRegi
        {
            get { return _bookOrgRegi; }
            set { _bookOrgRegi = value; }
        }

        /// <summary>
        ///     the value of the "INV_PRINT_BOOKER" field.
        /// </summary>
        public Byte? PrintBooker
        {
            get { return _printBooker; }
            set { _printBooker = value; }
        }

        /// <summary>
        ///     the value of the "INV_INV_ORG_NAME" field.
        /// </summary>
        public String InvOrgName
        {
            get { return _invOrgName; }
            set { _invOrgName = value; }
        }

        /// <summary>
        ///     the value of the "INV_EXTRA_NOTES" field.
        /// </summary>
        public String ExtraNotes
        {
            get { return _extraNotes; }
            set { _extraNotes = value; }
        }

        /// <summary>
        ///     the value of the "INV_BAT_ID" field.
        /// </summary>
        public String BatId
        {
            get { return _batId; }
            set { _batId = value; }
        }

        /// <summary>
        ///     the value of the "INV_SALES_ID" field.
        /// </summary>
        public String SalesId
        {
            get { return _salesId; }
            set { _salesId = value; }
        }

        /// <summary>
        ///     the value of the "INV_TEXT" field.
        /// </summary>
        public String Text
        {
            get { return _text; }
            set { _text = value; }
        }

        /// <summary>
        ///     the value of the "INV_PAY_DATE" field.
        /// </summary>
        public DateTime? PayDate
        {
            get { return _payDate; }
            set { _payDate = value; }
        }

        /// <summary>
        ///     the value of the "INV_PAY_STATUS" field.
        /// </summary>
        public String PayStatus
        {
            get { return _payStatus; }
            set { _payStatus = value; }
        }

        /// <summary>
        ///     the value of the "INV_PROJ_ID" field.
        /// </summary>
        public String ProjId
        {
            get { return _projId; }
            set { _projId = value; }
        }

        /// <summary>
        ///     the value of the "INV_CCARD_ID" field.
        /// </summary>
        public String CcardId
        {
            get { return _ccardId; }
            set { _ccardId = value; }
        }

        /// <summary>
        ///     the value of the "INV_RECVD" field.
        /// </summary>
        public Double? Recvd
        {
            get { return _recvd; }
            set { _recvd = value; }
        }

        /// <summary>
        ///     the value of the "INV_RECVD_BC" field.
        /// </summary>
        public Double? RecvdBc
        {
            get { return _recvdBc; }
            set { _recvdBc = value; }
        }

        /// <summary>
        ///     the value of the "INV_PERIOD" field.
        /// </summary>
        public String Period
        {
            get { return _period; }
            set { _period = value; }
        }

        /// <summary>
        ///     the value of the "INV_DUE_DATE" field.
        /// </summary>
        public DateTime? DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; }
        }

        /// <summary>
        ///     the value of the "INV_UNPAID_VAL" field.
        /// </summary>
        public Decimal UnpaidVal
        {
            get { return _unpaidVal; }
            set { _unpaidVal = value; }
        }

        /// <summary>
        ///     the value of the "INV_UNPAID_VAL_BC" field.
        /// </summary>
        public Decimal UnpaidValBc
        {
            get { return _unpaidValBc; }
            set { _unpaidValBc = value; }
        }

        /// <summary>
        ///     the value of the "INV_NOTES_ID" field.
        /// </summary>
        public String NotesId
        {
            get { return _notesId; }
            set { _notesId = value; }
        }

        /// <summary>
        ///     the value of the "INV_CRYSTAL_RPT" field.
        /// </summary>
        public String CrystalRpt
        {
            get { return _crystalRpt; }
            set { _crystalRpt = value; }
        }

        /// <summary>
        ///     the value of the "INV_APP_BY" field.
        /// </summary>
        public String AppBy
        {
            get { return _appBy; }
            set { _appBy = value; }
        }

        /// <summary>
        ///     the value of the "INV_APP_DATE" field.
        /// </summary>
        public DateTime? AppDate
        {
            get { return _appDate; }
            set { _appDate = value; }
        }

        /// <summary>
        ///     the value of the "INV_FOR_ATTN_OF" field.
        /// </summary>
        public String ForAttnOf
        {
            get { return _forAttnOf; }
            set { _forAttnOf = value; }
        }

        /// <summary>
        ///     the value of the "INV_PRINTED" field.
        /// </summary>
        public Byte? Printed
        {
            get { return _printed; }
            set { _printed = value; }
        }

        /// <summary>
        ///     the value of the "INV_CURR_RATE_BC" field.
        /// </summary>
        public Decimal CurrRateBc
        {
            get { return _currRateBc; }
            set { _currRateBc = value; }
        }

        /// <summary>
        ///     the value of the "INV_CURR_RATE_BC2" field.
        /// </summary>
        public Decimal CurrRateBc2
        {
            get { return _currRateBc2; }
            set { _currRateBc2 = value; }
        }

        /// <summary>
        ///     the value of the "INV_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "INV_MEP_ID" field.
        /// </summary>
        public String MepId
        {
            get { return _mepId; }
            set { _mepId = value; }
        }

        /// <summary>
        ///     the value of the "INV_LT_ID" field.
        /// </summary>
        public String LtId
        {
            get { return _ltId; }
            set { _ltId = value; }
        }

        /// <summary>
        ///     the value of the "INV_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "INV_ACC_STATUS" field.
        /// </summary>
        public String AccStatus
        {
            get { return _accStatus; }
            set { _accStatus = value; }
        }

        /// <summary>
        ///     the value of the "INV_ACC_REF" field.
        /// </summary>
        public String AccRef
        {
            get { return _accRef; }
            set { _accRef = value; }
        }

        /// <summary>
        ///     the value of the "INV_ACC_NOTES" field.
        /// </summary>
        public String AccNotes
        {
            get { return _accNotes; }
            set { _accNotes = value; }
        }

        /// <summary>
        ///     the value of the "INV_ACC_MOD_BY" field.
        /// </summary>
        public String AccModBy
        {
            get { return _accModBy; }
            set { _accModBy = value; }
        }

        /// <summary>
        ///     the value of the "INV_ACC_MOD_DATE" field.
        /// </summary>
        public DateTime? AccModDate
        {
            get { return _accModDate; }
            set { _accModDate = value; }
        }

        /// <summary>
        ///     the value of the "INV_NET_TOTAL_BC2" field.
        /// </summary>
        public Decimal NetTotalBc2
        {
            get { return _netTotalBc2; }
            set { _netTotalBc2 = value; }
        }

        /// <summary>
        ///     the value of the "INV_VAT_TOTAL_BC2" field.
        /// </summary>
        public Decimal VatTotalBc2
        {
            get { return _vatTotalBc2; }
            set { _vatTotalBc2 = value; }
        }

        /// <summary>
        ///     the value of the "INV_GROSS_TOTAL_BC2" field.
        /// </summary>
        public Decimal GrossTotalBc2
        {
            get { return _grossTotalBc2; }
            set { _grossTotalBc2 = value; }
        }

        /// <summary>
        ///     the value of the "INV_UNPAID_TOTAL_BC2" field.
        /// </summary>
        public Decimal UnpaidTotalBc2
        {
            get { return _unpaidTotalBc2; }
            set { _unpaidTotalBc2 = value; }
        }

        /// <summary>
        ///     the value of the "INV_PRINT_BAT_ID" field.
        /// </summary>
        public String PrintBatId
        {
            get { return _printBatId; }
            set { _printBatId = value; }
        }

        /// <summary>
        ///     the value of the "INV_PERSON_PHONE" field.
        /// </summary>
        public String PersonPhone
        {
            get { return _personPhone; }
            set { _personPhone = value; }
        }

        /// <summary>
        ///     the value of the "INV_ACC_ID" field.
        /// </summary>
        public String AccId
        {
            get { return _accId; }
            set { _accId = value; }
        }

        /// <summary>
        ///     the value of the "INV_BAT_ERROR" field.
        /// </summary>
        public Byte BatError
        {
            get { return _batError; }
            set { _batError = value; }
        }

        /// <summary>
        ///     the value of the "INV_SALES_PROLE_ID" field.
        /// </summary>
        public String SalesProleId
        {
            get { return _salesProleId; }
            set { _salesProleId = value; }
        }

        /// <summary>
        ///     the value of the "INV_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="InvheaderRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="InvheaderRecord" /> object instance.
        /// </returns>
        public InvheaderRecord Clone()
        {
            InvheaderRecord record = new InvheaderRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.BookId = this.BookId;
            record.OrgId = this.OrgId;
            record.PersonId = this.PersonId;
            record.SalesmanId = this.SalesmanId;
            record.DelvryRef = this.DelvryRef;
            record.Carrier = this.Carrier;
            record.DelvryDate = this.DelvryDate;
            record.OrderDate = this.OrderDate;
            record.CustOrderNo = this.CustOrderNo;
            record.DelvryAdd = this.DelvryAdd;
            record.Ref = this.Ref;
            record.Date = this.Date;
            record.Status = this.Status;
            record.Add = this.Add;
            record.CreditNteRef = this.CreditNteRef;
            record.CreditNteDte = this.CreditNteDte;
            record.CreditNteSta = this.CreditNteSta;
            record.Notes = this.Notes;
            record.NetTotal = this.NetTotal;
            record.VatTotal = this.VatTotal;
            record.GrossTotal = this.GrossTotal;
            record.NetTotalBc = this.NetTotalBc;
            record.VatTotalBc = this.VatTotalBc;
            record.GrossTotalBc = this.GrossTotalBc;
            record.CurrencyType = this.CurrencyType;
            record.Type = this.Type;
            record.AccountType = this.AccountType;
            record.InRespectOf = this.InRespectOf;
            record.Footer = this.Footer;
            record.CreditPercent = this.CreditPercent;
            record.CourseId = this.CourseId;
            record.CourseName = this.CourseName;
            record.CorsStrtDte = this.CorsStrtDte;
            record.CourseEndDte = this.CourseEndDte;
            record.CorsCostCode = this.CorsCostCode;
            record.BookRef = this.BookRef;
            record.Booker = this.Booker;
            record.BookOrgName = this.BookOrgName;
            record.AddMailstring = this.AddMailstring;
            record.BkOrgCustAc = this.BkOrgCustAc;
            record.VenueOrgName = this.VenueOrgName;
            record.Penalty = this.Penalty;
            record.BookOrgRegi = this.BookOrgRegi;
            record.PrintBooker = this.PrintBooker;
            record.InvOrgName = this.InvOrgName;
            record.ExtraNotes = this.ExtraNotes;
            record.BatId = this.BatId;
            record.SalesId = this.SalesId;
            record.Text = this.Text;
            record.PayDate = this.PayDate;
            record.PayStatus = this.PayStatus;
            record.ProjId = this.ProjId;
            record.CcardId = this.CcardId;
            record.Recvd = this.Recvd;
            record.RecvdBc = this.RecvdBc;
            record.Period = this.Period;
            record.DueDate = this.DueDate;
            record.UnpaidVal = this.UnpaidVal;
            record.UnpaidValBc = this.UnpaidValBc;
            record.NotesId = this.NotesId;
            record.CrystalRpt = this.CrystalRpt;
            record.AppBy = this.AppBy;
            record.AppDate = this.AppDate;
            record.ForAttnOf = this.ForAttnOf;
            record.Printed = this.Printed;
            record.CurrRateBc = this.CurrRateBc;
            record.CurrRateBc2 = this.CurrRateBc2;
            record.SelcoSpId = this.SelcoSpId;
            record.MepId = this.MepId;
            record.LtId = this.LtId;
            record.Userchar1 = this.Userchar1;
            record.AccStatus = this.AccStatus;
            record.AccRef = this.AccRef;
            record.AccNotes = this.AccNotes;
            record.AccModBy = this.AccModBy;
            record.AccModDate = this.AccModDate;
            record.NetTotalBc2 = this.NetTotalBc2;
            record.VatTotalBc2 = this.VatTotalBc2;
            record.GrossTotalBc2 = this.GrossTotalBc2;
            record.UnpaidTotalBc2 = this.UnpaidTotalBc2;
            record.PrintBatId = this.PrintBatId;
            record.PersonPhone = this.PersonPhone;
            record.AccId = this.AccId;
            record.BatError = this.BatError;
            record.SalesProleId = this.SalesProleId;
            record.ProleId = this.ProleId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="InvheaderRecord" /> instance is equal to another <see cref="InvheaderRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="InvheaderRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(InvheaderRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.BookId.TrimOrNullify() == that.BookId.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.PersonId.TrimOrNullify() == that.PersonId.TrimOrNullify());
            result = result && (this.SalesmanId.TrimOrNullify() == that.SalesmanId.TrimOrNullify());
            result = result && (this.DelvryRef.TrimOrNullify() == that.DelvryRef.TrimOrNullify());
            result = result && (this.Carrier.TrimOrNullify() == that.Carrier.TrimOrNullify());
            result = result && (this.DelvryDate == that.DelvryDate);
            result = result && (this.OrderDate == that.OrderDate);
            result = result && (this.CustOrderNo.TrimOrNullify() == that.CustOrderNo.TrimOrNullify());
            result = result && (this.DelvryAdd.TrimOrNullify() == that.DelvryAdd.TrimOrNullify());
            result = result && (this.Ref.TrimOrNullify() == that.Ref.TrimOrNullify());
            result = result && (this.Date == that.Date);
            result = result && (this.Status == that.Status);
            result = result && (this.Add.TrimOrNullify() == that.Add.TrimOrNullify());
            result = result && (this.CreditNteRef.TrimOrNullify() == that.CreditNteRef.TrimOrNullify());
            result = result && (this.CreditNteDte == that.CreditNteDte);
            result = result && (this.CreditNteSta == that.CreditNteSta);
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.NetTotal == that.NetTotal);
            result = result && (this.VatTotal == that.VatTotal);
            result = result && (this.GrossTotal == that.GrossTotal);
            result = result && (this.NetTotalBc == that.NetTotalBc);
            result = result && (this.VatTotalBc == that.VatTotalBc);
            result = result && (this.GrossTotalBc == that.GrossTotalBc);
            result = result && (this.CurrencyType.TrimOrNullify() == that.CurrencyType.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.AccountType.TrimOrNullify() == that.AccountType.TrimOrNullify());
            result = result && (this.InRespectOf.TrimOrNullify() == that.InRespectOf.TrimOrNullify());
            result = result && (this.Footer.TrimOrNullify() == that.Footer.TrimOrNullify());
            result = result && (this.CreditPercent == that.CreditPercent);
            result = result && (this.CourseId.TrimOrNullify() == that.CourseId.TrimOrNullify());
            result = result && (this.CourseName.TrimOrNullify() == that.CourseName.TrimOrNullify());
            result = result && (this.CorsStrtDte == that.CorsStrtDte);
            result = result && (this.CourseEndDte == that.CourseEndDte);
            result = result && (this.CorsCostCode.TrimOrNullify() == that.CorsCostCode.TrimOrNullify());
            result = result && (this.BookRef.TrimOrNullify() == that.BookRef.TrimOrNullify());
            result = result && (this.Booker.TrimOrNullify() == that.Booker.TrimOrNullify());
            result = result && (this.BookOrgName.TrimOrNullify() == that.BookOrgName.TrimOrNullify());
            result = result && (this.AddMailstring.TrimOrNullify() == that.AddMailstring.TrimOrNullify());
            result = result && (this.BkOrgCustAc.TrimOrNullify() == that.BkOrgCustAc.TrimOrNullify());
            result = result && (this.VenueOrgName.TrimOrNullify() == that.VenueOrgName.TrimOrNullify());
            result = result && (this.Penalty == that.Penalty);
            result = result && (this.BookOrgRegi.TrimOrNullify() == that.BookOrgRegi.TrimOrNullify());
            result = result && (this.PrintBooker == that.PrintBooker);
            result = result && (this.InvOrgName.TrimOrNullify() == that.InvOrgName.TrimOrNullify());
            result = result && (this.ExtraNotes.TrimOrNullify() == that.ExtraNotes.TrimOrNullify());
            result = result && (this.BatId.TrimOrNullify() == that.BatId.TrimOrNullify());
            result = result && (this.SalesId.TrimOrNullify() == that.SalesId.TrimOrNullify());
            result = result && (this.Text.TrimOrNullify() == that.Text.TrimOrNullify());
            result = result && (this.PayDate == that.PayDate);
            result = result && (this.PayStatus.TrimOrNullify() == that.PayStatus.TrimOrNullify());
            result = result && (this.ProjId.TrimOrNullify() == that.ProjId.TrimOrNullify());
            result = result && (this.CcardId.TrimOrNullify() == that.CcardId.TrimOrNullify());
            result = result && (this.Recvd == that.Recvd);
            result = result && (this.RecvdBc == that.RecvdBc);
            result = result && (this.Period.TrimOrNullify() == that.Period.TrimOrNullify());
            result = result && (this.DueDate == that.DueDate);
            result = result && (this.UnpaidVal == that.UnpaidVal);
            result = result && (this.UnpaidValBc == that.UnpaidValBc);
            result = result && (this.NotesId.TrimOrNullify() == that.NotesId.TrimOrNullify());
            result = result && (this.CrystalRpt.TrimOrNullify() == that.CrystalRpt.TrimOrNullify());
            result = result && (this.AppBy.TrimOrNullify() == that.AppBy.TrimOrNullify());
            result = result && (this.AppDate == that.AppDate);
            result = result && (this.ForAttnOf.TrimOrNullify() == that.ForAttnOf.TrimOrNullify());
            result = result && (this.Printed == that.Printed);
            result = result && (this.CurrRateBc == that.CurrRateBc);
            result = result && (this.CurrRateBc2 == that.CurrRateBc2);
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.MepId.TrimOrNullify() == that.MepId.TrimOrNullify());
            result = result && (this.LtId.TrimOrNullify() == that.LtId.TrimOrNullify());
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.AccStatus.TrimOrNullify() == that.AccStatus.TrimOrNullify());
            result = result && (this.AccRef.TrimOrNullify() == that.AccRef.TrimOrNullify());
            result = result && (this.AccNotes.TrimOrNullify() == that.AccNotes.TrimOrNullify());
            result = result && (this.AccModBy.TrimOrNullify() == that.AccModBy.TrimOrNullify());
            result = result && (this.AccModDate == that.AccModDate);
            result = result && (this.NetTotalBc2 == that.NetTotalBc2);
            result = result && (this.VatTotalBc2 == that.VatTotalBc2);
            result = result && (this.GrossTotalBc2 == that.GrossTotalBc2);
            result = result && (this.UnpaidTotalBc2 == that.UnpaidTotalBc2);
            result = result && (this.PrintBatId.TrimOrNullify() == that.PrintBatId.TrimOrNullify());
            result = result && (this.PersonPhone.TrimOrNullify() == that.PersonPhone.TrimOrNullify());
            result = result && (this.AccId.TrimOrNullify() == that.AccId.TrimOrNullify());
            result = result && (this.BatError == that.BatError);
            result = result && (this.SalesProleId.TrimOrNullify() == that.SalesProleId.TrimOrNullify());
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
