using Consensus.Sales;
using Consensus.Web.BackOffice.crm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.Sales
{
    public partial class GrantApplicationPage : BaseStandardPage<Opportunity, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Grant Application - " + this.Data.Name; }
        }

        public override string DefaultIcon
        {
            get
            {
                return "community_grants";
            }
        }
        public override Func<string, Opportunity> DataLoader
        {
            get
            {
                return Opportunity.FetchById;
            }
        }

        public override Func<Opportunity> DataCreator
        {
            get { return Opportunity.Create; }
        }

        #endregion

        #region Methods

        protected void Page_Load(object sender, EventArgs e)
        {

        }   

        protected override void PopulateControls()
        {
            base.PopulateControls();

            this.Data.SyType = Convert.ToInt32(OpportunitySyType.GrantApplication);
            Opportunity grantApplicationOpportunity = this.Data;
            this.GrantApplicationDetail.DataSource = grantApplicationOpportunity;
            this.OppPeopleList.OppXrefType = "";
            this.OppPeopleList.OppXrefSalesman = "0";
            this.OppPeopleList.OpportunityId = this.Data.Id;
            this.OppPeopleList.OppSyType = OpportunitySyType.GrantApplication;

            this.OppSalesManList.OppXrefType = "";
            this.OppSalesManList.OppXrefSalesman = "1";
            this.OppSalesManList.OpportunityId = this.Data.Id;
            this.OppSalesManList.OppSyType = OpportunitySyType.GrantApplication;

            this.DiaryList.ActivityType = "D-";
            this.DiaryList.ActivityMode = ActivityList.ActivityListMode.OPP_ID;
            this.DiaryList.ActivityParentId = this.Data.Id;
            this.DiaryList.OppSyType = OpportunitySyType.GrantApplication;

            this.EmailList.ActivityType = "Letter";
            this.EmailList.ActivityParentId = this.Data.Id;
            this.EmailList.ActivityMode = ActivityList.ActivityListMode.OPP_ID;
            this.EmailList.OppSyType = OpportunitySyType.GrantApplication;

            this.DonationList.ParentId = this.Data.Id;
            this.DonationList.DonationType = learning.controls.DonationList.DonationSearchListMode.Opportunity;
        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }
        #endregion
    }
}