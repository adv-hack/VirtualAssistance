using Consensus.Learning;
using Consensus.Contact;
using Consensus.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class NewDonationDetails : BaseControl<Booking, String>
    {
        public override String DataTypeName
        {
            get { return "Donation"; }
        }

        public override Func<String, Booking> DataLoader
        {
            get
            {
                return Booking.FetchById;
            }
        }

        protected override void OnInit(EventArgs e)
        {
          base.OnInit(e);
          this.SellCompName.DataSource = Common.SellingCompany.FetchAll();

          this.SellCompName.FieldValue = CurrentSession.User.SellingCompanyId;

        }

      

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            //set the default value
            String personId = this.Request.QueryString["personId"];
            String roleId = this.Request.QueryString["roleId"];
            String orgId = this.Request.QueryString["orgId"];
            String oppId  = this.Request.QueryString["oppId"];
            if (personId != null)
            {
              Person Person = Person.FetchById(personId);
              this.Contact.FieldValue = Person.PrincipalRole.Id;
              this.Contact.FieldText = Person.PrincipalRole.PersonName;
              this.BookerAddressId.FieldValue = Person.PrincipalRole.AddressId;
              this.OrgName.FieldValue = Person.PrincipalRole.OrganisationId;
              this.OrgName.FieldText = Person.PrincipalRole.Organisation.Name;
              this.InvoiceContact.FieldValue = Person.PrincipalRole.Id;
              this.InvoiceContact.FieldText = Person.PrincipalRole.PersonName;
              this.InvoicePersonId.FieldValue = Person.Id;
              this.InvoiceAddressId.FieldValue = Person.PrincipalRole.AddressId;
              this.InvOrgName.FieldValue = Person.PrincipalRole.OrganisationId;
              this.InvOrgName.FieldText = Person.PrincipalRole.Organisation.Name;
              this.Payment.AddressId.FieldValue = Person.PrincipalRole.AddressId;
              this.Payment.Organisation.FieldValue = Person.PrincipalRole.OrganisationId;
              this.Payment.Organisation.FieldText = Person.PrincipalRole.Organisation.Name;
              this.Payment.Person.FieldValue = Person.PrincipalRole.Id;
              this.Payment.Person.FieldText = Person.PrincipalRole.PersonName;
            }
            if (roleId != null)
            {
              Role Role = Role.FetchById(roleId);
              this.Contact.FieldValue = Role.Id;
              this.Contact.FieldText = Role.PersonName;
              this.BookerAddressId.FieldValue = Role.AddressId;
              this.OrgName.FieldValue = Role.OrganisationId;
              this.OrgName.FieldText = Role.Organisation.Name;
              this.InvoiceContact.FieldValue = Role.Id;
              this.InvoiceContact.FieldText = Role.PersonName;
              this.InvoicePersonId.FieldValue = Role.PersonId;
              this.InvoiceAddressId.FieldValue = Role.AddressId;
              this.InvOrgName.FieldValue = Role.OrganisationId;
              this.InvOrgName.FieldText = Role.Organisation.Name;
              this.Payment.AddressId.FieldValue = Role.AddressId;
              this.Payment.Organisation.FieldValue = Role.OrganisationId;
              this.Payment.Organisation.FieldText = Role.Organisation.Name;
              this.Payment.Person.FieldValue = Role.Id;
              this.Payment.Person.FieldText = Role.PersonName;
            }
            if (orgId != null)
            {
              Organisation Organisation = Organisation.FetchById(orgId);
              this.BookerAddressId.FieldValue = Organisation.PrincipalAddress.Id;
              this.OrgName.FieldValue = Organisation.Id;
              this.OrgName.FieldText = Organisation.Name;
              this.InvoiceAddressId.FieldValue = Organisation.PrincipalAddress.Id;
              this.InvOrgName.FieldValue = Organisation.Id;
              this.InvOrgName.FieldText = Organisation.Name;
              this.Payment.AddressId.FieldValue = Organisation.PrincipalAddress.Id;
              this.Payment.Organisation.FieldValue = Organisation.Id;
              this.Payment.Organisation.FieldText = Organisation.Name;
            }
            if (oppId != null)
            {
              Opportunity Opp = Opportunity.FetchById(oppId);
              this.OpportunityId.FieldValue = oppId;
              this.Contact.FieldValue = Opp.ClientOppXref.RoleId;
              this.Contact.FieldText = Opp.ClientOppXref.SalesPerson;
              this.BookerAddressId.FieldValue = Opp.ClientOppXref.Role.AddressId;
              this.OrgName.FieldValue = Opp.ClientOppXref.OrganisationId;
              this.OrgName.FieldText = Opp.ClientOppXref.OrgName;
              this.InvoiceContact.FieldValue = Opp.ClientOppXref.RoleId;
              this.InvoiceContact.FieldText = Opp.ClientOppXref.SalesPerson;
              this.InvoicePersonId.FieldValue = Opp.ClientOppXref.Role.PersonId;
              this.InvoiceAddressId.FieldValue = Opp.ClientOppXref.Role.AddressId;
              this.InvOrgName.FieldValue = Opp.ClientOppXref.OrganisationId;
              this.InvOrgName.FieldText = Opp.ClientOppXref.OrgName;
              this.Payment.AddressId.FieldValue = Opp.ClientOppXref.Role.AddressId;
              this.Payment.Organisation.FieldValue = Opp.ClientOppXref.OrganisationId;
              this.Payment.Organisation.FieldText = Opp.ClientOppXref.OrgName;
              this.Payment.Person.FieldValue = Opp.ClientOppXref.RoleId;
              this.Payment.Person.FieldText = Opp.ClientOppXref.SalesPerson;

            }


            // Selecting a person should pre-populate the organisation and the payee person
            this.InvoiceContact.ClientOnChange += "if (" + this.InvoiceContact.ClientID + ".getData() && " + this.InvoiceContact.ClientID + @".getData().organisation) {
                " + this.InvOrgName.ClientID + @".setValue(this.getData().organisation.id, this.getData().organisation.name);
                $('#" + this.InvoiceAddressId.ClientID + @"Field').val(this.getData().address.id);
                $('#" + this.InvoicePersonId.ClientID + @"Field').val(this.getData().pnId);
            }; " + this.Payment.Person.ClientID + @".setValue(this.getValue(), this.getText());";

            // Selecting an organisation should clear the person (if the person does not match the selected organisation) and should also pre-populate the payee organisation
            this.InvOrgName.ClientOnChange += "if (" + this.InvOrgName.ClientID + ".getValue() && !(" + this.InvoiceContact.ClientID + ".getData() && " + this.InvoiceContact.ClientID + ".getData().organisation && " + this.InvoiceContact.ClientID + ".getData().organisation.id && " + this.InvoiceContact.ClientID + ".getData().organisation.id == " + this.InvOrgName.ClientID + @".getValue())) {
                " + this.InvoiceContact.ClientID + @".setValue(null);
            }; " + this.Payment.Organisation.ClientID + @".setValue(this.getValue(), this.getText());";

            // Selecting a person should pre-populate the organisation 
            this.Contact.ClientOnChange += "if (" + this.Contact.ClientID + ".getData() && " + this.Contact.ClientID + @".getData().organisation) {
                " + this.OrgName.ClientID + @".setValue(this.getData().organisation.id, this.getData().organisation.name);
                 $('#" + this.BookerAddressId.ClientID + @"Field').val(this.getData().address.id);
                $('#" + this.Payment.AddressId.ClientID + @"Field').val(this.getData().address.id);
              if (!" + this.InvoiceContact.ClientID + @".getData()) {  
                " + this.InvOrgName.ClientID + @".setValue(this.getData().organisation.id, this.getData().organisation.name);
                " + this.InvoiceContact.ClientID + @".setValue(this.getValue(), this.getText());
                $('#" + this.InvoicePersonId.ClientID + @"Field').val(this.getData().pnId);
                $('#" + this.InvoiceAddressId.ClientID + @"Field').val(this.getData().address.id);
              }
            };
            newDonationDetails.functions.setGridUrl();";

            // Selecting an organisation should clear the person (if the person does not match the selected organisation) 
            this.OrgName.ClientOnChange += "if (" + this.OrgName.ClientID + ".getValue() && !(" + this.Contact.ClientID + ".getData().organisation && " + this.Contact.ClientID + ".getData().organisation.id && " + this.Contact.ClientID + ".getData().organisation.id == " + this.OrgName.ClientID + @".getValue())) {
                " + this.Contact.ClientID + @".setValue(null);
            }; ";

            // Display the payment/directdebit pages depending upon the payment method selected.
            this.SellCompName.ClientOnChange += "newDonationDetails.functions.setGridUrl()";
            //this.PaymentMethod.ClientOnChange += "newDonationDetails.functions.togglePages();";
            //this.PaymentMethod.ClientOnChange += this.Payment.PaymentType.ClientID + ".setValue(" + this.PaymentMethod.ClientID + @".getData());";
            this.Payment.SellingCompany.ClientOnChange += "newDonationDetails.functions.togglePages();";
            this.Payment.PaymentType.ClientOnChange += "newDonationDetails.functions.togglePages();";


        }
    }
}