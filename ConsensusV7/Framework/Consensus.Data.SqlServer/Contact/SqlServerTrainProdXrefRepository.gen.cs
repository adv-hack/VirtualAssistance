using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="TrainProdXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerTrainProdXrefRepository : SqlServerRepository<TrainProdXrefRecord, String>, ITrainProdXrefRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Contact"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "TrainProdXref"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="TrainProdXrefRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_TPXREF_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "TRAIN_PROD_XREF"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="TrainProdXrefRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="TrainProdXrefRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, TrainProdXrefRecord record)
        {
            record.Id = dataRecord["TPXREF_ID"].ConvertTo<String>();
            record.AddBy = dataRecord["TPXREF_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["TPXREF_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["TPXREF_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["TPXREF_MOD_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["TPXREF_RCV_FROM"].ConvertTo<String>();
            record.RcvDate = dataRecord["TPXREF_RCV_DATE"].ConvertTo<DateTime?>();
            record.TrainId = dataRecord["TPXREF_TRAIN_ID"].ConvertTo<String>();
            record.LocId = dataRecord["TPXREF_LOC_ID"].ConvertTo<String>();
            record.ProdId = dataRecord["TPXREF_PROD_ID"].ConvertTo<String>();
            record.StartDate = dataRecord["TPXREF_START_DATE"].ConvertTo<DateTime?>();
            record.EndDate = dataRecord["TPXREF_END_DATE"].ConvertTo<DateTime?>();
            record.Status = dataRecord["TPXREF_STATUS"].ConvertTo<String>();
            record.Grade = dataRecord["TPXREF_GRADE"].ConvertTo<String>();
            record.Notes = dataRecord["TPXREF_NOTES"].ConvertTo<String>();
            record.Cost = dataRecord["TPXREF_COST"].ConvertTo<Decimal?>();
            record.Userchar1 = dataRecord["TPXREF_USERCHAR_1"].ConvertTo<String>();
            record.Userchar2 = dataRecord["TPXREF_USERCHAR_2"].ConvertTo<String>();
            record.Userchar3 = dataRecord["TPXREF_USERCHAR_3"].ConvertTo<String>();
            record.Userchar4 = dataRecord["TPXREF_USERCHAR_4"].ConvertTo<String>();
            record.Userchar5 = dataRecord["TPXREF_USERCHAR_5"].ConvertTo<String>();
            record.Userchar6 = dataRecord["TPXREF_USERCHAR_6"].ConvertTo<String>();
            record.Userint1 = dataRecord["TPXREF_USERINT_1"].ConvertTo<Byte?>();
            record.Userint2 = dataRecord["TPXREF_USERINT_2"].ConvertTo<Byte?>();
            record.Userint3 = dataRecord["TPXREF_USERINT_3"].ConvertTo<Byte?>();
            record.Userint4 = dataRecord["TPXREF_USERINT_4"].ConvertTo<Byte?>();
            record.Userint5 = dataRecord["TPXREF_USERINT_5"].ConvertTo<Byte?>();
            record.Userint6 = dataRecord["TPXREF_USERINT_6"].ConvertTo<Byte?>();
            record.Usernum1 = dataRecord["TPXREF_USERNUM_1"].ConvertTo<Decimal?>();
            record.Usernum2 = dataRecord["TPXREF_USERNUM_2"].ConvertTo<Decimal?>();
            record.Usernum3 = dataRecord["TPXREF_USERNUM_3"].ConvertTo<Decimal?>();
            record.Usernum4 = dataRecord["TPXREF_USERNUM_4"].ConvertTo<Decimal?>();
            record.Usernum5 = dataRecord["TPXREF_USERNUM_5"].ConvertTo<Decimal?>();
            record.Usernum6 = dataRecord["TPXREF_USERNUM_6"].ConvertTo<Decimal?>();
            record.Userdate1 = dataRecord["TPXREF_USERDATE_1"].ConvertTo<DateTime?>();
            record.Userdate2 = dataRecord["TPXREF_USERDATE_2"].ConvertTo<DateTime?>();
            record.Userdate3 = dataRecord["TPXREF_USERDATE_3"].ConvertTo<DateTime?>();
            record.Userdate4 = dataRecord["TPXREF_USERDATE_4"].ConvertTo<DateTime?>();
            record.Userdate5 = dataRecord["TPXREF_USERDATE_5"].ConvertTo<DateTime?>();
            record.Userdate6 = dataRecord["TPXREF_USERDATE_6"].ConvertTo<DateTime?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="TrainProdXrefRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, TrainProdXrefRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_TPXREF_ID", record.Id);
            this.MapParameterIn(command, "@PA_TPXREF_TRAIN_ID", record.TrainId);
            this.MapParameterIn(command, "@PA_TPXREF_LOC_ID", record.LocId);
            this.MapParameterIn(command, "@PA_TPXREF_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_TPXREF_START_DATE", record.StartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDate);
            this.MapParameterIn(command, "@PA_TPXREF_END_DATE", record.EndDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndDate);
            this.MapParameterIn(command, "@PA_TPXREF_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_TPXREF_GRADE", record.Grade);
            this.MapParameterIn(command, "@PA_TPXREF_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_TPXREF_COST", record.Cost == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Cost);
            this.MapParameterIn(command, "@PA_TPXREF_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_TPXREF_USERCHAR_2", record.Userchar2);
            this.MapParameterIn(command, "@PA_TPXREF_USERCHAR_3", record.Userchar3);
            this.MapParameterIn(command, "@PA_TPXREF_USERCHAR_4", record.Userchar4);
            this.MapParameterIn(command, "@PA_TPXREF_USERCHAR_5", record.Userchar5);
            this.MapParameterIn(command, "@PA_TPXREF_USERCHAR_6", record.Userchar6);
            this.MapParameterIn(command, "@PA_TPXREF_USERINT_1", record.Userint1);
            this.MapParameterIn(command, "@PA_TPXREF_USERINT_2", record.Userint2);
            this.MapParameterIn(command, "@PA_TPXREF_USERINT_3", record.Userint3);
            this.MapParameterIn(command, "@PA_TPXREF_USERINT_4", record.Userint4);
            this.MapParameterIn(command, "@PA_TPXREF_USERINT_5", record.Userint5);
            this.MapParameterIn(command, "@PA_TPXREF_USERINT_6", record.Userint6);
            this.MapParameterIn(command, "@PA_TPXREF_USERNUM_1", record.Usernum1 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum1);
            this.MapParameterIn(command, "@PA_TPXREF_USERNUM_2", record.Usernum2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum2);
            this.MapParameterIn(command, "@PA_TPXREF_USERNUM_3", record.Usernum3 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum3);
            this.MapParameterIn(command, "@PA_TPXREF_USERNUM_4", record.Usernum4 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum4);
            this.MapParameterIn(command, "@PA_TPXREF_USERNUM_5", record.Usernum5 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum5);
            this.MapParameterIn(command, "@PA_TPXREF_USERNUM_6", record.Usernum6 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum6);
            this.MapParameterIn(command, "@PA_TPXREF_USERDATE_1", record.Userdate1 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate1);
            this.MapParameterIn(command, "@PA_TPXREF_USERDATE_2", record.Userdate2 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate2);
            this.MapParameterIn(command, "@PA_TPXREF_USERDATE_3", record.Userdate3 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate3);
            this.MapParameterIn(command, "@PA_TPXREF_USERDATE_4", record.Userdate4 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate4);
            this.MapParameterIn(command, "@PA_TPXREF_USERDATE_5", record.Userdate5 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate5);
            this.MapParameterIn(command, "@PA_TPXREF_USERDATE_6", record.Userdate6 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate6);
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
        ///     The <see cref="TrainProdXrefRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, TrainProdXrefRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_TPXREF_ID", record.Id);
            record.TrainId = this.MapParameterOut(command, "@PA_TPXREF_TRAIN_ID", record.TrainId);
            record.LocId = this.MapParameterOut(command, "@PA_TPXREF_LOC_ID", record.LocId);
            record.ProdId = this.MapParameterOut(command, "@PA_TPXREF_PROD_ID", record.ProdId);
            record.StartDate = this.MapParameterOut(command, "@PA_TPXREF_START_DATE", record.StartDate);
            record.EndDate = this.MapParameterOut(command, "@PA_TPXREF_END_DATE", record.EndDate);
            record.Status = this.MapParameterOut(command, "@PA_TPXREF_STATUS", record.Status);
            record.Grade = this.MapParameterOut(command, "@PA_TPXREF_GRADE", record.Grade);
            record.Notes = this.MapParameterOut(command, "@PA_TPXREF_NOTES", record.Notes);
            record.Cost = this.MapParameterOut(command, "@PA_TPXREF_COST", record.Cost);
            record.Userchar1 = this.MapParameterOut(command, "@PA_TPXREF_USERCHAR_1", record.Userchar1);
            record.Userchar2 = this.MapParameterOut(command, "@PA_TPXREF_USERCHAR_2", record.Userchar2);
            record.Userchar3 = this.MapParameterOut(command, "@PA_TPXREF_USERCHAR_3", record.Userchar3);
            record.Userchar4 = this.MapParameterOut(command, "@PA_TPXREF_USERCHAR_4", record.Userchar4);
            record.Userchar5 = this.MapParameterOut(command, "@PA_TPXREF_USERCHAR_5", record.Userchar5);
            record.Userchar6 = this.MapParameterOut(command, "@PA_TPXREF_USERCHAR_6", record.Userchar6);
            record.Userint1 = this.MapParameterOut(command, "@PA_TPXREF_USERINT_1", record.Userint1);
            record.Userint2 = this.MapParameterOut(command, "@PA_TPXREF_USERINT_2", record.Userint2);
            record.Userint3 = this.MapParameterOut(command, "@PA_TPXREF_USERINT_3", record.Userint3);
            record.Userint4 = this.MapParameterOut(command, "@PA_TPXREF_USERINT_4", record.Userint4);
            record.Userint5 = this.MapParameterOut(command, "@PA_TPXREF_USERINT_5", record.Userint5);
            record.Userint6 = this.MapParameterOut(command, "@PA_TPXREF_USERINT_6", record.Userint6);
            record.Usernum1 = this.MapParameterOut(command, "@PA_TPXREF_USERNUM_1", record.Usernum1);
            record.Usernum2 = this.MapParameterOut(command, "@PA_TPXREF_USERNUM_2", record.Usernum2);
            record.Usernum3 = this.MapParameterOut(command, "@PA_TPXREF_USERNUM_3", record.Usernum3);
            record.Usernum4 = this.MapParameterOut(command, "@PA_TPXREF_USERNUM_4", record.Usernum4);
            record.Usernum5 = this.MapParameterOut(command, "@PA_TPXREF_USERNUM_5", record.Usernum5);
            record.Usernum6 = this.MapParameterOut(command, "@PA_TPXREF_USERNUM_6", record.Usernum6);
            record.Userdate1 = this.MapParameterOut(command, "@PA_TPXREF_USERDATE_1", record.Userdate1);
            record.Userdate2 = this.MapParameterOut(command, "@PA_TPXREF_USERDATE_2", record.Userdate2);
            record.Userdate3 = this.MapParameterOut(command, "@PA_TPXREF_USERDATE_3", record.Userdate3);
            record.Userdate4 = this.MapParameterOut(command, "@PA_TPXREF_USERDATE_4", record.Userdate4);
            record.Userdate5 = this.MapParameterOut(command, "@PA_TPXREF_USERDATE_5", record.Userdate5);
            record.Userdate6 = this.MapParameterOut(command, "@PA_TPXREF_USERDATE_6", record.Userdate6);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="TrainProdXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="trainId">
        ///     The value which identifies the <see cref='TrainProdXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="TrainProdXrefRecord" /> instances that match the specified <paramref name='trainId' />.
        /// </returns>
        public IEnumerable<TrainProdXrefRecord> FetchAllByTrainId(String trainId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "TrainId");
            this.MapParameterIn(command, "@PA_TPXREF_TRAIN_ID", trainId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="TrainProdXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref='TrainProdXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="TrainProdXrefRecord" /> instances that match the specified <paramref name='prodId' />.
        /// </returns>
        public IEnumerable<TrainProdXrefRecord> FetchAllByProdId(String prodId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProdId");
            this.MapParameterIn(command, "@PA_TPXREF_PROD_ID", prodId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ITrainProdXrefRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.TrainProdXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="trainId">
        ///     The value which identifies the <see cref="!:TrainProdXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.TrainProdXrefRecord" /> instances that match the specified <paramref name="trainId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.TrainProdXrefRecord> ITrainProdXrefRepository.FetchAllByTrainId(System.String trainId)
        {
            return this.FetchAllByTrainId(trainId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.TrainProdXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:TrainProdXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.TrainProdXrefRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.TrainProdXrefRecord> ITrainProdXrefRepository.FetchAllByProdId(System.String prodId)
        {
            return this.FetchAllByProdId(prodId);
        }

        #endregion
    }
}
