using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class BookingInvoiceDetails : BaseControl<Booking, String>
    {
        public override string DataTypeName
        {
            get { return "Booking"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.InvoiceDetails.DataSource = this.DataSource;

            this.InvoiceRule.DataSource = Common.Code.FetchAllByType("IRUL");
            if (this.DataSource.InvoiceRuleOffset < 0)
            {
              this.OffsetSign.FieldValue = "-1";
            }
            else
            {
              this.OffsetSign.FieldValue = "1";
            }
            this.OffsetValue.FieldValue = Math.Abs(this.DataSource.InvoiceRuleOffset).ToString();

        }

    }
}