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
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPriceListRepository : SqlServerRepository<PriceListRecord, String>, IPriceListRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Finance"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "PriceList"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="PriceListRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PL_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Price_List"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="PriceListRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PriceListRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, PriceListRecord record)
        {
            record.Id = dataRecord["PL_ID"].ConvertTo<String>();
            record.Lock = dataRecord["PL_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["PL_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PL_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PL_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PL_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["PL_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PL_RCV_FROM"].ConvertTo<String>();
            record.Currency = dataRecord["PL_CURRENCY"].ConvertTo<String>();
            record.Name = dataRecord["PL_NAME"].ConvertTo<String>();
            record.ValidFrom = dataRecord["PL_VALID_FROM"].ConvertTo<DateTime?>();
            record.ValidUntil = dataRecord["PL_VALID_UNTIL"].ConvertTo<DateTime?>();
            record.BusinessUnit = dataRecord["PL_BUSINESS_UNIT"].ConvertTo<String>();
            record.Ticket = dataRecord["PL_TICKET"].ConvertTo<Byte?>();
            record.ProdFamily = dataRecord["PL_PROD_FAMILY"].ConvertTo<String>();
            record.BktId = dataRecord["PL_BKT_ID"].ConvertTo<String>();
            record.OrgOnly = dataRecord["PL_ORG_ONLY"].ConvertTo<Byte?>();
            record.Status = dataRecord["PL_STATUS"].ConvertTo<Byte?>();
            record.PrepayAccountOnly = dataRecord["PL_PREPAY_ACCOUNT_ONLY"].ConvertTo<Byte?>();
            record.PshId = dataRecord["PL_PSH_ID"].ConvertTo<Int32?>();
            record.Default = dataRecord["PL_DEFAULT"].ConvertTo<Byte>();
            record.VatCode = dataRecord["PL_VAT_CODE"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PriceListRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, PriceListRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PL_ID", record.Id);
            this.MapParameterIn(command, "@PA_PL_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_PL_CURRENCY", record.Currency);
            this.MapParameterIn(command, "@PA_PL_NAME", record.Name);
            this.MapParameterIn(command, "@PA_PL_VALID_FROM", record.ValidFrom == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ValidFrom);
            this.MapParameterIn(command, "@PA_PL_VALID_UNTIL", record.ValidUntil == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ValidUntil);
            this.MapParameterIn(command, "@PA_PL_BUSINESS_UNIT", record.BusinessUnit);
            this.MapParameterIn(command, "@PA_PL_TICKET", record.Ticket);
            this.MapParameterIn(command, "@PA_PL_PROD_FAMILY", record.ProdFamily);
            this.MapParameterIn(command, "@PA_PL_BKT_ID", record.BktId);
            this.MapParameterIn(command, "@PA_PL_ORG_ONLY", record.OrgOnly);
            this.MapParameterIn(command, "@PA_PL_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_PL_PREPAY_ACCOUNT_ONLY", record.PrepayAccountOnly);
            this.MapParameterIn(command, "@PA_PL_PSH_ID", record.PshId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PshId);
            this.MapParameterIn(command, "@PA_PL_DEFAULT", record.Default);
            this.MapParameterIn(command, "@PA_PL_VAT_CODE", record.VatCode);
            this.MapParameterIn(command, "@_AUDIT_USER_ID", UserId);
            this.MapParameterIn(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Extracts the parameter values for the specified <paramref name="command" /> and applies the values to the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PriceListRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, PriceListRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PL_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_PL_LOCK", record.Lock);
            record.Currency = this.MapParameterOut(command, "@PA_PL_CURRENCY", record.Currency);
            record.Name = this.MapParameterOut(command, "@PA_PL_NAME", record.Name);
            record.ValidFrom = this.MapParameterOut(command, "@PA_PL_VALID_FROM", record.ValidFrom);
            record.ValidUntil = this.MapParameterOut(command, "@PA_PL_VALID_UNTIL", record.ValidUntil);
            record.BusinessUnit = this.MapParameterOut(command, "@PA_PL_BUSINESS_UNIT", record.BusinessUnit);
            record.Ticket = this.MapParameterOut(command, "@PA_PL_TICKET", record.Ticket);
            record.ProdFamily = this.MapParameterOut(command, "@PA_PL_PROD_FAMILY", record.ProdFamily);
            record.BktId = this.MapParameterOut(command, "@PA_PL_BKT_ID", record.BktId);
            record.OrgOnly = this.MapParameterOut(command, "@PA_PL_ORG_ONLY", record.OrgOnly);
            record.Status = this.MapParameterOut(command, "@PA_PL_STATUS", record.Status);
            record.PrepayAccountOnly = this.MapParameterOut(command, "@PA_PL_PREPAY_ACCOUNT_ONLY", record.PrepayAccountOnly);
            record.PshId = this.MapParameterOut(command, "@PA_PL_PSH_ID", record.PshId);
            record.Default = this.MapParameterOut(command, "@PA_PL_DEFAULT", record.Default);
            record.VatCode = this.MapParameterOut(command, "@PA_PL_VAT_CODE", record.VatCode);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IPriceListRepository.TableName
        {
            get { return this.TableName; }
        }

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
        System.Collections.Generic.IEnumerable<Consensus.Finance.PriceListRecord> IPriceListRepository.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        #endregion
    }
}
