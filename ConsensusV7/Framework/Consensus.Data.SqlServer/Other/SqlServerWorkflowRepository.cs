using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="WorkflowRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerWorkflowRepository
    {
        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <param name="recType">
        ///     The unique value which distinctly identifies the <typeparamref name="TRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public IEnumerable<WorkflowRecord> FetchByRecType(String recType)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.Fetch, "RecType");
            this.MapParameterIn(command, "@PA_WF_REC_TYPE", recType);
            return this.Execute(command);
        }
    }
}
