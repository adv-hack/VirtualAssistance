using Consensus.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class InvoiceSummary : BaseControl<Invoice, String>
    {
        public override string DataTypeName
        {
            get { return "Invoice"; }
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();
        }
    }
}