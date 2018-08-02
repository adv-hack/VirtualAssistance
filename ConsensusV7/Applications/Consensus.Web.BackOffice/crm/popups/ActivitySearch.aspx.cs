using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Searches;
using Consensus.Web.Controls;

namespace Consensus.Web.BackOffice.learning.popups
{
    public partial class ActivitySearch : BasePopupSearchPage
    {
        /// <summary>
        ///     Gets the title of the popup page
        /// </summary>
        public override String DialogTitle
        {
            get { return "Activity Search"; }
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
            get
            {
                return this.SearchResult;
            }
        }

        protected override ISearchesRunnable GetSearch()
        {
            return Searches.Search.Create(SearchTypes.SearchActivity)
                .AddParameter("@PA_ACT_TYPE", this.ActivityType.FieldValue)
                .AddParameter("@PA_ACT_TITLE", this.SessionName.FieldValue)
                .AddParameter("@PA_ACT_START_DATE", this.StartDate.FieldValue)
                .AddParameter("@PA_ACT_END_DATE", this.EndDate.FieldValue)
                .AddParameter("@PA_PERSON_ID", this.Person.FieldValue)
                .AddParameter("@PA_SELLING_COMPANY_ID", this.SellingCompany.FieldValue);
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.SellingCompany.DataSource = Common.SellingCompany.FetchAll();
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void SetSearch(string value)
        {
            this.SessionName.FieldValue = value;
        }
    }
}