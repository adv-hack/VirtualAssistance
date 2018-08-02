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
    public partial class InvoiceAllocationList : BaseListControl
    {
        #region fields

        private String _invId;


        #endregion


        #region properties
        public String InvId
        {
            get { return _invId; }
            set { _invId = value; }
        }


        public override String DataTypeName
        {
            get { return "Invoice Allocation List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.InvoiceAllocation; }
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
                    .Select("PA_DATE")
                    .Select("PAY_TYPE")
                    .Select("uri")
                    .From(QuerySources.InvoiceAllocations)
                    .Where("PA_INV_ID", QueryConditionTypes.Equal, this.InvId)
                    .OrderBy("PA_DATE", true);
            }
        }
        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.InvoiceAllocation.Url += "&invId=" + HttpUtility.UrlEncode(this.InvId);
            this.DataTable.Json = "{ uri: \"finance/PayAllocation\", invId: " + HttpUtility.JavaScriptStringEncode(this.InvId, true) + " }";
        }

        #endregion

    }
}