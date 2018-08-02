using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ListRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerMailingListRepository
    {
        public override void Create(ListRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateList");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(ListRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateList");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}
