using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="TrainerRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalTrainerModel : LocalModel<TrainerRecord, String>, ITrainerModel
    {
        #region fields

        /// <summary>
        ///     The value of the "TRAIN_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _role;

        /// <summary>
        ///     The value of the "TRAIN_STATUS" field.
        /// </summary>
        private LocalCodeModel _status;

        /// <summary>
        ///     The value of the "TRAIN_ATTRIB01" field.
        /// </summary>
        private LocalCodeModel _attribute01;

        /// <summary>
        ///     The value of the "TRAIN_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The value of the "TRAIN_FEE_NOTES_TEXT_ID" field.
        /// </summary>
        private LocalC4textModel _feeNotesText;

        /// <summary>
        ///     The value of the "TRAIN_HOTEL_REQ_TEXT_ID" field.
        /// </summary>
        private LocalC4textModel _hotelReqText;

        /// <summary>
        ///     The value of the "TRAIN_OTHER_INFO_TEXT_ID" field.
        /// </summary>
        private LocalC4textModel _otherInfoText;

        /// <summary>
        ///     The collection of <see cref="TrainProdXrefModel" /> instances that reference this <see cref="TrainerModel" />.
        /// </summary>
        private LocalCollection<LocalTrainProdXrefModel, ITrainProdXrefModel> _trainProductXrefTrainer;

        /// <summary>
        ///     The collection of <see cref="ProfileTrainerModel" /> instances that reference this <see cref="TrainerModel" />.
        /// </summary>
        private LocalCollection<LocalProfileTrainerModel, IProfileTrainerModel> _trainers;

        /// <summary>
        ///     The collection of <see cref="ProfileVolunteerModel" /> instances that reference this <see cref="TrainerModel" />.
        /// </summary>
        private LocalCollection<LocalProfileVolunteerModel, IProfileVolunteerModel> _profileVolunteers;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<TrainerRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.Trainer.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<TrainerRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.Trainer.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<TrainerRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.Trainer.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_ADD_BY" field.
        /// </summary>
        public String AinAddBy
        {
            get { return this.ModifiedData.AinAddBy; }
            set { this.ModifiedData.AinAddBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_MOD_BY" field.
        /// </summary>
        public String AinModBy
        {
            get { return this.ModifiedData.AinModBy; }
            set { this.ModifiedData.AinModBy = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "TRAIN_PROLE_ID" field.
        /// </summary>
        public String RoleId
        {
            get { return this.ModifiedData.AinProleId; }
            set
            {
                if (this.ModifiedData.AinProleId != value)
                     _role = null;
                this.ModifiedData.AinProleId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_START_DATE" field.
        /// </summary>
        public DateTime? AinStartDate
        {
            get { return this.ModifiedData.AinStartDate; }
            set { this.ModifiedData.AinStartDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_STATUS" field.
        /// </summary>
        public LocalCodeModel Status
        {
            get
            {
                if (_status == null && !String.IsNullOrEmpty(this.StatusCode))
                    _status = this.Provider.Common.Code.FetchByTypeAndCode("TRSTA", this.StatusCode);
                if (_status == null)
                    _status = this.Provider.Common.Code.Create("TRSTA");
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_STATUS" field.
        /// </summary>
        public String StatusCode
        {
            get { return this.ModifiedData.AinStatus; }
            set
            {
                if (this.ModifiedData.AinStatus != value)
                     _status = null;
                this.ModifiedData.AinStatus = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_REVIEW_DATE" field.
        /// </summary>
        public DateTime? AinReviewDate
        {
            get { return this.ModifiedData.AinReviewDate; }
            set { this.ModifiedData.AinReviewDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_REF" field.
        /// </summary>
        public String AinRef
        {
            get { return this.ModifiedData.AinRef; }
            set { this.ModifiedData.AinRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_COST" field.
        /// </summary>
        public Decimal? AinCost
        {
            get { return this.ModifiedData.AinCost; }
            set { this.ModifiedData.AinCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_BIOG" field.
        /// </summary>
        public String AinBiog
        {
            get { return this.ModifiedData.AinBiog; }
            set { this.ModifiedData.AinBiog = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_ATTRIB01" field.
        /// </summary>
        public LocalCodeModel Attribute01
        {
            get
            {
                if (_attribute01 == null && !String.IsNullOrEmpty(this.Attribute01Code))
                    _attribute01 = this.Provider.Common.Code.FetchByTypeAndCode("TRAn1", this.Attribute01Code);
                if (_attribute01 == null)
                    _attribute01 = this.Provider.Common.Code.Create("TRAn1");
                return _attribute01;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_ATTRIB01" field.
        /// </summary>
        public String Attribute01Code
        {
            get { return this.ModifiedData.AinAttrib01; }
            set
            {
                if (this.ModifiedData.AinAttrib01 != value)
                     _attribute01 = null;
                this.ModifiedData.AinAttrib01 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_DAY_COST" field.
        /// </summary>
        public Decimal AinDayCost
        {
            get { return this.ModifiedData.AinDayCost; }
            set { this.ModifiedData.AinDayCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_HOUR_COST" field.
        /// </summary>
        public Decimal AinHourCost
        {
            get { return this.ModifiedData.AinHourCost; }
            set { this.ModifiedData.AinHourCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_BASE_POSTCODE" field.
        /// </summary>
        public String AinBasePostcode
        {
            get { return this.ModifiedData.AinBasePostcode; }
            set { this.ModifiedData.AinBasePostcode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_SELCO_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SellingCompany
        {
            get
            {
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.FetchById(this.SellingCompanyId);
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.Create();
                
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_SELCO_SP_ID" field.
        /// </summary>
        public String SellingCompanyId
        {
            get { return this.ModifiedData.AinSelcoSpId; }
            set
            {
                if (this.ModifiedData.AinSelcoSpId != value)
                     _sellingCompany = null;
                this.ModifiedData.AinSelcoSpId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_INS_EXPIRY" field.
        /// </summary>
        public DateTime? AinInsExpiry
        {
            get { return this.ModifiedData.AinInsExpiry; }
            set { this.ModifiedData.AinInsExpiry = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRN_UNIQUE_REF" field.
        /// </summary>
        public String NUniqueRef
        {
            get { return this.ModifiedData.NUniqueRef; }
            set { this.ModifiedData.NUniqueRef = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_FEE_NOTES_TEXT_ID" field.
        /// </summary>
        public LocalC4textModel FeeNotesText
        {
            get
            {
                if (_feeNotesText == null && this.FeeNotesTextId != null)
                    _feeNotesText = this.Provider.Activities.C4text.FetchById(this.FeeNotesTextId);
                if (_feeNotesText == null)
                    _feeNotesText = this.Provider.Activities.C4text.Create();
                
                return _feeNotesText;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_FEE_NOTES_TEXT_ID" field.
        /// </summary>
        public String FeeNotesTextId
        {
            get { return this.ModifiedData.AinFeeNotesTextId; }
            set
            {
                if (this.ModifiedData.AinFeeNotesTextId != value)
                     _feeNotesText = null;
                this.ModifiedData.AinFeeNotesTextId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_HOTEL_REQ_TEXT_ID" field.
        /// </summary>
        public LocalC4textModel HotelReqText
        {
            get
            {
                if (_hotelReqText == null && this.HotelReqTextId != null)
                    _hotelReqText = this.Provider.Activities.C4text.FetchById(this.HotelReqTextId);
                if (_hotelReqText == null)
                    _hotelReqText = this.Provider.Activities.C4text.Create();
                
                return _hotelReqText;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_HOTEL_REQ_TEXT_ID" field.
        /// </summary>
        public String HotelReqTextId
        {
            get { return this.ModifiedData.AinHotelReqTextId; }
            set
            {
                if (this.ModifiedData.AinHotelReqTextId != value)
                     _hotelReqText = null;
                this.ModifiedData.AinHotelReqTextId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_OTHER_INFO_TEXT_ID" field.
        /// </summary>
        public LocalC4textModel OtherInfoText
        {
            get
            {
                if (_otherInfoText == null && this.OtherInfoTextId != null)
                    _otherInfoText = this.Provider.Activities.C4text.FetchById(this.OtherInfoTextId);
                if (_otherInfoText == null)
                    _otherInfoText = this.Provider.Activities.C4text.Create();
                
                return _otherInfoText;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_OTHER_INFO_TEXT_ID" field.
        /// </summary>
        public String OtherInfoTextId
        {
            get { return this.ModifiedData.AinOtherInfoTextId; }
            set
            {
                if (this.ModifiedData.AinOtherInfoTextId != value)
                     _otherInfoText = null;
                this.ModifiedData.AinOtherInfoTextId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_PASSWORD" field.
        /// </summary>
        public String AinPassword
        {
            get { return this.ModifiedData.AinPassword; }
            set { this.ModifiedData.AinPassword = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_WEB" field.
        /// </summary>
        public Byte AinWeb
        {
            get { return this.ModifiedData.AinWeb; }
            set { this.ModifiedData.AinWeb = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_SY_TYPE" field.
        /// </summary>
        public Int32 AinSyType
        {
            get { return this.ModifiedData.AinSyType; }
            set { this.ModifiedData.AinSyType = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="TrainProdXrefModel" /> instances that reference this <see cref="TrainerModel" />.
        /// </summary>
        public LocalCollection<LocalTrainProdXrefModel, ITrainProdXrefModel> TrainProductXrefTrainer
        {
            get
            {
                if (_trainProductXrefTrainer == null)
                    _trainProductXrefTrainer = new LocalCollection<LocalTrainProdXrefModel, ITrainProdXrefModel>(this.Provider.Contact.TrainProdXref.FetchAllByTrainerId(this.Id));
                
                return _trainProductXrefTrainer;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProfileTrainerModel" /> instances that reference this <see cref="TrainerModel" />.
        /// </summary>
        public LocalCollection<LocalProfileTrainerModel, IProfileTrainerModel> Trainers
        {
            get
            {
                if (_trainers == null)
                    _trainers = new LocalCollection<LocalProfileTrainerModel, IProfileTrainerModel>(this.Provider.Common.ProfileTrainer.FetchAllByTrainerId(this.Id));
                
                return _trainers;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProfileVolunteerModel" /> instances that reference this <see cref="TrainerModel" />.
        /// </summary>
        public LocalCollection<LocalProfileVolunteerModel, IProfileVolunteerModel> ProfileVolunteers
        {
            get
            {
                if (_profileVolunteers == null)
                    _profileVolunteers = new LocalCollection<LocalProfileVolunteerModel, IProfileVolunteerModel>(this.Provider.Common.ProfileVolunteer.FetchAllByVolunteerId(this.Id));
                
                return _profileVolunteers;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalTrainerModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalTrainerModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalTrainerModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalTrainerModel(LocalProvider provider, TrainerRecord record) : base(provider, record)
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
            if (_status != null)
            {
                _status.Save();
                this.ModifiedData.AinStatus = _status.Value1;
            }
            if (_attribute01 != null)
            {
                _attribute01.Save();
                this.ModifiedData.AinAttrib01 = _attribute01.Value1;
            }
            if (_role != null)
            {
                _role.Save();
                this.ModifiedData.AinProleId = _role.Id == null && this.ModifiedData.AinProleId != null ? "" : _role.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.AinSelcoSpId = _sellingCompany.Id == null && this.ModifiedData.AinSelcoSpId != null ? "" : _sellingCompany.Id;
            }
            if (_feeNotesText != null)
            {
                _feeNotesText.Save();
                this.ModifiedData.AinFeeNotesTextId = _feeNotesText.Id == null && this.ModifiedData.AinFeeNotesTextId != null ? "" : _feeNotesText.Id;
            }
            if (_hotelReqText != null)
            {
                _hotelReqText.Save();
                this.ModifiedData.AinHotelReqTextId = _hotelReqText.Id == null && this.ModifiedData.AinHotelReqTextId != null ? "" : _hotelReqText.Id;
            }
            if (_otherInfoText != null)
            {
                _otherInfoText.Save();
                this.ModifiedData.AinOtherInfoTextId = _otherInfoText.Id == null && this.ModifiedData.AinOtherInfoTextId != null ? "" : _otherInfoText.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_trainProductXrefTrainer != null)
                _trainProductXrefTrainer.Execute(obj => obj.TrainerId = this.Id).Execute(obj => obj.Save());
            if (_trainers != null)
                _trainers.Execute(obj => obj.TrainerId = this.Id).Execute(obj => obj.Save());
            if (_profileVolunteers != null)
                _profileVolunteers.Execute(obj => obj.VolunteerId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_ADD_BY" field.
        /// </summary>
        System.String ITrainerModel.AinAddBy
        {
            get { return this.AinAddBy; }
            set { this.AinAddBy = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_MOD_BY" field.
        /// </summary>
        System.String ITrainerModel.AinModBy
        {
            get { return this.AinModBy; }
            set { this.AinModBy = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel ITrainerModel.Role
        {
            get { return this.Role; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_PROLE_ID" field.
        /// </summary>
        System.String ITrainerModel.RoleId
        {
            get { return this.RoleId; }
            set { this.RoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ITrainerModel.AinStartDate
        {
            get { return this.AinStartDate; }
            set { this.AinStartDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel ITrainerModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_STATUS" field.
        /// </summary>
        System.String ITrainerModel.StatusCode
        {
            get { return this.StatusCode; }
            set { this.StatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_REVIEW_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ITrainerModel.AinReviewDate
        {
            get { return this.AinReviewDate; }
            set { this.AinReviewDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_REF" field.
        /// </summary>
        System.String ITrainerModel.AinRef
        {
            get { return this.AinRef; }
            set { this.AinRef = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_COST" field.
        /// </summary>
        System.Nullable<System.Decimal> ITrainerModel.AinCost
        {
            get { return this.AinCost; }
            set { this.AinCost = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_BIOG" field.
        /// </summary>
        System.String ITrainerModel.AinBiog
        {
            get { return this.AinBiog; }
            set { this.AinBiog = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_ATTRIB01" field.
        /// </summary>
        Consensus.Common.ICodeModel ITrainerModel.Attribute01
        {
            get { return this.Attribute01; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_ATTRIB01" field.
        /// </summary>
        System.String ITrainerModel.Attribute01Code
        {
            get { return this.Attribute01Code; }
            set { this.Attribute01Code = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_DAY_COST" field.
        /// </summary>
        System.Decimal ITrainerModel.AinDayCost
        {
            get { return this.AinDayCost; }
            set { this.AinDayCost = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_HOUR_COST" field.
        /// </summary>
        System.Decimal ITrainerModel.AinHourCost
        {
            get { return this.AinHourCost; }
            set { this.AinHourCost = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_BASE_POSTCODE" field.
        /// </summary>
        System.String ITrainerModel.AinBasePostcode
        {
            get { return this.AinBasePostcode; }
            set { this.AinBasePostcode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel ITrainerModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_SELCO_SP_ID" field.
        /// </summary>
        System.String ITrainerModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_INS_EXPIRY" field.
        /// </summary>
        System.Nullable<System.DateTime> ITrainerModel.AinInsExpiry
        {
            get { return this.AinInsExpiry; }
            set { this.AinInsExpiry = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRN_UNIQUE_REF" field.
        /// </summary>
        System.String ITrainerModel.NUniqueRef
        {
            get { return this.NUniqueRef; }
            set { this.NUniqueRef = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_FEE_NOTES_TEXT_ID" field.
        /// </summary>
        Consensus.Activities.IC4textModel ITrainerModel.FeeNotesText
        {
            get { return this.FeeNotesText; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_FEE_NOTES_TEXT_ID" field.
        /// </summary>
        System.String ITrainerModel.FeeNotesTextId
        {
            get { return this.FeeNotesTextId; }
            set { this.FeeNotesTextId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_HOTEL_REQ_TEXT_ID" field.
        /// </summary>
        Consensus.Activities.IC4textModel ITrainerModel.HotelReqText
        {
            get { return this.HotelReqText; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_HOTEL_REQ_TEXT_ID" field.
        /// </summary>
        System.String ITrainerModel.HotelReqTextId
        {
            get { return this.HotelReqTextId; }
            set { this.HotelReqTextId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_OTHER_INFO_TEXT_ID" field.
        /// </summary>
        Consensus.Activities.IC4textModel ITrainerModel.OtherInfoText
        {
            get { return this.OtherInfoText; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_OTHER_INFO_TEXT_ID" field.
        /// </summary>
        System.String ITrainerModel.OtherInfoTextId
        {
            get { return this.OtherInfoTextId; }
            set { this.OtherInfoTextId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_PASSWORD" field.
        /// </summary>
        System.String ITrainerModel.AinPassword
        {
            get { return this.AinPassword; }
            set { this.AinPassword = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_WEB" field.
        /// </summary>
        System.Byte ITrainerModel.AinWeb
        {
            get { return this.AinWeb; }
            set { this.AinWeb = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_SY_TYPE" field.
        /// </summary>
        System.Int32 ITrainerModel.AinSyType
        {
            get { return this.AinSyType; }
            set { this.AinSyType = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainProdXrefModel" /> instances that reference this <see cref="!:TrainerModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ITrainProdXrefModel> ITrainerModel.TrainProductXrefTrainer
        {
            get { return this.TrainProductXrefTrainer; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProfileTrainerModel" /> instances that reference this <see cref="!:TrainerModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IProfileTrainerModel> ITrainerModel.Trainers
        {
            get { return this.Trainers; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProfileVolunteerModel" /> instances that reference this <see cref="!:TrainerModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IProfileVolunteerModel> ITrainerModel.ProfileVolunteers
        {
            get { return this.ProfileVolunteers; }
        }

        #endregion
    }
}
