using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="OrganisationModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IOrganisationFactory : IFactory<IOrganisationModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:OrganisationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OrganisationModel" /> instance.
        /// </returns>
        Consensus.Contact.IOrganisationModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OrganisationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OrganisationModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IOrganisationModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:OrganisationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OrganisationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.IOrganisationModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OrganisationModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:OrganisationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IOrganisationModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);
    }
}
