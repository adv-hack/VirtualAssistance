using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents the "Communications_Xref" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class CommunicationsXrefRecord : Record<Int64>, Cloneable<CommunicationsXrefRecord>, IEquatable<CommunicationsXrefRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "COMMXREF_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "COMMXREF_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "COMMXREF_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "COMMXREF_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "COMMXREF_TABLE_NAME" field.
        /// </summary>
        private String _tableName;

        /// <summary>
        ///     the value of the "COMMXREF_RECORD_ID" field.
        /// </summary>
        private String _recordId;

        /// <summary>
        ///     the value of the "COMMXREF_COMM_ID" field.
        /// </summary>
        private Int64 _commId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "COMMXREF_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "COMMXREF_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "COMMXREF_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "COMMXREF_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "COMMXREF_TABLE_NAME" field.
        /// </summary>
        public String TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        /// <summary>
        ///     the value of the "COMMXREF_RECORD_ID" field.
        /// </summary>
        public String RecordId
        {
            get { return _recordId; }
            set { _recordId = value; }
        }

        /// <summary>
        ///     the value of the "COMMXREF_COMM_ID" field.
        /// </summary>
        public Int64 CommId
        {
            get { return _commId; }
            set { _commId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="CommunicationsXrefRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="CommunicationsXrefRecord" /> object instance.
        /// </returns>
        public CommunicationsXrefRecord Clone()
        {
            CommunicationsXrefRecord record = new CommunicationsXrefRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.TableName = this.TableName;
            record.RecordId = this.RecordId;
            record.CommId = this.CommId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="CommunicationsXrefRecord" /> instance is equal to another <see cref="CommunicationsXrefRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="CommunicationsXrefRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(CommunicationsXrefRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.TableName.TrimOrNullify() == that.TableName.TrimOrNullify());
            result = result && (this.RecordId.TrimOrNullify() == that.RecordId.TrimOrNullify());
            result = result && (this.CommId == that.CommId);
            return result;
        }

        #endregion
    }
}
