using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Represents the "Member_location" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class MemberLocationRecord : Record<String>, Cloneable<MemberLocationRecord>, IEquatable<MemberLocationRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "MEL_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "MEL_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "MEL_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "MEL_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "MEL_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "MEL_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "MEL_MEM_ID" field.
        /// </summary>
        private String _memId;

        /// <summary>
        ///     the value of the "MEL_MEP_ID" field.
        /// </summary>
        private String _mepId;

        /// <summary>
        ///     the value of the "MEL_START" field.
        /// </summary>
        private DateTime? _start;

        /// <summary>
        ///     the value of the "MEL_END" field.
        /// </summary>
        private DateTime? _end;

        /// <summary>
        ///     the value of the "MEL_STATUS" field.
        /// </summary>
        private Int32? _status;

        /// <summary>
        ///     the value of the "MEL_TYPE" field.
        /// </summary>
        private Int32? _type;

        /// <summary>
        ///     the value of the "MEL_FEE" field.
        /// </summary>
        private Decimal _fee;

        /// <summary>
        ///     the value of the "MEL_FEE_BC" field.
        /// </summary>
        private Decimal _feeBc;

        /// <summary>
        ///     the value of the "MEL_FEE_BC2" field.
        /// </summary>
        private Decimal _feeBc2;

        /// <summary>
        ///     the value of the "MEL_CURRENCY" field.
        /// </summary>
        private String _currency;

        /// <summary>
        ///     the value of the "MEL_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "MEL_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "MEL_MAIL_ADD_ID" field.
        /// </summary>
        private String _mailAddId;

        /// <summary>
        ///     the value of the "MEL_MAIL_INV_ID" field.
        /// </summary>
        private String _mailInvId;

        /// <summary>
        ///     the value of the "MEL_MAIL_TO_HOME" field.
        /// </summary>
        private Byte? _mailToHome;

        /// <summary>
        ///     the value of the "MEL_RENEW_LOC" field.
        /// </summary>
        private Byte? _renewLoc;

        /// <summary>
        ///     the value of the "MEL_PRINCIPAL" field.
        /// </summary>
        private Byte? _principal;

        /// <summary>
        ///     the value of the "MEL_OVERSEAS" field.
        /// </summary>
        private Byte? _overseas;

        /// <summary>
        ///     the value of the "MEL_VATCD" field.
        /// </summary>
        private String _vatcd;

        /// <summary>
        ///     the value of the "MEL_REF" field.
        /// </summary>
        private String _ref;

        /// <summary>
        ///     the value of the "MEL_VAT_RATE" field.
        /// </summary>
        private Decimal _vatRate;

        /// <summary>
        ///     the value of the "MEL_VAT_AMT" field.
        /// </summary>
        private Decimal _vatAmt;

        /// <summary>
        ///     the value of the "MEL_VAT_AMT_BC" field.
        /// </summary>
        private Decimal _vatAmtBc;

        /// <summary>
        ///     the value of the "MEL_VAT_AMT_BC2" field.
        /// </summary>
        private Decimal _vatAmtBc2;

        /// <summary>
        ///     the value of the "MEL_INVLN_ID" field.
        /// </summary>
        private String _invlnId;

        /// <summary>
        ///     the value of the "MEL_NO_COPIES" field.
        /// </summary>
        private Int32? _noCopies;

        /// <summary>
        ///     the value of the "MEL_INVOICED" field.
        /// </summary>
        private Byte? _invoiced;

        /// <summary>
        ///     the value of the "MEL_USERNAME" field.
        /// </summary>
        private String _username;

        /// <summary>
        ///     the value of the "MEL_PASSWORD" field.
        /// </summary>
        private String _password;

        /// <summary>
        ///     the value of the "MEL_SY_TYPE" field.
        /// </summary>
        private Byte _syType;

        /// <summary>
        ///     the value of the "MEL_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "MEL_CURRENT" field.
        /// </summary>
        private Byte _current;

        /// <summary>
        ///     the value of the "MEL_GROSS_FEE" field.
        /// </summary>
        private Decimal _grossFee;

        /// <summary>
        ///     the value of the "MEL_GROSS_FEE_BC" field.
        /// </summary>
        private Decimal _grossFeeBc;

        /// <summary>
        ///     the value of the "MEL_GROSS_FEE_BC2" field.
        /// </summary>
        private Decimal _grossFeeBc2;

        /// <summary>
        ///     the value of the "MEL_DISC_REASON" field.
        /// </summary>
        private String _discReason;

        /// <summary>
        ///     the value of the "MEL_PHONE_OVERRIDE" field.
        /// </summary>
        private String _phoneOverride;

        /// <summary>
        ///     the value of the "MEL_FAX_OVERRIDE" field.
        /// </summary>
        private String _faxOverride;

        /// <summary>
        ///     the value of the "MEL_PHONE_STD_OVERRIDE" field.
        /// </summary>
        private String _phoneStdOverride;

        /// <summary>
        ///     the value of the "MEL_FAX_STD_OVERRIDE" field.
        /// </summary>
        private String _faxStdOverride;

        /// <summary>
        ///     the value of the "MEL_EMAIL_OVERRIDE" field.
        /// </summary>
        private String _emailOverride;

        /// <summary>
        ///     the value of the "MEL_URL" field.
        /// </summary>
        private String _url;

        /// <summary>
        ///     the value of the "MEL_FEE_NOT_PRO_RATA" field.
        /// </summary>
        private Decimal _feeNotProRata;

        /// <summary>
        ///     the value of the "MEL_WEB_ENABLED" field.
        /// </summary>
        private Byte? _webEnabled;

        /// <summary>
        ///     the value of the "MEL_FEE_EXEMPT" field.
        /// </summary>
        private Byte _feeExempt;

        /// <summary>
        ///     the value of the "MEL_CURRENT_DATE" field.
        /// </summary>
        private DateTime? _currentDate;

        /// <summary>
        ///     the value of the "MEL_CANCEL_DATE" field.
        /// </summary>
        private DateTime? _cancelDate;

        /// <summary>
        ///     the value of the "MEL_PL_ID" field.
        /// </summary>
        private String _plId;

        /// <summary>
        ///     the value of the "MEL_DISC_ID" field.
        /// </summary>
        private Int32? _discId;

        /// <summary>
        ///     the value of the "MEL_DISCOUNT" field.
        /// </summary>
        private Decimal? _discount;

        /// <summary>
        ///     the value of the "MEL_DISCOUNT_BC" field.
        /// </summary>
        private Decimal? _discountBc;

        /// <summary>
        ///     the value of the "MEL_DISCOUNT_BC2" field.
        /// </summary>
        private Decimal? _discountBc2;

        /// <summary>
        ///     the value of the "MEL_DISC_APPLIED_DATE" field.
        /// </summary>
        private DateTime? _discAppliedDate;

        /// <summary>
        ///     the value of the "MEL_FEE_CALCULATED" field.
        /// </summary>
        private Byte? _feeCalculated;

        /// <summary>
        ///     the value of the "MEL_LIST_PRICE" field.
        /// </summary>
        private Decimal? _listPrice;

        /// <summary>
        ///     the value of the "MEL_LIST_PRICE_BC" field.
        /// </summary>
        private Decimal? _listPriceBc;

        /// <summary>
        ///     the value of the "MEL_LIST_PRICE_BC2" field.
        /// </summary>
        private Decimal? _listPriceBc2;

        /// <summary>
        ///     the value of the "MEL_DESPATCH_DATE" field.
        /// </summary>
        private DateTime? _despatchDate;

        /// <summary>
        ///     the value of the "MEL_PO_NUMBER" field.
        /// </summary>
        private String _poNumber;

        /// <summary>
        ///     the value of the "MEL_QTY" field.
        /// </summary>
        private Int32? _qty;

        /// <summary>
        ///     the value of the "MEL_DO_NOT_RENEW" field.
        /// </summary>
        private Byte? _doNotRenew;

        /// <summary>
        ///     the value of the "MEL_CANCEL_REASON" field.
        /// </summary>
        private String _cancelReason;

        /// <summary>
        ///     the value of the "MEL_UNT_PRICE" field.
        /// </summary>
        private Decimal? _untPrice;

        /// <summary>
        ///     the value of the "MEL_UNT_PRICE_BC" field.
        /// </summary>
        private Decimal? _untPriceBc;

        /// <summary>
        ///     the value of the "MEL_UNT_PRICE_BC2" field.
        /// </summary>
        private Decimal? _untPriceBc2;

        /// <summary>
        ///     the value of the "MEL_DISC_RENEWAL" field.
        /// </summary>
        private DateTime? _discRenewal;

        /// <summary>
        ///     the value of the "MEL_PRICE_MODIFIED" field.
        /// </summary>
        private Byte _priceModified;

        /// <summary>
        ///     the value of the "MEL_DISC_PERCENT" field.
        /// </summary>
        private Decimal? _discPercent;

        /// <summary>
        ///     the value of the "MEL_REV_CODE" field.
        /// </summary>
        private String _revCode;

        /// <summary>
        ///     the value of the "MEL_COST_CODE" field.
        /// </summary>
        private String _costCode;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "MEL_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "MEL_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "MEL_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "MEL_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "MEL_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "MEL_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "MEL_MEM_ID" field.
        /// </summary>
        public String MemId
        {
            get { return _memId; }
            set { _memId = value; }
        }

        /// <summary>
        ///     the value of the "MEL_MEP_ID" field.
        /// </summary>
        public String MepId
        {
            get { return _mepId; }
            set { _mepId = value; }
        }

        /// <summary>
        ///     the value of the "MEL_START" field.
        /// </summary>
        public DateTime? Start
        {
            get { return _start; }
            set { _start = value; }
        }

        /// <summary>
        ///     the value of the "MEL_END" field.
        /// </summary>
        public DateTime? End
        {
            get { return _end; }
            set { _end = value; }
        }

        /// <summary>
        ///     the value of the "MEL_STATUS" field.
        /// </summary>
        public Int32? Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "MEL_TYPE" field.
        /// </summary>
        public Int32? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "MEL_FEE" field.
        /// </summary>
        public Decimal Fee
        {
            get { return _fee; }
            set { _fee = value; }
        }

        /// <summary>
        ///     the value of the "MEL_FEE_BC" field.
        /// </summary>
        public Decimal FeeBc
        {
            get { return _feeBc; }
            set { _feeBc = value; }
        }

        /// <summary>
        ///     the value of the "MEL_FEE_BC2" field.
        /// </summary>
        public Decimal FeeBc2
        {
            get { return _feeBc2; }
            set { _feeBc2 = value; }
        }

        /// <summary>
        ///     the value of the "MEL_CURRENCY" field.
        /// </summary>
        public String Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        /// <summary>
        ///     the value of the "MEL_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "MEL_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "MEL_MAIL_ADD_ID" field.
        /// </summary>
        public String MailAddId
        {
            get { return _mailAddId; }
            set { _mailAddId = value; }
        }

        /// <summary>
        ///     the value of the "MEL_MAIL_INV_ID" field.
        /// </summary>
        public String MailInvId
        {
            get { return _mailInvId; }
            set { _mailInvId = value; }
        }

        /// <summary>
        ///     the value of the "MEL_MAIL_TO_HOME" field.
        /// </summary>
        public Byte? MailToHome
        {
            get { return _mailToHome; }
            set { _mailToHome = value; }
        }

        /// <summary>
        ///     the value of the "MEL_RENEW_LOC" field.
        /// </summary>
        public Byte? RenewLoc
        {
            get { return _renewLoc; }
            set { _renewLoc = value; }
        }

        /// <summary>
        ///     the value of the "MEL_PRINCIPAL" field.
        /// </summary>
        public Byte? Principal
        {
            get { return _principal; }
            set { _principal = value; }
        }

        /// <summary>
        ///     the value of the "MEL_OVERSEAS" field.
        /// </summary>
        public Byte? Overseas
        {
            get { return _overseas; }
            set { _overseas = value; }
        }

        /// <summary>
        ///     the value of the "MEL_VATCD" field.
        /// </summary>
        public String Vatcd
        {
            get { return _vatcd; }
            set { _vatcd = value; }
        }

        /// <summary>
        ///     the value of the "MEL_REF" field.
        /// </summary>
        public String Ref
        {
            get { return _ref; }
            set { _ref = value; }
        }

        /// <summary>
        ///     the value of the "MEL_VAT_RATE" field.
        /// </summary>
        public Decimal VatRate
        {
            get { return _vatRate; }
            set { _vatRate = value; }
        }

        /// <summary>
        ///     the value of the "MEL_VAT_AMT" field.
        /// </summary>
        public Decimal VatAmt
        {
            get { return _vatAmt; }
            set { _vatAmt = value; }
        }

        /// <summary>
        ///     the value of the "MEL_VAT_AMT_BC" field.
        /// </summary>
        public Decimal VatAmtBc
        {
            get { return _vatAmtBc; }
            set { _vatAmtBc = value; }
        }

        /// <summary>
        ///     the value of the "MEL_VAT_AMT_BC2" field.
        /// </summary>
        public Decimal VatAmtBc2
        {
            get { return _vatAmtBc2; }
            set { _vatAmtBc2 = value; }
        }

        /// <summary>
        ///     the value of the "MEL_INVLN_ID" field.
        /// </summary>
        public String InvlnId
        {
            get { return _invlnId; }
            set { _invlnId = value; }
        }

        /// <summary>
        ///     the value of the "MEL_NO_COPIES" field.
        /// </summary>
        public Int32? NoCopies
        {
            get { return _noCopies; }
            set { _noCopies = value; }
        }

        /// <summary>
        ///     the value of the "MEL_INVOICED" field.
        /// </summary>
        public Byte? Invoiced
        {
            get { return _invoiced; }
            set { _invoiced = value; }
        }

        /// <summary>
        ///     the value of the "MEL_USERNAME" field.
        /// </summary>
        public String Username
        {
            get { return _username; }
            set { _username = value; }
        }

        /// <summary>
        ///     the value of the "MEL_PASSWORD" field.
        /// </summary>
        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        /// <summary>
        ///     the value of the "MEL_SY_TYPE" field.
        /// </summary>
        public Byte SyType
        {
            get { return _syType; }
            set { _syType = value; }
        }

        /// <summary>
        ///     the value of the "MEL_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "MEL_CURRENT" field.
        /// </summary>
        public Byte Current
        {
            get { return _current; }
            set { _current = value; }
        }

        /// <summary>
        ///     the value of the "MEL_GROSS_FEE" field.
        /// </summary>
        public Decimal GrossFee
        {
            get { return _grossFee; }
            set { _grossFee = value; }
        }

        /// <summary>
        ///     the value of the "MEL_GROSS_FEE_BC" field.
        /// </summary>
        public Decimal GrossFeeBc
        {
            get { return _grossFeeBc; }
            set { _grossFeeBc = value; }
        }

        /// <summary>
        ///     the value of the "MEL_GROSS_FEE_BC2" field.
        /// </summary>
        public Decimal GrossFeeBc2
        {
            get { return _grossFeeBc2; }
            set { _grossFeeBc2 = value; }
        }

        /// <summary>
        ///     the value of the "MEL_DISC_REASON" field.
        /// </summary>
        public String DiscReason
        {
            get { return _discReason; }
            set { _discReason = value; }
        }

        /// <summary>
        ///     the value of the "MEL_PHONE_OVERRIDE" field.
        /// </summary>
        public String PhoneOverride
        {
            get { return _phoneOverride; }
            set { _phoneOverride = value; }
        }

        /// <summary>
        ///     the value of the "MEL_FAX_OVERRIDE" field.
        /// </summary>
        public String FaxOverride
        {
            get { return _faxOverride; }
            set { _faxOverride = value; }
        }

        /// <summary>
        ///     the value of the "MEL_PHONE_STD_OVERRIDE" field.
        /// </summary>
        public String PhoneStdOverride
        {
            get { return _phoneStdOverride; }
            set { _phoneStdOverride = value; }
        }

        /// <summary>
        ///     the value of the "MEL_FAX_STD_OVERRIDE" field.
        /// </summary>
        public String FaxStdOverride
        {
            get { return _faxStdOverride; }
            set { _faxStdOverride = value; }
        }

        /// <summary>
        ///     the value of the "MEL_EMAIL_OVERRIDE" field.
        /// </summary>
        public String EmailOverride
        {
            get { return _emailOverride; }
            set { _emailOverride = value; }
        }

        /// <summary>
        ///     the value of the "MEL_URL" field.
        /// </summary>
        public String Url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        ///     the value of the "MEL_FEE_NOT_PRO_RATA" field.
        /// </summary>
        public Decimal FeeNotProRata
        {
            get { return _feeNotProRata; }
            set { _feeNotProRata = value; }
        }

        /// <summary>
        ///     the value of the "MEL_WEB_ENABLED" field.
        /// </summary>
        public Byte? WebEnabled
        {
            get { return _webEnabled; }
            set { _webEnabled = value; }
        }

        /// <summary>
        ///     the value of the "MEL_FEE_EXEMPT" field.
        /// </summary>
        public Byte FeeExempt
        {
            get { return _feeExempt; }
            set { _feeExempt = value; }
        }

        /// <summary>
        ///     the value of the "MEL_CURRENT_DATE" field.
        /// </summary>
        public DateTime? CurrentDate
        {
            get { return _currentDate; }
            set { _currentDate = value; }
        }

        /// <summary>
        ///     the value of the "MEL_CANCEL_DATE" field.
        /// </summary>
        public DateTime? CancelDate
        {
            get { return _cancelDate; }
            set { _cancelDate = value; }
        }

        /// <summary>
        ///     the value of the "MEL_PL_ID" field.
        /// </summary>
        public String PlId
        {
            get { return _plId; }
            set { _plId = value; }
        }

        /// <summary>
        ///     the value of the "MEL_DISC_ID" field.
        /// </summary>
        public Int32? DiscId
        {
            get { return _discId; }
            set { _discId = value; }
        }

        /// <summary>
        ///     the value of the "MEL_DISCOUNT" field.
        /// </summary>
        public Decimal? Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        /// <summary>
        ///     the value of the "MEL_DISCOUNT_BC" field.
        /// </summary>
        public Decimal? DiscountBc
        {
            get { return _discountBc; }
            set { _discountBc = value; }
        }

        /// <summary>
        ///     the value of the "MEL_DISCOUNT_BC2" field.
        /// </summary>
        public Decimal? DiscountBc2
        {
            get { return _discountBc2; }
            set { _discountBc2 = value; }
        }

        /// <summary>
        ///     the value of the "MEL_DISC_APPLIED_DATE" field.
        /// </summary>
        public DateTime? DiscAppliedDate
        {
            get { return _discAppliedDate; }
            set { _discAppliedDate = value; }
        }

        /// <summary>
        ///     the value of the "MEL_FEE_CALCULATED" field.
        /// </summary>
        public Byte? FeeCalculated
        {
            get { return _feeCalculated; }
            set { _feeCalculated = value; }
        }

        /// <summary>
        ///     the value of the "MEL_LIST_PRICE" field.
        /// </summary>
        public Decimal? ListPrice
        {
            get { return _listPrice; }
            set { _listPrice = value; }
        }

        /// <summary>
        ///     the value of the "MEL_LIST_PRICE_BC" field.
        /// </summary>
        public Decimal? ListPriceBc
        {
            get { return _listPriceBc; }
            set { _listPriceBc = value; }
        }

        /// <summary>
        ///     the value of the "MEL_LIST_PRICE_BC2" field.
        /// </summary>
        public Decimal? ListPriceBc2
        {
            get { return _listPriceBc2; }
            set { _listPriceBc2 = value; }
        }

        /// <summary>
        ///     the value of the "MEL_DESPATCH_DATE" field.
        /// </summary>
        public DateTime? DespatchDate
        {
            get { return _despatchDate; }
            set { _despatchDate = value; }
        }

        /// <summary>
        ///     the value of the "MEL_PO_NUMBER" field.
        /// </summary>
        public String PoNumber
        {
            get { return _poNumber; }
            set { _poNumber = value; }
        }

        /// <summary>
        ///     the value of the "MEL_QTY" field.
        /// </summary>
        public Int32? Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }

        /// <summary>
        ///     the value of the "MEL_DO_NOT_RENEW" field.
        /// </summary>
        public Byte? DoNotRenew
        {
            get { return _doNotRenew; }
            set { _doNotRenew = value; }
        }

        /// <summary>
        ///     the value of the "MEL_CANCEL_REASON" field.
        /// </summary>
        public String CancelReason
        {
            get { return _cancelReason; }
            set { _cancelReason = value; }
        }

        /// <summary>
        ///     the value of the "MEL_UNT_PRICE" field.
        /// </summary>
        public Decimal? UntPrice
        {
            get { return _untPrice; }
            set { _untPrice = value; }
        }

        /// <summary>
        ///     the value of the "MEL_UNT_PRICE_BC" field.
        /// </summary>
        public Decimal? UntPriceBc
        {
            get { return _untPriceBc; }
            set { _untPriceBc = value; }
        }

        /// <summary>
        ///     the value of the "MEL_UNT_PRICE_BC2" field.
        /// </summary>
        public Decimal? UntPriceBc2
        {
            get { return _untPriceBc2; }
            set { _untPriceBc2 = value; }
        }

        /// <summary>
        ///     the value of the "MEL_DISC_RENEWAL" field.
        /// </summary>
        public DateTime? DiscRenewal
        {
            get { return _discRenewal; }
            set { _discRenewal = value; }
        }

        /// <summary>
        ///     the value of the "MEL_PRICE_MODIFIED" field.
        /// </summary>
        public Byte PriceModified
        {
            get { return _priceModified; }
            set { _priceModified = value; }
        }

        /// <summary>
        ///     the value of the "MEL_DISC_PERCENT" field.
        /// </summary>
        public Decimal? DiscPercent
        {
            get { return _discPercent; }
            set { _discPercent = value; }
        }

        /// <summary>
        ///     the value of the "MEL_REV_CODE" field.
        /// </summary>
        public String RevCode
        {
            get { return _revCode; }
            set { _revCode = value; }
        }

        /// <summary>
        ///     the value of the "MEL_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return _costCode; }
            set { _costCode = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="MemberLocationRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="MemberLocationRecord" /> object instance.
        /// </returns>
        public MemberLocationRecord Clone()
        {
            MemberLocationRecord record = new MemberLocationRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.RcvFrom = this.RcvFrom;
            record.RcvDate = this.RcvDate;
            record.MemId = this.MemId;
            record.MepId = this.MepId;
            record.Start = this.Start;
            record.End = this.End;
            record.Status = this.Status;
            record.Type = this.Type;
            record.Fee = this.Fee;
            record.FeeBc = this.FeeBc;
            record.FeeBc2 = this.FeeBc2;
            record.Currency = this.Currency;
            record.OrgId = this.OrgId;
            record.ProleId = this.ProleId;
            record.MailAddId = this.MailAddId;
            record.MailInvId = this.MailInvId;
            record.MailToHome = this.MailToHome;
            record.RenewLoc = this.RenewLoc;
            record.Principal = this.Principal;
            record.Overseas = this.Overseas;
            record.Vatcd = this.Vatcd;
            record.Ref = this.Ref;
            record.VatRate = this.VatRate;
            record.VatAmt = this.VatAmt;
            record.VatAmtBc = this.VatAmtBc;
            record.VatAmtBc2 = this.VatAmtBc2;
            record.InvlnId = this.InvlnId;
            record.NoCopies = this.NoCopies;
            record.Invoiced = this.Invoiced;
            record.Username = this.Username;
            record.Password = this.Password;
            record.SyType = this.SyType;
            record.ProdId = this.ProdId;
            record.Current = this.Current;
            record.GrossFee = this.GrossFee;
            record.GrossFeeBc = this.GrossFeeBc;
            record.GrossFeeBc2 = this.GrossFeeBc2;
            record.DiscReason = this.DiscReason;
            record.PhoneOverride = this.PhoneOverride;
            record.FaxOverride = this.FaxOverride;
            record.PhoneStdOverride = this.PhoneStdOverride;
            record.FaxStdOverride = this.FaxStdOverride;
            record.EmailOverride = this.EmailOverride;
            record.Url = this.Url;
            record.FeeNotProRata = this.FeeNotProRata;
            record.WebEnabled = this.WebEnabled;
            record.FeeExempt = this.FeeExempt;
            record.CurrentDate = this.CurrentDate;
            record.CancelDate = this.CancelDate;
            record.PlId = this.PlId;
            record.DiscId = this.DiscId;
            record.Discount = this.Discount;
            record.DiscountBc = this.DiscountBc;
            record.DiscountBc2 = this.DiscountBc2;
            record.DiscAppliedDate = this.DiscAppliedDate;
            record.FeeCalculated = this.FeeCalculated;
            record.ListPrice = this.ListPrice;
            record.ListPriceBc = this.ListPriceBc;
            record.ListPriceBc2 = this.ListPriceBc2;
            record.DespatchDate = this.DespatchDate;
            record.PoNumber = this.PoNumber;
            record.Qty = this.Qty;
            record.DoNotRenew = this.DoNotRenew;
            record.CancelReason = this.CancelReason;
            record.UntPrice = this.UntPrice;
            record.UntPriceBc = this.UntPriceBc;
            record.UntPriceBc2 = this.UntPriceBc2;
            record.DiscRenewal = this.DiscRenewal;
            record.PriceModified = this.PriceModified;
            record.DiscPercent = this.DiscPercent;
            record.RevCode = this.RevCode;
            record.CostCode = this.CostCode;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="MemberLocationRecord" /> instance is equal to another <see cref="MemberLocationRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="MemberLocationRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(MemberLocationRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.MemId.TrimOrNullify() == that.MemId.TrimOrNullify());
            result = result && (this.MepId.TrimOrNullify() == that.MepId.TrimOrNullify());
            result = result && (this.Start == that.Start);
            result = result && (this.End == that.End);
            result = result && (this.Status == that.Status);
            result = result && (this.Type == that.Type);
            result = result && (this.Fee == that.Fee);
            result = result && (this.FeeBc == that.FeeBc);
            result = result && (this.FeeBc2 == that.FeeBc2);
            result = result && (this.Currency.TrimOrNullify() == that.Currency.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.MailAddId.TrimOrNullify() == that.MailAddId.TrimOrNullify());
            result = result && (this.MailInvId.TrimOrNullify() == that.MailInvId.TrimOrNullify());
            result = result && (this.MailToHome == that.MailToHome);
            result = result && (this.RenewLoc == that.RenewLoc);
            result = result && (this.Principal == that.Principal);
            result = result && (this.Overseas == that.Overseas);
            result = result && (this.Vatcd.TrimOrNullify() == that.Vatcd.TrimOrNullify());
            result = result && (this.Ref.TrimOrNullify() == that.Ref.TrimOrNullify());
            result = result && (this.VatRate == that.VatRate);
            result = result && (this.VatAmt == that.VatAmt);
            result = result && (this.VatAmtBc == that.VatAmtBc);
            result = result && (this.VatAmtBc2 == that.VatAmtBc2);
            result = result && (this.InvlnId.TrimOrNullify() == that.InvlnId.TrimOrNullify());
            result = result && (this.NoCopies == that.NoCopies);
            result = result && (this.Invoiced == that.Invoiced);
            result = result && (this.Username.TrimOrNullify() == that.Username.TrimOrNullify());
            result = result && (this.Password.TrimOrNullify() == that.Password.TrimOrNullify());
            result = result && (this.SyType == that.SyType);
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.Current == that.Current);
            result = result && (this.GrossFee == that.GrossFee);
            result = result && (this.GrossFeeBc == that.GrossFeeBc);
            result = result && (this.GrossFeeBc2 == that.GrossFeeBc2);
            result = result && (this.DiscReason.TrimOrNullify() == that.DiscReason.TrimOrNullify());
            result = result && (this.PhoneOverride.TrimOrNullify() == that.PhoneOverride.TrimOrNullify());
            result = result && (this.FaxOverride.TrimOrNullify() == that.FaxOverride.TrimOrNullify());
            result = result && (this.PhoneStdOverride.TrimOrNullify() == that.PhoneStdOverride.TrimOrNullify());
            result = result && (this.FaxStdOverride.TrimOrNullify() == that.FaxStdOverride.TrimOrNullify());
            result = result && (this.EmailOverride.TrimOrNullify() == that.EmailOverride.TrimOrNullify());
            result = result && (this.Url.TrimOrNullify() == that.Url.TrimOrNullify());
            result = result && (this.FeeNotProRata == that.FeeNotProRata);
            result = result && (this.WebEnabled == that.WebEnabled);
            result = result && (this.FeeExempt == that.FeeExempt);
            result = result && (this.CurrentDate == that.CurrentDate);
            result = result && (this.CancelDate == that.CancelDate);
            result = result && (this.PlId.TrimOrNullify() == that.PlId.TrimOrNullify());
            result = result && (this.DiscId == that.DiscId);
            result = result && (this.Discount == that.Discount);
            result = result && (this.DiscountBc == that.DiscountBc);
            result = result && (this.DiscountBc2 == that.DiscountBc2);
            result = result && (this.DiscAppliedDate == that.DiscAppliedDate);
            result = result && (this.FeeCalculated == that.FeeCalculated);
            result = result && (this.ListPrice == that.ListPrice);
            result = result && (this.ListPriceBc == that.ListPriceBc);
            result = result && (this.ListPriceBc2 == that.ListPriceBc2);
            result = result && (this.DespatchDate == that.DespatchDate);
            result = result && (this.PoNumber.TrimOrNullify() == that.PoNumber.TrimOrNullify());
            result = result && (this.Qty == that.Qty);
            result = result && (this.DoNotRenew == that.DoNotRenew);
            result = result && (this.CancelReason.TrimOrNullify() == that.CancelReason.TrimOrNullify());
            result = result && (this.UntPrice == that.UntPrice);
            result = result && (this.UntPriceBc == that.UntPriceBc);
            result = result && (this.UntPriceBc2 == that.UntPriceBc2);
            result = result && (this.DiscRenewal == that.DiscRenewal);
            result = result && (this.PriceModified == that.PriceModified);
            result = result && (this.DiscPercent == that.DiscPercent);
            result = result && (this.RevCode.TrimOrNullify() == that.RevCode.TrimOrNullify());
            result = result && (this.CostCode.TrimOrNullify() == that.CostCode.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
