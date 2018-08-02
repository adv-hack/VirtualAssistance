using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SessionModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISessionFactory : IFactory<ISessionModel, String>
    {
        Consensus.Learning.ISessionModel CreateFromEvent(System.String eventId);

        /// <summary>
        ///     Creates a new <see cref="!:SessionModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SessionModel" /> instance.
        /// </returns>
        Consensus.Learning.ISessionModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SessionModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SessionModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SessionModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SessionModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.ISessionModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionModel> FetchAllByLocationId(System.String locationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionModel> FetchAllByOpportunityId(System.String opportunityId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionModel> FetchAllByProductId(System.String productId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionModel> FetchAllByOrganisationId(System.String organisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="biillOfMaterialId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="biillOfMaterialId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionModel> FetchAllByBiillOfMaterialId(System.String biillOfMaterialId);
    }
}
