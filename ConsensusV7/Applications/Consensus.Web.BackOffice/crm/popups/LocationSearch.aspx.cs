using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Searches;

namespace Consensus.Web.BackOffice.crm.popups
{
    public partial class LocationSearch : BasePopupSearchPage
    {
        #region properties

        /// <summary>
        ///     Gets the title of the popup page
        /// </summary>
        public override String DialogTitle
        {
            get { return "Location Search"; }
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
        #region methods

        /// <summary>
        ///     Gets the parameterised search procedure.
        /// </summary>
        protected override ISearchesRunnable GetSearch()
        {
            return Searches.Search.Create(SearchTypes.SearchLocation)
                //.AddParameter("@PA_PN_ID", this.PersonID.FieldValue)
                .AddParameter("@PA_LOC_NAME", this.LocName.FieldValue)
                .AddParameter("@PA_LOC_REF", this.LocRef.FieldValue)
                .AddParameter("@PA_ORG_NAME", this.Organisation.FieldValue)
                .AddParameter("@PA_ADD_TOWN", this.Town.FieldValue)
                .AddParameter("@PA_LOC_ACTIVE", this.ActiveLocation.FieldValue == "0" ? "" : this.ActiveLocation.FieldValue)
                .AddParameter("@PA_LOC_VENUE_TYPE", this.LocType.FieldValue);
        }

        /// <summary>
        ///     Pre-populates the search fields.
        /// </summary>
        protected override void SetSearch(String value)
        {
            this.LocName.FieldValue = value;
        }

       
        #endregion
    }
}