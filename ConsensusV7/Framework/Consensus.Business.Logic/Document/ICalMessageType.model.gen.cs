using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="IcalmessagetypeRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalICalMessageTypeModel : LocalModel<IcalmessagetypeRecord, Int32>, IICalMessageTypeModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="ICalMessageModel" /> instances that reference this <see cref="ICalMessageTypeModel" />.
        /// </summary>
        private LocalCollection<LocalICalMessageModel, IICalMessageModel> _iCalendarMessages;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<IcalmessagetypeRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Document.ICalMessageType.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<IcalmessagetypeRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Document.ICalMessageType.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<IcalmessagetypeRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Document.ICalMessageType.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICMT_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICMT_VIEW" field.
        /// </summary>
        public String View
        {
            get { return this.ModifiedData.View; }
            set { this.ModifiedData.View = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICMT_PROC" field.
        /// </summary>
        public String Proc
        {
            get { return this.ModifiedData.Proc; }
            set { this.ModifiedData.Proc = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ICalMessageModel" /> instances that reference this <see cref="ICalMessageTypeModel" />.
        /// </summary>
        public LocalCollection<LocalICalMessageModel, IICalMessageModel> ICalendarMessages
        {
            get
            {
                if (_iCalendarMessages == null)
                    _iCalendarMessages = new LocalCollection<LocalICalMessageModel, IICalMessageModel>(this.Provider.Document.ICalMessage.FetchAllByICalMessageTypeId(this.Id));
                
                return _iCalendarMessages;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalICalMessageTypeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalICalMessageTypeModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalICalMessageTypeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalICalMessageTypeModel(LocalProvider provider, IcalmessagetypeRecord record) : base(provider, record)
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
            if (_iCalendarMessages != null)
                _iCalendarMessages.Execute(obj => obj.ICalMessageTypeId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "ICMT_NAME" field.
        /// </summary>
        System.String IICalMessageTypeModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICMT_VIEW" field.
        /// </summary>
        System.String IICalMessageTypeModel.View
        {
            get { return this.View; }
            set { this.View = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICMT_PROC" field.
        /// </summary>
        System.String IICalMessageTypeModel.Proc
        {
            get { return this.Proc; }
            set { this.Proc = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ICalMessageModel" /> instances that reference this <see cref="!:ICalMessageTypeModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IICalMessageModel> IICalMessageTypeModel.ICalendarMessages
        {
            get { return this.ICalendarMessages; }
        }

        #endregion
    }
}
