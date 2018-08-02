using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Specifies a permission that is held or withheld for a user or group.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class UserPermission : Proxy<IUserPermissionModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Principal" /> member.
        /// </summary>
        private Consensus.Security.UserPrincipal _principal;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The security principal to whom the permission is applied.
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
        ///     Gets or sets the unique code for The security principal to whom the permission is applied.
        /// </summary>
        public System.Int32 PrincipalId
        {
            get { return this.Model.PrincipalId; }
            set { this.Model.PrincipalId = value; }
        }

        /// <summary>
        ///     Gets or sets The data type to which the permission is applied.
        /// </summary>
        public System.String DataType
        {
            get { return this.Model.DataType; }
            set { this.Model.DataType = value; }
        }

        /// <summary>
        ///     Gets or sets The type of action that is either permitted or prohibited.
        /// </summary>
        public System.Int32 Action
        {
            get { return this.Model.Action; }
            set { this.Model.Action = value; }
        }

        /// <summary>
        ///     Gets or sets The value which indicates if the permission is granted (true) or denied (false).
        /// </summary>
        public System.Boolean Allow
        {
            get { return this.Model.Allow; }
            set { this.Model.Allow = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal UserPermission(IUserPermissionModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:UserPermissionModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserPermissionModel" /> instance.
        /// </returns>
        public static Consensus.Security.UserPermission Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserPermission.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:UserPermissionModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserPermissionModel" /> instance.
        /// </returns>
        public static Consensus.Security.UserPermission Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.IUserPermissionModel model = provider.Security.UserPermission.Create();
            return model == null ? null : new Consensus.Security.UserPermission(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserPermissionModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserPermissionModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserPermission> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserPermission.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserPermissionModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserPermissionModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserPermission> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserPermissionModel> collection = provider.Security.UserPermission.FetchAll();
            return collection.Select(model => new Consensus.Security.UserPermission(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserPermissionModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserPermissionModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserPermissionModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.UserPermission FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserPermission.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserPermissionModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserPermissionModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserPermissionModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.UserPermission FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.IUserPermissionModel model = provider.Security.UserPermission.FetchById(id);
            return model == null ? null : new Consensus.Security.UserPermission(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserPermission.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Security.UserPermission.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserPermissionModel" /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:UserPermissionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserPermissionModel" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserPermission> FetchAllByPrincipalId(System.Int32 principalId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserPermission.FetchAllByPrincipalId(site,principalId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserPermissionModel" /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:UserPermissionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserPermissionModel" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserPermission> FetchAllByPrincipalId(ConsensusSite site, System.Int32 principalId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserPermissionModel> collection = provider.Security.UserPermission.FetchAllByPrincipalId(principalId);
            return collection.Select(model => new Consensus.Security.UserPermission(model));
        }

        #endregion
    }
}
