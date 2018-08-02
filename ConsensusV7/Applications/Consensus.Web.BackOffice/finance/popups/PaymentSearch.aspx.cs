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
    public partial class PaymentSearch : BasePopupSearchPage
    {
        #region properties

        /// <summary>
        ///     Gets the title of the popup page
        /// </summary>
        public override String DialogTitle
        {
            get { return "Payment search"; }
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
            return Searches.Search.Create(SearchTypes.SearchPayment)
                .AddParameter("@PA_PAY_DATE", this.PaymentDate.FieldValue)
                .AddParameter("@PA_PAY_CUSTOMER_ACC", this.ARNumber.FieldValue)
                .AddParameter("@PA_PAY_REF", this.PaymentReference.FieldValue)
                .AddParameter("@PA_PAY_TYPE", this.PaymentType.FieldValue)
                .AddParameter("@PA_PN_SURNAME", this.Payer.FieldValue)
                .AddParameter("@PA_ORG_NAME", this.Organisation.FieldValue)
                .AddParameter("@PA_PAY_STATUS", this.Status.FieldValue)
                .AddParameter("@PA_PAY_CURR_TYPE", this.Currency.FieldValue)
                .AddParameter("@PA_PAY_UNUSED_VAL", this.UnusedValue.FieldValue);
        }

        /// <summary>
        ///     Pre-populates the search fields.
        /// </summary>
        protected override void SetSearch(String value)
        {
            this.PaymentId.FieldValue = value;
        }

        #endregion
    }
}