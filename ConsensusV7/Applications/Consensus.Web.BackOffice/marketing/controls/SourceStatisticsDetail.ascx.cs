using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.marketing.controls
{
    public partial class SourceStatisticsDetail : BaseControl<Promotion, String>
    {
        private string globalBaseCurrCode = "GBP"; // TODO: We don't have a way of getting this correctly at present
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

                this.BudgetCalculatedLabel.FieldValue = this.DataSource.Updated.HasValue ? this.DataSource.Updated.Value.ToString("dd MMMM yyyy") + " in " + globalBaseCurrCode : "";
                this.ActualCalculatedLabel.FieldValue = this.BudgetCalculatedLabel.FieldValue;
            }
            else if (!string.IsNullOrEmpty(this.Request.QueryString["mstid"]))
            {
                PromotionMaster refMaster = PromotionMaster.FetchById(this.Request.QueryString["mstid"]);
            }
        }
        /*
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            // When we are using this control for create in a popup, the parent promotion master ID is passed in the URL
            // (see SourceList.OnLoad).
            // Get this promotion master and populate the relevant read-only fields
            if (!string.IsNullOrEmpty(this.Request.QueryString["mstid"]))
            {
                PromotionMaster refMaster = PromotionMaster.FetchById(this.Request.QueryString["mstid"]);
                this.CampaignName.FieldValue = refMaster.CmpId.Name;
                this.SellingCompanyName.FieldValue = refMaster.CmpId.SellingCompany.Name;
                this.PromotionMasterName.FieldValue = refMaster.Name;
                this.PromotionMasterQcode.FieldValue = refMaster.Qcode;
            }

        }
        */
    }
}