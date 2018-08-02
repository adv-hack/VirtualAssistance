using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;
using Consensus.Finance;
using Consensus.Learning;

namespace Consensus.Membership
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class MemberLocation : Proxy<IMemberLocationModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Membership" /> member.
        /// </summary>
        private Consensus.Membership.Membership _membership;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MemberPeriod" /> member.
        /// </summary>
        private Consensus.Membership.MemberPeriod _memberPeriod;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="OrgId" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _orgId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Role" /> member.
        /// </summary>
        private Consensus.Contact.Role _role;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MailAddId" /> member.
        /// </summary>
        private Consensus.Contact.Address _mailAddId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MailInvId" /> member.
        /// </summary>
        private Consensus.Finance.Invoice _mailInvId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="InvlnId" /> member.
        /// </summary>
        private Consensus.Finance.InvoiceLine _invlnId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Product" /> member.
        /// </summary>
        private Consensus.Learning.ProductMembership _product;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PlId" /> member.
        /// </summary>
        private Consensus.Finance.PriceList _plId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="InvoiceLines" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.InvoiceLine, Consensus.Finance.IInvoiceLineModel> _invoiceLines;

        #endregion

        #region properties

        public System.Boolean Overseas
        {
            get { return this.Model.Overseas; }
            set { this.Model.Overseas = value; }
        }

        public System.Decimal FeeAmount
        {
            set { this.Model.FeeAmount = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_MEM_ID" field.
        /// </summary>
        public Consensus.Membership.Membership Membership
        {
            get
            {
                if (_membership == null && this.Model.Membership != null)
                    _membership = new Consensus.Membership.Membership(this.Model.Membership);
                if (_membership == null)
                    _membership = Consensus.Membership.Membership.Create();
                return _membership;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_MEM_ID" field.
        /// </summary>
        public System.String MembershipId
        {
            get { return this.Model.MembershipId; }
            set { this.Model.MembershipId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_MEP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "MEL_MEP_ID" field.
        /// </summary>
        public System.String MemberPeriodId
        {
            get { return this.Model.MemberPeriodId; }
            set { this.Model.MemberPeriodId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_START" field.
        /// </summary>
        public System.Nullable<System.DateTime> Start
        {
            get { return this.Model.Start; }
            set { this.Model.Start = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_END" field.
        /// </summary>
        public System.Nullable<System.DateTime> End
        {
            get { return this.Model.End; }
            set { this.Model.End = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_STATUS" field.
        /// </summary>
        public System.Nullable<System.Int32> Status
        {
            get { return this.Model.Status; }
            set { this.Model.Status = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_TYPE" field.
        /// </summary>
        public System.Nullable<System.Int32> Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_FEE" field.
        /// </summary>
        public System.Decimal Fee
        {
            get { return this.Model.Fee; }
            set { this.Model.Fee = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CURRENCY" field.
        /// </summary>
        public System.String Currency
        {
            get { return this.Model.Currency; }
            set { this.Model.Currency = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_ORG_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation OrgId
        {
            get
            {
                if (_orgId == null && this.Model.OrgId != null)
                    _orgId = new Consensus.Contact.Organisation(this.Model.OrgId);
                if (_orgId == null)
                    _orgId = Consensus.Contact.Organisation.Create();
                return _orgId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_ORG_ID" field.
        /// </summary>
        public System.String OrgIdId
        {
            get { return this.Model.OrgIdId; }
            set { this.Model.OrgIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "MEL_PROLE_ID" field.
        /// </summary>
        public System.String RoleId
        {
            get { return this.Model.RoleId; }
            set { this.Model.RoleId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_MAIL_ADD_ID" field.
        /// </summary>
        public Consensus.Contact.Address MailAddId
        {
            get
            {
                if (_mailAddId == null && this.Model.MailAddId != null)
                    _mailAddId = new Consensus.Contact.Address(this.Model.MailAddId);
                if (_mailAddId == null)
                    _mailAddId = Consensus.Contact.Address.Create();
                return _mailAddId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_MAIL_ADD_ID" field.
        /// </summary>
        public System.String MailAddIdId
        {
            get { return this.Model.MailAddIdId; }
            set { this.Model.MailAddIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_MAIL_INV_ID" field.
        /// </summary>
        public Consensus.Finance.Invoice MailInvId
        {
            get
            {
                if (_mailInvId == null && this.Model.MailInvId != null)
                    _mailInvId = new Consensus.Finance.Invoice(this.Model.MailInvId);
                if (_mailInvId == null)
                    _mailInvId = Consensus.Finance.Invoice.Create();
                return _mailInvId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_MAIL_INV_ID" field.
        /// </summary>
        public System.String MailInvIdId
        {
            get { return this.Model.MailInvIdId; }
            set { this.Model.MailInvIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_RENEW_LOC" field.
        /// </summary>
        public System.Nullable<System.Byte> RenewLoc
        {
            get { return this.Model.RenewLoc; }
            set { this.Model.RenewLoc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_PRINCIPAL" field.
        /// </summary>
        public System.Nullable<System.Byte> Principal
        {
            get { return this.Model.Principal; }
            set { this.Model.Principal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_VATCD" field.
        /// </summary>
        public System.String Vatcd
        {
            get { return this.Model.Vatcd; }
            set { this.Model.Vatcd = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_REF" field.
        /// </summary>
        public System.String Ref
        {
            get { return this.Model.Ref; }
            set { this.Model.Ref = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_VAT_RATE" field.
        /// </summary>
        public System.Decimal VatRate
        {
            get { return this.Model.VatRate; }
            set { this.Model.VatRate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_VAT_AMT" field.
        /// </summary>
        public System.Decimal VatAmt
        {
            get { return this.Model.VatAmt; }
            set { this.Model.VatAmt = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_INVLN_ID" field.
        /// </summary>
        public Consensus.Finance.InvoiceLine InvlnId
        {
            get
            {
                if (_invlnId == null && this.Model.InvlnId != null)
                    _invlnId = new Consensus.Finance.InvoiceLine(this.Model.InvlnId);
                if (_invlnId == null)
                    _invlnId = Consensus.Finance.InvoiceLine.Create();
                return _invlnId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_INVLN_ID" field.
        /// </summary>
        public System.String InvlnIdId
        {
            get { return this.Model.InvlnIdId; }
            set { this.Model.InvlnIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_INVOICED" field.
        /// </summary>
        public System.Nullable<System.Byte> Invoiced
        {
            get { return this.Model.Invoiced; }
            set { this.Model.Invoiced = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_SY_TYPE" field.
        /// </summary>
        public System.Byte SyType
        {
            get { return this.Model.SyType; }
            set { this.Model.SyType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_PROD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "MEL_PROD_ID" field.
        /// </summary>
        public System.String ProductId
        {
            get { return this.Model.ProductId; }
            set { this.Model.ProductId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CURRENT" field.
        /// </summary>
        public System.Byte Current
        {
            get { return this.Model.Current; }
            set { this.Model.Current = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_GROSS_FEE" field.
        /// </summary>
        public System.Decimal GrossFee
        {
            get { return this.Model.GrossFee; }
            set { this.Model.GrossFee = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISC_REASON" field.
        /// </summary>
        public System.String DiscReason
        {
            get { return this.Model.DiscReason; }
            set { this.Model.DiscReason = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_FEE_EXEMPT" field.
        /// </summary>
        public System.Byte FeeExempt
        {
            get { return this.Model.FeeExempt; }
            set { this.Model.FeeExempt = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CURRENT_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> CurrentDate
        {
            get { return this.Model.CurrentDate; }
            set { this.Model.CurrentDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CANCEL_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> CancelDate
        {
            get { return this.Model.CancelDate; }
            set { this.Model.CancelDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MEL_PL_ID" field.
        /// </summary>
        public Consensus.Finance.PriceList PlId
        {
            get
            {
                if (_plId == null && this.Model.PlId != null)
                    _plId = new Consensus.Finance.PriceList(this.Model.PlId);
                if (_plId == null)
                    _plId = Consensus.Finance.PriceList.Create();
                return _plId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_PL_ID" field.
        /// </summary>
        public System.String PlIdId
        {
            get { return this.Model.PlIdId; }
            set { this.Model.PlIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISC_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> DiscId
        {
            get { return this.Model.DiscId; }
            set { this.Model.DiscId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISCOUNT" field.
        /// </summary>
        public System.Nullable<System.Decimal> Discount
        {
            get { return this.Model.Discount; }
            set { this.Model.Discount = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_LIST_PRICE" field.
        /// </summary>
        public System.Nullable<System.Decimal> ListPrice
        {
            get { return this.Model.ListPrice; }
            set { this.Model.ListPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_PO_NUMBER" field.
        /// </summary>
        public System.String PoNumber
        {
            get { return this.Model.PoNumber; }
            set { this.Model.PoNumber = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_QTY" field.
        /// </summary>
        public System.Nullable<System.Int32> Qty
        {
            get { return this.Model.Qty; }
            set { this.Model.Qty = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DO_NOT_RENEW" field.
        /// </summary>
        public System.Nullable<System.Byte> DoNotRenew
        {
            get { return this.Model.DoNotRenew; }
            set { this.Model.DoNotRenew = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CANCEL_REASON" field.
        /// </summary>
        public System.String CancelReason
        {
            get { return this.Model.CancelReason; }
            set { this.Model.CancelReason = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_UNT_PRICE" field.
        /// </summary>
        public System.Nullable<System.Decimal> UntPrice
        {
            get { return this.Model.UntPrice; }
            set { this.Model.UntPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISC_RENEWAL" field.
        /// </summary>
        public System.Nullable<System.DateTime> DiscRenewal
        {
            get { return this.Model.DiscRenewal; }
            set { this.Model.DiscRenewal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_PRICE_MODIFIED" field.
        /// </summary>
        public System.Byte PriceModified
        {
            get { return this.Model.PriceModified; }
            set { this.Model.PriceModified = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISC_PERCENT" field.
        /// </summary>
        public System.Nullable<System.Decimal> DiscPercent
        {
            get { return this.Model.DiscPercent; }
            set { this.Model.DiscPercent = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_REV_CODE" field.
        /// </summary>
        public System.String RevCode
        {
            get { return this.Model.RevCode; }
            set { this.Model.RevCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_COST_CODE" field.
        /// </summary>
        public System.String CostCode
        {
            get { return this.Model.CostCode; }
            set { this.Model.CostCode = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:MemberLocationModel" />.
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
        internal MemberLocation(IMemberLocationModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public void Save()
        {
            this.Model.Save();
        }

        public static IEnumerable<Consensus.Membership.MemberLocation> CheckMemLocLinesToInvoice(System.String memberPeriodId, System.String userLoginId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberLocation.CheckMemLocLinesToInvoice(site,memberPeriodId,userLoginId);
        }

        public static IEnumerable<Consensus.Membership.MemberLocation> CheckMemLocLinesToInvoice(ConsensusSite site, System.String memberPeriodId, System.String userLoginId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberLocationModel> collection = provider.Membership.MemberLocation.CheckMemLocLinesToInvoice(memberPeriodId,userLoginId);
            return collection.Select(model => new Consensus.Membership.MemberLocation(model));
        }

        /// <summary>
        ///     Checks if Consultant scheme product already exist in database.
        /// </summary>
        /// <param name="productId">
        ///     Id of the Product.
        /// </param>
        /// <param name="memberLocationId">
        ///     Id of the Member Location.
        /// </param>
        /// <param name="memberPeriodId">
        ///     Id of the Member Period.
        /// </param>
        /// <returns>
        ///     Whether Consultant scheme product already exist in database.
        /// </returns>
        public static System.Boolean CheckIfProductExist(System.String productId, System.String memberLocationId, System.String memberPeriodId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberLocation.CheckIfProductExist(site,productId,memberLocationId,memberPeriodId);
        }

        /// <summary>
        ///     Checks if Consultant scheme product already exist in database.
        /// </summary>
        /// <param name="productId">
        ///     Id of the Product.
        /// </param>
        /// <param name="memberLocationId">
        ///     Id of the Member Location.
        /// </param>
        /// <param name="memberPeriodId">
        ///     Id of the Member Period.
        /// </param>
        /// <returns>
        ///     Whether Consultant scheme product already exist in database.
        /// </returns>
        public static System.Boolean CheckIfProductExist(ConsensusSite site, System.String productId, System.String memberLocationId, System.String memberPeriodId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Membership.MemberLocation.CheckIfProductExist(productId,memberLocationId,memberPeriodId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:MemberLocationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MemberLocationModel" /> instance.
        /// </returns>
        public static Consensus.Membership.MemberLocation Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberLocation.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:MemberLocationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MemberLocationModel" /> instance.
        /// </returns>
        public static Consensus.Membership.MemberLocation Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.IMemberLocationModel model = provider.Membership.MemberLocation.Create();
            return model == null ? null : new Consensus.Membership.MemberLocation(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MemberLocationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MemberLocationModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberLocation.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MemberLocationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MemberLocationModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberLocationModel> collection = provider.Membership.MemberLocation.FetchAll();
            return collection.Select(model => new Consensus.Membership.MemberLocation(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:MemberLocationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MemberLocationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Membership.MemberLocation FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberLocation.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:MemberLocationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MemberLocationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Membership.MemberLocation FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.IMemberLocationModel model = provider.Membership.MemberLocation.FetchById(id);
            return model == null ? null : new Consensus.Membership.MemberLocation(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberLocation.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Membership.MemberLocation.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="membershipId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="membershipId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByMembershipId(System.String membershipId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberLocation.FetchAllByMembershipId(site,membershipId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="membershipId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="membershipId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByMembershipId(ConsensusSite site, System.String membershipId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberLocationModel> collection = provider.Membership.MemberLocation.FetchAllByMembershipId(membershipId);
            return collection.Select(model => new Consensus.Membership.MemberLocation(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByMemberPeriodId(System.String memberPeriodId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberLocation.FetchAllByMemberPeriodId(site,memberPeriodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByMemberPeriodId(ConsensusSite site, System.String memberPeriodId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberLocationModel> collection = provider.Membership.MemberLocation.FetchAllByMemberPeriodId(memberPeriodId);
            return collection.Select(model => new Consensus.Membership.MemberLocation(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="orgIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="orgIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByOrgIdId(System.String orgIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberLocation.FetchAllByOrgIdId(site,orgIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="orgIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="orgIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByOrgIdId(ConsensusSite site, System.String orgIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberLocationModel> collection = provider.Membership.MemberLocation.FetchAllByOrgIdId(orgIdId);
            return collection.Select(model => new Consensus.Membership.MemberLocation(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByRoleId(System.String roleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberLocation.FetchAllByRoleId(site,roleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByRoleId(ConsensusSite site, System.String roleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberLocationModel> collection = provider.Membership.MemberLocation.FetchAllByRoleId(roleId);
            return collection.Select(model => new Consensus.Membership.MemberLocation(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="mailAddIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="mailAddIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByMailAddIdId(System.String mailAddIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberLocation.FetchAllByMailAddIdId(site,mailAddIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="mailAddIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="mailAddIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByMailAddIdId(ConsensusSite site, System.String mailAddIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberLocationModel> collection = provider.Membership.MemberLocation.FetchAllByMailAddIdId(mailAddIdId);
            return collection.Select(model => new Consensus.Membership.MemberLocation(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="mailInvIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="mailInvIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByMailInvIdId(System.String mailInvIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberLocation.FetchAllByMailInvIdId(site,mailInvIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="mailInvIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="mailInvIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByMailInvIdId(ConsensusSite site, System.String mailInvIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberLocationModel> collection = provider.Membership.MemberLocation.FetchAllByMailInvIdId(mailInvIdId);
            return collection.Select(model => new Consensus.Membership.MemberLocation(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="invlnIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="invlnIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByInvlnIdId(System.String invlnIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberLocation.FetchAllByInvlnIdId(site,invlnIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="invlnIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="invlnIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByInvlnIdId(ConsensusSite site, System.String invlnIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberLocationModel> collection = provider.Membership.MemberLocation.FetchAllByInvlnIdId(invlnIdId);
            return collection.Select(model => new Consensus.Membership.MemberLocation(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByProductId(System.String productId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberLocation.FetchAllByProductId(site,productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByProductId(ConsensusSite site, System.String productId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberLocationModel> collection = provider.Membership.MemberLocation.FetchAllByProductId(productId);
            return collection.Select(model => new Consensus.Membership.MemberLocation(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="plIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="plIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByPlIdId(System.String plIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberLocation.FetchAllByPlIdId(site,plIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="plIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="plIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberLocation> FetchAllByPlIdId(ConsensusSite site, System.String plIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberLocationModel> collection = provider.Membership.MemberLocation.FetchAllByPlIdId(plIdId);
            return collection.Select(model => new Consensus.Membership.MemberLocation(model));
        }

        #endregion
    }
}
