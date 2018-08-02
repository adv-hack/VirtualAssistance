using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PackRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPackRepository : IRepository<PackRecord, String>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="emailBody">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PackRecord" /> instances that match the specified <paramref name="emailBody" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PackRecord> FetchAllByEmailBody(System.String emailBody);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sendProleId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PackRecord" /> instances that match the specified <paramref name="sendProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PackRecord> FetchAllBySendProleId(System.String sendProleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pqId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PackRecord" /> instances that match the specified <paramref name="pqId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PackRecord> FetchAllByPqId(System.String pqId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PackRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PackRecord> FetchAllBySelcoSpId(System.String selcoSpId);

        #endregion
    }
}
