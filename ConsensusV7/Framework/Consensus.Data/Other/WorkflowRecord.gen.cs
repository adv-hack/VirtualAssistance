using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Represents the "Workflow" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class WorkflowRecord : Record<String>, Cloneable<WorkflowRecord>, IEquatable<WorkflowRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "WF_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "WF_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "WF_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "WF_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "WF_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "WF_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "WF_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "WF_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "WF_DESC" field.
        /// </summary>
        private String _desc;

        /// <summary>
        ///     the value of the "WF_REC_TYPE" field.
        /// </summary>
        private String _recType;

        /// <summary>
        ///     the value of the "WF_AUTO_LINK" field.
        /// </summary>
        private Byte? _autoLink;

        /// <summary>
        ///     the value of the "WF_FIRST_WFR_ID" field.
        /// </summary>
        private String _firstWfrId;

        /// <summary>
        ///     the value of the "WF_DELAY" field.
        /// </summary>
        private Int32? _delay;

        /// <summary>
        ///     the value of the "WF_OCCURS" field.
        /// </summary>
        private Byte? _occurs;

        /// <summary>
        ///     the value of the "WF_DAY_OF_WEEK" field.
        /// </summary>
        private Byte? _dayOfWeek;

        /// <summary>
        ///     the value of the "WF_DAILY_FREQ" field.
        /// </summary>
        private Byte? _dailyFreq;

        /// <summary>
        ///     the value of the "WF_NORMAL_TIME" field.
        /// </summary>
        private DateTime? _normalTime;

        /// <summary>
        ///     the value of the "WF_FREQUENCY" field.
        /// </summary>
        private Int32? _frequency;

        /// <summary>
        ///     the value of the "WF_VALID_FROM_DATE" field.
        /// </summary>
        private DateTime? _validFromDate;

        /// <summary>
        ///     the value of the "WF_VALID_TO_DATE" field.
        /// </summary>
        private DateTime? _validToDate;

        /// <summary>
        ///     the value of the "WF_DISABLED" field.
        /// </summary>
        private Byte? _disabled;

        /// <summary>
        ///     the value of the "WF_RUN_DATETIME" field.
        /// </summary>
        private DateTime? _runDatetime;

        /// <summary>
        ///     the value of the "WF_LAST_RUN_DTTIME" field.
        /// </summary>
        private DateTime? _lastRunDttime;

        /// <summary>
        ///     the value of the "WF_CREATED_BY_V1" field.
        /// </summary>
        private Boolean _createdByV1;

        /// <summary>
        ///     the value of the "WF_GROUP" field.
        /// </summary>
        private String _group;

        /// <summary>
        ///     the value of the "WF_UNIQUE_SYS_NAME" field.
        /// </summary>
        private String _uniqueSysName;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "WF_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "WF_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "WF_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "WF_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "WF_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "WF_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "WF_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "WF_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "WF_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        /// <summary>
        ///     the value of the "WF_REC_TYPE" field.
        /// </summary>
        public String RecType
        {
            get { return _recType; }
            set { _recType = value; }
        }

        /// <summary>
        ///     the value of the "WF_AUTO_LINK" field.
        /// </summary>
        public Byte? AutoLink
        {
            get { return _autoLink; }
            set { _autoLink = value; }
        }

        /// <summary>
        ///     the value of the "WF_FIRST_WFR_ID" field.
        /// </summary>
        public String FirstWfrId
        {
            get { return _firstWfrId; }
            set { _firstWfrId = value; }
        }

        /// <summary>
        ///     the value of the "WF_DELAY" field.
        /// </summary>
        public Int32? Delay
        {
            get { return _delay; }
            set { _delay = value; }
        }

        /// <summary>
        ///     the value of the "WF_OCCURS" field.
        /// </summary>
        public Byte? Occurs
        {
            get { return _occurs; }
            set { _occurs = value; }
        }

        /// <summary>
        ///     the value of the "WF_DAY_OF_WEEK" field.
        /// </summary>
        public Byte? DayOfWeek
        {
            get { return _dayOfWeek; }
            set { _dayOfWeek = value; }
        }

        /// <summary>
        ///     the value of the "WF_DAILY_FREQ" field.
        /// </summary>
        public Byte? DailyFreq
        {
            get { return _dailyFreq; }
            set { _dailyFreq = value; }
        }

        /// <summary>
        ///     the value of the "WF_NORMAL_TIME" field.
        /// </summary>
        public DateTime? NormalTime
        {
            get { return _normalTime; }
            set { _normalTime = value; }
        }

        /// <summary>
        ///     the value of the "WF_FREQUENCY" field.
        /// </summary>
        public Int32? Frequency
        {
            get { return _frequency; }
            set { _frequency = value; }
        }

        /// <summary>
        ///     the value of the "WF_VALID_FROM_DATE" field.
        /// </summary>
        public DateTime? ValidFromDate
        {
            get { return _validFromDate; }
            set { _validFromDate = value; }
        }

        /// <summary>
        ///     the value of the "WF_VALID_TO_DATE" field.
        /// </summary>
        public DateTime? ValidToDate
        {
            get { return _validToDate; }
            set { _validToDate = value; }
        }

        /// <summary>
        ///     the value of the "WF_DISABLED" field.
        /// </summary>
        public Byte? Disabled
        {
            get { return _disabled; }
            set { _disabled = value; }
        }

        /// <summary>
        ///     the value of the "WF_RUN_DATETIME" field.
        /// </summary>
        public DateTime? RunDatetime
        {
            get { return _runDatetime; }
            set { _runDatetime = value; }
        }

        /// <summary>
        ///     the value of the "WF_LAST_RUN_DTTIME" field.
        /// </summary>
        public DateTime? LastRunDttime
        {
            get { return _lastRunDttime; }
            set { _lastRunDttime = value; }
        }

        /// <summary>
        ///     the value of the "WF_CREATED_BY_V1" field.
        /// </summary>
        public Boolean CreatedByV1
        {
            get { return _createdByV1; }
            set { _createdByV1 = value; }
        }

        /// <summary>
        ///     the value of the "WF_GROUP" field.
        /// </summary>
        public String Group
        {
            get { return _group; }
            set { _group = value; }
        }

        /// <summary>
        ///     the value of the "WF_UNIQUE_SYS_NAME" field.
        /// </summary>
        public String UniqueSysName
        {
            get { return _uniqueSysName; }
            set { _uniqueSysName = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="WorkflowRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="WorkflowRecord" /> object instance.
        /// </returns>
        public WorkflowRecord Clone()
        {
            WorkflowRecord record = new WorkflowRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Name = this.Name;
            record.Desc = this.Desc;
            record.RecType = this.RecType;
            record.AutoLink = this.AutoLink;
            record.FirstWfrId = this.FirstWfrId;
            record.Delay = this.Delay;
            record.Occurs = this.Occurs;
            record.DayOfWeek = this.DayOfWeek;
            record.DailyFreq = this.DailyFreq;
            record.NormalTime = this.NormalTime;
            record.Frequency = this.Frequency;
            record.ValidFromDate = this.ValidFromDate;
            record.ValidToDate = this.ValidToDate;
            record.Disabled = this.Disabled;
            record.RunDatetime = this.RunDatetime;
            record.LastRunDttime = this.LastRunDttime;
            record.CreatedByV1 = this.CreatedByV1;
            record.Group = this.Group;
            record.UniqueSysName = this.UniqueSysName;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="WorkflowRecord" /> instance is equal to another <see cref="WorkflowRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="WorkflowRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(WorkflowRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Desc.TrimOrNullify() == that.Desc.TrimOrNullify());
            result = result && (this.RecType.TrimOrNullify() == that.RecType.TrimOrNullify());
            result = result && (this.AutoLink == that.AutoLink);
            result = result && (this.FirstWfrId.TrimOrNullify() == that.FirstWfrId.TrimOrNullify());
            result = result && (this.Delay == that.Delay);
            result = result && (this.Occurs == that.Occurs);
            result = result && (this.DayOfWeek == that.DayOfWeek);
            result = result && (this.DailyFreq == that.DailyFreq);
            result = result && (this.NormalTime == that.NormalTime);
            result = result && (this.Frequency == that.Frequency);
            result = result && (this.ValidFromDate == that.ValidFromDate);
            result = result && (this.ValidToDate == that.ValidToDate);
            result = result && (this.Disabled == that.Disabled);
            result = result && (this.RunDatetime == that.RunDatetime);
            result = result && (this.LastRunDttime == that.LastRunDttime);
            result = result && (this.CreatedByV1 == that.CreatedByV1);
            result = result && (this.Group.TrimOrNullify() == that.Group.TrimOrNullify());
            result = result && (this.UniqueSysName.TrimOrNullify() == that.UniqueSysName.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
