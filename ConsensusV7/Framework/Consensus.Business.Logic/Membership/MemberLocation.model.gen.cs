using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;
using Consensus.Finance;
using Consensus.Learning;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="MemberLocationRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalMemberLocationModel : LocalModel<MemberLocationRecord, String>, IMemberLocationModel
    {
        #region fields

        /// <summary>
        ///     The value of the "MEL_MEM_ID" field.
        /// </summary>
        private LocalMembershipModel _membership;

        /// <summary>
        ///     The value of the "MEL_MEP_ID" field.
        /// </summary>
        private LocalMemberPeriodModel _memberPeriod;

        /// <summary>
        ///     The value of the "MEL_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _orgId;

        /// <summary>
        ///     The value of the "MEL_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _role;

        /// <summary>
        ///     The value of the "MEL_MAIL_ADD_ID" field.
        /// </summary>
        private LocalAddressModel _mailAddId;

        /// <summary>
        ///     The value of the "MEL_MAIL_INV_ID" field.
        /// </summary>
        private LocalInvoiceModel _mailInvId;

        /// <summary>
        ///     The value of the "MEL_INVLN_ID" field.
        /// </summary>
        private LocalInvoiceLineModel _invlnId;

        /// <summary>
        ///     The value of the "MEL_PROD_ID" field.
        /// </summary>
        private LocalProductMembershipModel _product;

        /// <summary>
        ///     The value of the "MEL_PL_ID" field.
        /// </summary>
        private LocalPriceListModel _plId;

        /// <summary>
        ///     The collection of <see cref="InvoiceLineModel" /> instances that reference this <see cref="MemberLocationModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel> _invoiceLines;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<MemberLocationRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Membership.MemberLocation.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<MemberLocationRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Membership.MemberLocation.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<MemberLocationRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Membership.MemberLocation.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_MEM_ID" field.
        /// </summary>
        public LocalMembershipModel Membership
        {
            get
            {
                if (_membership == null && this.MembershipId != null)
                    _membership = this.Provider.Membership.Membership.FetchById(this.MembershipId);
                if (_membership == null)
                    _membership = this.Provider.Membership.Membership.Create();
                
                return _membership;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_MEM_ID" field.
        /// </summary>
        public String MembershipId
        {
            get { return this.ModifiedData.MemId; }
            set
            {
                if (this.ModifiedData.MemId != value)
                     _membership = null;
                this.ModifiedData.MemId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_MEP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "MEL_MEP_ID" field.
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
        ///     Gets or sets the value of the "MEL_START" field.
        /// </summary>
        public DateTime? Start
        {
            get { return this.ModifiedData.Start; }
            set { this.ModifiedData.Start = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_END" field.
        /// </summary>
        public DateTime? End
        {
            get { return this.ModifiedData.End; }
            set { this.ModifiedData.End = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_STATUS" field.
        /// </summary>
        public Int32? Status
        {
            get { return this.ModifiedData.Status; }
            set { this.ModifiedData.Status = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_TYPE" field.
        /// </summary>
        public Int32? Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_FEE" field.
        /// </summary>
        public Decimal Fee
        {
            get { return this.ModifiedData.Fee; }
            set { this.ModifiedData.Fee = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CURRENCY" field.
        /// </summary>
        public String Currency
        {
            get { return this.ModifiedData.Currency; }
            set { this.ModifiedData.Currency = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel OrgId
        {
            get
            {
                if (_orgId == null && this.OrgIdId != null)
                    _orgId = this.Provider.Contact.Organisation.FetchById(this.OrgIdId);
                if (_orgId == null)
                    _orgId = this.Provider.Contact.Organisation.Create();
                
                return _orgId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_ORG_ID" field.
        /// </summary>
        public String OrgIdId
        {
            get { return this.ModifiedData.OrgId; }
            set
            {
                if (this.ModifiedData.OrgId != value)
                     _orgId = null;
                this.ModifiedData.OrgId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "MEL_PROLE_ID" field.
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
        ///     Gets the The value of the "MEL_MAIL_ADD_ID" field.
        /// </summary>
        public LocalAddressModel MailAddId
        {
            get
            {
                if (_mailAddId == null && this.MailAddIdId != null)
                    _mailAddId = this.Provider.Contact.Address.FetchById(this.MailAddIdId);
                if (_mailAddId == null)
                    _mailAddId = this.Provider.Contact.Address.Create();
                
                return _mailAddId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_MAIL_ADD_ID" field.
        /// </summary>
        public String MailAddIdId
        {
            get { return this.ModifiedData.MailAddId; }
            set
            {
                if (this.ModifiedData.MailAddId != value)
                     _mailAddId = null;
                this.ModifiedData.MailAddId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_MAIL_INV_ID" field.
        /// </summary>
        public LocalInvoiceModel MailInvId
        {
            get
            {
                if (_mailInvId == null && this.MailInvIdId != null)
                    _mailInvId = this.Provider.Finance.Invoice.FetchById(this.MailInvIdId);
                if (_mailInvId == null)
                    _mailInvId = this.Provider.Finance.Invoice.Create();
                
                return _mailInvId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_MAIL_INV_ID" field.
        /// </summary>
        public String MailInvIdId
        {
            get { return this.ModifiedData.MailInvId; }
            set
            {
                if (this.ModifiedData.MailInvId != value)
                     _mailInvId = null;
                this.ModifiedData.MailInvId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_RENEW_LOC" field.
        /// </summary>
        public Byte? RenewLoc
        {
            get { return this.ModifiedData.RenewLoc; }
            set { this.ModifiedData.RenewLoc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_PRINCIPAL" field.
        /// </summary>
        public Byte? Principal
        {
            get { return this.ModifiedData.Principal; }
            set { this.ModifiedData.Principal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_VATCD" field.
        /// </summary>
        public String Vatcd
        {
            get { return this.ModifiedData.Vatcd; }
            set { this.ModifiedData.Vatcd = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_REF" field.
        /// </summary>
        public String Ref
        {
            get { return this.ModifiedData.Ref; }
            set { this.ModifiedData.Ref = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_VAT_RATE" field.
        /// </summary>
        public Decimal VatRate
        {
            get { return this.ModifiedData.VatRate; }
            set { this.ModifiedData.VatRate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_VAT_AMT" field.
        /// </summary>
        public Decimal VatAmt
        {
            get { return this.ModifiedData.VatAmt; }
            set { this.ModifiedData.VatAmt = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_INVLN_ID" field.
        /// </summary>
        public LocalInvoiceLineModel InvlnId
        {
            get
            {
                if (_invlnId == null && this.InvlnIdId != null)
                    _invlnId = this.Provider.Finance.InvoiceLine.FetchById(this.InvlnIdId);
                if (_invlnId == null)
                    _invlnId = this.Provider.Finance.InvoiceLine.Create();
                
                return _invlnId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_INVLN_ID" field.
        /// </summary>
        public String InvlnIdId
        {
            get { return this.ModifiedData.InvlnId; }
            set
            {
                if (this.ModifiedData.InvlnId != value)
                     _invlnId = null;
                this.ModifiedData.InvlnId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_INVOICED" field.
        /// </summary>
        public Byte? Invoiced
        {
            get { return this.ModifiedData.Invoiced; }
            set { this.ModifiedData.Invoiced = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_SY_TYPE" field.
        /// </summary>
        public Byte SyType
        {
            get { return this.ModifiedData.SyType; }
            set { this.ModifiedData.SyType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_PROD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "MEL_PROD_ID" field.
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
        ///     Gets or sets the value of the "MEL_CURRENT" field.
        /// </summary>
        public Byte Current
        {
            get { return this.ModifiedData.Current; }
            set { this.ModifiedData.Current = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_GROSS_FEE" field.
        /// </summary>
        public Decimal GrossFee
        {
            get { return this.ModifiedData.GrossFee; }
            set { this.ModifiedData.GrossFee = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISC_REASON" field.
        /// </summary>
        public String DiscReason
        {
            get { return this.ModifiedData.DiscReason; }
            set { this.ModifiedData.DiscReason = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_FEE_EXEMPT" field.
        /// </summary>
        public Byte FeeExempt
        {
            get { return this.ModifiedData.FeeExempt; }
            set { this.ModifiedData.FeeExempt = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CURRENT_DATE" field.
        /// </summary>
        public DateTime? CurrentDate
        {
            get { return this.ModifiedData.CurrentDate; }
            set { this.ModifiedData.CurrentDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CANCEL_DATE" field.
        /// </summary>
        public DateTime? CancelDate
        {
            get { return this.ModifiedData.CancelDate; }
            set { this.ModifiedData.CancelDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_PL_ID" field.
        /// </summary>
        public LocalPriceListModel PlId
        {
            get
            {
                if (_plId == null && this.PlIdId != null)
                    _plId = this.Provider.Finance.PriceList.FetchById(this.PlIdId);
                if (_plId == null)
                    _plId = this.Provider.Finance.PriceList.Create();
                
                return _plId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_PL_ID" field.
        /// </summary>
        public String PlIdId
        {
            get { return this.ModifiedData.PlId; }
            set
            {
                if (this.ModifiedData.PlId != value)
                     _plId = null;
                this.ModifiedData.PlId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISC_ID" field.
        /// </summary>
        public Int32? DiscId
        {
            get { return this.ModifiedData.DiscId; }
            set { this.ModifiedData.DiscId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISCOUNT" field.
        /// </summary>
        public Decimal? Discount
        {
            get { return this.ModifiedData.Discount; }
            set { this.ModifiedData.Discount = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_LIST_PRICE" field.
        /// </summary>
        public Decimal? ListPrice
        {
            get { return this.ModifiedData.ListPrice; }
            set { this.ModifiedData.ListPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_PO_NUMBER" field.
        /// </summary>
        public String PoNumber
        {
            get { return this.ModifiedData.PoNumber; }
            set { this.ModifiedData.PoNumber = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_QTY" field.
        /// </summary>
        public Int32? Qty
        {
            get { return this.ModifiedData.Qty; }
            set { this.ModifiedData.Qty = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DO_NOT_RENEW" field.
        /// </summary>
        public Byte? DoNotRenew
        {
            get { return this.ModifiedData.DoNotRenew; }
            set { this.ModifiedData.DoNotRenew = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CANCEL_REASON" field.
        /// </summary>
        public String CancelReason
        {
            get { return this.ModifiedData.CancelReason; }
            set { this.ModifiedData.CancelReason = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_UNT_PRICE" field.
        /// </summary>
        public Decimal? UntPrice
        {
            get { return this.ModifiedData.UntPrice; }
            set { this.ModifiedData.UntPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISC_RENEWAL" field.
        /// </summary>
        public DateTime? DiscRenewal
        {
            get { return this.ModifiedData.DiscRenewal; }
            set { this.ModifiedData.DiscRenewal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_PRICE_MODIFIED" field.
        /// </summary>
        public Byte PriceModified
        {
            get { return this.ModifiedData.PriceModified; }
            set { this.ModifiedData.PriceModified = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISC_PERCENT" field.
        /// </summary>
        public Decimal? DiscPercent
        {
            get { return this.ModifiedData.DiscPercent; }
            set { this.ModifiedData.DiscPercent = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_REV_CODE" field.
        /// </summary>
        public String RevCode
        {
            get { return this.ModifiedData.RevCode; }
            set { this.ModifiedData.RevCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return this.ModifiedData.CostCode; }
            set { this.ModifiedData.CostCode = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceLineModel" /> instances that reference this <see cref="MemberLocationModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel> InvoiceLines
        {
            get
            {
                if (_invoiceLines == null)
                    _invoiceLines = new LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel>(this.Provider.Finance.InvoiceLine.FetchAllByMelIdId(this.Id));
                
                return _invoiceLines;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalMemberLocationModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalMemberLocationModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalMemberLocationModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalMemberLocationModel(LocalProvider provider, MemberLocationRecord record) : base(provider, record)
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
            if (_membership != null)
            {
                _membership.Save();
                this.ModifiedData.MemId = _membership.Id == null && this.ModifiedData.MemId != null ? "" : _membership.Id;
            }
            if (_memberPeriod != null)
            {
                _memberPeriod.Save();
                this.ModifiedData.MepId = _memberPeriod.Id == null && this.ModifiedData.MepId != null ? "" : _memberPeriod.Id;
            }
            if (_orgId != null)
            {
                _orgId.Save();
                this.ModifiedData.OrgId = _orgId.Id == null && this.ModifiedData.OrgId != null ? "" : _orgId.Id;
            }
            if (_role != null)
            {
                _role.Save();
                this.ModifiedData.ProleId = _role.Id == null && this.ModifiedData.ProleId != null ? "" : _role.Id;
            }
            if (_mailAddId != null)
            {
                _mailAddId.Save();
                this.ModifiedData.MailAddId = _mailAddId.Id == null && this.ModifiedData.MailAddId != null ? "" : _mailAddId.Id;
            }
            if (_mailInvId != null)
            {
                _mailInvId.Save();
                this.ModifiedData.MailInvId = _mailInvId.Id == null && this.ModifiedData.MailInvId != null ? "" : _mailInvId.Id;
            }
            if (_invlnId != null)
            {
                _invlnId.Save();
                this.ModifiedData.InvlnId = _invlnId.Id == null && this.ModifiedData.InvlnId != null ? "" : _invlnId.Id;
            }
            if (_product != null)
            {
                _product.Save();
                this.ModifiedData.ProdId = _product.Id == null && this.ModifiedData.ProdId != null ? "" : _product.Id;
            }
            if (_plId != null)
            {
                _plId.Save();
                this.ModifiedData.PlId = _plId.Id == null && this.ModifiedData.PlId != null ? "" : _plId.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_invoiceLines != null)
                _invoiceLines.Execute(obj => obj.MelIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        System.Boolean IMemberLocationModel.Overseas
        {
            get { return this.Overseas; }
            set { this.Overseas = (System.Boolean)value; }
        }

        System.Decimal IMemberLocationModel.FeeAmount
        {
            set { this.FeeAmount = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_MEM_ID" field.
        /// </summary>
        Consensus.Membership.IMembershipModel IMemberLocationModel.Membership
        {
            get { return this.Membership; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_MEM_ID" field.
        /// </summary>
        System.String IMemberLocationModel.MembershipId
        {
            get { return this.MembershipId; }
            set { this.MembershipId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_MEP_ID" field.
        /// </summary>
        Consensus.Membership.IMemberPeriodModel IMemberLocationModel.MemberPeriod
        {
            get { return this.MemberPeriod; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_MEP_ID" field.
        /// </summary>
        System.String IMemberLocationModel.MemberPeriodId
        {
            get { return this.MemberPeriodId; }
            set { this.MemberPeriodId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_START" field.
        /// </summary>
        System.Nullable<System.DateTime> IMemberLocationModel.Start
        {
            get { return this.Start; }
            set { this.Start = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_END" field.
        /// </summary>
        System.Nullable<System.DateTime> IMemberLocationModel.End
        {
            get { return this.End; }
            set { this.End = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_STATUS" field.
        /// </summary>
        System.Nullable<System.Int32> IMemberLocationModel.Status
        {
            get { return this.Status; }
            set { this.Status = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_TYPE" field.
        /// </summary>
        System.Nullable<System.Int32> IMemberLocationModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_FEE" field.
        /// </summary>
        System.Decimal IMemberLocationModel.Fee
        {
            get { return this.Fee; }
            set { this.Fee = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CURRENCY" field.
        /// </summary>
        System.String IMemberLocationModel.Currency
        {
            get { return this.Currency; }
            set { this.Currency = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IMemberLocationModel.OrgId
        {
            get { return this.OrgId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_ORG_ID" field.
        /// </summary>
        System.String IMemberLocationModel.OrgIdId
        {
            get { return this.OrgIdId; }
            set { this.OrgIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IMemberLocationModel.Role
        {
            get { return this.Role; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_PROLE_ID" field.
        /// </summary>
        System.String IMemberLocationModel.RoleId
        {
            get { return this.RoleId; }
            set { this.RoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_MAIL_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel IMemberLocationModel.MailAddId
        {
            get { return this.MailAddId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_MAIL_ADD_ID" field.
        /// </summary>
        System.String IMemberLocationModel.MailAddIdId
        {
            get { return this.MailAddIdId; }
            set { this.MailAddIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_MAIL_INV_ID" field.
        /// </summary>
        Consensus.Finance.IInvoiceModel IMemberLocationModel.MailInvId
        {
            get { return this.MailInvId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_MAIL_INV_ID" field.
        /// </summary>
        System.String IMemberLocationModel.MailInvIdId
        {
            get { return this.MailInvIdId; }
            set { this.MailInvIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_RENEW_LOC" field.
        /// </summary>
        System.Nullable<System.Byte> IMemberLocationModel.RenewLoc
        {
            get { return this.RenewLoc; }
            set { this.RenewLoc = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_PRINCIPAL" field.
        /// </summary>
        System.Nullable<System.Byte> IMemberLocationModel.Principal
        {
            get { return this.Principal; }
            set { this.Principal = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_VATCD" field.
        /// </summary>
        System.String IMemberLocationModel.Vatcd
        {
            get { return this.Vatcd; }
            set { this.Vatcd = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_REF" field.
        /// </summary>
        System.String IMemberLocationModel.Ref
        {
            get { return this.Ref; }
            set { this.Ref = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_VAT_RATE" field.
        /// </summary>
        System.Decimal IMemberLocationModel.VatRate
        {
            get { return this.VatRate; }
            set { this.VatRate = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_VAT_AMT" field.
        /// </summary>
        System.Decimal IMemberLocationModel.VatAmt
        {
            get { return this.VatAmt; }
            set { this.VatAmt = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_INVLN_ID" field.
        /// </summary>
        Consensus.Finance.IInvoiceLineModel IMemberLocationModel.InvlnId
        {
            get { return this.InvlnId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_INVLN_ID" field.
        /// </summary>
        System.String IMemberLocationModel.InvlnIdId
        {
            get { return this.InvlnIdId; }
            set { this.InvlnIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_INVOICED" field.
        /// </summary>
        System.Nullable<System.Byte> IMemberLocationModel.Invoiced
        {
            get { return this.Invoiced; }
            set { this.Invoiced = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_SY_TYPE" field.
        /// </summary>
        System.Byte IMemberLocationModel.SyType
        {
            get { return this.SyType; }
            set { this.SyType = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductMembershipModel IMemberLocationModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_PROD_ID" field.
        /// </summary>
        System.String IMemberLocationModel.ProductId
        {
            get { return this.ProductId; }
            set { this.ProductId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CURRENT" field.
        /// </summary>
        System.Byte IMemberLocationModel.Current
        {
            get { return this.Current; }
            set { this.Current = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_GROSS_FEE" field.
        /// </summary>
        System.Decimal IMemberLocationModel.GrossFee
        {
            get { return this.GrossFee; }
            set { this.GrossFee = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISC_REASON" field.
        /// </summary>
        System.String IMemberLocationModel.DiscReason
        {
            get { return this.DiscReason; }
            set { this.DiscReason = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_FEE_EXEMPT" field.
        /// </summary>
        System.Byte IMemberLocationModel.FeeExempt
        {
            get { return this.FeeExempt; }
            set { this.FeeExempt = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CURRENT_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IMemberLocationModel.CurrentDate
        {
            get { return this.CurrentDate; }
            set { this.CurrentDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CANCEL_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IMemberLocationModel.CancelDate
        {
            get { return this.CancelDate; }
            set { this.CancelDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_PL_ID" field.
        /// </summary>
        Consensus.Finance.IPriceListModel IMemberLocationModel.PlId
        {
            get { return this.PlId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_PL_ID" field.
        /// </summary>
        System.String IMemberLocationModel.PlIdId
        {
            get { return this.PlIdId; }
            set { this.PlIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISC_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IMemberLocationModel.DiscId
        {
            get { return this.DiscId; }
            set { this.DiscId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISCOUNT" field.
        /// </summary>
        System.Nullable<System.Decimal> IMemberLocationModel.Discount
        {
            get { return this.Discount; }
            set { this.Discount = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_LIST_PRICE" field.
        /// </summary>
        System.Nullable<System.Decimal> IMemberLocationModel.ListPrice
        {
            get { return this.ListPrice; }
            set { this.ListPrice = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_PO_NUMBER" field.
        /// </summary>
        System.String IMemberLocationModel.PoNumber
        {
            get { return this.PoNumber; }
            set { this.PoNumber = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_QTY" field.
        /// </summary>
        System.Nullable<System.Int32> IMemberLocationModel.Qty
        {
            get { return this.Qty; }
            set { this.Qty = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DO_NOT_RENEW" field.
        /// </summary>
        System.Nullable<System.Byte> IMemberLocationModel.DoNotRenew
        {
            get { return this.DoNotRenew; }
            set { this.DoNotRenew = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CANCEL_REASON" field.
        /// </summary>
        System.String IMemberLocationModel.CancelReason
        {
            get { return this.CancelReason; }
            set { this.CancelReason = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_UNT_PRICE" field.
        /// </summary>
        System.Nullable<System.Decimal> IMemberLocationModel.UntPrice
        {
            get { return this.UntPrice; }
            set { this.UntPrice = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISC_RENEWAL" field.
        /// </summary>
        System.Nullable<System.DateTime> IMemberLocationModel.DiscRenewal
        {
            get { return this.DiscRenewal; }
            set { this.DiscRenewal = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_PRICE_MODIFIED" field.
        /// </summary>
        System.Byte IMemberLocationModel.PriceModified
        {
            get { return this.PriceModified; }
            set { this.PriceModified = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISC_PERCENT" field.
        /// </summary>
        System.Nullable<System.Decimal> IMemberLocationModel.DiscPercent
        {
            get { return this.DiscPercent; }
            set { this.DiscPercent = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_REV_CODE" field.
        /// </summary>
        System.String IMemberLocationModel.RevCode
        {
            get { return this.RevCode; }
            set { this.RevCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_COST_CODE" field.
        /// </summary>
        System.String IMemberLocationModel.CostCode
        {
            get { return this.CostCode; }
            set { this.CostCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:MemberLocationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceLineModel> IMemberLocationModel.InvoiceLines
        {
            get { return this.InvoiceLines; }
        }

        void IMemberLocationModel.Save()
        {
            this.Save();
        }

        #endregion
    }
}
