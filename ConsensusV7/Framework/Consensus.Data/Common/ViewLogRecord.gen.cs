using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Represents the "VIEW_LOG" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ViewLogRecord : Record<Int32>, Cloneable<ViewLogRecord>, IEquatable<ViewLogRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "VIEW_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "VIEW_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "VIEW_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "VIEW_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "VIEW_RCV_DATE" field.
        /// </summary>
        private DateTime _rcvDate;

        /// <summary>
        ///     the value of the "VIEW_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "VIEW_TABLE" field.
        /// </summary>
        private String _table;

        /// <summary>
        ///     the value of the "VIEW_REC_ID" field.
        /// </summary>
        private String _recId;

        /// <summary>
        ///     the value of the "VIEW_SOURCE" field.
        /// </summary>
        private Byte _source;

        /// <summary>
        ///     the value of the "VIEW_TYPE" field.
        /// </summary>
        private Byte _type;

        /// <summary>
        ///     the value of the "VIEW_REC_ID2" field.
        /// </summary>
        private String _recId2;

        /// <summary>
        ///     the value of the "VIEW_TABLE2" field.
        /// </summary>
        private String _table2;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "VIEW_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "VIEW_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "VIEW_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "VIEW_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "VIEW_RCV_DATE" field.
        /// </summary>
        public DateTime RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "VIEW_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "VIEW_TABLE" field.
        /// </summary>
        public String Table
        {
            get { return _table; }
            set { _table = value; }
        }

        /// <summary>
        ///     the value of the "VIEW_REC_ID" field.
        /// </summary>
        public String RecId
        {
            get { return _recId; }
            set { _recId = value; }
        }

        /// <summary>
        ///     the value of the "VIEW_SOURCE" field.
        /// </summary>
        public Byte Source
        {
            get { return _source; }
            set { _source = value; }
        }

        /// <summary>
        ///     the value of the "VIEW_TYPE" field.
        /// </summary>
        public Byte Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "VIEW_REC_ID2" field.
        /// </summary>
        public String RecId2
        {
            get { return _recId2; }
            set { _recId2 = value; }
        }

        /// <summary>
        ///     the value of the "VIEW_TABLE2" field.
        /// </summary>
        public String Table2
        {
            get { return _table2; }
            set { _table2 = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ViewLogRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ViewLogRecord" /> object instance.
        /// </returns>
        public ViewLogRecord Clone()
        {
            ViewLogRecord record = new ViewLogRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Table = this.Table;
            record.RecId = this.RecId;
            record.Source = this.Source;
            record.Type = this.Type;
            record.RecId2 = this.RecId2;
            record.Table2 = this.Table2;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ViewLogRecord" /> instance is equal to another <see cref="ViewLogRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ViewLogRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ViewLogRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.Table.TrimOrNullify() == that.Table.TrimOrNullify());
            result = result && (this.RecId.TrimOrNullify() == that.RecId.TrimOrNullify());
            result = result && (this.Source == that.Source);
            result = result && (this.Type == that.Type);
            result = result && (this.RecId2.TrimOrNullify() == that.RecId2.TrimOrNullify());
            result = result && (this.Table2.TrimOrNullify() == that.Table2.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
