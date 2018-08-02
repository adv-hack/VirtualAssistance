using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="C4currencyRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICurrencyRepository : IRepository<C4currencyRecord, String>
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

        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.C4currencyRecord FetchByCodeandSellingCompany(System.String code, System.String sellingCompany);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.C4currencyRecord" /> instances from the data store.
        /// </summary>
        /// <param name="spId">
        ///     The value which identifies the <see cref="!:CurrencyModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.C4currencyRecord" /> instances that match the specified <paramref name="spId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.C4currencyRecord> FetchAllBySpId(System.String spId);

        #endregion
    }
}
