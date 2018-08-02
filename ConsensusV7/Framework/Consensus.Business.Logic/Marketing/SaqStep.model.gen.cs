using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="SaqStepRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSaqStepModel : LocalModel<SaqStepRecord, Int64>, ISaqStepModel
    {
        #region fields

        /// <summary>
        ///     The value of the "STEP_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _ownerRole;

        /// <summary>
        ///     The collection of <see cref="SaqParameterModel" /> instances that reference this <see cref="SaqStepModel" />.
        /// </summary>
        private LocalCollection<LocalSaqParameterModel, ISaqParameterModel> _saqParameterStep;

        /// <summary>
        ///     The collection of <see cref="SaqQueryStepModel" /> instances that reference this <see cref="SaqStepModel" />.
        /// </summary>
        private LocalCollection<LocalSaqQueryStepModel, ISaqQueryStepModel> _saqQueryStepStep;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqStepRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Marketing.SaqStep.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqStepRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Marketing.SaqStep.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqStepRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Marketing.SaqStep.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "STEP_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel OwnerRole
        {
            get
            {
                if (_ownerRole == null && this.OwnerRoleId != null)
                    _ownerRole = this.Provider.Contact.Role.FetchById(this.OwnerRoleId);
                if (_ownerRole == null)
                    _ownerRole = this.Provider.Contact.Role.Create();
                
                return _ownerRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "STEP_PROLE_ID" field.
        /// </summary>
        public String OwnerRoleId
        {
            get { return this.ModifiedData.ProleId; }
            set
            {
                if (this.ModifiedData.ProleId != value)
                     _ownerRole = null;
                this.ModifiedData.ProleId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return this.ModifiedData.Desc; }
            set { this.ModifiedData.Desc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_RESULT_SIZE_OPT" field.
        /// </summary>
        public Byte ResultSizeOpt
        {
            get { return this.ModifiedData.ResultSizeOpt; }
            set { this.ModifiedData.ResultSizeOpt = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_RESULT_SIZE" field.
        /// </summary>
        public Int64 ResultSize
        {
            get { return this.ModifiedData.ResultSize; }
            set { this.ModifiedData.ResultSize = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_IN_USE" field.
        /// </summary>
        public Byte InUse
        {
            get { return this.ModifiedData.InUse; }
            set { this.ModifiedData.InUse = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_ORG_ONLY" field.
        /// </summary>
        public Byte OrgOnly
        {
            get { return this.ModifiedData.OrgOnly; }
            set { this.ModifiedData.OrgOnly = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_LOCKED" field.
        /// </summary>
        public Byte Locked
        {
            get { return this.ModifiedData.Locked; }
            set { this.ModifiedData.Locked = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_BOOK_ONLY" field.
        /// </summary>
        public Byte BookOnly
        {
            get { return this.ModifiedData.BookOnly; }
            set { this.ModifiedData.BookOnly = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_LINK_DEFAULT" field.
        /// </summary>
        public String LinkDefault
        {
            get { return this.ModifiedData.LinkDefault; }
            set { this.ModifiedData.LinkDefault = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SaqParameterModel" /> instances that reference this <see cref="SaqStepModel" />.
        /// </summary>
        public LocalCollection<LocalSaqParameterModel, ISaqParameterModel> SaqParameterStep
        {
            get
            {
                if (_saqParameterStep == null)
                    _saqParameterStep = new LocalCollection<LocalSaqParameterModel, ISaqParameterModel>(this.Provider.Marketing.SaqParameter.FetchAllByStepId(this.Id));
                
                return _saqParameterStep;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SaqQueryStepModel" /> instances that reference this <see cref="SaqStepModel" />.
        /// </summary>
        public LocalCollection<LocalSaqQueryStepModel, ISaqQueryStepModel> SaqQueryStepStep
        {
            get
            {
                if (_saqQueryStepStep == null)
                    _saqQueryStepStep = new LocalCollection<LocalSaqQueryStepModel, ISaqQueryStepModel>(this.Provider.Marketing.SaqQueryStep.FetchAllByStepId(this.Id));
                
                return _saqQueryStepStep;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSaqStepModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSaqStepModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSaqStepModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSaqStepModel(LocalProvider provider, SaqStepRecord record) : base(provider, record)
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
            if (_ownerRole != null)
            {
                _ownerRole.Save();
                this.ModifiedData.ProleId = _ownerRole.Id == null && this.ModifiedData.ProleId != null ? "" : _ownerRole.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_saqParameterStep != null)
                _saqParameterStep.Execute(obj => obj.StepId = this.Id).Execute(obj => obj.Save());
            if (_saqQueryStepStep != null)
                _saqQueryStepStep.Execute(obj => obj.StepId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "STEP_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel ISaqStepModel.OwnerRole
        {
            get { return this.OwnerRole; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "STEP_PROLE_ID" field.
        /// </summary>
        System.String ISaqStepModel.OwnerRoleId
        {
            get { return this.OwnerRoleId; }
            set { this.OwnerRoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_NAME" field.
        /// </summary>
        System.String ISaqStepModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_DESC" field.
        /// </summary>
        System.String ISaqStepModel.Desc
        {
            get { return this.Desc; }
            set { this.Desc = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_RESULT_SIZE_OPT" field.
        /// </summary>
        System.Byte ISaqStepModel.ResultSizeOpt
        {
            get { return this.ResultSizeOpt; }
            set { this.ResultSizeOpt = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_RESULT_SIZE" field.
        /// </summary>
        System.Int64 ISaqStepModel.ResultSize
        {
            get { return this.ResultSize; }
            set { this.ResultSize = (System.Int64)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_IN_USE" field.
        /// </summary>
        System.Byte ISaqStepModel.InUse
        {
            get { return this.InUse; }
            set { this.InUse = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_ORG_ONLY" field.
        /// </summary>
        System.Byte ISaqStepModel.OrgOnly
        {
            get { return this.OrgOnly; }
            set { this.OrgOnly = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_LOCKED" field.
        /// </summary>
        System.Byte ISaqStepModel.Locked
        {
            get { return this.Locked; }
            set { this.Locked = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_BOOK_ONLY" field.
        /// </summary>
        System.Byte ISaqStepModel.BookOnly
        {
            get { return this.BookOnly; }
            set { this.BookOnly = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_LINK_DEFAULT" field.
        /// </summary>
        System.String ISaqStepModel.LinkDefault
        {
            get { return this.LinkDefault; }
            set { this.LinkDefault = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqParameterModel" /> instances that reference this <see cref="!:SaqStepModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqParameterModel> ISaqStepModel.SaqParameterStep
        {
            get { return this.SaqParameterStep; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryStepModel" /> instances that reference this <see cref="!:SaqStepModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueryStepModel> ISaqStepModel.SaqQueryStepStep
        {
            get { return this.SaqQueryStepStep; }
        }

        #endregion
    }
}
