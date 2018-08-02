using Consensus.Contact;
using Consensus.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class ProfileTree : BaseControl<Profile, String>
    {

        public override String DataTypeName
        {
            get { return "Profile Tree"; }
        }

    }
}


