using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PriceListRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerPriceListRepository
    {
        /// <summary>
        ///     Retrieves all existing <see cref="PriceListRecord" /> instances from the data store, that are referenced by the valid prices
        ///     recorded against a given product.
        /// </summary>
        /// <param name="productId">
        ///     The unique identifier for the product whoses prices are inspected.
        /// </param>
        /// <returns>
        ///     The enumerable collection of <see cref="PriceListRecord" /> instances that are persisted within the data store.
        /// </returns>
        public virtual IEnumerable<PriceListRecord> FetchAllByProductId(String productId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProductId");
            this.MapParameterIn(command, "@PA_PROD_ID", productId);
            return this.Execute(command);
        }
    }
}
