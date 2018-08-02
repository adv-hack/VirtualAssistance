using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="OutputQueueModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IOutputQueueFactory : IFactory<IOutputQueueModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:OutputQueueModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OutputQueueModel" /> instance.
        /// </returns>
        Consensus.Document.IOutputQueueModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OutputQueueModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OutputQueueModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IOutputQueueModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:OutputQueueModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OutputQueueModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OutputQueueModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IOutputQueueModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OutputQueueModel" /> instances.
        /// </summary>
        /// <param name="adminProleId">
        ///     The value which identifies the <see cref="!:OutputQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OutputQueueModel" /> instances that match the specified <paramref name="adminProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IOutputQueueModel> FetchAllByAdminProleId(System.String adminProleId);
    }
}
