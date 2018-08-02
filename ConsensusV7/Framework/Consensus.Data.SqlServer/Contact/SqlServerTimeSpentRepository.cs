using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="TimeSpentRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerTimeSpentRepository
    {

        public override void Create(TimeSpentRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateTimeSpent");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", UserId);
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(TimeSpentRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateTimeSpent");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", UserId);
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}
