using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ActivityRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerActivityRepository
    {
        public override void Create(ActivityRecord record)
        {
            string procName = "spInsertUpdateActivity";
            if (record.Type == "D-Session")
                procName = "spInsertUpdateSession";

            DbCommand command = this.Provider.GetStoredProcedure(procName);
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(ActivityRecord record)
        {
            string procName = "spInsertUpdateActivity";
            if (record.Type == "D-Session")
                procName = "spInsertUpdateSession";

            DbCommand command = this.Provider.GetStoredProcedure(procName);
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void RemoveById(ActivityRecord record)
        {
            string procName = "spDeleteActivity";
            if (record.Type == "D-Session")
                procName = "spConsensusActivitiesSessionRemoveById";
            DbCommand command = this.Provider.GetStoredProcedure(procName);
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, false);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}
