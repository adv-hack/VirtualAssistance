using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CommitteeXrefRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICommitteeXrefRepository : IRepository<CommitteeXrefRecord, String>
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

        void Create(Consensus.Membership.CommitteeXrefRecord record);

        void Modify(Consensus.Membership.CommitteeXrefRecord record);

        void RemoveById(Consensus.Membership.CommitteeXrefRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.CommitteeXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="comId">
        ///     The value which identifies the <see cref="!:CommitteeXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.CommitteeXrefRecord" /> instances that match the specified <paramref name="comId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.CommitteeXrefRecord> FetchAllByComId(System.String comId);

        #endregion
    }
}
