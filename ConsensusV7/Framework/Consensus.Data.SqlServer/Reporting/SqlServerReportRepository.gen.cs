using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ReportRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerReportRepository : SqlServerRepository<ReportRecord, String>, IReportRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Reporting"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Report"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ReportRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_REP_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Report"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ReportRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ReportRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ReportRecord record)
        {
            record.Id = dataRecord["REP_ID"].ConvertTo<String>();
            record.Lock = dataRecord["REP_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["REP_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["REP_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["REP_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["REP_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["REP_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["REP_RCV_FROM"].ConvertTo<String>();
            record.Description = dataRecord["REP_DESCRIPTION"].ConvertTo<String>();
            record.Name = dataRecord["REP_NAME"].ConvertTo<String>();
            record.Cat = dataRecord["REP_CAT"].ConvertTo<String>();
            record.Type = dataRecord["REP_TYPE"].ConvertTo<String>();
            record.Notes = dataRecord["REP_NOTES"].ConvertTo<String>();
            record.Level = dataRecord["REP_LEVEL"].ConvertTo<Byte?>();
            record.Connection = dataRecord["REP_CONNECTION"].ConvertTo<Byte?>();
            record.Current = dataRecord["REP_CURRENT"].ConvertTo<Byte>();
            record.GenParameters = dataRecord["REP_GEN_PARAMETERS"].ConvertTo<Byte>();
            record.RptpId = dataRecord["REP_RPTP_ID"].ConvertTo<Int32?>();
            record.RppId = dataRecord["REP_RPP_ID"].ConvertTo<Int32?>();
            record.System = dataRecord["REP_SYSTEM"].ConvertTo<Byte>();
            record.Standard = dataRecord["REP_STANDARD"].ConvertTo<Byte>();
            record.CnId = dataRecord["REP_CN_ID"].ConvertTo<String>();
            record.SsrsParameters = dataRecord["REP_SSRS_PARAMETERS"].ConvertTo<Byte>();
            record.CreatedByV1 = dataRecord["REP_CREATED_BY_V1"].ConvertTo<Boolean>();
            record.PmenuId = dataRecord["REP_PMENU_ID"].ConvertTo<Int32?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ReportRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ReportRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_REP_ID", record.Id);
            this.MapParameterIn(command, "@PA_REP_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_REP_DESCRIPTION", record.Description);
            this.MapParameterIn(command, "@PA_REP_NAME", record.Name);
            this.MapParameterIn(command, "@PA_REP_CAT", record.Cat);
            this.MapParameterIn(command, "@PA_REP_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_REP_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_REP_LEVEL", record.Level);
            this.MapParameterIn(command, "@PA_REP_CONNECTION", record.Connection);
            this.MapParameterIn(command, "@PA_REP_CURRENT", record.Current);
            this.MapParameterIn(command, "@PA_REP_GEN_PARAMETERS", record.GenParameters);
            this.MapParameterIn(command, "@PA_REP_RPTP_ID", record.RptpId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.RptpId);
            this.MapParameterIn(command, "@PA_REP_RPP_ID", record.RppId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.RppId);
            this.MapParameterIn(command, "@PA_REP_SYSTEM", record.System);
            this.MapParameterIn(command, "@PA_REP_STANDARD", record.Standard);
            this.MapParameterIn(command, "@PA_REP_CN_ID", record.CnId);
            this.MapParameterIn(command, "@PA_REP_SSRS_PARAMETERS", record.SsrsParameters);
            this.MapParameterIn(command, "@PA_REP_CREATED_BY_V1", record.CreatedByV1);
            this.MapParameterIn(command, "@PA_REP_PMENU_ID", record.PmenuId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PmenuId);
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
        ///     The <see cref="ReportRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ReportRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_REP_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_REP_LOCK", record.Lock);
            record.Description = this.MapParameterOut(command, "@PA_REP_DESCRIPTION", record.Description);
            record.Name = this.MapParameterOut(command, "@PA_REP_NAME", record.Name);
            record.Cat = this.MapParameterOut(command, "@PA_REP_CAT", record.Cat);
            record.Type = this.MapParameterOut(command, "@PA_REP_TYPE", record.Type);
            record.Notes = this.MapParameterOut(command, "@PA_REP_NOTES", record.Notes);
            record.Level = this.MapParameterOut(command, "@PA_REP_LEVEL", record.Level);
            record.Connection = this.MapParameterOut(command, "@PA_REP_CONNECTION", record.Connection);
            record.Current = this.MapParameterOut(command, "@PA_REP_CURRENT", record.Current);
            record.GenParameters = this.MapParameterOut(command, "@PA_REP_GEN_PARAMETERS", record.GenParameters);
            record.RptpId = this.MapParameterOut(command, "@PA_REP_RPTP_ID", record.RptpId);
            record.RppId = this.MapParameterOut(command, "@PA_REP_RPP_ID", record.RppId);
            record.System = this.MapParameterOut(command, "@PA_REP_SYSTEM", record.System);
            record.Standard = this.MapParameterOut(command, "@PA_REP_STANDARD", record.Standard);
            record.CnId = this.MapParameterOut(command, "@PA_REP_CN_ID", record.CnId);
            record.SsrsParameters = this.MapParameterOut(command, "@PA_REP_SSRS_PARAMETERS", record.SsrsParameters);
            record.CreatedByV1 = this.MapParameterOut(command, "@PA_REP_CREATED_BY_V1", record.CreatedByV1);
            record.PmenuId = this.MapParameterOut(command, "@PA_REP_PMENU_ID", record.PmenuId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ReportRecord" /> instances from the data store.
        /// </summary>
        /// <param name="rptpId">
        ///     The value which identifies the <see cref='ReportModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ReportRecord" /> instances that match the specified <paramref name='rptpId' />.
        /// </returns>
        public IEnumerable<ReportRecord> FetchAllByRptpId(Int32? rptpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "RptpId");
            this.MapParameterIn(command, "@PA_REP_RPTP_ID", rptpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ReportRecord" /> instances from the data store.
        /// </summary>
        /// <param name="rppId">
        ///     The value which identifies the <see cref='ReportModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ReportRecord" /> instances that match the specified <paramref name='rppId' />.
        /// </returns>
        public IEnumerable<ReportRecord> FetchAllByRppId(Int32? rppId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "RppId");
            this.MapParameterIn(command, "@PA_REP_RPP_ID", rppId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IReportRepository.TableName
        {
            get { return this.TableName; }
        }

        System.Collections.Generic.IEnumerable<Consensus.Reporting.ReportRecord> IReportRepository.FetchAllByRptpId(System.Nullable<System.Int32> rptpId)
        {
            return this.FetchAllByRptpId(rptpId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Reporting.ReportRecord> IReportRepository.FetchAllByRppId(System.Nullable<System.Int32> rppId)
        {
            return this.FetchAllByRppId(rppId);
        }

        #endregion
    }
}
