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
    /// <summary>
    ///     Encapsulates the <see cref="AccountRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalAccountModel : LocalModel<AccountRecord, String>, IAccountModel
    {
        #region fields

        /// <summary>
        ///     The value of the "ACC_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _organisation;

        /// <summary>
        ///     The value of the "ACC_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _role;

        /// <summary>
        ///     The value of the "ACC_ADD_ID" field.
        /// </summary>
        private LocalAddressModel _address;

        /// <summary>
        ///     The value of the "ACC_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingComanpy;

        /// <summary>
        ///     The value of the "ACC_STATUS" field.
        /// </summary>
        private LocalCodeModel _status;

        /// <summary>
        ///     The value of the "ACC_VATCD" field.
        /// </summary>
        private LocalCodeModel _vatcd;

        /// <summary>
        ///     The value of the "ACC_TYPE" field.
        /// </summary>
        private LocalCodeModel _type;

        /// <summary>
        ///     The value of the "ACC_DOCS_METHOD" field.
        /// </summary>
        private LocalCodeModel _docsMethod;

        /// <summary>
        ///     The value of the "ACC_INV_PACK_ID" field.
        /// </summary>
        private LocalPackModel _invPackId;

        /// <summary>
        ///     The collection of <see cref="BookingModel" /> instances that reference this <see cref="AccountModel" />.
        /// </summary>
        private LocalCollection<LocalBookingModel, IBookingModel> _bookings;

        /// <summary>
        ///     The collection of <see cref="AccountXrefModel" /> instances that reference this <see cref="AccountModel" />.
        /// </summary>
        private LocalCollection<LocalAccountXrefModel, IAccountXrefModel> _accountXrefs;

        /// <summary>
        ///     The collection of <see cref="PaymentModel" /> instances that reference this <see cref="AccountModel" />.
        /// </summary>
        private LocalCollection<LocalPaymentModel, IPaymentModel> _payments;

        /// <summary>
        ///     The collection of <see cref="InvoiceModel" /> instances that reference this <see cref="AccountModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceModel, IInvoiceModel> _invoices;

        /// <summary>
        ///     The collection of <see cref="MemberPeriodModel" /> instances that reference this <see cref="AccountModel" />.
        /// </summary>
        private LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel> _memberPeriods;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AccountRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Finance.Account.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AccountRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Finance.Account.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<AccountRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Finance.Account.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_SYSTEM" field.
        /// </summary>
        public String System
        {
            get { return this.ModifiedData.System; }
            set { this.ModifiedData.System = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_SYSTEM_REF" field.
        /// </summary>
        public String ARNumber
        {
            get { return this.ModifiedData.SystemRef; }
            set { this.ModifiedData.SystemRef = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel Organisation
        {
            get
            {
                if (_organisation == null && this.OrganisationId != null)
                    _organisation = this.Provider.Contact.Organisation.FetchById(this.OrganisationId);
                if (_organisation == null)
                    _organisation = this.Provider.Contact.Organisation.Create();
                
                return _organisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_ORG_ID" field.
        /// </summary>
        public String OrganisationId
        {
            get { return this.ModifiedData.OrgId; }
            set
            {
                if (this.ModifiedData.OrgId != value)
                     _organisation = null;
                this.ModifiedData.OrgId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PRINCIPAL" field.
        /// </summary>
        public Byte? Principal
        {
            get { return this.ModifiedData.Principal; }
            set { this.ModifiedData.Principal = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel Role
        {
            get
            {
                if (_role == null && this.RoleId != null)
                    _role = this.Provider.Contact.Role.FetchById(this.RoleId);
                if (_role == null)
                    _role = this.Provider.Contact.Role.Create();
                
                return _role;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_PROLE_ID" field.
        /// </summary>
        public String RoleId
        {
            get { return this.ModifiedData.ProleId; }
            set
            {
                if (this.ModifiedData.ProleId != value)
                     _role = null;
                this.ModifiedData.ProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_ADD_ID" field.
        /// </summary>
        public LocalAddressModel Address
        {
            get
            {
                if (_address == null && this.AddressId != null)
                    _address = this.Provider.Contact.Address.FetchById(this.AddressId);
                if (_address == null)
                    _address = this.Provider.Contact.Address.Create();
                
                return _address;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_ADD_ID" field.
        /// </summary>
        public String AddressId
        {
            get { return this.ModifiedData.AddId; }
            set
            {
                if (this.ModifiedData.AddId != value)
                     _address = null;
                this.ModifiedData.AddId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_SELCO_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SellingComanpy
        {
            get
            {
                if (_sellingComanpy == null && this.SellingComanpyId != null)
                    _sellingComanpy = this.Provider.Common.SellingCompany.FetchById(this.SellingComanpyId);
                if (_sellingComanpy == null)
                    _sellingComanpy = this.Provider.Common.SellingCompany.Create();
                
                return _sellingComanpy;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_SELCO_SP_ID" field.
        /// </summary>
        public String SellingComanpyId
        {
            get { return this.ModifiedData.SelcoSpId; }
            set
            {
                if (this.ModifiedData.SelcoSpId != value)
                     _sellingComanpy = null;
                this.ModifiedData.SelcoSpId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAYMENT_DAYS" field.
        /// </summary>
        public Int32? PaymentDays
        {
            get { return this.ModifiedData.PaymentDays; }
            set { this.ModifiedData.PaymentDays = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_STATUS" field.
        /// </summary>
        public LocalCodeModel Status
        {
            get
            {
                if (_status == null && !String.IsNullOrEmpty(this.StatusCode))
                    _status = this.Provider.Common.Code.FetchByTypeAndCode("ACCST", this.StatusCode);
                if (_status == null)
                    _status = this.Provider.Common.Code.Create("ACCST");
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_STATUS" field.
        /// </summary>
        public String StatusCode
        {
            get { return this.ModifiedData.Status; }
            set
            {
                if (this.ModifiedData.Status != value)
                     _status = null;
                this.ModifiedData.Status = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAYMENT_TYPE" field.
        /// </summary>
        public Byte? PaymentType
        {
            get { return this.ModifiedData.PaymentType; }
            set { this.ModifiedData.PaymentType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAY_TERMS_1" field.
        /// </summary>
        public String PayTerms1
        {
            get { return this.ModifiedData.PayTerms1; }
            set { this.ModifiedData.PayTerms1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAY_TERMS_2" field.
        /// </summary>
        public String PayTerms2
        {
            get { return this.ModifiedData.PayTerms2; }
            set { this.ModifiedData.PayTerms2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAY_TERMS_3" field.
        /// </summary>
        public String PayTerms3
        {
            get { return this.ModifiedData.PayTerms3; }
            set { this.ModifiedData.PayTerms3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAY_TERMS_4" field.
        /// </summary>
        public String PayTerms4
        {
            get { return this.ModifiedData.PayTerms4; }
            set { this.ModifiedData.PayTerms4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_CREDIT" field.
        /// </summary>
        public Decimal Credit
        {
            get { return this.ModifiedData.Credit; }
            set { this.ModifiedData.Credit = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_SPECIAL_TERMS" field.
        /// </summary>
        public String SpecialTerms
        {
            get { return this.ModifiedData.SpecialTerms; }
            set { this.ModifiedData.SpecialTerms = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_VATCD" field.
        /// </summary>
        public LocalCodeModel Vatcd
        {
            get
            {
                if (_vatcd == null && !String.IsNullOrEmpty(this.VatcdCode))
                    _vatcd = this.Provider.Common.Code.FetchByTypeAndCode("Vatcd", this.VatcdCode);
                if (_vatcd == null)
                    _vatcd = this.Provider.Common.Code.Create("Vatcd");
                return _vatcd;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_VATCD" field.
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
        ///     Gets or sets the value of the "ACC_INVOICE_RULE" field.
        /// </summary>
        public Byte InvoiceRule
        {
            get { return this.ModifiedData.InvoiceRule; }
            set { this.ModifiedData.InvoiceRule = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_INVOICE_RULE_OFFSET" field.
        /// </summary>
        public Int16 InvoiceRuleOffset
        {
            get { return this.ModifiedData.InvoiceRuleOffset; }
            set { this.ModifiedData.InvoiceRuleOffset = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_INVOICE_WHEN_STATUS" field.
        /// </summary>
        public String InvoiceWhenStatus
        {
            get { return this.ModifiedData.InvoiceWhenStatus; }
            set { this.ModifiedData.InvoiceWhenStatus = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_NAT_ACCOUNT" field.
        /// </summary>
        public Byte? NatAccount
        {
            get { return this.ModifiedData.NatAccount; }
            set { this.ModifiedData.NatAccount = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_TYPE" field.
        /// </summary>
        public LocalCodeModel Type
        {
            get
            {
                if (_type == null && !String.IsNullOrEmpty(this.TypeCode))
                    _type = this.Provider.Common.Code.FetchByTypeAndCode("ACCTY", this.TypeCode);
                if (_type == null)
                    _type = this.Provider.Common.Code.Create("ACCTY");
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_TYPE" field.
        /// </summary>
        public String TypeCode
        {
            get { return this.ModifiedData.Type; }
            set
            {
                if (this.ModifiedData.Type != value)
                     _type = null;
                this.ModifiedData.Type = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return this.ModifiedData.Title; }
            set { this.ModifiedData.Title = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_DOCS_METHOD" field.
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
        ///     Gets or sets the unique code for the value of the "ACC_DOCS_METHOD" field.
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
        ///     Gets the The value of the "ACC_INV_PACK_ID" field.
        /// </summary>
        public LocalPackModel InvPackId
        {
            get
            {
                if (_invPackId == null && this.InvPackIdId != null)
                    _invPackId = this.Provider.Document.Pack.FetchById(this.InvPackIdId);
                if (_invPackId == null)
                    _invPackId = this.Provider.Document.Pack.Create();
                
                return _invPackId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_INV_PACK_ID" field.
        /// </summary>
        public String InvPackIdId
        {
            get { return this.ModifiedData.InvPackId; }
            set
            {
                if (this.ModifiedData.InvPackId != value)
                     _invPackId = null;
                this.ModifiedData.InvPackId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_REQ_PAYMENT_DAYS" field.
        /// </summary>
        public Int32 ReqPaymentDays
        {
            get { return this.ModifiedData.ReqPaymentDays; }
            set { this.ModifiedData.ReqPaymentDays = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_DEFAULT_INV_STATUS" field.
        /// </summary>
        public Byte? DefaultInvStatus
        {
            get { return this.ModifiedData.DefaultInvStatus; }
            set { this.ModifiedData.DefaultInvStatus = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_CURRENCY_TYPE" field.
        /// </summary>
        public String CurrencyType
        {
            get { return this.ModifiedData.CurrencyType; }
            set { this.ModifiedData.CurrencyType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_VAT_REG_NUM" field.
        /// </summary>
        public String VatRegNum
        {
            get { return this.ModifiedData.VatRegNum; }
            set { this.ModifiedData.VatRegNum = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_MEM_PAYMENT_DAYS" field.
        /// </summary>
        public Int32? MemPaymentDays
        {
            get { return this.ModifiedData.MemPaymentDays; }
            set { this.ModifiedData.MemPaymentDays = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PO_REQ" field.
        /// </summary>
        public Byte? PoReq
        {
            get { return this.ModifiedData.PoReq; }
            set { this.ModifiedData.PoReq = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_DEFAULT" field.
        /// </summary>
        public Byte? Default
        {
            get { return this.ModifiedData.Default; }
            set { this.ModifiedData.Default = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_NAT_ACCOUNT_DATE" field.
        /// </summary>
        public DateTime? NatAccountDate
        {
            get { return this.ModifiedData.NatAccountDate; }
            set { this.ModifiedData.NatAccountDate = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BookingModel" /> instances that reference this <see cref="AccountModel" />.
        /// </summary>
        public LocalCollection<LocalBookingModel, IBookingModel> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new LocalCollection<LocalBookingModel, IBookingModel>(this.Provider.Learning.Booking.FetchAllByAccountId(this.Id));
                
                return _bookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AccountXrefModel" /> instances that reference this <see cref="AccountModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalAccountXrefModel, IAccountXrefModel> AccountXrefs
        {
            get
            {
                if (_accountXrefs == null)
                    _accountXrefs = new LocalCollection<LocalAccountXrefModel, IAccountXrefModel>(this.Provider.Finance.AccountXref.FetchAllByAccountId(this.Id));
                
                return _accountXrefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PaymentModel" /> instances that reference this <see cref="AccountModel" />.
        /// </summary>
        public LocalCollection<LocalPaymentModel, IPaymentModel> Payments
        {
            get
            {
                if (_payments == null)
                    _payments = new LocalCollection<LocalPaymentModel, IPaymentModel>(this.Provider.Finance.Payment.FetchAllByAccountId(this.Id));
                
                return _payments;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceModel" /> instances that reference this <see cref="AccountModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceModel, IInvoiceModel> Invoices
        {
            get
            {
                if (_invoices == null)
                    _invoices = new LocalCollection<LocalInvoiceModel, IInvoiceModel>(this.Provider.Finance.Invoice.FetchAllByAccountId(this.Id));
                
                return _invoices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberPeriodModel" /> instances that reference this <see cref="AccountModel" />.
        /// </summary>
        public LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel> MemberPeriods
        {
            get
            {
                if (_memberPeriods == null)
                    _memberPeriods = new LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel>(this.Provider.Membership.MemberPeriod.FetchAllByAccountId(this.Id));
                
                return _memberPeriods;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalAccountModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalAccountModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalAccountModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalAccountModel(LocalProvider provider, AccountRecord record) : base(provider, record)
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
            if (_status != null)
            {
                _status.Save();
                this.ModifiedData.Status = _status.Value1;
            }
            if (_vatcd != null)
            {
                _vatcd.Save();
                this.ModifiedData.Vatcd = _vatcd.Value1;
            }
            if (_type != null)
            {
                _type.Save();
                this.ModifiedData.Type = _type.Value1;
            }
            if (_docsMethod != null)
            {
                _docsMethod.Save();
                this.ModifiedData.DocsMethod = _docsMethod.Value1;
            }
            if (_organisation != null)
            {
                _organisation.Save();
                this.ModifiedData.OrgId = _organisation.Id == null && this.ModifiedData.OrgId != null ? "" : _organisation.Id;
            }
            if (_role != null)
            {
                _role.Save();
                this.ModifiedData.ProleId = _role.Id == null && this.ModifiedData.ProleId != null ? "" : _role.Id;
            }
            if (_address != null)
            {
                _address.Save();
                this.ModifiedData.AddId = _address.Id == null && this.ModifiedData.AddId != null ? "" : _address.Id;
            }
            if (_sellingComanpy != null)
            {
                _sellingComanpy.Save();
                this.ModifiedData.SelcoSpId = _sellingComanpy.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingComanpy.Id;
            }
            if (_invPackId != null)
            {
                _invPackId.Save();
                this.ModifiedData.InvPackId = _invPackId.Id == null && this.ModifiedData.InvPackId != null ? "" : _invPackId.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_bookings != null)
                _bookings.Execute(obj => obj.AccountId = this.Id).Execute(obj => obj.Save());
            if (_accountXrefs != null)
                _accountXrefs.Execute(obj => obj.AccountId = this.Id).Execute(obj => obj.Save());
            if (_payments != null)
                _payments.Execute(obj => obj.AccountId = this.Id).Execute(obj => obj.Save());
            if (_invoices != null)
                _invoices.Execute(obj => obj.AccountId = this.Id).Execute(obj => obj.Save());
            if (_memberPeriods != null)
                _memberPeriods.Execute(obj => obj.AccountId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "ACC_SYSTEM" field.
        /// </summary>
        System.String IAccountModel.System
        {
            get { return this.System; }
            set { this.System = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_SYSTEM_REF" field.
        /// </summary>
        System.String IAccountModel.ARNumber
        {
            get { return this.ARNumber; }
            set { this.ARNumber = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IAccountModel.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_ORG_ID" field.
        /// </summary>
        System.String IAccountModel.OrganisationId
        {
            get { return this.OrganisationId; }
            set { this.OrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PRINCIPAL" field.
        /// </summary>
        System.Nullable<System.Byte> IAccountModel.Principal
        {
            get { return this.Principal; }
            set { this.Principal = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IAccountModel.Role
        {
            get { return this.Role; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_PROLE_ID" field.
        /// </summary>
        System.String IAccountModel.RoleId
        {
            get { return this.RoleId; }
            set { this.RoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel IAccountModel.Address
        {
            get { return this.Address; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_ADD_ID" field.
        /// </summary>
        System.String IAccountModel.AddressId
        {
            get { return this.AddressId; }
            set { this.AddressId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IAccountModel.SellingComanpy
        {
            get { return this.SellingComanpy; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_SELCO_SP_ID" field.
        /// </summary>
        System.String IAccountModel.SellingComanpyId
        {
            get { return this.SellingComanpyId; }
            set { this.SellingComanpyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAYMENT_DAYS" field.
        /// </summary>
        System.Nullable<System.Int32> IAccountModel.PaymentDays
        {
            get { return this.PaymentDays; }
            set { this.PaymentDays = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel IAccountModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_STATUS" field.
        /// </summary>
        System.String IAccountModel.StatusCode
        {
            get { return this.StatusCode; }
            set { this.StatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAYMENT_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> IAccountModel.PaymentType
        {
            get { return this.PaymentType; }
            set { this.PaymentType = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAY_TERMS_1" field.
        /// </summary>
        System.String IAccountModel.PayTerms1
        {
            get { return this.PayTerms1; }
            set { this.PayTerms1 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAY_TERMS_2" field.
        /// </summary>
        System.String IAccountModel.PayTerms2
        {
            get { return this.PayTerms2; }
            set { this.PayTerms2 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAY_TERMS_3" field.
        /// </summary>
        System.String IAccountModel.PayTerms3
        {
            get { return this.PayTerms3; }
            set { this.PayTerms3 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAY_TERMS_4" field.
        /// </summary>
        System.String IAccountModel.PayTerms4
        {
            get { return this.PayTerms4; }
            set { this.PayTerms4 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_CREDIT" field.
        /// </summary>
        System.Decimal IAccountModel.Credit
        {
            get { return this.Credit; }
            set { this.Credit = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_SPECIAL_TERMS" field.
        /// </summary>
        System.String IAccountModel.SpecialTerms
        {
            get { return this.SpecialTerms; }
            set { this.SpecialTerms = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_VATCD" field.
        /// </summary>
        Consensus.Common.ICodeModel IAccountModel.Vatcd
        {
            get { return this.Vatcd; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_VATCD" field.
        /// </summary>
        System.String IAccountModel.VatcdCode
        {
            get { return this.VatcdCode; }
            set { this.VatcdCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_INVOICE_RULE" field.
        /// </summary>
        System.Byte IAccountModel.InvoiceRule
        {
            get { return this.InvoiceRule; }
            set { this.InvoiceRule = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_INVOICE_RULE_OFFSET" field.
        /// </summary>
        System.Int16 IAccountModel.InvoiceRuleOffset
        {
            get { return this.InvoiceRuleOffset; }
            set { this.InvoiceRuleOffset = (System.Int16)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_INVOICE_WHEN_STATUS" field.
        /// </summary>
        System.String IAccountModel.InvoiceWhenStatus
        {
            get { return this.InvoiceWhenStatus; }
            set { this.InvoiceWhenStatus = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_NAT_ACCOUNT" field.
        /// </summary>
        System.Nullable<System.Byte> IAccountModel.NatAccount
        {
            get { return this.NatAccount; }
            set { this.NatAccount = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IAccountModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_TYPE" field.
        /// </summary>
        System.String IAccountModel.TypeCode
        {
            get { return this.TypeCode; }
            set { this.TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_TITLE" field.
        /// </summary>
        System.String IAccountModel.Title
        {
            get { return this.Title; }
            set { this.Title = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_DOCS_METHOD" field.
        /// </summary>
        Consensus.Common.ICodeModel IAccountModel.DocsMethod
        {
            get { return this.DocsMethod; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_DOCS_METHOD" field.
        /// </summary>
        System.String IAccountModel.DocsMethodCode
        {
            get { return this.DocsMethodCode; }
            set { this.DocsMethodCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACC_INV_PACK_ID" field.
        /// </summary>
        Consensus.Document.IPackModel IAccountModel.InvPackId
        {
            get { return this.InvPackId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_INV_PACK_ID" field.
        /// </summary>
        System.String IAccountModel.InvPackIdId
        {
            get { return this.InvPackIdId; }
            set { this.InvPackIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_REQ_PAYMENT_DAYS" field.
        /// </summary>
        System.Int32 IAccountModel.ReqPaymentDays
        {
            get { return this.ReqPaymentDays; }
            set { this.ReqPaymentDays = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_DEFAULT_INV_STATUS" field.
        /// </summary>
        System.Nullable<System.Byte> IAccountModel.DefaultInvStatus
        {
            get { return this.DefaultInvStatus; }
            set { this.DefaultInvStatus = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_CURRENCY_TYPE" field.
        /// </summary>
        System.String IAccountModel.CurrencyType
        {
            get { return this.CurrencyType; }
            set { this.CurrencyType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_VAT_REG_NUM" field.
        /// </summary>
        System.String IAccountModel.VatRegNum
        {
            get { return this.VatRegNum; }
            set { this.VatRegNum = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_MEM_PAYMENT_DAYS" field.
        /// </summary>
        System.Nullable<System.Int32> IAccountModel.MemPaymentDays
        {
            get { return this.MemPaymentDays; }
            set { this.MemPaymentDays = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PO_REQ" field.
        /// </summary>
        System.Nullable<System.Byte> IAccountModel.PoReq
        {
            get { return this.PoReq; }
            set { this.PoReq = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_DEFAULT" field.
        /// </summary>
        System.Nullable<System.Byte> IAccountModel.Default
        {
            get { return this.Default; }
            set { this.Default = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_NAT_ACCOUNT_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IAccountModel.NatAccountDate
        {
            get { return this.NatAccountDate; }
            set { this.NatAccountDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:AccountModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> IAccountModel.Bookings
        {
            get { return this.Bookings; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountXrefModel" /> instances that reference this <see cref="!:AccountModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountXrefModel> IAccountModel.AccountXrefs
        {
            get { return this.AccountXrefs; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:AccountModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPaymentModel> IAccountModel.Payments
        {
            get { return this.Payments; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:AccountModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> IAccountModel.Invoices
        {
            get { return this.Invoices; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:AccountModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberPeriodModel> IAccountModel.MemberPeriods
        {
            get { return this.MemberPeriods; }
        }

        #endregion
    }
}
