using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PaymentRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerPaymentRepository
    {
        public override void Create(PaymentRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdatePayment");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            //this.MapParametersIn(command, record, true);
            //Checks if Payment is for Refund
            if (String.IsNullOrEmpty(record.RefundPayId))
            {
                this.MapParametersIn(command, record, true);
            }
            else
            {
                record.Recvd = Decimal.Negate(record.Recvd);
                record.RecvdBc = Decimal.Negate(record.RecvdBc2);
                this.MapParametersIn(command, record, true);
                this.MapParameterIn(command, "@PA_PAY_TXN_TYPE", 3);
            }
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public void CreateAndAllocate(PaymentRecord record, String invoiceId)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdatePayment");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParameterIn(command, "@PA_INV_ID", invoiceId);
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(PaymentRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdatePayment");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}
