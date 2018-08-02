using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.marketing.controls
{
    public partial class CampaignDetail : BaseControl<Campaign, String>
    {
        private string globalBaseCurrCode = "GBP"; // TODO: We don't have a way of getting this correctly at present

        public override string DataTypeName
        {
            get { return "Campaign"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            
            this.SellingCompanyName.DataSource = Common.SellingCompany.FetchAll();
            this.SellingCompanyName.FieldValue = this.DataSource.SellingCompany.Id;

          if (this.DataSource.Id == null)
          {
            this.SellingCompanyName.FieldValue = CurrentSession.User.SellingCompanyId;
            this.Current.FieldValue = true;
          }
        }
    }
}