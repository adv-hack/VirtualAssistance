using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Web.Controls;
using Consensus.Searches;

namespace Consensus.Web.BackOffice.activities.controls
{
    public partial class InfoRequestList : BaseListControl
    {
        #region Properties

        private string _personId;

        public string PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }

        public override string DataTypeName
        {
            get
            {
                return "Information Request List";
            }
        }

        public override DataTable DataTable
        {
            get
            {
                return this.InfoRequestLists;
            }
        }

        public override object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("HD_ID")
                    .Select("HD_TITLE")
                    .Select("HD_CATEGORY")
                    .Select("HD_STATUS")
                    .Select("HD_PROLE_PN_NAME")
                    .Select("HD_GIVEN_TO_PN_NAME")
                    .Select("HD_ADD_DATE")
                    .Select("HD_FIXED_DATE")
                    .Select("PERSON_ID_REQUESTED_BY")
                    .Select("PERSON_ID_GIVEN_TO")
                    .Select("HD_RES_DATE")
                    .Select("uri")
                    .From(QuerySources.InfoRequest)
                    .WhereRaw("(PERSON_ID_REQUESTED_BY='" + this.PersonId + "' or PERSON_ID_GIVEN_TO='" + this.PersonId + "')", null)
                    .OrderBy("HD_STATUS", true)
                    .ThenBy("HD_ADD_DATE", true);

            }
        }

        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.DataTable.Json = "{ uri: \"activities/helpdesk\", personId: " + HttpUtility.JavaScriptStringEncode(this.PersonId, true) + " }";
        }

        #endregion
    }
}