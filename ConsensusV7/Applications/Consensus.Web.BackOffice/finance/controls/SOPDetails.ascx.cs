using Consensus.Finance;
using Consensus.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class SOPDetails : BaseControl<Invoice, String>
    {
        public override string DataTypeName
        {
            get { return "Invoice"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.LoggedOnUser.FieldValue = Security.UserSession.FetchCurrent().User.Username;

        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            this.LoggedOnUser.FieldValue = Security.UserSession.FetchCurrent().User.Username;

        }
    }
}