using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Represents the "Report_Page" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ReportPageRecord : Record<Int32>, Cloneable<ReportPageRecord>, IEquatable<ReportPageRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "RPTP_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "RPTP_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "RPTP_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "RPTP_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "RPTP_PAGE_NAME" field.
        /// </summary>
        private String _pageName;

        /// <summary>
        ///     the value of the "RPTP_PAGE_PATH" field.
        /// </summary>
        private String _pagePath;

        /// <summary>
        ///     the value of the "RPTP_SECTION" field.
        /// </summary>
        private String _section;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "RPTP_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "RPTP_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "RPTP_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "RPTP_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "RPTP_PAGE_NAME" field.
        /// </summary>
        public String PageName
        {
            get { return _pageName; }
            set { _pageName = value; }
        }

        /// <summary>
        ///     the value of the "RPTP_PAGE_PATH" field.
        /// </summary>
        public String PagePath
        {
            get { return _pagePath; }
            set { _pagePath = value; }
        }

        /// <summary>
        ///     the value of the "RPTP_SECTION" field.
        /// </summary>
        public String Section
        {
            get { return _section; }
            set { _section = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ReportPageRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ReportPageRecord" /> object instance.
        /// </returns>
        public ReportPageRecord Clone()
        {
            ReportPageRecord record = new ReportPageRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.PageName = this.PageName;
            record.PagePath = this.PagePath;
            record.Section = this.Section;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ReportPageRecord" /> instance is equal to another <see cref="ReportPageRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ReportPageRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ReportPageRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.PageName.TrimOrNullify() == that.PageName.TrimOrNullify());
            result = result && (this.PagePath.TrimOrNullify() == that.PagePath.TrimOrNullify());
            result = result && (this.Section.TrimOrNullify() == that.Section.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
