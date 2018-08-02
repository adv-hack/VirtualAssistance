using Consensus.Common;
using Consensus.Contact;
using Consensus.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class NewMemberWizard : BaseControl
    {
        public override String DataTypeName
        {
            get { return "Membership"; }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.SellCompName.DataSource = SellingCompany.FetchAll();

            this.SellCompName.FieldValue = CurrentSession.User.SellingCompanyId;

            SellingCompanyConfig sellingCompanyConfig = SellingCompanyConfig.FetchAllBySellingCompanyIdKeyName(CurrentSession.User.SellingCompanyId, "SC_VAT_METHOD").First();

            this.VATCalculation.FieldValue = sellingCompanyConfig.IntValue.ToString();

        }


        protected override void OnPreRender(EventArgs e)
        {
            //Pre-populate details from person screen
            if (!String.IsNullOrEmpty(this.Request.QueryString["personId"]))
            {
                var person = Contact.Person.FetchById(this.Request.QueryString["personId"]);
                this.Person.FieldValue = person.PrincipalRole.Id;
                this.Person.FieldText = person.FullName;
                this.OrgName.FieldValue = person.PrincipalRole.Organisation.Id;
                this.OrgName.FieldText = person.PrincipalRole.Organisation.Name;
                this.Address.FieldValue = person.PrincipalRole.Address.MailString;
                this.AddressId.FieldValue = person.PrincipalRole.AddressId;
                this.MembershipName.FieldValue = person.Salutation;
                this.Payment.Person.FieldValue = person.FullName;
                this.Payment.Person.FieldValue = person.PrincipalRole.Id;
            }

            if (!String.IsNullOrEmpty(this.Request.QueryString["proleId"]))
            {
                var role = Contact.Role.FetchById(this.Request.QueryString["proleId"]);
                this.Person.FieldValue = role.Id;
                this.Person.FieldText = role.Person.FullName;
                this.OrgName.FieldValue = role.OrganisationId;
                this.OrgName.FieldText = role.Organisation.Name;
                this.Address.FieldValue = role.Address.MailString;
                this.AddressId.FieldValue = role.AddressId;
                this.MembershipName.FieldValue = role.Person.Salutation;
                this.Payment.Person.FieldValue = role.Person.FullName;
                this.Payment.Person.FieldValue = role.Id;
            }

            this.SpecialistGroupList.Data = Query.Create()
                 .Select("PROD_ID")
                 .Select("PROD_NAME")
                 .Select("PROD_REF")
                 .Select("PROD_STATE")
                 .Select("PRS_PRICE")
                 .Select("PROD_PRICE")
                 .Select("PROD_VAT_CODE")
                 .Select("PRS_PL_ID")
                 .From(QuerySources.ActiveSpecialistGroups)
                 .OrderBy("PROD_NAME", true)
                 .Run();

            this.NetTotal.FieldValue = "0";
            this.Total.FieldValue = "0";
            this.VAT.FieldValue = "0";

            base.OnPreRender(e);
            this.StartDate.FieldValue = DateTime.Today;

            // Selecting a person should pre-populate the member organisation and the payee person
            this.Person.ClientOnChange += "if (" + this.Person.ClientID + ".getData() && " + this.Person.ClientID + @".getData().organisation) {
                " + this.OrgName.ClientID + @".setValue(this.getData().organisation.id, this.getData().organisation.name);
                " + this.MembershipName.ClientID + @"Field.value = this.getData().salutation;
                $('#" + this.AddressId.ClientID + @"Field').val(this.getData().address.id);
                $('#" + this.Address.ClientID + @"Field').val(this.getData().address.mailstring);
                };" + this.Payment.Person.ClientID + @".setValue(this.getValue(), this.getText());
                newMemberWizard.functions.getARNumbers()";

            // Selecting an account should pre-populate the organisation and the payee account           
            this.AccountId.ClientOnChange += "newMemberWizard.functions.getBillingContacts()";
            this.InvoiceContact.ClientOnChange += "newMemberWizard.functions.setInvoiceDetails()";


            // Selecting an organisation should clear the person (if the person does not match the selected organisation) and should also pre-populate the payee organisation
            this.OrgName.ClientOnChange += "if (" + this.OrgName.ClientID + ".getValue() && !(" + this.Person.ClientID + ".getData().organisation && " + this.Person.ClientID + ".getData().organisation.id && " + this.Person.ClientID + ".getData().organisation.id == " + this.OrgName.ClientID + @".getValue())) {
                " + this.Person.ClientID + @".setValue(null);
            }; " + this.Payment.Organisation.ClientID + @".setValue(this.getValue(), this.getText());";

            // Selecting a membership product should obtain product information so that the end date and price can be determined.
            this.MembershipProduct.ClientOnChange += "isGradePricePopulated=false; newMemberWizard.functions.populateEndDate(); newMemberWizard.functions.populatePriceList();directdebit.functions.populateDirectDebitDefaults(" + this.MembershipProduct.ClientID + ".getValue());newMemberWizard.functions.togglePages()";
            this.StartDate.ClientOnChange += "newMemberWizard.functions.populateEndDate();";
            this.PriceList.ClientOnChange += "newMemberWizard.functions.populatePrice();";
            this.EndDate.ClientOnChange += "newMemberWizard.functions.populatePrice();";
            this.Quantity.ClientOnChange += "newMemberWizard.functions.populatePrice();";

            // Display the payment/directdebit pages depending upon the payment method selected.

            this.Payment.SellingCompany.ClientOnChange += "newMemberWizard.functions.togglePaymentPages();";
            this.Payment.PaymentType.ClientOnChange += "newMemberWizard.functions.togglePaymentPages();";
            this.productPrices.DataSource = Finance.Price.FetchAll()
                .GroupBy(s => new { s.ProductId, s.PriceListId, s.Amount })
                .OrderBy(g => g.Key.ProductId).ThenBy(a => a.Key.Amount)
                .Select(prod => new
                {
                    ProdPrice = new
                    {
                        ProductId = prod.Key.ProductId,
                        PriceListId = prod.Key.PriceListId
                    },
                    ProductId = prod.Key.ProductId,
                    Amount = prod.Min(a => a.Amount),
                    PriceListId = prod.Key.PriceListId
                });
            this.PriceListForSummary.DataSource = Finance.PriceList.FetchAll();
            this.prodVATvalues.DataSource = Common.Code.FetchAllByType("VATCD");
        }
    }
}