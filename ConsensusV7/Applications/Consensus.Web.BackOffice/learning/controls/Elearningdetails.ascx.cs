using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
  public partial class Elearningdetails : BaseControl<Product, String>
  {
    public override String DataTypeName
    {
      get { return "elearning"; }
    }
    protected override void PopulateControl()
    {
      base.PopulateControl();
      this.GenericProduct.DataSource = this.DataSource;
      this.GenericProduct.ZeroVAT = false;
      this.SyProduct.FieldValue = "8";
    }
  }
}