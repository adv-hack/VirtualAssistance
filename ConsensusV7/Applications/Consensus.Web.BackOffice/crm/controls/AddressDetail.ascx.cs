using Consensus.Contact;
using Consensus.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Web.Controls;
using Consensus.UserInterface;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class AddressDetail : BaseControl<Address, String>
    {
        #region properties

        public override String DataTypeName
        {
            get { return "Address"; }
        }

        public Boolean DisplayAltAddressButton
        {
            get { return this.AddressLine1.Addons[0].Visible; }
            set { this.AddressLine1.Addons[0].Visible = value; }
        }

        public String OrganisationId
        {
            get;
            set;
        }

        public String PersonId
        {
            get;
            set;
        }

        public Boolean HideAddressContactInfo
        {
            get;
            set;
        }

        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Countries.DataSource = Country.FetchAll();
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            
            // Lock the fields when displaying an organisational address for a person
            this.LockField(this.AddressLine1);
            this.LockField(this.AddressLine2);
            this.LockField(this.AddressLine3);
            this.LockField(this.Town);
            this.LockField(this.County);
            this.LockField(this.Postcode);
            this.LockField(this.Countries);
            this.LockField(this.Phone);
            this.LockField(this.Fax);
            this.LockField(this.Email);

            // Contact fields are only required for organisational addresses
            this.Phone.Visible = !String.IsNullOrEmpty(OrganisationId) && !this.HideAddressContactInfo;
            this.Fax.Visible = !String.IsNullOrEmpty(OrganisationId) && !this.HideAddressContactInfo;
            this.Email.Visible = !String.IsNullOrEmpty(OrganisationId) && !this.HideAddressContactInfo;
            

			// Register the javascript to initialise the client-instance of the control
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID + "Js", String.Format("var {0} = new consensus.web.addressField('{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');",
                this.ClientID,
                this.IdField.ClientID,
                this.AddressLine1.ClientID,
                this.AddressLine2.ClientID,
                this.AddressLine3.ClientID,
                this.Town.ClientID,
                this.County.ClientID,
                this.Postcode.ClientID,
                this.Countries.ClientID,
                this.OrganisationId), true);
        }

        #endregion

        #region methods

        private void LockField(BaseInputControl control)
        {
            if (!String.IsNullOrEmpty(this.PersonId) && !String.IsNullOrEmpty(this.OrganisationId))
                control.IsReadOnly = ConfigurableBoolean.TrueEnforced;

            //If called from Person screen checks if organisation is selected
            if (String.IsNullOrEmpty(this.Request.QueryString["id"]) && !String.IsNullOrEmpty(this.Request.QueryString["organisationId"]))
            {
                control.IsReadOnly = ConfigurableBoolean.TrueEnforced;               
            }
        }

        #endregion
    }
}