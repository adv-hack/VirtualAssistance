using Consensus.Learning;
using Consensus.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class RelatedProductDetail : BaseControl<RelatedProduct, Int32>
    {
        public override string DataTypeName
        {
            get { return "Related Product"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<Int32, RelatedProduct> DataLoader
        {
            get { return RelatedProduct.FetchById; }
        }


        protected override void PopulateControl()
        {
            base.PopulateControl();
        }

        protected override void RegisterJavascript()
        {
            this.ProductName.ClientOnChange = this.ClientID + "RefreshProductReference.Update();";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, "var " + this.ClientID + "RefreshProductReference = new RefreshProductReference( '" + VirtualPathUtility.ToAbsolute("~/rest") + "');", true);
        }

    }
}