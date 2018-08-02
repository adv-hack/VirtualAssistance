using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Represents the "Sales_Channel" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class SalesChannelRecord : Record<String>, Cloneable<SalesChannelRecord>, IEquatable<SalesChannelRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "SCHN_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "SCHN_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "SCHN_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "SCHN_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "SCHN_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "SCHN_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "SCHN_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "SCHN_NUMBER" field.
        /// </summary>
        private Byte? _number;

        /// <summary>
        ///     the value of the "SCHN_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "SCHN_REF" field.
        /// </summary>
        private String _ref;

        /// <summary>
        ///     the value of the "SCHN_PL_ID" field.
        /// </summary>
        private String _plId;

        /// <summary>
        ///     the value of the "SCHN_STATE" field.
        /// </summary>
        private Byte? _state;

        /// <summary>
        ///     the value of the "SCHN_CUTOFF_TIME" field.
        /// </summary>
        private DateTime? _cutoffTime;

        /// <summary>
        ///     the value of the "SCHN_TIMEOUT" field.
        /// </summary>
        private Int32? _timeout;

        /// <summary>
        ///     the value of the "SCHN_NO_BOOK" field.
        /// </summary>
        private Byte? _noBook;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "SCHN_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "SCHN_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "SCHN_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "SCHN_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "SCHN_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "SCHN_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "SCHN_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "SCHN_NUMBER" field.
        /// </summary>
        public Byte? Number
        {
            get { return _number; }
            set { _number = value; }
        }

        /// <summary>
        ///     the value of the "SCHN_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "SCHN_REF" field.
        /// </summary>
        public String Ref
        {
            get { return _ref; }
            set { _ref = value; }
        }

        /// <summary>
        ///     the value of the "SCHN_PL_ID" field.
        /// </summary>
        public String PlId
        {
            get { return _plId; }
            set { _plId = value; }
        }

        /// <summary>
        ///     the value of the "SCHN_STATE" field.
        /// </summary>
        public Byte? State
        {
            get { return _state; }
            set { _state = value; }
        }

        /// <summary>
        ///     the value of the "SCHN_CUTOFF_TIME" field.
        /// </summary>
        public DateTime? CutoffTime
        {
            get { return _cutoffTime; }
            set { _cutoffTime = value; }
        }

        /// <summary>
        ///     the value of the "SCHN_TIMEOUT" field.
        /// </summary>
        public Int32? Timeout
        {
            get { return _timeout; }
            set { _timeout = value; }
        }

        /// <summary>
        ///     the value of the "SCHN_NO_BOOK" field.
        /// </summary>
        public Byte? NoBook
        {
            get { return _noBook; }
            set { _noBook = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="SalesChannelRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="SalesChannelRecord" /> object instance.
        /// </returns>
        public SalesChannelRecord Clone()
        {
            SalesChannelRecord record = new SalesChannelRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Number = this.Number;
            record.Name = this.Name;
            record.Ref = this.Ref;
            record.PlId = this.PlId;
            record.State = this.State;
            record.CutoffTime = this.CutoffTime;
            record.Timeout = this.Timeout;
            record.NoBook = this.NoBook;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="SalesChannelRecord" /> instance is equal to another <see cref="SalesChannelRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="SalesChannelRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(SalesChannelRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Number == that.Number);
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Ref.TrimOrNullify() == that.Ref.TrimOrNullify());
            result = result && (this.PlId.TrimOrNullify() == that.PlId.TrimOrNullify());
            result = result && (this.State == that.State);
            result = result && (this.CutoffTime == that.CutoffTime);
            result = result && (this.Timeout == that.Timeout);
            result = result && (this.NoBook == that.NoBook);
            return result;
        }

        #endregion
    }
}
