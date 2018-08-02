using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SaqStepRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSaqStepRepository : SqlServerRepository<SaqStepRecord, Int64>, ISaqStepRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Marketing"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "SaqStep"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SaqStepRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_STEP_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "SAQ_STEP"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SaqStepRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SaqStepRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SaqStepRecord record)
        {
            record.Id = dataRecord["STEP_ID"].ConvertTo<Int64>();
            record.AddBy = dataRecord["STEP_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["STEP_ADD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["STEP_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["STEP_MOD_DATE"].ConvertTo<DateTime>();
            record.ProleId = dataRecord["STEP_PROLE_ID"].ConvertTo<String>();
            record.Visibility = dataRecord["STEP_VISIBILITY"].ConvertTo<Byte>();
            record.Name = dataRecord["STEP_NAME"].ConvertTo<String>();
            record.Desc = dataRecord["STEP_DESC"].ConvertTo<String>();
            record.ResultSizeOpt = dataRecord["STEP_RESULT_SIZE_OPT"].ConvertTo<Byte>();
            record.ResultSize = dataRecord["STEP_RESULT_SIZE"].ConvertTo<Int64>();
            record.InUse = dataRecord["STEP_IN_USE"].ConvertTo<Byte>();
            record.OrgOnly = dataRecord["STEP_ORG_ONLY"].ConvertTo<Byte>();
            record.Locked = dataRecord["STEP_LOCKED"].ConvertTo<Byte>();
            record.BookOnly = dataRecord["STEP_BOOK_ONLY"].ConvertTo<Byte>();
            record.LinkDefault = dataRecord["STEP_LINK_DEFAULT"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SaqStepRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SaqStepRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_STEP_ID", record.Id == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_STEP_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_STEP_VISIBILITY", record.Visibility);
            this.MapParameterIn(command, "@PA_STEP_NAME", record.Name);
            this.MapParameterIn(command, "@PA_STEP_DESC", record.Desc);
            this.MapParameterIn(command, "@PA_STEP_RESULT_SIZE_OPT", record.ResultSizeOpt);
            this.MapParameterIn(command, "@PA_STEP_RESULT_SIZE", record.ResultSize == Int64.MinValue ? 0 : record.ResultSize);
            this.MapParameterIn(command, "@PA_STEP_IN_USE", record.InUse);
            this.MapParameterIn(command, "@PA_STEP_ORG_ONLY", record.OrgOnly);
            this.MapParameterIn(command, "@PA_STEP_LOCKED", record.Locked);
            this.MapParameterIn(command, "@PA_STEP_BOOK_ONLY", record.BookOnly);
            this.MapParameterIn(command, "@PA_STEP_LINK_DEFAULT", record.LinkDefault);
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
        ///     The <see cref="SaqStepRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SaqStepRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_STEP_ID", record.Id);
            record.ProleId = this.MapParameterOut(command, "@PA_STEP_PROLE_ID", record.ProleId);
            record.Visibility = this.MapParameterOut(command, "@PA_STEP_VISIBILITY", record.Visibility);
            record.Name = this.MapParameterOut(command, "@PA_STEP_NAME", record.Name);
            record.Desc = this.MapParameterOut(command, "@PA_STEP_DESC", record.Desc);
            record.ResultSizeOpt = this.MapParameterOut(command, "@PA_STEP_RESULT_SIZE_OPT", record.ResultSizeOpt);
            record.ResultSize = this.MapParameterOut(command, "@PA_STEP_RESULT_SIZE", record.ResultSize);
            record.InUse = this.MapParameterOut(command, "@PA_STEP_IN_USE", record.InUse);
            record.OrgOnly = this.MapParameterOut(command, "@PA_STEP_ORG_ONLY", record.OrgOnly);
            record.Locked = this.MapParameterOut(command, "@PA_STEP_LOCKED", record.Locked);
            record.BookOnly = this.MapParameterOut(command, "@PA_STEP_BOOK_ONLY", record.BookOnly);
            record.LinkDefault = this.MapParameterOut(command, "@PA_STEP_LINK_DEFAULT", record.LinkDefault);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SaqStepRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref='SaqStepModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SaqStepRecord" /> instances that match the specified <paramref name='proleId' />.
        /// </returns>
        public IEnumerable<SaqStepRecord> FetchAllByProleId(String proleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProleId");
            this.MapParameterIn(command, "@PA_STEP_PROLE_ID", proleId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISaqStepRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqStepRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:SaqStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqStepRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqStepRecord> ISaqStepRepository.FetchAllByProleId(System.String proleId)
        {
            return this.FetchAllByProleId(proleId);
        }

        #endregion
    }
}
