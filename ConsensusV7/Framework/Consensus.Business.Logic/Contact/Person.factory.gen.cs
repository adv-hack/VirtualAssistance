using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PersonModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPersonFactory : LocalFactory<LocalPersonModel, PersonRecord, String>, IPersonFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PersonModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PersonModel' /> instance.
        /// </returns>
        public LocalPersonModel Create()
        {
            return new LocalPersonModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PersonModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PersonModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPersonModel> FetchAll()
        {
            IEnumerable<PersonRecord> recordCollection = this.Provider.DataProvider.Contact.Person.FetchAll();
            foreach (PersonRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPersonModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PersonModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PersonModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PersonModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPersonModel FetchById(String id)
        {
            PersonRecord record = this.Provider.DataProvider.Contact.Person.FetchById(id);
            if (record == null)
                return null;
            return new LocalPersonModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Person/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.Person.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PersonModel' /> instances.
        /// </summary>
        /// <param name="personPromoIdId">
        ///     The value which identifies the <see cref='PersonModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PersonModel' /> instances that match the specified <paramref name='personPromoIdId' />.
        /// </returns>
        public IEnumerable<LocalPersonModel> FetchAllByPersonPromoIdId(String personPromoIdId)
        {
            IEnumerable<PersonRecord> recordCollection = this.Provider.DataProvider.Contact.Person.FetchAllByPromoId(personPromoIdId);
            foreach (PersonRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPersonModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

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
        Consensus.Contact.IPersonModel IPersonFactory.AnonymisePerson(System.String personId)
        {
            return this.AnonymisePerson(personId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PersonModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PersonModel" /> instance.
        /// </returns>
        Consensus.Contact.IPersonModel IPersonFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PersonModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PersonModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IPersonModel> IPersonFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PersonModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PersonModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PersonModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.IPersonModel IPersonFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IPersonFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PersonModel" /> instances.
        /// </summary>
        /// <param name="personPromoIdId">
        ///     The value which identifies the <see cref="!:PersonModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PersonModel" /> instances that match the specified <paramref name="personPromoIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IPersonModel> IPersonFactory.FetchAllByPersonPromoIdId(System.String personPromoIdId)
        {
            return this.FetchAllByPersonPromoIdId(personPromoIdId);
        }

        #endregion
    }
}
