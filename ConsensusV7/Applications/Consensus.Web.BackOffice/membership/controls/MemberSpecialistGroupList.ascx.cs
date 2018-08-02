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
    public partial class MemberSpecialistGroupList : BaseListControl
    {
        #region fields

        private String _memberPeriodId;
        private String _memberId;
        
        #endregion

        #region properties
        /// <summary>
        public String MemberPeriodId
        {
            get { return _memberPeriodId; }
            set { _memberPeriodId = value; }
        }

        public String MemberId
        {
            get { return _memberId; }
            set { _memberId = value; }
        }
        
        public override String DataTypeName
        {
            get { return "Membership Specialist Groups"; }
        }
        public override DataTable DataTable
        {
            get { return this.MemberSpecialistGroupLists; }
        }
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("PROD_REF")
                    .Select("PROD_NAME")
                    .Select("MEL_START")
                    .Select("MEL_END")
                    .Select("MEL_FEE")
                    .Select("MEL_VAT_AMT")
                    .Select("MEL_VATCD")
                    .Select("MEL_INVOICED")
                    .Select("MEL_PRICE_MODIFIED")
                    .Select("MEL_MEP_ID")
                    .Select("MEL_MEM_ID")
                    .Select("uri")
                    .From(QuerySources.SpecialistGroups)
                    .Where("MEL_MEP_ID", QueryConditionTypes.Equal, this.MemberPeriodId);
                    
            }
        }
        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.MemberSpecialistGroupLists.Url += "&mepid=" + HttpUtility.UrlEncode(this.MemberPeriodId);
            this.DataTable.Json = "{ uri: \"membership/memberlocation\", memberperiodId: " + HttpUtility.JavaScriptStringEncode(this.MemberPeriodId, true) + " }";
        }

        #endregion
    }
}