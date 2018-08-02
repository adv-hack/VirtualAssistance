using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Document;
using Consensus.Learning;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Account : Proxy<IAccountModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Role" /> member.
        /// </summary>
        private Consensus.Contact.Role _role;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Address" /> member.
        /// </summary>
        private Consensus.Contact.Address _address;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingComanpy" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingComanpy;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Vatcd" /> member.
        /// </summary>
        private Consensus.Common.Code _vatcd;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Type" /> member.
        /// </summary>
        private Consensus.Common.Code _type;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="DocsMethod" /> member.
        /// </summary>
        private Consensus.Common.Code _docsMethod;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="InvPackId" /> member.
        /// </summary>
        private Consensus.Document.Pack _invPackId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Bookings" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel> _bookings;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="AccountXrefs" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.AccountXref, Consensus.Finance.IAccountXrefModel> _accountXrefs;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Payments" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Payment, Consensus.Finance.IPaymentModel> _payments;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Invoices" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Invoice, Consensus.Finance.IInvoiceModel> _invoices;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MemberPeriods" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberPeriod, Consensus.Membership.IMemberPeriodModel> _memberPeriods;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "ACC_SYSTEM" field.
        /// </summary>
        public System.String System
        {
            get { return this.Model.System; }
            set { this.Model.System = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_SYSTEM_REF" field.
        /// </summary>
        public System.String ARNumber
        {
            get { return this.Model.ARNumber; }
            set { this.Model.ARNumber = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ACC_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PRINCIPAL" field.
        /// </summary>
        public System.Nullable<System.Byte> Principal
        {
            get { return this.Model.Principal; }
            set { this.Model.Principal = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role Role
        {
            get
            {
                if (_role == null && this.Model.Role != null)
                    _role = new Consensus.Contact.Role(this.Model.Role);
                if (_role == null)
                    _role = Consensus.Contact.Role.Create();
                return _role;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_PROLE_ID" field.
        /// </summary>
        public System.String RoleId
        {
            get { return this.Model.RoleId; }
            set { this.Model.RoleId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_ADD_ID" field.
        /// </summary>
        public Consensus.Contact.Address Address
        {
            get
            {
                if (_address == null && this.Model.Address != null)
                    _address = new Consensus.Contact.Address(this.Model.Address);
                if (_address == null)
                    _address = Consensus.Contact.Address.Create();
                return _address;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_ADD_ID" field.
        /// </summary>
        public System.String AddressId
        {
            get { return this.Model.AddressId; }
            set { this.Model.AddressId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_SELCO_SP_ID" field.
        /// </summary>
        public Consensus.Common.SellingCompany SellingComanpy
        {
            get
            {
                if (_sellingComanpy == null && this.Model.SellingComanpy != null)
                    _sellingComanpy = new Consensus.Common.SellingCompany(this.Model.SellingComanpy);
                if (_sellingComanpy == null)
                    _sellingComanpy = Consensus.Common.SellingCompany.Create();
                return _sellingComanpy;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingComanpyId
        {
            get { return this.Model.SellingComanpyId; }
            set { this.Model.SellingComanpyId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAYMENT_DAYS" field.
        /// </summary>
        public System.Nullable<System.Int32> PaymentDays
        {
            get { return this.Model.PaymentDays; }
            set { this.Model.PaymentDays = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_STATUS" field.
        /// </summary>
        public Consensus.Common.Code Status
        {
            get
            {
                if (_status == null && this.Model.Status != null)
                    _status = new Consensus.Common.Code(this.Model.Status);
                if (_status == null)
                    _status = Consensus.Common.Code.Create();
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_STATUS" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAYMENT_TYPE" field.
        /// </summary>
        public System.Nullable<System.Byte> PaymentType
        {
            get { return this.Model.PaymentType; }
            set { this.Model.PaymentType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAY_TERMS_1" field.
        /// </summary>
        public System.String PayTerms1
        {
            get { return this.Model.PayTerms1; }
            set { this.Model.PayTerms1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAY_TERMS_2" field.
        /// </summary>
        public System.String PayTerms2
        {
            get { return this.Model.PayTerms2; }
            set { this.Model.PayTerms2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAY_TERMS_3" field.
        /// </summary>
        public System.String PayTerms3
        {
            get { return this.Model.PayTerms3; }
            set { this.Model.PayTerms3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAY_TERMS_4" field.
        /// </summary>
        public System.String PayTerms4
        {
            get { return this.Model.PayTerms4; }
            set { this.Model.PayTerms4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_CREDIT" field.
        /// </summary>
        public System.Decimal Credit
        {
            get { return this.Model.Credit; }
            set { this.Model.Credit = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_SPECIAL_TERMS" field.
        /// </summary>
        public System.String SpecialTerms
        {
            get { return this.Model.SpecialTerms; }
            set { this.Model.SpecialTerms = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_VATCD" field.
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
        ///     Gets or sets the unique code for the value of the "ACC_VATCD" field.
        /// </summary>
        public System.String VatcdCode
        {
            get { return this.Model.VatcdCode; }
            set { this.Model.VatcdCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_INVOICE_RULE" field.
        /// </summary>
        public System.Byte InvoiceRule
        {
            get { return this.Model.InvoiceRule; }
            set { this.Model.InvoiceRule = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_INVOICE_RULE_OFFSET" field.
        /// </summary>
        public System.Int16 InvoiceRuleOffset
        {
            get { return this.Model.InvoiceRuleOffset; }
            set { this.Model.InvoiceRuleOffset = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_INVOICE_WHEN_STATUS" field.
        /// </summary>
        public System.String InvoiceWhenStatus
        {
            get { return this.Model.InvoiceWhenStatus; }
            set { this.Model.InvoiceWhenStatus = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_NAT_ACCOUNT" field.
        /// </summary>
        public System.Nullable<System.Byte> NatAccount
        {
            get { return this.Model.NatAccount; }
            set { this.Model.NatAccount = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_TYPE" field.
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
        ///     Gets or sets the unique code for the value of the "ACC_TYPE" field.
        /// </summary>
        public System.String TypeCode
        {
            get { return this.Model.TypeCode; }
            set { this.Model.TypeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_TITLE" field.
        /// </summary>
        public System.String Title
        {
            get { return this.Model.Title; }
            set { this.Model.Title = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_DOCS_METHOD" field.
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
        ///     Gets or sets the unique code for the value of the "ACC_DOCS_METHOD" field.
        /// </summary>
        public System.String DocsMethodCode
        {
            get { return this.Model.DocsMethodCode; }
            set { this.Model.DocsMethodCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_INV_PACK_ID" field.
        /// </summary>
        public Consensus.Document.Pack InvPackId
        {
            get
            {
                if (_invPackId == null && this.Model.InvPackId != null)
                    _invPackId = new Consensus.Document.Pack(this.Model.InvPackId);
                if (_invPackId == null)
                    _invPackId = Consensus.Document.Pack.Create();
                return _invPackId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_INV_PACK_ID" field.
        /// </summary>
        public System.String InvPackIdId
        {
            get { return this.Model.InvPackIdId; }
            set { this.Model.InvPackIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_REQ_PAYMENT_DAYS" field.
        /// </summary>
        public System.Int32 ReqPaymentDays
        {
            get { return this.Model.ReqPaymentDays; }
            set { this.Model.ReqPaymentDays = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_DEFAULT_INV_STATUS" field.
        /// </summary>
        public System.Nullable<System.Byte> DefaultInvStatus
        {
            get { return this.Model.DefaultInvStatus; }
            set { this.Model.DefaultInvStatus = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_CURRENCY_TYPE" field.
        /// </summary>
        public System.String CurrencyType
        {
            get { return this.Model.CurrencyType; }
            set { this.Model.CurrencyType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_VAT_REG_NUM" field.
        /// </summary>
        public System.String VatRegNum
        {
            get { return this.Model.VatRegNum; }
            set { this.Model.VatRegNum = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_MEM_PAYMENT_DAYS" field.
        /// </summary>
        public System.Nullable<System.Int32> MemPaymentDays
        {
            get { return this.Model.MemPaymentDays; }
            set { this.Model.MemPaymentDays = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PO_REQ" field.
        /// </summary>
        public System.Nullable<System.Byte> PoReq
        {
            get { return this.Model.PoReq; }
            set { this.Model.PoReq = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_DEFAULT" field.
        /// </summary>
        public System.Nullable<System.Byte> Default
        {
            get { return this.Model.Default; }
            set { this.Model.Default = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_NAT_ACCOUNT_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> NatAccountDate
        {
            get { return this.Model.NatAccountDate; }
            set { this.Model.NatAccountDate = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:AccountModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Booking> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel>(this.Model.Bookings, model => new Consensus.Learning.Booking(model));
                return _bookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountXrefModel" /> instances that reference this <see cref="!:AccountModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Finance.AccountXref> AccountXrefs
        {
            get
            {
                if (_accountXrefs == null)
                    _accountXrefs = new ProxyCollection<Consensus.Finance.AccountXref, Consensus.Finance.IAccountXrefModel>(this.Model.AccountXrefs, model => new Consensus.Finance.AccountXref(model));
                return _accountXrefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:AccountModel" />.
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
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:AccountModel" />.
        /// </summary>
        public Collection<Consensus.Finance.Invoice> Invoices
        {
            get
            {
                if (_invoices == null)
                    _invoices = new ProxyCollection<Consensus.Finance.Invoice, Consensus.Finance.IInvoiceModel>(this.Model.Invoices, model => new Consensus.Finance.Invoice(model));
                return _invoices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:AccountModel" />.
        /// </summary>
        public Collection<Consensus.Membership.MemberPeriod> MemberPeriods
        {
            get
            {
                if (_memberPeriods == null)
                    _memberPeriods = new ProxyCollection<Consensus.Membership.MemberPeriod, Consensus.Membership.IMemberPeriodModel>(this.Model.MemberPeriods, model => new Consensus.Membership.MemberPeriod(model));
                return _memberPeriods;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Account(IAccountModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a specific <see cref="!:AccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instance that matches the specified <paramref name="roleId" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Account> FetchByXrefRoleIdandOrgId(System.String roleId, System.String orgId, System.String spId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Account.FetchByXrefRoleIdandOrgId(site,roleId,orgId,spId);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instance that matches the specified <paramref name="roleId" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Account> FetchByXrefRoleIdandOrgId(ConsensusSite site, System.String roleId, System.String orgId, System.String spId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IAccountModel> collection = provider.Finance.Account.FetchByXrefRoleIdandOrgId(roleId,orgId,spId);
            return collection.Select(model => new Consensus.Finance.Account(model));
        }

        /// <summary>
        ///     Checks if ARNumber exist.
        /// </summary>
        /// <param name="arNumber">
        ///     ARNumber of Account.
        /// </param>
        /// <param name="sellingCompId">
        ///     Id of Selling Company.
        /// </param>
        /// <param name="accountId">
        ///     Id of the Account.
        /// </param>
        /// <returns>
        ///     Whether ARNumber exist in database.
        /// </returns>
        public static System.Boolean CheckIfARNumberExist(System.String arNumber, System.String sellingCompId, System.String accountId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Account.CheckIfARNumberExist(site,arNumber,sellingCompId,accountId);
        }

        /// <summary>
        ///     Checks if ARNumber exist.
        /// </summary>
        /// <param name="arNumber">
        ///     ARNumber of Account.
        /// </param>
        /// <param name="sellingCompId">
        ///     Id of Selling Company.
        /// </param>
        /// <param name="accountId">
        ///     Id of the Account.
        /// </param>
        /// <returns>
        ///     Whether ARNumber exist in database.
        /// </returns>
        public static System.Boolean CheckIfARNumberExist(ConsensusSite site, System.String arNumber, System.String sellingCompId, System.String accountId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.Account.CheckIfARNumberExist(arNumber,sellingCompId,accountId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:AccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AccountModel" /> instance.
        /// </returns>
        public static Consensus.Finance.Account Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Account.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:AccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AccountModel" /> instance.
        /// </returns>
        public static Consensus.Finance.Account Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IAccountModel model = provider.Finance.Account.Create();
            return model == null ? null : new Consensus.Finance.Account(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AccountModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AccountModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Account> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Account.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AccountModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AccountModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Account> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IAccountModel> collection = provider.Finance.Account.FetchAll();
            return collection.Select(model => new Consensus.Finance.Account(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AccountModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AccountModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.Account FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Account.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AccountModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AccountModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.Account FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IAccountModel model = provider.Finance.Account.FetchById(id);
            return model == null ? null : new Consensus.Finance.Account(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Account.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.Account.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Account> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Account.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Account> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IAccountModel> collection = provider.Finance.Account.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Finance.Account(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Account> FetchAllByRoleId(System.String roleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Account.FetchAllByRoleId(site,roleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Account> FetchAllByRoleId(ConsensusSite site, System.String roleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IAccountModel> collection = provider.Finance.Account.FetchAllByRoleId(roleId);
            return collection.Select(model => new Consensus.Finance.Account(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Account> FetchAllByAddressId(System.String addressId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Account.FetchAllByAddressId(site,addressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Account> FetchAllByAddressId(ConsensusSite site, System.String addressId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IAccountModel> collection = provider.Finance.Account.FetchAllByAddressId(addressId);
            return collection.Select(model => new Consensus.Finance.Account(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="sellingComanpyId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="sellingComanpyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Account> FetchAllBySellingComanpyId(System.String sellingComanpyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Account.FetchAllBySellingComanpyId(site,sellingComanpyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="sellingComanpyId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="sellingComanpyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Account> FetchAllBySellingComanpyId(ConsensusSite site, System.String sellingComanpyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IAccountModel> collection = provider.Finance.Account.FetchAllBySellingComanpyId(sellingComanpyId);
            return collection.Select(model => new Consensus.Finance.Account(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="invPackIdId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="invPackIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Account> FetchAllByInvPackIdId(System.String invPackIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Account.FetchAllByInvPackIdId(site,invPackIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="invPackIdId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="invPackIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Account> FetchAllByInvPackIdId(ConsensusSite site, System.String invPackIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IAccountModel> collection = provider.Finance.Account.FetchAllByInvPackIdId(invPackIdId);
            return collection.Select(model => new Consensus.Finance.Account(model));
        }

        #endregion
    }
}
