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
    public partial class LocalProfileTrainerModel : LocalModel<ProfileRecord, String>, IProfileTrainerModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PROF_STATUS" field.
        /// </summary>
        private LocalCodeModel _status;

        /// <summary>
        ///     The value of the "PROF_TRAIN_ID" field.
        /// </summary>
        private LocalTrainerModel _trainer;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProfileRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Common.ProfileTrainer.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProfileRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Common.ProfileTrainer.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProfileRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Common.ProfileTrainer.RemoveById; }
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
        public LocalCodeModel Status
        {
            get
            {
                if (_status == null && !String.IsNullOrEmpty(this.StatusCode))
                    _status = this.Provider.Common.Code.FetchByTypeAndCode("PROST", this.StatusCode);
                if (_status == null)
                    _status = this.Provider.Common.Code.Create("PROST");
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_STATUS" field.
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
        ///     Gets or sets the value of the "PROF_VALUE2" field.
        /// </summary>
        public String Value2
        {
            get { return this.ModifiedData.Value2; }
            set { this.ModifiedData.Value2 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROF_TRAIN_ID" field.
        /// </summary>
        public LocalTrainerModel Trainer
        {
            get
            {
                if (_trainer == null && this.TrainerId != null)
                    _trainer = this.Provider.Contact.Trainer.FetchById(this.TrainerId);
                if (_trainer == null)
                    _trainer = this.Provider.Contact.Trainer.Create();
                
                return _trainer;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_TRAIN_ID" field.
        /// </summary>
        public String TrainerId
        {
            get { return this.ModifiedData.TrainId; }
            set
            {
                if (this.ModifiedData.TrainId != value)
                     _trainer = null;
                this.ModifiedData.TrainId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalProfileTrainerModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalProfileTrainerModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalProfileTrainerModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalProfileTrainerModel(LocalProvider provider, ProfileRecord record) : base(provider, record)
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
                this.ModifiedData.Status = _status.Value1;
            }
            if (_trainer != null)
            {
                _trainer.Save();
                this.ModifiedData.TrainId = _trainer.Id == null && this.ModifiedData.TrainId != null ? "" : _trainer.Id;
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
        System.String IProfileTrainerModel.Key
        {
            get { return this.Key; }
            set { this.Key = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE" field.
        /// </summary>
        System.String IProfileTrainerModel.Value
        {
            get { return this.Value; }
            set { this.Value = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_NOTES" field.
        /// </summary>
        System.String IProfileTrainerModel.Notes
        {
            get { return this.Notes; }
            set { this.Notes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IProfileTrainerModel.Date
        {
            get { return this.Date; }
            set { this.Date = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE3" field.
        /// </summary>
        System.String IProfileTrainerModel.Value3
        {
            get { return this.Value3; }
            set { this.Value3 = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROF_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel IProfileTrainerModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_STATUS" field.
        /// </summary>
        System.String IProfileTrainerModel.StatusCode
        {
            get { return this.StatusCode; }
            set { this.StatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE2" field.
        /// </summary>
        System.String IProfileTrainerModel.Value2
        {
            get { return this.Value2; }
            set { this.Value2 = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROF_TRAIN_ID" field.
        /// </summary>
        Consensus.Contact.ITrainerModel IProfileTrainerModel.Trainer
        {
            get { return this.Trainer; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_TRAIN_ID" field.
        /// </summary>
        System.String IProfileTrainerModel.TrainerId
        {
            get { return this.TrainerId; }
            set { this.TrainerId = (System.String)value; }
        }

        #endregion
    }
}
