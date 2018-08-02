using Consensus.Finance;
using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class PaymentAllocationList : BaseListControl
    {
        #region fields

        private String _payId;

        #endregion


        #region properties
        public String PayId
        {
            get { return _payId; }
            set { _payId = value; }
        }

        public override String DataTypeName
        {
            get { return "Payment Allocation List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.PaymentAllocation; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("PA_ID")
                    .Select("PA_INV_ID")
                    .Select("PA_INV_REF")
                    .Select("PA_CREDIT_ID")
                    .Select("PA_CREDIT_REF")
                    .Select("PA_PAY_ID")
                    .Select("PA_CURR_TYPE")
                    .Select("PA_VALUE")
                    .Select("PA_REFUND_ID")
                    .Select("PA_ADD_DATE")
                    .Select("uri")
                    .From(QuerySources.PaymentAllocations)
                    .WhereRaw("(PA_PAY_ID = '" + this.PayId + "' or PA_REFUND_ID = '" + this.PayId + "')", null)
                    .OrderBy("PA_ADD_DATE", true);
            }
        }
        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var payment = Payment.FetchById(this.PayId);
            if (payment.ReverseRes == "Refund")
            {
                this.PaymentAllocation.CanCreate = false;
            }
            else
            {
                this.PaymentAllocation.CanCreate = true;
            }

            this.PaymentAllocation.Url += "&payId=" + HttpUtility.UrlEncode(this.PayId);
            this.DataTable.Json = "{ uri: \"finance/PayAllocation\", PayId: " + HttpUtility.JavaScriptStringEncode(this.PayId, true) + " }";
        }

        #endregion
    }
}