using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ScreenCustomFieldRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerScreenCustomFieldRepository
    {
        /// <summary>
        /// Fetch the custom fields for a page.
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public IEnumerable<ScreenCustomFieldRecord> FetchAllByPage(string page)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spConsensusUserInterfaceScreenCustomFieldFetchAllByPage");
            this.MapParameterIn(command, "@PA_PAGE", page);
            return this.Execute(command);
        }
    }
}
