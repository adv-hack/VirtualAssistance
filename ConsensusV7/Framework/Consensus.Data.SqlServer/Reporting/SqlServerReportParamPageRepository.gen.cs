using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ReportParampageRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerReportParamPageRepository : SqlServerRepository<ReportParampageRecord, Int32>, IReportParamPageRepository
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
            get { return "ReportParampage"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ReportParampageRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_RPP_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Report_ParamPage"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ReportParampageRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ReportParampageRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ReportParampageRecord record)
        {
            record.Id = dataRecord["RPP_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["RPP_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["RPP_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["RPP_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["RPP_MOD_BY"].ConvertTo<String>();
            record.PageName = dataRecord["RPP_PAGE_NAME"].ConvertTo<String>();
            record.PagePath = dataRecord["RPP_PAGE_PATH"].ConvertTo<String>();
            record.ParamDesc = dataRecord["RPP_PARAM_DESC"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ReportParampageRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ReportParampageRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_RPP_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_RPP_PAGE_NAME", record.PageName);
            this.MapParameterIn(command, "@PA_RPP_PAGE_PATH", record.PagePath);
            this.MapParameterIn(command, "@PA_RPP_PARAM_DESC", record.ParamDesc);
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
        ///     The <see cref="ReportParampageRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ReportParampageRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_RPP_ID", record.Id);
            record.PageName = this.MapParameterOut(command, "@PA_RPP_PAGE_NAME", record.PageName);
            record.PagePath = this.MapParameterOut(command, "@PA_RPP_PAGE_PATH", record.PagePath);
            record.ParamDesc = this.MapParameterOut(command, "@PA_RPP_PARAM_DESC", record.ParamDesc);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IReportParamPageRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
