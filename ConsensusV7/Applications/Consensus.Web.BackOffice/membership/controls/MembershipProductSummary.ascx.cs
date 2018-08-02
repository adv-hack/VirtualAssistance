using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class MembershipProductSummary : BaseControl
    {
        public override String DataTypeName
        {
            get { return "Product"; }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);            
            this.PriceList.DataSource = Finance.PriceList.FetchAllByProductId(this.Request.QueryString["productId"]);
            this.GUID.FieldValue = this.Request.QueryString["guid"];
            this.ProductName.FieldValue = this.Request.QueryString["productName"];
            this.PriceList.FieldValue = this.Request.QueryString["priceList"];
            this.Amount.FieldValue = this.Request.QueryString["amount"];
            this.VatCode.FieldValue = this.Request.QueryString["vatCode"];
            this.PriceListName.FieldValue = this.Request.QueryString["priceListName"];
            this.ProductId.FieldValue = this.Request.QueryString["productId"];
        }
    }
}