using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="DirectdebitRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerDirectDebitRepository
    {
        public override void Create(DirectdebitRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateDirectDebit");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(DirectdebitRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateDirectDebit");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}
