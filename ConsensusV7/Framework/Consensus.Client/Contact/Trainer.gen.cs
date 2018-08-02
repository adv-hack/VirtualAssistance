using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Trainer : Proxy<ITrainerModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Role" /> member.
        /// </summary>
        private Consensus.Contact.Role _role;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Attribute01" /> member.
        /// </summary>
        private Consensus.Common.Code _attribute01;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="FeeNotesText" /> member.
        /// </summary>
        private Consensus.Activities.C4text _feeNotesText;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="HotelReqText" /> member.
        /// </summary>
        private Consensus.Activities.C4text _hotelReqText;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="OtherInfoText" /> member.
        /// </summary>
        private Consensus.Activities.C4text _otherInfoText;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="TrainProductXrefTrainer" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.TrainProdXref, Consensus.Contact.ITrainProdXrefModel> _trainProductXrefTrainer;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Trainers" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Common.ProfileTrainer, Consensus.Common.IProfileTrainerModel> _trainers;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ProfileVolunteers" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Common.ProfileVolunteer, Consensus.Common.IProfileVolunteerModel> _profileVolunteers;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_ADD_BY" field.
        /// </summary>
        public System.String AinAddBy
        {
            get { return this.Model.AinAddBy; }
            set { this.Model.AinAddBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_MOD_BY" field.
        /// </summary>
        public System.String AinModBy
        {
            get { return this.Model.AinModBy; }
            set { this.Model.AinModBy = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "TRAIN_PROLE_ID" field.
        /// </summary>
        public System.String RoleId
        {
            get { return this.Model.RoleId; }
            set { this.Model.RoleId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_START_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> AinStartDate
        {
            get { return this.Model.AinStartDate; }
            set { this.Model.AinStartDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_STATUS" field.
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
        ///     Gets or sets the unique code for the value of the "TRAIN_STATUS" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_REVIEW_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> AinReviewDate
        {
            get { return this.Model.AinReviewDate; }
            set { this.Model.AinReviewDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_REF" field.
        /// </summary>
        public System.String AinRef
        {
            get { return this.Model.AinRef; }
            set { this.Model.AinRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_COST" field.
        /// </summary>
        public System.Nullable<System.Decimal> AinCost
        {
            get { return this.Model.AinCost; }
            set { this.Model.AinCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_BIOG" field.
        /// </summary>
        public System.String AinBiog
        {
            get { return this.Model.AinBiog; }
            set { this.Model.AinBiog = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_ATTRIB01" field.
        /// </summary>
        public Consensus.Common.Code Attribute01
        {
            get
            {
                if (_attribute01 == null && this.Model.Attribute01 != null)
                    _attribute01 = new Consensus.Common.Code(this.Model.Attribute01);
                if (_attribute01 == null)
                    _attribute01 = Consensus.Common.Code.Create();
                return _attribute01;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_ATTRIB01" field.
        /// </summary>
        public System.String Attribute01Code
        {
            get { return this.Model.Attribute01Code; }
            set { this.Model.Attribute01Code = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_DAY_COST" field.
        /// </summary>
        public System.Decimal AinDayCost
        {
            get { return this.Model.AinDayCost; }
            set { this.Model.AinDayCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_HOUR_COST" field.
        /// </summary>
        public System.Decimal AinHourCost
        {
            get { return this.Model.AinHourCost; }
            set { this.Model.AinHourCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_BASE_POSTCODE" field.
        /// </summary>
        public System.String AinBasePostcode
        {
            get { return this.Model.AinBasePostcode; }
            set { this.Model.AinBasePostcode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "TRAIN_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_INS_EXPIRY" field.
        /// </summary>
        public System.Nullable<System.DateTime> AinInsExpiry
        {
            get { return this.Model.AinInsExpiry; }
            set { this.Model.AinInsExpiry = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRN_UNIQUE_REF" field.
        /// </summary>
        public System.String NUniqueRef
        {
            get { return this.Model.NUniqueRef; }
            set { this.Model.NUniqueRef = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_FEE_NOTES_TEXT_ID" field.
        /// </summary>
        public Consensus.Activities.C4text FeeNotesText
        {
            get
            {
                if (_feeNotesText == null && this.Model.FeeNotesText != null)
                    _feeNotesText = new Consensus.Activities.C4text(this.Model.FeeNotesText);
                if (_feeNotesText == null)
                    _feeNotesText = Consensus.Activities.C4text.Create();
                return _feeNotesText;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_FEE_NOTES_TEXT_ID" field.
        /// </summary>
        public System.String FeeNotesTextId
        {
            get { return this.Model.FeeNotesTextId; }
            set { this.Model.FeeNotesTextId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_HOTEL_REQ_TEXT_ID" field.
        /// </summary>
        public Consensus.Activities.C4text HotelReqText
        {
            get
            {
                if (_hotelReqText == null && this.Model.HotelReqText != null)
                    _hotelReqText = new Consensus.Activities.C4text(this.Model.HotelReqText);
                if (_hotelReqText == null)
                    _hotelReqText = Consensus.Activities.C4text.Create();
                return _hotelReqText;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_HOTEL_REQ_TEXT_ID" field.
        /// </summary>
        public System.String HotelReqTextId
        {
            get { return this.Model.HotelReqTextId; }
            set { this.Model.HotelReqTextId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_OTHER_INFO_TEXT_ID" field.
        /// </summary>
        public Consensus.Activities.C4text OtherInfoText
        {
            get
            {
                if (_otherInfoText == null && this.Model.OtherInfoText != null)
                    _otherInfoText = new Consensus.Activities.C4text(this.Model.OtherInfoText);
                if (_otherInfoText == null)
                    _otherInfoText = Consensus.Activities.C4text.Create();
                return _otherInfoText;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_OTHER_INFO_TEXT_ID" field.
        /// </summary>
        public System.String OtherInfoTextId
        {
            get { return this.Model.OtherInfoTextId; }
            set { this.Model.OtherInfoTextId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_PASSWORD" field.
        /// </summary>
        public System.String AinPassword
        {
            get { return this.Model.AinPassword; }
            set { this.Model.AinPassword = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_WEB" field.
        /// </summary>
        public System.Byte AinWeb
        {
            get { return this.Model.AinWeb; }
            set { this.Model.AinWeb = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_SY_TYPE" field.
        /// </summary>
        public System.Int32 AinSyType
        {
            get { return this.Model.AinSyType; }
            set { this.Model.AinSyType = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainProdXrefModel" /> instances that reference this <see cref="!:TrainerModel" />.
        /// </summary>
        public Collection<Consensus.Contact.TrainProdXref> TrainProductXrefTrainer
        {
            get
            {
                if (_trainProductXrefTrainer == null)
                    _trainProductXrefTrainer = new ProxyCollection<Consensus.Contact.TrainProdXref, Consensus.Contact.ITrainProdXrefModel>(this.Model.TrainProductXrefTrainer, model => new Consensus.Contact.TrainProdXref(model));
                return _trainProductXrefTrainer;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProfileTrainerModel" /> instances that reference this <see cref="!:TrainerModel" />.
        /// </summary>
        public Collection<Consensus.Common.ProfileTrainer> Trainers
        {
            get
            {
                if (_trainers == null)
                    _trainers = new ProxyCollection<Consensus.Common.ProfileTrainer, Consensus.Common.IProfileTrainerModel>(this.Model.Trainers, model => new Consensus.Common.ProfileTrainer(model));
                return _trainers;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProfileVolunteerModel" /> instances that reference this <see cref="!:TrainerModel" />.
        /// </summary>
        public Collection<Consensus.Common.ProfileVolunteer> ProfileVolunteers
        {
            get
            {
                if (_profileVolunteers == null)
                    _profileVolunteers = new ProxyCollection<Consensus.Common.ProfileVolunteer, Consensus.Common.IProfileVolunteerModel>(this.Model.ProfileVolunteers, model => new Consensus.Common.ProfileVolunteer(model));
                return _profileVolunteers;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Trainer(ITrainerModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Check if Person exist or not.
        /// </summary>
        /// <param name="proleId">
        ///     ProleId of Role.
        /// </param>
        /// <param name="trainerId">
        ///     Id of Trainer.
        /// </param>
        /// <param name="syType">
        ///     Determines whether person is associate or trainer.
        /// </param>
        /// <returns>
        ///     Whether Person exist or not.
        /// </returns>
        public static System.Boolean CheckIfPersonIsAssociatedWithTrainer(System.String proleId, System.String trainerId, System.String syType)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Trainer.CheckIfPersonIsAssociatedWithTrainer(site,proleId,trainerId,syType);
        }

        /// <summary>
        ///     Check if Person exist or not.
        /// </summary>
        /// <param name="proleId">
        ///     ProleId of Role.
        /// </param>
        /// <param name="trainerId">
        ///     Id of Trainer.
        /// </param>
        /// <param name="syType">
        ///     Determines whether person is associate or trainer.
        /// </param>
        /// <returns>
        ///     Whether Person exist or not.
        /// </returns>
        public static System.Boolean CheckIfPersonIsAssociatedWithTrainer(ConsensusSite site, System.String proleId, System.String trainerId, System.String syType)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.Trainer.CheckIfPersonIsAssociatedWithTrainer(proleId,trainerId,syType);
        }

        /// <summary>
        ///     Creates a new <see cref="!:TrainerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TrainerModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Trainer Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Trainer.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:TrainerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TrainerModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Trainer Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ITrainerModel model = provider.Contact.Trainer.Create();
            return model == null ? null : new Consensus.Contact.Trainer(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TrainerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TrainerModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Trainer> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Trainer.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TrainerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TrainerModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Trainer> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ITrainerModel> collection = provider.Contact.Trainer.FetchAll();
            return collection.Select(model => new Consensus.Contact.Trainer(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TrainerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TrainerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Trainer FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Trainer.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TrainerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TrainerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Trainer FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ITrainerModel model = provider.Contact.Trainer.FetchById(id);
            return model == null ? null : new Consensus.Contact.Trainer(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Trainer.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.Trainer.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Trainer> FetchAllByRoleId(System.String roleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Trainer.FetchAllByRoleId(site,roleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Trainer> FetchAllByRoleId(ConsensusSite site, System.String roleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ITrainerModel> collection = provider.Contact.Trainer.FetchAllByRoleId(roleId);
            return collection.Select(model => new Consensus.Contact.Trainer(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Trainer> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Trainer.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Trainer> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ITrainerModel> collection = provider.Contact.Trainer.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Contact.Trainer(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="feeNotesTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="feeNotesTextId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Trainer> FetchAllByFeeNotesTextId(System.String feeNotesTextId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Trainer.FetchAllByFeeNotesTextId(site,feeNotesTextId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="feeNotesTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="feeNotesTextId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Trainer> FetchAllByFeeNotesTextId(ConsensusSite site, System.String feeNotesTextId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ITrainerModel> collection = provider.Contact.Trainer.FetchAllByFeeNotesTextId(feeNotesTextId);
            return collection.Select(model => new Consensus.Contact.Trainer(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="hotelReqTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="hotelReqTextId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Trainer> FetchAllByHotelReqTextId(System.String hotelReqTextId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Trainer.FetchAllByHotelReqTextId(site,hotelReqTextId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="hotelReqTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="hotelReqTextId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Trainer> FetchAllByHotelReqTextId(ConsensusSite site, System.String hotelReqTextId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ITrainerModel> collection = provider.Contact.Trainer.FetchAllByHotelReqTextId(hotelReqTextId);
            return collection.Select(model => new Consensus.Contact.Trainer(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="otherInfoTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="otherInfoTextId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Trainer> FetchAllByOtherInfoTextId(System.String otherInfoTextId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Trainer.FetchAllByOtherInfoTextId(site,otherInfoTextId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="otherInfoTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="otherInfoTextId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Trainer> FetchAllByOtherInfoTextId(ConsensusSite site, System.String otherInfoTextId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ITrainerModel> collection = provider.Contact.Trainer.FetchAllByOtherInfoTextId(otherInfoTextId);
            return collection.Select(model => new Consensus.Contact.Trainer(model));
        }

        #endregion
    }
}
