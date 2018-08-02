using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class ProductDetails : BaseControl<Product>
    {
        public override string DataTypeName
        {
            get { return "Product"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.GenericProduct.DataSource = this.DataSource;
        }
    }
}