using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class PortalSetup : Proxy<IPortalSetupModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PortalUserSites" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Portal.PortalUserSite, Consensus.Portal.IPortalUserSiteModel> _portalUserSites;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "PS_PORTAL_TITLE" field.
        /// </summary>
        public System.String PortalTitle
        {
            get { return this.Model.PortalTitle; }
            set { this.Model.PortalTitle = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PS_PORTAL_URL" field.
        /// </summary>
        public System.String PortalUrl
        {
            get { return this.Model.PortalUrl; }
            set { this.Model.PortalUrl = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserSiteModel" /> instances that reference this <see cref="!:PortalSetupModel" />.
        /// </summary>
        public Collection<Consensus.Portal.PortalUserSite> PortalUserSites
        {
            get
            {
                if (_portalUserSites == null)
                    _portalUserSites = new ProxyCollection<Consensus.Portal.PortalUserSite, Consensus.Portal.IPortalUserSiteModel>(this.Model.PortalUserSites, model => new Consensus.Portal.PortalUserSite(model));
                return _portalUserSites;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal PortalSetup(IPortalSetupModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:PortalSetupModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalSetupModel" /> instance.
        /// </returns>
        public static Consensus.Portal.PortalSetup Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalSetup.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PortalSetupModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalSetupModel" /> instance.
        /// </returns>
        public static Consensus.Portal.PortalSetup Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Portal.IPortalSetupModel model = provider.Portal.PortalSetup.Create();
            return model == null ? null : new Consensus.Portal.PortalSetup(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalSetupModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalSetupModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalSetup> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalSetup.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalSetupModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalSetupModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalSetup> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Portal.IPortalSetupModel> collection = provider.Portal.PortalSetup.FetchAll();
            return collection.Select(model => new Consensus.Portal.PortalSetup(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalSetupModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalSetupModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalSetupModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Portal.PortalSetup FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalSetup.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalSetupModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalSetupModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalSetupModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Portal.PortalSetup FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Portal.IPortalSetupModel model = provider.Portal.PortalSetup.FetchById(id);
            return model == null ? null : new Consensus.Portal.PortalSetup(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalSetup.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Portal.PortalSetup.GetTableName();
        }

        #endregion
    }
}
