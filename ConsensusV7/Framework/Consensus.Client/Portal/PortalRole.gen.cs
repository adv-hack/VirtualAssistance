using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class PortalRole : Proxy<IPortalRoleModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PortalUserRoles" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Portal.PortalUserRole, Consensus.Portal.IPortalUserRoleModel> _portalUserRoles;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "PR_TITLE" field.
        /// </summary>
        public System.String Title
        {
            get { return this.Model.Title; }
            set { this.Model.Title = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserRoleModel" /> instances that reference this <see cref="!:PortalRoleModel" />.
        /// </summary>
        public Collection<Consensus.Portal.PortalUserRole> PortalUserRoles
        {
            get
            {
                if (_portalUserRoles == null)
                    _portalUserRoles = new ProxyCollection<Consensus.Portal.PortalUserRole, Consensus.Portal.IPortalUserRoleModel>(this.Model.PortalUserRoles, model => new Consensus.Portal.PortalUserRole(model));
                return _portalUserRoles;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal PortalRole(IPortalRoleModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:PortalRoleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalRoleModel" /> instance.
        /// </returns>
        public static Consensus.Portal.PortalRole Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalRole.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PortalRoleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalRoleModel" /> instance.
        /// </returns>
        public static Consensus.Portal.PortalRole Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Portal.IPortalRoleModel model = provider.Portal.PortalRole.Create();
            return model == null ? null : new Consensus.Portal.PortalRole(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalRoleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalRoleModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalRole> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalRole.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalRoleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalRoleModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalRole> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Portal.IPortalRoleModel> collection = provider.Portal.PortalRole.FetchAll();
            return collection.Select(model => new Consensus.Portal.PortalRole(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalRoleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalRoleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalRoleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Portal.PortalRole FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalRole.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalRoleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalRoleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalRoleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Portal.PortalRole FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Portal.IPortalRoleModel model = provider.Portal.PortalRole.FetchById(id);
            return model == null ? null : new Consensus.Portal.PortalRole(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalRole.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Portal.PortalRole.GetTableName();
        }

        #endregion
    }
}
