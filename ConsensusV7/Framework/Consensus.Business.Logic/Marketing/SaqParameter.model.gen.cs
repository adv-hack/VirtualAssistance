using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="SaqStepParamsRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSaqParameterModel : LocalModel<SaqStepParamsRecord, Int64>, ISaqParameterModel
    {
        #region fields

        /// <summary>
        ///     The value of the "STPRM_STEP_ID" field.
        /// </summary>
        private LocalSaqStepModel _step;

        /// <summary>
        ///     The value of the "STPRM_F_ID" field.
        /// </summary>
        private LocalSaqFilterFieldModel _filterField;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqStepParamsRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Marketing.SaqParameter.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqStepParamsRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Marketing.SaqParameter.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqStepParamsRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Marketing.SaqParameter.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "STPRM_STEP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "STPRM_STEP_ID" field.
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
        ///     Gets the The value of the "STPRM_F_ID" field.
        /// </summary>
        public LocalSaqFilterFieldModel FilterField
        {
            get
            {
                if (_filterField == null)
                    _filterField = this.Provider.Marketing.SaqFilterField.FetchById(this.FilterFieldId);
                if (_filterField == null)
                    _filterField = this.Provider.Marketing.SaqFilterField.Create();
                
                return _filterField;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "STPRM_F_ID" field.
        /// </summary>
        public Int64 FilterFieldId
        {
            get { return this.ModifiedData.FId; }
            set
            {
                if (this.ModifiedData.FId != value)
                     _filterField = null;
                this.ModifiedData.FId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_CONDITION" field.
        /// </summary>
        public String Condition
        {
            get { return this.ModifiedData.Condition; }
            set { this.ModifiedData.Condition = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_VALUE" field.
        /// </summary>
        public String Value
        {
            get { return this.ModifiedData.Value; }
            set { this.ModifiedData.Value = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_OPERAND" field.
        /// </summary>
        public String Operand
        {
            get { return this.ModifiedData.Operand; }
            set { this.ModifiedData.Operand = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_ORDER" field.
        /// </summary>
        public Int32 Order
        {
            get { return this.ModifiedData.Order; }
            set { this.ModifiedData.Order = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_PRE_BRACKET" field.
        /// </summary>
        public String PreBracket
        {
            get { return this.ModifiedData.PreBracket; }
            set { this.ModifiedData.PreBracket = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_POST_BRACKET" field.
        /// </summary>
        public String PostBracket
        {
            get { return this.ModifiedData.PostBracket; }
            set { this.ModifiedData.PostBracket = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSaqParameterModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSaqParameterModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSaqParameterModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSaqParameterModel(LocalProvider provider, SaqStepParamsRecord record) : base(provider, record)
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
            if (_step != null)
            {
                _step.Save();
                this.ModifiedData.StepId = _step.Id;
            }
            if (_filterField != null)
            {
                _filterField.Save();
                this.ModifiedData.FId = _filterField.Id;
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
        ///     Gets the The value of the "STPRM_STEP_ID" field.
        /// </summary>
        Consensus.Marketing.ISaqStepModel ISaqParameterModel.Step
        {
            get { return this.Step; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "STPRM_STEP_ID" field.
        /// </summary>
        System.Int64 ISaqParameterModel.StepId
        {
            get { return this.StepId; }
            set { this.StepId = (System.Int64)value; }
        }

        /// <summary>
        ///     Gets the The value of the "STPRM_F_ID" field.
        /// </summary>
        Consensus.Marketing.ISaqFilterFieldModel ISaqParameterModel.FilterField
        {
            get { return this.FilterField; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "STPRM_F_ID" field.
        /// </summary>
        System.Int64 ISaqParameterModel.FilterFieldId
        {
            get { return this.FilterFieldId; }
            set { this.FilterFieldId = (System.Int64)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_CONDITION" field.
        /// </summary>
        System.String ISaqParameterModel.Condition
        {
            get { return this.Condition; }
            set { this.Condition = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_VALUE" field.
        /// </summary>
        System.String ISaqParameterModel.Value
        {
            get { return this.Value; }
            set { this.Value = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_OPERAND" field.
        /// </summary>
        System.String ISaqParameterModel.Operand
        {
            get { return this.Operand; }
            set { this.Operand = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_ORDER" field.
        /// </summary>
        System.Int32 ISaqParameterModel.Order
        {
            get { return this.Order; }
            set { this.Order = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_PRE_BRACKET" field.
        /// </summary>
        System.String ISaqParameterModel.PreBracket
        {
            get { return this.PreBracket; }
            set { this.PreBracket = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_POST_BRACKET" field.
        /// </summary>
        System.String ISaqParameterModel.PostBracket
        {
            get { return this.PostBracket; }
            set { this.PostBracket = (System.String)value; }
        }

        #endregion
    }
}
