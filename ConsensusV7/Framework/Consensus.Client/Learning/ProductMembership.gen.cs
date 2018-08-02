using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Document;
using Consensus.Finance;
using Consensus.Membership;
using Consensus.Sales;

namespace Consensus.Learning
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ProductMembership : Proxy<IProductMembershipModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="JoiningPack" /> member.
        /// </summary>
        private Consensus.Document.Pack _joiningPack;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Remind1Pack" /> member.
        /// </summary>
        private Consensus.Document.Pack _remind1Pack;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Remind2Pack" /> member.
        /// </summary>
        private Consensus.Document.Pack _remind2Pack;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="RenewalPack" /> member.
        /// </summary>
        private Consensus.Document.Pack _renewalPack;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="LapsedPack" /> member.
        /// </summary>
        private Consensus.Document.Pack _lapsedPack;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="CancelPack" /> member.
        /// </summary>
        private Consensus.Document.Pack _cancelPack;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Remind3Pack" /> member.
        /// </summary>
        private Consensus.Document.Pack _remind3Pack;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="RenewedPack" /> member.
        /// </summary>
        private Consensus.Document.Pack _renewedPack;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="AppPack" /> member.
        /// </summary>
        private Consensus.Document.Pack _appPack;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="OfferPack" /> member.
        /// </summary>
        private Consensus.Document.Pack _offerPack;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MemberPeriods" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberPeriod, Consensus.Membership.IMemberPeriodModel> _memberPeriods;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MemberLocations" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberLocation, Consensus.Membership.IMemberLocationModel> _memberLocations;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ActiveProductEvent" /> member.
        /// </summary>
        private Consensus.Learning.ProductEvent _activeProductEvent;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MainSession" /> member.
        /// </summary>
        private Consensus.Learning.BillOfMaterial _mainSession;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProdDescrip" /> member.
        /// </summary>
        private Consensus.Activities.C4text _prodDescrip;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProdContent" /> member.
        /// </summary>
        private Consensus.Activities.C4text _prodContent;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProdPrereq" /> member.
        /// </summary>
        private Consensus.Activities.C4text _prodPrereq;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProdObjective" /> member.
        /// </summary>
        private Consensus.Activities.C4text _prodObjective;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Type" /> member.
        /// </summary>
        private Consensus.Common.Code _type;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Category" /> member.
        /// </summary>
        private Consensus.Common.Code _category;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Group" /> member.
        /// </summary>
        private Consensus.Common.Code _group;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="RevCode" /> member.
        /// </summary>
        private Consensus.Common.Code _revCode;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="VatCode" /> member.
        /// </summary>
        private Consensus.Common.Code _vatCode;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProleId" /> member.
        /// </summary>
        private Consensus.Contact.Role _proleId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProductManager" /> member.
        /// </summary>
        private Consensus.Contact.Role _productManager;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="BookingTerms" /> member.
        /// </summary>
        private Consensus.Finance.BookingTerms _bookingTerms;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Location" /> member.
        /// </summary>
        private Consensus.Contact.Location _location;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="AuthorPerson" /> member.
        /// </summary>
        private Consensus.Contact.Person _authorPerson;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="RegBody" /> member.
        /// </summary>
        private Consensus.Common.Code _regBody;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Venue" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _venue;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SearchGroup" /> member.
        /// </summary>
        private Consensus.Common.Code _searchGroup;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="DefDelStat" /> member.
        /// </summary>
        private Consensus.Common.Code _defDelStat;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PaymentSchedule" /> member.
        /// </summary>
        private Consensus.Finance.Payscheduleheader _paymentSchedule;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProductTrainingRules" /> member.
        /// </summary>
        private Consensus.Activities.C4text _productTrainingRules;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="DefMethDel" /> member.
        /// </summary>
        private Consensus.Common.Code _defMethDel;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Classification" /> member.
        /// </summary>
        private Consensus.Common.Code _classification;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="GatewayAccId" /> member.
        /// </summary>
        private Consensus.Common.Code _gatewayAccId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="RoyaltyModel" /> member.
        /// </summary>
        private Consensus.Common.Code _royaltyModel;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="TrainProductXref" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.TrainProdXref, Consensus.Contact.ITrainProdXrefModel> _trainProductXref;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="BillOfMaterials" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.BillOfMaterial, Consensus.Learning.IBillOfMaterialModel> _billOfMaterials;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="BOMs" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.BillOfMaterial, Consensus.Learning.IBillOfMaterialModel> _bOMs;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="AccomBOMs" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.BillOfMaterial, Consensus.Learning.IBillOfMaterialModel> _accomBOMs;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Events" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _events;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="RelatedProduct" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.RelatedProduct, Consensus.Learning.IRelatedProductModel> _relatedProduct;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ProductEvents" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.ProductEvent, Consensus.Learning.IProductEventModel> _productEvents;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Elements" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel> _elements;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ProductEP" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.EventProduct, Consensus.Learning.IEventProductModel> _productEP;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SelectGroupProduct" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.ProdSelectGroup, Consensus.Learning.IProdSelectGroupModel> _selectGroupProduct;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="TemplateResources" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.TemplateResource, Consensus.Learning.ITemplateResourceModel> _templateResources;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SessionCourse" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Session, Consensus.Learning.ISessionModel> _sessionCourse;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="OppProdId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Sales.Opportunity, Consensus.Sales.IOpportunityModel> _oppProdId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PackProducts" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.PackProduct, Consensus.Document.IPackProductModel> _packProducts;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Prices" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Price, Consensus.Finance.IPriceModel> _prices;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="InvoiceLines" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.InvoiceLine, Consensus.Finance.IInvoiceLineModel> _invoiceLines;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PrepayAccounts" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.PrepayAccount, Consensus.Finance.IPrepayAccountModel> _prepayAccounts;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ProfileProducts" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Common.ProfileProduct, Consensus.Common.IProfileProductModel> _profileProducts;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ActivityXRefs" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.ActivityXref, Consensus.Activities.IActivityXrefModel> _activityXRefs;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ParentProduct" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberBom, Consensus.Membership.IMemberBomModel> _parentProduct;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="GradeProduct" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberBom, Consensus.Membership.IMemberBomModel> _gradeProduct;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CommiteeProduct" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.Committee, Consensus.Membership.ICommitteeModel> _commiteeProduct;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets whether the membership product has a fixed renewal date.
        /// </summary>
        public System.Boolean IsRenewalFixed
        {
            get { return this.Model.IsRenewalFixed; }
            set { this.Model.IsRenewalFixed = value; }
        }

        /// <summary>
        ///     Gets or sets the day on which the fixed renewal occurs.
        /// </summary>
        public System.Int32 RenewalDay
        {
            get { return this.Model.RenewalDay; }
            set { this.Model.RenewalDay = value; }
        }

        /// <summary>
        ///     Gets or sets the month on which the fixed renewal occurs.
        /// </summary>
        public System.Int32 RenewalMonth
        {
            get { return this.Model.RenewalMonth; }
            set { this.Model.RenewalMonth = value; }
        }

        /// <summary>
        ///     Gets or sets the minimum number of days allowed for a renewing membership.
        /// </summary>
        public System.Int32 RenewalExclusion
        {
            get { return this.Model.RenewalExclusion; }
            set { this.Model.RenewalExclusion = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_NEW" field.
        /// </summary>
        public Consensus.Document.Pack JoiningPack
        {
            get
            {
                if (_joiningPack == null && this.Model.JoiningPack != null)
                    _joiningPack = new Consensus.Document.Pack(this.Model.JoiningPack);
                if (_joiningPack == null)
                    _joiningPack = Consensus.Document.Pack.Create();
                return _joiningPack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_NEW" field.
        /// </summary>
        public System.String JoiningPackId
        {
            get { return this.Model.JoiningPackId; }
            set { this.Model.JoiningPackId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_REMIND1" field.
        /// </summary>
        public Consensus.Document.Pack Remind1Pack
        {
            get
            {
                if (_remind1Pack == null && this.Model.Remind1Pack != null)
                    _remind1Pack = new Consensus.Document.Pack(this.Model.Remind1Pack);
                if (_remind1Pack == null)
                    _remind1Pack = Consensus.Document.Pack.Create();
                return _remind1Pack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_REMIND1" field.
        /// </summary>
        public System.String Remind1PackId
        {
            get { return this.Model.Remind1PackId; }
            set { this.Model.Remind1PackId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_REMIND2" field.
        /// </summary>
        public Consensus.Document.Pack Remind2Pack
        {
            get
            {
                if (_remind2Pack == null && this.Model.Remind2Pack != null)
                    _remind2Pack = new Consensus.Document.Pack(this.Model.Remind2Pack);
                if (_remind2Pack == null)
                    _remind2Pack = Consensus.Document.Pack.Create();
                return _remind2Pack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_REMIND2" field.
        /// </summary>
        public System.String Remind2PackId
        {
            get { return this.Model.Remind2PackId; }
            set { this.Model.Remind2PackId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_RENEW" field.
        /// </summary>
        public Consensus.Document.Pack RenewalPack
        {
            get
            {
                if (_renewalPack == null && this.Model.RenewalPack != null)
                    _renewalPack = new Consensus.Document.Pack(this.Model.RenewalPack);
                if (_renewalPack == null)
                    _renewalPack = Consensus.Document.Pack.Create();
                return _renewalPack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_RENEW" field.
        /// </summary>
        public System.String RenewalPackId
        {
            get { return this.Model.RenewalPackId; }
            set { this.Model.RenewalPackId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_LAPSED" field.
        /// </summary>
        public Consensus.Document.Pack LapsedPack
        {
            get
            {
                if (_lapsedPack == null && this.Model.LapsedPack != null)
                    _lapsedPack = new Consensus.Document.Pack(this.Model.LapsedPack);
                if (_lapsedPack == null)
                    _lapsedPack = Consensus.Document.Pack.Create();
                return _lapsedPack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_LAPSED" field.
        /// </summary>
        public System.String LapsedPackId
        {
            get { return this.Model.LapsedPackId; }
            set { this.Model.LapsedPackId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_CANCEL" field.
        /// </summary>
        public Consensus.Document.Pack CancelPack
        {
            get
            {
                if (_cancelPack == null && this.Model.CancelPack != null)
                    _cancelPack = new Consensus.Document.Pack(this.Model.CancelPack);
                if (_cancelPack == null)
                    _cancelPack = Consensus.Document.Pack.Create();
                return _cancelPack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_CANCEL" field.
        /// </summary>
        public System.String CancelPackId
        {
            get { return this.Model.CancelPackId; }
            set { this.Model.CancelPackId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_GROUP" field.
        /// </summary>
        public System.Nullable<System.Byte> MsGroup
        {
            get { return this.Model.MsGroup; }
            set { this.Model.MsGroup = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_RENEW_DAYS" field.
        /// </summary>
        public System.Nullable<System.Int32> RenewDays
        {
            get { return this.Model.RenewDays; }
            set { this.Model.RenewDays = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MEM_INV_TYPE" field.
        /// </summary>
        public System.Nullable<System.Byte> MemInvType
        {
            get { return this.Model.MemInvType; }
            set { this.Model.MemInvType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_REMIND3" field.
        /// </summary>
        public Consensus.Document.Pack Remind3Pack
        {
            get
            {
                if (_remind3Pack == null && this.Model.Remind3Pack != null)
                    _remind3Pack = new Consensus.Document.Pack(this.Model.Remind3Pack);
                if (_remind3Pack == null)
                    _remind3Pack = Consensus.Document.Pack.Create();
                return _remind3Pack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_REMIND3" field.
        /// </summary>
        public System.String Remind3PackId
        {
            get { return this.Model.Remind3PackId; }
            set { this.Model.Remind3PackId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_RM1_DAYS" field.
        /// </summary>
        public System.Nullable<System.Int32> Reminder1Days
        {
            get { return this.Model.Reminder1Days; }
            set { this.Model.Reminder1Days = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_RM2_DAYS" field.
        /// </summary>
        public System.Nullable<System.Int32> Reminder2Days
        {
            get { return this.Model.Reminder2Days; }
            set { this.Model.Reminder2Days = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_RM3_DAYS" field.
        /// </summary>
        public System.Nullable<System.Int32> Reminder3Days
        {
            get { return this.Model.Reminder3Days; }
            set { this.Model.Reminder3Days = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_LAPS_DAYS" field.
        /// </summary>
        public System.Nullable<System.Int32> LapsedDays
        {
            get { return this.Model.LapsedDays; }
            set { this.Model.LapsedDays = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_RENEWED" field.
        /// </summary>
        public Consensus.Document.Pack RenewedPack
        {
            get
            {
                if (_renewedPack == null && this.Model.RenewedPack != null)
                    _renewedPack = new Consensus.Document.Pack(this.Model.RenewedPack);
                if (_renewedPack == null)
                    _renewedPack = Consensus.Document.Pack.Create();
                return _renewedPack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_RENEWED" field.
        /// </summary>
        public System.String RenewedPackId
        {
            get { return this.Model.RenewedPackId; }
            set { this.Model.RenewedPackId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXCL_CALC" field.
        /// </summary>
        public System.Nullable<System.Byte> ExclCalc
        {
            get { return this.Model.ExclCalc; }
            set { this.Model.ExclCalc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SG_NO" field.
        /// </summary>
        public System.Nullable<System.Int32> NumberOfSpecialistGroups
        {
            get { return this.Model.NumberOfSpecialistGroups; }
            set { this.Model.NumberOfSpecialistGroups = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_APP" field.
        /// </summary>
        public Consensus.Document.Pack AppPack
        {
            get
            {
                if (_appPack == null && this.Model.AppPack != null)
                    _appPack = new Consensus.Document.Pack(this.Model.AppPack);
                if (_appPack == null)
                    _appPack = Consensus.Document.Pack.Create();
                return _appPack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_APP" field.
        /// </summary>
        public System.String AppPackId
        {
            get { return this.Model.AppPackId; }
            set { this.Model.AppPackId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_OFF" field.
        /// </summary>
        public Consensus.Document.Pack OfferPack
        {
            get
            {
                if (_offerPack == null && this.Model.OfferPack != null)
                    _offerPack = new Consensus.Document.Pack(this.Model.OfferPack);
                if (_offerPack == null)
                    _offerPack = Consensus.Document.Pack.Create();
                return _offerPack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_OFF" field.
        /// </summary>
        public System.String OfferPackId
        {
            get { return this.Model.OfferPackId; }
            set { this.Model.OfferPackId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_NO_INV_RENEW" field.
        /// </summary>
        public System.Nullable<System.Byte> NoInvRenew
        {
            get { return this.Model.NoInvRenew; }
            set { this.Model.NoInvRenew = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_PREFIX" field.
        /// </summary>
        public System.String Prefix
        {
            get { return this.Model.Prefix; }
            set { this.Model.Prefix = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_NON_RENEW_MEMB" field.
        /// </summary>
        public System.Byte NonRenewMemb
        {
            get { return this.Model.NonRenewMemb; }
            set { this.Model.NonRenewMemb = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DD_NO_OF_INSTALLMENTS" field.
        /// </summary>
        public System.Nullable<System.Int32> DdNoOfInstallments
        {
            get { return this.Model.DdNoOfInstallments; }
            set { this.Model.DdNoOfInstallments = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DD_FREQUENCY" field.
        /// </summary>
        public System.Nullable<System.Int32> DdFrequency
        {
            get { return this.Model.DdFrequency; }
            set { this.Model.DdFrequency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MEM_FIRST_BOOK" field.
        /// </summary>
        public System.Byte MemFirstBook
        {
            get { return this.Model.MemFirstBook; }
            set { this.Model.MemFirstBook = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:ProductMembershipModel" />.
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

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:ProductMembershipModel" />.
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

        /// <summary>
        ///     Gets or sets the academic code.
        /// </summary>
        public Consensus.Learning.ProductEvent ActiveProductEvent
        {
            get
            {
                if (_activeProductEvent == null && this.Model.ActiveProductEvent != null)
                    _activeProductEvent = new Consensus.Learning.ProductEvent(this.Model.ActiveProductEvent);
                if (_activeProductEvent == null)
                    _activeProductEvent = Consensus.Learning.ProductEvent.Create();
                return _activeProductEvent;
            }
        }

        /// <summary>
        ///     Gets or sets the main session.
        /// </summary>
        public Consensus.Learning.BillOfMaterial MainSession
        {
            get
            {
                if (_mainSession == null && this.Model.MainSession != null)
                    _mainSession = new Consensus.Learning.BillOfMaterial(this.Model.MainSession);
                if (_mainSession == null)
                    _mainSession = Consensus.Learning.BillOfMaterial.Create();
                return _mainSession;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_REF" field.
        /// </summary>
        public System.String Ref
        {
            get { return this.Model.Ref; }
            set { this.Model.Ref = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_DESCRIP" field.
        /// </summary>
        public Consensus.Activities.C4text ProdDescrip
        {
            get
            {
                if (_prodDescrip == null && this.Model.ProdDescrip != null)
                    _prodDescrip = new Consensus.Activities.C4text(this.Model.ProdDescrip);
                if (_prodDescrip == null)
                    _prodDescrip = Consensus.Activities.C4text.Create();
                return _prodDescrip;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_DESCRIP" field.
        /// </summary>
        public System.String ProdDescripId
        {
            get { return this.Model.ProdDescripId; }
            set { this.Model.ProdDescripId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TEXT1" field.
        /// </summary>
        public Consensus.Activities.C4text ProdContent
        {
            get
            {
                if (_prodContent == null && this.Model.ProdContent != null)
                    _prodContent = new Consensus.Activities.C4text(this.Model.ProdContent);
                if (_prodContent == null)
                    _prodContent = Consensus.Activities.C4text.Create();
                return _prodContent;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TEXT1" field.
        /// </summary>
        public System.String ProdContentId
        {
            get { return this.Model.ProdContentId; }
            set { this.Model.ProdContentId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TEXT2" field.
        /// </summary>
        public Consensus.Activities.C4text ProdPrereq
        {
            get
            {
                if (_prodPrereq == null && this.Model.ProdPrereq != null)
                    _prodPrereq = new Consensus.Activities.C4text(this.Model.ProdPrereq);
                if (_prodPrereq == null)
                    _prodPrereq = Consensus.Activities.C4text.Create();
                return _prodPrereq;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TEXT2" field.
        /// </summary>
        public System.String ProdPrereqId
        {
            get { return this.Model.ProdPrereqId; }
            set { this.Model.ProdPrereqId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TEXT3" field.
        /// </summary>
        public Consensus.Activities.C4text ProdObjective
        {
            get
            {
                if (_prodObjective == null && this.Model.ProdObjective != null)
                    _prodObjective = new Consensus.Activities.C4text(this.Model.ProdObjective);
                if (_prodObjective == null)
                    _prodObjective = Consensus.Activities.C4text.Create();
                return _prodObjective;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TEXT3" field.
        /// </summary>
        public System.String ProdObjectiveId
        {
            get { return this.Model.ProdObjectiveId; }
            set { this.Model.ProdObjectiveId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SY_PRODUCT" field.
        /// </summary>
        public System.Nullable<System.Byte> SyProduct
        {
            get { return this.Model.SyProduct; }
            set { this.Model.SyProduct = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TYPE" field.
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
        ///     Gets or sets the unique code for the value of the "PROD_TYPE" field.
        /// </summary>
        public System.String TypeCode
        {
            get { return this.Model.TypeCode; }
            set { this.Model.TypeCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_CATEGORY" field.
        /// </summary>
        public Consensus.Common.Code Category
        {
            get
            {
                if (_category == null && this.Model.Category != null)
                    _category = new Consensus.Common.Code(this.Model.Category);
                if (_category == null)
                    _category = Consensus.Common.Code.Create();
                return _category;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_CATEGORY" field.
        /// </summary>
        public System.String CategoryCode
        {
            get { return this.Model.CategoryCode; }
            set { this.Model.CategoryCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_GROUP" field.
        /// </summary>
        public Consensus.Common.Code Group
        {
            get
            {
                if (_group == null && this.Model.Group != null)
                    _group = new Consensus.Common.Code(this.Model.Group);
                if (_group == null)
                    _group = Consensus.Common.Code.Create();
                return _group;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_GROUP" field.
        /// </summary>
        public System.String GroupCode
        {
            get { return this.Model.GroupCode; }
            set { this.Model.GroupCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_PRICE" field.
        /// </summary>
        public System.Nullable<System.Double> Price
        {
            get { return this.Model.Price; }
            set { this.Model.Price = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_BLOCK_PRICE" field.
        /// </summary>
        public System.Nullable<System.Double> BlockPrice
        {
            get { return this.Model.BlockPrice; }
            set { this.Model.BlockPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SPARE_PRICE" field.
        /// </summary>
        public System.Nullable<System.Double> SparePrice
        {
            get { return this.Model.SparePrice; }
            set { this.Model.SparePrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_COST_PRICE" field.
        /// </summary>
        public System.Nullable<System.Double> CostPrice
        {
            get { return this.Model.CostPrice; }
            set { this.Model.CostPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_COST_CODE" field.
        /// </summary>
        public System.String CostCode
        {
            get { return this.Model.CostCode; }
            set { this.Model.CostCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_REV_CODE" field.
        /// </summary>
        public Consensus.Common.Code RevCode
        {
            get
            {
                if (_revCode == null && this.Model.RevCode != null)
                    _revCode = new Consensus.Common.Code(this.Model.RevCode);
                if (_revCode == null)
                    _revCode = Consensus.Common.Code.Create();
                return _revCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_REV_CODE" field.
        /// </summary>
        public System.String RevCodeCode
        {
            get { return this.Model.RevCodeCode; }
            set { this.Model.RevCodeCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_VAT_CODE" field.
        /// </summary>
        public Consensus.Common.Code VatCode
        {
            get
            {
                if (_vatCode == null && this.Model.VatCode != null)
                    _vatCode = new Consensus.Common.Code(this.Model.VatCode);
                if (_vatCode == null)
                    _vatCode = Consensus.Common.Code.Create();
                return _vatCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_VAT_CODE" field.
        /// </summary>
        public System.String VatCodeCode
        {
            get { return this.Model.VatCodeCode; }
            set { this.Model.VatCodeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MIN_ATTEND" field.
        /// </summary>
        public System.Nullable<System.Double> MinAttend
        {
            get { return this.Model.MinAttend; }
            set { this.Model.MinAttend = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MAX_ATTEND" field.
        /// </summary>
        public System.Nullable<System.Double> MaxAttend
        {
            get { return this.Model.MaxAttend; }
            set { this.Model.MaxAttend = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_COURSE_LEN" field.
        /// </summary>
        public System.Nullable<System.Double> CourseLen
        {
            get { return this.Model.CourseLen; }
            set { this.Model.CourseLen = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SPARE_FLAG1" field.
        /// </summary>
        public System.Nullable<System.Byte> CanChangeCostCode
        {
            get { return this.Model.CanChangeCostCode; }
            set { this.Model.CanChangeCostCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_ENTRY_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> EntryDate
        {
            get { return this.Model.EntryDate; }
            set { this.Model.EntryDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CODE" field.
        /// </summary>
        public System.String SchemeNo
        {
            get { return this.Model.SchemeNo; }
            set { this.Model.SchemeNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SELL_HINT" field.
        /// </summary>
        public System.String ProdSellHint
        {
            get { return this.Model.ProdSellHint; }
            set { this.Model.ProdSellHint = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_TOP_LEVEL" field.
        /// </summary>
        public System.Nullable<System.Byte> TopLevel
        {
            get { return this.Model.TopLevel; }
            set { this.Model.TopLevel = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_STATE" field.
        /// </summary>
        public System.Nullable<System.Byte> State
        {
            get { return this.Model.State; }
            set { this.Model.State = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_STOCKED" field.
        /// </summary>
        public System.Nullable<System.Byte> Stocked
        {
            get { return this.Model.Stocked; }
            set { this.Model.Stocked = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_QTY_AV" field.
        /// </summary>
        public System.Nullable<System.Double> QtyAv
        {
            get { return this.Model.QtyAv; }
            set { this.Model.QtyAv = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_QTY_AC" field.
        /// </summary>
        public System.Nullable<System.Double> QtyAc
        {
            get { return this.Model.QtyAc; }
            set { this.Model.QtyAc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_TRN_TXT_ID" field.
        /// </summary>
        public System.String TrnTxtId
        {
            get { return this.Model.TrnTxtId; }
            set { this.Model.TrnTxtId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PROD_PROLE_ID" field.
        /// </summary>
        public System.String ProleIdId
        {
            get { return this.Model.ProleIdId; }
            set { this.Model.ProleIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MAN_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role ProductManager
        {
            get
            {
                if (_productManager == null && this.Model.ProductManager != null)
                    _productManager = new Consensus.Contact.Role(this.Model.ProductManager);
                if (_productManager == null)
                    _productManager = Consensus.Contact.Role.Create();
                return _productManager;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MAN_PROLE_ID" field.
        /// </summary>
        public System.String ProductManagerId
        {
            get { return this.Model.ProductManagerId; }
            set { this.Model.ProductManagerId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_BKT_ID" field.
        /// </summary>
        public Consensus.Finance.BookingTerms BookingTerms
        {
            get
            {
                if (_bookingTerms == null && this.Model.BookingTerms != null)
                    _bookingTerms = new Consensus.Finance.BookingTerms(this.Model.BookingTerms);
                if (_bookingTerms == null)
                    _bookingTerms = Consensus.Finance.BookingTerms.Create();
                return _bookingTerms;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_BKT_ID" field.
        /// </summary>
        public System.String BookingTermsId
        {
            get { return this.Model.BookingTermsId; }
            set { this.Model.BookingTermsId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_LOC_ID" field.
        /// </summary>
        public Consensus.Contact.Location Location
        {
            get
            {
                if (_location == null && this.Model.Location != null)
                    _location = new Consensus.Contact.Location(this.Model.Location);
                if (_location == null)
                    _location = Consensus.Contact.Location.Create();
                return _location;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_LOC_ID" field.
        /// </summary>
        public System.String LocationId
        {
            get { return this.Model.LocationId; }
            set { this.Model.LocationId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_WEB" field.
        /// </summary>
        public System.Nullable<System.Byte> Web
        {
            get { return this.Model.Web; }
            set { this.Model.Web = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "prod_quantity" field.
        /// </summary>
        public System.Nullable<System.Double> ProdQuantity
        {
            get { return this.Model.ProdQuantity; }
            set { this.Model.ProdQuantity = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PROD_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_AUTH_PN_ID" field.
        /// </summary>
        public Consensus.Contact.Person AuthorPerson
        {
            get
            {
                if (_authorPerson == null && this.Model.AuthorPerson != null)
                    _authorPerson = new Consensus.Contact.Person(this.Model.AuthorPerson);
                if (_authorPerson == null)
                    _authorPerson = Consensus.Contact.Person.Create();
                return _authorPerson;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_AUTH_PN_ID" field.
        /// </summary>
        public System.String AuthorPersonId
        {
            get { return this.Model.AuthorPersonId; }
            set { this.Model.AuthorPersonId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_ISBN" field.
        /// </summary>
        public System.String Isbn
        {
            get { return this.Model.Isbn; }
            set { this.Model.Isbn = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_PAGE_COUNT" field.
        /// </summary>
        public System.Nullable<System.Int32> PageCount
        {
            get { return this.Model.PageCount; }
            set { this.Model.PageCount = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_FREQ" field.
        /// </summary>
        public System.Nullable<System.Int32> Freq
        {
            get { return this.Model.Freq; }
            set { this.Model.Freq = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_REG_BODY_ID_1" field.
        /// </summary>
        public Consensus.Common.Code RegBody
        {
            get
            {
                if (_regBody == null && this.Model.RegBody != null)
                    _regBody = new Consensus.Common.Code(this.Model.RegBody);
                if (_regBody == null)
                    _regBody = Consensus.Common.Code.Create();
                return _regBody;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_REG_BODY_ID_1" field.
        /// </summary>
        public System.String RegBodyCode
        {
            get { return this.Model.RegBodyCode; }
            set { this.Model.RegBodyCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_REG_BODY_ID_2" field.
        /// </summary>
        public System.String RegBodyRef
        {
            get { return this.Model.RegBodyRef; }
            set { this.Model.RegBodyRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_KEYWORDS" field.
        /// </summary>
        public System.String Keywords
        {
            get { return this.Model.Keywords; }
            set { this.Model.Keywords = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CUT_PRD" field.
        /// </summary>
        public System.Nullable<System.Int32> CutOffPeriod
        {
            get { return this.Model.CutOffPeriod; }
            set { this.Model.CutOffPeriod = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_FUNDED" field.
        /// </summary>
        public System.Nullable<System.Byte> Funded
        {
            get { return this.Model.Funded; }
            set { this.Model.Funded = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_FUNDED_ORG_ID" field.
        /// </summary>
        public System.String FundingBody
        {
            get { return this.Model.FundingBody; }
            set { this.Model.FundingBody = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_QUAL_DEL" field.
        /// </summary>
        public System.Nullable<System.Byte> QualDel
        {
            get { return this.Model.QualDel; }
            set { this.Model.QualDel = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_ORG_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation Venue
        {
            get
            {
                if (_venue == null && this.Model.Venue != null)
                    _venue = new Consensus.Contact.Organisation(this.Model.Venue);
                if (_venue == null)
                    _venue = Consensus.Contact.Organisation.Create();
                return _venue;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_ORG_ID" field.
        /// </summary>
        public System.String VenueId
        {
            get { return this.Model.VenueId; }
            set { this.Model.VenueId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CALC_COMMISSION" field.
        /// </summary>
        public System.Nullable<System.Byte> CalcCommission
        {
            get { return this.Model.CalcCommission; }
            set { this.Model.CalcCommission = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DEF_TRAINEE_DAYS" field.
        /// </summary>
        public System.Nullable<System.Decimal> DefTraineeDays
        {
            get { return this.Model.DefTraineeDays; }
            set { this.Model.DefTraineeDays = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_GRANT_ELIGIBLE" field.
        /// </summary>
        public System.Nullable<System.Byte> GrantEligible
        {
            get { return this.Model.GrantEligible; }
            set { this.Model.GrantEligible = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_GRANT_VALUE_AVAILABLE" field.
        /// </summary>
        public System.Nullable<System.Decimal> GrantValueAvailable
        {
            get { return this.Model.GrantValueAvailable; }
            set { this.Model.GrantValueAvailable = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_BREAKEVEN_1" field.
        /// </summary>
        public System.Nullable<System.Decimal> Breakeven1
        {
            get { return this.Model.Breakeven1; }
            set { this.Model.Breakeven1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_BREAKEVEN_2" field.
        /// </summary>
        public System.Nullable<System.Decimal> Breakeven2
        {
            get { return this.Model.Breakeven2; }
            set { this.Model.Breakeven2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXT_COURSEWARE" field.
        /// </summary>
        public System.Nullable<System.Byte> ExtCourseware
        {
            get { return this.Model.ExtCourseware; }
            set { this.Model.ExtCourseware = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CONTINGENCY" field.
        /// </summary>
        public System.Nullable<System.Int32> Contingency
        {
            get { return this.Model.Contingency; }
            set { this.Model.Contingency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_COST" field.
        /// </summary>
        public System.Nullable<System.Decimal> Cost
        {
            get { return this.Model.Cost; }
            set { this.Model.Cost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DELIVERY_DAY" field.
        /// </summary>
        public System.Nullable<System.Int32> DeliveryDay
        {
            get { return this.Model.DeliveryDay; }
            set { this.Model.DeliveryDay = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXT_URL" field.
        /// </summary>
        public System.String ExtUrl
        {
            get { return this.Model.ExtUrl; }
            set { this.Model.ExtUrl = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_NONE_CHARGEABLE" field.
        /// </summary>
        public System.Byte NoneChargeable
        {
            get { return this.Model.NoneChargeable; }
            set { this.Model.NoneChargeable = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DESIG_LETTERS" field.
        /// </summary>
        public System.String DesigLetters
        {
            get { return this.Model.DesigLetters; }
            set { this.Model.DesigLetters = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXPIRY_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> ExpiryDate
        {
            get { return this.Model.ExpiryDate; }
            set { this.Model.ExpiryDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_INV_ZERO_VAL" field.
        /// </summary>
        public System.Int32 InvZeroVal
        {
            get { return this.Model.InvZeroVal; }
            set { this.Model.InvZeroVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXCLUDE_TRAIN_HISTORY" field.
        /// </summary>
        public System.Byte ExcludeTrainHistory
        {
            get { return this.Model.ExcludeTrainHistory; }
            set { this.Model.ExcludeTrainHistory = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_START_DATE_TYPE" field.
        /// </summary>
        public System.Byte StartDateType
        {
            get { return this.Model.StartDateType; }
            set { this.Model.StartDateType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_START_DATE_FIXED" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartDateFixed
        {
            get { return this.Model.StartDateFixed; }
            set { this.Model.StartDateFixed = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_START_DATE_OFFSET" field.
        /// </summary>
        public System.Int32 StartDateOffset
        {
            get { return this.Model.StartDateOffset; }
            set { this.Model.StartDateOffset = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_START_DATE_OFFSET_TYPE" field.
        /// </summary>
        public System.String StartDateOffsetType
        {
            get { return this.Model.StartDateOffsetType; }
            set { this.Model.StartDateOffsetType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_END_DATE_TYPE" field.
        /// </summary>
        public System.Byte EndDateType
        {
            get { return this.Model.EndDateType; }
            set { this.Model.EndDateType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_END_DATE_FIXED" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndDateFixed
        {
            get { return this.Model.EndDateFixed; }
            set { this.Model.EndDateFixed = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_END_DATE_OFFSET" field.
        /// </summary>
        public System.Int32 EndDateOffset
        {
            get { return this.Model.EndDateOffset; }
            set { this.Model.EndDateOffset = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_END_DATE_OFFSET_TYPE" field.
        /// </summary>
        public System.String EndDateOffsetType
        {
            get { return this.Model.EndDateOffsetType; }
            set { this.Model.EndDateOffsetType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DESC_EDITABLE" field.
        /// </summary>
        public System.Byte DescEditable
        {
            get { return this.Model.DescEditable; }
            set { this.Model.DescEditable = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_AUTHOR_NAME" field.
        /// </summary>
        public System.String AuthorName
        {
            get { return this.Model.AuthorName; }
            set { this.Model.AuthorName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_PREPAY_UNITS" field.
        /// </summary>
        public System.Nullable<System.Int32> PrepayUnits
        {
            get { return this.Model.PrepayUnits; }
            set { this.Model.PrepayUnits = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DELIV_METHOD" field.
        /// </summary>
        public System.String DelivMethod
        {
            get { return this.Model.DelivMethod; }
            set { this.Model.DelivMethod = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_SEARCH_GROUP" field.
        /// </summary>
        public Consensus.Common.Code SearchGroup
        {
            get
            {
                if (_searchGroup == null && this.Model.SearchGroup != null)
                    _searchGroup = new Consensus.Common.Code(this.Model.SearchGroup);
                if (_searchGroup == null)
                    _searchGroup = Consensus.Common.Code.Create();
                return _searchGroup;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_SEARCH_GROUP" field.
        /// </summary>
        public System.String SearchGroupCode
        {
            get { return this.Model.SearchGroupCode; }
            set { this.Model.SearchGroupCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_DEF_ELEM_ST" field.
        /// </summary>
        public Consensus.Common.Code DefDelStat
        {
            get
            {
                if (_defDelStat == null && this.Model.DefDelStat != null)
                    _defDelStat = new Consensus.Common.Code(this.Model.DefDelStat);
                if (_defDelStat == null)
                    _defDelStat = Consensus.Common.Code.Create();
                return _defDelStat;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_DEF_ELEM_ST" field.
        /// </summary>
        public System.String DefDelStatCode
        {
            get { return this.Model.DefDelStatCode; }
            set { this.Model.DefDelStatCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SHORT_DESC" field.
        /// </summary>
        public System.String ProductSummary
        {
            get { return this.Model.ProductSummary; }
            set { this.Model.ProductSummary = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_ONECLICK_CHECKOUT" field.
        /// </summary>
        public System.Byte OneclickCheckout
        {
            get { return this.Model.OneclickCheckout; }
            set { this.Model.OneclickCheckout = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_BOOKER_ONLY" field.
        /// </summary>
        public System.Byte BookerOnly
        {
            get { return this.Model.BookerOnly; }
            set { this.Model.BookerOnly = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DEPT" field.
        /// </summary>
        public System.String Dept
        {
            get { return this.Model.Dept; }
            set { this.Model.Dept = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SKU" field.
        /// </summary>
        public System.String Sku
        {
            get { return this.Model.Sku; }
            set { this.Model.Sku = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_JOB_CODE" field.
        /// </summary>
        public System.String JobCode
        {
            get { return this.Model.JobCode; }
            set { this.Model.JobCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_JOB_ANALY_CODE" field.
        /// </summary>
        public System.String JobAnalyCode
        {
            get { return this.Model.JobAnalyCode; }
            set { this.Model.JobAnalyCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_JOB_TYPE" field.
        /// </summary>
        public System.String JobType
        {
            get { return this.Model.JobType; }
            set { this.Model.JobType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_JOB_PARENT" field.
        /// </summary>
        public System.String JobParent
        {
            get { return this.Model.JobParent; }
            set { this.Model.JobParent = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_PSH_ID" field.
        /// </summary>
        public Consensus.Finance.Payscheduleheader PaymentSchedule
        {
            get
            {
                if (_paymentSchedule == null && this.Model.PaymentSchedule != null)
                    _paymentSchedule = new Consensus.Finance.Payscheduleheader(this.Model.PaymentSchedule);
                if (_paymentSchedule == null)
                    _paymentSchedule = Consensus.Finance.Payscheduleheader.Create();
                return _paymentSchedule;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_PSH_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> PaymentScheduleId
        {
            get { return this.Model.PaymentScheduleId; }
            set { this.Model.PaymentScheduleId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_IMAGE" field.
        /// </summary>
        public System.String Image
        {
            get { return this.Model.Image; }
            set { this.Model.Image = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_ONLINE_SCHE" field.
        /// </summary>
        public System.String OnlineSchedule
        {
            get { return this.Model.OnlineSchedule; }
            set { this.Model.OnlineSchedule = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_URL_NAME" field.
        /// </summary>
        public System.String UrlName
        {
            get { return this.Model.UrlName; }
            set { this.Model.UrlName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_TRAIN_PROV" field.
        /// </summary>
        public System.Nullable<System.Byte> TrainProv
        {
            get { return this.Model.TrainProv; }
            set { this.Model.TrainProv = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_LICENSED" field.
        /// </summary>
        public System.Byte Licensed
        {
            get { return this.Model.Licensed; }
            set { this.Model.Licensed = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DEL_CLOSE_DAYS" field.
        /// </summary>
        public System.Int32 DelCloseDays
        {
            get { return this.Model.DelCloseDays; }
            set { this.Model.DelCloseDays = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TRN_RULES_TXT" field.
        /// </summary>
        public Consensus.Activities.C4text ProductTrainingRules
        {
            get
            {
                if (_productTrainingRules == null && this.Model.ProductTrainingRules != null)
                    _productTrainingRules = new Consensus.Activities.C4text(this.Model.ProductTrainingRules);
                if (_productTrainingRules == null)
                    _productTrainingRules = Consensus.Activities.C4text.Create();
                return _productTrainingRules;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TRN_RULES_TXT" field.
        /// </summary>
        public System.String ProductTrainingRulesId
        {
            get { return this.Model.ProductTrainingRulesId; }
            set { this.Model.ProductTrainingRulesId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_DEF_METH_DEL" field.
        /// </summary>
        public Consensus.Common.Code DefMethDel
        {
            get
            {
                if (_defMethDel == null && this.Model.DefMethDel != null)
                    _defMethDel = new Consensus.Common.Code(this.Model.DefMethDel);
                if (_defMethDel == null)
                    _defMethDel = Consensus.Common.Code.Create();
                return _defMethDel;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_DEF_METH_DEL" field.
        /// </summary>
        public System.String DefMethDelCode
        {
            get { return this.Model.DefMethDelCode; }
            set { this.Model.DefMethDelCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_CODE_IMAGE" field.
        /// </summary>
        public Consensus.Common.Code Classification
        {
            get
            {
                if (_classification == null && this.Model.Classification != null)
                    _classification = new Consensus.Common.Code(this.Model.Classification);
                if (_classification == null)
                    _classification = Consensus.Common.Code.Create();
                return _classification;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_CODE_IMAGE" field.
        /// </summary>
        public System.String ClassificationCode
        {
            get { return this.Model.ClassificationCode; }
            set { this.Model.ClassificationCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_GATEWAY_ACC_ID" field.
        /// </summary>
        public Consensus.Common.Code GatewayAccId
        {
            get
            {
                if (_gatewayAccId == null && this.Model.GatewayAccId != null)
                    _gatewayAccId = new Consensus.Common.Code(this.Model.GatewayAccId);
                if (_gatewayAccId == null)
                    _gatewayAccId = Consensus.Common.Code.Create();
                return _gatewayAccId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_GATEWAY_ACC_ID" field.
        /// </summary>
        public System.String GatewayAccIdCode
        {
            get { return this.Model.GatewayAccIdCode; }
            set { this.Model.GatewayAccIdCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_ROYALTY_MODEL" field.
        /// </summary>
        public Consensus.Common.Code RoyaltyModel
        {
            get
            {
                if (_royaltyModel == null && this.Model.RoyaltyModel != null)
                    _royaltyModel = new Consensus.Common.Code(this.Model.RoyaltyModel);
                if (_royaltyModel == null)
                    _royaltyModel = Consensus.Common.Code.Create();
                return _royaltyModel;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_ROYALTY_MODEL" field.
        /// </summary>
        public System.String RoyaltyModelCode
        {
            get { return this.Model.RoyaltyModelCode; }
            set { this.Model.RoyaltyModelCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CUT_PRD_TIME" field.
        /// </summary>
        public System.Nullable<System.Byte> CutOffTime
        {
            get { return this.Model.CutOffTime; }
            set { this.Model.CutOffTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_GIFTAID" field.
        /// </summary>
        public System.Nullable<System.Byte> Giftaid
        {
            get { return this.Model.Giftaid; }
            set { this.Model.Giftaid = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainProdXrefModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Contact.TrainProdXref> TrainProductXref
        {
            get
            {
                if (_trainProductXref == null)
                    _trainProductXref = new ProxyCollection<Consensus.Contact.TrainProdXref, Consensus.Contact.ITrainProdXrefModel>(this.Model.TrainProductXref, model => new Consensus.Contact.TrainProdXref(model));
                return _trainProductXref;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BillOfMaterialModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Learning.BillOfMaterial> BillOfMaterials
        {
            get
            {
                if (_billOfMaterials == null)
                    _billOfMaterials = new ProxyCollection<Consensus.Learning.BillOfMaterial, Consensus.Learning.IBillOfMaterialModel>(this.Model.BillOfMaterials, model => new Consensus.Learning.BillOfMaterial(model));
                return _billOfMaterials;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BillOfMaterialModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Learning.BillOfMaterial> BOMs
        {
            get
            {
                if (_bOMs == null)
                    _bOMs = new ProxyCollection<Consensus.Learning.BillOfMaterial, Consensus.Learning.IBillOfMaterialModel>(this.Model.BOMs, model => new Consensus.Learning.BillOfMaterial(model));
                return _bOMs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BillOfMaterialModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Learning.BillOfMaterial> AccomBOMs
        {
            get
            {
                if (_accomBOMs == null)
                    _accomBOMs = new ProxyCollection<Consensus.Learning.BillOfMaterial, Consensus.Learning.IBillOfMaterialModel>(this.Model.AccomBOMs, model => new Consensus.Learning.BillOfMaterial(model));
                return _accomBOMs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Event> Events
        {
            get
            {
                if (_events == null)
                    _events = new ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel>(this.Model.Events, model => new Consensus.Learning.Event(model));
                return _events;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RelatedProductModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Learning.RelatedProduct> RelatedProduct
        {
            get
            {
                if (_relatedProduct == null)
                    _relatedProduct = new ProxyCollection<Consensus.Learning.RelatedProduct, Consensus.Learning.IRelatedProductModel>(this.Model.RelatedProduct, model => new Consensus.Learning.RelatedProduct(model));
                return _relatedProduct;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductEventModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Learning.ProductEvent> ProductEvents
        {
            get
            {
                if (_productEvents == null)
                    _productEvents = new ProxyCollection<Consensus.Learning.ProductEvent, Consensus.Learning.IProductEventModel>(this.Model.ProductEvents, model => new Consensus.Learning.ProductEvent(model));
                return _productEvents;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Element> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel>(this.Model.Elements, model => new Consensus.Learning.Element(model));
                return _elements;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventProductModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Learning.EventProduct> ProductEP
        {
            get
            {
                if (_productEP == null)
                    _productEP = new ProxyCollection<Consensus.Learning.EventProduct, Consensus.Learning.IEventProductModel>(this.Model.ProductEP, model => new Consensus.Learning.EventProduct(model));
                return _productEP;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProdSelectGroupModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Learning.ProdSelectGroup> SelectGroupProduct
        {
            get
            {
                if (_selectGroupProduct == null)
                    _selectGroupProduct = new ProxyCollection<Consensus.Learning.ProdSelectGroup, Consensus.Learning.IProdSelectGroupModel>(this.Model.SelectGroupProduct, model => new Consensus.Learning.ProdSelectGroup(model));
                return _selectGroupProduct;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TemplateResourceModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Learning.TemplateResource> TemplateResources
        {
            get
            {
                if (_templateResources == null)
                    _templateResources = new ProxyCollection<Consensus.Learning.TemplateResource, Consensus.Learning.ITemplateResourceModel>(this.Model.TemplateResources, model => new Consensus.Learning.TemplateResource(model));
                return _templateResources;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Session> SessionCourse
        {
            get
            {
                if (_sessionCourse == null)
                    _sessionCourse = new ProxyCollection<Consensus.Learning.Session, Consensus.Learning.ISessionModel>(this.Model.SessionCourse, model => new Consensus.Learning.Session(model));
                return _sessionCourse;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Sales.Opportunity> OppProdId
        {
            get
            {
                if (_oppProdId == null)
                    _oppProdId = new ProxyCollection<Consensus.Sales.Opportunity, Consensus.Sales.IOpportunityModel>(this.Model.OppProdId, model => new Consensus.Sales.Opportunity(model));
                return _oppProdId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackProductModel" /> instances that reference this <see cref="!:ProductModel" />.
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
        ///     Gets the collection of <see cref="!:PriceModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Finance.Price> Prices
        {
            get
            {
                if (_prices == null)
                    _prices = new ProxyCollection<Consensus.Finance.Price, Consensus.Finance.IPriceModel>(this.Model.Prices, model => new Consensus.Finance.Price(model));
                return _prices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:ProductModel" />.
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
        ///     Gets the collection of <see cref="!:PrepayAccountModel" /> instances that reference this <see cref="!:ProductModel" />.
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
        ///     Gets the collection of <see cref="!:ProfileProductModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Common.ProfileProduct> ProfileProducts
        {
            get
            {
                if (_profileProducts == null)
                    _profileProducts = new ProxyCollection<Consensus.Common.ProfileProduct, Consensus.Common.IProfileProductModel>(this.Model.ProfileProducts, model => new Consensus.Common.ProfileProduct(model));
                return _profileProducts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityXrefModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Activities.ActivityXref> ActivityXRefs
        {
            get
            {
                if (_activityXRefs == null)
                    _activityXRefs = new ProxyCollection<Consensus.Activities.ActivityXref, Consensus.Activities.IActivityXrefModel>(this.Model.ActivityXRefs, model => new Consensus.Activities.ActivityXref(model));
                return _activityXRefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberBomModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Membership.MemberBom> ParentProduct
        {
            get
            {
                if (_parentProduct == null)
                    _parentProduct = new ProxyCollection<Consensus.Membership.MemberBom, Consensus.Membership.IMemberBomModel>(this.Model.ParentProduct, model => new Consensus.Membership.MemberBom(model));
                return _parentProduct;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberBomModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Membership.MemberBom> GradeProduct
        {
            get
            {
                if (_gradeProduct == null)
                    _gradeProduct = new ProxyCollection<Consensus.Membership.MemberBom, Consensus.Membership.IMemberBomModel>(this.Model.GradeProduct, model => new Consensus.Membership.MemberBom(model));
                return _gradeProduct;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CommitteeModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        public Collection<Consensus.Membership.Committee> CommiteeProduct
        {
            get
            {
                if (_commiteeProduct == null)
                    _commiteeProduct = new ProxyCollection<Consensus.Membership.Committee, Consensus.Membership.ICommitteeModel>(this.Model.CommiteeProduct, model => new Consensus.Membership.Committee(model));
                return _commiteeProduct;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ProductMembership(IProductMembershipModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <param name="startDate">
        ///     The proposed start date for the membership.
        /// </param>
        public System.DateTime CalculateMembershipEndDate(System.DateTime startDate)
        {
            return this.Model.CalculateMembershipEndDate(startDate);
        }

        /// <param name="personId">
        ///     The person that the membership is for.
        /// </param>
        /// <param name="startDate">
        ///     The date on which the membership will start.
        /// </param>
        /// <param name="endDate">
        ///     The date on which the membership will end.
        /// </param>
        /// <param name="priceList">
        ///     The price list from which the price is selected.
        /// </param>
        public System.Object CalculateMembershipPrice(System.String personId, System.Int32 quantity, System.DateTime startDate, System.DateTime endDate, System.String priceList)
        {
            return this.Model.CalculateMembershipPrice(personId,quantity,startDate,endDate,priceList);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ProductMembershipModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProductMembershipModel" /> instance.
        /// </returns>
        public static Consensus.Learning.ProductMembership Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ProductMembershipModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProductMembershipModel" /> instance.
        /// </returns>
        public static Consensus.Learning.ProductMembership Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IProductMembershipModel model = provider.Learning.ProductMembership.Create();
            return model == null ? null : new Consensus.Learning.ProductMembership(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProductMembershipModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProductMembershipModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAll();
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProductMembershipModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProductMembershipModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.ProductMembership FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProductMembershipModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProductMembershipModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.ProductMembership FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IProductMembershipModel model = provider.Learning.ProductMembership.FetchById(id);
            return model == null ? null : new Consensus.Learning.ProductMembership(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Learning.ProductMembership.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="prodDescripId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="prodDescripId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByProdDescripId(System.String prodDescripId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByProdDescripId(site,prodDescripId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="prodDescripId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="prodDescripId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByProdDescripId(ConsensusSite site, System.String prodDescripId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByProdDescripId(prodDescripId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="prodContentId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="prodContentId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByProdContentId(System.String prodContentId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByProdContentId(site,prodContentId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="prodContentId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="prodContentId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByProdContentId(ConsensusSite site, System.String prodContentId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByProdContentId(prodContentId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="prodPrereqId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="prodPrereqId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByProdPrereqId(System.String prodPrereqId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByProdPrereqId(site,prodPrereqId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="prodPrereqId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="prodPrereqId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByProdPrereqId(ConsensusSite site, System.String prodPrereqId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByProdPrereqId(prodPrereqId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="prodObjectiveId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="prodObjectiveId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByProdObjectiveId(System.String prodObjectiveId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByProdObjectiveId(site,prodObjectiveId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="prodObjectiveId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="prodObjectiveId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByProdObjectiveId(ConsensusSite site, System.String prodObjectiveId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByProdObjectiveId(prodObjectiveId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByProleIdId(System.String proleIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByProleIdId(site,proleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByProleIdId(ConsensusSite site, System.String proleIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByProleIdId(proleIdId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="productManagerId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="productManagerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByProductManagerId(System.String productManagerId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByProductManagerId(site,productManagerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="productManagerId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="productManagerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByProductManagerId(ConsensusSite site, System.String productManagerId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByProductManagerId(productManagerId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="bookingTermsId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByBookingTermsId(System.String bookingTermsId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByBookingTermsId(site,bookingTermsId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="bookingTermsId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByBookingTermsId(ConsensusSite site, System.String bookingTermsId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByBookingTermsId(bookingTermsId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByLocationId(System.String locationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByLocationId(site,locationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByLocationId(ConsensusSite site, System.String locationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByLocationId(locationId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="joiningPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="joiningPackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByJoiningPackId(System.String joiningPackId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByJoiningPackId(site,joiningPackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="joiningPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="joiningPackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByJoiningPackId(ConsensusSite site, System.String joiningPackId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByJoiningPackId(joiningPackId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="remind1PackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="remind1PackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByRemind1PackId(System.String remind1PackId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByRemind1PackId(site,remind1PackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="remind1PackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="remind1PackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByRemind1PackId(ConsensusSite site, System.String remind1PackId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByRemind1PackId(remind1PackId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="remind2PackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="remind2PackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByRemind2PackId(System.String remind2PackId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByRemind2PackId(site,remind2PackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="remind2PackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="remind2PackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByRemind2PackId(ConsensusSite site, System.String remind2PackId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByRemind2PackId(remind2PackId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="renewalPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="renewalPackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByRenewalPackId(System.String renewalPackId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByRenewalPackId(site,renewalPackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="renewalPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="renewalPackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByRenewalPackId(ConsensusSite site, System.String renewalPackId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByRenewalPackId(renewalPackId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="lapsedPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="lapsedPackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByLapsedPackId(System.String lapsedPackId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByLapsedPackId(site,lapsedPackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="lapsedPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="lapsedPackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByLapsedPackId(ConsensusSite site, System.String lapsedPackId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByLapsedPackId(lapsedPackId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="cancelPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="cancelPackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByCancelPackId(System.String cancelPackId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByCancelPackId(site,cancelPackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="cancelPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="cancelPackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByCancelPackId(ConsensusSite site, System.String cancelPackId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByCancelPackId(cancelPackId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="authorPersonId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="authorPersonId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByAuthorPersonId(System.String authorPersonId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByAuthorPersonId(site,authorPersonId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="authorPersonId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="authorPersonId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByAuthorPersonId(ConsensusSite site, System.String authorPersonId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByAuthorPersonId(authorPersonId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="remind3PackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="remind3PackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByRemind3PackId(System.String remind3PackId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByRemind3PackId(site,remind3PackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="remind3PackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="remind3PackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByRemind3PackId(ConsensusSite site, System.String remind3PackId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByRemind3PackId(remind3PackId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="renewedPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="renewedPackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByRenewedPackId(System.String renewedPackId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByRenewedPackId(site,renewedPackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="renewedPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="renewedPackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByRenewedPackId(ConsensusSite site, System.String renewedPackId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByRenewedPackId(renewedPackId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="appPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="appPackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByAppPackId(System.String appPackId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByAppPackId(site,appPackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="appPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="appPackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByAppPackId(ConsensusSite site, System.String appPackId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByAppPackId(appPackId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="offerPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="offerPackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByOfferPackId(System.String offerPackId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByOfferPackId(site,offerPackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="offerPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="offerPackId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByOfferPackId(ConsensusSite site, System.String offerPackId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByOfferPackId(offerPackId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="venueId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="venueId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByVenueId(System.String venueId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByVenueId(site,venueId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="venueId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="venueId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByVenueId(ConsensusSite site, System.String venueId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByVenueId(venueId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByPaymentScheduleId(System.Nullable<System.Int32> paymentScheduleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByPaymentScheduleId(site,paymentScheduleId);
        }

        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByPaymentScheduleId(ConsensusSite site, System.Nullable<System.Int32> paymentScheduleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByPaymentScheduleId(paymentScheduleId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="productTrainingRulesId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="productTrainingRulesId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByProductTrainingRulesId(System.String productTrainingRulesId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductMembership.FetchAllByProductTrainingRulesId(site,productTrainingRulesId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="productTrainingRulesId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="productTrainingRulesId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductMembership> FetchAllByProductTrainingRulesId(ConsensusSite site, System.String productTrainingRulesId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductMembershipModel> collection = provider.Learning.ProductMembership.FetchAllByProductTrainingRulesId(productTrainingRulesId);
            return collection.Select(model => new Consensus.Learning.ProductMembership(model));
        }

        #endregion
    }
}
