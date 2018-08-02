using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class MainSessionDetails : BaseControl<Product, String>
    {

        public override String DataTypeName
        {
            get { return "Session"; }
        }
        protected override void PopulateControl()
        {

            //we are creating a new course, so we need to set these values and not require a product.
            if (this.DataSource.Id == null)
            {
                this.DataSource.MainSession.Chargeable = 1;
                this.DataSource.MainSession.Mandatory = 1;
                this.DataSource.MainSession.InvoicePrint = 1;
                this.DataSource.MainSession.ShowAttLog = 1;
                this.DataSource.MainSession.ShowSales = 1;
                this.DataSource.MainSession.Element = 1;
                this.DataSource.MainSession.Session = 1;
                this.DataSource.MainSession.Real = 1; // NFPCCB-18478 Field 'Free places' is not updated as per 'Max Places'
            }
            base.PopulateControl();
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            if (this.DataSource.Id == null)
            {
                this.SessionProduct.Requirement = UserInterface.ScreenObjectRequirement.Optional;
                this.SessionProduct.IsReadOnly = UserInterface.ConfigurableBoolean.True;
            }



        }
    }
}