using Consensus.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.security.controls
{
    public partial class LicenseOwner : BaseControl<License>
    {
        /// <summary>
        ///     Gets the name of the data-type being modified.
        /// </summary>
        public override String DataTypeName
        {
            get { return "License"; }
        }

        /// <summary>
        ///     Registers any client-side script for the control.
        /// </summary>
        protected override void RegisterJavascript()
        {
            this.Person.ClientOnChange = @"
                var data = this.getData();
                if (data) {
                    " + this.Organisation.ClientID + @".setValue(data.organisation.id, data.organisation.name);
                    $('#" + this.Address.ClientID + @"Field').val(data.address.mailstring);
                    $('#" + this.Phone.ClientID + @"Field').val(data.telephone);
                    $('#" + this.Email.ClientID + @"Field').val(data.email);
                } else {
                    $('#" + this.Organisation.ClientID + @"Field').val('');
                    $('#" + this.Address.ClientID + @"Field').val('');
                    $('#" + this.Phone.ClientID + @"Field').val('');
                    $('#" + this.Email.ClientID + @"Field').val('');
                }";
        }
    }
}