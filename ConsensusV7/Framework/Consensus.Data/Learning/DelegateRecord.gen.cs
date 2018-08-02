using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Represents the "Delegate" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class DelegateRecord : Record<String>, Cloneable<DelegateRecord>, IEquatable<DelegateRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "DEL_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "DEL_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "DEL_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "DEL_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "DEL_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "DEL_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "DEL_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "DEL_LINE_NO" field.
        /// </summary>
        private Double? _lineNo;

        /// <summary>
        ///     the value of the "DEL_BOOK_ID" field.
        /// </summary>
        private String _bookId;

        /// <summary>
        ///     the value of the "DEL_PRODUCT_ID" field.
        /// </summary>
        private String _productId;

        /// <summary>
        ///     the value of the "DEL_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "DEL_PERSON_ID" field.
        /// </summary>
        private String _personId;

        /// <summary>
        ///     the value of the "DEL_QUANTITY" field.
        /// </summary>
        private Double? _quantity;

        /// <summary>
        ///     the value of the "DEL_LIST_PRICE" field.
        /// </summary>
        private Double? _listPrice;

        /// <summary>
        ///     the value of the "DEL_DISCOUNT" field.
        /// </summary>
        private Double? _discount;

        /// <summary>
        ///     the value of the "DEL_DISCTD_PRICE" field.
        /// </summary>
        private Double? _disctdPrice;

        /// <summary>
        ///     the value of the "DEL_NET_VAL" field.
        /// </summary>
        private Decimal _netVal;

        /// <summary>
        ///     the value of the "DEL_VAT_CODE" field.
        /// </summary>
        private String _vatCode;

        /// <summary>
        ///     the value of the "DEL_VAT_RATE" field.
        /// </summary>
        private Decimal _vatRate;

        /// <summary>
        ///     the value of the "DEL_VAT_AMT" field.
        /// </summary>
        private Decimal _vatAmt;

        /// <summary>
        ///     the value of the "DEL_TOT_PRICE" field.
        /// </summary>
        private Decimal _totPrice;

        /// <summary>
        ///     the value of the "DEL_UNION_ID" field.
        /// </summary>
        private String _unionId;

        /// <summary>
        ///     the value of the "DEL_TUC_REGION" field.
        /// </summary>
        private String _tucRegion;

        /// <summary>
        ///     the value of the "DEL_BOOK_APPROVED" field.
        /// </summary>
        private Byte? _bookApproved;

        /// <summary>
        ///     the value of the "DEL_BOOK_APPR_BY" field.
        /// </summary>
        private String _bookApprBy;

        /// <summary>
        ///     the value of the "DEL_BOOK_APPR_DATE" field.
        /// </summary>
        private DateTime? _bookApprDate;

        /// <summary>
        ///     the value of the "DEL_PACK" field.
        /// </summary>
        private String _pack;

        /// <summary>
        ///     the value of the "DEL_USERINT_1" field.
        /// </summary>
        private Byte? _userint1;

        /// <summary>
        ///     the value of the "DEL_USERINT_2" field.
        /// </summary>
        private Byte? _userint2;

        /// <summary>
        ///     the value of the "DEL_USERINT_3" field.
        /// </summary>
        private Byte? _userint3;

        /// <summary>
        ///     the value of the "DEL_USERINT_4" field.
        /// </summary>
        private Byte? _userint4;

        /// <summary>
        ///     the value of the "DEL_USERINT_5" field.
        /// </summary>
        private Byte? _userint5;

        /// <summary>
        ///     the value of the "DEL_USERINT_6" field.
        /// </summary>
        private Byte? _userint6;

        /// <summary>
        ///     the value of the "DEL_USERINT_7" field.
        /// </summary>
        private Byte? _userint7;

        /// <summary>
        ///     the value of the "DEL_USERINT_8" field.
        /// </summary>
        private Byte? _userint8;

        /// <summary>
        ///     the value of the "DEL_USERINT_9" field.
        /// </summary>
        private Byte? _userint9;

        /// <summary>
        ///     the value of the "DEL_USERINT_10" field.
        /// </summary>
        private Byte? _userint10;

        /// <summary>
        ///     the value of the "DEL_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "DEL_NOTES_ID" field.
        /// </summary>
        private String _notesId;

        /// <summary>
        ///     the value of the "DEL_WAIT_STATUS" field.
        /// </summary>
        private String _waitStatus;

        /// <summary>
        ///     the value of the "DEL_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "DEL_TIME_MVD_CUST" field.
        /// </summary>
        private Byte? _timeMvdCust;

        /// <summary>
        ///     the value of the "DEL_CANCEL_DATE" field.
        /// </summary>
        private DateTime? _cancelDate;

        /// <summary>
        ///     the value of the "DEL_CANCEL_BY" field.
        /// </summary>
        private String _cancelBy;

        /// <summary>
        ///     the value of the "DEL_REMIND_METHOD" field.
        /// </summary>
        private String _remindMethod;

        /// <summary>
        ///     the value of the "DEL_REMIND_DATE" field.
        /// </summary>
        private DateTime? _remindDate;

        /// <summary>
        ///     the value of the "DEL_REMIND_BY" field.
        /// </summary>
        private String _remindBy;

        /// <summary>
        ///     the value of the "DEL_CONFIRM_METHOD" field.
        /// </summary>
        private String _confirmMethod;

        /// <summary>
        ///     the value of the "DEL_CONFIRM_DATE" field.
        /// </summary>
        private DateTime? _confirmDate;

        /// <summary>
        ///     the value of the "DEL_CONFIRM_BY" field.
        /// </summary>
        private String _confirmBy;

        /// <summary>
        ///     the value of the "DEL_DELIV_ADDRESS" field.
        /// </summary>
        private String _delivAddress;

        /// <summary>
        ///     the value of the "DEL_DEL_ID" field.
        /// </summary>
        private String _delId;

        /// <summary>
        ///     the value of the "DEL_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "DEL_SUB_DEL_ID" field.
        /// </summary>
        private String _subDelId;

        /// <summary>
        ///     the value of the "DEL_PAY" field.
        /// </summary>
        private Byte? _pay;

        /// <summary>
        ///     the value of the "DEL_PAY2" field.
        /// </summary>
        private Byte? _pay2;

        /// <summary>
        ///     the value of the "DEL_TRN_ID" field.
        /// </summary>
        private String _trnId;

        /// <summary>
        ///     the value of the "DEL_COURSE_ID" field.
        /// </summary>
        private String _courseId;

        /// <summary>
        ///     the value of the "DEL_BUD_VAL" field.
        /// </summary>
        private Decimal? _budVal;

        /// <summary>
        ///     the value of the "DEL_BUDC_ID" field.
        /// </summary>
        private String _budcId;

        /// <summary>
        ///     the value of the "DEL_BUD_COST_ID" field.
        /// </summary>
        private String _budCostId;

        /// <summary>
        ///     the value of the "DEL_WAIT_PROD_ID" field.
        /// </summary>
        private String _waitProdId;

        /// <summary>
        ///     the value of the "DEL_WAIT_DATE" field.
        /// </summary>
        private DateTime? _waitDate;

        /// <summary>
        ///     the value of the "DEL_TEAM" field.
        /// </summary>
        private String _team;

        /// <summary>
        ///     the value of the "DEL_SPEC_REQ" field.
        /// </summary>
        private String _specReq;

        /// <summary>
        ///     the value of the "DEL_BAT_ID" field.
        /// </summary>
        private String _batId;

        /// <summary>
        ///     the value of the "DEL_BADGE_NAME" field.
        /// </summary>
        private String _badgeName;

        /// <summary>
        ///     the value of the "DEL_TOT_TKT_PNTS" field.
        /// </summary>
        private Int32? _totTktPnts;

        /// <summary>
        ///     the value of the "DEL_TCK_DEL_ID" field.
        /// </summary>
        private String _tckDelId;

        /// <summary>
        ///     the value of the "DEL_COURSE_NAME" field.
        /// </summary>
        private String _courseName;

        /// <summary>
        ///     the value of the "DEL_COURSE_ST_DATE" field.
        /// </summary>
        private DateTime? _courseStDate;

        /// <summary>
        ///     the value of the "DEL_PASS" field.
        /// </summary>
        private Byte? _pass;

        /// <summary>
        ///     the value of the "DEL_MEP_ID" field.
        /// </summary>
        private String _mepId;

        /// <summary>
        ///     the value of the "DEL_PRICE_CALC" field.
        /// </summary>
        private String _priceCalc;

        /// <summary>
        ///     the value of the "DEL_DEPOS_VAL" field.
        /// </summary>
        private Decimal? _deposVal;

        /// <summary>
        ///     the value of the "DEL_DEPOS_VAL_BC" field.
        /// </summary>
        private Decimal? _deposValBc;

        /// <summary>
        ///     the value of the "DEL_DEPOS_VAL_BC2" field.
        /// </summary>
        private Decimal? _deposValBc2;

        /// <summary>
        ///     the value of the "DEL_ALT_PHONE" field.
        /// </summary>
        private String _altPhone;

        /// <summary>
        ///     the value of the "DEL_ATTRIB01" field.
        /// </summary>
        private String _attrib01;

        /// <summary>
        ///     the value of the "DEL_ATTRIB02" field.
        /// </summary>
        private Byte? _attrib02;

        /// <summary>
        ///     the value of the "DEL_ATTRIB03" field.
        /// </summary>
        private Byte? _attrib03;

        /// <summary>
        ///     the value of the "DEL_ATTRIB04" field.
        /// </summary>
        private Byte? _attrib04;

        /// <summary>
        ///     the value of the "DEL_ATTRIB05" field.
        /// </summary>
        private String _attrib05;

        /// <summary>
        ///     the value of the "DEL_ATTRIB06" field.
        /// </summary>
        private String _attrib06;

        /// <summary>
        ///     the value of the "DEL_ATTRIB07" field.
        /// </summary>
        private Byte? _attrib07;

        /// <summary>
        ///     the value of the "DEL_ATTRIB08" field.
        /// </summary>
        private Byte? _attrib08;

        /// <summary>
        ///     the value of the "DEL_ATTRIB09" field.
        /// </summary>
        private String _attrib09;

        /// <summary>
        ///     the value of the "DEL_ATTRIB10" field.
        /// </summary>
        private String _attrib10;

        /// <summary>
        ///     the value of the "DEL_ATTRIB11" field.
        /// </summary>
        private String _attrib11;

        /// <summary>
        ///     the value of the "DEL_DEPOS_UNPAID" field.
        /// </summary>
        private Decimal? _deposUnpaid;

        /// <summary>
        ///     the value of the "DEL_DEPOS_UNPAID_BC" field.
        /// </summary>
        private Decimal? _deposUnpaidBc;

        /// <summary>
        ///     the value of the "DEL_DEPOS_UNPAID_BC2" field.
        /// </summary>
        private Decimal? _deposUnpaidBc2;

        /// <summary>
        ///     the value of the "DEL_START_DATE" field.
        /// </summary>
        private DateTime? _startDate;

        /// <summary>
        ///     the value of the "DEL_END_DATE" field.
        /// </summary>
        private DateTime? _endDate;

        /// <summary>
        ///     the value of the "DEL_DONOT_REPRICE" field.
        /// </summary>
        private Byte? _donotReprice;

        /// <summary>
        ///     the value of the "DEL_DD_PAYMENT_STAT" field.
        /// </summary>
        private String _ddPaymentStat;

        /// <summary>
        ///     the value of the "DEL_CANC_REASON" field.
        /// </summary>
        private String _cancReason;

        /// <summary>
        ///     the value of the "DEL_DEPOS_CHG_REASON" field.
        /// </summary>
        private String _deposChgReason;

        /// <summary>
        ///     the value of the "DEL_DOC_RECIPIENT" field.
        /// </summary>
        private String _docRecipient;

        /// <summary>
        ///     the value of the "DEL_ATTRIB12" field.
        /// </summary>
        private Byte? _attrib12;

        /// <summary>
        ///     the value of the "DEL_NOTES2" field.
        /// </summary>
        private String _notes2;

        /// <summary>
        ///     the value of the "DEL_DOC_RECIPIENT_EMAIL" field.
        /// </summary>
        private String _docRecipientEmail;

        /// <summary>
        ///     the value of the "DEL_ETT_ID" field.
        /// </summary>
        private String _ettId;

        /// <summary>
        ///     the value of the "DEL_TRANSFER_COUNT" field.
        /// </summary>
        private Int32? _transferCount;

        /// <summary>
        ///     the value of the "DEL_SUBSTITUTE_COUNT" field.
        /// </summary>
        private Int32? _substituteCount;

        /// <summary>
        ///     the value of the "DEL_TRANSFER_DEL_ID" field.
        /// </summary>
        private String _transferDelId;

        /// <summary>
        ///     the value of the "DEL_DIET_REQUIRE" field.
        /// </summary>
        private String _dietRequire;

        /// <summary>
        ///     the value of the "DEL_ATTRIB13" field.
        /// </summary>
        private String _attrib13;

        /// <summary>
        ///     the value of the "DEL_SURNAME" field.
        /// </summary>
        private String _surname;

        /// <summary>
        ///     the value of the "DEL_INITIAL" field.
        /// </summary>
        private String _initial;

        /// <summary>
        ///     the value of the "DEL_MEM_REF" field.
        /// </summary>
        private String _memRef;

        /// <summary>
        ///     the value of the "DEL_ADD_POSTCODE" field.
        /// </summary>
        private String _addPostcode;

        /// <summary>
        ///     the value of the "DEL_ADD_ID" field.
        /// </summary>
        private String _addId;

        /// <summary>
        ///     the value of the "DEL_WAIT_PRIORITY" field.
        /// </summary>
        private String _waitPriority;

        /// <summary>
        ///     the value of the "DEL_TBA_GENDER" field.
        /// </summary>
        private String _tbaGender;

        /// <summary>
        ///     the value of the "DEL_TBA_NATIONALITY" field.
        /// </summary>
        private String _tbaNationality;

        /// <summary>
        ///     the value of the "DEL_TBA_ETHNICITY" field.
        /// </summary>
        private String _tbaEthnicity;

        /// <summary>
        ///     the value of the "DEL_CANCEL_REF" field.
        /// </summary>
        private String _cancelRef;

        /// <summary>
        ///     the value of the "DEL_SHARE_DETAILS" field.
        /// </summary>
        private Byte? _shareDetails;

        /// <summary>
        ///     the value of the "DEL_AUTH_STATUS" field.
        /// </summary>
        private Int32? _authStatus;

        /// <summary>
        ///     the value of the "DEL_MEDICAL_DET" field.
        /// </summary>
        private String _medicalDet;

        /// <summary>
        ///     the value of the "DEL_DELIV_COUNTRY_ID" field.
        /// </summary>
        private String _delivCountryId;

        /// <summary>
        ///     the value of the "DEL_DELIV_FAO" field.
        /// </summary>
        private String _delivFao;

        /// <summary>
        ///     the value of the "DEL_DELIV_PHONE" field.
        /// </summary>
        private String _delivPhone;

        /// <summary>
        ///     the value of the "DEL_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "DEL_USERCHAR_2" field.
        /// </summary>
        private String _userchar2;

        /// <summary>
        ///     the value of the "DEL_EXCL_TOKEN" field.
        /// </summary>
        private Byte _exclToken;

        /// <summary>
        ///     the value of the "DEL_FIRST_NAME" field.
        /// </summary>
        private String _firstName;

        /// <summary>
        ///     the value of the "DEL_NI_NUMBER" field.
        /// </summary>
        private String _niNumber;

        /// <summary>
        ///     the value of the "DEL_UNIQUE_REF" field.
        /// </summary>
        private String _uniqueRef;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "DEL_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "DEL_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "DEL_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "DEL_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "DEL_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "DEL_LINE_NO" field.
        /// </summary>
        public Double? LineNo
        {
            get { return _lineNo; }
            set { _lineNo = value; }
        }

        /// <summary>
        ///     the value of the "DEL_BOOK_ID" field.
        /// </summary>
        public String BookId
        {
            get { return _bookId; }
            set { _bookId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_PRODUCT_ID" field.
        /// </summary>
        public String ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_PERSON_ID" field.
        /// </summary>
        public String PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_QUANTITY" field.
        /// </summary>
        public Double? Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        /// <summary>
        ///     the value of the "DEL_LIST_PRICE" field.
        /// </summary>
        public Double? ListPrice
        {
            get { return _listPrice; }
            set { _listPrice = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DISCOUNT" field.
        /// </summary>
        public Double? Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DISCTD_PRICE" field.
        /// </summary>
        public Double? DisctdPrice
        {
            get { return _disctdPrice; }
            set { _disctdPrice = value; }
        }

        /// <summary>
        ///     the value of the "DEL_NET_VAL" field.
        /// </summary>
        public Decimal NetVal
        {
            get { return _netVal; }
            set { _netVal = value; }
        }

        /// <summary>
        ///     the value of the "DEL_VAT_CODE" field.
        /// </summary>
        public String VatCode
        {
            get { return _vatCode; }
            set { _vatCode = value; }
        }

        /// <summary>
        ///     the value of the "DEL_VAT_RATE" field.
        /// </summary>
        public Decimal VatRate
        {
            get { return _vatRate; }
            set { _vatRate = value; }
        }

        /// <summary>
        ///     the value of the "DEL_VAT_AMT" field.
        /// </summary>
        public Decimal VatAmt
        {
            get { return _vatAmt; }
            set { _vatAmt = value; }
        }

        /// <summary>
        ///     the value of the "DEL_TOT_PRICE" field.
        /// </summary>
        public Decimal TotPrice
        {
            get { return _totPrice; }
            set { _totPrice = value; }
        }

        /// <summary>
        ///     the value of the "DEL_UNION_ID" field.
        /// </summary>
        public String UnionId
        {
            get { return _unionId; }
            set { _unionId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_TUC_REGION" field.
        /// </summary>
        public String TucRegion
        {
            get { return _tucRegion; }
            set { _tucRegion = value; }
        }

        /// <summary>
        ///     the value of the "DEL_BOOK_APPROVED" field.
        /// </summary>
        public Byte? BookApproved
        {
            get { return _bookApproved; }
            set { _bookApproved = value; }
        }

        /// <summary>
        ///     the value of the "DEL_BOOK_APPR_BY" field.
        /// </summary>
        public String BookApprBy
        {
            get { return _bookApprBy; }
            set { _bookApprBy = value; }
        }

        /// <summary>
        ///     the value of the "DEL_BOOK_APPR_DATE" field.
        /// </summary>
        public DateTime? BookApprDate
        {
            get { return _bookApprDate; }
            set { _bookApprDate = value; }
        }

        /// <summary>
        ///     the value of the "DEL_PACK" field.
        /// </summary>
        public String Pack
        {
            get { return _pack; }
            set { _pack = value; }
        }

        /// <summary>
        ///     the value of the "DEL_USERINT_1" field.
        /// </summary>
        public Byte? Userint1
        {
            get { return _userint1; }
            set { _userint1 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_USERINT_2" field.
        /// </summary>
        public Byte? Userint2
        {
            get { return _userint2; }
            set { _userint2 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_USERINT_3" field.
        /// </summary>
        public Byte? Userint3
        {
            get { return _userint3; }
            set { _userint3 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_USERINT_4" field.
        /// </summary>
        public Byte? Userint4
        {
            get { return _userint4; }
            set { _userint4 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_USERINT_5" field.
        /// </summary>
        public Byte? Userint5
        {
            get { return _userint5; }
            set { _userint5 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_USERINT_6" field.
        /// </summary>
        public Byte? Userint6
        {
            get { return _userint6; }
            set { _userint6 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_USERINT_7" field.
        /// </summary>
        public Byte? Userint7
        {
            get { return _userint7; }
            set { _userint7 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_USERINT_8" field.
        /// </summary>
        public Byte? Userint8
        {
            get { return _userint8; }
            set { _userint8 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_USERINT_9" field.
        /// </summary>
        public Byte? Userint9
        {
            get { return _userint9; }
            set { _userint9 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_USERINT_10" field.
        /// </summary>
        public Byte? Userint10
        {
            get { return _userint10; }
            set { _userint10 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_NOTES_ID" field.
        /// </summary>
        public String NotesId
        {
            get { return _notesId; }
            set { _notesId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_WAIT_STATUS" field.
        /// </summary>
        public String WaitStatus
        {
            get { return _waitStatus; }
            set { _waitStatus = value; }
        }

        /// <summary>
        ///     the value of the "DEL_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "DEL_TIME_MVD_CUST" field.
        /// </summary>
        public Byte? TimeMvdCust
        {
            get { return _timeMvdCust; }
            set { _timeMvdCust = value; }
        }

        /// <summary>
        ///     the value of the "DEL_CANCEL_DATE" field.
        /// </summary>
        public DateTime? CancelDate
        {
            get { return _cancelDate; }
            set { _cancelDate = value; }
        }

        /// <summary>
        ///     the value of the "DEL_CANCEL_BY" field.
        /// </summary>
        public String CancelBy
        {
            get { return _cancelBy; }
            set { _cancelBy = value; }
        }

        /// <summary>
        ///     the value of the "DEL_REMIND_METHOD" field.
        /// </summary>
        public String RemindMethod
        {
            get { return _remindMethod; }
            set { _remindMethod = value; }
        }

        /// <summary>
        ///     the value of the "DEL_REMIND_DATE" field.
        /// </summary>
        public DateTime? RemindDate
        {
            get { return _remindDate; }
            set { _remindDate = value; }
        }

        /// <summary>
        ///     the value of the "DEL_REMIND_BY" field.
        /// </summary>
        public String RemindBy
        {
            get { return _remindBy; }
            set { _remindBy = value; }
        }

        /// <summary>
        ///     the value of the "DEL_CONFIRM_METHOD" field.
        /// </summary>
        public String ConfirmMethod
        {
            get { return _confirmMethod; }
            set { _confirmMethod = value; }
        }

        /// <summary>
        ///     the value of the "DEL_CONFIRM_DATE" field.
        /// </summary>
        public DateTime? ConfirmDate
        {
            get { return _confirmDate; }
            set { _confirmDate = value; }
        }

        /// <summary>
        ///     the value of the "DEL_CONFIRM_BY" field.
        /// </summary>
        public String ConfirmBy
        {
            get { return _confirmBy; }
            set { _confirmBy = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DELIV_ADDRESS" field.
        /// </summary>
        public String DelivAddress
        {
            get { return _delivAddress; }
            set { _delivAddress = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DEL_ID" field.
        /// </summary>
        public String DelId
        {
            get { return _delId; }
            set { _delId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_SUB_DEL_ID" field.
        /// </summary>
        public String SubDelId
        {
            get { return _subDelId; }
            set { _subDelId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_PAY" field.
        /// </summary>
        public Byte? Pay
        {
            get { return _pay; }
            set { _pay = value; }
        }

        /// <summary>
        ///     the value of the "DEL_PAY2" field.
        /// </summary>
        public Byte? Pay2
        {
            get { return _pay2; }
            set { _pay2 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_TRN_ID" field.
        /// </summary>
        public String TrnId
        {
            get { return _trnId; }
            set { _trnId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_COURSE_ID" field.
        /// </summary>
        public String CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_BUD_VAL" field.
        /// </summary>
        public Decimal? BudVal
        {
            get { return _budVal; }
            set { _budVal = value; }
        }

        /// <summary>
        ///     the value of the "DEL_BUDC_ID" field.
        /// </summary>
        public String BudcId
        {
            get { return _budcId; }
            set { _budcId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_BUD_COST_ID" field.
        /// </summary>
        public String BudCostId
        {
            get { return _budCostId; }
            set { _budCostId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_WAIT_PROD_ID" field.
        /// </summary>
        public String WaitProdId
        {
            get { return _waitProdId; }
            set { _waitProdId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_WAIT_DATE" field.
        /// </summary>
        public DateTime? WaitDate
        {
            get { return _waitDate; }
            set { _waitDate = value; }
        }

        /// <summary>
        ///     the value of the "DEL_TEAM" field.
        /// </summary>
        public String Team
        {
            get { return _team; }
            set { _team = value; }
        }

        /// <summary>
        ///     the value of the "DEL_SPEC_REQ" field.
        /// </summary>
        public String SpecReq
        {
            get { return _specReq; }
            set { _specReq = value; }
        }

        /// <summary>
        ///     the value of the "DEL_BAT_ID" field.
        /// </summary>
        public String BatId
        {
            get { return _batId; }
            set { _batId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_BADGE_NAME" field.
        /// </summary>
        public String BadgeName
        {
            get { return _badgeName; }
            set { _badgeName = value; }
        }

        /// <summary>
        ///     the value of the "DEL_TOT_TKT_PNTS" field.
        /// </summary>
        public Int32? TotTktPnts
        {
            get { return _totTktPnts; }
            set { _totTktPnts = value; }
        }

        /// <summary>
        ///     the value of the "DEL_TCK_DEL_ID" field.
        /// </summary>
        public String TckDelId
        {
            get { return _tckDelId; }
            set { _tckDelId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_COURSE_NAME" field.
        /// </summary>
        public String CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }

        /// <summary>
        ///     the value of the "DEL_COURSE_ST_DATE" field.
        /// </summary>
        public DateTime? CourseStDate
        {
            get { return _courseStDate; }
            set { _courseStDate = value; }
        }

        /// <summary>
        ///     the value of the "DEL_PASS" field.
        /// </summary>
        public Byte? Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }

        /// <summary>
        ///     the value of the "DEL_MEP_ID" field.
        /// </summary>
        public String MepId
        {
            get { return _mepId; }
            set { _mepId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_PRICE_CALC" field.
        /// </summary>
        public String PriceCalc
        {
            get { return _priceCalc; }
            set { _priceCalc = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DEPOS_VAL" field.
        /// </summary>
        public Decimal? DeposVal
        {
            get { return _deposVal; }
            set { _deposVal = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DEPOS_VAL_BC" field.
        /// </summary>
        public Decimal? DeposValBc
        {
            get { return _deposValBc; }
            set { _deposValBc = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DEPOS_VAL_BC2" field.
        /// </summary>
        public Decimal? DeposValBc2
        {
            get { return _deposValBc2; }
            set { _deposValBc2 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ALT_PHONE" field.
        /// </summary>
        public String AltPhone
        {
            get { return _altPhone; }
            set { _altPhone = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ATTRIB01" field.
        /// </summary>
        public String Attrib01
        {
            get { return _attrib01; }
            set { _attrib01 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ATTRIB02" field.
        /// </summary>
        public Byte? Attrib02
        {
            get { return _attrib02; }
            set { _attrib02 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ATTRIB03" field.
        /// </summary>
        public Byte? Attrib03
        {
            get { return _attrib03; }
            set { _attrib03 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ATTRIB04" field.
        /// </summary>
        public Byte? Attrib04
        {
            get { return _attrib04; }
            set { _attrib04 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ATTRIB05" field.
        /// </summary>
        public String Attrib05
        {
            get { return _attrib05; }
            set { _attrib05 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ATTRIB06" field.
        /// </summary>
        public String Attrib06
        {
            get { return _attrib06; }
            set { _attrib06 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ATTRIB07" field.
        /// </summary>
        public Byte? Attrib07
        {
            get { return _attrib07; }
            set { _attrib07 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ATTRIB08" field.
        /// </summary>
        public Byte? Attrib08
        {
            get { return _attrib08; }
            set { _attrib08 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ATTRIB09" field.
        /// </summary>
        public String Attrib09
        {
            get { return _attrib09; }
            set { _attrib09 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ATTRIB10" field.
        /// </summary>
        public String Attrib10
        {
            get { return _attrib10; }
            set { _attrib10 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ATTRIB11" field.
        /// </summary>
        public String Attrib11
        {
            get { return _attrib11; }
            set { _attrib11 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DEPOS_UNPAID" field.
        /// </summary>
        public Decimal? DeposUnpaid
        {
            get { return _deposUnpaid; }
            set { _deposUnpaid = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DEPOS_UNPAID_BC" field.
        /// </summary>
        public Decimal? DeposUnpaidBc
        {
            get { return _deposUnpaidBc; }
            set { _deposUnpaidBc = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DEPOS_UNPAID_BC2" field.
        /// </summary>
        public Decimal? DeposUnpaidBc2
        {
            get { return _deposUnpaidBc2; }
            set { _deposUnpaidBc2 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        ///     the value of the "DEL_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DONOT_REPRICE" field.
        /// </summary>
        public Byte? DonotReprice
        {
            get { return _donotReprice; }
            set { _donotReprice = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DD_PAYMENT_STAT" field.
        /// </summary>
        public String DdPaymentStat
        {
            get { return _ddPaymentStat; }
            set { _ddPaymentStat = value; }
        }

        /// <summary>
        ///     the value of the "DEL_CANC_REASON" field.
        /// </summary>
        public String CancReason
        {
            get { return _cancReason; }
            set { _cancReason = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DEPOS_CHG_REASON" field.
        /// </summary>
        public String DeposChgReason
        {
            get { return _deposChgReason; }
            set { _deposChgReason = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DOC_RECIPIENT" field.
        /// </summary>
        public String DocRecipient
        {
            get { return _docRecipient; }
            set { _docRecipient = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ATTRIB12" field.
        /// </summary>
        public Byte? Attrib12
        {
            get { return _attrib12; }
            set { _attrib12 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_NOTES2" field.
        /// </summary>
        public String Notes2
        {
            get { return _notes2; }
            set { _notes2 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DOC_RECIPIENT_EMAIL" field.
        /// </summary>
        public String DocRecipientEmail
        {
            get { return _docRecipientEmail; }
            set { _docRecipientEmail = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ETT_ID" field.
        /// </summary>
        public String EttId
        {
            get { return _ettId; }
            set { _ettId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_TRANSFER_COUNT" field.
        /// </summary>
        public Int32? TransferCount
        {
            get { return _transferCount; }
            set { _transferCount = value; }
        }

        /// <summary>
        ///     the value of the "DEL_SUBSTITUTE_COUNT" field.
        /// </summary>
        public Int32? SubstituteCount
        {
            get { return _substituteCount; }
            set { _substituteCount = value; }
        }

        /// <summary>
        ///     the value of the "DEL_TRANSFER_DEL_ID" field.
        /// </summary>
        public String TransferDelId
        {
            get { return _transferDelId; }
            set { _transferDelId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DIET_REQUIRE" field.
        /// </summary>
        public String DietRequire
        {
            get { return _dietRequire; }
            set { _dietRequire = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ATTRIB13" field.
        /// </summary>
        public String Attrib13
        {
            get { return _attrib13; }
            set { _attrib13 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_SURNAME" field.
        /// </summary>
        public String Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        /// <summary>
        ///     the value of the "DEL_INITIAL" field.
        /// </summary>
        public String Initial
        {
            get { return _initial; }
            set { _initial = value; }
        }

        /// <summary>
        ///     the value of the "DEL_MEM_REF" field.
        /// </summary>
        public String MemRef
        {
            get { return _memRef; }
            set { _memRef = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ADD_POSTCODE" field.
        /// </summary>
        public String AddPostcode
        {
            get { return _addPostcode; }
            set { _addPostcode = value; }
        }

        /// <summary>
        ///     the value of the "DEL_ADD_ID" field.
        /// </summary>
        public String AddId
        {
            get { return _addId; }
            set { _addId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_WAIT_PRIORITY" field.
        /// </summary>
        public String WaitPriority
        {
            get { return _waitPriority; }
            set { _waitPriority = value; }
        }

        /// <summary>
        ///     the value of the "DEL_TBA_GENDER" field.
        /// </summary>
        public String TbaGender
        {
            get { return _tbaGender; }
            set { _tbaGender = value; }
        }

        /// <summary>
        ///     the value of the "DEL_TBA_NATIONALITY" field.
        /// </summary>
        public String TbaNationality
        {
            get { return _tbaNationality; }
            set { _tbaNationality = value; }
        }

        /// <summary>
        ///     the value of the "DEL_TBA_ETHNICITY" field.
        /// </summary>
        public String TbaEthnicity
        {
            get { return _tbaEthnicity; }
            set { _tbaEthnicity = value; }
        }

        /// <summary>
        ///     the value of the "DEL_CANCEL_REF" field.
        /// </summary>
        public String CancelRef
        {
            get { return _cancelRef; }
            set { _cancelRef = value; }
        }

        /// <summary>
        ///     the value of the "DEL_SHARE_DETAILS" field.
        /// </summary>
        public Byte? ShareDetails
        {
            get { return _shareDetails; }
            set { _shareDetails = value; }
        }

        /// <summary>
        ///     the value of the "DEL_AUTH_STATUS" field.
        /// </summary>
        public Int32? AuthStatus
        {
            get { return _authStatus; }
            set { _authStatus = value; }
        }

        /// <summary>
        ///     the value of the "DEL_MEDICAL_DET" field.
        /// </summary>
        public String MedicalDet
        {
            get { return _medicalDet; }
            set { _medicalDet = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DELIV_COUNTRY_ID" field.
        /// </summary>
        public String DelivCountryId
        {
            get { return _delivCountryId; }
            set { _delivCountryId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DELIV_FAO" field.
        /// </summary>
        public String DelivFao
        {
            get { return _delivFao; }
            set { _delivFao = value; }
        }

        /// <summary>
        ///     the value of the "DEL_DELIV_PHONE" field.
        /// </summary>
        public String DelivPhone
        {
            get { return _delivPhone; }
            set { _delivPhone = value; }
        }

        /// <summary>
        ///     the value of the "DEL_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "DEL_USERCHAR_2" field.
        /// </summary>
        public String Userchar2
        {
            get { return _userchar2; }
            set { _userchar2 = value; }
        }

        /// <summary>
        ///     the value of the "DEL_EXCL_TOKEN" field.
        /// </summary>
        public Byte ExclToken
        {
            get { return _exclToken; }
            set { _exclToken = value; }
        }

        /// <summary>
        ///     the value of the "DEL_FIRST_NAME" field.
        /// </summary>
        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        /// <summary>
        ///     the value of the "DEL_NI_NUMBER" field.
        /// </summary>
        public String NiNumber
        {
            get { return _niNumber; }
            set { _niNumber = value; }
        }

        /// <summary>
        ///     the value of the "DEL_UNIQUE_REF" field.
        /// </summary>
        public String UniqueRef
        {
            get { return _uniqueRef; }
            set { _uniqueRef = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="DelegateRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="DelegateRecord" /> object instance.
        /// </returns>
        public DelegateRecord Clone()
        {
            DelegateRecord record = new DelegateRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.LineNo = this.LineNo;
            record.BookId = this.BookId;
            record.ProductId = this.ProductId;
            record.OrgId = this.OrgId;
            record.PersonId = this.PersonId;
            record.Quantity = this.Quantity;
            record.ListPrice = this.ListPrice;
            record.Discount = this.Discount;
            record.DisctdPrice = this.DisctdPrice;
            record.NetVal = this.NetVal;
            record.VatCode = this.VatCode;
            record.VatRate = this.VatRate;
            record.VatAmt = this.VatAmt;
            record.TotPrice = this.TotPrice;
            record.UnionId = this.UnionId;
            record.TucRegion = this.TucRegion;
            record.BookApproved = this.BookApproved;
            record.BookApprBy = this.BookApprBy;
            record.BookApprDate = this.BookApprDate;
            record.Pack = this.Pack;
            record.Userint1 = this.Userint1;
            record.Userint2 = this.Userint2;
            record.Userint3 = this.Userint3;
            record.Userint4 = this.Userint4;
            record.Userint5 = this.Userint5;
            record.Userint6 = this.Userint6;
            record.Userint7 = this.Userint7;
            record.Userint8 = this.Userint8;
            record.Userint9 = this.Userint9;
            record.Userint10 = this.Userint10;
            record.ProleId = this.ProleId;
            record.NotesId = this.NotesId;
            record.WaitStatus = this.WaitStatus;
            record.Notes = this.Notes;
            record.TimeMvdCust = this.TimeMvdCust;
            record.CancelDate = this.CancelDate;
            record.CancelBy = this.CancelBy;
            record.RemindMethod = this.RemindMethod;
            record.RemindDate = this.RemindDate;
            record.RemindBy = this.RemindBy;
            record.ConfirmMethod = this.ConfirmMethod;
            record.ConfirmDate = this.ConfirmDate;
            record.ConfirmBy = this.ConfirmBy;
            record.DelivAddress = this.DelivAddress;
            record.DelId = this.DelId;
            record.Userchar1 = this.Userchar1;
            record.SubDelId = this.SubDelId;
            record.Pay = this.Pay;
            record.Pay2 = this.Pay2;
            record.TrnId = this.TrnId;
            record.CourseId = this.CourseId;
            record.BudVal = this.BudVal;
            record.BudcId = this.BudcId;
            record.BudCostId = this.BudCostId;
            record.WaitProdId = this.WaitProdId;
            record.WaitDate = this.WaitDate;
            record.Team = this.Team;
            record.SpecReq = this.SpecReq;
            record.BatId = this.BatId;
            record.BadgeName = this.BadgeName;
            record.TotTktPnts = this.TotTktPnts;
            record.TckDelId = this.TckDelId;
            record.CourseName = this.CourseName;
            record.CourseStDate = this.CourseStDate;
            record.Pass = this.Pass;
            record.MepId = this.MepId;
            record.PriceCalc = this.PriceCalc;
            record.DeposVal = this.DeposVal;
            record.DeposValBc = this.DeposValBc;
            record.DeposValBc2 = this.DeposValBc2;
            record.AltPhone = this.AltPhone;
            record.Attrib01 = this.Attrib01;
            record.Attrib02 = this.Attrib02;
            record.Attrib03 = this.Attrib03;
            record.Attrib04 = this.Attrib04;
            record.Attrib05 = this.Attrib05;
            record.Attrib06 = this.Attrib06;
            record.Attrib07 = this.Attrib07;
            record.Attrib08 = this.Attrib08;
            record.Attrib09 = this.Attrib09;
            record.Attrib10 = this.Attrib10;
            record.Attrib11 = this.Attrib11;
            record.DeposUnpaid = this.DeposUnpaid;
            record.DeposUnpaidBc = this.DeposUnpaidBc;
            record.DeposUnpaidBc2 = this.DeposUnpaidBc2;
            record.StartDate = this.StartDate;
            record.EndDate = this.EndDate;
            record.DonotReprice = this.DonotReprice;
            record.DdPaymentStat = this.DdPaymentStat;
            record.CancReason = this.CancReason;
            record.DeposChgReason = this.DeposChgReason;
            record.DocRecipient = this.DocRecipient;
            record.Attrib12 = this.Attrib12;
            record.Notes2 = this.Notes2;
            record.DocRecipientEmail = this.DocRecipientEmail;
            record.EttId = this.EttId;
            record.TransferCount = this.TransferCount;
            record.SubstituteCount = this.SubstituteCount;
            record.TransferDelId = this.TransferDelId;
            record.DietRequire = this.DietRequire;
            record.Attrib13 = this.Attrib13;
            record.Surname = this.Surname;
            record.Initial = this.Initial;
            record.MemRef = this.MemRef;
            record.AddPostcode = this.AddPostcode;
            record.AddId = this.AddId;
            record.WaitPriority = this.WaitPriority;
            record.TbaGender = this.TbaGender;
            record.TbaNationality = this.TbaNationality;
            record.TbaEthnicity = this.TbaEthnicity;
            record.CancelRef = this.CancelRef;
            record.ShareDetails = this.ShareDetails;
            record.AuthStatus = this.AuthStatus;
            record.MedicalDet = this.MedicalDet;
            record.DelivCountryId = this.DelivCountryId;
            record.DelivFao = this.DelivFao;
            record.DelivPhone = this.DelivPhone;
            record.SelcoSpId = this.SelcoSpId;
            record.Userchar2 = this.Userchar2;
            record.ExclToken = this.ExclToken;
            record.FirstName = this.FirstName;
            record.NiNumber = this.NiNumber;
            record.UniqueRef = this.UniqueRef;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="DelegateRecord" /> instance is equal to another <see cref="DelegateRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="DelegateRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(DelegateRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.LineNo == that.LineNo);
            result = result && (this.BookId.TrimOrNullify() == that.BookId.TrimOrNullify());
            result = result && (this.ProductId.TrimOrNullify() == that.ProductId.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.PersonId.TrimOrNullify() == that.PersonId.TrimOrNullify());
            result = result && (this.Quantity == that.Quantity);
            result = result && (this.ListPrice == that.ListPrice);
            result = result && (this.Discount == that.Discount);
            result = result && (this.DisctdPrice == that.DisctdPrice);
            result = result && (this.NetVal == that.NetVal);
            result = result && (this.VatCode.TrimOrNullify() == that.VatCode.TrimOrNullify());
            result = result && (this.VatRate == that.VatRate);
            result = result && (this.VatAmt == that.VatAmt);
            result = result && (this.TotPrice == that.TotPrice);
            result = result && (this.UnionId.TrimOrNullify() == that.UnionId.TrimOrNullify());
            result = result && (this.TucRegion.TrimOrNullify() == that.TucRegion.TrimOrNullify());
            result = result && (this.BookApproved == that.BookApproved);
            result = result && (this.BookApprBy.TrimOrNullify() == that.BookApprBy.TrimOrNullify());
            result = result && (this.BookApprDate == that.BookApprDate);
            result = result && (this.Pack.TrimOrNullify() == that.Pack.TrimOrNullify());
            result = result && (this.Userint1 == that.Userint1);
            result = result && (this.Userint2 == that.Userint2);
            result = result && (this.Userint3 == that.Userint3);
            result = result && (this.Userint4 == that.Userint4);
            result = result && (this.Userint5 == that.Userint5);
            result = result && (this.Userint6 == that.Userint6);
            result = result && (this.Userint7 == that.Userint7);
            result = result && (this.Userint8 == that.Userint8);
            result = result && (this.Userint9 == that.Userint9);
            result = result && (this.Userint10 == that.Userint10);
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.NotesId.TrimOrNullify() == that.NotesId.TrimOrNullify());
            result = result && (this.WaitStatus.TrimOrNullify() == that.WaitStatus.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.TimeMvdCust == that.TimeMvdCust);
            result = result && (this.CancelDate == that.CancelDate);
            result = result && (this.CancelBy.TrimOrNullify() == that.CancelBy.TrimOrNullify());
            result = result && (this.RemindMethod.TrimOrNullify() == that.RemindMethod.TrimOrNullify());
            result = result && (this.RemindDate == that.RemindDate);
            result = result && (this.RemindBy.TrimOrNullify() == that.RemindBy.TrimOrNullify());
            result = result && (this.ConfirmMethod.TrimOrNullify() == that.ConfirmMethod.TrimOrNullify());
            result = result && (this.ConfirmDate == that.ConfirmDate);
            result = result && (this.ConfirmBy.TrimOrNullify() == that.ConfirmBy.TrimOrNullify());
            result = result && (this.DelivAddress.TrimOrNullify() == that.DelivAddress.TrimOrNullify());
            result = result && (this.DelId.TrimOrNullify() == that.DelId.TrimOrNullify());
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.SubDelId.TrimOrNullify() == that.SubDelId.TrimOrNullify());
            result = result && (this.Pay == that.Pay);
            result = result && (this.Pay2 == that.Pay2);
            result = result && (this.TrnId.TrimOrNullify() == that.TrnId.TrimOrNullify());
            result = result && (this.CourseId.TrimOrNullify() == that.CourseId.TrimOrNullify());
            result = result && (this.BudVal == that.BudVal);
            result = result && (this.BudcId.TrimOrNullify() == that.BudcId.TrimOrNullify());
            result = result && (this.BudCostId.TrimOrNullify() == that.BudCostId.TrimOrNullify());
            result = result && (this.WaitProdId.TrimOrNullify() == that.WaitProdId.TrimOrNullify());
            result = result && (this.WaitDate == that.WaitDate);
            result = result && (this.Team.TrimOrNullify() == that.Team.TrimOrNullify());
            result = result && (this.SpecReq.TrimOrNullify() == that.SpecReq.TrimOrNullify());
            result = result && (this.BatId.TrimOrNullify() == that.BatId.TrimOrNullify());
            result = result && (this.BadgeName.TrimOrNullify() == that.BadgeName.TrimOrNullify());
            result = result && (this.TotTktPnts == that.TotTktPnts);
            result = result && (this.TckDelId.TrimOrNullify() == that.TckDelId.TrimOrNullify());
            result = result && (this.CourseName.TrimOrNullify() == that.CourseName.TrimOrNullify());
            result = result && (this.CourseStDate == that.CourseStDate);
            result = result && (this.Pass == that.Pass);
            result = result && (this.MepId.TrimOrNullify() == that.MepId.TrimOrNullify());
            result = result && (this.PriceCalc.TrimOrNullify() == that.PriceCalc.TrimOrNullify());
            result = result && (this.DeposVal == that.DeposVal);
            result = result && (this.DeposValBc == that.DeposValBc);
            result = result && (this.DeposValBc2 == that.DeposValBc2);
            result = result && (this.AltPhone.TrimOrNullify() == that.AltPhone.TrimOrNullify());
            result = result && (this.Attrib01.TrimOrNullify() == that.Attrib01.TrimOrNullify());
            result = result && (this.Attrib02 == that.Attrib02);
            result = result && (this.Attrib03 == that.Attrib03);
            result = result && (this.Attrib04 == that.Attrib04);
            result = result && (this.Attrib05.TrimOrNullify() == that.Attrib05.TrimOrNullify());
            result = result && (this.Attrib06.TrimOrNullify() == that.Attrib06.TrimOrNullify());
            result = result && (this.Attrib07 == that.Attrib07);
            result = result && (this.Attrib08 == that.Attrib08);
            result = result && (this.Attrib09.TrimOrNullify() == that.Attrib09.TrimOrNullify());
            result = result && (this.Attrib10.TrimOrNullify() == that.Attrib10.TrimOrNullify());
            result = result && (this.Attrib11.TrimOrNullify() == that.Attrib11.TrimOrNullify());
            result = result && (this.DeposUnpaid == that.DeposUnpaid);
            result = result && (this.DeposUnpaidBc == that.DeposUnpaidBc);
            result = result && (this.DeposUnpaidBc2 == that.DeposUnpaidBc2);
            result = result && (this.StartDate == that.StartDate);
            result = result && (this.EndDate == that.EndDate);
            result = result && (this.DonotReprice == that.DonotReprice);
            result = result && (this.DdPaymentStat.TrimOrNullify() == that.DdPaymentStat.TrimOrNullify());
            result = result && (this.CancReason.TrimOrNullify() == that.CancReason.TrimOrNullify());
            result = result && (this.DeposChgReason.TrimOrNullify() == that.DeposChgReason.TrimOrNullify());
            result = result && (this.DocRecipient.TrimOrNullify() == that.DocRecipient.TrimOrNullify());
            result = result && (this.Attrib12 == that.Attrib12);
            result = result && (this.Notes2.TrimOrNullify() == that.Notes2.TrimOrNullify());
            result = result && (this.DocRecipientEmail.TrimOrNullify() == that.DocRecipientEmail.TrimOrNullify());
            result = result && (this.EttId.TrimOrNullify() == that.EttId.TrimOrNullify());
            result = result && (this.TransferCount == that.TransferCount);
            result = result && (this.SubstituteCount == that.SubstituteCount);
            result = result && (this.TransferDelId.TrimOrNullify() == that.TransferDelId.TrimOrNullify());
            result = result && (this.DietRequire.TrimOrNullify() == that.DietRequire.TrimOrNullify());
            result = result && (this.Attrib13.TrimOrNullify() == that.Attrib13.TrimOrNullify());
            result = result && (this.Surname.TrimOrNullify() == that.Surname.TrimOrNullify());
            result = result && (this.Initial.TrimOrNullify() == that.Initial.TrimOrNullify());
            result = result && (this.MemRef.TrimOrNullify() == that.MemRef.TrimOrNullify());
            result = result && (this.AddPostcode.TrimOrNullify() == that.AddPostcode.TrimOrNullify());
            result = result && (this.AddId.TrimOrNullify() == that.AddId.TrimOrNullify());
            result = result && (this.WaitPriority.TrimOrNullify() == that.WaitPriority.TrimOrNullify());
            result = result && (this.TbaGender.TrimOrNullify() == that.TbaGender.TrimOrNullify());
            result = result && (this.TbaNationality.TrimOrNullify() == that.TbaNationality.TrimOrNullify());
            result = result && (this.TbaEthnicity.TrimOrNullify() == that.TbaEthnicity.TrimOrNullify());
            result = result && (this.CancelRef.TrimOrNullify() == that.CancelRef.TrimOrNullify());
            result = result && (this.ShareDetails == that.ShareDetails);
            result = result && (this.AuthStatus == that.AuthStatus);
            result = result && (this.MedicalDet.TrimOrNullify() == that.MedicalDet.TrimOrNullify());
            result = result && (this.DelivCountryId.TrimOrNullify() == that.DelivCountryId.TrimOrNullify());
            result = result && (this.DelivFao.TrimOrNullify() == that.DelivFao.TrimOrNullify());
            result = result && (this.DelivPhone.TrimOrNullify() == that.DelivPhone.TrimOrNullify());
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.Userchar2.TrimOrNullify() == that.Userchar2.TrimOrNullify());
            result = result && (this.ExclToken == that.ExclToken);
            result = result && (this.FirstName.TrimOrNullify() == that.FirstName.TrimOrNullify());
            result = result && (this.NiNumber.TrimOrNullify() == that.NiNumber.TrimOrNullify());
            result = result && (this.UniqueRef.TrimOrNullify() == that.UniqueRef.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
