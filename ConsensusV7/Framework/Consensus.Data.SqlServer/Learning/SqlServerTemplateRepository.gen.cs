using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="TemplateXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerTemplateRepository : SqlServerRepository<TemplateXrefRecord, String>, ITemplateRepository
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
            get { return "TemplateXref"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="TemplateXrefRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_TXREF_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Template_Xref"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="TemplateXrefRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="TemplateXrefRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, TemplateXrefRecord record)
        {
            record.Id = dataRecord["TXREF_ID"].ConvertTo<String>();
            record.Lock = dataRecord["TXREF_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["TXREF_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["TXREF_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["TXREF_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["TXREF_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["TXREF_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["TXREF_RCV_FROM"].ConvertTo<String>();
            record.BomId = dataRecord["TXREF_BOM_ID"].ConvertTo<String>();
            record.ProdId = dataRecord["TXREF_PROD_ID"].ConvertTo<String>();
            record.Usage = dataRecord["TXREF_USAGE"].ConvertTo<Byte?>();
            record.Qty = dataRecord["TXREF_QTY"].ConvertTo<Double?>();
            record.DelQty = dataRecord["TXREF_DEL_QTY"].ConvertTo<Double?>();
            record.PerDay = dataRecord["TXREF_PER_DAY"].ConvertTo<Byte?>();
            record.ArgId = dataRecord["TXREF_ARG_ID"].ConvertTo<String>();
            record.Type = dataRecord["TXREF_TYPE"].ConvertTo<Byte>();
            record.ProfKey = dataRecord["TXREF_PROF_KEY"].ConvertTo<String>();
            record.ProfValue = dataRecord["TXREF_PROF_VALUE"].ConvertTo<String>();
            record.ProfValue2 = dataRecord["TXREF_PROF_VALUE2"].ConvertTo<String>();
            record.Ratio = dataRecord["TXREF_RATIO"].ConvertTo<Int32>();
            record.UntType = dataRecord["TXREF_UNT_TYPE"].ConvertTo<String>();
            record.Trainer = dataRecord["TXREF_TRAINER"].ConvertTo<Byte?>();
            record.Cost = dataRecord["TXREF_COST"].ConvertTo<Decimal>();
            record.RoomType = dataRecord["TXREF_ROOM_TYPE"].ConvertTo<String>();
            record.IncInBudget = dataRecord["TXREF_INC_IN_BUDGET"].ConvertTo<Byte>();
            record.TrainProleId = dataRecord["TXREF_TRAIN_PROLE_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="TemplateXrefRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, TemplateXrefRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_TXREF_ID", record.Id);
            this.MapParameterIn(command, "@PA_TXREF_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_TXREF_BOM_ID", record.BomId);
            this.MapParameterIn(command, "@PA_TXREF_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_TXREF_USAGE", record.Usage);
            this.MapParameterIn(command, "@PA_TXREF_QTY", record.Qty == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Qty);
            this.MapParameterIn(command, "@PA_TXREF_DEL_QTY", record.DelQty == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.DelQty);
            this.MapParameterIn(command, "@PA_TXREF_PER_DAY", record.PerDay);
            this.MapParameterIn(command, "@PA_TXREF_ARG_ID", record.ArgId);
            this.MapParameterIn(command, "@PA_TXREF_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_TXREF_PROF_KEY", record.ProfKey);
            this.MapParameterIn(command, "@PA_TXREF_PROF_VALUE", record.ProfValue);
            this.MapParameterIn(command, "@PA_TXREF_PROF_VALUE2", record.ProfValue2);
            this.MapParameterIn(command, "@PA_TXREF_RATIO", record.Ratio == Int32.MinValue ? 1 : record.Ratio);
            this.MapParameterIn(command, "@PA_TXREF_UNT_TYPE", record.UntType);
            this.MapParameterIn(command, "@PA_TXREF_TRAINER", record.Trainer);
            this.MapParameterIn(command, "@PA_TXREF_COST", record.Cost == Decimal.MinValue ? 0M : record.Cost);
            this.MapParameterIn(command, "@PA_TXREF_ROOM_TYPE", record.RoomType);
            this.MapParameterIn(command, "@PA_TXREF_INC_IN_BUDGET", record.IncInBudget);
            this.MapParameterIn(command, "@PA_TXREF_TRAIN_PROLE_ID", record.TrainProleId);
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
        ///     The <see cref="TemplateXrefRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, TemplateXrefRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_TXREF_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_TXREF_LOCK", record.Lock);
            record.BomId = this.MapParameterOut(command, "@PA_TXREF_BOM_ID", record.BomId);
            record.ProdId = this.MapParameterOut(command, "@PA_TXREF_PROD_ID", record.ProdId);
            record.Usage = this.MapParameterOut(command, "@PA_TXREF_USAGE", record.Usage);
            record.Qty = this.MapParameterOut(command, "@PA_TXREF_QTY", record.Qty);
            record.DelQty = this.MapParameterOut(command, "@PA_TXREF_DEL_QTY", record.DelQty);
            record.PerDay = this.MapParameterOut(command, "@PA_TXREF_PER_DAY", record.PerDay);
            record.ArgId = this.MapParameterOut(command, "@PA_TXREF_ARG_ID", record.ArgId);
            record.Type = this.MapParameterOut(command, "@PA_TXREF_TYPE", record.Type);
            record.ProfKey = this.MapParameterOut(command, "@PA_TXREF_PROF_KEY", record.ProfKey);
            record.ProfValue = this.MapParameterOut(command, "@PA_TXREF_PROF_VALUE", record.ProfValue);
            record.ProfValue2 = this.MapParameterOut(command, "@PA_TXREF_PROF_VALUE2", record.ProfValue2);
            record.Ratio = this.MapParameterOut(command, "@PA_TXREF_RATIO", record.Ratio);
            record.UntType = this.MapParameterOut(command, "@PA_TXREF_UNT_TYPE", record.UntType);
            record.Trainer = this.MapParameterOut(command, "@PA_TXREF_TRAINER", record.Trainer);
            record.Cost = this.MapParameterOut(command, "@PA_TXREF_COST", record.Cost);
            record.RoomType = this.MapParameterOut(command, "@PA_TXREF_ROOM_TYPE", record.RoomType);
            record.IncInBudget = this.MapParameterOut(command, "@PA_TXREF_INC_IN_BUDGET", record.IncInBudget);
            record.TrainProleId = this.MapParameterOut(command, "@PA_TXREF_TRAIN_PROLE_ID", record.TrainProleId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="TemplateXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bomId">
        ///     The value which identifies the <see cref='TemplateModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="TemplateXrefRecord" /> instances that match the specified <paramref name='bomId' />.
        /// </returns>
        public IEnumerable<TemplateXrefRecord> FetchAllByBomId(String bomId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "BomId");
            this.MapParameterIn(command, "@PA_TXREF_BOM_ID", bomId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="TemplateXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref='TemplateModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="TemplateXrefRecord" /> instances that match the specified <paramref name='prodId' />.
        /// </returns>
        public IEnumerable<TemplateXrefRecord> FetchAllByProdId(String prodId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProdId");
            this.MapParameterIn(command, "@PA_TXREF_PROD_ID", prodId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="TemplateXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="trainProleId">
        ///     The value which identifies the <see cref='TemplateModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="TemplateXrefRecord" /> instances that match the specified <paramref name='trainProleId' />.
        /// </returns>
        public IEnumerable<TemplateXrefRecord> FetchAllByTrainProleId(String trainProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "TrainProleId");
            this.MapParameterIn(command, "@PA_TXREF_TRAIN_PROLE_ID", trainProleId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ITemplateRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.TemplateXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bomId">
        ///     The value which identifies the <see cref="!:TemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.TemplateXrefRecord" /> instances that match the specified <paramref name="bomId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.TemplateXrefRecord> ITemplateRepository.FetchAllByBomId(System.String bomId)
        {
            return this.FetchAllByBomId(bomId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.TemplateXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:TemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.TemplateXrefRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.TemplateXrefRecord> ITemplateRepository.FetchAllByProdId(System.String prodId)
        {
            return this.FetchAllByProdId(prodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.TemplateXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="trainProleId">
        ///     The value which identifies the <see cref="!:TemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.TemplateXrefRecord" /> instances that match the specified <paramref name="trainProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.TemplateXrefRecord> ITemplateRepository.FetchAllByTrainProleId(System.String trainProleId)
        {
            return this.FetchAllByTrainProleId(trainProleId);
        }

        #endregion
    }
}
