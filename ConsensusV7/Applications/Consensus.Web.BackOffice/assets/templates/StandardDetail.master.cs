using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.assets.templates
{
    public partial class StandardDetail : MasterPage
    {
        /// <summary>
        ///     EditButton control.
        /// </summary>
        public global::System.Web.UI.WebControls.LinkButton EditButton;

        /// <summary>
        ///     SaveButton control.
        /// </summary>
        public global::System.Web.UI.HtmlControls.HtmlButton SaveButton;
        
        ///     CustomiseButton control.
        /// </summary>
        public LinkButton CustomiseButton;
        protected void Page_PreRender(object sender, EventArgs e)
        {
            
        }
        
        /// <summary>
        ///     Occurs when the page navigation is bound to a data source.
        /// </summary>
        protected void HeaderNavigation_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            
        }
    }
}