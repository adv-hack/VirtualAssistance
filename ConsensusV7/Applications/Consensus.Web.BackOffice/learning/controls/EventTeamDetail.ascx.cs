using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Activities;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class EventTeamDetail : BaseControl<ActivityXref, String>
    {
        public override string DataTypeName
        {
            get
            {
                return "Event Team Member";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}