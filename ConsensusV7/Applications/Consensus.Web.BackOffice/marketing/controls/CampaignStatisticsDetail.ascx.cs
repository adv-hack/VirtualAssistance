using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.marketing.controls
{
    public partial class CampaignStatisticsDetail : BaseControl<Campaign, String>
    {
        private string globalBaseCurrCode = "GBP"; // TODO: We don't have a way of getting this correctly at present
        public override string DataTypeName
        {
            get { return "Campaign"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();

            this.BudgetCalculatedLabel.FieldValue = this.DataSource.Updated.HasValue ? this.DataSource.Updated.Value.ToString("dd MMMM yyyy") + " in " + globalBaseCurrCode : "";
            this.ActualCalculatedLabel.FieldValue = this.BudgetCalculatedLabel.FieldValue;
            this.ActualBookingsValue.FieldValue = (this.DataSource.ActualBookValue ?? 0).ToString();
            this.CalculatedBudgetCosts.FieldValue = (this.DataSource.CalcEst ?? 0).ToString();
            this.CalculatedActualCosts.FieldValue = (this.DataSource.CalcAct ?? 0).ToString();
            this.TotalBudgetCosts.FieldValue = ((this.DataSource.CalcEst ?? 0) + (this.DataSource.BudgetCosts ?? 0)).ToString();
            this.TotalActualCosts.FieldValue = ((this.DataSource.CalcAct ?? 0) + (this.DataSource.ActualCosts ?? 0)).ToString();
        }

    }
}