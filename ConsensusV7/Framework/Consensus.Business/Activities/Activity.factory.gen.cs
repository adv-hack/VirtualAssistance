using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ActivityModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IActivityFactory : IFactory<IActivityModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ActivityModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ActivityModel" /> instance.
        /// </returns>
        Consensus.Activities.IActivityModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ActivityModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ActivityModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ActivityModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ActivityModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Activities.IActivityModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityModel> FetchAllByOpportunityId(System.String opportunityId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);
    }
}
