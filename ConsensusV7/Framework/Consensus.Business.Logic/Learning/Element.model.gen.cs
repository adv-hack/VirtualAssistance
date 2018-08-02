using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Finance;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ElementRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalElementModel : LocalModel<ElementRecord, String>, IElementModel
    {
        #region fields

        /// <summary>
        ///     The value of the "ELEM_DEL_ID" field.
        /// </summary>
        private LocalLearnerModel _delegate;

        /// <summary>
        ///     The value of the "ELEM_PROD_ID" field.
        /// </summary>
        private LocalProductModel _product;

        /// <summary>
        ///     The value of the "ELEM_ACT_ID" field.
        /// </summary>
        private LocalActivityModel _activity;

        /// <summary>
        ///     The value of the "ELEM_COURSE_ID" field.
        /// </summary>
        private LocalEventModel _course;

        /// <summary>
        ///     The value of the "ELEM_BOOK_ID" field.
        /// </summary>
        private LocalBookingModel _booking;

        /// <summary>
        ///     The value of the "ELEM_VATCD" field.
        /// </summary>
        private LocalCodeModel _vatcd;

        /// <summary>
        ///     The value of the "ELEM_REV_CODE" field.
        /// </summary>
        private LocalCodeModel _revCode;

        /// <summary>
        ///     The value of the "ELEM_GRADE" field.
        /// </summary>
        private LocalCodeModel _grade;

        /// <summary>
        ///     The value of the "ELEM_PAYMENT_METHD" field.
        /// </summary>
        private LocalCodeModel _paymentMethod;

        /// <summary>
        ///     The value of the "ELEM_PL_ID" field.
        /// </summary>
        private LocalPriceListModel _priceList;

        /// <summary>
        ///     The value of the "ELEM_SXREF_ID" field.
        /// </summary>
        private LocalSessionXrefModel _sessionXrefs;

        /// <summary>
        ///     The value of the "ELEM_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The value of the "ELEM_PRS_ID" field.
        /// </summary>
        private LocalPriceModel _priceId;

        /// <summary>
        ///     The value of the "ELEM_ELEM_ID" field.
        /// </summary>
        private LocalElementModel _parentElement;

        /// <summary>
        ///     The value of the "ELEM_BKT_ID" field.
        /// </summary>
        private LocalBookingTermsModel _bookingTerm;

        /// <summary>
        ///     The value of the "ELEM_PSH_ID" field.
        /// </summary>
        private LocalPayscheduleheaderModel _paymentSchedule;

        /// <summary>
        ///     The collection of <see cref="ElementModel" /> instances that reference this <see cref="ElementModel" />.
        /// </summary>
        private LocalCollection<LocalElementModel, IElementModel> _elements;

        /// <summary>
        ///     The collection of <see cref="InvoiceLineModel" /> instances that reference this <see cref="ElementModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel> _invoiceLines;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ElementRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.Element.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ElementRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.Element.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ElementRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.Element.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_DEL_ID" field.
        /// </summary>
        public LocalLearnerModel Delegate
        {
            get
            {
                if (_delegate == null && this.DelegateId != null)
                    _delegate = this.Provider.Learning.Learner.FetchById(this.DelegateId);
                if (_delegate == null)
                    _delegate = this.Provider.Learning.Learner.Create();
                
                return _delegate;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_DEL_ID" field.
        /// </summary>
        public String DelegateId
        {
            get { return this.ModifiedData.DelId; }
            set
            {
                if (this.ModifiedData.DelId != value)
                     _delegate = null;
                this.ModifiedData.DelId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PROD_ID" field.
        /// </summary>
        public LocalProductModel Product
        {
            get
            {
                if (_product == null && this.ProductId != null)
                    _product = this.Provider.Learning.Product.FetchById(this.ProductId);
                if (_product == null)
                    _product = this.Provider.Learning.Product.Create();
                
                return _product;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PROD_ID" field.
        /// </summary>
        public String ProductId
        {
            get { return this.ModifiedData.ProdId; }
            set
            {
                if (this.ModifiedData.ProdId != value)
                     _product = null;
                this.ModifiedData.ProdId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_ACT_ID" field.
        /// </summary>
        public LocalActivityModel Activity
        {
            get
            {
                if (_activity == null && this.ActivityId != null)
                    _activity = this.Provider.Activities.Activity.FetchById(this.ActivityId);
                if (_activity == null)
                    _activity = this.Provider.Activities.Activity.Create();
                
                return _activity;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_ACT_ID" field.
        /// </summary>
        public String ActivityId
        {
            get { return this.ModifiedData.ActId; }
            set
            {
                if (this.ModifiedData.ActId != value)
                     _activity = null;
                this.ModifiedData.ActId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_COURSE_ID" field.
        /// </summary>
        public LocalEventModel Course
        {
            get
            {
                if (_course == null && this.CourseId != null)
                    _course = this.Provider.Learning.Event.FetchById(this.CourseId);
                if (_course == null)
                    _course = this.Provider.Learning.Event.Create();
                
                return _course;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_COURSE_ID" field.
        /// </summary>
        public String CourseId
        {
            get { return this.ModifiedData.CourseId; }
            set
            {
                if (this.ModifiedData.CourseId != value)
                     _course = null;
                this.ModifiedData.CourseId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_BOOK_ID" field.
        /// </summary>
        public LocalBookingModel Booking
        {
            get
            {
                if (_booking == null && this.BookingId != null)
                    _booking = this.Provider.Learning.Booking.FetchById(this.BookingId);
                if (_booking == null)
                    _booking = this.Provider.Learning.Booking.Create();
                
                return _booking;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_BOOK_ID" field.
        /// </summary>
        public String BookingId
        {
            get { return this.ModifiedData.BookId; }
            set
            {
                if (this.ModifiedData.BookId != value)
                     _booking = null;
                this.ModifiedData.BookId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CERT_NO" field.
        /// </summary>
        public String CertNo
        {
            get { return this.ModifiedData.CertNo; }
            set { this.ModifiedData.CertNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_ATTENDED" field.
        /// </summary>
        public Byte? Attended
        {
            get { return this.ModifiedData.Attended; }
            set { this.ModifiedData.Attended = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CURRENCY_TYPE" field.
        /// </summary>
        public String CurrencyType
        {
            get { return this.ModifiedData.CurrencyType; }
            set { this.ModifiedData.CurrencyType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_PRICE" field.
        /// </summary>
        public Decimal Price
        {
            get { return this.ModifiedData.Price; }
            set { this.ModifiedData.Price = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_BLOCK_PRICE" field.
        /// </summary>
        public Decimal BlockPrice
        {
            get { return this.ModifiedData.BlockPrice; }
            set { this.ModifiedData.BlockPrice = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_VATCD" field.
        /// </summary>
        public LocalCodeModel Vatcd
        {
            get
            {
                if (_vatcd == null && !String.IsNullOrEmpty(this.VatcdCode))
                    _vatcd = this.Provider.Common.Code.FetchByTypeAndCode("VATCD", this.VatcdCode);
                if (_vatcd == null)
                    _vatcd = this.Provider.Common.Code.Create("VATCD");
                return _vatcd;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_VATCD" field.
        /// </summary>
        public String VatcdCode
        {
            get { return this.ModifiedData.Vatcd; }
            set
            {
                if (this.ModifiedData.Vatcd != value)
                     _vatcd = null;
                this.ModifiedData.Vatcd = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return this.ModifiedData.CostCode; }
            set { this.ModifiedData.CostCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_DO_NOT_INVCE" field.
        /// </summary>
        public Byte? DoNotInvoice
        {
            get { return this.ModifiedData.DoNotInvce; }
            set { this.ModifiedData.DoNotInvce = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_INVOICED" field.
        /// </summary>
        public Byte? Invoiced
        {
            get { return this.ModifiedData.Invoiced; }
            set { this.ModifiedData.Invoiced = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_INVOICED_DATE" field.
        /// </summary>
        public DateTime? InvoicedDate
        {
            get { return this.ModifiedData.InvoicedDate; }
            set { this.ModifiedData.InvoicedDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return this.ModifiedData.Description; }
            set { this.ModifiedData.Description = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_REV_CODE" field.
        /// </summary>
        public LocalCodeModel RevCode
        {
            get
            {
                if (_revCode == null && !String.IsNullOrEmpty(this.RevCodeCode))
                    _revCode = this.Provider.Common.Code.FetchByTypeAndCode("REVE", this.RevCodeCode);
                if (_revCode == null)
                    _revCode = this.Provider.Common.Code.Create("REVE");
                return _revCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_REV_CODE" field.
        /// </summary>
        public String RevCodeCode
        {
            get { return this.ModifiedData.RevCode; }
            set
            {
                if (this.ModifiedData.RevCode != value)
                     _revCode = null;
                this.ModifiedData.RevCode = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_INVOICE_PRINT" field.
        /// </summary>
        public Byte? InvoicePrinted
        {
            get { return this.ModifiedData.InvoicePrint; }
            set { this.ModifiedData.InvoicePrint = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CANCELLED" field.
        /// </summary>
        public Byte? Cancelled
        {
            get { return this.ModifiedData.Cancelled; }
            set { this.ModifiedData.Cancelled = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return this.ModifiedData.Notes; }
            set { this.ModifiedData.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_NON_ATD_RSN" field.
        /// </summary>
        public String NonAtdRsn
        {
            get { return this.ModifiedData.NonAtdRsn; }
            set { this.ModifiedData.NonAtdRsn = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CERT_ISE_DAT" field.
        /// </summary>
        public DateTime? CertIseDat
        {
            get { return this.ModifiedData.CertIseDat; }
            set { this.ModifiedData.CertIseDat = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_PASS" field.
        /// </summary>
        public Byte? Pass
        {
            get { return this.ModifiedData.Pass; }
            set { this.ModifiedData.Pass = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_SCORE" field.
        /// </summary>
        public Decimal? Score
        {
            get { return this.ModifiedData.Score; }
            set { this.ModifiedData.Score = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_STATUS" field.
        /// </summary>
        public Byte? Status
        {
            get { return this.ModifiedData.Status; }
            set { this.ModifiedData.Status = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_GRADE" field.
        /// </summary>
        public LocalCodeModel Grade
        {
            get
            {
                if (_grade == null && !String.IsNullOrEmpty(this.GradeCode))
                    _grade = this.Provider.Common.Code.FetchByTypeAndCode("DLGRD", this.GradeCode);
                if (_grade == null)
                    _grade = this.Provider.Common.Code.Create("DLGRD");
                return _grade;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_GRADE" field.
        /// </summary>
        public String GradeCode
        {
            get { return this.ModifiedData.Grade; }
            set
            {
                if (this.ModifiedData.Grade != value)
                     _grade = null;
                this.ModifiedData.Grade = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PAYMENT_METHD" field.
        /// </summary>
        public LocalCodeModel PaymentMethod
        {
            get
            {
                if (_paymentMethod == null && !String.IsNullOrEmpty(this.PaymentMethodCode))
                    _paymentMethod = this.Provider.Common.Code.FetchByTypeAndCode("PAYM", this.PaymentMethodCode);
                if (_paymentMethod == null)
                    _paymentMethod = this.Provider.Common.Code.Create("PAYM");
                return _paymentMethod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PAYMENT_METHD" field.
        /// </summary>
        public String PaymentMethodCode
        {
            get { return this.ModifiedData.PaymentMethd; }
            set
            {
                if (this.ModifiedData.PaymentMethd != value)
                     _paymentMethod = null;
                this.ModifiedData.PaymentMethd = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_QTY" field.
        /// </summary>
        public Double? Qty
        {
            get { return this.ModifiedData.Qty; }
            set { this.ModifiedData.Qty = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_UNT_PRICE" field.
        /// </summary>
        public Decimal UintPrice
        {
            get { return this.ModifiedData.UntPrice; }
            set { this.ModifiedData.UntPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_SHOW_SALES" field.
        /// </summary>
        public Byte? ShowSales
        {
            get { return this.ModifiedData.ShowSales; }
            set { this.ModifiedData.ShowSales = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_MSTC_ID" field.
        /// </summary>
        public String MstcId
        {
            get { return this.ModifiedData.MstcId; }
            set { this.ModifiedData.MstcId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LST_PRICE" field.
        /// </summary>
        public Decimal ListPrice
        {
            get { return this.ModifiedData.LstPrice; }
            set { this.ModifiedData.LstPrice = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PL_ID" field.
        /// </summary>
        public LocalPriceListModel PriceList
        {
            get
            {
                if (_priceList == null && this.PriceListId != null)
                    _priceList = this.Provider.Finance.PriceList.FetchById(this.PriceListId);
                if (_priceList == null)
                    _priceList = this.Provider.Finance.PriceList.Create();
                
                return _priceList;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PL_ID" field.
        /// </summary>
        public String PriceListId
        {
            get { return this.ModifiedData.PlId; }
            set
            {
                if (this.ModifiedData.PlId != value)
                     _priceList = null;
                this.ModifiedData.PlId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_RETAIL_PRICE" field.
        /// </summary>
        public Decimal RetailPrice
        {
            get { return this.ModifiedData.RetailPrice; }
            set { this.ModifiedData.RetailPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_COST_PRICE" field.
        /// </summary>
        public Decimal CostPrice
        {
            get { return this.ModifiedData.CostPrice; }
            set { this.ModifiedData.CostPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_MAIN_SESSION" field.
        /// </summary>
        public Byte? MainSession
        {
            get { return this.ModifiedData.MainSession; }
            set { this.ModifiedData.MainSession = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_SELL_MSTC_ID" field.
        /// </summary>
        public String SellMstcId
        {
            get { return this.ModifiedData.SellMstcId; }
            set { this.ModifiedData.SellMstcId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_PREPAY_UNITS" field.
        /// </summary>
        public Double? PrepayUnits
        {
            get { return this.ModifiedData.PrepayUnits; }
            set { this.ModifiedData.PrepayUnits = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return this.ModifiedData.StartDate; }
            set { this.ModifiedData.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return this.ModifiedData.EndDate; }
            set { this.ModifiedData.EndDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_SXREF_ID" field.
        /// </summary>
        public LocalSessionXrefModel SessionXrefs
        {
            get
            {
                if (_sessionXrefs == null && this.SessionXrefsId != null)
                    _sessionXrefs = this.Provider.Learning.SessionXref.FetchById(this.SessionXrefsId);
                if (_sessionXrefs == null)
                    _sessionXrefs = this.Provider.Learning.SessionXref.Create();
                
                return _sessionXrefs;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_SXREF_ID" field.
        /// </summary>
        public String SessionXrefsId
        {
            get { return this.ModifiedData.SxrefId; }
            set
            {
                if (this.ModifiedData.SxrefId != value)
                     _sessionXrefs = null;
                this.ModifiedData.SxrefId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_START_TIME" field.
        /// </summary>
        public DateTime? StartTime
        {
            get { return this.ModifiedData.StartTime; }
            set { this.ModifiedData.StartTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_END_TIME" field.
        /// </summary>
        public DateTime? EndTime
        {
            get { return this.ModifiedData.EndTime; }
            set { this.ModifiedData.EndTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_VAT_AMT" field.
        /// </summary>
        public Decimal VatAmt
        {
            get { return this.ModifiedData.VatAmt; }
            set { this.ModifiedData.VatAmt = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_SUSPEND_DATA" field.
        /// </summary>
        public String LmspSuspendData
        {
            get { return this.ModifiedData.LmspSuspendData; }
            set { this.ModifiedData.LmspSuspendData = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_SCORE" field.
        /// </summary>
        public Byte? LmspScore
        {
            get { return this.ModifiedData.LmspScore; }
            set { this.ModifiedData.LmspScore = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_LESSON_STATUS" field.
        /// </summary>
        public String LmspLessonStatus
        {
            get { return this.ModifiedData.LmspLessonStatus; }
            set { this.ModifiedData.LmspLessonStatus = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_COMMENTS" field.
        /// </summary>
        public String LmspComments
        {
            get { return this.ModifiedData.LmspComments; }
            set { this.ModifiedData.LmspComments = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CERT_PRN_DATE" field.
        /// </summary>
        public DateTime? CertPrnDate
        {
            get { return this.ModifiedData.CertPrnDate; }
            set { this.ModifiedData.CertPrnDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CERT_PRINT_ANYWAY" field.
        /// </summary>
        public Byte? CertPrintAnyway
        {
            get { return this.ModifiedData.CertPrintAnyway; }
            set { this.ModifiedData.CertPrintAnyway = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_SELCO_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.SellingCompanyId != null)
                    _sellingCompany = this.Provider.Common.SellingCompany.FetchById(this.SellingCompanyId);
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.Create();
                
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_SELCO_SP_ID" field.
        /// </summary>
        public String SellingCompanyId
        {
            get { return this.ModifiedData.SelcoSpId; }
            set
            {
                if (this.ModifiedData.SelcoSpId != value)
                     _sellingCompany = null;
                this.ModifiedData.SelcoSpId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CHK_IN_TIME" field.
        /// </summary>
        public DateTime? ChkInTime
        {
            get { return this.ModifiedData.ChkInTime; }
            set { this.ModifiedData.ChkInTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_EXP_CHK_OUT_TIME" field.
        /// </summary>
        public DateTime? ExpChkOutTime
        {
            get { return this.ModifiedData.ExpChkOutTime; }
            set { this.ModifiedData.ExpChkOutTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_ACT_CHK_OUT_TIME" field.
        /// </summary>
        public DateTime? ActChkOutTime
        {
            get { return this.ModifiedData.ActChkOutTime; }
            set { this.ModifiedData.ActChkOutTime = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PRS_ID" field.
        /// </summary>
        public LocalPriceModel PriceId
        {
            get
            {
                if (_priceId == null && this.PriceIdId != null)
                    _priceId = this.Provider.Finance.Price.FetchById(this.PriceIdId);
                if (_priceId == null)
                    _priceId = this.Provider.Finance.Price.Create();
                
                return _priceId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PRS_ID" field.
        /// </summary>
        public String PriceIdId
        {
            get { return this.ModifiedData.PrsId; }
            set
            {
                if (this.ModifiedData.PrsId != value)
                     _priceId = null;
                this.ModifiedData.PrsId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_GRP_ID" field.
        /// </summary>
        public Int32? GrpId
        {
            get { return this.ModifiedData.GrpId; }
            set { this.ModifiedData.GrpId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_AUTH_STATUS" field.
        /// </summary>
        public Byte? AuthStatus
        {
            get { return this.ModifiedData.AuthStatus; }
            set { this.ModifiedData.AuthStatus = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_ELEM_ID" field.
        /// </summary>
        public LocalElementModel ParentElement
        {
            get
            {
                if (_parentElement == null && this.ParentElementId != null)
                    _parentElement = this.Provider.Learning.Element.FetchById(this.ParentElementId);
                if (_parentElement == null)
                    _parentElement = this.Provider.Learning.Element.Create();
                
                return _parentElement;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_ELEM_ID" field.
        /// </summary>
        public String ParentElementId
        {
            get { return this.ModifiedData.ElemId; }
            set
            {
                if (this.ModifiedData.ElemId != value)
                     _parentElement = null;
                this.ModifiedData.ElemId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_BKT_ID" field.
        /// </summary>
        public LocalBookingTermsModel BookingTerm
        {
            get
            {
                if (_bookingTerm == null && this.BookingTermId != null)
                    _bookingTerm = this.Provider.Finance.BookingTerms.FetchById(this.BookingTermId);
                if (_bookingTerm == null)
                    _bookingTerm = this.Provider.Finance.BookingTerms.Create();
                
                return _bookingTerm;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_BKT_ID" field.
        /// </summary>
        public String BookingTermId
        {
            get { return this.ModifiedData.BktId; }
            set
            {
                if (this.ModifiedData.BktId != value)
                     _bookingTerm = null;
                this.ModifiedData.BktId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_MANDATORY" field.
        /// </summary>
        public Byte Mandatory
        {
            get { return this.ModifiedData.Mandatory; }
            set { this.ModifiedData.Mandatory = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PSH_ID" field.
        /// </summary>
        public LocalPayscheduleheaderModel PaymentSchedule
        {
            get
            {
                if (_paymentSchedule == null && this.PaymentScheduleId != null)
                    _paymentSchedule = this.Provider.Finance.Payscheduleheader.FetchById(this.PaymentScheduleId.Value);
                if (_paymentSchedule == null)
                    _paymentSchedule = this.Provider.Finance.Payscheduleheader.Create();
                
                return _paymentSchedule;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PSH_ID" field.
        /// </summary>
        public Int32? PaymentScheduleId
        {
            get { return this.ModifiedData.PshId; }
            set
            {
                if (this.ModifiedData.PshId != value)
                     _paymentSchedule = null;
                this.ModifiedData.PshId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_SCO_END_DTE" field.
        /// </summary>
        public DateTime? ScoEndDte
        {
            get { return this.ModifiedData.ScoEndDte; }
            set { this.ModifiedData.ScoEndDte = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_TOTAL_TIME" field.
        /// </summary>
        public String LmspTotalTime
        {
            get { return this.ModifiedData.LmspTotalTime; }
            set { this.ModifiedData.LmspTotalTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_LESSON_LOCATION" field.
        /// </summary>
        public String LmspLessonLocation
        {
            get { return this.ModifiedData.LmspLessonLocation; }
            set { this.ModifiedData.LmspLessonLocation = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_COMPLETES" field.
        /// </summary>
        public Int32 LmspCompletes
        {
            get { return this.ModifiedData.LmspCompletes; }
            set { this.ModifiedData.LmspCompletes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_GIFT_AID" field.
        /// </summary>
        public Byte GiftAid
        {
            get { return this.ModifiedData.GiftAid; }
            set { this.ModifiedData.GiftAid = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CLAIMED" field.
        /// </summary>
        public Byte Claimed
        {
            get { return this.ModifiedData.Claimed; }
            set { this.ModifiedData.Claimed = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ElementModel" /> instances that reference this <see cref="ElementModel" />.
        /// </summary>
        public LocalCollection<LocalElementModel, IElementModel> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new LocalCollection<LocalElementModel, IElementModel>(this.Provider.Learning.Element.FetchAllByParentElementId(this.Id));
                
                return _elements;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceLineModel" /> instances that reference this <see cref="ElementModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel> InvoiceLines
        {
            get
            {
                if (_invoiceLines == null)
                    _invoiceLines = new LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel>(this.Provider.Finance.InvoiceLine.FetchAllByElementId(this.Id));
                
                return _invoiceLines;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalElementModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalElementModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalElementModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalElementModel(LocalProvider provider, ElementRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
            if (_vatcd != null)
            {
                _vatcd.Save();
                this.ModifiedData.Vatcd = _vatcd.Value1;
            }
            if (_revCode != null)
            {
                _revCode.Save();
                this.ModifiedData.RevCode = _revCode.Value1;
            }
            if (_grade != null)
            {
                _grade.Save();
                this.ModifiedData.Grade = _grade.Value1;
            }
            if (_paymentMethod != null)
            {
                _paymentMethod.Save();
                this.ModifiedData.PaymentMethd = _paymentMethod.Value1;
            }
            if (_delegate != null)
            {
                _delegate.Save();
                this.ModifiedData.DelId = _delegate.Id == null && this.ModifiedData.DelId != null ? "" : _delegate.Id;
            }
            if (_product != null)
            {
                _product.Save();
                this.ModifiedData.ProdId = _product.Id == null && this.ModifiedData.ProdId != null ? "" : _product.Id;
            }
            if (_activity != null)
            {
                _activity.Save();
                this.ModifiedData.ActId = _activity.Id == null && this.ModifiedData.ActId != null ? "" : _activity.Id;
            }
            if (_course != null)
            {
                _course.Save();
                this.ModifiedData.CourseId = _course.Id == null && this.ModifiedData.CourseId != null ? "" : _course.Id;
            }
            if (_booking != null)
            {
                _booking.Save();
                this.ModifiedData.BookId = _booking.Id == null && this.ModifiedData.BookId != null ? "" : _booking.Id;
            }
            if (_priceList != null)
            {
                _priceList.Save();
                this.ModifiedData.PlId = _priceList.Id == null && this.ModifiedData.PlId != null ? "" : _priceList.Id;
            }
            if (_sessionXrefs != null)
            {
                _sessionXrefs.Save();
                this.ModifiedData.SxrefId = _sessionXrefs.Id == null && this.ModifiedData.SxrefId != null ? "" : _sessionXrefs.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
            }
            if (_priceId != null)
            {
                _priceId.Save();
                this.ModifiedData.PrsId = _priceId.Id == null && this.ModifiedData.PrsId != null ? "" : _priceId.Id;
            }
            if (_parentElement != null)
            {
                _parentElement.Save();
                this.ModifiedData.ElemId = _parentElement.Id == null && this.ModifiedData.ElemId != null ? "" : _parentElement.Id;
            }
            if (_bookingTerm != null)
            {
                _bookingTerm.Save();
                this.ModifiedData.BktId = _bookingTerm.Id == null && this.ModifiedData.BktId != null ? "" : _bookingTerm.Id;
            }
            if (_paymentSchedule != null)
            {
                _paymentSchedule.Save();
                this.ModifiedData.PshId = _paymentSchedule.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_elements != null)
                _elements.Execute(obj => obj.ParentElementId = this.Id).Execute(obj => obj.Save());
            if (_invoiceLines != null)
                _invoiceLines.Execute(obj => obj.ElementId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "ELEM_DEL_ID" field.
        /// </summary>
        Consensus.Learning.ILearnerModel IElementModel.Delegate
        {
            get { return this.Delegate; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_DEL_ID" field.
        /// </summary>
        System.String IElementModel.DelegateId
        {
            get { return this.DelegateId; }
            set { this.DelegateId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IElementModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PROD_ID" field.
        /// </summary>
        System.String IElementModel.ProductId
        {
            get { return this.ProductId; }
            set { this.ProductId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_ACT_ID" field.
        /// </summary>
        Consensus.Activities.IActivityModel IElementModel.Activity
        {
            get { return this.Activity; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_ACT_ID" field.
        /// </summary>
        System.String IElementModel.ActivityId
        {
            get { return this.ActivityId; }
            set { this.ActivityId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IEventModel IElementModel.Course
        {
            get { return this.Course; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_COURSE_ID" field.
        /// </summary>
        System.String IElementModel.CourseId
        {
            get { return this.CourseId; }
            set { this.CourseId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_BOOK_ID" field.
        /// </summary>
        Consensus.Learning.IBookingModel IElementModel.Booking
        {
            get { return this.Booking; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_BOOK_ID" field.
        /// </summary>
        System.String IElementModel.BookingId
        {
            get { return this.BookingId; }
            set { this.BookingId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CERT_NO" field.
        /// </summary>
        System.String IElementModel.CertNo
        {
            get { return this.CertNo; }
            set { this.CertNo = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_ATTENDED" field.
        /// </summary>
        System.Nullable<System.Byte> IElementModel.Attended
        {
            get { return this.Attended; }
            set { this.Attended = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CURRENCY_TYPE" field.
        /// </summary>
        System.String IElementModel.CurrencyType
        {
            get { return this.CurrencyType; }
            set { this.CurrencyType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_PRICE" field.
        /// </summary>
        System.Decimal IElementModel.Price
        {
            get { return this.Price; }
            set { this.Price = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_BLOCK_PRICE" field.
        /// </summary>
        System.Decimal IElementModel.BlockPrice
        {
            get { return this.BlockPrice; }
            set { this.BlockPrice = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_VATCD" field.
        /// </summary>
        Consensus.Common.ICodeModel IElementModel.Vatcd
        {
            get { return this.Vatcd; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_VATCD" field.
        /// </summary>
        System.String IElementModel.VatcdCode
        {
            get { return this.VatcdCode; }
            set { this.VatcdCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_COST_CODE" field.
        /// </summary>
        System.String IElementModel.CostCode
        {
            get { return this.CostCode; }
            set { this.CostCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_DO_NOT_INVCE" field.
        /// </summary>
        System.Nullable<System.Byte> IElementModel.DoNotInvoice
        {
            get { return this.DoNotInvoice; }
            set { this.DoNotInvoice = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_INVOICED" field.
        /// </summary>
        System.Nullable<System.Byte> IElementModel.Invoiced
        {
            get { return this.Invoiced; }
            set { this.Invoiced = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_INVOICED_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IElementModel.InvoicedDate
        {
            get { return this.InvoicedDate; }
            set { this.InvoicedDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_DESCRIPTION" field.
        /// </summary>
        System.String IElementModel.Description
        {
            get { return this.Description; }
            set { this.Description = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_REV_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel IElementModel.RevCode
        {
            get { return this.RevCode; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_REV_CODE" field.
        /// </summary>
        System.String IElementModel.RevCodeCode
        {
            get { return this.RevCodeCode; }
            set { this.RevCodeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_INVOICE_PRINT" field.
        /// </summary>
        System.Nullable<System.Byte> IElementModel.InvoicePrinted
        {
            get { return this.InvoicePrinted; }
            set { this.InvoicePrinted = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CANCELLED" field.
        /// </summary>
        System.Nullable<System.Byte> IElementModel.Cancelled
        {
            get { return this.Cancelled; }
            set { this.Cancelled = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_NOTES" field.
        /// </summary>
        System.String IElementModel.Notes
        {
            get { return this.Notes; }
            set { this.Notes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_NON_ATD_RSN" field.
        /// </summary>
        System.String IElementModel.NonAtdRsn
        {
            get { return this.NonAtdRsn; }
            set { this.NonAtdRsn = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CERT_ISE_DAT" field.
        /// </summary>
        System.Nullable<System.DateTime> IElementModel.CertIseDat
        {
            get { return this.CertIseDat; }
            set { this.CertIseDat = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_PASS" field.
        /// </summary>
        System.Nullable<System.Byte> IElementModel.Pass
        {
            get { return this.Pass; }
            set { this.Pass = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_SCORE" field.
        /// </summary>
        System.Nullable<System.Decimal> IElementModel.Score
        {
            get { return this.Score; }
            set { this.Score = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> IElementModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_STATUS" field.
        /// </summary>
        System.Nullable<System.Byte> IElementModel.Status
        {
            get { return this.Status; }
            set { this.Status = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_GRADE" field.
        /// </summary>
        Consensus.Common.ICodeModel IElementModel.Grade
        {
            get { return this.Grade; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_GRADE" field.
        /// </summary>
        System.String IElementModel.GradeCode
        {
            get { return this.GradeCode; }
            set { this.GradeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PAYMENT_METHD" field.
        /// </summary>
        Consensus.Common.ICodeModel IElementModel.PaymentMethod
        {
            get { return this.PaymentMethod; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PAYMENT_METHD" field.
        /// </summary>
        System.String IElementModel.PaymentMethodCode
        {
            get { return this.PaymentMethodCode; }
            set { this.PaymentMethodCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_QTY" field.
        /// </summary>
        System.Nullable<System.Double> IElementModel.Qty
        {
            get { return this.Qty; }
            set { this.Qty = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_UNT_PRICE" field.
        /// </summary>
        System.Decimal IElementModel.UintPrice
        {
            get { return this.UintPrice; }
            set { this.UintPrice = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_SHOW_SALES" field.
        /// </summary>
        System.Nullable<System.Byte> IElementModel.ShowSales
        {
            get { return this.ShowSales; }
            set { this.ShowSales = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_MSTC_ID" field.
        /// </summary>
        System.String IElementModel.MstcId
        {
            get { return this.MstcId; }
            set { this.MstcId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LST_PRICE" field.
        /// </summary>
        System.Decimal IElementModel.ListPrice
        {
            get { return this.ListPrice; }
            set { this.ListPrice = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PL_ID" field.
        /// </summary>
        Consensus.Finance.IPriceListModel IElementModel.PriceList
        {
            get { return this.PriceList; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PL_ID" field.
        /// </summary>
        System.String IElementModel.PriceListId
        {
            get { return this.PriceListId; }
            set { this.PriceListId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_RETAIL_PRICE" field.
        /// </summary>
        System.Decimal IElementModel.RetailPrice
        {
            get { return this.RetailPrice; }
            set { this.RetailPrice = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_COST_PRICE" field.
        /// </summary>
        System.Decimal IElementModel.CostPrice
        {
            get { return this.CostPrice; }
            set { this.CostPrice = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_MAIN_SESSION" field.
        /// </summary>
        System.Nullable<System.Byte> IElementModel.MainSession
        {
            get { return this.MainSession; }
            set { this.MainSession = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_SELL_MSTC_ID" field.
        /// </summary>
        System.String IElementModel.SellMstcId
        {
            get { return this.SellMstcId; }
            set { this.SellMstcId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_PREPAY_UNITS" field.
        /// </summary>
        System.Nullable<System.Double> IElementModel.PrepayUnits
        {
            get { return this.PrepayUnits; }
            set { this.PrepayUnits = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IElementModel.StartDate
        {
            get { return this.StartDate; }
            set { this.StartDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IElementModel.EndDate
        {
            get { return this.EndDate; }
            set { this.EndDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_SXREF_ID" field.
        /// </summary>
        Consensus.Learning.ISessionXrefModel IElementModel.SessionXrefs
        {
            get { return this.SessionXrefs; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_SXREF_ID" field.
        /// </summary>
        System.String IElementModel.SessionXrefsId
        {
            get { return this.SessionXrefsId; }
            set { this.SessionXrefsId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_START_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> IElementModel.StartTime
        {
            get { return this.StartTime; }
            set { this.StartTime = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_END_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> IElementModel.EndTime
        {
            get { return this.EndTime; }
            set { this.EndTime = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_VAT_AMT" field.
        /// </summary>
        System.Decimal IElementModel.VatAmt
        {
            get { return this.VatAmt; }
            set { this.VatAmt = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_SUSPEND_DATA" field.
        /// </summary>
        System.String IElementModel.LmspSuspendData
        {
            get { return this.LmspSuspendData; }
            set { this.LmspSuspendData = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_SCORE" field.
        /// </summary>
        System.Nullable<System.Byte> IElementModel.LmspScore
        {
            get { return this.LmspScore; }
            set { this.LmspScore = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_LESSON_STATUS" field.
        /// </summary>
        System.String IElementModel.LmspLessonStatus
        {
            get { return this.LmspLessonStatus; }
            set { this.LmspLessonStatus = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_COMMENTS" field.
        /// </summary>
        System.String IElementModel.LmspComments
        {
            get { return this.LmspComments; }
            set { this.LmspComments = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CERT_PRN_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IElementModel.CertPrnDate
        {
            get { return this.CertPrnDate; }
            set { this.CertPrnDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CERT_PRINT_ANYWAY" field.
        /// </summary>
        System.Nullable<System.Byte> IElementModel.CertPrintAnyway
        {
            get { return this.CertPrintAnyway; }
            set { this.CertPrintAnyway = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IElementModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_SELCO_SP_ID" field.
        /// </summary>
        System.String IElementModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CHK_IN_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> IElementModel.ChkInTime
        {
            get { return this.ChkInTime; }
            set { this.ChkInTime = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_EXP_CHK_OUT_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> IElementModel.ExpChkOutTime
        {
            get { return this.ExpChkOutTime; }
            set { this.ExpChkOutTime = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_ACT_CHK_OUT_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> IElementModel.ActChkOutTime
        {
            get { return this.ActChkOutTime; }
            set { this.ActChkOutTime = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PRS_ID" field.
        /// </summary>
        Consensus.Finance.IPriceModel IElementModel.PriceId
        {
            get { return this.PriceId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PRS_ID" field.
        /// </summary>
        System.String IElementModel.PriceIdId
        {
            get { return this.PriceIdId; }
            set { this.PriceIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_GRP_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IElementModel.GrpId
        {
            get { return this.GrpId; }
            set { this.GrpId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_AUTH_STATUS" field.
        /// </summary>
        System.Nullable<System.Byte> IElementModel.AuthStatus
        {
            get { return this.AuthStatus; }
            set { this.AuthStatus = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_ELEM_ID" field.
        /// </summary>
        Consensus.Learning.IElementModel IElementModel.ParentElement
        {
            get { return this.ParentElement; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_ELEM_ID" field.
        /// </summary>
        System.String IElementModel.ParentElementId
        {
            get { return this.ParentElementId; }
            set { this.ParentElementId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_BKT_ID" field.
        /// </summary>
        Consensus.Finance.IBookingTermsModel IElementModel.BookingTerm
        {
            get { return this.BookingTerm; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_BKT_ID" field.
        /// </summary>
        System.String IElementModel.BookingTermId
        {
            get { return this.BookingTermId; }
            set { this.BookingTermId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_MANDATORY" field.
        /// </summary>
        System.Byte IElementModel.Mandatory
        {
            get { return this.Mandatory; }
            set { this.Mandatory = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PSH_ID" field.
        /// </summary>
        Consensus.Finance.IPayscheduleheaderModel IElementModel.PaymentSchedule
        {
            get { return this.PaymentSchedule; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PSH_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IElementModel.PaymentScheduleId
        {
            get { return this.PaymentScheduleId; }
            set { this.PaymentScheduleId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_SCO_END_DTE" field.
        /// </summary>
        System.Nullable<System.DateTime> IElementModel.ScoEndDte
        {
            get { return this.ScoEndDte; }
            set { this.ScoEndDte = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_TOTAL_TIME" field.
        /// </summary>
        System.String IElementModel.LmspTotalTime
        {
            get { return this.LmspTotalTime; }
            set { this.LmspTotalTime = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_LESSON_LOCATION" field.
        /// </summary>
        System.String IElementModel.LmspLessonLocation
        {
            get { return this.LmspLessonLocation; }
            set { this.LmspLessonLocation = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_COMPLETES" field.
        /// </summary>
        System.Int32 IElementModel.LmspCompletes
        {
            get { return this.LmspCompletes; }
            set { this.LmspCompletes = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_GIFT_AID" field.
        /// </summary>
        System.Byte IElementModel.GiftAid
        {
            get { return this.GiftAid; }
            set { this.GiftAid = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CLAIMED" field.
        /// </summary>
        System.Byte IElementModel.Claimed
        {
            get { return this.Claimed; }
            set { this.Claimed = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:ElementModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> IElementModel.Elements
        {
            get { return this.Elements; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:ElementModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceLineModel> IElementModel.InvoiceLines
        {
            get { return this.InvoiceLines; }
        }

        #endregion
    }
}
