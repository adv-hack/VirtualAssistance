using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ActLinkXrefModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IActLinkXrefFactory : IFactory<IActLinkXrefModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ActLinkXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ActLinkXrefModel" /> instance.
        /// </returns>
        Consensus.Activities.IActLinkXrefModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ActLinkXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ActLinkXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActLinkXrefModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ActLinkXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ActLinkXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActLinkXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Activities.IActLinkXrefModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActLinkXrefModel" /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref="!:ActLinkXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActLinkXrefModel" /> instances that match the specified <paramref name="activityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActLinkXrefModel> FetchAllByActivityId(System.String activityId);
    }
}
