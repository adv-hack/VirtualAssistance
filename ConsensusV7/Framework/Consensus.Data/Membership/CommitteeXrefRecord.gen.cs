using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Represents the "Committee_Xref" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class CommitteeXrefRecord : Record<String>, Cloneable<CommitteeXrefRecord>, IEquatable<CommitteeXrefRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "COMXREF_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "COMXREF_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "COMXREF_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "COMXREF_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "COMXREF_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "COMXREF_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "COMXREF_COM_ID" field.
        /// </summary>
        private String _comId;

        /// <summary>
        ///     the value of the "COMXREF_TABLE_NAME" field.
        /// </summary>
        private String _tableName;

        /// <summary>
        ///     the value of the "COMXREF_RECORD_ID" field.
        /// </summary>
        private String _recordId;

        /// <summary>
        ///     the value of the "COMXREF_DISABLED" field.
        /// </summary>
        private Byte? _disabled;

        /// <summary>
        ///     the value of the "COMXREF_ROLE" field.
        /// </summary>
        private String _role;

        /// <summary>
        ///     the value of the "COMXREF_DATE" field.
        /// </summary>
        private DateTime? _date;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "COMXREF_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "COMXREF_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "COMXREF_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "COMXREF_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "COMXREF_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "COMXREF_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "COMXREF_COM_ID" field.
        /// </summary>
        public String ComId
        {
            get { return _comId; }
            set { _comId = value; }
        }

        /// <summary>
        ///     the value of the "COMXREF_TABLE_NAME" field.
        /// </summary>
        public String TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        /// <summary>
        ///     the value of the "COMXREF_RECORD_ID" field.
        /// </summary>
        public String RecordId
        {
            get { return _recordId; }
            set { _recordId = value; }
        }

        /// <summary>
        ///     the value of the "COMXREF_DISABLED" field.
        /// </summary>
        public Byte? Disabled
        {
            get { return _disabled; }
            set { _disabled = value; }
        }

        /// <summary>
        ///     the value of the "COMXREF_ROLE" field.
        /// </summary>
        public String Role
        {
            get { return _role; }
            set { _role = value; }
        }

        /// <summary>
        ///     the value of the "COMXREF_DATE" field.
        /// </summary>
        public DateTime? Date
        {
            get { return _date; }
            set { _date = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="CommitteeXrefRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="CommitteeXrefRecord" /> object instance.
        /// </returns>
        public CommitteeXrefRecord Clone()
        {
            CommitteeXrefRecord record = new CommitteeXrefRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.RcvFrom = this.RcvFrom;
            record.RcvDate = this.RcvDate;
            record.ComId = this.ComId;
            record.TableName = this.TableName;
            record.RecordId = this.RecordId;
            record.Disabled = this.Disabled;
            record.Role = this.Role;
            record.Date = this.Date;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="CommitteeXrefRecord" /> instance is equal to another <see cref="CommitteeXrefRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="CommitteeXrefRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(CommitteeXrefRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.ComId.TrimOrNullify() == that.ComId.TrimOrNullify());
            result = result && (this.TableName.TrimOrNullify() == that.TableName.TrimOrNullify());
            result = result && (this.RecordId.TrimOrNullify() == that.RecordId.TrimOrNullify());
            result = result && (this.Disabled == that.Disabled);
            result = result && (this.Role.TrimOrNullify() == that.Role.TrimOrNullify());
            result = result && (this.Date == that.Date);
            return result;
        }

        #endregion
    }
}
