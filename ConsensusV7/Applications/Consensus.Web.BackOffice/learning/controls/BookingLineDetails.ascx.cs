using Consensus.Learning;
using Consensus.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
  public partial class BookingLineDetails : BaseControl<Learner, String>
  {
    public override String DataTypeName
    {
      get { return "Delegate"; }
    }

    /// <summary>
    ///     Gets the delegated method for loading the API object that is presented within the page.
    /// </summary>
    public override Func<String, Learner> DataLoader
    {
      get { return Learner.FetchById; }
    }

    protected override void PopulateControl()
    {
      base.PopulateControl();

    }

    protected override void OnInit(EventArgs e)
    {
      base.OnInit(e);

      //String CourseId = this.Request.QueryString["CourseId"];
      //String ActId = this.Request.QueryString["ActId"];
      //String ProdId = this.Request.QueryString["ProdId"];
      //String PrsId = this.Request.QueryString["PrsId"];
      //if (CourseId != "")
      //{
      //  this.Price.DataSource = Common.GenericModel.FetchAllByCourseIdPrices(CourseId, 1).Where(pricelists => String.Equals(ActId, pricelists.Id4, StringComparison.OrdinalIgnoreCase));
      //  this.Price.DataBind();
      //}

      //this.Price.FieldValue = PrsId;

    }

    protected override void OnPreRender(EventArgs e)
    {
      base.OnPreRender(e);


    }
  }
}