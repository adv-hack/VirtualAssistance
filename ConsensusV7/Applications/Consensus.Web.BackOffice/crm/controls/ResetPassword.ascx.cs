using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Portal;
using Consensus.Contact;


namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class ResetPassword : BaseControl<PortalUser, Int32>
    {
        public override String DataTypeName
        {
            get { return "Reset Password"; }
        }

        public override Func<Int32, PortalUser> DataLoader
        {
            get { return PortalUser.FetchById; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            string randomPW = System.Web.Security.Membership.GeneratePassword(8, 0);

            this.NewPassword.FieldValue = randomPW;
            this.ConfirmPassword.FieldValue = randomPW;
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            
        }

        protected override void RegisterJavascript()
        {
            this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "ResetPasswordJs", @"
                function validatePasswordMatch(source, arguments) {
                    var newPassword = $('#" + this.NewPassword.ClientID + @"Field').val();
                    var confirmPassword = $('#" + this.ConfirmPassword.ClientID + @"Field').val();
                    arguments.IsValid = (newPassword.length == 0 || (newPassword == confirmPassword));
                }
            ", true);


        }
    }
}