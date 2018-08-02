using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Contact;
using Consensus.Common;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class OrganisationAddressDetail : BaseControl<OrganisationAddress, String>
    {

        public override String DataTypeName
        {
            get { return "Organisation Address"; }
        }

        public override Func<String, OrganisationAddress> DataLoader
        {
            get { return OrganisationAddress.FetchById; }
        }


        protected override void PopulateControl()
        {

            base.PopulateControl();

            this.AddressDetail.DisplayAltAddressButton = false;
            if (this.DataSource == null)
            {
              this.AddressDetail.OrganisationId = this.Request.QueryString["orgId"];
            }
            else
            {
              this.AddressDetail.DataSource = this.DataSource.Address;
              this.AddressDetail.OrganisationId = this.DataSource.OrganisationId;
            }
            if (this.Request.QueryString["orgId"] == null)
            {
              this.Principal.Visible = false;
              this.AddressType.Visible = false;
            }
        }
    }
}