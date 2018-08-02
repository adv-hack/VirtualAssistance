using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class PortalUserSite : Proxy<IPortalUserSiteModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PortalUser" /> member.
        /// </summary>
        private Consensus.Portal.PortalUser _portalUser;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PortalSetup" /> member.
        /// </summary>
        private Consensus.Portal.PortalSetup _portalSetup;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "PUSTE_PU_ID" field.
        /// </summary>
        public Consensus.Portal.PortalUser PortalUser
        {
            get
            {
                if (_portalUser == null && this.Model.PortalUser != null)
                    _portalUser = new Consensus.Portal.PortalUser(this.Model.PortalUser);
                if (_portalUser == null)
                    _portalUser = Consensus.Portal.PortalUser.Create();
                return _portalUser;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PUSTE_PU_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> PortalUserId
        {
            get { return this.Model.PortalUserId; }
            set { this.Model.PortalUserId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PUSTE_PS_ID" field.
        /// </summary>
        public Consensus.Portal.PortalSetup PortalSetup
        {
            get
            {
                if (_portalSetup == null && this.Model.PortalSetup != null)
                    _portalSetup = new Consensus.Portal.PortalSetup(this.Model.PortalSetup);
                if (_portalSetup == null)
                    _portalSetup = Consensus.Portal.PortalSetup.Create();
                return _portalSetup;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PUSTE_PS_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> PortalSetupId
        {
            get { return this.Model.PortalSetupId; }
            set { this.Model.PortalSetupId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal PortalUserSite(IPortalUserSiteModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:PortalUserSiteModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalUserSiteModel" /> instance.
        /// </returns>
        public static Consensus.Portal.PortalUserSite Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUserSite.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PortalUserSiteModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalUserSiteModel" /> instance.
        /// </returns>
        public static Consensus.Portal.PortalUserSite Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Portal.IPortalUserSiteModel model = provider.Portal.PortalUserSite.Create();
            return model == null ? null : new Consensus.Portal.PortalUserSite(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalUserSiteModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalUserSiteModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalUserSite> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUserSite.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalUserSiteModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalUserSiteModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalUserSite> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Portal.IPortalUserSiteModel> collection = provider.Portal.PortalUserSite.FetchAll();
            return collection.Select(model => new Consensus.Portal.PortalUserSite(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalUserSiteModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalUserSiteModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserSiteModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Portal.PortalUserSite FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUserSite.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalUserSiteModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalUserSiteModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserSiteModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Portal.PortalUserSite FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Portal.IPortalUserSiteModel model = provider.Portal.PortalUserSite.FetchById(id);
            return model == null ? null : new Consensus.Portal.PortalUserSite(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUserSite.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Portal.PortalUserSite.GetTableName();
        }

        public static IEnumerable<Consensus.Portal.PortalUserSite> FetchAllByPortalUserId(System.Nullable<System.Int32> portalUserId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUserSite.FetchAllByPortalUserId(site,portalUserId);
        }

        public static IEnumerable<Consensus.Portal.PortalUserSite> FetchAllByPortalUserId(ConsensusSite site, System.Nullable<System.Int32> portalUserId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Portal.IPortalUserSiteModel> collection = provider.Portal.PortalUserSite.FetchAllByPortalUserId(portalUserId);
            return collection.Select(model => new Consensus.Portal.PortalUserSite(model));
        }

        public static IEnumerable<Consensus.Portal.PortalUserSite> FetchAllByPortalSetupId(System.Nullable<System.Int32> portalSetupId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUserSite.FetchAllByPortalSetupId(site,portalSetupId);
        }

        public static IEnumerable<Consensus.Portal.PortalUserSite> FetchAllByPortalSetupId(ConsensusSite site, System.Nullable<System.Int32> portalSetupId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Portal.IPortalUserSiteModel> collection = provider.Portal.PortalUserSite.FetchAllByPortalSetupId(portalSetupId);
            return collection.Select(model => new Consensus.Portal.PortalUserSite(model));
        }

        #endregion
    }
}
