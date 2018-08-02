using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Represents the "Branch_Xref" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class BranchXrefRecord : Record<String>, Cloneable<BranchXrefRecord>, IEquatable<BranchXrefRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "BRXREF_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "BRXREF_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "BRXREF_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "BRXREF_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "BRXREF_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "BRXREF_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "BRXREF_BR_ID" field.
        /// </summary>
        private String _brId;

        /// <summary>
        ///     the value of the "BRXREF_TABLE_NAME" field.
        /// </summary>
        private String _tableName;

        /// <summary>
        ///     the value of the "BRXREF_RECORD_ID" field.
        /// </summary>
        private String _recordId;

        /// <summary>
        ///     the value of the "BRXREF_DISABLED" field.
        /// </summary>
        private Byte? _disabled;

        /// <summary>
        ///     the value of the "BRXREF_POSITION" field.
        /// </summary>
        private String _position;

        /// <summary>
        ///     the value of the "BRXREF_DISTRICT" field.
        /// </summary>
        private String _district;

        /// <summary>
        ///     the value of the "BRXREF_DIS_ID" field.
        /// </summary>
        private String _disId;

        /// <summary>
        ///     the value of the "BRXREF_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "BRXREF_START_DATE" field.
        /// </summary>
        private DateTime? _startDate;

        /// <summary>
        ///     the value of the "BRXREF_END_DATE" field.
        /// </summary>
        private DateTime? _endDate;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "BRXREF_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "BRXREF_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "BRXREF_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "BRXREF_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "BRXREF_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "BRXREF_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "BRXREF_BR_ID" field.
        /// </summary>
        public String BrId
        {
            get { return _brId; }
            set { _brId = value; }
        }

        /// <summary>
        ///     the value of the "BRXREF_TABLE_NAME" field.
        /// </summary>
        public String TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        /// <summary>
        ///     the value of the "BRXREF_RECORD_ID" field.
        /// </summary>
        public String RecordId
        {
            get { return _recordId; }
            set { _recordId = value; }
        }

        /// <summary>
        ///     the value of the "BRXREF_DISABLED" field.
        /// </summary>
        public Byte? Disabled
        {
            get { return _disabled; }
            set { _disabled = value; }
        }

        /// <summary>
        ///     the value of the "BRXREF_POSITION" field.
        /// </summary>
        public String Position
        {
            get { return _position; }
            set { _position = value; }
        }

        /// <summary>
        ///     the value of the "BRXREF_DISTRICT" field.
        /// </summary>
        public String District
        {
            get { return _district; }
            set { _district = value; }
        }

        /// <summary>
        ///     the value of the "BRXREF_DIS_ID" field.
        /// </summary>
        public String DisId
        {
            get { return _disId; }
            set { _disId = value; }
        }

        /// <summary>
        ///     the value of the "BRXREF_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "BRXREF_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        ///     the value of the "BRXREF_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="BranchXrefRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="BranchXrefRecord" /> object instance.
        /// </returns>
        public BranchXrefRecord Clone()
        {
            BranchXrefRecord record = new BranchXrefRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.RcvFrom = this.RcvFrom;
            record.RcvDate = this.RcvDate;
            record.BrId = this.BrId;
            record.TableName = this.TableName;
            record.RecordId = this.RecordId;
            record.Disabled = this.Disabled;
            record.Position = this.Position;
            record.District = this.District;
            record.DisId = this.DisId;
            record.Status = this.Status;
            record.StartDate = this.StartDate;
            record.EndDate = this.EndDate;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="BranchXrefRecord" /> instance is equal to another <see cref="BranchXrefRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="BranchXrefRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(BranchXrefRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.BrId.TrimOrNullify() == that.BrId.TrimOrNullify());
            result = result && (this.TableName.TrimOrNullify() == that.TableName.TrimOrNullify());
            result = result && (this.RecordId.TrimOrNullify() == that.RecordId.TrimOrNullify());
            result = result && (this.Disabled == that.Disabled);
            result = result && (this.Position.TrimOrNullify() == that.Position.TrimOrNullify());
            result = result && (this.District.TrimOrNullify() == that.District.TrimOrNullify());
            result = result && (this.DisId.TrimOrNullify() == that.DisId.TrimOrNullify());
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.StartDate == that.StartDate);
            result = result && (this.EndDate == that.EndDate);
            return result;
        }

        #endregion
    }
}
