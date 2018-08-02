using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Represents the "Member_period" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class MemberPeriodRecord : Record<String>, Cloneable<MemberPeriodRecord>, IEquatable<MemberPeriodRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "MEP_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "MEP_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "MEP_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "MEP_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "MEP_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "MEP_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "MEP_MEM_ID" field.
        /// </summary>
        private String _memId;

        /// <summary>
        ///     the value of the "MEP_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "MEP_MEM_GRADE" field.
        /// </summary>
        private String _memGrade;

        /// <summary>
        ///     the value of the "MEP_YEAR" field.
        /// </summary>
        private String _year;

        /// <summary>
        ///     the value of the "MEP_START" field.
        /// </summary>
        private DateTime? _start;

        /// <summary>
        ///     the value of the "MEP_END" field.
        /// </summary>
        private DateTime? _end;

        /// <summary>
        ///     the value of the "MEP_RENEW_DATE1" field.
        /// </summary>
        private DateTime? _renewDate1;

        /// <summary>
        ///     the value of the "MEP_RENEW_DATE2" field.
        /// </summary>
        private DateTime? _renewDate2;

        /// <summary>
        ///     the value of the "MEP_RENEW_DATE3" field.
        /// </summary>
        private DateTime? _renewDate3;

        /// <summary>
        ///     the value of the "MEP_QTY_1" field.
        /// </summary>
        private Int32? _qty1;

        /// <summary>
        ///     the value of the "MEP_QTY_2" field.
        /// </summary>
        private Int32? _qty2;

        /// <summary>
        ///     the value of the "MEP_QTY_3" field.
        /// </summary>
        private Int32? _qty3;

        /// <summary>
        ///     the value of the "MEP_QTY_4" field.
        /// </summary>
        private Int32? _qty4;

        /// <summary>
        ///     the value of the "MEP_QTY_5" field.
        /// </summary>
        private Int32? _qty5;

        /// <summary>
        ///     the value of the "MEP_FEE" field.
        /// </summary>
        private Decimal _fee;

        /// <summary>
        ///     the value of the "MEP_FEE_BC" field.
        /// </summary>
        private Decimal _feeBc;

        /// <summary>
        ///     the value of the "MEP_FEE_BC2" field.
        /// </summary>
        private Decimal _feeBc2;

        /// <summary>
        ///     the value of the "MEP_CURRENCY" field.
        /// </summary>
        private String _currency;

        /// <summary>
        ///     the value of the "MEP_FEE_EXTRA" field.
        /// </summary>
        private Decimal _feeExtra;

        /// <summary>
        ///     the value of the "MEP_FEE_EXTRA_BC" field.
        /// </summary>
        private Decimal _feeExtraBc;

        /// <summary>
        ///     the value of the "MEP_FEE_EXTRA_BC2" field.
        /// </summary>
        private Decimal _feeExtraBc2;

        /// <summary>
        ///     the value of the "MEP_PAY_METHOD" field.
        /// </summary>
        private String _payMethod;

        /// <summary>
        ///     the value of the "MEP_PAY_STATUS" field.
        /// </summary>
        private String _payStatus;

        /// <summary>
        ///     the value of the "MEP_PO_REF" field.
        /// </summary>
        private String _poRef;

        /// <summary>
        ///     the value of the "MEP_CCARD_TYPE" field.
        /// </summary>
        private String _ccardType;

        /// <summary>
        ///     the value of the "MEP_NAME_ON_CARD" field.
        /// </summary>
        private String _nameOnCard;

        /// <summary>
        ///     the value of the "MEP_CCARD_NUMBER" field.
        /// </summary>
        private String _ccardNumber;

        /// <summary>
        ///     the value of the "MEP_CCARD_START" field.
        /// </summary>
        private String _ccardStart;

        /// <summary>
        ///     the value of the "MEP_CCARD_EXPY" field.
        /// </summary>
        private String _ccardExpy;

        /// <summary>
        ///     the value of the "MEP_BANK_ACC_CODE" field.
        /// </summary>
        private String _bankAccCode;

        /// <summary>
        ///     the value of the "MEP_SORT_CODE" field.
        /// </summary>
        private String _sortCode;

        /// <summary>
        ///     the value of the "MEP_CCARD_ISSUE" field.
        /// </summary>
        private String _ccardIssue;

        /// <summary>
        ///     the value of the "MEP_SECURITY" field.
        /// </summary>
        private String _security;

        /// <summary>
        ///     the value of the "MEP_CCARD_AUTHCODE" field.
        /// </summary>
        private String _ccardAuthcode;

        /// <summary>
        ///     the value of the "MEP_DOCS_METHOD" field.
        /// </summary>
        private String _docsMethod;

        /// <summary>
        ///     the value of the "MEP_INV_ORG_ID" field.
        /// </summary>
        private String _invOrgId;

        /// <summary>
        ///     the value of the "MEP_INV_PROLE_ID" field.
        /// </summary>
        private String _invProleId;

        /// <summary>
        ///     the value of the "MEP_INV_ADD_ID" field.
        /// </summary>
        private String _invAddId;

        /// <summary>
        ///     the value of the "MEP_PRICE_LIST_ID" field.
        /// </summary>
        private String _priceListId;

        /// <summary>
        ///     the value of the "MEP_CURRENT" field.
        /// </summary>
        private Byte? _current;

        /// <summary>
        ///     the value of the "MEP_PM_ID" field.
        /// </summary>
        private String _pmId;

        /// <summary>
        ///     the value of the "MEP_SUB_ONLY" field.
        /// </summary>
        private Int32? _subOnly;

        /// <summary>
        ///     the value of the "MEP_RENEWED_DATE" field.
        /// </summary>
        private DateTime? _renewedDate;

        /// <summary>
        ///     the value of the "MEP_LAPSED_DATE" field.
        /// </summary>
        private DateTime? _lapsedDate;

        /// <summary>
        ///     the value of the "MEP_RENEW_DATE_0" field.
        /// </summary>
        private DateTime? _renewDate0;

        /// <summary>
        ///     the value of the "MEP_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "MEP_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "MEP_RENEWAL_DATE" field.
        /// </summary>
        private DateTime? _renewalDate;

        /// <summary>
        ///     the value of the "MEP_RENEW_START" field.
        /// </summary>
        private DateTime? _renewStart;

        /// <summary>
        ///     the value of the "MEP_CREATE_BAT_ID" field.
        /// </summary>
        private String _createBatId;

        /// <summary>
        ///     the value of the "MEP_RENEW_BAT_ID" field.
        /// </summary>
        private String _renewBatId;

        /// <summary>
        ///     the value of the "MEP_OLD_MEP_ID" field.
        /// </summary>
        private String _oldMepId;

        /// <summary>
        ///     the value of the "MEP_INC_HIERARCHY" field.
        /// </summary>
        private Int32? _incHierarchy;

        /// <summary>
        ///     the value of the "MEP_NO_COPIES_1" field.
        /// </summary>
        private Int32? _noCopies1;

        /// <summary>
        ///     the value of the "MEP_NO_COPIES_2" field.
        /// </summary>
        private Int32? _noCopies2;

        /// <summary>
        ///     the value of the "MEP_NO_COPIES_3" field.
        /// </summary>
        private Int32? _noCopies3;

        /// <summary>
        ///     the value of the "MEP_CUST_ORDER_NO" field.
        /// </summary>
        private String _custOrderNo;

        /// <summary>
        ///     the value of the "MEP_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "MEP_CANCEL_REASON" field.
        /// </summary>
        private String _cancelReason;

        /// <summary>
        ///     the value of the "MEP_MEMB_RATE" field.
        /// </summary>
        private Byte? _membRate;

        /// <summary>
        ///     the value of the "MEP_MEM_TYPE" field.
        /// </summary>
        private String _memType;

        /// <summary>
        ///     the value of the "MEP_FOR_ATTN_OF" field.
        /// </summary>
        private String _forAttnOf;

        /// <summary>
        ///     the value of the "MEP_ORG_CUST_AC" field.
        /// </summary>
        private String _orgCustAc;

        /// <summary>
        ///     the value of the "MEP_REMIND1_BAT_ID" field.
        /// </summary>
        private String _remind1BatId;

        /// <summary>
        ///     the value of the "MEP_REMIND2_BAT_ID" field.
        /// </summary>
        private String _remind2BatId;

        /// <summary>
        ///     the value of the "MEP_REMIND3_BAT_ID" field.
        /// </summary>
        private String _remind3BatId;

        /// <summary>
        ///     the value of the "MEP_REMIND4_BAT_ID" field.
        /// </summary>
        private String _remind4BatId;

        /// <summary>
        ///     the value of the "MEP_REMIND1_DATE" field.
        /// </summary>
        private DateTime? _remind1Date;

        /// <summary>
        ///     the value of the "MEP_REMIND2_DATE" field.
        /// </summary>
        private DateTime? _remind2Date;

        /// <summary>
        ///     the value of the "MEP_REMIND3_DATE" field.
        /// </summary>
        private DateTime? _remind3Date;

        /// <summary>
        ///     the value of the "MEP_REMIND4_DATE" field.
        /// </summary>
        private DateTime? _remind4Date;

        /// <summary>
        ///     the value of the "MEP_PREV_STATUS" field.
        /// </summary>
        private String _prevStatus;

        /// <summary>
        ///     the value of the "MEP_CONT_PAYMENT" field.
        /// </summary>
        private Byte? _contPayment;

        /// <summary>
        ///     the value of the "MEP_NET_FEE" field.
        /// </summary>
        private Decimal _netFee;

        /// <summary>
        ///     the value of the "MEP_NET_FEE_BC" field.
        /// </summary>
        private Decimal _netFeeBc;

        /// <summary>
        ///     the value of the "MEP_NET_FEE_BC2" field.
        /// </summary>
        private Decimal _netFeeBc2;

        /// <summary>
        ///     the value of the "MEP_VAT_AMT" field.
        /// </summary>
        private Decimal _vatAmt;

        /// <summary>
        ///     the value of the "MEP_VAT_AMT_BC" field.
        /// </summary>
        private Decimal _vatAmtBc;

        /// <summary>
        ///     the value of the "MEP_VAT_AMT_BC2" field.
        /// </summary>
        private Decimal _vatAmtBc2;

        /// <summary>
        ///     the value of the "MEP_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "MEP_CURRENT_DATE" field.
        /// </summary>
        private DateTime? _currentDate;

        /// <summary>
        ///     the value of the "MEP_LAPSE_DATE" field.
        /// </summary>
        private DateTime? _lapseDate;

        /// <summary>
        ///     the value of the "MEP_BATCH_INVOICE" field.
        /// </summary>
        private Byte? _batchInvoice;

        /// <summary>
        ///     the value of the "MEP_BASKET_FL" field.
        /// </summary>
        private Byte _basketFl;

        /// <summary>
        ///     the value of the "MEP_INDEM_INSUR_DATE" field.
        /// </summary>
        private DateTime? _indemInsurDate;

        /// <summary>
        ///     the value of the "MEP_EXP_BAT_ID" field.
        /// </summary>
        private String _expBatId;

        /// <summary>
        ///     the value of the "MEP_ROLLBACK_DATE" field.
        /// </summary>
        private DateTime? _rollbackDate;

        /// <summary>
        ///     the value of the "MEP_STATUS_INT" field.
        /// </summary>
        private Int32 _statusInt;

        /// <summary>
        ///     the value of the "MEP_SHORT_DATED" field.
        /// </summary>
        private Int32? _shortDated;

        /// <summary>
        ///     the value of the "MEP_CART_ID" field.
        /// </summary>
        private Int32? _cartId;

        /// <summary>
        ///     the value of the "MEP_PCLN_ID" field.
        /// </summary>
        private Int32? _pclnId;

        /// <summary>
        ///     the value of the "MEP_CURR_RATE_BC" field.
        /// </summary>
        private Decimal? _currRateBc;

        /// <summary>
        ///     the value of the "MEP_CURR_RATE_BC2" field.
        /// </summary>
        private Decimal? _currRateBc2;

        /// <summary>
        ///     the value of the "MEP_APP_METHOD" field.
        /// </summary>
        private String _appMethod;

        /// <summary>
        ///     the value of the "MEP_OPP_ID" field.
        /// </summary>
        private String _oppId;

        /// <summary>
        ///     the value of the "MEP_DO_NOT_INVOIC" field.
        /// </summary>
        private Byte? _doNotInvoic;

        /// <summary>
        ///     the value of the "MEP_PO_EXPIRATION_DATE" field.
        /// </summary>
        private DateTime? _poExpirationDate;

        /// <summary>
        ///     the value of the "MEP_ACC_ID" field.
        /// </summary>
        private String _accId;

        /// <summary>
        ///     the value of the "MEP_MEMBERSHIP_NAME" field.
        /// </summary>
        private String _membershipName;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "MEP_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "MEP_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "MEP_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "MEP_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "MEP_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "MEP_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "MEP_MEM_ID" field.
        /// </summary>
        public String MemId
        {
            get { return _memId; }
            set { _memId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_MEM_GRADE" field.
        /// </summary>
        public String MemGrade
        {
            get { return _memGrade; }
            set { _memGrade = value; }
        }

        /// <summary>
        ///     the value of the "MEP_YEAR" field.
        /// </summary>
        public String Year
        {
            get { return _year; }
            set { _year = value; }
        }

        /// <summary>
        ///     the value of the "MEP_START" field.
        /// </summary>
        public DateTime? Start
        {
            get { return _start; }
            set { _start = value; }
        }

        /// <summary>
        ///     the value of the "MEP_END" field.
        /// </summary>
        public DateTime? End
        {
            get { return _end; }
            set { _end = value; }
        }

        /// <summary>
        ///     the value of the "MEP_RENEW_DATE1" field.
        /// </summary>
        public DateTime? RenewDate1
        {
            get { return _renewDate1; }
            set { _renewDate1 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_RENEW_DATE2" field.
        /// </summary>
        public DateTime? RenewDate2
        {
            get { return _renewDate2; }
            set { _renewDate2 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_RENEW_DATE3" field.
        /// </summary>
        public DateTime? RenewDate3
        {
            get { return _renewDate3; }
            set { _renewDate3 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_QTY_1" field.
        /// </summary>
        public Int32? Qty1
        {
            get { return _qty1; }
            set { _qty1 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_QTY_2" field.
        /// </summary>
        public Int32? Qty2
        {
            get { return _qty2; }
            set { _qty2 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_QTY_3" field.
        /// </summary>
        public Int32? Qty3
        {
            get { return _qty3; }
            set { _qty3 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_QTY_4" field.
        /// </summary>
        public Int32? Qty4
        {
            get { return _qty4; }
            set { _qty4 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_QTY_5" field.
        /// </summary>
        public Int32? Qty5
        {
            get { return _qty5; }
            set { _qty5 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_FEE" field.
        /// </summary>
        public Decimal Fee
        {
            get { return _fee; }
            set { _fee = value; }
        }

        /// <summary>
        ///     the value of the "MEP_FEE_BC" field.
        /// </summary>
        public Decimal FeeBc
        {
            get { return _feeBc; }
            set { _feeBc = value; }
        }

        /// <summary>
        ///     the value of the "MEP_FEE_BC2" field.
        /// </summary>
        public Decimal FeeBc2
        {
            get { return _feeBc2; }
            set { _feeBc2 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_CURRENCY" field.
        /// </summary>
        public String Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        /// <summary>
        ///     the value of the "MEP_FEE_EXTRA" field.
        /// </summary>
        public Decimal FeeExtra
        {
            get { return _feeExtra; }
            set { _feeExtra = value; }
        }

        /// <summary>
        ///     the value of the "MEP_FEE_EXTRA_BC" field.
        /// </summary>
        public Decimal FeeExtraBc
        {
            get { return _feeExtraBc; }
            set { _feeExtraBc = value; }
        }

        /// <summary>
        ///     the value of the "MEP_FEE_EXTRA_BC2" field.
        /// </summary>
        public Decimal FeeExtraBc2
        {
            get { return _feeExtraBc2; }
            set { _feeExtraBc2 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_PAY_METHOD" field.
        /// </summary>
        public String PayMethod
        {
            get { return _payMethod; }
            set { _payMethod = value; }
        }

        /// <summary>
        ///     the value of the "MEP_PAY_STATUS" field.
        /// </summary>
        public String PayStatus
        {
            get { return _payStatus; }
            set { _payStatus = value; }
        }

        /// <summary>
        ///     the value of the "MEP_PO_REF" field.
        /// </summary>
        public String PoRef
        {
            get { return _poRef; }
            set { _poRef = value; }
        }

        /// <summary>
        ///     the value of the "MEP_CCARD_TYPE" field.
        /// </summary>
        public String CcardType
        {
            get { return _ccardType; }
            set { _ccardType = value; }
        }

        /// <summary>
        ///     the value of the "MEP_NAME_ON_CARD" field.
        /// </summary>
        public String NameOnCard
        {
            get { return _nameOnCard; }
            set { _nameOnCard = value; }
        }

        /// <summary>
        ///     the value of the "MEP_CCARD_NUMBER" field.
        /// </summary>
        public String CcardNumber
        {
            get { return _ccardNumber; }
            set { _ccardNumber = value; }
        }

        /// <summary>
        ///     the value of the "MEP_CCARD_START" field.
        /// </summary>
        public String CcardStart
        {
            get { return _ccardStart; }
            set { _ccardStart = value; }
        }

        /// <summary>
        ///     the value of the "MEP_CCARD_EXPY" field.
        /// </summary>
        public String CcardExpy
        {
            get { return _ccardExpy; }
            set { _ccardExpy = value; }
        }

        /// <summary>
        ///     the value of the "MEP_BANK_ACC_CODE" field.
        /// </summary>
        public String BankAccCode
        {
            get { return _bankAccCode; }
            set { _bankAccCode = value; }
        }

        /// <summary>
        ///     the value of the "MEP_SORT_CODE" field.
        /// </summary>
        public String SortCode
        {
            get { return _sortCode; }
            set { _sortCode = value; }
        }

        /// <summary>
        ///     the value of the "MEP_CCARD_ISSUE" field.
        /// </summary>
        public String CcardIssue
        {
            get { return _ccardIssue; }
            set { _ccardIssue = value; }
        }

        /// <summary>
        ///     the value of the "MEP_SECURITY" field.
        /// </summary>
        public String Security
        {
            get { return _security; }
            set { _security = value; }
        }

        /// <summary>
        ///     the value of the "MEP_CCARD_AUTHCODE" field.
        /// </summary>
        public String CcardAuthcode
        {
            get { return _ccardAuthcode; }
            set { _ccardAuthcode = value; }
        }

        /// <summary>
        ///     the value of the "MEP_DOCS_METHOD" field.
        /// </summary>
        public String DocsMethod
        {
            get { return _docsMethod; }
            set { _docsMethod = value; }
        }

        /// <summary>
        ///     the value of the "MEP_INV_ORG_ID" field.
        /// </summary>
        public String InvOrgId
        {
            get { return _invOrgId; }
            set { _invOrgId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_INV_PROLE_ID" field.
        /// </summary>
        public String InvProleId
        {
            get { return _invProleId; }
            set { _invProleId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_INV_ADD_ID" field.
        /// </summary>
        public String InvAddId
        {
            get { return _invAddId; }
            set { _invAddId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_PRICE_LIST_ID" field.
        /// </summary>
        public String PriceListId
        {
            get { return _priceListId; }
            set { _priceListId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_CURRENT" field.
        /// </summary>
        public Byte? Current
        {
            get { return _current; }
            set { _current = value; }
        }

        /// <summary>
        ///     the value of the "MEP_PM_ID" field.
        /// </summary>
        public String PmId
        {
            get { return _pmId; }
            set { _pmId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_SUB_ONLY" field.
        /// </summary>
        public Int32? SubOnly
        {
            get { return _subOnly; }
            set { _subOnly = value; }
        }

        /// <summary>
        ///     the value of the "MEP_RENEWED_DATE" field.
        /// </summary>
        public DateTime? RenewedDate
        {
            get { return _renewedDate; }
            set { _renewedDate = value; }
        }

        /// <summary>
        ///     the value of the "MEP_LAPSED_DATE" field.
        /// </summary>
        public DateTime? LapsedDate
        {
            get { return _lapsedDate; }
            set { _lapsedDate = value; }
        }

        /// <summary>
        ///     the value of the "MEP_RENEW_DATE_0" field.
        /// </summary>
        public DateTime? RenewDate0
        {
            get { return _renewDate0; }
            set { _renewDate0 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "MEP_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_RENEWAL_DATE" field.
        /// </summary>
        public DateTime? RenewalDate
        {
            get { return _renewalDate; }
            set { _renewalDate = value; }
        }

        /// <summary>
        ///     the value of the "MEP_RENEW_START" field.
        /// </summary>
        public DateTime? RenewStart
        {
            get { return _renewStart; }
            set { _renewStart = value; }
        }

        /// <summary>
        ///     the value of the "MEP_CREATE_BAT_ID" field.
        /// </summary>
        public String CreateBatId
        {
            get { return _createBatId; }
            set { _createBatId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_RENEW_BAT_ID" field.
        /// </summary>
        public String RenewBatId
        {
            get { return _renewBatId; }
            set { _renewBatId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_OLD_MEP_ID" field.
        /// </summary>
        public String OldMepId
        {
            get { return _oldMepId; }
            set { _oldMepId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_INC_HIERARCHY" field.
        /// </summary>
        public Int32? IncHierarchy
        {
            get { return _incHierarchy; }
            set { _incHierarchy = value; }
        }

        /// <summary>
        ///     the value of the "MEP_NO_COPIES_1" field.
        /// </summary>
        public Int32? NoCopies1
        {
            get { return _noCopies1; }
            set { _noCopies1 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_NO_COPIES_2" field.
        /// </summary>
        public Int32? NoCopies2
        {
            get { return _noCopies2; }
            set { _noCopies2 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_NO_COPIES_3" field.
        /// </summary>
        public Int32? NoCopies3
        {
            get { return _noCopies3; }
            set { _noCopies3 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_CUST_ORDER_NO" field.
        /// </summary>
        public String CustOrderNo
        {
            get { return _custOrderNo; }
            set { _custOrderNo = value; }
        }

        /// <summary>
        ///     the value of the "MEP_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_CANCEL_REASON" field.
        /// </summary>
        public String CancelReason
        {
            get { return _cancelReason; }
            set { _cancelReason = value; }
        }

        /// <summary>
        ///     the value of the "MEP_MEMB_RATE" field.
        /// </summary>
        public Byte? MembRate
        {
            get { return _membRate; }
            set { _membRate = value; }
        }

        /// <summary>
        ///     the value of the "MEP_MEM_TYPE" field.
        /// </summary>
        public String MemType
        {
            get { return _memType; }
            set { _memType = value; }
        }

        /// <summary>
        ///     the value of the "MEP_FOR_ATTN_OF" field.
        /// </summary>
        public String ForAttnOf
        {
            get { return _forAttnOf; }
            set { _forAttnOf = value; }
        }

        /// <summary>
        ///     the value of the "MEP_ORG_CUST_AC" field.
        /// </summary>
        public String OrgCustAc
        {
            get { return _orgCustAc; }
            set { _orgCustAc = value; }
        }

        /// <summary>
        ///     the value of the "MEP_REMIND1_BAT_ID" field.
        /// </summary>
        public String Remind1BatId
        {
            get { return _remind1BatId; }
            set { _remind1BatId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_REMIND2_BAT_ID" field.
        /// </summary>
        public String Remind2BatId
        {
            get { return _remind2BatId; }
            set { _remind2BatId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_REMIND3_BAT_ID" field.
        /// </summary>
        public String Remind3BatId
        {
            get { return _remind3BatId; }
            set { _remind3BatId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_REMIND4_BAT_ID" field.
        /// </summary>
        public String Remind4BatId
        {
            get { return _remind4BatId; }
            set { _remind4BatId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_REMIND1_DATE" field.
        /// </summary>
        public DateTime? Remind1Date
        {
            get { return _remind1Date; }
            set { _remind1Date = value; }
        }

        /// <summary>
        ///     the value of the "MEP_REMIND2_DATE" field.
        /// </summary>
        public DateTime? Remind2Date
        {
            get { return _remind2Date; }
            set { _remind2Date = value; }
        }

        /// <summary>
        ///     the value of the "MEP_REMIND3_DATE" field.
        /// </summary>
        public DateTime? Remind3Date
        {
            get { return _remind3Date; }
            set { _remind3Date = value; }
        }

        /// <summary>
        ///     the value of the "MEP_REMIND4_DATE" field.
        /// </summary>
        public DateTime? Remind4Date
        {
            get { return _remind4Date; }
            set { _remind4Date = value; }
        }

        /// <summary>
        ///     the value of the "MEP_PREV_STATUS" field.
        /// </summary>
        public String PrevStatus
        {
            get { return _prevStatus; }
            set { _prevStatus = value; }
        }

        /// <summary>
        ///     the value of the "MEP_CONT_PAYMENT" field.
        /// </summary>
        public Byte? ContPayment
        {
            get { return _contPayment; }
            set { _contPayment = value; }
        }

        /// <summary>
        ///     the value of the "MEP_NET_FEE" field.
        /// </summary>
        public Decimal NetFee
        {
            get { return _netFee; }
            set { _netFee = value; }
        }

        /// <summary>
        ///     the value of the "MEP_NET_FEE_BC" field.
        /// </summary>
        public Decimal NetFeeBc
        {
            get { return _netFeeBc; }
            set { _netFeeBc = value; }
        }

        /// <summary>
        ///     the value of the "MEP_NET_FEE_BC2" field.
        /// </summary>
        public Decimal NetFeeBc2
        {
            get { return _netFeeBc2; }
            set { _netFeeBc2 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_VAT_AMT" field.
        /// </summary>
        public Decimal VatAmt
        {
            get { return _vatAmt; }
            set { _vatAmt = value; }
        }

        /// <summary>
        ///     the value of the "MEP_VAT_AMT_BC" field.
        /// </summary>
        public Decimal VatAmtBc
        {
            get { return _vatAmtBc; }
            set { _vatAmtBc = value; }
        }

        /// <summary>
        ///     the value of the "MEP_VAT_AMT_BC2" field.
        /// </summary>
        public Decimal VatAmtBc2
        {
            get { return _vatAmtBc2; }
            set { _vatAmtBc2 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "MEP_CURRENT_DATE" field.
        /// </summary>
        public DateTime? CurrentDate
        {
            get { return _currentDate; }
            set { _currentDate = value; }
        }

        /// <summary>
        ///     the value of the "MEP_LAPSE_DATE" field.
        /// </summary>
        public DateTime? LapseDate
        {
            get { return _lapseDate; }
            set { _lapseDate = value; }
        }

        /// <summary>
        ///     the value of the "MEP_BATCH_INVOICE" field.
        /// </summary>
        public Byte? BatchInvoice
        {
            get { return _batchInvoice; }
            set { _batchInvoice = value; }
        }

        /// <summary>
        ///     the value of the "MEP_BASKET_FL" field.
        /// </summary>
        public Byte BasketFl
        {
            get { return _basketFl; }
            set { _basketFl = value; }
        }

        /// <summary>
        ///     the value of the "MEP_INDEM_INSUR_DATE" field.
        /// </summary>
        public DateTime? IndemInsurDate
        {
            get { return _indemInsurDate; }
            set { _indemInsurDate = value; }
        }

        /// <summary>
        ///     the value of the "MEP_EXP_BAT_ID" field.
        /// </summary>
        public String ExpBatId
        {
            get { return _expBatId; }
            set { _expBatId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_ROLLBACK_DATE" field.
        /// </summary>
        public DateTime? RollbackDate
        {
            get { return _rollbackDate; }
            set { _rollbackDate = value; }
        }

        /// <summary>
        ///     the value of the "MEP_STATUS_INT" field.
        /// </summary>
        public Int32 StatusInt
        {
            get { return _statusInt; }
            set { _statusInt = value; }
        }

        /// <summary>
        ///     the value of the "MEP_SHORT_DATED" field.
        /// </summary>
        public Int32? ShortDated
        {
            get { return _shortDated; }
            set { _shortDated = value; }
        }

        /// <summary>
        ///     the value of the "MEP_CART_ID" field.
        /// </summary>
        public Int32? CartId
        {
            get { return _cartId; }
            set { _cartId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_PCLN_ID" field.
        /// </summary>
        public Int32? PclnId
        {
            get { return _pclnId; }
            set { _pclnId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_CURR_RATE_BC" field.
        /// </summary>
        public Decimal? CurrRateBc
        {
            get { return _currRateBc; }
            set { _currRateBc = value; }
        }

        /// <summary>
        ///     the value of the "MEP_CURR_RATE_BC2" field.
        /// </summary>
        public Decimal? CurrRateBc2
        {
            get { return _currRateBc2; }
            set { _currRateBc2 = value; }
        }

        /// <summary>
        ///     the value of the "MEP_APP_METHOD" field.
        /// </summary>
        public String AppMethod
        {
            get { return _appMethod; }
            set { _appMethod = value; }
        }

        /// <summary>
        ///     the value of the "MEP_OPP_ID" field.
        /// </summary>
        public String OppId
        {
            get { return _oppId; }
            set { _oppId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_DO_NOT_INVOIC" field.
        /// </summary>
        public Byte? DoNotInvoic
        {
            get { return _doNotInvoic; }
            set { _doNotInvoic = value; }
        }

        /// <summary>
        ///     the value of the "MEP_PO_EXPIRATION_DATE" field.
        /// </summary>
        public DateTime? PoExpirationDate
        {
            get { return _poExpirationDate; }
            set { _poExpirationDate = value; }
        }

        /// <summary>
        ///     the value of the "MEP_ACC_ID" field.
        /// </summary>
        public String AccId
        {
            get { return _accId; }
            set { _accId = value; }
        }

        /// <summary>
        ///     the value of the "MEP_MEMBERSHIP_NAME" field.
        /// </summary>
        public String MembershipName
        {
            get { return _membershipName; }
            set { _membershipName = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="MemberPeriodRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="MemberPeriodRecord" /> object instance.
        /// </returns>
        public MemberPeriodRecord Clone()
        {
            MemberPeriodRecord record = new MemberPeriodRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.RcvFrom = this.RcvFrom;
            record.RcvDate = this.RcvDate;
            record.MemId = this.MemId;
            record.ProdId = this.ProdId;
            record.MemGrade = this.MemGrade;
            record.Year = this.Year;
            record.Start = this.Start;
            record.End = this.End;
            record.RenewDate1 = this.RenewDate1;
            record.RenewDate2 = this.RenewDate2;
            record.RenewDate3 = this.RenewDate3;
            record.Qty1 = this.Qty1;
            record.Qty2 = this.Qty2;
            record.Qty3 = this.Qty3;
            record.Qty4 = this.Qty4;
            record.Qty5 = this.Qty5;
            record.Fee = this.Fee;
            record.FeeBc = this.FeeBc;
            record.FeeBc2 = this.FeeBc2;
            record.Currency = this.Currency;
            record.FeeExtra = this.FeeExtra;
            record.FeeExtraBc = this.FeeExtraBc;
            record.FeeExtraBc2 = this.FeeExtraBc2;
            record.PayMethod = this.PayMethod;
            record.PayStatus = this.PayStatus;
            record.PoRef = this.PoRef;
            record.CcardType = this.CcardType;
            record.NameOnCard = this.NameOnCard;
            record.CcardNumber = this.CcardNumber;
            record.CcardStart = this.CcardStart;
            record.CcardExpy = this.CcardExpy;
            record.BankAccCode = this.BankAccCode;
            record.SortCode = this.SortCode;
            record.CcardIssue = this.CcardIssue;
            record.Security = this.Security;
            record.CcardAuthcode = this.CcardAuthcode;
            record.DocsMethod = this.DocsMethod;
            record.InvOrgId = this.InvOrgId;
            record.InvProleId = this.InvProleId;
            record.InvAddId = this.InvAddId;
            record.PriceListId = this.PriceListId;
            record.Current = this.Current;
            record.PmId = this.PmId;
            record.SubOnly = this.SubOnly;
            record.RenewedDate = this.RenewedDate;
            record.LapsedDate = this.LapsedDate;
            record.RenewDate0 = this.RenewDate0;
            record.Status = this.Status;
            record.SelcoSpId = this.SelcoSpId;
            record.RenewalDate = this.RenewalDate;
            record.RenewStart = this.RenewStart;
            record.CreateBatId = this.CreateBatId;
            record.RenewBatId = this.RenewBatId;
            record.OldMepId = this.OldMepId;
            record.IncHierarchy = this.IncHierarchy;
            record.NoCopies1 = this.NoCopies1;
            record.NoCopies2 = this.NoCopies2;
            record.NoCopies3 = this.NoCopies3;
            record.CustOrderNo = this.CustOrderNo;
            record.Userchar1 = this.Userchar1;
            record.CancelReason = this.CancelReason;
            record.MembRate = this.MembRate;
            record.MemType = this.MemType;
            record.ForAttnOf = this.ForAttnOf;
            record.OrgCustAc = this.OrgCustAc;
            record.Remind1BatId = this.Remind1BatId;
            record.Remind2BatId = this.Remind2BatId;
            record.Remind3BatId = this.Remind3BatId;
            record.Remind4BatId = this.Remind4BatId;
            record.Remind1Date = this.Remind1Date;
            record.Remind2Date = this.Remind2Date;
            record.Remind3Date = this.Remind3Date;
            record.Remind4Date = this.Remind4Date;
            record.PrevStatus = this.PrevStatus;
            record.ContPayment = this.ContPayment;
            record.NetFee = this.NetFee;
            record.NetFeeBc = this.NetFeeBc;
            record.NetFeeBc2 = this.NetFeeBc2;
            record.VatAmt = this.VatAmt;
            record.VatAmtBc = this.VatAmtBc;
            record.VatAmtBc2 = this.VatAmtBc2;
            record.Notes = this.Notes;
            record.CurrentDate = this.CurrentDate;
            record.LapseDate = this.LapseDate;
            record.BatchInvoice = this.BatchInvoice;
            record.BasketFl = this.BasketFl;
            record.IndemInsurDate = this.IndemInsurDate;
            record.ExpBatId = this.ExpBatId;
            record.RollbackDate = this.RollbackDate;
            record.StatusInt = this.StatusInt;
            record.ShortDated = this.ShortDated;
            record.CartId = this.CartId;
            record.PclnId = this.PclnId;
            record.CurrRateBc = this.CurrRateBc;
            record.CurrRateBc2 = this.CurrRateBc2;
            record.AppMethod = this.AppMethod;
            record.OppId = this.OppId;
            record.DoNotInvoic = this.DoNotInvoic;
            record.PoExpirationDate = this.PoExpirationDate;
            record.AccId = this.AccId;
            record.MembershipName = this.MembershipName;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="MemberPeriodRecord" /> instance is equal to another <see cref="MemberPeriodRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="MemberPeriodRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(MemberPeriodRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.MemId.TrimOrNullify() == that.MemId.TrimOrNullify());
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.MemGrade.TrimOrNullify() == that.MemGrade.TrimOrNullify());
            result = result && (this.Year.TrimOrNullify() == that.Year.TrimOrNullify());
            result = result && (this.Start == that.Start);
            result = result && (this.End == that.End);
            result = result && (this.RenewDate1 == that.RenewDate1);
            result = result && (this.RenewDate2 == that.RenewDate2);
            result = result && (this.RenewDate3 == that.RenewDate3);
            result = result && (this.Qty1 == that.Qty1);
            result = result && (this.Qty2 == that.Qty2);
            result = result && (this.Qty3 == that.Qty3);
            result = result && (this.Qty4 == that.Qty4);
            result = result && (this.Qty5 == that.Qty5);
            result = result && (this.Fee == that.Fee);
            result = result && (this.FeeBc == that.FeeBc);
            result = result && (this.FeeBc2 == that.FeeBc2);
            result = result && (this.Currency.TrimOrNullify() == that.Currency.TrimOrNullify());
            result = result && (this.FeeExtra == that.FeeExtra);
            result = result && (this.FeeExtraBc == that.FeeExtraBc);
            result = result && (this.FeeExtraBc2 == that.FeeExtraBc2);
            result = result && (this.PayMethod.TrimOrNullify() == that.PayMethod.TrimOrNullify());
            result = result && (this.PayStatus.TrimOrNullify() == that.PayStatus.TrimOrNullify());
            result = result && (this.PoRef.TrimOrNullify() == that.PoRef.TrimOrNullify());
            result = result && (this.CcardType.TrimOrNullify() == that.CcardType.TrimOrNullify());
            result = result && (this.NameOnCard.TrimOrNullify() == that.NameOnCard.TrimOrNullify());
            result = result && (this.CcardNumber.TrimOrNullify() == that.CcardNumber.TrimOrNullify());
            result = result && (this.CcardStart.TrimOrNullify() == that.CcardStart.TrimOrNullify());
            result = result && (this.CcardExpy.TrimOrNullify() == that.CcardExpy.TrimOrNullify());
            result = result && (this.BankAccCode.TrimOrNullify() == that.BankAccCode.TrimOrNullify());
            result = result && (this.SortCode.TrimOrNullify() == that.SortCode.TrimOrNullify());
            result = result && (this.CcardIssue.TrimOrNullify() == that.CcardIssue.TrimOrNullify());
            result = result && (this.Security.TrimOrNullify() == that.Security.TrimOrNullify());
            result = result && (this.CcardAuthcode.TrimOrNullify() == that.CcardAuthcode.TrimOrNullify());
            result = result && (this.DocsMethod.TrimOrNullify() == that.DocsMethod.TrimOrNullify());
            result = result && (this.InvOrgId.TrimOrNullify() == that.InvOrgId.TrimOrNullify());
            result = result && (this.InvProleId.TrimOrNullify() == that.InvProleId.TrimOrNullify());
            result = result && (this.InvAddId.TrimOrNullify() == that.InvAddId.TrimOrNullify());
            result = result && (this.PriceListId.TrimOrNullify() == that.PriceListId.TrimOrNullify());
            result = result && (this.Current == that.Current);
            result = result && (this.PmId.TrimOrNullify() == that.PmId.TrimOrNullify());
            result = result && (this.SubOnly == that.SubOnly);
            result = result && (this.RenewedDate == that.RenewedDate);
            result = result && (this.LapsedDate == that.LapsedDate);
            result = result && (this.RenewDate0 == that.RenewDate0);
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.RenewalDate == that.RenewalDate);
            result = result && (this.RenewStart == that.RenewStart);
            result = result && (this.CreateBatId.TrimOrNullify() == that.CreateBatId.TrimOrNullify());
            result = result && (this.RenewBatId.TrimOrNullify() == that.RenewBatId.TrimOrNullify());
            result = result && (this.OldMepId.TrimOrNullify() == that.OldMepId.TrimOrNullify());
            result = result && (this.IncHierarchy == that.IncHierarchy);
            result = result && (this.NoCopies1 == that.NoCopies1);
            result = result && (this.NoCopies2 == that.NoCopies2);
            result = result && (this.NoCopies3 == that.NoCopies3);
            result = result && (this.CustOrderNo.TrimOrNullify() == that.CustOrderNo.TrimOrNullify());
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.CancelReason.TrimOrNullify() == that.CancelReason.TrimOrNullify());
            result = result && (this.MembRate == that.MembRate);
            result = result && (this.MemType.TrimOrNullify() == that.MemType.TrimOrNullify());
            result = result && (this.ForAttnOf.TrimOrNullify() == that.ForAttnOf.TrimOrNullify());
            result = result && (this.OrgCustAc.TrimOrNullify() == that.OrgCustAc.TrimOrNullify());
            result = result && (this.Remind1BatId.TrimOrNullify() == that.Remind1BatId.TrimOrNullify());
            result = result && (this.Remind2BatId.TrimOrNullify() == that.Remind2BatId.TrimOrNullify());
            result = result && (this.Remind3BatId.TrimOrNullify() == that.Remind3BatId.TrimOrNullify());
            result = result && (this.Remind4BatId.TrimOrNullify() == that.Remind4BatId.TrimOrNullify());
            result = result && (this.Remind1Date == that.Remind1Date);
            result = result && (this.Remind2Date == that.Remind2Date);
            result = result && (this.Remind3Date == that.Remind3Date);
            result = result && (this.Remind4Date == that.Remind4Date);
            result = result && (this.PrevStatus.TrimOrNullify() == that.PrevStatus.TrimOrNullify());
            result = result && (this.ContPayment == that.ContPayment);
            result = result && (this.NetFee == that.NetFee);
            result = result && (this.NetFeeBc == that.NetFeeBc);
            result = result && (this.NetFeeBc2 == that.NetFeeBc2);
            result = result && (this.VatAmt == that.VatAmt);
            result = result && (this.VatAmtBc == that.VatAmtBc);
            result = result && (this.VatAmtBc2 == that.VatAmtBc2);
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.CurrentDate == that.CurrentDate);
            result = result && (this.LapseDate == that.LapseDate);
            result = result && (this.BatchInvoice == that.BatchInvoice);
            result = result && (this.BasketFl == that.BasketFl);
            result = result && (this.IndemInsurDate == that.IndemInsurDate);
            result = result && (this.ExpBatId.TrimOrNullify() == that.ExpBatId.TrimOrNullify());
            result = result && (this.RollbackDate == that.RollbackDate);
            result = result && (this.StatusInt == that.StatusInt);
            result = result && (this.ShortDated == that.ShortDated);
            result = result && (this.CartId == that.CartId);
            result = result && (this.PclnId == that.PclnId);
            result = result && (this.CurrRateBc == that.CurrRateBc);
            result = result && (this.CurrRateBc2 == that.CurrRateBc2);
            result = result && (this.AppMethod.TrimOrNullify() == that.AppMethod.TrimOrNullify());
            result = result && (this.OppId.TrimOrNullify() == that.OppId.TrimOrNullify());
            result = result && (this.DoNotInvoic == that.DoNotInvoic);
            result = result && (this.PoExpirationDate == that.PoExpirationDate);
            result = result && (this.AccId.TrimOrNullify() == that.AccId.TrimOrNullify());
            result = result && (this.MembershipName.TrimOrNullify() == that.MembershipName.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
