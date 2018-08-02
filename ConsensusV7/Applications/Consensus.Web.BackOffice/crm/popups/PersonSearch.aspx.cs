using Consensus.Searches;
using Consensus;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm.popups
{
    public partial class PersonSearch : BasePopupSearchPage
    {
        #region fields

        /// <summary>
        ///     The value of organisation text value
        /// </summary>
        private String _organisationTextValue;

        /// <summary>
        /// The value of type of person whether Person,Associate or Volunteer
        /// </summary>
        private String _sy_person_type;

        /// <summary>
        ///     The value of organisation Id value
        /// </summary>
        private String _organisationIdValue;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the title of the popup page
        /// </summary>
        public override String DialogTitle
        {
            get { return "Person Search"; }
        }

        public string SY_Person_Type
        {
            get { return _sy_person_type; }
            set { _sy_person_type = value; }
        }

        /// <summary>
        ///     Gets the width of the popup page
        /// </summary>
        public override UInt32 DialogWidth
        {
            get { return 1200; }
        }

        /// <summary>
        ///     Gets the table which displays the search result.
        /// </summary>
        protected override DataTable SearchResultTable
        {
            get { return this.SearchResult; }
        }

        /// <summary>
        ///     Gets the organisation text value
        /// </summary>
        protected String OrganisationTextValue
        {
            get { return _organisationTextValue; }
            set { _organisationTextValue = value; }
        }

        /// <summary>
        ///     Gets the organisation Id value
        /// </summary>
        protected String OrganisationIdValue
        {
            get { return _organisationIdValue; }
            set { _organisationIdValue = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Gets the parameterised search procedure.
        /// </summary>
        protected override ISearchesRunnable GetSearch()
        {
            return Searches.Search.Create(SearchTypes.SearchPerson)
                .AddParameter("@PA_PN_ID", this.PersonID.FieldValue)
                .AddParameter("@PA_PN_FIRST_NAME", this.FirstName.FieldValue)
                .AddParameter("@PA_PN_SURNAME", this.Surname.FieldValue)
                .AddParameter("@PA_ORG_NAME", this.Organisation.FieldValue)
                .AddParameter("@PA_ADD_POSTCODE", this.Postcode.FieldValue)
                .AddParameter("@PA_PROLE_EMAIL", this.Email.FieldValue)
                .AddParameter("@PA_PROLE_TYPE", this.RoleType.FieldValue)
                .AddParameter("@PA_PROLE_POS_TYPE", this.JobType.FieldValue)
                .AddParameter("@PA_PN_PARTNER_SYS_REF", this.SysRef.FieldValue)
                .AddParameter("@PA_SY_Person_Type", this.SY_Person_Type)
                .AddParameter("@PA_Associate_Status", this.AssociateStatus.FieldValue)
                .AddParameter("@PA_Volunteer_Status", this.VolunteerStatus.FieldValue)
                .AddParameter("@PA_Associate_Type", this.AssociateType.FieldValue)
                .AddParameter("@PA_Volunteer_Type", this.VolunteerType.FieldValue);


        }

        /// <summary>
        ///     Pre-populates the search fields.
        /// </summary>
        protected override void SetSearch(String value)
        {
            String[] elements = value.Split('$');
            this.Surname.FieldValue = elements[0];
            this.FirstName.FieldValue = elements.Length > 1 ? elements[1] : null;
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
           

            this.SearchResult.Json = "{ uri: \"contact/role\", IsPrincipal:true }";

            this.PersonProfiles.DataSource = Common.ProfilePerson.FetchAll().Where(x => x.PersonId != null)
                .Select(x => new
                {
                    Key = x.Key,
                    Values = new
                    {
                        Value1 = x.Value,
                        Value2 = x.Value2
                    }

                });
            this.AssociateProfiles.DataSource = Common.ProfileTrainer.FetchAll().Where(x => x.TrainerId != null)
                .Select(x => new
                {
                    Key = x.Key,
                    Values = new
                    {
                        Value1 = x.Value,
                        Value2 = x.Value2
                    }

                });
            this.VolunteerProfiles.DataSource = Common.ProfileVolunteer.FetchAll().Where(x => x.VolunteerId != null)
                .Select(x => new
                {
                    Key = x.Key,
                    Values = new
                    {
                        Value1 = x.Value,
                        Value2 = x.Value2
                    }

                });

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.OrganisationTextValue = this.Request.QueryString["orgText"];
            if (!string.IsNullOrEmpty(this.personType.FieldValue))
            {
                this.SY_Person_Type = this.personType.FieldValue == "Associate" ? "0" : "1";
            }
            if (this.OrganisationTextValue == "null")
            {
                this.Organisation.FieldValue = String.Empty;
            }

            this.OrganisationIdValue = this.Request.QueryString["orgId"];

            if (this.OrganisationIdValue == "null")
            {
                this.Organisation.DataBoundValue = String.Empty;
            }
        }
        #endregion
    }
}