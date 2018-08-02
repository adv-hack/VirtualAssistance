using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Finance;
using Consensus.Marketing;
using Consensus.Sales;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="BookingRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalBookingModel : LocalModel<BookingRecord, String>, IBookingModel
    {
        #region fields

        /// <summary>
        ///     The value of the "BOOK_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _bookerOrg;

        /// <summary>
        ///     The value of the "BOOK_PERSON_ID" field.
        /// </summary>
        private LocalPersonModel _bookerPerson;

        /// <summary>
        ///     The value of the "BOOK_INV_ADD" field.
        /// </summary>
        private LocalAddressModel _invoiceAddress;

        /// <summary>
        ///     The value of the "BOOK_NOTES" field.
        /// </summary>
        private LocalNotesModel _notes;

        /// <summary>
        ///     The value of the "BOOK_BOOKING_METHD" field.
        /// </summary>
        private LocalCodeModel _bookingMethod;

        /// <summary>
        ///     The value of the "BOOK_PAYMENT_METHD" field.
        /// </summary>
        private LocalCodeModel _paymentMethod;

        /// <summary>
        ///     The value of the "BOOK_SOURCE_CODE" field.
        /// </summary>
        private LocalPromotionModel _sourceCode;

        /// <summary>
        ///     The value of the "BOOK_INV_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _invoiceOrg;

        /// <summary>
        ///     The value of the "BOOK_INV_EXT_NOTES" field.
        /// </summary>
        private LocalNotesModel _invExtNotes;

        /// <summary>
        ///     The value of the "BOOK_PL_ID" field.
        /// </summary>
        private LocalPriceListModel _priceList;

        /// <summary>
        ///     The value of the "BOOK_REASON" field.
        /// </summary>
        private LocalCodeModel _reason;

        /// <summary>
        ///     The value of the "BOOK_OPP_ID" field.
        /// </summary>
        private LocalOpportunityModel _opportunity;

        /// <summary>
        ///     The value of the "BOOK_DELIV_ADD" field.
        /// </summary>
        private LocalAddressModel _delivAdd;

        /// <summary>
        ///     The value of the "BOOK_DOCS_METHOD" field.
        /// </summary>
        private LocalCodeModel _docsMethod;

        /// <summary>
        ///     The value of the "BOOK_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The value of the "BOOK_ADD_ID" field.
        /// </summary>
        private LocalAddressModel _bookerAddress;

        /// <summary>
        ///     The value of the "BOOK_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _bookerRole;

        /// <summary>
        ///     The value of the "BOOK_INV_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _invoiceRole;

        /// <summary>
        ///     The value of the "BOOK_SCHN_ID" field.
        /// </summary>
        private LocalSalesChannelModel _salesChannel;

        /// <summary>
        ///     The value of the "BOOK_INVOICE_WHEN_STATUS" field.
        /// </summary>
        private LocalCodeModel _invoiceWhenStatus;

        /// <summary>
        ///     The value of the "BOOK_ACC_ID" field.
        /// </summary>
        private LocalAccountModel _account;

        /// <summary>
        ///     The collection of <see cref="LearnerModel" /> instances that reference this <see cref="BookingModel" />.
        /// </summary>
        private LocalCollection<LocalLearnerModel, ILearnerModel> _learners;

        /// <summary>
        ///     The collection of <see cref="ElementModel" /> instances that reference this <see cref="BookingModel" />.
        /// </summary>
        private LocalCollection<LocalElementModel, IElementModel> _elements;

        /// <summary>
        ///     The collection of <see cref="PaymentModel" /> instances that reference this <see cref="BookingModel" />.
        /// </summary>
        private LocalCollection<LocalPaymentModel, IPaymentModel> _payments;

        /// <summary>
        ///     The collection of <see cref="InvoiceLineModel" /> instances that reference this <see cref="BookingModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel> _invoiceLines;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<BookingRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.Booking.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<BookingRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.Booking.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<BookingRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.Booking.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel BookerOrg
        {
            get
            {
                if (_bookerOrg == null && this.BookerOrgId != null)
                    _bookerOrg = this.Provider.Contact.Organisation.FetchById(this.BookerOrgId);
                if (_bookerOrg == null)
                    _bookerOrg = this.Provider.Contact.Organisation.Create();
                
                return _bookerOrg;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_ORG_ID" field.
        /// </summary>
        public String BookerOrgId
        {
            get { return this.ModifiedData.OrgId; }
            set
            {
                if (this.ModifiedData.OrgId != value)
                     _bookerOrg = null;
                this.ModifiedData.OrgId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_PERSON_ID" field.
        /// </summary>
        public LocalPersonModel BookerPerson
        {
            get
            {
                if (_bookerPerson == null && this.BookerPersonId != null)
                    _bookerPerson = this.Provider.Contact.Person.FetchById(this.BookerPersonId);
                if (_bookerPerson == null)
                    _bookerPerson = this.Provider.Contact.Person.Create();
                
                return _bookerPerson;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_PERSON_ID" field.
        /// </summary>
        public String BookerPersonId
        {
            get { return this.ModifiedData.PersonId; }
            set
            {
                if (this.ModifiedData.PersonId != value)
                     _bookerPerson = null;
                this.ModifiedData.PersonId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CUST_ORD_NO" field.
        /// </summary>
        public String CustOrdNo
        {
            get { return this.ModifiedData.CustOrdNo; }
            set { this.ModifiedData.CustOrdNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_ORDER_TYPE" field.
        /// </summary>
        public String Status
        {
            get { return this.ModifiedData.OrderType; }
            set { this.ModifiedData.OrderType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INV_ADD" field.
        /// </summary>
        public LocalAddressModel InvoiceAddress
        {
            get
            {
                if (_invoiceAddress == null && this.InvoiceAddressId != null)
                    _invoiceAddress = this.Provider.Contact.Address.FetchById(this.InvoiceAddressId);
                if (_invoiceAddress == null)
                    _invoiceAddress = this.Provider.Contact.Address.Create();
                
                return _invoiceAddress;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INV_ADD" field.
        /// </summary>
        public String InvoiceAddressId
        {
            get { return this.ModifiedData.InvAdd; }
            set
            {
                if (this.ModifiedData.InvAdd != value)
                     _invoiceAddress = null;
                this.ModifiedData.InvAdd = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_NOTES" field.
        /// </summary>
        public LocalNotesModel Notes
        {
            get
            {
                if (_notes == null && this.NotesId != null)
                    _notes = this.Provider.Common.Notes.FetchById(this.NotesId);
                if (_notes == null)
                    _notes = this.Provider.Common.Notes.Create();
                
                return _notes;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_NOTES" field.
        /// </summary>
        public String NotesId
        {
            get { return this.ModifiedData.Notes; }
            set
            {
                if (this.ModifiedData.Notes != value)
                     _notes = null;
                this.ModifiedData.Notes = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_NET_TOTAL" field.
        /// </summary>
        public Decimal NetTotal
        {
            get { return this.ModifiedData.NetTotal; }
            set { this.ModifiedData.NetTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_VAT_TOTAL" field.
        /// </summary>
        public Decimal VatTotal
        {
            get { return this.ModifiedData.VatTotal; }
            set { this.ModifiedData.VatTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_GROSS_TOTAL" field.
        /// </summary>
        public Decimal GrossTotal
        {
            get { return this.ModifiedData.GrossTotal; }
            set { this.ModifiedData.GrossTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CONFIRMED" field.
        /// </summary>
        public DateTime? Confirmed
        {
            get { return this.ModifiedData.Confirmed; }
            set { this.ModifiedData.Confirmed = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_APPROVED" field.
        /// </summary>
        public Byte? Approved
        {
            get { return this.ModifiedData.Approved; }
            set { this.ModifiedData.Approved = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_APPROVED_BY" field.
        /// </summary>
        public String ApprovedBy
        {
            get { return this.ModifiedData.ApprovedBy; }
            set { this.ModifiedData.ApprovedBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_APPROVE_DATE" field.
        /// </summary>
        public DateTime? ApproveDate
        {
            get { return this.ModifiedData.ApproveDate; }
            set { this.ModifiedData.ApproveDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_BOOKING_METHD" field.
        /// </summary>
        public LocalCodeModel BookingMethod
        {
            get
            {
                if (_bookingMethod == null && !String.IsNullOrEmpty(this.BookingMethodCode))
                    _bookingMethod = this.Provider.Common.Code.FetchByTypeAndCode("BOOKM", this.BookingMethodCode);
                if (_bookingMethod == null)
                    _bookingMethod = this.Provider.Common.Code.Create("BOOKM");
                return _bookingMethod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_BOOKING_METHD" field.
        /// </summary>
        public String BookingMethodCode
        {
            get { return this.ModifiedData.BookingMethd; }
            set
            {
                if (this.ModifiedData.BookingMethd != value)
                     _bookingMethod = null;
                this.ModifiedData.BookingMethd = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_PAYMENT_METHD" field.
        /// </summary>
        public LocalCodeModel PaymentMethod
        {
            get
            {
                if (_paymentMethod == null && !String.IsNullOrEmpty(this.PaymentMethodCode))
                    _paymentMethod = this.Provider.Common.Code.FetchByTypeAndCode("PYPAY", this.PaymentMethodCode);
                if (_paymentMethod == null)
                    _paymentMethod = this.Provider.Common.Code.Create("PYPAY");
                return _paymentMethod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_PAYMENT_METHD" field.
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
        ///     Gets the The value of the "BOOK_SOURCE_CODE" field.
        /// </summary>
        public LocalPromotionModel SourceCode
        {
            get
            {
                if (_sourceCode == null && this.SourceCodeId != null)
                    _sourceCode = this.Provider.Marketing.Promotion.FetchById(this.SourceCodeId);
                if (_sourceCode == null)
                    _sourceCode = this.Provider.Marketing.Promotion.Create();
                
                return _sourceCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_SOURCE_CODE" field.
        /// </summary>
        public String SourceCodeId
        {
            get { return this.ModifiedData.SourceCode; }
            set
            {
                if (this.ModifiedData.SourceCode != value)
                     _sourceCode = null;
                this.ModifiedData.SourceCode = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_STUDENT_PRICE" field.
        /// </summary>
        public Decimal GiftAidTotal
        {
            get { return this.ModifiedData.StudentPrice; }
            set { this.ModifiedData.StudentPrice = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INV_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel InvoiceOrg
        {
            get
            {
                if (_invoiceOrg == null && this.InvoiceOrgId != null)
                    _invoiceOrg = this.Provider.Contact.Organisation.FetchById(this.InvoiceOrgId);
                if (_invoiceOrg == null)
                    _invoiceOrg = this.Provider.Contact.Organisation.Create();
                
                return _invoiceOrg;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INV_ORG_ID" field.
        /// </summary>
        public String InvoiceOrgId
        {
            get { return this.ModifiedData.InvOrgId; }
            set
            {
                if (this.ModifiedData.InvOrgId != value)
                     _invoiceOrg = null;
                this.ModifiedData.InvOrgId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INV_EXT_NOTES" field.
        /// </summary>
        public LocalNotesModel InvExtNotes
        {
            get
            {
                if (_invExtNotes == null && this.InvExtNotesId != null)
                    _invExtNotes = this.Provider.Common.Notes.FetchById(this.InvExtNotesId);
                if (_invExtNotes == null)
                    _invExtNotes = this.Provider.Common.Notes.Create();
                
                return _invExtNotes;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INV_EXT_NOTES" field.
        /// </summary>
        public String InvExtNotesId
        {
            get { return this.ModifiedData.InvExtNotes; }
            set
            {
                if (this.ModifiedData.InvExtNotes != value)
                     _invExtNotes = null;
                this.ModifiedData.InvExtNotes = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICED" field.
        /// </summary>
        public Byte? Invoiced
        {
            get { return this.ModifiedData.Invoiced; }
            set { this.ModifiedData.Invoiced = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_FOR_ATTN_OF" field.
        /// </summary>
        public String ForAttentionOf
        {
            get { return this.ModifiedData.ForAttnOf; }
            set { this.ModifiedData.ForAttnOf = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_DO_NOT_INVOIC" field.
        /// </summary>
        public Byte? DoNotInvoice
        {
            get { return this.ModifiedData.DoNotInvoic; }
            set { this.ModifiedData.DoNotInvoic = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_PL_ID" field.
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
        ///     Gets or sets the unique code for the value of the "BOOK_PL_ID" field.
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
        ///     Gets the The value of the "BOOK_REASON" field.
        /// </summary>
        public LocalCodeModel Reason
        {
            get
            {
                if (_reason == null && !String.IsNullOrEmpty(this.ReasonCode))
                    _reason = this.Provider.Common.Code.FetchByTypeAndCode("BRES", this.ReasonCode);
                if (_reason == null)
                    _reason = this.Provider.Common.Code.Create("BRES");
                return _reason;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_REASON" field.
        /// </summary>
        public String ReasonCode
        {
            get { return this.ModifiedData.Reason; }
            set
            {
                if (this.ModifiedData.Reason != value)
                     _reason = null;
                this.ModifiedData.Reason = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_PAID" field.
        /// </summary>
        public Byte? Paid
        {
            get { return this.ModifiedData.Paid; }
            set { this.ModifiedData.Paid = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CANCEL_DATE" field.
        /// </summary>
        public DateTime? CancelDate
        {
            get { return this.ModifiedData.CancelDate; }
            set { this.ModifiedData.CancelDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CANCEL_BY" field.
        /// </summary>
        public String CancelBy
        {
            get { return this.ModifiedData.CancelBy; }
            set { this.ModifiedData.CancelBy = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_OPP_ID" field.
        /// </summary>
        public LocalOpportunityModel Opportunity
        {
            get
            {
                if (_opportunity == null && this.OpportunityId != null)
                    _opportunity = this.Provider.Sales.Opportunity.FetchById(this.OpportunityId);
                if (_opportunity == null)
                    _opportunity = this.Provider.Sales.Opportunity.Create();
                
                return _opportunity;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_OPP_ID" field.
        /// </summary>
        public String OpportunityId
        {
            get { return this.ModifiedData.OppId; }
            set
            {
                if (this.ModifiedData.OppId != value)
                     _opportunity = null;
                this.ModifiedData.OppId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_DELIV_ADD" field.
        /// </summary>
        public LocalAddressModel DelivAdd
        {
            get
            {
                if (_delivAdd == null && this.DelivAddId != null)
                    _delivAdd = this.Provider.Contact.Address.FetchById(this.DelivAddId);
                if (_delivAdd == null)
                    _delivAdd = this.Provider.Contact.Address.Create();
                
                return _delivAdd;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_DELIV_ADD" field.
        /// </summary>
        public String DelivAddId
        {
            get { return this.ModifiedData.DelivAdd; }
            set
            {
                if (this.ModifiedData.DelivAdd != value)
                     _delivAdd = null;
                this.ModifiedData.DelivAdd = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_DOCS_METHOD" field.
        /// </summary>
        public LocalCodeModel DocsMethod
        {
            get
            {
                if (_docsMethod == null && !String.IsNullOrEmpty(this.DocsMethodCode))
                    _docsMethod = this.Provider.Common.Code.FetchByTypeAndCode("DPMS", this.DocsMethodCode);
                if (_docsMethod == null)
                    _docsMethod = this.Provider.Common.Code.Create("DPMS");
                return _docsMethod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_DOCS_METHOD" field.
        /// </summary>
        public String DocsMethodCode
        {
            get { return this.ModifiedData.DocsMethod; }
            set
            {
                if (this.ModifiedData.DocsMethod != value)
                     _docsMethod = null;
                this.ModifiedData.DocsMethod = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CANC_REASON" field.
        /// </summary>
        public String CancReason
        {
            get { return this.ModifiedData.CancReason; }
            set { this.ModifiedData.CancReason = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CURRENCY_TYPE" field.
        /// </summary>
        public String CurrencyType
        {
            get { return this.ModifiedData.CurrencyType; }
            set { this.ModifiedData.CurrencyType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "BOOK_SELCO_SP_ID" field.
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
        ///     Gets the The value of the "BOOK_ADD_ID" field.
        /// </summary>
        public LocalAddressModel BookerAddress
        {
            get
            {
                if (_bookerAddress == null && this.BookerAddressId != null)
                    _bookerAddress = this.Provider.Contact.Address.FetchById(this.BookerAddressId);
                if (_bookerAddress == null)
                    _bookerAddress = this.Provider.Contact.Address.Create();
                
                return _bookerAddress;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_ADD_ID" field.
        /// </summary>
        public String BookerAddressId
        {
            get { return this.ModifiedData.AddId; }
            set
            {
                if (this.ModifiedData.AddId != value)
                     _bookerAddress = null;
                this.ModifiedData.AddId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel BookerRole
        {
            get
            {
                if (_bookerRole == null && this.BookerRoleId != null)
                    _bookerRole = this.Provider.Contact.Role.FetchById(this.BookerRoleId);
                if (_bookerRole == null)
                    _bookerRole = this.Provider.Contact.Role.Create();
                
                return _bookerRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_PROLE_ID" field.
        /// </summary>
        public String BookerRoleId
        {
            get { return this.ModifiedData.ProleId; }
            set
            {
                if (this.ModifiedData.ProleId != value)
                     _bookerRole = null;
                this.ModifiedData.ProleId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_VATCD_OVRRIDE" field.
        /// </summary>
        public String VatcdOvrride
        {
            get { return this.ModifiedData.VatcdOvrride; }
            set { this.ModifiedData.VatcdOvrride = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_ORG_CUST_AC" field.
        /// </summary>
        public String InvoiceAccountRef
        {
            get { return this.ModifiedData.OrgCustAc; }
            set { this.ModifiedData.OrgCustAc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_DELIV_FAO" field.
        /// </summary>
        public String DelivFao
        {
            get { return this.ModifiedData.DelivFao; }
            set { this.ModifiedData.DelivFao = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_DELIV_PHONE" field.
        /// </summary>
        public String DelivPhone
        {
            get { return this.ModifiedData.DelivPhone; }
            set { this.ModifiedData.DelivPhone = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INV_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel InvoiceRole
        {
            get
            {
                if (_invoiceRole == null && this.InvoiceRoleId != null)
                    _invoiceRole = this.Provider.Contact.Role.FetchById(this.InvoiceRoleId);
                if (_invoiceRole == null)
                    _invoiceRole = this.Provider.Contact.Role.Create();
                
                return _invoiceRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INV_PROLE_ID" field.
        /// </summary>
        public String InvoiceRoleId
        {
            get { return this.ModifiedData.InvProleId; }
            set
            {
                if (this.ModifiedData.InvProleId != value)
                     _invoiceRole = null;
                this.ModifiedData.InvProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_SCHN_ID" field.
        /// </summary>
        public LocalSalesChannelModel SalesChannel
        {
            get
            {
                if (_salesChannel == null && this.SalesChannelId != null)
                    _salesChannel = this.Provider.Sales.SalesChannel.FetchById(this.SalesChannelId);
                if (_salesChannel == null)
                    _salesChannel = this.Provider.Sales.SalesChannel.Create();
                
                return _salesChannel;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_SCHN_ID" field.
        /// </summary>
        public String SalesChannelId
        {
            get { return this.ModifiedData.SchnId; }
            set
            {
                if (this.ModifiedData.SchnId != value)
                     _salesChannel = null;
                this.ModifiedData.SchnId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_RULE" field.
        /// </summary>
        public Byte InvoiceRule
        {
            get { return this.ModifiedData.InvoiceRule; }
            set { this.ModifiedData.InvoiceRule = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_RULE_OFFSET" field.
        /// </summary>
        public Int16 InvoiceRuleOffset
        {
            get { return this.ModifiedData.InvoiceRuleOffset; }
            set { this.ModifiedData.InvoiceRuleOffset = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_DO_NOT_INVOICE_REASON" field.
        /// </summary>
        public String DoNotInvoiceReason
        {
            get { return this.ModifiedData.DoNotInvoiceReason; }
            set { this.ModifiedData.DoNotInvoiceReason = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_OFFSET_TYPE" field.
        /// </summary>
        public String InvoiceOffsetType
        {
            get { return this.ModifiedData.InvoiceOffsetType; }
            set { this.ModifiedData.InvoiceOffsetType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INVOICE_WHEN_STATUS" field.
        /// </summary>
        public LocalCodeModel InvoiceWhenStatus
        {
            get
            {
                if (_invoiceWhenStatus == null && !String.IsNullOrEmpty(this.InvoiceWhenStatusCode))
                    _invoiceWhenStatus = this.Provider.Common.Code.FetchByTypeAndCode("SSTAT", this.InvoiceWhenStatusCode);
                if (_invoiceWhenStatus == null)
                    _invoiceWhenStatus = this.Provider.Common.Code.Create("SSTAT");
                return _invoiceWhenStatus;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INVOICE_WHEN_STATUS" field.
        /// </summary>
        public String InvoiceWhenStatusCode
        {
            get { return this.ModifiedData.InvoiceWhenStatus; }
            set
            {
                if (this.ModifiedData.InvoiceWhenStatus != value)
                     _invoiceWhenStatus = null;
                this.ModifiedData.InvoiceWhenStatus = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_MUST_USE_RULE" field.
        /// </summary>
        public Byte InvoiceMustUseRule
        {
            get { return this.ModifiedData.InvoiceMustUseRule; }
            set { this.ModifiedData.InvoiceMustUseRule = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_CONSOLIDATE" field.
        /// </summary>
        public Byte InvoiceConsolidate
        {
            get { return this.ModifiedData.InvoiceConsolidate; }
            set { this.ModifiedData.InvoiceConsolidate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_ACC_ID" field.
        /// </summary>
        public LocalAccountModel Account
        {
            get
            {
                if (_account == null && this.AccountId != null)
                    _account = this.Provider.Finance.Account.FetchById(this.AccountId);
                if (_account == null)
                    _account = this.Provider.Finance.Account.Create();
                
                return _account;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_ACC_ID" field.
        /// </summary>
        public String AccountId
        {
            get { return this.ModifiedData.AccId; }
            set
            {
                if (this.ModifiedData.AccId != value)
                     _account = null;
                this.ModifiedData.AccId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_RESV_TO_DATE" field.
        /// </summary>
        public DateTime? ResvToDate
        {
            get { return this.ModifiedData.ResvToDate; }
            set { this.ModifiedData.ResvToDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_PER_DEL" field.
        /// </summary>
        public Byte InvoicePerDel
        {
            get { return this.ModifiedData.InvoicePerDel; }
            set { this.ModifiedData.InvoicePerDel = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CANCEL_REF" field.
        /// </summary>
        public String CancelRef
        {
            get { return this.ModifiedData.CancelRef; }
            set { this.ModifiedData.CancelRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_PER_PERSON" field.
        /// </summary>
        public Byte InvoicePerPerson
        {
            get { return this.ModifiedData.InvoicePerPerson; }
            set { this.ModifiedData.InvoicePerPerson = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_PROMO_CODE" field.
        /// </summary>
        public String PromoCode
        {
            get { return this.ModifiedData.PromoCode; }
            set { this.ModifiedData.PromoCode = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LearnerModel" /> instances that reference this <see cref="BookingModel" />.
        /// </summary>
        public LocalCollection<LocalLearnerModel, ILearnerModel> Learners
        {
            get
            {
                if (_learners == null)
                    _learners = new LocalCollection<LocalLearnerModel, ILearnerModel>(this.Provider.Learning.Learner.FetchAllByBookingId(this.Id));
                
                return _learners;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ElementModel" /> instances that reference this <see cref="BookingModel" />.
        /// </summary>
        public LocalCollection<LocalElementModel, IElementModel> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new LocalCollection<LocalElementModel, IElementModel>(this.Provider.Learning.Element.FetchAllByBookingId(this.Id));
                
                return _elements;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PaymentModel" /> instances that reference this <see cref="BookingModel" />.
        /// </summary>
        public LocalCollection<LocalPaymentModel, IPaymentModel> Payments
        {
            get
            {
                if (_payments == null)
                    _payments = new LocalCollection<LocalPaymentModel, IPaymentModel>(this.Provider.Finance.Payment.FetchAllByBookingId(this.Id));
                
                return _payments;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceLineModel" /> instances that reference this <see cref="BookingModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel> InvoiceLines
        {
            get
            {
                if (_invoiceLines == null)
                    _invoiceLines = new LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel>(this.Provider.Finance.InvoiceLine.FetchAllByBookingId(this.Id));
                
                return _invoiceLines;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalBookingModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalBookingModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalBookingModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalBookingModel(LocalProvider provider, BookingRecord record) : base(provider, record)
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
            if (_bookingMethod != null)
            {
                _bookingMethod.Save();
                this.ModifiedData.BookingMethd = _bookingMethod.Value1;
            }
            if (_paymentMethod != null)
            {
                _paymentMethod.Save();
                this.ModifiedData.PaymentMethd = _paymentMethod.Value1;
            }
            if (_reason != null)
            {
                _reason.Save();
                this.ModifiedData.Reason = _reason.Value1;
            }
            if (_docsMethod != null)
            {
                _docsMethod.Save();
                this.ModifiedData.DocsMethod = _docsMethod.Value1;
            }
            if (_invoiceWhenStatus != null)
            {
                _invoiceWhenStatus.Save();
                this.ModifiedData.InvoiceWhenStatus = _invoiceWhenStatus.Value1;
            }
            if (_bookerOrg != null)
            {
                _bookerOrg.Save();
                this.ModifiedData.OrgId = _bookerOrg.Id == null && this.ModifiedData.OrgId != null ? "" : _bookerOrg.Id;
            }
            if (_bookerPerson != null)
            {
                _bookerPerson.Save();
                this.ModifiedData.PersonId = _bookerPerson.Id == null && this.ModifiedData.PersonId != null ? "" : _bookerPerson.Id;
            }
            if (_invoiceAddress != null)
            {
                _invoiceAddress.Save();
                this.ModifiedData.InvAdd = _invoiceAddress.Id == null && this.ModifiedData.InvAdd != null ? "" : _invoiceAddress.Id;
            }
            if (_notes != null)
            {
                _notes.Save();
                this.ModifiedData.Notes = _notes.Id == null && this.ModifiedData.Notes != null ? "" : _notes.Id;
            }
            if (_sourceCode != null)
            {
                _sourceCode.Save();
                this.ModifiedData.SourceCode = _sourceCode.Id == null && this.ModifiedData.SourceCode != null ? "" : _sourceCode.Id;
            }
            if (_invoiceOrg != null)
            {
                _invoiceOrg.Save();
                this.ModifiedData.InvOrgId = _invoiceOrg.Id == null && this.ModifiedData.InvOrgId != null ? "" : _invoiceOrg.Id;
            }
            if (_invExtNotes != null)
            {
                _invExtNotes.Save();
                this.ModifiedData.InvExtNotes = _invExtNotes.Id == null && this.ModifiedData.InvExtNotes != null ? "" : _invExtNotes.Id;
            }
            if (_priceList != null)
            {
                _priceList.Save();
                this.ModifiedData.PlId = _priceList.Id == null && this.ModifiedData.PlId != null ? "" : _priceList.Id;
            }
            if (_opportunity != null)
            {
                _opportunity.Save();
                this.ModifiedData.OppId = _opportunity.Id == null && this.ModifiedData.OppId != null ? "" : _opportunity.Id;
            }
            if (_delivAdd != null)
            {
                _delivAdd.Save();
                this.ModifiedData.DelivAdd = _delivAdd.Id == null && this.ModifiedData.DelivAdd != null ? "" : _delivAdd.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
            }
            if (_bookerAddress != null)
            {
                _bookerAddress.Save();
                this.ModifiedData.AddId = _bookerAddress.Id == null && this.ModifiedData.AddId != null ? "" : _bookerAddress.Id;
            }
            if (_bookerRole != null)
            {
                _bookerRole.Save();
                this.ModifiedData.ProleId = _bookerRole.Id == null && this.ModifiedData.ProleId != null ? "" : _bookerRole.Id;
            }
            if (_invoiceRole != null)
            {
                _invoiceRole.Save();
                this.ModifiedData.InvProleId = _invoiceRole.Id == null && this.ModifiedData.InvProleId != null ? "" : _invoiceRole.Id;
            }
            if (_salesChannel != null)
            {
                _salesChannel.Save();
                this.ModifiedData.SchnId = _salesChannel.Id == null && this.ModifiedData.SchnId != null ? "" : _salesChannel.Id;
            }
            if (_account != null)
            {
                _account.Save();
                this.ModifiedData.AccId = _account.Id == null && this.ModifiedData.AccId != null ? "" : _account.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_learners != null)
                _learners.Execute(obj => obj.BookingId = this.Id).Execute(obj => obj.Save());
            if (_elements != null)
                _elements.Execute(obj => obj.BookingId = this.Id).Execute(obj => obj.Save());
            if (_payments != null)
                _payments.Execute(obj => obj.BookingId = this.Id).Execute(obj => obj.Save());
            if (_invoiceLines != null)
                _invoiceLines.Execute(obj => obj.BookingId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "BOOK_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IBookingModel.BookerOrg
        {
            get { return this.BookerOrg; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_ORG_ID" field.
        /// </summary>
        System.String IBookingModel.BookerOrgId
        {
            get { return this.BookerOrgId; }
            set { this.BookerOrgId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_PERSON_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel IBookingModel.BookerPerson
        {
            get { return this.BookerPerson; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_PERSON_ID" field.
        /// </summary>
        System.String IBookingModel.BookerPersonId
        {
            get { return this.BookerPersonId; }
            set { this.BookerPersonId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CUST_ORD_NO" field.
        /// </summary>
        System.String IBookingModel.CustOrdNo
        {
            get { return this.CustOrdNo; }
            set { this.CustOrdNo = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_ORDER_TYPE" field.
        /// </summary>
        System.String IBookingModel.Status
        {
            get { return this.Status; }
            set { this.Status = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INV_ADD" field.
        /// </summary>
        Consensus.Contact.IAddressModel IBookingModel.InvoiceAddress
        {
            get { return this.InvoiceAddress; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INV_ADD" field.
        /// </summary>
        System.String IBookingModel.InvoiceAddressId
        {
            get { return this.InvoiceAddressId; }
            set { this.InvoiceAddressId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_NOTES" field.
        /// </summary>
        Consensus.Common.INotesModel IBookingModel.Notes
        {
            get { return this.Notes; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_NOTES" field.
        /// </summary>
        System.String IBookingModel.NotesId
        {
            get { return this.NotesId; }
            set { this.NotesId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_NET_TOTAL" field.
        /// </summary>
        System.Decimal IBookingModel.NetTotal
        {
            get { return this.NetTotal; }
            set { this.NetTotal = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_VAT_TOTAL" field.
        /// </summary>
        System.Decimal IBookingModel.VatTotal
        {
            get { return this.VatTotal; }
            set { this.VatTotal = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_GROSS_TOTAL" field.
        /// </summary>
        System.Decimal IBookingModel.GrossTotal
        {
            get { return this.GrossTotal; }
            set { this.GrossTotal = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CONFIRMED" field.
        /// </summary>
        System.Nullable<System.DateTime> IBookingModel.Confirmed
        {
            get { return this.Confirmed; }
            set { this.Confirmed = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_APPROVED" field.
        /// </summary>
        System.Nullable<System.Byte> IBookingModel.Approved
        {
            get { return this.Approved; }
            set { this.Approved = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_APPROVED_BY" field.
        /// </summary>
        System.String IBookingModel.ApprovedBy
        {
            get { return this.ApprovedBy; }
            set { this.ApprovedBy = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_APPROVE_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IBookingModel.ApproveDate
        {
            get { return this.ApproveDate; }
            set { this.ApproveDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_BOOKING_METHD" field.
        /// </summary>
        Consensus.Common.ICodeModel IBookingModel.BookingMethod
        {
            get { return this.BookingMethod; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_BOOKING_METHD" field.
        /// </summary>
        System.String IBookingModel.BookingMethodCode
        {
            get { return this.BookingMethodCode; }
            set { this.BookingMethodCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_PAYMENT_METHD" field.
        /// </summary>
        Consensus.Common.ICodeModel IBookingModel.PaymentMethod
        {
            get { return this.PaymentMethod; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_PAYMENT_METHD" field.
        /// </summary>
        System.String IBookingModel.PaymentMethodCode
        {
            get { return this.PaymentMethodCode; }
            set { this.PaymentMethodCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_SOURCE_CODE" field.
        /// </summary>
        Consensus.Marketing.IPromotionModel IBookingModel.SourceCode
        {
            get { return this.SourceCode; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_SOURCE_CODE" field.
        /// </summary>
        System.String IBookingModel.SourceCodeId
        {
            get { return this.SourceCodeId; }
            set { this.SourceCodeId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_STUDENT_PRICE" field.
        /// </summary>
        System.Decimal IBookingModel.GiftAidTotal
        {
            get { return this.GiftAidTotal; }
            set { this.GiftAidTotal = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INV_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IBookingModel.InvoiceOrg
        {
            get { return this.InvoiceOrg; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INV_ORG_ID" field.
        /// </summary>
        System.String IBookingModel.InvoiceOrgId
        {
            get { return this.InvoiceOrgId; }
            set { this.InvoiceOrgId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INV_EXT_NOTES" field.
        /// </summary>
        Consensus.Common.INotesModel IBookingModel.InvExtNotes
        {
            get { return this.InvExtNotes; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INV_EXT_NOTES" field.
        /// </summary>
        System.String IBookingModel.InvExtNotesId
        {
            get { return this.InvExtNotesId; }
            set { this.InvExtNotesId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICED" field.
        /// </summary>
        System.Nullable<System.Byte> IBookingModel.Invoiced
        {
            get { return this.Invoiced; }
            set { this.Invoiced = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_FOR_ATTN_OF" field.
        /// </summary>
        System.String IBookingModel.ForAttentionOf
        {
            get { return this.ForAttentionOf; }
            set { this.ForAttentionOf = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_DO_NOT_INVOIC" field.
        /// </summary>
        System.Nullable<System.Byte> IBookingModel.DoNotInvoice
        {
            get { return this.DoNotInvoice; }
            set { this.DoNotInvoice = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_PL_ID" field.
        /// </summary>
        Consensus.Finance.IPriceListModel IBookingModel.PriceList
        {
            get { return this.PriceList; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_PL_ID" field.
        /// </summary>
        System.String IBookingModel.PriceListId
        {
            get { return this.PriceListId; }
            set { this.PriceListId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_REASON" field.
        /// </summary>
        Consensus.Common.ICodeModel IBookingModel.Reason
        {
            get { return this.Reason; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_REASON" field.
        /// </summary>
        System.String IBookingModel.ReasonCode
        {
            get { return this.ReasonCode; }
            set { this.ReasonCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_PAID" field.
        /// </summary>
        System.Nullable<System.Byte> IBookingModel.Paid
        {
            get { return this.Paid; }
            set { this.Paid = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CANCEL_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IBookingModel.CancelDate
        {
            get { return this.CancelDate; }
            set { this.CancelDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CANCEL_BY" field.
        /// </summary>
        System.String IBookingModel.CancelBy
        {
            get { return this.CancelBy; }
            set { this.CancelBy = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_OPP_ID" field.
        /// </summary>
        Consensus.Sales.IOpportunityModel IBookingModel.Opportunity
        {
            get { return this.Opportunity; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_OPP_ID" field.
        /// </summary>
        System.String IBookingModel.OpportunityId
        {
            get { return this.OpportunityId; }
            set { this.OpportunityId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_DELIV_ADD" field.
        /// </summary>
        Consensus.Contact.IAddressModel IBookingModel.DelivAdd
        {
            get { return this.DelivAdd; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_DELIV_ADD" field.
        /// </summary>
        System.String IBookingModel.DelivAddId
        {
            get { return this.DelivAddId; }
            set { this.DelivAddId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_DOCS_METHOD" field.
        /// </summary>
        Consensus.Common.ICodeModel IBookingModel.DocsMethod
        {
            get { return this.DocsMethod; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_DOCS_METHOD" field.
        /// </summary>
        System.String IBookingModel.DocsMethodCode
        {
            get { return this.DocsMethodCode; }
            set { this.DocsMethodCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CANC_REASON" field.
        /// </summary>
        System.String IBookingModel.CancReason
        {
            get { return this.CancReason; }
            set { this.CancReason = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CURRENCY_TYPE" field.
        /// </summary>
        System.String IBookingModel.CurrencyType
        {
            get { return this.CurrencyType; }
            set { this.CurrencyType = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IBookingModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_SELCO_SP_ID" field.
        /// </summary>
        System.String IBookingModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel IBookingModel.BookerAddress
        {
            get { return this.BookerAddress; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_ADD_ID" field.
        /// </summary>
        System.String IBookingModel.BookerAddressId
        {
            get { return this.BookerAddressId; }
            set { this.BookerAddressId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IBookingModel.BookerRole
        {
            get { return this.BookerRole; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_PROLE_ID" field.
        /// </summary>
        System.String IBookingModel.BookerRoleId
        {
            get { return this.BookerRoleId; }
            set { this.BookerRoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_VATCD_OVRRIDE" field.
        /// </summary>
        System.String IBookingModel.VatcdOvrride
        {
            get { return this.VatcdOvrride; }
            set { this.VatcdOvrride = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_ORG_CUST_AC" field.
        /// </summary>
        System.String IBookingModel.InvoiceAccountRef
        {
            get { return this.InvoiceAccountRef; }
            set { this.InvoiceAccountRef = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_DELIV_FAO" field.
        /// </summary>
        System.String IBookingModel.DelivFao
        {
            get { return this.DelivFao; }
            set { this.DelivFao = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_DELIV_PHONE" field.
        /// </summary>
        System.String IBookingModel.DelivPhone
        {
            get { return this.DelivPhone; }
            set { this.DelivPhone = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INV_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IBookingModel.InvoiceRole
        {
            get { return this.InvoiceRole; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INV_PROLE_ID" field.
        /// </summary>
        System.String IBookingModel.InvoiceRoleId
        {
            get { return this.InvoiceRoleId; }
            set { this.InvoiceRoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_SCHN_ID" field.
        /// </summary>
        Consensus.Sales.ISalesChannelModel IBookingModel.SalesChannel
        {
            get { return this.SalesChannel; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_SCHN_ID" field.
        /// </summary>
        System.String IBookingModel.SalesChannelId
        {
            get { return this.SalesChannelId; }
            set { this.SalesChannelId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_RULE" field.
        /// </summary>
        System.Byte IBookingModel.InvoiceRule
        {
            get { return this.InvoiceRule; }
            set { this.InvoiceRule = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_RULE_OFFSET" field.
        /// </summary>
        System.Int16 IBookingModel.InvoiceRuleOffset
        {
            get { return this.InvoiceRuleOffset; }
            set { this.InvoiceRuleOffset = (System.Int16)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_DO_NOT_INVOICE_REASON" field.
        /// </summary>
        System.String IBookingModel.DoNotInvoiceReason
        {
            get { return this.DoNotInvoiceReason; }
            set { this.DoNotInvoiceReason = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_OFFSET_TYPE" field.
        /// </summary>
        System.String IBookingModel.InvoiceOffsetType
        {
            get { return this.InvoiceOffsetType; }
            set { this.InvoiceOffsetType = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INVOICE_WHEN_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel IBookingModel.InvoiceWhenStatus
        {
            get { return this.InvoiceWhenStatus; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INVOICE_WHEN_STATUS" field.
        /// </summary>
        System.String IBookingModel.InvoiceWhenStatusCode
        {
            get { return this.InvoiceWhenStatusCode; }
            set { this.InvoiceWhenStatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_MUST_USE_RULE" field.
        /// </summary>
        System.Byte IBookingModel.InvoiceMustUseRule
        {
            get { return this.InvoiceMustUseRule; }
            set { this.InvoiceMustUseRule = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_CONSOLIDATE" field.
        /// </summary>
        System.Byte IBookingModel.InvoiceConsolidate
        {
            get { return this.InvoiceConsolidate; }
            set { this.InvoiceConsolidate = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_ACC_ID" field.
        /// </summary>
        Consensus.Finance.IAccountModel IBookingModel.Account
        {
            get { return this.Account; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_ACC_ID" field.
        /// </summary>
        System.String IBookingModel.AccountId
        {
            get { return this.AccountId; }
            set { this.AccountId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_RESV_TO_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IBookingModel.ResvToDate
        {
            get { return this.ResvToDate; }
            set { this.ResvToDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_PER_DEL" field.
        /// </summary>
        System.Byte IBookingModel.InvoicePerDel
        {
            get { return this.InvoicePerDel; }
            set { this.InvoicePerDel = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CANCEL_REF" field.
        /// </summary>
        System.String IBookingModel.CancelRef
        {
            get { return this.CancelRef; }
            set { this.CancelRef = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_PER_PERSON" field.
        /// </summary>
        System.Byte IBookingModel.InvoicePerPerson
        {
            get { return this.InvoicePerPerson; }
            set { this.InvoicePerPerson = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_PROMO_CODE" field.
        /// </summary>
        System.String IBookingModel.PromoCode
        {
            get { return this.PromoCode; }
            set { this.PromoCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:BookingModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ILearnerModel> IBookingModel.Learners
        {
            get { return this.Learners; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:BookingModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> IBookingModel.Elements
        {
            get { return this.Elements; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:BookingModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPaymentModel> IBookingModel.Payments
        {
            get { return this.Payments; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:BookingModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceLineModel> IBookingModel.InvoiceLines
        {
            get { return this.InvoiceLines; }
        }

        #endregion
    }
}
