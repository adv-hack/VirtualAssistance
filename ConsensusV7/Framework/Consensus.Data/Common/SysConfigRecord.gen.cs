using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Represents the "SYS_CONFIG" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class SysConfigRecord : Record<Int32>, Cloneable<SysConfigRecord>, IEquatable<SysConfigRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "SC_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "SC_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "SC_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "SC_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "SC_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "SC_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "SC_SP_ID" field.
        /// </summary>
        private String _spId;

        /// <summary>
        ///     the value of the "SC_KEY_NAME" field.
        /// </summary>
        private String _keyName;

        /// <summary>
        ///     the value of the "SC_VALUE_TO_USE" field.
        /// </summary>
        private Byte? _valueToUse;

        /// <summary>
        ///     the value of the "SC_LABEL_NAME" field.
        /// </summary>
        private String _labelName;

        /// <summary>
        ///     the value of the "SC_CHAR_VALUE" field.
        /// </summary>
        private String _charValue;

        /// <summary>
        ///     the value of the "SC_RECORD_ID" field.
        /// </summary>
        private String _recordId;

        /// <summary>
        ///     the value of the "SC_INT_VALUE" field.
        /// </summary>
        private Int32? _intValue;

        /// <summary>
        ///     the value of the "SC_DATETIME_VALUE" field.
        /// </summary>
        private DateTime? _datetimeValue;

        /// <summary>
        ///     the value of the "SC_DECIMAL_VALUE" field.
        /// </summary>
        private Decimal? _decimalValue;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "SC_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "SC_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "SC_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "SC_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "SC_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "SC_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "SC_SP_ID" field.
        /// </summary>
        public String SpId
        {
            get { return _spId; }
            set { _spId = value; }
        }

        /// <summary>
        ///     the value of the "SC_KEY_NAME" field.
        /// </summary>
        public String KeyName
        {
            get { return _keyName; }
            set { _keyName = value; }
        }

        /// <summary>
        ///     the value of the "SC_VALUE_TO_USE" field.
        /// </summary>
        public Byte? ValueToUse
        {
            get { return _valueToUse; }
            set { _valueToUse = value; }
        }

        /// <summary>
        ///     the value of the "SC_LABEL_NAME" field.
        /// </summary>
        public String LabelName
        {
            get { return _labelName; }
            set { _labelName = value; }
        }

        /// <summary>
        ///     the value of the "SC_CHAR_VALUE" field.
        /// </summary>
        public String CharValue
        {
            get { return _charValue; }
            set { _charValue = value; }
        }

        /// <summary>
        ///     the value of the "SC_RECORD_ID" field.
        /// </summary>
        public String RecordId
        {
            get { return _recordId; }
            set { _recordId = value; }
        }

        /// <summary>
        ///     the value of the "SC_INT_VALUE" field.
        /// </summary>
        public Int32? IntValue
        {
            get { return _intValue; }
            set { _intValue = value; }
        }

        /// <summary>
        ///     the value of the "SC_DATETIME_VALUE" field.
        /// </summary>
        public DateTime? DatetimeValue
        {
            get { return _datetimeValue; }
            set { _datetimeValue = value; }
        }

        /// <summary>
        ///     the value of the "SC_DECIMAL_VALUE" field.
        /// </summary>
        public Decimal? DecimalValue
        {
            get { return _decimalValue; }
            set { _decimalValue = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="SysConfigRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="SysConfigRecord" /> object instance.
        /// </returns>
        public SysConfigRecord Clone()
        {
            SysConfigRecord record = new SysConfigRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.SpId = this.SpId;
            record.KeyName = this.KeyName;
            record.ValueToUse = this.ValueToUse;
            record.LabelName = this.LabelName;
            record.CharValue = this.CharValue;
            record.RecordId = this.RecordId;
            record.IntValue = this.IntValue;
            record.DatetimeValue = this.DatetimeValue;
            record.DecimalValue = this.DecimalValue;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="SysConfigRecord" /> instance is equal to another <see cref="SysConfigRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="SysConfigRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(SysConfigRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.SpId.TrimOrNullify() == that.SpId.TrimOrNullify());
            result = result && (this.KeyName.TrimOrNullify() == that.KeyName.TrimOrNullify());
            result = result && (this.ValueToUse == that.ValueToUse);
            result = result && (this.LabelName.TrimOrNullify() == that.LabelName.TrimOrNullify());
            result = result && (this.CharValue.TrimOrNullify() == that.CharValue.TrimOrNullify());
            result = result && (this.RecordId.TrimOrNullify() == that.RecordId.TrimOrNullify());
            result = result && (this.IntValue == that.IntValue);
            result = result && (this.DatetimeValue == that.DatetimeValue);
            result = result && (this.DecimalValue == that.DecimalValue);
            return result;
        }

        #endregion
    }
}
