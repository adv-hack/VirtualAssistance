using Consensus.Web.Controls;
using System;
using Consensus.Searches;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document.popups
{
    public partial class RelatedArticlesSearch : BasePopupSearchPage
    {
        #region properties

        /// <summary>
        ///     Gets the title of the popup page
        /// </summary>
        public override String DialogTitle
        {
            get { return "Article Search"; }
        }

        /// <summary>
        ///     Gets the width of the popup page
        /// </summary>
        public override UInt32 DialogWidth
        {
            get { return 1000; }
        }

        /// <summary>
        ///     Gets the table which displays the search result.
        /// </summary>
        protected override DataTable SearchResultTable
        {
            get { return this.SearchResult; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Gets the parameterised search procedure.
        /// </summary>
        protected override ISearchesRunnable GetSearch()
        {
            return Searches.Search.Create(SearchTypes.SearchArticle)
                .AddParameter("@PA_ARTI_ID", Convert.ToInt32(Request.QueryString["articleid"]))
                .AddParameter("@PA_ARTI_NAME", this.ArticleName.FieldValue)
                .AddParameter("@PA_ARTI_STATE", this.Status.FieldValue);         
        }

        /// <summary>
        ///     Pre-populates the search fields.
        /// </summary>
        protected override void SetSearch(String value)
        {
            this.ArticleName.FieldValue = value;
        }

        #endregion
    }
}

    