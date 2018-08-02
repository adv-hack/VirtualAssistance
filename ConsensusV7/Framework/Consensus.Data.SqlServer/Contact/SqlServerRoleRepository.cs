using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="RoleRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerRoleRepository
    {
        public override void Create(PersonRoleRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdatePersonRole");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapErrorParams(command);
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.CheckErrorParams(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(PersonRoleRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdatePersonRole");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapErrorParams(command);
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.CheckErrorParams(command);
            this.MapParametersOut(command, record);
        }   
    }
}
