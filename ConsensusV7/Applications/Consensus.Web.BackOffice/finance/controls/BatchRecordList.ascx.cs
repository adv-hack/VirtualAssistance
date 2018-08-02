using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class BatchRecordList : BaseListControl
    {
        #region fields

        /// <summary>
        ///     The ID of the person whose roles will be displayed.
        /// </summary>
        private String _batchId;
        #endregion
        #region properties
        /// <summary>
        ///     Gets or sets the ID of the person whose roles will be displayed.
        /// </summary>
        public String BatchId
        {
            get { return _batchId; }
            set { _batchId = value; }
        }
        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Record"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.RecordList; }
        }
        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("BATXR_ID")
                    .Select("BATXR_TABLE_NAME")
                    .Select("BATXR_RECORD_ID")
                    .Select("BATXR_STATUS")
                    .Select("BATXR_LINK_URL")
                    .Select("BATXR_LINK_ID")
                    .Select("BATXR_BAT_ID")
                    .Select("uri")
                    .From(QuerySources.BatchRecords)
                    .Where("BATXR_BAT_ID", QueryConditionTypes.Equal, this.BatchId)
                    .And("BATXR_TABLE_NAME", QueryConditionTypes.NotEqual, "CIPD_InvLines_API");
            }
        }

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}