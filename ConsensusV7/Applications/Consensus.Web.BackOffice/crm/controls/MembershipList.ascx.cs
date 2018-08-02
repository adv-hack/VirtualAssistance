using Consensus.Contact;
using Consensus.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class MembershipList : BaseControl<Proxy>
    {

        public override String DataTypeName
        {
            get { return "Membership List"; }
        }        
        protected override void PopulateControl()
        {
            String filterColumn = null;
            String filterValue = null;
            QuerySources querysource = QuerySources.Memberships;

            if (this.DataSource is Person)
            {
                filterColumn = "PN_ID";
                filterValue = (this.DataSource as Person).Id;
            }

            if (this.DataSource is Role)
            {
                filterColumn = "MEL_PROLE_ID";
                filterValue = (this.DataSource as Role).Id;
            }

            if (this.DataSource is Organisation)
            {
                filterColumn = "MEL_ORG_ID";
                filterValue = (this.DataSource as Organisation).Id;
            }

            this.MembershipListResult.Data = Query.Create()
                .Select("MEM_ID")
                .Select("MEP_ID")
                .Select("MEP_MEMBERSHIP_NAME", "MembershipName")
                .Select("MEM_REF", "Ref")
                .Select("PROD_NAME", "Name")
                .Select("MEP_STATUS", "Status")
                .Select("MEP_START", "StartDate")
                .Select("MEP_END", "EndDate")
                .Select("MEP_RENEWAL_DATE", "RenewDate")
                .Select("uri")
                .From(querysource)
                .Where(filterColumn, QueryConditionTypes.Equal, filterValue)
                .And("MEP_STATUS", QueryConditionTypes.DoesNotStartWith, "10")
                .And("MEP_STATUS", QueryConditionTypes.DoesNotStartWith, "90")
                .OrderBy("MEM_START", true);

        }

        #region Page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);           

            //Appended personId or proleId from Person screen.
            if (this.DataSource is Person)
            {
                this.MembershipListResult.CreateUrl += "&personId=" + (this.DataSource as Person).Id;
            }

            if (this.DataSource is Role)
            {
                this.MembershipListResult.CreateUrl += "&proleId=" + (this.DataSource as Role).Id;
            }

        }

        #endregion
    }
}