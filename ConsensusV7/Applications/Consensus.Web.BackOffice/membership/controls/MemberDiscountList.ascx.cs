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
    public partial class MemberDiscountList : BaseListControl
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
            get { return "Membership Discounts"; }
        }
        public override DataTable DataTable
        {
            get { return this.MemberDiscountLists; }
        }
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("MEL_DISC_REASON")
                    .Select("MEL_DISC_RENEWAL")
                    .Select("MEL_FEE")
                    .Select("MEL_VAT_AMT")
                    .Select("MEL_VATCD")
                    .Select("MEL_INVOICED")
                    .Select("uri")
                    .From(QuerySources.MembershipDiscounts)
                    .Where("MEL_MEP_ID", QueryConditionTypes.Equal, this.MemberPeriodId);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            this.MemberDiscountLists.Url += "&mepid=" + HttpUtility.UrlEncode(this.MemberPeriodId);
            this.DataTable.Json = "{ uri: \"membership/memberlocation\", memberperiodId: " + HttpUtility.JavaScriptStringEncode(this.MemberPeriodId, true) + " }";
        }
       
        #endregion
    }
}