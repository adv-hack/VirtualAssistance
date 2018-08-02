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
    /// <summary>
    ///     Encapsulates the <see cref="PackRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPackModel : LocalModel<PackRecord, String>, IPackModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PACK_EMAIL_BODY" field.
        /// </summary>
        private LocalC4textModel _packEmailBody;

        /// <summary>
        ///     The value of the "PACK_SEND_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _packSenderId;

        /// <summary>
        ///     The value of the "PACK_PQ_ID" field.
        /// </summary>
        private LocalOutputQueueModel _packOutputQueueId;

        /// <summary>
        ///     The value of the "PACK_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _packSellingCompanyId;

        /// <summary>
        ///     The collection of <see cref="CustomerPackModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalCustomerPackModel, ICustomerPackModel> _customerPacks;

        /// <summary>
        ///     The collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalProductMembershipModel, IProductMembershipModel> _membershipJoiningPack;

        /// <summary>
        ///     The collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalProductMembershipModel, IProductMembershipModel> _membershipRemind1Pack;

        /// <summary>
        ///     The collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalProductMembershipModel, IProductMembershipModel> _membershipRemind2Pack;

        /// <summary>
        ///     The collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalProductMembershipModel, IProductMembershipModel> _membershipRenewalPack;

        /// <summary>
        ///     The collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalProductMembershipModel, IProductMembershipModel> _membershipLapsedPack;

        /// <summary>
        ///     The collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalProductMembershipModel, IProductMembershipModel> _membershipCancelPack;

        /// <summary>
        ///     The collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalProductMembershipModel, IProductMembershipModel> _membershipRemind3Pack;

        /// <summary>
        ///     The collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalProductMembershipModel, IProductMembershipModel> _membershipRenewedPack;

        /// <summary>
        ///     The collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalProductMembershipModel, IProductMembershipModel> _membershipAppPack;

        /// <summary>
        ///     The collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalProductMembershipModel, IProductMembershipModel> _membershipOfferPack;

        /// <summary>
        ///     The collection of <see cref="PackProductModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalPackProductModel, IPackProductModel> _packProducts;

        /// <summary>
        ///     The collection of <see cref="PackXrefModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalPackXrefModel, IPackXrefModel> _packId;

        /// <summary>
        ///     The collection of <see cref="PrintRequestModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalPrintRequestModel, IPrintRequestModel> _packPrintRequests;

        /// <summary>
        ///     The collection of <see cref="AccountModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalAccountModel, IAccountModel> _accounts;

        /// <summary>
        ///     The collection of <see cref="InvoiceModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceModel, IInvoiceModel> _invoices;

        /// <summary>
        ///     The collection of <see cref="SaqQueueModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        private LocalCollection<LocalSaqQueueModel, ISaqQueueModel> _saqQueuePack;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PackRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Document.Pack.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PackRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Document.Pack.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PackRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Document.Pack.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_TYPE" field.
        /// </summary>
        public Byte? PackType
        {
            get { return this.ModifiedData.PackType; }
            set { this.ModifiedData.PackType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_EMAIL_SUBJECT" field.
        /// </summary>
        public String EmailSubject
        {
            get { return this.ModifiedData.EmailSubject; }
            set { this.ModifiedData.EmailSubject = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_ACT_PQ_KEEP" field.
        /// </summary>
        public Byte? ActPqKeep
        {
            get { return this.ModifiedData.ActPqKeep; }
            set { this.ModifiedData.ActPqKeep = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACK_EMAIL_BODY" field.
        /// </summary>
        public LocalC4textModel PackEmailBody
        {
            get
            {
                if (_packEmailBody == null && this.PackEmailBodyId != null)
                    _packEmailBody = this.Provider.Activities.C4text.FetchById(this.PackEmailBodyId);
                if (_packEmailBody == null)
                    _packEmailBody = this.Provider.Activities.C4text.Create();
                
                return _packEmailBody;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACK_EMAIL_BODY" field.
        /// </summary>
        public String PackEmailBodyId
        {
            get { return this.ModifiedData.EmailBody; }
            set
            {
                if (this.ModifiedData.EmailBody != value)
                     _packEmailBody = null;
                this.ModifiedData.EmailBody = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_STATUS" field.
        /// </summary>
        public Byte Status
        {
            get { return this.ModifiedData.Status; }
            set { this.ModifiedData.Status = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACK_SEND_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel PackSenderId
        {
            get
            {
                if (_packSenderId == null && this.PackSenderIdId != null)
                    _packSenderId = this.Provider.Contact.Role.FetchById(this.PackSenderIdId);
                if (_packSenderId == null)
                    _packSenderId = this.Provider.Contact.Role.Create();
                
                return _packSenderId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACK_SEND_PROLE_ID" field.
        /// </summary>
        public String PackSenderIdId
        {
            get { return this.ModifiedData.SendProleId; }
            set
            {
                if (this.ModifiedData.SendProleId != value)
                     _packSenderId = null;
                this.ModifiedData.SendProleId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_CATEGORY" field.
        /// </summary>
        public String Category
        {
            get { return this.ModifiedData.Category; }
            set { this.ModifiedData.Category = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACK_PQ_ID" field.
        /// </summary>
        public LocalOutputQueueModel PackOutputQueueId
        {
            get
            {
                if (_packOutputQueueId == null && this.PackOutputQueueIdId != null)
                    _packOutputQueueId = this.Provider.Document.OutputQueue.FetchById(this.PackOutputQueueIdId);
                if (_packOutputQueueId == null)
                    _packOutputQueueId = this.Provider.Document.OutputQueue.Create();
                
                return _packOutputQueueId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACK_PQ_ID" field.
        /// </summary>
        public String PackOutputQueueIdId
        {
            get { return this.ModifiedData.PqId; }
            set
            {
                if (this.ModifiedData.PqId != value)
                     _packOutputQueueId = null;
                this.ModifiedData.PqId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_BCC_EMAIL" field.
        /// </summary>
        public String BccEmail
        {
            get { return this.ModifiedData.BccEmail; }
            set { this.ModifiedData.BccEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_MDN_EMAIL" field.
        /// </summary>
        public String MdnEmail
        {
            get { return this.ModifiedData.MdnEmail; }
            set { this.ModifiedData.MdnEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_DSN_EMAIL" field.
        /// </summary>
        public String DsnEmail
        {
            get { return this.ModifiedData.DsnEmail; }
            set { this.ModifiedData.DsnEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_DSN_OPTIONS" field.
        /// </summary>
        public String DsnOptions
        {
            get { return this.ModifiedData.DsnOptions; }
            set { this.ModifiedData.DsnOptions = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACK_SELCO_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel PackSellingCompanyId
        {
            get
            {
                if (_packSellingCompanyId == null && this.PackSellingCompanyIdId != null)
                    _packSellingCompanyId = this.Provider.Common.SellingCompany.FetchById(this.PackSellingCompanyIdId);
                if (_packSellingCompanyId == null)
                    _packSellingCompanyId = this.Provider.Common.SellingCompany.Create();
                
                return _packSellingCompanyId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACK_SELCO_SP_ID" field.
        /// </summary>
        public String PackSellingCompanyIdId
        {
            get { return this.ModifiedData.SelcoSpId; }
            set
            {
                if (this.ModifiedData.SelcoSpId != value)
                     _packSellingCompanyId = null;
                this.ModifiedData.SelcoSpId = value;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="CustomerPackModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        public LocalCollection<LocalCustomerPackModel, ICustomerPackModel> CustomerPacks
        {
            get
            {
                if (_customerPacks == null)
                    _customerPacks = new LocalCollection<LocalCustomerPackModel, ICustomerPackModel>(this.Provider.Contact.CustomerPack.FetchAllByPackId(this.Id));
                
                return _customerPacks;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalProductMembershipModel, IProductMembershipModel> MembershipJoiningPack
        {
            get
            {
                if (_membershipJoiningPack == null)
                    _membershipJoiningPack = new LocalCollection<LocalProductMembershipModel, IProductMembershipModel>(this.Provider.Learning.ProductMembership.FetchAllByJoiningPackId(this.Id));
                
                return _membershipJoiningPack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalProductMembershipModel, IProductMembershipModel> MembershipRemind1Pack
        {
            get
            {
                if (_membershipRemind1Pack == null)
                    _membershipRemind1Pack = new LocalCollection<LocalProductMembershipModel, IProductMembershipModel>(this.Provider.Learning.ProductMembership.FetchAllByRemind1PackId(this.Id));
                
                return _membershipRemind1Pack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalProductMembershipModel, IProductMembershipModel> MembershipRemind2Pack
        {
            get
            {
                if (_membershipRemind2Pack == null)
                    _membershipRemind2Pack = new LocalCollection<LocalProductMembershipModel, IProductMembershipModel>(this.Provider.Learning.ProductMembership.FetchAllByRemind2PackId(this.Id));
                
                return _membershipRemind2Pack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalProductMembershipModel, IProductMembershipModel> MembershipRenewalPack
        {
            get
            {
                if (_membershipRenewalPack == null)
                    _membershipRenewalPack = new LocalCollection<LocalProductMembershipModel, IProductMembershipModel>(this.Provider.Learning.ProductMembership.FetchAllByRenewalPackId(this.Id));
                
                return _membershipRenewalPack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalProductMembershipModel, IProductMembershipModel> MembershipLapsedPack
        {
            get
            {
                if (_membershipLapsedPack == null)
                    _membershipLapsedPack = new LocalCollection<LocalProductMembershipModel, IProductMembershipModel>(this.Provider.Learning.ProductMembership.FetchAllByLapsedPackId(this.Id));
                
                return _membershipLapsedPack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalProductMembershipModel, IProductMembershipModel> MembershipCancelPack
        {
            get
            {
                if (_membershipCancelPack == null)
                    _membershipCancelPack = new LocalCollection<LocalProductMembershipModel, IProductMembershipModel>(this.Provider.Learning.ProductMembership.FetchAllByCancelPackId(this.Id));
                
                return _membershipCancelPack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalProductMembershipModel, IProductMembershipModel> MembershipRemind3Pack
        {
            get
            {
                if (_membershipRemind3Pack == null)
                    _membershipRemind3Pack = new LocalCollection<LocalProductMembershipModel, IProductMembershipModel>(this.Provider.Learning.ProductMembership.FetchAllByRemind3PackId(this.Id));
                
                return _membershipRemind3Pack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalProductMembershipModel, IProductMembershipModel> MembershipRenewedPack
        {
            get
            {
                if (_membershipRenewedPack == null)
                    _membershipRenewedPack = new LocalCollection<LocalProductMembershipModel, IProductMembershipModel>(this.Provider.Learning.ProductMembership.FetchAllByRenewedPackId(this.Id));
                
                return _membershipRenewedPack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalProductMembershipModel, IProductMembershipModel> MembershipAppPack
        {
            get
            {
                if (_membershipAppPack == null)
                    _membershipAppPack = new LocalCollection<LocalProductMembershipModel, IProductMembershipModel>(this.Provider.Learning.ProductMembership.FetchAllByAppPackId(this.Id));
                
                return _membershipAppPack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductMembershipModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalProductMembershipModel, IProductMembershipModel> MembershipOfferPack
        {
            get
            {
                if (_membershipOfferPack == null)
                    _membershipOfferPack = new LocalCollection<LocalProductMembershipModel, IProductMembershipModel>(this.Provider.Learning.ProductMembership.FetchAllByOfferPackId(this.Id));
                
                return _membershipOfferPack;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PackProductModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        public LocalCollection<LocalPackProductModel, IPackProductModel> PackProducts
        {
            get
            {
                if (_packProducts == null)
                    _packProducts = new LocalCollection<LocalPackProductModel, IPackProductModel>(this.Provider.Document.PackProduct.FetchAllByPackId(this.Id));
                
                return _packProducts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PackXrefModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        public LocalCollection<LocalPackXrefModel, IPackXrefModel> PackId
        {
            get
            {
                if (_packId == null)
                    _packId = new LocalCollection<LocalPackXrefModel, IPackXrefModel>(this.Provider.Document.PackXref.FetchAllByPackIdId(this.Id));
                
                return _packId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PrintRequestModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalPrintRequestModel, IPrintRequestModel> PackPrintRequests
        {
            get
            {
                if (_packPrintRequests == null)
                    _packPrintRequests = new LocalCollection<LocalPrintRequestModel, IPrintRequestModel>(this.Provider.Document.PrintRequest.FetchAllByPackId(this.Id));
                
                return _packPrintRequests;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AccountModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalAccountModel, IAccountModel> Accounts
        {
            get
            {
                if (_accounts == null)
                    _accounts = new LocalCollection<LocalAccountModel, IAccountModel>(this.Provider.Finance.Account.FetchAllByInvPackIdId(this.Id));
                
                return _accounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceModel, IInvoiceModel> Invoices
        {
            get
            {
                if (_invoices == null)
                    _invoices = new LocalCollection<LocalInvoiceModel, IInvoiceModel>(this.Provider.Finance.Invoice.FetchAllByPackId(this.Id));
                
                return _invoices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SaqQueueModel" /> instances that reference this <see cref="PackModel" />.
        /// </summary>
        public LocalCollection<LocalSaqQueueModel, ISaqQueueModel> SaqQueuePack
        {
            get
            {
                if (_saqQueuePack == null)
                    _saqQueuePack = new LocalCollection<LocalSaqQueueModel, ISaqQueueModel>(this.Provider.Marketing.SaqQueue.FetchAllByPackId(this.Id));
                
                return _saqQueuePack;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPackModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPackModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPackModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPackModel(LocalProvider provider, PackRecord record) : base(provider, record)
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
            if (_packEmailBody != null)
            {
                _packEmailBody.Save();
                this.ModifiedData.EmailBody = _packEmailBody.Id == null && this.ModifiedData.EmailBody != null ? "" : _packEmailBody.Id;
            }
            if (_packSenderId != null)
            {
                _packSenderId.Save();
                this.ModifiedData.SendProleId = _packSenderId.Id == null && this.ModifiedData.SendProleId != null ? "" : _packSenderId.Id;
            }
            if (_packOutputQueueId != null)
            {
                _packOutputQueueId.Save();
                this.ModifiedData.PqId = _packOutputQueueId.Id == null && this.ModifiedData.PqId != null ? "" : _packOutputQueueId.Id;
            }
            if (_packSellingCompanyId != null)
            {
                _packSellingCompanyId.Save();
                this.ModifiedData.SelcoSpId = _packSellingCompanyId.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _packSellingCompanyId.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_customerPacks != null)
                _customerPacks.Execute(obj => obj.PackId = this.Id).Execute(obj => obj.Save());
            if (_membershipJoiningPack != null)
                _membershipJoiningPack.Execute(obj => obj.JoiningPackId = this.Id).Execute(obj => obj.Save());
            if (_membershipRemind1Pack != null)
                _membershipRemind1Pack.Execute(obj => obj.Remind1PackId = this.Id).Execute(obj => obj.Save());
            if (_membershipRemind2Pack != null)
                _membershipRemind2Pack.Execute(obj => obj.Remind2PackId = this.Id).Execute(obj => obj.Save());
            if (_membershipRenewalPack != null)
                _membershipRenewalPack.Execute(obj => obj.RenewalPackId = this.Id).Execute(obj => obj.Save());
            if (_membershipLapsedPack != null)
                _membershipLapsedPack.Execute(obj => obj.LapsedPackId = this.Id).Execute(obj => obj.Save());
            if (_membershipCancelPack != null)
                _membershipCancelPack.Execute(obj => obj.CancelPackId = this.Id).Execute(obj => obj.Save());
            if (_membershipRemind3Pack != null)
                _membershipRemind3Pack.Execute(obj => obj.Remind3PackId = this.Id).Execute(obj => obj.Save());
            if (_membershipRenewedPack != null)
                _membershipRenewedPack.Execute(obj => obj.RenewedPackId = this.Id).Execute(obj => obj.Save());
            if (_membershipAppPack != null)
                _membershipAppPack.Execute(obj => obj.AppPackId = this.Id).Execute(obj => obj.Save());
            if (_membershipOfferPack != null)
                _membershipOfferPack.Execute(obj => obj.OfferPackId = this.Id).Execute(obj => obj.Save());
            if (_packProducts != null)
                _packProducts.Execute(obj => obj.PackId = this.Id).Execute(obj => obj.Save());
            if (_packId != null)
                _packId.Execute(obj => obj.PackIdId = this.Id).Execute(obj => obj.Save());
            if (_packPrintRequests != null)
                _packPrintRequests.Execute(obj => obj.PackId = this.Id).Execute(obj => obj.Save());
            if (_accounts != null)
                _accounts.Execute(obj => obj.InvPackIdId = this.Id).Execute(obj => obj.Save());
            if (_invoices != null)
                _invoices.Execute(obj => obj.PackId = this.Id).Execute(obj => obj.Save());
            if (_saqQueuePack != null)
                _saqQueuePack.Execute(obj => obj.PackId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "PACK_NAME" field.
        /// </summary>
        System.String IPackModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> IPackModel.PackType
        {
            get { return this.PackType; }
            set { this.PackType = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_EMAIL_SUBJECT" field.
        /// </summary>
        System.String IPackModel.EmailSubject
        {
            get { return this.EmailSubject; }
            set { this.EmailSubject = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_ACT_PQ_KEEP" field.
        /// </summary>
        System.Nullable<System.Byte> IPackModel.ActPqKeep
        {
            get { return this.ActPqKeep; }
            set { this.ActPqKeep = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACK_EMAIL_BODY" field.
        /// </summary>
        Consensus.Activities.IC4textModel IPackModel.PackEmailBody
        {
            get { return this.PackEmailBody; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACK_EMAIL_BODY" field.
        /// </summary>
        System.String IPackModel.PackEmailBodyId
        {
            get { return this.PackEmailBodyId; }
            set { this.PackEmailBodyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_STATUS" field.
        /// </summary>
        System.Byte IPackModel.Status
        {
            get { return this.Status; }
            set { this.Status = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACK_SEND_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IPackModel.PackSenderId
        {
            get { return this.PackSenderId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACK_SEND_PROLE_ID" field.
        /// </summary>
        System.String IPackModel.PackSenderIdId
        {
            get { return this.PackSenderIdId; }
            set { this.PackSenderIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_CATEGORY" field.
        /// </summary>
        System.String IPackModel.Category
        {
            get { return this.Category; }
            set { this.Category = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACK_PQ_ID" field.
        /// </summary>
        Consensus.Document.IOutputQueueModel IPackModel.PackOutputQueueId
        {
            get { return this.PackOutputQueueId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACK_PQ_ID" field.
        /// </summary>
        System.String IPackModel.PackOutputQueueIdId
        {
            get { return this.PackOutputQueueIdId; }
            set { this.PackOutputQueueIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_BCC_EMAIL" field.
        /// </summary>
        System.String IPackModel.BccEmail
        {
            get { return this.BccEmail; }
            set { this.BccEmail = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_MDN_EMAIL" field.
        /// </summary>
        System.String IPackModel.MdnEmail
        {
            get { return this.MdnEmail; }
            set { this.MdnEmail = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_DSN_EMAIL" field.
        /// </summary>
        System.String IPackModel.DsnEmail
        {
            get { return this.DsnEmail; }
            set { this.DsnEmail = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_DSN_OPTIONS" field.
        /// </summary>
        System.String IPackModel.DsnOptions
        {
            get { return this.DsnOptions; }
            set { this.DsnOptions = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACK_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IPackModel.PackSellingCompanyId
        {
            get { return this.PackSellingCompanyId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACK_SELCO_SP_ID" field.
        /// </summary>
        System.String IPackModel.PackSellingCompanyIdId
        {
            get { return this.PackSellingCompanyIdId; }
            set { this.PackSellingCompanyIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CustomerPackModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ICustomerPackModel> IPackModel.CustomerPacks
        {
            get { return this.CustomerPacks; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> IPackModel.MembershipJoiningPack
        {
            get { return this.MembershipJoiningPack; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> IPackModel.MembershipRemind1Pack
        {
            get { return this.MembershipRemind1Pack; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> IPackModel.MembershipRemind2Pack
        {
            get { return this.MembershipRemind2Pack; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> IPackModel.MembershipRenewalPack
        {
            get { return this.MembershipRenewalPack; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> IPackModel.MembershipLapsedPack
        {
            get { return this.MembershipLapsedPack; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> IPackModel.MembershipCancelPack
        {
            get { return this.MembershipCancelPack; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> IPackModel.MembershipRemind3Pack
        {
            get { return this.MembershipRemind3Pack; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> IPackModel.MembershipRenewedPack
        {
            get { return this.MembershipRenewedPack; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> IPackModel.MembershipAppPack
        {
            get { return this.MembershipAppPack; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> IPackModel.MembershipOfferPack
        {
            get { return this.MembershipOfferPack; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackProductModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackProductModel> IPackModel.PackProducts
        {
            get { return this.PackProducts; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackXrefModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackXrefModel> IPackModel.PackId
        {
            get { return this.PackId; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrintRequestModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Document.IPrintRequestModel> IPackModel.PackPrintRequests
        {
            get { return this.PackPrintRequests; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountModel> IPackModel.Accounts
        {
            get { return this.Accounts; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> IPackModel.Invoices
        {
            get { return this.Invoices; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueueModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueueModel> IPackModel.SaqQueuePack
        {
            get { return this.SaqQueuePack; }
        }

        #endregion
    }
}
