using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ViewLogRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerViewLogRepository
    {
        public override void Create(ViewLogRecord record)
        {
           
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateViewLog");
            this.MapParameterIn(command, "@PA_VIEW_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", UserId);
            this.MapParameterIn(command, "@PA_VIEW_TABLE", record.Table);
            this.MapParameterIn(command, "@PA_VIEW_SOURCE", record.Source);
            this.MapParameterIn(command, "@PA_VIEW_REC_ID", record.RecId);
            this.Execute(command);
            this.MapParametersOut(command, record);

        }
    }
}
