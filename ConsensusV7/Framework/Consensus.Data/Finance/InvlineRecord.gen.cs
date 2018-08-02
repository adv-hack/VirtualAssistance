using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Represents the "InvLine" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class InvlineRecord : Record<String>, Cloneable<InvlineRecord>, IEquatable<InvlineRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "INVLN_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "INVLN_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "INVLN_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "INVLN_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "INVLN_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "INVLN_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "INVLN_INV_ID" field.
        /// </summary>
        private String _invId;

        /// <summary>
        ///     the value of the "INVLN_PRODUCT_ID" field.
        /// </summary>
        private String _productId;

        /// <summary>
        ///     the value of the "INVLN_ORDER_LN_ID" field.
        /// </summary>
        private String _orderLnId;

        /// <summary>
        ///     the value of the "INVLN_LINE_NO" field.
        /// </summary>
        private Double? _lineNo;

        /// <summary>
        ///     the value of the "INVLN_QTY" field.
        /// </summary>
        private Double? _qty;

        /// <summary>
        ///     the value of the "INVLN_UNIT_PRICE" field.
        /// </summary>
        private Decimal _unitPrice;

        /// <summary>
        ///     the value of the "INVLN_DISCOUNT" field.
        /// </summary>
        private Decimal _discount;

        /// <summary>
        ///     the value of the "INVLN_DISCT_PRICE" field.
        /// </summary>
        private Decimal _disctPrice;

        /// <summary>
        ///     the value of the "INVLN_NET" field.
        /// </summary>
        private Decimal _net;

        /// <summary>
        ///     the value of the "INVLN_VAT_CODE" field.
        /// </summary>
        private String _vatCode;

        /// <summary>
        ///     the value of the "INVLN_VAT_RATE" field.
        /// </summary>
        private Decimal _vatRate;

        /// <summary>
        ///     the value of the "INVLN_VAT_AMT" field.
        /// </summary>
        private Decimal _vatAmt;

        /// <summary>
        ///     the value of the "INVLN_TOTAL_PRICE" field.
        /// </summary>
        private Decimal _totalPrice;

        /// <summary>
        ///     the value of the "INVLN_CREDIT_DESC" field.
        /// </summary>
        private String _creditDesc;

        /// <summary>
        ///     the value of the "INVLN_UNIT_PRCE_BC" field.
        /// </summary>
        private Decimal _unitPrceBc;

        /// <summary>
        ///     the value of the "INVLN_DISCOUNT_BC" field.
        /// </summary>
        private Decimal _discountBc;

        /// <summary>
        ///     the value of the "INVLN_DISC_PRCE_BC" field.
        /// </summary>
        private Decimal _discPrceBc;

        /// <summary>
        ///     the value of the "INVLN_NET_BC" field.
        /// </summary>
        private Decimal _netBc;

        /// <summary>
        ///     the value of the "INVLN_TOT_PRICE_BC" field.
        /// </summary>
        private Decimal _totPriceBc;

        /// <summary>
        ///     the value of the "INVLN_CURR_TYPE" field.
        /// </summary>
        private String _currType;

        /// <summary>
        ///     the value of the "INVLN_DESCRIPTION" field.
        /// </summary>
        private String _description;

        /// <summary>
        ///     the value of the "INVLN_SALES_ID" field.
        /// </summary>
        private String _salesId;

        /// <summary>
        ///     the value of the "INVLN_SALES_DET_ID" field.
        /// </summary>
        private String _salesDetId;

        /// <summary>
        ///     the value of the "INVLN_BOOK_ID" field.
        /// </summary>
        private String _bookId;

        /// <summary>
        ///     the value of the "INVLN_ELEM_ID" field.
        /// </summary>
        private String _elemId;

        /// <summary>
        ///     the value of the "INVLN_COURSE_ID" field.
        /// </summary>
        private String _courseId;

        /// <summary>
        ///     the value of the "INVLN_TYPE" field.
        /// </summary>
        private Byte? _type;

        /// <summary>
        ///     the value of the "INVLN_PROD_NAME" field.
        /// </summary>
        private String _prodName;

        /// <summary>
        ///     the value of the "INVLN_PRD_REV_CODE" field.
        /// </summary>
        private String _prdRevCode;

        /// <summary>
        ///     the value of the "INVLN_PROJ_ID" field.
        /// </summary>
        private String _projId;

        /// <summary>
        ///     the value of the "INVLN_MEL_ID" field.
        /// </summary>
        private String _melId;

        /// <summary>
        ///     the value of the "INVLN_UNT_PRCE_BC2" field.
        /// </summary>
        private Decimal _untPrceBc2;

        /// <summary>
        ///     the value of the "INVLN_NET_BC2" field.
        /// </summary>
        private Decimal _netBc2;

        /// <summary>
        ///     the value of the "INVLN_TOT_PRCE_BC2" field.
        /// </summary>
        private Decimal _totPrceBc2;

        /// <summary>
        ///     the value of the "INVLN_VAT_AMT_BC" field.
        /// </summary>
        private Decimal _vatAmtBc;

        /// <summary>
        ///     the value of the "INVLN_VAT_AMT_BC2" field.
        /// </summary>
        private Decimal _vatAmtBc2;

        /// <summary>
        ///     the value of the "INVLN_COST_CODE" field.
        /// </summary>
        private String _costCode;

        /// <summary>
        ///     the value of the "INVLN_CREDITED" field.
        /// </summary>
        private Byte? _credited;

        /// <summary>
        ///     the value of the "INVLN_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "INVLN_ANL1" field.
        /// </summary>
        private String _anl1;

        /// <summary>
        ///     the value of the "INVLN_ANL2" field.
        /// </summary>
        private String _anl2;

        /// <summary>
        ///     the value of the "INVLN_ANL3" field.
        /// </summary>
        private String _anl3;

        /// <summary>
        ///     the value of the "INVLN_DISCOUNT_BC2" field.
        /// </summary>
        private Decimal _discountBc2;

        /// <summary>
        ///     the value of the "INVLN_DISC_PRICE_BC2" field.
        /// </summary>
        private Decimal _discPriceBc2;

        /// <summary>
        ///     the value of the "INVLN_CREDIT_FOR_INVLN_ID" field.
        /// </summary>
        private String _creditForInvlnId;

        /// <summary>
        ///     the value of the "INVLN_DO_NOT_PRINT" field.
        /// </summary>
        private Byte _doNotPrint;

        /// <summary>
        ///     the value of the "INVLN_DEL_COST_CODE" field.
        /// </summary>
        private String _delCostCode;

        /// <summary>
        ///     the value of the "INVLN_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "INVLN_CURRENCY_TYPE" field.
        /// </summary>
        private String _currencyType;

        /// <summary>
        ///     the value of the "INVLN_CURR_RATE_BC" field.
        /// </summary>
        private Decimal? _currRateBc;

        /// <summary>
        ///     the value of the "INVLN_CURR_RATE_BC2" field.
        /// </summary>
        private Decimal? _currRateBc2;

        /// <summary>
        ///     the value of the "INVLN_UNIT_PRICE_DISC" field.
        /// </summary>
        private Decimal? _unitPriceDisc;

        /// <summary>
        ///     the value of the "INVLN_UNIT_PRICE_DISC_BC" field.
        /// </summary>
        private Decimal? _unitPriceDiscBc;

        /// <summary>
        ///     the value of the "INVLN_UNIT_PRICE_DISC_BC2" field.
        /// </summary>
        private Decimal? _unitPriceDiscBc2;

        /// <summary>
        ///     the value of the "INVLN_DEPT" field.
        /// </summary>
        private String _dept;

        /// <summary>
        ///     the value of the "INVLN_SKU" field.
        /// </summary>
        private String _sku;

        /// <summary>
        ///     the value of the "INVLN_JOB_CODE" field.
        /// </summary>
        private String _jobCode;

        /// <summary>
        ///     the value of the "INVLN_JOB_ANAL_CODE" field.
        /// </summary>
        private String _jobAnalCode;

        /// <summary>
        ///     the value of the "INVLN_JOB_TYPE" field.
        /// </summary>
        private String _jobType;

        /// <summary>
        ///     the value of the "INVLN_JOB_PARENT" field.
        /// </summary>
        private String _jobParent;

        /// <summary>
        ///     the value of the "INVLN_PRS_TYPE" field.
        /// </summary>
        private Byte _prsType;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "INVLN_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_INV_ID" field.
        /// </summary>
        public String InvId
        {
            get { return _invId; }
            set { _invId = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_PRODUCT_ID" field.
        /// </summary>
        public String ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_ORDER_LN_ID" field.
        /// </summary>
        public String OrderLnId
        {
            get { return _orderLnId; }
            set { _orderLnId = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_LINE_NO" field.
        /// </summary>
        public Double? LineNo
        {
            get { return _lineNo; }
            set { _lineNo = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_QTY" field.
        /// </summary>
        public Double? Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_UNIT_PRICE" field.
        /// </summary>
        public Decimal UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_DISCOUNT" field.
        /// </summary>
        public Decimal Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_DISCT_PRICE" field.
        /// </summary>
        public Decimal DisctPrice
        {
            get { return _disctPrice; }
            set { _disctPrice = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_NET" field.
        /// </summary>
        public Decimal Net
        {
            get { return _net; }
            set { _net = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_VAT_CODE" field.
        /// </summary>
        public String VatCode
        {
            get { return _vatCode; }
            set { _vatCode = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_VAT_RATE" field.
        /// </summary>
        public Decimal VatRate
        {
            get { return _vatRate; }
            set { _vatRate = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_VAT_AMT" field.
        /// </summary>
        public Decimal VatAmt
        {
            get { return _vatAmt; }
            set { _vatAmt = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_TOTAL_PRICE" field.
        /// </summary>
        public Decimal TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_CREDIT_DESC" field.
        /// </summary>
        public String CreditDesc
        {
            get { return _creditDesc; }
            set { _creditDesc = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_UNIT_PRCE_BC" field.
        /// </summary>
        public Decimal UnitPrceBc
        {
            get { return _unitPrceBc; }
            set { _unitPrceBc = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_DISCOUNT_BC" field.
        /// </summary>
        public Decimal DiscountBc
        {
            get { return _discountBc; }
            set { _discountBc = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_DISC_PRCE_BC" field.
        /// </summary>
        public Decimal DiscPrceBc
        {
            get { return _discPrceBc; }
            set { _discPrceBc = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_NET_BC" field.
        /// </summary>
        public Decimal NetBc
        {
            get { return _netBc; }
            set { _netBc = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_TOT_PRICE_BC" field.
        /// </summary>
        public Decimal TotPriceBc
        {
            get { return _totPriceBc; }
            set { _totPriceBc = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_CURR_TYPE" field.
        /// </summary>
        public String CurrType
        {
            get { return _currType; }
            set { _currType = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_SALES_ID" field.
        /// </summary>
        public String SalesId
        {
            get { return _salesId; }
            set { _salesId = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_SALES_DET_ID" field.
        /// </summary>
        public String SalesDetId
        {
            get { return _salesDetId; }
            set { _salesDetId = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_BOOK_ID" field.
        /// </summary>
        public String BookId
        {
            get { return _bookId; }
            set { _bookId = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_ELEM_ID" field.
        /// </summary>
        public String ElemId
        {
            get { return _elemId; }
            set { _elemId = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_COURSE_ID" field.
        /// </summary>
        public String CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_PROD_NAME" field.
        /// </summary>
        public String ProdName
        {
            get { return _prodName; }
            set { _prodName = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_PRD_REV_CODE" field.
        /// </summary>
        public String PrdRevCode
        {
            get { return _prdRevCode; }
            set { _prdRevCode = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_PROJ_ID" field.
        /// </summary>
        public String ProjId
        {
            get { return _projId; }
            set { _projId = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_MEL_ID" field.
        /// </summary>
        public String MelId
        {
            get { return _melId; }
            set { _melId = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_UNT_PRCE_BC2" field.
        /// </summary>
        public Decimal UntPrceBc2
        {
            get { return _untPrceBc2; }
            set { _untPrceBc2 = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_NET_BC2" field.
        /// </summary>
        public Decimal NetBc2
        {
            get { return _netBc2; }
            set { _netBc2 = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_TOT_PRCE_BC2" field.
        /// </summary>
        public Decimal TotPrceBc2
        {
            get { return _totPrceBc2; }
            set { _totPrceBc2 = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_VAT_AMT_BC" field.
        /// </summary>
        public Decimal VatAmtBc
        {
            get { return _vatAmtBc; }
            set { _vatAmtBc = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_VAT_AMT_BC2" field.
        /// </summary>
        public Decimal VatAmtBc2
        {
            get { return _vatAmtBc2; }
            set { _vatAmtBc2 = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return _costCode; }
            set { _costCode = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_CREDITED" field.
        /// </summary>
        public Byte? Credited
        {
            get { return _credited; }
            set { _credited = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_ANL1" field.
        /// </summary>
        public String Anl1
        {
            get { return _anl1; }
            set { _anl1 = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_ANL2" field.
        /// </summary>
        public String Anl2
        {
            get { return _anl2; }
            set { _anl2 = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_ANL3" field.
        /// </summary>
        public String Anl3
        {
            get { return _anl3; }
            set { _anl3 = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_DISCOUNT_BC2" field.
        /// </summary>
        public Decimal DiscountBc2
        {
            get { return _discountBc2; }
            set { _discountBc2 = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_DISC_PRICE_BC2" field.
        /// </summary>
        public Decimal DiscPriceBc2
        {
            get { return _discPriceBc2; }
            set { _discPriceBc2 = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_CREDIT_FOR_INVLN_ID" field.
        /// </summary>
        public String CreditForInvlnId
        {
            get { return _creditForInvlnId; }
            set { _creditForInvlnId = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_DO_NOT_PRINT" field.
        /// </summary>
        public Byte DoNotPrint
        {
            get { return _doNotPrint; }
            set { _doNotPrint = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_DEL_COST_CODE" field.
        /// </summary>
        public String DelCostCode
        {
            get { return _delCostCode; }
            set { _delCostCode = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_CURRENCY_TYPE" field.
        /// </summary>
        public String CurrencyType
        {
            get { return _currencyType; }
            set { _currencyType = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_CURR_RATE_BC" field.
        /// </summary>
        public Decimal? CurrRateBc
        {
            get { return _currRateBc; }
            set { _currRateBc = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_CURR_RATE_BC2" field.
        /// </summary>
        public Decimal? CurrRateBc2
        {
            get { return _currRateBc2; }
            set { _currRateBc2 = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_UNIT_PRICE_DISC" field.
        /// </summary>
        public Decimal? UnitPriceDisc
        {
            get { return _unitPriceDisc; }
            set { _unitPriceDisc = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_UNIT_PRICE_DISC_BC" field.
        /// </summary>
        public Decimal? UnitPriceDiscBc
        {
            get { return _unitPriceDiscBc; }
            set { _unitPriceDiscBc = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_UNIT_PRICE_DISC_BC2" field.
        /// </summary>
        public Decimal? UnitPriceDiscBc2
        {
            get { return _unitPriceDiscBc2; }
            set { _unitPriceDiscBc2 = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_DEPT" field.
        /// </summary>
        public String Dept
        {
            get { return _dept; }
            set { _dept = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_SKU" field.
        /// </summary>
        public String Sku
        {
            get { return _sku; }
            set { _sku = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_JOB_CODE" field.
        /// </summary>
        public String JobCode
        {
            get { return _jobCode; }
            set { _jobCode = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_JOB_ANAL_CODE" field.
        /// </summary>
        public String JobAnalCode
        {
            get { return _jobAnalCode; }
            set { _jobAnalCode = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_JOB_TYPE" field.
        /// </summary>
        public String JobType
        {
            get { return _jobType; }
            set { _jobType = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_JOB_PARENT" field.
        /// </summary>
        public String JobParent
        {
            get { return _jobParent; }
            set { _jobParent = value; }
        }

        /// <summary>
        ///     the value of the "INVLN_PRS_TYPE" field.
        /// </summary>
        public Byte PrsType
        {
            get { return _prsType; }
            set { _prsType = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="InvlineRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="InvlineRecord" /> object instance.
        /// </returns>
        public InvlineRecord Clone()
        {
            InvlineRecord record = new InvlineRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.InvId = this.InvId;
            record.ProductId = this.ProductId;
            record.OrderLnId = this.OrderLnId;
            record.LineNo = this.LineNo;
            record.Qty = this.Qty;
            record.UnitPrice = this.UnitPrice;
            record.Discount = this.Discount;
            record.DisctPrice = this.DisctPrice;
            record.Net = this.Net;
            record.VatCode = this.VatCode;
            record.VatRate = this.VatRate;
            record.VatAmt = this.VatAmt;
            record.TotalPrice = this.TotalPrice;
            record.CreditDesc = this.CreditDesc;
            record.UnitPrceBc = this.UnitPrceBc;
            record.DiscountBc = this.DiscountBc;
            record.DiscPrceBc = this.DiscPrceBc;
            record.NetBc = this.NetBc;
            record.TotPriceBc = this.TotPriceBc;
            record.CurrType = this.CurrType;
            record.Description = this.Description;
            record.SalesId = this.SalesId;
            record.SalesDetId = this.SalesDetId;
            record.BookId = this.BookId;
            record.ElemId = this.ElemId;
            record.CourseId = this.CourseId;
            record.Type = this.Type;
            record.ProdName = this.ProdName;
            record.PrdRevCode = this.PrdRevCode;
            record.ProjId = this.ProjId;
            record.MelId = this.MelId;
            record.UntPrceBc2 = this.UntPrceBc2;
            record.NetBc2 = this.NetBc2;
            record.TotPrceBc2 = this.TotPrceBc2;
            record.VatAmtBc = this.VatAmtBc;
            record.VatAmtBc2 = this.VatAmtBc2;
            record.CostCode = this.CostCode;
            record.Credited = this.Credited;
            record.Userchar1 = this.Userchar1;
            record.Anl1 = this.Anl1;
            record.Anl2 = this.Anl2;
            record.Anl3 = this.Anl3;
            record.DiscountBc2 = this.DiscountBc2;
            record.DiscPriceBc2 = this.DiscPriceBc2;
            record.CreditForInvlnId = this.CreditForInvlnId;
            record.DoNotPrint = this.DoNotPrint;
            record.DelCostCode = this.DelCostCode;
            record.SelcoSpId = this.SelcoSpId;
            record.CurrencyType = this.CurrencyType;
            record.CurrRateBc = this.CurrRateBc;
            record.CurrRateBc2 = this.CurrRateBc2;
            record.UnitPriceDisc = this.UnitPriceDisc;
            record.UnitPriceDiscBc = this.UnitPriceDiscBc;
            record.UnitPriceDiscBc2 = this.UnitPriceDiscBc2;
            record.Dept = this.Dept;
            record.Sku = this.Sku;
            record.JobCode = this.JobCode;
            record.JobAnalCode = this.JobAnalCode;
            record.JobType = this.JobType;
            record.JobParent = this.JobParent;
            record.PrsType = this.PrsType;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="InvlineRecord" /> instance is equal to another <see cref="InvlineRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="InvlineRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(InvlineRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.InvId.TrimOrNullify() == that.InvId.TrimOrNullify());
            result = result && (this.ProductId.TrimOrNullify() == that.ProductId.TrimOrNullify());
            result = result && (this.OrderLnId.TrimOrNullify() == that.OrderLnId.TrimOrNullify());
            result = result && (this.LineNo == that.LineNo);
            result = result && (this.Qty == that.Qty);
            result = result && (this.UnitPrice == that.UnitPrice);
            result = result && (this.Discount == that.Discount);
            result = result && (this.DisctPrice == that.DisctPrice);
            result = result && (this.Net == that.Net);
            result = result && (this.VatCode.TrimOrNullify() == that.VatCode.TrimOrNullify());
            result = result && (this.VatRate == that.VatRate);
            result = result && (this.VatAmt == that.VatAmt);
            result = result && (this.TotalPrice == that.TotalPrice);
            result = result && (this.CreditDesc.TrimOrNullify() == that.CreditDesc.TrimOrNullify());
            result = result && (this.UnitPrceBc == that.UnitPrceBc);
            result = result && (this.DiscountBc == that.DiscountBc);
            result = result && (this.DiscPrceBc == that.DiscPrceBc);
            result = result && (this.NetBc == that.NetBc);
            result = result && (this.TotPriceBc == that.TotPriceBc);
            result = result && (this.CurrType.TrimOrNullify() == that.CurrType.TrimOrNullify());
            result = result && (this.Description.TrimOrNullify() == that.Description.TrimOrNullify());
            result = result && (this.SalesId.TrimOrNullify() == that.SalesId.TrimOrNullify());
            result = result && (this.SalesDetId.TrimOrNullify() == that.SalesDetId.TrimOrNullify());
            result = result && (this.BookId.TrimOrNullify() == that.BookId.TrimOrNullify());
            result = result && (this.ElemId.TrimOrNullify() == that.ElemId.TrimOrNullify());
            result = result && (this.CourseId.TrimOrNullify() == that.CourseId.TrimOrNullify());
            result = result && (this.Type == that.Type);
            result = result && (this.ProdName.TrimOrNullify() == that.ProdName.TrimOrNullify());
            result = result && (this.PrdRevCode.TrimOrNullify() == that.PrdRevCode.TrimOrNullify());
            result = result && (this.ProjId.TrimOrNullify() == that.ProjId.TrimOrNullify());
            result = result && (this.MelId.TrimOrNullify() == that.MelId.TrimOrNullify());
            result = result && (this.UntPrceBc2 == that.UntPrceBc2);
            result = result && (this.NetBc2 == that.NetBc2);
            result = result && (this.TotPrceBc2 == that.TotPrceBc2);
            result = result && (this.VatAmtBc == that.VatAmtBc);
            result = result && (this.VatAmtBc2 == that.VatAmtBc2);
            result = result && (this.CostCode.TrimOrNullify() == that.CostCode.TrimOrNullify());
            result = result && (this.Credited == that.Credited);
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.Anl1.TrimOrNullify() == that.Anl1.TrimOrNullify());
            result = result && (this.Anl2.TrimOrNullify() == that.Anl2.TrimOrNullify());
            result = result && (this.Anl3.TrimOrNullify() == that.Anl3.TrimOrNullify());
            result = result && (this.DiscountBc2 == that.DiscountBc2);
            result = result && (this.DiscPriceBc2 == that.DiscPriceBc2);
            result = result && (this.CreditForInvlnId.TrimOrNullify() == that.CreditForInvlnId.TrimOrNullify());
            result = result && (this.DoNotPrint == that.DoNotPrint);
            result = result && (this.DelCostCode.TrimOrNullify() == that.DelCostCode.TrimOrNullify());
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.CurrencyType.TrimOrNullify() == that.CurrencyType.TrimOrNullify());
            result = result && (this.CurrRateBc == that.CurrRateBc);
            result = result && (this.CurrRateBc2 == that.CurrRateBc2);
            result = result && (this.UnitPriceDisc == that.UnitPriceDisc);
            result = result && (this.UnitPriceDiscBc == that.UnitPriceDiscBc);
            result = result && (this.UnitPriceDiscBc2 == that.UnitPriceDiscBc2);
            result = result && (this.Dept.TrimOrNullify() == that.Dept.TrimOrNullify());
            result = result && (this.Sku.TrimOrNullify() == that.Sku.TrimOrNullify());
            result = result && (this.JobCode.TrimOrNullify() == that.JobCode.TrimOrNullify());
            result = result && (this.JobAnalCode.TrimOrNullify() == that.JobAnalCode.TrimOrNullify());
            result = result && (this.JobType.TrimOrNullify() == that.JobType.TrimOrNullify());
            result = result && (this.JobParent.TrimOrNullify() == that.JobParent.TrimOrNullify());
            result = result && (this.PrsType == that.PrsType);
            return result;
        }

        #endregion
    }
}
