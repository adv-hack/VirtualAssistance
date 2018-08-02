using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PrepayAccountModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPrepayAccountFactory : IFactory<IPrepayAccountModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PrepayAccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PrepayAccountModel" /> instance.
        /// </returns>
        Consensus.Finance.IPrepayAccountModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PrepayAccountModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPrepayAccountModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PrepayAccountModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PrepayAccountModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IPrepayAccountModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPrepayAccountModel> FetchAllByOrganisationId(System.String organisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </summary>
        /// <param name="contactId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instances that match the specified <paramref name="contactId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPrepayAccountModel> FetchAllByContactId(System.String contactId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPrepayAccountModel> FetchAllByProductId(System.String productId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </summary>
        /// <param name="membershipId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instances that match the specified <paramref name="membershipId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPrepayAccountModel> FetchAllByMembershipId(System.String membershipId);
    }
}
