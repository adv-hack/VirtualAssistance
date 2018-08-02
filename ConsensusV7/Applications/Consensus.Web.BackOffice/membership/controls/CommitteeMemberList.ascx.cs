using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class CommitteeMemberList : BaseListControl
    {
        private string _committeeid;
        public string CommitteeId
        {
            get { return _committeeid; }
            set { _committeeid = value; }
        }
        public override String DataTypeName
        {
            get { return "Committee member"; }
        }
        public override DataTable DataTable
        {
            get { return this.CommitteeMemberLists; }
        }
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("PROLE_PN_NAME")
                    .Select("PROLE_PERSON_ID")
                    .Select("COMXREF_ROLE")
                    .Select("PROLE_PHONE")
                    .Select("PROLE_EMAIL")
                    .Select("PROLE_ORG_NAME")
                    .Select("PROLE_ORG_ID")
                    .Select("COMXREF_DATE")
                    .Select("uri")
                    .From(QuerySources.CommitteeMember)
                    .Where("COMXREF_COM_ID", QueryConditionTypes.Equal, this.CommitteeId);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.CommitteeMemberLists.Url += "&comid=" + HttpUtility.UrlEncode(this.CommitteeId);
            this.DataTable.Json = "{uri:\"membership/committeexref\",comid:" + HttpUtility.JavaScriptStringEncode(this.CommitteeId, true) + "}";
        }
        
    }
}