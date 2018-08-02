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
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerCurrencyRepository : SqlServerRepository<C4currencyRecord, String>, ICurrencyRepository
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
            get { return "C4currency"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="C4currencyRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_CURR_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "C4Currency"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="C4currencyRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="C4currencyRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, C4currencyRecord record)
        {
            record.Id = dataRecord["CURR_ID"].ConvertTo<String>();
            record.Code = dataRecord["CURR_CODE"].ConvertTo<String>();
            record.StartDate = dataRecord["CURR_START_DATE"].ConvertTo<DateTime?>();
            record.EndDate = dataRecord["CURR_END_DATE"].ConvertTo<DateTime?>();
            record.ConvFactor = dataRecord["CURR_CONV_FACTOR"].ConvertTo<Decimal>();
            record.DispFactor = dataRecord["CURR_DISP_FACTOR"].ConvertTo<Decimal>();
            record.Descrip = dataRecord["CURR_DESCRIP"].ConvertTo<String>();
            record.Lock = dataRecord["CURR_LOCK"].ConvertTo<String>();
            record.Euro = dataRecord["CURR_EURO"].ConvertTo<Byte?>();
            record.AddDate = dataRecord["CURR_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["CURR_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["CURR_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["CURR_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["CURR_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["CURR_RCV_FROM"].ConvertTo<String>();
            record.ConvFact2 = dataRecord["CURR_CONV_FACT2"].ConvertTo<Decimal>();
            record.SpId = dataRecord["CURR_SP_ID"].ConvertTo<String>();
            record.SymbolValue = dataRecord["CURR_SYMBOL_VALUE"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="C4currencyRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, C4currencyRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_CURR_ID", record.Id);
            this.MapParameterIn(command, "@PA_CURR_CODE", record.Code);
            this.MapParameterIn(command, "@PA_CURR_START_DATE", record.StartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDate);
            this.MapParameterIn(command, "@PA_CURR_END_DATE", record.EndDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndDate);
            this.MapParameterIn(command, "@PA_CURR_CONV_FACTOR", record.ConvFactor == Decimal.MinValue ? 0M : record.ConvFactor);
            this.MapParameterIn(command, "@PA_CURR_DISP_FACTOR", record.DispFactor == Decimal.MinValue ? 0M : record.DispFactor);
            this.MapParameterIn(command, "@PA_CURR_DESCRIP", record.Descrip);
            this.MapParameterIn(command, "@PA_CURR_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_CURR_EURO", record.Euro);
            this.MapParameterIn(command, "@PA_CURR_CONV_FACT2", record.ConvFact2 == Decimal.MinValue ? 0M : record.ConvFact2);
            this.MapParameterIn(command, "@PA_CURR_SP_ID", record.SpId);
            this.MapParameterIn(command, "@PA_CURR_SYMBOL_VALUE", record.SymbolValue);
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
        ///     The <see cref="C4currencyRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, C4currencyRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_CURR_ID", record.Id);
            record.Code = this.MapParameterOut(command, "@PA_CURR_CODE", record.Code);
            record.StartDate = this.MapParameterOut(command, "@PA_CURR_START_DATE", record.StartDate);
            record.EndDate = this.MapParameterOut(command, "@PA_CURR_END_DATE", record.EndDate);
            record.ConvFactor = this.MapParameterOut(command, "@PA_CURR_CONV_FACTOR", record.ConvFactor);
            record.DispFactor = this.MapParameterOut(command, "@PA_CURR_DISP_FACTOR", record.DispFactor);
            record.Descrip = this.MapParameterOut(command, "@PA_CURR_DESCRIP", record.Descrip);
            record.Lock = this.MapParameterOut(command, "@PA_CURR_LOCK", record.Lock);
            record.Euro = this.MapParameterOut(command, "@PA_CURR_EURO", record.Euro);
            record.ConvFact2 = this.MapParameterOut(command, "@PA_CURR_CONV_FACT2", record.ConvFact2);
            record.SpId = this.MapParameterOut(command, "@PA_CURR_SP_ID", record.SpId);
            record.SymbolValue = this.MapParameterOut(command, "@PA_CURR_SYMBOL_VALUE", record.SymbolValue);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="C4currencyRecord" /> instances from the data store.
        /// </summary>
        /// <param name="spId">
        ///     The value which identifies the <see cref='CurrencyModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="C4currencyRecord" /> instances that match the specified <paramref name='spId' />.
        /// </returns>
        public IEnumerable<C4currencyRecord> FetchAllBySpId(String spId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SpId");
            this.MapParameterIn(command, "@PA_CURR_SP_ID", spId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ICurrencyRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.C4currencyRecord ICurrencyRepository.FetchByCodeandSellingCompany(System.String code, System.String sellingCompany)
        {
            return this.FetchByCodeandSellingCompany(code, sellingCompany);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.C4currencyRecord" /> instances from the data store.
        /// </summary>
        /// <param name="spId">
        ///     The value which identifies the <see cref="!:CurrencyModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.C4currencyRecord" /> instances that match the specified <paramref name="spId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.C4currencyRecord> ICurrencyRepository.FetchAllBySpId(System.String spId)
        {
            return this.FetchAllBySpId(spId);
        }

        #endregion
    }
}
