using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Represents the "Report" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ReportRecord : Record<String>, Cloneable<ReportRecord>, IEquatable<ReportRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "REP_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "REP_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "REP_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "REP_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "REP_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "REP_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "REP_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "REP_DESCRIPTION" field.
        /// </summary>
        private String _description;

        /// <summary>
        ///     the value of the "REP_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "REP_CAT" field.
        /// </summary>
        private String _cat;

        /// <summary>
        ///     the value of the "REP_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "REP_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "REP_LEVEL" field.
        /// </summary>
        private Byte? _level;

        /// <summary>
        ///     the value of the "REP_CONNECTION" field.
        /// </summary>
        private Byte? _connection;

        /// <summary>
        ///     the value of the "REP_CURRENT" field.
        /// </summary>
        private Byte _current;

        /// <summary>
        ///     the value of the "REP_GEN_PARAMETERS" field.
        /// </summary>
        private Byte _genParameters;

        /// <summary>
        ///     the value of the "REP_RPTP_ID" field.
        /// </summary>
        private Int32? _rptpId;

        /// <summary>
        ///     the value of the "REP_RPP_ID" field.
        /// </summary>
        private Int32? _rppId;

        /// <summary>
        ///     the value of the "REP_SYSTEM" field.
        /// </summary>
        private Byte _system;

        /// <summary>
        ///     the value of the "REP_STANDARD" field.
        /// </summary>
        private Byte _standard;

        /// <summary>
        ///     the value of the "REP_CN_ID" field.
        /// </summary>
        private String _cnId;

        /// <summary>
        ///     the value of the "REP_SSRS_PARAMETERS" field.
        /// </summary>
        private Byte _ssrsParameters;

        /// <summary>
        ///     the value of the "REP_CREATED_BY_V1" field.
        /// </summary>
        private Boolean _createdByV1;

        /// <summary>
        ///     the value of the "REP_PMENU_ID" field.
        /// </summary>
        private Int32? _pmenuId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "REP_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "REP_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "REP_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "REP_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "REP_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "REP_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "REP_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "REP_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        ///     the value of the "REP_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "REP_CAT" field.
        /// </summary>
        public String Cat
        {
            get { return _cat; }
            set { _cat = value; }
        }

        /// <summary>
        ///     the value of the "REP_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "REP_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "REP_LEVEL" field.
        /// </summary>
        public Byte? Level
        {
            get { return _level; }
            set { _level = value; }
        }

        /// <summary>
        ///     the value of the "REP_CONNECTION" field.
        /// </summary>
        public Byte? Connection
        {
            get { return _connection; }
            set { _connection = value; }
        }

        /// <summary>
        ///     the value of the "REP_CURRENT" field.
        /// </summary>
        public Byte Current
        {
            get { return _current; }
            set { _current = value; }
        }

        /// <summary>
        ///     the value of the "REP_GEN_PARAMETERS" field.
        /// </summary>
        public Byte GenParameters
        {
            get { return _genParameters; }
            set { _genParameters = value; }
        }

        /// <summary>
        ///     the value of the "REP_RPTP_ID" field.
        /// </summary>
        public Int32? RptpId
        {
            get { return _rptpId; }
            set { _rptpId = value; }
        }

        /// <summary>
        ///     the value of the "REP_RPP_ID" field.
        /// </summary>
        public Int32? RppId
        {
            get { return _rppId; }
            set { _rppId = value; }
        }

        /// <summary>
        ///     the value of the "REP_SYSTEM" field.
        /// </summary>
        public Byte System
        {
            get { return _system; }
            set { _system = value; }
        }

        /// <summary>
        ///     the value of the "REP_STANDARD" field.
        /// </summary>
        public Byte Standard
        {
            get { return _standard; }
            set { _standard = value; }
        }

        /// <summary>
        ///     the value of the "REP_CN_ID" field.
        /// </summary>
        public String CnId
        {
            get { return _cnId; }
            set { _cnId = value; }
        }

        /// <summary>
        ///     the value of the "REP_SSRS_PARAMETERS" field.
        /// </summary>
        public Byte SsrsParameters
        {
            get { return _ssrsParameters; }
            set { _ssrsParameters = value; }
        }

        /// <summary>
        ///     the value of the "REP_CREATED_BY_V1" field.
        /// </summary>
        public Boolean CreatedByV1
        {
            get { return _createdByV1; }
            set { _createdByV1 = value; }
        }

        /// <summary>
        ///     the value of the "REP_PMENU_ID" field.
        /// </summary>
        public Int32? PmenuId
        {
            get { return _pmenuId; }
            set { _pmenuId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ReportRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ReportRecord" /> object instance.
        /// </returns>
        public ReportRecord Clone()
        {
            ReportRecord record = new ReportRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Description = this.Description;
            record.Name = this.Name;
            record.Cat = this.Cat;
            record.Type = this.Type;
            record.Notes = this.Notes;
            record.Level = this.Level;
            record.Connection = this.Connection;
            record.Current = this.Current;
            record.GenParameters = this.GenParameters;
            record.RptpId = this.RptpId;
            record.RppId = this.RppId;
            record.System = this.System;
            record.Standard = this.Standard;
            record.CnId = this.CnId;
            record.SsrsParameters = this.SsrsParameters;
            record.CreatedByV1 = this.CreatedByV1;
            record.PmenuId = this.PmenuId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ReportRecord" /> instance is equal to another <see cref="ReportRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ReportRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ReportRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Description.TrimOrNullify() == that.Description.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Cat.TrimOrNullify() == that.Cat.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.Level == that.Level);
            result = result && (this.Connection == that.Connection);
            result = result && (this.Current == that.Current);
            result = result && (this.GenParameters == that.GenParameters);
            result = result && (this.RptpId == that.RptpId);
            result = result && (this.RppId == that.RppId);
            result = result && (this.System == that.System);
            result = result && (this.Standard == that.Standard);
            result = result && (this.CnId.TrimOrNullify() == that.CnId.TrimOrNullify());
            result = result && (this.SsrsParameters == that.SsrsParameters);
            result = result && (this.CreatedByV1 == that.CreatedByV1);
            result = result && (this.PmenuId == that.PmenuId);
            return result;
        }

        #endregion
    }
}
