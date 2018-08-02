using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="UserGroupModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalUserGroupFactory : LocalFactory<LocalUserGroupModel, UserGroupRecord, Int32>, IUserGroupFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='UserGroupModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='UserGroupModel' /> instance.
        /// </returns>
        public LocalUserGroupModel Create()
        {
            return new LocalUserGroupModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='UserGroupModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='UserGroupModel' /> instances.
        /// </returns>
        public IEnumerable<LocalUserGroupModel> FetchAll()
        {
            IEnumerable<UserGroupRecord> recordCollection = this.Provider.DataProvider.Security.UserGroup.FetchAll();
            foreach (UserGroupRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserGroupModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='UserGroupModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='UserGroupModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserGroupModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalUserGroupModel FetchById(Int32 id)
        {
            UserGroupRecord record = this.Provider.DataProvider.Security.UserGroup.FetchById(id);
            if (record == null)
                return null;
            return new LocalUserGroupModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='UserGroup/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Security.UserGroup.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='UserGroupModel' /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref='UserGroupModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserGroupModel' /> instances that match the specified <paramref name='principalId' />.
        /// </returns>
        public IEnumerable<LocalUserGroupModel> FetchAllByPrincipalId(Int32 principalId)
        {
            IEnumerable<UserGroupRecord> recordCollection = this.Provider.DataProvider.Security.UserGroup.FetchAllByPrincipalId(principalId);
            foreach (UserGroupRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserGroupModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:UserGroupModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserGroupModel" /> instance.
        /// </returns>
        Consensus.Security.IUserGroupModel IUserGroupFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserGroupModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserGroupModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserGroupModel> IUserGroupFactory.FetchAll()
        {
            return this.FetchAll();
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
        Consensus.Security.IUserGroupModel IUserGroupFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IUserGroupFactory.GetTableName()
        {
            return this.GetTableName();
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
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserGroupModel> IUserGroupFactory.FetchAllByPrincipalId(System.Int32 principalId)
        {
            return this.FetchAllByPrincipalId(principalId);
        }

        #endregion
    }
}
