using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ScreenCustomFieldValueRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerScreenCustomFieldValueRepository
    {
        
        /// <summary>
        ///  Gets the value for a custom field for a given record.
        /// </summary>
        /// <param name="fieldId">The custom field ID (which is associated with a page)</param>
        /// <param name="recordId">The ID value of the record displayed on the page, converted to a string if required.</param>
        /// <returns></returns>
        public ScreenCustomFieldValueRecord FetchByFieldIdAndRecordId(Int32 fieldId, String recordId)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spConsensusUserInterfaceScreenCustomFieldValueFetchByFieldIdAndRecordId");
            this.MapParameterIn(command, "@PA_CFIELD_ID", fieldId);
            this.MapParameterIn(command, "@PA_RECORD_ID", recordId);
            return this.Execute(command).FirstOrDefault();
        }
    }
}
