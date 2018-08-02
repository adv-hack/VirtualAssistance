using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SaqQueueModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISaqQueueFactory : IFactory<ISaqQueueModel, Int64>
    {
        /// <summary>
        ///     Creates a new <see cref="!:SaqQueueModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqQueueModel" /> instance.
        /// </returns>
        Consensus.Marketing.ISaqQueueModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqQueueModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqQueueModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueueModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqQueueModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqQueueModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.ISaqQueueModel FetchById(System.Int64 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="queryId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="queryId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueueModel> FetchAllByQueryId(System.Int64 queryId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="mailingListId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="mailingListId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueueModel> FetchAllByMailingListId(System.String mailingListId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="profilePersonId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="profilePersonId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueueModel> FetchAllByProfilePersonId(System.String profilePersonId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="profileOrgId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="profileOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueueModel> FetchAllByProfileOrgId(System.String profileOrgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueueModel> FetchAllByPackId(System.String packId);
    }
}
