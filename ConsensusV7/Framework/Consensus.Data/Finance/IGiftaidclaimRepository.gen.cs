using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="GiftaidclaimRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IGiftaidclaimRepository : IRepository<GiftaidclaimRecord, Int32>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> instances from the data store.
        /// </summary>
        /// <param name="submitterProleId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> instances that match the specified <paramref name="submitterProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.GiftaidclaimRecord> FetchAllBySubmitterProleId(System.String submitterProleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> instances from the data store.
        /// </summary>
        /// <param name="trusteeProleId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> instances that match the specified <paramref name="trusteeProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.GiftaidclaimRecord> FetchAllByTrusteeProleId(System.String trusteeProleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.GiftaidclaimRecord> FetchAllByOrgId(System.String orgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.GiftaidclaimRecord> FetchAllBySelcoSpId(System.String selcoSpId);

        #endregion
    }
}
