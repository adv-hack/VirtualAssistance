using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CostCodeRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerCostCodeRepository : SqlServerRepository<CostCodeRecord, String>, ICostCodeRepository
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
            get { return "CostCode"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="CostCodeRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_COST_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Cost_Code"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="CostCodeRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CostCodeRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, CostCodeRecord record)
        {
            record.Id = dataRecord["COST_ID"].ConvertTo<String>();
            record.Lock = dataRecord["COST_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["COST_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["COST_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["COST_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["COST_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["COST_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["COST_RCV_FROM"].ConvertTo<String>();
            record.Code = dataRecord["COST_CODE"].ConvertTo<String>();
            record.Desc = dataRecord["COST_DESC"].ConvertTo<String>();
            record.SelcoSpId = dataRecord["COST_SELCO_SP_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CostCodeRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, CostCodeRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_COST_ID", record.Id);
            this.MapParameterIn(command, "@PA_COST_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_COST_CODE", record.Code);
            this.MapParameterIn(command, "@PA_COST_DESC", record.Desc);
            this.MapParameterIn(command, "@PA_COST_SELCO_SP_ID", record.SelcoSpId);
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
        ///     The <see cref="CostCodeRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, CostCodeRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_COST_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_COST_LOCK", record.Lock);
            record.Code = this.MapParameterOut(command, "@PA_COST_CODE", record.Code);
            record.Desc = this.MapParameterOut(command, "@PA_COST_DESC", record.Desc);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_COST_SELCO_SP_ID", record.SelcoSpId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CostCodeRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='CostCodeModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CostCodeRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<CostCodeRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_COST_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ICostCodeRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.CostCodeRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:CostCodeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.CostCodeRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.CostCodeRecord> ICostCodeRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        #endregion
    }
}
