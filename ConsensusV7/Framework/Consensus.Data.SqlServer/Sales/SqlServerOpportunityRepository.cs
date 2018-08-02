using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="OpportunityRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerOpportunityRepository
    {
        public override void Create(OpportunityRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateOpportunity");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(OpportunityRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateOpportunity");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }   
    }
}
