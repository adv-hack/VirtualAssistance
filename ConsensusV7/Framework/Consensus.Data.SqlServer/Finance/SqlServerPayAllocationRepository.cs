using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PayAllocationRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerPayAllocationRepository
    {
        public override void Create(PayAllocationRecord record)
        {
          
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdatePayAllocation");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
        public void CreateReverse(PayAllocationRecord record,Boolean reverse,String paid)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdatePayAllocation");
            this.MapParametersIn(command, record, true);
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParameterIn(command, "@PA_REVERSE",reverse);
            this.MapParameterIn(command, "@PA_PA_ID", paid);
            this.MapParameterIn(command, "@PA_PA_PAY_ID",record.PayId);
            this.MapParameterIn(command, "@PA_PAY_REFUND_PAY_ID", record.PayId);
            
            this.Execute(command);
            this.MapParametersOut(command, record);

        }
        public override void Modify(PayAllocationRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdatePayAllocation");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}
