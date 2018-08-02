using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class DonationDetails : BaseControl<Product, String>
    {
        public override String DataTypeName
        {
            get { return "Donation"; }
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.GenericProduct.ZeroVAT = true;
            this.GenericProduct.DataSource = this.DataSource;

            this.SyProduct.FieldValue = "29";
        }
    }
}