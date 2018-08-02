using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LocationModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILocationFactory : IFactory<ILocationModel, String>
    {
        /// <summary>
        ///     Check if Location Reference exist or not.
        /// </summary>
        /// <param name="reference">
        ///     Location Reference.
        /// </param>
        /// <param name="locationId">
        ///     Id of Location.
        /// </param>
        /// <returns>
        ///     Whether loction exist or not.
        /// </returns>
        System.Boolean CheckIfLocationReferenceExist(System.String reference, System.String locationId);

        /// <summary>
        ///     Creates a new <see cref="!:LocationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LocationModel" /> instance.
        /// </returns>
        Consensus.Contact.ILocationModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LocationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LocationModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ILocationModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:LocationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LocationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ILocationModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ILocationModel> FetchAllByOrganisationId(System.String organisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ILocationModel> FetchAllByAddressId(System.String addressId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ILocationModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="locationRoleId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="locationRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ILocationModel> FetchAllByLocationRoleId(System.String locationRoleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="linkedLocationId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="linkedLocationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ILocationModel> FetchAllByLinkedLocationId(System.String linkedLocationId);
    }
}
