using Consensus.Common;
using Consensus.Web.BackOffice.assets.templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.common.controls
{
    public partial class CodeDetail : BaseControl<Code> 
    {
        public override String DataTypeName
        {
            get { return "Code"; }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            this.SystemValue.FieldValue = "0";
            this.DeletedValue.FieldValue = "0";
            (this.Page.Master as Popup).CustomiseButton.Visible = false;
        }
    }
}