using Consensus.Contact;
using Consensus.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class PersonList : BaseControl<Organisation>
    {
        /// <summary>
        ///     The ID of the parent object that the associate records are linked to.
        /// </summary>
        private String _organisationId;

        public override String DataTypeName
        {
            get { return "Person List"; }
        }

        /// <summary>
        ///     Gets or sets the ID of the parent object that the Person records are linked to.
        /// </summary>
        public String OrganisationId
        {
            get { return _organisationId; }
            set { _organisationId = value; }
        }

        protected override void PopulateControl()
        {
            // Display person list
            this.PersonListResult.Data = Query.Create()
                .Select("PROLE_ID")
                .Select("PROLE_ORG_ID")
                .Select("PROLE_POS_TITLE", "JobTitle")
                .Select("PROLE_PN_NAME", "Name")
                .Select("PROLE_PERSON_ID")
                .Select("PROLE_PHONE", "Telephone")
                .Select("PROLE_EMAIL", "Email")
                .Select("PROLE_MOBILE", "Mobile")
                .Select("uri")
                .From(QuerySources.OrganisationPersonList)
                .Where("PROLE_ORG_ID", QueryConditionTypes.Equal, this.DataSource.Id)
                .OrderBy("PN_SURNAME", true);
            //need to add something to toggle key contact

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.PersonListResult.CreateUrl += "&organisationId=" + this.OrganisationId;
        }
    }
}