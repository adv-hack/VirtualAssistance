using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PrintQueueRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IOutputQueueRepository : IRepository<PrintQueueRecord, String>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PrintQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="adminProleId">
        ///     The value which identifies the <see cref="!:OutputQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PrintQueueRecord" /> instances that match the specified <paramref name="adminProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PrintQueueRecord> FetchAllByAdminProleId(System.String adminProleId);

        #endregion
    }
}
