using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Document;
using Consensus.Membership;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ProductRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProductMembershipModel : LocalProductModel, IProductMembershipModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PROD_MS_NEW" field.
        /// </summary>
        private LocalPackModel _joiningPack;

        /// <summary>
        ///     The value of the "PROD_MS_REMIND1" field.
        /// </summary>
        private LocalPackModel _remind1Pack;

        /// <summary>
        ///     The value of the "PROD_MS_REMIND2" field.
        /// </summary>
        private LocalPackModel _remind2Pack;

        /// <summary>
        ///     The value of the "PROD_MS_RENEW" field.
        /// </summary>
        private LocalPackModel _renewalPack;

        /// <summary>
        ///     The value of the "PROD_MS_LAPSED" field.
        /// </summary>
        private LocalPackModel _lapsedPack;

        /// <summary>
        ///     The value of the "PROD_MS_CANCEL" field.
        /// </summary>
        private LocalPackModel _cancelPack;

        /// <summary>
        ///     The value of the "PROD_MS_REMIND3" field.
        /// </summary>
        private LocalPackModel _remind3Pack;

        /// <summary>
        ///     The value of the "PROD_MS_RENEWED" field.
        /// </summary>
        private LocalPackModel _renewedPack;

        /// <summary>
        ///     The value of the "PROD_MS_APP" field.
        /// </summary>
        private LocalPackModel _appPack;

        /// <summary>
        ///     The value of the "PROD_MS_OFF" field.
        /// </summary>
        private LocalPackModel _offerPack;

        /// <summary>
        ///     The collection of <see cref="MemberPeriodModel" /> instances that reference this <see cref="ProductMembershipModel" />.
        /// </summary>
        private LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel> _memberPeriods;

        /// <summary>
        ///     The collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="ProductMembershipModel" />.
        /// </summary>
        private LocalCollection<LocalMemberLocationModel, IMemberLocationModel> _memberLocations;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.Product.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.Product.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.Product.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_NEW" field.
        /// </summary>
        public LocalPackModel JoiningPack
        {
            get
            {
                if (_joiningPack == null && this.JoiningPackId != null)
                    _joiningPack = this.Provider.Document.Pack.FetchById(this.JoiningPackId);
                if (_joiningPack == null)
                    _joiningPack = this.Provider.Document.Pack.Create();
                
                return _joiningPack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_NEW" field.
        /// </summary>
        public String JoiningPackId
        {
            get { return this.ModifiedData.MsNew; }
            set
            {
                if (this.ModifiedData.MsNew != value)
                     _joiningPack = null;
                this.ModifiedData.MsNew = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_REMIND1" field.
        /// </summary>
        public LocalPackModel Remind1Pack
        {
            get
            {
                if (_remind1Pack == null && this.Remind1PackId != null)
                    _remind1Pack = this.Provider.Document.Pack.FetchById(this.Remind1PackId);
                if (_remind1Pack == null)
                    _remind1Pack = this.Provider.Document.Pack.Create();
                
                return _remind1Pack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_REMIND1" field.
        /// </summary>
        public String Remind1PackId
        {
            get { return this.ModifiedData.MsRemind1; }
            set
            {
                if (this.ModifiedData.MsRemind1 != value)
                     _remind1Pack = null;
                this.ModifiedData.MsRemind1 = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_REMIND2" field.
        /// </summary>
        public LocalPackModel Remind2Pack
        {
            get
            {
                if (_remind2Pack == null && this.Remind2PackId != null)
                    _remind2Pack = this.Provider.Document.Pack.FetchById(this.Remind2PackId);
                if (_remind2Pack == null)
                    _remind2Pack = this.Provider.Document.Pack.Create();
                
                return _remind2Pack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_REMIND2" field.
        /// </summary>
        public String Remind2PackId
        {
            get { return this.ModifiedData.MsRemind2; }
            set
            {
                if (this.ModifiedData.MsRemind2 != value)
                     _remind2Pack = null;
                this.ModifiedData.MsRemind2 = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_RENEW" field.
        /// </summary>
        public LocalPackModel RenewalPack
        {
            get
            {
                if (_renewalPack == null && this.RenewalPackId != null)
                    _renewalPack = this.Provider.Document.Pack.FetchById(this.RenewalPackId);
                if (_renewalPack == null)
                    _renewalPack = this.Provider.Document.Pack.Create();
                
                return _renewalPack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_RENEW" field.
        /// </summary>
        public String RenewalPackId
        {
            get { return this.ModifiedData.MsRenew; }
            set
            {
                if (this.ModifiedData.MsRenew != value)
                     _renewalPack = null;
                this.ModifiedData.MsRenew = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_LAPSED" field.
        /// </summary>
        public LocalPackModel LapsedPack
        {
            get
            {
                if (_lapsedPack == null && this.LapsedPackId != null)
                    _lapsedPack = this.Provider.Document.Pack.FetchById(this.LapsedPackId);
                if (_lapsedPack == null)
                    _lapsedPack = this.Provider.Document.Pack.Create();
                
                return _lapsedPack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_LAPSED" field.
        /// </summary>
        public String LapsedPackId
        {
            get { return this.ModifiedData.MsLapsed; }
            set
            {
                if (this.ModifiedData.MsLapsed != value)
                     _lapsedPack = null;
                this.ModifiedData.MsLapsed = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_CANCEL" field.
        /// </summary>
        public LocalPackModel CancelPack
        {
            get
            {
                if (_cancelPack == null && this.CancelPackId != null)
                    _cancelPack = this.Provider.Document.Pack.FetchById(this.CancelPackId);
                if (_cancelPack == null)
                    _cancelPack = this.Provider.Document.Pack.Create();
                
                return _cancelPack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_CANCEL" field.
        /// </summary>
        public String CancelPackId
        {
            get { return this.ModifiedData.MsCancel; }
            set
            {
                if (this.ModifiedData.MsCancel != value)
                     _cancelPack = null;
                this.ModifiedData.MsCancel = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_GROUP" field.
        /// </summary>
        public Byte? MsGroup
        {
            get { return this.ModifiedData.MsGroup; }
            set { this.ModifiedData.MsGroup = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_RENEW_DAYS" field.
        /// </summary>
        public Int32? RenewDays
        {
            get { return this.ModifiedData.RenewDays; }
            set { this.ModifiedData.RenewDays = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MEM_INV_TYPE" field.
        /// </summary>
        public Byte? MemInvType
        {
            get { return this.ModifiedData.MemInvType; }
            set { this.ModifiedData.MemInvType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_REMIND3" field.
        /// </summary>
        public LocalPackModel Remind3Pack
        {
            get
            {
                if (_remind3Pack == null && this.Remind3PackId != null)
                    _remind3Pack = this.Provider.Document.Pack.FetchById(this.Remind3PackId);
                if (_remind3Pack == null)
                    _remind3Pack = this.Provider.Document.Pack.Create();
                
                return _remind3Pack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_REMIND3" field.
        /// </summary>
        public String Remind3PackId
        {
            get { return this.ModifiedData.MsRemind3; }
            set
            {
                if (this.ModifiedData.MsRemind3 != value)
                     _remind3Pack = null;
                this.ModifiedData.MsRemind3 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_RM1_DAYS" field.
        /// </summary>
        public Int32? Reminder1Days
        {
            get { return this.ModifiedData.MsRm1Days; }
            set { this.ModifiedData.MsRm1Days = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_RM2_DAYS" field.
        /// </summary>
        public Int32? Reminder2Days
        {
            get { return this.ModifiedData.MsRm2Days; }
            set { this.ModifiedData.MsRm2Days = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_RM3_DAYS" field.
        /// </summary>
        public Int32? Reminder3Days
        {
            get { return this.ModifiedData.MsRm3Days; }
            set { this.ModifiedData.MsRm3Days = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_LAPS_DAYS" field.
        /// </summary>
        public Int32? LapsedDays
        {
            get { return this.ModifiedData.MsLapsDays; }
            set { this.ModifiedData.MsLapsDays = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_RENEWED" field.
        /// </summary>
        public LocalPackModel RenewedPack
        {
            get
            {
                if (_renewedPack == null && this.RenewedPackId != null)
                    _renewedPack = this.Provider.Document.Pack.FetchById(this.RenewedPackId);
                if (_renewedPack == null)
                    _renewedPack = this.Provider.Document.Pack.Create();
                
                return _renewedPack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_RENEWED" field.
        /// </summary>
        public String RenewedPackId
        {
            get { return this.ModifiedData.MsRenewed; }
            set
            {
                if (this.ModifiedData.MsRenewed != value)
                     _renewedPack = null;
                this.ModifiedData.MsRenewed = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXCL_CALC" field.
        /// </summary>
        public Byte? ExclCalc
        {
            get { return this.ModifiedData.ExclCalc; }
            set { this.ModifiedData.ExclCalc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SG_NO" field.
        /// </summary>
        public Int32? NumberOfSpecialistGroups
        {
            get { return this.ModifiedData.SgNo; }
            set { this.ModifiedData.SgNo = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_APP" field.
        /// </summary>
        public LocalPackModel AppPack
        {
            get
            {
                if (_appPack == null && this.AppPackId != null)
                    _appPack = this.Provider.Document.Pack.FetchById(this.AppPackId);
                if (_appPack == null)
                    _appPack = this.Provider.Document.Pack.Create();
                
                return _appPack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_APP" field.
        /// </summary>
        public String AppPackId
        {
            get { return this.ModifiedData.MsApp; }
            set
            {
                if (this.ModifiedData.MsApp != value)
                     _appPack = null;
                this.ModifiedData.MsApp = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_OFF" field.
        /// </summary>
        public LocalPackModel OfferPack
        {
            get
            {
                if (_offerPack == null && this.OfferPackId != null)
                    _offerPack = this.Provider.Document.Pack.FetchById(this.OfferPackId);
                if (_offerPack == null)
                    _offerPack = this.Provider.Document.Pack.Create();
                
                return _offerPack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_OFF" field.
        /// </summary>
        public String OfferPackId
        {
            get { return this.ModifiedData.MsOff; }
            set
            {
                if (this.ModifiedData.MsOff != value)
                     _offerPack = null;
                this.ModifiedData.MsOff = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_NO_INV_RENEW" field.
        /// </summary>
        public Byte? NoInvRenew
        {
            get { return this.ModifiedData.NoInvRenew; }
            set { this.ModifiedData.NoInvRenew = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_PREFIX" field.
        /// </summary>
        public String Prefix
        {
            get { return this.ModifiedData.Prefix; }
            set { this.ModifiedData.Prefix = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_NON_RENEW_MEMB" field.
        /// </summary>
        public Byte NonRenewMemb
        {
            get { return this.ModifiedData.NonRenewMemb; }
            set { this.ModifiedData.NonRenewMemb = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DD_NO_OF_INSTALLMENTS" field.
        /// </summary>
        public Int32? DdNoOfInstallments
        {
            get { return this.ModifiedData.DdNoOfInstallments; }
            set { this.ModifiedData.DdNoOfInstallments = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DD_FREQUENCY" field.
        /// </summary>
        public Int32? DdFrequency
        {
            get { return this.ModifiedData.DdFrequency; }
            set { this.ModifiedData.DdFrequency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MEM_FIRST_BOOK" field.
        /// </summary>
        public Byte MemFirstBook
        {
            get { return this.ModifiedData.MemFirstBook; }
            set { this.ModifiedData.MemFirstBook = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberPeriodModel" /> instances that reference this <see cref="ProductMembershipModel" />.
        /// </summary>
        public LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel> MemberPeriods
        {
            get
            {
                if (_memberPeriods == null)
                    _memberPeriods = new LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel>(this.Provider.Membership.MemberPeriod.FetchAllByProductId(this.Id));
                
                return _memberPeriods;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="ProductMembershipModel" />.
        /// </summary>
        public LocalCollection<LocalMemberLocationModel, IMemberLocationModel> MemberLocations
        {
            get
            {
                if (_memberLocations == null)
                    _memberLocations = new LocalCollection<LocalMemberLocationModel, IMemberLocationModel>(this.Provider.Membership.MemberLocation.FetchAllByProductId(this.Id));
                
                return _memberLocations;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalProductMembershipModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalProductMembershipModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalProductMembershipModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalProductMembershipModel(LocalProvider provider, ProductRecord record) : base(provider, record)
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
            if (_joiningPack != null)
            {
                _joiningPack.Save();
                this.ModifiedData.MsNew = _joiningPack.Id == null && this.ModifiedData.MsNew != null ? "" : _joiningPack.Id;
            }
            if (_remind1Pack != null)
            {
                _remind1Pack.Save();
                this.ModifiedData.MsRemind1 = _remind1Pack.Id == null && this.ModifiedData.MsRemind1 != null ? "" : _remind1Pack.Id;
            }
            if (_remind2Pack != null)
            {
                _remind2Pack.Save();
                this.ModifiedData.MsRemind2 = _remind2Pack.Id == null && this.ModifiedData.MsRemind2 != null ? "" : _remind2Pack.Id;
            }
            if (_renewalPack != null)
            {
                _renewalPack.Save();
                this.ModifiedData.MsRenew = _renewalPack.Id == null && this.ModifiedData.MsRenew != null ? "" : _renewalPack.Id;
            }
            if (_lapsedPack != null)
            {
                _lapsedPack.Save();
                this.ModifiedData.MsLapsed = _lapsedPack.Id == null && this.ModifiedData.MsLapsed != null ? "" : _lapsedPack.Id;
            }
            if (_cancelPack != null)
            {
                _cancelPack.Save();
                this.ModifiedData.MsCancel = _cancelPack.Id == null && this.ModifiedData.MsCancel != null ? "" : _cancelPack.Id;
            }
            if (_remind3Pack != null)
            {
                _remind3Pack.Save();
                this.ModifiedData.MsRemind3 = _remind3Pack.Id == null && this.ModifiedData.MsRemind3 != null ? "" : _remind3Pack.Id;
            }
            if (_renewedPack != null)
            {
                _renewedPack.Save();
                this.ModifiedData.MsRenewed = _renewedPack.Id == null && this.ModifiedData.MsRenewed != null ? "" : _renewedPack.Id;
            }
            if (_appPack != null)
            {
                _appPack.Save();
                this.ModifiedData.MsApp = _appPack.Id == null && this.ModifiedData.MsApp != null ? "" : _appPack.Id;
            }
            if (_offerPack != null)
            {
                _offerPack.Save();
                this.ModifiedData.MsOff = _offerPack.Id == null && this.ModifiedData.MsOff != null ? "" : _offerPack.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_memberPeriods != null)
                _memberPeriods.Execute(obj => obj.ProductId = this.Id).Execute(obj => obj.Save());
            if (_memberLocations != null)
                _memberLocations.Execute(obj => obj.ProductId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets whether the membership product has a fixed renewal date.
        /// </summary>
        System.Boolean IProductMembershipModel.IsRenewalFixed
        {
            get { return this.IsRenewalFixed; }
            set { this.IsRenewalFixed = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets or sets the day on which the fixed renewal occurs.
        /// </summary>
        System.Int32 IProductMembershipModel.RenewalDay
        {
            get { return this.RenewalDay; }
            set { this.RenewalDay = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the month on which the fixed renewal occurs.
        /// </summary>
        System.Int32 IProductMembershipModel.RenewalMonth
        {
            get { return this.RenewalMonth; }
            set { this.RenewalMonth = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the minimum number of days allowed for a renewing membership.
        /// </summary>
        System.Int32 IProductMembershipModel.RenewalExclusion
        {
            get { return this.RenewalExclusion; }
            set { this.RenewalExclusion = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_NEW" field.
        /// </summary>
        Consensus.Document.IPackModel IProductMembershipModel.JoiningPack
        {
            get { return this.JoiningPack; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_NEW" field.
        /// </summary>
        System.String IProductMembershipModel.JoiningPackId
        {
            get { return this.JoiningPackId; }
            set { this.JoiningPackId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_REMIND1" field.
        /// </summary>
        Consensus.Document.IPackModel IProductMembershipModel.Remind1Pack
        {
            get { return this.Remind1Pack; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_REMIND1" field.
        /// </summary>
        System.String IProductMembershipModel.Remind1PackId
        {
            get { return this.Remind1PackId; }
            set { this.Remind1PackId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_REMIND2" field.
        /// </summary>
        Consensus.Document.IPackModel IProductMembershipModel.Remind2Pack
        {
            get { return this.Remind2Pack; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_REMIND2" field.
        /// </summary>
        System.String IProductMembershipModel.Remind2PackId
        {
            get { return this.Remind2PackId; }
            set { this.Remind2PackId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_RENEW" field.
        /// </summary>
        Consensus.Document.IPackModel IProductMembershipModel.RenewalPack
        {
            get { return this.RenewalPack; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_RENEW" field.
        /// </summary>
        System.String IProductMembershipModel.RenewalPackId
        {
            get { return this.RenewalPackId; }
            set { this.RenewalPackId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_LAPSED" field.
        /// </summary>
        Consensus.Document.IPackModel IProductMembershipModel.LapsedPack
        {
            get { return this.LapsedPack; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_LAPSED" field.
        /// </summary>
        System.String IProductMembershipModel.LapsedPackId
        {
            get { return this.LapsedPackId; }
            set { this.LapsedPackId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_CANCEL" field.
        /// </summary>
        Consensus.Document.IPackModel IProductMembershipModel.CancelPack
        {
            get { return this.CancelPack; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_CANCEL" field.
        /// </summary>
        System.String IProductMembershipModel.CancelPackId
        {
            get { return this.CancelPackId; }
            set { this.CancelPackId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_GROUP" field.
        /// </summary>
        System.Nullable<System.Byte> IProductMembershipModel.MsGroup
        {
            get { return this.MsGroup; }
            set { this.MsGroup = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_RENEW_DAYS" field.
        /// </summary>
        System.Nullable<System.Int32> IProductMembershipModel.RenewDays
        {
            get { return this.RenewDays; }
            set { this.RenewDays = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MEM_INV_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> IProductMembershipModel.MemInvType
        {
            get { return this.MemInvType; }
            set { this.MemInvType = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_REMIND3" field.
        /// </summary>
        Consensus.Document.IPackModel IProductMembershipModel.Remind3Pack
        {
            get { return this.Remind3Pack; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_REMIND3" field.
        /// </summary>
        System.String IProductMembershipModel.Remind3PackId
        {
            get { return this.Remind3PackId; }
            set { this.Remind3PackId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_RM1_DAYS" field.
        /// </summary>
        System.Nullable<System.Int32> IProductMembershipModel.Reminder1Days
        {
            get { return this.Reminder1Days; }
            set { this.Reminder1Days = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_RM2_DAYS" field.
        /// </summary>
        System.Nullable<System.Int32> IProductMembershipModel.Reminder2Days
        {
            get { return this.Reminder2Days; }
            set { this.Reminder2Days = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_RM3_DAYS" field.
        /// </summary>
        System.Nullable<System.Int32> IProductMembershipModel.Reminder3Days
        {
            get { return this.Reminder3Days; }
            set { this.Reminder3Days = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_LAPS_DAYS" field.
        /// </summary>
        System.Nullable<System.Int32> IProductMembershipModel.LapsedDays
        {
            get { return this.LapsedDays; }
            set { this.LapsedDays = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_RENEWED" field.
        /// </summary>
        Consensus.Document.IPackModel IProductMembershipModel.RenewedPack
        {
            get { return this.RenewedPack; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_RENEWED" field.
        /// </summary>
        System.String IProductMembershipModel.RenewedPackId
        {
            get { return this.RenewedPackId; }
            set { this.RenewedPackId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXCL_CALC" field.
        /// </summary>
        System.Nullable<System.Byte> IProductMembershipModel.ExclCalc
        {
            get { return this.ExclCalc; }
            set { this.ExclCalc = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SG_NO" field.
        /// </summary>
        System.Nullable<System.Int32> IProductMembershipModel.NumberOfSpecialistGroups
        {
            get { return this.NumberOfSpecialistGroups; }
            set { this.NumberOfSpecialistGroups = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_APP" field.
        /// </summary>
        Consensus.Document.IPackModel IProductMembershipModel.AppPack
        {
            get { return this.AppPack; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_APP" field.
        /// </summary>
        System.String IProductMembershipModel.AppPackId
        {
            get { return this.AppPackId; }
            set { this.AppPackId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_OFF" field.
        /// </summary>
        Consensus.Document.IPackModel IProductMembershipModel.OfferPack
        {
            get { return this.OfferPack; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_OFF" field.
        /// </summary>
        System.String IProductMembershipModel.OfferPackId
        {
            get { return this.OfferPackId; }
            set { this.OfferPackId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_NO_INV_RENEW" field.
        /// </summary>
        System.Nullable<System.Byte> IProductMembershipModel.NoInvRenew
        {
            get { return this.NoInvRenew; }
            set { this.NoInvRenew = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_PREFIX" field.
        /// </summary>
        System.String IProductMembershipModel.Prefix
        {
            get { return this.Prefix; }
            set { this.Prefix = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_NON_RENEW_MEMB" field.
        /// </summary>
        System.Byte IProductMembershipModel.NonRenewMemb
        {
            get { return this.NonRenewMemb; }
            set { this.NonRenewMemb = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DD_NO_OF_INSTALLMENTS" field.
        /// </summary>
        System.Nullable<System.Int32> IProductMembershipModel.DdNoOfInstallments
        {
            get { return this.DdNoOfInstallments; }
            set { this.DdNoOfInstallments = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DD_FREQUENCY" field.
        /// </summary>
        System.Nullable<System.Int32> IProductMembershipModel.DdFrequency
        {
            get { return this.DdFrequency; }
            set { this.DdFrequency = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MEM_FIRST_BOOK" field.
        /// </summary>
        System.Byte IProductMembershipModel.MemFirstBook
        {
            get { return this.MemFirstBook; }
            set { this.MemFirstBook = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:ProductMembershipModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberPeriodModel> IProductMembershipModel.MemberPeriods
        {
            get { return this.MemberPeriods; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:ProductMembershipModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> IProductMembershipModel.MemberLocations
        {
            get { return this.MemberLocations; }
        }

        /// <summary>
        ///     Calculates the proposed end date for a membership that is based upon this product, based on the specified start date.
        /// </summary>
        /// <param name="startDate">
        ///     The proposed start date for the membership.
        /// </param>
        /// <returns>
        ///     The proposed end date for the membership.
        /// </returns>
        System.DateTime IProductMembershipModel.CalculateMembershipEndDate(System.DateTime startDate)
        {
            return this.CalculateMembershipEndDate(startDate);
        }

        /// <summary>
        ///     Calculates the price for a new membership that is based upon this product.
        /// </summary>
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
        System.Object IProductMembershipModel.CalculateMembershipPrice(System.String personId, System.Int32 quantity, System.DateTime startDate, System.DateTime endDate, System.String priceList)
        {
            return this.CalculateMembershipPrice(personId, quantity, startDate, endDate, priceList);
        }

        #endregion
    }
}
