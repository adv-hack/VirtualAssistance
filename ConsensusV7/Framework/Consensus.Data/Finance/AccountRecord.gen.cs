using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Represents the "Account" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class AccountRecord : Record<String>, Cloneable<AccountRecord>, IEquatable<AccountRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ACC_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "ACC_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "ACC_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "ACC_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "ACC_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "ACC_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "ACC_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "ACC_SYSTEM" field.
        /// </summary>
        private String _system;

        /// <summary>
        ///     the value of the "ACC_SYSTEM_REF" field.
        /// </summary>
        private String _systemRef;

        /// <summary>
        ///     the value of the "ACC_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "ACC_PRINCIPAL" field.
        /// </summary>
        private Byte? _principal;

        /// <summary>
        ///     the value of the "ACC_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "ACC_CONTACT_ID" field.
        /// </summary>
        private String _contactId;

        /// <summary>
        ///     the value of the "ACC_ADD_ID" field.
        /// </summary>
        private String _addId;

        /// <summary>
        ///     the value of the "ACC_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "ACC_NO_ADD_CHANGE" field.
        /// </summary>
        private Byte? _noAddChange;

        /// <summary>
        ///     the value of the "ACC_PAYMENT_DAYS" field.
        /// </summary>
        private Int32? _paymentDays;

        /// <summary>
        ///     the value of the "ACC_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "ACC_PAYMENT_TYPE" field.
        /// </summary>
        private Byte? _paymentType;

        /// <summary>
        ///     the value of the "ACC_PAY_TERMS_1" field.
        /// </summary>
        private String _payTerms1;

        /// <summary>
        ///     the value of the "ACC_PAY_TERMS_2" field.
        /// </summary>
        private String _payTerms2;

        /// <summary>
        ///     the value of the "ACC_PAY_TERMS_3" field.
        /// </summary>
        private String _payTerms3;

        /// <summary>
        ///     the value of the "ACC_PAY_TERMS_4" field.
        /// </summary>
        private String _payTerms4;

        /// <summary>
        ///     the value of the "ACC_CREDIT" field.
        /// </summary>
        private Decimal _credit;

        /// <summary>
        ///     the value of the "ACC_SPECIAL_TERMS" field.
        /// </summary>
        private String _specialTerms;

        /// <summary>
        ///     the value of the "ACC_VATCD" field.
        /// </summary>
        private String _vatcd;

        /// <summary>
        ///     the value of the "ACC_INV_FOR_ATTN_OF" field.
        /// </summary>
        private String _invForAttnOf;

        /// <summary>
        ///     the value of the "ACC_INVOICE_RULE" field.
        /// </summary>
        private Byte _invoiceRule;

        /// <summary>
        ///     the value of the "ACC_INVOICE_RULE_OFFSET" field.
        /// </summary>
        private Int16 _invoiceRuleOffset;

        /// <summary>
        ///     the value of the "ACC_INVOICE_CONSOLIDATE" field.
        /// </summary>
        private Byte _invoiceConsolidate;

        /// <summary>
        ///     the value of the "ACC_INVOICE_WHEN_STATUS" field.
        /// </summary>
        private String _invoiceWhenStatus;

        /// <summary>
        ///     the value of the "ACC_INVOICE_FORMAT" field.
        /// </summary>
        private Byte _invoiceFormat;

        /// <summary>
        ///     the value of the "ACC_INVOICE_MUST_USE_RULE" field.
        /// </summary>
        private Byte _invoiceMustUseRule;

        /// <summary>
        ///     the value of the "ACC_INVOICE_FORMAT_0_TEXT" field.
        /// </summary>
        private String _invoiceFormat0Text;

        /// <summary>
        ///     the value of the "ACC_INVOICE_FORMAT_1_TEXT" field.
        /// </summary>
        private String _invoiceFormat1Text;

        /// <summary>
        ///     the value of the "ACC_INVOICE_OFFSET_TYPE" field.
        /// </summary>
        private String _invoiceOffsetType;

        /// <summary>
        ///     the value of the "ACC_INV_ADD_TO" field.
        /// </summary>
        private Byte? _invAddTo;

        /// <summary>
        ///     the value of the "ACC_NAT_ACCOUNT" field.
        /// </summary>
        private Byte? _natAccount;

        /// <summary>
        ///     the value of the "ACC_BANK_NAME" field.
        /// </summary>
        private String _bankName;

        /// <summary>
        ///     the value of the "ACC_BANK_SORT_CODE" field.
        /// </summary>
        private String _bankSortCode;

        /// <summary>
        ///     the value of the "ACC_BANK_NO" field.
        /// </summary>
        private String _bankNo;

        /// <summary>
        ///     the value of the "ACC_BANK_ADD_ID" field.
        /// </summary>
        private String _bankAddId;

        /// <summary>
        ///     the value of the "ACC_PAYMENT_METHD" field.
        /// </summary>
        private String _paymentMethd;

        /// <summary>
        ///     the value of the "ACC_DOC_TYPE" field.
        /// </summary>
        private String _docType;

        /// <summary>
        ///     the value of the "ACC_COUT_OFF_DAYS" field.
        /// </summary>
        private Int32? _coutOffDays;

        /// <summary>
        ///     the value of the "ACC_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "ACC_TITLE" field.
        /// </summary>
        private String _title;

        /// <summary>
        ///     the value of the "ACC_STATUS_DATE" field.
        /// </summary>
        private DateTime? _statusDate;

        /// <summary>
        ///     the value of the "ACC_BAT_ID" field.
        /// </summary>
        private String _batId;

        /// <summary>
        ///     the value of the "ACC_REQ_CREDIT" field.
        /// </summary>
        private Decimal? _reqCredit;

        /// <summary>
        ///     the value of the "ACC_DOCS_METHOD" field.
        /// </summary>
        private String _docsMethod;

        /// <summary>
        ///     the value of the "ACC_DO_NOT_CHASE" field.
        /// </summary>
        private Byte _doNotChase;

        /// <summary>
        ///     the value of the "ACC_INV_PACK_ID" field.
        /// </summary>
        private String _invPackId;

        /// <summary>
        ///     the value of the "ACC_REQ_PAYMENT_TYPE" field.
        /// </summary>
        private Byte _reqPaymentType;

        /// <summary>
        ///     the value of the "ACC_REQ_PAYMENT_DAYS" field.
        /// </summary>
        private Int32 _reqPaymentDays;

        /// <summary>
        ///     the value of the "ACC_DEFAULT_INV_STATUS" field.
        /// </summary>
        private Byte? _defaultInvStatus;

        /// <summary>
        ///     the value of the "ACC_CURRENCY_TYPE" field.
        /// </summary>
        private String _currencyType;

        /// <summary>
        ///     the value of the "ACC_VAT_REG_NUM" field.
        /// </summary>
        private String _vatRegNum;

        /// <summary>
        ///     the value of the "ACC_MEM_PAYMENT_DAYS" field.
        /// </summary>
        private Int32? _memPaymentDays;

        /// <summary>
        ///     the value of the "ACC_PO_REQ" field.
        /// </summary>
        private Byte? _poReq;

        /// <summary>
        ///     the value of the "ACC_RUN_DATE" field.
        /// </summary>
        private DateTime? _runDate;

        /// <summary>
        ///     the value of the "ACC_PSH_ID" field.
        /// </summary>
        private Int32? _pshId;

        /// <summary>
        ///     the value of the "ACC_DEFAULT" field.
        /// </summary>
        private Byte? _default;

        /// <summary>
        ///     the value of the "ACC_RULE_TYPE" field.
        /// </summary>
        private Byte? _ruleType;

        /// <summary>
        ///     the value of the "ACC_NAT_ACCOUNT_DATE" field.
        /// </summary>
        private DateTime? _natAccountDate;

        /// <summary>
        ///     the value of the "ACC_COURSE_LEN" field.
        /// </summary>
        private Double? _courseLen;

        /// <summary>
        ///     the value of the "ACC_RENEW_DAYS" field.
        /// </summary>
        private Int32? _renewDays;

        /// <summary>
        ///     the value of the "ACC_FIXED_RENEWAL" field.
        /// </summary>
        private Byte? _fixedRenewal;

        /// <summary>
        ///     the value of the "ACC_RENEWAL_MONTH" field.
        /// </summary>
        private String _renewalMonth;

        /// <summary>
        ///     the value of the "ACC_RENEWAL_DAY" field.
        /// </summary>
        private String _renewalDay;

        /// <summary>
        ///     the value of the "ACC_RENEW" field.
        /// </summary>
        private Byte _renew;

        /// <summary>
        ///     the value of the "ACC_EXCL_DAY" field.
        /// </summary>
        private String _exclDay;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ACC_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "ACC_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "ACC_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "ACC_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "ACC_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "ACC_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "ACC_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "ACC_SYSTEM" field.
        /// </summary>
        public String System
        {
            get { return _system; }
            set { _system = value; }
        }

        /// <summary>
        ///     the value of the "ACC_SYSTEM_REF" field.
        /// </summary>
        public String SystemRef
        {
            get { return _systemRef; }
            set { _systemRef = value; }
        }

        /// <summary>
        ///     the value of the "ACC_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "ACC_PRINCIPAL" field.
        /// </summary>
        public Byte? Principal
        {
            get { return _principal; }
            set { _principal = value; }
        }

        /// <summary>
        ///     the value of the "ACC_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "ACC_CONTACT_ID" field.
        /// </summary>
        public String ContactId
        {
            get { return _contactId; }
            set { _contactId = value; }
        }

        /// <summary>
        ///     the value of the "ACC_ADD_ID" field.
        /// </summary>
        public String AddId
        {
            get { return _addId; }
            set { _addId = value; }
        }

        /// <summary>
        ///     the value of the "ACC_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "ACC_NO_ADD_CHANGE" field.
        /// </summary>
        public Byte? NoAddChange
        {
            get { return _noAddChange; }
            set { _noAddChange = value; }
        }

        /// <summary>
        ///     the value of the "ACC_PAYMENT_DAYS" field.
        /// </summary>
        public Int32? PaymentDays
        {
            get { return _paymentDays; }
            set { _paymentDays = value; }
        }

        /// <summary>
        ///     the value of the "ACC_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "ACC_PAYMENT_TYPE" field.
        /// </summary>
        public Byte? PaymentType
        {
            get { return _paymentType; }
            set { _paymentType = value; }
        }

        /// <summary>
        ///     the value of the "ACC_PAY_TERMS_1" field.
        /// </summary>
        public String PayTerms1
        {
            get { return _payTerms1; }
            set { _payTerms1 = value; }
        }

        /// <summary>
        ///     the value of the "ACC_PAY_TERMS_2" field.
        /// </summary>
        public String PayTerms2
        {
            get { return _payTerms2; }
            set { _payTerms2 = value; }
        }

        /// <summary>
        ///     the value of the "ACC_PAY_TERMS_3" field.
        /// </summary>
        public String PayTerms3
        {
            get { return _payTerms3; }
            set { _payTerms3 = value; }
        }

        /// <summary>
        ///     the value of the "ACC_PAY_TERMS_4" field.
        /// </summary>
        public String PayTerms4
        {
            get { return _payTerms4; }
            set { _payTerms4 = value; }
        }

        /// <summary>
        ///     the value of the "ACC_CREDIT" field.
        /// </summary>
        public Decimal Credit
        {
            get { return _credit; }
            set { _credit = value; }
        }

        /// <summary>
        ///     the value of the "ACC_SPECIAL_TERMS" field.
        /// </summary>
        public String SpecialTerms
        {
            get { return _specialTerms; }
            set { _specialTerms = value; }
        }

        /// <summary>
        ///     the value of the "ACC_VATCD" field.
        /// </summary>
        public String Vatcd
        {
            get { return _vatcd; }
            set { _vatcd = value; }
        }

        /// <summary>
        ///     the value of the "ACC_INV_FOR_ATTN_OF" field.
        /// </summary>
        public String InvForAttnOf
        {
            get { return _invForAttnOf; }
            set { _invForAttnOf = value; }
        }

        /// <summary>
        ///     the value of the "ACC_INVOICE_RULE" field.
        /// </summary>
        public Byte InvoiceRule
        {
            get { return _invoiceRule; }
            set { _invoiceRule = value; }
        }

        /// <summary>
        ///     the value of the "ACC_INVOICE_RULE_OFFSET" field.
        /// </summary>
        public Int16 InvoiceRuleOffset
        {
            get { return _invoiceRuleOffset; }
            set { _invoiceRuleOffset = value; }
        }

        /// <summary>
        ///     the value of the "ACC_INVOICE_CONSOLIDATE" field.
        /// </summary>
        public Byte InvoiceConsolidate
        {
            get { return _invoiceConsolidate; }
            set { _invoiceConsolidate = value; }
        }

        /// <summary>
        ///     the value of the "ACC_INVOICE_WHEN_STATUS" field.
        /// </summary>
        public String InvoiceWhenStatus
        {
            get { return _invoiceWhenStatus; }
            set { _invoiceWhenStatus = value; }
        }

        /// <summary>
        ///     the value of the "ACC_INVOICE_FORMAT" field.
        /// </summary>
        public Byte InvoiceFormat
        {
            get { return _invoiceFormat; }
            set { _invoiceFormat = value; }
        }

        /// <summary>
        ///     the value of the "ACC_INVOICE_MUST_USE_RULE" field.
        /// </summary>
        public Byte InvoiceMustUseRule
        {
            get { return _invoiceMustUseRule; }
            set { _invoiceMustUseRule = value; }
        }

        /// <summary>
        ///     the value of the "ACC_INVOICE_FORMAT_0_TEXT" field.
        /// </summary>
        public String InvoiceFormat0Text
        {
            get { return _invoiceFormat0Text; }
            set { _invoiceFormat0Text = value; }
        }

        /// <summary>
        ///     the value of the "ACC_INVOICE_FORMAT_1_TEXT" field.
        /// </summary>
        public String InvoiceFormat1Text
        {
            get { return _invoiceFormat1Text; }
            set { _invoiceFormat1Text = value; }
        }

        /// <summary>
        ///     the value of the "ACC_INVOICE_OFFSET_TYPE" field.
        /// </summary>
        public String InvoiceOffsetType
        {
            get { return _invoiceOffsetType; }
            set { _invoiceOffsetType = value; }
        }

        /// <summary>
        ///     the value of the "ACC_INV_ADD_TO" field.
        /// </summary>
        public Byte? InvAddTo
        {
            get { return _invAddTo; }
            set { _invAddTo = value; }
        }

        /// <summary>
        ///     the value of the "ACC_NAT_ACCOUNT" field.
        /// </summary>
        public Byte? NatAccount
        {
            get { return _natAccount; }
            set { _natAccount = value; }
        }

        /// <summary>
        ///     the value of the "ACC_BANK_NAME" field.
        /// </summary>
        public String BankName
        {
            get { return _bankName; }
            set { _bankName = value; }
        }

        /// <summary>
        ///     the value of the "ACC_BANK_SORT_CODE" field.
        /// </summary>
        public String BankSortCode
        {
            get { return _bankSortCode; }
            set { _bankSortCode = value; }
        }

        /// <summary>
        ///     the value of the "ACC_BANK_NO" field.
        /// </summary>
        public String BankNo
        {
            get { return _bankNo; }
            set { _bankNo = value; }
        }

        /// <summary>
        ///     the value of the "ACC_BANK_ADD_ID" field.
        /// </summary>
        public String BankAddId
        {
            get { return _bankAddId; }
            set { _bankAddId = value; }
        }

        /// <summary>
        ///     the value of the "ACC_PAYMENT_METHD" field.
        /// </summary>
        public String PaymentMethd
        {
            get { return _paymentMethd; }
            set { _paymentMethd = value; }
        }

        /// <summary>
        ///     the value of the "ACC_DOC_TYPE" field.
        /// </summary>
        public String DocType
        {
            get { return _docType; }
            set { _docType = value; }
        }

        /// <summary>
        ///     the value of the "ACC_COUT_OFF_DAYS" field.
        /// </summary>
        public Int32? CoutOffDays
        {
            get { return _coutOffDays; }
            set { _coutOffDays = value; }
        }

        /// <summary>
        ///     the value of the "ACC_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "ACC_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        ///     the value of the "ACC_STATUS_DATE" field.
        /// </summary>
        public DateTime? StatusDate
        {
            get { return _statusDate; }
            set { _statusDate = value; }
        }

        /// <summary>
        ///     the value of the "ACC_BAT_ID" field.
        /// </summary>
        public String BatId
        {
            get { return _batId; }
            set { _batId = value; }
        }

        /// <summary>
        ///     the value of the "ACC_REQ_CREDIT" field.
        /// </summary>
        public Decimal? ReqCredit
        {
            get { return _reqCredit; }
            set { _reqCredit = value; }
        }

        /// <summary>
        ///     the value of the "ACC_DOCS_METHOD" field.
        /// </summary>
        public String DocsMethod
        {
            get { return _docsMethod; }
            set { _docsMethod = value; }
        }

        /// <summary>
        ///     the value of the "ACC_DO_NOT_CHASE" field.
        /// </summary>
        public Byte DoNotChase
        {
            get { return _doNotChase; }
            set { _doNotChase = value; }
        }

        /// <summary>
        ///     the value of the "ACC_INV_PACK_ID" field.
        /// </summary>
        public String InvPackId
        {
            get { return _invPackId; }
            set { _invPackId = value; }
        }

        /// <summary>
        ///     the value of the "ACC_REQ_PAYMENT_TYPE" field.
        /// </summary>
        public Byte ReqPaymentType
        {
            get { return _reqPaymentType; }
            set { _reqPaymentType = value; }
        }

        /// <summary>
        ///     the value of the "ACC_REQ_PAYMENT_DAYS" field.
        /// </summary>
        public Int32 ReqPaymentDays
        {
            get { return _reqPaymentDays; }
            set { _reqPaymentDays = value; }
        }

        /// <summary>
        ///     the value of the "ACC_DEFAULT_INV_STATUS" field.
        /// </summary>
        public Byte? DefaultInvStatus
        {
            get { return _defaultInvStatus; }
            set { _defaultInvStatus = value; }
        }

        /// <summary>
        ///     the value of the "ACC_CURRENCY_TYPE" field.
        /// </summary>
        public String CurrencyType
        {
            get { return _currencyType; }
            set { _currencyType = value; }
        }

        /// <summary>
        ///     the value of the "ACC_VAT_REG_NUM" field.
        /// </summary>
        public String VatRegNum
        {
            get { return _vatRegNum; }
            set { _vatRegNum = value; }
        }

        /// <summary>
        ///     the value of the "ACC_MEM_PAYMENT_DAYS" field.
        /// </summary>
        public Int32? MemPaymentDays
        {
            get { return _memPaymentDays; }
            set { _memPaymentDays = value; }
        }

        /// <summary>
        ///     the value of the "ACC_PO_REQ" field.
        /// </summary>
        public Byte? PoReq
        {
            get { return _poReq; }
            set { _poReq = value; }
        }

        /// <summary>
        ///     the value of the "ACC_RUN_DATE" field.
        /// </summary>
        public DateTime? RunDate
        {
            get { return _runDate; }
            set { _runDate = value; }
        }

        /// <summary>
        ///     the value of the "ACC_PSH_ID" field.
        /// </summary>
        public Int32? PshId
        {
            get { return _pshId; }
            set { _pshId = value; }
        }

        /// <summary>
        ///     the value of the "ACC_DEFAULT" field.
        /// </summary>
        public Byte? Default
        {
            get { return _default; }
            set { _default = value; }
        }

        /// <summary>
        ///     the value of the "ACC_RULE_TYPE" field.
        /// </summary>
        public Byte? RuleType
        {
            get { return _ruleType; }
            set { _ruleType = value; }
        }

        /// <summary>
        ///     the value of the "ACC_NAT_ACCOUNT_DATE" field.
        /// </summary>
        public DateTime? NatAccountDate
        {
            get { return _natAccountDate; }
            set { _natAccountDate = value; }
        }

        /// <summary>
        ///     the value of the "ACC_COURSE_LEN" field.
        /// </summary>
        public Double? CourseLen
        {
            get { return _courseLen; }
            set { _courseLen = value; }
        }

        /// <summary>
        ///     the value of the "ACC_RENEW_DAYS" field.
        /// </summary>
        public Int32? RenewDays
        {
            get { return _renewDays; }
            set { _renewDays = value; }
        }

        /// <summary>
        ///     the value of the "ACC_FIXED_RENEWAL" field.
        /// </summary>
        public Byte? FixedRenewal
        {
            get { return _fixedRenewal; }
            set { _fixedRenewal = value; }
        }

        /// <summary>
        ///     the value of the "ACC_RENEWAL_MONTH" field.
        /// </summary>
        public String RenewalMonth
        {
            get { return _renewalMonth; }
            set { _renewalMonth = value; }
        }

        /// <summary>
        ///     the value of the "ACC_RENEWAL_DAY" field.
        /// </summary>
        public String RenewalDay
        {
            get { return _renewalDay; }
            set { _renewalDay = value; }
        }

        /// <summary>
        ///     the value of the "ACC_RENEW" field.
        /// </summary>
        public Byte Renew
        {
            get { return _renew; }
            set { _renew = value; }
        }

        /// <summary>
        ///     the value of the "ACC_EXCL_DAY" field.
        /// </summary>
        public String ExclDay
        {
            get { return _exclDay; }
            set { _exclDay = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="AccountRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="AccountRecord" /> object instance.
        /// </returns>
        public AccountRecord Clone()
        {
            AccountRecord record = new AccountRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.System = this.System;
            record.SystemRef = this.SystemRef;
            record.OrgId = this.OrgId;
            record.Principal = this.Principal;
            record.ProleId = this.ProleId;
            record.ContactId = this.ContactId;
            record.AddId = this.AddId;
            record.SelcoSpId = this.SelcoSpId;
            record.NoAddChange = this.NoAddChange;
            record.PaymentDays = this.PaymentDays;
            record.Status = this.Status;
            record.PaymentType = this.PaymentType;
            record.PayTerms1 = this.PayTerms1;
            record.PayTerms2 = this.PayTerms2;
            record.PayTerms3 = this.PayTerms3;
            record.PayTerms4 = this.PayTerms4;
            record.Credit = this.Credit;
            record.SpecialTerms = this.SpecialTerms;
            record.Vatcd = this.Vatcd;
            record.InvForAttnOf = this.InvForAttnOf;
            record.InvoiceRule = this.InvoiceRule;
            record.InvoiceRuleOffset = this.InvoiceRuleOffset;
            record.InvoiceConsolidate = this.InvoiceConsolidate;
            record.InvoiceWhenStatus = this.InvoiceWhenStatus;
            record.InvoiceFormat = this.InvoiceFormat;
            record.InvoiceMustUseRule = this.InvoiceMustUseRule;
            record.InvoiceFormat0Text = this.InvoiceFormat0Text;
            record.InvoiceFormat1Text = this.InvoiceFormat1Text;
            record.InvoiceOffsetType = this.InvoiceOffsetType;
            record.InvAddTo = this.InvAddTo;
            record.NatAccount = this.NatAccount;
            record.BankName = this.BankName;
            record.BankSortCode = this.BankSortCode;
            record.BankNo = this.BankNo;
            record.BankAddId = this.BankAddId;
            record.PaymentMethd = this.PaymentMethd;
            record.DocType = this.DocType;
            record.CoutOffDays = this.CoutOffDays;
            record.Type = this.Type;
            record.Title = this.Title;
            record.StatusDate = this.StatusDate;
            record.BatId = this.BatId;
            record.ReqCredit = this.ReqCredit;
            record.DocsMethod = this.DocsMethod;
            record.DoNotChase = this.DoNotChase;
            record.InvPackId = this.InvPackId;
            record.ReqPaymentType = this.ReqPaymentType;
            record.ReqPaymentDays = this.ReqPaymentDays;
            record.DefaultInvStatus = this.DefaultInvStatus;
            record.CurrencyType = this.CurrencyType;
            record.VatRegNum = this.VatRegNum;
            record.MemPaymentDays = this.MemPaymentDays;
            record.PoReq = this.PoReq;
            record.RunDate = this.RunDate;
            record.PshId = this.PshId;
            record.Default = this.Default;
            record.RuleType = this.RuleType;
            record.NatAccountDate = this.NatAccountDate;
            record.CourseLen = this.CourseLen;
            record.RenewDays = this.RenewDays;
            record.FixedRenewal = this.FixedRenewal;
            record.RenewalMonth = this.RenewalMonth;
            record.RenewalDay = this.RenewalDay;
            record.Renew = this.Renew;
            record.ExclDay = this.ExclDay;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="AccountRecord" /> instance is equal to another <see cref="AccountRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="AccountRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(AccountRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.System.TrimOrNullify() == that.System.TrimOrNullify());
            result = result && (this.SystemRef.TrimOrNullify() == that.SystemRef.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.Principal == that.Principal);
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.ContactId.TrimOrNullify() == that.ContactId.TrimOrNullify());
            result = result && (this.AddId.TrimOrNullify() == that.AddId.TrimOrNullify());
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.NoAddChange == that.NoAddChange);
            result = result && (this.PaymentDays == that.PaymentDays);
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.PaymentType == that.PaymentType);
            result = result && (this.PayTerms1.TrimOrNullify() == that.PayTerms1.TrimOrNullify());
            result = result && (this.PayTerms2.TrimOrNullify() == that.PayTerms2.TrimOrNullify());
            result = result && (this.PayTerms3.TrimOrNullify() == that.PayTerms3.TrimOrNullify());
            result = result && (this.PayTerms4.TrimOrNullify() == that.PayTerms4.TrimOrNullify());
            result = result && (this.Credit == that.Credit);
            result = result && (this.SpecialTerms.TrimOrNullify() == that.SpecialTerms.TrimOrNullify());
            result = result && (this.Vatcd.TrimOrNullify() == that.Vatcd.TrimOrNullify());
            result = result && (this.InvForAttnOf.TrimOrNullify() == that.InvForAttnOf.TrimOrNullify());
            result = result && (this.InvoiceRule == that.InvoiceRule);
            result = result && (this.InvoiceRuleOffset == that.InvoiceRuleOffset);
            result = result && (this.InvoiceConsolidate == that.InvoiceConsolidate);
            result = result && (this.InvoiceWhenStatus.TrimOrNullify() == that.InvoiceWhenStatus.TrimOrNullify());
            result = result && (this.InvoiceFormat == that.InvoiceFormat);
            result = result && (this.InvoiceMustUseRule == that.InvoiceMustUseRule);
            result = result && (this.InvoiceFormat0Text.TrimOrNullify() == that.InvoiceFormat0Text.TrimOrNullify());
            result = result && (this.InvoiceFormat1Text.TrimOrNullify() == that.InvoiceFormat1Text.TrimOrNullify());
            result = result && (this.InvoiceOffsetType.TrimOrNullify() == that.InvoiceOffsetType.TrimOrNullify());
            result = result && (this.InvAddTo == that.InvAddTo);
            result = result && (this.NatAccount == that.NatAccount);
            result = result && (this.BankName.TrimOrNullify() == that.BankName.TrimOrNullify());
            result = result && (this.BankSortCode.TrimOrNullify() == that.BankSortCode.TrimOrNullify());
            result = result && (this.BankNo.TrimOrNullify() == that.BankNo.TrimOrNullify());
            result = result && (this.BankAddId.TrimOrNullify() == that.BankAddId.TrimOrNullify());
            result = result && (this.PaymentMethd.TrimOrNullify() == that.PaymentMethd.TrimOrNullify());
            result = result && (this.DocType.TrimOrNullify() == that.DocType.TrimOrNullify());
            result = result && (this.CoutOffDays == that.CoutOffDays);
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.Title.TrimOrNullify() == that.Title.TrimOrNullify());
            result = result && (this.StatusDate == that.StatusDate);
            result = result && (this.BatId.TrimOrNullify() == that.BatId.TrimOrNullify());
            result = result && (this.ReqCredit == that.ReqCredit);
            result = result && (this.DocsMethod.TrimOrNullify() == that.DocsMethod.TrimOrNullify());
            result = result && (this.DoNotChase == that.DoNotChase);
            result = result && (this.InvPackId.TrimOrNullify() == that.InvPackId.TrimOrNullify());
            result = result && (this.ReqPaymentType == that.ReqPaymentType);
            result = result && (this.ReqPaymentDays == that.ReqPaymentDays);
            result = result && (this.DefaultInvStatus == that.DefaultInvStatus);
            result = result && (this.CurrencyType.TrimOrNullify() == that.CurrencyType.TrimOrNullify());
            result = result && (this.VatRegNum.TrimOrNullify() == that.VatRegNum.TrimOrNullify());
            result = result && (this.MemPaymentDays == that.MemPaymentDays);
            result = result && (this.PoReq == that.PoReq);
            result = result && (this.RunDate == that.RunDate);
            result = result && (this.PshId == that.PshId);
            result = result && (this.Default == that.Default);
            result = result && (this.RuleType == that.RuleType);
            result = result && (this.NatAccountDate == that.NatAccountDate);
            result = result && (this.CourseLen == that.CourseLen);
            result = result && (this.RenewDays == that.RenewDays);
            result = result && (this.FixedRenewal == that.FixedRenewal);
            result = result && (this.RenewalMonth.TrimOrNullify() == that.RenewalMonth.TrimOrNullify());
            result = result && (this.RenewalDay.TrimOrNullify() == that.RenewalDay.TrimOrNullify());
            result = result && (this.Renew == that.Renew);
            result = result && (this.ExclDay.TrimOrNullify() == that.ExclDay.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
