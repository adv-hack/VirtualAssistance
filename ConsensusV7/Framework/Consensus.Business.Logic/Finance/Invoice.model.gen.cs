using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Document;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="InvheaderRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalInvoiceModel : LocalModel<InvheaderRecord, String>, IInvoiceModel
    {
        #region fields

        /// <summary>
        ///     The value of the "INV_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _organisation;

        /// <summary>
        ///     The value of the "INV_PERSON_ID" field.
        /// </summary>
        private LocalPersonModel _person;

        /// <summary>
        ///     The value of the "INV_SALESMAN_ID" field.
        /// </summary>
        private LocalPersonModel _salesPerson;

        /// <summary>
        ///     The value of the "INV_ADD" field.
        /// </summary>
        private LocalAddressModel _add;

        /// <summary>
        ///     The value of the "INV_CREDIT_NTE_REF" field.
        /// </summary>
        private LocalInvoiceModel _creditNteRef;

        /// <summary>
        ///     The value of the "INV_TYPE" field.
        /// </summary>
        private LocalCodeModel _type;

        /// <summary>
        ///     The value of the "INV_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The value of the "INV_MEP_ID" field.
        /// </summary>
        private LocalMemberPeriodModel _memberPeriod;

        /// <summary>
        ///     The value of the "INV_LT_ID" field.
        /// </summary>
        private LocalPackModel _pack;

        /// <summary>
        ///     The value of the "INV_ACC_ID" field.
        /// </summary>
        private LocalAccountModel _account;

        /// <summary>
        ///     The value of the "INV_SALES_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _salesProleId;

        /// <summary>
        ///     The value of the "INV_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _proleId;

        /// <summary>
        ///     The collection of <see cref="InvoiceModel" /> instances that reference this <see cref="InvoiceModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceModel, IInvoiceModel> _creditNteRefInvoices;

        /// <summary>
        ///     The collection of <see cref="InvoiceLineModel" /> instances that reference this <see cref="InvoiceModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel> _invoiceLines;

        /// <summary>
        ///     The collection of <see cref="PayAllocationModel" /> instances that reference this <see cref="InvoiceModel" />.
        /// </summary>
        private LocalCollection<LocalPayAllocationModel, IPayAllocationModel> _pA_InvId;

        /// <summary>
        ///     The collection of <see cref="PayAllocationModel" /> instances that reference this <see cref="InvoiceModel" />.
        /// </summary>
        private LocalCollection<LocalPayAllocationModel, IPayAllocationModel> _pA_CreditId;

        /// <summary>
        ///     The collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="InvoiceModel" />.
        /// </summary>
        private LocalCollection<LocalMemberLocationModel, IMemberLocationModel> _memberLocations;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<InvheaderRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Finance.Invoice.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<InvheaderRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Finance.Invoice.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<InvheaderRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Finance.Invoice.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BOOK_ID" field.
        /// </summary>
        public String Booking
        {
            get { return this.ModifiedData.BookId; }
            set { this.ModifiedData.BookId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "INV_ORG_ID" field.
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
        ///     Gets the The value of the "INV_PERSON_ID" field.
        /// </summary>
        public LocalPersonModel Person
        {
            get
            {
                if (_person == null && this.PersonId != null)
                    _person = this.Provider.Contact.Person.FetchById(this.PersonId);
                if (_person == null)
                    _person = this.Provider.Contact.Person.Create();
                
                return _person;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_PERSON_ID" field.
        /// </summary>
        public String PersonId
        {
            get { return this.ModifiedData.PersonId; }
            set
            {
                if (this.ModifiedData.PersonId != value)
                     _person = null;
                this.ModifiedData.PersonId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "INV_SALESMAN_ID" field.
        /// </summary>
        public LocalPersonModel SalesPerson
        {
            get
            {
                if (_salesPerson == null && this.SalesPersonId != null)
                    _salesPerson = this.Provider.Contact.Person.FetchById(this.SalesPersonId);
                if (_salesPerson == null)
                    _salesPerson = this.Provider.Contact.Person.Create();
                
                return _salesPerson;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_SALESMAN_ID" field.
        /// </summary>
        public String SalesPersonId
        {
            get { return this.ModifiedData.SalesmanId; }
            set
            {
                if (this.ModifiedData.SalesmanId != value)
                     _salesPerson = null;
                this.ModifiedData.SalesmanId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_CUST_ORDER_NO" field.
        /// </summary>
        public String PurchaseOrderNumber
        {
            get { return this.ModifiedData.CustOrderNo; }
            set { this.ModifiedData.CustOrderNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_REF" field.
        /// </summary>
        public String Reference
        {
            get { return this.ModifiedData.Ref; }
            set { this.ModifiedData.Ref = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_DATE" field.
        /// </summary>
        public DateTime? Date
        {
            get { return this.ModifiedData.Date; }
            set { this.ModifiedData.Date = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_STATUS" field.
        /// </summary>
        public Byte? Status
        {
            get { return this.ModifiedData.Status; }
            set { this.ModifiedData.Status = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_ADD" field.
        /// </summary>
        public LocalAddressModel Add
        {
            get
            {
                if (_add == null && this.AddId != null)
                    _add = this.Provider.Contact.Address.FetchById(this.AddId);
                if (_add == null)
                    _add = this.Provider.Contact.Address.Create();
                
                return _add;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_ADD" field.
        /// </summary>
        public String AddId
        {
            get { return this.ModifiedData.Add; }
            set
            {
                if (this.ModifiedData.Add != value)
                     _add = null;
                this.ModifiedData.Add = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "INV_CREDIT_NTE_REF" field.
        /// </summary>
        public LocalInvoiceModel CreditNteRef
        {
            get
            {
                if (_creditNteRef == null && this.CreditNteRefId != null)
                    _creditNteRef = this.Provider.Finance.Invoice.FetchById(this.CreditNteRefId);
                if (_creditNteRef == null)
                    _creditNteRef = this.Provider.Finance.Invoice.Create();
                
                return _creditNteRef;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_CREDIT_NTE_REF" field.
        /// </summary>
        public String CreditNteRefId
        {
            get { return this.ModifiedData.CreditNteRef; }
            set
            {
                if (this.ModifiedData.CreditNteRef != value)
                     _creditNteRef = null;
                this.ModifiedData.CreditNteRef = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return this.ModifiedData.Notes; }
            set { this.ModifiedData.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_NET_TOTAL" field.
        /// </summary>
        public Decimal NetTotal
        {
            get { return this.ModifiedData.NetTotal; }
            set { this.ModifiedData.NetTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_VAT_TOTAL" field.
        /// </summary>
        public Decimal VatTotal
        {
            get { return this.ModifiedData.VatTotal; }
            set { this.ModifiedData.VatTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_GROSS_TOTAL" field.
        /// </summary>
        public Decimal GrossTotal
        {
            get { return this.ModifiedData.GrossTotal; }
            set { this.ModifiedData.GrossTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_CURRENCY_TYPE" field.
        /// </summary>
        public String Currency
        {
            get { return this.ModifiedData.CurrencyType; }
            set { this.ModifiedData.CurrencyType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_TYPE" field.
        /// </summary>
        public LocalCodeModel Type
        {
            get
            {
                if (_type == null && !String.IsNullOrEmpty(this.TypeCode))
                    _type = this.Provider.Common.Code.FetchByTypeAndCode("INVTY", this.TypeCode);
                if (_type == null)
                    _type = this.Provider.Common.Code.Create("INVTY");
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_TYPE" field.
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
        ///     Gets or sets the value of the "INV_ACCOUNT_TYPE" field.
        /// </summary>
        public String AccountType
        {
            get { return this.ModifiedData.AccountType; }
            set { this.ModifiedData.AccountType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_COURSE_ID" field.
        /// </summary>
        public String CourseId
        {
            get { return this.ModifiedData.CourseId; }
            set { this.ModifiedData.CourseId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_COURSE_NAME" field.
        /// </summary>
        public String CourseName
        {
            get { return this.ModifiedData.CourseName; }
            set { this.ModifiedData.CourseName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_CORS_STRT_DTE" field.
        /// </summary>
        public DateTime? CorsStrtDte
        {
            get { return this.ModifiedData.CorsStrtDte; }
            set { this.ModifiedData.CorsStrtDte = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_CORS_COST_CODE" field.
        /// </summary>
        public String CorsCostCode
        {
            get { return this.ModifiedData.CorsCostCode; }
            set { this.ModifiedData.CorsCostCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BOOK_REF" field.
        /// </summary>
        public String BookRef
        {
            get { return this.ModifiedData.BookRef; }
            set { this.ModifiedData.BookRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BOOKER" field.
        /// </summary>
        public String PersonName
        {
            get { return this.ModifiedData.Booker; }
            set { this.ModifiedData.Booker = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BOOK_ORG_NAME" field.
        /// </summary>
        public String OrganisationName
        {
            get { return this.ModifiedData.BookOrgName; }
            set { this.ModifiedData.BookOrgName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ADD_MAILSTRING" field.
        /// </summary>
        public String AddressMailstring
        {
            get { return this.ModifiedData.AddMailstring; }
            set { this.ModifiedData.AddMailstring = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BK_ORG_CUST_AC" field.
        /// </summary>
        public String ArNo
        {
            get { return this.ModifiedData.BkOrgCustAc; }
            set { this.ModifiedData.BkOrgCustAc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_INV_ORG_NAME" field.
        /// </summary>
        public String OrgName
        {
            get { return this.ModifiedData.InvOrgName; }
            set { this.ModifiedData.InvOrgName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_PERIOD" field.
        /// </summary>
        public String Period
        {
            get { return this.ModifiedData.Period; }
            set { this.ModifiedData.Period = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_DUE_DATE" field.
        /// </summary>
        public DateTime? DueDate
        {
            get { return this.ModifiedData.DueDate; }
            set { this.ModifiedData.DueDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_UNPAID_VAL" field.
        /// </summary>
        public Decimal UnpaidValue
        {
            get { return this.ModifiedData.UnpaidVal; }
            set { this.ModifiedData.UnpaidVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_APP_BY" field.
        /// </summary>
        public String ApprovedBy
        {
            get { return this.ModifiedData.AppBy; }
            set { this.ModifiedData.AppBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_APP_DATE" field.
        /// </summary>
        public DateTime? ApprovedDate
        {
            get { return this.ModifiedData.AppDate; }
            set { this.ModifiedData.AppDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_FOR_ATTN_OF" field.
        /// </summary>
        public String ForTheAttentionOf
        {
            get { return this.ModifiedData.ForAttnOf; }
            set { this.ModifiedData.ForAttnOf = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_PRINTED" field.
        /// </summary>
        public Byte? Printed
        {
            get { return this.ModifiedData.Printed; }
            set { this.ModifiedData.Printed = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "INV_SELCO_SP_ID" field.
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
        ///     Gets the The value of the "INV_MEP_ID" field.
        /// </summary>
        public LocalMemberPeriodModel MemberPeriod
        {
            get
            {
                if (_memberPeriod == null && this.MemberPeriodId != null)
                    _memberPeriod = this.Provider.Membership.MemberPeriod.FetchById(this.MemberPeriodId);
                if (_memberPeriod == null)
                    _memberPeriod = this.Provider.Membership.MemberPeriod.Create();
                
                return _memberPeriod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_MEP_ID" field.
        /// </summary>
        public String MemberPeriodId
        {
            get { return this.ModifiedData.MepId; }
            set
            {
                if (this.ModifiedData.MepId != value)
                     _memberPeriod = null;
                this.ModifiedData.MepId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "INV_LT_ID" field.
        /// </summary>
        public LocalPackModel Pack
        {
            get
            {
                if (_pack == null && this.PackId != null)
                    _pack = this.Provider.Document.Pack.FetchById(this.PackId);
                if (_pack == null)
                    _pack = this.Provider.Document.Pack.Create();
                
                return _pack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_LT_ID" field.
        /// </summary>
        public String PackId
        {
            get { return this.ModifiedData.LtId; }
            set
            {
                if (this.ModifiedData.LtId != value)
                     _pack = null;
                this.ModifiedData.LtId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return this.ModifiedData.Userchar1; }
            set { this.ModifiedData.Userchar1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_STATUS" field.
        /// </summary>
        public String SOPStatus
        {
            get { return this.ModifiedData.AccStatus; }
            set { this.ModifiedData.AccStatus = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_REF" field.
        /// </summary>
        public String SOPRef
        {
            get { return this.ModifiedData.AccRef; }
            set { this.ModifiedData.AccRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_NOTES" field.
        /// </summary>
        public String SOPNotes
        {
            get { return this.ModifiedData.AccNotes; }
            set { this.ModifiedData.AccNotes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_MOD_BY" field.
        /// </summary>
        public String SOPModBy
        {
            get { return this.ModifiedData.AccModBy; }
            set { this.ModifiedData.AccModBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_MOD_DATE" field.
        /// </summary>
        public DateTime? SOPModDate
        {
            get { return this.ModifiedData.AccModDate; }
            set { this.ModifiedData.AccModDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_ACC_ID" field.
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
        ///     Gets or sets the unique code for the value of the "INV_ACC_ID" field.
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
        ///     Gets the The value of the "INV_SALES_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel SalesProleId
        {
            get
            {
                if (_salesProleId == null && this.SalesProleIdId != null)
                    _salesProleId = this.Provider.Contact.Role.FetchById(this.SalesProleIdId);
                if (_salesProleId == null)
                    _salesProleId = this.Provider.Contact.Role.Create();
                
                return _salesProleId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_SALES_PROLE_ID" field.
        /// </summary>
        public String SalesProleIdId
        {
            get { return this.ModifiedData.SalesProleId; }
            set
            {
                if (this.ModifiedData.SalesProleId != value)
                     _salesProleId = null;
                this.ModifiedData.SalesProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "INV_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel ProleId
        {
            get
            {
                if (_proleId == null && this.ProleIdId != null)
                    _proleId = this.Provider.Contact.Role.FetchById(this.ProleIdId);
                if (_proleId == null)
                    _proleId = this.Provider.Contact.Role.Create();
                
                return _proleId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_PROLE_ID" field.
        /// </summary>
        public String ProleIdId
        {
            get { return this.ModifiedData.ProleId; }
            set
            {
                if (this.ModifiedData.ProleId != value)
                     _proleId = null;
                this.ModifiedData.ProleId = value;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceModel" /> instances that reference this <see cref="InvoiceModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceModel, IInvoiceModel> CreditNteRefInvoices
        {
            get
            {
                if (_creditNteRefInvoices == null)
                    _creditNteRefInvoices = new LocalCollection<LocalInvoiceModel, IInvoiceModel>(this.Provider.Finance.Invoice.FetchAllByCreditNteRefId(this.Id));
                
                return _creditNteRefInvoices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceLineModel" /> instances that reference this <see cref="InvoiceModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel> InvoiceLines
        {
            get
            {
                if (_invoiceLines == null)
                    _invoiceLines = new LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel>(this.Provider.Finance.InvoiceLine.FetchAllByInvoiceId(this.Id));
                
                return _invoiceLines;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PayAllocationModel" /> instances that reference this <see cref="InvoiceModel" />.
        /// </summary>
        public LocalCollection<LocalPayAllocationModel, IPayAllocationModel> PA_InvId
        {
            get
            {
                if (_pA_InvId == null)
                    _pA_InvId = new LocalCollection<LocalPayAllocationModel, IPayAllocationModel>(this.Provider.Finance.PayAllocation.FetchAllByInvIdId(this.Id));
                
                return _pA_InvId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PayAllocationModel" /> instances that reference this <see cref="InvoiceModel" />.
        /// </summary>
        public LocalCollection<LocalPayAllocationModel, IPayAllocationModel> PA_CreditId
        {
            get
            {
                if (_pA_CreditId == null)
                    _pA_CreditId = new LocalCollection<LocalPayAllocationModel, IPayAllocationModel>(this.Provider.Finance.PayAllocation.FetchAllByCreditIdId(this.Id));
                
                return _pA_CreditId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="InvoiceModel" />.
        /// </summary>
        public LocalCollection<LocalMemberLocationModel, IMemberLocationModel> MemberLocations
        {
            get
            {
                if (_memberLocations == null)
                    _memberLocations = new LocalCollection<LocalMemberLocationModel, IMemberLocationModel>(this.Provider.Membership.MemberLocation.FetchAllByMailInvIdId(this.Id));
                
                return _memberLocations;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalInvoiceModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalInvoiceModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalInvoiceModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalInvoiceModel(LocalProvider provider, InvheaderRecord record) : base(provider, record)
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
            if (_type != null)
            {
                _type.Save();
                this.ModifiedData.Type = _type.Value1;
            }
            if (_organisation != null)
            {
                _organisation.Save();
                this.ModifiedData.OrgId = _organisation.Id == null && this.ModifiedData.OrgId != null ? "" : _organisation.Id;
            }
            if (_person != null)
            {
                _person.Save();
                this.ModifiedData.PersonId = _person.Id == null && this.ModifiedData.PersonId != null ? "" : _person.Id;
            }
            if (_salesPerson != null)
            {
                _salesPerson.Save();
                this.ModifiedData.SalesmanId = _salesPerson.Id == null && this.ModifiedData.SalesmanId != null ? "" : _salesPerson.Id;
            }
            if (_add != null)
            {
                _add.Save();
                this.ModifiedData.Add = _add.Id == null && this.ModifiedData.Add != null ? "" : _add.Id;
            }
            if (_creditNteRef != null)
            {
                _creditNteRef.Save();
                this.ModifiedData.CreditNteRef = _creditNteRef.Id == null && this.ModifiedData.CreditNteRef != null ? "" : _creditNteRef.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
            }
            if (_memberPeriod != null)
            {
                _memberPeriod.Save();
                this.ModifiedData.MepId = _memberPeriod.Id == null && this.ModifiedData.MepId != null ? "" : _memberPeriod.Id;
            }
            if (_pack != null)
            {
                _pack.Save();
                this.ModifiedData.LtId = _pack.Id == null && this.ModifiedData.LtId != null ? "" : _pack.Id;
            }
            if (_account != null)
            {
                _account.Save();
                this.ModifiedData.AccId = _account.Id == null && this.ModifiedData.AccId != null ? "" : _account.Id;
            }
            if (_salesProleId != null)
            {
                _salesProleId.Save();
                this.ModifiedData.SalesProleId = _salesProleId.Id == null && this.ModifiedData.SalesProleId != null ? "" : _salesProleId.Id;
            }
            if (_proleId != null)
            {
                _proleId.Save();
                this.ModifiedData.ProleId = _proleId.Id == null && this.ModifiedData.ProleId != null ? "" : _proleId.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_creditNteRefInvoices != null)
                _creditNteRefInvoices.Execute(obj => obj.CreditNteRefId = this.Id).Execute(obj => obj.Save());
            if (_invoiceLines != null)
                _invoiceLines.Execute(obj => obj.InvoiceId = this.Id).Execute(obj => obj.Save());
            if (_pA_InvId != null)
                _pA_InvId.Execute(obj => obj.InvIdId = this.Id).Execute(obj => obj.Save());
            if (_pA_CreditId != null)
                _pA_CreditId.Execute(obj => obj.CreditIdId = this.Id).Execute(obj => obj.Save());
            if (_memberLocations != null)
                _memberLocations.Execute(obj => obj.MailInvIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "INV_BOOK_ID" field.
        /// </summary>
        System.String IInvoiceModel.Booking
        {
            get { return this.Booking; }
            set { this.Booking = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IInvoiceModel.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_ORG_ID" field.
        /// </summary>
        System.String IInvoiceModel.OrganisationId
        {
            get { return this.OrganisationId; }
            set { this.OrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_PERSON_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel IInvoiceModel.Person
        {
            get { return this.Person; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_PERSON_ID" field.
        /// </summary>
        System.String IInvoiceModel.PersonId
        {
            get { return this.PersonId; }
            set { this.PersonId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_SALESMAN_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel IInvoiceModel.SalesPerson
        {
            get { return this.SalesPerson; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_SALESMAN_ID" field.
        /// </summary>
        System.String IInvoiceModel.SalesPersonId
        {
            get { return this.SalesPersonId; }
            set { this.SalesPersonId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_CUST_ORDER_NO" field.
        /// </summary>
        System.String IInvoiceModel.PurchaseOrderNumber
        {
            get { return this.PurchaseOrderNumber; }
            set { this.PurchaseOrderNumber = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_REF" field.
        /// </summary>
        System.String IInvoiceModel.Reference
        {
            get { return this.Reference; }
            set { this.Reference = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IInvoiceModel.Date
        {
            get { return this.Date; }
            set { this.Date = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_STATUS" field.
        /// </summary>
        System.Nullable<System.Byte> IInvoiceModel.Status
        {
            get { return this.Status; }
            set { this.Status = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_ADD" field.
        /// </summary>
        Consensus.Contact.IAddressModel IInvoiceModel.Add
        {
            get { return this.Add; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_ADD" field.
        /// </summary>
        System.String IInvoiceModel.AddId
        {
            get { return this.AddId; }
            set { this.AddId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_CREDIT_NTE_REF" field.
        /// </summary>
        Consensus.Finance.IInvoiceModel IInvoiceModel.CreditNteRef
        {
            get { return this.CreditNteRef; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_CREDIT_NTE_REF" field.
        /// </summary>
        System.String IInvoiceModel.CreditNteRefId
        {
            get { return this.CreditNteRefId; }
            set { this.CreditNteRefId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_NOTES" field.
        /// </summary>
        System.String IInvoiceModel.Notes
        {
            get { return this.Notes; }
            set { this.Notes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_NET_TOTAL" field.
        /// </summary>
        System.Decimal IInvoiceModel.NetTotal
        {
            get { return this.NetTotal; }
            set { this.NetTotal = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_VAT_TOTAL" field.
        /// </summary>
        System.Decimal IInvoiceModel.VatTotal
        {
            get { return this.VatTotal; }
            set { this.VatTotal = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_GROSS_TOTAL" field.
        /// </summary>
        System.Decimal IInvoiceModel.GrossTotal
        {
            get { return this.GrossTotal; }
            set { this.GrossTotal = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_CURRENCY_TYPE" field.
        /// </summary>
        System.String IInvoiceModel.Currency
        {
            get { return this.Currency; }
            set { this.Currency = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IInvoiceModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_TYPE" field.
        /// </summary>
        System.String IInvoiceModel.TypeCode
        {
            get { return this.TypeCode; }
            set { this.TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACCOUNT_TYPE" field.
        /// </summary>
        System.String IInvoiceModel.AccountType
        {
            get { return this.AccountType; }
            set { this.AccountType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_COURSE_ID" field.
        /// </summary>
        System.String IInvoiceModel.CourseId
        {
            get { return this.CourseId; }
            set { this.CourseId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_COURSE_NAME" field.
        /// </summary>
        System.String IInvoiceModel.CourseName
        {
            get { return this.CourseName; }
            set { this.CourseName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_CORS_STRT_DTE" field.
        /// </summary>
        System.Nullable<System.DateTime> IInvoiceModel.CorsStrtDte
        {
            get { return this.CorsStrtDte; }
            set { this.CorsStrtDte = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_CORS_COST_CODE" field.
        /// </summary>
        System.String IInvoiceModel.CorsCostCode
        {
            get { return this.CorsCostCode; }
            set { this.CorsCostCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BOOK_REF" field.
        /// </summary>
        System.String IInvoiceModel.BookRef
        {
            get { return this.BookRef; }
            set { this.BookRef = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BOOKER" field.
        /// </summary>
        System.String IInvoiceModel.PersonName
        {
            get { return this.PersonName; }
            set { this.PersonName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BOOK_ORG_NAME" field.
        /// </summary>
        System.String IInvoiceModel.OrganisationName
        {
            get { return this.OrganisationName; }
            set { this.OrganisationName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ADD_MAILSTRING" field.
        /// </summary>
        System.String IInvoiceModel.AddressMailstring
        {
            get { return this.AddressMailstring; }
            set { this.AddressMailstring = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BK_ORG_CUST_AC" field.
        /// </summary>
        System.String IInvoiceModel.ArNo
        {
            get { return this.ArNo; }
            set { this.ArNo = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_INV_ORG_NAME" field.
        /// </summary>
        System.String IInvoiceModel.OrgName
        {
            get { return this.OrgName; }
            set { this.OrgName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_PERIOD" field.
        /// </summary>
        System.String IInvoiceModel.Period
        {
            get { return this.Period; }
            set { this.Period = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_DUE_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IInvoiceModel.DueDate
        {
            get { return this.DueDate; }
            set { this.DueDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_UNPAID_VAL" field.
        /// </summary>
        System.Decimal IInvoiceModel.UnpaidValue
        {
            get { return this.UnpaidValue; }
            set { this.UnpaidValue = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_APP_BY" field.
        /// </summary>
        System.String IInvoiceModel.ApprovedBy
        {
            get { return this.ApprovedBy; }
            set { this.ApprovedBy = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_APP_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IInvoiceModel.ApprovedDate
        {
            get { return this.ApprovedDate; }
            set { this.ApprovedDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_FOR_ATTN_OF" field.
        /// </summary>
        System.String IInvoiceModel.ForTheAttentionOf
        {
            get { return this.ForTheAttentionOf; }
            set { this.ForTheAttentionOf = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_PRINTED" field.
        /// </summary>
        System.Nullable<System.Byte> IInvoiceModel.Printed
        {
            get { return this.Printed; }
            set { this.Printed = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IInvoiceModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_SELCO_SP_ID" field.
        /// </summary>
        System.String IInvoiceModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_MEP_ID" field.
        /// </summary>
        Consensus.Membership.IMemberPeriodModel IInvoiceModel.MemberPeriod
        {
            get { return this.MemberPeriod; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_MEP_ID" field.
        /// </summary>
        System.String IInvoiceModel.MemberPeriodId
        {
            get { return this.MemberPeriodId; }
            set { this.MemberPeriodId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_LT_ID" field.
        /// </summary>
        Consensus.Document.IPackModel IInvoiceModel.Pack
        {
            get { return this.Pack; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_LT_ID" field.
        /// </summary>
        System.String IInvoiceModel.PackId
        {
            get { return this.PackId; }
            set { this.PackId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_USERCHAR_1" field.
        /// </summary>
        System.String IInvoiceModel.Userchar1
        {
            get { return this.Userchar1; }
            set { this.Userchar1 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_STATUS" field.
        /// </summary>
        System.String IInvoiceModel.SOPStatus
        {
            get { return this.SOPStatus; }
            set { this.SOPStatus = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_REF" field.
        /// </summary>
        System.String IInvoiceModel.SOPRef
        {
            get { return this.SOPRef; }
            set { this.SOPRef = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_NOTES" field.
        /// </summary>
        System.String IInvoiceModel.SOPNotes
        {
            get { return this.SOPNotes; }
            set { this.SOPNotes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_MOD_BY" field.
        /// </summary>
        System.String IInvoiceModel.SOPModBy
        {
            get { return this.SOPModBy; }
            set { this.SOPModBy = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_MOD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IInvoiceModel.SOPModDate
        {
            get { return this.SOPModDate; }
            set { this.SOPModDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_ACC_ID" field.
        /// </summary>
        Consensus.Finance.IAccountModel IInvoiceModel.Account
        {
            get { return this.Account; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_ACC_ID" field.
        /// </summary>
        System.String IInvoiceModel.AccountId
        {
            get { return this.AccountId; }
            set { this.AccountId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_SALES_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IInvoiceModel.SalesProleId
        {
            get { return this.SalesProleId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_SALES_PROLE_ID" field.
        /// </summary>
        System.String IInvoiceModel.SalesProleIdId
        {
            get { return this.SalesProleIdId; }
            set { this.SalesProleIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "INV_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IInvoiceModel.ProleId
        {
            get { return this.ProleId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_PROLE_ID" field.
        /// </summary>
        System.String IInvoiceModel.ProleIdId
        {
            get { return this.ProleIdId; }
            set { this.ProleIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:InvoiceModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> IInvoiceModel.CreditNteRefInvoices
        {
            get { return this.CreditNteRefInvoices; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:InvoiceModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceLineModel> IInvoiceModel.InvoiceLines
        {
            get { return this.InvoiceLines; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PayAllocationModel" /> instances that reference this <see cref="!:InvoiceModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPayAllocationModel> IInvoiceModel.PA_InvId
        {
            get { return this.PA_InvId; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PayAllocationModel" /> instances that reference this <see cref="!:InvoiceModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPayAllocationModel> IInvoiceModel.PA_CreditId
        {
            get { return this.PA_CreditId; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:InvoiceModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> IInvoiceModel.MemberLocations
        {
            get { return this.MemberLocations; }
        }

        #endregion
    }
}
