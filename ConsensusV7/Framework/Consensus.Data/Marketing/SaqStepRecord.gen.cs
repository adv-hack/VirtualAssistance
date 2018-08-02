using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Represents the "SAQ_STEP" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class SaqStepRecord : Record<Int64>, Cloneable<SaqStepRecord>, IEquatable<SaqStepRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "STEP_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "STEP_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "STEP_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "STEP_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "STEP_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "STEP_VISIBILITY" field.
        /// </summary>
        private Byte _visibility;

        /// <summary>
        ///     the value of the "STEP_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "STEP_DESC" field.
        /// </summary>
        private String _desc;

        /// <summary>
        ///     the value of the "STEP_RESULT_SIZE_OPT" field.
        /// </summary>
        private Byte _resultSizeOpt;

        /// <summary>
        ///     the value of the "STEP_RESULT_SIZE" field.
        /// </summary>
        private Int64 _resultSize;

        /// <summary>
        ///     the value of the "STEP_IN_USE" field.
        /// </summary>
        private Byte _inUse;

        /// <summary>
        ///     the value of the "STEP_ORG_ONLY" field.
        /// </summary>
        private Byte _orgOnly;

        /// <summary>
        ///     the value of the "STEP_LOCKED" field.
        /// </summary>
        private Byte _locked;

        /// <summary>
        ///     the value of the "STEP_BOOK_ONLY" field.
        /// </summary>
        private Byte _bookOnly;

        /// <summary>
        ///     the value of the "STEP_LINK_DEFAULT" field.
        /// </summary>
        private String _linkDefault;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "STEP_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "STEP_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "STEP_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "STEP_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "STEP_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "STEP_VISIBILITY" field.
        /// </summary>
        public Byte Visibility
        {
            get { return _visibility; }
            set { _visibility = value; }
        }

        /// <summary>
        ///     the value of the "STEP_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "STEP_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        /// <summary>
        ///     the value of the "STEP_RESULT_SIZE_OPT" field.
        /// </summary>
        public Byte ResultSizeOpt
        {
            get { return _resultSizeOpt; }
            set { _resultSizeOpt = value; }
        }

        /// <summary>
        ///     the value of the "STEP_RESULT_SIZE" field.
        /// </summary>
        public Int64 ResultSize
        {
            get { return _resultSize; }
            set { _resultSize = value; }
        }

        /// <summary>
        ///     the value of the "STEP_IN_USE" field.
        /// </summary>
        public Byte InUse
        {
            get { return _inUse; }
            set { _inUse = value; }
        }

        /// <summary>
        ///     the value of the "STEP_ORG_ONLY" field.
        /// </summary>
        public Byte OrgOnly
        {
            get { return _orgOnly; }
            set { _orgOnly = value; }
        }

        /// <summary>
        ///     the value of the "STEP_LOCKED" field.
        /// </summary>
        public Byte Locked
        {
            get { return _locked; }
            set { _locked = value; }
        }

        /// <summary>
        ///     the value of the "STEP_BOOK_ONLY" field.
        /// </summary>
        public Byte BookOnly
        {
            get { return _bookOnly; }
            set { _bookOnly = value; }
        }

        /// <summary>
        ///     the value of the "STEP_LINK_DEFAULT" field.
        /// </summary>
        public String LinkDefault
        {
            get { return _linkDefault; }
            set { _linkDefault = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="SaqStepRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="SaqStepRecord" /> object instance.
        /// </returns>
        public SaqStepRecord Clone()
        {
            SaqStepRecord record = new SaqStepRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.ProleId = this.ProleId;
            record.Visibility = this.Visibility;
            record.Name = this.Name;
            record.Desc = this.Desc;
            record.ResultSizeOpt = this.ResultSizeOpt;
            record.ResultSize = this.ResultSize;
            record.InUse = this.InUse;
            record.OrgOnly = this.OrgOnly;
            record.Locked = this.Locked;
            record.BookOnly = this.BookOnly;
            record.LinkDefault = this.LinkDefault;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="SaqStepRecord" /> instance is equal to another <see cref="SaqStepRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="SaqStepRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(SaqStepRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.Visibility == that.Visibility);
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Desc.TrimOrNullify() == that.Desc.TrimOrNullify());
            result = result && (this.ResultSizeOpt == that.ResultSizeOpt);
            result = result && (this.ResultSize == that.ResultSize);
            result = result && (this.InUse == that.InUse);
            result = result && (this.OrgOnly == that.OrgOnly);
            result = result && (this.Locked == that.Locked);
            result = result && (this.BookOnly == that.BookOnly);
            result = result && (this.LinkDefault.TrimOrNullify() == that.LinkDefault.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
