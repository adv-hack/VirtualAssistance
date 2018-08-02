using Consensus.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class CreditNoteDetails : BaseControl<Invoice, String>
    {
        public override string DataTypeName
        {
            get { return "Invoice"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.SellingCompanyId.DataSource = Common.SellingCompany.FetchAll();
            if (this.DataSource != null && this.DataSource.Id != null)
            {
                this.SellingCompanyId.FieldValue = this.DataSource.SellingCompany.Id;
            }
        }

        protected override void RegisterJavascript()
        {
            this.ARNo.ClientOnChange = @"                                         
                if (this.getData()!=null && this.getData().person_id && this.getData().person_id.length != 0) {
                    " + this.CreditNoteContact.ClientID + @".setValue(this.getData().prole_id, this.getData().person_name); 
                    $('#" + this.PersonId.ClientID + @"Field').val(this.getData().person_id);  
                    " + this.AccountContact.ClientID + @".setValue(this.getData().prole_id, this.getData().person_name); 
                } else {                    
                    " + this.AccountContact.ClientID + @".setValue(null); 
                }

                if (this.getData()!=null && this.getData().title && this.getData().title.length != 0) {
                    $('#" + this.AccountName.ClientID + @"Field').val(this.getData().title);                      
                } else {
                    $('#" + this.AccountName.ClientID + @"Field').val(null);                 
                }

                if (this.getData()!=null && this.getData().status && this.getData().status.length != 0) {
                    $('#" + this.AccountStatus.ClientID + @"Field').val(this.getData().status);                      
                } else {
                    $('#" + this.AccountStatus.ClientID + @"Field').val(null);                       
                }   

            ";

            this.OrgName.ClientOnChange = @"

                if (this.getData() && (this.getValue() || '') != '') {
                    if (this.getText()) {
                        $('#" + this.OrganisationName.ClientID + @"Field').val(this.getText());                         
                    } else {
                        $('#" + this.OrganisationName.ClientID + @"Field').val(null);
                    }                   
                }

                if (!" + this.ARNo.ClientID + ".getData() || !" + this.ARNo.ClientID + ".getData().org_id || " + this.ARNo.ClientID + @".getData().org_id.length == 0 || " + this.ARNo.ClientID + @".getData().org_id != this.getValue()) {          
                    " + this.ARNo.ClientID + @".setValue(null);
                    " + this.AccountContact.ClientID + @".setValue(null);
                    $('#" + this.AccountName.ClientID + @"Field').val(null);
                    $('#" + this.AccountStatus.ClientID + @"Field').val(null);
                }

                if (this.getData()!=null && this.getData().add_id && this.getData().add_id.length != 0) {
                    $('#" + this.AddressMailstring.ClientID + @"Field').val(this.getData().add_mailstring);
                    $('#" + this.AddressId.ClientID + @"Field').val(this.getData().add_id);
                } else {
                    $('#" + this.AddressMailstring.ClientID + @"Field').val(null);
                    $('#" + this.AddressId.ClientID + @"Field').val(null); 
                }   
            ";

            this.CreditNoteContact.ClientOnChange += @"
                if (this.getData() && (this.getValue() || '') != '') {
                    if (this.getData().pnId && this.getData().pnId.length != 0) {
                        $('#" + this.PersonId.ClientID + @"Field').val(this.getData().pnId);                         
                    } else {
                        $('#" + this.PersonId.ClientID + @"Field').val(null);
                    }                   
                }
            ";
        }
    }
}