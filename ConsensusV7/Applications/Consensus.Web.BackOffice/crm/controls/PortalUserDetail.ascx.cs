using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Portal;
using Consensus.Contact;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class PortalUserDetail : BaseControl<PortalUser, String>
    {
        public override String DataTypeName
        {
            get { return "Portal User"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();

            this.SellingCompany.DataSource = Common.SellingCompany.FetchAll();
            this.SellingCompany.FieldValue = this.DataSource.SellingCompany.Id;          
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (String.IsNullOrEmpty(this.DataSource.PersonRoleId))
                this.SellingCompany.FieldValue = CurrentSession.User.SellingCompanyId;

            if (!String.IsNullOrEmpty(this.DataSource.AuthProvider))
                 this.AuthProvider.FieldValue = "Secure Authentication Provider"; 
            else if (!String.IsNullOrEmpty(this.DataSource.Id.ToString()) && (!String.IsNullOrEmpty(this.DataSource.LastLogin.ToString())))
                this.AuthProvider.FieldValue = "Legacy";

            if (!String.IsNullOrEmpty(this.DataSource.FirstLogin.ToString())) 
               this.FirstLogin.FieldValue = this.DataSource.FirstLogin.Value.ToString("dd MMMM yyyy HH:mm");

           if (!String.IsNullOrEmpty(this.DataSource.LastLogin.ToString())) 
            this.LastLogin.FieldValue = this.DataSource.LastLogin.Value.ToString("dd MMMM yyyy HH:mm");

        }

        protected override void RegisterJavascript()
        {
            this.PersonRole.ClientOnChange = @"
                if (this.getData()) {
                    " + this.Organisation.ClientID + @".setValue(this.getData().organisation.id, this.getData().organisation.name);
                }";
        }
    }
}