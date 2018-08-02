using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Represents the "LetTmpltType" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class LettmplttypeRecord : Record<String>, Cloneable<LettmplttypeRecord>, IEquatable<LettmplttypeRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "LTT_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "LTT_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "LTT_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "LTT_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "LTT_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "LTT_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "LTT_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "LTT_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "LTT_DESC" field.
        /// </summary>
        private String _desc;

        /// <summary>
        ///     the value of the "LTT_LEVELS" field.
        /// </summary>
        private Int32? _levels;

        /// <summary>
        ///     the value of the "LTT_TYPE" field.
        /// </summary>
        private Byte? _type;

        /// <summary>
        ///     the value of the "LTT_PROC_NAME" field.
        /// </summary>
        private String _procName;

        /// <summary>
        ///     the value of the "LTT_EQUIVALENT" field.
        /// </summary>
        private String _equivalent;

        /// <summary>
        ///     the value of the "LTT_DEFAULT_PR_TYPE" field.
        /// </summary>
        private String _defaultPrType;

        /// <summary>
        ///     the value of the "LTT_URL" field.
        /// </summary>
        private String _url;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "LTT_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "LTT_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "LTT_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "LTT_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "LTT_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "LTT_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "LTT_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "LTT_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "LTT_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        /// <summary>
        ///     the value of the "LTT_LEVELS" field.
        /// </summary>
        public Int32? Levels
        {
            get { return _levels; }
            set { _levels = value; }
        }

        /// <summary>
        ///     the value of the "LTT_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "LTT_PROC_NAME" field.
        /// </summary>
        public String ProcName
        {
            get { return _procName; }
            set { _procName = value; }
        }

        /// <summary>
        ///     the value of the "LTT_EQUIVALENT" field.
        /// </summary>
        public String Equivalent
        {
            get { return _equivalent; }
            set { _equivalent = value; }
        }

        /// <summary>
        ///     the value of the "LTT_DEFAULT_PR_TYPE" field.
        /// </summary>
        public String DefaultPrType
        {
            get { return _defaultPrType; }
            set { _defaultPrType = value; }
        }

        /// <summary>
        ///     the value of the "LTT_URL" field.
        /// </summary>
        public String Url
        {
            get { return _url; }
            set { _url = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="LettmplttypeRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="LettmplttypeRecord" /> object instance.
        /// </returns>
        public LettmplttypeRecord Clone()
        {
            LettmplttypeRecord record = new LettmplttypeRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Name = this.Name;
            record.Desc = this.Desc;
            record.Levels = this.Levels;
            record.Type = this.Type;
            record.ProcName = this.ProcName;
            record.Equivalent = this.Equivalent;
            record.DefaultPrType = this.DefaultPrType;
            record.Url = this.Url;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="LettmplttypeRecord" /> instance is equal to another <see cref="LettmplttypeRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="LettmplttypeRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(LettmplttypeRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Desc.TrimOrNullify() == that.Desc.TrimOrNullify());
            result = result && (this.Levels == that.Levels);
            result = result && (this.Type == that.Type);
            result = result && (this.ProcName.TrimOrNullify() == that.ProcName.TrimOrNullify());
            result = result && (this.Equivalent.TrimOrNullify() == that.Equivalent.TrimOrNullify());
            result = result && (this.DefaultPrType.TrimOrNullify() == that.DefaultPrType.TrimOrNullify());
            result = result && (this.Url.TrimOrNullify() == that.Url.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
