using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Searches;
using Consensus.Web.Controls;

namespace Consensus.Web.BackOffice.security.popups
{
    public partial class ReportSearch : BasePopupSearchPage
    {
        #region properties

        /// <summary>
        ///     Gets the title of the popup page
        /// </summary>
        public override String DialogTitle
        {
            get { return "Report Search"; }
        }

        /// <summary>
        ///     Gets the width of the popup page
        /// </summary>
        public override UInt32 DialogWidth
        {
            get { return 900; }
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
            return Searches.Search.Create(SearchTypes.SearchReport)
                .AddParameter("@PA_REP_ID", this.ReportId.FieldValue)
                .AddParameter("@PA_REP_NAME", this.ReportName.FieldValue)                
                .AddParameter("@PA_REP_CAT", this.Category.FieldValue)
                .AddParameter("@PA_REP_CURRENT", this.Status.FieldValue == string.Empty ? null: this.Status.FieldValue);
        }

        /// <summary>
        ///     Pre-populates the search fields.
        /// </summary>
        protected override void SetSearch(String value)
        {
            this.ReportName.FieldValue = value;
        }

        protected override void OnPreRender(EventArgs eventArguments)
        {
            base.OnPreRender(eventArguments);            
            this.Status.DataSource = this.PopulateStatusList();            
        }

        /// <summary>
        /// Populates Status List
        /// </summary>
        /// <returns></returns>
        private object PopulateStatusList()
        {
            List<KeyValuePair<Int16, String>> statusList = new List<KeyValuePair<Int16, String>>();
            statusList.Add(new KeyValuePair<Int16, string>(0, "Disabled"));
            statusList.Add(new KeyValuePair<Int16, string>(1, "Current"));
            return statusList;
        }
        #endregion
    }
}