using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class EventSessionNotesSection : BaseControl<Session, String>
    {

        public override String DataTypeName
        {
            get { return "Session"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();

        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
        }

    }
}