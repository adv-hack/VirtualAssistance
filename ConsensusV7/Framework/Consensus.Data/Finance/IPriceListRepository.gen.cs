using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PriceListRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPriceListRepository : IRepository<PriceListRecord, String>
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
        ///     Retrieves all existing <see cref="T:Consensus.Finance.PriceListRecord" /> instances from the data store, that are referenced by the valid prices
        ///                     recorded against a given product.
        /// </summary>
        /// <param name="productId">
        ///     The unique identifier for the product whoses prices are inspected.
        /// </param>
        /// <returns>
        ///     The enumerable collection of <see cref="T:Consensus.Finance.PriceListRecord" /> instances that are persisted within the data store.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PriceListRecord> FetchAllByProductId(System.String productId);

        #endregion
    }
}
