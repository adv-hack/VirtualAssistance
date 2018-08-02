using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class OrganisationDetail : BaseControl<Organisation, String>
    {
        public override String DataTypeName
        {
            get { return "Organisation"; }
        }
        
        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.Countries.DataSource = Country.FetchAll();
            this.AddressDetail.DataSource = this.DataSource.PrincipalAddress;

            //this.AddressDetail.OrganisationId = this.DataSource.Id;


            this.SellCompName.DataSource = Common.SellingCompany.FetchAll();
            this.SellCompName.FieldValue = this.DataSource.SellingCompany.Id;
        }
    }
}