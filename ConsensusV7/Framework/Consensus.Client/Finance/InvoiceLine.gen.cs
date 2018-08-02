using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Learning;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class InvoiceLine : Proxy<IInvoiceLineModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Invoice" /> member.
        /// </summary>
        private Consensus.Finance.Invoice _invoice;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProductId" /> member.
        /// </summary>
        private Consensus.Learning.Product _productId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="VatCode" /> member.
        /// </summary>
        private Consensus.Common.Code _vatCode;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Booking" /> member.
        /// </summary>
        private Consensus.Learning.Booking _booking;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Element" /> member.
        /// </summary>
        private Consensus.Learning.Element _element;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="CourseId" /> member.
        /// </summary>
        private Consensus.Learning.Event _courseId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="RevCode" /> member.
        /// </summary>
        private Consensus.Common.Code _revCode;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MelId" /> member.
        /// </summary>
        private Consensus.Membership.MemberLocation _melId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MemberLocations" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberLocation, Consensus.Membership.IMemberLocationModel> _memberLocations;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "INVLN_INV_ID" field.
        /// </summary>
        public Consensus.Finance.Invoice Invoice
        {
            get
            {
                if (_invoice == null && this.Model.Invoice != null)
                    _invoice = new Consensus.Finance.Invoice(this.Model.Invoice);
                if (_invoice == null)
                    _invoice = Consensus.Finance.Invoice.Create();
                return _invoice;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_INV_ID" field.
        /// </summary>
        public System.String InvoiceId
        {
            get { return this.Model.InvoiceId; }
            set { this.Model.InvoiceId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_PRODUCT_ID" field.
        /// </summary>
        public Consensus.Learning.Product ProductId
        {
            get
            {
                if (_productId == null && this.Model.ProductId != null)
                    _productId = new Consensus.Learning.Product(this.Model.ProductId);
                if (_productId == null)
                    _productId = Consensus.Learning.Product.Create();
                return _productId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_PRODUCT_ID" field.
        /// </summary>
        public System.String ProductIdId
        {
            get { return this.Model.ProductIdId; }
            set { this.Model.ProductIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_QTY" field.
        /// </summary>
        public System.Nullable<System.Double> Qty
        {
            get { return this.Model.Qty; }
            set { this.Model.Qty = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_UNIT_PRICE" field.
        /// </summary>
        public System.Decimal UnitPrice
        {
            get { return this.Model.UnitPrice; }
            set { this.Model.UnitPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_DISCOUNT" field.
        /// </summary>
        public System.Decimal Discount
        {
            get { return this.Model.Discount; }
            set { this.Model.Discount = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_NET" field.
        /// </summary>
        public System.Decimal Net
        {
            get { return this.Model.Net; }
            set { this.Model.Net = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_VAT_CODE" field.
        /// </summary>
        public Consensus.Common.Code VatCode
        {
            get
            {
                if (_vatCode == null && this.Model.VatCode != null)
                    _vatCode = new Consensus.Common.Code(this.Model.VatCode);
                if (_vatCode == null)
                    _vatCode = Consensus.Common.Code.Create();
                return _vatCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_VAT_CODE" field.
        /// </summary>
        public System.String VatCodeCode
        {
            get { return this.Model.VatCodeCode; }
            set { this.Model.VatCodeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_VAT_RATE" field.
        /// </summary>
        public System.Decimal VatRate
        {
            get { return this.Model.VatRate; }
            set { this.Model.VatRate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_VAT_AMT" field.
        /// </summary>
        public System.Decimal VatAmt
        {
            get { return this.Model.VatAmt; }
            set { this.Model.VatAmt = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_TOTAL_PRICE" field.
        /// </summary>
        public System.Decimal TotalPrice
        {
            get { return this.Model.TotalPrice; }
            set { this.Model.TotalPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_DESCRIPTION" field.
        /// </summary>
        public System.String Description
        {
            get { return this.Model.Description; }
            set { this.Model.Description = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_BOOK_ID" field.
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
        ///     Gets or sets the unique code for the value of the "INVLN_BOOK_ID" field.
        /// </summary>
        public System.String BookingId
        {
            get { return this.Model.BookingId; }
            set { this.Model.BookingId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_ELEM_ID" field.
        /// </summary>
        public Consensus.Learning.Element Element
        {
            get
            {
                if (_element == null && this.Model.Element != null)
                    _element = new Consensus.Learning.Element(this.Model.Element);
                if (_element == null)
                    _element = Consensus.Learning.Element.Create();
                return _element;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_ELEM_ID" field.
        /// </summary>
        public System.String ElementId
        {
            get { return this.Model.ElementId; }
            set { this.Model.ElementId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_COURSE_ID" field.
        /// </summary>
        public Consensus.Learning.Event CourseId
        {
            get
            {
                if (_courseId == null && this.Model.CourseId != null)
                    _courseId = new Consensus.Learning.Event(this.Model.CourseId);
                if (_courseId == null)
                    _courseId = Consensus.Learning.Event.Create();
                return _courseId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_COURSE_ID" field.
        /// </summary>
        public System.String CourseIdId
        {
            get { return this.Model.CourseIdId; }
            set { this.Model.CourseIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_TYPE" field.
        /// </summary>
        public System.Nullable<System.Byte> Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_PROD_NAME" field.
        /// </summary>
        public System.String ProdName
        {
            get { return this.Model.ProdName; }
            set { this.Model.ProdName = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_PRD_REV_CODE" field.
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
        ///     Gets or sets the unique code for the value of the "INVLN_PRD_REV_CODE" field.
        /// </summary>
        public System.String RevCodeCode
        {
            get { return this.Model.RevCodeCode; }
            set { this.Model.RevCodeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_PROJ_ID" field.
        /// </summary>
        public System.String ProjId
        {
            get { return this.Model.ProjId; }
            set { this.Model.ProjId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_MEL_ID" field.
        /// </summary>
        public Consensus.Membership.MemberLocation MelId
        {
            get
            {
                if (_melId == null && this.Model.MelId != null)
                    _melId = new Consensus.Membership.MemberLocation(this.Model.MelId);
                if (_melId == null)
                    _melId = Consensus.Membership.MemberLocation.Create();
                return _melId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_MEL_ID" field.
        /// </summary>
        public System.String MelIdId
        {
            get { return this.Model.MelIdId; }
            set { this.Model.MelIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_COST_CODE" field.
        /// </summary>
        public System.String CostCode
        {
            get { return this.Model.CostCode; }
            set { this.Model.CostCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_CREDITED" field.
        /// </summary>
        public System.Nullable<System.Byte> Credited
        {
            get { return this.Model.Credited; }
            set { this.Model.Credited = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "INVLN_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_DEPT" field.
        /// </summary>
        public System.String Dept
        {
            get { return this.Model.Dept; }
            set { this.Model.Dept = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_SKU" field.
        /// </summary>
        public System.String Sku
        {
            get { return this.Model.Sku; }
            set { this.Model.Sku = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_JOB_CODE" field.
        /// </summary>
        public System.String JobCode
        {
            get { return this.Model.JobCode; }
            set { this.Model.JobCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_JOB_ANAL_CODE" field.
        /// </summary>
        public System.String JobAnalCode
        {
            get { return this.Model.JobAnalCode; }
            set { this.Model.JobAnalCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_JOB_TYPE" field.
        /// </summary>
        public System.String JobType
        {
            get { return this.Model.JobType; }
            set { this.Model.JobType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_JOB_PARENT" field.
        /// </summary>
        public System.String JobParent
        {
            get { return this.Model.JobParent; }
            set { this.Model.JobParent = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_PRS_TYPE" field.
        /// </summary>
        public System.Byte PrsType
        {
            get { return this.Model.PrsType; }
            set { this.Model.PrsType = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:InvoiceLineModel" />.
        /// </summary>
        public Collection<Consensus.Membership.MemberLocation> MemberLocations
        {
            get
            {
                if (_memberLocations == null)
                    _memberLocations = new ProxyCollection<Consensus.Membership.MemberLocation, Consensus.Membership.IMemberLocationModel>(this.Model.MemberLocations, model => new Consensus.Membership.MemberLocation(model));
                return _memberLocations;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal InvoiceLine(IInvoiceLineModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public void Delete()
        {
            this.Model.Delete();
        }

        public void Save()
        {
            this.Model.Save();
        }

        /// <summary>
        ///     Creates a new <see cref="!:InvoiceLineModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:InvoiceLineModel" /> instance.
        /// </returns>
        public static Consensus.Finance.InvoiceLine Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return InvoiceLine.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:InvoiceLineModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:InvoiceLineModel" /> instance.
        /// </returns>
        public static Consensus.Finance.InvoiceLine Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IInvoiceLineModel model = provider.Finance.InvoiceLine.Create();
            return model == null ? null : new Consensus.Finance.InvoiceLine(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:InvoiceLineModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.InvoiceLine> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return InvoiceLine.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:InvoiceLineModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.InvoiceLine> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceLineModel> collection = provider.Finance.InvoiceLine.FetchAll();
            return collection.Select(model => new Consensus.Finance.InvoiceLine(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:InvoiceLineModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:InvoiceLineModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.InvoiceLine FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return InvoiceLine.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:InvoiceLineModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:InvoiceLineModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.InvoiceLine FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IInvoiceLineModel model = provider.Finance.InvoiceLine.FetchById(id);
            return model == null ? null : new Consensus.Finance.InvoiceLine(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return InvoiceLine.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.InvoiceLine.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="invoiceId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="invoiceId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.InvoiceLine> FetchAllByInvoiceId(System.String invoiceId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return InvoiceLine.FetchAllByInvoiceId(site,invoiceId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="invoiceId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="invoiceId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.InvoiceLine> FetchAllByInvoiceId(ConsensusSite site, System.String invoiceId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceLineModel> collection = provider.Finance.InvoiceLine.FetchAllByInvoiceId(invoiceId);
            return collection.Select(model => new Consensus.Finance.InvoiceLine(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="productIdId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="productIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.InvoiceLine> FetchAllByProductIdId(System.String productIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return InvoiceLine.FetchAllByProductIdId(site,productIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="productIdId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="productIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.InvoiceLine> FetchAllByProductIdId(ConsensusSite site, System.String productIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceLineModel> collection = provider.Finance.InvoiceLine.FetchAllByProductIdId(productIdId);
            return collection.Select(model => new Consensus.Finance.InvoiceLine(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.InvoiceLine> FetchAllByBookingId(System.String bookingId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return InvoiceLine.FetchAllByBookingId(site,bookingId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.InvoiceLine> FetchAllByBookingId(ConsensusSite site, System.String bookingId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceLineModel> collection = provider.Finance.InvoiceLine.FetchAllByBookingId(bookingId);
            return collection.Select(model => new Consensus.Finance.InvoiceLine(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="elementId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="elementId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.InvoiceLine> FetchAllByElementId(System.String elementId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return InvoiceLine.FetchAllByElementId(site,elementId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="elementId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="elementId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.InvoiceLine> FetchAllByElementId(ConsensusSite site, System.String elementId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceLineModel> collection = provider.Finance.InvoiceLine.FetchAllByElementId(elementId);
            return collection.Select(model => new Consensus.Finance.InvoiceLine(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="courseIdId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="courseIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.InvoiceLine> FetchAllByCourseIdId(System.String courseIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return InvoiceLine.FetchAllByCourseIdId(site,courseIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="courseIdId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="courseIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.InvoiceLine> FetchAllByCourseIdId(ConsensusSite site, System.String courseIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceLineModel> collection = provider.Finance.InvoiceLine.FetchAllByCourseIdId(courseIdId);
            return collection.Select(model => new Consensus.Finance.InvoiceLine(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="melIdId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="melIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.InvoiceLine> FetchAllByMelIdId(System.String melIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return InvoiceLine.FetchAllByMelIdId(site,melIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="melIdId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="melIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.InvoiceLine> FetchAllByMelIdId(ConsensusSite site, System.String melIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceLineModel> collection = provider.Finance.InvoiceLine.FetchAllByMelIdId(melIdId);
            return collection.Select(model => new Consensus.Finance.InvoiceLine(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.InvoiceLine> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return InvoiceLine.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.InvoiceLine> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceLineModel> collection = provider.Finance.InvoiceLine.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Finance.InvoiceLine(model));
        }

        #endregion
    }
}
