using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.marketing.controls
{
    public partial class SourceDetailBasic : BaseControl<Promotion, String>
    {
        public override Func<String, Promotion> DataLoader
        {
            get { return Promotion.FetchById; }
        }

        public override string DataTypeName
        {
            get { return "Source Code"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();

            if (this.DataSource != null)
            {
                this.CampaignName.FieldText = this.DataSource.PromotionMaster.CmpId.Name;
                this.CampaignName.FieldValue = this.DataSource.PromotionMaster.CmpId.Id;
                this.SellingCompanyName.FieldValue = this.DataSource.PromotionMaster.CmpId.SellingCompany.Name;
                this.PromotionMasterName.FieldText = this.DataSource.PromotionMaster.Name;
                this.PromotionMasterName.FieldValue = this.DataSource.PromotionMaster.Id;
            }
            else if (!string.IsNullOrEmpty(this.Request.QueryString["mstid"]))
            {
                PromotionMaster refMaster = PromotionMaster.FetchById(this.Request.QueryString["mstid"]);
                this.CampaignName.FieldValue = refMaster.CmpId.Id;
                this.CampaignName.FieldText = refMaster.CmpId.Name;
                this.SellingCompanyName.FieldValue = refMaster.CmpId.SellingCompany.Name;
                this.PromotionMasterName.FieldText = refMaster.Name;
                this.PromotionMasterName.FieldValue = refMaster.Id;
            }
        }
    }
}