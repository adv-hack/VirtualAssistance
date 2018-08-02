using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ProductEventRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerProductEventRepository : SqlServerRepository<ProductEventRecord, Int32>, IProductEventRepository
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
            get { return "ProductEvent"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ProductEventRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PE_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Product_Event"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ProductEventRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ProductEventRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ProductEventRecord record)
        {
            record.Id = dataRecord["PE_ID"].ConvertTo<Int32>();
            record.AddBy = dataRecord["PE_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["PE_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PE_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PE_MOD_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PE_RCV_FROM"].ConvertTo<String>();
            record.RcvDate = dataRecord["PE_RCV_DATE"].ConvertTo<DateTime?>();
            record.ProdId = dataRecord["PE_PROD_ID"].ConvertTo<String>();
            record.Instance = dataRecord["PE_INSTANCE"].ConvertTo<Int32>();
            record.AcadyCode = dataRecord["PE_ACADY_CODE"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ProductEventRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ProductEventRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PE_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_PE_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_PE_INSTANCE", record.Instance == Int32.MinValue ? 0 : record.Instance);
            this.MapParameterIn(command, "@PA_PE_ACADY_CODE", record.AcadyCode);
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
        ///     The <see cref="ProductEventRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ProductEventRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PE_ID", record.Id);
            record.ProdId = this.MapParameterOut(command, "@PA_PE_PROD_ID", record.ProdId);
            record.Instance = this.MapParameterOut(command, "@PA_PE_INSTANCE", record.Instance);
            record.AcadyCode = this.MapParameterOut(command, "@PA_PE_ACADY_CODE", record.AcadyCode);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductEventRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref='ProductEventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductEventRecord" /> instances that match the specified <paramref name='prodId' />.
        /// </returns>
        public IEnumerable<ProductEventRecord> FetchAllByProdId(String prodId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProdId");
            this.MapParameterIn(command, "@PA_PE_PROD_ID", prodId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IProductEventRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductEventRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:ProductEventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductEventRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductEventRecord> IProductEventRepository.FetchAllByProdId(System.String prodId)
        {
            return this.FetchAllByProdId(prodId);
        }

        #endregion
    }
}
