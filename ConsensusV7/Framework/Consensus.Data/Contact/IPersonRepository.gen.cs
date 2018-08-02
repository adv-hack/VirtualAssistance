using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PersonRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPersonRepository : IRepository<PersonRecord, String>
    {
        #region properties

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String TableName
        {
            get;
        }

        #endregion

        #region methods

        void Create(Consensus.Contact.PersonRecord record);

        void Modify(Consensus.Contact.PersonRecord record);

        Consensus.Contact.PersonRecord AnonymisePerson(System.String personId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.PersonRecord" /> instances from the data store.
        /// </summary>
        /// <param name="promoId">
        ///     The value which identifies the <see cref="!:PersonModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.PersonRecord" /> instances that match the specified <paramref name="promoId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.PersonRecord> FetchAllByPromoId(System.String promoId);

        #endregion
    }
}
