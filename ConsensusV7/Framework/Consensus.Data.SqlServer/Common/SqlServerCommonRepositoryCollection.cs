using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Microsoft SQL Server repository collection which pertains to the Common namespace.
    /// </summary>
    public partial class SqlServerCommonRepositoryCollection
    {
        partial void OverrideProvider(Type SqlServerDataRepositoryType, ref SqlServerProvider provider)
        {
            if (SqlServerDataRepositoryType.Name == "SqlServerAttachmentDataRepository" /*|| SqlServerDataRepositoryType.Name == "SqlServerCodeRepository"*/)
            {
                string attachmentsConnString = provider["attachments_connection"];
                if (!String.IsNullOrEmpty(attachmentsConnString))
                {
                    SqlServerProvider newProvider = new SqlServerProvider()
                    {
                        Site = provider.Site,
                        Settings = provider.Settings,
                        ConnectionStringField = "attachments_connection"
                    };
                    provider = newProvider;
                }
            }
        }
    }
}
