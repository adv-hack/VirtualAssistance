using System;
using Consensus.Web.Controls;
using Consensus.Searches;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document.popups
{
    public partial class DocumentTemplateSearch : BasePopupSearchPage
    {
        /// <summary>
        ///     Gets the title of the popup page
        /// </summary>
        public override String DialogTitle
        {
            get { return "Document Template Search"; }
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
        protected override ISearchesRunnable GetSearch()
        {
            return Searches.Search.Create(SearchTypes.SearchDocumentTemplate)
                .AddParameter("@DOC_TMP_NAME", this.Name.FieldValue)
                .AddParameter("@PACK_TYPE_ID", Convert.ToInt32(Request.QueryString["packtype"]))
                .AddParameter("@DOC_TMP_TYPE", this.DocTemplateType.FieldValue)                
                .AddParameter("@SELCO_SP_ID", this.SellingCompany.FieldValue);
        }

        /// <summary>
        ///     Pre-populates the search fields.
        /// </summary>
        protected override void SetSearch(String value)
        {
            this.Name.FieldValue = value;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void OnInit(EventArgs eventArguments)
        {
            base.OnInit(eventArguments);
            this.SellingCompany.DataSource = Common.SellingCompany.FetchAll();
            this.SellingCompany.FieldValue = CurrentSession.User.SellingCompanyId;
        }
    }
}