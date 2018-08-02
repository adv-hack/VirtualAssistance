using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="OrganisationRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerOrganisationRepository
    {
        public override void Create(OrganisationRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateOrganisation");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(OrganisationRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateOrganisation");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}
