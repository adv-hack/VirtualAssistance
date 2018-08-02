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
    public partial class CommitteeList : BaseListControl
    {
        private string _branchid;
        public string BranchId
        {
            get { return _branchid; }
            set { _branchid = value; }
        }
        public override String DataTypeName
        {
            get { return "Committees"; }
        }
        public override DataTable DataTable
        {
            get { return this.CommitteesLists; }
        }
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                 .Select("COM_NAME")
                 .Select("COM_STATUS")
                 .Select("COM_TYPE")
                 .Select("COM_CATEGORY")
                 .Select("COM_GROUP")
                 .Select("COM_BR_ID")
                 .Select("uri")
                 .From(QuerySources.BranchCommittees)
                 .Where("COM_BR_ID", QueryConditionTypes.Equal, this.BranchId);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.CommitteesLists.Url += "&brid=" + HttpUtility.UrlEncode(this.BranchId);
            this.DataTable.Json = "{uri:\"membership/committee\", bridid:" + HttpUtility.JavaScriptStringEncode(this.BranchId, true) + " }";
        }
    }
}