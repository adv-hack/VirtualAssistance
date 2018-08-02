using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.popups
{
    public partial class DistrictSearch : BasePopupSearchPage
    {
        #region properties

        /// <summary>
        ///     Gets the title of the popup page
        /// </summary>
        public override String DialogTitle
        {
            get { return "District  Search"; }
        }

        /// <summary>
        ///     Gets the width of the popup page
        /// </summary>
        public override UInt32 DialogWidth
        {
            get { return 800; }
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
            return Searches.Search.Create(SearchTypes.SearchDistrict)
                .AddParameter("@PA_DIS_ID", this.DistrictId.FieldValue)
                .AddParameter("@PA_DIS_NAME", this.Name.FieldValue)
                .AddParameter("@PA_DIS_REGION", this.Region.FieldValue)
                .AddParameter("@PA_DIS_STATUS", this.Status.FieldValue)
                .AddParameter("@PA_DIS_TYPE", this.Type.FieldValue)
                .AddParameter("@PA_DIS_CATEGORY", this.Category.FieldValue)
                .AddParameter("@PA_DIS_GROUP", this.Group.FieldValue);
        }

        /// <summary>
        ///     Pre-populates the search fields.
        /// </summary>
        protected override void SetSearch(String value)
        {
            this.Name.FieldValue = value;
        }

        #endregion
    }
}