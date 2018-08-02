using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CountryModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICountryFactory : IFactory<ICountryModel, String>
    {
        /// <summary>
        ///     Checks if Country's name or code exist.
        /// </summary>
        /// <param name="name">
        ///     Name of the country.
        /// </param>
        /// <param name="code">
        ///     Code of the country.
        /// </param>
        /// <param name="countryId">
        ///     Id of the country.
        /// </param>
        /// <returns>
        ///     Whether country's name or code exist in database.
        /// </returns>
        System.Object CheckIfCountryOrCodeExist(System.String name, System.String code, System.String countryId);

        /// <summary>
        ///     Creates a new <see cref="!:CountryModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CountryModel" /> instance.
        /// </returns>
        Consensus.Contact.ICountryModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CountryModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CountryModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICountryModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:CountryModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CountryModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CountryModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ICountryModel FetchById(System.String id);

        System.String GetTableName();
    }
}
