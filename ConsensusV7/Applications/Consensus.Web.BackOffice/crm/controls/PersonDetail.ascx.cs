using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class PersonDetail : BaseControl<Role, String>
    {
        public override String DataTypeName
        {
            get { return "Person"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.Address.DataSource = this.DataSource.Address;
            this.Address.OrganisationId = this.DataSource.OrganisationId;
            this.Address.PersonId = this.DataSource.PersonId;
            this.Address.DisplayAltAddressButton = true;
            this.Address.IdField.FieldValue = this.DataSource.AddressId;
            //if (this.DataSource.PersonId != null)
            //{
            //    this.GiftAid.Visible = false;
            //    this.Declaration.Visible = false;
            //}
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            //Pre-populate details from Organisation screen
            if (String.IsNullOrEmpty(this.Request.QueryString["id"]) && !String.IsNullOrEmpty(this.Request.QueryString["organisationId"]))
            {
                var organisation = Contact.Organisation.FetchById(this.Request.QueryString["organisationId"]);
                this.Organisation.FieldValue = organisation.Id;
                this.Organisation.FieldText = organisation.Name;                
                this.Address.DataSource = organisation.PrincipalAddress.Address;                
                this.Address.IdField.FieldValue = organisation.PrincipalAddress.AddressId;                          
                this.Address.OrganisationId = organisation.Id;                
                this.Address.DisplayAltAddressButton = true;
                this.Organisation.IsReadOnly = UserInterface.ConfigurableBoolean.TrueEnforced;                                
            }
        }


        protected override void RegisterJavascript()
        {
            this.Organisation.ClientOnChange = @"
                if (this.getData())
                    " + this.Address.ClientID + @".lockFields(this.getData().org_id,this.getData().add_id,this.getData().addressLine1, this.getData().addressLine2, this.getData().addressLine3, this.getData().town, this.getData().county, this.getData().postcode, this.getData().country);
                else
                    " + this.Address.ClientID + @".unlockFields();";
        }
    }
}