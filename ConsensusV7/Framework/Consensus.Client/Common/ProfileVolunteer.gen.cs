using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Common
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ProfileVolunteer : Proxy<IProfileVolunteerModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProfStatus" /> member.
        /// </summary>
        private Consensus.Common.Code _profStatus;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Volunteer" /> member.
        /// </summary>
        private Consensus.Contact.Trainer _volunteer;

        #endregion

        #region properties

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
        public Consensus.Common.Code ProfStatus
        {
            get
            {
                if (_profStatus == null && this.Model.ProfStatus != null)
                    _profStatus = new Consensus.Common.Code(this.Model.ProfStatus);
                if (_profStatus == null)
                    _profStatus = Consensus.Common.Code.Create();
                return _profStatus;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_STATUS" field.
        /// </summary>
        public System.String ProfStatusCode
        {
            get { return this.Model.ProfStatusCode; }
            set { this.Model.ProfStatusCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE2" field.
        /// </summary>
        public System.String Value2
        {
            get { return this.Model.Value2; }
            set { this.Model.Value2 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROF_VOL_ID" field.
        /// </summary>
        public Consensus.Contact.Trainer Volunteer
        {
            get
            {
                if (_volunteer == null && this.Model.Volunteer != null)
                    _volunteer = new Consensus.Contact.Trainer(this.Model.Volunteer);
                if (_volunteer == null)
                    _volunteer = Consensus.Contact.Trainer.Create();
                return _volunteer;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_VOL_ID" field.
        /// </summary>
        public System.String VolunteerId
        {
            get { return this.Model.VolunteerId; }
            set { this.Model.VolunteerId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ProfileVolunteer(IProfileVolunteerModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ProfileVolunteerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileVolunteerModel" /> instance.
        /// </returns>
        public static Consensus.Common.ProfileVolunteer Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileVolunteer.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ProfileVolunteerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileVolunteerModel" /> instance.
        /// </returns>
        public static Consensus.Common.ProfileVolunteer Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IProfileVolunteerModel model = provider.Common.ProfileVolunteer.Create();
            return model == null ? null : new Consensus.Common.ProfileVolunteer(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileVolunteerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileVolunteerModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileVolunteer> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileVolunteer.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileVolunteerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileVolunteerModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileVolunteer> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IProfileVolunteerModel> collection = provider.Common.ProfileVolunteer.FetchAll();
            return collection.Select(model => new Consensus.Common.ProfileVolunteer(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileVolunteerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileVolunteerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileVolunteerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.ProfileVolunteer FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileVolunteer.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileVolunteerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileVolunteerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileVolunteerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.ProfileVolunteer FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IProfileVolunteerModel model = provider.Common.ProfileVolunteer.FetchById(id);
            return model == null ? null : new Consensus.Common.ProfileVolunteer(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileVolunteer.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.ProfileVolunteer.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileVolunteerModel" /> instances.
        /// </summary>
        /// <param name="volunteerId">
        ///     The value which identifies the <see cref="!:ProfileVolunteerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileVolunteerModel" /> instances that match the specified <paramref name="volunteerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileVolunteer> FetchAllByVolunteerId(System.String volunteerId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileVolunteer.FetchAllByVolunteerId(site,volunteerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileVolunteerModel" /> instances.
        /// </summary>
        /// <param name="volunteerId">
        ///     The value which identifies the <see cref="!:ProfileVolunteerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileVolunteerModel" /> instances that match the specified <paramref name="volunteerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileVolunteer> FetchAllByVolunteerId(ConsensusSite site, System.String volunteerId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IProfileVolunteerModel> collection = provider.Common.ProfileVolunteer.FetchAllByVolunteerId(volunteerId);
            return collection.Select(model => new Consensus.Common.ProfileVolunteer(model));
        }

        #endregion
    }
}
