using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Represents the "Prices" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PricesRecord : Record<String>, Cloneable<PricesRecord>, IEquatable<PricesRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PRS_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "PRS_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PRS_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PRS_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PRS_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PRS_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PRS_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PRS_PL_ID" field.
        /// </summary>
        private String _plId;

        /// <summary>
        ///     the value of the "PRS_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "PRS_PRICE" field.
        /// </summary>
        private Decimal _price;

        /// <summary>
        ///     the value of the "PRS_BLOCK_PRICE" field.
        /// </summary>
        private Decimal _blockPrice;

        /// <summary>
        ///     the value of the "PRS_SPARE_PRICE" field.
        /// </summary>
        private Decimal _sparePrice;

        /// <summary>
        ///     the value of the "PRS_COST_PRICE" field.
        /// </summary>
        private Decimal _costPrice;

        /// <summary>
        ///     the value of the "PRS_COST_CODE" field.
        /// </summary>
        private String _costCode;

        /// <summary>
        ///     the value of the "PRS_REV_CODE" field.
        /// </summary>
        private String _revCode;

        /// <summary>
        ///     the value of the "PRS_DISC_SCHED" field.
        /// </summary>
        private String _discSched;

        /// <summary>
        ///     the value of the "PRS_VAT_CODE" field.
        /// </summary>
        private String _vatCode;

        /// <summary>
        ///     the value of the "PRS_RETAIL_PRICE" field.
        /// </summary>
        private Decimal _retailPrice;

        /// <summary>
        ///     the value of the "PRS_NO_COST_NO_SEL" field.
        /// </summary>
        private Byte? _noCostNoSel;

        /// <summary>
        ///     the value of the "PRS_DEFAULT" field.
        /// </summary>
        private Byte? _default;

        /// <summary>
        ///     the value of the "PRS_GL_CODE1" field.
        /// </summary>
        private String _glCode1;

        /// <summary>
        ///     the value of the "PRS_GL_CODE2" field.
        /// </summary>
        private String _glCode2;

        /// <summary>
        ///     the value of the "PRS_PROD_CATEGORY" field.
        /// </summary>
        private String _prodCategory;

        /// <summary>
        ///     the value of the "PRS_DISC_PERCENT" field.
        /// </summary>
        private Decimal _discPercent;

        /// <summary>
        ///     the value of the "PRS_PRICE_A" field.
        /// </summary>
        private Decimal _priceA;

        /// <summary>
        ///     the value of the "PRS_PRICE_B" field.
        /// </summary>
        private Decimal _priceB;

        /// <summary>
        ///     the value of the "PRS_PRICE_C" field.
        /// </summary>
        private Decimal _priceC;

        /// <summary>
        ///     the value of the "PRS_PRICE_D" field.
        /// </summary>
        private Decimal _priceD;

        /// <summary>
        ///     the value of the "PRS_PRICE_E" field.
        /// </summary>
        private Decimal _priceE;

        /// <summary>
        ///     the value of the "PRS_GROUP_QTY" field.
        /// </summary>
        private Int32? _groupQty;

        /// <summary>
        ///     the value of the "PRS_GROUP_DTE" field.
        /// </summary>
        private Int32? _groupDte;

        /// <summary>
        ///     the value of the "PRS_GROUP_QTY_ID" field.
        /// </summary>
        private String _groupQtyId;

        /// <summary>
        ///     the value of the "PRS_GROUP_DTE_ID" field.
        /// </summary>
        private String _groupDteId;

        /// <summary>
        ///     the value of the "PRS_QTY_MIN" field.
        /// </summary>
        private Int32? _qtyMin;

        /// <summary>
        ///     the value of the "PRS_QTY_MAX" field.
        /// </summary>
        private Int32? _qtyMax;

        /// <summary>
        ///     the value of the "PRS_VALID_FROM" field.
        /// </summary>
        private DateTime? _validFrom;

        /// <summary>
        ///     the value of the "PRS_VALID_UNTIL" field.
        /// </summary>
        private DateTime? _validUntil;

        /// <summary>
        ///     the value of the "PRS_BEFORE_DAYS" field.
        /// </summary>
        private Int32? _beforeDays;

        /// <summary>
        ///     the value of the "PRS_VAT_CODE2" field.
        /// </summary>
        private String _vatCode2;

        /// <summary>
        ///     the value of the "PRS_START_DATE" field.
        /// </summary>
        private DateTime? _startDate;

        /// <summary>
        ///     the value of the "PRS_END_DATE" field.
        /// </summary>
        private DateTime? _endDate;

        /// <summary>
        ///     the value of the "PRS_QUAL_ID" field.
        /// </summary>
        private String _qualId;

        /// <summary>
        ///     the value of the "PRS_PREPAY_PROD_ID" field.
        /// </summary>
        private String _prepayProdId;

        /// <summary>
        ///     the value of the "PRS_LINE_ID" field.
        /// </summary>
        private String _lineId;

        /// <summary>
        ///     the value of the "PRS_SEAS_ID" field.
        /// </summary>
        private String _seasId;

        /// <summary>
        ///     the value of the "PRS_INC_PLACES" field.
        /// </summary>
        private Byte? _incPlaces;

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_1" field.
        /// </summary>
        private Decimal? _subPrice1;

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_2" field.
        /// </summary>
        private Decimal? _subPrice2;

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_3" field.
        /// </summary>
        private Decimal? _subPrice3;

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_4" field.
        /// </summary>
        private Decimal? _subPrice4;

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_5" field.
        /// </summary>
        private Decimal? _subPrice5;

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_6" field.
        /// </summary>
        private Decimal? _subPrice6;

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_7" field.
        /// </summary>
        private Decimal? _subPrice7;

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_8" field.
        /// </summary>
        private Decimal? _subPrice8;

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_9" field.
        /// </summary>
        private Decimal? _subPrice9;

        /// <summary>
        ///     the value of the "PRS_CURR_TYPE" field.
        /// </summary>
        private String _currType;

        /// <summary>
        ///     the value of the "PRS_DO_NOT_RECALC" field.
        /// </summary>
        private Byte? _doNotRecalc;

        /// <summary>
        ///     the value of the "PRS_SCHN_NUMBER" field.
        /// </summary>
        private Byte? _schnNumber;

        /// <summary>
        ///     the value of the "PRS_MEMB_PRICE" field.
        /// </summary>
        private Byte? _membPrice;

        /// <summary>
        ///     the value of the "PRS_START" field.
        /// </summary>
        private Int32? _start;

        /// <summary>
        ///     the value of the "PRS_END" field.
        /// </summary>
        private Int32? _end;

        /// <summary>
        ///     the value of the "PRS_DESC" field.
        /// </summary>
        private String _desc;

        /// <summary>
        ///     the value of the "PRS_PRS_ID" field.
        /// </summary>
        private String _prsId;

        /// <summary>
        ///     the value of the "PRS_WEB" field.
        /// </summary>
        private Byte _web;

        /// <summary>
        ///     the value of the "PRS_VALID_DATE" field.
        /// </summary>
        private Byte _validDate;

        /// <summary>
        ///     the value of the "PRS_REGION" field.
        /// </summary>
        private String _region;

        /// <summary>
        ///     the value of the "PRS_TYPE" field.
        /// </summary>
        private Byte? _type;

        /// <summary>
        ///     the value of the "PRS_SEA_ID" field.
        /// </summary>
        private Int32? _seaId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PRS_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "PRS_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PRS_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PRS_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PRS_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PRS_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PRS_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PRS_PL_ID" field.
        /// </summary>
        public String PlId
        {
            get { return _plId; }
            set { _plId = value; }
        }

        /// <summary>
        ///     the value of the "PRS_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "PRS_PRICE" field.
        /// </summary>
        public Decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        ///     the value of the "PRS_BLOCK_PRICE" field.
        /// </summary>
        public Decimal BlockPrice
        {
            get { return _blockPrice; }
            set { _blockPrice = value; }
        }

        /// <summary>
        ///     the value of the "PRS_SPARE_PRICE" field.
        /// </summary>
        public Decimal SparePrice
        {
            get { return _sparePrice; }
            set { _sparePrice = value; }
        }

        /// <summary>
        ///     the value of the "PRS_COST_PRICE" field.
        /// </summary>
        public Decimal CostPrice
        {
            get { return _costPrice; }
            set { _costPrice = value; }
        }

        /// <summary>
        ///     the value of the "PRS_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return _costCode; }
            set { _costCode = value; }
        }

        /// <summary>
        ///     the value of the "PRS_REV_CODE" field.
        /// </summary>
        public String RevCode
        {
            get { return _revCode; }
            set { _revCode = value; }
        }

        /// <summary>
        ///     the value of the "PRS_DISC_SCHED" field.
        /// </summary>
        public String DiscSched
        {
            get { return _discSched; }
            set { _discSched = value; }
        }

        /// <summary>
        ///     the value of the "PRS_VAT_CODE" field.
        /// </summary>
        public String VatCode
        {
            get { return _vatCode; }
            set { _vatCode = value; }
        }

        /// <summary>
        ///     the value of the "PRS_RETAIL_PRICE" field.
        /// </summary>
        public Decimal RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }

        /// <summary>
        ///     the value of the "PRS_NO_COST_NO_SEL" field.
        /// </summary>
        public Byte? NoCostNoSel
        {
            get { return _noCostNoSel; }
            set { _noCostNoSel = value; }
        }

        /// <summary>
        ///     the value of the "PRS_DEFAULT" field.
        /// </summary>
        public Byte? Default
        {
            get { return _default; }
            set { _default = value; }
        }

        /// <summary>
        ///     the value of the "PRS_GL_CODE1" field.
        /// </summary>
        public String GlCode1
        {
            get { return _glCode1; }
            set { _glCode1 = value; }
        }

        /// <summary>
        ///     the value of the "PRS_GL_CODE2" field.
        /// </summary>
        public String GlCode2
        {
            get { return _glCode2; }
            set { _glCode2 = value; }
        }

        /// <summary>
        ///     the value of the "PRS_PROD_CATEGORY" field.
        /// </summary>
        public String ProdCategory
        {
            get { return _prodCategory; }
            set { _prodCategory = value; }
        }

        /// <summary>
        ///     the value of the "PRS_DISC_PERCENT" field.
        /// </summary>
        public Decimal DiscPercent
        {
            get { return _discPercent; }
            set { _discPercent = value; }
        }

        /// <summary>
        ///     the value of the "PRS_PRICE_A" field.
        /// </summary>
        public Decimal PriceA
        {
            get { return _priceA; }
            set { _priceA = value; }
        }

        /// <summary>
        ///     the value of the "PRS_PRICE_B" field.
        /// </summary>
        public Decimal PriceB
        {
            get { return _priceB; }
            set { _priceB = value; }
        }

        /// <summary>
        ///     the value of the "PRS_PRICE_C" field.
        /// </summary>
        public Decimal PriceC
        {
            get { return _priceC; }
            set { _priceC = value; }
        }

        /// <summary>
        ///     the value of the "PRS_PRICE_D" field.
        /// </summary>
        public Decimal PriceD
        {
            get { return _priceD; }
            set { _priceD = value; }
        }

        /// <summary>
        ///     the value of the "PRS_PRICE_E" field.
        /// </summary>
        public Decimal PriceE
        {
            get { return _priceE; }
            set { _priceE = value; }
        }

        /// <summary>
        ///     the value of the "PRS_GROUP_QTY" field.
        /// </summary>
        public Int32? GroupQty
        {
            get { return _groupQty; }
            set { _groupQty = value; }
        }

        /// <summary>
        ///     the value of the "PRS_GROUP_DTE" field.
        /// </summary>
        public Int32? GroupDte
        {
            get { return _groupDte; }
            set { _groupDte = value; }
        }

        /// <summary>
        ///     the value of the "PRS_GROUP_QTY_ID" field.
        /// </summary>
        public String GroupQtyId
        {
            get { return _groupQtyId; }
            set { _groupQtyId = value; }
        }

        /// <summary>
        ///     the value of the "PRS_GROUP_DTE_ID" field.
        /// </summary>
        public String GroupDteId
        {
            get { return _groupDteId; }
            set { _groupDteId = value; }
        }

        /// <summary>
        ///     the value of the "PRS_QTY_MIN" field.
        /// </summary>
        public Int32? QtyMin
        {
            get { return _qtyMin; }
            set { _qtyMin = value; }
        }

        /// <summary>
        ///     the value of the "PRS_QTY_MAX" field.
        /// </summary>
        public Int32? QtyMax
        {
            get { return _qtyMax; }
            set { _qtyMax = value; }
        }

        /// <summary>
        ///     the value of the "PRS_VALID_FROM" field.
        /// </summary>
        public DateTime? ValidFrom
        {
            get { return _validFrom; }
            set { _validFrom = value; }
        }

        /// <summary>
        ///     the value of the "PRS_VALID_UNTIL" field.
        /// </summary>
        public DateTime? ValidUntil
        {
            get { return _validUntil; }
            set { _validUntil = value; }
        }

        /// <summary>
        ///     the value of the "PRS_BEFORE_DAYS" field.
        /// </summary>
        public Int32? BeforeDays
        {
            get { return _beforeDays; }
            set { _beforeDays = value; }
        }

        /// <summary>
        ///     the value of the "PRS_VAT_CODE2" field.
        /// </summary>
        public String VatCode2
        {
            get { return _vatCode2; }
            set { _vatCode2 = value; }
        }

        /// <summary>
        ///     the value of the "PRS_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        ///     the value of the "PRS_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        /// <summary>
        ///     the value of the "PRS_QUAL_ID" field.
        /// </summary>
        public String QualId
        {
            get { return _qualId; }
            set { _qualId = value; }
        }

        /// <summary>
        ///     the value of the "PRS_PREPAY_PROD_ID" field.
        /// </summary>
        public String PrepayProdId
        {
            get { return _prepayProdId; }
            set { _prepayProdId = value; }
        }

        /// <summary>
        ///     the value of the "PRS_LINE_ID" field.
        /// </summary>
        public String LineId
        {
            get { return _lineId; }
            set { _lineId = value; }
        }

        /// <summary>
        ///     the value of the "PRS_SEAS_ID" field.
        /// </summary>
        public String SeasId
        {
            get { return _seasId; }
            set { _seasId = value; }
        }

        /// <summary>
        ///     the value of the "PRS_INC_PLACES" field.
        /// </summary>
        public Byte? IncPlaces
        {
            get { return _incPlaces; }
            set { _incPlaces = value; }
        }

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_1" field.
        /// </summary>
        public Decimal? SubPrice1
        {
            get { return _subPrice1; }
            set { _subPrice1 = value; }
        }

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_2" field.
        /// </summary>
        public Decimal? SubPrice2
        {
            get { return _subPrice2; }
            set { _subPrice2 = value; }
        }

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_3" field.
        /// </summary>
        public Decimal? SubPrice3
        {
            get { return _subPrice3; }
            set { _subPrice3 = value; }
        }

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_4" field.
        /// </summary>
        public Decimal? SubPrice4
        {
            get { return _subPrice4; }
            set { _subPrice4 = value; }
        }

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_5" field.
        /// </summary>
        public Decimal? SubPrice5
        {
            get { return _subPrice5; }
            set { _subPrice5 = value; }
        }

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_6" field.
        /// </summary>
        public Decimal? SubPrice6
        {
            get { return _subPrice6; }
            set { _subPrice6 = value; }
        }

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_7" field.
        /// </summary>
        public Decimal? SubPrice7
        {
            get { return _subPrice7; }
            set { _subPrice7 = value; }
        }

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_8" field.
        /// </summary>
        public Decimal? SubPrice8
        {
            get { return _subPrice8; }
            set { _subPrice8 = value; }
        }

        /// <summary>
        ///     the value of the "PRS_SUB_PRICE_9" field.
        /// </summary>
        public Decimal? SubPrice9
        {
            get { return _subPrice9; }
            set { _subPrice9 = value; }
        }

        /// <summary>
        ///     the value of the "PRS_CURR_TYPE" field.
        /// </summary>
        public String CurrType
        {
            get { return _currType; }
            set { _currType = value; }
        }

        /// <summary>
        ///     the value of the "PRS_DO_NOT_RECALC" field.
        /// </summary>
        public Byte? DoNotRecalc
        {
            get { return _doNotRecalc; }
            set { _doNotRecalc = value; }
        }

        /// <summary>
        ///     the value of the "PRS_SCHN_NUMBER" field.
        /// </summary>
        public Byte? SchnNumber
        {
            get { return _schnNumber; }
            set { _schnNumber = value; }
        }

        /// <summary>
        ///     the value of the "PRS_MEMB_PRICE" field.
        /// </summary>
        public Byte? MembPrice
        {
            get { return _membPrice; }
            set { _membPrice = value; }
        }

        /// <summary>
        ///     the value of the "PRS_START" field.
        /// </summary>
        public Int32? Start
        {
            get { return _start; }
            set { _start = value; }
        }

        /// <summary>
        ///     the value of the "PRS_END" field.
        /// </summary>
        public Int32? End
        {
            get { return _end; }
            set { _end = value; }
        }

        /// <summary>
        ///     the value of the "PRS_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        /// <summary>
        ///     the value of the "PRS_PRS_ID" field.
        /// </summary>
        public String PrsId
        {
            get { return _prsId; }
            set { _prsId = value; }
        }

        /// <summary>
        ///     the value of the "PRS_WEB" field.
        /// </summary>
        public Byte Web
        {
            get { return _web; }
            set { _web = value; }
        }

        /// <summary>
        ///     the value of the "PRS_VALID_DATE" field.
        /// </summary>
        public Byte ValidDate
        {
            get { return _validDate; }
            set { _validDate = value; }
        }

        /// <summary>
        ///     the value of the "PRS_REGION" field.
        /// </summary>
        public String Region
        {
            get { return _region; }
            set { _region = value; }
        }

        /// <summary>
        ///     the value of the "PRS_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "PRS_SEA_ID" field.
        /// </summary>
        public Int32? SeaId
        {
            get { return _seaId; }
            set { _seaId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PricesRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PricesRecord" /> object instance.
        /// </returns>
        public PricesRecord Clone()
        {
            PricesRecord record = new PricesRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.PlId = this.PlId;
            record.ProdId = this.ProdId;
            record.Price = this.Price;
            record.BlockPrice = this.BlockPrice;
            record.SparePrice = this.SparePrice;
            record.CostPrice = this.CostPrice;
            record.CostCode = this.CostCode;
            record.RevCode = this.RevCode;
            record.DiscSched = this.DiscSched;
            record.VatCode = this.VatCode;
            record.RetailPrice = this.RetailPrice;
            record.NoCostNoSel = this.NoCostNoSel;
            record.Default = this.Default;
            record.GlCode1 = this.GlCode1;
            record.GlCode2 = this.GlCode2;
            record.ProdCategory = this.ProdCategory;
            record.DiscPercent = this.DiscPercent;
            record.PriceA = this.PriceA;
            record.PriceB = this.PriceB;
            record.PriceC = this.PriceC;
            record.PriceD = this.PriceD;
            record.PriceE = this.PriceE;
            record.GroupQty = this.GroupQty;
            record.GroupDte = this.GroupDte;
            record.GroupQtyId = this.GroupQtyId;
            record.GroupDteId = this.GroupDteId;
            record.QtyMin = this.QtyMin;
            record.QtyMax = this.QtyMax;
            record.ValidFrom = this.ValidFrom;
            record.ValidUntil = this.ValidUntil;
            record.BeforeDays = this.BeforeDays;
            record.VatCode2 = this.VatCode2;
            record.StartDate = this.StartDate;
            record.EndDate = this.EndDate;
            record.QualId = this.QualId;
            record.PrepayProdId = this.PrepayProdId;
            record.LineId = this.LineId;
            record.SeasId = this.SeasId;
            record.IncPlaces = this.IncPlaces;
            record.SubPrice1 = this.SubPrice1;
            record.SubPrice2 = this.SubPrice2;
            record.SubPrice3 = this.SubPrice3;
            record.SubPrice4 = this.SubPrice4;
            record.SubPrice5 = this.SubPrice5;
            record.SubPrice6 = this.SubPrice6;
            record.SubPrice7 = this.SubPrice7;
            record.SubPrice8 = this.SubPrice8;
            record.SubPrice9 = this.SubPrice9;
            record.CurrType = this.CurrType;
            record.DoNotRecalc = this.DoNotRecalc;
            record.SchnNumber = this.SchnNumber;
            record.MembPrice = this.MembPrice;
            record.Start = this.Start;
            record.End = this.End;
            record.Desc = this.Desc;
            record.PrsId = this.PrsId;
            record.Web = this.Web;
            record.ValidDate = this.ValidDate;
            record.Region = this.Region;
            record.Type = this.Type;
            record.SeaId = this.SeaId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PricesRecord" /> instance is equal to another <see cref="PricesRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PricesRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PricesRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.PlId.TrimOrNullify() == that.PlId.TrimOrNullify());
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.Price == that.Price);
            result = result && (this.BlockPrice == that.BlockPrice);
            result = result && (this.SparePrice == that.SparePrice);
            result = result && (this.CostPrice == that.CostPrice);
            result = result && (this.CostCode.TrimOrNullify() == that.CostCode.TrimOrNullify());
            result = result && (this.RevCode.TrimOrNullify() == that.RevCode.TrimOrNullify());
            result = result && (this.DiscSched.TrimOrNullify() == that.DiscSched.TrimOrNullify());
            result = result && (this.VatCode.TrimOrNullify() == that.VatCode.TrimOrNullify());
            result = result && (this.RetailPrice == that.RetailPrice);
            result = result && (this.NoCostNoSel == that.NoCostNoSel);
            result = result && (this.Default == that.Default);
            result = result && (this.GlCode1.TrimOrNullify() == that.GlCode1.TrimOrNullify());
            result = result && (this.GlCode2.TrimOrNullify() == that.GlCode2.TrimOrNullify());
            result = result && (this.ProdCategory.TrimOrNullify() == that.ProdCategory.TrimOrNullify());
            result = result && (this.DiscPercent == that.DiscPercent);
            result = result && (this.PriceA == that.PriceA);
            result = result && (this.PriceB == that.PriceB);
            result = result && (this.PriceC == that.PriceC);
            result = result && (this.PriceD == that.PriceD);
            result = result && (this.PriceE == that.PriceE);
            result = result && (this.GroupQty == that.GroupQty);
            result = result && (this.GroupDte == that.GroupDte);
            result = result && (this.GroupQtyId.TrimOrNullify() == that.GroupQtyId.TrimOrNullify());
            result = result && (this.GroupDteId.TrimOrNullify() == that.GroupDteId.TrimOrNullify());
            result = result && (this.QtyMin == that.QtyMin);
            result = result && (this.QtyMax == that.QtyMax);
            result = result && (this.ValidFrom == that.ValidFrom);
            result = result && (this.ValidUntil == that.ValidUntil);
            result = result && (this.BeforeDays == that.BeforeDays);
            result = result && (this.VatCode2.TrimOrNullify() == that.VatCode2.TrimOrNullify());
            result = result && (this.StartDate == that.StartDate);
            result = result && (this.EndDate == that.EndDate);
            result = result && (this.QualId.TrimOrNullify() == that.QualId.TrimOrNullify());
            result = result && (this.PrepayProdId.TrimOrNullify() == that.PrepayProdId.TrimOrNullify());
            result = result && (this.LineId.TrimOrNullify() == that.LineId.TrimOrNullify());
            result = result && (this.SeasId.TrimOrNullify() == that.SeasId.TrimOrNullify());
            result = result && (this.IncPlaces == that.IncPlaces);
            result = result && (this.SubPrice1 == that.SubPrice1);
            result = result && (this.SubPrice2 == that.SubPrice2);
            result = result && (this.SubPrice3 == that.SubPrice3);
            result = result && (this.SubPrice4 == that.SubPrice4);
            result = result && (this.SubPrice5 == that.SubPrice5);
            result = result && (this.SubPrice6 == that.SubPrice6);
            result = result && (this.SubPrice7 == that.SubPrice7);
            result = result && (this.SubPrice8 == that.SubPrice8);
            result = result && (this.SubPrice9 == that.SubPrice9);
            result = result && (this.CurrType.TrimOrNullify() == that.CurrType.TrimOrNullify());
            result = result && (this.DoNotRecalc == that.DoNotRecalc);
            result = result && (this.SchnNumber == that.SchnNumber);
            result = result && (this.MembPrice == that.MembPrice);
            result = result && (this.Start == that.Start);
            result = result && (this.End == that.End);
            result = result && (this.Desc.TrimOrNullify() == that.Desc.TrimOrNullify());
            result = result && (this.PrsId.TrimOrNullify() == that.PrsId.TrimOrNullify());
            result = result && (this.Web == that.Web);
            result = result && (this.ValidDate == that.ValidDate);
            result = result && (this.Region.TrimOrNullify() == that.Region.TrimOrNullify());
            result = result && (this.Type == that.Type);
            result = result && (this.SeaId == that.SeaId);
            return result;
        }

        #endregion
    }
}
