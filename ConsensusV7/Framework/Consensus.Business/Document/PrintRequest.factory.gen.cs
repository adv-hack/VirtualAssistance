using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PrintRequestModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPrintRequestFactory : IFactory<IPrintRequestModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PrintRequestModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PrintRequestModel" /> instance.
        /// </returns>
        Consensus.Document.IPrintRequestModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PrintRequestModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PrintRequestModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPrintRequestModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PrintRequestModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PrintRequestModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IPrintRequestModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="queueId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="queueId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPrintRequestModel> FetchAllByQueueId(System.String queueId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPrintRequestModel> FetchAllByPackId(System.String packId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="batchId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="batchId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPrintRequestModel> FetchAllByBatchId(System.String batchId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="sendFromProleId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="sendFromProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPrintRequestModel> FetchAllBySendFromProleId(System.String sendFromProleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="sendToProleId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="sendToProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPrintRequestModel> FetchAllBySendToProleId(System.String sendToProleId);
    }
}
