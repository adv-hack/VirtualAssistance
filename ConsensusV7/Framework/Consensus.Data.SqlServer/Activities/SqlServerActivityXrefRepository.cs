using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ActivityXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerActivityXrefRepository
    {
        public override void Create(ActivityXrefRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateActivity_Xref");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapErrorParams(command);
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.CheckErrorParams(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(ActivityXrefRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateActivity_Xref");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapErrorParams(command);
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.CheckErrorParams(command);
            this.MapParametersOut(command, record);
        }
    }
}
