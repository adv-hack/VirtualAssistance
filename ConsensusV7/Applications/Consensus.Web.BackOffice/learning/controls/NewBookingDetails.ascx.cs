using Consensus.Learning;
using Consensus.Contact;
using Consensus.Sales;
using Consensus.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class NewBookingDetails : BaseControl<Booking, String>
    {

        public override String DataTypeName
        {
            get { return "Booking"; }
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

            SellingCompanyConfig sellingCompanyConfig = Common.SellingCompanyConfig.FetchAllBySellingCompanyIdKeyName(CurrentSession.User.SellingCompanyId, "SC_VAT_METHOD").First();

            this.VATCalculation.FieldValue = sellingCompanyConfig.IntValue.ToString();

        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            //set the default value
            String personId = this.Request.QueryString["personId"];
            String roleId = this.Request.QueryString["roleId"];
            String orgId = this.Request.QueryString["orgId"];
            String oppId = this.Request.QueryString["oppId"];

            //roleId = "131";

            if (personId != null)
            {
                Person Person = Person.FetchById(personId);
                this.Contact.FieldValue = Person.PrincipalRole.Id;
                this.Contact.FieldText = Person.PrincipalRole.PersonName;
                this.BookerAddressId.FieldValue = Person.PrincipalRole.AddressId;
                this.OrgName.FieldValue = Person.PrincipalRole.OrganisationId;
                this.OrgName.FieldText = Person.PrincipalRole.Organisation.Name;
                this.BookingAddress.FieldValue = Person.PrincipalRole.Address.MailString;

            }

            if (roleId != null)
            {
                Role Role = Role.FetchById(roleId);
                this.Contact.FieldValue = Role.Id;
                this.Contact.FieldText = Role.PersonName;
                this.BookerAddressId.FieldValue = Role.AddressId;
                this.OrgName.FieldValue = Role.OrganisationId;
                this.OrgName.FieldText = Role.Organisation.Name;
                this.BookingAddress.FieldValue = Role.Address.MailString;

            }
            if (orgId != null)
            {
                Organisation Organisation = Organisation.FetchById(orgId);
                this.OrgName.FieldValue = Organisation.Id;
                this.OrgName.FieldText = Organisation.Name;

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
                this.BookingAddress.FieldValue = Opp.ClientOppXref.Role.Address.MailString;

            }
            //if we have defaulted our booker, get AR number and everything ready

            // Selecting a person should pre-populate the organisation 
            this.Contact.ClientOnChange += "if (" + this.Contact.ClientID + ".getData() && " + this.Contact.ClientID + @".getData().organisation) {
                " + this.OrgName.ClientID + @".setValue(this.getData().organisation.id, this.getData().organisation.name);
                 $('#" + this.BookerAddressId.ClientID + @"Field').val(this.getData().address.id);
                 $('#" + this.BookingAddress.ClientID + @"Field').val(this.getData().address.mailstring);
                 if(this.getData().organisation.id == ''){
                        $('#Content_Content_ctl01_AddressSearch').hide();
                    }else{
                        $('#Content_Content_ctl01_AddressSearch').show();
                    }
            };
            newBookingDetails.functions.getARNumbers();";

            this.Account.ClientOnChange += "newBookingDetails.functions.getBillingContacts()";
            this.InvoiceContact.ClientOnChange += "newBookingDetails.functions.setInvoiceDetails()";

            // Selecting an organisation should clear the person (if the person does not match the selected organisation) 
            this.OrgName.ClientOnChange += "if (" + this.OrgName.ClientID + ".getValue() && !(" + this.Contact.ClientID + ".getData().organisation && " + this.Contact.ClientID + ".getData().organisation.id && " + this.Contact.ClientID + ".getData().organisation.id == " + this.OrgName.ClientID + @".getValue())) {
                " + this.Contact.ClientID + @".setValue(null);
                 $('#" + this.BookerAddressId.ClientID + @"Field').val(this.getData().add_id);
                 $('#" + this.BookingAddress.ClientID + @"Field').val(this.getData().add_mailstring);
            }; ";

            // Display the payment depending upon the payment method selected.
            this.SellCompName.ClientOnChange += "newBookingDetails.functions.getVATCalculation()";
            //this.PaymentMethod.ClientOnChange += "newBookingDetails.functions.togglePages();";
            //this.PaymentMethod.ClientOnChange += this.Payment.PaymentType.ClientID + ".setValue(" + this.PaymentMethod.ClientID + @".getData());";
            this.Payment.SellingCompany.ClientOnChange += "newBookingDetails.functions.togglePages();";
            this.Payment.PaymentType.ClientOnChange += "newBookingDetails.functions.togglePages();";

        }

        protected override void RegisterJavascript()
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID + "Js", String.Format("var {0} = addressField();", this.BookingAddress.ClientID), true);
        }

    }
}