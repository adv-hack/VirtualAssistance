using System;
using Consensus.Searches;
using Consensus.Web.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document.controls
{
    public partial class RelatedArticlesList : BaseListControl
    {
        
        private String _parentid;
      
        
        /// <summary>
        ///     Gets or sets the Id of the parent object that the session records are linked to.
        /// </summary>
        public String ParentId
        {
            get { return _parentid; }
            set { _parentid = value; }
        }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Related Articles list"; }
        }

        public override DataTable DataTable
        {
            get
            {
                return this.RelatedArticlesListTable;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public override object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("ARTI_NAME")
                    .Select("ARTIXREF_ADD_DATE")
                    .Select("ARTI_SUMMARY")
                    .Select("ARTIXREF_ARTI_ID")
                    .Select("ARTIXREF_REL_ARTI_ID")
                    
                    .Select("uri")
                    .From(QuerySources.Articles)
                    .Where("ARTIXREF_ARTI_ID", QueryConditionTypes.Equal, this.ParentId);                    
            }

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.DataTable.Json = "{ uri: \"document/articlexref\", artiId: " + HttpUtility.JavaScriptStringEncode(this.ParentId, true) + " }";
            this.RelatedArticlesListTable.Url += "&mainArticleId=" + HttpUtility.UrlEncode(this.ParentId);
           
        }
    }
}