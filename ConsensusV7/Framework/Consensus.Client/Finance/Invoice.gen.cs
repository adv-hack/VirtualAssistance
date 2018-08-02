using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Document;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Invoice : Proxy<IInvoiceModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Person" /> member.
        /// </summary>
        private Consensus.Contact.Person _person;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SalesPerson" /> member.
        /// </summary>
        private Consensus.Contact.Person _salesPerson;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Add" /> member.
        /// </summary>
        private Consensus.Contact.Address _add;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="CreditNteRef" /> member.
        /// </summary>
        private Consensus.Finance.Invoice _creditNteRef;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Type" /> member.
        /// </summary>
        private Consensus.Common.Code _type;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MemberPeriod" /> member.
        /// </summary>
        private Consensus.Membership.MemberPeriod _memberPeriod;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Pack" /> member.
        /// </summary>
        private Consensus.Document.Pack _pack;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Account" /> member.
        /// </summary>
        private Consensus.Finance.Account _account;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SalesProleId" /> member.
        /// </summary>
        private Consensus.Contact.Role _salesProleId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProleId" /> member.
        /// </summary>
        private Consensus.Contact.Role _proleId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CreditNteRefInvoices" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Invoice, Consensus.Finance.IInvoiceModel> _creditNteRefInvoices;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="InvoiceLines" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.InvoiceLine, Consensus.Finance.IInvoiceLineModel> _invoiceLines;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PA_InvId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.PayAllocation, Consensus.Finance.IPayAllocationModel> _pA_InvId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PA_CreditId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.PayAllocation, Consensus.Finance.IPayAllocationModel> _pA_CreditId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MemberLocations" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberLocation, Consensus.Membership.IMemberLocationModel> _memberLocations;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "INV_BOOK_ID" field.
        /// </summary>
        public System.String Booking
        {
            get { return this.Model.Booking; }
            set { this.Model.Booking = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_ORG_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation Organisation
        {
            get
            {
                if (_organisation == null && this.Model.Organisation != null)
                    _organisation = new Consensus.Contact.Organisation(this.Model.Organisation);
                if (_organisation == null)
                    _organisation = Consensus.Contact.Organisation.Create();
                return _organisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_PERSON_ID" field.
        /// </summary>
        public Consensus.Contact.Person Person
        {
            get
            {
                if (_person == null && this.Model.Person != null)
                    _person = new Consensus.Contact.Person(this.Model.Person);
                if (_person == null)
                    _person = Consensus.Contact.Person.Create();
                return _person;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_PERSON_ID" field.
        /// </summary>
        public System.String PersonId
        {
            get { return this.Model.PersonId; }
            set { this.Model.PersonId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_SALESMAN_ID" field.
        /// </summary>
        public Consensus.Contact.Person SalesPerson
        {
            get
            {
                if (_salesPerson == null && this.Model.SalesPerson != null)
                    _salesPerson = new Consensus.Contact.Person(this.Model.SalesPerson);
                if (_salesPerson == null)
                    _salesPerson = Consensus.Contact.Person.Create();
                return _salesPerson;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_SALESMAN_ID" field.
        /// </summary>
        public System.String SalesPersonId
        {
            get { return this.Model.SalesPersonId; }
            set { this.Model.SalesPersonId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_CUST_ORDER_NO" field.
        /// </summary>
        public System.String PurchaseOrderNumber
        {
            get { return this.Model.PurchaseOrderNumber; }
            set { this.Model.PurchaseOrderNumber = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_REF" field.
        /// </summary>
        public System.String Reference
        {
            get { return this.Model.Reference; }
            set { this.Model.Reference = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> Date
        {
            get { return this.Model.Date; }
            set { this.Model.Date = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_STATUS" field.
        /// </summary>
        public System.Nullable<System.Byte> Status
        {
            get { return this.Model.Status; }
            set { this.Model.Status = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_ADD" field.
        /// </summary>
        public Consensus.Contact.Address Add
        {
            get
            {
                if (_add == null && this.Model.Add != null)
                    _add = new Consensus.Contact.Address(this.Model.Add);
                if (_add == null)
                    _add = Consensus.Contact.Address.Create();
                return _add;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_ADD" field.
        /// </summary>
        public System.String AddId
        {
            get { return this.Model.AddId; }
            set { this.Model.AddId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_CREDIT_NTE_REF" field.
        /// </summary>
        public Consensus.Finance.Invoice CreditNteRef
        {
            get
            {
                if (_creditNteRef == null && this.Model.CreditNteRef != null)
                    _creditNteRef = new Consensus.Finance.Invoice(this.Model.CreditNteRef);
                if (_creditNteRef == null)
                    _creditNteRef = Consensus.Finance.Invoice.Create();
                return _creditNteRef;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_CREDIT_NTE_REF" field.
        /// </summary>
        public System.String CreditNteRefId
        {
            get { return this.Model.CreditNteRefId; }
            set { this.Model.CreditNteRefId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_NET_TOTAL" field.
        /// </summary>
        public System.Decimal NetTotal
        {
            get { return this.Model.NetTotal; }
            set { this.Model.NetTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_VAT_TOTAL" field.
        /// </summary>
        public System.Decimal VatTotal
        {
            get { return this.Model.VatTotal; }
            set { this.Model.VatTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_GROSS_TOTAL" field.
        /// </summary>
        public System.Decimal GrossTotal
        {
            get { return this.Model.GrossTotal; }
            set { this.Model.GrossTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_CURRENCY_TYPE" field.
        /// </summary>
        public System.String Currency
        {
            get { return this.Model.Currency; }
            set { this.Model.Currency = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_TYPE" field.
        /// </summary>
        public Consensus.Common.Code Type
        {
            get
            {
                if (_type == null && this.Model.Type != null)
                    _type = new Consensus.Common.Code(this.Model.Type);
                if (_type == null)
                    _type = Consensus.Common.Code.Create();
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_TYPE" field.
        /// </summary>
        public System.String TypeCode
        {
            get { return this.Model.TypeCode; }
            set { this.Model.TypeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACCOUNT_TYPE" field.
        /// </summary>
        public System.String AccountType
        {
            get { return this.Model.AccountType; }
            set { this.Model.AccountType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_COURSE_ID" field.
        /// </summary>
        public System.String CourseId
        {
            get { return this.Model.CourseId; }
            set { this.Model.CourseId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_COURSE_NAME" field.
        /// </summary>
        public System.String CourseName
        {
            get { return this.Model.CourseName; }
            set { this.Model.CourseName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_CORS_STRT_DTE" field.
        /// </summary>
        public System.Nullable<System.DateTime> CorsStrtDte
        {
            get { return this.Model.CorsStrtDte; }
            set { this.Model.CorsStrtDte = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_CORS_COST_CODE" field.
        /// </summary>
        public System.String CorsCostCode
        {
            get { return this.Model.CorsCostCode; }
            set { this.Model.CorsCostCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BOOK_REF" field.
        /// </summary>
        public System.String BookRef
        {
            get { return this.Model.BookRef; }
            set { this.Model.BookRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BOOKER" field.
        /// </summary>
        public System.String PersonName
        {
            get { return this.Model.PersonName; }
            set { this.Model.PersonName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BOOK_ORG_NAME" field.
        /// </summary>
        public System.String OrganisationName
        {
            get { return this.Model.OrganisationName; }
            set { this.Model.OrganisationName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ADD_MAILSTRING" field.
        /// </summary>
        public System.String AddressMailstring
        {
            get { return this.Model.AddressMailstring; }
            set { this.Model.AddressMailstring = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BK_ORG_CUST_AC" field.
        /// </summary>
        public System.String ArNo
        {
            get { return this.Model.ArNo; }
            set { this.Model.ArNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_INV_ORG_NAME" field.
        /// </summary>
        public System.String OrgName
        {
            get { return this.Model.OrgName; }
            set { this.Model.OrgName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_PERIOD" field.
        /// </summary>
        public System.String Period
        {
            get { return this.Model.Period; }
            set { this.Model.Period = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_DUE_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> DueDate
        {
            get { return this.Model.DueDate; }
            set { this.Model.DueDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_UNPAID_VAL" field.
        /// </summary>
        public System.Decimal UnpaidValue
        {
            get { return this.Model.UnpaidValue; }
            set { this.Model.UnpaidValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_APP_BY" field.
        /// </summary>
        public System.String ApprovedBy
        {
            get { return this.Model.ApprovedBy; }
            set { this.Model.ApprovedBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_APP_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> ApprovedDate
        {
            get { return this.Model.ApprovedDate; }
            set { this.Model.ApprovedDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_FOR_ATTN_OF" field.
        /// </summary>
        public System.String ForTheAttentionOf
        {
            get { return this.Model.ForTheAttentionOf; }
            set { this.Model.ForTheAttentionOf = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_PRINTED" field.
        /// </summary>
        public System.Nullable<System.Byte> Printed
        {
            get { return this.Model.Printed; }
            set { this.Model.Printed = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "INV_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_MEP_ID" field.
        /// </summary>
        public Consensus.Membership.MemberPeriod MemberPeriod
        {
            get
            {
                if (_memberPeriod == null && this.Model.MemberPeriod != null)
                    _memberPeriod = new Consensus.Membership.MemberPeriod(this.Model.MemberPeriod);
                if (_memberPeriod == null)
                    _memberPeriod = Consensus.Membership.MemberPeriod.Create();
                return _memberPeriod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_MEP_ID" field.
        /// </summary>
        public System.String MemberPeriodId
        {
            get { return this.Model.MemberPeriodId; }
            set { this.Model.MemberPeriodId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_LT_ID" field.
        /// </summary>
        public Consensus.Document.Pack Pack
        {
            get
            {
                if (_pack == null && this.Model.Pack != null)
                    _pack = new Consensus.Document.Pack(this.Model.Pack);
                if (_pack == null)
                    _pack = Consensus.Document.Pack.Create();
                return _pack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_LT_ID" field.
        /// </summary>
        public System.String PackId
        {
            get { return this.Model.PackId; }
            set { this.Model.PackId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_USERCHAR_1" field.
        /// </summary>
        public System.String Userchar1
        {
            get { return this.Model.Userchar1; }
            set { this.Model.Userchar1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_STATUS" field.
        /// </summary>
        public System.String SOPStatus
        {
            get { return this.Model.SOPStatus; }
            set { this.Model.SOPStatus = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_REF" field.
        /// </summary>
        public System.String SOPRef
        {
            get { return this.Model.SOPRef; }
            set { this.Model.SOPRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_NOTES" field.
        /// </summary>
        public System.String SOPNotes
        {
            get { return this.Model.SOPNotes; }
            set { this.Model.SOPNotes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_MOD_BY" field.
        /// </summary>
        public System.String SOPModBy
        {
            get { return this.Model.SOPModBy; }
            set { this.Model.SOPModBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_MOD_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> SOPModDate
        {
            get { return this.Model.SOPModDate; }
            set { this.Model.SOPModDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_ACC_ID" field.
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
        ///     Gets or sets the unique code for the value of the "INV_ACC_ID" field.
        /// </summary>
        public System.String AccountId
        {
            get { return this.Model.AccountId; }
            set { this.Model.AccountId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_SALES_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role SalesProleId
        {
            get
            {
                if (_salesProleId == null && this.Model.SalesProleId != null)
                    _salesProleId = new Consensus.Contact.Role(this.Model.SalesProleId);
                if (_salesProleId == null)
                    _salesProleId = Consensus.Contact.Role.Create();
                return _salesProleId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_SALES_PROLE_ID" field.
        /// </summary>
        public System.String SalesProleIdId
        {
            get { return this.Model.SalesProleIdId; }
            set { this.Model.SalesProleIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role ProleId
        {
            get
            {
                if (_proleId == null && this.Model.ProleId != null)
                    _proleId = new Consensus.Contact.Role(this.Model.ProleId);
                if (_proleId == null)
                    _proleId = Consensus.Contact.Role.Create();
                return _proleId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_PROLE_ID" field.
        /// </summary>
        public System.String ProleIdId
        {
            get { return this.Model.ProleIdId; }
            set { this.Model.ProleIdId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:InvoiceModel" />.
        /// </summary>
        public Collection<Consensus.Finance.Invoice> CreditNteRefInvoices
        {
            get
            {
                if (_creditNteRefInvoices == null)
                    _creditNteRefInvoices = new ProxyCollection<Consensus.Finance.Invoice, Consensus.Finance.IInvoiceModel>(this.Model.CreditNteRefInvoices, model => new Consensus.Finance.Invoice(model));
                return _creditNteRefInvoices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:InvoiceModel" />.
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

        /// <summary>
        ///     Gets the collection of <see cref="!:PayAllocationModel" /> instances that reference this <see cref="!:InvoiceModel" />.
        /// </summary>
        public Collection<Consensus.Finance.PayAllocation> PA_InvId
        {
            get
            {
                if (_pA_InvId == null)
                    _pA_InvId = new ProxyCollection<Consensus.Finance.PayAllocation, Consensus.Finance.IPayAllocationModel>(this.Model.PA_InvId, model => new Consensus.Finance.PayAllocation(model));
                return _pA_InvId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PayAllocationModel" /> instances that reference this <see cref="!:InvoiceModel" />.
        /// </summary>
        public Collection<Consensus.Finance.PayAllocation> PA_CreditId
        {
            get
            {
                if (_pA_CreditId == null)
                    _pA_CreditId = new ProxyCollection<Consensus.Finance.PayAllocation, Consensus.Finance.IPayAllocationModel>(this.Model.PA_CreditId, model => new Consensus.Finance.PayAllocation(model));
                return _pA_CreditId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:InvoiceModel" />.
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
        internal Invoice(IInvoiceModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public static System.Boolean CheckIfInvoiceCredited(System.String invId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.CheckIfInvoiceCredited(site,invId);
        }

        public static System.Boolean CheckIfInvoiceCredited(ConsensusSite site, System.String invId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.Invoice.CheckIfInvoiceCredited(invId);
        }

        public static IEnumerable<Consensus.Finance.Invoice> CreditInvoice(System.String invId, System.String userloginId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.CreditInvoice(site,invId,userloginId);
        }

        public static IEnumerable<Consensus.Finance.Invoice> CreditInvoice(ConsensusSite site, System.String invId, System.String userloginId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceModel> collection = provider.Finance.Invoice.CreditInvoice(invId,userloginId);
            return collection.Select(model => new Consensus.Finance.Invoice(model));
        }

        /// <summary>
        ///     Creates a new <see cref="!:InvoiceModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:InvoiceModel" /> instance.
        /// </returns>
        public static Consensus.Finance.Invoice Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:InvoiceModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:InvoiceModel" /> instance.
        /// </returns>
        public static Consensus.Finance.Invoice Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IInvoiceModel model = provider.Finance.Invoice.Create();
            return model == null ? null : new Consensus.Finance.Invoice(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:InvoiceModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:InvoiceModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:InvoiceModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:InvoiceModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceModel> collection = provider.Finance.Invoice.FetchAll();
            return collection.Select(model => new Consensus.Finance.Invoice(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:InvoiceModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:InvoiceModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.Invoice FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:InvoiceModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:InvoiceModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.Invoice FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IInvoiceModel model = provider.Finance.Invoice.FetchById(id);
            return model == null ? null : new Consensus.Finance.Invoice(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.Invoice.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceModel> collection = provider.Finance.Invoice.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Finance.Invoice(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllByPersonId(System.String personId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.FetchAllByPersonId(site,personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllByPersonId(ConsensusSite site, System.String personId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceModel> collection = provider.Finance.Invoice.FetchAllByPersonId(personId);
            return collection.Select(model => new Consensus.Finance.Invoice(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="salesPersonId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="salesPersonId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllBySalesPersonId(System.String salesPersonId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.FetchAllBySalesPersonId(site,salesPersonId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="salesPersonId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="salesPersonId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllBySalesPersonId(ConsensusSite site, System.String salesPersonId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceModel> collection = provider.Finance.Invoice.FetchAllBySalesPersonId(salesPersonId);
            return collection.Select(model => new Consensus.Finance.Invoice(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllByAddId(System.String addId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.FetchAllByAddId(site,addId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllByAddId(ConsensusSite site, System.String addId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceModel> collection = provider.Finance.Invoice.FetchAllByAddId(addId);
            return collection.Select(model => new Consensus.Finance.Invoice(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="creditNteRefId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="creditNteRefId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllByCreditNteRefId(System.String creditNteRefId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.FetchAllByCreditNteRefId(site,creditNteRefId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="creditNteRefId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="creditNteRefId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllByCreditNteRefId(ConsensusSite site, System.String creditNteRefId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceModel> collection = provider.Finance.Invoice.FetchAllByCreditNteRefId(creditNteRefId);
            return collection.Select(model => new Consensus.Finance.Invoice(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceModel> collection = provider.Finance.Invoice.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Finance.Invoice(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllByMemberPeriodId(System.String memberPeriodId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.FetchAllByMemberPeriodId(site,memberPeriodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllByMemberPeriodId(ConsensusSite site, System.String memberPeriodId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceModel> collection = provider.Finance.Invoice.FetchAllByMemberPeriodId(memberPeriodId);
            return collection.Select(model => new Consensus.Finance.Invoice(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllByPackId(System.String packId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.FetchAllByPackId(site,packId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllByPackId(ConsensusSite site, System.String packId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceModel> collection = provider.Finance.Invoice.FetchAllByPackId(packId);
            return collection.Select(model => new Consensus.Finance.Invoice(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllByAccountId(System.String accountId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.FetchAllByAccountId(site,accountId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllByAccountId(ConsensusSite site, System.String accountId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceModel> collection = provider.Finance.Invoice.FetchAllByAccountId(accountId);
            return collection.Select(model => new Consensus.Finance.Invoice(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="salesProleIdId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="salesProleIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllBySalesProleIdId(System.String salesProleIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.FetchAllBySalesProleIdId(site,salesProleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="salesProleIdId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="salesProleIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllBySalesProleIdId(ConsensusSite site, System.String salesProleIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceModel> collection = provider.Finance.Invoice.FetchAllBySalesProleIdId(salesProleIdId);
            return collection.Select(model => new Consensus.Finance.Invoice(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllByProleIdId(System.String proleIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Invoice.FetchAllByProleIdId(site,proleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Invoice> FetchAllByProleIdId(ConsensusSite site, System.String proleIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IInvoiceModel> collection = provider.Finance.Invoice.FetchAllByProleIdId(proleIdId);
            return collection.Select(model => new Consensus.Finance.Invoice(model));
        }

        #endregion
    }
}
