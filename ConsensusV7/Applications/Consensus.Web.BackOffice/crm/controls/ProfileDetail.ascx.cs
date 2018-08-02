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
    public partial class ProfileDetail : BaseControl<Profile, String>
    {

        public override String DataTypeName
        {
            get { return "Profile"; }
        }

        public override Func<string, Profile> DataLoader
        {
            get
            {
                return Profile.FetchById;
            }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
        }

        protected override void OnInit(EventArgs e)
        {
            switch (this.Request.QueryString["profileType"])
            {
                case "person":
                    this.Person.DataBoundValue = "personId";
                    this.Key.PopupUrl += "&profileType=PRCT";
                    break;
                case "organisation":
                    this.Organisation.DataBoundValue = "organisationId";
                    this.Key.PopupUrl += "&profileType=PROF";
                    break;
                case "course":
                    this.Course.DataBoundValue = "coursesId";
                    this.Key.PopupUrl += "&profileType=PRCOU";
                    break;
                case "product":
                    this.Course.DataBoundValue = "productId";
                    this.Key.PopupUrl += "&profileType=PRPRO";
                    break;
                case "trainer":
                    this.Trainer.DataBoundValue = "trainerId";
                    this.Key.PopupUrl += "&profileType=PRTRN";
                    break;
                case "volunteer":
                    this.Volunteer.DataBoundValue = "volunteerId";
                    this.Key.PopupUrl += "&profileType=PRVOL";
                    break;
            }
            base.OnInit(e);
        }

        protected override void RegisterJavascript()
        {
            this.Key.ClientOnChange = @"
                $('#" + this.Value.ClientID + "Field').val(this.getData().level1); $('#" + this.Value2.ClientID + @"Field').val(this.getData().level2);
            ";
        }
    }
}