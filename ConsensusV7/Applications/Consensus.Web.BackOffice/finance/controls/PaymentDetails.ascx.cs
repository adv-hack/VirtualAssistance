using Consensus.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Document;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class PaymentDetails : BaseControl<Payment, String>
    {
        public override string DataTypeName
        {
            get { return "Payment"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();

            this.SellingCompany.DataSource = Common.SellingCompany.FetchAll();
            this.SellingCompany.FieldValue = this.DataSource.SellingCompany.Id;
            //this.Purpose.FieldValue = this.DataSource.Purpose.ConvertTo<String>("0");
            //this.Conversion.FieldValue = ((double)this.DataSource.ConversionRate).ToString();
        }

        protected override void RegisterJavascript()
        {
            base.RegisterJavascript();
            this.ARNum.ClientOnChange = @"
                if (this.getData() && (this.getValue() || '') != '') {
                    if (this.getData().org_id && this.getData().org_id.length != 0) {
                        " + this.AROrg.ClientID + @".setValue(this.getData().org_id, this.getData().org_name);
                    } else {
                        " + this.AROrg.ClientID + @".setValue(null);
                    }
                    if (this.getData().person_id && this.getData().person_id.length != 0) {
                        " + this.PersonName.ClientID + @".setValue(this.getData().prole_id, this.getData().person_name); 
                    } else {
                        " + this.PersonName.ClientID + @".setValue(null); 
                    }
                }
            ";

            this.AROrg.ClientOnChange = @"
                if (!" + this.ARNum.ClientID + ".getData() || !" + this.ARNum.ClientID + ".getData().org_id || " + this.ARNum.ClientID + @".getData().org_id.length == 0 || " + this.ARNum.ClientID + @".getData().org_id != this.getValue()) {
                    " + this.ARNum.ClientID + @".setValue(null);
                }
            ";
        }
    }
}