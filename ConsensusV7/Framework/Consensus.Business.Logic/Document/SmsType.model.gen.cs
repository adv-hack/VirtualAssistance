using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="SmsTypeRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSmsTypeModel : LocalModel<SmsTypeRecord, Int32>, ISmsTypeModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="SmsMessageModel" /> instances that reference this <see cref="SmsTypeModel" />.
        /// </summary>
        private LocalCollection<LocalSmsMessageModel, ISmsMessageModel> _smsMessages;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SmsTypeRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Document.SmsType.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SmsTypeRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Document.SmsType.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SmsTypeRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Document.SmsType.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMT_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMT_VIEW" field.
        /// </summary>
        public String View
        {
            get { return this.ModifiedData.View; }
            set { this.ModifiedData.View = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMT_STORED_PROC" field.
        /// </summary>
        public String StoredProc
        {
            get { return this.ModifiedData.StoredProc; }
            set { this.ModifiedData.StoredProc = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SmsMessageModel" /> instances that reference this <see cref="SmsTypeModel" />.
        /// </summary>
        public LocalCollection<LocalSmsMessageModel, ISmsMessageModel> SmsMessages
        {
            get
            {
                if (_smsMessages == null)
                    _smsMessages = new LocalCollection<LocalSmsMessageModel, ISmsMessageModel>(this.Provider.Document.SmsMessage.FetchAllBySmsMessageTypeId(this.Id));
                
                return _smsMessages;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSmsTypeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSmsTypeModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSmsTypeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSmsTypeModel(LocalProvider provider, SmsTypeRecord record) : base(provider, record)
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
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_smsMessages != null)
                _smsMessages.Execute(obj => obj.SmsMessageTypeId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "SMT_NAME" field.
        /// </summary>
        System.String ISmsTypeModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMT_VIEW" field.
        /// </summary>
        System.String ISmsTypeModel.View
        {
            get { return this.View; }
            set { this.View = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMT_STORED_PROC" field.
        /// </summary>
        System.String ISmsTypeModel.StoredProc
        {
            get { return this.StoredProc; }
            set { this.StoredProc = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SmsMessageModel" /> instances that reference this <see cref="!:SmsTypeModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.ISmsMessageModel> ISmsTypeModel.SmsMessages
        {
            get { return this.SmsMessages; }
        }

        #endregion
    }
}
