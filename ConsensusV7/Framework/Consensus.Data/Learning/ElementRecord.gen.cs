using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Represents the "Element" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ElementRecord : Record<String>, Cloneable<ElementRecord>, IEquatable<ElementRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ELEM_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "ELEM_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "ELEM_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "ELEM_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "ELEM_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "ELEM_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "ELEM_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "ELEM_DEL_ID" field.
        /// </summary>
        private String _delId;

        /// <summary>
        ///     the value of the "ELEM_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "ELEM_ACT_ID" field.
        /// </summary>
        private String _actId;

        /// <summary>
        ///     the value of the "ELEM_COURSE_ID" field.
        /// </summary>
        private String _courseId;

        /// <summary>
        ///     the value of the "ELEM_BOOK_ID" field.
        /// </summary>
        private String _bookId;

        /// <summary>
        ///     the value of the "ELEM_WHO_PAYS" field.
        /// </summary>
        private String _whoPays;

        /// <summary>
        ///     the value of the "ELEM_CERT_NO" field.
        /// </summary>
        private String _certNo;

        /// <summary>
        ///     the value of the "ELEM_ATTENDED" field.
        /// </summary>
        private Byte? _attended;

        /// <summary>
        ///     the value of the "ELEM_USER_DATE_1" field.
        /// </summary>
        private DateTime? _userDate1;

        /// <summary>
        ///     the value of the "ELEM_USER_DATE_2" field.
        /// </summary>
        private DateTime? _userDate2;

        /// <summary>
        ///     the value of the "ELEM_USER_DATE_3" field.
        /// </summary>
        private DateTime? _userDate3;

        /// <summary>
        ///     the value of the "ELEM_USERINT_1" field.
        /// </summary>
        private Byte? _userint1;

        /// <summary>
        ///     the value of the "ELEM_USERINT_2" field.
        /// </summary>
        private Byte? _userint2;

        /// <summary>
        ///     the value of the "ELEM_USERNUM_1" field.
        /// </summary>
        private Double? _usernum1;

        /// <summary>
        ///     the value of the "ELEM_USERNUM_2" field.
        /// </summary>
        private Double? _usernum2;

        /// <summary>
        ///     the value of the "ELEM_USERNUM_3" field.
        /// </summary>
        private Double? _usernum3;

        /// <summary>
        ///     the value of the "ELEM_CURRENCY_TYPE" field.
        /// </summary>
        private String _currencyType;

        /// <summary>
        ///     the value of the "ELEM_PRICE" field.
        /// </summary>
        private Decimal _price;

        /// <summary>
        ///     the value of the "ELEM_BLOCK_PRICE" field.
        /// </summary>
        private Decimal _blockPrice;

        /// <summary>
        ///     the value of the "ELEM_PRICE_BC" field.
        /// </summary>
        private Decimal _priceBc;

        /// <summary>
        ///     the value of the "ELEM_BLOCK_PRCE_BC" field.
        /// </summary>
        private Decimal _blockPrceBc;

        /// <summary>
        ///     the value of the "ELEM_VATCD" field.
        /// </summary>
        private String _vatcd;

        /// <summary>
        ///     the value of the "ELEM_COST_CODE" field.
        /// </summary>
        private String _costCode;

        /// <summary>
        ///     the value of the "ELEM_DO_NOT_INVCE" field.
        /// </summary>
        private Byte? _doNotInvce;

        /// <summary>
        ///     the value of the "ELEM_INVOICED" field.
        /// </summary>
        private Byte? _invoiced;

        /// <summary>
        ///     the value of the "ELEM_INVOICED_DATE" field.
        /// </summary>
        private DateTime? _invoicedDate;

        /// <summary>
        ///     the value of the "ELEM_DESCRIPTION" field.
        /// </summary>
        private String _description;

        /// <summary>
        ///     the value of the "ELEM_REV_CODE" field.
        /// </summary>
        private String _revCode;

        /// <summary>
        ///     the value of the "ELEM_INVOICE_PRINT" field.
        /// </summary>
        private Byte? _invoicePrint;

        /// <summary>
        ///     the value of the "ELEM_CANCELLED" field.
        /// </summary>
        private Byte? _cancelled;

        /// <summary>
        ///     the value of the "ELEM_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "ELEM_CREDITED" field.
        /// </summary>
        private Byte? _credited;

        /// <summary>
        ///     the value of the "ELEM_NON_ATD_RSN" field.
        /// </summary>
        private String _nonAtdRsn;

        /// <summary>
        ///     the value of the "ELEM_CERT_ISE_DAT" field.
        /// </summary>
        private DateTime? _certIseDat;

        /// <summary>
        ///     the value of the "ELEM_CERT_PRN_DAT" field.
        /// </summary>
        private DateTime? _certPrnDat;

        /// <summary>
        ///     the value of the "ELEM_LCSE_NO" field.
        /// </summary>
        private String _lcseNo;

        /// <summary>
        ///     the value of the "ELEM_LCSE_ISE_DAT" field.
        /// </summary>
        private DateTime? _lcseIseDat;

        /// <summary>
        ///     the value of the "ELEM_LCSE_PRN_DAT" field.
        /// </summary>
        private DateTime? _lcsePrnDat;

        /// <summary>
        ///     the value of the "ELEM_REQ_DATE" field.
        /// </summary>
        private DateTime? _reqDate;

        /// <summary>
        ///     the value of the "ELEM_PASS" field.
        /// </summary>
        private Byte? _pass;

        /// <summary>
        ///     the value of the "ELEM_SCORE" field.
        /// </summary>
        private Decimal? _score;

        /// <summary>
        ///     the value of the "ELEM_CHOSEN" field.
        /// </summary>
        private Byte? _chosen;

        /// <summary>
        ///     the value of the "ELEM_TYPE" field.
        /// </summary>
        private Byte? _type;

        /// <summary>
        ///     the value of the "ELEM_STATUS" field.
        /// </summary>
        private Byte? _status;

        /// <summary>
        ///     the value of the "ELEM_GRADE" field.
        /// </summary>
        private String _grade;

        /// <summary>
        ///     the value of the "ELEM_PRICE_BC2" field.
        /// </summary>
        private Decimal _priceBc2;

        /// <summary>
        ///     the value of the "ELEM_BLK_PRICE_BC2" field.
        /// </summary>
        private Decimal _blkPriceBc2;

        /// <summary>
        ///     the value of the "ELEM_PAYMENT_METHD" field.
        /// </summary>
        private String _paymentMethd;

        /// <summary>
        ///     the value of the "ELEM_QTY" field.
        /// </summary>
        private Double? _qty;

        /// <summary>
        ///     the value of the "ELEM_UNT_PRICE" field.
        /// </summary>
        private Decimal _untPrice;

        /// <summary>
        ///     the value of the "ELEM_UNT_PRICE_BC" field.
        /// </summary>
        private Decimal _untPriceBc;

        /// <summary>
        ///     the value of the "ELEM_UNT_PRICE_BC2" field.
        /// </summary>
        private Decimal _untPriceBc2;

        /// <summary>
        ///     the value of the "ELEM_SHOW_SALES" field.
        /// </summary>
        private Byte? _showSales;

        /// <summary>
        ///     the value of the "ELEM_MSTC_ID" field.
        /// </summary>
        private String _mstcId;

        /// <summary>
        ///     the value of the "ELEM_LST_PRICE" field.
        /// </summary>
        private Decimal _lstPrice;

        /// <summary>
        ///     the value of the "ELEM_LST_PRICE_BC" field.
        /// </summary>
        private Decimal _lstPriceBc;

        /// <summary>
        ///     the value of the "ELEM_LST_PRICE_BC2" field.
        /// </summary>
        private Decimal _lstPriceBc2;

        /// <summary>
        ///     the value of the "ELEM_DEL_TYPE" field.
        /// </summary>
        private Byte? _delType;

        /// <summary>
        ///     the value of the "ELEM_DEL_ATTRIBS" field.
        /// </summary>
        private String _delAttribs;

        /// <summary>
        ///     the value of the "ELEM_PL_ID" field.
        /// </summary>
        private String _plId;

        /// <summary>
        ///     the value of the "ELEM_DEL_QTY" field.
        /// </summary>
        private Double? _delQty;

        /// <summary>
        ///     the value of the "ELEM_BLOCK" field.
        /// </summary>
        private Byte? _block;

        /// <summary>
        ///     the value of the "ELEM_RESULT" field.
        /// </summary>
        private String _result;

        /// <summary>
        ///     the value of the "ELEM_HISTORY" field.
        /// </summary>
        private String _history;

        /// <summary>
        ///     the value of the "ELEM_RETAIL_PRICE" field.
        /// </summary>
        private Decimal _retailPrice;

        /// <summary>
        ///     the value of the "ELEM_COST_PRICE" field.
        /// </summary>
        private Decimal _costPrice;

        /// <summary>
        ///     the value of the "ELEM_RET_PRICE_BC" field.
        /// </summary>
        private Decimal _retPriceBc;

        /// <summary>
        ///     the value of the "ELEM_CST_PRICE_BC" field.
        /// </summary>
        private Decimal _cstPriceBc;

        /// <summary>
        ///     the value of the "ELEM_RET_PRICE_BC2" field.
        /// </summary>
        private Decimal _retPriceBc2;

        /// <summary>
        ///     the value of the "ELEM_CST_PRICE_BC2" field.
        /// </summary>
        private Decimal _cstPriceBc2;

        /// <summary>
        ///     the value of the "ELEM_VAL_TO_REV" field.
        /// </summary>
        private Decimal _valToRev;

        /// <summary>
        ///     the value of the "ELEM_DEL_TYPE_DESC" field.
        /// </summary>
        private String _delTypeDesc;

        /// <summary>
        ///     the value of the "ELEM_DESCRIPTION2" field.
        /// </summary>
        private String _description2;

        /// <summary>
        ///     the value of the "ELEM_LMSP_ID" field.
        /// </summary>
        private String _lmspId;

        /// <summary>
        ///     the value of the "ELEM_SCO_START_DTE" field.
        /// </summary>
        private DateTime? _scoStartDte;

        /// <summary>
        ///     the value of the "ELEM_FAIL_RSN" field.
        /// </summary>
        private String _failRsn;

        /// <summary>
        ///     the value of the "ELEM_MAIN_SESSION" field.
        /// </summary>
        private Byte? _mainSession;

        /// <summary>
        ///     the value of the "ELEM_SELL_MSTC_ID" field.
        /// </summary>
        private String _sellMstcId;

        /// <summary>
        ///     the value of the "ELEM_PREPAY_UNITS" field.
        /// </summary>
        private Double? _prepayUnits;

        /// <summary>
        ///     the value of the "ELEM_START_DATE" field.
        /// </summary>
        private DateTime? _startDate;

        /// <summary>
        ///     the value of the "ELEM_END_DATE" field.
        /// </summary>
        private DateTime? _endDate;

        /// <summary>
        ///     the value of the "ELEM_REG_NO" field.
        /// </summary>
        private String _regNo;

        /// <summary>
        ///     the value of the "ELEM_SXREF_ID" field.
        /// </summary>
        private String _sxrefId;

        /// <summary>
        ///     the value of the "ELEM_ROOM_TYPE" field.
        /// </summary>
        private String _roomType;

        /// <summary>
        ///     the value of the "ELEM_ROOM_BED_TYPE" field.
        /// </summary>
        private String _roomBedType;

        /// <summary>
        ///     the value of the "ELEM_QTY_2" field.
        /// </summary>
        private Double? _qty2;

        /// <summary>
        ///     the value of the "ELEM_QUAL_ID" field.
        /// </summary>
        private String _qualId;

        /// <summary>
        ///     the value of the "ELEM_TICKET_PNTS" field.
        /// </summary>
        private Int32? _ticketPnts;

        /// <summary>
        ///     the value of the "ELEM_DISC_REASON" field.
        /// </summary>
        private String _discReason;

        /// <summary>
        ///     the value of the "ELEM_START_TIME" field.
        /// </summary>
        private DateTime? _startTime;

        /// <summary>
        ///     the value of the "ELEM_END_TIME" field.
        /// </summary>
        private DateTime? _endTime;

        /// <summary>
        ///     the value of the "ELEM_SST_ID" field.
        /// </summary>
        private String _sstId;

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_1" field.
        /// </summary>
        private Double? _subQty1;

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_2" field.
        /// </summary>
        private Double? _subQty2;

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_3" field.
        /// </summary>
        private Double? _subQty3;

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_4" field.
        /// </summary>
        private Double? _subQty4;

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_5" field.
        /// </summary>
        private Double? _subQty5;

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_6" field.
        /// </summary>
        private Double? _subQty6;

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_7" field.
        /// </summary>
        private Double? _subQty7;

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_8" field.
        /// </summary>
        private Double? _subQty8;

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_9" field.
        /// </summary>
        private Double? _subQty9;

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_1" field.
        /// </summary>
        private Double? _untPrc1;

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_2" field.
        /// </summary>
        private Double? _untPrc2;

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_3" field.
        /// </summary>
        private Double? _untPrc3;

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_4" field.
        /// </summary>
        private Double? _untPrc4;

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_5" field.
        /// </summary>
        private Double? _untPrc5;

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_6" field.
        /// </summary>
        private Double? _untPrc6;

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_7" field.
        /// </summary>
        private Double? _untPrc7;

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_8" field.
        /// </summary>
        private Double? _untPrc8;

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_9" field.
        /// </summary>
        private Double? _untPrc9;

        /// <summary>
        ///     the value of the "ELEM_UNT_TYPE" field.
        /// </summary>
        private String _untType;

        /// <summary>
        ///     the value of the "ELEM_VAT_AMT" field.
        /// </summary>
        private Decimal _vatAmt;

        /// <summary>
        ///     the value of the "ELEM_PRICE_CALC" field.
        /// </summary>
        private String _priceCalc;

        /// <summary>
        ///     the value of the "ELEM_DISC_AMT" field.
        /// </summary>
        private Decimal _discAmt;

        /// <summary>
        ///     the value of the "ELEM_LMSP_SUSPEND_DATA" field.
        /// </summary>
        private String _lmspSuspendData;

        /// <summary>
        ///     the value of the "ELEM_LMSP_SCORE" field.
        /// </summary>
        private Byte? _lmspScore;

        /// <summary>
        ///     the value of the "ELEM_LMSP_LESSON_STATUS" field.
        /// </summary>
        private String _lmspLessonStatus;

        /// <summary>
        ///     the value of the "ELEM_LMSP_COMMENTS" field.
        /// </summary>
        private String _lmspComments;

        /// <summary>
        ///     the value of the "ELEM_CHG_PRC_BY" field.
        /// </summary>
        private String _chgPrcBy;

        /// <summary>
        ///     the value of the "ELEM_CHG_PRC_DATE" field.
        /// </summary>
        private DateTime? _chgPrcDate;

        /// <summary>
        ///     the value of the "ELEM_CERT_PRINT_STATUS" field.
        /// </summary>
        private Byte? _certPrintStatus;

        /// <summary>
        ///     the value of the "ELEM_CR_ID" field.
        /// </summary>
        private String _crId;

        /// <summary>
        ///     the value of the "ELEM_CERT_PRN_DATE" field.
        /// </summary>
        private DateTime? _certPrnDate;

        /// <summary>
        ///     the value of the "ELEM_CERT_PRINT_ANYWAY" field.
        /// </summary>
        private Byte? _certPrintAnyway;

        /// <summary>
        ///     the value of the "ELEM_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "ELEM_CHK_IN_TIME" field.
        /// </summary>
        private DateTime? _chkInTime;

        /// <summary>
        ///     the value of the "ELEM_EXP_CHK_OUT_TIME" field.
        /// </summary>
        private DateTime? _expChkOutTime;

        /// <summary>
        ///     the value of the "ELEM_ACT_CHK_OUT_TIME" field.
        /// </summary>
        private DateTime? _actChkOutTime;

        /// <summary>
        ///     the value of the "ELEM_PRS_ID" field.
        /// </summary>
        private String _prsId;

        /// <summary>
        ///     the value of the "ELEM_TEACH_HRS" field.
        /// </summary>
        private Decimal? _teachHrs;

        /// <summary>
        ///     the value of the "ELEM_STUD_WKS" field.
        /// </summary>
        private Decimal? _studWks;

        /// <summary>
        ///     the value of the "ELEM_COMMISSION_DONE" field.
        /// </summary>
        private Byte _commissionDone;

        /// <summary>
        ///     the value of the "ELEM_COMMISSION_ELEM_ID" field.
        /// </summary>
        private String _commissionElemId;

        /// <summary>
        ///     the value of the "ELEM_AGT_ID" field.
        /// </summary>
        private Int32? _agtId;

        /// <summary>
        ///     the value of the "ELEM_EVENT_CANCEL" field.
        /// </summary>
        private Byte _eventCancel;

        /// <summary>
        ///     the value of the "ELEM_PROFORMA" field.
        /// </summary>
        private Byte? _proforma;

        /// <summary>
        ///     the value of the "ELEM_BAT_ID" field.
        /// </summary>
        private String _batId;

        /// <summary>
        ///     the value of the "ELEM_SOP_NO" field.
        /// </summary>
        private Byte? _sopNo;

        /// <summary>
        ///     the value of the "ELEM_ERROR_DESC" field.
        /// </summary>
        private String _errorDesc;

        /// <summary>
        ///     the value of the "ELEM_GRP_ID" field.
        /// </summary>
        private Int32? _grpId;

        /// <summary>
        ///     the value of the "ELEM_AUTH_STATUS" field.
        /// </summary>
        private Byte? _authStatus;

        /// <summary>
        ///     the value of the "ELEM_ELEM_ID" field.
        /// </summary>
        private String _elemId;

        /// <summary>
        ///     the value of the "ELEM_BKT_ID" field.
        /// </summary>
        private String _bktId;

        /// <summary>
        ///     the value of the "ELEM_UNIT_PRICE_DISC" field.
        /// </summary>
        private Decimal? _unitPriceDisc;

        /// <summary>
        ///     the value of the "ELEM_UNIT_PRICE_DISC_BC" field.
        /// </summary>
        private Decimal? _unitPriceDiscBc;

        /// <summary>
        ///     the value of the "ELEM_UNIT_PRICE_DISC_BC2" field.
        /// </summary>
        private Decimal? _unitPriceDiscBc2;

        /// <summary>
        ///     the value of the "ELEM_UNIT_DISCOUNT" field.
        /// </summary>
        private Decimal? _unitDiscount;

        /// <summary>
        ///     the value of the "ELEM_UNIT_DISCOUNT_BC" field.
        /// </summary>
        private Decimal? _unitDiscountBc;

        /// <summary>
        ///     the value of the "ELEM_UNIT_DISCOUNT_BC2" field.
        /// </summary>
        private Decimal? _unitDiscountBc2;

        /// <summary>
        ///     the value of the "ELEM_PRICE_DISC" field.
        /// </summary>
        private Decimal? _priceDisc;

        /// <summary>
        ///     the value of the "ELEM_PRICE_DISC_BC" field.
        /// </summary>
        private Decimal? _priceDiscBc;

        /// <summary>
        ///     the value of the "ELEM_PRICE_DISC_BC2" field.
        /// </summary>
        private Decimal? _priceDiscBc2;

        /// <summary>
        ///     the value of the "ELEM_DISCOUNT" field.
        /// </summary>
        private Decimal? _discount;

        /// <summary>
        ///     the value of the "ELEM_DISCOUNT_BC" field.
        /// </summary>
        private Decimal? _discountBc;

        /// <summary>
        ///     the value of the "ELEM_DISCOUNT_BC2" field.
        /// </summary>
        private Decimal? _discountBc2;

        /// <summary>
        ///     the value of the "ELEM_EXT_STATUS" field.
        /// </summary>
        private String _extStatus;

        /// <summary>
        ///     the value of the "ELEM_CURR_RATE_BC" field.
        /// </summary>
        private Decimal? _currRateBc;

        /// <summary>
        ///     the value of the "ELEM_CURR_RATE_BC2" field.
        /// </summary>
        private Decimal? _currRateBc2;

        /// <summary>
        ///     the value of the "ELEM_SENT_DATE" field.
        /// </summary>
        private DateTime? _sentDate;

        /// <summary>
        ///     the value of the "ELEM_DELIV_DATE" field.
        /// </summary>
        private DateTime? _delivDate;

        /// <summary>
        ///     the value of the "ELEM_RET_DATE" field.
        /// </summary>
        private DateTime? _retDate;

        /// <summary>
        ///     the value of the "ELEM_DELIVER_TO_DEL" field.
        /// </summary>
        private Byte _deliverToDel;

        /// <summary>
        ///     the value of the "ELEM_BOM_ID" field.
        /// </summary>
        private String _bomId;

        /// <summary>
        ///     the value of the "ELEM_DISC_ID" field.
        /// </summary>
        private Int32? _discId;

        /// <summary>
        ///     the value of the "ELEM_EXCL_DISCAMT" field.
        /// </summary>
        private Byte? _exclDiscamt;

        /// <summary>
        ///     the value of the "ELEM_DISC_APPLIED_DATE" field.
        /// </summary>
        private DateTime? _discAppliedDate;

        /// <summary>
        ///     the value of the "ELEM_BOOK_GROUP" field.
        /// </summary>
        private String _bookGroup;

        /// <summary>
        ///     the value of the "ELEM_RECOMMENDED" field.
        /// </summary>
        private Byte _recommended;

        /// <summary>
        ///     the value of the "ELEM_MANDATORY" field.
        /// </summary>
        private Byte _mandatory;

        /// <summary>
        ///     the value of the "ELEM_ST_ELEM_ID" field.
        /// </summary>
        private String _stElemId;

        /// <summary>
        ///     the value of the "ELEM_UNIQUE_REF" field.
        /// </summary>
        private String _uniqueRef;

        /// <summary>
        ///     the value of the "ELEM_PARTNER_SYS_REF" field.
        /// </summary>
        private String _partnerSysRef;

        /// <summary>
        ///     the value of the "ELEM_QUO_DET_ID" field.
        /// </summary>
        private String _quoDetId;

        /// <summary>
        ///     the value of the "ELEM_CERT_EXPY_DATE" field.
        /// </summary>
        private DateTime? _certExpyDate;

        /// <summary>
        ///     the value of the "ELEM_AUTH_PROLE_ID" field.
        /// </summary>
        private String _authProleId;

        /// <summary>
        ///     the value of the "ELEM_AUTH_ASSO_TYPE" field.
        /// </summary>
        private Byte? _authAssoType;

        /// <summary>
        ///     the value of the "ELEM_AUTH_CODE" field.
        /// </summary>
        private String _authCode;

        /// <summary>
        ///     the value of the "ELEM_AUTH_REQ_DATE" field.
        /// </summary>
        private DateTime? _authReqDate;

        /// <summary>
        ///     the value of the "ELEM_LAST_AUTH_PROLE_ID" field.
        /// </summary>
        private String _lastAuthProleId;

        /// <summary>
        ///     the value of the "ELEM_AUTH_LAST_COMMENTS" field.
        /// </summary>
        private String _authLastComments;

        /// <summary>
        ///     the value of the "ELEM_PSH_ID" field.
        /// </summary>
        private Int32? _pshId;

        /// <summary>
        ///     the value of the "ELEM_BLOCK_DEL" field.
        /// </summary>
        private Byte? _blockDel;

        /// <summary>
        ///     the value of the "ELEM_PRS_TYPE" field.
        /// </summary>
        private Byte _prsType;

        /// <summary>
        ///     the value of the "ELEM_CANCEL_DATE" field.
        /// </summary>
        private DateTime? _cancelDate;

        /// <summary>
        ///     the value of the "ELEM_SCORE_1" field.
        /// </summary>
        private Decimal _score1;

        /// <summary>
        ///     the value of the "ELEM_SCORE_2" field.
        /// </summary>
        private Decimal _score2;

        /// <summary>
        ///     the value of the "ELEM_SCORE_3" field.
        /// </summary>
        private Decimal _score3;

        /// <summary>
        ///     the value of the "ELEM_SCORE_4" field.
        /// </summary>
        private Decimal _score4;

        /// <summary>
        ///     the value of the "ELEM_SCORE_5" field.
        /// </summary>
        private Decimal _score5;

        /// <summary>
        ///     the value of the "ELEM_SCORE_6" field.
        /// </summary>
        private Decimal _score6;

        /// <summary>
        ///     the value of the "ELEM_PDPE_ID" field.
        /// </summary>
        private String _pdpeId;

        /// <summary>
        ///     the value of the "ELEM_SCO_END_DTE" field.
        /// </summary>
        private DateTime? _scoEndDte;

        /// <summary>
        ///     the value of the "ELEM_LMSP_TOTAL_TIME" field.
        /// </summary>
        private String _lmspTotalTime;

        /// <summary>
        ///     the value of the "ELEM_LMSP_LESSON_LOCATION" field.
        /// </summary>
        private String _lmspLessonLocation;

        /// <summary>
        ///     the value of the "ELEM_LMSP_COMPLETES" field.
        /// </summary>
        private Int32 _lmspCompletes;

        /// <summary>
        ///     the value of the "ELEM_GIFT_AID" field.
        /// </summary>
        private Byte _giftAid;

        /// <summary>
        ///     the value of the "ELEM_CLAIMED" field.
        /// </summary>
        private Byte _claimed;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ELEM_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DEL_ID" field.
        /// </summary>
        public String DelId
        {
            get { return _delId; }
            set { _delId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_ACT_ID" field.
        /// </summary>
        public String ActId
        {
            get { return _actId; }
            set { _actId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_COURSE_ID" field.
        /// </summary>
        public String CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_BOOK_ID" field.
        /// </summary>
        public String BookId
        {
            get { return _bookId; }
            set { _bookId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_WHO_PAYS" field.
        /// </summary>
        public String WhoPays
        {
            get { return _whoPays; }
            set { _whoPays = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CERT_NO" field.
        /// </summary>
        public String CertNo
        {
            get { return _certNo; }
            set { _certNo = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_ATTENDED" field.
        /// </summary>
        public Byte? Attended
        {
            get { return _attended; }
            set { _attended = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_USER_DATE_1" field.
        /// </summary>
        public DateTime? UserDate1
        {
            get { return _userDate1; }
            set { _userDate1 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_USER_DATE_2" field.
        /// </summary>
        public DateTime? UserDate2
        {
            get { return _userDate2; }
            set { _userDate2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_USER_DATE_3" field.
        /// </summary>
        public DateTime? UserDate3
        {
            get { return _userDate3; }
            set { _userDate3 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_USERINT_1" field.
        /// </summary>
        public Byte? Userint1
        {
            get { return _userint1; }
            set { _userint1 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_USERINT_2" field.
        /// </summary>
        public Byte? Userint2
        {
            get { return _userint2; }
            set { _userint2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_USERNUM_1" field.
        /// </summary>
        public Double? Usernum1
        {
            get { return _usernum1; }
            set { _usernum1 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_USERNUM_2" field.
        /// </summary>
        public Double? Usernum2
        {
            get { return _usernum2; }
            set { _usernum2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_USERNUM_3" field.
        /// </summary>
        public Double? Usernum3
        {
            get { return _usernum3; }
            set { _usernum3 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CURRENCY_TYPE" field.
        /// </summary>
        public String CurrencyType
        {
            get { return _currencyType; }
            set { _currencyType = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PRICE" field.
        /// </summary>
        public Decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_BLOCK_PRICE" field.
        /// </summary>
        public Decimal BlockPrice
        {
            get { return _blockPrice; }
            set { _blockPrice = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PRICE_BC" field.
        /// </summary>
        public Decimal PriceBc
        {
            get { return _priceBc; }
            set { _priceBc = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_BLOCK_PRCE_BC" field.
        /// </summary>
        public Decimal BlockPrceBc
        {
            get { return _blockPrceBc; }
            set { _blockPrceBc = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_VATCD" field.
        /// </summary>
        public String Vatcd
        {
            get { return _vatcd; }
            set { _vatcd = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return _costCode; }
            set { _costCode = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DO_NOT_INVCE" field.
        /// </summary>
        public Byte? DoNotInvce
        {
            get { return _doNotInvce; }
            set { _doNotInvce = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_INVOICED" field.
        /// </summary>
        public Byte? Invoiced
        {
            get { return _invoiced; }
            set { _invoiced = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_INVOICED_DATE" field.
        /// </summary>
        public DateTime? InvoicedDate
        {
            get { return _invoicedDate; }
            set { _invoicedDate = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_REV_CODE" field.
        /// </summary>
        public String RevCode
        {
            get { return _revCode; }
            set { _revCode = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_INVOICE_PRINT" field.
        /// </summary>
        public Byte? InvoicePrint
        {
            get { return _invoicePrint; }
            set { _invoicePrint = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CANCELLED" field.
        /// </summary>
        public Byte? Cancelled
        {
            get { return _cancelled; }
            set { _cancelled = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CREDITED" field.
        /// </summary>
        public Byte? Credited
        {
            get { return _credited; }
            set { _credited = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_NON_ATD_RSN" field.
        /// </summary>
        public String NonAtdRsn
        {
            get { return _nonAtdRsn; }
            set { _nonAtdRsn = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CERT_ISE_DAT" field.
        /// </summary>
        public DateTime? CertIseDat
        {
            get { return _certIseDat; }
            set { _certIseDat = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CERT_PRN_DAT" field.
        /// </summary>
        public DateTime? CertPrnDat
        {
            get { return _certPrnDat; }
            set { _certPrnDat = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_LCSE_NO" field.
        /// </summary>
        public String LcseNo
        {
            get { return _lcseNo; }
            set { _lcseNo = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_LCSE_ISE_DAT" field.
        /// </summary>
        public DateTime? LcseIseDat
        {
            get { return _lcseIseDat; }
            set { _lcseIseDat = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_LCSE_PRN_DAT" field.
        /// </summary>
        public DateTime? LcsePrnDat
        {
            get { return _lcsePrnDat; }
            set { _lcsePrnDat = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_REQ_DATE" field.
        /// </summary>
        public DateTime? ReqDate
        {
            get { return _reqDate; }
            set { _reqDate = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PASS" field.
        /// </summary>
        public Byte? Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SCORE" field.
        /// </summary>
        public Decimal? Score
        {
            get { return _score; }
            set { _score = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CHOSEN" field.
        /// </summary>
        public Byte? Chosen
        {
            get { return _chosen; }
            set { _chosen = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_STATUS" field.
        /// </summary>
        public Byte? Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_GRADE" field.
        /// </summary>
        public String Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PRICE_BC2" field.
        /// </summary>
        public Decimal PriceBc2
        {
            get { return _priceBc2; }
            set { _priceBc2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_BLK_PRICE_BC2" field.
        /// </summary>
        public Decimal BlkPriceBc2
        {
            get { return _blkPriceBc2; }
            set { _blkPriceBc2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PAYMENT_METHD" field.
        /// </summary>
        public String PaymentMethd
        {
            get { return _paymentMethd; }
            set { _paymentMethd = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_QTY" field.
        /// </summary>
        public Double? Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNT_PRICE" field.
        /// </summary>
        public Decimal UntPrice
        {
            get { return _untPrice; }
            set { _untPrice = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNT_PRICE_BC" field.
        /// </summary>
        public Decimal UntPriceBc
        {
            get { return _untPriceBc; }
            set { _untPriceBc = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNT_PRICE_BC2" field.
        /// </summary>
        public Decimal UntPriceBc2
        {
            get { return _untPriceBc2; }
            set { _untPriceBc2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SHOW_SALES" field.
        /// </summary>
        public Byte? ShowSales
        {
            get { return _showSales; }
            set { _showSales = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_MSTC_ID" field.
        /// </summary>
        public String MstcId
        {
            get { return _mstcId; }
            set { _mstcId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_LST_PRICE" field.
        /// </summary>
        public Decimal LstPrice
        {
            get { return _lstPrice; }
            set { _lstPrice = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_LST_PRICE_BC" field.
        /// </summary>
        public Decimal LstPriceBc
        {
            get { return _lstPriceBc; }
            set { _lstPriceBc = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_LST_PRICE_BC2" field.
        /// </summary>
        public Decimal LstPriceBc2
        {
            get { return _lstPriceBc2; }
            set { _lstPriceBc2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DEL_TYPE" field.
        /// </summary>
        public Byte? DelType
        {
            get { return _delType; }
            set { _delType = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DEL_ATTRIBS" field.
        /// </summary>
        public String DelAttribs
        {
            get { return _delAttribs; }
            set { _delAttribs = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PL_ID" field.
        /// </summary>
        public String PlId
        {
            get { return _plId; }
            set { _plId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DEL_QTY" field.
        /// </summary>
        public Double? DelQty
        {
            get { return _delQty; }
            set { _delQty = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_BLOCK" field.
        /// </summary>
        public Byte? Block
        {
            get { return _block; }
            set { _block = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_RESULT" field.
        /// </summary>
        public String Result
        {
            get { return _result; }
            set { _result = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_HISTORY" field.
        /// </summary>
        public String History
        {
            get { return _history; }
            set { _history = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_RETAIL_PRICE" field.
        /// </summary>
        public Decimal RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_COST_PRICE" field.
        /// </summary>
        public Decimal CostPrice
        {
            get { return _costPrice; }
            set { _costPrice = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_RET_PRICE_BC" field.
        /// </summary>
        public Decimal RetPriceBc
        {
            get { return _retPriceBc; }
            set { _retPriceBc = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CST_PRICE_BC" field.
        /// </summary>
        public Decimal CstPriceBc
        {
            get { return _cstPriceBc; }
            set { _cstPriceBc = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_RET_PRICE_BC2" field.
        /// </summary>
        public Decimal RetPriceBc2
        {
            get { return _retPriceBc2; }
            set { _retPriceBc2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CST_PRICE_BC2" field.
        /// </summary>
        public Decimal CstPriceBc2
        {
            get { return _cstPriceBc2; }
            set { _cstPriceBc2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_VAL_TO_REV" field.
        /// </summary>
        public Decimal ValToRev
        {
            get { return _valToRev; }
            set { _valToRev = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DEL_TYPE_DESC" field.
        /// </summary>
        public String DelTypeDesc
        {
            get { return _delTypeDesc; }
            set { _delTypeDesc = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DESCRIPTION2" field.
        /// </summary>
        public String Description2
        {
            get { return _description2; }
            set { _description2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_LMSP_ID" field.
        /// </summary>
        public String LmspId
        {
            get { return _lmspId; }
            set { _lmspId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SCO_START_DTE" field.
        /// </summary>
        public DateTime? ScoStartDte
        {
            get { return _scoStartDte; }
            set { _scoStartDte = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_FAIL_RSN" field.
        /// </summary>
        public String FailRsn
        {
            get { return _failRsn; }
            set { _failRsn = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_MAIN_SESSION" field.
        /// </summary>
        public Byte? MainSession
        {
            get { return _mainSession; }
            set { _mainSession = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SELL_MSTC_ID" field.
        /// </summary>
        public String SellMstcId
        {
            get { return _sellMstcId; }
            set { _sellMstcId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PREPAY_UNITS" field.
        /// </summary>
        public Double? PrepayUnits
        {
            get { return _prepayUnits; }
            set { _prepayUnits = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_REG_NO" field.
        /// </summary>
        public String RegNo
        {
            get { return _regNo; }
            set { _regNo = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SXREF_ID" field.
        /// </summary>
        public String SxrefId
        {
            get { return _sxrefId; }
            set { _sxrefId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_ROOM_TYPE" field.
        /// </summary>
        public String RoomType
        {
            get { return _roomType; }
            set { _roomType = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_ROOM_BED_TYPE" field.
        /// </summary>
        public String RoomBedType
        {
            get { return _roomBedType; }
            set { _roomBedType = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_QTY_2" field.
        /// </summary>
        public Double? Qty2
        {
            get { return _qty2; }
            set { _qty2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_QUAL_ID" field.
        /// </summary>
        public String QualId
        {
            get { return _qualId; }
            set { _qualId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_TICKET_PNTS" field.
        /// </summary>
        public Int32? TicketPnts
        {
            get { return _ticketPnts; }
            set { _ticketPnts = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DISC_REASON" field.
        /// </summary>
        public String DiscReason
        {
            get { return _discReason; }
            set { _discReason = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_START_TIME" field.
        /// </summary>
        public DateTime? StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_END_TIME" field.
        /// </summary>
        public DateTime? EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SST_ID" field.
        /// </summary>
        public String SstId
        {
            get { return _sstId; }
            set { _sstId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_1" field.
        /// </summary>
        public Double? SubQty1
        {
            get { return _subQty1; }
            set { _subQty1 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_2" field.
        /// </summary>
        public Double? SubQty2
        {
            get { return _subQty2; }
            set { _subQty2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_3" field.
        /// </summary>
        public Double? SubQty3
        {
            get { return _subQty3; }
            set { _subQty3 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_4" field.
        /// </summary>
        public Double? SubQty4
        {
            get { return _subQty4; }
            set { _subQty4 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_5" field.
        /// </summary>
        public Double? SubQty5
        {
            get { return _subQty5; }
            set { _subQty5 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_6" field.
        /// </summary>
        public Double? SubQty6
        {
            get { return _subQty6; }
            set { _subQty6 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_7" field.
        /// </summary>
        public Double? SubQty7
        {
            get { return _subQty7; }
            set { _subQty7 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_8" field.
        /// </summary>
        public Double? SubQty8
        {
            get { return _subQty8; }
            set { _subQty8 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SUB_QTY_9" field.
        /// </summary>
        public Double? SubQty9
        {
            get { return _subQty9; }
            set { _subQty9 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_1" field.
        /// </summary>
        public Double? UntPrc1
        {
            get { return _untPrc1; }
            set { _untPrc1 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_2" field.
        /// </summary>
        public Double? UntPrc2
        {
            get { return _untPrc2; }
            set { _untPrc2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_3" field.
        /// </summary>
        public Double? UntPrc3
        {
            get { return _untPrc3; }
            set { _untPrc3 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_4" field.
        /// </summary>
        public Double? UntPrc4
        {
            get { return _untPrc4; }
            set { _untPrc4 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_5" field.
        /// </summary>
        public Double? UntPrc5
        {
            get { return _untPrc5; }
            set { _untPrc5 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_6" field.
        /// </summary>
        public Double? UntPrc6
        {
            get { return _untPrc6; }
            set { _untPrc6 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_7" field.
        /// </summary>
        public Double? UntPrc7
        {
            get { return _untPrc7; }
            set { _untPrc7 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_8" field.
        /// </summary>
        public Double? UntPrc8
        {
            get { return _untPrc8; }
            set { _untPrc8 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNT_PRC_9" field.
        /// </summary>
        public Double? UntPrc9
        {
            get { return _untPrc9; }
            set { _untPrc9 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNT_TYPE" field.
        /// </summary>
        public String UntType
        {
            get { return _untType; }
            set { _untType = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_VAT_AMT" field.
        /// </summary>
        public Decimal VatAmt
        {
            get { return _vatAmt; }
            set { _vatAmt = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PRICE_CALC" field.
        /// </summary>
        public String PriceCalc
        {
            get { return _priceCalc; }
            set { _priceCalc = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DISC_AMT" field.
        /// </summary>
        public Decimal DiscAmt
        {
            get { return _discAmt; }
            set { _discAmt = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_LMSP_SUSPEND_DATA" field.
        /// </summary>
        public String LmspSuspendData
        {
            get { return _lmspSuspendData; }
            set { _lmspSuspendData = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_LMSP_SCORE" field.
        /// </summary>
        public Byte? LmspScore
        {
            get { return _lmspScore; }
            set { _lmspScore = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_LMSP_LESSON_STATUS" field.
        /// </summary>
        public String LmspLessonStatus
        {
            get { return _lmspLessonStatus; }
            set { _lmspLessonStatus = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_LMSP_COMMENTS" field.
        /// </summary>
        public String LmspComments
        {
            get { return _lmspComments; }
            set { _lmspComments = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CHG_PRC_BY" field.
        /// </summary>
        public String ChgPrcBy
        {
            get { return _chgPrcBy; }
            set { _chgPrcBy = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CHG_PRC_DATE" field.
        /// </summary>
        public DateTime? ChgPrcDate
        {
            get { return _chgPrcDate; }
            set { _chgPrcDate = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CERT_PRINT_STATUS" field.
        /// </summary>
        public Byte? CertPrintStatus
        {
            get { return _certPrintStatus; }
            set { _certPrintStatus = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CR_ID" field.
        /// </summary>
        public String CrId
        {
            get { return _crId; }
            set { _crId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CERT_PRN_DATE" field.
        /// </summary>
        public DateTime? CertPrnDate
        {
            get { return _certPrnDate; }
            set { _certPrnDate = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CERT_PRINT_ANYWAY" field.
        /// </summary>
        public Byte? CertPrintAnyway
        {
            get { return _certPrintAnyway; }
            set { _certPrintAnyway = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CHK_IN_TIME" field.
        /// </summary>
        public DateTime? ChkInTime
        {
            get { return _chkInTime; }
            set { _chkInTime = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_EXP_CHK_OUT_TIME" field.
        /// </summary>
        public DateTime? ExpChkOutTime
        {
            get { return _expChkOutTime; }
            set { _expChkOutTime = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_ACT_CHK_OUT_TIME" field.
        /// </summary>
        public DateTime? ActChkOutTime
        {
            get { return _actChkOutTime; }
            set { _actChkOutTime = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PRS_ID" field.
        /// </summary>
        public String PrsId
        {
            get { return _prsId; }
            set { _prsId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_TEACH_HRS" field.
        /// </summary>
        public Decimal? TeachHrs
        {
            get { return _teachHrs; }
            set { _teachHrs = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_STUD_WKS" field.
        /// </summary>
        public Decimal? StudWks
        {
            get { return _studWks; }
            set { _studWks = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_COMMISSION_DONE" field.
        /// </summary>
        public Byte CommissionDone
        {
            get { return _commissionDone; }
            set { _commissionDone = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_COMMISSION_ELEM_ID" field.
        /// </summary>
        public String CommissionElemId
        {
            get { return _commissionElemId; }
            set { _commissionElemId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_AGT_ID" field.
        /// </summary>
        public Int32? AgtId
        {
            get { return _agtId; }
            set { _agtId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_EVENT_CANCEL" field.
        /// </summary>
        public Byte EventCancel
        {
            get { return _eventCancel; }
            set { _eventCancel = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PROFORMA" field.
        /// </summary>
        public Byte? Proforma
        {
            get { return _proforma; }
            set { _proforma = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_BAT_ID" field.
        /// </summary>
        public String BatId
        {
            get { return _batId; }
            set { _batId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SOP_NO" field.
        /// </summary>
        public Byte? SopNo
        {
            get { return _sopNo; }
            set { _sopNo = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_ERROR_DESC" field.
        /// </summary>
        public String ErrorDesc
        {
            get { return _errorDesc; }
            set { _errorDesc = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_GRP_ID" field.
        /// </summary>
        public Int32? GrpId
        {
            get { return _grpId; }
            set { _grpId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_AUTH_STATUS" field.
        /// </summary>
        public Byte? AuthStatus
        {
            get { return _authStatus; }
            set { _authStatus = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_ELEM_ID" field.
        /// </summary>
        public String ElemId
        {
            get { return _elemId; }
            set { _elemId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_BKT_ID" field.
        /// </summary>
        public String BktId
        {
            get { return _bktId; }
            set { _bktId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNIT_PRICE_DISC" field.
        /// </summary>
        public Decimal? UnitPriceDisc
        {
            get { return _unitPriceDisc; }
            set { _unitPriceDisc = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNIT_PRICE_DISC_BC" field.
        /// </summary>
        public Decimal? UnitPriceDiscBc
        {
            get { return _unitPriceDiscBc; }
            set { _unitPriceDiscBc = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNIT_PRICE_DISC_BC2" field.
        /// </summary>
        public Decimal? UnitPriceDiscBc2
        {
            get { return _unitPriceDiscBc2; }
            set { _unitPriceDiscBc2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNIT_DISCOUNT" field.
        /// </summary>
        public Decimal? UnitDiscount
        {
            get { return _unitDiscount; }
            set { _unitDiscount = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNIT_DISCOUNT_BC" field.
        /// </summary>
        public Decimal? UnitDiscountBc
        {
            get { return _unitDiscountBc; }
            set { _unitDiscountBc = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNIT_DISCOUNT_BC2" field.
        /// </summary>
        public Decimal? UnitDiscountBc2
        {
            get { return _unitDiscountBc2; }
            set { _unitDiscountBc2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PRICE_DISC" field.
        /// </summary>
        public Decimal? PriceDisc
        {
            get { return _priceDisc; }
            set { _priceDisc = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PRICE_DISC_BC" field.
        /// </summary>
        public Decimal? PriceDiscBc
        {
            get { return _priceDiscBc; }
            set { _priceDiscBc = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PRICE_DISC_BC2" field.
        /// </summary>
        public Decimal? PriceDiscBc2
        {
            get { return _priceDiscBc2; }
            set { _priceDiscBc2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DISCOUNT" field.
        /// </summary>
        public Decimal? Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DISCOUNT_BC" field.
        /// </summary>
        public Decimal? DiscountBc
        {
            get { return _discountBc; }
            set { _discountBc = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DISCOUNT_BC2" field.
        /// </summary>
        public Decimal? DiscountBc2
        {
            get { return _discountBc2; }
            set { _discountBc2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_EXT_STATUS" field.
        /// </summary>
        public String ExtStatus
        {
            get { return _extStatus; }
            set { _extStatus = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CURR_RATE_BC" field.
        /// </summary>
        public Decimal? CurrRateBc
        {
            get { return _currRateBc; }
            set { _currRateBc = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CURR_RATE_BC2" field.
        /// </summary>
        public Decimal? CurrRateBc2
        {
            get { return _currRateBc2; }
            set { _currRateBc2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SENT_DATE" field.
        /// </summary>
        public DateTime? SentDate
        {
            get { return _sentDate; }
            set { _sentDate = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DELIV_DATE" field.
        /// </summary>
        public DateTime? DelivDate
        {
            get { return _delivDate; }
            set { _delivDate = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_RET_DATE" field.
        /// </summary>
        public DateTime? RetDate
        {
            get { return _retDate; }
            set { _retDate = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DELIVER_TO_DEL" field.
        /// </summary>
        public Byte DeliverToDel
        {
            get { return _deliverToDel; }
            set { _deliverToDel = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_BOM_ID" field.
        /// </summary>
        public String BomId
        {
            get { return _bomId; }
            set { _bomId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DISC_ID" field.
        /// </summary>
        public Int32? DiscId
        {
            get { return _discId; }
            set { _discId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_EXCL_DISCAMT" field.
        /// </summary>
        public Byte? ExclDiscamt
        {
            get { return _exclDiscamt; }
            set { _exclDiscamt = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_DISC_APPLIED_DATE" field.
        /// </summary>
        public DateTime? DiscAppliedDate
        {
            get { return _discAppliedDate; }
            set { _discAppliedDate = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_BOOK_GROUP" field.
        /// </summary>
        public String BookGroup
        {
            get { return _bookGroup; }
            set { _bookGroup = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_RECOMMENDED" field.
        /// </summary>
        public Byte Recommended
        {
            get { return _recommended; }
            set { _recommended = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_MANDATORY" field.
        /// </summary>
        public Byte Mandatory
        {
            get { return _mandatory; }
            set { _mandatory = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_ST_ELEM_ID" field.
        /// </summary>
        public String StElemId
        {
            get { return _stElemId; }
            set { _stElemId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_UNIQUE_REF" field.
        /// </summary>
        public String UniqueRef
        {
            get { return _uniqueRef; }
            set { _uniqueRef = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PARTNER_SYS_REF" field.
        /// </summary>
        public String PartnerSysRef
        {
            get { return _partnerSysRef; }
            set { _partnerSysRef = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_QUO_DET_ID" field.
        /// </summary>
        public String QuoDetId
        {
            get { return _quoDetId; }
            set { _quoDetId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CERT_EXPY_DATE" field.
        /// </summary>
        public DateTime? CertExpyDate
        {
            get { return _certExpyDate; }
            set { _certExpyDate = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_AUTH_PROLE_ID" field.
        /// </summary>
        public String AuthProleId
        {
            get { return _authProleId; }
            set { _authProleId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_AUTH_ASSO_TYPE" field.
        /// </summary>
        public Byte? AuthAssoType
        {
            get { return _authAssoType; }
            set { _authAssoType = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_AUTH_CODE" field.
        /// </summary>
        public String AuthCode
        {
            get { return _authCode; }
            set { _authCode = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_AUTH_REQ_DATE" field.
        /// </summary>
        public DateTime? AuthReqDate
        {
            get { return _authReqDate; }
            set { _authReqDate = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_LAST_AUTH_PROLE_ID" field.
        /// </summary>
        public String LastAuthProleId
        {
            get { return _lastAuthProleId; }
            set { _lastAuthProleId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_AUTH_LAST_COMMENTS" field.
        /// </summary>
        public String AuthLastComments
        {
            get { return _authLastComments; }
            set { _authLastComments = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PSH_ID" field.
        /// </summary>
        public Int32? PshId
        {
            get { return _pshId; }
            set { _pshId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_BLOCK_DEL" field.
        /// </summary>
        public Byte? BlockDel
        {
            get { return _blockDel; }
            set { _blockDel = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PRS_TYPE" field.
        /// </summary>
        public Byte PrsType
        {
            get { return _prsType; }
            set { _prsType = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CANCEL_DATE" field.
        /// </summary>
        public DateTime? CancelDate
        {
            get { return _cancelDate; }
            set { _cancelDate = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SCORE_1" field.
        /// </summary>
        public Decimal Score1
        {
            get { return _score1; }
            set { _score1 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SCORE_2" field.
        /// </summary>
        public Decimal Score2
        {
            get { return _score2; }
            set { _score2 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SCORE_3" field.
        /// </summary>
        public Decimal Score3
        {
            get { return _score3; }
            set { _score3 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SCORE_4" field.
        /// </summary>
        public Decimal Score4
        {
            get { return _score4; }
            set { _score4 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SCORE_5" field.
        /// </summary>
        public Decimal Score5
        {
            get { return _score5; }
            set { _score5 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SCORE_6" field.
        /// </summary>
        public Decimal Score6
        {
            get { return _score6; }
            set { _score6 = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_PDPE_ID" field.
        /// </summary>
        public String PdpeId
        {
            get { return _pdpeId; }
            set { _pdpeId = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_SCO_END_DTE" field.
        /// </summary>
        public DateTime? ScoEndDte
        {
            get { return _scoEndDte; }
            set { _scoEndDte = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_LMSP_TOTAL_TIME" field.
        /// </summary>
        public String LmspTotalTime
        {
            get { return _lmspTotalTime; }
            set { _lmspTotalTime = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_LMSP_LESSON_LOCATION" field.
        /// </summary>
        public String LmspLessonLocation
        {
            get { return _lmspLessonLocation; }
            set { _lmspLessonLocation = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_LMSP_COMPLETES" field.
        /// </summary>
        public Int32 LmspCompletes
        {
            get { return _lmspCompletes; }
            set { _lmspCompletes = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_GIFT_AID" field.
        /// </summary>
        public Byte GiftAid
        {
            get { return _giftAid; }
            set { _giftAid = value; }
        }

        /// <summary>
        ///     the value of the "ELEM_CLAIMED" field.
        /// </summary>
        public Byte Claimed
        {
            get { return _claimed; }
            set { _claimed = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ElementRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ElementRecord" /> object instance.
        /// </returns>
        public ElementRecord Clone()
        {
            ElementRecord record = new ElementRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.DelId = this.DelId;
            record.ProdId = this.ProdId;
            record.ActId = this.ActId;
            record.CourseId = this.CourseId;
            record.BookId = this.BookId;
            record.WhoPays = this.WhoPays;
            record.CertNo = this.CertNo;
            record.Attended = this.Attended;
            record.UserDate1 = this.UserDate1;
            record.UserDate2 = this.UserDate2;
            record.UserDate3 = this.UserDate3;
            record.Userint1 = this.Userint1;
            record.Userint2 = this.Userint2;
            record.Usernum1 = this.Usernum1;
            record.Usernum2 = this.Usernum2;
            record.Usernum3 = this.Usernum3;
            record.CurrencyType = this.CurrencyType;
            record.Price = this.Price;
            record.BlockPrice = this.BlockPrice;
            record.PriceBc = this.PriceBc;
            record.BlockPrceBc = this.BlockPrceBc;
            record.Vatcd = this.Vatcd;
            record.CostCode = this.CostCode;
            record.DoNotInvce = this.DoNotInvce;
            record.Invoiced = this.Invoiced;
            record.InvoicedDate = this.InvoicedDate;
            record.Description = this.Description;
            record.RevCode = this.RevCode;
            record.InvoicePrint = this.InvoicePrint;
            record.Cancelled = this.Cancelled;
            record.Notes = this.Notes;
            record.Credited = this.Credited;
            record.NonAtdRsn = this.NonAtdRsn;
            record.CertIseDat = this.CertIseDat;
            record.CertPrnDat = this.CertPrnDat;
            record.LcseNo = this.LcseNo;
            record.LcseIseDat = this.LcseIseDat;
            record.LcsePrnDat = this.LcsePrnDat;
            record.ReqDate = this.ReqDate;
            record.Pass = this.Pass;
            record.Score = this.Score;
            record.Chosen = this.Chosen;
            record.Type = this.Type;
            record.Status = this.Status;
            record.Grade = this.Grade;
            record.PriceBc2 = this.PriceBc2;
            record.BlkPriceBc2 = this.BlkPriceBc2;
            record.PaymentMethd = this.PaymentMethd;
            record.Qty = this.Qty;
            record.UntPrice = this.UntPrice;
            record.UntPriceBc = this.UntPriceBc;
            record.UntPriceBc2 = this.UntPriceBc2;
            record.ShowSales = this.ShowSales;
            record.MstcId = this.MstcId;
            record.LstPrice = this.LstPrice;
            record.LstPriceBc = this.LstPriceBc;
            record.LstPriceBc2 = this.LstPriceBc2;
            record.DelType = this.DelType;
            record.DelAttribs = this.DelAttribs;
            record.PlId = this.PlId;
            record.DelQty = this.DelQty;
            record.Block = this.Block;
            record.Result = this.Result;
            record.History = this.History;
            record.RetailPrice = this.RetailPrice;
            record.CostPrice = this.CostPrice;
            record.RetPriceBc = this.RetPriceBc;
            record.CstPriceBc = this.CstPriceBc;
            record.RetPriceBc2 = this.RetPriceBc2;
            record.CstPriceBc2 = this.CstPriceBc2;
            record.ValToRev = this.ValToRev;
            record.DelTypeDesc = this.DelTypeDesc;
            record.Description2 = this.Description2;
            record.LmspId = this.LmspId;
            record.ScoStartDte = this.ScoStartDte;
            record.FailRsn = this.FailRsn;
            record.MainSession = this.MainSession;
            record.SellMstcId = this.SellMstcId;
            record.PrepayUnits = this.PrepayUnits;
            record.StartDate = this.StartDate;
            record.EndDate = this.EndDate;
            record.RegNo = this.RegNo;
            record.SxrefId = this.SxrefId;
            record.RoomType = this.RoomType;
            record.RoomBedType = this.RoomBedType;
            record.Qty2 = this.Qty2;
            record.QualId = this.QualId;
            record.TicketPnts = this.TicketPnts;
            record.DiscReason = this.DiscReason;
            record.StartTime = this.StartTime;
            record.EndTime = this.EndTime;
            record.SstId = this.SstId;
            record.SubQty1 = this.SubQty1;
            record.SubQty2 = this.SubQty2;
            record.SubQty3 = this.SubQty3;
            record.SubQty4 = this.SubQty4;
            record.SubQty5 = this.SubQty5;
            record.SubQty6 = this.SubQty6;
            record.SubQty7 = this.SubQty7;
            record.SubQty8 = this.SubQty8;
            record.SubQty9 = this.SubQty9;
            record.UntPrc1 = this.UntPrc1;
            record.UntPrc2 = this.UntPrc2;
            record.UntPrc3 = this.UntPrc3;
            record.UntPrc4 = this.UntPrc4;
            record.UntPrc5 = this.UntPrc5;
            record.UntPrc6 = this.UntPrc6;
            record.UntPrc7 = this.UntPrc7;
            record.UntPrc8 = this.UntPrc8;
            record.UntPrc9 = this.UntPrc9;
            record.UntType = this.UntType;
            record.VatAmt = this.VatAmt;
            record.PriceCalc = this.PriceCalc;
            record.DiscAmt = this.DiscAmt;
            record.LmspSuspendData = this.LmspSuspendData;
            record.LmspScore = this.LmspScore;
            record.LmspLessonStatus = this.LmspLessonStatus;
            record.LmspComments = this.LmspComments;
            record.ChgPrcBy = this.ChgPrcBy;
            record.ChgPrcDate = this.ChgPrcDate;
            record.CertPrintStatus = this.CertPrintStatus;
            record.CrId = this.CrId;
            record.CertPrnDate = this.CertPrnDate;
            record.CertPrintAnyway = this.CertPrintAnyway;
            record.SelcoSpId = this.SelcoSpId;
            record.ChkInTime = this.ChkInTime;
            record.ExpChkOutTime = this.ExpChkOutTime;
            record.ActChkOutTime = this.ActChkOutTime;
            record.PrsId = this.PrsId;
            record.TeachHrs = this.TeachHrs;
            record.StudWks = this.StudWks;
            record.CommissionDone = this.CommissionDone;
            record.CommissionElemId = this.CommissionElemId;
            record.AgtId = this.AgtId;
            record.EventCancel = this.EventCancel;
            record.Proforma = this.Proforma;
            record.BatId = this.BatId;
            record.SopNo = this.SopNo;
            record.ErrorDesc = this.ErrorDesc;
            record.GrpId = this.GrpId;
            record.AuthStatus = this.AuthStatus;
            record.ElemId = this.ElemId;
            record.BktId = this.BktId;
            record.UnitPriceDisc = this.UnitPriceDisc;
            record.UnitPriceDiscBc = this.UnitPriceDiscBc;
            record.UnitPriceDiscBc2 = this.UnitPriceDiscBc2;
            record.UnitDiscount = this.UnitDiscount;
            record.UnitDiscountBc = this.UnitDiscountBc;
            record.UnitDiscountBc2 = this.UnitDiscountBc2;
            record.PriceDisc = this.PriceDisc;
            record.PriceDiscBc = this.PriceDiscBc;
            record.PriceDiscBc2 = this.PriceDiscBc2;
            record.Discount = this.Discount;
            record.DiscountBc = this.DiscountBc;
            record.DiscountBc2 = this.DiscountBc2;
            record.ExtStatus = this.ExtStatus;
            record.CurrRateBc = this.CurrRateBc;
            record.CurrRateBc2 = this.CurrRateBc2;
            record.SentDate = this.SentDate;
            record.DelivDate = this.DelivDate;
            record.RetDate = this.RetDate;
            record.DeliverToDel = this.DeliverToDel;
            record.BomId = this.BomId;
            record.DiscId = this.DiscId;
            record.ExclDiscamt = this.ExclDiscamt;
            record.DiscAppliedDate = this.DiscAppliedDate;
            record.BookGroup = this.BookGroup;
            record.Recommended = this.Recommended;
            record.Mandatory = this.Mandatory;
            record.StElemId = this.StElemId;
            record.UniqueRef = this.UniqueRef;
            record.PartnerSysRef = this.PartnerSysRef;
            record.QuoDetId = this.QuoDetId;
            record.CertExpyDate = this.CertExpyDate;
            record.AuthProleId = this.AuthProleId;
            record.AuthAssoType = this.AuthAssoType;
            record.AuthCode = this.AuthCode;
            record.AuthReqDate = this.AuthReqDate;
            record.LastAuthProleId = this.LastAuthProleId;
            record.AuthLastComments = this.AuthLastComments;
            record.PshId = this.PshId;
            record.BlockDel = this.BlockDel;
            record.PrsType = this.PrsType;
            record.CancelDate = this.CancelDate;
            record.Score1 = this.Score1;
            record.Score2 = this.Score2;
            record.Score3 = this.Score3;
            record.Score4 = this.Score4;
            record.Score5 = this.Score5;
            record.Score6 = this.Score6;
            record.PdpeId = this.PdpeId;
            record.ScoEndDte = this.ScoEndDte;
            record.LmspTotalTime = this.LmspTotalTime;
            record.LmspLessonLocation = this.LmspLessonLocation;
            record.LmspCompletes = this.LmspCompletes;
            record.GiftAid = this.GiftAid;
            record.Claimed = this.Claimed;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ElementRecord" /> instance is equal to another <see cref="ElementRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ElementRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ElementRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.DelId.TrimOrNullify() == that.DelId.TrimOrNullify());
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.ActId.TrimOrNullify() == that.ActId.TrimOrNullify());
            result = result && (this.CourseId.TrimOrNullify() == that.CourseId.TrimOrNullify());
            result = result && (this.BookId.TrimOrNullify() == that.BookId.TrimOrNullify());
            result = result && (this.WhoPays.TrimOrNullify() == that.WhoPays.TrimOrNullify());
            result = result && (this.CertNo.TrimOrNullify() == that.CertNo.TrimOrNullify());
            result = result && (this.Attended == that.Attended);
            result = result && (this.UserDate1 == that.UserDate1);
            result = result && (this.UserDate2 == that.UserDate2);
            result = result && (this.UserDate3 == that.UserDate3);
            result = result && (this.Userint1 == that.Userint1);
            result = result && (this.Userint2 == that.Userint2);
            result = result && (this.Usernum1 == that.Usernum1);
            result = result && (this.Usernum2 == that.Usernum2);
            result = result && (this.Usernum3 == that.Usernum3);
            result = result && (this.CurrencyType.TrimOrNullify() == that.CurrencyType.TrimOrNullify());
            result = result && (this.Price == that.Price);
            result = result && (this.BlockPrice == that.BlockPrice);
            result = result && (this.PriceBc == that.PriceBc);
            result = result && (this.BlockPrceBc == that.BlockPrceBc);
            result = result && (this.Vatcd.TrimOrNullify() == that.Vatcd.TrimOrNullify());
            result = result && (this.CostCode.TrimOrNullify() == that.CostCode.TrimOrNullify());
            result = result && (this.DoNotInvce == that.DoNotInvce);
            result = result && (this.Invoiced == that.Invoiced);
            result = result && (this.InvoicedDate == that.InvoicedDate);
            result = result && (this.Description.TrimOrNullify() == that.Description.TrimOrNullify());
            result = result && (this.RevCode.TrimOrNullify() == that.RevCode.TrimOrNullify());
            result = result && (this.InvoicePrint == that.InvoicePrint);
            result = result && (this.Cancelled == that.Cancelled);
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.Credited == that.Credited);
            result = result && (this.NonAtdRsn.TrimOrNullify() == that.NonAtdRsn.TrimOrNullify());
            result = result && (this.CertIseDat == that.CertIseDat);
            result = result && (this.CertPrnDat == that.CertPrnDat);
            result = result && (this.LcseNo.TrimOrNullify() == that.LcseNo.TrimOrNullify());
            result = result && (this.LcseIseDat == that.LcseIseDat);
            result = result && (this.LcsePrnDat == that.LcsePrnDat);
            result = result && (this.ReqDate == that.ReqDate);
            result = result && (this.Pass == that.Pass);
            result = result && (this.Score == that.Score);
            result = result && (this.Chosen == that.Chosen);
            result = result && (this.Type == that.Type);
            result = result && (this.Status == that.Status);
            result = result && (this.Grade.TrimOrNullify() == that.Grade.TrimOrNullify());
            result = result && (this.PriceBc2 == that.PriceBc2);
            result = result && (this.BlkPriceBc2 == that.BlkPriceBc2);
            result = result && (this.PaymentMethd.TrimOrNullify() == that.PaymentMethd.TrimOrNullify());
            result = result && (this.Qty == that.Qty);
            result = result && (this.UntPrice == that.UntPrice);
            result = result && (this.UntPriceBc == that.UntPriceBc);
            result = result && (this.UntPriceBc2 == that.UntPriceBc2);
            result = result && (this.ShowSales == that.ShowSales);
            result = result && (this.MstcId.TrimOrNullify() == that.MstcId.TrimOrNullify());
            result = result && (this.LstPrice == that.LstPrice);
            result = result && (this.LstPriceBc == that.LstPriceBc);
            result = result && (this.LstPriceBc2 == that.LstPriceBc2);
            result = result && (this.DelType == that.DelType);
            result = result && (this.DelAttribs.TrimOrNullify() == that.DelAttribs.TrimOrNullify());
            result = result && (this.PlId.TrimOrNullify() == that.PlId.TrimOrNullify());
            result = result && (this.DelQty == that.DelQty);
            result = result && (this.Block == that.Block);
            result = result && (this.Result.TrimOrNullify() == that.Result.TrimOrNullify());
            result = result && (this.History.TrimOrNullify() == that.History.TrimOrNullify());
            result = result && (this.RetailPrice == that.RetailPrice);
            result = result && (this.CostPrice == that.CostPrice);
            result = result && (this.RetPriceBc == that.RetPriceBc);
            result = result && (this.CstPriceBc == that.CstPriceBc);
            result = result && (this.RetPriceBc2 == that.RetPriceBc2);
            result = result && (this.CstPriceBc2 == that.CstPriceBc2);
            result = result && (this.ValToRev == that.ValToRev);
            result = result && (this.DelTypeDesc.TrimOrNullify() == that.DelTypeDesc.TrimOrNullify());
            result = result && (this.Description2.TrimOrNullify() == that.Description2.TrimOrNullify());
            result = result && (this.LmspId.TrimOrNullify() == that.LmspId.TrimOrNullify());
            result = result && (this.ScoStartDte == that.ScoStartDte);
            result = result && (this.FailRsn.TrimOrNullify() == that.FailRsn.TrimOrNullify());
            result = result && (this.MainSession == that.MainSession);
            result = result && (this.SellMstcId.TrimOrNullify() == that.SellMstcId.TrimOrNullify());
            result = result && (this.PrepayUnits == that.PrepayUnits);
            result = result && (this.StartDate == that.StartDate);
            result = result && (this.EndDate == that.EndDate);
            result = result && (this.RegNo.TrimOrNullify() == that.RegNo.TrimOrNullify());
            result = result && (this.SxrefId.TrimOrNullify() == that.SxrefId.TrimOrNullify());
            result = result && (this.RoomType.TrimOrNullify() == that.RoomType.TrimOrNullify());
            result = result && (this.RoomBedType.TrimOrNullify() == that.RoomBedType.TrimOrNullify());
            result = result && (this.Qty2 == that.Qty2);
            result = result && (this.QualId.TrimOrNullify() == that.QualId.TrimOrNullify());
            result = result && (this.TicketPnts == that.TicketPnts);
            result = result && (this.DiscReason.TrimOrNullify() == that.DiscReason.TrimOrNullify());
            result = result && (this.StartTime == that.StartTime);
            result = result && (this.EndTime == that.EndTime);
            result = result && (this.SstId.TrimOrNullify() == that.SstId.TrimOrNullify());
            result = result && (this.SubQty1 == that.SubQty1);
            result = result && (this.SubQty2 == that.SubQty2);
            result = result && (this.SubQty3 == that.SubQty3);
            result = result && (this.SubQty4 == that.SubQty4);
            result = result && (this.SubQty5 == that.SubQty5);
            result = result && (this.SubQty6 == that.SubQty6);
            result = result && (this.SubQty7 == that.SubQty7);
            result = result && (this.SubQty8 == that.SubQty8);
            result = result && (this.SubQty9 == that.SubQty9);
            result = result && (this.UntPrc1 == that.UntPrc1);
            result = result && (this.UntPrc2 == that.UntPrc2);
            result = result && (this.UntPrc3 == that.UntPrc3);
            result = result && (this.UntPrc4 == that.UntPrc4);
            result = result && (this.UntPrc5 == that.UntPrc5);
            result = result && (this.UntPrc6 == that.UntPrc6);
            result = result && (this.UntPrc7 == that.UntPrc7);
            result = result && (this.UntPrc8 == that.UntPrc8);
            result = result && (this.UntPrc9 == that.UntPrc9);
            result = result && (this.UntType.TrimOrNullify() == that.UntType.TrimOrNullify());
            result = result && (this.VatAmt == that.VatAmt);
            result = result && (this.PriceCalc.TrimOrNullify() == that.PriceCalc.TrimOrNullify());
            result = result && (this.DiscAmt == that.DiscAmt);
            result = result && (this.LmspSuspendData.TrimOrNullify() == that.LmspSuspendData.TrimOrNullify());
            result = result && (this.LmspScore == that.LmspScore);
            result = result && (this.LmspLessonStatus.TrimOrNullify() == that.LmspLessonStatus.TrimOrNullify());
            result = result && (this.LmspComments.TrimOrNullify() == that.LmspComments.TrimOrNullify());
            result = result && (this.ChgPrcBy.TrimOrNullify() == that.ChgPrcBy.TrimOrNullify());
            result = result && (this.ChgPrcDate == that.ChgPrcDate);
            result = result && (this.CertPrintStatus == that.CertPrintStatus);
            result = result && (this.CrId.TrimOrNullify() == that.CrId.TrimOrNullify());
            result = result && (this.CertPrnDate == that.CertPrnDate);
            result = result && (this.CertPrintAnyway == that.CertPrintAnyway);
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.ChkInTime == that.ChkInTime);
            result = result && (this.ExpChkOutTime == that.ExpChkOutTime);
            result = result && (this.ActChkOutTime == that.ActChkOutTime);
            result = result && (this.PrsId.TrimOrNullify() == that.PrsId.TrimOrNullify());
            result = result && (this.TeachHrs == that.TeachHrs);
            result = result && (this.StudWks == that.StudWks);
            result = result && (this.CommissionDone == that.CommissionDone);
            result = result && (this.CommissionElemId.TrimOrNullify() == that.CommissionElemId.TrimOrNullify());
            result = result && (this.AgtId == that.AgtId);
            result = result && (this.EventCancel == that.EventCancel);
            result = result && (this.Proforma == that.Proforma);
            result = result && (this.BatId.TrimOrNullify() == that.BatId.TrimOrNullify());
            result = result && (this.SopNo == that.SopNo);
            result = result && (this.ErrorDesc.TrimOrNullify() == that.ErrorDesc.TrimOrNullify());
            result = result && (this.GrpId == that.GrpId);
            result = result && (this.AuthStatus == that.AuthStatus);
            result = result && (this.ElemId.TrimOrNullify() == that.ElemId.TrimOrNullify());
            result = result && (this.BktId.TrimOrNullify() == that.BktId.TrimOrNullify());
            result = result && (this.UnitPriceDisc == that.UnitPriceDisc);
            result = result && (this.UnitPriceDiscBc == that.UnitPriceDiscBc);
            result = result && (this.UnitPriceDiscBc2 == that.UnitPriceDiscBc2);
            result = result && (this.UnitDiscount == that.UnitDiscount);
            result = result && (this.UnitDiscountBc == that.UnitDiscountBc);
            result = result && (this.UnitDiscountBc2 == that.UnitDiscountBc2);
            result = result && (this.PriceDisc == that.PriceDisc);
            result = result && (this.PriceDiscBc == that.PriceDiscBc);
            result = result && (this.PriceDiscBc2 == that.PriceDiscBc2);
            result = result && (this.Discount == that.Discount);
            result = result && (this.DiscountBc == that.DiscountBc);
            result = result && (this.DiscountBc2 == that.DiscountBc2);
            result = result && (this.ExtStatus.TrimOrNullify() == that.ExtStatus.TrimOrNullify());
            result = result && (this.CurrRateBc == that.CurrRateBc);
            result = result && (this.CurrRateBc2 == that.CurrRateBc2);
            result = result && (this.SentDate == that.SentDate);
            result = result && (this.DelivDate == that.DelivDate);
            result = result && (this.RetDate == that.RetDate);
            result = result && (this.DeliverToDel == that.DeliverToDel);
            result = result && (this.BomId.TrimOrNullify() == that.BomId.TrimOrNullify());
            result = result && (this.DiscId == that.DiscId);
            result = result && (this.ExclDiscamt == that.ExclDiscamt);
            result = result && (this.DiscAppliedDate == that.DiscAppliedDate);
            result = result && (this.BookGroup.TrimOrNullify() == that.BookGroup.TrimOrNullify());
            result = result && (this.Recommended == that.Recommended);
            result = result && (this.Mandatory == that.Mandatory);
            result = result && (this.StElemId.TrimOrNullify() == that.StElemId.TrimOrNullify());
            result = result && (this.UniqueRef.TrimOrNullify() == that.UniqueRef.TrimOrNullify());
            result = result && (this.PartnerSysRef.TrimOrNullify() == that.PartnerSysRef.TrimOrNullify());
            result = result && (this.QuoDetId.TrimOrNullify() == that.QuoDetId.TrimOrNullify());
            result = result && (this.CertExpyDate == that.CertExpyDate);
            result = result && (this.AuthProleId.TrimOrNullify() == that.AuthProleId.TrimOrNullify());
            result = result && (this.AuthAssoType == that.AuthAssoType);
            result = result && (this.AuthCode.TrimOrNullify() == that.AuthCode.TrimOrNullify());
            result = result && (this.AuthReqDate == that.AuthReqDate);
            result = result && (this.LastAuthProleId.TrimOrNullify() == that.LastAuthProleId.TrimOrNullify());
            result = result && (this.AuthLastComments.TrimOrNullify() == that.AuthLastComments.TrimOrNullify());
            result = result && (this.PshId == that.PshId);
            result = result && (this.BlockDel == that.BlockDel);
            result = result && (this.PrsType == that.PrsType);
            result = result && (this.CancelDate == that.CancelDate);
            result = result && (this.Score1 == that.Score1);
            result = result && (this.Score2 == that.Score2);
            result = result && (this.Score3 == that.Score3);
            result = result && (this.Score4 == that.Score4);
            result = result && (this.Score5 == that.Score5);
            result = result && (this.Score6 == that.Score6);
            result = result && (this.PdpeId.TrimOrNullify() == that.PdpeId.TrimOrNullify());
            result = result && (this.ScoEndDte == that.ScoEndDte);
            result = result && (this.LmspTotalTime.TrimOrNullify() == that.LmspTotalTime.TrimOrNullify());
            result = result && (this.LmspLessonLocation.TrimOrNullify() == that.LmspLessonLocation.TrimOrNullify());
            result = result && (this.LmspCompletes == that.LmspCompletes);
            result = result && (this.GiftAid == that.GiftAid);
            result = result && (this.Claimed == that.Claimed);
            return result;
        }

        #endregion
    }
}
