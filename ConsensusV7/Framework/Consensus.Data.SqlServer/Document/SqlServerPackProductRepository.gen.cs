using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ProductPackRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPackProductRepository : SqlServerRepository<ProductPackRecord, Int32>, IPackProductRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Document"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "ProductPack"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ProductPackRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PPA_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Product_Pack"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ProductPackRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ProductPackRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ProductPackRecord record)
        {
            record.Id = dataRecord["PPA_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["PPA_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["PPA_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PPA_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["PPA_MOD_BY"].ConvertTo<String>();
            record.ProdId = dataRecord["PPA_PROD_ID"].ConvertTo<String>();
            record.PackId = dataRecord["PPA_PACK_ID"].ConvertTo<String>();
            record.Type = dataRecord["PPA_TYPE"].ConvertTo<String>();
            record.Suppress = dataRecord["PPA_SUPPRESS"].ConvertTo<Byte>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ProductPackRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ProductPackRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PPA_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_PPA_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_PPA_PACK_ID", record.PackId);
            this.MapParameterIn(command, "@PA_PPA_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_PPA_SUPPRESS", record.Suppress);
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
        ///     The <see cref="ProductPackRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ProductPackRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PPA_ID", record.Id);
            record.ProdId = this.MapParameterOut(command, "@PA_PPA_PROD_ID", record.ProdId);
            record.PackId = this.MapParameterOut(command, "@PA_PPA_PACK_ID", record.PackId);
            record.Type = this.MapParameterOut(command, "@PA_PPA_TYPE", record.Type);
            record.Suppress = this.MapParameterOut(command, "@PA_PPA_SUPPRESS", record.Suppress);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductPackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref='PackProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductPackRecord" /> instances that match the specified <paramref name='prodId' />.
        /// </returns>
        public IEnumerable<ProductPackRecord> FetchAllByProdId(String prodId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProdId");
            this.MapParameterIn(command, "@PA_PPA_PROD_ID", prodId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductPackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref='PackProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductPackRecord" /> instances that match the specified <paramref name='packId' />.
        /// </returns>
        public IEnumerable<ProductPackRecord> FetchAllByPackId(String packId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PackId");
            this.MapParameterIn(command, "@PA_PPA_PACK_ID", packId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IPackProductRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.ProductPackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:PackProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.ProductPackRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ProductPackRecord> IPackProductRepository.FetchAllByProdId(System.String prodId)
        {
            return this.FetchAllByProdId(prodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.ProductPackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:PackProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.ProductPackRecord" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ProductPackRecord> IPackProductRepository.FetchAllByPackId(System.String packId)
        {
            return this.FetchAllByPackId(packId);
        }

        #endregion
    }
}
