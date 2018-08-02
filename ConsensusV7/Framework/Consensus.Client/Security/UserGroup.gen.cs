using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a collection of users.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class UserGroup : Proxy<IUserGroupModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Principal" /> member.
        /// </summary>
        private Consensus.Security.UserPrincipal _principal;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="UserGroupMemberships" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Security.UserGroupMember, Consensus.Security.IUserGroupMemberModel> _userGroupMemberships;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The security principal referenced by the group.
        /// </summary>
        public Consensus.Security.UserPrincipal Principal
        {
            get
            {
                if (_principal == null && this.Model.Principal != null)
                    _principal = new Consensus.Security.UserPrincipal(this.Model.Principal);
                if (_principal == null)
                    _principal = Consensus.Security.UserPrincipal.Create();
                return _principal;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for The security principal referenced by the group.
        /// </summary>
        public System.Int32 PrincipalId
        {
            get { return this.Model.PrincipalId; }
            set { this.Model.PrincipalId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserGroupMemberModel" /> instances that reference this <see cref="!:UserGroupModel" />.
        /// </summary>
        public Collection<Consensus.Security.UserGroupMember> UserGroupMemberships
        {
            get
            {
                if (_userGroupMemberships == null)
                    _userGroupMemberships = new ProxyCollection<Consensus.Security.UserGroupMember, Consensus.Security.IUserGroupMemberModel>(this.Model.UserGroupMemberships, model => new Consensus.Security.UserGroupMember(model));
                return _userGroupMemberships;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal UserGroup(IUserGroupModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:UserGroupModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserGroupModel" /> instance.
        /// </returns>
        public static Consensus.Security.UserGroup Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserGroup.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:UserGroupModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserGroupModel" /> instance.
        /// </returns>
        public static Consensus.Security.UserGroup Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.IUserGroupModel model = provider.Security.UserGroup.Create();
            return model == null ? null : new Consensus.Security.UserGroup(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserGroupModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserGroupModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserGroup> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserGroup.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserGroupModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserGroupModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserGroup> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserGroupModel> collection = provider.Security.UserGroup.FetchAll();
            return collection.Select(model => new Consensus.Security.UserGroup(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserGroupModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserGroupModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserGroupModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.UserGroup FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserGroup.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserGroupModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserGroupModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserGroupModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.UserGroup FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.IUserGroupModel model = provider.Security.UserGroup.FetchById(id);
            return model == null ? null : new Consensus.Security.UserGroup(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserGroup.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Security.UserGroup.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserGroupModel" /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:UserGroupModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserGroupModel" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserGroup> FetchAllByPrincipalId(System.Int32 principalId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserGroup.FetchAllByPrincipalId(site,principalId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserGroupModel" /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:UserGroupModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserGroupModel" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserGroup> FetchAllByPrincipalId(ConsensusSite site, System.Int32 principalId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserGroupModel> collection = provider.Security.UserGroup.FetchAllByPrincipalId(principalId);
            return collection.Select(model => new Consensus.Security.UserGroup(model));
        }

        #endregion
    }
}
