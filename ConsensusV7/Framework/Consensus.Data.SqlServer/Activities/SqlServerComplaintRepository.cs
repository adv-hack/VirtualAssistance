using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ComplaintRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerComplaintRepository
    {
        //public override void Create(ComplaintRecord record)
        //{
        //    //DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateOrganisation");
        //    //this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
        //    //this.MapParametersIn(command, record, true);
        //    //this.MapParameterIn(command, "@PA_HD_TYPE", 3);
        //    //this.Execute(command);
        //    //this.MapParametersOut(command, record);
        //}
    }
}
