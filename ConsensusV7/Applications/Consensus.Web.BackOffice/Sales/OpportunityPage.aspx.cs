using Consensus.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Web.BackOffice.crm;

namespace Consensus.Web.BackOffice.Sales
{
    public partial class OpportunityPage : BaseStandardPage<Opportunity, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Opportunity - " + this.Data.Name; }
        }

        public override string DefaultIcon
        {
            get
            {
                return "money_bag_pound";
            }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Opportunity> DataLoader
        {
            get { return Opportunity.FetchById; }
        }

        public override Func<Opportunity> DataCreator
        {
            get { return Opportunity.Create; }
        }



        #endregion

        #region methods

        protected override void PopulateControls()
        {
            // Get the role to be displayed
            Opportunity opportunity = this.Data;


            this.OpportunityDetail.DataSource = opportunity;
            this.OppPeopleList.OppXrefType = "";
            this.OppPeopleList.OppXrefSalesman = "0";
            this.OppPeopleList.OpportunityId = this.Data.Id;
            this.OppPeopleList.OppSyType = OpportunitySyType.Opportunity;
            this.OppSalesManList.OppXrefType = "";
            this.OppSalesManList.OppXrefSalesman = "1";
            this.OppSalesManList.OpportunityId = this.Data.Id;
            this.OppSalesManList.OppSyType = OpportunitySyType.Opportunity;

            this.EmailList.ActivityType = "Letter";
            this.EmailList.ActivityParentId = this.Data.Id;
            this.EmailList.ActivityMode = ActivityList.ActivityListMode.OPP_ID;
            this.EmailList.OppSyType = OpportunitySyType.Opportunity;
            this.DiaryList.ActivityType = "D-";
            this.DiaryList.ActivityMode = ActivityList.ActivityListMode.OPP_ID;
            this.DiaryList.ActivityParentId = this.Data.Id;
            this.DiaryList.OppSyType = OpportunitySyType.Opportunity;

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