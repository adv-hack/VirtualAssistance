using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="LicenseModuleRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerLicenseModuleRepository
    {
        /// <summary>
        ///     Retrieves a collection of <see cref="LicenseModuleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="licId">
        ///     The value which identifies the <see cref='LicenseModuleModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="LicenseModuleRecord" /> instances that match the specified <paramref name='licId' />.
        /// </returns>
        public IEnumerable<LicenseModuleRecord> FetchAllByLicId(Guid licId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "LicId");
            this.MapParameterIn(command, "@PA_LM_LIC_ID", licId);
            return this.Execute(command);
        }
    }
}
