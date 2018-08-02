using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class DataProtection : BaseControl<Role, String>
    {
        public override String DataTypeName
        {
            get { return "Data Protection"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            if (this.DataSource == null || this.DataSource.Id == null)
            {
                this.DoNotMail.FieldValue = true;
                this.DoNotEmail.FieldValue = true;
                this.DoNotFax.FieldValue = true;
                this.DoNotSwap.FieldValue = true;
                this.DoNotSpare1.FieldValue = true;
                this.DoNotSpare2.FieldValue = true;
                this.DoNotSpare3.FieldValue = true;
                this.DoNotSpare4.FieldValue = true;

                this.RoleDoNotEmail.FieldValue = true;
                this.RoleDoNotFax.FieldValue = true;
                this.RoleDoNotMail.FieldValue = true;
                this.RoleDoNotSwap.FieldValue = true;
                this.RoleDoNotTelesale.FieldValue = true;
            }
        }
    }
}