using Consensus.Sales;
using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Web.BackOffice.marketing;

namespace Consensus.Web.BackOffice.marketing
{
    public partial class CampaignPage : BaseStandardPage<Campaign, String>
    {
        public override Func<String, Campaign> DataLoader
        {
            get { return Campaign.FetchById; }
        }

        public override Func<Campaign> DataCreator
        {
            get { return Campaign.Create; }
        }

        public override string DefaultTitle
        {
            get { return "Campaign - " + this.Data.Name; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override string DefaultIcon
        {
          get { return "multichannel"; }
        }

        protected override void PopulateControls()
        {
            // Get the role to be displayed
            Campaign campaign = this.Data;

            this.CampaignDetail.DataSource = campaign;

            this.CampaignStatisticsDetail.DataSource = campaign;
            
            this.PromotionMasterList.PromotionMasterParentId = campaign.Id;

            this.ActivityList.ActivityMode = crm.ActivityList.ActivityListMode.Campaign;
            this.ActivityList.ActivityParentId = this.Data.Id;
        }
        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }
    }
}