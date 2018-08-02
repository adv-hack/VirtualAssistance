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
    public partial class ProfileOrganisation : Proxy<IProfileOrganisationModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SaqQueueProfileOrg" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.SaqQueue, Consensus.Marketing.ISaqQueueModel> _saqQueueProfileOrg;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "PROF_ORG_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation Organisation
        {
            get
            {
                if (_organisation == null && this.Model.Organisation != null)
                    _organisation = new Consensus.Contact.Organisation(this.Model.Organisation);
                if (_organisation == null)
                    _organisation = Consensus.Contact.Organisation.Create();
                return _organisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueueModel" /> instances that reference this <see cref="!:ProfileOrganisationModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.SaqQueue> SaqQueueProfileOrg
        {
            get
            {
                if (_saqQueueProfileOrg == null)
                    _saqQueueProfileOrg = new ProxyCollection<Consensus.Marketing.SaqQueue, Consensus.Marketing.ISaqQueueModel>(this.Model.SaqQueueProfileOrg, model => new Consensus.Marketing.SaqQueue(model));
                return _saqQueueProfileOrg;
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
        internal ProfileOrganisation(IProfileOrganisationModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ProfileOrganisationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileOrganisationModel" /> instance.
        /// </returns>
        public static Consensus.Common.ProfileOrganisation Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileOrganisation.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ProfileOrganisationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileOrganisationModel" /> instance.
        /// </returns>
        public static Consensus.Common.ProfileOrganisation Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IProfileOrganisationModel model = provider.Common.ProfileOrganisation.Create();
            return model == null ? null : new Consensus.Common.ProfileOrganisation(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileOrganisationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileOrganisationModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileOrganisation> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileOrganisation.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileOrganisationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileOrganisationModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileOrganisation> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IProfileOrganisationModel> collection = provider.Common.ProfileOrganisation.FetchAll();
            return collection.Select(model => new Consensus.Common.ProfileOrganisation(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileOrganisationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileOrganisationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileOrganisationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.ProfileOrganisation FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileOrganisation.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileOrganisationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileOrganisationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileOrganisationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.ProfileOrganisation FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IProfileOrganisationModel model = provider.Common.ProfileOrganisation.FetchById(id);
            return model == null ? null : new Consensus.Common.ProfileOrganisation(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileOrganisation.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.ProfileOrganisation.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileOrganisationModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:ProfileOrganisationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileOrganisationModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileOrganisation> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileOrganisation.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileOrganisationModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:ProfileOrganisationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileOrganisationModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileOrganisation> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IProfileOrganisationModel> collection = provider.Common.ProfileOrganisation.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Common.ProfileOrganisation(model));
        }

        #endregion
    }
}
