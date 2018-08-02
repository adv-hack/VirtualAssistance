using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="HistorylinkRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerHistoryLinkRepository
    {

        /// <summary>
        ///     Removes an existing <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <param name="record">
        ///     The data structure to be removed from the data store.
        /// </param>
        public virtual void CleanUp(Int32 userId)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spConsensusUserInterfaceHistoryLinkCleanUp");
            this.MapParameterIn(command, "@PA_USER_ID", userId);
            this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <typeparamref name="TRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public HistorylinkRecord FetchByUserIDandURL(Int32 userId, String URL)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.Fetch, "UserID", "URL");
            this.MapParameterIn(command, "@PA_HL_USER_ID", userId);
            this.MapParameterIn(command, "@PA_HL_URL", URL);
            return this.Execute(command).FirstOrDefault();
        }

       
    }
}

