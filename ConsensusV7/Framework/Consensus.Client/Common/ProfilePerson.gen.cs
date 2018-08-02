using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;
using Consensus.Marketing;

namespace Consensus.Common
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ProfilePerson : Proxy<IProfilePersonModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Person" /> member.
        /// </summary>
        private Consensus.Contact.Person _person;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SaqQueueProfilePerson" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.SaqQueue, Consensus.Marketing.ISaqQueueModel> _saqQueueProfilePerson;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "PROF_PERSON_ID" field.
        /// </summary>
        public Consensus.Contact.Person Person
        {
            get
            {
                if (_person == null && this.Model.Person != null)
                    _person = new Consensus.Contact.Person(this.Model.Person);
                if (_person == null)
                    _person = Consensus.Contact.Person.Create();
                return _person;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_PERSON_ID" field.
        /// </summary>
        public System.String PersonId
        {
            get { return this.Model.PersonId; }
            set { this.Model.PersonId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueueModel" /> instances that reference this <see cref="!:ProfilePersonModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.SaqQueue> SaqQueueProfilePerson
        {
            get
            {
                if (_saqQueueProfilePerson == null)
                    _saqQueueProfilePerson = new ProxyCollection<Consensus.Marketing.SaqQueue, Consensus.Marketing.ISaqQueueModel>(this.Model.SaqQueueProfilePerson, model => new Consensus.Marketing.SaqQueue(model));
                return _saqQueueProfilePerson;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_KEY" field.
        /// </summary>
        public System.String Key
        {
            get { return this.Model.Key; }
            set { this.Model.Key = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE" field.
        /// </summary>
        public System.String Value
        {
            get { return this.Model.Value; }
            set { this.Model.Value = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> Date
        {
            get { return this.Model.Date; }
            set { this.Model.Date = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE3" field.
        /// </summary>
        public System.String Value3
        {
            get { return this.Model.Value3; }
            set { this.Model.Value3 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROF_STATUS" field.
        /// </summary>
        public Consensus.Common.Code Status
        {
            get
            {
                if (_status == null && this.Model.Status != null)
                    _status = new Consensus.Common.Code(this.Model.Status);
                if (_status == null)
                    _status = Consensus.Common.Code.Create();
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_STATUS" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE2" field.
        /// </summary>
        public System.String Value2
        {
            get { return this.Model.Value2; }
            set { this.Model.Value2 = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ProfilePerson(IProfilePersonModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ProfilePersonModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfilePersonModel" /> instance.
        /// </returns>
        public static Consensus.Common.ProfilePerson Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfilePerson.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ProfilePersonModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfilePersonModel" /> instance.
        /// </returns>
        public static Consensus.Common.ProfilePerson Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IProfilePersonModel model = provider.Common.ProfilePerson.Create();
            return model == null ? null : new Consensus.Common.ProfilePerson(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfilePersonModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfilePersonModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfilePerson> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfilePerson.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfilePersonModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfilePersonModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfilePerson> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IProfilePersonModel> collection = provider.Common.ProfilePerson.FetchAll();
            return collection.Select(model => new Consensus.Common.ProfilePerson(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfilePersonModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfilePersonModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfilePersonModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.ProfilePerson FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfilePerson.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfilePersonModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfilePersonModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfilePersonModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.ProfilePerson FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IProfilePersonModel model = provider.Common.ProfilePerson.FetchById(id);
            return model == null ? null : new Consensus.Common.ProfilePerson(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfilePerson.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.ProfilePerson.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfilePersonModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:ProfilePersonModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfilePersonModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfilePerson> FetchAllByPersonId(System.String personId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfilePerson.FetchAllByPersonId(site,personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfilePersonModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:ProfilePersonModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfilePersonModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfilePerson> FetchAllByPersonId(ConsensusSite site, System.String personId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IProfilePersonModel> collection = provider.Common.ProfilePerson.FetchAllByPersonId(personId);
            return collection.Select(model => new Consensus.Common.ProfilePerson(model));
        }

        #endregion
    }
}
