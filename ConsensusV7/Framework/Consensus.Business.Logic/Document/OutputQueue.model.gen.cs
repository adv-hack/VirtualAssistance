using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="PrintQueueRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalOutputQueueModel : LocalModel<PrintQueueRecord, String>, IOutputQueueModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PQ_ADMIN_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _adminProle;

        /// <summary>
        ///     The collection of <see cref="PackModel" /> instances that reference this <see cref="OutputQueueModel" />.
        /// </summary>
        private LocalCollection<LocalPackModel, IPackModel> _packOutputQueue;

        /// <summary>
        ///     The collection of <see cref="PrintRequestModel" /> instances that reference this <see cref="OutputQueueModel" />.
        /// </summary>
        private LocalCollection<LocalPrintRequestModel, IPrintRequestModel> _outputQueueRequests;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PrintQueueRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Document.OutputQueue.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PrintQueueRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Document.OutputQueue.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PrintQueueRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Document.OutputQueue.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_QUEUE_TYPE" field.
        /// </summary>
        public String QueueType
        {
            get { return this.ModifiedData.QueueType; }
            set { this.ModifiedData.QueueType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_SEND_TYPE" field.
        /// </summary>
        public Byte? SendType
        {
            get { return this.ModifiedData.SendType; }
            set { this.ModifiedData.SendType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PQ_ADMIN_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel AdminProle
        {
            get
            {
                if (_adminProle == null && this.AdminProleId != null)
                    _adminProle = this.Provider.Contact.Role.FetchById(this.AdminProleId);
                if (_adminProle == null)
                    _adminProle = this.Provider.Contact.Role.Create();
                
                return _adminProle;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PQ_ADMIN_PROLE_ID" field.
        /// </summary>
        public String AdminProleId
        {
            get { return this.ModifiedData.AdminProleId; }
            set
            {
                if (this.ModifiedData.AdminProleId != value)
                     _adminProle = null;
                this.ModifiedData.AdminProleId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_MAIL_SERVER" field.
        /// </summary>
        public String MailServer
        {
            get { return this.ModifiedData.MailServer; }
            set { this.ModifiedData.MailServer = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_LOGON_ID" field.
        /// </summary>
        public String LogonId
        {
            get { return this.ModifiedData.LogonId; }
            set { this.ModifiedData.LogonId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_LOGON_PASSWORD" field.
        /// </summary>
        public String LogonPassword
        {
            get { return this.ModifiedData.LogonPassword; }
            set { this.ModifiedData.LogonPassword = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_PRINT_SERVER" field.
        /// </summary>
        public String PrintServer
        {
            get { return this.ModifiedData.PrintServer; }
            set { this.ModifiedData.PrintServer = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_PRINTER_NOTES" field.
        /// </summary>
        public String PrinterNotes
        {
            get { return this.ModifiedData.PrinterNotes; }
            set { this.ModifiedData.PrinterNotes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return this.ModifiedData.Description; }
            set { this.ModifiedData.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_SYSTEM_DEFAULT" field.
        /// </summary>
        public Byte? SystemDefault
        {
            get { return this.ModifiedData.SystemDefault; }
            set { this.ModifiedData.SystemDefault = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_DPM_SERVER" field.
        /// </summary>
        public String DpmServer
        {
            get { return this.ModifiedData.DpmServer; }
            set { this.ModifiedData.DpmServer = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_PORT" field.
        /// </summary>
        public String Port
        {
            get { return this.ModifiedData.Port; }
            set { this.ModifiedData.Port = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_SSL" field.
        /// </summary>
        public Byte? Ssl
        {
            get { return this.ModifiedData.Ssl; }
            set { this.ModifiedData.Ssl = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_PROXY" field.
        /// </summary>
        public Byte? Proxy
        {
            get { return this.ModifiedData.Proxy; }
            set { this.ModifiedData.Proxy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_FROM" field.
        /// </summary>
        public String From
        {
            get { return this.ModifiedData.From; }
            set { this.ModifiedData.From = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PackModel" /> instances that reference this <see cref="OutputQueueModel" />.
        /// </summary>
        public LocalCollection<LocalPackModel, IPackModel> PackOutputQueue
        {
            get
            {
                if (_packOutputQueue == null)
                    _packOutputQueue = new LocalCollection<LocalPackModel, IPackModel>(this.Provider.Document.Pack.FetchAllByPackOutputQueueIdId(this.Id));
                
                return _packOutputQueue;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PrintRequestModel" /> instances that reference this <see cref="OutputQueueModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalPrintRequestModel, IPrintRequestModel> OutputQueueRequests
        {
            get
            {
                if (_outputQueueRequests == null)
                    _outputQueueRequests = new LocalCollection<LocalPrintRequestModel, IPrintRequestModel>(this.Provider.Document.PrintRequest.FetchAllByQueueId(this.Id));
                
                return _outputQueueRequests;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalOutputQueueModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalOutputQueueModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalOutputQueueModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalOutputQueueModel(LocalProvider provider, PrintQueueRecord record) : base(provider, record)
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
            if (_adminProle != null)
            {
                _adminProle.Save();
                this.ModifiedData.AdminProleId = _adminProle.Id == null && this.ModifiedData.AdminProleId != null ? "" : _adminProle.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_packOutputQueue != null)
                _packOutputQueue.Execute(obj => obj.PackOutputQueueIdId = this.Id).Execute(obj => obj.Save());
            if (_outputQueueRequests != null)
                _outputQueueRequests.Execute(obj => obj.QueueId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "PQ_QUEUE_TYPE" field.
        /// </summary>
        System.String IOutputQueueModel.QueueType
        {
            get { return this.QueueType; }
            set { this.QueueType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_SEND_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> IOutputQueueModel.SendType
        {
            get { return this.SendType; }
            set { this.SendType = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PQ_ADMIN_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IOutputQueueModel.AdminProle
        {
            get { return this.AdminProle; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PQ_ADMIN_PROLE_ID" field.
        /// </summary>
        System.String IOutputQueueModel.AdminProleId
        {
            get { return this.AdminProleId; }
            set { this.AdminProleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_MAIL_SERVER" field.
        /// </summary>
        System.String IOutputQueueModel.MailServer
        {
            get { return this.MailServer; }
            set { this.MailServer = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_LOGON_ID" field.
        /// </summary>
        System.String IOutputQueueModel.LogonId
        {
            get { return this.LogonId; }
            set { this.LogonId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_LOGON_PASSWORD" field.
        /// </summary>
        System.String IOutputQueueModel.LogonPassword
        {
            get { return this.LogonPassword; }
            set { this.LogonPassword = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_PRINT_SERVER" field.
        /// </summary>
        System.String IOutputQueueModel.PrintServer
        {
            get { return this.PrintServer; }
            set { this.PrintServer = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_PRINTER_NOTES" field.
        /// </summary>
        System.String IOutputQueueModel.PrinterNotes
        {
            get { return this.PrinterNotes; }
            set { this.PrinterNotes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_DESCRIPTION" field.
        /// </summary>
        System.String IOutputQueueModel.Description
        {
            get { return this.Description; }
            set { this.Description = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_SYSTEM_DEFAULT" field.
        /// </summary>
        System.Nullable<System.Byte> IOutputQueueModel.SystemDefault
        {
            get { return this.SystemDefault; }
            set { this.SystemDefault = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_DPM_SERVER" field.
        /// </summary>
        System.String IOutputQueueModel.DpmServer
        {
            get { return this.DpmServer; }
            set { this.DpmServer = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_PORT" field.
        /// </summary>
        System.String IOutputQueueModel.Port
        {
            get { return this.Port; }
            set { this.Port = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_SSL" field.
        /// </summary>
        System.Nullable<System.Byte> IOutputQueueModel.Ssl
        {
            get { return this.Ssl; }
            set { this.Ssl = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_PROXY" field.
        /// </summary>
        System.Nullable<System.Byte> IOutputQueueModel.Proxy
        {
            get { return this.Proxy; }
            set { this.Proxy = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_FROM" field.
        /// </summary>
        System.String IOutputQueueModel.From
        {
            get { return this.From; }
            set { this.From = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackModel" /> instances that reference this <see cref="!:OutputQueueModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackModel> IOutputQueueModel.PackOutputQueue
        {
            get { return this.PackOutputQueue; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrintRequestModel" /> instances that reference this <see cref="!:OutputQueueModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Document.IPrintRequestModel> IOutputQueueModel.OutputQueueRequests
        {
            get { return this.OutputQueueRequests; }
        }

        #endregion
    }
}
