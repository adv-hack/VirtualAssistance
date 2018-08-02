using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.popups
{
    public partial class EventSearch : BasePopupSearchPage
    {
        #region properties

        /// <summary>
        ///     Gets the title of the popup page
        /// </summary>
        public override String DialogTitle
        {
            get { return "Event search"; }
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
            return Searches.Search.Create(SearchTypes.SearchEvent)
                .AddParameter("@PA_COURSE_NAME", this.EventName.FieldValue)
                .AddParameter("@PA_COURSE_REF", this.EventReference.FieldValue)
                .AddParameter("@PA_COURSE_ID", this.EventID.FieldValue)
                .AddParameter("@PA_COURSE_START_DATE_AFTER", this.StartingAfter.FieldValue)
                .AddParameter("@PA_COURSE_START_DATE_BEFORE", this.StartingBefore.FieldValue)
                .AddParameter("@PA_ADD_TOWN", this.VenueTown.FieldValue)
                .AddParameter("@PA_PROD_GROUP", this.Group.FieldValue)
                .AddParameter("@PA_COURSE_STATUS", this.EventStatus.FieldValue)
                .AddParameter("@PA_COURSE_TYPE", this.EventType.FieldValue)
                .AddParameter("@PA_PROD_CATEGORY", this.Category.FieldValue)
                .AddParameter("@PA_LOC_NAME", this.Location.FieldValue);
        }

        /// <summary>
        ///     Pre-populates the search fields.
        /// </summary>
        protected override void SetSearch(String value)
        {
            this.EventName.FieldValue = value;            
        }

        /// <summary>
        /// Pre-populates default value
        /// </summary>
        /// <param name="e"></param>
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);       
            this.StartingAfter.FieldValue = DateTime.Now.Date;
        }


        #endregion
    }
}