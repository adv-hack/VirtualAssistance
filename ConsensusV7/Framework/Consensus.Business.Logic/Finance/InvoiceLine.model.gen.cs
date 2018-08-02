using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Learning;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="InvlineRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalInvoiceLineModel : LocalModel<InvlineRecord, String>, IInvoiceLineModel
    {
        #region fields

        /// <summary>
        ///     The value of the "INVLN_INV_ID" field.
        /// </summary>
        private LocalInvoiceModel _invoice;

        /// <summary>
        ///     The value of the "INVLN_PRODUCT_ID" field.
        /// </summary>
        private LocalProductModel _productId;

        /// <summary>
        ///     The value of the "INVLN_VAT_CODE" field.
        /// </summary>
        private LocalCodeModel _vatCode;

        /// <summary>
        ///     The value of the "INVLN_BOOK_ID" field.
        /// </summary>
        private LocalBookingModel _booking;

        /// <summary>
        ///     The value of the "INVLN_ELEM_ID" field.
        /// </summary>
        private LocalElementModel _element;

        /// <summary>
        ///     The value of the "INVLN_COURSE_ID" field.
        /// </summary>
        private LocalEventModel _courseId;

        /// <summary>
        ///     The value of the "INVLN_PRD_REV_CODE" field.
        /// </summary>
        private LocalCodeModel _revCode;

        /// <summary>
        ///     The value of the "INVLN_MEL_ID" field.
        /// </summary>
        private LocalMemberLocationModel _melId;

        /// <summary>
        ///     The value of the "INVLN_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="InvoiceLineModel" />.
        /// </summary>
        private LocalCollection<LocalMemberLocationModel, IMemberLocationModel> _memberLocations;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<InvlineRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Finance.InvoiceLine.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<InvlineRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Finance.InvoiceLine.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<InvlineRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Finance.InvoiceLine.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_INV_ID" field.
        /// </summary>
        public LocalInvoiceModel Invoice
        {
            get
            {
                if (_invoice == null && this.InvoiceId != null)
                    _invoice = this.Provider.Finance.Invoice.FetchById(this.InvoiceId);
                if (_invoice == null)
                    _invoice = this.Provider.Finance.Invoice.Create();
                
                return _invoice;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_INV_ID" field.
        /// </summary>
        public String InvoiceId
        {
            get { return this.ModifiedData.InvId; }
            set
            {
                if (this.ModifiedData.InvId != value)
                     _invoice = null;
                this.ModifiedData.InvId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_PRODUCT_ID" field.
        /// </summary>
        public LocalProductModel ProductId
        {
            get
            {
                if (_productId == null && this.ProductIdId != null)
                    _productId = this.Provider.Learning.Product.FetchById(this.ProductIdId);
                if (_productId == null)
                    _productId = this.Provider.Learning.Product.Create();
                
                return _productId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_PRODUCT_ID" field.
        /// </summary>
        public String ProductIdId
        {
            get { return this.ModifiedData.ProductId; }
            set
            {
                if (this.ModifiedData.ProductId != value)
                     _productId = null;
                this.ModifiedData.ProductId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_QTY" field.
        /// </summary>
        public Double? Qty
        {
            get { return this.ModifiedData.Qty; }
            set { this.ModifiedData.Qty = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_UNIT_PRICE" field.
        /// </summary>
        public Decimal UnitPrice
        {
            get { return this.ModifiedData.UnitPrice; }
            set { this.ModifiedData.UnitPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_DISCOUNT" field.
        /// </summary>
        public Decimal Discount
        {
            get { return this.ModifiedData.Discount; }
            set { this.ModifiedData.Discount = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_NET" field.
        /// </summary>
        public Decimal Net
        {
            get { return this.ModifiedData.Net; }
            set { this.ModifiedData.Net = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_VAT_CODE" field.
        /// </summary>
        public LocalCodeModel VatCode
        {
            get
            {
                if (_vatCode == null && !String.IsNullOrEmpty(this.VatCodeCode))
                    _vatCode = this.Provider.Common.Code.FetchByTypeAndCode("VATCD", this.VatCodeCode);
                if (_vatCode == null)
                    _vatCode = this.Provider.Common.Code.Create("VATCD");
                return _vatCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_VAT_CODE" field.
        /// </summary>
        public String VatCodeCode
        {
            get { return this.ModifiedData.VatCode; }
            set
            {
                if (this.ModifiedData.VatCode != value)
                     _vatCode = null;
                this.ModifiedData.VatCode = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_VAT_RATE" field.
        /// </summary>
        public Decimal VatRate
        {
            get { return this.ModifiedData.VatRate; }
            set { this.ModifiedData.VatRate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_VAT_AMT" field.
        /// </summary>
        public Decimal VatAmt
        {
            get { return this.ModifiedData.VatAmt; }
            set { this.ModifiedData.VatAmt = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_TOTAL_PRICE" field.
        /// </summary>
        public Decimal TotalPrice
        {
            get { return this.ModifiedData.TotalPrice; }
            set { this.ModifiedData.TotalPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return this.ModifiedData.Description; }
            set { this.ModifiedData.Description = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_BOOK_ID" field.
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
        ///     Gets or sets the unique code for the value of the "INVLN_BOOK_ID" field.
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
        ///     Gets the The value of the "INVLN_ELEM_ID" field.
        /// </summary>
        public LocalElementModel Element
        {
            get
            {
                if (_element == null && this.ElementId != null)
                    _element = this.Provider.Learning.Element.FetchById(this.ElementId);
                if (_element == null)
                    _element = this.Provider.Learning.Element.Create();
                
                return _element;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_ELEM_ID" field.
        /// </summary>
        public String ElementId
        {
            get { return this.ModifiedData.ElemId; }
            set
            {
                if (this.ModifiedData.ElemId != value)
                     _element = null;
                this.ModifiedData.ElemId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_COURSE_ID" field.
        /// </summary>
        public LocalEventModel CourseId
        {
            get
            {
                if (_courseId == null && this.CourseIdId != null)
                    _courseId = this.Provider.Learning.Event.FetchById(this.CourseIdId);
                if (_courseId == null)
                    _courseId = this.Provider.Learning.Event.Create();
                
                return _courseId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_COURSE_ID" field.
        /// </summary>
        public String CourseIdId
        {
            get { return this.ModifiedData.CourseId; }
            set
            {
                if (this.ModifiedData.CourseId != value)
                     _courseId = null;
                this.ModifiedData.CourseId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_PROD_NAME" field.
        /// </summary>
        public String ProdName
        {
            get { return this.ModifiedData.ProdName; }
            set { this.ModifiedData.ProdName = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_PRD_REV_CODE" field.
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
        ///     Gets or sets the unique code for the value of the "INVLN_PRD_REV_CODE" field.
        /// </summary>
        public String RevCodeCode
        {
            get { return this.ModifiedData.PrdRevCode; }
            set
            {
                if (this.ModifiedData.PrdRevCode != value)
                     _revCode = null;
                this.ModifiedData.PrdRevCode = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_PROJ_ID" field.
        /// </summary>
        public String ProjId
        {
            get { return this.ModifiedData.ProjId; }
            set { this.ModifiedData.ProjId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_MEL_ID" field.
        /// </summary>
        public LocalMemberLocationModel MelId
        {
            get
            {
                if (_melId == null && this.MelIdId != null)
                    _melId = this.Provider.Membership.MemberLocation.FetchById(this.MelIdId);
                if (_melId == null)
                    _melId = this.Provider.Membership.MemberLocation.Create();
                
                return _melId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_MEL_ID" field.
        /// </summary>
        public String MelIdId
        {
            get { return this.ModifiedData.MelId; }
            set
            {
                if (this.ModifiedData.MelId != value)
                     _melId = null;
                this.ModifiedData.MelId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return this.ModifiedData.CostCode; }
            set { this.ModifiedData.CostCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_CREDITED" field.
        /// </summary>
        public Byte? Credited
        {
            get { return this.ModifiedData.Credited; }
            set { this.ModifiedData.Credited = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "INVLN_SELCO_SP_ID" field.
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
        ///     Gets or sets the value of the "INVLN_DEPT" field.
        /// </summary>
        public String Dept
        {
            get { return this.ModifiedData.Dept; }
            set { this.ModifiedData.Dept = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_SKU" field.
        /// </summary>
        public String Sku
        {
            get { return this.ModifiedData.Sku; }
            set { this.ModifiedData.Sku = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_JOB_CODE" field.
        /// </summary>
        public String JobCode
        {
            get { return this.ModifiedData.JobCode; }
            set { this.ModifiedData.JobCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_JOB_ANAL_CODE" field.
        /// </summary>
        public String JobAnalCode
        {
            get { return this.ModifiedData.JobAnalCode; }
            set { this.ModifiedData.JobAnalCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_JOB_TYPE" field.
        /// </summary>
        public String JobType
        {
            get { return this.ModifiedData.JobType; }
            set { this.ModifiedData.JobType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_JOB_PARENT" field.
        /// </summary>
        public String JobParent
        {
            get { return this.ModifiedData.JobParent; }
            set { this.ModifiedData.JobParent = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_PRS_TYPE" field.
        /// </summary>
        public Byte PrsType
        {
            get { return this.ModifiedData.PrsType; }
            set { this.ModifiedData.PrsType = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="InvoiceLineModel" />.
        /// </summary>
        public LocalCollection<LocalMemberLocationModel, IMemberLocationModel> MemberLocations
        {
            get
            {
                if (_memberLocations == null)
                    _memberLocations = new LocalCollection<LocalMemberLocationModel, IMemberLocationModel>(this.Provider.Membership.MemberLocation.FetchAllByInvlnIdId(this.Id));
                
                return _memberLocations;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalInvoiceLineModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalInvoiceLineModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalInvoiceLineModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalInvoiceLineModel(LocalProvider provider, InvlineRecord record) : base(provider, record)
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
            if (_vatCode != null)
            {
                _vatCode.Save();
                this.ModifiedData.VatCode = _vatCode.Value1;
            }
            if (_revCode != null)
            {
                _revCode.Save();
                this.ModifiedData.PrdRevCode = _revCode.Value1;
            }
            if (_invoice != null)
            {
                _invoice.Save();
                this.ModifiedData.InvId = _invoice.Id == null && this.ModifiedData.InvId != null ? "" : _invoice.Id;
            }
            if (_productId != null)
            {
                _productId.Save();
                this.ModifiedData.ProductId = _productId.Id == null && this.ModifiedData.ProductId != null ? "" : _productId.Id;
            }
            if (_booking != null)
            {
                _booking.Save();
                this.ModifiedData.BookId = _booking.Id == null && this.ModifiedData.BookId != null ? "" : _booking.Id;
            }
            if (_element != null)
            {
                _element.Save();
                this.ModifiedData.ElemId = _element.Id == null && this.ModifiedData.ElemId != null ? "" : _element.Id;
            }
            if (_courseId != null)
            {
                _courseId.Save();
                this.ModifiedData.CourseId = _courseId.Id == null && this.ModifiedData.CourseId != null ? "" : _courseId.Id;
            }
            if (_melId != null)
            {
                _melId.Save();
                this.ModifiedData.MelId = _melId.Id == null && this.ModifiedData.MelId != null ? "" : _melId.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_memberLocations != null)
                _memberLocations.Execute(obj => obj.InvlnIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "INVLN_INV_ID" field.
        /// </summary>
        Consensus.Finance.IInvoiceModel IInvoiceLineModel.Invoice
        {
            get { return this.Invoice; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_INV_ID" field.
        /// </summary>
        System.String IInvoiceLineModel.InvoiceId
        {
            get { return this.InvoiceId; }
            set { this.InvoiceId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_PRODUCT_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IInvoiceLineModel.ProductId
        {
            get { return this.ProductId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_PRODUCT_ID" field.
        /// </summary>
        System.String IInvoiceLineModel.ProductIdId
        {
            get { return this.ProductIdId; }
            set { this.ProductIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_QTY" field.
        /// </summary>
        System.Nullable<System.Double> IInvoiceLineModel.Qty
        {
            get { return this.Qty; }
            set { this.Qty = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_UNIT_PRICE" field.
        /// </summary>
        System.Decimal IInvoiceLineModel.UnitPrice
        {
            get { return this.UnitPrice; }
            set { this.UnitPrice = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_DISCOUNT" field.
        /// </summary>
        System.Decimal IInvoiceLineModel.Discount
        {
            get { return this.Discount; }
            set { this.Discount = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_NET" field.
        /// </summary>
        System.Decimal IInvoiceLineModel.Net
        {
            get { return this.Net; }
            set { this.Net = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_VAT_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel IInvoiceLineModel.VatCode
        {
            get { return this.VatCode; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_VAT_CODE" field.
        /// </summary>
        System.String IInvoiceLineModel.VatCodeCode
        {
            get { return this.VatCodeCode; }
            set { this.VatCodeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_VAT_RATE" field.
        /// </summary>
        System.Decimal IInvoiceLineModel.VatRate
        {
            get { return this.VatRate; }
            set { this.VatRate = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_VAT_AMT" field.
        /// </summary>
        System.Decimal IInvoiceLineModel.VatAmt
        {
            get { return this.VatAmt; }
            set { this.VatAmt = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_TOTAL_PRICE" field.
        /// </summary>
        System.Decimal IInvoiceLineModel.TotalPrice
        {
            get { return this.TotalPrice; }
            set { this.TotalPrice = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_DESCRIPTION" field.
        /// </summary>
        System.String IInvoiceLineModel.Description
        {
            get { return this.Description; }
            set { this.Description = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_BOOK_ID" field.
        /// </summary>
        Consensus.Learning.IBookingModel IInvoiceLineModel.Booking
        {
            get { return this.Booking; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_BOOK_ID" field.
        /// </summary>
        System.String IInvoiceLineModel.BookingId
        {
            get { return this.BookingId; }
            set { this.BookingId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_ELEM_ID" field.
        /// </summary>
        Consensus.Learning.IElementModel IInvoiceLineModel.Element
        {
            get { return this.Element; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_ELEM_ID" field.
        /// </summary>
        System.String IInvoiceLineModel.ElementId
        {
            get { return this.ElementId; }
            set { this.ElementId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IEventModel IInvoiceLineModel.CourseId
        {
            get { return this.CourseId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_COURSE_ID" field.
        /// </summary>
        System.String IInvoiceLineModel.CourseIdId
        {
            get { return this.CourseIdId; }
            set { this.CourseIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> IInvoiceLineModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_PROD_NAME" field.
        /// </summary>
        System.String IInvoiceLineModel.ProdName
        {
            get { return this.ProdName; }
            set { this.ProdName = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_PRD_REV_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel IInvoiceLineModel.RevCode
        {
            get { return this.RevCode; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_PRD_REV_CODE" field.
        /// </summary>
        System.String IInvoiceLineModel.RevCodeCode
        {
            get { return this.RevCodeCode; }
            set { this.RevCodeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_PROJ_ID" field.
        /// </summary>
        System.String IInvoiceLineModel.ProjId
        {
            get { return this.ProjId; }
            set { this.ProjId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_MEL_ID" field.
        /// </summary>
        Consensus.Membership.IMemberLocationModel IInvoiceLineModel.MelId
        {
            get { return this.MelId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_MEL_ID" field.
        /// </summary>
        System.String IInvoiceLineModel.MelIdId
        {
            get { return this.MelIdId; }
            set { this.MelIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_COST_CODE" field.
        /// </summary>
        System.String IInvoiceLineModel.CostCode
        {
            get { return this.CostCode; }
            set { this.CostCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_CREDITED" field.
        /// </summary>
        System.Nullable<System.Byte> IInvoiceLineModel.Credited
        {
            get { return this.Credited; }
            set { this.Credited = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IInvoiceLineModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_SELCO_SP_ID" field.
        /// </summary>
        System.String IInvoiceLineModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_DEPT" field.
        /// </summary>
        System.String IInvoiceLineModel.Dept
        {
            get { return this.Dept; }
            set { this.Dept = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_SKU" field.
        /// </summary>
        System.String IInvoiceLineModel.Sku
        {
            get { return this.Sku; }
            set { this.Sku = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_JOB_CODE" field.
        /// </summary>
        System.String IInvoiceLineModel.JobCode
        {
            get { return this.JobCode; }
            set { this.JobCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_JOB_ANAL_CODE" field.
        /// </summary>
        System.String IInvoiceLineModel.JobAnalCode
        {
            get { return this.JobAnalCode; }
            set { this.JobAnalCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_JOB_TYPE" field.
        /// </summary>
        System.String IInvoiceLineModel.JobType
        {
            get { return this.JobType; }
            set { this.JobType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_JOB_PARENT" field.
        /// </summary>
        System.String IInvoiceLineModel.JobParent
        {
            get { return this.JobParent; }
            set { this.JobParent = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_PRS_TYPE" field.
        /// </summary>
        System.Byte IInvoiceLineModel.PrsType
        {
            get { return this.PrsType; }
            set { this.PrsType = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:InvoiceLineModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> IInvoiceLineModel.MemberLocations
        {
            get { return this.MemberLocations; }
        }

        void IInvoiceLineModel.Delete()
        {
            this.Delete();
        }

        void IInvoiceLineModel.Save()
        {
            this.Save();
        }

        #endregion
    }
}
