using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Represents the "Booking" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class BookingRecord : Record<String>, Cloneable<BookingRecord>, IEquatable<BookingRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "BOOK_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "BOOK_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "BOOK_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "BOOK_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "BOOK_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "BOOK_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "BOOK_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "BOOK_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "BOOK_PERSON_ID" field.
        /// </summary>
        private String _personId;

        /// <summary>
        ///     the value of the "BOOK_COURSE_ID" field.
        /// </summary>
        private String _courseId;

        /// <summary>
        ///     the value of the "BOOK_SALESMAN" field.
        /// </summary>
        private String _salesman;

        /// <summary>
        ///     the value of the "BOOK_INV_ID" field.
        /// </summary>
        private String _invId;

        /// <summary>
        ///     the value of the "BOOK_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "BOOK_STATUS_DATE" field.
        /// </summary>
        private DateTime? _statusDate;

        /// <summary>
        ///     the value of the "BOOK_ORDER_DATE" field.
        /// </summary>
        private DateTime? _orderDate;

        /// <summary>
        ///     the value of the "BOOK_DLVRY_DATE" field.
        /// </summary>
        private DateTime? _dlvryDate;

        /// <summary>
        ///     the value of the "BOOK_DLVRY_REF" field.
        /// </summary>
        private String _dlvryRef;

        /// <summary>
        ///     the value of the "BOOK_CARRIER" field.
        /// </summary>
        private String _carrier;

        /// <summary>
        ///     the value of the "BOOK_CUST_ORD_NO" field.
        /// </summary>
        private String _custOrdNo;

        /// <summary>
        ///     the value of the "BOOK_ORDER_TYPE" field.
        /// </summary>
        private String _orderType;

        /// <summary>
        ///     the value of the "BOOK_INV_STATUS" field.
        /// </summary>
        private String _invStatus;

        /// <summary>
        ///     the value of the "BOOK_INV_ADD" field.
        /// </summary>
        private String _invAdd;

        /// <summary>
        ///     the value of the "BOOK_DLVRY_ADD" field.
        /// </summary>
        private String _dlvryAdd;

        /// <summary>
        ///     the value of the "BOOK_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "BOOK_NET_TOTAL" field.
        /// </summary>
        private Decimal _netTotal;

        /// <summary>
        ///     the value of the "BOOK_VAT_TOTAL" field.
        /// </summary>
        private Decimal _vatTotal;

        /// <summary>
        ///     the value of the "BOOK_GROSS_TOTAL" field.
        /// </summary>
        private Decimal _grossTotal;

        /// <summary>
        ///     the value of the "BOOK_PLACES" field.
        /// </summary>
        private Double? _places;

        /// <summary>
        ///     the value of the "BOOK_PROV_LETTER" field.
        /// </summary>
        private DateTime? _provLetter;

        /// <summary>
        ///     the value of the "BOOK_CONFIRMED" field.
        /// </summary>
        private DateTime? _confirmed;

        /// <summary>
        ///     the value of the "BOOK_JOIN_PACK" field.
        /// </summary>
        private DateTime? _joinPack;

        /// <summary>
        ///     the value of the "BOOK_PAID_DATE" field.
        /// </summary>
        private DateTime? _paidDate;

        /// <summary>
        ///     the value of the "BOOK_UNION_ID" field.
        /// </summary>
        private String _unionId;

        /// <summary>
        ///     the value of the "BOOK_TUC_REGION" field.
        /// </summary>
        private String _tucRegion;

        /// <summary>
        ///     the value of the "BOOK_APPROVED" field.
        /// </summary>
        private Byte? _approved;

        /// <summary>
        ///     the value of the "BOOK_APPROVED_BY" field.
        /// </summary>
        private String _approvedBy;

        /// <summary>
        ///     the value of the "BOOK_APPROVE_DATE" field.
        /// </summary>
        private DateTime? _approveDate;

        /// <summary>
        ///     the value of the "BOOK_TIMING_FLAG" field.
        /// </summary>
        private Byte? _timingFlag;

        /// <summary>
        ///     the value of the "BOOK_ARCH_FLAG" field.
        /// </summary>
        private Byte? _archFlag;

        /// <summary>
        ///     the value of the "BOOK_BOOKING_METHD" field.
        /// </summary>
        private String _bookingMethd;

        /// <summary>
        ///     the value of the "BOOK_PAYMENT_METHD" field.
        /// </summary>
        private String _paymentMethd;

        /// <summary>
        ///     the value of the "BOOK_SOURCE_CODE" field.
        /// </summary>
        private String _sourceCode;

        /// <summary>
        ///     the value of the "BOOK_NET_TOTAL_ADJ" field.
        /// </summary>
        private Decimal _netTotalAdj;

        /// <summary>
        ///     the value of the "BOOK_DATE_PAID" field.
        /// </summary>
        private DateTime? _datePaid;

        /// <summary>
        ///     the value of the "BOOK_TIMES_MOVED" field.
        /// </summary>
        private Byte? _timesMoved;

        /// <summary>
        ///     the value of the "BOOK_CORS_MVD_FROM" field.
        /// </summary>
        private String _corsMvdFrom;

        /// <summary>
        ///     the value of the "BOOK_STUDENT_PRICE" field.
        /// </summary>
        private Decimal _studentPrice;

        /// <summary>
        ///     the value of the "BOOK_ADJUST_VATCD" field.
        /// </summary>
        private String _adjustVatcd;

        /// <summary>
        ///     the value of the "BOOK_ADJUST_DESCRP" field.
        /// </summary>
        private String _adjustDescrp;

        /// <summary>
        ///     the value of the "BOOK_CONF_SENT_DTE" field.
        /// </summary>
        private DateTime? _confSentDte;

        /// <summary>
        ///     the value of the "BOOK_JOIN_SENT_DTE" field.
        /// </summary>
        private DateTime? _joinSentDte;

        /// <summary>
        ///     the value of the "BOOK_TIME_MVD_CUST" field.
        /// </summary>
        private Byte? _timeMvdCust;

        /// <summary>
        ///     the value of the "BOOK_CORS_MVD_CUST" field.
        /// </summary>
        private String _corsMvdCust;

        /// <summary>
        ///     the value of the "BOOK_PROV_SENT_DTE" field.
        /// </summary>
        private DateTime? _provSentDte;

        /// <summary>
        ///     the value of the "BOOK_INV_ORG_ID" field.
        /// </summary>
        private String _invOrgId;

        /// <summary>
        ///     the value of the "BOOK_INV_EXT_NOTES" field.
        /// </summary>
        private String _invExtNotes;

        /// <summary>
        ///     the value of the "BOOK_INVOICED" field.
        /// </summary>
        private Byte? _invoiced;

        /// <summary>
        ///     the value of the "BOOK_FOR_ATTN_OF" field.
        /// </summary>
        private String _forAttnOf;

        /// <summary>
        ///     the value of the "BOOK_DO_NOT_INVOIC" field.
        /// </summary>
        private Byte? _doNotInvoic;

        /// <summary>
        ///     the value of the "BOOK_MSTC_ID" field.
        /// </summary>
        private String _mstcId;

        /// <summary>
        ///     the value of the "BOOK_BAT_ID" field.
        /// </summary>
        private String _batId;

        /// <summary>
        ///     the value of the "BOOK_BAT_ID2" field.
        /// </summary>
        private String _batId2;

        /// <summary>
        ///     the value of the "BOOK_BLOCK_PRICED" field.
        /// </summary>
        private Byte? _blockPriced;

        /// <summary>
        ///     the value of the "BOOK_PL_ID" field.
        /// </summary>
        private String _plId;

        /// <summary>
        ///     the value of the "BOOK_BLOCK_PRICE" field.
        /// </summary>
        private Double? _blockPrice;

        /// <summary>
        ///     the value of the "BOOK_INCOM_CODE" field.
        /// </summary>
        private String _incomCode;

        /// <summary>
        ///     the value of the "BOOK_EXPEND_CODE" field.
        /// </summary>
        private String _expendCode;

        /// <summary>
        ///     the value of the "BOOK_PRODUCT_GROUP" field.
        /// </summary>
        private String _productGroup;

        /// <summary>
        ///     the value of the "BOOK_REASON" field.
        /// </summary>
        private String _reason;

        /// <summary>
        ///     the value of the "BOOK_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "BOOK_CCARD_ID" field.
        /// </summary>
        private String _ccardId;

        /// <summary>
        ///     the value of the "BOOK_PROV_PACK" field.
        /// </summary>
        private String _provPack;

        /// <summary>
        ///     the value of the "BOOK_CONF_PACK" field.
        /// </summary>
        private String _confPack;

        /// <summary>
        ///     the value of the "BOOK_JOINING_PACK" field.
        /// </summary>
        private String _joiningPack;

        /// <summary>
        ///     the value of the "BOOK_POST_PACK" field.
        /// </summary>
        private String _postPack;

        /// <summary>
        ///     the value of the "BOOK_PROV_TO_BOOK" field.
        /// </summary>
        private Byte? _provToBook;

        /// <summary>
        ///     the value of the "BOOK_PROV_TO_DEL" field.
        /// </summary>
        private Byte? _provToDel;

        /// <summary>
        ///     the value of the "BOOK_CONF_TO_BOOK" field.
        /// </summary>
        private Byte? _confToBook;

        /// <summary>
        ///     the value of the "BOOK_CONF_TO_DEL" field.
        /// </summary>
        private Byte? _confToDel;

        /// <summary>
        ///     the value of the "BOOK_JOIN_TO_BOOK" field.
        /// </summary>
        private Byte? _joinToBook;

        /// <summary>
        ///     the value of the "BOOK_JOIN_TO_DEL" field.
        /// </summary>
        private Byte? _joinToDel;

        /// <summary>
        ///     the value of the "BOOK_POST_TO_BOOK" field.
        /// </summary>
        private Byte? _postToBook;

        /// <summary>
        ///     the value of the "BOOK_POST_TO_DEL" field.
        /// </summary>
        private Byte? _postToDel;

        /// <summary>
        ///     the value of the "BOOK_PAID" field.
        /// </summary>
        private Byte? _paid;

        /// <summary>
        ///     the value of the "BOOK_PROV_INV" field.
        /// </summary>
        private Byte? _provInv;

        /// <summary>
        ///     the value of the "BOOK_CONF_INV" field.
        /// </summary>
        private Byte? _confInv;

        /// <summary>
        ///     the value of the "BOOK_JOIN_INV" field.
        /// </summary>
        private Byte? _joinInv;

        /// <summary>
        ///     the value of the "BOOK_POST_INV" field.
        /// </summary>
        private Byte? _postInv;

        /// <summary>
        ///     the value of the "BOOK_PERIOD" field.
        /// </summary>
        private String _period;

        /// <summary>
        ///     the value of the "BOOK_USERCHAR_2" field.
        /// </summary>
        private String _userchar2;

        /// <summary>
        ///     the value of the "BOOK_CANCEL_DATE" field.
        /// </summary>
        private DateTime? _cancelDate;

        /// <summary>
        ///     the value of the "BOOK_CANCEL_BY" field.
        /// </summary>
        private String _cancelBy;

        /// <summary>
        ///     the value of the "BOOK_PP_SENT_DTE" field.
        /// </summary>
        private DateTime? _ppSentDte;

        /// <summary>
        ///     the value of the "BOOK_BU_ID" field.
        /// </summary>
        private String _buId;

        /// <summary>
        ///     the value of the "BOOK_OPP_ID" field.
        /// </summary>
        private String _oppId;

        /// <summary>
        ///     the value of the "BOOK_CRYSTAL_INV" field.
        /// </summary>
        private String _crystalInv;

        /// <summary>
        ///     the value of the "BOOK_QUO_ID" field.
        /// </summary>
        private String _quoId;

        /// <summary>
        ///     the value of the "BOOK_DISC_METHOD" field.
        /// </summary>
        private Byte? _discMethod;

        /// <summary>
        ///     the value of the "BOOK_DELIV_ADD" field.
        /// </summary>
        private String _delivAdd;

        /// <summary>
        ///     the value of the "BOOK_DOCS_METHOD" field.
        /// </summary>
        private String _docsMethod;

        /// <summary>
        ///     the value of the "BOOK_DUE_DATE" field.
        /// </summary>
        private DateTime? _dueDate;

        /// <summary>
        ///     the value of the "BOOK_SALES_MAN" field.
        /// </summary>
        private String _salesMan;

        /// <summary>
        ///     the value of the "BOOK_SOP_SENT_DTE" field.
        /// </summary>
        private DateTime? _sopSentDte;

        /// <summary>
        ///     the value of the "BOOK_SOP_STATUS" field.
        /// </summary>
        private String _sopStatus;

        /// <summary>
        ///     the value of the "BOOK_SOP_NOTES" field.
        /// </summary>
        private String _sopNotes;

        /// <summary>
        ///     the value of the "BOOK_SOP_IN_DTE" field.
        /// </summary>
        private DateTime? _sopInDte;

        /// <summary>
        ///     the value of the "BOOK_SOP_REF" field.
        /// </summary>
        private String _sopRef;

        /// <summary>
        ///     the value of the "BOOK_SOP_INV_REF" field.
        /// </summary>
        private String _sopInvRef;

        /// <summary>
        ///     the value of the "BOOK_DISC_VALUE" field.
        /// </summary>
        private Byte? _discValue;

        /// <summary>
        ///     the value of the "BOOK_PRINT_LOG" field.
        /// </summary>
        private String _printLog;

        /// <summary>
        ///     the value of the "BOOK_CANC_REASON" field.
        /// </summary>
        private String _cancReason;

        /// <summary>
        ///     the value of the "BOOK_SOP_REL_DTE" field.
        /// </summary>
        private DateTime? _sopRelDte;

        /// <summary>
        ///     the value of the "BOOK_SOP_INT_1" field.
        /// </summary>
        private Int32? _sopInt1;

        /// <summary>
        ///     the value of the "BOOK_USERCHAR_3" field.
        /// </summary>
        private String _userchar3;

        /// <summary>
        ///     the value of the "BOOK_USER_DATE_1" field.
        /// </summary>
        private DateTime? _userDate1;

        /// <summary>
        ///     the value of the "BOOK_USER_DATE_2" field.
        /// </summary>
        private DateTime? _userDate2;

        /// <summary>
        ///     the value of the "BOOK_USER_DATE_3" field.
        /// </summary>
        private DateTime? _userDate3;

        /// <summary>
        ///     the value of the "BOOK_MULTI_LANG" field.
        /// </summary>
        private Byte? _multiLang;

        /// <summary>
        ///     the value of the "BOOK_APPROVER1_ID" field.
        /// </summary>
        private String _approver1Id;

        /// <summary>
        ///     the value of the "BOOK_APPROVER2_ID" field.
        /// </summary>
        private String _approver2Id;

        /// <summary>
        ///     the value of the "BOOK_APPROVER3_ID" field.
        /// </summary>
        private String _approver3Id;

        /// <summary>
        ///     the value of the "BOOK_NOMINATOR_ID" field.
        /// </summary>
        private String _nominatorId;

        /// <summary>
        ///     the value of the "BOOK_APPROVER1_DOC" field.
        /// </summary>
        private String _approver1Doc;

        /// <summary>
        ///     the value of the "BOOK_APPROVER2_DOC" field.
        /// </summary>
        private String _approver2Doc;

        /// <summary>
        ///     the value of the "BOOK_APPROVER3_DOC" field.
        /// </summary>
        private String _approver3Doc;

        /// <summary>
        ///     the value of the "BOOK_NOMINATOR_DOC" field.
        /// </summary>
        private String _nominatorDoc;

        /// <summary>
        ///     the value of the "BOOK_ECUST_ID" field.
        /// </summary>
        private String _ecustId;

        /// <summary>
        ///     the value of the "BOOK_ECUST_00" field.
        /// </summary>
        private String _ecust00;

        /// <summary>
        ///     the value of the "BOOK_ECUST_01" field.
        /// </summary>
        private String _ecust01;

        /// <summary>
        ///     the value of the "BOOK_ECUST_02" field.
        /// </summary>
        private String _ecust02;

        /// <summary>
        ///     the value of the "BOOK_ECUST_03" field.
        /// </summary>
        private String _ecust03;

        /// <summary>
        ///     the value of the "BOOK_ECUST_04" field.
        /// </summary>
        private String _ecust04;

        /// <summary>
        ///     the value of the "BOOK_ECUST_05" field.
        /// </summary>
        private String _ecust05;

        /// <summary>
        ///     the value of the "BOOK_ECUST_06" field.
        /// </summary>
        private String _ecust06;

        /// <summary>
        ///     the value of the "BOOK_ECUST_07" field.
        /// </summary>
        private String _ecust07;

        /// <summary>
        ///     the value of the "BOOK_ECUST_08" field.
        /// </summary>
        private String _ecust08;

        /// <summary>
        ///     the value of the "BOOK_ECUST_09" field.
        /// </summary>
        private String _ecust09;

        /// <summary>
        ///     the value of the "BOOK_CURRENCY_TYPE" field.
        /// </summary>
        private String _currencyType;

        /// <summary>
        ///     the value of the "BOOK_CURR_RATE_BC" field.
        /// </summary>
        private Decimal _currRateBc;

        /// <summary>
        ///     the value of the "BOOK_CURR_RATE_BC2" field.
        /// </summary>
        private Decimal _currRateBc2;

        /// <summary>
        ///     the value of the "BOOK_APPROVER4_ID" field.
        /// </summary>
        private String _approver4Id;

        /// <summary>
        ///     the value of the "BOOK_REJECT1_ID" field.
        /// </summary>
        private String _reject1Id;

        /// <summary>
        ///     the value of the "BOOK_REJECT2_ID" field.
        /// </summary>
        private String _reject2Id;

        /// <summary>
        ///     the value of the "BOOK_REJECT3_ID" field.
        /// </summary>
        private String _reject3Id;

        /// <summary>
        ///     the value of the "BOOK_REJECT4_ID" field.
        /// </summary>
        private String _reject4Id;

        /// <summary>
        ///     the value of the "BOOK_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "BOOK_ADD_ID" field.
        /// </summary>
        private String _addId;

        /// <summary>
        ///     the value of the "BOOK_APPREJ1_EMAIL" field.
        /// </summary>
        private String _apprej1Email;

        /// <summary>
        ///     the value of the "BOOK_APPREJ2_EMAIL" field.
        /// </summary>
        private String _apprej2Email;

        /// <summary>
        ///     the value of the "BOOK_APPREJ3_EMAIL" field.
        /// </summary>
        private String _apprej3Email;

        /// <summary>
        ///     the value of the "BOOK_APPREJ4_EMAIL" field.
        /// </summary>
        private String _apprej4Email;

        /// <summary>
        ///     the value of the "BOOK_APPREJ1_DATE" field.
        /// </summary>
        private DateTime? _apprej1Date;

        /// <summary>
        ///     the value of the "BOOK_APPREJ2_DATE" field.
        /// </summary>
        private DateTime? _apprej2Date;

        /// <summary>
        ///     the value of the "BOOK_APPREJ3_DATE" field.
        /// </summary>
        private DateTime? _apprej3Date;

        /// <summary>
        ///     the value of the "BOOK_APPREJ4_DATE" field.
        /// </summary>
        private DateTime? _apprej4Date;

        /// <summary>
        ///     the value of the "BOOK_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "BOOK_VATCD_OVRRIDE" field.
        /// </summary>
        private String _vatcdOvrride;

        /// <summary>
        ///     the value of the "BOOK_ORG_CUST_AC" field.
        /// </summary>
        private String _orgCustAc;

        /// <summary>
        ///     the value of the "BOOK_USER_DATE_4" field.
        /// </summary>
        private DateTime? _userDate4;

        /// <summary>
        ///     the value of the "BOOK_USER_DATE_5" field.
        /// </summary>
        private DateTime? _userDate5;

        /// <summary>
        ///     the value of the "BOOK_USER_DATE_6" field.
        /// </summary>
        private DateTime? _userDate6;

        /// <summary>
        ///     the value of the "BOOK_USERCHAR_4" field.
        /// </summary>
        private String _userchar4;

        /// <summary>
        ///     the value of the "BOOK_USERCHAR_5" field.
        /// </summary>
        private String _userchar5;

        /// <summary>
        ///     the value of the "BOOK_USERCHAR_6" field.
        /// </summary>
        private String _userchar6;

        /// <summary>
        ///     the value of the "BOOK_USER_TINT_1" field.
        /// </summary>
        private Byte? _userTint1;

        /// <summary>
        ///     the value of the "BOOK_USER_TINT_2" field.
        /// </summary>
        private Byte? _userTint2;

        /// <summary>
        ///     the value of the "BOOK_USER_TINT_3" field.
        /// </summary>
        private Byte? _userTint3;

        /// <summary>
        ///     the value of the "BOOK_USER_TINT_4" field.
        /// </summary>
        private Byte? _userTint4;

        /// <summary>
        ///     the value of the "BOOK_USER_TINT_5" field.
        /// </summary>
        private Byte? _userTint5;

        /// <summary>
        ///     the value of the "BOOK_USER_TINT_6" field.
        /// </summary>
        private Byte? _userTint6;

        /// <summary>
        ///     the value of the "BOOK_DELIV_FAO" field.
        /// </summary>
        private String _delivFao;

        /// <summary>
        ///     the value of the "BOOK_DELIV_PHONE" field.
        /// </summary>
        private String _delivPhone;

        /// <summary>
        ///     the value of the "BOOK_INV_PROLE_ID" field.
        /// </summary>
        private String _invProleId;

        /// <summary>
        ///     the value of the "BOOK_INV_TYPE" field.
        /// </summary>
        private Byte? _invType;

        /// <summary>
        ///     the value of the "BOOK_CHARGE_TYPE" field.
        /// </summary>
        private String _chargeType;

        /// <summary>
        ///     the value of the "BOOK_DEPOSIT_TOT" field.
        /// </summary>
        private Decimal? _depositTot;

        /// <summary>
        ///     the value of the "BOOK_DEPOSIT_PAID" field.
        /// </summary>
        private Decimal? _depositPaid;

        /// <summary>
        ///     the value of the "BOOK_SCHN_ID" field.
        /// </summary>
        private String _schnId;

        /// <summary>
        ///     the value of the "BOOK_SY_TYPE" field.
        /// </summary>
        private Byte? _syType;

        /// <summary>
        ///     the value of the "BOOK_PRJOIN_SENT_DTE" field.
        /// </summary>
        private DateTime? _prjoinSentDte;

        /// <summary>
        ///     the value of the "BOOK_POJOIN_SENT_DTE" field.
        /// </summary>
        private DateTime? _pojoinSentDte;

        /// <summary>
        ///     the value of the "BOOK_PREJOIN_PACK" field.
        /// </summary>
        private String _prejoinPack;

        /// <summary>
        ///     the value of the "BOOK_PSTJOIN_PACK" field.
        /// </summary>
        private String _pstjoinPack;

        /// <summary>
        ///     the value of the "BOOK_PREJOIN_TO_BOOK" field.
        /// </summary>
        private Byte? _prejoinToBook;

        /// <summary>
        ///     the value of the "BOOK_PREJOIN_TO_DEL" field.
        /// </summary>
        private Byte? _prejoinToDel;

        /// <summary>
        ///     the value of the "BOOK_PSTJOIN_TO_BOOK" field.
        /// </summary>
        private Byte? _pstjoinToBook;

        /// <summary>
        ///     the value of the "BOOK_PSTJOIN_TO_DEL" field.
        /// </summary>
        private Byte? _pstjoinToDel;

        /// <summary>
        ///     the value of the "BOOK_NET_TOTAL_BC" field.
        /// </summary>
        private Decimal _netTotalBc;

        /// <summary>
        ///     the value of the "BOOK_NET_TOTAL_BC2" field.
        /// </summary>
        private Decimal _netTotalBc2;

        /// <summary>
        ///     the value of the "BOOK_TERMS_ACC_BY" field.
        /// </summary>
        private String _termsAccBy;

        /// <summary>
        ///     the value of the "BOOK_INVOICE_RULE" field.
        /// </summary>
        private Byte _invoiceRule;

        /// <summary>
        ///     the value of the "BOOK_INVOICE_RULE_OFFSET" field.
        /// </summary>
        private Int16 _invoiceRuleOffset;

        /// <summary>
        ///     the value of the "BOOK_DO_NOT_INVOICE_REASON" field.
        /// </summary>
        private String _doNotInvoiceReason;

        /// <summary>
        ///     the value of the "BOOK_INVOICE_OFFSET_TYPE" field.
        /// </summary>
        private String _invoiceOffsetType;

        /// <summary>
        ///     the value of the "BOOK_INVOICE_WHEN_STATUS" field.
        /// </summary>
        private String _invoiceWhenStatus;

        /// <summary>
        ///     the value of the "BOOK_INVOICE_MUST_USE_RULE" field.
        /// </summary>
        private Byte _invoiceMustUseRule;

        /// <summary>
        ///     the value of the "BOOK_INVOICE_CONSOLIDATE" field.
        /// </summary>
        private Byte _invoiceConsolidate;

        /// <summary>
        ///     the value of the "BOOK_INVOICE_FORMAT" field.
        /// </summary>
        private Byte _invoiceFormat;

        /// <summary>
        ///     the value of the "BOOK_INVOICE_FORMAT_0_TEXT" field.
        /// </summary>
        private String _invoiceFormat0Text;

        /// <summary>
        ///     the value of the "BOOK_INVOICE_FORMAT_1_TEXT" field.
        /// </summary>
        private String _invoiceFormat1Text;

        /// <summary>
        ///     the value of the "BOOK_ACC_ID" field.
        /// </summary>
        private String _accId;

        /// <summary>
        ///     the value of the "BOOK_RESV_TO_DATE" field.
        /// </summary>
        private DateTime? _resvToDate;

        /// <summary>
        ///     the value of the "BOOK_AGT_ID" field.
        /// </summary>
        private Int32? _agtId;

        /// <summary>
        ///     the value of the "BOOK_AGT_ORG_ID" field.
        /// </summary>
        private String _agtOrgId;

        /// <summary>
        ///     the value of the "BOOK_AGT_TYPE" field.
        /// </summary>
        private String _agtType;

        /// <summary>
        ///     the value of the "BOOK_AGT_COMMISSION" field.
        /// </summary>
        private Decimal? _agtCommission;

        /// <summary>
        ///     the value of the "BOOK_INVOICE_PER_DEL" field.
        /// </summary>
        private Byte _invoicePerDel;

        /// <summary>
        ///     the value of the "BOOK_MANAGED" field.
        /// </summary>
        private Byte? _managed;

        /// <summary>
        ///     the value of the "BOOK_CANCEL_REF" field.
        /// </summary>
        private String _cancelRef;

        /// <summary>
        ///     the value of the "BOOK_INVOICE_PER_PERSON" field.
        /// </summary>
        private Byte _invoicePerPerson;

        /// <summary>
        ///     the value of the "BOOK_PROFORMA" field.
        /// </summary>
        private Byte? _proforma;

        /// <summary>
        ///     the value of the "BOOK_CART_ID" field.
        /// </summary>
        private Int32? _cartId;

        /// <summary>
        ///     the value of the "BOOK_PS_ID" field.
        /// </summary>
        private Int32? _psId;

        /// <summary>
        ///     the value of the "BOOK_PROMO_CODE" field.
        /// </summary>
        private String _promoCode;

        /// <summary>
        ///     the value of the "BOOK_CUST_BR_INF" field.
        /// </summary>
        private String _custBrInf;

        /// <summary>
        ///     the value of the "BOOK_CONF_SENT_OFFLINE_DATE" field.
        /// </summary>
        private DateTime? _confSentOfflineDate;

        /// <summary>
        ///     the value of the "BOOK_USERNUM_1" field.
        /// </summary>
        private Decimal? _usernum1;

        /// <summary>
        ///     the value of the "BOOK_USERNUM_2" field.
        /// </summary>
        private Decimal? _usernum2;

        /// <summary>
        ///     the value of the "BOOK_USERNUM_3" field.
        /// </summary>
        private Decimal? _usernum3;

        /// <summary>
        ///     the value of the "BOOK_USERNUM_4" field.
        /// </summary>
        private Decimal? _usernum4;

        /// <summary>
        ///     the value of the "BOOK_USERNUM_5" field.
        /// </summary>
        private Decimal? _usernum5;

        /// <summary>
        ///     the value of the "BOOK_USERNUM_6" field.
        /// </summary>
        private Decimal? _usernum6;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "BOOK_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PERSON_ID" field.
        /// </summary>
        public String PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_COURSE_ID" field.
        /// </summary>
        public String CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_SALESMAN" field.
        /// </summary>
        public String Salesman
        {
            get { return _salesman; }
            set { _salesman = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INV_ID" field.
        /// </summary>
        public String InvId
        {
            get { return _invId; }
            set { _invId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_STATUS_DATE" field.
        /// </summary>
        public DateTime? StatusDate
        {
            get { return _statusDate; }
            set { _statusDate = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ORDER_DATE" field.
        /// </summary>
        public DateTime? OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_DLVRY_DATE" field.
        /// </summary>
        public DateTime? DlvryDate
        {
            get { return _dlvryDate; }
            set { _dlvryDate = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_DLVRY_REF" field.
        /// </summary>
        public String DlvryRef
        {
            get { return _dlvryRef; }
            set { _dlvryRef = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CARRIER" field.
        /// </summary>
        public String Carrier
        {
            get { return _carrier; }
            set { _carrier = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CUST_ORD_NO" field.
        /// </summary>
        public String CustOrdNo
        {
            get { return _custOrdNo; }
            set { _custOrdNo = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ORDER_TYPE" field.
        /// </summary>
        public String OrderType
        {
            get { return _orderType; }
            set { _orderType = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INV_STATUS" field.
        /// </summary>
        public String InvStatus
        {
            get { return _invStatus; }
            set { _invStatus = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INV_ADD" field.
        /// </summary>
        public String InvAdd
        {
            get { return _invAdd; }
            set { _invAdd = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_DLVRY_ADD" field.
        /// </summary>
        public String DlvryAdd
        {
            get { return _dlvryAdd; }
            set { _dlvryAdd = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_NET_TOTAL" field.
        /// </summary>
        public Decimal NetTotal
        {
            get { return _netTotal; }
            set { _netTotal = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_VAT_TOTAL" field.
        /// </summary>
        public Decimal VatTotal
        {
            get { return _vatTotal; }
            set { _vatTotal = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_GROSS_TOTAL" field.
        /// </summary>
        public Decimal GrossTotal
        {
            get { return _grossTotal; }
            set { _grossTotal = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PLACES" field.
        /// </summary>
        public Double? Places
        {
            get { return _places; }
            set { _places = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PROV_LETTER" field.
        /// </summary>
        public DateTime? ProvLetter
        {
            get { return _provLetter; }
            set { _provLetter = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CONFIRMED" field.
        /// </summary>
        public DateTime? Confirmed
        {
            get { return _confirmed; }
            set { _confirmed = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_JOIN_PACK" field.
        /// </summary>
        public DateTime? JoinPack
        {
            get { return _joinPack; }
            set { _joinPack = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PAID_DATE" field.
        /// </summary>
        public DateTime? PaidDate
        {
            get { return _paidDate; }
            set { _paidDate = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_UNION_ID" field.
        /// </summary>
        public String UnionId
        {
            get { return _unionId; }
            set { _unionId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_TUC_REGION" field.
        /// </summary>
        public String TucRegion
        {
            get { return _tucRegion; }
            set { _tucRegion = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPROVED" field.
        /// </summary>
        public Byte? Approved
        {
            get { return _approved; }
            set { _approved = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPROVED_BY" field.
        /// </summary>
        public String ApprovedBy
        {
            get { return _approvedBy; }
            set { _approvedBy = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPROVE_DATE" field.
        /// </summary>
        public DateTime? ApproveDate
        {
            get { return _approveDate; }
            set { _approveDate = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_TIMING_FLAG" field.
        /// </summary>
        public Byte? TimingFlag
        {
            get { return _timingFlag; }
            set { _timingFlag = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ARCH_FLAG" field.
        /// </summary>
        public Byte? ArchFlag
        {
            get { return _archFlag; }
            set { _archFlag = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_BOOKING_METHD" field.
        /// </summary>
        public String BookingMethd
        {
            get { return _bookingMethd; }
            set { _bookingMethd = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PAYMENT_METHD" field.
        /// </summary>
        public String PaymentMethd
        {
            get { return _paymentMethd; }
            set { _paymentMethd = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_SOURCE_CODE" field.
        /// </summary>
        public String SourceCode
        {
            get { return _sourceCode; }
            set { _sourceCode = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_NET_TOTAL_ADJ" field.
        /// </summary>
        public Decimal NetTotalAdj
        {
            get { return _netTotalAdj; }
            set { _netTotalAdj = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_DATE_PAID" field.
        /// </summary>
        public DateTime? DatePaid
        {
            get { return _datePaid; }
            set { _datePaid = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_TIMES_MOVED" field.
        /// </summary>
        public Byte? TimesMoved
        {
            get { return _timesMoved; }
            set { _timesMoved = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CORS_MVD_FROM" field.
        /// </summary>
        public String CorsMvdFrom
        {
            get { return _corsMvdFrom; }
            set { _corsMvdFrom = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_STUDENT_PRICE" field.
        /// </summary>
        public Decimal StudentPrice
        {
            get { return _studentPrice; }
            set { _studentPrice = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ADJUST_VATCD" field.
        /// </summary>
        public String AdjustVatcd
        {
            get { return _adjustVatcd; }
            set { _adjustVatcd = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ADJUST_DESCRP" field.
        /// </summary>
        public String AdjustDescrp
        {
            get { return _adjustDescrp; }
            set { _adjustDescrp = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CONF_SENT_DTE" field.
        /// </summary>
        public DateTime? ConfSentDte
        {
            get { return _confSentDte; }
            set { _confSentDte = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_JOIN_SENT_DTE" field.
        /// </summary>
        public DateTime? JoinSentDte
        {
            get { return _joinSentDte; }
            set { _joinSentDte = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_TIME_MVD_CUST" field.
        /// </summary>
        public Byte? TimeMvdCust
        {
            get { return _timeMvdCust; }
            set { _timeMvdCust = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CORS_MVD_CUST" field.
        /// </summary>
        public String CorsMvdCust
        {
            get { return _corsMvdCust; }
            set { _corsMvdCust = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PROV_SENT_DTE" field.
        /// </summary>
        public DateTime? ProvSentDte
        {
            get { return _provSentDte; }
            set { _provSentDte = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INV_ORG_ID" field.
        /// </summary>
        public String InvOrgId
        {
            get { return _invOrgId; }
            set { _invOrgId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INV_EXT_NOTES" field.
        /// </summary>
        public String InvExtNotes
        {
            get { return _invExtNotes; }
            set { _invExtNotes = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INVOICED" field.
        /// </summary>
        public Byte? Invoiced
        {
            get { return _invoiced; }
            set { _invoiced = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_FOR_ATTN_OF" field.
        /// </summary>
        public String ForAttnOf
        {
            get { return _forAttnOf; }
            set { _forAttnOf = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_DO_NOT_INVOIC" field.
        /// </summary>
        public Byte? DoNotInvoic
        {
            get { return _doNotInvoic; }
            set { _doNotInvoic = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_MSTC_ID" field.
        /// </summary>
        public String MstcId
        {
            get { return _mstcId; }
            set { _mstcId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_BAT_ID" field.
        /// </summary>
        public String BatId
        {
            get { return _batId; }
            set { _batId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_BAT_ID2" field.
        /// </summary>
        public String BatId2
        {
            get { return _batId2; }
            set { _batId2 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_BLOCK_PRICED" field.
        /// </summary>
        public Byte? BlockPriced
        {
            get { return _blockPriced; }
            set { _blockPriced = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PL_ID" field.
        /// </summary>
        public String PlId
        {
            get { return _plId; }
            set { _plId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_BLOCK_PRICE" field.
        /// </summary>
        public Double? BlockPrice
        {
            get { return _blockPrice; }
            set { _blockPrice = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INCOM_CODE" field.
        /// </summary>
        public String IncomCode
        {
            get { return _incomCode; }
            set { _incomCode = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_EXPEND_CODE" field.
        /// </summary>
        public String ExpendCode
        {
            get { return _expendCode; }
            set { _expendCode = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PRODUCT_GROUP" field.
        /// </summary>
        public String ProductGroup
        {
            get { return _productGroup; }
            set { _productGroup = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_REASON" field.
        /// </summary>
        public String Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CCARD_ID" field.
        /// </summary>
        public String CcardId
        {
            get { return _ccardId; }
            set { _ccardId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PROV_PACK" field.
        /// </summary>
        public String ProvPack
        {
            get { return _provPack; }
            set { _provPack = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CONF_PACK" field.
        /// </summary>
        public String ConfPack
        {
            get { return _confPack; }
            set { _confPack = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_JOINING_PACK" field.
        /// </summary>
        public String JoiningPack
        {
            get { return _joiningPack; }
            set { _joiningPack = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_POST_PACK" field.
        /// </summary>
        public String PostPack
        {
            get { return _postPack; }
            set { _postPack = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PROV_TO_BOOK" field.
        /// </summary>
        public Byte? ProvToBook
        {
            get { return _provToBook; }
            set { _provToBook = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PROV_TO_DEL" field.
        /// </summary>
        public Byte? ProvToDel
        {
            get { return _provToDel; }
            set { _provToDel = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CONF_TO_BOOK" field.
        /// </summary>
        public Byte? ConfToBook
        {
            get { return _confToBook; }
            set { _confToBook = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CONF_TO_DEL" field.
        /// </summary>
        public Byte? ConfToDel
        {
            get { return _confToDel; }
            set { _confToDel = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_JOIN_TO_BOOK" field.
        /// </summary>
        public Byte? JoinToBook
        {
            get { return _joinToBook; }
            set { _joinToBook = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_JOIN_TO_DEL" field.
        /// </summary>
        public Byte? JoinToDel
        {
            get { return _joinToDel; }
            set { _joinToDel = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_POST_TO_BOOK" field.
        /// </summary>
        public Byte? PostToBook
        {
            get { return _postToBook; }
            set { _postToBook = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_POST_TO_DEL" field.
        /// </summary>
        public Byte? PostToDel
        {
            get { return _postToDel; }
            set { _postToDel = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PAID" field.
        /// </summary>
        public Byte? Paid
        {
            get { return _paid; }
            set { _paid = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PROV_INV" field.
        /// </summary>
        public Byte? ProvInv
        {
            get { return _provInv; }
            set { _provInv = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CONF_INV" field.
        /// </summary>
        public Byte? ConfInv
        {
            get { return _confInv; }
            set { _confInv = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_JOIN_INV" field.
        /// </summary>
        public Byte? JoinInv
        {
            get { return _joinInv; }
            set { _joinInv = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_POST_INV" field.
        /// </summary>
        public Byte? PostInv
        {
            get { return _postInv; }
            set { _postInv = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PERIOD" field.
        /// </summary>
        public String Period
        {
            get { return _period; }
            set { _period = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USERCHAR_2" field.
        /// </summary>
        public String Userchar2
        {
            get { return _userchar2; }
            set { _userchar2 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CANCEL_DATE" field.
        /// </summary>
        public DateTime? CancelDate
        {
            get { return _cancelDate; }
            set { _cancelDate = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CANCEL_BY" field.
        /// </summary>
        public String CancelBy
        {
            get { return _cancelBy; }
            set { _cancelBy = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PP_SENT_DTE" field.
        /// </summary>
        public DateTime? PpSentDte
        {
            get { return _ppSentDte; }
            set { _ppSentDte = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_BU_ID" field.
        /// </summary>
        public String BuId
        {
            get { return _buId; }
            set { _buId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_OPP_ID" field.
        /// </summary>
        public String OppId
        {
            get { return _oppId; }
            set { _oppId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CRYSTAL_INV" field.
        /// </summary>
        public String CrystalInv
        {
            get { return _crystalInv; }
            set { _crystalInv = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_QUO_ID" field.
        /// </summary>
        public String QuoId
        {
            get { return _quoId; }
            set { _quoId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_DISC_METHOD" field.
        /// </summary>
        public Byte? DiscMethod
        {
            get { return _discMethod; }
            set { _discMethod = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_DELIV_ADD" field.
        /// </summary>
        public String DelivAdd
        {
            get { return _delivAdd; }
            set { _delivAdd = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_DOCS_METHOD" field.
        /// </summary>
        public String DocsMethod
        {
            get { return _docsMethod; }
            set { _docsMethod = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_DUE_DATE" field.
        /// </summary>
        public DateTime? DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_SALES_MAN" field.
        /// </summary>
        public String SalesMan
        {
            get { return _salesMan; }
            set { _salesMan = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_SOP_SENT_DTE" field.
        /// </summary>
        public DateTime? SopSentDte
        {
            get { return _sopSentDte; }
            set { _sopSentDte = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_SOP_STATUS" field.
        /// </summary>
        public String SopStatus
        {
            get { return _sopStatus; }
            set { _sopStatus = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_SOP_NOTES" field.
        /// </summary>
        public String SopNotes
        {
            get { return _sopNotes; }
            set { _sopNotes = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_SOP_IN_DTE" field.
        /// </summary>
        public DateTime? SopInDte
        {
            get { return _sopInDte; }
            set { _sopInDte = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_SOP_REF" field.
        /// </summary>
        public String SopRef
        {
            get { return _sopRef; }
            set { _sopRef = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_SOP_INV_REF" field.
        /// </summary>
        public String SopInvRef
        {
            get { return _sopInvRef; }
            set { _sopInvRef = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_DISC_VALUE" field.
        /// </summary>
        public Byte? DiscValue
        {
            get { return _discValue; }
            set { _discValue = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PRINT_LOG" field.
        /// </summary>
        public String PrintLog
        {
            get { return _printLog; }
            set { _printLog = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CANC_REASON" field.
        /// </summary>
        public String CancReason
        {
            get { return _cancReason; }
            set { _cancReason = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_SOP_REL_DTE" field.
        /// </summary>
        public DateTime? SopRelDte
        {
            get { return _sopRelDte; }
            set { _sopRelDte = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_SOP_INT_1" field.
        /// </summary>
        public Int32? SopInt1
        {
            get { return _sopInt1; }
            set { _sopInt1 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USERCHAR_3" field.
        /// </summary>
        public String Userchar3
        {
            get { return _userchar3; }
            set { _userchar3 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USER_DATE_1" field.
        /// </summary>
        public DateTime? UserDate1
        {
            get { return _userDate1; }
            set { _userDate1 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USER_DATE_2" field.
        /// </summary>
        public DateTime? UserDate2
        {
            get { return _userDate2; }
            set { _userDate2 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USER_DATE_3" field.
        /// </summary>
        public DateTime? UserDate3
        {
            get { return _userDate3; }
            set { _userDate3 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_MULTI_LANG" field.
        /// </summary>
        public Byte? MultiLang
        {
            get { return _multiLang; }
            set { _multiLang = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPROVER1_ID" field.
        /// </summary>
        public String Approver1Id
        {
            get { return _approver1Id; }
            set { _approver1Id = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPROVER2_ID" field.
        /// </summary>
        public String Approver2Id
        {
            get { return _approver2Id; }
            set { _approver2Id = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPROVER3_ID" field.
        /// </summary>
        public String Approver3Id
        {
            get { return _approver3Id; }
            set { _approver3Id = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_NOMINATOR_ID" field.
        /// </summary>
        public String NominatorId
        {
            get { return _nominatorId; }
            set { _nominatorId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPROVER1_DOC" field.
        /// </summary>
        public String Approver1Doc
        {
            get { return _approver1Doc; }
            set { _approver1Doc = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPROVER2_DOC" field.
        /// </summary>
        public String Approver2Doc
        {
            get { return _approver2Doc; }
            set { _approver2Doc = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPROVER3_DOC" field.
        /// </summary>
        public String Approver3Doc
        {
            get { return _approver3Doc; }
            set { _approver3Doc = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_NOMINATOR_DOC" field.
        /// </summary>
        public String NominatorDoc
        {
            get { return _nominatorDoc; }
            set { _nominatorDoc = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ECUST_ID" field.
        /// </summary>
        public String EcustId
        {
            get { return _ecustId; }
            set { _ecustId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ECUST_00" field.
        /// </summary>
        public String Ecust00
        {
            get { return _ecust00; }
            set { _ecust00 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ECUST_01" field.
        /// </summary>
        public String Ecust01
        {
            get { return _ecust01; }
            set { _ecust01 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ECUST_02" field.
        /// </summary>
        public String Ecust02
        {
            get { return _ecust02; }
            set { _ecust02 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ECUST_03" field.
        /// </summary>
        public String Ecust03
        {
            get { return _ecust03; }
            set { _ecust03 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ECUST_04" field.
        /// </summary>
        public String Ecust04
        {
            get { return _ecust04; }
            set { _ecust04 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ECUST_05" field.
        /// </summary>
        public String Ecust05
        {
            get { return _ecust05; }
            set { _ecust05 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ECUST_06" field.
        /// </summary>
        public String Ecust06
        {
            get { return _ecust06; }
            set { _ecust06 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ECUST_07" field.
        /// </summary>
        public String Ecust07
        {
            get { return _ecust07; }
            set { _ecust07 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ECUST_08" field.
        /// </summary>
        public String Ecust08
        {
            get { return _ecust08; }
            set { _ecust08 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ECUST_09" field.
        /// </summary>
        public String Ecust09
        {
            get { return _ecust09; }
            set { _ecust09 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CURRENCY_TYPE" field.
        /// </summary>
        public String CurrencyType
        {
            get { return _currencyType; }
            set { _currencyType = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CURR_RATE_BC" field.
        /// </summary>
        public Decimal CurrRateBc
        {
            get { return _currRateBc; }
            set { _currRateBc = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CURR_RATE_BC2" field.
        /// </summary>
        public Decimal CurrRateBc2
        {
            get { return _currRateBc2; }
            set { _currRateBc2 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPROVER4_ID" field.
        /// </summary>
        public String Approver4Id
        {
            get { return _approver4Id; }
            set { _approver4Id = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_REJECT1_ID" field.
        /// </summary>
        public String Reject1Id
        {
            get { return _reject1Id; }
            set { _reject1Id = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_REJECT2_ID" field.
        /// </summary>
        public String Reject2Id
        {
            get { return _reject2Id; }
            set { _reject2Id = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_REJECT3_ID" field.
        /// </summary>
        public String Reject3Id
        {
            get { return _reject3Id; }
            set { _reject3Id = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_REJECT4_ID" field.
        /// </summary>
        public String Reject4Id
        {
            get { return _reject4Id; }
            set { _reject4Id = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ADD_ID" field.
        /// </summary>
        public String AddId
        {
            get { return _addId; }
            set { _addId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPREJ1_EMAIL" field.
        /// </summary>
        public String Apprej1Email
        {
            get { return _apprej1Email; }
            set { _apprej1Email = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPREJ2_EMAIL" field.
        /// </summary>
        public String Apprej2Email
        {
            get { return _apprej2Email; }
            set { _apprej2Email = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPREJ3_EMAIL" field.
        /// </summary>
        public String Apprej3Email
        {
            get { return _apprej3Email; }
            set { _apprej3Email = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPREJ4_EMAIL" field.
        /// </summary>
        public String Apprej4Email
        {
            get { return _apprej4Email; }
            set { _apprej4Email = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPREJ1_DATE" field.
        /// </summary>
        public DateTime? Apprej1Date
        {
            get { return _apprej1Date; }
            set { _apprej1Date = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPREJ2_DATE" field.
        /// </summary>
        public DateTime? Apprej2Date
        {
            get { return _apprej2Date; }
            set { _apprej2Date = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPREJ3_DATE" field.
        /// </summary>
        public DateTime? Apprej3Date
        {
            get { return _apprej3Date; }
            set { _apprej3Date = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_APPREJ4_DATE" field.
        /// </summary>
        public DateTime? Apprej4Date
        {
            get { return _apprej4Date; }
            set { _apprej4Date = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_VATCD_OVRRIDE" field.
        /// </summary>
        public String VatcdOvrride
        {
            get { return _vatcdOvrride; }
            set { _vatcdOvrride = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ORG_CUST_AC" field.
        /// </summary>
        public String OrgCustAc
        {
            get { return _orgCustAc; }
            set { _orgCustAc = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USER_DATE_4" field.
        /// </summary>
        public DateTime? UserDate4
        {
            get { return _userDate4; }
            set { _userDate4 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USER_DATE_5" field.
        /// </summary>
        public DateTime? UserDate5
        {
            get { return _userDate5; }
            set { _userDate5 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USER_DATE_6" field.
        /// </summary>
        public DateTime? UserDate6
        {
            get { return _userDate6; }
            set { _userDate6 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USERCHAR_4" field.
        /// </summary>
        public String Userchar4
        {
            get { return _userchar4; }
            set { _userchar4 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USERCHAR_5" field.
        /// </summary>
        public String Userchar5
        {
            get { return _userchar5; }
            set { _userchar5 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USERCHAR_6" field.
        /// </summary>
        public String Userchar6
        {
            get { return _userchar6; }
            set { _userchar6 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USER_TINT_1" field.
        /// </summary>
        public Byte? UserTint1
        {
            get { return _userTint1; }
            set { _userTint1 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USER_TINT_2" field.
        /// </summary>
        public Byte? UserTint2
        {
            get { return _userTint2; }
            set { _userTint2 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USER_TINT_3" field.
        /// </summary>
        public Byte? UserTint3
        {
            get { return _userTint3; }
            set { _userTint3 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USER_TINT_4" field.
        /// </summary>
        public Byte? UserTint4
        {
            get { return _userTint4; }
            set { _userTint4 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USER_TINT_5" field.
        /// </summary>
        public Byte? UserTint5
        {
            get { return _userTint5; }
            set { _userTint5 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USER_TINT_6" field.
        /// </summary>
        public Byte? UserTint6
        {
            get { return _userTint6; }
            set { _userTint6 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_DELIV_FAO" field.
        /// </summary>
        public String DelivFao
        {
            get { return _delivFao; }
            set { _delivFao = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_DELIV_PHONE" field.
        /// </summary>
        public String DelivPhone
        {
            get { return _delivPhone; }
            set { _delivPhone = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INV_PROLE_ID" field.
        /// </summary>
        public String InvProleId
        {
            get { return _invProleId; }
            set { _invProleId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INV_TYPE" field.
        /// </summary>
        public Byte? InvType
        {
            get { return _invType; }
            set { _invType = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CHARGE_TYPE" field.
        /// </summary>
        public String ChargeType
        {
            get { return _chargeType; }
            set { _chargeType = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_DEPOSIT_TOT" field.
        /// </summary>
        public Decimal? DepositTot
        {
            get { return _depositTot; }
            set { _depositTot = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_DEPOSIT_PAID" field.
        /// </summary>
        public Decimal? DepositPaid
        {
            get { return _depositPaid; }
            set { _depositPaid = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_SCHN_ID" field.
        /// </summary>
        public String SchnId
        {
            get { return _schnId; }
            set { _schnId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_SY_TYPE" field.
        /// </summary>
        public Byte? SyType
        {
            get { return _syType; }
            set { _syType = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PRJOIN_SENT_DTE" field.
        /// </summary>
        public DateTime? PrjoinSentDte
        {
            get { return _prjoinSentDte; }
            set { _prjoinSentDte = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_POJOIN_SENT_DTE" field.
        /// </summary>
        public DateTime? PojoinSentDte
        {
            get { return _pojoinSentDte; }
            set { _pojoinSentDte = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PREJOIN_PACK" field.
        /// </summary>
        public String PrejoinPack
        {
            get { return _prejoinPack; }
            set { _prejoinPack = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PSTJOIN_PACK" field.
        /// </summary>
        public String PstjoinPack
        {
            get { return _pstjoinPack; }
            set { _pstjoinPack = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PREJOIN_TO_BOOK" field.
        /// </summary>
        public Byte? PrejoinToBook
        {
            get { return _prejoinToBook; }
            set { _prejoinToBook = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PREJOIN_TO_DEL" field.
        /// </summary>
        public Byte? PrejoinToDel
        {
            get { return _prejoinToDel; }
            set { _prejoinToDel = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PSTJOIN_TO_BOOK" field.
        /// </summary>
        public Byte? PstjoinToBook
        {
            get { return _pstjoinToBook; }
            set { _pstjoinToBook = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PSTJOIN_TO_DEL" field.
        /// </summary>
        public Byte? PstjoinToDel
        {
            get { return _pstjoinToDel; }
            set { _pstjoinToDel = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_NET_TOTAL_BC" field.
        /// </summary>
        public Decimal NetTotalBc
        {
            get { return _netTotalBc; }
            set { _netTotalBc = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_NET_TOTAL_BC2" field.
        /// </summary>
        public Decimal NetTotalBc2
        {
            get { return _netTotalBc2; }
            set { _netTotalBc2 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_TERMS_ACC_BY" field.
        /// </summary>
        public String TermsAccBy
        {
            get { return _termsAccBy; }
            set { _termsAccBy = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INVOICE_RULE" field.
        /// </summary>
        public Byte InvoiceRule
        {
            get { return _invoiceRule; }
            set { _invoiceRule = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INVOICE_RULE_OFFSET" field.
        /// </summary>
        public Int16 InvoiceRuleOffset
        {
            get { return _invoiceRuleOffset; }
            set { _invoiceRuleOffset = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_DO_NOT_INVOICE_REASON" field.
        /// </summary>
        public String DoNotInvoiceReason
        {
            get { return _doNotInvoiceReason; }
            set { _doNotInvoiceReason = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INVOICE_OFFSET_TYPE" field.
        /// </summary>
        public String InvoiceOffsetType
        {
            get { return _invoiceOffsetType; }
            set { _invoiceOffsetType = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INVOICE_WHEN_STATUS" field.
        /// </summary>
        public String InvoiceWhenStatus
        {
            get { return _invoiceWhenStatus; }
            set { _invoiceWhenStatus = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INVOICE_MUST_USE_RULE" field.
        /// </summary>
        public Byte InvoiceMustUseRule
        {
            get { return _invoiceMustUseRule; }
            set { _invoiceMustUseRule = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INVOICE_CONSOLIDATE" field.
        /// </summary>
        public Byte InvoiceConsolidate
        {
            get { return _invoiceConsolidate; }
            set { _invoiceConsolidate = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INVOICE_FORMAT" field.
        /// </summary>
        public Byte InvoiceFormat
        {
            get { return _invoiceFormat; }
            set { _invoiceFormat = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INVOICE_FORMAT_0_TEXT" field.
        /// </summary>
        public String InvoiceFormat0Text
        {
            get { return _invoiceFormat0Text; }
            set { _invoiceFormat0Text = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INVOICE_FORMAT_1_TEXT" field.
        /// </summary>
        public String InvoiceFormat1Text
        {
            get { return _invoiceFormat1Text; }
            set { _invoiceFormat1Text = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_ACC_ID" field.
        /// </summary>
        public String AccId
        {
            get { return _accId; }
            set { _accId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_RESV_TO_DATE" field.
        /// </summary>
        public DateTime? ResvToDate
        {
            get { return _resvToDate; }
            set { _resvToDate = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_AGT_ID" field.
        /// </summary>
        public Int32? AgtId
        {
            get { return _agtId; }
            set { _agtId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_AGT_ORG_ID" field.
        /// </summary>
        public String AgtOrgId
        {
            get { return _agtOrgId; }
            set { _agtOrgId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_AGT_TYPE" field.
        /// </summary>
        public String AgtType
        {
            get { return _agtType; }
            set { _agtType = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_AGT_COMMISSION" field.
        /// </summary>
        public Decimal? AgtCommission
        {
            get { return _agtCommission; }
            set { _agtCommission = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INVOICE_PER_DEL" field.
        /// </summary>
        public Byte InvoicePerDel
        {
            get { return _invoicePerDel; }
            set { _invoicePerDel = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_MANAGED" field.
        /// </summary>
        public Byte? Managed
        {
            get { return _managed; }
            set { _managed = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CANCEL_REF" field.
        /// </summary>
        public String CancelRef
        {
            get { return _cancelRef; }
            set { _cancelRef = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_INVOICE_PER_PERSON" field.
        /// </summary>
        public Byte InvoicePerPerson
        {
            get { return _invoicePerPerson; }
            set { _invoicePerPerson = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PROFORMA" field.
        /// </summary>
        public Byte? Proforma
        {
            get { return _proforma; }
            set { _proforma = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CART_ID" field.
        /// </summary>
        public Int32? CartId
        {
            get { return _cartId; }
            set { _cartId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PS_ID" field.
        /// </summary>
        public Int32? PsId
        {
            get { return _psId; }
            set { _psId = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_PROMO_CODE" field.
        /// </summary>
        public String PromoCode
        {
            get { return _promoCode; }
            set { _promoCode = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CUST_BR_INF" field.
        /// </summary>
        public String CustBrInf
        {
            get { return _custBrInf; }
            set { _custBrInf = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_CONF_SENT_OFFLINE_DATE" field.
        /// </summary>
        public DateTime? ConfSentOfflineDate
        {
            get { return _confSentOfflineDate; }
            set { _confSentOfflineDate = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USERNUM_1" field.
        /// </summary>
        public Decimal? Usernum1
        {
            get { return _usernum1; }
            set { _usernum1 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USERNUM_2" field.
        /// </summary>
        public Decimal? Usernum2
        {
            get { return _usernum2; }
            set { _usernum2 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USERNUM_3" field.
        /// </summary>
        public Decimal? Usernum3
        {
            get { return _usernum3; }
            set { _usernum3 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USERNUM_4" field.
        /// </summary>
        public Decimal? Usernum4
        {
            get { return _usernum4; }
            set { _usernum4 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USERNUM_5" field.
        /// </summary>
        public Decimal? Usernum5
        {
            get { return _usernum5; }
            set { _usernum5 = value; }
        }

        /// <summary>
        ///     the value of the "BOOK_USERNUM_6" field.
        /// </summary>
        public Decimal? Usernum6
        {
            get { return _usernum6; }
            set { _usernum6 = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="BookingRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="BookingRecord" /> object instance.
        /// </returns>
        public BookingRecord Clone()
        {
            BookingRecord record = new BookingRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.OrgId = this.OrgId;
            record.PersonId = this.PersonId;
            record.CourseId = this.CourseId;
            record.Salesman = this.Salesman;
            record.InvId = this.InvId;
            record.Status = this.Status;
            record.StatusDate = this.StatusDate;
            record.OrderDate = this.OrderDate;
            record.DlvryDate = this.DlvryDate;
            record.DlvryRef = this.DlvryRef;
            record.Carrier = this.Carrier;
            record.CustOrdNo = this.CustOrdNo;
            record.OrderType = this.OrderType;
            record.InvStatus = this.InvStatus;
            record.InvAdd = this.InvAdd;
            record.DlvryAdd = this.DlvryAdd;
            record.Notes = this.Notes;
            record.NetTotal = this.NetTotal;
            record.VatTotal = this.VatTotal;
            record.GrossTotal = this.GrossTotal;
            record.Places = this.Places;
            record.ProvLetter = this.ProvLetter;
            record.Confirmed = this.Confirmed;
            record.JoinPack = this.JoinPack;
            record.PaidDate = this.PaidDate;
            record.UnionId = this.UnionId;
            record.TucRegion = this.TucRegion;
            record.Approved = this.Approved;
            record.ApprovedBy = this.ApprovedBy;
            record.ApproveDate = this.ApproveDate;
            record.TimingFlag = this.TimingFlag;
            record.ArchFlag = this.ArchFlag;
            record.BookingMethd = this.BookingMethd;
            record.PaymentMethd = this.PaymentMethd;
            record.SourceCode = this.SourceCode;
            record.NetTotalAdj = this.NetTotalAdj;
            record.DatePaid = this.DatePaid;
            record.TimesMoved = this.TimesMoved;
            record.CorsMvdFrom = this.CorsMvdFrom;
            record.StudentPrice = this.StudentPrice;
            record.AdjustVatcd = this.AdjustVatcd;
            record.AdjustDescrp = this.AdjustDescrp;
            record.ConfSentDte = this.ConfSentDte;
            record.JoinSentDte = this.JoinSentDte;
            record.TimeMvdCust = this.TimeMvdCust;
            record.CorsMvdCust = this.CorsMvdCust;
            record.ProvSentDte = this.ProvSentDte;
            record.InvOrgId = this.InvOrgId;
            record.InvExtNotes = this.InvExtNotes;
            record.Invoiced = this.Invoiced;
            record.ForAttnOf = this.ForAttnOf;
            record.DoNotInvoic = this.DoNotInvoic;
            record.MstcId = this.MstcId;
            record.BatId = this.BatId;
            record.BatId2 = this.BatId2;
            record.BlockPriced = this.BlockPriced;
            record.PlId = this.PlId;
            record.BlockPrice = this.BlockPrice;
            record.IncomCode = this.IncomCode;
            record.ExpendCode = this.ExpendCode;
            record.ProductGroup = this.ProductGroup;
            record.Reason = this.Reason;
            record.Userchar1 = this.Userchar1;
            record.CcardId = this.CcardId;
            record.ProvPack = this.ProvPack;
            record.ConfPack = this.ConfPack;
            record.JoiningPack = this.JoiningPack;
            record.PostPack = this.PostPack;
            record.ProvToBook = this.ProvToBook;
            record.ProvToDel = this.ProvToDel;
            record.ConfToBook = this.ConfToBook;
            record.ConfToDel = this.ConfToDel;
            record.JoinToBook = this.JoinToBook;
            record.JoinToDel = this.JoinToDel;
            record.PostToBook = this.PostToBook;
            record.PostToDel = this.PostToDel;
            record.Paid = this.Paid;
            record.ProvInv = this.ProvInv;
            record.ConfInv = this.ConfInv;
            record.JoinInv = this.JoinInv;
            record.PostInv = this.PostInv;
            record.Period = this.Period;
            record.Userchar2 = this.Userchar2;
            record.CancelDate = this.CancelDate;
            record.CancelBy = this.CancelBy;
            record.PpSentDte = this.PpSentDte;
            record.BuId = this.BuId;
            record.OppId = this.OppId;
            record.CrystalInv = this.CrystalInv;
            record.QuoId = this.QuoId;
            record.DiscMethod = this.DiscMethod;
            record.DelivAdd = this.DelivAdd;
            record.DocsMethod = this.DocsMethod;
            record.DueDate = this.DueDate;
            record.SalesMan = this.SalesMan;
            record.SopSentDte = this.SopSentDte;
            record.SopStatus = this.SopStatus;
            record.SopNotes = this.SopNotes;
            record.SopInDte = this.SopInDte;
            record.SopRef = this.SopRef;
            record.SopInvRef = this.SopInvRef;
            record.DiscValue = this.DiscValue;
            record.PrintLog = this.PrintLog;
            record.CancReason = this.CancReason;
            record.SopRelDte = this.SopRelDte;
            record.SopInt1 = this.SopInt1;
            record.Userchar3 = this.Userchar3;
            record.UserDate1 = this.UserDate1;
            record.UserDate2 = this.UserDate2;
            record.UserDate3 = this.UserDate3;
            record.MultiLang = this.MultiLang;
            record.Approver1Id = this.Approver1Id;
            record.Approver2Id = this.Approver2Id;
            record.Approver3Id = this.Approver3Id;
            record.NominatorId = this.NominatorId;
            record.Approver1Doc = this.Approver1Doc;
            record.Approver2Doc = this.Approver2Doc;
            record.Approver3Doc = this.Approver3Doc;
            record.NominatorDoc = this.NominatorDoc;
            record.EcustId = this.EcustId;
            record.Ecust00 = this.Ecust00;
            record.Ecust01 = this.Ecust01;
            record.Ecust02 = this.Ecust02;
            record.Ecust03 = this.Ecust03;
            record.Ecust04 = this.Ecust04;
            record.Ecust05 = this.Ecust05;
            record.Ecust06 = this.Ecust06;
            record.Ecust07 = this.Ecust07;
            record.Ecust08 = this.Ecust08;
            record.Ecust09 = this.Ecust09;
            record.CurrencyType = this.CurrencyType;
            record.CurrRateBc = this.CurrRateBc;
            record.CurrRateBc2 = this.CurrRateBc2;
            record.Approver4Id = this.Approver4Id;
            record.Reject1Id = this.Reject1Id;
            record.Reject2Id = this.Reject2Id;
            record.Reject3Id = this.Reject3Id;
            record.Reject4Id = this.Reject4Id;
            record.SelcoSpId = this.SelcoSpId;
            record.AddId = this.AddId;
            record.Apprej1Email = this.Apprej1Email;
            record.Apprej2Email = this.Apprej2Email;
            record.Apprej3Email = this.Apprej3Email;
            record.Apprej4Email = this.Apprej4Email;
            record.Apprej1Date = this.Apprej1Date;
            record.Apprej2Date = this.Apprej2Date;
            record.Apprej3Date = this.Apprej3Date;
            record.Apprej4Date = this.Apprej4Date;
            record.ProleId = this.ProleId;
            record.VatcdOvrride = this.VatcdOvrride;
            record.OrgCustAc = this.OrgCustAc;
            record.UserDate4 = this.UserDate4;
            record.UserDate5 = this.UserDate5;
            record.UserDate6 = this.UserDate6;
            record.Userchar4 = this.Userchar4;
            record.Userchar5 = this.Userchar5;
            record.Userchar6 = this.Userchar6;
            record.UserTint1 = this.UserTint1;
            record.UserTint2 = this.UserTint2;
            record.UserTint3 = this.UserTint3;
            record.UserTint4 = this.UserTint4;
            record.UserTint5 = this.UserTint5;
            record.UserTint6 = this.UserTint6;
            record.DelivFao = this.DelivFao;
            record.DelivPhone = this.DelivPhone;
            record.InvProleId = this.InvProleId;
            record.InvType = this.InvType;
            record.ChargeType = this.ChargeType;
            record.DepositTot = this.DepositTot;
            record.DepositPaid = this.DepositPaid;
            record.SchnId = this.SchnId;
            record.SyType = this.SyType;
            record.PrjoinSentDte = this.PrjoinSentDte;
            record.PojoinSentDte = this.PojoinSentDte;
            record.PrejoinPack = this.PrejoinPack;
            record.PstjoinPack = this.PstjoinPack;
            record.PrejoinToBook = this.PrejoinToBook;
            record.PrejoinToDel = this.PrejoinToDel;
            record.PstjoinToBook = this.PstjoinToBook;
            record.PstjoinToDel = this.PstjoinToDel;
            record.NetTotalBc = this.NetTotalBc;
            record.NetTotalBc2 = this.NetTotalBc2;
            record.TermsAccBy = this.TermsAccBy;
            record.InvoiceRule = this.InvoiceRule;
            record.InvoiceRuleOffset = this.InvoiceRuleOffset;
            record.DoNotInvoiceReason = this.DoNotInvoiceReason;
            record.InvoiceOffsetType = this.InvoiceOffsetType;
            record.InvoiceWhenStatus = this.InvoiceWhenStatus;
            record.InvoiceMustUseRule = this.InvoiceMustUseRule;
            record.InvoiceConsolidate = this.InvoiceConsolidate;
            record.InvoiceFormat = this.InvoiceFormat;
            record.InvoiceFormat0Text = this.InvoiceFormat0Text;
            record.InvoiceFormat1Text = this.InvoiceFormat1Text;
            record.AccId = this.AccId;
            record.ResvToDate = this.ResvToDate;
            record.AgtId = this.AgtId;
            record.AgtOrgId = this.AgtOrgId;
            record.AgtType = this.AgtType;
            record.AgtCommission = this.AgtCommission;
            record.InvoicePerDel = this.InvoicePerDel;
            record.Managed = this.Managed;
            record.CancelRef = this.CancelRef;
            record.InvoicePerPerson = this.InvoicePerPerson;
            record.Proforma = this.Proforma;
            record.CartId = this.CartId;
            record.PsId = this.PsId;
            record.PromoCode = this.PromoCode;
            record.CustBrInf = this.CustBrInf;
            record.ConfSentOfflineDate = this.ConfSentOfflineDate;
            record.Usernum1 = this.Usernum1;
            record.Usernum2 = this.Usernum2;
            record.Usernum3 = this.Usernum3;
            record.Usernum4 = this.Usernum4;
            record.Usernum5 = this.Usernum5;
            record.Usernum6 = this.Usernum6;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="BookingRecord" /> instance is equal to another <see cref="BookingRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="BookingRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(BookingRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.PersonId.TrimOrNullify() == that.PersonId.TrimOrNullify());
            result = result && (this.CourseId.TrimOrNullify() == that.CourseId.TrimOrNullify());
            result = result && (this.Salesman.TrimOrNullify() == that.Salesman.TrimOrNullify());
            result = result && (this.InvId.TrimOrNullify() == that.InvId.TrimOrNullify());
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.StatusDate == that.StatusDate);
            result = result && (this.OrderDate == that.OrderDate);
            result = result && (this.DlvryDate == that.DlvryDate);
            result = result && (this.DlvryRef.TrimOrNullify() == that.DlvryRef.TrimOrNullify());
            result = result && (this.Carrier.TrimOrNullify() == that.Carrier.TrimOrNullify());
            result = result && (this.CustOrdNo.TrimOrNullify() == that.CustOrdNo.TrimOrNullify());
            result = result && (this.OrderType.TrimOrNullify() == that.OrderType.TrimOrNullify());
            result = result && (this.InvStatus.TrimOrNullify() == that.InvStatus.TrimOrNullify());
            result = result && (this.InvAdd.TrimOrNullify() == that.InvAdd.TrimOrNullify());
            result = result && (this.DlvryAdd.TrimOrNullify() == that.DlvryAdd.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.NetTotal == that.NetTotal);
            result = result && (this.VatTotal == that.VatTotal);
            result = result && (this.GrossTotal == that.GrossTotal);
            result = result && (this.Places == that.Places);
            result = result && (this.ProvLetter == that.ProvLetter);
            result = result && (this.Confirmed == that.Confirmed);
            result = result && (this.JoinPack == that.JoinPack);
            result = result && (this.PaidDate == that.PaidDate);
            result = result && (this.UnionId.TrimOrNullify() == that.UnionId.TrimOrNullify());
            result = result && (this.TucRegion.TrimOrNullify() == that.TucRegion.TrimOrNullify());
            result = result && (this.Approved == that.Approved);
            result = result && (this.ApprovedBy.TrimOrNullify() == that.ApprovedBy.TrimOrNullify());
            result = result && (this.ApproveDate == that.ApproveDate);
            result = result && (this.TimingFlag == that.TimingFlag);
            result = result && (this.ArchFlag == that.ArchFlag);
            result = result && (this.BookingMethd.TrimOrNullify() == that.BookingMethd.TrimOrNullify());
            result = result && (this.PaymentMethd.TrimOrNullify() == that.PaymentMethd.TrimOrNullify());
            result = result && (this.SourceCode.TrimOrNullify() == that.SourceCode.TrimOrNullify());
            result = result && (this.NetTotalAdj == that.NetTotalAdj);
            result = result && (this.DatePaid == that.DatePaid);
            result = result && (this.TimesMoved == that.TimesMoved);
            result = result && (this.CorsMvdFrom.TrimOrNullify() == that.CorsMvdFrom.TrimOrNullify());
            result = result && (this.StudentPrice == that.StudentPrice);
            result = result && (this.AdjustVatcd.TrimOrNullify() == that.AdjustVatcd.TrimOrNullify());
            result = result && (this.AdjustDescrp.TrimOrNullify() == that.AdjustDescrp.TrimOrNullify());
            result = result && (this.ConfSentDte == that.ConfSentDte);
            result = result && (this.JoinSentDte == that.JoinSentDte);
            result = result && (this.TimeMvdCust == that.TimeMvdCust);
            result = result && (this.CorsMvdCust.TrimOrNullify() == that.CorsMvdCust.TrimOrNullify());
            result = result && (this.ProvSentDte == that.ProvSentDte);
            result = result && (this.InvOrgId.TrimOrNullify() == that.InvOrgId.TrimOrNullify());
            result = result && (this.InvExtNotes.TrimOrNullify() == that.InvExtNotes.TrimOrNullify());
            result = result && (this.Invoiced == that.Invoiced);
            result = result && (this.ForAttnOf.TrimOrNullify() == that.ForAttnOf.TrimOrNullify());
            result = result && (this.DoNotInvoic == that.DoNotInvoic);
            result = result && (this.MstcId.TrimOrNullify() == that.MstcId.TrimOrNullify());
            result = result && (this.BatId.TrimOrNullify() == that.BatId.TrimOrNullify());
            result = result && (this.BatId2.TrimOrNullify() == that.BatId2.TrimOrNullify());
            result = result && (this.BlockPriced == that.BlockPriced);
            result = result && (this.PlId.TrimOrNullify() == that.PlId.TrimOrNullify());
            result = result && (this.BlockPrice == that.BlockPrice);
            result = result && (this.IncomCode.TrimOrNullify() == that.IncomCode.TrimOrNullify());
            result = result && (this.ExpendCode.TrimOrNullify() == that.ExpendCode.TrimOrNullify());
            result = result && (this.ProductGroup.TrimOrNullify() == that.ProductGroup.TrimOrNullify());
            result = result && (this.Reason.TrimOrNullify() == that.Reason.TrimOrNullify());
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.CcardId.TrimOrNullify() == that.CcardId.TrimOrNullify());
            result = result && (this.ProvPack.TrimOrNullify() == that.ProvPack.TrimOrNullify());
            result = result && (this.ConfPack.TrimOrNullify() == that.ConfPack.TrimOrNullify());
            result = result && (this.JoiningPack.TrimOrNullify() == that.JoiningPack.TrimOrNullify());
            result = result && (this.PostPack.TrimOrNullify() == that.PostPack.TrimOrNullify());
            result = result && (this.ProvToBook == that.ProvToBook);
            result = result && (this.ProvToDel == that.ProvToDel);
            result = result && (this.ConfToBook == that.ConfToBook);
            result = result && (this.ConfToDel == that.ConfToDel);
            result = result && (this.JoinToBook == that.JoinToBook);
            result = result && (this.JoinToDel == that.JoinToDel);
            result = result && (this.PostToBook == that.PostToBook);
            result = result && (this.PostToDel == that.PostToDel);
            result = result && (this.Paid == that.Paid);
            result = result && (this.ProvInv == that.ProvInv);
            result = result && (this.ConfInv == that.ConfInv);
            result = result && (this.JoinInv == that.JoinInv);
            result = result && (this.PostInv == that.PostInv);
            result = result && (this.Period.TrimOrNullify() == that.Period.TrimOrNullify());
            result = result && (this.Userchar2.TrimOrNullify() == that.Userchar2.TrimOrNullify());
            result = result && (this.CancelDate == that.CancelDate);
            result = result && (this.CancelBy.TrimOrNullify() == that.CancelBy.TrimOrNullify());
            result = result && (this.PpSentDte == that.PpSentDte);
            result = result && (this.BuId.TrimOrNullify() == that.BuId.TrimOrNullify());
            result = result && (this.OppId.TrimOrNullify() == that.OppId.TrimOrNullify());
            result = result && (this.CrystalInv.TrimOrNullify() == that.CrystalInv.TrimOrNullify());
            result = result && (this.QuoId.TrimOrNullify() == that.QuoId.TrimOrNullify());
            result = result && (this.DiscMethod == that.DiscMethod);
            result = result && (this.DelivAdd.TrimOrNullify() == that.DelivAdd.TrimOrNullify());
            result = result && (this.DocsMethod.TrimOrNullify() == that.DocsMethod.TrimOrNullify());
            result = result && (this.DueDate == that.DueDate);
            result = result && (this.SalesMan.TrimOrNullify() == that.SalesMan.TrimOrNullify());
            result = result && (this.SopSentDte == that.SopSentDte);
            result = result && (this.SopStatus.TrimOrNullify() == that.SopStatus.TrimOrNullify());
            result = result && (this.SopNotes.TrimOrNullify() == that.SopNotes.TrimOrNullify());
            result = result && (this.SopInDte == that.SopInDte);
            result = result && (this.SopRef.TrimOrNullify() == that.SopRef.TrimOrNullify());
            result = result && (this.SopInvRef.TrimOrNullify() == that.SopInvRef.TrimOrNullify());
            result = result && (this.DiscValue == that.DiscValue);
            result = result && (this.PrintLog.TrimOrNullify() == that.PrintLog.TrimOrNullify());
            result = result && (this.CancReason.TrimOrNullify() == that.CancReason.TrimOrNullify());
            result = result && (this.SopRelDte == that.SopRelDte);
            result = result && (this.SopInt1 == that.SopInt1);
            result = result && (this.Userchar3.TrimOrNullify() == that.Userchar3.TrimOrNullify());
            result = result && (this.UserDate1 == that.UserDate1);
            result = result && (this.UserDate2 == that.UserDate2);
            result = result && (this.UserDate3 == that.UserDate3);
            result = result && (this.MultiLang == that.MultiLang);
            result = result && (this.Approver1Id.TrimOrNullify() == that.Approver1Id.TrimOrNullify());
            result = result && (this.Approver2Id.TrimOrNullify() == that.Approver2Id.TrimOrNullify());
            result = result && (this.Approver3Id.TrimOrNullify() == that.Approver3Id.TrimOrNullify());
            result = result && (this.NominatorId.TrimOrNullify() == that.NominatorId.TrimOrNullify());
            result = result && (this.Approver1Doc.TrimOrNullify() == that.Approver1Doc.TrimOrNullify());
            result = result && (this.Approver2Doc.TrimOrNullify() == that.Approver2Doc.TrimOrNullify());
            result = result && (this.Approver3Doc.TrimOrNullify() == that.Approver3Doc.TrimOrNullify());
            result = result && (this.NominatorDoc.TrimOrNullify() == that.NominatorDoc.TrimOrNullify());
            result = result && (this.EcustId.TrimOrNullify() == that.EcustId.TrimOrNullify());
            result = result && (this.Ecust00.TrimOrNullify() == that.Ecust00.TrimOrNullify());
            result = result && (this.Ecust01.TrimOrNullify() == that.Ecust01.TrimOrNullify());
            result = result && (this.Ecust02.TrimOrNullify() == that.Ecust02.TrimOrNullify());
            result = result && (this.Ecust03.TrimOrNullify() == that.Ecust03.TrimOrNullify());
            result = result && (this.Ecust04.TrimOrNullify() == that.Ecust04.TrimOrNullify());
            result = result && (this.Ecust05.TrimOrNullify() == that.Ecust05.TrimOrNullify());
            result = result && (this.Ecust06.TrimOrNullify() == that.Ecust06.TrimOrNullify());
            result = result && (this.Ecust07.TrimOrNullify() == that.Ecust07.TrimOrNullify());
            result = result && (this.Ecust08.TrimOrNullify() == that.Ecust08.TrimOrNullify());
            result = result && (this.Ecust09.TrimOrNullify() == that.Ecust09.TrimOrNullify());
            result = result && (this.CurrencyType.TrimOrNullify() == that.CurrencyType.TrimOrNullify());
            result = result && (this.CurrRateBc == that.CurrRateBc);
            result = result && (this.CurrRateBc2 == that.CurrRateBc2);
            result = result && (this.Approver4Id.TrimOrNullify() == that.Approver4Id.TrimOrNullify());
            result = result && (this.Reject1Id.TrimOrNullify() == that.Reject1Id.TrimOrNullify());
            result = result && (this.Reject2Id.TrimOrNullify() == that.Reject2Id.TrimOrNullify());
            result = result && (this.Reject3Id.TrimOrNullify() == that.Reject3Id.TrimOrNullify());
            result = result && (this.Reject4Id.TrimOrNullify() == that.Reject4Id.TrimOrNullify());
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.AddId.TrimOrNullify() == that.AddId.TrimOrNullify());
            result = result && (this.Apprej1Email.TrimOrNullify() == that.Apprej1Email.TrimOrNullify());
            result = result && (this.Apprej2Email.TrimOrNullify() == that.Apprej2Email.TrimOrNullify());
            result = result && (this.Apprej3Email.TrimOrNullify() == that.Apprej3Email.TrimOrNullify());
            result = result && (this.Apprej4Email.TrimOrNullify() == that.Apprej4Email.TrimOrNullify());
            result = result && (this.Apprej1Date == that.Apprej1Date);
            result = result && (this.Apprej2Date == that.Apprej2Date);
            result = result && (this.Apprej3Date == that.Apprej3Date);
            result = result && (this.Apprej4Date == that.Apprej4Date);
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.VatcdOvrride.TrimOrNullify() == that.VatcdOvrride.TrimOrNullify());
            result = result && (this.OrgCustAc.TrimOrNullify() == that.OrgCustAc.TrimOrNullify());
            result = result && (this.UserDate4 == that.UserDate4);
            result = result && (this.UserDate5 == that.UserDate5);
            result = result && (this.UserDate6 == that.UserDate6);
            result = result && (this.Userchar4.TrimOrNullify() == that.Userchar4.TrimOrNullify());
            result = result && (this.Userchar5.TrimOrNullify() == that.Userchar5.TrimOrNullify());
            result = result && (this.Userchar6.TrimOrNullify() == that.Userchar6.TrimOrNullify());
            result = result && (this.UserTint1 == that.UserTint1);
            result = result && (this.UserTint2 == that.UserTint2);
            result = result && (this.UserTint3 == that.UserTint3);
            result = result && (this.UserTint4 == that.UserTint4);
            result = result && (this.UserTint5 == that.UserTint5);
            result = result && (this.UserTint6 == that.UserTint6);
            result = result && (this.DelivFao.TrimOrNullify() == that.DelivFao.TrimOrNullify());
            result = result && (this.DelivPhone.TrimOrNullify() == that.DelivPhone.TrimOrNullify());
            result = result && (this.InvProleId.TrimOrNullify() == that.InvProleId.TrimOrNullify());
            result = result && (this.InvType == that.InvType);
            result = result && (this.ChargeType.TrimOrNullify() == that.ChargeType.TrimOrNullify());
            result = result && (this.DepositTot == that.DepositTot);
            result = result && (this.DepositPaid == that.DepositPaid);
            result = result && (this.SchnId.TrimOrNullify() == that.SchnId.TrimOrNullify());
            result = result && (this.SyType == that.SyType);
            result = result && (this.PrjoinSentDte == that.PrjoinSentDte);
            result = result && (this.PojoinSentDte == that.PojoinSentDte);
            result = result && (this.PrejoinPack.TrimOrNullify() == that.PrejoinPack.TrimOrNullify());
            result = result && (this.PstjoinPack.TrimOrNullify() == that.PstjoinPack.TrimOrNullify());
            result = result && (this.PrejoinToBook == that.PrejoinToBook);
            result = result && (this.PrejoinToDel == that.PrejoinToDel);
            result = result && (this.PstjoinToBook == that.PstjoinToBook);
            result = result && (this.PstjoinToDel == that.PstjoinToDel);
            result = result && (this.NetTotalBc == that.NetTotalBc);
            result = result && (this.NetTotalBc2 == that.NetTotalBc2);
            result = result && (this.TermsAccBy.TrimOrNullify() == that.TermsAccBy.TrimOrNullify());
            result = result && (this.InvoiceRule == that.InvoiceRule);
            result = result && (this.InvoiceRuleOffset == that.InvoiceRuleOffset);
            result = result && (this.DoNotInvoiceReason.TrimOrNullify() == that.DoNotInvoiceReason.TrimOrNullify());
            result = result && (this.InvoiceOffsetType.TrimOrNullify() == that.InvoiceOffsetType.TrimOrNullify());
            result = result && (this.InvoiceWhenStatus.TrimOrNullify() == that.InvoiceWhenStatus.TrimOrNullify());
            result = result && (this.InvoiceMustUseRule == that.InvoiceMustUseRule);
            result = result && (this.InvoiceConsolidate == that.InvoiceConsolidate);
            result = result && (this.InvoiceFormat == that.InvoiceFormat);
            result = result && (this.InvoiceFormat0Text.TrimOrNullify() == that.InvoiceFormat0Text.TrimOrNullify());
            result = result && (this.InvoiceFormat1Text.TrimOrNullify() == that.InvoiceFormat1Text.TrimOrNullify());
            result = result && (this.AccId.TrimOrNullify() == that.AccId.TrimOrNullify());
            result = result && (this.ResvToDate == that.ResvToDate);
            result = result && (this.AgtId == that.AgtId);
            result = result && (this.AgtOrgId.TrimOrNullify() == that.AgtOrgId.TrimOrNullify());
            result = result && (this.AgtType.TrimOrNullify() == that.AgtType.TrimOrNullify());
            result = result && (this.AgtCommission == that.AgtCommission);
            result = result && (this.InvoicePerDel == that.InvoicePerDel);
            result = result && (this.Managed == that.Managed);
            result = result && (this.CancelRef.TrimOrNullify() == that.CancelRef.TrimOrNullify());
            result = result && (this.InvoicePerPerson == that.InvoicePerPerson);
            result = result && (this.Proforma == that.Proforma);
            result = result && (this.CartId == that.CartId);
            result = result && (this.PsId == that.PsId);
            result = result && (this.PromoCode.TrimOrNullify() == that.PromoCode.TrimOrNullify());
            result = result && (this.CustBrInf.TrimOrNullify() == that.CustBrInf.TrimOrNullify());
            result = result && (this.ConfSentOfflineDate == that.ConfSentOfflineDate);
            result = result && (this.Usernum1 == that.Usernum1);
            result = result && (this.Usernum2 == that.Usernum2);
            result = result && (this.Usernum3 == that.Usernum3);
            result = result && (this.Usernum4 == that.Usernum4);
            result = result && (this.Usernum5 == that.Usernum5);
            result = result && (this.Usernum6 == that.Usernum6);
            return result;
        }

        #endregion
    }
}
