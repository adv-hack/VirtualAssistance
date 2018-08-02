using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Contact;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class NewRoleDetail : BaseControl<Role, String>
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public override String DataTypeName
        {
            get { return "New Role"; }
        }

        public override Func<String, Role> DataLoader
        {
            get
            {
                return Role.FetchById;
            }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.SellCompName.DataSource = Common.SellingCompany.FetchAll();
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();

            this.Address.DataSource = this.DataSource.Address;
            this.Address.OrganisationId = this.DataSource.OrganisationId;
            this.Address.PersonId = this.DataSource.PersonId;
        }
        protected override void OnPreRender(EventArgs e)
        {
          base.OnPreRender(e);
          this.SellCompName.FieldValue = CurrentSession.User.SellingCompanyId;
          this.PersonID.FieldValue = this.Request.QueryString["PersonId"];
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

