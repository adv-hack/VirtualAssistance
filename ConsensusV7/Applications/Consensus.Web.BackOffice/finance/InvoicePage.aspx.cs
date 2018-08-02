using Consensus.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance
{
    public partial class InvoicePage : BaseStandardPage<Invoice, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Invoice - " + this.Data.Reference; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "invoice"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Invoice> DataLoader
        {
            get { return Invoice.FetchById; }
        }
        #endregion

        #region methods

        protected override void PopulateControls()
        {
            this.InvoiceDetails.DataSource = this.Data;
            //this.SOPDetails.DataSource = Data;
            this.InvoiceLines.InvId = this.DataId;
            //this.InvoiceSummary.DataSource = this.Data;
            this.InvoiceAllocation.InvId = this.Data.Id;

            this.PopulateSideBar("javascript:createPayment('" + this.Data.Id + "','" + this.Data.UnpaidValue + "');", "Add Payment");
            this.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, @"
                function createPayment(invId, unpaidValue) {
                    if(parseFloat(unpaidValue) == 0){
                        window.top.swal.call(window.top,{ title: 'Warning', text: 'There is no balance outstanding for this invoice.', type: 'warning', showCancelButton: false, confirmButtonText: 'Ok', confirmButtonClass: 'btn btn-danger', buttonsStyling: false }).then(function (success) {
                        });
                    }
                    else{
                        consensus.web.popupFrame({
                            url: consensus.resolveUrl('~/GenericPopup.aspx?context=finance&control=newpayment&parent=invoice&width=1050&invid=' + invId),
                            open: function () {
                                var button = $(this.window.document.body).find('#Content_PopupFooter_SaveButton');
                                var state = new consensus.data.state(button, { uri: 'finance/payment' }, this.window);
                                consensus.data.setState(state);
                            },
                            result: function (data) {
                              consensus.network.send({
                                method: 'put',
                                url: data.uri,
                                data: data,
                                success: function (result) {
                                  window.location.href = consensus.resolveUrl('~/finance/payment?id=' + result.Id);
                                }
                              });
                            }
                        });
                    }
                }
            ", true);
            this.PopulateSideBar("javascript:creditInvoice('" + this.Data.Id + "');", "Credit invoice");
            SetSendPackSidebarOption();

        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }

        #endregion
    }
}