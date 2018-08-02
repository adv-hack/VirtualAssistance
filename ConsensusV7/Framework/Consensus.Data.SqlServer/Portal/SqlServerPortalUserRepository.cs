using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PortalUserRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerPortalUserRepository
    {
        public override void Create(PortalUserRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdatePortal_User");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(PortalUserRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdatePortal_User");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}
