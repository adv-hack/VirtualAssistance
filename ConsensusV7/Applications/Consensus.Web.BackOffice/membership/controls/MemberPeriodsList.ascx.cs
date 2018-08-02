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
    public partial class MemberPeriodsList : BaseListControl
    {

        #region fields

        /// <summary>
        ///     The ID of the parent membership object that the location records are linked to.
        /// </summary>
        private String _membershipId;

        /// <summary>
        ///     The ID of the current membership period object that the list is linked to.
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
        ///     Gets or sets the ID of the current membership period object that the list is linked to.
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
            get { return this.MemberPeriodListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("MEP_ID")
                    .Select("MEP_MEM_ID")
                    .Select("MEL_PROLE_ID")
                    .Select("PROLE_PN_NAME")
                    .Select("MEL_ORG_ID")
                    .Select("ORG_NAME")
                    .Select("MEP_PROD_ID")
                    .Select("PROD_NAME")
                    .Select("MEP_START")
                    .Select("MEP_END")
                    .Select("MEP_STATUS")
                    .Select("uri")
                    .From(QuerySources.MembershipPeriods)
                    .Where("MEP_MEM_ID", QueryConditionTypes.Equal, this.MembershipId)
                    .And("MEP_ID", QueryConditionTypes.NotEqual, this.MemberPeriodId)
                    .OrderBy("MEP_START", false);
            }
        }				        
        #endregion

    }
}