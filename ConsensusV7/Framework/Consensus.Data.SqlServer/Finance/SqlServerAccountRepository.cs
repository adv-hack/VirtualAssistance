using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="AccountRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerAccountRepository
    {
        /// <summary>
        ///     Retrieves a specific <see cref='AccountModel' /> instance.
        /// </summary>
        /// <param name="recType">
        ///     The recType value for the <see cref='AccountModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AccountModel' /> instance that matches the specified <paramref name='roleId' />; or null, if no matching instance can be found.
        /// </returns>
        public IEnumerable<AccountRecord> FetchByXrefRoleIdandOrgId(String roleId, String orgId, String spId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.Fetch, "XrefRoleIdandOrgId");
            this.MapParameterIn(command, "@PA_ACXREF_PROLE_ID", roleId);
            this.MapParameterIn(command, "@PA_ACXREF_ORG_ID", orgId);
            this.MapParameterIn(command, "@PA_ACC_SELCO_SP_ID", spId);
            return this.Execute(command);
        }

        public override void Create(AccountRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateAccount");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(AccountRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateAccount");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}
