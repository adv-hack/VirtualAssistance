using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="UserPermissionModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalUserPermissionFactory : LocalFactory<LocalUserPermissionModel, UserPermissionRecord, Int32>, IUserPermissionFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='UserPermissionModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='UserPermissionModel' /> instance.
        /// </returns>
        public LocalUserPermissionModel Create()
        {
            return new LocalUserPermissionModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='UserPermissionModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='UserPermissionModel' /> instances.
        /// </returns>
        public IEnumerable<LocalUserPermissionModel> FetchAll()
        {
            IEnumerable<UserPermissionRecord> recordCollection = this.Provider.DataProvider.Security.UserPermission.FetchAll();
            foreach (UserPermissionRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserPermissionModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='UserPermissionModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='UserPermissionModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserPermissionModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalUserPermissionModel FetchById(Int32 id)
        {
            UserPermissionRecord record = this.Provider.DataProvider.Security.UserPermission.FetchById(id);
            if (record == null)
                return null;
            return new LocalUserPermissionModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='UserPermission/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Security.UserPermission.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='UserPermissionModel' /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref='UserPermissionModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserPermissionModel' /> instances that match the specified <paramref name='principalId' />.
        /// </returns>
        public IEnumerable<LocalUserPermissionModel> FetchAllByPrincipalId(Int32 principalId)
        {
            IEnumerable<UserPermissionRecord> recordCollection = this.Provider.DataProvider.Security.UserPermission.FetchAllByPrincipalId(principalId);
            foreach (UserPermissionRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserPermissionModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:UserPermissionModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserPermissionModel" /> instance.
        /// </returns>
        Consensus.Security.IUserPermissionModel IUserPermissionFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserPermissionModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserPermissionModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserPermissionModel> IUserPermissionFactory.FetchAll()
        {
            return this.FetchAll();
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
        Consensus.Security.IUserPermissionModel IUserPermissionFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IUserPermissionFactory.GetTableName()
        {
            return this.GetTableName();
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
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserPermissionModel> IUserPermissionFactory.FetchAllByPrincipalId(System.Int32 principalId)
        {
            return this.FetchAllByPrincipalId(principalId);
        }

        #endregion
    }
}
