using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PersonModel" /> object.
    /// </summary>
    public partial class LocalPersonFactory
    {

        /// <summary>
        ///     Performs anonymise person on a single <see cref='PersonModel' /> instance.
        ///     Functionality replicated from the SQL performed in V6.5
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='PersonModel' /> instance to be modified.
        /// </param>
        /// <returns>
        ///     The <see cref='PersonModel' /> instance that match the specified <paramref name='personId' />.
        /// </returns>
        public LocalPersonModel AnonymisePerson(String personId)
        {
       
            //Update person details
            PersonRecord record = this.Provider.DataProvider.Contact.Person.AnonymisePerson(personId);
            LocalPersonModel model = record == null ? null : new LocalPersonModel(this.Provider, record);
            return model;

        }
    }
}
