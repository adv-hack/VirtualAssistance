using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="TemplateXrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalTemplateTrainerModel : LocalTemplateModel, ITemplateTrainerModel
    {
        #region fields

        /// <summary>
        ///     The value of the "TXREF_TRAIN_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _trainerRole;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<TemplateXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.Template.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<TemplateXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.Template.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<TemplateXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.Template.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_PROF_KEY" field.
        /// </summary>
        public String ProfKey
        {
            get { return this.ModifiedData.ProfKey; }
            set { this.ModifiedData.ProfKey = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_PROF_VALUE" field.
        /// </summary>
        public String ProfValue
        {
            get { return this.ModifiedData.ProfValue; }
            set { this.ModifiedData.ProfValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_PROF_VALUE2" field.
        /// </summary>
        public String ProfValue2
        {
            get { return this.ModifiedData.ProfValue2; }
            set { this.ModifiedData.ProfValue2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_RATIO" field.
        /// </summary>
        public Int32 Ratio
        {
            get { return this.ModifiedData.Ratio; }
            set { this.ModifiedData.Ratio = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_TRAINER" field.
        /// </summary>
        public Byte? Trainer
        {
            get { return this.ModifiedData.Trainer; }
            set { this.ModifiedData.Trainer = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TXREF_TRAIN_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel TrainerRole
        {
            get
            {
                if (_trainerRole == null && this.TrainerRoleId != null)
                    _trainerRole = this.Provider.Contact.Role.FetchById(this.TrainerRoleId);
                if (_trainerRole == null)
                    _trainerRole = this.Provider.Contact.Role.Create();
                
                return _trainerRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TXREF_TRAIN_PROLE_ID" field.
        /// </summary>
        public String TrainerRoleId
        {
            get { return this.ModifiedData.TrainProleId; }
            set
            {
                if (this.ModifiedData.TrainProleId != value)
                     _trainerRole = null;
                this.ModifiedData.TrainProleId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalTemplateTrainerModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalTemplateTrainerModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalTemplateTrainerModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalTemplateTrainerModel(LocalProvider provider, TemplateXrefRecord record) : base(provider, record)
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
            if (_trainerRole != null)
            {
                _trainerRole.Save();
                this.ModifiedData.TrainProleId = _trainerRole.Id == null && this.ModifiedData.TrainProleId != null ? "" : _trainerRole.Id;
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
        ///     Gets the The value of the "TXREF_TRAINER" field.
        /// </summary>
        Consensus.Common.ICodeModel ITemplateTrainerModel.TypeModel
        {
            get { return this.TypeModel; }
        }

        System.String ITemplateTrainerModel.TypeModelCode
        {
            get { return this.TypeModelCode; }
            set { this.TypeModelCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_PROF_KEY" field.
        /// </summary>
        System.String ITemplateTrainerModel.ProfKey
        {
            get { return this.ProfKey; }
            set { this.ProfKey = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_PROF_VALUE" field.
        /// </summary>
        System.String ITemplateTrainerModel.ProfValue
        {
            get { return this.ProfValue; }
            set { this.ProfValue = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_PROF_VALUE2" field.
        /// </summary>
        System.String ITemplateTrainerModel.ProfValue2
        {
            get { return this.ProfValue2; }
            set { this.ProfValue2 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_RATIO" field.
        /// </summary>
        System.Int32 ITemplateTrainerModel.Ratio
        {
            get { return this.Ratio; }
            set { this.Ratio = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_TRAINER" field.
        /// </summary>
        System.Nullable<System.Byte> ITemplateTrainerModel.Trainer
        {
            get { return this.Trainer; }
            set { this.Trainer = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "TXREF_TRAIN_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel ITemplateTrainerModel.TrainerRole
        {
            get { return this.TrainerRole; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TXREF_TRAIN_PROLE_ID" field.
        /// </summary>
        System.String ITemplateTrainerModel.TrainerRoleId
        {
            get { return this.TrainerRoleId; }
            set { this.TrainerRoleId = (System.String)value; }
        }

        #endregion
    }
}
