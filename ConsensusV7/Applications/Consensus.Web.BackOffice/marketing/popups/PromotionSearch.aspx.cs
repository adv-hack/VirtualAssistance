using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.marketing.popups
{
    public partial class PromotionSearch : BasePopupSearchPage
    {
        #region properties

        /// <summary>
        ///     Gets the title of the popup page
        /// </summary>
        public override String DialogTitle
        {
            get { return "Source Code Search"; }
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
            return Searches.Search.Create(SearchTypes.SearchPromotion)
                .AddParameter("@PA_CMP_NAME", this.Campaign.FieldValue)
                .AddParameter("@PA_PM_MST_NAME", this.PromotionMaster.FieldValue)
                .AddParameter("@PA_PM_NAME", this.SourceCode.FieldValue)
                .AddParameter("@PA_CMP_START_DATE", this.StartDate.FieldValue)
                .AddParameter("@PA_CMP_END_DATE", this.EndDate.FieldValue)
                .AddParameter("@PA_PM_CHANNEL", this.Channel.FieldValue)
                .AddParameter("@PA_PM_MEDIA_NAME", this.MediaName.FieldValue)
                .AddParameter("@PA_PM_TYPE", this.Type.FieldValue)
                .AddParameter("@PA_CMP_QCODE", this.QuickCode.FieldValue);
        }

        /// <summary>
        ///     Pre-populates the search fields.
        /// </summary>
        protected override void SetSearch(String value)
        {
            this.QuickCode.FieldValue = value;
        }

        #endregion
    }
}