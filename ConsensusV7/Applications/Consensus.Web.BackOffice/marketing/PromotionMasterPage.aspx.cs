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
    public partial class PromotionMasterPage : BaseStandardPage<PromotionMaster, String>
    {
        public override Func<String, PromotionMaster> DataLoader
        {
            get { return PromotionMaster.FetchById; }
        }

        public override Func<PromotionMaster> DataCreator
        {
            get { return PromotionMaster.Create; }
        }

        public override string DefaultTitle
        {
            get { return "Promotion Master - " + this.Data.Name; }
        }
        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
          get { return "advertising"; }
        }

        protected override void PopulateControls()
        {
            // Get the role to be displayed
            PromotionMaster promotionMaster = this.Data;

            this.PromotionMasterDetail.DataSource = promotionMaster;

            this.PromotionMasterStatisticsDetail.DataSource = promotionMaster;

            this.SourceList.PromotionParentId = promotionMaster.Id;
        }
    }
}