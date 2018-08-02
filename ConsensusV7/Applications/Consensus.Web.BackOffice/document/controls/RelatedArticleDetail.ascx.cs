using Consensus.Document;
using Consensus.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document.controls
{
    public partial class RelatedArticleDetail : BaseControl<Articlexref, Int32>
    {
        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override string DataTypeName
        {
            get { return "Related Article"; }
        }
        protected override void RegisterJavascript()
        {
            this.ArticleName.ClientOnChange += @"
               if (this.getData() && (this.getValue() || '') != '')
                    {
                            var data=this.getData();                                                                           
                            $('#" + this.ArticleSummary.ClientID + @"Field').val(data.summary);      
                            $('#" + this.RelatedArticleId.ClientID + @"Field').val(data.articleId);                            
                    }
                else
                    {                               
                           $('#" + this.ArticleSummary.ClientID + @"Field').val(''); 
                           $('#" + this.RelatedArticleId.ClientID + @"Field').val('');
                    }
                     ";

        }
        public override Func<Int32, Articlexref> DataLoader
        {
            get { return Articlexref.FetchById; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.ArticleName.PopupUrl += "articleid=" + this.Request.QueryString["mainArticleId"];
        }
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            this.ArtiId.FieldValue = this.Request.QueryString["mainArticleId"];            
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.AllowDelete = true;
        }       
    }
}