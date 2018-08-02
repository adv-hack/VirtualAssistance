using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="OpportunityXrefModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IOpportunityXrefFactory : IFactory<IOpportunityXrefModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:OpportunityXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OpportunityXrefModel" /> instance.
        /// </returns>
        Consensus.Sales.IOpportunityXrefModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OpportunityXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OpportunityXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityXrefModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:OpportunityXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OpportunityXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Sales.IOpportunityXrefModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityXrefModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityXrefModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityXrefModel> FetchAllByRoleId(System.String roleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityXrefModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityXrefModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityXrefModel> FetchAllByOpportunityId(System.String opportunityId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityXrefModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityXrefModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityXrefModel> FetchAllByOrganisationId(System.String organisationId);
    }
}
