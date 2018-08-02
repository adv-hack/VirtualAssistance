using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProfileVolunteerModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProfileVolunteerFactory : IFactory<IProfileVolunteerModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ProfileVolunteerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileVolunteerModel" /> instance.
        /// </returns>
        Consensus.Common.IProfileVolunteerModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileVolunteerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileVolunteerModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileVolunteerModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileVolunteerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileVolunteerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileVolunteerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IProfileVolunteerModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileVolunteerModel" /> instances.
        /// </summary>
        /// <param name="volunteerId">
        ///     The value which identifies the <see cref="!:ProfileVolunteerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileVolunteerModel" /> instances that match the specified <paramref name="volunteerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileVolunteerModel> FetchAllByVolunteerId(System.String volunteerId);
    }
}
