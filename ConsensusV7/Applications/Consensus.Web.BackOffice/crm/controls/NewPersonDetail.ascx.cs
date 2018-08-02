using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class NewPersonDetail : BaseControl<Role, String>
    {

        public override String DataTypeName
        {
            get { return "New Person"; }
        }

        public override Func<String, Role> DataLoader
        {
            get
            {
                return Role.FetchById;
            }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.DataProtection.DataSource = this.DataSource;
            this.PersonDetails.DataSource = this.DataSource;
        }


    }
}