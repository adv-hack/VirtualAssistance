using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Document
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class OutputQueue : Proxy<IOutputQueueModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="AdminProle" /> member.
        /// </summary>
        private Consensus.Contact.Role _adminProle;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PackOutputQueue" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.Pack, Consensus.Document.IPackModel> _packOutputQueue;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="OutputQueueRequests" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.PrintRequest, Consensus.Document.IPrintRequestModel> _outputQueueRequests;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "PQ_QUEUE_TYPE" field.
        /// </summary>
        public System.String QueueType
        {
            get { return this.Model.QueueType; }
            set { this.Model.QueueType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_SEND_TYPE" field.
        /// </summary>
        public System.Nullable<System.Byte> SendType
        {
            get { return this.Model.SendType; }
            set { this.Model.SendType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PQ_ADMIN_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role AdminProle
        {
            get
            {
                if (_adminProle == null && this.Model.AdminProle != null)
                    _adminProle = new Consensus.Contact.Role(this.Model.AdminProle);
                if (_adminProle == null)
                    _adminProle = Consensus.Contact.Role.Create();
                return _adminProle;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PQ_ADMIN_PROLE_ID" field.
        /// </summary>
        public System.String AdminProleId
        {
            get { return this.Model.AdminProleId; }
            set { this.Model.AdminProleId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_MAIL_SERVER" field.
        /// </summary>
        public System.String MailServer
        {
            get { return this.Model.MailServer; }
            set { this.Model.MailServer = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_LOGON_ID" field.
        /// </summary>
        public System.String LogonId
        {
            get { return this.Model.LogonId; }
            set { this.Model.LogonId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_LOGON_PASSWORD" field.
        /// </summary>
        public System.String LogonPassword
        {
            get { return this.Model.LogonPassword; }
            set { this.Model.LogonPassword = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_PRINT_SERVER" field.
        /// </summary>
        public System.String PrintServer
        {
            get { return this.Model.PrintServer; }
            set { this.Model.PrintServer = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_PRINTER_NOTES" field.
        /// </summary>
        public System.String PrinterNotes
        {
            get { return this.Model.PrinterNotes; }
            set { this.Model.PrinterNotes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_DESCRIPTION" field.
        /// </summary>
        public System.String Description
        {
            get { return this.Model.Description; }
            set { this.Model.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_SYSTEM_DEFAULT" field.
        /// </summary>
        public System.Nullable<System.Byte> SystemDefault
        {
            get { return this.Model.SystemDefault; }
            set { this.Model.SystemDefault = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_DPM_SERVER" field.
        /// </summary>
        public System.String DpmServer
        {
            get { return this.Model.DpmServer; }
            set { this.Model.DpmServer = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_PORT" field.
        /// </summary>
        public System.String Port
        {
            get { return this.Model.Port; }
            set { this.Model.Port = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_SSL" field.
        /// </summary>
        public System.Nullable<System.Byte> Ssl
        {
            get { return this.Model.Ssl; }
            set { this.Model.Ssl = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_PROXY" field.
        /// </summary>
        public System.Nullable<System.Byte> Proxy
        {
            get { return this.Model.Proxy; }
            set { this.Model.Proxy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_FROM" field.
        /// </summary>
        public System.String From
        {
            get { return this.Model.From; }
            set { this.Model.From = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackModel" /> instances that reference this <see cref="!:OutputQueueModel" />.
        /// </summary>
        public Collection<Consensus.Document.Pack> PackOutputQueue
        {
            get
            {
                if (_packOutputQueue == null)
                    _packOutputQueue = new ProxyCollection<Consensus.Document.Pack, Consensus.Document.IPackModel>(this.Model.PackOutputQueue, model => new Consensus.Document.Pack(model));
                return _packOutputQueue;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrintRequestModel" /> instances that reference this <see cref="!:OutputQueueModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Document.PrintRequest> OutputQueueRequests
        {
            get
            {
                if (_outputQueueRequests == null)
                    _outputQueueRequests = new ProxyCollection<Consensus.Document.PrintRequest, Consensus.Document.IPrintRequestModel>(this.Model.OutputQueueRequests, model => new Consensus.Document.PrintRequest(model));
                return _outputQueueRequests;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal OutputQueue(IOutputQueueModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:OutputQueueModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OutputQueueModel" /> instance.
        /// </returns>
        public static Consensus.Document.OutputQueue Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OutputQueue.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:OutputQueueModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OutputQueueModel" /> instance.
        /// </returns>
        public static Consensus.Document.OutputQueue Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IOutputQueueModel model = provider.Document.OutputQueue.Create();
            return model == null ? null : new Consensus.Document.OutputQueue(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OutputQueueModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OutputQueueModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.OutputQueue> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OutputQueue.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OutputQueueModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OutputQueueModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.OutputQueue> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IOutputQueueModel> collection = provider.Document.OutputQueue.FetchAll();
            return collection.Select(model => new Consensus.Document.OutputQueue(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OutputQueueModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OutputQueueModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OutputQueueModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.OutputQueue FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OutputQueue.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OutputQueueModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OutputQueueModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OutputQueueModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.OutputQueue FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IOutputQueueModel model = provider.Document.OutputQueue.FetchById(id);
            return model == null ? null : new Consensus.Document.OutputQueue(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OutputQueue.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.OutputQueue.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OutputQueueModel" /> instances.
        /// </summary>
        /// <param name="adminProleId">
        ///     The value which identifies the <see cref="!:OutputQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OutputQueueModel" /> instances that match the specified <paramref name="adminProleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.OutputQueue> FetchAllByAdminProleId(System.String adminProleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OutputQueue.FetchAllByAdminProleId(site,adminProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OutputQueueModel" /> instances.
        /// </summary>
        /// <param name="adminProleId">
        ///     The value which identifies the <see cref="!:OutputQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OutputQueueModel" /> instances that match the specified <paramref name="adminProleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.OutputQueue> FetchAllByAdminProleId(ConsensusSite site, System.String adminProleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IOutputQueueModel> collection = provider.Document.OutputQueue.FetchAllByAdminProleId(adminProleId);
            return collection.Select(model => new Consensus.Document.OutputQueue(model));
        }

        #endregion
    }
}
