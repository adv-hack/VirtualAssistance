using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class PortalUserRole : Proxy<IPortalUserRoleModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PortalUser" /> member.
        /// </summary>
        private Consensus.Portal.PortalUser _portalUser;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PortalRole" /> member.
        /// </summary>
        private Consensus.Portal.PortalRole _portalRole;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "PUR_PU_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PUR_PU_ID" field.
        /// </summary>
        public System.Int32 PortalUserId
        {
            get { return this.Model.PortalUserId; }
            set { this.Model.PortalUserId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PUR_PR_ID" field.
        /// </summary>
        public Consensus.Portal.PortalRole PortalRole
        {
            get
            {
                if (_portalRole == null && this.Model.PortalRole != null)
                    _portalRole = new Consensus.Portal.PortalRole(this.Model.PortalRole);
                if (_portalRole == null)
                    _portalRole = Consensus.Portal.PortalRole.Create();
                return _portalRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PUR_PR_ID" field.
        /// </summary>
        public System.Int32 PortalRoleId
        {
            get { return this.Model.PortalRoleId; }
            set { this.Model.PortalRoleId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal PortalUserRole(IPortalUserRoleModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:PortalUserRoleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalUserRoleModel" /> instance.
        /// </returns>
        public static Consensus.Portal.PortalUserRole Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUserRole.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PortalUserRoleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalUserRoleModel" /> instance.
        /// </returns>
        public static Consensus.Portal.PortalUserRole Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Portal.IPortalUserRoleModel model = provider.Portal.PortalUserRole.Create();
            return model == null ? null : new Consensus.Portal.PortalUserRole(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalUserRoleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalUserRoleModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalUserRole> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUserRole.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalUserRoleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalUserRoleModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalUserRole> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Portal.IPortalUserRoleModel> collection = provider.Portal.PortalUserRole.FetchAll();
            return collection.Select(model => new Consensus.Portal.PortalUserRole(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalUserRoleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalUserRoleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserRoleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Portal.PortalUserRole FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUserRole.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalUserRoleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalUserRoleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserRoleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Portal.PortalUserRole FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Portal.IPortalUserRoleModel model = provider.Portal.PortalUserRole.FetchById(id);
            return model == null ? null : new Consensus.Portal.PortalUserRole(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUserRole.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Portal.PortalUserRole.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PortalUserRoleModel" /> instances.
        /// </summary>
        /// <param name="portalUserId">
        ///     The value which identifies the <see cref="!:PortalUserRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserRoleModel" /> instances that match the specified <paramref name="portalUserId" />.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalUserRole> FetchAllByPortalUserId(System.Int32 portalUserId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUserRole.FetchAllByPortalUserId(site,portalUserId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PortalUserRoleModel" /> instances.
        /// </summary>
        /// <param name="portalUserId">
        ///     The value which identifies the <see cref="!:PortalUserRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserRoleModel" /> instances that match the specified <paramref name="portalUserId" />.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalUserRole> FetchAllByPortalUserId(ConsensusSite site, System.Int32 portalUserId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Portal.IPortalUserRoleModel> collection = provider.Portal.PortalUserRole.FetchAllByPortalUserId(portalUserId);
            return collection.Select(model => new Consensus.Portal.PortalUserRole(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PortalUserRoleModel" /> instances.
        /// </summary>
        /// <param name="portalRoleId">
        ///     The value which identifies the <see cref="!:PortalUserRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserRoleModel" /> instances that match the specified <paramref name="portalRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalUserRole> FetchAllByPortalRoleId(System.Int32 portalRoleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUserRole.FetchAllByPortalRoleId(site,portalRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PortalUserRoleModel" /> instances.
        /// </summary>
        /// <param name="portalRoleId">
        ///     The value which identifies the <see cref="!:PortalUserRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserRoleModel" /> instances that match the specified <paramref name="portalRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalUserRole> FetchAllByPortalRoleId(ConsensusSite site, System.Int32 portalRoleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Portal.IPortalUserRoleModel> collection = provider.Portal.PortalUserRole.FetchAllByPortalRoleId(portalRoleId);
            return collection.Select(model => new Consensus.Portal.PortalUserRole(model));
        }

        #endregion
    }
}
