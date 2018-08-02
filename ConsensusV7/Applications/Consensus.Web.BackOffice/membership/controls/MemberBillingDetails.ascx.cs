using Consensus.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Document;
using Consensus.Finance;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class MemberBillingDetails : BaseControl<MemberPeriod, String>
    {
        public override string DataTypeName
        {
            get { return "Billing"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();

            this.InvAddress.DataSource = this.DataSource.InvAddress;
            this.InvAddress.OrganisationId = this.DataSource.InvOrganisationId;
            this.InvAddress.PersonId = this.DataSource.InvoiceRole.PersonId;

            if (this.DataSource.DirectDebits.Count > 0)
            {
                DirectDebit directDebit = this.DataSource.DirectDebits.OfType<DirectDebit>().LastOrDefault();
                if (directDebit != null && directDebit.Status != null)
                    this.DDStatus.FieldValue = GetDDStatusString(directDebit.Status.Value);
                else
                    this.DDStatus.Visible = false;
            }
            else
            {
                this.DDStatus.Visible = false;
            }

            int nonInvoicedCount = 0;
            foreach(MemberLocation loc in this.DataSource.MemberLocations)
            {
                if(loc.SyType>=0 && loc.SyType < 5 && loc.Invoiced == 0)
                {
                    nonInvoicedCount++;
                }
            }

            this.Invoiced.FieldValue = nonInvoicedCount == 0;

            
        }

        private string GetDDStatusString(int ddStatus)
        {
            switch (ddStatus)
            {
                case 0:
                    return "New Instruction";
                case 1:
                    return "Authorisation Sent to Bank";
                case 2:
                    return "Rejected by Bank";
                case 3:
                    return "First Collection";
                case 4:
                    return "Standard Collection";
                case 5:
                    return "Payment sent to Bank";
                case 6:
                    return "Payment Rejected";
                case 7:
                    return "Cancelled by Member";
                case 8:
                    return "Cancellation sent to Bank";
                case 9:
                    return "Cancellation accepted by Bank";
                case 10:
                    return "Membership Cancelled";
                default:
                    return "";
            }
        }

        protected override void RegisterJavascript()
        {
            base.RegisterJavascript();
            this.ARNum.ClientOnChange = @"
                var data = this.getData();
                if (data && (this.getValue() || '') != '') {
                    $('#" + this.AccountName.ClientID + @"Field').val(data.title); $('#" + this.AccountStatus.ClientID + @"Field').val(data.status);
            if (data.org_id && data.org_id.length != 0) {
                        " + this.InvoiceOrg.ClientID + @".setValue(data.org_id, data.org_name);
                    } else {
                        " + this.InvoiceOrg.ClientID + @".setValue(null);
                    }
                    if (data.person_id && data.person_id.length != 0) {
                        " + this.AccountContact.ClientID + @".setValue(data.prole_id, data.person_name); 
                        " + this.InvoiceContact.ClientID + @".setValue(data.prole_id, data.person_name); 
                    } else {
                        " + this.InvoiceContact.ClientID + @".setValue(null); " + this.AccountContact.ClientID + @".setValue(null); 
                    }
                    if (data.add_id && data.add_id.length != 0)  
                        " + this.InvAddress.ClientID + @".lockFields(data.org_id, data.add_id, data.addressLine1, data.addressLine2, data.addressLine3, data.town, data.county, data.postcode, data.country);
                    else
                    " + this.InvAddress.ClientID + @".unlockFields();
                }
                else {
                     $('#" + this.AccountName.ClientID + @"Field').val(''); $('#" + this.AccountStatus.ClientID + @"Field').val('');" + this.AccountContact.ClientID + @".setValue(null); 
                }

            ";

            this.InvoiceOrg.ClientOnChange = @"
                var orgData = this.getData();
                if (!" + this.ARNum.ClientID + ".getData() || !" + this.ARNum.ClientID + ".getData().org_id || " + this.ARNum.ClientID + @".getData().org_id.length == 0 || " + this.ARNum.ClientID + @".getData().org_id != this.getValue()) {
                    " + this.ARNum.ClientID + @".setValue(null);  
                        if( orgData.add_id && orgData.add_id.length !=0) {
                            "+ this.InvAddress.ClientID + @".lockFields(orgData.org_id, orgData.add_id, orgData.addressLine1, orgData.addressLine2, orgData.addressLine3, orgData.town, orgData.county, orgData.postcode, orgData.country);}
                   
        }
            ";
        }
    }
}
