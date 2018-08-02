using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.popups
{
    public partial class InvoiceSearch : BasePopupSearchPage
    {
        #region properties

        /// <summary>
        ///     Gets the title of the popup page
        /// </summary>
        public override String DialogTitle
        {
            get { return "Invoice search"; }
        }

        /// <summary>
        ///     Gets the width of the popup page
        /// </summary>
        public override UInt32 DialogWidth
        {
            get { return 1200; }
        }

        /// <summary>
        ///     Gets the table which displays the search result.
        /// </summary>
        protected override DataTable SearchResultTable
        {
            get { return this.SearchResult; }
        }

        #endregion

        #region page cycle

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
        }

        #endregion

        #region methods

        /// <summary>
        ///     Gets the parameterised search procedure.
        /// </summary>
        protected override ISearchesRunnable GetSearch()
        {
            return Searches.Search.Create(SearchTypes.SearchInvoice)
                .AddParameter("@PA_INV_REF", this.InvoiceNumber.FieldValue)
                .AddParameter("@PA_INV_BK_ORG_CUST_AC", this.ARNumber.FieldValue)
                .AddParameter("@PA_PN_SURNAME", this.Contact.FieldValue)
                .AddParameter("@PA_ORG_NAME", this.Organisation.FieldValue)
                .AddParameter("@PA_INV_DATE_AFTER", this.InvoiceDateAfter.FieldValue)
                .AddParameter("@PA_INV_DATE_BEFORE", this.InvoiceDateBefore.FieldValue)
                .AddParameter("@PA_INV_DUE_DATE_AFTER", this.InvoiceDueDateAfter.FieldValue)
                .AddParameter("@PA_INV_DUE_DATE_BEFORE", this.InvoiceDueDateBefore.FieldValue)
                .AddParameter("@PA_INV_CURRENCY_TYPE", this.Currency.FieldValue)
                .AddParameter("@PA_INV_UNPAID_VAL", this.UnpaidValue.FieldValue);

        }

        /// <summary>
        ///     Pre-populates the search fields.
        /// </summary>
        protected override void SetSearch(String value)
        {
            this.InvoiceNumber.FieldValue = value;
        }

        #endregion
    }
}