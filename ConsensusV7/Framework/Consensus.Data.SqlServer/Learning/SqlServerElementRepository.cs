using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ElementRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerElementRepository
    {
        public override void Create(ElementRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateElement");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(ElementRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateElement");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}
