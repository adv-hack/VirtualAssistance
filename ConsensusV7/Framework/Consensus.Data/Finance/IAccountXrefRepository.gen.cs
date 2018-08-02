using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="AccountXrefRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAccountXrefRepository : IRepository<AccountXrefRecord, String>
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

        void Create(Consensus.Finance.AccountXrefRecord record);

        void Modify(Consensus.Finance.AccountXrefRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="accId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountXrefRecord" /> instances that match the specified <paramref name="accId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountXrefRecord> FetchAllByAccId(System.String accId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountXrefRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountXrefRecord> FetchAllByOrgId(System.String orgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountXrefRecord" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountXrefRecord> FetchAllByAddId(System.String addId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountXrefRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountXrefRecord> FetchAllByProleId(System.String proleId);

        #endregion
    }
}
