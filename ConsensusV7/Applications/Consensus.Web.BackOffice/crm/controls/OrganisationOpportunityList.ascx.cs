using Consensus.Sales;
using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class OrganisationOpportunityList : BaseListControl
    {

        #region Private members

        /// <summary>
        /// Determines OpportunitySyType
        /// </summary>
        private OpportunitySyType _opportunitySyType;

        /// <summary>
        /// Gets or sets the ID of the parent object that the opportunity records are linked to.
        /// </summary>
        private String _opportunityParentId;

        #endregion

        #region Properties

        public override String DataTypeName
        {
            get { return "Opportunity"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.OppListResult; }
        }

        /// <summary>
        /// Sets opportunity Sytype for determining different opportunities
        /// </summary>
        public OpportunitySyType OpportunitySyType
        {
            get { return _opportunitySyType; }
            set { _opportunitySyType = value; }
        }

        /// <summary>
        ///     Gets or sets the ID of the parent object that the opportunity records are linked to.
        /// </summary>
        public String OpportunityParentId
        {
            get { return _opportunityParentId; }
            set { _opportunityParentId = value; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                       .Select("OPP_ID")
                       .Select("OPPXREF_ORG_ID", "ORG_ID")
                       .Select("OPP_NAME", "Name")                       
                       .Select("OPPXREF_ORG_NAME", "Organisation")
                       .Select("OPP_STATUS", "Status")
                       .Select("OPP_DATE_ENQ", "EnqDate")
                       .Select("OPP_PROD_INTEREST", "ProdInterest")
                       .Select("OPP_VAL_POT", "PotValue")
                       .Select("OPP_DATE_DEC")
                       .Select("OPP_SALES_TYPE")
                       .Select("uri")
                       .From(QuerySources.OrganisationOpportunities)
                       .Where("OPPXREF_ORG_ID", QueryConditionTypes.Equal, this.OpportunityParentId)
                       .And("OPP_SY_TYPE", QueryConditionTypes.Equal, this.OpportunitySyType)
                       .OrderBy("OPP_NAME", true);
            }
        }

        #endregion

        #region Page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            switch (this.OpportunitySyType)
            {
                case OpportunitySyType.Opportunity:
                    this.OppListResult.Url = "~/sales/opportunity?id={{Id}}";
                    this.OppListResult.CreateUrl = "~/sales/opportunity?";
                    break;

                case OpportunitySyType.GrantApplication:
                    this.OppListResult.Url = "~/sales/GrantApplication?id={{Id}}";
                    this.OppListResult.CreateUrl = "~/sales/GrantApplication?";
                    break;

                case OpportunitySyType.Legacies:
                    this.OppListResult.Url = "~/sales/Legacy?id={{Id}}";
                    this.OppListResult.CreateUrl = "~/sales/Legacy?";
                    break;

                case OpportunitySyType.Donors:
                    this.OppListResult.Url = "~/sales/Donor?id={{Id}}";
                    this.OppListResult.CreateUrl = "~/sales/Donor?";
                    break;

                case OpportunitySyType.Pledges:
                    this.OppListResult.Url = "~/sales/Pledge?id={{Id}}";
                    this.OppListResult.CreateUrl = "~/sales/Pledge?";
                    break;
            }

            //Appended organisation id from organisation screen
            this.OppListResult.CreateUrl += "&orgId=" + this.OpportunityParentId;

        }

        #endregion
    }
}