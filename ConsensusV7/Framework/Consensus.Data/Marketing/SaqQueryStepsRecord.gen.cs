using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Represents the "SAQ_QUERY_STEPS" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class SaqQueryStepsRecord : Record<Int32>, Cloneable<SaqQueryStepsRecord>, IEquatable<SaqQueryStepsRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "QSTEP_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "QSTEP_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "QSTEP_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "QSTEP_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "QSTEP_QRY_ID" field.
        /// </summary>
        private Int64 _qryId;

        /// <summary>
        ///     the value of the "QSTEP_STEP_ID" field.
        /// </summary>
        private Int64 _stepId;

        /// <summary>
        ///     the value of the "QSTEP_LINK" field.
        /// </summary>
        private String _link;

        /// <summary>
        ///     the value of the "QSTEP_ORDER" field.
        /// </summary>
        private Int16 _order;

        /// <summary>
        ///     the value of the "QSTEP_RESULT_COUNT" field.
        /// </summary>
        private Int64 _resultCount;

        /// <summary>
        ///     the value of the "QSTEP_ORG_TOTAL" field.
        /// </summary>
        private Int64 _orgTotal;

        /// <summary>
        ///     the value of the "QSTEP_ROLE_TOTAL" field.
        /// </summary>
        private Int64 _roleTotal;

        /// <summary>
        ///     the value of the "QSTEP_PERSON_TOTAL" field.
        /// </summary>
        private Int64 _personTotal;

        /// <summary>
        ///     the value of the "QSTEP_RUN_TIME" field.
        /// </summary>
        private DateTime? _runTime;

        /// <summary>
        ///     the value of the "QSTEP_LINK_CHANGE" field.
        /// </summary>
        private Int64? _linkChange;

        /// <summary>
        ///     the value of the "QSTEP_SCHED_RUN_DATE" field.
        /// </summary>
        private DateTime? _schedRunDate;

        /// <summary>
        ///     the value of the "QSTEP_SCHED_RUN_TIME" field.
        /// </summary>
        private DateTime? _schedRunTime;

        /// <summary>
        ///     the value of the "QSTEP_CALCULATED_DATE" field.
        /// </summary>
        private DateTime? _calculatedDate;

        /// <summary>
        ///     the value of the "QSTEP_OUTPUT_DATE" field.
        /// </summary>
        private DateTime? _outputDate;

        /// <summary>
        ///     the value of the "QSTEP_LOCKED" field.
        /// </summary>
        private Byte _locked;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "QSTEP_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_QRY_ID" field.
        /// </summary>
        public Int64 QryId
        {
            get { return _qryId; }
            set { _qryId = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_STEP_ID" field.
        /// </summary>
        public Int64 StepId
        {
            get { return _stepId; }
            set { _stepId = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_LINK" field.
        /// </summary>
        public String Link
        {
            get { return _link; }
            set { _link = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_ORDER" field.
        /// </summary>
        public Int16 Order
        {
            get { return _order; }
            set { _order = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_RESULT_COUNT" field.
        /// </summary>
        public Int64 ResultCount
        {
            get { return _resultCount; }
            set { _resultCount = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_ORG_TOTAL" field.
        /// </summary>
        public Int64 OrgTotal
        {
            get { return _orgTotal; }
            set { _orgTotal = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_ROLE_TOTAL" field.
        /// </summary>
        public Int64 RoleTotal
        {
            get { return _roleTotal; }
            set { _roleTotal = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_PERSON_TOTAL" field.
        /// </summary>
        public Int64 PersonTotal
        {
            get { return _personTotal; }
            set { _personTotal = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_RUN_TIME" field.
        /// </summary>
        public DateTime? RunTime
        {
            get { return _runTime; }
            set { _runTime = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_LINK_CHANGE" field.
        /// </summary>
        public Int64? LinkChange
        {
            get { return _linkChange; }
            set { _linkChange = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_SCHED_RUN_DATE" field.
        /// </summary>
        public DateTime? SchedRunDate
        {
            get { return _schedRunDate; }
            set { _schedRunDate = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_SCHED_RUN_TIME" field.
        /// </summary>
        public DateTime? SchedRunTime
        {
            get { return _schedRunTime; }
            set { _schedRunTime = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_CALCULATED_DATE" field.
        /// </summary>
        public DateTime? CalculatedDate
        {
            get { return _calculatedDate; }
            set { _calculatedDate = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_OUTPUT_DATE" field.
        /// </summary>
        public DateTime? OutputDate
        {
            get { return _outputDate; }
            set { _outputDate = value; }
        }

        /// <summary>
        ///     the value of the "QSTEP_LOCKED" field.
        /// </summary>
        public Byte Locked
        {
            get { return _locked; }
            set { _locked = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="SaqQueryStepsRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="SaqQueryStepsRecord" /> object instance.
        /// </returns>
        public SaqQueryStepsRecord Clone()
        {
            SaqQueryStepsRecord record = new SaqQueryStepsRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.QryId = this.QryId;
            record.StepId = this.StepId;
            record.Link = this.Link;
            record.Order = this.Order;
            record.ResultCount = this.ResultCount;
            record.OrgTotal = this.OrgTotal;
            record.RoleTotal = this.RoleTotal;
            record.PersonTotal = this.PersonTotal;
            record.RunTime = this.RunTime;
            record.LinkChange = this.LinkChange;
            record.SchedRunDate = this.SchedRunDate;
            record.SchedRunTime = this.SchedRunTime;
            record.CalculatedDate = this.CalculatedDate;
            record.OutputDate = this.OutputDate;
            record.Locked = this.Locked;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="SaqQueryStepsRecord" /> instance is equal to another <see cref="SaqQueryStepsRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="SaqQueryStepsRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(SaqQueryStepsRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.QryId == that.QryId);
            result = result && (this.StepId == that.StepId);
            result = result && (this.Link.TrimOrNullify() == that.Link.TrimOrNullify());
            result = result && (this.Order == that.Order);
            result = result && (this.ResultCount == that.ResultCount);
            result = result && (this.OrgTotal == that.OrgTotal);
            result = result && (this.RoleTotal == that.RoleTotal);
            result = result && (this.PersonTotal == that.PersonTotal);
            result = result && (this.RunTime == that.RunTime);
            result = result && (this.LinkChange == that.LinkChange);
            result = result && (this.SchedRunDate == that.SchedRunDate);
            result = result && (this.SchedRunTime == that.SchedRunTime);
            result = result && (this.CalculatedDate == that.CalculatedDate);
            result = result && (this.OutputDate == that.OutputDate);
            result = result && (this.Locked == that.Locked);
            return result;
        }

        #endregion
    }
}
