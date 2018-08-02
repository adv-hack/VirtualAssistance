using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="AttachmentRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerAttachmentRepository
    {
        public override void Create(AttachmentRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateAttachment");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(AttachmentRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateAttachment");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public IEnumerable<AttachmentRecord> FetchAllByUrlAndRecordId(String Url, String recordId)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spConsensusCommonAttachmentFetchAllByUrlAndRecordId");
            this.MapParameterIn(command, "@PA_TABLE_URL", Url);
            this.MapParameterIn(command, "@PA_RECORD_ID", recordId);
            return this.Execute(command);
        }
    }
}
