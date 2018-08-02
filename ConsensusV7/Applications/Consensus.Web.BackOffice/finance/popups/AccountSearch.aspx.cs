using Consensus.Contact;
using Consensus.Searches;
using Consensus.UserInterface;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.popups
{
    public partial class AccountSearch : BasePopupSearchPage
    {
        #region properties

        /// <summary>
        ///     Gets the title of the popup page
        /// </summary>
        public override String DialogTitle
        {
            get { return "Account Search"; }
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
            return Searches.Search.Create(SearchTypes.SearchAccount)
                .AddParameter("@PA_ACC_SYSTEM_REF", this.ARNumber.FieldValue)
                .AddParameter("@PA_ACC_TITLE", this.AccountTitle.FieldValue)
                .AddParameter("@PA_ORG_ID", this.OrganisationId.FieldValue)
                .AddParameter("@PA_PN_ID", this.PersonId.FieldValue);  
        }

        /// <summary>
        ///     Pre-populates the search fields.
        /// </summary>
        protected override void SetSearch(String value)
        {
            this.ARNumber.FieldValue = value;
        }

        #endregion
    }
}