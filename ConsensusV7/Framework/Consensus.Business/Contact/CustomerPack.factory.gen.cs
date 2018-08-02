using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CustomerPackModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICustomerPackFactory : IFactory<ICustomerPackModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:CustomerPackModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CustomerPackModel" /> instance.
        /// </returns>
        Consensus.Contact.ICustomerPackModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CustomerPackModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CustomerPackModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICustomerPackModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:CustomerPackModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CustomerPackModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CustomerPackModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ICustomerPackModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CustomerPackModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:CustomerPackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CustomerPackModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICustomerPackModel> FetchAllByOrganisationId(System.String organisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CustomerPackModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:CustomerPackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CustomerPackModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICustomerPackModel> FetchAllByPackId(System.String packId);
    }
}
