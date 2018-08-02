using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="C4textRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerC4textRepository
    {
        public IEnumerable<C4textRecord> FetchAllByOwnerUrlAndOwnerId(String ownerUrl, String ownerId)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spConsensusActivitiesC4textFetchAllByOwnerUrlAndOwnerId");
            this.MapParameterIn(command, "@PA_OWNER_URL", ownerUrl);
            this.MapParameterIn(command, "@PA_OWNER_ID", ownerId);
            return this.Execute(command);
        }
    }
}
