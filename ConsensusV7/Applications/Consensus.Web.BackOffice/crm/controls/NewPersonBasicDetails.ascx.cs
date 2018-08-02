using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm.controls
{

    public partial class NewPersonBasicDetails : BaseControl<Role, String>
    {
        public override String DataTypeName
        {
            get { return "Data Protection"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.SellCompName.DataSource = Common.SellingCompany.FetchAll();

        }

        protected override void RegisterJavascript()
        {
            this.Organisation.ClientOnChange = @"
                var data = this.getData();
                if (data)
                    " + this.Address.ClientID + @".lockFields(data.org_id,data.add_id,data.addressLine1, data.addressLine2, data.addressLine3, data.town, data.county, data.postcode, data.country);
                else
                    " + this.Address.ClientID + @".unlockFields();";
        }
    }
}