using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PersonModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPersonFactory : IFactory<IPersonModel, String>
    {
        /// <summary>
        ///     Performs anonymise person on a single <see cref="!:PersonModel" /> instance.
        ///                     Functionality replicated from the SQL performed in V6.5.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:PersonModel" /> instance to be modified.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PersonModel" /> instance that match the specified <paramref name="personId" />.
        /// </returns>
        Consensus.Contact.IPersonModel AnonymisePerson(System.String personId);

        /// <summary>
        ///     Creates a new <see cref="!:PersonModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PersonModel" /> instance.
        /// </returns>
        Consensus.Contact.IPersonModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PersonModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PersonModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IPersonModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PersonModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PersonModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PersonModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.IPersonModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PersonModel" /> instances.
        /// </summary>
        /// <param name="personPromoIdId">
        ///     The value which identifies the <see cref="!:PersonModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PersonModel" /> instances that match the specified <paramref name="personPromoIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IPersonModel> FetchAllByPersonPromoIdId(System.String personPromoIdId);
    }
}
