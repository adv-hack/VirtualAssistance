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
    public partial class BranchDistrictList : BaseListControl
    {
        private string _branchid;
        public string BranchId
        {
            get { return _branchid; }
            set { _branchid = value; }
        }
        public override String DataTypeName
        {
            get { return "Branch District"; }
        }
        public override DataTable DataTable
        {
            get { return this.BranchDistrictLists; }
        }
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("DIS_NAME")
                    .Select("DIS_REGION")
                    .Select("DIS_STATUS")
                    .Select("DIS_TYPE")
                    .Select("DIS_CATEGORY")
                    .Select("DIS_GROUP")
                    .Select("DIS_NAME")
                    .Select("BRXREF_BR_ID")
                    .Select("uri")
                    .From(QuerySources.BranchDistricts)
                    .Where("BRXREF_BR_ID", QueryConditionTypes.Equal, this.BranchId);
            }
        }

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.BranchDistrictLists.Url += "&brid=" + HttpUtility.UrlEncode(this.BranchId);
            this.DataTable.Json = "{uri:\"membership/branchxref\", brid:" + HttpUtility.JavaScriptStringEncode(this.BranchId, true) + " }";
        }

        #endregion
    }
}