using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Finance;

namespace Consensus.Learning
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Element : Proxy<IElementModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Delegate" /> member.
        /// </summary>
        private Consensus.Learning.Learner _delegate;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Product" /> member.
        /// </summary>
        private Consensus.Learning.Product _product;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Activity" /> member.
        /// </summary>
        private Consensus.Activities.Activity _activity;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Course" /> member.
        /// </summary>
        private Consensus.Learning.Event _course;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Booking" /> member.
        /// </summary>
        private Consensus.Learning.Booking _booking;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Vatcd" /> member.
        /// </summary>
        private Consensus.Common.Code _vatcd;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="RevCode" /> member.
        /// </summary>
        private Consensus.Common.Code _revCode;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Grade" /> member.
        /// </summary>
        private Consensus.Common.Code _grade;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PaymentMethod" /> member.
        /// </summary>
        private Consensus.Common.Code _paymentMethod;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PriceList" /> member.
        /// </summary>
        private Consensus.Finance.PriceList _priceList;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SessionXrefs" /> member.
        /// </summary>
        private Consensus.Learning.SessionXref _sessionXrefs;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PriceId" /> member.
        /// </summary>
        private Consensus.Finance.Price _priceId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ParentElement" /> member.
        /// </summary>
        private Consensus.Learning.Element _parentElement;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="BookingTerm" /> member.
        /// </summary>
        private Consensus.Finance.BookingTerms _bookingTerm;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PaymentSchedule" /> member.
        /// </summary>
        private Consensus.Finance.Payscheduleheader _paymentSchedule;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Elements" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel> _elements;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="InvoiceLines" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.InvoiceLine, Consensus.Finance.IInvoiceLineModel> _invoiceLines;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "ELEM_DEL_ID" field.
        /// </summary>
        public Consensus.Learning.Learner Delegate
        {
            get
            {
                if (_delegate == null && this.Model.Delegate != null)
                    _delegate = new Consensus.Learning.Learner(this.Model.Delegate);
                if (_delegate == null)
                    _delegate = Consensus.Learning.Learner.Create();
                return _delegate;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_DEL_ID" field.
        /// </summary>
        public System.String DelegateId
        {
            get { return this.Model.DelegateId; }
            set { this.Model.DelegateId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PROD_ID" field.
        /// </summary>
        public Consensus.Learning.Product Product
        {
            get
            {
                if (_product == null && this.Model.Product != null)
                    _product = new Consensus.Learning.Product(this.Model.Product);
                if (_product == null)
                    _product = Consensus.Learning.Product.Create();
                return _product;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PROD_ID" field.
        /// </summary>
        public System.String ProductId
        {
            get { return this.Model.ProductId; }
            set { this.Model.ProductId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_ACT_ID" field.
        /// </summary>
        public Consensus.Activities.Activity Activity
        {
            get
            {
                if (_activity == null && this.Model.Activity != null)
                    _activity = new Consensus.Activities.Activity(this.Model.Activity);
                if (_activity == null)
                    _activity = Consensus.Activities.Activity.Create();
                return _activity;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_ACT_ID" field.
        /// </summary>
        public System.String ActivityId
        {
            get { return this.Model.ActivityId; }
            set { this.Model.ActivityId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_COURSE_ID" field.
        /// </summary>
        public Consensus.Learning.Event Course
        {
            get
            {
                if (_course == null && this.Model.Course != null)
                    _course = new Consensus.Learning.Event(this.Model.Course);
                if (_course == null)
                    _course = Consensus.Learning.Event.Create();
                return _course;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_COURSE_ID" field.
        /// </summary>
        public System.String CourseId
        {
            get { return this.Model.CourseId; }
            set { this.Model.CourseId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_BOOK_ID" field.
        /// </summary>
        public Consensus.Learning.Booking Booking
        {
            get
            {
                if (_booking == null && this.Model.Booking != null)
                    _booking = new Consensus.Learning.Booking(this.Model.Booking);
                if (_booking == null)
                    _booking = Consensus.Learning.Booking.Create();
                return _booking;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_BOOK_ID" field.
        /// </summary>
        public System.String BookingId
        {
            get { return this.Model.BookingId; }
            set { this.Model.BookingId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CERT_NO" field.
        /// </summary>
        public System.String CertNo
        {
            get { return this.Model.CertNo; }
            set { this.Model.CertNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_ATTENDED" field.
        /// </summary>
        public System.Nullable<System.Byte> Attended
        {
            get { return this.Model.Attended; }
            set { this.Model.Attended = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CURRENCY_TYPE" field.
        /// </summary>
        public System.String CurrencyType
        {
            get { return this.Model.CurrencyType; }
            set { this.Model.CurrencyType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_PRICE" field.
        /// </summary>
        public System.Decimal Price
        {
            get { return this.Model.Price; }
            set { this.Model.Price = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_BLOCK_PRICE" field.
        /// </summary>
        public System.Decimal BlockPrice
        {
            get { return this.Model.BlockPrice; }
            set { this.Model.BlockPrice = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_VATCD" field.
        /// </summary>
        public Consensus.Common.Code Vatcd
        {
            get
            {
                if (_vatcd == null && this.Model.Vatcd != null)
                    _vatcd = new Consensus.Common.Code(this.Model.Vatcd);
                if (_vatcd == null)
                    _vatcd = Consensus.Common.Code.Create();
                return _vatcd;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_VATCD" field.
        /// </summary>
        public System.String VatcdCode
        {
            get { return this.Model.VatcdCode; }
            set { this.Model.VatcdCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_COST_CODE" field.
        /// </summary>
        public System.String CostCode
        {
            get { return this.Model.CostCode; }
            set { this.Model.CostCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_DO_NOT_INVCE" field.
        /// </summary>
        public System.Nullable<System.Byte> DoNotInvoice
        {
            get { return this.Model.DoNotInvoice; }
            set { this.Model.DoNotInvoice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_INVOICED" field.
        /// </summary>
        public System.Nullable<System.Byte> Invoiced
        {
            get { return this.Model.Invoiced; }
            set { this.Model.Invoiced = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_INVOICED_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> InvoicedDate
        {
            get { return this.Model.InvoicedDate; }
            set { this.Model.InvoicedDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_DESCRIPTION" field.
        /// </summary>
        public System.String Description
        {
            get { return this.Model.Description; }
            set { this.Model.Description = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_REV_CODE" field.
        /// </summary>
        public Consensus.Common.Code RevCode
        {
            get
            {
                if (_revCode == null && this.Model.RevCode != null)
                    _revCode = new Consensus.Common.Code(this.Model.RevCode);
                if (_revCode == null)
                    _revCode = Consensus.Common.Code.Create();
                return _revCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_REV_CODE" field.
        /// </summary>
        public System.String RevCodeCode
        {
            get { return this.Model.RevCodeCode; }
            set { this.Model.RevCodeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_INVOICE_PRINT" field.
        /// </summary>
        public System.Nullable<System.Byte> InvoicePrinted
        {
            get { return this.Model.InvoicePrinted; }
            set { this.Model.InvoicePrinted = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CANCELLED" field.
        /// </summary>
        public System.Nullable<System.Byte> Cancelled
        {
            get { return this.Model.Cancelled; }
            set { this.Model.Cancelled = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_NON_ATD_RSN" field.
        /// </summary>
        public System.String NonAtdRsn
        {
            get { return this.Model.NonAtdRsn; }
            set { this.Model.NonAtdRsn = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CERT_ISE_DAT" field.
        /// </summary>
        public System.Nullable<System.DateTime> CertIseDat
        {
            get { return this.Model.CertIseDat; }
            set { this.Model.CertIseDat = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_PASS" field.
        /// </summary>
        public System.Nullable<System.Byte> Pass
        {
            get { return this.Model.Pass; }
            set { this.Model.Pass = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_SCORE" field.
        /// </summary>
        public System.Nullable<System.Decimal> Score
        {
            get { return this.Model.Score; }
            set { this.Model.Score = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_TYPE" field.
        /// </summary>
        public System.Nullable<System.Byte> Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_STATUS" field.
        /// </summary>
        public System.Nullable<System.Byte> Status
        {
            get { return this.Model.Status; }
            set { this.Model.Status = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_GRADE" field.
        /// </summary>
        public Consensus.Common.Code Grade
        {
            get
            {
                if (_grade == null && this.Model.Grade != null)
                    _grade = new Consensus.Common.Code(this.Model.Grade);
                if (_grade == null)
                    _grade = Consensus.Common.Code.Create();
                return _grade;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_GRADE" field.
        /// </summary>
        public System.String GradeCode
        {
            get { return this.Model.GradeCode; }
            set { this.Model.GradeCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PAYMENT_METHD" field.
        /// </summary>
        public Consensus.Common.Code PaymentMethod
        {
            get
            {
                if (_paymentMethod == null && this.Model.PaymentMethod != null)
                    _paymentMethod = new Consensus.Common.Code(this.Model.PaymentMethod);
                if (_paymentMethod == null)
                    _paymentMethod = Consensus.Common.Code.Create();
                return _paymentMethod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PAYMENT_METHD" field.
        /// </summary>
        public System.String PaymentMethodCode
        {
            get { return this.Model.PaymentMethodCode; }
            set { this.Model.PaymentMethodCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_QTY" field.
        /// </summary>
        public System.Nullable<System.Double> Qty
        {
            get { return this.Model.Qty; }
            set { this.Model.Qty = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_UNT_PRICE" field.
        /// </summary>
        public System.Decimal UintPrice
        {
            get { return this.Model.UintPrice; }
            set { this.Model.UintPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_SHOW_SALES" field.
        /// </summary>
        public System.Nullable<System.Byte> ShowSales
        {
            get { return this.Model.ShowSales; }
            set { this.Model.ShowSales = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_MSTC_ID" field.
        /// </summary>
        public System.String MstcId
        {
            get { return this.Model.MstcId; }
            set { this.Model.MstcId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LST_PRICE" field.
        /// </summary>
        public System.Decimal ListPrice
        {
            get { return this.Model.ListPrice; }
            set { this.Model.ListPrice = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PL_ID" field.
        /// </summary>
        public Consensus.Finance.PriceList PriceList
        {
            get
            {
                if (_priceList == null && this.Model.PriceList != null)
                    _priceList = new Consensus.Finance.PriceList(this.Model.PriceList);
                if (_priceList == null)
                    _priceList = Consensus.Finance.PriceList.Create();
                return _priceList;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PL_ID" field.
        /// </summary>
        public System.String PriceListId
        {
            get { return this.Model.PriceListId; }
            set { this.Model.PriceListId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_RETAIL_PRICE" field.
        /// </summary>
        public System.Decimal RetailPrice
        {
            get { return this.Model.RetailPrice; }
            set { this.Model.RetailPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_COST_PRICE" field.
        /// </summary>
        public System.Decimal CostPrice
        {
            get { return this.Model.CostPrice; }
            set { this.Model.CostPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_MAIN_SESSION" field.
        /// </summary>
        public System.Nullable<System.Byte> MainSession
        {
            get { return this.Model.MainSession; }
            set { this.Model.MainSession = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_SELL_MSTC_ID" field.
        /// </summary>
        public System.String SellMstcId
        {
            get { return this.Model.SellMstcId; }
            set { this.Model.SellMstcId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_PREPAY_UNITS" field.
        /// </summary>
        public System.Nullable<System.Double> PrepayUnits
        {
            get { return this.Model.PrepayUnits; }
            set { this.Model.PrepayUnits = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_START_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartDate
        {
            get { return this.Model.StartDate; }
            set { this.Model.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_END_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndDate
        {
            get { return this.Model.EndDate; }
            set { this.Model.EndDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_SXREF_ID" field.
        /// </summary>
        public Consensus.Learning.SessionXref SessionXrefs
        {
            get
            {
                if (_sessionXrefs == null && this.Model.SessionXrefs != null)
                    _sessionXrefs = new Consensus.Learning.SessionXref(this.Model.SessionXrefs);
                if (_sessionXrefs == null)
                    _sessionXrefs = Consensus.Learning.SessionXref.Create();
                return _sessionXrefs;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_SXREF_ID" field.
        /// </summary>
        public System.String SessionXrefsId
        {
            get { return this.Model.SessionXrefsId; }
            set { this.Model.SessionXrefsId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_START_TIME" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartTime
        {
            get { return this.Model.StartTime; }
            set { this.Model.StartTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_END_TIME" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndTime
        {
            get { return this.Model.EndTime; }
            set { this.Model.EndTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_VAT_AMT" field.
        /// </summary>
        public System.Decimal VatAmt
        {
            get { return this.Model.VatAmt; }
            set { this.Model.VatAmt = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_SUSPEND_DATA" field.
        /// </summary>
        public System.String LmspSuspendData
        {
            get { return this.Model.LmspSuspendData; }
            set { this.Model.LmspSuspendData = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_SCORE" field.
        /// </summary>
        public System.Nullable<System.Byte> LmspScore
        {
            get { return this.Model.LmspScore; }
            set { this.Model.LmspScore = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_LESSON_STATUS" field.
        /// </summary>
        public System.String LmspLessonStatus
        {
            get { return this.Model.LmspLessonStatus; }
            set { this.Model.LmspLessonStatus = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_COMMENTS" field.
        /// </summary>
        public System.String LmspComments
        {
            get { return this.Model.LmspComments; }
            set { this.Model.LmspComments = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CERT_PRN_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> CertPrnDate
        {
            get { return this.Model.CertPrnDate; }
            set { this.Model.CertPrnDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CERT_PRINT_ANYWAY" field.
        /// </summary>
        public System.Nullable<System.Byte> CertPrintAnyway
        {
            get { return this.Model.CertPrintAnyway; }
            set { this.Model.CertPrintAnyway = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_SELCO_SP_ID" field.
        /// </summary>
        public Consensus.Common.SellingCompany SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.Model.SellingCompany != null)
                    _sellingCompany = new Consensus.Common.SellingCompany(this.Model.SellingCompany);
                if (_sellingCompany == null)
                    _sellingCompany = Consensus.Common.SellingCompany.Create();
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CHK_IN_TIME" field.
        /// </summary>
        public System.Nullable<System.DateTime> ChkInTime
        {
            get { return this.Model.ChkInTime; }
            set { this.Model.ChkInTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_EXP_CHK_OUT_TIME" field.
        /// </summary>
        public System.Nullable<System.DateTime> ExpChkOutTime
        {
            get { return this.Model.ExpChkOutTime; }
            set { this.Model.ExpChkOutTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_ACT_CHK_OUT_TIME" field.
        /// </summary>
        public System.Nullable<System.DateTime> ActChkOutTime
        {
            get { return this.Model.ActChkOutTime; }
            set { this.Model.ActChkOutTime = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PRS_ID" field.
        /// </summary>
        public Consensus.Finance.Price PriceId
        {
            get
            {
                if (_priceId == null && this.Model.PriceId != null)
                    _priceId = new Consensus.Finance.Price(this.Model.PriceId);
                if (_priceId == null)
                    _priceId = Consensus.Finance.Price.Create();
                return _priceId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PRS_ID" field.
        /// </summary>
        public System.String PriceIdId
        {
            get { return this.Model.PriceIdId; }
            set { this.Model.PriceIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_GRP_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> GrpId
        {
            get { return this.Model.GrpId; }
            set { this.Model.GrpId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_AUTH_STATUS" field.
        /// </summary>
        public System.Nullable<System.Byte> AuthStatus
        {
            get { return this.Model.AuthStatus; }
            set { this.Model.AuthStatus = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_ELEM_ID" field.
        /// </summary>
        public Consensus.Learning.Element ParentElement
        {
            get
            {
                if (_parentElement == null && this.Model.ParentElement != null)
                    _parentElement = new Consensus.Learning.Element(this.Model.ParentElement);
                if (_parentElement == null)
                    _parentElement = Consensus.Learning.Element.Create();
                return _parentElement;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_ELEM_ID" field.
        /// </summary>
        public System.String ParentElementId
        {
            get { return this.Model.ParentElementId; }
            set { this.Model.ParentElementId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_BKT_ID" field.
        /// </summary>
        public Consensus.Finance.BookingTerms BookingTerm
        {
            get
            {
                if (_bookingTerm == null && this.Model.BookingTerm != null)
                    _bookingTerm = new Consensus.Finance.BookingTerms(this.Model.BookingTerm);
                if (_bookingTerm == null)
                    _bookingTerm = Consensus.Finance.BookingTerms.Create();
                return _bookingTerm;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_BKT_ID" field.
        /// </summary>
        public System.String BookingTermId
        {
            get { return this.Model.BookingTermId; }
            set { this.Model.BookingTermId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_MANDATORY" field.
        /// </summary>
        public System.Byte Mandatory
        {
            get { return this.Model.Mandatory; }
            set { this.Model.Mandatory = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PSH_ID" field.
        /// </summary>
        public Consensus.Finance.Payscheduleheader PaymentSchedule
        {
            get
            {
                if (_paymentSchedule == null && this.Model.PaymentSchedule != null)
                    _paymentSchedule = new Consensus.Finance.Payscheduleheader(this.Model.PaymentSchedule);
                if (_paymentSchedule == null)
                    _paymentSchedule = Consensus.Finance.Payscheduleheader.Create();
                return _paymentSchedule;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PSH_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> PaymentScheduleId
        {
            get { return this.Model.PaymentScheduleId; }
            set { this.Model.PaymentScheduleId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_SCO_END_DTE" field.
        /// </summary>
        public System.Nullable<System.DateTime> ScoEndDte
        {
            get { return this.Model.ScoEndDte; }
            set { this.Model.ScoEndDte = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_TOTAL_TIME" field.
        /// </summary>
        public System.String LmspTotalTime
        {
            get { return this.Model.LmspTotalTime; }
            set { this.Model.LmspTotalTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_LESSON_LOCATION" field.
        /// </summary>
        public System.String LmspLessonLocation
        {
            get { return this.Model.LmspLessonLocation; }
            set { this.Model.LmspLessonLocation = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_COMPLETES" field.
        /// </summary>
        public System.Int32 LmspCompletes
        {
            get { return this.Model.LmspCompletes; }
            set { this.Model.LmspCompletes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_GIFT_AID" field.
        /// </summary>
        public System.Byte GiftAid
        {
            get { return this.Model.GiftAid; }
            set { this.Model.GiftAid = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CLAIMED" field.
        /// </summary>
        public System.Byte Claimed
        {
            get { return this.Model.Claimed; }
            set { this.Model.Claimed = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:ElementModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Element> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel>(this.Model.Elements, model => new Consensus.Learning.Element(model));
                return _elements;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:ElementModel" />.
        /// </summary>
        public Collection<Consensus.Finance.InvoiceLine> InvoiceLines
        {
            get
            {
                if (_invoiceLines == null)
                    _invoiceLines = new ProxyCollection<Consensus.Finance.InvoiceLine, Consensus.Finance.IInvoiceLineModel>(this.Model.InvoiceLines, model => new Consensus.Finance.InvoiceLine(model));
                return _invoiceLines;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Element(IElementModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ElementModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ElementModel" /> instance.
        /// </returns>
        public static Consensus.Learning.Element Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Element.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ElementModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ElementModel" /> instance.
        /// </returns>
        public static Consensus.Learning.Element Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IElementModel model = provider.Learning.Element.Create();
            return model == null ? null : new Consensus.Learning.Element(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ElementModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ElementModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Element.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ElementModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ElementModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IElementModel> collection = provider.Learning.Element.FetchAll();
            return collection.Select(model => new Consensus.Learning.Element(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ElementModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ElementModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.Element FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Element.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ElementModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ElementModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.Element FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IElementModel model = provider.Learning.Element.FetchById(id);
            return model == null ? null : new Consensus.Learning.Element(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Element.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Learning.Element.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="delegateId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="delegateId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByDelegateId(System.String delegateId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Element.FetchAllByDelegateId(site,delegateId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="delegateId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="delegateId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByDelegateId(ConsensusSite site, System.String delegateId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IElementModel> collection = provider.Learning.Element.FetchAllByDelegateId(delegateId);
            return collection.Select(model => new Consensus.Learning.Element(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByProductId(System.String productId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Element.FetchAllByProductId(site,productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByProductId(ConsensusSite site, System.String productId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IElementModel> collection = provider.Learning.Element.FetchAllByProductId(productId);
            return collection.Select(model => new Consensus.Learning.Element(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="activityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByActivityId(System.String activityId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Element.FetchAllByActivityId(site,activityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="activityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByActivityId(ConsensusSite site, System.String activityId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IElementModel> collection = provider.Learning.Element.FetchAllByActivityId(activityId);
            return collection.Select(model => new Consensus.Learning.Element(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="courseId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByCourseId(System.String courseId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Element.FetchAllByCourseId(site,courseId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="courseId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByCourseId(ConsensusSite site, System.String courseId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IElementModel> collection = provider.Learning.Element.FetchAllByCourseId(courseId);
            return collection.Select(model => new Consensus.Learning.Element(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByBookingId(System.String bookingId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Element.FetchAllByBookingId(site,bookingId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByBookingId(ConsensusSite site, System.String bookingId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IElementModel> collection = provider.Learning.Element.FetchAllByBookingId(bookingId);
            return collection.Select(model => new Consensus.Learning.Element(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="priceListId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="priceListId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByPriceListId(System.String priceListId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Element.FetchAllByPriceListId(site,priceListId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="priceListId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="priceListId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByPriceListId(ConsensusSite site, System.String priceListId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IElementModel> collection = provider.Learning.Element.FetchAllByPriceListId(priceListId);
            return collection.Select(model => new Consensus.Learning.Element(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="sessionXrefsId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="sessionXrefsId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllBySessionXrefsId(System.String sessionXrefsId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Element.FetchAllBySessionXrefsId(site,sessionXrefsId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="sessionXrefsId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="sessionXrefsId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllBySessionXrefsId(ConsensusSite site, System.String sessionXrefsId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IElementModel> collection = provider.Learning.Element.FetchAllBySessionXrefsId(sessionXrefsId);
            return collection.Select(model => new Consensus.Learning.Element(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Element.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IElementModel> collection = provider.Learning.Element.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Learning.Element(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="priceIdId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="priceIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByPriceIdId(System.String priceIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Element.FetchAllByPriceIdId(site,priceIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="priceIdId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="priceIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByPriceIdId(ConsensusSite site, System.String priceIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IElementModel> collection = provider.Learning.Element.FetchAllByPriceIdId(priceIdId);
            return collection.Select(model => new Consensus.Learning.Element(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="parentElementId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="parentElementId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByParentElementId(System.String parentElementId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Element.FetchAllByParentElementId(site,parentElementId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="parentElementId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="parentElementId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByParentElementId(ConsensusSite site, System.String parentElementId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IElementModel> collection = provider.Learning.Element.FetchAllByParentElementId(parentElementId);
            return collection.Select(model => new Consensus.Learning.Element(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="bookingTermId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="bookingTermId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByBookingTermId(System.String bookingTermId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Element.FetchAllByBookingTermId(site,bookingTermId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="bookingTermId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="bookingTermId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Element> FetchAllByBookingTermId(ConsensusSite site, System.String bookingTermId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IElementModel> collection = provider.Learning.Element.FetchAllByBookingTermId(bookingTermId);
            return collection.Select(model => new Consensus.Learning.Element(model));
        }

        public static IEnumerable<Consensus.Learning.Element> FetchAllByPaymentScheduleId(System.Nullable<System.Int32> paymentScheduleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Element.FetchAllByPaymentScheduleId(site,paymentScheduleId);
        }

        public static IEnumerable<Consensus.Learning.Element> FetchAllByPaymentScheduleId(ConsensusSite site, System.Nullable<System.Int32> paymentScheduleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IElementModel> collection = provider.Learning.Element.FetchAllByPaymentScheduleId(paymentScheduleId);
            return collection.Select(model => new Consensus.Learning.Element(model));
        }

        #endregion
    }
}
