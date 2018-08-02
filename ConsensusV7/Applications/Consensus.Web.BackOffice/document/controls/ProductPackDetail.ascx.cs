using Consensus.Common;
using Consensus.Learning;
using Consensus.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document.controls
{
    public partial class ProductPackDetail : BaseControl<PackProduct, Int32>
    {
       public override string DataTypeName
        {
            get { return "Add Pack"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
        }


        public override Func<Int32, PackProduct> DataLoader
        {
            get { return PackProduct.FetchById; }
        }
    }
}