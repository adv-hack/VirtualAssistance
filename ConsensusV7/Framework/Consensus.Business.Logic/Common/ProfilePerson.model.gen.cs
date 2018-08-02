using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;
using Consensus.Marketing;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="ProfileRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProfilePersonModel : LocalProfileModel, IProfilePersonModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PROF_PERSON_ID" field.
        /// </summary>
        private LocalPersonModel _person;

        /// <summary>
        ///     The collection of <see cref="SaqQueueModel" /> instances that reference this <see cref="ProfilePersonModel" />.
        /// </summary>
        private LocalCollection<LocalSaqQueueModel, ISaqQueueModel> _saqQueueProfilePerson;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProfileRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Common.Profile.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProfileRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Common.Profile.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProfileRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Common.Profile.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "PROF_PERSON_ID" field.
        /// </summary>
        public LocalPersonModel Person
        {
            get
            {
                if (_person == null && this.PersonId != null)
                    _person = this.Provider.Contact.Person.FetchById(this.PersonId);
                if (_person == null)
                    _person = this.Provider.Contact.Person.Create();
                
                return _person;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_PERSON_ID" field.
        /// </summary>
        public String PersonId
        {
            get { return this.ModifiedData.PersonId; }
            set
            {
                if (this.ModifiedData.PersonId != value)
                     _person = null;
                this.ModifiedData.PersonId = value;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SaqQueueModel" /> instances that reference this <see cref="ProfilePersonModel" />.
        /// </summary>
        public LocalCollection<LocalSaqQueueModel, ISaqQueueModel> SaqQueueProfilePerson
        {
            get
            {
                if (_saqQueueProfilePerson == null)
                    _saqQueueProfilePerson = new LocalCollection<LocalSaqQueueModel, ISaqQueueModel>(this.Provider.Marketing.SaqQueue.FetchAllByProfilePersonId(this.Id));
                
                return _saqQueueProfilePerson;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalProfilePersonModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalProfilePersonModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalProfilePersonModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalProfilePersonModel(LocalProvider provider, ProfileRecord record) : base(provider, record)
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
            if (_person != null)
            {
                _person.Save();
                this.ModifiedData.PersonId = _person.Id == null && this.ModifiedData.PersonId != null ? "" : _person.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_saqQueueProfilePerson != null)
                _saqQueueProfilePerson.Execute(obj => obj.ProfilePersonId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "PROF_PERSON_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel IProfilePersonModel.Person
        {
            get { return this.Person; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_PERSON_ID" field.
        /// </summary>
        System.String IProfilePersonModel.PersonId
        {
            get { return this.PersonId; }
            set { this.PersonId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueueModel" /> instances that reference this <see cref="!:ProfilePersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueueModel> IProfilePersonModel.SaqQueueProfilePerson
        {
            get { return this.SaqQueueProfilePerson; }
        }

        #endregion
    }
}
