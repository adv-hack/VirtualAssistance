using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProfileOrganisationModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProfileOrganisationFactory : IFactory<IProfileOrganisationModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ProfileOrganisationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileOrganisationModel" /> instance.
        /// </returns>
        Consensus.Common.IProfileOrganisationModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileOrganisationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileOrganisationModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileOrganisationModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileOrganisationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileOrganisationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileOrganisationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IProfileOrganisationModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileOrganisationModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:ProfileOrganisationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileOrganisationModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileOrganisationModel> FetchAllByOrganisationId(System.String organisationId);
    }
}
