using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ActivityXrefModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IActivityXrefFactory : IFactory<IActivityXrefModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ActivityXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ActivityXrefModel" /> instance.
        /// </returns>
        Consensus.Activities.IActivityXrefModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ActivityXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityXrefModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ActivityXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ActivityXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Activities.IActivityXrefModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="activityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityXrefModel> FetchAllByActivityId(System.String activityId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityXrefModel> FetchAllByPersonId(System.String personId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityXrefModel> FetchAllByOrganisationId(System.String organisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="personRoleId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="personRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityXrefModel> FetchAllByPersonRoleId(System.String personRoleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityXrefModel> FetchAllByProductId(System.String productId);
    }
}
