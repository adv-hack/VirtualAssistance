using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="SaqQueryStepsRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSaqQueryStepModel : LocalModel<SaqQueryStepsRecord, Int32>, ISaqQueryStepModel
    {
        #region fields

        /// <summary>
        ///     The value of the "QSTEP_QRY_ID" field.
        /// </summary>
        private LocalSaqQueryModel _stepQuery;

        /// <summary>
        ///     The value of the "QSTEP_STEP_ID" field.
        /// </summary>
        private LocalSaqStepModel _step;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqQueryStepsRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Marketing.SaqQueryStep.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqQueryStepsRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Marketing.SaqQueryStep.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqQueryStepsRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Marketing.SaqQueryStep.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "QSTEP_QRY_ID" field.
        /// </summary>
        public LocalSaqQueryModel StepQuery
        {
            get
            {
                if (_stepQuery == null)
                    _stepQuery = this.Provider.Marketing.SaqQuery.FetchById(this.StepQueryId);
                if (_stepQuery == null)
                    _stepQuery = this.Provider.Marketing.SaqQuery.Create();
                
                return _stepQuery;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QSTEP_QRY_ID" field.
        /// </summary>
        public Int64 StepQueryId
        {
            get { return this.ModifiedData.QryId; }
            set
            {
                if (this.ModifiedData.QryId != value)
                     _stepQuery = null;
                this.ModifiedData.QryId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "QSTEP_STEP_ID" field.
        /// </summary>
        public LocalSaqStepModel Step
        {
            get
            {
                if (_step == null)
                    _step = this.Provider.Marketing.SaqStep.FetchById(this.StepId);
                if (_step == null)
                    _step = this.Provider.Marketing.SaqStep.Create();
                
                return _step;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QSTEP_STEP_ID" field.
        /// </summary>
        public Int64 StepId
        {
            get { return this.ModifiedData.StepId; }
            set
            {
                if (this.ModifiedData.StepId != value)
                     _step = null;
                this.ModifiedData.StepId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_LINK" field.
        /// </summary>
        public String Link
        {
            get { return this.ModifiedData.Link; }
            set { this.ModifiedData.Link = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_ORDER" field.
        /// </summary>
        public Int16 Order
        {
            get { return this.ModifiedData.Order; }
            set { this.ModifiedData.Order = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_RESULT_COUNT" field.
        /// </summary>
        public Int64 ResultCount
        {
            get { return this.ModifiedData.ResultCount; }
            set { this.ModifiedData.ResultCount = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_ORG_TOTAL" field.
        /// </summary>
        public Int64 OrgTotal
        {
            get { return this.ModifiedData.OrgTotal; }
            set { this.ModifiedData.OrgTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_ROLE_TOTAL" field.
        /// </summary>
        public Int64 RoleTotal
        {
            get { return this.ModifiedData.RoleTotal; }
            set { this.ModifiedData.RoleTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_PERSON_TOTAL" field.
        /// </summary>
        public Int64 PersonTotal
        {
            get { return this.ModifiedData.PersonTotal; }
            set { this.ModifiedData.PersonTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_LOCKED" field.
        /// </summary>
        public Byte Locked
        {
            get { return this.ModifiedData.Locked; }
            set { this.ModifiedData.Locked = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSaqQueryStepModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSaqQueryStepModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSaqQueryStepModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSaqQueryStepModel(LocalProvider provider, SaqQueryStepsRecord record) : base(provider, record)
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
            if (_stepQuery != null)
            {
                _stepQuery.Save();
                this.ModifiedData.QryId = _stepQuery.Id;
            }
            if (_step != null)
            {
                _step.Save();
                this.ModifiedData.StepId = _step.Id;
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
        ///     Gets the The value of the "QSTEP_QRY_ID" field.
        /// </summary>
        Consensus.Marketing.ISaqQueryModel ISaqQueryStepModel.StepQuery
        {
            get { return this.StepQuery; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QSTEP_QRY_ID" field.
        /// </summary>
        System.Int64 ISaqQueryStepModel.StepQueryId
        {
            get { return this.StepQueryId; }
            set { this.StepQueryId = (System.Int64)value; }
        }

        /// <summary>
        ///     Gets the The value of the "QSTEP_STEP_ID" field.
        /// </summary>
        Consensus.Marketing.ISaqStepModel ISaqQueryStepModel.Step
        {
            get { return this.Step; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QSTEP_STEP_ID" field.
        /// </summary>
        System.Int64 ISaqQueryStepModel.StepId
        {
            get { return this.StepId; }
            set { this.StepId = (System.Int64)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_LINK" field.
        /// </summary>
        System.String ISaqQueryStepModel.Link
        {
            get { return this.Link; }
            set { this.Link = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_ORDER" field.
        /// </summary>
        System.Int16 ISaqQueryStepModel.Order
        {
            get { return this.Order; }
            set { this.Order = (System.Int16)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_RESULT_COUNT" field.
        /// </summary>
        System.Int64 ISaqQueryStepModel.ResultCount
        {
            get { return this.ResultCount; }
            set { this.ResultCount = (System.Int64)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_ORG_TOTAL" field.
        /// </summary>
        System.Int64 ISaqQueryStepModel.OrgTotal
        {
            get { return this.OrgTotal; }
            set { this.OrgTotal = (System.Int64)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_ROLE_TOTAL" field.
        /// </summary>
        System.Int64 ISaqQueryStepModel.RoleTotal
        {
            get { return this.RoleTotal; }
            set { this.RoleTotal = (System.Int64)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_PERSON_TOTAL" field.
        /// </summary>
        System.Int64 ISaqQueryStepModel.PersonTotal
        {
            get { return this.PersonTotal; }
            set { this.PersonTotal = (System.Int64)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_LOCKED" field.
        /// </summary>
        System.Byte ISaqQueryStepModel.Locked
        {
            get { return this.Locked; }
            set { this.Locked = (System.Byte)value; }
        }

        #endregion
    }
}
