using Consensus.Learning;
using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class InvoiceDetails : BaseControl<Booking, String>
    {
        public override string DataTypeName
        {
            get { return "Donation"; }
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();
        }

        protected override void RegisterJavascript()
        {
            this.InvoiceContact.ClientOnChange = @"
                if (this.getData()) {
                    " + this.InvOrgName.ClientID + @".setValue(this.getData().organisation.id, this.getData().organisation.name);
                    $('#" + this.InvoiceAddress.ClientID + @"Field').val(this.getData().address.mailstring);
                    $('#" + this.InvoiceAddressId.ClientID + @"Field').val(this.getData().address.id);
                }";

            this.InvOrgName.ClientOnChange = @"
                if (this.getData()) { 
                    " + this.InvoiceContact.ClientID + @".setValue(''); 
                    " + this.ARNo.ClientID + @".setValue('');
                    $('#" + this.InvoiceAddress.ClientID + @"Field').val('');
                    $('#" + this.InvoiceAddressId.ClientID + @"Field').val('');
                }
                if (" + this.InvOrgName.ClientID + @".getData() == null) {
                    " + this.InvoiceContact.ClientID + @".setValue(''); 
                    $('#" + this.InvoiceAddress.ClientID + @"Field').val('');
                    $('#" + this.InvoiceAddressId.ClientID + @"Field').val('');
                }";

            this.ARNo.ClientOnChange = @"
                if (this.getData()) {
                    if (this.getData().org_id && this.getData().org_id.length != 0) {
                        " + this.InvOrgName.ClientID + @".setValue(this.getData().org_id, this.getData().org_name);
                    } else {
                        " + this.InvOrgName.ClientID + @".setValue(null);
                    }
                    if (this.getData().add_id && this.getData().add_id.length != 0) {
                        $('#" + this.InvoiceAddress.ClientID + @"Field').val(this.getData().add_mailstring);
                        $('#" + this.InvoiceAddressId.ClientID + @"Field').val(this.getData().add_id);
                    } else {
                        $('#" + this.InvoiceAddress.ClientID + @"Field').val('');
                        $('#" + this.InvoiceAddressId.ClientID + @"Field').val('');
                    }
                    if (this.getData().person_id && this.getData().person_id.length != 0) {
                        " + this.InvoiceContact.ClientID + @".setValue(this.getData().prole_id, this.getData().person_name); 
                    } else {
                        " + this.InvoiceContact.ClientID + @".setValue(null); 
                    }
                }";
        }
    }
}