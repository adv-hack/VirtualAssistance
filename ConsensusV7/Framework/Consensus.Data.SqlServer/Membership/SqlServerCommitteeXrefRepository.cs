using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CommitteeXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerCommitteeXrefRepository
    {
        public override void Create(CommitteeXrefRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateCommittee_Xref");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.MapParameterIn(command, "@PA_COMXREF_DATE", record.Date);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
        public override void Modify(CommitteeXrefRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateCommittee_Xref");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.MapParameterIn(command, "@PA_COMXREF_DATE", record.Date);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
        public override void RemoveById(CommitteeXrefRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spDeleteCommitteePerson");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}
