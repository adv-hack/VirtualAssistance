using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Searches;
using Consensus.Web.Controls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class MemberBranchList : BaseListControl
    {
        #region fields

        private String _memberPeriodId;        
        #endregion

        #region properties
        /// <summary>
        public String MemberPeriodId
        {
            get { return _memberPeriodId; }
            set { _memberPeriodId = value; }
        }
        
        public override String DataTypeName
        {
            get { return "Branch Membership"; }
        }
        public override DataTable DataTable
        {
            get { return this.MemberBranchLists; }
        }
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("BRXREF_ID")
                    .Select("BR_ID")
                    .Select("BR_NAME")
                    .Select("BRXREF_STATUS")
                    .Select("BRXREF_START_DATE")
                    .Select("BRXREF_END_DATE")
                    .Select("BR_REGION")
                    .Select("BR_TYPE")
                    .Select("BR_Category")
                    .Select("BR_Group")
                    .Select("BR_STATUS")
                    .Select("uri")
                    .From(QuerySources.MembershipBranches)
                    .Where("BRXREF_RECORD_ID", QueryConditionTypes.Equal, this.MemberPeriodId);

            }
        }
        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.MemberBranchLists.Url += "&mepid=" + HttpUtility.UrlEncode(this.MemberPeriodId);
            this.DataTable.Json = "{ uri: \"membership/branchxref\", mepid: " + HttpUtility.JavaScriptStringEncode(this.MemberPeriodId, true) + " }";
        }

        #endregion
    }
}