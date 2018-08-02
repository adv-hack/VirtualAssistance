using Consensus.Web.BackOffice.assets.templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.security.controls
{
    public partial class UserPermissionDetail : BaseControl
    {
        public override String DataTypeName
        {
            get { return "Permission"; }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            (this.Page.Master as Popup).CustomiseButton.Visible = false;
        }
    }
}