using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ReportPageRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerReportPageRepository : SqlServerRepository<ReportPageRecord, Int32>, IReportPageRepository
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
            get { return "ReportPage"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ReportPageRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_RPTP_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Report_Page"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ReportPageRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ReportPageRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ReportPageRecord record)
        {
            record.Id = dataRecord["RPTP_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["RPTP_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["RPTP_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["RPTP_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["RPTP_MOD_BY"].ConvertTo<String>();
            record.PageName = dataRecord["RPTP_PAGE_NAME"].ConvertTo<String>();
            record.PagePath = dataRecord["RPTP_PAGE_PATH"].ConvertTo<String>();
            record.Section = dataRecord["RPTP_SECTION"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ReportPageRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ReportPageRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_RPTP_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_RPTP_PAGE_NAME", record.PageName);
            this.MapParameterIn(command, "@PA_RPTP_PAGE_PATH", record.PagePath);
            this.MapParameterIn(command, "@PA_RPTP_SECTION", record.Section);
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
        ///     The <see cref="ReportPageRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ReportPageRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_RPTP_ID", record.Id);
            record.PageName = this.MapParameterOut(command, "@PA_RPTP_PAGE_NAME", record.PageName);
            record.PagePath = this.MapParameterOut(command, "@PA_RPTP_PAGE_PATH", record.PagePath);
            record.Section = this.MapParameterOut(command, "@PA_RPTP_SECTION", record.Section);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IReportPageRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
