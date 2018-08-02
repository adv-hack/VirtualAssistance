using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="MemberPeriodRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerMemberPeriodRepository
    {
        public override void Create(MemberPeriodRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateMember_Period");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParameterIn(command, "@PA_PERIOD_ONLY", 1);
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(MemberPeriodRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateMember_Period");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

    }
}
