using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="MembershipRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerMembershipRepository
    {
        public override void Create(MembershipRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateMembership");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(MembershipRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateMembership");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}
