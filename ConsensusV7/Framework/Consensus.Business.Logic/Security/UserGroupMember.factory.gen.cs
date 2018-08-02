using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="UserGroupMemberModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalUserGroupMemberFactory : LocalFactory<LocalUserGroupMemberModel, UserGroupMemberRecord, Int32>, IUserGroupMemberFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='UserGroupMemberModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='UserGroupMemberModel' /> instance.
        /// </returns>
        public LocalUserGroupMemberModel Create()
        {
            return new LocalUserGroupMemberModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='UserGroupMemberModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='UserGroupMemberModel' /> instances.
        /// </returns>
        public IEnumerable<LocalUserGroupMemberModel> FetchAll()
        {
            IEnumerable<UserGroupMemberRecord> recordCollection = this.Provider.DataProvider.Security.UserGroupMember.FetchAll();
            foreach (UserGroupMemberRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserGroupMemberModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='UserGroupMemberModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='UserGroupMemberModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserGroupMemberModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalUserGroupMemberModel FetchById(Int32 id)
        {
            UserGroupMemberRecord record = this.Provider.DataProvider.Security.UserGroupMember.FetchById(id);
            if (record == null)
                return null;
            return new LocalUserGroupMemberModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='UserGroupMember/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Security.UserGroupMember.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='UserGroupMemberModel' /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref='UserGroupMemberModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserGroupMemberModel' /> instances that match the specified <paramref name='principalId' />.
        /// </returns>
        public IEnumerable<LocalUserGroupMemberModel> FetchAllByPrincipalId(Int32 principalId)
        {
            IEnumerable<UserGroupMemberRecord> recordCollection = this.Provider.DataProvider.Security.UserGroupMember.FetchAllByPrincipalId(principalId);
            foreach (UserGroupMemberRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserGroupMemberModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='UserGroupMemberModel' /> instances.
        /// </summary>
        /// <param name="groupId">
        ///     The value which identifies the <see cref='UserGroupMemberModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserGroupMemberModel' /> instances that match the specified <paramref name='groupId' />.
        /// </returns>
        public IEnumerable<LocalUserGroupMemberModel> FetchAllByGroupId(Int32 groupId)
        {
            IEnumerable<UserGroupMemberRecord> recordCollection = this.Provider.DataProvider.Security.UserGroupMember.FetchAllByGroupId(groupId);
            foreach (UserGroupMemberRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserGroupMemberModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:UserGroupMemberModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserGroupMemberModel" /> instance.
        /// </returns>
        Consensus.Security.IUserGroupMemberModel IUserGroupMemberFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserGroupMemberModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserGroupMemberModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserGroupMemberModel> IUserGroupMemberFactory.FetchAll()
        {
            return this.FetchAll();
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
        Consensus.Security.IUserGroupMemberModel IUserGroupMemberFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IUserGroupMemberFactory.GetTableName()
        {
            return this.GetTableName();
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
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserGroupMemberModel> IUserGroupMemberFactory.FetchAllByPrincipalId(System.Int32 principalId)
        {
            return this.FetchAllByPrincipalId(principalId);
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
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserGroupMemberModel> IUserGroupMemberFactory.FetchAllByGroupId(System.Int32 groupId)
        {
            return this.FetchAllByGroupId(groupId);
        }

        #endregion
    }
}
