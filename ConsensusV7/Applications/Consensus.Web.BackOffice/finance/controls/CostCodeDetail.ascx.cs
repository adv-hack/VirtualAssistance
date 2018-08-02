using Consensus.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class CostCodeDetails : BaseControl<CostCode, string>
    {
        public override String DataTypeName
        {
            get { return "Cost Code"; }
        }

        public override Func<string, CostCode> DataLoader
        {
            get { return CostCode.FetchById; }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.SellingCompany.DataSource = Common.SellingCompany.FetchAll();



        }
        protected override void PopulateControl()
        {
            base.PopulateControl();
        }

        protected override void OnPreRender(EventArgs e)
        {
            if (this.DataSource == null || this.DataSource.Id == null)
            {
                this.SellingCompany.FieldValue = this.CurrentSession.User.SellingCompanyId;
            }
            else
            {
                this.SellingCompany.FieldValue = this.DataSource.SelcoSpIdId;
            }
        }
    }
}