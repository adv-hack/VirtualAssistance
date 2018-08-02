using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="InvheaderRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerInvoiceRepository
    {
        public override void Create(InvheaderRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateInvHeader");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(InvheaderRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateInvHeader");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            if (record.AccId == null)
            {
                record.AccId = string.Empty;
                record.AccStatus = string.Empty;
            }
            if (record.OrgId == null)
            {
                record.OrgId = string.Empty;
                record.InvOrgName = string.Empty;
                record.Add = string.Empty;
                record.AddMailstring = string.Empty;
            }
            if (record.ProleId == null) {
                record.ProleId = string.Empty;
                record.PersonId = string.Empty;
            }
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public void RollbackInvoice(InvheaderRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateInvHeader");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParameterIn(command, "@PA_INV_CREDIT_NTE_REF", record.Id);
            this.MapParameterIn(command, "@PA_CREDIT_INVOICE", "1");
            this.MapParameterIn(command, "@PA_INV_MEP_ID", record.MepId);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public void CreateInvoice(String Id, String userLoginId, String sellingCompany = null, Int32 booking = 0)
        {
            DbCommand command;
            if (booking == 1)
            {
                command = this.Provider.GetStoredProcedure("spInsertUpdateInvHeader");
                this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
                this.MapParameterIn(command, "@PA_INV_BOOK_ID", Id);
                this.MapParameterIn(command, "@PA_AUTO_CREATE_INVLINES", "0");
                this.MapParameterIn(command, "@PA_INV_SELCO_SP_ID", sellingCompany);
            }
            else
            {
                command = this.Provider.GetStoredProcedure("spConsensusMembershipInvoiceToCreate");
                this.MapParameterIn(command, "@PA_USER_LOGIN_ID", userLoginId);
                this.MapParameterIn(command, "@PA_INV_MEP_ID", Id);
                this.MapParameterIn(command, "@PA_FROM_MEMBERSHIP", "1");
                
            }
            var response = this.Execute(command).FirstOrDefault();
            //return response
        }
        public void CreditInvoice(InvheaderRecord record,string invId,string userloginId)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateInvHeader");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID",userloginId);
            this.MapParameterIn(command, "@PA_INV_CREDIT_NTE_REF", record.Id);
            this.MapParameterIn(command, "@PA_CREDIT_INVOICE", 1);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}
