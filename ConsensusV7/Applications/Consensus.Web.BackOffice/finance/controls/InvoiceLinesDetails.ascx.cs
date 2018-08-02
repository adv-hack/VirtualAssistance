using Consensus.Finance;
using Consensus.Contact;
using Consensus.Common;
using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class InvoiceLinesDetails : BaseControl<InvoiceLine, String>
    {
        protected override void OnInit(EventArgs e)
        {
            // Custom field data isn't read because we haven't defined a DataLoader. 
            if (Page is BaseSecurePage)
                ((BaseSecurePage)Page).BlockCustomFields = true;

            base.OnInit(e);
        }
        public override string DataTypeName
        {
            get { return "Invoice line"; }
        }        

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            var invoiceId = Request.QueryString.Get("InvId");
            var invoice = Finance.Invoice.FetchById(invoiceId);
                        
            // Set the cost codes to those applicable to the currently selected selling company
            this.CostCode.DataSource = Finance.CostCode.FetchAll().Where(costCode => String.IsNullOrEmpty(invoice.SellingCompanyId) || String.Equals(costCode.SelcoSpIdId, invoice.SellingCompanyId, StringComparison.OrdinalIgnoreCase));
            this.CostCode.DataBind();
        }        
    }
}