using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="C4currencyRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerCurrencyRepository
    {

        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <typeparamref name="TRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public C4currencyRecord FetchByCodeandSellingCompany(String code, String sellingCompany)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.Fetch,"Code", "SellingCompany");
            this.MapParameterIn(command, "@PA_CURR_CODE", code);
            this.MapParameterIn(command, "@PA_CURR_SP_ID", sellingCompany);
            return this.Execute(command).FirstOrDefault();
        }

    }
}
