using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PromotionRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerPromotionRepository
    {
        public override void Create(PromotionRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdatePromotion");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(PromotionRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdatePromotion");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}
