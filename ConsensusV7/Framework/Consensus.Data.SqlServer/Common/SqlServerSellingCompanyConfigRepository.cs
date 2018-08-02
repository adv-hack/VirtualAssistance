using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SysConfigRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerSellingCompanyConfigRepository
    {
        /// <summary>
        ///     Retrieves all existing <typeparamref name="TRecord" /> instances from the data store.
        /// </summary>
        /// <returns>
        ///     The enumerable collection of <typeparamref name="TRecord" /> instances that are persisted within the data store.
        /// </returns>
        public virtual IEnumerable<SysConfigRecord> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SellingCompanyId");
            this.MapParameterIn(command, "@PA_SP_ID", sellingCompanyId);
            return this.Execute(command);
        }
        /// <summary>
        ///     Retrieves all existing <typeparamref name="TRecord" /> instances from the data store.
        /// </summary>
        /// <returns>
        ///     The enumerable collection of <typeparamref name="TRecord" /> instances that are persisted within the data store.
        /// </returns>
        public virtual IEnumerable<SysConfigRecord> FetchAllBySellingCompanyIdKeyName(String sellingCompanyId,String keyName)
        {
          DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SellingCompanyIdKeyName");
          this.MapParameterIn(command, "@PA_SP_ID", sellingCompanyId);
          this.MapParameterIn(command, "@PA_SC_KEY_NAME", keyName);
          return this.Execute(command);
        }
    }
}
