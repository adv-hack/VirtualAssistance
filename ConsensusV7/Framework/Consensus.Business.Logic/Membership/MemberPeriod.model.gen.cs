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
    /// <summary>
    ///     Encapsulates the <see cref="MemberPeriodRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalMemberPeriodModel : LocalModel<MemberPeriodRecord, String>, IMemberPeriodModel
    {
        #region fields

        /// <summary>
        ///     The value of the "MEP_MEM_ID" field.
        /// </summary>
        private LocalMembershipModel _memId;

        /// <summary>
        ///     The value of the "MEP_PROD_ID" field.
        /// </summary>
        private LocalProductMembershipModel _product;

        /// <summary>
        ///     The value of the "MEP_PAY_METHOD" field.
        /// </summary>
        private LocalCodeModel _payMethod;

        /// <summary>
        ///     The value of the "MEP_PAY_STATUS" field.
        /// </summary>
        private LocalCodeModel _payStatus;

        /// <summary>
        ///     The value of the "MEP_INV_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _invOrganisation;

        /// <summary>
        ///     The value of the "MEP_INV_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _invoiceRole;

        /// <summary>
        ///     The value of the "MEP_INV_ADD_ID" field.
        /// </summary>
        private LocalAddressModel _invAddress;

        /// <summary>
        ///     The value of the "MEP_PM_ID" field.
        /// </summary>
        private LocalPromotionModel _sourceCode;

        /// <summary>
        ///     The value of the "MEP_STATUS" field.
        /// </summary>
        private LocalCodeModel _status;

        /// <summary>
        ///     The value of the "MEP_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The value of the "MEP_CANCEL_REASON" field.
        /// </summary>
        private LocalCodeModel _cancelReason;

        /// <summary>
        ///     The value of the "MEP_APP_METHOD" field.
        /// </summary>
        private LocalCodeModel _appMethod;

        /// <summary>
        ///     The value of the "MEP_ACC_ID" field.
        /// </summary>
        private LocalAccountModel _account;

        /// <summary>
        ///     The collection of <see cref="LearnerModel" /> instances that reference this <see cref="MemberPeriodModel" />.
        /// </summary>
        private LocalCollection<LocalLearnerModel, ILearnerModel> _learners;

        /// <summary>
        ///     The collection of <see cref="PaymentModel" /> instances that reference this <see cref="MemberPeriodModel" />.
        /// </summary>
        private LocalCollection<LocalPaymentModel, IPaymentModel> _payments;

        /// <summary>
        ///     The collection of <see cref="InvoiceModel" /> instances that reference this <see cref="MemberPeriodModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceModel, IInvoiceModel> _invHeader;

        /// <summary>
        ///     The collection of <see cref="DirectDebitModel" /> instances that reference this <see cref="MemberPeriodModel" />.
        /// </summary>
        private LocalCollection<LocalDirectDebitModel, IDirectDebitModel> _directDebits;

        /// <summary>
        ///     The collection of <see cref="PrepayAccountModel" /> instances that reference this <see cref="MemberPeriodModel" />.
        /// </summary>
        private LocalCollection<LocalPrepayAccountModel, IPrepayAccountModel> _prepayAccounts;

        /// <summary>
        ///     The collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="MemberPeriodModel" />.
        /// </summary>
        private LocalCollection<LocalMemberLocationModel, IMemberLocationModel> _memberLocations;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<MemberPeriodRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Membership.MemberPeriod.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<MemberPeriodRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Membership.MemberPeriod.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<MemberPeriodRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Membership.MemberPeriod.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_MEM_ID" field.
        /// </summary>
        public LocalMembershipModel MemId
        {
            get
            {
                if (_memId == null && this.MemIdId != null)
                    _memId = this.Provider.Membership.Membership.FetchById(this.MemIdId);
                if (_memId == null)
                    _memId = this.Provider.Membership.Membership.Create();
                
                return _memId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_MEM_ID" field.
        /// </summary>
        public String MemIdId
        {
            get { return this.ModifiedData.MemId; }
            set
            {
                if (this.ModifiedData.MemId != value)
                     _memId = null;
                this.ModifiedData.MemId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_PROD_ID" field.
        /// </summary>
        public LocalProductMembershipModel Product
        {
            get
            {
                if (_product == null && this.ProductId != null)
                    _product = this.Provider.Learning.ProductMembership.FetchById(this.ProductId);
                if (_product == null)
                    _product = this.Provider.Learning.ProductMembership.Create();
                
                return _product;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_PROD_ID" field.
        /// </summary>
        public String ProductId
        {
            get { return this.ModifiedData.ProdId; }
            set
            {
                if (this.ModifiedData.ProdId != value)
                     _product = null;
                this.ModifiedData.ProdId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_MEM_GRADE" field.
        /// </summary>
        public String MemGrade
        {
            get { return this.ModifiedData.MemGrade; }
            set { this.ModifiedData.MemGrade = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_START" field.
        /// </summary>
        public DateTime? Start
        {
            get { return this.ModifiedData.Start; }
            set { this.ModifiedData.Start = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_END" field.
        /// </summary>
        public DateTime? End
        {
            get { return this.ModifiedData.End; }
            set { this.ModifiedData.End = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_QTY_1" field.
        /// </summary>
        public Int32? Qty1
        {
            get { return this.ModifiedData.Qty1; }
            set { this.ModifiedData.Qty1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_QTY_2" field.
        /// </summary>
        public Int32? Qty2
        {
            get { return this.ModifiedData.Qty2; }
            set { this.ModifiedData.Qty2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_QTY_3" field.
        /// </summary>
        public Int32? Qty3
        {
            get { return this.ModifiedData.Qty3; }
            set { this.ModifiedData.Qty3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_FEE" field.
        /// </summary>
        public Decimal Fee
        {
            get { return this.ModifiedData.Fee; }
            set { this.ModifiedData.Fee = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_CURRENCY" field.
        /// </summary>
        public String Currency
        {
            get { return this.ModifiedData.Currency; }
            set { this.ModifiedData.Currency = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_PAY_METHOD" field.
        /// </summary>
        public LocalCodeModel PayMethod
        {
            get
            {
                if (_payMethod == null && !String.IsNullOrEmpty(this.PayMethodCode))
                    _payMethod = this.Provider.Common.Code.FetchByTypeAndCode("MPAYM", this.PayMethodCode);
                if (_payMethod == null)
                    _payMethod = this.Provider.Common.Code.Create("MPAYM");
                return _payMethod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_PAY_METHOD" field.
        /// </summary>
        public String PayMethodCode
        {
            get { return this.ModifiedData.PayMethod; }
            set
            {
                if (this.ModifiedData.PayMethod != value)
                     _payMethod = null;
                this.ModifiedData.PayMethod = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_PAY_STATUS" field.
        /// </summary>
        public LocalCodeModel PayStatus
        {
            get
            {
                if (_payStatus == null && !String.IsNullOrEmpty(this.PayStatusCode))
                    _payStatus = this.Provider.Common.Code.FetchByTypeAndCode("PAYST", this.PayStatusCode);
                if (_payStatus == null)
                    _payStatus = this.Provider.Common.Code.Create("PAYST");
                return _payStatus;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_PAY_STATUS" field.
        /// </summary>
        public String PayStatusCode
        {
            get { return this.ModifiedData.PayStatus; }
            set
            {
                if (this.ModifiedData.PayStatus != value)
                     _payStatus = null;
                this.ModifiedData.PayStatus = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_INV_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel InvOrganisation
        {
            get
            {
                if (_invOrganisation == null && this.InvOrganisationId != null)
                    _invOrganisation = this.Provider.Contact.Organisation.FetchById(this.InvOrganisationId);
                if (_invOrganisation == null)
                    _invOrganisation = this.Provider.Contact.Organisation.Create();
                
                return _invOrganisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_INV_ORG_ID" field.
        /// </summary>
        public String InvOrganisationId
        {
            get { return this.ModifiedData.InvOrgId; }
            set
            {
                if (this.ModifiedData.InvOrgId != value)
                     _invOrganisation = null;
                this.ModifiedData.InvOrgId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_INV_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "MEP_INV_PROLE_ID" field.
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
        ///     Gets the The value of the "MEP_INV_ADD_ID" field.
        /// </summary>
        public LocalAddressModel InvAddress
        {
            get
            {
                if (_invAddress == null && this.InvAddressId != null)
                    _invAddress = this.Provider.Contact.Address.FetchById(this.InvAddressId);
                if (_invAddress == null)
                    _invAddress = this.Provider.Contact.Address.Create();
                
                return _invAddress;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_INV_ADD_ID" field.
        /// </summary>
        public String InvAddressId
        {
            get { return this.ModifiedData.InvAddId; }
            set
            {
                if (this.ModifiedData.InvAddId != value)
                     _invAddress = null;
                this.ModifiedData.InvAddId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_PRICE_LIST_ID" field.
        /// </summary>
        public String PriceListId
        {
            get { return this.ModifiedData.PriceListId; }
            set { this.ModifiedData.PriceListId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_CURRENT" field.
        /// </summary>
        public Byte? Current
        {
            get { return this.ModifiedData.Current; }
            set { this.ModifiedData.Current = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_PM_ID" field.
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
        ///     Gets or sets the unique code for the value of the "MEP_PM_ID" field.
        /// </summary>
        public String SourceCodeId
        {
            get { return this.ModifiedData.PmId; }
            set
            {
                if (this.ModifiedData.PmId != value)
                     _sourceCode = null;
                this.ModifiedData.PmId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_RENEWED_DATE" field.
        /// </summary>
        public DateTime? RenewedDate
        {
            get { return this.ModifiedData.RenewedDate; }
            set { this.ModifiedData.RenewedDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_LAPSED_DATE" field.
        /// </summary>
        public DateTime? LapsedDate
        {
            get { return this.ModifiedData.LapsedDate; }
            set { this.ModifiedData.LapsedDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_STATUS" field.
        /// </summary>
        public LocalCodeModel Status
        {
            get
            {
                if (_status == null && !String.IsNullOrEmpty(this.StatusCode))
                    _status = this.Provider.Common.Code.FetchByTypeAndCode("MSPST", this.StatusCode);
                if (_status == null)
                    _status = this.Provider.Common.Code.Create("MSPST");
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_STATUS" field.
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
        ///     Gets the The value of the "MEP_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "MEP_SELCO_SP_ID" field.
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
        ///     Gets or sets the value of the "MEP_RENEWAL_DATE" field.
        /// </summary>
        public DateTime? RenewalDate
        {
            get { return this.ModifiedData.RenewalDate; }
            set { this.ModifiedData.RenewalDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_OLD_MEP_ID" field.
        /// </summary>
        public String OldMepId
        {
            get { return this.ModifiedData.OldMepId; }
            set { this.ModifiedData.OldMepId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_CUST_ORDER_NO" field.
        /// </summary>
        public String CustOrderNo
        {
            get { return this.ModifiedData.CustOrderNo; }
            set { this.ModifiedData.CustOrderNo = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_CANCEL_REASON" field.
        /// </summary>
        public LocalCodeModel CancelReason
        {
            get
            {
                if (_cancelReason == null && !String.IsNullOrEmpty(this.CancelReasonCode))
                    _cancelReason = this.Provider.Common.Code.FetchByTypeAndCode("MEPCR", this.CancelReasonCode);
                if (_cancelReason == null)
                    _cancelReason = this.Provider.Common.Code.Create("MEPCR");
                return _cancelReason;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_CANCEL_REASON" field.
        /// </summary>
        public String CancelReasonCode
        {
            get { return this.ModifiedData.CancelReason; }
            set
            {
                if (this.ModifiedData.CancelReason != value)
                     _cancelReason = null;
                this.ModifiedData.CancelReason = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_FOR_ATTN_OF" field.
        /// </summary>
        public String ForAttnOf
        {
            get { return this.ModifiedData.ForAttnOf; }
            set { this.ModifiedData.ForAttnOf = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_ORG_CUST_AC" field.
        /// </summary>
        public String AccountRef
        {
            get { return this.ModifiedData.OrgCustAc; }
            set { this.ModifiedData.OrgCustAc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_CURRENT_DATE" field.
        /// </summary>
        public DateTime? CurrentDate
        {
            get { return this.ModifiedData.CurrentDate; }
            set { this.ModifiedData.CurrentDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_LAPSE_DATE" field.
        /// </summary>
        public DateTime? LapseDate
        {
            get { return this.ModifiedData.LapseDate; }
            set { this.ModifiedData.LapseDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_INDEM_INSUR_DATE" field.
        /// </summary>
        public DateTime? IndemInsurDate
        {
            get { return this.ModifiedData.IndemInsurDate; }
            set { this.ModifiedData.IndemInsurDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_ROLLBACK_DATE" field.
        /// </summary>
        public DateTime? RollbackDate
        {
            get { return this.ModifiedData.RollbackDate; }
            set { this.ModifiedData.RollbackDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_APP_METHOD" field.
        /// </summary>
        public LocalCodeModel AppMethod
        {
            get
            {
                if (_appMethod == null && !String.IsNullOrEmpty(this.AppMethodCode))
                    _appMethod = this.Provider.Common.Code.FetchByTypeAndCode("MEMAP", this.AppMethodCode);
                if (_appMethod == null)
                    _appMethod = this.Provider.Common.Code.Create("MEMAP");
                return _appMethod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_APP_METHOD" field.
        /// </summary>
        public String AppMethodCode
        {
            get { return this.ModifiedData.AppMethod; }
            set
            {
                if (this.ModifiedData.AppMethod != value)
                     _appMethod = null;
                this.ModifiedData.AppMethod = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_DO_NOT_INVOIC" field.
        /// </summary>
        public Byte? ManualInvoice
        {
            get { return this.ModifiedData.DoNotInvoic; }
            set { this.ModifiedData.DoNotInvoic = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_ACC_ID" field.
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
        ///     Gets or sets the unique code for the value of the "MEP_ACC_ID" field.
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
        ///     Gets or sets the value of the "MEP_MEMBERSHIP_NAME" field.
        /// </summary>
        public String MembershipName
        {
            get { return this.ModifiedData.MembershipName; }
            set { this.ModifiedData.MembershipName = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LearnerModel" /> instances that reference this <see cref="MemberPeriodModel" />.
        /// </summary>
        public LocalCollection<LocalLearnerModel, ILearnerModel> Learners
        {
            get
            {
                if (_learners == null)
                    _learners = new LocalCollection<LocalLearnerModel, ILearnerModel>(this.Provider.Learning.Learner.FetchAllByMemberPeriodId(this.Id));
                
                return _learners;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PaymentModel" /> instances that reference this <see cref="MemberPeriodModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalPaymentModel, IPaymentModel> Payments
        {
            get
            {
                if (_payments == null)
                    _payments = new LocalCollection<LocalPaymentModel, IPaymentModel>(this.Provider.Finance.Payment.FetchAllByMemberPeriodId(this.Id));
                
                return _payments;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceModel" /> instances that reference this <see cref="MemberPeriodModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceModel, IInvoiceModel> InvHeader
        {
            get
            {
                if (_invHeader == null)
                    _invHeader = new LocalCollection<LocalInvoiceModel, IInvoiceModel>(this.Provider.Finance.Invoice.FetchAllByMemberPeriodId(this.Id));
                
                return _invHeader;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="DirectDebitModel" /> instances that reference this <see cref="MemberPeriodModel" />.
        /// </summary>
        public LocalCollection<LocalDirectDebitModel, IDirectDebitModel> DirectDebits
        {
            get
            {
                if (_directDebits == null)
                    _directDebits = new LocalCollection<LocalDirectDebitModel, IDirectDebitModel>(this.Provider.Finance.DirectDebit.FetchAllByMemberPeriodId(this.Id));
                
                return _directDebits;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PrepayAccountModel" /> instances that reference this <see cref="MemberPeriodModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalPrepayAccountModel, IPrepayAccountModel> PrepayAccounts
        {
            get
            {
                if (_prepayAccounts == null)
                    _prepayAccounts = new LocalCollection<LocalPrepayAccountModel, IPrepayAccountModel>(this.Provider.Finance.PrepayAccount.FetchAllByMembershipId(this.Id));
                
                return _prepayAccounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="MemberPeriodModel" />.
        /// </summary>
        public LocalCollection<LocalMemberLocationModel, IMemberLocationModel> MemberLocations
        {
            get
            {
                if (_memberLocations == null)
                    _memberLocations = new LocalCollection<LocalMemberLocationModel, IMemberLocationModel>(this.Provider.Membership.MemberLocation.FetchAllByMemberPeriodId(this.Id));
                
                return _memberLocations;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalMemberPeriodModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalMemberPeriodModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalMemberPeriodModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalMemberPeriodModel(LocalProvider provider, MemberPeriodRecord record) : base(provider, record)
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
            if (_payMethod != null)
            {
                _payMethod.Save();
                this.ModifiedData.PayMethod = _payMethod.Value1;
            }
            if (_payStatus != null)
            {
                _payStatus.Save();
                this.ModifiedData.PayStatus = _payStatus.Value1;
            }
            if (_status != null)
            {
                _status.Save();
                this.ModifiedData.Status = _status.Value1;
            }
            if (_cancelReason != null)
            {
                _cancelReason.Save();
                this.ModifiedData.CancelReason = _cancelReason.Value1;
            }
            if (_appMethod != null)
            {
                _appMethod.Save();
                this.ModifiedData.AppMethod = _appMethod.Value1;
            }
            if (_memId != null)
            {
                _memId.Save();
                this.ModifiedData.MemId = _memId.Id == null && this.ModifiedData.MemId != null ? "" : _memId.Id;
            }
            if (_product != null)
            {
                _product.Save();
                this.ModifiedData.ProdId = _product.Id == null && this.ModifiedData.ProdId != null ? "" : _product.Id;
            }
            if (_invOrganisation != null)
            {
                _invOrganisation.Save();
                this.ModifiedData.InvOrgId = _invOrganisation.Id == null && this.ModifiedData.InvOrgId != null ? "" : _invOrganisation.Id;
            }
            if (_invoiceRole != null)
            {
                _invoiceRole.Save();
                this.ModifiedData.InvProleId = _invoiceRole.Id == null && this.ModifiedData.InvProleId != null ? "" : _invoiceRole.Id;
            }
            if (_invAddress != null)
            {
                _invAddress.Save();
                this.ModifiedData.InvAddId = _invAddress.Id == null && this.ModifiedData.InvAddId != null ? "" : _invAddress.Id;
            }
            if (_sourceCode != null)
            {
                _sourceCode.Save();
                this.ModifiedData.PmId = _sourceCode.Id == null && this.ModifiedData.PmId != null ? "" : _sourceCode.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
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
                _learners.Execute(obj => obj.MemberPeriodId = this.Id).Execute(obj => obj.Save());
            if (_payments != null)
                _payments.Execute(obj => obj.MemberPeriodId = this.Id).Execute(obj => obj.Save());
            if (_invHeader != null)
                _invHeader.Execute(obj => obj.MemberPeriodId = this.Id).Execute(obj => obj.Save());
            if (_directDebits != null)
                _directDebits.Execute(obj => obj.MemberPeriodId = this.Id).Execute(obj => obj.Save());
            if (_prepayAccounts != null)
                _prepayAccounts.Execute(obj => obj.MembershipId = this.Id).Execute(obj => obj.Save());
            if (_memberLocations != null)
                _memberLocations.Execute(obj => obj.MemberPeriodId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        System.Int32 IMemberPeriodModel.StatusNumber
        {
            get { return this.StatusNumber; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_MEM_ID" field.
        /// </summary>
        Consensus.Membership.IMembershipModel IMemberPeriodModel.MemId
        {
            get { return this.MemId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_MEM_ID" field.
        /// </summary>
        System.String IMemberPeriodModel.MemIdId
        {
            get { return this.MemIdId; }
            set { this.MemIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductMembershipModel IMemberPeriodModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_PROD_ID" field.
        /// </summary>
        System.String IMemberPeriodModel.ProductId
        {
            get { return this.ProductId; }
            set { this.ProductId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_MEM_GRADE" field.
        /// </summary>
        System.String IMemberPeriodModel.MemGrade
        {
            get { return this.MemGrade; }
            set { this.MemGrade = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_START" field.
        /// </summary>
        System.Nullable<System.DateTime> IMemberPeriodModel.Start
        {
            get { return this.Start; }
            set { this.Start = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_END" field.
        /// </summary>
        System.Nullable<System.DateTime> IMemberPeriodModel.End
        {
            get { return this.End; }
            set { this.End = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_QTY_1" field.
        /// </summary>
        System.Nullable<System.Int32> IMemberPeriodModel.Qty1
        {
            get { return this.Qty1; }
            set { this.Qty1 = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_QTY_2" field.
        /// </summary>
        System.Nullable<System.Int32> IMemberPeriodModel.Qty2
        {
            get { return this.Qty2; }
            set { this.Qty2 = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_QTY_3" field.
        /// </summary>
        System.Nullable<System.Int32> IMemberPeriodModel.Qty3
        {
            get { return this.Qty3; }
            set { this.Qty3 = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_FEE" field.
        /// </summary>
        System.Decimal IMemberPeriodModel.Fee
        {
            get { return this.Fee; }
            set { this.Fee = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_CURRENCY" field.
        /// </summary>
        System.String IMemberPeriodModel.Currency
        {
            get { return this.Currency; }
            set { this.Currency = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_PAY_METHOD" field.
        /// </summary>
        Consensus.Common.ICodeModel IMemberPeriodModel.PayMethod
        {
            get { return this.PayMethod; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_PAY_METHOD" field.
        /// </summary>
        System.String IMemberPeriodModel.PayMethodCode
        {
            get { return this.PayMethodCode; }
            set { this.PayMethodCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_PAY_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel IMemberPeriodModel.PayStatus
        {
            get { return this.PayStatus; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_PAY_STATUS" field.
        /// </summary>
        System.String IMemberPeriodModel.PayStatusCode
        {
            get { return this.PayStatusCode; }
            set { this.PayStatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_INV_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IMemberPeriodModel.InvOrganisation
        {
            get { return this.InvOrganisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_INV_ORG_ID" field.
        /// </summary>
        System.String IMemberPeriodModel.InvOrganisationId
        {
            get { return this.InvOrganisationId; }
            set { this.InvOrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_INV_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IMemberPeriodModel.InvoiceRole
        {
            get { return this.InvoiceRole; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_INV_PROLE_ID" field.
        /// </summary>
        System.String IMemberPeriodModel.InvoiceRoleId
        {
            get { return this.InvoiceRoleId; }
            set { this.InvoiceRoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_INV_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel IMemberPeriodModel.InvAddress
        {
            get { return this.InvAddress; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_INV_ADD_ID" field.
        /// </summary>
        System.String IMemberPeriodModel.InvAddressId
        {
            get { return this.InvAddressId; }
            set { this.InvAddressId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_PRICE_LIST_ID" field.
        /// </summary>
        System.String IMemberPeriodModel.PriceListId
        {
            get { return this.PriceListId; }
            set { this.PriceListId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_CURRENT" field.
        /// </summary>
        System.Nullable<System.Byte> IMemberPeriodModel.Current
        {
            get { return this.Current; }
            set { this.Current = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_PM_ID" field.
        /// </summary>
        Consensus.Marketing.IPromotionModel IMemberPeriodModel.SourceCode
        {
            get { return this.SourceCode; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_PM_ID" field.
        /// </summary>
        System.String IMemberPeriodModel.SourceCodeId
        {
            get { return this.SourceCodeId; }
            set { this.SourceCodeId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_RENEWED_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IMemberPeriodModel.RenewedDate
        {
            get { return this.RenewedDate; }
            set { this.RenewedDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_LAPSED_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IMemberPeriodModel.LapsedDate
        {
            get { return this.LapsedDate; }
            set { this.LapsedDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel IMemberPeriodModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_STATUS" field.
        /// </summary>
        System.String IMemberPeriodModel.StatusCode
        {
            get { return this.StatusCode; }
            set { this.StatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IMemberPeriodModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_SELCO_SP_ID" field.
        /// </summary>
        System.String IMemberPeriodModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_RENEWAL_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IMemberPeriodModel.RenewalDate
        {
            get { return this.RenewalDate; }
            set { this.RenewalDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_OLD_MEP_ID" field.
        /// </summary>
        System.String IMemberPeriodModel.OldMepId
        {
            get { return this.OldMepId; }
            set { this.OldMepId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_CUST_ORDER_NO" field.
        /// </summary>
        System.String IMemberPeriodModel.CustOrderNo
        {
            get { return this.CustOrderNo; }
            set { this.CustOrderNo = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_CANCEL_REASON" field.
        /// </summary>
        Consensus.Common.ICodeModel IMemberPeriodModel.CancelReason
        {
            get { return this.CancelReason; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_CANCEL_REASON" field.
        /// </summary>
        System.String IMemberPeriodModel.CancelReasonCode
        {
            get { return this.CancelReasonCode; }
            set { this.CancelReasonCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_FOR_ATTN_OF" field.
        /// </summary>
        System.String IMemberPeriodModel.ForAttnOf
        {
            get { return this.ForAttnOf; }
            set { this.ForAttnOf = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_ORG_CUST_AC" field.
        /// </summary>
        System.String IMemberPeriodModel.AccountRef
        {
            get { return this.AccountRef; }
            set { this.AccountRef = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_CURRENT_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IMemberPeriodModel.CurrentDate
        {
            get { return this.CurrentDate; }
            set { this.CurrentDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_LAPSE_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IMemberPeriodModel.LapseDate
        {
            get { return this.LapseDate; }
            set { this.LapseDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_INDEM_INSUR_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IMemberPeriodModel.IndemInsurDate
        {
            get { return this.IndemInsurDate; }
            set { this.IndemInsurDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_ROLLBACK_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IMemberPeriodModel.RollbackDate
        {
            get { return this.RollbackDate; }
            set { this.RollbackDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_APP_METHOD" field.
        /// </summary>
        Consensus.Common.ICodeModel IMemberPeriodModel.AppMethod
        {
            get { return this.AppMethod; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_APP_METHOD" field.
        /// </summary>
        System.String IMemberPeriodModel.AppMethodCode
        {
            get { return this.AppMethodCode; }
            set { this.AppMethodCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_DO_NOT_INVOIC" field.
        /// </summary>
        System.Nullable<System.Byte> IMemberPeriodModel.ManualInvoice
        {
            get { return this.ManualInvoice; }
            set { this.ManualInvoice = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEP_ACC_ID" field.
        /// </summary>
        Consensus.Finance.IAccountModel IMemberPeriodModel.Account
        {
            get { return this.Account; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_ACC_ID" field.
        /// </summary>
        System.String IMemberPeriodModel.AccountId
        {
            get { return this.AccountId; }
            set { this.AccountId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_MEMBERSHIP_NAME" field.
        /// </summary>
        System.String IMemberPeriodModel.MembershipName
        {
            get { return this.MembershipName; }
            set { this.MembershipName = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ILearnerModel> IMemberPeriodModel.Learners
        {
            get { return this.Learners; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IPaymentModel> IMemberPeriodModel.Payments
        {
            get { return this.Payments; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> IMemberPeriodModel.InvHeader
        {
            get { return this.InvHeader; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:DirectDebitModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IDirectDebitModel> IMemberPeriodModel.DirectDebits
        {
            get { return this.DirectDebits; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrepayAccountModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IPrepayAccountModel> IMemberPeriodModel.PrepayAccounts
        {
            get { return this.PrepayAccounts; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> IMemberPeriodModel.MemberLocations
        {
            get { return this.MemberLocations; }
        }

        #endregion
    }
}
