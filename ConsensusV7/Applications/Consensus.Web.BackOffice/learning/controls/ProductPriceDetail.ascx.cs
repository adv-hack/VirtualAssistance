using Consensus.Common;
using Consensus.Finance;
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
    public partial class ProductPriceDetail : BaseControl<Price, String>
    {
        public override string DataTypeName
        {
            get { return "Price Record"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Price> DataLoader
        {
            get { return Price.FetchById; }
        }
        protected override void OnInit(EventArgs e)
        {

            IEnumerable<PriceList> listPrices = PriceList.FetchAll();
            this.PriceName.DataSource = listPrices.Where(record => record.Status == 1);
            base.OnInit(e);
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            if (this.DataSource != null)
                this.PriceName.FieldValue = this.DataSource.PriceList.Id ;
        }


        protected override void RegisterJavascript()
        {
            this.PriceName.ClientOnChange = this.ClientID + "PopulatePriceListDetails.Update();";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, "var " + this.ClientID +   "PopulatePriceListDetails = new PopulatePriceListDetails('" + this.ValidFrom.ClientID + "Group', '" + this.ValidUntil.ClientID + "Group', '" + this.CurrType.ClientID + "Field', '" + this.PriceName.ClientID + "Field', '" + VirtualPathUtility.ToAbsolute("~/rest") + "')", true);
        }

        protected bool Type_OnLoadDataSource(Code code)
        {
            Int32 parsed;
            if (this.Request.QueryString["productType"] != "1")
                //don't return course specific codes if not a course
                return !Int32.TryParse(code.Value3, out parsed) || (parsed < 50 && parsed != 1);
            else
                return Int32.TryParse(code.Value3, out parsed);
        }
         

    }
}