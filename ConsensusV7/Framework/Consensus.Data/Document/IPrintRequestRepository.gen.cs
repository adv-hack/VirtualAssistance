using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PrintReqRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPrintRequestRepository : IRepository<PrintReqRecord, String>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pqId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances that match the specified <paramref name="pqId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PrintReqRecord> FetchAllByPqId(System.String pqId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances from the data store.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PrintReqRecord> FetchAllByPackId(System.String packId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances from the data store.
        /// </summary>
        /// <param name="batId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances that match the specified <paramref name="batId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PrintReqRecord> FetchAllByBatId(System.String batId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sendFromProleId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances that match the specified <paramref name="sendFromProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PrintReqRecord> FetchAllBySendFromProleId(System.String sendFromProleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sendToProleId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances that match the specified <paramref name="sendToProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PrintReqRecord> FetchAllBySendToProleId(System.String sendToProleId);

        #endregion
    }
}
