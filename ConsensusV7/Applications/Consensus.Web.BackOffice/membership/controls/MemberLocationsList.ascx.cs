using Consensus.Contact;
using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership
{
    public partial class MemberLocationsList : BaseListControl
    {

        #region fields

        /// <summary>
        ///     The ID of the parent membership object that the location records are linked to.
        /// </summary>
        private String _membershipId;

        /// <summary>
        ///     The ID of the parent memberperiod object that the location records are linked to.
        /// </summary>
        private String _memberPeriodId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the ID of the membership object that the location records are linked to.
        /// </summary>
        public String MembershipId
        {
            get { return _membershipId; }
            set { _membershipId = value; }
        }

        /// <summary>
        ///     Gets or sets the ID of the memberperiod object that the location records are linked to.
        /// </summary>
        public String MemberPeriodId
        {
            get { return _memberPeriodId; }
            set { _memberPeriodId = value; }
        }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Member Location"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.LocationListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("MEL_ID")
                    .Select("PN_ID")
                    .Select("MEL_PROLE_ID")
                    .Select("PROLE_PN_NAME")
                    .Select("MEL_ORG_ID")
                    .Select("ORG_NAME")
                    .Select("Status")
                    .Select("MEL_OVERSEAS")
                    .Select("MEL_FEE")
                    .Select("MEL_VAT_AMT")
                    .Select("MEL_VATCD")
                    .Select("MEL_INVOICED")
                    .Select("MEL_RENEW_LOC")
                    .Select("MEL_PRICE_MODIFIED")
                    .Select("uri")
                    .From(QuerySources.MembershipLocations)
                    .Where("MEL_MEP_ID", QueryConditionTypes.Equal, this.MemberPeriodId)
                    .And("MEL_SY_TYPE", QueryConditionTypes.Equal, 0)
                    .OrderBy("MEL_RENEW_LOC", false)
                    .ThenBy("MEL_ADD_DATE", true);
            }
        }

        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.DataTable.Url += "&memberPeriodId=" + this.MemberPeriodId;
            this.DataTable.Json = "{ uri: \"membership/memberlocation\", memberPeriodId: " + HttpUtility.JavaScriptStringEncode(this.MemberPeriodId, true) + " , membershipId: " + HttpUtility.JavaScriptStringEncode(this.MembershipId, true) + "}";
        }

        #endregion
    }
}