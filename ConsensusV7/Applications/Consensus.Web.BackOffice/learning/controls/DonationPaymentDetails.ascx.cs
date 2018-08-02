using Consensus.Learning;
using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class DonationPaymentDetails : BaseControl<Booking, String>
    {
        public override string DataTypeName
        {
            get { return "Donation"; }
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.InvoiceDetails.DataSource = this.DataSource;


        }
    }
}