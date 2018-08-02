using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class MembershipGradesDetails : BaseControl<Product, String>
    {
        public override String DataTypeName
        {
            get { return "Membership Grade"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.GenericProduct.SysProductType = "17";
            this.GenericProduct.DataSource = this.DataSource;
            this.SyProduct.FieldValue = "17";
            
        }
    }
}