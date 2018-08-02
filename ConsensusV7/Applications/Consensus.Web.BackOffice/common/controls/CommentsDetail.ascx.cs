using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Activities;

namespace Consensus.Web.BackOffice.common.controls
{
    public partial class CommentsDetail : BaseControl<C4text, string>
    {
        //public string CommentOwnerURL
        //{
        //    get
        //    {
        //        return Page.Request.QueryString["ownerurl"];
        //    }
        //}

        //public string CommentOwnerId
        //{
        //    get
        //    {
        //        return Page.Request.QueryString["ownerid"];
        //    }
        //}

        public override string DataTypeName { get { return "C4text"; } }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<string, C4text> DataLoader
        {
            get { return C4text.FetchById; }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
        }
    }
}