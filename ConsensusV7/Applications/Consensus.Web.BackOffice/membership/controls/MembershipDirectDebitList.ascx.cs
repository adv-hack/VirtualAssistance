using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Web.Controls;
using Consensus.Searches;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class MembershipDirectDebitList : BaseListControl
    {
        #region fields

       

        /// <summary>
        ///     The ID of the current membership period object that the list is linked to.
        /// </summary>
        private String _memberPeriodId;


        #endregion

        #region properties

        
        /// <summary>
        ///     Gets or sets the ID of the current membership period object that the list is linked to.
        /// </summary>
        public String MemberPeriodId
        {
            get { return _memberPeriodId; }
            set { _memberPeriodId = value; }
        }


        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Direct Debit List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.MemberDirectDebitListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("DD_ID")
                    .Select("PROLE_PN_NAME")
                    .Select("DD_RCV_DATE")
                    .Select("DD_DUE_DATE")
                    .Select("DD_END_DATE")
                    .Select("MEP_ID")
                    .Select("MEP_MEM_ID")
                    .Select("DD_STATUS_TEXT")                   
                    .Select("uri")
                    .From(QuerySources.MembershipDirectDebits)                    
                    .Where("MEP_ID", QueryConditionTypes.Equal, this.MemberPeriodId)
                    .OrderBy("DD_ID", true);
            }
        }
        #endregion
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.DataTable.Json = "{ uri: \"finance/directdebit\", MemberPeriodId: " + HttpUtility.JavaScriptStringEncode(this.MemberPeriodId, true) + " }";
        }
    }
}