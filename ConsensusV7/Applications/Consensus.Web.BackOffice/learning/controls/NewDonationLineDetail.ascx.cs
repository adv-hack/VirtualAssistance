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
  public partial class NewDonationLineDetail : BaseControl<Element, String>
    {
        public override String DataTypeName
        {
            get { return "Donation"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Element> DataLoader
        {
          get { return Element.FetchById; }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            this.SellingCompany.FieldValue = this.Request.QueryString["sellingCompany"];
            this.DelegateAddress.FieldValue = this.Request.QueryString["addressId"];
            this.DelegateOrg.FieldValue = this.Request.QueryString["organisationId"];
            this.DelegateRole.FieldValue = this.Request.QueryString["roleId"];

            String Personid = this.Request.QueryString["personid"];
            this.DelegatePerson.FieldValue = Personid;
            this.Qty.FieldValue = "1";
            this.PaymentMethod.FieldValue = "01-Invoice";
            this.Type.FieldValue = "29";
            this.MainSession.FieldValue = "1";
            // Set the cost codes to those applicable to the currently selected selling company
            if (this.SellingCompany.FieldValue != "")
            {
              this.CostCode.DataSource = Finance.CostCode.FetchAll().Where(costCode => String.IsNullOrEmpty(this.SellingCompany.FieldValue) || String.Equals(costCode.SelcoSpIdId, this.SellingCompany.FieldValue, StringComparison.OrdinalIgnoreCase));
              this.CostCode.DataBind();
            }
            //get active Gift Aid for this person
            IEnumerable<Giftaid> giftaid = Giftaid.FetchAllByPnIdId(Personid).Where(g => g.Active == true);
            foreach (Giftaid gift in giftaid)
            {
              this.ActiveGiftAidId.FieldValue = gift.Id.ToString();
              this.Declaration.FieldValue = gift.TypeCode;
              this.GiftAid.FieldValue = true;
              this.ActiveGiftAidActive.FieldValue = gift.Active.ToString();
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
          base.OnPreRender(e);

          this.DonationProduct.ClientOnChange += "if (" + this.DonationProduct.ClientID + @".getData()) {
                $('#" + this.Description.ClientID + @"Field').val(this.getText());
                $('#" + this.VatCode.ClientID + @"Field').val(this.getData().prod_vat_code);
                $('#" + this.VatCodeValue.ClientID + @"Field').val(this.getData().vat_code_value);
                callPromise(" + this.DonationProduct.ClientID + @".getValue(), '" + this.PriceList.ClientID + @"');
                
            }; ";
        }
    }
}