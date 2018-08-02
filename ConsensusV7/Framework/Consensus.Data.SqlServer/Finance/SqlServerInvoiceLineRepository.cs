using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="InvlineRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerInvoiceLineRepository
    {

        public override void Create(InvlineRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateInvLine");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(InvlineRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateInvLine");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void RemoveById(InvlineRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spDeleteInvLine");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        } 
    }
}
