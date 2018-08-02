using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="BranchXrefRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBranchXrefRepository : IRepository<BranchXrefRecord, String>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.BranchXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="brId">
        ///     The value which identifies the <see cref="!:BranchXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.BranchXrefRecord" /> instances that match the specified <paramref name="brId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.BranchXrefRecord> FetchAllByBrId(System.String brId);

        #endregion
    }
}
