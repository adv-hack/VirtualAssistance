using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;
using Consensus.Other;

namespace Consensus.Document
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class PrintRequest : Proxy<IPrintRequestModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Queue" /> member.
        /// </summary>
        private Consensus.Document.OutputQueue _queue;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Pack" /> member.
        /// </summary>
        private Consensus.Document.Pack _pack;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Batch" /> member.
        /// </summary>
        private Consensus.Other.Batch _batch;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SendFromProle" /> member.
        /// </summary>
        private Consensus.Contact.Person _sendFromProle;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SendToProle" /> member.
        /// </summary>
        private Consensus.Contact.Person _sendToProle;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_1" field.
        /// </summary>
        public System.String Id1
        {
            get { return this.Model.Id1; }
            set { this.Model.Id1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_2" field.
        /// </summary>
        public System.String Id2
        {
            get { return this.Model.Id2; }
            set { this.Model.Id2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_3" field.
        /// </summary>
        public System.String Id3
        {
            get { return this.Model.Id3; }
            set { this.Model.Id3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_TYPE" field.
        /// </summary>
        public System.String Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_STATUS" field.
        /// </summary>
        public System.Nullable<System.Int32> Status
        {
            get { return this.Model.Status; }
            set { this.Model.Status = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_REQ_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> ReqDate
        {
            get { return this.Model.ReqDate; }
            set { this.Model.ReqDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_REQ_BY" field.
        /// </summary>
        public System.String ReqBy
        {
            get { return this.Model.ReqBy; }
            set { this.Model.ReqBy = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PR_PQ_ID" field.
        /// </summary>
        public Consensus.Document.OutputQueue Queue
        {
            get
            {
                if (_queue == null && this.Model.Queue != null)
                    _queue = new Consensus.Document.OutputQueue(this.Model.Queue);
                if (_queue == null)
                    _queue = Consensus.Document.OutputQueue.Create();
                return _queue;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_PQ_ID" field.
        /// </summary>
        public System.String QueueId
        {
            get { return this.Model.QueueId; }
            set { this.Model.QueueId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ACT_PQ_STATUS" field.
        /// </summary>
        public System.String ActPqStatus
        {
            get { return this.Model.ActPqStatus; }
            set { this.Model.ActPqStatus = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_PQ_SEND_TYPE" field.
        /// </summary>
        public System.String PqSendType
        {
            get { return this.Model.PqSendType; }
            set { this.Model.PqSendType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PR_PACK_ID" field.
        /// </summary>
        public Consensus.Document.Pack Pack
        {
            get
            {
                if (_pack == null && this.Model.Pack != null)
                    _pack = new Consensus.Document.Pack(this.Model.Pack);
                if (_pack == null)
                    _pack = Consensus.Document.Pack.Create();
                return _pack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_PACK_ID" field.
        /// </summary>
        public System.String PackId
        {
            get { return this.Model.PackId; }
            set { this.Model.PackId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PR_BAT_ID" field.
        /// </summary>
        public Consensus.Other.Batch Batch
        {
            get
            {
                if (_batch == null && this.Model.Batch != null)
                    _batch = new Consensus.Other.Batch(this.Model.Batch);
                if (_batch == null)
                    _batch = Consensus.Other.Batch.Create();
                return _batch;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_BAT_ID" field.
        /// </summary>
        public System.String BatchId
        {
            get { return this.Model.BatchId; }
            set { this.Model.BatchId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_SEND_TO_BOOKER" field.
        /// </summary>
        public System.Nullable<System.Byte> SendToBooker
        {
            get { return this.Model.SendToBooker; }
            set { this.Model.SendToBooker = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_SEND_TO_DELEGATE" field.
        /// </summary>
        public System.Nullable<System.Byte> SendToDelegate
        {
            get { return this.Model.SendToDelegate; }
            set { this.Model.SendToDelegate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PR_SEND_FROM_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Person SendFromProle
        {
            get
            {
                if (_sendFromProle == null && this.Model.SendFromProle != null)
                    _sendFromProle = new Consensus.Contact.Person(this.Model.SendFromProle);
                if (_sendFromProle == null)
                    _sendFromProle = Consensus.Contact.Person.Create();
                return _sendFromProle;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_SEND_FROM_PROLE_ID" field.
        /// </summary>
        public System.String SendFromProleId
        {
            get { return this.Model.SendFromProleId; }
            set { this.Model.SendFromProleId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PR_SEND_TO_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Person SendToProle
        {
            get
            {
                if (_sendToProle == null && this.Model.SendToProle != null)
                    _sendToProle = new Consensus.Contact.Person(this.Model.SendToProle);
                if (_sendToProle == null)
                    _sendToProle = Consensus.Contact.Person.Create();
                return _sendToProle;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_SEND_TO_PROLE_ID" field.
        /// </summary>
        public System.String SendToProleId
        {
            get { return this.Model.SendToProleId; }
            set { this.Model.SendToProleId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_4" field.
        /// </summary>
        public System.String Id4
        {
            get { return this.Model.Id4; }
            set { this.Model.Id4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_5" field.
        /// </summary>
        public System.String Id5
        {
            get { return this.Model.Id5; }
            set { this.Model.Id5 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal PrintRequest(IPrintRequestModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:PrintRequestModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PrintRequestModel" /> instance.
        /// </returns>
        public static Consensus.Document.PrintRequest Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrintRequest.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PrintRequestModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PrintRequestModel" /> instance.
        /// </returns>
        public static Consensus.Document.PrintRequest Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IPrintRequestModel model = provider.Document.PrintRequest.Create();
            return model == null ? null : new Consensus.Document.PrintRequest(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PrintRequestModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PrintRequestModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.PrintRequest> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrintRequest.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PrintRequestModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PrintRequestModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.PrintRequest> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPrintRequestModel> collection = provider.Document.PrintRequest.FetchAll();
            return collection.Select(model => new Consensus.Document.PrintRequest(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PrintRequestModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PrintRequestModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.PrintRequest FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrintRequest.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PrintRequestModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PrintRequestModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.PrintRequest FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IPrintRequestModel model = provider.Document.PrintRequest.FetchById(id);
            return model == null ? null : new Consensus.Document.PrintRequest(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrintRequest.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.PrintRequest.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="queueId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="queueId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PrintRequest> FetchAllByQueueId(System.String queueId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrintRequest.FetchAllByQueueId(site,queueId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="queueId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="queueId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PrintRequest> FetchAllByQueueId(ConsensusSite site, System.String queueId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPrintRequestModel> collection = provider.Document.PrintRequest.FetchAllByQueueId(queueId);
            return collection.Select(model => new Consensus.Document.PrintRequest(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PrintRequest> FetchAllByPackId(System.String packId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrintRequest.FetchAllByPackId(site,packId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PrintRequest> FetchAllByPackId(ConsensusSite site, System.String packId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPrintRequestModel> collection = provider.Document.PrintRequest.FetchAllByPackId(packId);
            return collection.Select(model => new Consensus.Document.PrintRequest(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="batchId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="batchId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PrintRequest> FetchAllByBatchId(System.String batchId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrintRequest.FetchAllByBatchId(site,batchId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="batchId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="batchId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PrintRequest> FetchAllByBatchId(ConsensusSite site, System.String batchId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPrintRequestModel> collection = provider.Document.PrintRequest.FetchAllByBatchId(batchId);
            return collection.Select(model => new Consensus.Document.PrintRequest(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="sendFromProleId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="sendFromProleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PrintRequest> FetchAllBySendFromProleId(System.String sendFromProleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrintRequest.FetchAllBySendFromProleId(site,sendFromProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="sendFromProleId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="sendFromProleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PrintRequest> FetchAllBySendFromProleId(ConsensusSite site, System.String sendFromProleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPrintRequestModel> collection = provider.Document.PrintRequest.FetchAllBySendFromProleId(sendFromProleId);
            return collection.Select(model => new Consensus.Document.PrintRequest(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="sendToProleId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="sendToProleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PrintRequest> FetchAllBySendToProleId(System.String sendToProleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrintRequest.FetchAllBySendToProleId(site,sendToProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="sendToProleId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="sendToProleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PrintRequest> FetchAllBySendToProleId(ConsensusSite site, System.String sendToProleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPrintRequestModel> collection = provider.Document.PrintRequest.FetchAllBySendToProleId(sendToProleId);
            return collection.Select(model => new Consensus.Document.PrintRequest(model));
        }

        #endregion
    }
}
