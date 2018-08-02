using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="TimeSpentRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerTimeSpentRepository : SqlServerRepository<TimeSpentRecord, String>, ITimeSpentRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Contact"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "TimeSpent"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="TimeSpentRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_TIM_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Time_Spent"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="TimeSpentRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="TimeSpentRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, TimeSpentRecord record)
        {
            record.Id = dataRecord["TIM_ID"].ConvertTo<String>();
            record.AddDate = dataRecord["TIM_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["TIM_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["TIM_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["TIM_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["TIM_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["TIM_RCV_FROM"].ConvertTo<String>();
            record.ActId = dataRecord["TIM_ACT_ID"].ConvertTo<String>();
            record.RoleId = dataRecord["TIM_ROLE_ID"].ConvertTo<String>();
            record.Hours = dataRecord["TIM_HOURS"].ConvertTo<Double?>();
            record.Date = dataRecord["TIM_DATE"].ConvertTo<DateTime?>();
            record.Type = dataRecord["TIM_TYPE"].ConvertTo<String>();
            record.CostCode = dataRecord["TIM_COST_CODE"].ConvertTo<String>();
            record.Desc = dataRecord["TIM_DESC"].ConvertTo<String>();
            record.Lock = dataRecord["TIM_LOCK"].ConvertTo<String>();
            record.OrgId = dataRecord["TIM_ORG_ID"].ConvertTo<String>();
            record.ProjId = dataRecord["TIM_PROJ_ID"].ConvertTo<String>();
            record.TraHours = dataRecord["TIM_TRA_HOURS"].ConvertTo<Double?>();
            record.HouCharge = dataRecord["TIM_HOU_CHARGE"].ConvertTo<Double?>();
            record.TraCharge = dataRecord["TIM_TRA_CHARGE"].ConvertTo<Double?>();
            record.Mileage = dataRecord["TIM_MILEAGE"].ConvertTo<Decimal?>();
            record.Expenses = dataRecord["TIM_EXPENSES"].ConvertTo<Decimal?>();
            record.BatId = dataRecord["TIM_BAT_ID"].ConvertTo<String>();
            record.CstAc = dataRecord["TIM_CST_AC"].ConvertTo<Double?>();
            record.UntType = dataRecord["TIM_UNT_TYPE"].ConvertTo<String>();
            record.TimType = dataRecord["TIM_DROPDOWN_1"].ConvertTo<String>();
            record.TrainSyType = dataRecord["TIM_TRAIN_SY_TYPE"].ConvertTo<Int16>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="TimeSpentRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, TimeSpentRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_TIM_ID", record.Id);
            this.MapParameterIn(command, "@PA_TIM_ACT_ID", record.ActId);
            this.MapParameterIn(command, "@PA_TIM_ROLE_ID", record.RoleId);
            this.MapParameterIn(command, "@PA_TIM_HOURS", record.Hours == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Hours);
            this.MapParameterIn(command, "@PA_TIM_DATE", record.Date == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Date);
            this.MapParameterIn(command, "@PA_TIM_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_TIM_COST_CODE", record.CostCode);
            this.MapParameterIn(command, "@PA_TIM_DESC", record.Desc);
            this.MapParameterIn(command, "@PA_TIM_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_TIM_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_TIM_PROJ_ID", record.ProjId);
            this.MapParameterIn(command, "@PA_TIM_TRA_HOURS", record.TraHours == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TraHours);
            this.MapParameterIn(command, "@PA_TIM_HOU_CHARGE", record.HouCharge == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.HouCharge);
            this.MapParameterIn(command, "@PA_TIM_TRA_CHARGE", record.TraCharge == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TraCharge);
            this.MapParameterIn(command, "@PA_TIM_MILEAGE", record.Mileage == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Mileage);
            this.MapParameterIn(command, "@PA_TIM_EXPENSES", record.Expenses == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Expenses);
            this.MapParameterIn(command, "@PA_TIM_BAT_ID", record.BatId);
            this.MapParameterIn(command, "@PA_TIM_CST_AC", record.CstAc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CstAc);
            this.MapParameterIn(command, "@PA_TIM_UNT_TYPE", record.UntType);
            this.MapParameterIn(command, "@PA_TIM_DROPDOWN_1", record.TimType);
            this.MapParameterIn(command, "@PA_TIM_TRAIN_SY_TYPE", record.TrainSyType == Int16.MinValue ? ( useV6Logic ? new Int16?(0) : null ) : record.TrainSyType);
            this.MapParameterIn(command, "@_AUDIT_USER_ID", UserId);
            this.MapParameterIn(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Extracts the parameter values for the specified <paramref name="command" /> and applies the values to the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="TimeSpentRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, TimeSpentRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_TIM_ID", record.Id);
            record.ActId = this.MapParameterOut(command, "@PA_TIM_ACT_ID", record.ActId);
            record.RoleId = this.MapParameterOut(command, "@PA_TIM_ROLE_ID", record.RoleId);
            record.Hours = this.MapParameterOut(command, "@PA_TIM_HOURS", record.Hours);
            record.Date = this.MapParameterOut(command, "@PA_TIM_DATE", record.Date);
            record.Type = this.MapParameterOut(command, "@PA_TIM_TYPE", record.Type);
            record.CostCode = this.MapParameterOut(command, "@PA_TIM_COST_CODE", record.CostCode);
            record.Desc = this.MapParameterOut(command, "@PA_TIM_DESC", record.Desc);
            record.Lock = this.MapParameterOut(command, "@PA_TIM_LOCK", record.Lock);
            record.OrgId = this.MapParameterOut(command, "@PA_TIM_ORG_ID", record.OrgId);
            record.ProjId = this.MapParameterOut(command, "@PA_TIM_PROJ_ID", record.ProjId);
            record.TraHours = this.MapParameterOut(command, "@PA_TIM_TRA_HOURS", record.TraHours);
            record.HouCharge = this.MapParameterOut(command, "@PA_TIM_HOU_CHARGE", record.HouCharge);
            record.TraCharge = this.MapParameterOut(command, "@PA_TIM_TRA_CHARGE", record.TraCharge);
            record.Mileage = this.MapParameterOut(command, "@PA_TIM_MILEAGE", record.Mileage);
            record.Expenses = this.MapParameterOut(command, "@PA_TIM_EXPENSES", record.Expenses);
            record.BatId = this.MapParameterOut(command, "@PA_TIM_BAT_ID", record.BatId);
            record.CstAc = this.MapParameterOut(command, "@PA_TIM_CST_AC", record.CstAc);
            record.UntType = this.MapParameterOut(command, "@PA_TIM_UNT_TYPE", record.UntType);
            record.TimType = this.MapParameterOut(command, "@PA_TIM_DROPDOWN_1", record.TimType);
            record.TrainSyType = this.MapParameterOut(command, "@PA_TIM_TRAIN_SY_TYPE", record.TrainSyType);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ITimeSpentRepository.TableName
        {
            get { return this.TableName; }
        }

        void ITimeSpentRepository.Create(Consensus.Contact.TimeSpentRecord record)
        {
            this.Create(record);
        }

        void ITimeSpentRepository.Modify(Consensus.Contact.TimeSpentRecord record)
        {
            this.Modify(record);
        }

        #endregion
    }
}
