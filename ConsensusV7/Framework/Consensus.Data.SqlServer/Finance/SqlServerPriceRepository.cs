using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PriceRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerPriceRepository
    {
        public override void Modify(PricesRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdatePrice");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Create(PricesRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdatePrice");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
        public PricesRecord RecalculateMemberFee(String productId, String plId, DateTime? startDate, DateTime? endDate, Int32 qtyTotal)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spConsensusFinancePricesRecalculateMemberFee");
            this.MapParameterIn(command, "@PA_PRODUCT_ID", productId);
            this.MapParameterIn(command, "@PA_PRICE_LIST_ID", plId);
            this.MapParameterIn(command, "@PA_START_DATE", startDate);
            this.MapParameterIn(command, "@PA_END_DATE", endDate);
            this.MapParameterIn(command, "@PA_QTY_TOTAL", qtyTotal);
            return this.Execute(command).FirstOrDefault();
        }
        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <param name="recType">
        ///     The unique value which distinctly identifies the <typeparamref name="TRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public IEnumerable<PricesRecord> FetchAllByProdidPriceListid(String productId, String plId)
        {
          DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProdidPriceListid");
          this.MapParameterIn(command, "@PA_PRS_PROD_ID", productId);
          this.MapParameterIn(command, "@PA_PRS_PL_ID", plId);
          return this.Execute(command);
        }
    }
}
