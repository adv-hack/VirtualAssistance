using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="UserGroupMemberRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserGroupMemberRepository : IRepository<UserGroupMemberRecord, Int32>
    {
        #region properties

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String TableName
        {
            get;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Security.UserGroupMemberRecord" /> instances from the data store.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:UserGroupMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.UserGroupMemberRecord" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.UserGroupMemberRecord> FetchAllByPrincipalId(System.Int32 principalId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Security.UserGroupMemberRecord" /> instances from the data store.
        /// </summary>
        /// <param name="groupId">
        ///     The value which identifies the <see cref="!:UserGroupMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.UserGroupMemberRecord" /> instances that match the specified <paramref name="groupId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.UserGroupMemberRecord> FetchAllByGroupId(System.Int32 groupId);

        #endregion
    }
}
