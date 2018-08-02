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
    public partial class MemberGradeList : BaseListControl
    {
        #region fields

        private String _memberPeriodId;
        private String _prodId;
        #endregion

        #region properties
        /// <summary>
        public String MemberPeriodId
        {
            get { return _memberPeriodId; }
            set { _memberPeriodId = value; }
        }
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }
        public override String DataTypeName
        {
            get { return "Membership Grades"; }
        }
        public override DataTable DataTable
        {
            get { return this.MemberGradeLists; }
        }
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("PROD_REF")
                    .Select("PROD_NAME")
                    .Select("MEL_DATE")
                    .Select("MEL_FEE")
                    .Select("MEL_VAT_AMT")
                    .Select("MEL_VATCD")
                    .Select("MEL_INVOICED")
                    .Select("MEL_PRICE_MODIFIED")
                    .Select("MEL_MEP_ID")
                    .Select("uri")
                    .From(QuerySources.MembershipGrades)
                    .Where("MEL_MEP_ID", QueryConditionTypes.Equal, this.MemberPeriodId)
                    .OrderBy("MEL_DATE",false);
            }
        }
        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.MemberGradeLists.CreateUrl += "&mepid="+HttpUtility.UrlEncode(this.MemberPeriodId)+"&prodid=" + HttpUtility.UrlEncode(this.ProdId);
           
            this.DataTable.Json = "{ uri: \"membership/memberlocation\", memberperiodId: " + HttpUtility.JavaScriptStringEncode(this.MemberPeriodId, true) + " }";
        }

        #endregion
    }
}