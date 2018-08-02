using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ProductProdXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerRelatedProductRepository : SqlServerRepository<ProductProdXrefRecord, Int32>, IRelatedProductRepository
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
            get { return "ProductProdXref"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ProductProdXrefRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PPX_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Product_Prod_Xref"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ProductProdXrefRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ProductProdXrefRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ProductProdXrefRecord record)
        {
            record.Id = dataRecord["PPX_ID"].ConvertTo<Int32>();
            record.AddBy = dataRecord["PPX_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["PPX_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PPX_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PPX_MOD_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PPX_RCV_FROM"].ConvertTo<String>();
            record.RcvDate = dataRecord["PPX_RCV_DATE"].ConvertTo<DateTime?>();
            record.MastProdId = dataRecord["PPX_MAST_PROD_ID"].ConvertTo<String>();
            record.RelatedProdId = dataRecord["PPX_SIM_PROD_ID"].ConvertTo<String>();
            record.Notes = dataRecord["PPX_NOTES"].ConvertTo<String>();
            record.Prereq = dataRecord["PPX_PREREQ"].ConvertTo<Byte>();
            record.SchnId = dataRecord["PPX_SCHN_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ProductProdXrefRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ProductProdXrefRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PPX_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_PPX_MAST_PROD_ID", record.MastProdId);
            this.MapParameterIn(command, "@PA_PPX_SIM_PROD_ID", record.RelatedProdId);
            this.MapParameterIn(command, "@PA_PPX_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_PPX_PREREQ", record.Prereq);
            this.MapParameterIn(command, "@PA_PPX_SCHN_ID", record.SchnId);
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
        ///     The <see cref="ProductProdXrefRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ProductProdXrefRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PPX_ID", record.Id);
            record.MastProdId = this.MapParameterOut(command, "@PA_PPX_MAST_PROD_ID", record.MastProdId);
            record.RelatedProdId = this.MapParameterOut(command, "@PA_PPX_SIM_PROD_ID", record.RelatedProdId);
            record.Notes = this.MapParameterOut(command, "@PA_PPX_NOTES", record.Notes);
            record.Prereq = this.MapParameterOut(command, "@PA_PPX_PREREQ", record.Prereq);
            record.SchnId = this.MapParameterOut(command, "@PA_PPX_SCHN_ID", record.SchnId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductProdXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="relatedProdId">
        ///     The value which identifies the <see cref='RelatedProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductProdXrefRecord" /> instances that match the specified <paramref name='relatedProdId' />.
        /// </returns>
        public IEnumerable<ProductProdXrefRecord> FetchAllByRelatedProdId(String relatedProdId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "RelatedProdId");
            this.MapParameterIn(command, "@PA_PPX_SIM_PROD_ID", relatedProdId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductProdXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="schnId">
        ///     The value which identifies the <see cref='RelatedProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductProdXrefRecord" /> instances that match the specified <paramref name='schnId' />.
        /// </returns>
        public IEnumerable<ProductProdXrefRecord> FetchAllBySchnId(String schnId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SchnId");
            this.MapParameterIn(command, "@PA_PPX_SCHN_ID", schnId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IRelatedProductRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductProdXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="relatedProdId">
        ///     The value which identifies the <see cref="!:RelatedProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductProdXrefRecord" /> instances that match the specified <paramref name="relatedProdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductProdXrefRecord> IRelatedProductRepository.FetchAllByRelatedProdId(System.String relatedProdId)
        {
            return this.FetchAllByRelatedProdId(relatedProdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductProdXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="schnId">
        ///     The value which identifies the <see cref="!:RelatedProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductProdXrefRecord" /> instances that match the specified <paramref name="schnId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductProdXrefRecord> IRelatedProductRepository.FetchAllBySchnId(System.String schnId)
        {
            return this.FetchAllBySchnId(schnId);
        }

        #endregion
    }
}
