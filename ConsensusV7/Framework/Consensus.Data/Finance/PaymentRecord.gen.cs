using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Represents the "Payment" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PaymentRecord : Record<String>, Cloneable<PaymentRecord>, IEquatable<PaymentRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PAY_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "PAY_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PAY_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PAY_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PAY_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PAY_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PAY_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PAY_CCARD_TYPE" field.
        /// </summary>
        private String _ccardType;

        /// <summary>
        ///     the value of the "PAY_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "PAY_NUMBER" field.
        /// </summary>
        private String _number;

        /// <summary>
        ///     the value of the "PAY_EXPY_DTE" field.
        /// </summary>
        private DateTime? _expyDte;

        /// <summary>
        ///     the value of the "PAY_APPVL_REF" field.
        /// </summary>
        private String _appvlRef;

        /// <summary>
        ///     the value of the "PAY_ISSUE_NO" field.
        /// </summary>
        private String _issueNo;

        /// <summary>
        ///     the value of the "PAY_CURR_TYPE" field.
        /// </summary>
        private String _currType;

        /// <summary>
        ///     the value of the "PAY_RECVD" field.
        /// </summary>
        private Decimal _recvd;

        /// <summary>
        ///     the value of the "PAY_RECVD_BC" field.
        /// </summary>
        private Decimal _recvdBc;

        /// <summary>
        ///     the value of the "PAY_DATE" field.
        /// </summary>
        private DateTime? _date;

        /// <summary>
        ///     the value of the "PAY_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "PAY_CUSTOMER_ACC" field.
        /// </summary>
        private String _customerAcc;

        /// <summary>
        ///     the value of the "PAY_UNUSED_VAL" field.
        /// </summary>
        private Decimal _unusedVal;

        /// <summary>
        ///     the value of the "PAY_UNUSED_VAL_BC" field.
        /// </summary>
        private Decimal _unusedValBc;

        /// <summary>
        ///     the value of the "PAY_GL_CODE" field.
        /// </summary>
        private String _glCode;

        /// <summary>
        ///     the value of the "PAY_PERIOD" field.
        /// </summary>
        private String _period;

        /// <summary>
        ///     the value of the "PAY_ORDER_ID" field.
        /// </summary>
        private String _orderId;

        /// <summary>
        ///     the value of the "PAY_HIDDEN" field.
        /// </summary>
        private Byte? _hidden;

        /// <summary>
        ///     the value of the "PAY_CHEQUE_NO" field.
        /// </summary>
        private String _chequeNo;

        /// <summary>
        ///     the value of the "PAY_SORT_CODE" field.
        /// </summary>
        private String _sortCode;

        /// <summary>
        ///     the value of the "PAY_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "PAY_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "PAY_VALID_DATE" field.
        /// </summary>
        private DateTime? _validDate;

        /// <summary>
        ///     the value of the "PAY_CURR_RATE_BC" field.
        /// </summary>
        private Decimal _currRateBc;

        /// <summary>
        ///     the value of the "PAY_CURR_RATE_BC2" field.
        /// </summary>
        private Decimal _currRateBc2;

        /// <summary>
        ///     the value of the "PAY_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "PAY_MEP_ID" field.
        /// </summary>
        private String _mepId;

        /// <summary>
        ///     the value of the "PAY_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "PAY_PN_ID" field.
        /// </summary>
        private String _pnId;

        /// <summary>
        ///     the value of the "PAY_REF" field.
        /// </summary>
        private String _ref;

        /// <summary>
        ///     the value of the "PAY_BOOK_ID" field.
        /// </summary>
        private String _bookId;

        /// <summary>
        ///     the value of the "PAY_CARD_SEC_ID" field.
        /// </summary>
        private String _cardSecId;

        /// <summary>
        ///     the value of the "PAY_START_MONTH" field.
        /// </summary>
        private String _startMonth;

        /// <summary>
        ///     the value of the "PAY_START_YEAR" field.
        /// </summary>
        private String _startYear;

        /// <summary>
        ///     the value of the "PAY_EXPY_MONTH" field.
        /// </summary>
        private String _expyMonth;

        /// <summary>
        ///     the value of the "PAY_EXPY_YEAR" field.
        /// </summary>
        private String _expyYear;

        /// <summary>
        ///     the value of the "PAY_REFUND_PAY_ID" field.
        /// </summary>
        private String _refundPayId;

        /// <summary>
        ///     the value of the "PAY_REFUND_PAY_REF" field.
        /// </summary>
        private String _refundPayRef;

        /// <summary>
        ///     the value of the "PAY_TXN_TYPE" field.
        /// </summary>
        private Int32? _txnType;

        /// <summary>
        ///     the value of the "PAY_BANKING_REF" field.
        /// </summary>
        private String _bankingRef;

        /// <summary>
        ///     the value of the "PAY_BAT_ID" field.
        /// </summary>
        private String _batId;

        /// <summary>
        ///     the value of the "PAY_BANK_CHG" field.
        /// </summary>
        private Decimal _bankChg;

        /// <summary>
        ///     the value of the "PAY_BANK_CHG_BC" field.
        /// </summary>
        private Decimal _bankChgBc;

        /// <summary>
        ///     the value of the "PAY_BANK_CHG_BC2" field.
        /// </summary>
        private Decimal _bankChgBc2;

        /// <summary>
        ///     the value of the "PAY_MEP_CRT_BAT_ID" field.
        /// </summary>
        private String _mepCrtBatId;

        /// <summary>
        ///     the value of the "PAY_RECVD_BC2" field.
        /// </summary>
        private Decimal _recvdBc2;

        /// <summary>
        ///     the value of the "PAY_UNUSED_VAL_BC2" field.
        /// </summary>
        private Decimal _unusedValBc2;

        /// <summary>
        ///     the value of the "PAY_COST_CODE" field.
        /// </summary>
        private String _costCode;

        /// <summary>
        ///     the value of the "PAY_PURPOSE" field.
        /// </summary>
        private Byte? _purpose;

        /// <summary>
        ///     the value of the "PAY_SCHN_ID" field.
        /// </summary>
        private String _schnId;

        /// <summary>
        ///     the value of the "PAY_ADD_ID" field.
        /// </summary>
        private String _addId;

        /// <summary>
        ///     the value of the "PAY_REVERSE_RES" field.
        /// </summary>
        private String _reverseRes;

        /// <summary>
        ///     the value of the "PAY_BANK_SORT_CODE" field.
        /// </summary>
        private String _bankSortCode;

        /// <summary>
        ///     the value of the "PAY_BANK_ACCOUNT" field.
        /// </summary>
        private String _bankAccount;

        /// <summary>
        ///     the value of the "PAY_ACC_ID" field.
        /// </summary>
        private String _accId;

        /// <summary>
        ///     the value of the "PAY_ACC_TRAN_RET" field.
        /// </summary>
        private Double? _accTranRet;

        /// <summary>
        ///     the value of the "PAY_EXP_BAT_ID" field.
        /// </summary>
        private String _expBatId;

        /// <summary>
        ///     the value of the "PAY_MOTO" field.
        /// </summary>
        private Byte _moto;

        /// <summary>
        ///     the value of the "PAY_LT_ID" field.
        /// </summary>
        private String _ltId;

        /// <summary>
        ///     the value of the "PAY_MSTC_ID" field.
        /// </summary>
        private String _mstcId;

        /// <summary>
        ///     the value of the "PAY_ORIGINAL_CUSTOMER_ACC" field.
        /// </summary>
        private String _originalCustomerAcc;

        /// <summary>
        ///     the value of the "PAY_TOKEN" field.
        /// </summary>
        private String _token;

        /// <summary>
        ///     the value of the "PAY_VOUCHER_TYPE" field.
        /// </summary>
        private String _voucherType;

        /// <summary>
        ///     the value of the "PAY_GATEWAY_ACC_ID" field.
        /// </summary>
        private String _gatewayAccId;

        /// <summary>
        ///     the value of the "PAY_CARDHOLDER_PROLE_ID" field.
        /// </summary>
        private String _cardholderProleId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PAY_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "PAY_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PAY_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PAY_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PAY_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PAY_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PAY_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PAY_CCARD_TYPE" field.
        /// </summary>
        public String CcardType
        {
            get { return _ccardType; }
            set { _ccardType = value; }
        }

        /// <summary>
        ///     the value of the "PAY_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "PAY_NUMBER" field.
        /// </summary>
        public String Number
        {
            get { return _number; }
            set { _number = value; }
        }

        /// <summary>
        ///     the value of the "PAY_EXPY_DTE" field.
        /// </summary>
        public DateTime? ExpyDte
        {
            get { return _expyDte; }
            set { _expyDte = value; }
        }

        /// <summary>
        ///     the value of the "PAY_APPVL_REF" field.
        /// </summary>
        public String AppvlRef
        {
            get { return _appvlRef; }
            set { _appvlRef = value; }
        }

        /// <summary>
        ///     the value of the "PAY_ISSUE_NO" field.
        /// </summary>
        public String IssueNo
        {
            get { return _issueNo; }
            set { _issueNo = value; }
        }

        /// <summary>
        ///     the value of the "PAY_CURR_TYPE" field.
        /// </summary>
        public String CurrType
        {
            get { return _currType; }
            set { _currType = value; }
        }

        /// <summary>
        ///     the value of the "PAY_RECVD" field.
        /// </summary>
        public Decimal Recvd
        {
            get { return _recvd; }
            set { _recvd = value; }
        }

        /// <summary>
        ///     the value of the "PAY_RECVD_BC" field.
        /// </summary>
        public Decimal RecvdBc
        {
            get { return _recvdBc; }
            set { _recvdBc = value; }
        }

        /// <summary>
        ///     the value of the "PAY_DATE" field.
        /// </summary>
        public DateTime? Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        ///     the value of the "PAY_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "PAY_CUSTOMER_ACC" field.
        /// </summary>
        public String CustomerAcc
        {
            get { return _customerAcc; }
            set { _customerAcc = value; }
        }

        /// <summary>
        ///     the value of the "PAY_UNUSED_VAL" field.
        /// </summary>
        public Decimal UnusedVal
        {
            get { return _unusedVal; }
            set { _unusedVal = value; }
        }

        /// <summary>
        ///     the value of the "PAY_UNUSED_VAL_BC" field.
        /// </summary>
        public Decimal UnusedValBc
        {
            get { return _unusedValBc; }
            set { _unusedValBc = value; }
        }

        /// <summary>
        ///     the value of the "PAY_GL_CODE" field.
        /// </summary>
        public String GlCode
        {
            get { return _glCode; }
            set { _glCode = value; }
        }

        /// <summary>
        ///     the value of the "PAY_PERIOD" field.
        /// </summary>
        public String Period
        {
            get { return _period; }
            set { _period = value; }
        }

        /// <summary>
        ///     the value of the "PAY_ORDER_ID" field.
        /// </summary>
        public String OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_HIDDEN" field.
        /// </summary>
        public Byte? Hidden
        {
            get { return _hidden; }
            set { _hidden = value; }
        }

        /// <summary>
        ///     the value of the "PAY_CHEQUE_NO" field.
        /// </summary>
        public String ChequeNo
        {
            get { return _chequeNo; }
            set { _chequeNo = value; }
        }

        /// <summary>
        ///     the value of the "PAY_SORT_CODE" field.
        /// </summary>
        public String SortCode
        {
            get { return _sortCode; }
            set { _sortCode = value; }
        }

        /// <summary>
        ///     the value of the "PAY_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "PAY_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "PAY_VALID_DATE" field.
        /// </summary>
        public DateTime? ValidDate
        {
            get { return _validDate; }
            set { _validDate = value; }
        }

        /// <summary>
        ///     the value of the "PAY_CURR_RATE_BC" field.
        /// </summary>
        public Decimal CurrRateBc
        {
            get { return _currRateBc; }
            set { _currRateBc = value; }
        }

        /// <summary>
        ///     the value of the "PAY_CURR_RATE_BC2" field.
        /// </summary>
        public Decimal CurrRateBc2
        {
            get { return _currRateBc2; }
            set { _currRateBc2 = value; }
        }

        /// <summary>
        ///     the value of the "PAY_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_MEP_ID" field.
        /// </summary>
        public String MepId
        {
            get { return _mepId; }
            set { _mepId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_PN_ID" field.
        /// </summary>
        public String PnId
        {
            get { return _pnId; }
            set { _pnId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_REF" field.
        /// </summary>
        public String Ref
        {
            get { return _ref; }
            set { _ref = value; }
        }

        /// <summary>
        ///     the value of the "PAY_BOOK_ID" field.
        /// </summary>
        public String BookId
        {
            get { return _bookId; }
            set { _bookId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_CARD_SEC_ID" field.
        /// </summary>
        public String CardSecId
        {
            get { return _cardSecId; }
            set { _cardSecId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_START_MONTH" field.
        /// </summary>
        public String StartMonth
        {
            get { return _startMonth; }
            set { _startMonth = value; }
        }

        /// <summary>
        ///     the value of the "PAY_START_YEAR" field.
        /// </summary>
        public String StartYear
        {
            get { return _startYear; }
            set { _startYear = value; }
        }

        /// <summary>
        ///     the value of the "PAY_EXPY_MONTH" field.
        /// </summary>
        public String ExpyMonth
        {
            get { return _expyMonth; }
            set { _expyMonth = value; }
        }

        /// <summary>
        ///     the value of the "PAY_EXPY_YEAR" field.
        /// </summary>
        public String ExpyYear
        {
            get { return _expyYear; }
            set { _expyYear = value; }
        }

        /// <summary>
        ///     the value of the "PAY_REFUND_PAY_ID" field.
        /// </summary>
        public String RefundPayId
        {
            get { return _refundPayId; }
            set { _refundPayId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_REFUND_PAY_REF" field.
        /// </summary>
        public String RefundPayRef
        {
            get { return _refundPayRef; }
            set { _refundPayRef = value; }
        }

        /// <summary>
        ///     the value of the "PAY_TXN_TYPE" field.
        /// </summary>
        public Int32? TxnType
        {
            get { return _txnType; }
            set { _txnType = value; }
        }

        /// <summary>
        ///     the value of the "PAY_BANKING_REF" field.
        /// </summary>
        public String BankingRef
        {
            get { return _bankingRef; }
            set { _bankingRef = value; }
        }

        /// <summary>
        ///     the value of the "PAY_BAT_ID" field.
        /// </summary>
        public String BatId
        {
            get { return _batId; }
            set { _batId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_BANK_CHG" field.
        /// </summary>
        public Decimal BankChg
        {
            get { return _bankChg; }
            set { _bankChg = value; }
        }

        /// <summary>
        ///     the value of the "PAY_BANK_CHG_BC" field.
        /// </summary>
        public Decimal BankChgBc
        {
            get { return _bankChgBc; }
            set { _bankChgBc = value; }
        }

        /// <summary>
        ///     the value of the "PAY_BANK_CHG_BC2" field.
        /// </summary>
        public Decimal BankChgBc2
        {
            get { return _bankChgBc2; }
            set { _bankChgBc2 = value; }
        }

        /// <summary>
        ///     the value of the "PAY_MEP_CRT_BAT_ID" field.
        /// </summary>
        public String MepCrtBatId
        {
            get { return _mepCrtBatId; }
            set { _mepCrtBatId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_RECVD_BC2" field.
        /// </summary>
        public Decimal RecvdBc2
        {
            get { return _recvdBc2; }
            set { _recvdBc2 = value; }
        }

        /// <summary>
        ///     the value of the "PAY_UNUSED_VAL_BC2" field.
        /// </summary>
        public Decimal UnusedValBc2
        {
            get { return _unusedValBc2; }
            set { _unusedValBc2 = value; }
        }

        /// <summary>
        ///     the value of the "PAY_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return _costCode; }
            set { _costCode = value; }
        }

        /// <summary>
        ///     the value of the "PAY_PURPOSE" field.
        /// </summary>
        public Byte? Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }

        /// <summary>
        ///     the value of the "PAY_SCHN_ID" field.
        /// </summary>
        public String SchnId
        {
            get { return _schnId; }
            set { _schnId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_ADD_ID" field.
        /// </summary>
        public String AddId
        {
            get { return _addId; }
            set { _addId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_REVERSE_RES" field.
        /// </summary>
        public String ReverseRes
        {
            get { return _reverseRes; }
            set { _reverseRes = value; }
        }

        /// <summary>
        ///     the value of the "PAY_BANK_SORT_CODE" field.
        /// </summary>
        public String BankSortCode
        {
            get { return _bankSortCode; }
            set { _bankSortCode = value; }
        }

        /// <summary>
        ///     the value of the "PAY_BANK_ACCOUNT" field.
        /// </summary>
        public String BankAccount
        {
            get { return _bankAccount; }
            set { _bankAccount = value; }
        }

        /// <summary>
        ///     the value of the "PAY_ACC_ID" field.
        /// </summary>
        public String AccId
        {
            get { return _accId; }
            set { _accId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_ACC_TRAN_RET" field.
        /// </summary>
        public Double? AccTranRet
        {
            get { return _accTranRet; }
            set { _accTranRet = value; }
        }

        /// <summary>
        ///     the value of the "PAY_EXP_BAT_ID" field.
        /// </summary>
        public String ExpBatId
        {
            get { return _expBatId; }
            set { _expBatId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_MOTO" field.
        /// </summary>
        public Byte Moto
        {
            get { return _moto; }
            set { _moto = value; }
        }

        /// <summary>
        ///     the value of the "PAY_LT_ID" field.
        /// </summary>
        public String LtId
        {
            get { return _ltId; }
            set { _ltId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_MSTC_ID" field.
        /// </summary>
        public String MstcId
        {
            get { return _mstcId; }
            set { _mstcId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_ORIGINAL_CUSTOMER_ACC" field.
        /// </summary>
        public String OriginalCustomerAcc
        {
            get { return _originalCustomerAcc; }
            set { _originalCustomerAcc = value; }
        }

        /// <summary>
        ///     the value of the "PAY_TOKEN" field.
        /// </summary>
        public String Token
        {
            get { return _token; }
            set { _token = value; }
        }

        /// <summary>
        ///     the value of the "PAY_VOUCHER_TYPE" field.
        /// </summary>
        public String VoucherType
        {
            get { return _voucherType; }
            set { _voucherType = value; }
        }

        /// <summary>
        ///     the value of the "PAY_GATEWAY_ACC_ID" field.
        /// </summary>
        public String GatewayAccId
        {
            get { return _gatewayAccId; }
            set { _gatewayAccId = value; }
        }

        /// <summary>
        ///     the value of the "PAY_CARDHOLDER_PROLE_ID" field.
        /// </summary>
        public String CardholderProleId
        {
            get { return _cardholderProleId; }
            set { _cardholderProleId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PaymentRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PaymentRecord" /> object instance.
        /// </returns>
        public PaymentRecord Clone()
        {
            PaymentRecord record = new PaymentRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.CcardType = this.CcardType;
            record.Name = this.Name;
            record.Number = this.Number;
            record.ExpyDte = this.ExpyDte;
            record.AppvlRef = this.AppvlRef;
            record.IssueNo = this.IssueNo;
            record.CurrType = this.CurrType;
            record.Recvd = this.Recvd;
            record.RecvdBc = this.RecvdBc;
            record.Date = this.Date;
            record.Type = this.Type;
            record.CustomerAcc = this.CustomerAcc;
            record.UnusedVal = this.UnusedVal;
            record.UnusedValBc = this.UnusedValBc;
            record.GlCode = this.GlCode;
            record.Period = this.Period;
            record.OrderId = this.OrderId;
            record.Hidden = this.Hidden;
            record.ChequeNo = this.ChequeNo;
            record.SortCode = this.SortCode;
            record.Status = this.Status;
            record.Notes = this.Notes;
            record.ValidDate = this.ValidDate;
            record.CurrRateBc = this.CurrRateBc;
            record.CurrRateBc2 = this.CurrRateBc2;
            record.SelcoSpId = this.SelcoSpId;
            record.MepId = this.MepId;
            record.OrgId = this.OrgId;
            record.PnId = this.PnId;
            record.Ref = this.Ref;
            record.BookId = this.BookId;
            record.CardSecId = this.CardSecId;
            record.StartMonth = this.StartMonth;
            record.StartYear = this.StartYear;
            record.ExpyMonth = this.ExpyMonth;
            record.ExpyYear = this.ExpyYear;
            record.RefundPayId = this.RefundPayId;
            record.RefundPayRef = this.RefundPayRef;
            record.TxnType = this.TxnType;
            record.BankingRef = this.BankingRef;
            record.BatId = this.BatId;
            record.BankChg = this.BankChg;
            record.BankChgBc = this.BankChgBc;
            record.BankChgBc2 = this.BankChgBc2;
            record.MepCrtBatId = this.MepCrtBatId;
            record.RecvdBc2 = this.RecvdBc2;
            record.UnusedValBc2 = this.UnusedValBc2;
            record.CostCode = this.CostCode;
            record.Purpose = this.Purpose;
            record.SchnId = this.SchnId;
            record.AddId = this.AddId;
            record.ReverseRes = this.ReverseRes;
            record.BankSortCode = this.BankSortCode;
            record.BankAccount = this.BankAccount;
            record.AccId = this.AccId;
            record.AccTranRet = this.AccTranRet;
            record.ExpBatId = this.ExpBatId;
            record.Moto = this.Moto;
            record.LtId = this.LtId;
            record.MstcId = this.MstcId;
            record.OriginalCustomerAcc = this.OriginalCustomerAcc;
            record.Token = this.Token;
            record.VoucherType = this.VoucherType;
            record.GatewayAccId = this.GatewayAccId;
            record.CardholderProleId = this.CardholderProleId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PaymentRecord" /> instance is equal to another <see cref="PaymentRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PaymentRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PaymentRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.CcardType.TrimOrNullify() == that.CcardType.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Number.TrimOrNullify() == that.Number.TrimOrNullify());
            result = result && (this.ExpyDte == that.ExpyDte);
            result = result && (this.AppvlRef.TrimOrNullify() == that.AppvlRef.TrimOrNullify());
            result = result && (this.IssueNo.TrimOrNullify() == that.IssueNo.TrimOrNullify());
            result = result && (this.CurrType.TrimOrNullify() == that.CurrType.TrimOrNullify());
            result = result && (this.Recvd == that.Recvd);
            result = result && (this.RecvdBc == that.RecvdBc);
            result = result && (this.Date == that.Date);
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.CustomerAcc.TrimOrNullify() == that.CustomerAcc.TrimOrNullify());
            result = result && (this.UnusedVal == that.UnusedVal);
            result = result && (this.UnusedValBc == that.UnusedValBc);
            result = result && (this.GlCode.TrimOrNullify() == that.GlCode.TrimOrNullify());
            result = result && (this.Period.TrimOrNullify() == that.Period.TrimOrNullify());
            result = result && (this.OrderId.TrimOrNullify() == that.OrderId.TrimOrNullify());
            result = result && (this.Hidden == that.Hidden);
            result = result && (this.ChequeNo.TrimOrNullify() == that.ChequeNo.TrimOrNullify());
            result = result && (this.SortCode.TrimOrNullify() == that.SortCode.TrimOrNullify());
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.ValidDate == that.ValidDate);
            result = result && (this.CurrRateBc == that.CurrRateBc);
            result = result && (this.CurrRateBc2 == that.CurrRateBc2);
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.MepId.TrimOrNullify() == that.MepId.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.PnId.TrimOrNullify() == that.PnId.TrimOrNullify());
            result = result && (this.Ref.TrimOrNullify() == that.Ref.TrimOrNullify());
            result = result && (this.BookId.TrimOrNullify() == that.BookId.TrimOrNullify());
            result = result && (this.CardSecId.TrimOrNullify() == that.CardSecId.TrimOrNullify());
            result = result && (this.StartMonth.TrimOrNullify() == that.StartMonth.TrimOrNullify());
            result = result && (this.StartYear.TrimOrNullify() == that.StartYear.TrimOrNullify());
            result = result && (this.ExpyMonth.TrimOrNullify() == that.ExpyMonth.TrimOrNullify());
            result = result && (this.ExpyYear.TrimOrNullify() == that.ExpyYear.TrimOrNullify());
            result = result && (this.RefundPayId.TrimOrNullify() == that.RefundPayId.TrimOrNullify());
            result = result && (this.RefundPayRef.TrimOrNullify() == that.RefundPayRef.TrimOrNullify());
            result = result && (this.TxnType == that.TxnType);
            result = result && (this.BankingRef.TrimOrNullify() == that.BankingRef.TrimOrNullify());
            result = result && (this.BatId.TrimOrNullify() == that.BatId.TrimOrNullify());
            result = result && (this.BankChg == that.BankChg);
            result = result && (this.BankChgBc == that.BankChgBc);
            result = result && (this.BankChgBc2 == that.BankChgBc2);
            result = result && (this.MepCrtBatId.TrimOrNullify() == that.MepCrtBatId.TrimOrNullify());
            result = result && (this.RecvdBc2 == that.RecvdBc2);
            result = result && (this.UnusedValBc2 == that.UnusedValBc2);
            result = result && (this.CostCode.TrimOrNullify() == that.CostCode.TrimOrNullify());
            result = result && (this.Purpose == that.Purpose);
            result = result && (this.SchnId.TrimOrNullify() == that.SchnId.TrimOrNullify());
            result = result && (this.AddId.TrimOrNullify() == that.AddId.TrimOrNullify());
            result = result && (this.ReverseRes.TrimOrNullify() == that.ReverseRes.TrimOrNullify());
            result = result && (this.BankSortCode.TrimOrNullify() == that.BankSortCode.TrimOrNullify());
            result = result && (this.BankAccount.TrimOrNullify() == that.BankAccount.TrimOrNullify());
            result = result && (this.AccId.TrimOrNullify() == that.AccId.TrimOrNullify());
            result = result && (this.AccTranRet == that.AccTranRet);
            result = result && (this.ExpBatId.TrimOrNullify() == that.ExpBatId.TrimOrNullify());
            result = result && (this.Moto == that.Moto);
            result = result && (this.LtId.TrimOrNullify() == that.LtId.TrimOrNullify());
            result = result && (this.MstcId.TrimOrNullify() == that.MstcId.TrimOrNullify());
            result = result && (this.OriginalCustomerAcc.TrimOrNullify() == that.OriginalCustomerAcc.TrimOrNullify());
            result = result && (this.Token.TrimOrNullify() == that.Token.TrimOrNullify());
            result = result && (this.VoucherType.TrimOrNullify() == that.VoucherType.TrimOrNullify());
            result = result && (this.GatewayAccId.TrimOrNullify() == that.GatewayAccId.TrimOrNullify());
            result = result && (this.CardholderProleId.TrimOrNullify() == that.CardholderProleId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
