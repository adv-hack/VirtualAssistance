using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="UserAccountRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerUserAccountRepository
    {
        /// <summary>
        ///     Retrieves a single <see cref="UserAccountRecord" /> instance from the data store.
        /// </summary>
        /// <param name="username">
        ///     The value which identifies the <see cref='UserAccountRecord' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="UserAccountRecord" /> instance which matches the specified <paramref name="username"/>.
        /// </returns>
        public UserAccountRecord FetchByUsername(String username)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.Fetch, "Username");
            this.MapParameterIn(command, "@PA_USERNAME", username);
            return this.Execute(command).FirstOrDefault();
        }

        /// <summary>
        ///     Retrieves a string <see cref="String" /> value which contains the reporting URL.
        /// </summary>
        /// <returns>
        ///     The <see cref="String" /> reporting URL.
        /// </returns>
        public String ReportingURL(String portalPage)
        {
            Dictionary<String, Object>[] returnValues = this.Provider.ExecuteProcedure("spConsensusReportingFetchURL", new Dictionary<string, object> { { "@PA_PMENU_ID", portalPage } });
            if (returnValues.Length > 0)
            {
                return returnValues[0]["REPORT_URL"].ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
