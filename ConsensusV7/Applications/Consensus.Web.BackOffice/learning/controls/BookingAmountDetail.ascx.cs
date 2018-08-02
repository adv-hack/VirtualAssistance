using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class BookingAmountDetail : BaseControl<Element, String>
    {
        public override String DataTypeName
        {
            get { return "Donation"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Element> DataLoader
        {
            get { return Element.FetchById; }
        }
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();

            if (this.DataSource.SellingCompanyId == null)
            {
                this.DataSource.SellingCompanyId = this.DataSource.Booking.SellingCompanyId;
            }

            // Set the cost codes to those applicable to the currently selected selling company
            this.CostCode.DataSource = Finance.CostCode.FetchAll().Where(costCode => String.IsNullOrEmpty(this.DataSource.SellingCompanyId) || String.Equals(costCode.SelcoSpIdId, this.DataSource.SellingCompanyId, StringComparison.OrdinalIgnoreCase));
            this.CostCode.DataBind();
        }
    }
}