using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Represents the "Literature" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class LiteratureRecord : Record<String>, Cloneable<LiteratureRecord>, IEquatable<LiteratureRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "LIT_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "LIT_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "LIT_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "LIT_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "LIT_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "LIT_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "LIT_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "LIT_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "LIT_COST" field.
        /// </summary>
        private Double? _cost;

        /// <summary>
        ///     the value of the "LIT_TEMPLATE" field.
        /// </summary>
        private String _template;

        /// <summary>
        ///     the value of the "LIT_EXAM" field.
        /// </summary>
        private Byte? _exam;

        /// <summary>
        ///     the value of the "LIT_ATTENDANCE" field.
        /// </summary>
        private Byte? _attendance;

        /// <summary>
        ///     the value of the "LIT_TYPE" field.
        /// </summary>
        private Byte? _type;

        /// <summary>
        ///     the value of the "LIT_CURRENT" field.
        /// </summary>
        private Byte? _current;

        /// <summary>
        ///     the value of the "LIT_LT_ID" field.
        /// </summary>
        private String _ltId;

        /// <summary>
        ///     the value of the "LIT_SEND_OVERRIDE" field.
        /// </summary>
        private Byte? _sendOverride;

        /// <summary>
        ///     the value of the "LIT_EMAIL_ONLY" field.
        /// </summary>
        private Byte _emailOnly;

        /// <summary>
        ///     the value of the "LIT_PRINT_ONLY" field.
        /// </summary>
        private Byte _printOnly;

        /// <summary>
        ///     the value of the "LIT_FILE_NAME" field.
        /// </summary>
        private String _fileName;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "LIT_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "LIT_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "LIT_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "LIT_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "LIT_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "LIT_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "LIT_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "LIT_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "LIT_COST" field.
        /// </summary>
        public Double? Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        /// <summary>
        ///     the value of the "LIT_TEMPLATE" field.
        /// </summary>
        public String Template
        {
            get { return _template; }
            set { _template = value; }
        }

        /// <summary>
        ///     the value of the "LIT_EXAM" field.
        /// </summary>
        public Byte? Exam
        {
            get { return _exam; }
            set { _exam = value; }
        }

        /// <summary>
        ///     the value of the "LIT_ATTENDANCE" field.
        /// </summary>
        public Byte? Attendance
        {
            get { return _attendance; }
            set { _attendance = value; }
        }

        /// <summary>
        ///     the value of the "LIT_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "LIT_CURRENT" field.
        /// </summary>
        public Byte? Current
        {
            get { return _current; }
            set { _current = value; }
        }

        /// <summary>
        ///     the value of the "LIT_LT_ID" field.
        /// </summary>
        public String LtId
        {
            get { return _ltId; }
            set { _ltId = value; }
        }

        /// <summary>
        ///     the value of the "LIT_SEND_OVERRIDE" field.
        /// </summary>
        public Byte? SendOverride
        {
            get { return _sendOverride; }
            set { _sendOverride = value; }
        }

        /// <summary>
        ///     the value of the "LIT_EMAIL_ONLY" field.
        /// </summary>
        public Byte EmailOnly
        {
            get { return _emailOnly; }
            set { _emailOnly = value; }
        }

        /// <summary>
        ///     the value of the "LIT_PRINT_ONLY" field.
        /// </summary>
        public Byte PrintOnly
        {
            get { return _printOnly; }
            set { _printOnly = value; }
        }

        /// <summary>
        ///     the value of the "LIT_FILE_NAME" field.
        /// </summary>
        public String FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="LiteratureRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="LiteratureRecord" /> object instance.
        /// </returns>
        public LiteratureRecord Clone()
        {
            LiteratureRecord record = new LiteratureRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Name = this.Name;
            record.Cost = this.Cost;
            record.Template = this.Template;
            record.Exam = this.Exam;
            record.Attendance = this.Attendance;
            record.Type = this.Type;
            record.Current = this.Current;
            record.LtId = this.LtId;
            record.SendOverride = this.SendOverride;
            record.EmailOnly = this.EmailOnly;
            record.PrintOnly = this.PrintOnly;
            record.FileName = this.FileName;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="LiteratureRecord" /> instance is equal to another <see cref="LiteratureRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="LiteratureRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(LiteratureRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Cost == that.Cost);
            result = result && (this.Template.TrimOrNullify() == that.Template.TrimOrNullify());
            result = result && (this.Exam == that.Exam);
            result = result && (this.Attendance == that.Attendance);
            result = result && (this.Type == that.Type);
            result = result && (this.Current == that.Current);
            result = result && (this.LtId.TrimOrNullify() == that.LtId.TrimOrNullify());
            result = result && (this.SendOverride == that.SendOverride);
            result = result && (this.EmailOnly == that.EmailOnly);
            result = result && (this.PrintOnly == that.PrintOnly);
            result = result && (this.FileName.TrimOrNullify() == that.FileName.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
