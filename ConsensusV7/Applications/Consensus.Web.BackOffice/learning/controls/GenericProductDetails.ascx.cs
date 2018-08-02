using Consensus.Learning;
using Consensus.Common;
using Consensus.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class GenericProductDetails : BaseControl<Product, String>
    {
        /// <summary>
        /// Flag for Product - SysProduct
        /// </summary>
        private string _sysProductType;

        /// <summary>
        ///     The flag for zero VAT
        /// </summary>
        private Boolean _zeroVAT = false;

        /// <summary>
        ///     Gets or sets the flag for zero VAT
        /// </summary>
        public Boolean ZeroVAT
        {
            get { return _zeroVAT; }
            set { _zeroVAT = value; }
        }

        /// <summary>
        /// Gets or sets the flag for SysProduct Type
        /// </summary>
        public String SysProductType
        {
            get { return _sysProductType; }
            set { _sysProductType = value; }
        }
        public override String DataTypeName
        {
            get { return "Product"; }
        }

        protected override void OnInit(EventArgs e)
        {
            this.SellCompName.DataSource = Common.SellingCompany.FetchAll(); 
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //SysProduct: 17 - for MembershipGrade; 16 - SpecialistGroup; 19 - ConsultantScheme
            if (this.SysProductType == "17" || this.SysProductType == "16" || this.SysProductType == "19")
            {
                this.TopLevel.Visible = false;
                this.DefDelStat.Visible = false;
            }
        }

        protected override void PopulateControl()
        {

            this.ProdMan.FieldValue = this.DataSource.ProductManager.Id;
            this.ProdMan.FieldText = this.DataSource.ProductManager.PersonName;

            //this.SellCompName.DataSource = Common.SellingCompany.FetchAll();
            this.SellCompName.FieldValue = this.DataSource.SellingCompany.Id;

            // Set the cost codes to those applicable to the currently selected selling company
            this.CostCode.DataSource = Finance.CostCode.FetchAll().Where(costCode => String.IsNullOrEmpty(this.DataSource.SellingCompanyId) || String.Equals(costCode.SelcoSpIdId, this.DataSource.SellingCompanyId, StringComparison.OrdinalIgnoreCase));
           // this.CostCode.DataBind();

            if (string.IsNullOrEmpty(this.DataSource.CostCode))
                this.CostCode.FieldValue = "";

            if (this.DataSource.Id == null)
            {
                this.TopLevel.FieldValue = true;
            }

        }
        protected bool ZeroVAT_OnLoadDataSource(Code code)
        {
            Decimal parsed;
            if (ZeroVAT == true)
                return Decimal.TryParse(code.Value3, out parsed) && parsed.In(0); 
            else
                return Decimal.TryParse(code.Value3, out parsed); 
        }
        protected override void RegisterJavascript()
        {
            this.SellCompName.ClientOnChange = "updateCostCode('" + this.SellCompName.ClientID + "', '" + this.CostCode.ClientID + "');";
            this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "GenericProductDetailJs", @"
                function validateCostCode(source, arguments) {
                    var rCode = $('#" + this.RevCode.ClientID + @"Field').val();
                    var cCode = $('#" + this.CostCode.ClientID + @"Field').val();
                    arguments.IsValid = (!rCode || rCode.length == 0 || (cCode && cCode.length != 0));
                }
                function validateRevCode(source, arguments) {
                    var rCode = $('#" + this.RevCode.ClientID + @"Field').val();
                    var cCode = $('#" + this.CostCode.ClientID + @"Field').val();
                    arguments.IsValid = (!cCode || cCode.length == 0 || (rCode && rCode.length != 0));
                }
                function CheckForPrice(source, arguments) {
                  var status = $('#" + this.Status.ClientID + @"Field').val();
                  var ProdId = $('#" + this.ProductId.ClientID + @"Field').val();
                  var Prices = true;
                  if (status == '1') {
                    if (ProdId != """") {
                      var pricelists = GetPrices(ProdId)
                      Prices = (pricelists.length != 0);
                    }
                    else {
                      Prices = false;
                    }
                  }
                  arguments.IsValid = Prices;
                }
                function validateUniqueReference(source, args) {
                var productId = $('#" + this.ProductId.ClientID + @"Field').val();
                var reference = $('#" + this.Ref.ClientID + @"Field').val();
                consensus.network.send({
                    async: false,
                    method: 'post',
                    url: 'learning/product/FetchAllByReference?reference=' + reference ,
                    success: function (response) {
                        if (response) {
                            if (response != productId) {
                                args.IsValid = false;
                            }
                        }
                    },
                    error: function (request) {
                    }
                });
                }
            ", true);


        }
    }
}