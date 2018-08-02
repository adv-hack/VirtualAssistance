using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="BranchXrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalBranchXrefModel : LocalModel<BranchXrefRecord, String>, IBranchXrefModel
    {
        #region fields

        /// <summary>
        ///     The value of the "BRXREF_BR_ID" field.
        /// </summary>
        private LocalBranchModel _branch;

        /// <summary>
        ///     The value of the "BRXREF_STATUS" field.
        /// </summary>
        private LocalCodeModel _status;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<BranchXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Membership.BranchXref.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<BranchXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Membership.BranchXref.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<BranchXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Membership.BranchXref.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "BRXREF_BR_ID" field.
        /// </summary>
        public LocalBranchModel Branch
        {
            get
            {
                if (_branch == null && this.BranchId != null)
                    _branch = this.Provider.Membership.Branch.FetchById(this.BranchId);
                if (_branch == null)
                    _branch = this.Provider.Membership.Branch.Create();
                
                return _branch;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BRXREF_BR_ID" field.
        /// </summary>
        public String BranchId
        {
            get { return this.ModifiedData.BrId; }
            set
            {
                if (this.ModifiedData.BrId != value)
                     _branch = null;
                this.ModifiedData.BrId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BRXREF_TABLE_NAME" field.
        /// </summary>
        public String TableName
        {
            get { return this.ModifiedData.TableName; }
            set { this.ModifiedData.TableName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BRXREF_RECORD_ID" field.
        /// </summary>
        public String RecordId
        {
            get { return this.ModifiedData.RecordId; }
            set { this.ModifiedData.RecordId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BRXREF_STATUS" field.
        /// </summary>
        public LocalCodeModel Status
        {
            get
            {
                if (_status == null && !String.IsNullOrEmpty(this.StatusCode))
                    _status = this.Provider.Common.Code.FetchByTypeAndCode("MBSTA", this.StatusCode);
                if (_status == null)
                    _status = this.Provider.Common.Code.Create("MBSTA");
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BRXREF_STATUS" field.
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
        ///     Gets or sets the value of the "BRXREF_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return this.ModifiedData.StartDate; }
            set { this.ModifiedData.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BRXREF_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return this.ModifiedData.EndDate; }
            set { this.ModifiedData.EndDate = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalBranchXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalBranchXrefModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalBranchXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalBranchXrefModel(LocalProvider provider, BranchXrefRecord record) : base(provider, record)
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
            if (_branch != null)
            {
                _branch.Save();
                this.ModifiedData.BrId = _branch.Id == null && this.ModifiedData.BrId != null ? "" : _branch.Id;
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
        ///     Gets the The value of the "BRXREF_BR_ID" field.
        /// </summary>
        Consensus.Membership.IBranchModel IBranchXrefModel.Branch
        {
            get { return this.Branch; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BRXREF_BR_ID" field.
        /// </summary>
        System.String IBranchXrefModel.BranchId
        {
            get { return this.BranchId; }
            set { this.BranchId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BRXREF_TABLE_NAME" field.
        /// </summary>
        System.String IBranchXrefModel.TableName
        {
            get { return this.TableName; }
            set { this.TableName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BRXREF_RECORD_ID" field.
        /// </summary>
        System.String IBranchXrefModel.RecordId
        {
            get { return this.RecordId; }
            set { this.RecordId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BRXREF_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel IBranchXrefModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BRXREF_STATUS" field.
        /// </summary>
        System.String IBranchXrefModel.StatusCode
        {
            get { return this.StatusCode; }
            set { this.StatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BRXREF_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IBranchXrefModel.StartDate
        {
            get { return this.StartDate; }
            set { this.StartDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BRXREF_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IBranchXrefModel.EndDate
        {
            get { return this.EndDate; }
            set { this.EndDate = (System.Nullable<System.DateTime>)value; }
        }

        #endregion
    }
}
