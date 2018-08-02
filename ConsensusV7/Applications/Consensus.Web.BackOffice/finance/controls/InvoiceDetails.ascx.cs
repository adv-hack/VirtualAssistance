using Consensus.Finance;
using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class InvoiceDetails : BaseControl<Invoice, String>
    {
        public override string DataTypeName
        {
            get { return "Invoice"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();

            this.SelCo.DataSource = Common.SellingCompany.FetchAll();
            this.SelCo.FieldValue = this.DataSource.SellingCompany.Id;
            this.Type.FieldValue = "Invoice";
            this.InvoiceNo.IsReadOnly = UserInterface.ConfigurableBoolean.True;
            this.Status.FieldValue = this.DataSource.Status.ConvertTo<String>("0");
            if (!string.IsNullOrEmpty(this.ID))
            {
                this.InvoiceDate.IsReadOnly = UserInterface.ConfigurableBoolean.True;
            }
        }

        protected override void RegisterJavascript()
        {
            this.ARNo.ClientOnChange = @"
                if (this.getData() && (this.getValue() || '') != '') {
                    if (this.getData().org_id && this.getData().org_id.length != 0) {
                        " + this.OrgName.ClientID + @".setValue(this.getData().org_id, this.getData().org_name);
                    } else {
                        " + this.OrgName.ClientID + @".setValue(null);
                    }
                    if (this.getData().person_id && this.getData().person_id.length != 0) {
                        " + this.Contact.ClientID + @".setValue(this.getData().prole_id, this.getData().person_name); 
                    } else {
                        " + this.Contact.ClientID + @".setValue(null); 
                    }
                    if (this.getData().add_id && this.getData().add_id.length != 0) {
                      $('#" + this.AddressMailstring.ClientID + @"Field').val(this.getData().add_mailstring);
                      $('#" + this.AddressId.ClientID + @"Field').val(this.getData().add_id);
                    } else {
                        " + this.Contact.ClientID + @".setValue(null); 
                    }
                }
            ";

            this.OrgName.ClientOnChange = @"

                if (!" + this.ARNo.ClientID + ".getData() || !" + this.ARNo.ClientID + ".getData().org_id || " + this.ARNo.ClientID + @".getData().org_id.length == 0 || " + this.ARNo.ClientID + @".getData().org_id != this.getValue()) {          
                    " + this.ARNo.ClientID + @".setValue(null);
                    " + this.Contact.ClientID + @".setValue(null);
                }
                if (!" + this.Contact.ClientID + ".getData() || !" + this.Contact.ClientID + ".getData().organisation.id || " + this.Contact.ClientID + @".getData().organisation.id.length == 0 || " + this.Contact.ClientID + @".getData().organisation.id != this.getValue()) {          
                    " + this.ARNo.ClientID + @".setValue(null);             
                    " + this.Contact.ClientID + @".setValue(null);
                }
            ";
        }


    }
}