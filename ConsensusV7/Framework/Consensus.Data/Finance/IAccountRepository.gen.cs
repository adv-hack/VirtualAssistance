using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="AccountRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAccountRepository : IRepository<AccountRecord, String>
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
        ///     Retrieves a specific <see cref="!:AccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instance that matches the specified <paramref name="roleId" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountRecord> FetchByXrefRoleIdandOrgId(System.String roleId, System.String orgId, System.String spId);

        void Create(Consensus.Finance.AccountRecord record);

        void Modify(Consensus.Finance.AccountRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountRecord> FetchAllByOrgId(System.String orgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountRecord> FetchAllByProleId(System.String proleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountRecord> FetchAllByAddId(System.String addId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountRecord> FetchAllBySelcoSpId(System.String selcoSpId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invPackId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances that match the specified <paramref name="invPackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountRecord> FetchAllByInvPackId(System.String invPackId);

        #endregion
    }
}
