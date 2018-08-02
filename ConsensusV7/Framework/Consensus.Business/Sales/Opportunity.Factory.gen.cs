using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="OpportunityModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IOpportunityFactory : IFactory<IOpportunityModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:OpportunityModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OpportunityModel" /> instance.
        /// </returns>
        Consensus.Sales.IOpportunityModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OpportunityModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OpportunityModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:OpportunityModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OpportunityModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Sales.IOpportunityModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="promIdId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="promIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityModel> FetchAllByPromIdId(System.String promIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="activityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityModel> FetchAllByActivityId(System.String activityId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="courseIdId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="courseIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityModel> FetchAllByCourseIdId(System.String courseIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityModel> FetchAllByProductId(System.String productId);
    }
}
