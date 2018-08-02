using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CountryModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCountryFactory : LocalFactory<LocalCountryModel, CountryRecord, String>, ICountryFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='CountryModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='CountryModel' /> instance.
        /// </returns>
        public LocalCountryModel Create()
        {
            return new LocalCountryModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='CountryModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='CountryModel' /> instances.
        /// </returns>
        public IEnumerable<LocalCountryModel> FetchAll()
        {
            IEnumerable<CountryRecord> recordCollection = this.Provider.DataProvider.Contact.Country.FetchAll();
            foreach (CountryRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCountryModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='CountryModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='CountryModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CountryModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalCountryModel FetchById(String id)
        {
            CountryRecord record = this.Provider.DataProvider.Contact.Country.FetchById(id);
            if (record == null)
                return null;
            return new LocalCountryModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Country/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.Country.TableName;
        }

        #endregion

        #region implementations

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
        System.Object ICountryFactory.CheckIfCountryOrCodeExist(System.String name, System.String code, System.String countryId)
        {
            return this.CheckIfCountryOrCodeExist(name, code, countryId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CountryModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CountryModel" /> instance.
        /// </returns>
        Consensus.Contact.ICountryModel ICountryFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CountryModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CountryModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICountryModel> ICountryFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CountryModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CountryModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CountryModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ICountryModel ICountryFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ICountryFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
