using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class ProductFinanceDetails : BaseControl<Product, String>
    {
        public override String DataTypeName
        {
            get { return "Finance"; }
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();     
            if(this.DataSource!=null && this.DataSource.Id != null)
            {
                this.InvZeroVal.FieldValue = this.DataSource.InvZeroVal == 1 ? true : false;
            }       
        }

    }
}