using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="LettertmpltRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerLetterTemplateRepository
    {
        public override void Create(LettertmpltRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateLetterTemplate");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(LettertmpltRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateLetterTemplate");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}

