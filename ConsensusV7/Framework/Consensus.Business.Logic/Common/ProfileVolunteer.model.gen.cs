using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="ProfileRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProfileVolunteerModel : LocalModel<ProfileRecord, String>, IProfileVolunteerModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PROF_STATUS" field.
        /// </summary>
        private LocalCodeModel _profStatus;

        /// <summary>
        ///     The value of the "PROF_VOL_ID" field.
        /// </summary>
        private LocalTrainerModel _volunteer;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProfileRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Common.ProfileVolunteer.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProfileRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Common.ProfileVolunteer.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProfileRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Common.ProfileVolunteer.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_KEY" field.
        /// </summary>
        public String Key
        {
            get { return this.ModifiedData.Key; }
            set { this.ModifiedData.Key = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE" field.
        /// </summary>
        public String Value
        {
            get { return this.ModifiedData.Value; }
            set { this.ModifiedData.Value = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return this.ModifiedData.Notes; }
            set { this.ModifiedData.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_DATE" field.
        /// </summary>
        public DateTime? Date
        {
            get { return this.ModifiedData.Date; }
            set { this.ModifiedData.Date = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE3" field.
        /// </summary>
        public String Value3
        {
            get { return this.ModifiedData.Value3; }
            set { this.ModifiedData.Value3 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROF_STATUS" field.
        /// </summary>
        public LocalCodeModel ProfStatus
        {
            get
            {
                if (_profStatus == null && !String.IsNullOrEmpty(this.ProfStatusCode))
                    _profStatus = this.Provider.Common.Code.FetchByTypeAndCode("PROST", this.ProfStatusCode);
                if (_profStatus == null)
                    _profStatus = this.Provider.Common.Code.Create("PROST");
                return _profStatus;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_STATUS" field.
        /// </summary>
        public String ProfStatusCode
        {
            get { return this.ModifiedData.Status; }
            set
            {
                if (this.ModifiedData.Status != value)
                     _profStatus = null;
                this.ModifiedData.Status = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE2" field.
        /// </summary>
        public String Value2
        {
            get { return this.ModifiedData.Value2; }
            set { this.ModifiedData.Value2 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROF_VOL_ID" field.
        /// </summary>
        public LocalTrainerModel Volunteer
        {
            get
            {
                if (_volunteer == null && this.VolunteerId != null)
                    _volunteer = this.Provider.Contact.Trainer.FetchById(this.VolunteerId);
                if (_volunteer == null)
                    _volunteer = this.Provider.Contact.Trainer.Create();
                
                return _volunteer;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_VOL_ID" field.
        /// </summary>
        public String VolunteerId
        {
            get { return this.ModifiedData.VolId; }
            set
            {
                if (this.ModifiedData.VolId != value)
                     _volunteer = null;
                this.ModifiedData.VolId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalProfileVolunteerModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalProfileVolunteerModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalProfileVolunteerModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalProfileVolunteerModel(LocalProvider provider, ProfileRecord record) : base(provider, record)
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
            if (_profStatus != null)
            {
                _profStatus.Save();
                this.ModifiedData.Status = _profStatus.Value1;
            }
            if (_volunteer != null)
            {
                _volunteer.Save();
                this.ModifiedData.VolId = _volunteer.Id == null && this.ModifiedData.VolId != null ? "" : _volunteer.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "PROF_KEY" field.
        /// </summary>
        System.String IProfileVolunteerModel.Key
        {
            get { return this.Key; }
            set { this.Key = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE" field.
        /// </summary>
        System.String IProfileVolunteerModel.Value
        {
            get { return this.Value; }
            set { this.Value = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_NOTES" field.
        /// </summary>
        System.String IProfileVolunteerModel.Notes
        {
            get { return this.Notes; }
            set { this.Notes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IProfileVolunteerModel.Date
        {
            get { return this.Date; }
            set { this.Date = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE3" field.
        /// </summary>
        System.String IProfileVolunteerModel.Value3
        {
            get { return this.Value3; }
            set { this.Value3 = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROF_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel IProfileVolunteerModel.ProfStatus
        {
            get { return this.ProfStatus; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_STATUS" field.
        /// </summary>
        System.String IProfileVolunteerModel.ProfStatusCode
        {
            get { return this.ProfStatusCode; }
            set { this.ProfStatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE2" field.
        /// </summary>
        System.String IProfileVolunteerModel.Value2
        {
            get { return this.Value2; }
            set { this.Value2 = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROF_VOL_ID" field.
        /// </summary>
        Consensus.Contact.ITrainerModel IProfileVolunteerModel.Volunteer
        {
            get { return this.Volunteer; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_VOL_ID" field.
        /// </summary>
        System.String IProfileVolunteerModel.VolunteerId
        {
            get { return this.VolunteerId; }
            set { this.VolunteerId = (System.String)value; }
        }

        #endregion
    }
}
