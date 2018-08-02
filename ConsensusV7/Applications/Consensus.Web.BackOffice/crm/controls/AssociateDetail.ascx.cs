using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Contact;
using Consensus.Common;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class AssociateDetail : BaseControl<Associate, Int32>
    {
        public override String DataTypeName
        {
            get { return "Relationship"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<Int32, Associate> DataLoader
        {
            get { return Associate.FetchById; }
        }

        protected override void OnInit(EventArgs e)
        {
            switch (this.Request.QueryString["associateType"])
            {
                case "associate":
                    this.Person.DataBoundValue = "RoleId";
                    this.Person.DataBoundText = "Role.PersonName";
                    break;
                case "associatedwith":
                    this.Person.DataBoundValue = "AssociatedRoleId";
                    this.Person.DataBoundText = "AssociatedRole.PersonName";
                    break;
                case "organisation":
                    this.Person.DataBoundValue = "RoleId";
                    this.Person.DataBoundText = "Role.PersonName";
                    break;
            }

            base.OnInit(e);
            if (this.DataSource == null)
            {
              this.StartDate.FieldValue = DateTime.Now.Date;
            }
        }

        protected override void RegisterJavascript()
        {
            this.Person.ClientOnChange = @"
                if ((this.getData() && this.getData().organisation && this.getData().organisation.id && this.getData().organisation.id.length != 0) || this.getData().organisation.id == '') {
                    " + this.Organisation.ClientID + @".setValue(this.getData().organisation.id, this.getData().organisation.name);
                }";

            this.Organisation.ClientOnChange = @"
                if ((this.getValue() || '') != '' && " + this.Person.ClientID + ".getData() && " + this.Person.ClientID + ".getData().organisation && " + this.Person.ClientID + @".getData().organisation.id != this.getValue()) { 
                    " + this.Person.ClientID + @".setValue(null); 
            }";
        }

        protected bool AssociateType_OnLoadDataSource(Code code)
        {
            Int32 parsed;
            if (this.Request.QueryString["associateType"] == "organisation")
                return !Int32.TryParse(code.Value3, out parsed) || parsed.In(0, 1, 7, 8) || (parsed >= 200 && parsed <= 299);
            else
                return !Int32.TryParse(code.Value3, out parsed) || (parsed >= 2 && parsed <= 6) || (parsed >= 100 && parsed <= 199);
        }
    }
}