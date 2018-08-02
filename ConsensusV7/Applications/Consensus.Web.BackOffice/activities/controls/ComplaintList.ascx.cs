using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.activities.controls
{
    public partial class ComplaintList : BaseListControl
    {
        private String _personId;
        public String PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }

        public override String DataTypeName
        {
            get { return "Complaints"; }
        }
        public override DataTable DataTable
        {
            get { return this.ComplaintLists; }
        }
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                .Select("CMPL_ID")
                .Select("CMPL_TITLE")
                .Select("CMPL_STATUS_1")
                .Select("CMPL_DATE_OF_COMPL")
                .Select("CMPL_DATE_NEXT_ACT")
                .Select("FROM_PROLE_PN_NAME")
                .Select("MGR_PROLE_PN_NAME")
                .Select("MEDTR_PROLE_PN_NAME")
                .Select("PERSON_ID_COMPLAINANT")
                .Select("CMPL_FROM_PROLE_ID")
                .Select("PERSON_ID_ASSIGNEE")
                .Select("CMPL_MGR_PROLE_ID")
                .Select("PERSON_ID_OWNER")
                .Select("CMPL_MEDTR_PROLE_ID")
                .Select("uri")
                .From(QuerySources.Complaints)
                .WhereRaw("(PERSON_ID_COMPLAINANT = '" + this.PersonId + "' or PERSON_ID_OWNER = '" + this.PersonId + "' or PERSON_ID_ASSIGNEE = '" + this.PersonId + "')", null)
                .OrderBy("CMPL_DATE_NEXT_ACT", true);
            }
        }
        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.DataTable.Json = "{ uri: \"activities/complaint\", personId: " + HttpUtility.JavaScriptStringEncode(this.PersonId, true) + " }";
        }

        #endregion
    }
}