using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="CommunicationsXrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCommunications_XrefModel : LocalModel<CommunicationsXrefRecord, Int64>, ICommunications_XrefModel
    {
        #region fields

        /// <summary>
        ///     The value of the "COMMXREF_COMM_ID" field.
        /// </summary>
        private LocalCommunicationsModel _communication;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CommunicationsXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.Communications_Xref.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CommunicationsXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.Communications_Xref.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<CommunicationsXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.Communications_Xref.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "COMMXREF_COMM_ID" field.
        /// </summary>
        public LocalCommunicationsModel Communication
        {
            get
            {
                if (_communication == null)
                    _communication = this.Provider.Contact.Communications.FetchById(this.CommunicationId);
                if (_communication == null)
                    _communication = this.Provider.Contact.Communications.Create();
                
                return _communication;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COMMXREF_COMM_ID" field.
        /// </summary>
        public Int64 CommunicationId
        {
            get { return this.ModifiedData.CommId; }
            set
            {
                if (this.ModifiedData.CommId != value)
                     _communication = null;
                this.ModifiedData.CommId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalCommunications_XrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalCommunications_XrefModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalCommunications_XrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalCommunications_XrefModel(LocalProvider provider, CommunicationsXrefRecord record) : base(provider, record)
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
            if (_communication != null)
            {
                _communication.Save();
                this.ModifiedData.CommId = _communication.Id;
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
        ///     Gets the The value of the "COMMXREF_COMM_ID" field.
        /// </summary>
        Consensus.Contact.ICommunicationsModel ICommunications_XrefModel.Communication
        {
            get { return this.Communication; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COMMXREF_COMM_ID" field.
        /// </summary>
        System.Int64 ICommunications_XrefModel.CommunicationId
        {
            get { return this.CommunicationId; }
            set { this.CommunicationId = (System.Int64)value; }
        }

        #endregion
    }
}
