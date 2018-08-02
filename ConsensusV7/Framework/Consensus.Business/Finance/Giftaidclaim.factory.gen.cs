using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="GiftaidclaimModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IGiftaidclaimFactory : IFactory<IGiftaidclaimModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:GiftaidclaimModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:GiftaidclaimModel" /> instance.
        /// </returns>
        Consensus.Finance.IGiftaidclaimModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:GiftaidclaimModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IGiftaidclaimModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:GiftaidclaimModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:GiftaidclaimModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IGiftaidclaimModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </summary>
        /// <param name="submitterId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instances that match the specified <paramref name="submitterId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IGiftaidclaimModel> FetchAllBySubmitterId(System.String submitterId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </summary>
        /// <param name="trusteeId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instances that match the specified <paramref name="trusteeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IGiftaidclaimModel> FetchAllByTrusteeId(System.String trusteeId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IGiftaidclaimModel> FetchAllByOrganisationId(System.String organisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IGiftaidclaimModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);
    }
}
