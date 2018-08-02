using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class BookingDetails : BaseControl<Booking, String>
    {
        public override string DataTypeName
        {
            get { return "Booking"; }
        }



        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.BookerDetails.DataSource = this.DataSource;
            this.SellCompName.DataSource = Common.SellingCompany.FetchAll();
            this.SellCompName.FieldValue = this.DataSource.SellingCompany.Id;



            this.CurrencyType.DataSource = Finance.Currency.FetchAll().Where(currencyType => String.IsNullOrEmpty(this.DataSource.SellingCompanyId) || String.Equals(currencyType.SellingCompanyId, this.DataSource.SellingCompanyId, StringComparison.OrdinalIgnoreCase));
            this.CurrencyType.DataBind();
            this.CurrencyType.FieldValue = this.DataSource.CurrencyType;

            this.NetTotal.FieldValue = String.Format("{0:.00}", this.DataSource.NetTotal);
            this.VATTotal.FieldValue = String.Format("{0:.00}", this.DataSource.VatTotal);
            this.GrossTotal.FieldValue = String.Format("{0:.00}", this.DataSource.NetTotal + this.DataSource.VatTotal);

        }
        protected override void OnInit(EventArgs e)
        {


            base.OnInit(e);
            this.SellCompName.DataSource = Common.SellingCompany.FetchAll();

            this.CurrencyType.DataSource = Finance.Currency.FetchAll();
            this.CurrencyType.DataBind();


        }
    }
}