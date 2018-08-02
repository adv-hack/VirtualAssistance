using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Encapsulates the <see cref="BatchXrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalBatchXrefModel : LocalModel<BatchXrefRecord, Int32>, IBatchXrefModel
    {
        #region fields

        /// <summary>
        ///     Link between the batch xref and batch.
        /// </summary>
        private LocalBatchModel _batch;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<BatchXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Other.BatchXref.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<BatchXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Other.BatchXref.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<BatchXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Other.BatchXref.RemoveById; }
        }

        /// <summary>
        ///     Gets the Link between the batch xref and batch.
        /// </summary>
        public LocalBatchModel Batch
        {
            get
            {
                if (_batch == null && this.BatchId != null)
                    _batch = this.Provider.Other.Batch.FetchById(this.BatchId);
                if (_batch == null)
                    _batch = this.Provider.Other.Batch.Create();
                
                return _batch;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for Link between the batch xref and batch.
        /// </summary>
        public String BatchId
        {
            get { return this.ModifiedData.BatId; }
            set
            {
                if (this.ModifiedData.BatId != value)
                     _batch = null;
                this.ModifiedData.BatId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_RECORD_ID" field.
        /// </summary>
        public String RecordId
        {
            get { return this.ModifiedData.RecordId; }
            set { this.ModifiedData.RecordId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_TABLE_NAME" field.
        /// </summary>
        public String TableName
        {
            get { return this.ModifiedData.TableName; }
            set { this.ModifiedData.TableName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_LINK_ID" field.
        /// </summary>
        public String LinkId
        {
            get { return this.ModifiedData.LinkId; }
            set { this.ModifiedData.LinkId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_LINK_URL" field.
        /// </summary>
        public String LinkUrl
        {
            get { return this.ModifiedData.LinkUrl; }
            set { this.ModifiedData.LinkUrl = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_STATUS" field.
        /// </summary>
        public Byte Status
        {
            get { return this.ModifiedData.Status; }
            set { this.ModifiedData.Status = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalBatchXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalBatchXrefModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalBatchXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalBatchXrefModel(LocalProvider provider, BatchXrefRecord record) : base(provider, record)
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
            if (_batch != null)
            {
                _batch.Save();
                this.ModifiedData.BatId = _batch.Id == null && this.ModifiedData.BatId != null ? "" : _batch.Id;
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
        ///     Gets the Link between the batch xref and batch.
        /// </summary>
        Consensus.Other.IBatchModel IBatchXrefModel.Batch
        {
            get { return this.Batch; }
        }

        /// <summary>
        ///     Gets or sets the unique code for Link between the batch xref and batch.
        /// </summary>
        System.String IBatchXrefModel.BatchId
        {
            get { return this.BatchId; }
            set { this.BatchId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_RECORD_ID" field.
        /// </summary>
        System.String IBatchXrefModel.RecordId
        {
            get { return this.RecordId; }
            set { this.RecordId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_TABLE_NAME" field.
        /// </summary>
        System.String IBatchXrefModel.TableName
        {
            get { return this.TableName; }
            set { this.TableName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_LINK_ID" field.
        /// </summary>
        System.String IBatchXrefModel.LinkId
        {
            get { return this.LinkId; }
            set { this.LinkId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_LINK_URL" field.
        /// </summary>
        System.String IBatchXrefModel.LinkUrl
        {
            get { return this.LinkUrl; }
            set { this.LinkUrl = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_STATUS" field.
        /// </summary>
        System.Byte IBatchXrefModel.Status
        {
            get { return this.Status; }
            set { this.Status = (System.Byte)value; }
        }

        #endregion
    }
}
