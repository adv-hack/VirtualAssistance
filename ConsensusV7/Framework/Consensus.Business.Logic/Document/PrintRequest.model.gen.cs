using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;
using Consensus.Other;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="PrintReqRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPrintRequestModel : LocalModel<PrintReqRecord, String>, IPrintRequestModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PR_PQ_ID" field.
        /// </summary>
        private LocalOutputQueueModel _queue;

        /// <summary>
        ///     The value of the "PR_PACK_ID" field.
        /// </summary>
        private LocalPackModel _pack;

        /// <summary>
        ///     The value of the "PR_BAT_ID" field.
        /// </summary>
        private LocalBatchModel _batch;

        /// <summary>
        ///     The value of the "PR_SEND_FROM_PROLE_ID" field.
        /// </summary>
        private LocalPersonModel _sendFromProle;

        /// <summary>
        ///     The value of the "PR_SEND_TO_PROLE_ID" field.
        /// </summary>
        private LocalPersonModel _sendToProle;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PrintReqRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Document.PrintRequest.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PrintReqRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Document.PrintRequest.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PrintReqRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Document.PrintRequest.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_1" field.
        /// </summary>
        public String Id1
        {
            get { return this.ModifiedData.Id1; }
            set { this.ModifiedData.Id1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_2" field.
        /// </summary>
        public String Id2
        {
            get { return this.ModifiedData.Id2; }
            set { this.ModifiedData.Id2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_3" field.
        /// </summary>
        public String Id3
        {
            get { return this.ModifiedData.Id3; }
            set { this.ModifiedData.Id3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_STATUS" field.
        /// </summary>
        public Int32? Status
        {
            get { return this.ModifiedData.Status; }
            set { this.ModifiedData.Status = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_REQ_DATE" field.
        /// </summary>
        public DateTime? ReqDate
        {
            get { return this.ModifiedData.ReqDate; }
            set { this.ModifiedData.ReqDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_REQ_BY" field.
        /// </summary>
        public String ReqBy
        {
            get { return this.ModifiedData.ReqBy; }
            set { this.ModifiedData.ReqBy = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PR_PQ_ID" field.
        /// </summary>
        public LocalOutputQueueModel Queue
        {
            get
            {
                if (_queue == null && this.QueueId != null)
                    _queue = this.Provider.Document.OutputQueue.FetchById(this.QueueId);
                if (_queue == null)
                    _queue = this.Provider.Document.OutputQueue.Create();
                
                return _queue;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_PQ_ID" field.
        /// </summary>
        public String QueueId
        {
            get { return this.ModifiedData.PqId; }
            set
            {
                if (this.ModifiedData.PqId != value)
                     _queue = null;
                this.ModifiedData.PqId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ACT_PQ_STATUS" field.
        /// </summary>
        public String ActPqStatus
        {
            get { return this.ModifiedData.ActPqStatus; }
            set { this.ModifiedData.ActPqStatus = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_PQ_SEND_TYPE" field.
        /// </summary>
        public String PqSendType
        {
            get { return this.ModifiedData.PqSendType; }
            set { this.ModifiedData.PqSendType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PR_PACK_ID" field.
        /// </summary>
        public LocalPackModel Pack
        {
            get
            {
                if (_pack == null && this.PackId != null)
                    _pack = this.Provider.Document.Pack.FetchById(this.PackId);
                if (_pack == null)
                    _pack = this.Provider.Document.Pack.Create();
                
                return _pack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_PACK_ID" field.
        /// </summary>
        public String PackId
        {
            get { return this.ModifiedData.PackId; }
            set
            {
                if (this.ModifiedData.PackId != value)
                     _pack = null;
                this.ModifiedData.PackId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PR_BAT_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PR_BAT_ID" field.
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
        ///     Gets or sets the value of the "PR_SEND_TO_BOOKER" field.
        /// </summary>
        public Byte? SendToBooker
        {
            get { return this.ModifiedData.SendToBooker; }
            set { this.ModifiedData.SendToBooker = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_SEND_TO_DELEGATE" field.
        /// </summary>
        public Byte? SendToDelegate
        {
            get { return this.ModifiedData.SendToDelegate; }
            set { this.ModifiedData.SendToDelegate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PR_SEND_FROM_PROLE_ID" field.
        /// </summary>
        public LocalPersonModel SendFromProle
        {
            get
            {
                if (_sendFromProle == null && this.SendFromProleId != null)
                    _sendFromProle = this.Provider.Contact.Person.FetchById(this.SendFromProleId);
                if (_sendFromProle == null)
                    _sendFromProle = this.Provider.Contact.Person.Create();
                
                return _sendFromProle;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_SEND_FROM_PROLE_ID" field.
        /// </summary>
        public String SendFromProleId
        {
            get { return this.ModifiedData.SendFromProleId; }
            set
            {
                if (this.ModifiedData.SendFromProleId != value)
                     _sendFromProle = null;
                this.ModifiedData.SendFromProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PR_SEND_TO_PROLE_ID" field.
        /// </summary>
        public LocalPersonModel SendToProle
        {
            get
            {
                if (_sendToProle == null && this.SendToProleId != null)
                    _sendToProle = this.Provider.Contact.Person.FetchById(this.SendToProleId);
                if (_sendToProle == null)
                    _sendToProle = this.Provider.Contact.Person.Create();
                
                return _sendToProle;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_SEND_TO_PROLE_ID" field.
        /// </summary>
        public String SendToProleId
        {
            get { return this.ModifiedData.SendToProleId; }
            set
            {
                if (this.ModifiedData.SendToProleId != value)
                     _sendToProle = null;
                this.ModifiedData.SendToProleId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_4" field.
        /// </summary>
        public String Id4
        {
            get { return this.ModifiedData.Id4; }
            set { this.ModifiedData.Id4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_5" field.
        /// </summary>
        public String Id5
        {
            get { return this.ModifiedData.Id5; }
            set { this.ModifiedData.Id5 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPrintRequestModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPrintRequestModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPrintRequestModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPrintRequestModel(LocalProvider provider, PrintReqRecord record) : base(provider, record)
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
            if (_queue != null)
            {
                _queue.Save();
                this.ModifiedData.PqId = _queue.Id == null && this.ModifiedData.PqId != null ? "" : _queue.Id;
            }
            if (_pack != null)
            {
                _pack.Save();
                this.ModifiedData.PackId = _pack.Id == null && this.ModifiedData.PackId != null ? "" : _pack.Id;
            }
            if (_batch != null)
            {
                _batch.Save();
                this.ModifiedData.BatId = _batch.Id == null && this.ModifiedData.BatId != null ? "" : _batch.Id;
            }
            if (_sendFromProle != null)
            {
                _sendFromProle.Save();
                this.ModifiedData.SendFromProleId = _sendFromProle.Id == null && this.ModifiedData.SendFromProleId != null ? "" : _sendFromProle.Id;
            }
            if (_sendToProle != null)
            {
                _sendToProle.Save();
                this.ModifiedData.SendToProleId = _sendToProle.Id == null && this.ModifiedData.SendToProleId != null ? "" : _sendToProle.Id;
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
        ///     Gets or sets the value of the "PR_ID_1" field.
        /// </summary>
        System.String IPrintRequestModel.Id1
        {
            get { return this.Id1; }
            set { this.Id1 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_2" field.
        /// </summary>
        System.String IPrintRequestModel.Id2
        {
            get { return this.Id2; }
            set { this.Id2 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_3" field.
        /// </summary>
        System.String IPrintRequestModel.Id3
        {
            get { return this.Id3; }
            set { this.Id3 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_TYPE" field.
        /// </summary>
        System.String IPrintRequestModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_STATUS" field.
        /// </summary>
        System.Nullable<System.Int32> IPrintRequestModel.Status
        {
            get { return this.Status; }
            set { this.Status = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_REQ_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IPrintRequestModel.ReqDate
        {
            get { return this.ReqDate; }
            set { this.ReqDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_REQ_BY" field.
        /// </summary>
        System.String IPrintRequestModel.ReqBy
        {
            get { return this.ReqBy; }
            set { this.ReqBy = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PR_PQ_ID" field.
        /// </summary>
        Consensus.Document.IOutputQueueModel IPrintRequestModel.Queue
        {
            get { return this.Queue; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_PQ_ID" field.
        /// </summary>
        System.String IPrintRequestModel.QueueId
        {
            get { return this.QueueId; }
            set { this.QueueId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ACT_PQ_STATUS" field.
        /// </summary>
        System.String IPrintRequestModel.ActPqStatus
        {
            get { return this.ActPqStatus; }
            set { this.ActPqStatus = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_PQ_SEND_TYPE" field.
        /// </summary>
        System.String IPrintRequestModel.PqSendType
        {
            get { return this.PqSendType; }
            set { this.PqSendType = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PR_PACK_ID" field.
        /// </summary>
        Consensus.Document.IPackModel IPrintRequestModel.Pack
        {
            get { return this.Pack; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_PACK_ID" field.
        /// </summary>
        System.String IPrintRequestModel.PackId
        {
            get { return this.PackId; }
            set { this.PackId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PR_BAT_ID" field.
        /// </summary>
        Consensus.Other.IBatchModel IPrintRequestModel.Batch
        {
            get { return this.Batch; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_BAT_ID" field.
        /// </summary>
        System.String IPrintRequestModel.BatchId
        {
            get { return this.BatchId; }
            set { this.BatchId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_SEND_TO_BOOKER" field.
        /// </summary>
        System.Nullable<System.Byte> IPrintRequestModel.SendToBooker
        {
            get { return this.SendToBooker; }
            set { this.SendToBooker = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_SEND_TO_DELEGATE" field.
        /// </summary>
        System.Nullable<System.Byte> IPrintRequestModel.SendToDelegate
        {
            get { return this.SendToDelegate; }
            set { this.SendToDelegate = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PR_SEND_FROM_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel IPrintRequestModel.SendFromProle
        {
            get { return this.SendFromProle; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_SEND_FROM_PROLE_ID" field.
        /// </summary>
        System.String IPrintRequestModel.SendFromProleId
        {
            get { return this.SendFromProleId; }
            set { this.SendFromProleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PR_SEND_TO_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel IPrintRequestModel.SendToProle
        {
            get { return this.SendToProle; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_SEND_TO_PROLE_ID" field.
        /// </summary>
        System.String IPrintRequestModel.SendToProleId
        {
            get { return this.SendToProleId; }
            set { this.SendToProleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_4" field.
        /// </summary>
        System.String IPrintRequestModel.Id4
        {
            get { return this.Id4; }
            set { this.Id4 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_5" field.
        /// </summary>
        System.String IPrintRequestModel.Id5
        {
            get { return this.Id5; }
            set { this.Id5 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_NAME" field.
        /// </summary>
        System.String IPrintRequestModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        #endregion
    }
}
