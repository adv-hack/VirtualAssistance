using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ProdselectgroupsRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerProdSelectGroupRepository : SqlServerRepository<ProdselectgroupsRecord, Int32>, IProdSelectGroupRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Learning"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Prodselectgroups"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ProdselectgroupsRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PSG_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "ProdSelectGroups"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ProdselectgroupsRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ProdselectgroupsRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ProdselectgroupsRecord record)
        {
            record.Id = dataRecord["PSG_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["PSG_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["PSG_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PSG_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["PSG_MOD_BY"].ConvertTo<String>();
            record.Product = dataRecord["PSG_PROD_ID"].ConvertTo<String>();
            record.Type = dataRecord["PSG_TYPE"].ConvertTo<Byte>();
            record.Name = dataRecord["PSG_NAME"].ConvertTo<String>();
            record.Description = dataRecord["PSG_DESCRIPTION"].ConvertTo<String>();
            record.Min = dataRecord["PSG_MIN"].ConvertTo<Byte>();
            record.Max = dataRecord["PSG_MAX"].ConvertTo<Byte>();
            record.Order = dataRecord["PSG_ORDER"].ConvertTo<Byte>();
            record.ErrorMessage = dataRecord["PSG_ERROR_MESSAGE"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ProdselectgroupsRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ProdselectgroupsRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PSG_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_PSG_PROD_ID", record.Product);
            this.MapParameterIn(command, "@PA_PSG_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_PSG_NAME", record.Name);
            this.MapParameterIn(command, "@PA_PSG_DESCRIPTION", record.Description);
            this.MapParameterIn(command, "@PA_PSG_MIN", record.Min);
            this.MapParameterIn(command, "@PA_PSG_MAX", record.Max);
            this.MapParameterIn(command, "@PA_PSG_ORDER", record.Order);
            this.MapParameterIn(command, "@PA_PSG_ERROR_MESSAGE", record.ErrorMessage);
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
        ///     The <see cref="ProdselectgroupsRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ProdselectgroupsRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PSG_ID", record.Id);
            record.Product = this.MapParameterOut(command, "@PA_PSG_PROD_ID", record.Product);
            record.Type = this.MapParameterOut(command, "@PA_PSG_TYPE", record.Type);
            record.Name = this.MapParameterOut(command, "@PA_PSG_NAME", record.Name);
            record.Description = this.MapParameterOut(command, "@PA_PSG_DESCRIPTION", record.Description);
            record.Min = this.MapParameterOut(command, "@PA_PSG_MIN", record.Min);
            record.Max = this.MapParameterOut(command, "@PA_PSG_MAX", record.Max);
            record.Order = this.MapParameterOut(command, "@PA_PSG_ORDER", record.Order);
            record.ErrorMessage = this.MapParameterOut(command, "@PA_PSG_ERROR_MESSAGE", record.ErrorMessage);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProdselectgroupsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="product">
        ///     The value which identifies the <see cref='ProdSelectGroupModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProdselectgroupsRecord" /> instances that match the specified <paramref name='product' />.
        /// </returns>
        public IEnumerable<ProdselectgroupsRecord> FetchAllByProduct(String product)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "Product");
            this.MapParameterIn(command, "@PA_PSG_PROD_ID", product);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IProdSelectGroupRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProdselectgroupsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="product">
        ///     The value which identifies the <see cref="!:ProdSelectGroupModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProdselectgroupsRecord" /> instances that match the specified <paramref name="product" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProdselectgroupsRecord> IProdSelectGroupRepository.FetchAllByProduct(System.String product)
        {
            return this.FetchAllByProduct(product);
        }

        #endregion
    }
}
