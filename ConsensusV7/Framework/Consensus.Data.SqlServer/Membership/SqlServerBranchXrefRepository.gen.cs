using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="BranchXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerBranchXrefRepository : SqlServerRepository<BranchXrefRecord, String>, IBranchXrefRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Membership"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "BranchXref"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="BranchXrefRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_BRXREF_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Branch_Xref"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="BranchXrefRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="BranchXrefRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, BranchXrefRecord record)
        {
            record.Id = dataRecord["BRXREF_ID"].ConvertTo<String>();
            record.AddBy = dataRecord["BRXREF_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["BRXREF_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["BRXREF_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["BRXREF_MOD_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["BRXREF_RCV_FROM"].ConvertTo<String>();
            record.RcvDate = dataRecord["BRXREF_RCV_DATE"].ConvertTo<DateTime?>();
            record.BrId = dataRecord["BRXREF_BR_ID"].ConvertTo<String>();
            record.TableName = dataRecord["BRXREF_TABLE_NAME"].ConvertTo<String>();
            record.RecordId = dataRecord["BRXREF_RECORD_ID"].ConvertTo<String>();
            record.Disabled = dataRecord["BRXREF_DISABLED"].ConvertTo<Byte?>();
            record.Position = dataRecord["BRXREF_POSITION"].ConvertTo<String>();
            record.District = dataRecord["BRXREF_DISTRICT"].ConvertTo<String>();
            record.DisId = dataRecord["BRXREF_DIS_ID"].ConvertTo<String>();
            record.Status = dataRecord["BRXREF_STATUS"].ConvertTo<String>();
            record.StartDate = dataRecord["BRXREF_START_DATE"].ConvertTo<DateTime?>();
            record.EndDate = dataRecord["BRXREF_END_DATE"].ConvertTo<DateTime?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="BranchXrefRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, BranchXrefRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_BRXREF_ID", record.Id);
            this.MapParameterIn(command, "@PA_BRXREF_BR_ID", record.BrId);
            this.MapParameterIn(command, "@PA_BRXREF_TABLE_NAME", record.TableName);
            this.MapParameterIn(command, "@PA_BRXREF_RECORD_ID", record.RecordId);
            this.MapParameterIn(command, "@PA_BRXREF_DISABLED", record.Disabled);
            this.MapParameterIn(command, "@PA_BRXREF_POSITION", record.Position);
            this.MapParameterIn(command, "@PA_BRXREF_DISTRICT", record.District);
            this.MapParameterIn(command, "@PA_BRXREF_DIS_ID", record.DisId);
            this.MapParameterIn(command, "@PA_BRXREF_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_BRXREF_START_DATE", record.StartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDate);
            this.MapParameterIn(command, "@PA_BRXREF_END_DATE", record.EndDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndDate);
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
        ///     The <see cref="BranchXrefRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, BranchXrefRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_BRXREF_ID", record.Id);
            record.BrId = this.MapParameterOut(command, "@PA_BRXREF_BR_ID", record.BrId);
            record.TableName = this.MapParameterOut(command, "@PA_BRXREF_TABLE_NAME", record.TableName);
            record.RecordId = this.MapParameterOut(command, "@PA_BRXREF_RECORD_ID", record.RecordId);
            record.Disabled = this.MapParameterOut(command, "@PA_BRXREF_DISABLED", record.Disabled);
            record.Position = this.MapParameterOut(command, "@PA_BRXREF_POSITION", record.Position);
            record.District = this.MapParameterOut(command, "@PA_BRXREF_DISTRICT", record.District);
            record.DisId = this.MapParameterOut(command, "@PA_BRXREF_DIS_ID", record.DisId);
            record.Status = this.MapParameterOut(command, "@PA_BRXREF_STATUS", record.Status);
            record.StartDate = this.MapParameterOut(command, "@PA_BRXREF_START_DATE", record.StartDate);
            record.EndDate = this.MapParameterOut(command, "@PA_BRXREF_END_DATE", record.EndDate);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BranchXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="brId">
        ///     The value which identifies the <see cref='BranchXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BranchXrefRecord" /> instances that match the specified <paramref name='brId' />.
        /// </returns>
        public IEnumerable<BranchXrefRecord> FetchAllByBrId(String brId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "BrId");
            this.MapParameterIn(command, "@PA_BRXREF_BR_ID", brId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IBranchXrefRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.BranchXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="brId">
        ///     The value which identifies the <see cref="!:BranchXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.BranchXrefRecord" /> instances that match the specified <paramref name="brId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.BranchXrefRecord> IBranchXrefRepository.FetchAllByBrId(System.String brId)
        {
            return this.FetchAllByBrId(brId);
        }

        #endregion
    }
}
