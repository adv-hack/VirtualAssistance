using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a membership to a user group.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class UserGroupMember : Proxy<IUserGroupMemberModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Principal" /> member.
        /// </summary>
        private Consensus.Security.UserPrincipal _principal;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Group" /> member.
        /// </summary>
        private Consensus.Security.UserGroup _group;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The security principal that is a member of the group.
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
        ///     Gets or sets the unique code for The security principal that is a member of the group.
        /// </summary>
        public System.Int32 PrincipalId
        {
            get { return this.Model.PrincipalId; }
            set { this.Model.PrincipalId = value; }
        }

        /// <summary>
        ///     Gets the The user group in which the member is included.
        /// </summary>
        public Consensus.Security.UserGroup Group
        {
            get
            {
                if (_group == null && this.Model.Group != null)
                    _group = new Consensus.Security.UserGroup(this.Model.Group);
                if (_group == null)
                    _group = Consensus.Security.UserGroup.Create();
                return _group;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for The user group in which the member is included.
        /// </summary>
        public System.Int32 GroupId
        {
            get { return this.Model.GroupId; }
            set { this.Model.GroupId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal UserGroupMember(IUserGroupMemberModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:UserGroupMemberModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserGroupMemberModel" /> instance.
        /// </returns>
        public static Consensus.Security.UserGroupMember Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserGroupMember.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:UserGroupMemberModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserGroupMemberModel" /> instance.
        /// </returns>
        public static Consensus.Security.UserGroupMember Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.IUserGroupMemberModel model = provider.Security.UserGroupMember.Create();
            return model == null ? null : new Consensus.Security.UserGroupMember(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserGroupMemberModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserGroupMemberModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserGroupMember> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserGroupMember.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserGroupMemberModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserGroupMemberModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserGroupMember> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserGroupMemberModel> collection = provider.Security.UserGroupMember.FetchAll();
            return collection.Select(model => new Consensus.Security.UserGroupMember(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserGroupMemberModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserGroupMemberModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserGroupMemberModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.UserGroupMember FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserGroupMember.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserGroupMemberModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserGroupMemberModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserGroupMemberModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.UserGroupMember FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.IUserGroupMemberModel model = provider.Security.UserGroupMember.FetchById(id);
            return model == null ? null : new Consensus.Security.UserGroupMember(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserGroupMember.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Security.UserGroupMember.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserGroupMemberModel" /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:UserGroupMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserGroupMemberModel" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserGroupMember> FetchAllByPrincipalId(System.Int32 principalId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserGroupMember.FetchAllByPrincipalId(site,principalId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserGroupMemberModel" /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:UserGroupMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserGroupMemberModel" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserGroupMember> FetchAllByPrincipalId(ConsensusSite site, System.Int32 principalId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserGroupMemberModel> collection = provider.Security.UserGroupMember.FetchAllByPrincipalId(principalId);
            return collection.Select(model => new Consensus.Security.UserGroupMember(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserGroupMemberModel" /> instances.
        /// </summary>
        /// <param name="groupId">
        ///     The value which identifies the <see cref="!:UserGroupMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserGroupMemberModel" /> instances that match the specified <paramref name="groupId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserGroupMember> FetchAllByGroupId(System.Int32 groupId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserGroupMember.FetchAllByGroupId(site,groupId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserGroupMemberModel" /> instances.
        /// </summary>
        /// <param name="groupId">
        ///     The value which identifies the <see cref="!:UserGroupMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserGroupMemberModel" /> instances that match the specified <paramref name="groupId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserGroupMember> FetchAllByGroupId(ConsensusSite site, System.Int32 groupId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserGroupMemberModel> collection = provider.Security.UserGroupMember.FetchAllByGroupId(groupId);
            return collection.Select(model => new Consensus.Security.UserGroupMember(model));
        }

        #endregion
    }
}
