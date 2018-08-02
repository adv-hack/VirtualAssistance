using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="AccountXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerAccountXrefRepository
    {
        public override void Create(AccountXrefRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateAccount_Xref");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(AccountXrefRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateAccount_Xref");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}
