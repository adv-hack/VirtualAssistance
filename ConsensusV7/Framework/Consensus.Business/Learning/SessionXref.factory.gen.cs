using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SessionXrefModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISessionXrefFactory : IFactory<ISessionXrefModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:SessionXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SessionXrefModel" /> instance.
        /// </returns>
        Consensus.Learning.ISessionXrefModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SessionXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SessionXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionXrefModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SessionXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SessionXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.ISessionXrefModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionXrefModel" /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:SessionXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionXrefModel" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionXrefModel> FetchAllByEventId(System.String eventId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionXrefModel" /> instances.
        /// </summary>
        /// <param name="sessionId">
        ///     The value which identifies the <see cref="!:SessionXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionXrefModel" /> instances that match the specified <paramref name="sessionId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionXrefModel> FetchAllBySessionId(System.String sessionId);

        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionXrefModel> FetchAllByEventProductId(System.Nullable<System.Int32> eventProductId);
    }
}
