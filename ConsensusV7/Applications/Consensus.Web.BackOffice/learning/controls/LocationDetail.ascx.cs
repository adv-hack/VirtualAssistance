using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class LocationDetail : BaseControl<Location, String>
    {
        #region properties

        public override string DataTypeName
        {
            get { return "Location"; }
        }

        #endregion

        #region Methods        

        protected override void OnPreRender(EventArgs eventArguments)
        {
            base.OnPreRender(eventArguments);
            this.SellingCompany.DataSource = Common.SellingCompany.FetchAll();

            //Defaults for new Location
            if (this.DataSource == null || this.DataSource.Id == null)
            {
                this.TrainLocation.FieldValue = true;
                this.OurLocation.FieldValue = false;
            }
            else
            {
                this.SellingCompany.FieldValue = this.DataSource.SellingCompanyId;
            }
        }

        protected override void RegisterJavascript()
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID + "Js", String.Format("var {0} = addressField();", this.Address.ClientID), true);

            this.Organisation.ClientOnChange = @"
                if (this.getData()) {
                    $('#" + this.Address.ClientID + @"Field').val(this.getData().add_mailstring);
                    $('#" + this.AddressId.ClientID + @"Field').val(this.getData().add_id);
                    }
                else    {
                    $('#" + this.Address.ClientID + @"Field').val('');
                    $('#" + this.AddressId.ClientID + @"Field').val('');
                    }";

            this.PersonRole.ClientOnChange += @"
                if (this.getData() && (this.getValue() || '') != '') {
                    var data=this.getData();                   
                    document.getElementById('" + this.LocationPhone.ClientID + "Field').value=data.telephone;"
                    + "document.getElementById('" + this.LocationEmail.ClientID + "Field').value=data.email;}";            
        }

        #endregion
    }
}