using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.marketing.controls
{
    public partial class SourceDetail : BaseControl<Promotion, String>
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

            if (!string.IsNullOrEmpty(this.Request.QueryString["mstid"]))
            {
                PromotionMaster refMaster = PromotionMaster.FetchById(this.Request.QueryString["mstid"]);
                this.CampaignName.FieldText = refMaster.CmpId.Name;
                this.CampaignName.FieldValue = refMaster.CmpId.Id;
                this.SellingCompanyName.FieldValue = refMaster.CmpId.SellingCompany.Name;
                this.PromotionMasterName.FieldText = refMaster.Name;
                this.PromotionMasterName.FieldValue = refMaster.Id;
                //this.PromotionMasterQcode.FieldValue = refMaster.Qcode;
            }
            else if (this.DataSource != null && this.DataSource.PromotionMaster != null)
            {
              this.CampaignName.FieldText = this.DataSource.PromotionMaster.CmpId.Name;
              this.CampaignName.FieldValue = this.DataSource.PromotionMaster.CmpId.Id;
              this.SellingCompanyName.FieldValue = this.DataSource.PromotionMaster.CmpId.SellingCompany.Name;
              this.PromotionMasterName.FieldText = this.DataSource.PromotionMaster.Name;
              this.PromotionMasterName.FieldValue = this.DataSource.PromotionMaster.Id;
              //this.PromotionMasterQcode.FieldValue = this.DataSource.PromotionMaster.Qcode;
            }
        }
    }
}