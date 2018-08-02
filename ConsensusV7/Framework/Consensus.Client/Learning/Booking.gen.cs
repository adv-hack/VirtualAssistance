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
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Booking : Proxy<IBookingModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="BookerOrg" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _bookerOrg;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="BookerPerson" /> member.
        /// </summary>
        private Consensus.Contact.Person _bookerPerson;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="InvoiceAddress" /> member.
        /// </summary>
        private Consensus.Contact.Address _invoiceAddress;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Notes" /> member.
        /// </summary>
        private Consensus.Common.Notes _notes;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="BookingMethod" /> member.
        /// </summary>
        private Consensus.Common.Code _bookingMethod;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PaymentMethod" /> member.
        /// </summary>
        private Consensus.Common.Code _paymentMethod;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SourceCode" /> member.
        /// </summary>
        private Consensus.Marketing.Promotion _sourceCode;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="InvoiceOrg" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _invoiceOrg;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="InvExtNotes" /> member.
        /// </summary>
        private Consensus.Common.Notes _invExtNotes;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PriceList" /> member.
        /// </summary>
        private Consensus.Finance.PriceList _priceList;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Reason" /> member.
        /// </summary>
        private Consensus.Common.Code _reason;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Opportunity" /> member.
        /// </summary>
        private Consensus.Sales.Opportunity _opportunity;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="DelivAdd" /> member.
        /// </summary>
        private Consensus.Contact.Address _delivAdd;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="DocsMethod" /> member.
        /// </summary>
        private Consensus.Common.Code _docsMethod;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="BookerAddress" /> member.
        /// </summary>
        private Consensus.Contact.Address _bookerAddress;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="BookerRole" /> member.
        /// </summary>
        private Consensus.Contact.Role _bookerRole;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="InvoiceRole" /> member.
        /// </summary>
        private Consensus.Contact.Role _invoiceRole;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SalesChannel" /> member.
        /// </summary>
        private Consensus.Sales.SalesChannel _salesChannel;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="InvoiceWhenStatus" /> member.
        /// </summary>
        private Consensus.Common.Code _invoiceWhenStatus;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Account" /> member.
        /// </summary>
        private Consensus.Finance.Account _account;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Learners" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Learner, Consensus.Learning.ILearnerModel> _learners;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Elements" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel> _elements;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Payments" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Payment, Consensus.Finance.IPaymentModel> _payments;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="InvoiceLines" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.InvoiceLine, Consensus.Finance.IInvoiceLineModel> _invoiceLines;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "BOOK_ORG_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation BookerOrg
        {
            get
            {
                if (_bookerOrg == null && this.Model.BookerOrg != null)
                    _bookerOrg = new Consensus.Contact.Organisation(this.Model.BookerOrg);
                if (_bookerOrg == null)
                    _bookerOrg = Consensus.Contact.Organisation.Create();
                return _bookerOrg;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_ORG_ID" field.
        /// </summary>
        public System.String BookerOrgId
        {
            get { return this.Model.BookerOrgId; }
            set { this.Model.BookerOrgId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_PERSON_ID" field.
        /// </summary>
        public Consensus.Contact.Person BookerPerson
        {
            get
            {
                if (_bookerPerson == null && this.Model.BookerPerson != null)
                    _bookerPerson = new Consensus.Contact.Person(this.Model.BookerPerson);
                if (_bookerPerson == null)
                    _bookerPerson = Consensus.Contact.Person.Create();
                return _bookerPerson;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_PERSON_ID" field.
        /// </summary>
        public System.String BookerPersonId
        {
            get { return this.Model.BookerPersonId; }
            set { this.Model.BookerPersonId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CUST_ORD_NO" field.
        /// </summary>
        public System.String CustOrdNo
        {
            get { return this.Model.CustOrdNo; }
            set { this.Model.CustOrdNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_ORDER_TYPE" field.
        /// </summary>
        public System.String Status
        {
            get { return this.Model.Status; }
            set { this.Model.Status = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INV_ADD" field.
        /// </summary>
        public Consensus.Contact.Address InvoiceAddress
        {
            get
            {
                if (_invoiceAddress == null && this.Model.InvoiceAddress != null)
                    _invoiceAddress = new Consensus.Contact.Address(this.Model.InvoiceAddress);
                if (_invoiceAddress == null)
                    _invoiceAddress = Consensus.Contact.Address.Create();
                return _invoiceAddress;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INV_ADD" field.
        /// </summary>
        public System.String InvoiceAddressId
        {
            get { return this.Model.InvoiceAddressId; }
            set { this.Model.InvoiceAddressId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_NOTES" field.
        /// </summary>
        public Consensus.Common.Notes Notes
        {
            get
            {
                if (_notes == null && this.Model.Notes != null)
                    _notes = new Consensus.Common.Notes(this.Model.Notes);
                if (_notes == null)
                    _notes = Consensus.Common.Notes.Create();
                return _notes;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_NOTES" field.
        /// </summary>
        public System.String NotesId
        {
            get { return this.Model.NotesId; }
            set { this.Model.NotesId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_NET_TOTAL" field.
        /// </summary>
        public System.Decimal NetTotal
        {
            get { return this.Model.NetTotal; }
            set { this.Model.NetTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_VAT_TOTAL" field.
        /// </summary>
        public System.Decimal VatTotal
        {
            get { return this.Model.VatTotal; }
            set { this.Model.VatTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_GROSS_TOTAL" field.
        /// </summary>
        public System.Decimal GrossTotal
        {
            get { return this.Model.GrossTotal; }
            set { this.Model.GrossTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CONFIRMED" field.
        /// </summary>
        public System.Nullable<System.DateTime> Confirmed
        {
            get { return this.Model.Confirmed; }
            set { this.Model.Confirmed = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_APPROVED" field.
        /// </summary>
        public System.Nullable<System.Byte> Approved
        {
            get { return this.Model.Approved; }
            set { this.Model.Approved = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_APPROVED_BY" field.
        /// </summary>
        public System.String ApprovedBy
        {
            get { return this.Model.ApprovedBy; }
            set { this.Model.ApprovedBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_APPROVE_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> ApproveDate
        {
            get { return this.Model.ApproveDate; }
            set { this.Model.ApproveDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_BOOKING_METHD" field.
        /// </summary>
        public Consensus.Common.Code BookingMethod
        {
            get
            {
                if (_bookingMethod == null && this.Model.BookingMethod != null)
                    _bookingMethod = new Consensus.Common.Code(this.Model.BookingMethod);
                if (_bookingMethod == null)
                    _bookingMethod = Consensus.Common.Code.Create();
                return _bookingMethod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_BOOKING_METHD" field.
        /// </summary>
        public System.String BookingMethodCode
        {
            get { return this.Model.BookingMethodCode; }
            set { this.Model.BookingMethodCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_PAYMENT_METHD" field.
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
        ///     Gets or sets the unique code for the value of the "BOOK_PAYMENT_METHD" field.
        /// </summary>
        public System.String PaymentMethodCode
        {
            get { return this.Model.PaymentMethodCode; }
            set { this.Model.PaymentMethodCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_SOURCE_CODE" field.
        /// </summary>
        public Consensus.Marketing.Promotion SourceCode
        {
            get
            {
                if (_sourceCode == null && this.Model.SourceCode != null)
                    _sourceCode = new Consensus.Marketing.Promotion(this.Model.SourceCode);
                if (_sourceCode == null)
                    _sourceCode = Consensus.Marketing.Promotion.Create();
                return _sourceCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_SOURCE_CODE" field.
        /// </summary>
        public System.String SourceCodeId
        {
            get { return this.Model.SourceCodeId; }
            set { this.Model.SourceCodeId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_STUDENT_PRICE" field.
        /// </summary>
        public System.Decimal GiftAidTotal
        {
            get { return this.Model.GiftAidTotal; }
            set { this.Model.GiftAidTotal = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INV_ORG_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation InvoiceOrg
        {
            get
            {
                if (_invoiceOrg == null && this.Model.InvoiceOrg != null)
                    _invoiceOrg = new Consensus.Contact.Organisation(this.Model.InvoiceOrg);
                if (_invoiceOrg == null)
                    _invoiceOrg = Consensus.Contact.Organisation.Create();
                return _invoiceOrg;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INV_ORG_ID" field.
        /// </summary>
        public System.String InvoiceOrgId
        {
            get { return this.Model.InvoiceOrgId; }
            set { this.Model.InvoiceOrgId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INV_EXT_NOTES" field.
        /// </summary>
        public Consensus.Common.Notes InvExtNotes
        {
            get
            {
                if (_invExtNotes == null && this.Model.InvExtNotes != null)
                    _invExtNotes = new Consensus.Common.Notes(this.Model.InvExtNotes);
                if (_invExtNotes == null)
                    _invExtNotes = Consensus.Common.Notes.Create();
                return _invExtNotes;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INV_EXT_NOTES" field.
        /// </summary>
        public System.String InvExtNotesId
        {
            get { return this.Model.InvExtNotesId; }
            set { this.Model.InvExtNotesId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICED" field.
        /// </summary>
        public System.Nullable<System.Byte> Invoiced
        {
            get { return this.Model.Invoiced; }
            set { this.Model.Invoiced = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_FOR_ATTN_OF" field.
        /// </summary>
        public System.String ForAttentionOf
        {
            get { return this.Model.ForAttentionOf; }
            set { this.Model.ForAttentionOf = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_DO_NOT_INVOIC" field.
        /// </summary>
        public System.Nullable<System.Byte> DoNotInvoice
        {
            get { return this.Model.DoNotInvoice; }
            set { this.Model.DoNotInvoice = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_PL_ID" field.
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
        ///     Gets or sets the unique code for the value of the "BOOK_PL_ID" field.
        /// </summary>
        public System.String PriceListId
        {
            get { return this.Model.PriceListId; }
            set { this.Model.PriceListId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_REASON" field.
        /// </summary>
        public Consensus.Common.Code Reason
        {
            get
            {
                if (_reason == null && this.Model.Reason != null)
                    _reason = new Consensus.Common.Code(this.Model.Reason);
                if (_reason == null)
                    _reason = Consensus.Common.Code.Create();
                return _reason;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_REASON" field.
        /// </summary>
        public System.String ReasonCode
        {
            get { return this.Model.ReasonCode; }
            set { this.Model.ReasonCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_PAID" field.
        /// </summary>
        public System.Nullable<System.Byte> Paid
        {
            get { return this.Model.Paid; }
            set { this.Model.Paid = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CANCEL_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> CancelDate
        {
            get { return this.Model.CancelDate; }
            set { this.Model.CancelDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CANCEL_BY" field.
        /// </summary>
        public System.String CancelBy
        {
            get { return this.Model.CancelBy; }
            set { this.Model.CancelBy = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_OPP_ID" field.
        /// </summary>
        public Consensus.Sales.Opportunity Opportunity
        {
            get
            {
                if (_opportunity == null && this.Model.Opportunity != null)
                    _opportunity = new Consensus.Sales.Opportunity(this.Model.Opportunity);
                if (_opportunity == null)
                    _opportunity = Consensus.Sales.Opportunity.Create();
                return _opportunity;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_OPP_ID" field.
        /// </summary>
        public System.String OpportunityId
        {
            get { return this.Model.OpportunityId; }
            set { this.Model.OpportunityId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_DELIV_ADD" field.
        /// </summary>
        public Consensus.Contact.Address DelivAdd
        {
            get
            {
                if (_delivAdd == null && this.Model.DelivAdd != null)
                    _delivAdd = new Consensus.Contact.Address(this.Model.DelivAdd);
                if (_delivAdd == null)
                    _delivAdd = Consensus.Contact.Address.Create();
                return _delivAdd;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_DELIV_ADD" field.
        /// </summary>
        public System.String DelivAddId
        {
            get { return this.Model.DelivAddId; }
            set { this.Model.DelivAddId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_DOCS_METHOD" field.
        /// </summary>
        public Consensus.Common.Code DocsMethod
        {
            get
            {
                if (_docsMethod == null && this.Model.DocsMethod != null)
                    _docsMethod = new Consensus.Common.Code(this.Model.DocsMethod);
                if (_docsMethod == null)
                    _docsMethod = Consensus.Common.Code.Create();
                return _docsMethod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_DOCS_METHOD" field.
        /// </summary>
        public System.String DocsMethodCode
        {
            get { return this.Model.DocsMethodCode; }
            set { this.Model.DocsMethodCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CANC_REASON" field.
        /// </summary>
        public System.String CancReason
        {
            get { return this.Model.CancReason; }
            set { this.Model.CancReason = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CURRENCY_TYPE" field.
        /// </summary>
        public System.String CurrencyType
        {
            get { return this.Model.CurrencyType; }
            set { this.Model.CurrencyType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "BOOK_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_ADD_ID" field.
        /// </summary>
        public Consensus.Contact.Address BookerAddress
        {
            get
            {
                if (_bookerAddress == null && this.Model.BookerAddress != null)
                    _bookerAddress = new Consensus.Contact.Address(this.Model.BookerAddress);
                if (_bookerAddress == null)
                    _bookerAddress = Consensus.Contact.Address.Create();
                return _bookerAddress;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_ADD_ID" field.
        /// </summary>
        public System.String BookerAddressId
        {
            get { return this.Model.BookerAddressId; }
            set { this.Model.BookerAddressId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role BookerRole
        {
            get
            {
                if (_bookerRole == null && this.Model.BookerRole != null)
                    _bookerRole = new Consensus.Contact.Role(this.Model.BookerRole);
                if (_bookerRole == null)
                    _bookerRole = Consensus.Contact.Role.Create();
                return _bookerRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_PROLE_ID" field.
        /// </summary>
        public System.String BookerRoleId
        {
            get { return this.Model.BookerRoleId; }
            set { this.Model.BookerRoleId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_VATCD_OVRRIDE" field.
        /// </summary>
        public System.String VatcdOvrride
        {
            get { return this.Model.VatcdOvrride; }
            set { this.Model.VatcdOvrride = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_ORG_CUST_AC" field.
        /// </summary>
        public System.String InvoiceAccountRef
        {
            get { return this.Model.InvoiceAccountRef; }
            set { this.Model.InvoiceAccountRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_DELIV_FAO" field.
        /// </summary>
        public System.String DelivFao
        {
            get { return this.Model.DelivFao; }
            set { this.Model.DelivFao = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_DELIV_PHONE" field.
        /// </summary>
        public System.String DelivPhone
        {
            get { return this.Model.DelivPhone; }
            set { this.Model.DelivPhone = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INV_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role InvoiceRole
        {
            get
            {
                if (_invoiceRole == null && this.Model.InvoiceRole != null)
                    _invoiceRole = new Consensus.Contact.Role(this.Model.InvoiceRole);
                if (_invoiceRole == null)
                    _invoiceRole = Consensus.Contact.Role.Create();
                return _invoiceRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INV_PROLE_ID" field.
        /// </summary>
        public System.String InvoiceRoleId
        {
            get { return this.Model.InvoiceRoleId; }
            set { this.Model.InvoiceRoleId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_SCHN_ID" field.
        /// </summary>
        public Consensus.Sales.SalesChannel SalesChannel
        {
            get
            {
                if (_salesChannel == null && this.Model.SalesChannel != null)
                    _salesChannel = new Consensus.Sales.SalesChannel(this.Model.SalesChannel);
                if (_salesChannel == null)
                    _salesChannel = Consensus.Sales.SalesChannel.Create();
                return _salesChannel;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_SCHN_ID" field.
        /// </summary>
        public System.String SalesChannelId
        {
            get { return this.Model.SalesChannelId; }
            set { this.Model.SalesChannelId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_RULE" field.
        /// </summary>
        public System.Byte InvoiceRule
        {
            get { return this.Model.InvoiceRule; }
            set { this.Model.InvoiceRule = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_RULE_OFFSET" field.
        /// </summary>
        public System.Int16 InvoiceRuleOffset
        {
            get { return this.Model.InvoiceRuleOffset; }
            set { this.Model.InvoiceRuleOffset = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_DO_NOT_INVOICE_REASON" field.
        /// </summary>
        public System.String DoNotInvoiceReason
        {
            get { return this.Model.DoNotInvoiceReason; }
            set { this.Model.DoNotInvoiceReason = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_OFFSET_TYPE" field.
        /// </summary>
        public System.String InvoiceOffsetType
        {
            get { return this.Model.InvoiceOffsetType; }
            set { this.Model.InvoiceOffsetType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INVOICE_WHEN_STATUS" field.
        /// </summary>
        public Consensus.Common.Code InvoiceWhenStatus
        {
            get
            {
                if (_invoiceWhenStatus == null && this.Model.InvoiceWhenStatus != null)
                    _invoiceWhenStatus = new Consensus.Common.Code(this.Model.InvoiceWhenStatus);
                if (_invoiceWhenStatus == null)
                    _invoiceWhenStatus = Consensus.Common.Code.Create();
                return _invoiceWhenStatus;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INVOICE_WHEN_STATUS" field.
        /// </summary>
        public System.String InvoiceWhenStatusCode
        {
            get { return this.Model.InvoiceWhenStatusCode; }
            set { this.Model.InvoiceWhenStatusCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_MUST_USE_RULE" field.
        /// </summary>
        public System.Byte InvoiceMustUseRule
        {
            get { return this.Model.InvoiceMustUseRule; }
            set { this.Model.InvoiceMustUseRule = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_CONSOLIDATE" field.
        /// </summary>
        public System.Byte InvoiceConsolidate
        {
            get { return this.Model.InvoiceConsolidate; }
            set { this.Model.InvoiceConsolidate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_ACC_ID" field.
        /// </summary>
        public Consensus.Finance.Account Account
        {
            get
            {
                if (_account == null && this.Model.Account != null)
                    _account = new Consensus.Finance.Account(this.Model.Account);
                if (_account == null)
                    _account = Consensus.Finance.Account.Create();
                return _account;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_ACC_ID" field.
        /// </summary>
        public System.String AccountId
        {
            get { return this.Model.AccountId; }
            set { this.Model.AccountId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_RESV_TO_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> ResvToDate
        {
            get { return this.Model.ResvToDate; }
            set { this.Model.ResvToDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_PER_DEL" field.
        /// </summary>
        public System.Byte InvoicePerDel
        {
            get { return this.Model.InvoicePerDel; }
            set { this.Model.InvoicePerDel = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CANCEL_REF" field.
        /// </summary>
        public System.String CancelRef
        {
            get { return this.Model.CancelRef; }
            set { this.Model.CancelRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_PER_PERSON" field.
        /// </summary>
        public System.Byte InvoicePerPerson
        {
            get { return this.Model.InvoicePerPerson; }
            set { this.Model.InvoicePerPerson = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_PROMO_CODE" field.
        /// </summary>
        public System.String PromoCode
        {
            get { return this.Model.PromoCode; }
            set { this.Model.PromoCode = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:BookingModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Learner> Learners
        {
            get
            {
                if (_learners == null)
                    _learners = new ProxyCollection<Consensus.Learning.Learner, Consensus.Learning.ILearnerModel>(this.Model.Learners, model => new Consensus.Learning.Learner(model));
                return _learners;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:BookingModel" />.
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
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:BookingModel" />.
        /// </summary>
        public Collection<Consensus.Finance.Payment> Payments
        {
            get
            {
                if (_payments == null)
                    _payments = new ProxyCollection<Consensus.Finance.Payment, Consensus.Finance.IPaymentModel>(this.Model.Payments, model => new Consensus.Finance.Payment(model));
                return _payments;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:BookingModel" />.
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
        internal Booking(IBookingModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public static Consensus.Learning.Booking GetConfirmedEvents(System.String bookId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.GetConfirmedEvents(site,bookId);
        }

        public static Consensus.Learning.Booking GetConfirmedEvents(ConsensusSite site, System.String bookId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IBookingModel model = provider.Learning.Booking.GetConfirmedEvents(bookId);
            return model == null ? null : new Consensus.Learning.Booking(model);
        }

        public static IEnumerable<Consensus.Learning.Booking> BookingGenerateGrpId(System.String bookId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.BookingGenerateGrpId(site,bookId);
        }

        public static IEnumerable<Consensus.Learning.Booking> BookingGenerateGrpId(ConsensusSite site, System.String bookId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.BookingGenerateGrpId(bookId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        public static IEnumerable<Consensus.Learning.Booking> GetBookingLines(System.String bookId, System.String userLoginId, System.String sellingCompany)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.GetBookingLines(site,bookId,userLoginId,sellingCompany);
        }

        public static IEnumerable<Consensus.Learning.Booking> GetBookingLines(ConsensusSite site, System.String bookId, System.String userLoginId, System.String sellingCompany)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.GetBookingLines(bookId,userLoginId,sellingCompany);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        public static System.Boolean CheckIfBookingAlreadyCancelled(System.String bookId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.CheckIfBookingAlreadyCancelled(site,bookId);
        }

        public static System.Boolean CheckIfBookingAlreadyCancelled(ConsensusSite site, System.String bookId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Learning.Booking.CheckIfBookingAlreadyCancelled(bookId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:BookingModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BookingModel" /> instance.
        /// </returns>
        public static Consensus.Learning.Booking Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:BookingModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BookingModel" /> instance.
        /// </returns>
        public static Consensus.Learning.Booking Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IBookingModel model = provider.Learning.Booking.Create();
            return model == null ? null : new Consensus.Learning.Booking(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BookingModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BookingModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BookingModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BookingModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAll();
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BookingModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BookingModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.Booking FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BookingModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BookingModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.Booking FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IBookingModel model = provider.Learning.Booking.FetchById(id);
            return model == null ? null : new Consensus.Learning.Booking(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Learning.Booking.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="bookerOrgId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="bookerOrgId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByBookerOrgId(System.String bookerOrgId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAllByBookerOrgId(site,bookerOrgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="bookerOrgId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="bookerOrgId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByBookerOrgId(ConsensusSite site, System.String bookerOrgId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAllByBookerOrgId(bookerOrgId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="bookerPersonId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="bookerPersonId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByBookerPersonId(System.String bookerPersonId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAllByBookerPersonId(site,bookerPersonId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="bookerPersonId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="bookerPersonId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByBookerPersonId(ConsensusSite site, System.String bookerPersonId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAllByBookerPersonId(bookerPersonId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="invoiceAddressId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="invoiceAddressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByInvoiceAddressId(System.String invoiceAddressId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAllByInvoiceAddressId(site,invoiceAddressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="invoiceAddressId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="invoiceAddressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByInvoiceAddressId(ConsensusSite site, System.String invoiceAddressId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAllByInvoiceAddressId(invoiceAddressId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="notesId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="notesId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByNotesId(System.String notesId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAllByNotesId(site,notesId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="notesId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="notesId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByNotesId(ConsensusSite site, System.String notesId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAllByNotesId(notesId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="sourceCodeId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="sourceCodeId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllBySourceCodeId(System.String sourceCodeId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAllBySourceCodeId(site,sourceCodeId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="sourceCodeId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="sourceCodeId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllBySourceCodeId(ConsensusSite site, System.String sourceCodeId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAllBySourceCodeId(sourceCodeId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="invoiceOrgId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="invoiceOrgId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByInvoiceOrgId(System.String invoiceOrgId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAllByInvoiceOrgId(site,invoiceOrgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="invoiceOrgId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="invoiceOrgId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByInvoiceOrgId(ConsensusSite site, System.String invoiceOrgId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAllByInvoiceOrgId(invoiceOrgId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="invExtNotesId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="invExtNotesId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByInvExtNotesId(System.String invExtNotesId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAllByInvExtNotesId(site,invExtNotesId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="invExtNotesId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="invExtNotesId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByInvExtNotesId(ConsensusSite site, System.String invExtNotesId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAllByInvExtNotesId(invExtNotesId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="priceListId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="priceListId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByPriceListId(System.String priceListId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAllByPriceListId(site,priceListId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="priceListId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="priceListId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByPriceListId(ConsensusSite site, System.String priceListId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAllByPriceListId(priceListId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByOpportunityId(System.String opportunityId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAllByOpportunityId(site,opportunityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByOpportunityId(ConsensusSite site, System.String opportunityId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAllByOpportunityId(opportunityId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="delivAddId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="delivAddId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByDelivAddId(System.String delivAddId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAllByDelivAddId(site,delivAddId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="delivAddId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="delivAddId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByDelivAddId(ConsensusSite site, System.String delivAddId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAllByDelivAddId(delivAddId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="bookerAddressId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="bookerAddressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByBookerAddressId(System.String bookerAddressId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAllByBookerAddressId(site,bookerAddressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="bookerAddressId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="bookerAddressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByBookerAddressId(ConsensusSite site, System.String bookerAddressId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAllByBookerAddressId(bookerAddressId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="bookerRoleId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="bookerRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByBookerRoleId(System.String bookerRoleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAllByBookerRoleId(site,bookerRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="bookerRoleId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="bookerRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByBookerRoleId(ConsensusSite site, System.String bookerRoleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAllByBookerRoleId(bookerRoleId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="invoiceRoleId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="invoiceRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByInvoiceRoleId(System.String invoiceRoleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAllByInvoiceRoleId(site,invoiceRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="invoiceRoleId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="invoiceRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByInvoiceRoleId(ConsensusSite site, System.String invoiceRoleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAllByInvoiceRoleId(invoiceRoleId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="salesChannelId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="salesChannelId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllBySalesChannelId(System.String salesChannelId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAllBySalesChannelId(site,salesChannelId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="salesChannelId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="salesChannelId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllBySalesChannelId(ConsensusSite site, System.String salesChannelId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAllBySalesChannelId(salesChannelId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByAccountId(System.String accountId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Booking.FetchAllByAccountId(site,accountId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Booking> FetchAllByAccountId(ConsensusSite site, System.String accountId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBookingModel> collection = provider.Learning.Booking.FetchAllByAccountId(accountId);
            return collection.Select(model => new Consensus.Learning.Booking(model));
        }

        #endregion
    }
}
