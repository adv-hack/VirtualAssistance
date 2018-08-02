using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Marketing;

namespace Consensus.Membership
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class MemberPeriod : Proxy<IMemberPeriodModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MemId" /> member.
        /// </summary>
        private Consensus.Membership.Membership _memId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Product" /> member.
        /// </summary>
        private Consensus.Learning.ProductMembership _product;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PayMethod" /> member.
        /// </summary>
        private Consensus.Common.Code _payMethod;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PayStatus" /> member.
        /// </summary>
        private Consensus.Common.Code _payStatus;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="InvOrganisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _invOrganisation;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="InvoiceRole" /> member.
        /// </summary>
        private Consensus.Contact.Role _invoiceRole;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="InvAddress" /> member.
        /// </summary>
        private Consensus.Contact.Address _invAddress;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SourceCode" /> member.
        /// </summary>
        private Consensus.Marketing.Promotion _sourceCode;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="CancelReason" /> member.
        /// </summary>
        private Consensus.Common.Code _cancelReason;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="AppMethod" /> member.
        /// </summary>
        private Consensus.Common.Code _appMethod;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Account" /> member.
        /// </summary>
        private Consensus.Finance.Account _account;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Learners" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Learner, Consensus.Learning.ILearnerModel> _learners;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Payments" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Payment, Consensus.Finance.IPaymentModel> _payments;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="InvHeader" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Invoice, Consensus.Finance.IInvoiceModel> _invHeader;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="DirectDebits" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.DirectDebit, Consensus.Finance.IDirectDebitModel> _directDebits;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PrepayAccounts" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.PrepayAccount, Consensus.Finance.IPrepayAccountModel> _prepayAccounts;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MemberLocations" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberLocation, Consensus.Membership.IMemberLocationModel> _memberLocations;

        #endregion

        #region properties

        public System.Int32 StatusNumber
        {
            get { return this.Model.StatusNumber; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_MEM_ID" field.
        /// </summary>
        public Consensus.Membership.Membership MemId
        {
            get
            {
                if (_memId == null && this.Model.MemId != null)
                    _memId = new Consensus.Membership.Membership(this.Model.MemId);
                if (_memId == null)
                    _memId = Consensus.Membership.Membership.Create();
                return _memId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_MEM_ID" field.
        /// </summary>
        public System.String MemIdId
        {
            get { return this.Model.MemIdId; }
            set { this.Model.MemIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_PROD_ID" field.
        /// </summary>
        public Consensus.Learning.ProductMembership Product
        {
            get
            {
                if (_product == null && this.Model.Product != null)
                    _product = new Consensus.Learning.ProductMembership(this.Model.Product);
                if (_product == null)
                    _product = Consensus.Learning.ProductMembership.Create();
                return _product;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_PROD_ID" field.
        /// </summary>
        public System.String ProductId
        {
            get { return this.Model.ProductId; }
            set { this.Model.ProductId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_MEM_GRADE" field.
        /// </summary>
        public System.String MemGrade
        {
            get { return this.Model.MemGrade; }
            set { this.Model.MemGrade = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_START" field.
        /// </summary>
        public System.Nullable<System.DateTime> Start
        {
            get { return this.Model.Start; }
            set { this.Model.Start = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_END" field.
        /// </summary>
        public System.Nullable<System.DateTime> End
        {
            get { return this.Model.End; }
            set { this.Model.End = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_QTY_1" field.
        /// </summary>
        public System.Nullable<System.Int32> Qty1
        {
            get { return this.Model.Qty1; }
            set { this.Model.Qty1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_QTY_2" field.
        /// </summary>
        public System.Nullable<System.Int32> Qty2
        {
            get { return this.Model.Qty2; }
            set { this.Model.Qty2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_QTY_3" field.
        /// </summary>
        public System.Nullable<System.Int32> Qty3
        {
            get { return this.Model.Qty3; }
            set { this.Model.Qty3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_FEE" field.
        /// </summary>
        public System.Decimal Fee
        {
            get { return this.Model.Fee; }
            set { this.Model.Fee = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_CURRENCY" field.
        /// </summary>
        public System.String Currency
        {
            get { return this.Model.Currency; }
            set { this.Model.Currency = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_PAY_METHOD" field.
        /// </summary>
        public Consensus.Common.Code PayMethod
        {
            get
            {
                if (_payMethod == null && this.Model.PayMethod != null)
                    _payMethod = new Consensus.Common.Code(this.Model.PayMethod);
                if (_payMethod == null)
                    _payMethod = Consensus.Common.Code.Create();
                return _payMethod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_PAY_METHOD" field.
        /// </summary>
        public System.String PayMethodCode
        {
            get { return this.Model.PayMethodCode; }
            set { this.Model.PayMethodCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_PAY_STATUS" field.
        /// </summary>
        public Consensus.Common.Code PayStatus
        {
            get
            {
                if (_payStatus == null && this.Model.PayStatus != null)
                    _payStatus = new Consensus.Common.Code(this.Model.PayStatus);
                if (_payStatus == null)
                    _payStatus = Consensus.Common.Code.Create();
                return _payStatus;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_PAY_STATUS" field.
        /// </summary>
        public System.String PayStatusCode
        {
            get { return this.Model.PayStatusCode; }
            set { this.Model.PayStatusCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_INV_ORG_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation InvOrganisation
        {
            get
            {
                if (_invOrganisation == null && this.Model.InvOrganisation != null)
                    _invOrganisation = new Consensus.Contact.Organisation(this.Model.InvOrganisation);
                if (_invOrganisation == null)
                    _invOrganisation = Consensus.Contact.Organisation.Create();
                return _invOrganisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_INV_ORG_ID" field.
        /// </summary>
        public System.String InvOrganisationId
        {
            get { return this.Model.InvOrganisationId; }
            set { this.Model.InvOrganisationId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_INV_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "MEP_INV_PROLE_ID" field.
        /// </summary>
        public System.String InvoiceRoleId
        {
            get { return this.Model.InvoiceRoleId; }
            set { this.Model.InvoiceRoleId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_INV_ADD_ID" field.
        /// </summary>
        public Consensus.Contact.Address InvAddress
        {
            get
            {
                if (_invAddress == null && this.Model.InvAddress != null)
                    _invAddress = new Consensus.Contact.Address(this.Model.InvAddress);
                if (_invAddress == null)
                    _invAddress = Consensus.Contact.Address.Create();
                return _invAddress;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_INV_ADD_ID" field.
        /// </summary>
        public System.String InvAddressId
        {
            get { return this.Model.InvAddressId; }
            set { this.Model.InvAddressId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_PRICE_LIST_ID" field.
        /// </summary>
        public System.String PriceListId
        {
            get { return this.Model.PriceListId; }
            set { this.Model.PriceListId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_CURRENT" field.
        /// </summary>
        public System.Nullable<System.Byte> Current
        {
            get { return this.Model.Current; }
            set { this.Model.Current = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_PM_ID" field.
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
        ///     Gets or sets the unique code for the value of the "MEP_PM_ID" field.
        /// </summary>
        public System.String SourceCodeId
        {
            get { return this.Model.SourceCodeId; }
            set { this.Model.SourceCodeId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_RENEWED_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> RenewedDate
        {
            get { return this.Model.RenewedDate; }
            set { this.Model.RenewedDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_LAPSED_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> LapsedDate
        {
            get { return this.Model.LapsedDate; }
            set { this.Model.LapsedDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_STATUS" field.
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
        ///     Gets or sets the unique code for the value of the "MEP_STATUS" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "MEP_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_RENEWAL_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> RenewalDate
        {
            get { return this.Model.RenewalDate; }
            set { this.Model.RenewalDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_OLD_MEP_ID" field.
        /// </summary>
        public System.String OldMepId
        {
            get { return this.Model.OldMepId; }
            set { this.Model.OldMepId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_CUST_ORDER_NO" field.
        /// </summary>
        public System.String CustOrderNo
        {
            get { return this.Model.CustOrderNo; }
            set { this.Model.CustOrderNo = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_CANCEL_REASON" field.
        /// </summary>
        public Consensus.Common.Code CancelReason
        {
            get
            {
                if (_cancelReason == null && this.Model.CancelReason != null)
                    _cancelReason = new Consensus.Common.Code(this.Model.CancelReason);
                if (_cancelReason == null)
                    _cancelReason = Consensus.Common.Code.Create();
                return _cancelReason;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_CANCEL_REASON" field.
        /// </summary>
        public System.String CancelReasonCode
        {
            get { return this.Model.CancelReasonCode; }
            set { this.Model.CancelReasonCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_FOR_ATTN_OF" field.
        /// </summary>
        public System.String ForAttnOf
        {
            get { return this.Model.ForAttnOf; }
            set { this.Model.ForAttnOf = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_ORG_CUST_AC" field.
        /// </summary>
        public System.String AccountRef
        {
            get { return this.Model.AccountRef; }
            set { this.Model.AccountRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_CURRENT_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> CurrentDate
        {
            get { return this.Model.CurrentDate; }
            set { this.Model.CurrentDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_LAPSE_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> LapseDate
        {
            get { return this.Model.LapseDate; }
            set { this.Model.LapseDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_INDEM_INSUR_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> IndemInsurDate
        {
            get { return this.Model.IndemInsurDate; }
            set { this.Model.IndemInsurDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_ROLLBACK_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> RollbackDate
        {
            get { return this.Model.RollbackDate; }
            set { this.Model.RollbackDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_APP_METHOD" field.
        /// </summary>
        public Consensus.Common.Code AppMethod
        {
            get
            {
                if (_appMethod == null && this.Model.AppMethod != null)
                    _appMethod = new Consensus.Common.Code(this.Model.AppMethod);
                if (_appMethod == null)
                    _appMethod = Consensus.Common.Code.Create();
                return _appMethod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_APP_METHOD" field.
        /// </summary>
        public System.String AppMethodCode
        {
            get { return this.Model.AppMethodCode; }
            set { this.Model.AppMethodCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_DO_NOT_INVOIC" field.
        /// </summary>
        public System.Nullable<System.Byte> ManualInvoice
        {
            get { return this.Model.ManualInvoice; }
            set { this.Model.ManualInvoice = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_ACC_ID" field.
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
        ///     Gets or sets the unique code for the value of the "MEP_ACC_ID" field.
        /// </summary>
        public System.String AccountId
        {
            get { return this.Model.AccountId; }
            set { this.Model.AccountId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_MEMBERSHIP_NAME" field.
        /// </summary>
        public System.String MembershipName
        {
            get { return this.Model.MembershipName; }
            set { this.Model.MembershipName = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
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
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
        /// </summary>
        [NonSerializedAttribute]
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
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
        /// </summary>
        public Collection<Consensus.Finance.Invoice> InvHeader
        {
            get
            {
                if (_invHeader == null)
                    _invHeader = new ProxyCollection<Consensus.Finance.Invoice, Consensus.Finance.IInvoiceModel>(this.Model.InvHeader, model => new Consensus.Finance.Invoice(model));
                return _invHeader;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:DirectDebitModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
        /// </summary>
        public Collection<Consensus.Finance.DirectDebit> DirectDebits
        {
            get
            {
                if (_directDebits == null)
                    _directDebits = new ProxyCollection<Consensus.Finance.DirectDebit, Consensus.Finance.IDirectDebitModel>(this.Model.DirectDebits, model => new Consensus.Finance.DirectDebit(model));
                return _directDebits;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrepayAccountModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Finance.PrepayAccount> PrepayAccounts
        {
            get
            {
                if (_prepayAccounts == null)
                    _prepayAccounts = new ProxyCollection<Consensus.Finance.PrepayAccount, Consensus.Finance.IPrepayAccountModel>(this.Model.PrepayAccounts, model => new Consensus.Finance.PrepayAccount(model));
                return _prepayAccounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
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
        internal MemberPeriod(IMemberPeriodModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Performs rollback membership on a single <see cref="!:MemberPeriodModel" /> instance.
        ///                     Functionality replicated from the SQL performed in V6.5.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instance to be modified.
        /// </param>
        /// <param name="status">
        ///     The status value which should be set.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instance that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        public static Consensus.Membership.MemberPeriod RollbackMembership(System.String memberPeriodId, System.String status)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberPeriod.RollbackMembership(site,memberPeriodId,status);
        }

        /// <summary>
        ///     Performs rollback membership on a single <see cref="!:MemberPeriodModel" /> instance.
        ///                     Functionality replicated from the SQL performed in V6.5.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instance to be modified.
        /// </param>
        /// <param name="status">
        ///     The status value which should be set.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instance that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        public static Consensus.Membership.MemberPeriod RollbackMembership(ConsensusSite site, System.String memberPeriodId, System.String status)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.IMemberPeriodModel model = provider.Membership.MemberPeriod.RollbackMembership(memberPeriodId,status);
            return model == null ? null : new Consensus.Membership.MemberPeriod(model);
        }

        /// <summary>
        ///     Cancels existing DDs on <see cref="!:MemberPeriodModel" /> instance.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instance to be modified.
        /// </param>
        /// <param name="directDebitId">
        ///     The new Direct Debit Id which identifies the instance which should not be modified.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instance that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        public static Consensus.Membership.MemberPeriod CancelExistingDirectDebits(System.String memberPeriodId, System.String directDebitId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberPeriod.CancelExistingDirectDebits(site,memberPeriodId,directDebitId);
        }

        /// <summary>
        ///     Cancels existing DDs on <see cref="!:MemberPeriodModel" /> instance.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instance to be modified.
        /// </param>
        /// <param name="directDebitId">
        ///     The new Direct Debit Id which identifies the instance which should not be modified.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instance that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        public static Consensus.Membership.MemberPeriod CancelExistingDirectDebits(ConsensusSite site, System.String memberPeriodId, System.String directDebitId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.IMemberPeriodModel model = provider.Membership.MemberPeriod.CancelExistingDirectDebits(memberPeriodId,directDebitId);
            return model == null ? null : new Consensus.Membership.MemberPeriod(model);
        }

        /// <summary>
        ///     Creates a new <see cref="!:MemberPeriodModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MemberPeriodModel" /> instance.
        /// </returns>
        public static Consensus.Membership.MemberPeriod Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberPeriod.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:MemberPeriodModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MemberPeriodModel" /> instance.
        /// </returns>
        public static Consensus.Membership.MemberPeriod Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.IMemberPeriodModel model = provider.Membership.MemberPeriod.Create();
            return model == null ? null : new Consensus.Membership.MemberPeriod(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MemberPeriodModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberPeriod.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MemberPeriodModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberPeriodModel> collection = provider.Membership.MemberPeriod.FetchAll();
            return collection.Select(model => new Consensus.Membership.MemberPeriod(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:MemberPeriodModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MemberPeriodModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Membership.MemberPeriod FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberPeriod.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:MemberPeriodModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MemberPeriodModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Membership.MemberPeriod FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.IMemberPeriodModel model = provider.Membership.MemberPeriod.FetchById(id);
            return model == null ? null : new Consensus.Membership.MemberPeriod(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberPeriod.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Membership.MemberPeriod.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="memIdId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="memIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAllByMemIdId(System.String memIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberPeriod.FetchAllByMemIdId(site,memIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="memIdId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="memIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAllByMemIdId(ConsensusSite site, System.String memIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberPeriodModel> collection = provider.Membership.MemberPeriod.FetchAllByMemIdId(memIdId);
            return collection.Select(model => new Consensus.Membership.MemberPeriod(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAllByProductId(System.String productId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberPeriod.FetchAllByProductId(site,productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAllByProductId(ConsensusSite site, System.String productId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberPeriodModel> collection = provider.Membership.MemberPeriod.FetchAllByProductId(productId);
            return collection.Select(model => new Consensus.Membership.MemberPeriod(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="invOrganisationId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="invOrganisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAllByInvOrganisationId(System.String invOrganisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberPeriod.FetchAllByInvOrganisationId(site,invOrganisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="invOrganisationId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="invOrganisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAllByInvOrganisationId(ConsensusSite site, System.String invOrganisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberPeriodModel> collection = provider.Membership.MemberPeriod.FetchAllByInvOrganisationId(invOrganisationId);
            return collection.Select(model => new Consensus.Membership.MemberPeriod(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="invoiceRoleId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="invoiceRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAllByInvoiceRoleId(System.String invoiceRoleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberPeriod.FetchAllByInvoiceRoleId(site,invoiceRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="invoiceRoleId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="invoiceRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAllByInvoiceRoleId(ConsensusSite site, System.String invoiceRoleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberPeriodModel> collection = provider.Membership.MemberPeriod.FetchAllByInvoiceRoleId(invoiceRoleId);
            return collection.Select(model => new Consensus.Membership.MemberPeriod(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="invAddressId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="invAddressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAllByInvAddressId(System.String invAddressId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberPeriod.FetchAllByInvAddressId(site,invAddressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="invAddressId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="invAddressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAllByInvAddressId(ConsensusSite site, System.String invAddressId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberPeriodModel> collection = provider.Membership.MemberPeriod.FetchAllByInvAddressId(invAddressId);
            return collection.Select(model => new Consensus.Membership.MemberPeriod(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="sourceCodeId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="sourceCodeId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAllBySourceCodeId(System.String sourceCodeId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberPeriod.FetchAllBySourceCodeId(site,sourceCodeId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="sourceCodeId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="sourceCodeId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAllBySourceCodeId(ConsensusSite site, System.String sourceCodeId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberPeriodModel> collection = provider.Membership.MemberPeriod.FetchAllBySourceCodeId(sourceCodeId);
            return collection.Select(model => new Consensus.Membership.MemberPeriod(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberPeriod.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberPeriodModel> collection = provider.Membership.MemberPeriod.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Membership.MemberPeriod(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAllByAccountId(System.String accountId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberPeriod.FetchAllByAccountId(site,accountId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberPeriod> FetchAllByAccountId(ConsensusSite site, System.String accountId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberPeriodModel> collection = provider.Membership.MemberPeriod.FetchAllByAccountId(accountId);
            return collection.Select(model => new Consensus.Membership.MemberPeriod(model));
        }

        #endregion
    }
}
