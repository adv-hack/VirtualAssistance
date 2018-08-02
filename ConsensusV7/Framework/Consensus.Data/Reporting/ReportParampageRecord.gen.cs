using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Represents the "Report_ParamPage" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ReportParampageRecord : Record<Int32>, Cloneable<ReportParampageRecord>, IEquatable<ReportParampageRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "RPP_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "RPP_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "RPP_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "RPP_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "RPP_PAGE_NAME" field.
        /// </summary>
        private String _pageName;

        /// <summary>
        ///     the value of the "RPP_PAGE_PATH" field.
        /// </summary>
        private String _pagePath;

        /// <summary>
        ///     the value of the "RPP_PARAM_DESC" field.
        /// </summary>
        private String _paramDesc;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "RPP_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "RPP_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "RPP_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "RPP_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "RPP_PAGE_NAME" field.
        /// </summary>
        public String PageName
        {
            get { return _pageName; }
            set { _pageName = value; }
        }

        /// <summary>
        ///     the value of the "RPP_PAGE_PATH" field.
        /// </summary>
        public String PagePath
        {
            get { return _pagePath; }
            set { _pagePath = value; }
        }

        /// <summary>
        ///     the value of the "RPP_PARAM_DESC" field.
        /// </summary>
        public String ParamDesc
        {
            get { return _paramDesc; }
            set { _paramDesc = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ReportParampageRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ReportParampageRecord" /> object instance.
        /// </returns>
        public ReportParampageRecord Clone()
        {
            ReportParampageRecord record = new ReportParampageRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.PageName = this.PageName;
            record.PagePath = this.PagePath;
            record.ParamDesc = this.ParamDesc;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ReportParampageRecord" /> instance is equal to another <see cref="ReportParampageRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ReportParampageRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ReportParampageRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.PageName.TrimOrNullify() == that.PageName.TrimOrNullify());
            result = result && (this.PagePath.TrimOrNullify() == that.PagePath.TrimOrNullify());
            result = result && (this.ParamDesc.TrimOrNullify() == that.ParamDesc.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
