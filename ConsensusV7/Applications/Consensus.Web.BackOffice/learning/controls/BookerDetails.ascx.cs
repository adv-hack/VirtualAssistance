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
    public partial class BookerDetails : BaseControl<Booking, String>
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
            this.Contact.ClientOnChange = @"
                if (this.getData() && this.getData().organisation != null && this.getData().address != null && isDataAvailable == false) {

                    isDataAvailable = true;
                    " + this.OrgName.ClientID + @".setValue(this.getData().organisation.id, this.getData().organisation.name);
                    $('#" + this.BookerAddress.ClientID + @"Field').val(this.getData().address.mailstring);
                    $('#" + this.BookerAddressId.ClientID + @"Field').val(this.getData().address.id);
                    isDataAvailable = false;

                }";

            this.OrgName.ClientOnChange = @"
                if (this.getData() && isDataAvailable == false) { 
                    " + this.Contact.ClientID + @".setValue(''); 
                    $('#" + this.BookerAddress.ClientID + @"Field').val('');
                    $('#" + this.BookerAddressId.ClientID + @"Field').val('');
                }
                if (" + this.OrgName.ClientID + @".getData() == null && isDataAvailable == false) {
                    " + this.Contact.ClientID + @".setValue(''); 
                    $('#" + this.BookerAddress.ClientID + @"Field').val('');
                    $('#" + this.BookerAddressId.ClientID + @"Field').val('');
                }";
        }
    }
}