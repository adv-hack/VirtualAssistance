using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning
{
  public partial class elearningPage : BaseStandardPage<Product, String>
  {
    #region properties

    /// <summary>
    ///     Gets the text displayed within the header of the page.
    /// </summary>
    public override String DefaultTitle
    {
      get { return "elearning Product - " + this.Data.Name; }
    }

    /// <summary>
    ///     Gets the icon displayed within the header of the page.
    /// </summary>
    public override String DefaultIcon
    {
      get { return "elearning"; }
    }

    /// <summary>
    ///     Gets the delegated method for loading the API object that is presented within the page.
    /// </summary>
    public override Func<String, Product> DataLoader
    {
      get { return Product.FetchById; }
    }

    /// <summary>
    ///     Gets the delegated method for creating the API object that is presented within the page.
    /// </summary>
    public override Func<Product> DataCreator
    {
      get { return Product.Create; }
    }

    #endregion

    #region methods

    protected override void PopulateControls()
    {
      this.ElearningDetails.DataSource = this.Data;

      this.PricesList.PriceParentId = this.Data.Id;
      this.PricesList.ParentSyProduct = "8";
    }
    protected override void PopulateLinks()
    {
      this.PopulateLink(this.BottomTabControl);
    }
    #endregion
  }
}