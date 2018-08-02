using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     The link between a batch record and the associated record.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class BatchXrefRecord : Record<Int32>, Cloneable<BatchXrefRecord>, IEquatable<BatchXrefRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "BATXR_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "BATXR_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "BATXR_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "BATXR_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "BATXR_RCV_DATE" field.
        /// </summary>
        private DateTime _rcvDate;

        /// <summary>
        ///     the value of the "BATXR_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "BATXR_BAT_ID" field.
        /// </summary>
        private String _batId;

        /// <summary>
        ///     the value of the "BATXR_RECORD_ID" field.
        /// </summary>
        private String _recordId;

        /// <summary>
        ///     the value of the "BATXR_TABLE_NAME" field.
        /// </summary>
        private String _tableName;

        /// <summary>
        ///     the value of the "BATXR_LINK_ID" field.
        /// </summary>
        private String _linkId;

        /// <summary>
        ///     the value of the "BATXR_LINK_URL" field.
        /// </summary>
        private String _linkUrl;

        /// <summary>
        ///     the value of the "BATXR_STATUS" field.
        /// </summary>
        private Byte _status;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "BATXR_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "BATXR_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "BATXR_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "BATXR_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "BATXR_RCV_DATE" field.
        /// </summary>
        public DateTime RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "BATXR_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "BATXR_BAT_ID" field.
        /// </summary>
        public String BatId
        {
            get { return _batId; }
            set { _batId = value; }
        }

        /// <summary>
        ///     the value of the "BATXR_RECORD_ID" field.
        /// </summary>
        public String RecordId
        {
            get { return _recordId; }
            set { _recordId = value; }
        }

        /// <summary>
        ///     the value of the "BATXR_TABLE_NAME" field.
        /// </summary>
        public String TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        /// <summary>
        ///     the value of the "BATXR_LINK_ID" field.
        /// </summary>
        public String LinkId
        {
            get { return _linkId; }
            set { _linkId = value; }
        }

        /// <summary>
        ///     the value of the "BATXR_LINK_URL" field.
        /// </summary>
        public String LinkUrl
        {
            get { return _linkUrl; }
            set { _linkUrl = value; }
        }

        /// <summary>
        ///     the value of the "BATXR_STATUS" field.
        /// </summary>
        public Byte Status
        {
            get { return _status; }
            set { _status = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="BatchXrefRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="BatchXrefRecord" /> object instance.
        /// </returns>
        public BatchXrefRecord Clone()
        {
            BatchXrefRecord record = new BatchXrefRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.BatId = this.BatId;
            record.RecordId = this.RecordId;
            record.TableName = this.TableName;
            record.LinkId = this.LinkId;
            record.LinkUrl = this.LinkUrl;
            record.Status = this.Status;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="BatchXrefRecord" /> instance is equal to another <see cref="BatchXrefRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="BatchXrefRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(BatchXrefRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.BatId.TrimOrNullify() == that.BatId.TrimOrNullify());
            result = result && (this.RecordId.TrimOrNullify() == that.RecordId.TrimOrNullify());
            result = result && (this.TableName.TrimOrNullify() == that.TableName.TrimOrNullify());
            result = result && (this.LinkId.TrimOrNullify() == that.LinkId.TrimOrNullify());
            result = result && (this.LinkUrl.TrimOrNullify() == that.LinkUrl.TrimOrNullify());
            result = result && (this.Status == that.Status);
            return result;
        }

        #endregion
    }
}
