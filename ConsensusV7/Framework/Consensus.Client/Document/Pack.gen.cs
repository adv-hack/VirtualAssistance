using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Marketing;

namespace Consensus.Document
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Pack : Proxy<IPackModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PackEmailBody" /> member.
        /// </summary>
        private Consensus.Activities.C4text _packEmailBody;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PackSenderId" /> member.
        /// </summary>
        private Consensus.Contact.Role _packSenderId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PackOutputQueueId" /> member.
        /// </summary>
        private Consensus.Document.OutputQueue _packOutputQueueId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PackSellingCompanyId" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _packSellingCompanyId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CustomerPacks" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.CustomerPack, Consensus.Contact.ICustomerPackModel> _customerPacks;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MembershipJoiningPack" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel> _membershipJoiningPack;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MembershipRemind1Pack" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel> _membershipRemind1Pack;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MembershipRemind2Pack" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel> _membershipRemind2Pack;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MembershipRenewalPack" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel> _membershipRenewalPack;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MembershipLapsedPack" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel> _membershipLapsedPack;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MembershipCancelPack" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel> _membershipCancelPack;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MembershipRemind3Pack" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel> _membershipRemind3Pack;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MembershipRenewedPack" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel> _membershipRenewedPack;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MembershipAppPack" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel> _membershipAppPack;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MembershipOfferPack" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel> _membershipOfferPack;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PackProducts" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.PackProduct, Consensus.Document.IPackProductModel> _packProducts;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PackId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.PackXref, Consensus.Document.IPackXrefModel> _packId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PackPrintRequests" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.PrintRequest, Consensus.Document.IPrintRequestModel> _packPrintRequests;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Accounts" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Account, Consensus.Finance.IAccountModel> _accounts;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Invoices" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Invoice, Consensus.Finance.IInvoiceModel> _invoices;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SaqQueuePack" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.SaqQueue, Consensus.Marketing.ISaqQueueModel> _saqQueuePack;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "PACK_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_TYPE" field.
        /// </summary>
        public System.Nullable<System.Byte> PackType
        {
            get { return this.Model.PackType; }
            set { this.Model.PackType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_EMAIL_SUBJECT" field.
        /// </summary>
        public System.String EmailSubject
        {
            get { return this.Model.EmailSubject; }
            set { this.Model.EmailSubject = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_ACT_PQ_KEEP" field.
        /// </summary>
        public System.Nullable<System.Byte> ActPqKeep
        {
            get { return this.Model.ActPqKeep; }
            set { this.Model.ActPqKeep = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACK_EMAIL_BODY" field.
        /// </summary>
        public Consensus.Activities.C4text PackEmailBody
        {
            get
            {
                if (_packEmailBody == null && this.Model.PackEmailBody != null)
                    _packEmailBody = new Consensus.Activities.C4text(this.Model.PackEmailBody);
                if (_packEmailBody == null)
                    _packEmailBody = Consensus.Activities.C4text.Create();
                return _packEmailBody;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACK_EMAIL_BODY" field.
        /// </summary>
        public System.String PackEmailBodyId
        {
            get { return this.Model.PackEmailBodyId; }
            set { this.Model.PackEmailBodyId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_STATUS" field.
        /// </summary>
        public System.Byte Status
        {
            get { return this.Model.Status; }
            set { this.Model.Status = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACK_SEND_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role PackSenderId
        {
            get
            {
                if (_packSenderId == null && this.Model.PackSenderId != null)
                    _packSenderId = new Consensus.Contact.Role(this.Model.PackSenderId);
                if (_packSenderId == null)
                    _packSenderId = Consensus.Contact.Role.Create();
                return _packSenderId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACK_SEND_PROLE_ID" field.
        /// </summary>
        public System.String PackSenderIdId
        {
            get { return this.Model.PackSenderIdId; }
            set { this.Model.PackSenderIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_CATEGORY" field.
        /// </summary>
        public System.String Category
        {
            get { return this.Model.Category; }
            set { this.Model.Category = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACK_PQ_ID" field.
        /// </summary>
        public Consensus.Document.OutputQueue PackOutputQueueId
        {
            get
            {
                if (_packOutputQueueId == null && this.Model.PackOutputQueueId != null)
                    _packOutputQueueId = new Consensus.Document.OutputQueue(this.Model.PackOutputQueueId);
                if (_packOutputQueueId == null)
                    _packOutputQueueId = Consensus.Document.OutputQueue.Create();
                return _packOutputQueueId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACK_PQ_ID" field.
        /// </summary>
        public System.String PackOutputQueueIdId
        {
            get { return this.Model.PackOutputQueueIdId; }
            set { this.Model.PackOutputQueueIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_BCC_EMAIL" field.
        /// </summary>
        public System.String BccEmail
        {
            get { return this.Model.BccEmail; }
            set { this.Model.BccEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_MDN_EMAIL" field.
        /// </summary>
        public System.String MdnEmail
        {
            get { return this.Model.MdnEmail; }
            set { this.Model.MdnEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_DSN_EMAIL" field.
        /// </summary>
        public System.String DsnEmail
        {
            get { return this.Model.DsnEmail; }
            set { this.Model.DsnEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_DSN_OPTIONS" field.
        /// </summary>
        public System.String DsnOptions
        {
            get { return this.Model.DsnOptions; }
            set { this.Model.DsnOptions = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACK_SELCO_SP_ID" field.
        /// </summary>
        public Consensus.Common.SellingCompany PackSellingCompanyId
        {
            get
            {
                if (_packSellingCompanyId == null && this.Model.PackSellingCompanyId != null)
                    _packSellingCompanyId = new Consensus.Common.SellingCompany(this.Model.PackSellingCompanyId);
                if (_packSellingCompanyId == null)
                    _packSellingCompanyId = Consensus.Common.SellingCompany.Create();
                return _packSellingCompanyId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACK_SELCO_SP_ID" field.
        /// </summary>
        public System.String PackSellingCompanyIdId
        {
            get { return this.Model.PackSellingCompanyIdId; }
            set { this.Model.PackSellingCompanyIdId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CustomerPackModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        public Collection<Consensus.Contact.CustomerPack> CustomerPacks
        {
            get
            {
                if (_customerPacks == null)
                    _customerPacks = new ProxyCollection<Consensus.Contact.CustomerPack, Consensus.Contact.ICustomerPackModel>(this.Model.CustomerPacks, model => new Consensus.Contact.CustomerPack(model));
                return _customerPacks;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.ProductMembership> MembershipJoiningPack
        {
            get
            {
                if (_membershipJoiningPack == null)
                    _membershipJoiningPack = new ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel>(this.Model.MembershipJoiningPack, model => new Consensus.Learning.ProductMembership(model));
                return _membershipJoiningPack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.ProductMembership> MembershipRemind1Pack
        {
            get
            {
                if (_membershipRemind1Pack == null)
                    _membershipRemind1Pack = new ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel>(this.Model.MembershipRemind1Pack, model => new Consensus.Learning.ProductMembership(model));
                return _membershipRemind1Pack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.ProductMembership> MembershipRemind2Pack
        {
            get
            {
                if (_membershipRemind2Pack == null)
                    _membershipRemind2Pack = new ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel>(this.Model.MembershipRemind2Pack, model => new Consensus.Learning.ProductMembership(model));
                return _membershipRemind2Pack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.ProductMembership> MembershipRenewalPack
        {
            get
            {
                if (_membershipRenewalPack == null)
                    _membershipRenewalPack = new ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel>(this.Model.MembershipRenewalPack, model => new Consensus.Learning.ProductMembership(model));
                return _membershipRenewalPack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.ProductMembership> MembershipLapsedPack
        {
            get
            {
                if (_membershipLapsedPack == null)
                    _membershipLapsedPack = new ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel>(this.Model.MembershipLapsedPack, model => new Consensus.Learning.ProductMembership(model));
                return _membershipLapsedPack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.ProductMembership> MembershipCancelPack
        {
            get
            {
                if (_membershipCancelPack == null)
                    _membershipCancelPack = new ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel>(this.Model.MembershipCancelPack, model => new Consensus.Learning.ProductMembership(model));
                return _membershipCancelPack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.ProductMembership> MembershipRemind3Pack
        {
            get
            {
                if (_membershipRemind3Pack == null)
                    _membershipRemind3Pack = new ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel>(this.Model.MembershipRemind3Pack, model => new Consensus.Learning.ProductMembership(model));
                return _membershipRemind3Pack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.ProductMembership> MembershipRenewedPack
        {
            get
            {
                if (_membershipRenewedPack == null)
                    _membershipRenewedPack = new ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel>(this.Model.MembershipRenewedPack, model => new Consensus.Learning.ProductMembership(model));
                return _membershipRenewedPack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.ProductMembership> MembershipAppPack
        {
            get
            {
                if (_membershipAppPack == null)
                    _membershipAppPack = new ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel>(this.Model.MembershipAppPack, model => new Consensus.Learning.ProductMembership(model));
                return _membershipAppPack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.ProductMembership> MembershipOfferPack
        {
            get
            {
                if (_membershipOfferPack == null)
                    _membershipOfferPack = new ProxyCollection<Consensus.Learning.ProductMembership, Consensus.Learning.IProductMembershipModel>(this.Model.MembershipOfferPack, model => new Consensus.Learning.ProductMembership(model));
                return _membershipOfferPack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackProductModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        public Collection<Consensus.Document.PackProduct> PackProducts
        {
            get
            {
                if (_packProducts == null)
                    _packProducts = new ProxyCollection<Consensus.Document.PackProduct, Consensus.Document.IPackProductModel>(this.Model.PackProducts, model => new Consensus.Document.PackProduct(model));
                return _packProducts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackXrefModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        public Collection<Consensus.Document.PackXref> PackId
        {
            get
            {
                if (_packId == null)
                    _packId = new ProxyCollection<Consensus.Document.PackXref, Consensus.Document.IPackXrefModel>(this.Model.PackId, model => new Consensus.Document.PackXref(model));
                return _packId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrintRequestModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Document.PrintRequest> PackPrintRequests
        {
            get
            {
                if (_packPrintRequests == null)
                    _packPrintRequests = new ProxyCollection<Consensus.Document.PrintRequest, Consensus.Document.IPrintRequestModel>(this.Model.PackPrintRequests, model => new Consensus.Document.PrintRequest(model));
                return _packPrintRequests;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Finance.Account> Accounts
        {
            get
            {
                if (_accounts == null)
                    _accounts = new ProxyCollection<Consensus.Finance.Account, Consensus.Finance.IAccountModel>(this.Model.Accounts, model => new Consensus.Finance.Account(model));
                return _accounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:PackModel" />.
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
        ///     Gets the collection of <see cref="!:SaqQueueModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.SaqQueue> SaqQueuePack
        {
            get
            {
                if (_saqQueuePack == null)
                    _saqQueuePack = new ProxyCollection<Consensus.Marketing.SaqQueue, Consensus.Marketing.ISaqQueueModel>(this.Model.SaqQueuePack, model => new Consensus.Marketing.SaqQueue(model));
                return _saqQueuePack;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Pack(IPackModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Checks if iCalMessage name exist.
        /// </summary>
        /// <param name="packName">
        ///     Name of the iCalendar Message.
        /// </param>
        /// <param name="packId">
        ///     Id of the iCalendar Message.
        /// </param>
        /// <returns>
        ///     Whether iCalendar Message's name exist in database.
        /// </returns>
        public static System.Boolean CheckIfNameExist(System.String packName, System.String packId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Pack.CheckIfNameExist(site,packName,packId);
        }

        /// <summary>
        ///     Checks if iCalMessage name exist.
        /// </summary>
        /// <param name="packName">
        ///     Name of the iCalendar Message.
        /// </param>
        /// <param name="packId">
        ///     Id of the iCalendar Message.
        /// </param>
        /// <returns>
        ///     Whether iCalendar Message's name exist in database.
        /// </returns>
        public static System.Boolean CheckIfNameExist(ConsensusSite site, System.String packName, System.String packId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.Pack.CheckIfNameExist(packName,packId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PackModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PackModel" /> instance.
        /// </returns>
        public static Consensus.Document.Pack Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Pack.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PackModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PackModel" /> instance.
        /// </returns>
        public static Consensus.Document.Pack Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IPackModel model = provider.Document.Pack.Create();
            return model == null ? null : new Consensus.Document.Pack(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PackModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PackModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.Pack> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Pack.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PackModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PackModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.Pack> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPackModel> collection = provider.Document.Pack.FetchAll();
            return collection.Select(model => new Consensus.Document.Pack(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PackModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PackModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.Pack FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Pack.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PackModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PackModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.Pack FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IPackModel model = provider.Document.Pack.FetchById(id);
            return model == null ? null : new Consensus.Document.Pack(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Pack.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.Pack.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackModel" /> instances.
        /// </summary>
        /// <param name="packEmailBodyId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instances that match the specified <paramref name="packEmailBodyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.Pack> FetchAllByPackEmailBodyId(System.String packEmailBodyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Pack.FetchAllByPackEmailBodyId(site,packEmailBodyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackModel" /> instances.
        /// </summary>
        /// <param name="packEmailBodyId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instances that match the specified <paramref name="packEmailBodyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.Pack> FetchAllByPackEmailBodyId(ConsensusSite site, System.String packEmailBodyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPackModel> collection = provider.Document.Pack.FetchAllByPackEmailBodyId(packEmailBodyId);
            return collection.Select(model => new Consensus.Document.Pack(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackModel" /> instances.
        /// </summary>
        /// <param name="packSenderIdId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instances that match the specified <paramref name="packSenderIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.Pack> FetchAllByPackSenderIdId(System.String packSenderIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Pack.FetchAllByPackSenderIdId(site,packSenderIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackModel" /> instances.
        /// </summary>
        /// <param name="packSenderIdId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instances that match the specified <paramref name="packSenderIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.Pack> FetchAllByPackSenderIdId(ConsensusSite site, System.String packSenderIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPackModel> collection = provider.Document.Pack.FetchAllByPackSenderIdId(packSenderIdId);
            return collection.Select(model => new Consensus.Document.Pack(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackModel" /> instances.
        /// </summary>
        /// <param name="packOutputQueueIdId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instances that match the specified <paramref name="packOutputQueueIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.Pack> FetchAllByPackOutputQueueIdId(System.String packOutputQueueIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Pack.FetchAllByPackOutputQueueIdId(site,packOutputQueueIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackModel" /> instances.
        /// </summary>
        /// <param name="packOutputQueueIdId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instances that match the specified <paramref name="packOutputQueueIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.Pack> FetchAllByPackOutputQueueIdId(ConsensusSite site, System.String packOutputQueueIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPackModel> collection = provider.Document.Pack.FetchAllByPackOutputQueueIdId(packOutputQueueIdId);
            return collection.Select(model => new Consensus.Document.Pack(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackModel" /> instances.
        /// </summary>
        /// <param name="packSellingCompanyIdId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instances that match the specified <paramref name="packSellingCompanyIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.Pack> FetchAllByPackSellingCompanyIdId(System.String packSellingCompanyIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Pack.FetchAllByPackSellingCompanyIdId(site,packSellingCompanyIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackModel" /> instances.
        /// </summary>
        /// <param name="packSellingCompanyIdId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instances that match the specified <paramref name="packSellingCompanyIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.Pack> FetchAllByPackSellingCompanyIdId(ConsensusSite site, System.String packSellingCompanyIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPackModel> collection = provider.Document.Pack.FetchAllByPackSellingCompanyIdId(packSellingCompanyIdId);
            return collection.Select(model => new Consensus.Document.Pack(model));
        }

        #endregion
    }
}
