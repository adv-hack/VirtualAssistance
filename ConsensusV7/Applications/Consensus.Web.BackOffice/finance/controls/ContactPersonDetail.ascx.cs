using Consensus.Finance;
using System;
using System.Linq;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class ContactPersonDetail : BaseControl<AccountXref, String>
    {
        public override Func<String, AccountXref> DataLoader

        {
            get { return AccountXref.FetchById; }
        }
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            MainContact.IsReadOnly = UserInterface.ConfigurableBoolean.True;
            Statement.IsReadOnly = UserInterface.ConfigurableBoolean.True;
            Invoice.IsReadOnly = UserInterface.ConfigurableBoolean.True;
            MustUse.IsReadOnly = UserInterface.ConfigurableBoolean.True;
        }

        /// <summary>
        ///     Sets if record can be deleted
        /// </summary>
        private Boolean _allowDelete = true;

        /// <summary>
        ///     Sets if record can be deleted
        /// </summary>
        public override bool AllowDelete
        {
            get { return _allowDelete; }
            set { _allowDelete = value; }
        }

        public override string DataTypeName
        {
            get { return "Contact Person"; }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            //get available contacts for the respective account Id            
            var contactList = AccountXref.FetchAllByAccountId(Request.QueryString["accountId"]).ToList();
            //bind the value in the hidden field
            AvailableContacts.FieldValue = contactList.Count(r=>r.RoleId!=null).ToString();
            //bind the value in the hidden field
            AccountId.FieldValue = Request.QueryString["accountId"];
            if (DataSource != null)
            {
                IsEdit.FieldValue = "True";
                IsMainContactOnEdit.FieldValue = DataSource.Main == 1 ? "True" : "False";
                PersonId.FieldValue = this.DataSource.Role.PersonId;
                AccountXRefId.FieldValue = this.DataSource.Id;
                RoleId.FieldValue = DataSource.RoleId;                                
                if (DataSource.Role.PersonName != null)
                {
                    MainContact.IsReadOnly = this.DataSource.Main == 1 ? UserInterface.ConfigurableBoolean.True : UserInterface.ConfigurableBoolean.False;
                    Statement.IsReadOnly = UserInterface.ConfigurableBoolean.False;
                    Invoice.IsReadOnly = UserInterface.ConfigurableBoolean.False;
                    MustUse.IsReadOnly = UserInterface.ConfigurableBoolean.False;
                }
            }
            else
            {
                IsEdit.FieldValue = "False";
                IsMainContactOnEdit.FieldValue = "False";
            }

            Contact.ClientOnChange = @"
                if (this.getData() && (this.getValue() || '') != '') {

                var data = this.getData();  
                if(data){
                
                    if (!data.organisation && !data.organisation.id && data.organisation.id.length == 0) 
                    {" + OrgName.ClientID + @".setValue(''); }

                          " + OrgName.ClientID + @".setValue(data.organisation.id, data.organisation.name); 
                            if($('#" + IsEdit.ClientID + @"Field').val() == 'False' || $('#" + IsMainContactOnEdit.ClientID + @"Field').val() == 'False')
                            { 
                                $('#" + MainContact.ClientID + @"Field').bootstrapSwitch('disabled',false).bootstrapSwitch('readonly',false);
                                $('#" + MainContact.ClientID + @"Field').bootstrapSwitch('state', false);  
                            }                   
                            else if($('#" + MainContact.ClientID + @"Field')[0].checked == true)
                            {
                                $('#" + MainContact.ClientID + @"Field').bootstrapSwitch('disabled',false).bootstrapSwitch('readonly',true);
                            }
                            else
                            {
                               $('#" + MainContact.ClientID + @"Field').bootstrapSwitch('disabled',false).bootstrapSwitch('readonly',false);
                            }
                          $('#" + Invoice.ClientID + @"Field').bootstrapSwitch('disabled',false).bootstrapSwitch('readonly',false);
                          $('#" + MustUse.ClientID + @"Field').bootstrapSwitch('disabled',false).bootstrapSwitch('readonly',false);
                          $('#" + Statement.ClientID + @"Field').bootstrapSwitch('disabled',false).bootstrapSwitch('readonly',false);
                      
                       
                           if($('#" + AvailableContacts.ClientID + @"Field').val() == '0'){
                                 $('#" + MainContact.ClientID + @"Field').bootstrapSwitch('state', true);   
                                $('#" + MainContact.ClientID + @"Field').bootstrapSwitch('disabled',false).bootstrapSwitch('readonly',true);
                           }                        
                            $('#" + this.OrganisationId.ClientID + @"Field').val(data.organisation.id);                                                               
                    
                }
                else
                {
                   " + OrgName.ClientID + @".setValue('');                  
                   $('#" + MainContact.ClientID + @"Field').bootstrapSwitch('disabled',true).bootstrapSwitch('readonly',true);
                   $('#" + Invoice.ClientID + @"Field').bootstrapSwitch('disabled',true).bootstrapSwitch('readonly',true);
                   $('#" + MustUse.ClientID + @"Field').bootstrapSwitch('disabled',true).bootstrapSwitch('readonly',true);
                   $('#" + Statement.ClientID + @"Field').bootstrapSwitch('disabled',true).bootstrapSwitch('readonly',true);
                   $('#" + MainContact.ClientID + @"Field').bootstrapSwitch('state', false);
                    $('#" + this.OrganisationId.ClientID + @"Field').val(''); 
                }
                
                if (data.address.mailstring && data.address.id && data.address.id.length != 0) 
                {                   
                      $('#" + Address.ClientID + @"Field').val(data.address.mailstring);
                      $('#" + AddressId.ClientID + @"Field').val(data.address.id);                                         
                }
                else
                {
                      $('#" + Address.ClientID + @"Field').val('');
                      $('#" + AddressId.ClientID + @"Field').val('');
                }
                
                }
                if(data == undefined)
                {      
                        if($('#" + IsEdit.ClientID + @"Field').val() == 'False' || $('#" + IsMainContactOnEdit.ClientID + @"Field').val() == 'False')
                        { 
                            $('#" + MainContact.ClientID + @"Field').bootstrapSwitch('disabled',false).bootstrapSwitch('readonly',false);
                            $('#" + MainContact.ClientID + @"Field').bootstrapSwitch('state', false);  
                        }
                        $('#" + Invoice.ClientID + @"Field').bootstrapSwitch('state', false);  
                        $('#" + MustUse.ClientID + @"Field').bootstrapSwitch('state', false);
                        $('#" + Statement.ClientID + @"Field').bootstrapSwitch('state', false);   
                        $('#" + this.PersonId.ClientID + @"Field').val('');    
                        $('#" + this.RoleId.ClientID + @"Field').val('');                                            
                        $('#" + MainContact.ClientID + @"Field').bootstrapSwitch('disabled',true).bootstrapSwitch('readonly',true);
                        $('#" + Invoice.ClientID + @"Field').bootstrapSwitch('disabled',true).bootstrapSwitch('readonly',true);
                        $('#" + MustUse.ClientID + @"Field').bootstrapSwitch('disabled',true).bootstrapSwitch('readonly',true);
                        $('#" + Statement.ClientID + @"Field').bootstrapSwitch('disabled',true).bootstrapSwitch('readonly',true);                                                    
                        if($('#" + MainContact.ClientID + @"Field')[0].checked == true)
                        { 
                            $('#" + canNotSaveContact.ClientID + @"Field').val(1);                                                 
                        }                                       
                }
                else
                {

                        $('#" + canNotSaveContact.ClientID + @"Field').val(0);     
                        $('#" + this.PersonId.ClientID + @"Field').val(data.pnId); 
                        $('#" + this.RoleId.ClientID + @"Field').val(this._current.value);    
                }
                ";

            OrgName.ClientOnChange = @"
                if(this.getData())
                {
                    var data = this.getData();                         
                    var prevOrg_id = $('#" + this.OrganisationId.ClientID + @"Field').val();
                    if(prevOrg_id != data.org_id)
                    {
                         $('#" + this.PersonId.ClientID + @"Field').val(null);    
                         $('#" + this.RoleId.ClientID + @"Field').val(null);    
                        $('#" + this.Contact.ClientID + @"Field').val(null);   
                        " + this.Contact.ClientID + @".setValue(null);  
                        $('#" + MainContact.ClientID + @"Field').bootstrapSwitch('disabled',true).bootstrapSwitch('readonly',true);
                        $('#" + Invoice.ClientID + @"Field').bootstrapSwitch('disabled',true).bootstrapSwitch('readonly',true);
                        $('#" + MustUse.ClientID + @"Field').bootstrapSwitch('disabled',true).bootstrapSwitch('readonly',true);
                        $('#" + Statement.ClientID + @"Field').bootstrapSwitch('disabled',true).bootstrapSwitch('readonly',true);
                        if($('#" + canNotSaveContact.ClientID + @"Field').val() == '1')
                        {
                            $('#" + MainContact.ClientID + @"Field').bootstrapSwitch('state', false);  
                        }
                        $('#" + Invoice.ClientID + @"Field').bootstrapSwitch('state', false);  
                        $('#" + MustUse.ClientID + @"Field').bootstrapSwitch('state', false);
                        $('#" + Statement.ClientID + @"Field').bootstrapSwitch('state', false);  
                    }

                    if (data.add_mailstring && data.add_id && data.add_id.length != 0) 
                    {                   
                          $('#" + Address.ClientID + @"Field').val(data.add_mailstring);
                          $('#" + AddressId.ClientID + @"Field').val(data.add_id);                                              
                    }
                   else
                   {
                          $('#" + Address.ClientID + @"Field').val('');
                          $('#" + AddressId.ClientID + @"Field').val('');                        
                   }
                    if(data == undefined)
                    {
                        $('#" + this.OrganisationId.ClientID + @"Field').val('');                                            
                    }
                    else
                    {    
                        $('#" + this.OrganisationId.ClientID + @"Field').val(data.org_id);   
                    }
                }    
                else                      
                   { $('#" + this.OrganisationId.ClientID + @"Field').val('');    }
                ";
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            if (DataSource != null)
            {
                AllowDelete = DataSource.Main != 1;
            }
        }

        protected override void RegisterJavascript()
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID + "Js", String.Format("var {0} = addressField();", this.Address.ClientID), true);
        }
    }
}