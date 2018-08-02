using Consensus.Common;
using Consensus.Document;
using Consensus.UserInterface;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document.controls
{
    public partial class ArticleDetail : BaseControl<Article, Int32>
    {
        public override string DataTypeName
        {
            get
            {
                return "Articles";
            }
        }
        public override Func<int, Article> DataLoader
        {
            get { return Article.FetchById; }
        }
        private void LockField(BaseInputControl control)
        {
            control.IsReadOnly = ConfigurableBoolean.TrueEnforced;
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();
        }
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            if (this.DataSource == null || this.DataSource.Id == 0)
            {
                this.Featured.FieldValue = false;
                this.createdDate.FieldValue = DateTime.Now.Date;
                this.viewCount.FieldValue = "0";
            }
            else
            {
                var portalViewed = Common.ViewLog.FetchAll().Where(x => x.RecId == Convert.ToString(this.DataSource.Id) && x.Source == Convert.ToByte("1") && x.Table == "ARTICLE").Count();
                this.viewCount.FieldValue = Convert.ToString(portalViewed);
               
                
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}