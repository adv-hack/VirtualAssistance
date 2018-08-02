using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="MemberLocationRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerMemberLocationRepository
    {
        public override void Create(MemberLocationRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateMember_Location");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            if (record.SyType == 1)
            {
                if (record.Fee < 0)
                {
                    this.MapParameterIn(command, "@PA_MEL_FEE", record.Fee = decimal.Negate(record.Fee));
                }
                else
                {
                    this.MapParameterIn(command, "@PA_MEL_FEE", record.Fee);
                }
            }
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public void CreateDiscount(MemberLocationRecord record, decimal feeamount)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateMember_Location");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            if (record.Fee != 0)
            {
                this.MapParameterIn(command, "@PA_MEL_FEE", record.Fee = decimal.Negate(record.Fee));
            }
            else if (record.DiscPercent != null)
            {
                this.MapParameterIn(command, "@PA_MEL_FEE", record.Fee = decimal.Negate(Convert.ToDecimal((record.DiscPercent * feeamount) / 100)));
            }
            else
            {
                this.MapParameterIn(command, "@PA_MEL_FEE", record.Fee = decimal.Negate(record.Fee));
            }
           
            if (record.Fee < 0)
            {
                this.MapParameterIn(command, "@PA_MEL_FEE", record.Fee);
            }
            else
            {
                this.MapParameterIn(command, "@PA_MEL_FEE", record.Fee = decimal.Negate(record.Fee));
            }
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
        public override void Modify(MemberLocationRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateMember_Location");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            if (record.SyType == 1 )
            {
                if (record.Fee < 0)
                {
                    this.MapParameterIn(command, "@PA_MEL_FEE", record.Fee = decimal.Negate(record.Fee));    
                }
                else
                {
                    this.MapParameterIn(command, "@PA_MEL_FEE", record.Fee);
                }
            }
            this.Execute(command);
            this.MapParametersOut(command, record);
        }
    }
}
