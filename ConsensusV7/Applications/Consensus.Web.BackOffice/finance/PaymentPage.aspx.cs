using Consensus.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance
{
    public partial class PaymentPage : BaseStandardPage<Payment, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Payment - " + this.Data.Id; }
        }

        public override string DefaultIcon
        {
            get
            {
                return "receive_cash";
            }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Payment> DataLoader
        {
            get { return Payment.FetchById; }
        }

        #endregion

        #region methods

        protected override void PopulateControls()
        {
            this.PaymentDetails.DataSource = this.Data;
            this.PaymentAllocation.PayId = this.Data.Id;

            if (this.Data.ReverseRes != "Refund")
            {
                this.PopulateSideBar("javascript:refund('" + this.Data.Id + "');", "Refund");
            }
            this.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, @"
                function refund(payId) {
                    consensus.web.popupFrame({
                        url: consensus.resolveUrl('~/GenericPopup.aspx?context=finance&control=newpayment&parent=payment&width=1050&payId=' + payId),
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
            ", true);
        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }

        #endregion
    }
}