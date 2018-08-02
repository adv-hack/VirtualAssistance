using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.marketing.controls
{
    public partial class PromotionMasterDetail : BaseControl<PromotionMaster, String>
    {
        private string globalBaseCurrCode = "GBP"; // TODO: We don't have a way of getting this correctly at present
        public override string DataTypeName
        {
          get { return "Promotion Master"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
                        
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            // When we are using this control for create in a popup, the parent campaign ID is passed in the URL
            // (see PromotionMasterList.OnLoad).
            // Get this campaign and populate the relevant read-only fields
            if (!string.IsNullOrEmpty(this.Request.QueryString["cmpid"]))
            {
                Campaign refCampaign = Campaign.FetchById(this.Request.QueryString["cmpid"]);
                this.CampaignName.FieldText = refCampaign.Name;
                this.CampaignName.FieldValue = refCampaign.Id;
                this.SellingCompanyName.FieldValue = refCampaign.SellingCompany.Name;
            }
            else if (this.DataSource != null && this.DataSource.CmpId != null)
            {
                this.CampaignName.FieldText = this.DataSource.CmpId.Name;
                this.CampaignName.FieldValue = this.DataSource.CmpId.Id;
                this.SellingCompanyName.FieldValue = this.DataSource.CmpId.SellingCompany.Name;
            }

            List<object> types = new List<object>();
            types.Add(new { Name = "Campaign", Id = 0 });
            types.Add(new { Name = "Event", Id = 1 });

            this.Type.DataSource = types;
            if (this.DataSource != null)
                this.Type.FieldValue = this.DataSource.Type.ToString();
        }
    }
}