using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PayAllocationRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPayAllocationRepository : IRepository<PayAllocationRecord, String>
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

        void Create(Consensus.Finance.PayAllocationRecord record);

        void CreateReverse(Consensus.Finance.PayAllocationRecord record, System.Boolean reverse, System.String paid);

        void Modify(Consensus.Finance.PayAllocationRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PayAllocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PayAllocationRecord" /> instances that match the specified <paramref name="invId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PayAllocationRecord> FetchAllByInvId(System.String invId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PayAllocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="payId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PayAllocationRecord" /> instances that match the specified <paramref name="payId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PayAllocationRecord> FetchAllByPayId(System.String payId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PayAllocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="creditId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PayAllocationRecord" /> instances that match the specified <paramref name="creditId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PayAllocationRecord> FetchAllByCreditId(System.String creditId);

        #endregion
    }
}
