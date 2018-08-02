using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Document;

namespace Consensus.Other
{
    /// <summary>
    ///     Encapsulates the <see cref="BatchRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalBatchModel : LocalModel<BatchRecord, String>, IBatchModel
    {
        #region fields

        /// <summary>
        ///     The value of the "BAT_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The value of the "BAT_EC_ID" field.
        /// </summary>
        private LocalExportconfigurationsModel _batchEcId;

        /// <summary>
        ///     The value of the "BAT_DI_ID" field.
        /// </summary>
        private LocalDataimportsModel _batchDiId;

        /// <summary>
        ///     The collection of <see cref="PrintRequestModel" /> instances that reference this <see cref="BatchModel" />.
        /// </summary>
        private LocalCollection<LocalPrintRequestModel, IPrintRequestModel> _batchPrintRequests;

        /// <summary>
        ///     The collection of <see cref="BatchXrefModel" /> instances that reference this <see cref="BatchModel" />.
        /// </summary>
        private LocalCollection<LocalBatchXrefModel, IBatchXrefModel> _batchXref;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<BatchRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Other.Batch.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<BatchRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Other.Batch.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<BatchRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Other.Batch.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_PROC" field.
        /// </summary>
        public String Procedure
        {
            get { return this.ModifiedData.Proc; }
            set { this.ModifiedData.Proc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return this.ModifiedData.Status; }
            set { this.ModifiedData.Status = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_COUNT" field.
        /// </summary>
        public Int32? BatchProcessedRecords
        {
            get { return this.ModifiedData.Count; }
            set { this.ModifiedData.Count = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_START_D_T" field.
        /// </summary>
        public DateTime? BatchStartedDate
        {
            get { return this.ModifiedData.StartDT; }
            set { this.ModifiedData.StartDT = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_RUN_D_T" field.
        /// </summary>
        public DateTime? BatchFinishedDate
        {
            get { return this.ModifiedData.RunDT; }
            set { this.ModifiedData.RunDT = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_RUN_BY" field.
        /// </summary>
        public String BatchRunBy
        {
            get { return this.ModifiedData.RunBy; }
            set { this.ModifiedData.RunBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_NOTE" field.
        /// </summary>
        public String BatchNote
        {
            get { return this.ModifiedData.Note; }
            set { this.ModifiedData.Note = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BAT_SELCO_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.SellingCompanyId != null)
                    _sellingCompany = this.Provider.Common.SellingCompany.FetchById(this.SellingCompanyId);
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.Create();
                
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BAT_SELCO_SP_ID" field.
        /// </summary>
        public String SellingCompanyId
        {
            get { return this.ModifiedData.SelcoSpId; }
            set
            {
                if (this.ModifiedData.SelcoSpId != value)
                     _sellingCompany = null;
                this.ModifiedData.SelcoSpId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_ERROR_NOTE" field.
        /// </summary>
        public String BatchErrorNote
        {
            get { return this.ModifiedData.ErrorNote; }
            set { this.ModifiedData.ErrorNote = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_EXT_FLAG" field.
        /// </summary>
        public Byte? ExternallyCompleted
        {
            get { return this.ModifiedData.ExtFlag; }
            set { this.ModifiedData.ExtFlag = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_DD_STATUS" field.
        /// </summary>
        public Byte? DdStatus
        {
            get { return this.ModifiedData.DdStatus; }
            set { this.ModifiedData.DdStatus = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_REC_ID" field.
        /// </summary>
        public String RecId
        {
            get { return this.ModifiedData.RecId; }
            set { this.ModifiedData.RecId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_RERUN" field.
        /// </summary>
        public Byte Rerun
        {
            get { return this.ModifiedData.Rerun; }
            set { this.ModifiedData.Rerun = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BAT_EC_ID" field.
        /// </summary>
        public LocalExportconfigurationsModel BatchEcId
        {
            get
            {
                if (_batchEcId == null && this.BatchEcIdId != null)
                    _batchEcId = this.Provider.Other.Exportconfigurations.FetchById(this.BatchEcIdId.Value);
                if (_batchEcId == null)
                    _batchEcId = this.Provider.Other.Exportconfigurations.Create();
                
                return _batchEcId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BAT_EC_ID" field.
        /// </summary>
        public Int32? BatchEcIdId
        {
            get { return this.ModifiedData.EcId; }
            set
            {
                if (this.ModifiedData.EcId != value)
                     _batchEcId = null;
                this.ModifiedData.EcId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_ARG_ID" field.
        /// </summary>
        public String ArgId
        {
            get { return this.ModifiedData.ArgId; }
            set { this.ModifiedData.ArgId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BAT_DI_ID" field.
        /// </summary>
        public LocalDataimportsModel BatchDiId
        {
            get
            {
                if (_batchDiId == null && this.BatchDiIdId != null)
                    _batchDiId = this.Provider.Other.Dataimports.FetchById(this.BatchDiIdId.Value);
                if (_batchDiId == null)
                    _batchDiId = this.Provider.Other.Dataimports.Create();
                
                return _batchDiId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BAT_DI_ID" field.
        /// </summary>
        public Int32? BatchDiIdId
        {
            get { return this.ModifiedData.DiId; }
            set
            {
                if (this.ModifiedData.DiId != value)
                     _batchDiId = null;
                this.ModifiedData.DiId = value;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PrintRequestModel" /> instances that reference this <see cref="BatchModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalPrintRequestModel, IPrintRequestModel> BatchPrintRequests
        {
            get
            {
                if (_batchPrintRequests == null)
                    _batchPrintRequests = new LocalCollection<LocalPrintRequestModel, IPrintRequestModel>(this.Provider.Document.PrintRequest.FetchAllByBatchId(this.Id));
                
                return _batchPrintRequests;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BatchXrefModel" /> instances that reference this <see cref="BatchModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalBatchXrefModel, IBatchXrefModel> BatchXref
        {
            get
            {
                if (_batchXref == null)
                    _batchXref = new LocalCollection<LocalBatchXrefModel, IBatchXrefModel>(this.Provider.Other.BatchXref.FetchAllByBatchId(this.Id));
                
                return _batchXref;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalBatchModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalBatchModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalBatchModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalBatchModel(LocalProvider provider, BatchRecord record) : base(provider, record)
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
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
            }
            if (_batchEcId != null)
            {
                _batchEcId.Save();
                this.ModifiedData.EcId = _batchEcId.Id;
            }
            if (_batchDiId != null)
            {
                _batchDiId.Save();
                this.ModifiedData.DiId = _batchDiId.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_batchPrintRequests != null)
                _batchPrintRequests.Execute(obj => obj.BatchId = this.Id).Execute(obj => obj.Save());
            if (_batchXref != null)
                _batchXref.Execute(obj => obj.BatchId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "BAT_TYPE" field.
        /// </summary>
        System.String IBatchModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_PROC" field.
        /// </summary>
        System.String IBatchModel.Procedure
        {
            get { return this.Procedure; }
            set { this.Procedure = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_STATUS" field.
        /// </summary>
        System.String IBatchModel.Status
        {
            get { return this.Status; }
            set { this.Status = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_COUNT" field.
        /// </summary>
        System.Nullable<System.Int32> IBatchModel.BatchProcessedRecords
        {
            get { return this.BatchProcessedRecords; }
            set { this.BatchProcessedRecords = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_START_D_T" field.
        /// </summary>
        System.Nullable<System.DateTime> IBatchModel.BatchStartedDate
        {
            get { return this.BatchStartedDate; }
            set { this.BatchStartedDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_RUN_D_T" field.
        /// </summary>
        System.Nullable<System.DateTime> IBatchModel.BatchFinishedDate
        {
            get { return this.BatchFinishedDate; }
            set { this.BatchFinishedDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_RUN_BY" field.
        /// </summary>
        System.String IBatchModel.BatchRunBy
        {
            get { return this.BatchRunBy; }
            set { this.BatchRunBy = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_NOTE" field.
        /// </summary>
        System.String IBatchModel.BatchNote
        {
            get { return this.BatchNote; }
            set { this.BatchNote = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BAT_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IBatchModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BAT_SELCO_SP_ID" field.
        /// </summary>
        System.String IBatchModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_ERROR_NOTE" field.
        /// </summary>
        System.String IBatchModel.BatchErrorNote
        {
            get { return this.BatchErrorNote; }
            set { this.BatchErrorNote = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_EXT_FLAG" field.
        /// </summary>
        System.Nullable<System.Byte> IBatchModel.ExternallyCompleted
        {
            get { return this.ExternallyCompleted; }
            set { this.ExternallyCompleted = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_DD_STATUS" field.
        /// </summary>
        System.Nullable<System.Byte> IBatchModel.DdStatus
        {
            get { return this.DdStatus; }
            set { this.DdStatus = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_REC_ID" field.
        /// </summary>
        System.String IBatchModel.RecId
        {
            get { return this.RecId; }
            set { this.RecId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_RERUN" field.
        /// </summary>
        System.Byte IBatchModel.Rerun
        {
            get { return this.Rerun; }
            set { this.Rerun = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BAT_EC_ID" field.
        /// </summary>
        Consensus.Other.IExportconfigurationsModel IBatchModel.BatchEcId
        {
            get { return this.BatchEcId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BAT_EC_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IBatchModel.BatchEcIdId
        {
            get { return this.BatchEcIdId; }
            set { this.BatchEcIdId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_ARG_ID" field.
        /// </summary>
        System.String IBatchModel.ArgId
        {
            get { return this.ArgId; }
            set { this.ArgId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BAT_DI_ID" field.
        /// </summary>
        Consensus.Other.IDataimportsModel IBatchModel.BatchDiId
        {
            get { return this.BatchDiId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BAT_DI_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IBatchModel.BatchDiIdId
        {
            get { return this.BatchDiIdId; }
            set { this.BatchDiIdId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrintRequestModel" /> instances that reference this <see cref="!:BatchModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Document.IPrintRequestModel> IBatchModel.BatchPrintRequests
        {
            get { return this.BatchPrintRequests; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BatchXrefModel" /> instances that reference this <see cref="!:BatchModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Other.IBatchXrefModel> IBatchModel.BatchXref
        {
            get { return this.BatchXref; }
        }

        #endregion
    }
}
