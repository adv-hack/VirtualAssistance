using Consensus.Contact;
using Consensus.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm
{
    public partial class OrganisationPage : BaseStandardPage<Organisation, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Organisation - " + this.Data.Name; ; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "organization"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Organisation> DataLoader
        {
            get { return Organisation.FetchById; }
        }

        /// <summary>
        ///     Gets the delegated method for creating the API object that is presented within the page.
        /// </summary>
        public override Func<Organisation> DataCreator
        {
            get { return Organisation.Create; }
        }

        #endregion

        #region methods

        protected override void PopulateControls()
        {
            // Get the organisation to be displayed
            Organisation organisation = this.Data;


            this.OrganisationDetail.DataSource = organisation;

            this.ProfileList.ProfileParentId = this.Data.Id;
            this.ProfileList.ProfileMode = ProfileList.ProfileListMode.PROF_ORG_ID;

            this.AssociateList.AssociateType = AssociateList.AssociateListMode.OrganisationAssociates;
            this.AssociateList.AssociateParentId = this.DataId;
            this.PeopleList.DataSource = organisation;
            this.PeopleList.OrganisationId = this.Data.Id;
            this.AddressList.OrgId = this.DataId;
            //this.DeptList.OrganisationID = this.DataId;
            this.MembershipList.DataSource = organisation;

            this.EmailList.ActivityType = "Letter";
            this.EmailList.ActivityParentId = this.Data.Id;
            this.EmailList.ActivityMode = ActivityList.ActivityListMode.ORG_ID;
            this.DiaryList.ActivityType = "D-";
            this.DiaryList.ActivityMode = ActivityList.ActivityListMode.ORG_ID;
            this.DiaryList.ActivityParentId = this.Data.Id;

            this.OpportunityList.OpportunityParentId = this.Data.Id;
            this.OpportunityList.OpportunitySyType = OpportunitySyType.Opportunity;

            this.GrantApplicationList.OpportunityParentId = this.Data.Id;
            this.GrantApplicationList.OpportunitySyType = OpportunitySyType.GrantApplication;

            this.LegacyList.OpportunityParentId = this.Data.Id;
            this.LegacyList.OpportunitySyType = OpportunitySyType.Legacies;

            this.MajorDonorList.OpportunityParentId = this.Data.Id;
            this.MajorDonorList.OpportunitySyType = OpportunitySyType.Donors;

            this.PledgeList.OpportunityParentId = this.Data.Id;
            this.PledgeList.OpportunitySyType = OpportunitySyType.Pledges;
        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }

        #endregion
    }
}