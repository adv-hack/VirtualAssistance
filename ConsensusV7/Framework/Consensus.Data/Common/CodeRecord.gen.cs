using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Represents the "Code" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class CodeRecord : Record<String>, Cloneable<CodeRecord>, IEquatable<CodeRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "CODE_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "CODE_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "CODE_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "CODE_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "CODE_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "CODE_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "CODE_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "CODE_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "CODE_VALUE1" field.
        /// </summary>
        private String _value1;

        /// <summary>
        ///     the value of the "CODE_VALUE2" field.
        /// </summary>
        private String _value2;

        /// <summary>
        ///     the value of the "CODE_VALUE3" field.
        /// </summary>
        private String _value3;

        /// <summary>
        ///     the value of the "CODE_DESCRIPTION" field.
        /// </summary>
        private String _description;

        /// <summary>
        ///     the value of the "CODE_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "CODE_VALUE4" field.
        /// </summary>
        private String _value4;

        /// <summary>
        ///     the value of the "CODE_SYSTEM" field.
        /// </summary>
        private Byte? _system;

        /// <summary>
        ///     the value of the "CODE_DELETED" field.
        /// </summary>
        private Byte? _deleted;

        /// <summary>
        ///     the value of the "CODE_INSTRUCT" field.
        /// </summary>
        private String _instruct;

        /// <summary>
        ///     the value of the "CODE_READ_ONLY" field.
        /// </summary>
        private Byte? _readOnly;

        /// <summary>
        ///     the value of the "CODE_ORIG_VALUE" field.
        /// </summary>
        private String _origValue;

        /// <summary>
        ///     the value of the "CODE_VALUE5" field.
        /// </summary>
        private String _value5;

        /// <summary>
        ///     the value of the "CODE_ORDER" field.
        /// </summary>
        private Int32 _order;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "CODE_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "CODE_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "CODE_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "CODE_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "CODE_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "CODE_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "CODE_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "CODE_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "CODE_VALUE1" field.
        /// </summary>
        public String Value1
        {
            get { return _value1; }
            set { _value1 = value; }
        }

        /// <summary>
        ///     the value of the "CODE_VALUE2" field.
        /// </summary>
        public String Value2
        {
            get { return _value2; }
            set { _value2 = value; }
        }

        /// <summary>
        ///     the value of the "CODE_VALUE3" field.
        /// </summary>
        public String Value3
        {
            get { return _value3; }
            set { _value3 = value; }
        }

        /// <summary>
        ///     the value of the "CODE_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        ///     the value of the "CODE_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "CODE_VALUE4" field.
        /// </summary>
        public String Value4
        {
            get { return _value4; }
            set { _value4 = value; }
        }

        /// <summary>
        ///     the value of the "CODE_SYSTEM" field.
        /// </summary>
        public Byte? System
        {
            get { return _system; }
            set { _system = value; }
        }

        /// <summary>
        ///     the value of the "CODE_DELETED" field.
        /// </summary>
        public Byte? Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

        /// <summary>
        ///     the value of the "CODE_INSTRUCT" field.
        /// </summary>
        public String Instruct
        {
            get { return _instruct; }
            set { _instruct = value; }
        }

        /// <summary>
        ///     the value of the "CODE_READ_ONLY" field.
        /// </summary>
        public Byte? ReadOnly
        {
            get { return _readOnly; }
            set { _readOnly = value; }
        }

        /// <summary>
        ///     the value of the "CODE_ORIG_VALUE" field.
        /// </summary>
        public String OrigValue
        {
            get { return _origValue; }
            set { _origValue = value; }
        }

        /// <summary>
        ///     the value of the "CODE_VALUE5" field.
        /// </summary>
        public String Value5
        {
            get { return _value5; }
            set { _value5 = value; }
        }

        /// <summary>
        ///     the value of the "CODE_ORDER" field.
        /// </summary>
        public Int32 Order
        {
            get { return _order; }
            set { _order = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="CodeRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="CodeRecord" /> object instance.
        /// </returns>
        public CodeRecord Clone()
        {
            CodeRecord record = new CodeRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Type = this.Type;
            record.Value1 = this.Value1;
            record.Value2 = this.Value2;
            record.Value3 = this.Value3;
            record.Description = this.Description;
            record.Notes = this.Notes;
            record.Value4 = this.Value4;
            record.System = this.System;
            record.Deleted = this.Deleted;
            record.Instruct = this.Instruct;
            record.ReadOnly = this.ReadOnly;
            record.OrigValue = this.OrigValue;
            record.Value5 = this.Value5;
            record.Order = this.Order;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="CodeRecord" /> instance is equal to another <see cref="CodeRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="CodeRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(CodeRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.Value1.TrimOrNullify() == that.Value1.TrimOrNullify());
            result = result && (this.Value2.TrimOrNullify() == that.Value2.TrimOrNullify());
            result = result && (this.Value3.TrimOrNullify() == that.Value3.TrimOrNullify());
            result = result && (this.Description.TrimOrNullify() == that.Description.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.Value4.TrimOrNullify() == that.Value4.TrimOrNullify());
            result = result && (this.System == that.System);
            result = result && (this.Deleted == that.Deleted);
            result = result && (this.Instruct.TrimOrNullify() == that.Instruct.TrimOrNullify());
            result = result && (this.ReadOnly == that.ReadOnly);
            result = result && (this.OrigValue.TrimOrNullify() == that.OrigValue.TrimOrNullify());
            result = result && (this.Value5.TrimOrNullify() == that.Value5.TrimOrNullify());
            result = result && (this.Order == that.Order);
            return result;
        }

        #endregion
    }
}
