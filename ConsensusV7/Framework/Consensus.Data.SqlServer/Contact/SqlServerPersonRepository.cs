using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PersonRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerPersonRepository
    {
        public override void Create(PersonRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdatePerson");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(PersonRecord record)
        {
           
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdatePerson");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }


        public PersonRecord AnonymisePerson(String personId)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spfnAnonymisePerson");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParameterIn(command, "@PA_PN_ID", personId);
            return this.Execute(command).FirstOrDefault();
        }
    }
}
