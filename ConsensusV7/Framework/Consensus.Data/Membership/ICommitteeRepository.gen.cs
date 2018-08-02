using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CommitteeRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICommitteeRepository : IRepository<CommitteeRecord, String>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.CommitteeRecord" /> instances from the data store.
        /// </summary>
        /// <param name="disId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.CommitteeRecord" /> instances that match the specified <paramref name="disId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.CommitteeRecord> FetchAllByDisId(System.String disId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.CommitteeRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.CommitteeRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.CommitteeRecord> FetchAllByProdId(System.String prodId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.CommitteeRecord" /> instances from the data store.
        /// </summary>
        /// <param name="brId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.CommitteeRecord" /> instances that match the specified <paramref name="brId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.CommitteeRecord> FetchAllByBrId(System.String brId);

        #endregion
    }
}
