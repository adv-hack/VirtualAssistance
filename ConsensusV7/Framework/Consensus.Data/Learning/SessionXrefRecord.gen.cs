using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Represents the "Session_Xref" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class SessionXrefRecord : Record<String>, Cloneable<SessionXrefRecord>, IEquatable<SessionXrefRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "SXREF_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "SXREF_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "SXREF_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "SXREF_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "SXREF_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "SXREF_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "SXREF_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "SXREF_COURSE_ID" field.
        /// </summary>
        private String _courseId;

        /// <summary>
        ///     the value of the "SXREF_ACT_ID" field.
        /// </summary>
        private String _actId;

        /// <summary>
        ///     the value of the "SXREF_REAL" field.
        /// </summary>
        private Byte? _real;

        /// <summary>
        ///     the value of the "SXREF_ELEMENT" field.
        /// </summary>
        private Byte? _element;

        /// <summary>
        ///     the value of the "SXREF_MANDATORY" field.
        /// </summary>
        private Byte? _mandatory;

        /// <summary>
        ///     the value of the "SXREF_INV_PRINT" field.
        /// </summary>
        private Byte? _invPrint;

        /// <summary>
        ///     the value of the "SXREF_CURRENCY" field.
        /// </summary>
        private String _currency;

        /// <summary>
        ///     the value of the "SXREF_PRICE" field.
        /// </summary>
        private Decimal _price;

        /// <summary>
        ///     the value of the "SXREF_BLOCK_PRICE" field.
        /// </summary>
        private Decimal _blockPrice;

        /// <summary>
        ///     the value of the "SXREF_PRICE_BC" field.
        /// </summary>
        private Decimal _priceBc;

        /// <summary>
        ///     the value of the "SXREF_BLK_PRICE_BC" field.
        /// </summary>
        private Decimal _blkPriceBc;

        /// <summary>
        ///     the value of the "SXREF_VATCD" field.
        /// </summary>
        private String _vatcd;

        /// <summary>
        ///     the value of the "SXREF_REV_CODE" field.
        /// </summary>
        private String _revCode;

        /// <summary>
        ///     the value of the "SXREF_COST_CODE" field.
        /// </summary>
        private String _costCode;

        /// <summary>
        ///     the value of the "SXREF_DO_NOT_INV" field.
        /// </summary>
        private Byte? _doNotInv;

        /// <summary>
        ///     the value of the "SXREF_SHOW_SALES" field.
        /// </summary>
        private Byte? _showSales;

        /// <summary>
        ///     the value of the "SXREF_NO_IN_SET" field.
        /// </summary>
        private Int32? _noInSet;

        /// <summary>
        ///     the value of the "SXREF_RETAIL_PRICE" field.
        /// </summary>
        private Decimal _retailPrice;

        /// <summary>
        ///     the value of the "SXREF_COST_PRICE" field.
        /// </summary>
        private Decimal _costPrice;

        /// <summary>
        ///     the value of the "SXREF_RET_PRICE_BC" field.
        /// </summary>
        private Decimal _retPriceBc;

        /// <summary>
        ///     the value of the "SXREF_CST_PRICE_BC" field.
        /// </summary>
        private Decimal _cstPriceBc;

        /// <summary>
        ///     the value of the "SXREF_RET_PRIC_BC2" field.
        /// </summary>
        private Decimal _retPricBc2;

        /// <summary>
        ///     the value of the "SXREF_CST_PRIC_BC2" field.
        /// </summary>
        private Decimal _cstPricBc2;

        /// <summary>
        ///     the value of the "SXREF_PRICE_A" field.
        /// </summary>
        private Decimal _priceA;

        /// <summary>
        ///     the value of the "SXREF_PRICE_B" field.
        /// </summary>
        private Decimal _priceB;

        /// <summary>
        ///     the value of the "SXREF_PRICE_C" field.
        /// </summary>
        private Decimal _priceC;

        /// <summary>
        ///     the value of the "SXREF_PRICE_D" field.
        /// </summary>
        private Decimal _priceD;

        /// <summary>
        ///     the value of the "SXREF_PRICE_E" field.
        /// </summary>
        private Decimal _priceE;

        /// <summary>
        ///     the value of the "SXREF_DEFAULT" field.
        /// </summary>
        private Byte? _default;

        /// <summary>
        ///     the value of the "SXREF_PL_ID" field.
        /// </summary>
        private String _plId;

        /// <summary>
        ///     the value of the "SXREF_TICKET" field.
        /// </summary>
        private Byte? _ticket;

        /// <summary>
        ///     the value of the "SXREF_GROUP_QTY" field.
        /// </summary>
        private Byte? _groupQty;

        /// <summary>
        ///     the value of the "SXREF_GROUP_DTE" field.
        /// </summary>
        private Byte? _groupDte;

        /// <summary>
        ///     the value of the "SXREF_GROUP_QTY_ID" field.
        /// </summary>
        private String _groupQtyId;

        /// <summary>
        ///     the value of the "SXREF_GROUP_DTE_ID" field.
        /// </summary>
        private String _groupDteId;

        /// <summary>
        ///     the value of the "SXREF_QTY_MIN" field.
        /// </summary>
        private Int32? _qtyMin;

        /// <summary>
        ///     the value of the "SXREF_QTY_MAX" field.
        /// </summary>
        private Int32? _qtyMax;

        /// <summary>
        ///     the value of the "SXREF_VALID_FROM" field.
        /// </summary>
        private DateTime? _validFrom;

        /// <summary>
        ///     the value of the "SXREF_VALID_UNTIL" field.
        /// </summary>
        private DateTime? _validUntil;

        /// <summary>
        ///     the value of the "SXREF_BEFORE_DAYS" field.
        /// </summary>
        private Int32? _beforeDays;

        /// <summary>
        ///     the value of the "SXREF_CHARGEABLE" field.
        /// </summary>
        private Int32? _chargeable;

        /// <summary>
        ///     the value of the "SXREF_MAIN_SESSION" field.
        /// </summary>
        private Byte? _mainSession;

        /// <summary>
        ///     the value of the "SXREF_ETT_ID" field.
        /// </summary>
        private String _ettId;

        /// <summary>
        ///     the value of the "SXREF_GRP_SG_ID" field.
        /// </summary>
        private String _grpSgId;

        /// <summary>
        ///     the value of the "SXREF_STRM_SG_ID" field.
        /// </summary>
        private String _strmSgId;

        /// <summary>
        ///     the value of the "SXREF_GRID_START" field.
        /// </summary>
        private String _gridStart;

        /// <summary>
        ///     the value of the "SXREF_GRID_END" field.
        /// </summary>
        private String _gridEnd;

        /// <summary>
        ///     the value of the "SXREF_SESS_PNTS" field.
        /// </summary>
        private Int32? _sessPnts;

        /// <summary>
        ///     the value of the "SXREF_MAST_SESS" field.
        /// </summary>
        private Int32? _mastSess;

        /// <summary>
        ///     the value of the "SXREF_SELECTED" field.
        /// </summary>
        private Byte? _selected;

        /// <summary>
        ///     the value of the "SXREF_COUNT_DEL" field.
        /// </summary>
        private Byte? _countDel;

        /// <summary>
        ///     the value of the "SXREF_PAY_PNTS" field.
        /// </summary>
        private Byte? _payPnts;

        /// <summary>
        ///     the value of the "SXREF_CODE" field.
        /// </summary>
        private String _code;

        /// <summary>
        ///     the value of the "SXREF_ACTXREF_ID" field.
        /// </summary>
        private String _actxrefId;

        /// <summary>
        ///     the value of the "SXREF_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "SXREF_PL_NAME" field.
        /// </summary>
        private String _plName;

        /// <summary>
        ///     the value of the "SXREF_PRS_ID" field.
        /// </summary>
        private String _prsId;

        /// <summary>
        ///     the value of the "SXREF_MEMBER" field.
        /// </summary>
        private Byte? _member;

        /// <summary>
        ///     the value of the "SXREF_START_DAY" field.
        /// </summary>
        private Int32? _startDay;

        /// <summary>
        ///     the value of the "SXREF_END_DAY" field.
        /// </summary>
        private Int32? _endDay;

        /// <summary>
        ///     the value of the "SXREF_LST_PRICE" field.
        /// </summary>
        private Decimal _lstPrice;

        /// <summary>
        ///     the value of the "SXREF_STUDENT" field.
        /// </summary>
        private Byte? _student;

        /// <summary>
        ///     the value of the "SXREF_BOM_ID" field.
        /// </summary>
        private String _bomId;

        /// <summary>
        ///     the value of the "SXREF_EP_ID" field.
        /// </summary>
        private Int32? _epId;

        /// <summary>
        ///     the value of the "SXREF_VALID_DATE" field.
        /// </summary>
        private Byte _validDate;

        /// <summary>
        ///     the value of the "SXREF_REGION" field.
        /// </summary>
        private String _region;

        /// <summary>
        ///     the value of the "SXREF_CSG_ID" field.
        /// </summary>
        private Int32? _csgId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "SXREF_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_COURSE_ID" field.
        /// </summary>
        public String CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_ACT_ID" field.
        /// </summary>
        public String ActId
        {
            get { return _actId; }
            set { _actId = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_REAL" field.
        /// </summary>
        public Byte? Real
        {
            get { return _real; }
            set { _real = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_ELEMENT" field.
        /// </summary>
        public Byte? Element
        {
            get { return _element; }
            set { _element = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_MANDATORY" field.
        /// </summary>
        public Byte? Mandatory
        {
            get { return _mandatory; }
            set { _mandatory = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_INV_PRINT" field.
        /// </summary>
        public Byte? InvPrint
        {
            get { return _invPrint; }
            set { _invPrint = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_CURRENCY" field.
        /// </summary>
        public String Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_PRICE" field.
        /// </summary>
        public Decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_BLOCK_PRICE" field.
        /// </summary>
        public Decimal BlockPrice
        {
            get { return _blockPrice; }
            set { _blockPrice = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_PRICE_BC" field.
        /// </summary>
        public Decimal PriceBc
        {
            get { return _priceBc; }
            set { _priceBc = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_BLK_PRICE_BC" field.
        /// </summary>
        public Decimal BlkPriceBc
        {
            get { return _blkPriceBc; }
            set { _blkPriceBc = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_VATCD" field.
        /// </summary>
        public String Vatcd
        {
            get { return _vatcd; }
            set { _vatcd = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_REV_CODE" field.
        /// </summary>
        public String RevCode
        {
            get { return _revCode; }
            set { _revCode = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return _costCode; }
            set { _costCode = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_DO_NOT_INV" field.
        /// </summary>
        public Byte? DoNotInv
        {
            get { return _doNotInv; }
            set { _doNotInv = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_SHOW_SALES" field.
        /// </summary>
        public Byte? ShowSales
        {
            get { return _showSales; }
            set { _showSales = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_NO_IN_SET" field.
        /// </summary>
        public Int32? NoInSet
        {
            get { return _noInSet; }
            set { _noInSet = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_RETAIL_PRICE" field.
        /// </summary>
        public Decimal RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_COST_PRICE" field.
        /// </summary>
        public Decimal CostPrice
        {
            get { return _costPrice; }
            set { _costPrice = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_RET_PRICE_BC" field.
        /// </summary>
        public Decimal RetPriceBc
        {
            get { return _retPriceBc; }
            set { _retPriceBc = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_CST_PRICE_BC" field.
        /// </summary>
        public Decimal CstPriceBc
        {
            get { return _cstPriceBc; }
            set { _cstPriceBc = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_RET_PRIC_BC2" field.
        /// </summary>
        public Decimal RetPricBc2
        {
            get { return _retPricBc2; }
            set { _retPricBc2 = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_CST_PRIC_BC2" field.
        /// </summary>
        public Decimal CstPricBc2
        {
            get { return _cstPricBc2; }
            set { _cstPricBc2 = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_PRICE_A" field.
        /// </summary>
        public Decimal PriceA
        {
            get { return _priceA; }
            set { _priceA = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_PRICE_B" field.
        /// </summary>
        public Decimal PriceB
        {
            get { return _priceB; }
            set { _priceB = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_PRICE_C" field.
        /// </summary>
        public Decimal PriceC
        {
            get { return _priceC; }
            set { _priceC = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_PRICE_D" field.
        /// </summary>
        public Decimal PriceD
        {
            get { return _priceD; }
            set { _priceD = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_PRICE_E" field.
        /// </summary>
        public Decimal PriceE
        {
            get { return _priceE; }
            set { _priceE = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_DEFAULT" field.
        /// </summary>
        public Byte? Default
        {
            get { return _default; }
            set { _default = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_PL_ID" field.
        /// </summary>
        public String PlId
        {
            get { return _plId; }
            set { _plId = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_TICKET" field.
        /// </summary>
        public Byte? Ticket
        {
            get { return _ticket; }
            set { _ticket = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_GROUP_QTY" field.
        /// </summary>
        public Byte? GroupQty
        {
            get { return _groupQty; }
            set { _groupQty = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_GROUP_DTE" field.
        /// </summary>
        public Byte? GroupDte
        {
            get { return _groupDte; }
            set { _groupDte = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_GROUP_QTY_ID" field.
        /// </summary>
        public String GroupQtyId
        {
            get { return _groupQtyId; }
            set { _groupQtyId = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_GROUP_DTE_ID" field.
        /// </summary>
        public String GroupDteId
        {
            get { return _groupDteId; }
            set { _groupDteId = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_QTY_MIN" field.
        /// </summary>
        public Int32? QtyMin
        {
            get { return _qtyMin; }
            set { _qtyMin = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_QTY_MAX" field.
        /// </summary>
        public Int32? QtyMax
        {
            get { return _qtyMax; }
            set { _qtyMax = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_VALID_FROM" field.
        /// </summary>
        public DateTime? ValidFrom
        {
            get { return _validFrom; }
            set { _validFrom = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_VALID_UNTIL" field.
        /// </summary>
        public DateTime? ValidUntil
        {
            get { return _validUntil; }
            set { _validUntil = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_BEFORE_DAYS" field.
        /// </summary>
        public Int32? BeforeDays
        {
            get { return _beforeDays; }
            set { _beforeDays = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_CHARGEABLE" field.
        /// </summary>
        public Int32? Chargeable
        {
            get { return _chargeable; }
            set { _chargeable = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_MAIN_SESSION" field.
        /// </summary>
        public Byte? MainSession
        {
            get { return _mainSession; }
            set { _mainSession = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_ETT_ID" field.
        /// </summary>
        public String EttId
        {
            get { return _ettId; }
            set { _ettId = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_GRP_SG_ID" field.
        /// </summary>
        public String GrpSgId
        {
            get { return _grpSgId; }
            set { _grpSgId = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_STRM_SG_ID" field.
        /// </summary>
        public String StrmSgId
        {
            get { return _strmSgId; }
            set { _strmSgId = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_GRID_START" field.
        /// </summary>
        public String GridStart
        {
            get { return _gridStart; }
            set { _gridStart = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_GRID_END" field.
        /// </summary>
        public String GridEnd
        {
            get { return _gridEnd; }
            set { _gridEnd = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_SESS_PNTS" field.
        /// </summary>
        public Int32? SessPnts
        {
            get { return _sessPnts; }
            set { _sessPnts = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_MAST_SESS" field.
        /// </summary>
        public Int32? MastSess
        {
            get { return _mastSess; }
            set { _mastSess = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_SELECTED" field.
        /// </summary>
        public Byte? Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_COUNT_DEL" field.
        /// </summary>
        public Byte? CountDel
        {
            get { return _countDel; }
            set { _countDel = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_PAY_PNTS" field.
        /// </summary>
        public Byte? PayPnts
        {
            get { return _payPnts; }
            set { _payPnts = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_CODE" field.
        /// </summary>
        public String Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_ACTXREF_ID" field.
        /// </summary>
        public String ActxrefId
        {
            get { return _actxrefId; }
            set { _actxrefId = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_PL_NAME" field.
        /// </summary>
        public String PlName
        {
            get { return _plName; }
            set { _plName = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_PRS_ID" field.
        /// </summary>
        public String PrsId
        {
            get { return _prsId; }
            set { _prsId = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_MEMBER" field.
        /// </summary>
        public Byte? Member
        {
            get { return _member; }
            set { _member = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_START_DAY" field.
        /// </summary>
        public Int32? StartDay
        {
            get { return _startDay; }
            set { _startDay = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_END_DAY" field.
        /// </summary>
        public Int32? EndDay
        {
            get { return _endDay; }
            set { _endDay = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_LST_PRICE" field.
        /// </summary>
        public Decimal LstPrice
        {
            get { return _lstPrice; }
            set { _lstPrice = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_STUDENT" field.
        /// </summary>
        public Byte? Student
        {
            get { return _student; }
            set { _student = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_BOM_ID" field.
        /// </summary>
        public String BomId
        {
            get { return _bomId; }
            set { _bomId = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_EP_ID" field.
        /// </summary>
        public Int32? EpId
        {
            get { return _epId; }
            set { _epId = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_VALID_DATE" field.
        /// </summary>
        public Byte ValidDate
        {
            get { return _validDate; }
            set { _validDate = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_REGION" field.
        /// </summary>
        public String Region
        {
            get { return _region; }
            set { _region = value; }
        }

        /// <summary>
        ///     the value of the "SXREF_CSG_ID" field.
        /// </summary>
        public Int32? CsgId
        {
            get { return _csgId; }
            set { _csgId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="SessionXrefRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="SessionXrefRecord" /> object instance.
        /// </returns>
        public SessionXrefRecord Clone()
        {
            SessionXrefRecord record = new SessionXrefRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.CourseId = this.CourseId;
            record.ActId = this.ActId;
            record.Real = this.Real;
            record.Element = this.Element;
            record.Mandatory = this.Mandatory;
            record.InvPrint = this.InvPrint;
            record.Currency = this.Currency;
            record.Price = this.Price;
            record.BlockPrice = this.BlockPrice;
            record.PriceBc = this.PriceBc;
            record.BlkPriceBc = this.BlkPriceBc;
            record.Vatcd = this.Vatcd;
            record.RevCode = this.RevCode;
            record.CostCode = this.CostCode;
            record.DoNotInv = this.DoNotInv;
            record.ShowSales = this.ShowSales;
            record.NoInSet = this.NoInSet;
            record.RetailPrice = this.RetailPrice;
            record.CostPrice = this.CostPrice;
            record.RetPriceBc = this.RetPriceBc;
            record.CstPriceBc = this.CstPriceBc;
            record.RetPricBc2 = this.RetPricBc2;
            record.CstPricBc2 = this.CstPricBc2;
            record.PriceA = this.PriceA;
            record.PriceB = this.PriceB;
            record.PriceC = this.PriceC;
            record.PriceD = this.PriceD;
            record.PriceE = this.PriceE;
            record.Default = this.Default;
            record.PlId = this.PlId;
            record.Ticket = this.Ticket;
            record.GroupQty = this.GroupQty;
            record.GroupDte = this.GroupDte;
            record.GroupQtyId = this.GroupQtyId;
            record.GroupDteId = this.GroupDteId;
            record.QtyMin = this.QtyMin;
            record.QtyMax = this.QtyMax;
            record.ValidFrom = this.ValidFrom;
            record.ValidUntil = this.ValidUntil;
            record.BeforeDays = this.BeforeDays;
            record.Chargeable = this.Chargeable;
            record.MainSession = this.MainSession;
            record.EttId = this.EttId;
            record.GrpSgId = this.GrpSgId;
            record.StrmSgId = this.StrmSgId;
            record.GridStart = this.GridStart;
            record.GridEnd = this.GridEnd;
            record.SessPnts = this.SessPnts;
            record.MastSess = this.MastSess;
            record.Selected = this.Selected;
            record.CountDel = this.CountDel;
            record.PayPnts = this.PayPnts;
            record.Code = this.Code;
            record.ActxrefId = this.ActxrefId;
            record.ProdId = this.ProdId;
            record.PlName = this.PlName;
            record.PrsId = this.PrsId;
            record.Member = this.Member;
            record.StartDay = this.StartDay;
            record.EndDay = this.EndDay;
            record.LstPrice = this.LstPrice;
            record.Student = this.Student;
            record.BomId = this.BomId;
            record.EpId = this.EpId;
            record.ValidDate = this.ValidDate;
            record.Region = this.Region;
            record.CsgId = this.CsgId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="SessionXrefRecord" /> instance is equal to another <see cref="SessionXrefRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="SessionXrefRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(SessionXrefRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.CourseId.TrimOrNullify() == that.CourseId.TrimOrNullify());
            result = result && (this.ActId.TrimOrNullify() == that.ActId.TrimOrNullify());
            result = result && (this.Real == that.Real);
            result = result && (this.Element == that.Element);
            result = result && (this.Mandatory == that.Mandatory);
            result = result && (this.InvPrint == that.InvPrint);
            result = result && (this.Currency.TrimOrNullify() == that.Currency.TrimOrNullify());
            result = result && (this.Price == that.Price);
            result = result && (this.BlockPrice == that.BlockPrice);
            result = result && (this.PriceBc == that.PriceBc);
            result = result && (this.BlkPriceBc == that.BlkPriceBc);
            result = result && (this.Vatcd.TrimOrNullify() == that.Vatcd.TrimOrNullify());
            result = result && (this.RevCode.TrimOrNullify() == that.RevCode.TrimOrNullify());
            result = result && (this.CostCode.TrimOrNullify() == that.CostCode.TrimOrNullify());
            result = result && (this.DoNotInv == that.DoNotInv);
            result = result && (this.ShowSales == that.ShowSales);
            result = result && (this.NoInSet == that.NoInSet);
            result = result && (this.RetailPrice == that.RetailPrice);
            result = result && (this.CostPrice == that.CostPrice);
            result = result && (this.RetPriceBc == that.RetPriceBc);
            result = result && (this.CstPriceBc == that.CstPriceBc);
            result = result && (this.RetPricBc2 == that.RetPricBc2);
            result = result && (this.CstPricBc2 == that.CstPricBc2);
            result = result && (this.PriceA == that.PriceA);
            result = result && (this.PriceB == that.PriceB);
            result = result && (this.PriceC == that.PriceC);
            result = result && (this.PriceD == that.PriceD);
            result = result && (this.PriceE == that.PriceE);
            result = result && (this.Default == that.Default);
            result = result && (this.PlId.TrimOrNullify() == that.PlId.TrimOrNullify());
            result = result && (this.Ticket == that.Ticket);
            result = result && (this.GroupQty == that.GroupQty);
            result = result && (this.GroupDte == that.GroupDte);
            result = result && (this.GroupQtyId.TrimOrNullify() == that.GroupQtyId.TrimOrNullify());
            result = result && (this.GroupDteId.TrimOrNullify() == that.GroupDteId.TrimOrNullify());
            result = result && (this.QtyMin == that.QtyMin);
            result = result && (this.QtyMax == that.QtyMax);
            result = result && (this.ValidFrom == that.ValidFrom);
            result = result && (this.ValidUntil == that.ValidUntil);
            result = result && (this.BeforeDays == that.BeforeDays);
            result = result && (this.Chargeable == that.Chargeable);
            result = result && (this.MainSession == that.MainSession);
            result = result && (this.EttId.TrimOrNullify() == that.EttId.TrimOrNullify());
            result = result && (this.GrpSgId.TrimOrNullify() == that.GrpSgId.TrimOrNullify());
            result = result && (this.StrmSgId.TrimOrNullify() == that.StrmSgId.TrimOrNullify());
            result = result && (this.GridStart.TrimOrNullify() == that.GridStart.TrimOrNullify());
            result = result && (this.GridEnd.TrimOrNullify() == that.GridEnd.TrimOrNullify());
            result = result && (this.SessPnts == that.SessPnts);
            result = result && (this.MastSess == that.MastSess);
            result = result && (this.Selected == that.Selected);
            result = result && (this.CountDel == that.CountDel);
            result = result && (this.PayPnts == that.PayPnts);
            result = result && (this.Code.TrimOrNullify() == that.Code.TrimOrNullify());
            result = result && (this.ActxrefId.TrimOrNullify() == that.ActxrefId.TrimOrNullify());
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.PlName.TrimOrNullify() == that.PlName.TrimOrNullify());
            result = result && (this.PrsId.TrimOrNullify() == that.PrsId.TrimOrNullify());
            result = result && (this.Member == that.Member);
            result = result && (this.StartDay == that.StartDay);
            result = result && (this.EndDay == that.EndDay);
            result = result && (this.LstPrice == that.LstPrice);
            result = result && (this.Student == that.Student);
            result = result && (this.BomId.TrimOrNullify() == that.BomId.TrimOrNullify());
            result = result && (this.EpId == that.EpId);
            result = result && (this.ValidDate == that.ValidDate);
            result = result && (this.Region.TrimOrNullify() == that.Region.TrimOrNullify());
            result = result && (this.CsgId == that.CsgId);
            return result;
        }

        #endregion
    }
}
