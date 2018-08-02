using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.assets.templates
{
    public partial class Popup : System.Web.UI.MasterPage
    {
        #region properties

        /// <summary>
        ///     CustomiseButton control.
        /// </summary>
        public LinkButton CustomiseButton;

        #endregion

        #region page cycle

        protected void Page_Load(object sender, EventArgs e)
        {
            BasePopupPage page = this.Page as BasePopupPage;
            this.TitleMetaTag.Attributes["content"] = page == null ? "" : page.DialogTitle;
            this.WidthMetaTag.Attributes["content"] = page == null ? "750px" : page.DialogWidth.ToString();
        }

        #endregion
    }
}