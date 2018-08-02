using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents the "Time_Spent" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class TimeSpentRecord : Record<String>, Cloneable<TimeSpentRecord>, IEquatable<TimeSpentRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "TIM_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "TIM_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "TIM_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "TIM_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "TIM_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "TIM_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "TIM_ACT_ID" field.
        /// </summary>
        private String _actId;

        /// <summary>
        ///     the value of the "TIM_ROLE_ID" field.
        /// </summary>
        private String _roleId;

        /// <summary>
        ///     the value of the "TIM_HOURS" field.
        /// </summary>
        private Double? _hours;

        /// <summary>
        ///     the value of the "TIM_DATE" field.
        /// </summary>
        private DateTime? _date;

        /// <summary>
        ///     the value of the "TIM_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "TIM_COST_CODE" field.
        /// </summary>
        private String _costCode;

        /// <summary>
        ///     the value of the "TIM_DESC" field.
        /// </summary>
        private String _desc;

        /// <summary>
        ///     the value of the "TIM_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "TIM_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "TIM_PROJ_ID" field.
        /// </summary>
        private String _projId;

        /// <summary>
        ///     the value of the "TIM_TRA_HOURS" field.
        /// </summary>
        private Double? _traHours;

        /// <summary>
        ///     the value of the "TIM_HOU_CHARGE" field.
        /// </summary>
        private Double? _houCharge;

        /// <summary>
        ///     the value of the "TIM_TRA_CHARGE" field.
        /// </summary>
        private Double? _traCharge;

        /// <summary>
        ///     the value of the "TIM_MILEAGE" field.
        /// </summary>
        private Decimal? _mileage;

        /// <summary>
        ///     the value of the "TIM_EXPENSES" field.
        /// </summary>
        private Decimal? _expenses;

        /// <summary>
        ///     the value of the "TIM_BAT_ID" field.
        /// </summary>
        private String _batId;

        /// <summary>
        ///     the value of the "TIM_CST_AC" field.
        /// </summary>
        private Double? _cstAc;

        /// <summary>
        ///     the value of the "TIM_UNT_TYPE" field.
        /// </summary>
        private String _untType;

        /// <summary>
        ///     the value of the "TIM_DROPDOWN_1" field.
        /// </summary>
        private String _timType;

        /// <summary>
        ///     the value of the "TIM_TRAIN_SY_TYPE" field.
        /// </summary>
        private Int16 _trainSyType;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "TIM_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "TIM_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "TIM_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "TIM_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "TIM_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "TIM_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "TIM_ACT_ID" field.
        /// </summary>
        public String ActId
        {
            get { return _actId; }
            set { _actId = value; }
        }

        /// <summary>
        ///     the value of the "TIM_ROLE_ID" field.
        /// </summary>
        public String RoleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }

        /// <summary>
        ///     the value of the "TIM_HOURS" field.
        /// </summary>
        public Double? Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        /// <summary>
        ///     the value of the "TIM_DATE" field.
        /// </summary>
        public DateTime? Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        ///     the value of the "TIM_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "TIM_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return _costCode; }
            set { _costCode = value; }
        }

        /// <summary>
        ///     the value of the "TIM_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        /// <summary>
        ///     the value of the "TIM_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "TIM_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "TIM_PROJ_ID" field.
        /// </summary>
        public String ProjId
        {
            get { return _projId; }
            set { _projId = value; }
        }

        /// <summary>
        ///     the value of the "TIM_TRA_HOURS" field.
        /// </summary>
        public Double? TraHours
        {
            get { return _traHours; }
            set { _traHours = value; }
        }

        /// <summary>
        ///     the value of the "TIM_HOU_CHARGE" field.
        /// </summary>
        public Double? HouCharge
        {
            get { return _houCharge; }
            set { _houCharge = value; }
        }

        /// <summary>
        ///     the value of the "TIM_TRA_CHARGE" field.
        /// </summary>
        public Double? TraCharge
        {
            get { return _traCharge; }
            set { _traCharge = value; }
        }

        /// <summary>
        ///     the value of the "TIM_MILEAGE" field.
        /// </summary>
        public Decimal? Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }

        /// <summary>
        ///     the value of the "TIM_EXPENSES" field.
        /// </summary>
        public Decimal? Expenses
        {
            get { return _expenses; }
            set { _expenses = value; }
        }

        /// <summary>
        ///     the value of the "TIM_BAT_ID" field.
        /// </summary>
        public String BatId
        {
            get { return _batId; }
            set { _batId = value; }
        }

        /// <summary>
        ///     the value of the "TIM_CST_AC" field.
        /// </summary>
        public Double? CstAc
        {
            get { return _cstAc; }
            set { _cstAc = value; }
        }

        /// <summary>
        ///     the value of the "TIM_UNT_TYPE" field.
        /// </summary>
        public String UntType
        {
            get { return _untType; }
            set { _untType = value; }
        }

        /// <summary>
        ///     the value of the "TIM_DROPDOWN_1" field.
        /// </summary>
        public String TimType
        {
            get { return _timType; }
            set { _timType = value; }
        }

        /// <summary>
        ///     the value of the "TIM_TRAIN_SY_TYPE" field.
        /// </summary>
        public Int16 TrainSyType
        {
            get { return _trainSyType; }
            set { _trainSyType = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="TimeSpentRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="TimeSpentRecord" /> object instance.
        /// </returns>
        public TimeSpentRecord Clone()
        {
            TimeSpentRecord record = new TimeSpentRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.ActId = this.ActId;
            record.RoleId = this.RoleId;
            record.Hours = this.Hours;
            record.Date = this.Date;
            record.Type = this.Type;
            record.CostCode = this.CostCode;
            record.Desc = this.Desc;
            record.Lock = this.Lock;
            record.OrgId = this.OrgId;
            record.ProjId = this.ProjId;
            record.TraHours = this.TraHours;
            record.HouCharge = this.HouCharge;
            record.TraCharge = this.TraCharge;
            record.Mileage = this.Mileage;
            record.Expenses = this.Expenses;
            record.BatId = this.BatId;
            record.CstAc = this.CstAc;
            record.UntType = this.UntType;
            record.TimType = this.TimType;
            record.TrainSyType = this.TrainSyType;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="TimeSpentRecord" /> instance is equal to another <see cref="TimeSpentRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="TimeSpentRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(TimeSpentRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.ActId.TrimOrNullify() == that.ActId.TrimOrNullify());
            result = result && (this.RoleId.TrimOrNullify() == that.RoleId.TrimOrNullify());
            result = result && (this.Hours == that.Hours);
            result = result && (this.Date == that.Date);
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.CostCode.TrimOrNullify() == that.CostCode.TrimOrNullify());
            result = result && (this.Desc.TrimOrNullify() == that.Desc.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.ProjId.TrimOrNullify() == that.ProjId.TrimOrNullify());
            result = result && (this.TraHours == that.TraHours);
            result = result && (this.HouCharge == that.HouCharge);
            result = result && (this.TraCharge == that.TraCharge);
            result = result && (this.Mileage == that.Mileage);
            result = result && (this.Expenses == that.Expenses);
            result = result && (this.BatId.TrimOrNullify() == that.BatId.TrimOrNullify());
            result = result && (this.CstAc == that.CstAc);
            result = result && (this.UntType.TrimOrNullify() == that.UntType.TrimOrNullify());
            result = result && (this.TimType.TrimOrNullify() == that.TimType.TrimOrNullify());
            result = result && (this.TrainSyType == that.TrainSyType);
            return result;
        }

        #endregion
    }
}
