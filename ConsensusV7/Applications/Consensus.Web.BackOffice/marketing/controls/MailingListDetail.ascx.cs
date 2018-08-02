using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Security;

namespace Consensus.Web.BackOffice.marketing.controls
{
    public partial class MailingListDetail : BaseControl<MailingList, long>
    {        
        public override string DataTypeName
        {
            get { return "Mailing List"; }
        }
    }
}