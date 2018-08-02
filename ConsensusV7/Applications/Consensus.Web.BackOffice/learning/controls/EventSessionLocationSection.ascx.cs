using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class EventSessionLocationSection : BaseControl<Session, String>
    {

        public override String DataTypeName
        {
            get { return "Session"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();

        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            // Register the javascript to initialise the client-instance of the control
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID + "Js", String.Format("var {0} = addressField();",
                this.SessionAddress.ClientID), true);

            this.SessionOrganisation.ClientOnChange = @"
                if (this.getData())
                    $('#" + this.SessionAddress.ClientID + @"Field').val(this.getData().add_mailstring);
                else
                    $('#" + this.SessionAddress.ClientID + @"Field').val('');";

            this.SessionLocation.ClientOnChange = @"
                if (this.getData() && (this.getValue() || '') != '') {
                    
                    var data=this.getData();  
                    " + this.SessionOrganisation.ClientID + @".setValue(data.organisation.id,data.organisation.name);                    
                    $('#" + this.SessionAddress.ClientID + @"Field').val(data.address.add_mailstring);
                    $('#" + this.SessionAddressId.ClientID + @"Field').val(data.address.address.add_id);
                    }
                else    {
                    $('#" + this.SessionAddress.ClientID + @"Field').val('');
                    $('#" + this.SessionAddressId.ClientID + @"Field').val('');
                    }";
        }
    }

}
