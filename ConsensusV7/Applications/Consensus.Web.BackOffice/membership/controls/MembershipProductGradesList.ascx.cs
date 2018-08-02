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
    public partial class MembershipProductGradesList : BaseListControl
    {
        #region fields

        private String _gradeproductId;

        #endregion

        #region properties
        /// <summary>
        public String GradeParentId
        {
            get { return _gradeproductId; }
            set { _gradeproductId = value; }
        }
        public override String DataTypeName
        {
            get { return "Available Grades"; }
        }
        public override DataTable DataTable
        {
            get { return this.MembershipProdGradeLists; }
        }
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("MBOM_ID")
                    .Select("MBOM_PARENT_ID")
                    .Select("MBOM_GRADE_ID")
                    .Select("MBOM_MAIN")
                    .Select("PROD_REF")
                    .Select("PROD_NAME")
                    .Select("PRS_PRICE")
                    .Select("uri")
                    .From(QuerySources.MembershipProdGrades)
                    .Where("MBOM_PARENT_ID", QueryConditionTypes.Equal, this.GradeParentId);
            }
        }
        #endregion

        #region page cycle
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.DataTable.Json = "{ uri: \"membership/memberbom\", productId: " + HttpUtility.JavaScriptStringEncode(this.GradeParentId, true) + " }";
            this.MembershipProdGradeLists.Url += "&gradeParentId=" + HttpUtility.UrlEncode(this.GradeParentId);
        }

        #endregion
    }
}