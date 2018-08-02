using Consensus.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document
{
    public partial class ArticlePage : BaseStandardPage<Article, Int32>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Article - " + this.Data.Name; }
        }

        public override string DefaultIcon
        {
            get
            {
                return "news";
            }
        }
        public override Func<int, Article> DataLoader
        {
            get
            {
                return Article.FetchById;
            }
        }

        public override Func<Article> DataCreator
        {
            get { return Article.Create; }
        }

        #endregion
        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }
        protected override void PopulateControls()
        {
            this.RelatedArticlesList.ParentId = Convert.ToString(this.Data.Id);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}