using Consensus.Contact;
using Consensus.Sales;
using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm
{
    public partial class OpportunityList : BaseListControl
    {
        #region enums

        /// <summary>
        ///     Enumerates the different modes that the associate list can be used for.
        /// </summary>
        public enum OpportunityListMode
        {
            SalesPerson,
            SalesRole,
            SalesOrganisation,
            EndUserPerson,
            EndUserRole,
            EndUserOrganisation
        }

        #endregion

        #region fields

        /// <summary>
        ///     The mode that the opportunity list is be used for.
        /// </summary>
        private OpportunityListMode _opportunityMode;

        /// <summary>
        ///     The ID of the parent object that the associate records are linked to.
        /// </summary>
        private String _opportunityParentId;

        private OpportunitySyType _opportunitySyType;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the mode that the opportunity list is be used for.
        /// </summary>
        public OpportunityListMode OpportunityMode
        {
            get { return _opportunityMode; }
            set { _opportunityMode = value; }
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
        /// Sets opportunity Sytype for determining different opportunities
        /// </summary>
        public OpportunitySyType OpportunitySyType
        {
            get { return _opportunitySyType; }
            set { _opportunitySyType = value; }
        }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
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
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                IQueryConditionable query = null;
                switch (this.OpportunityMode)
                {
                    case OpportunityListMode.SalesPerson:
                    case OpportunityListMode.SalesRole:
                    case OpportunityListMode.SalesOrganisation:
                        query = Query.Create()
                            .Select("OPP_ID")
                            .Select("OPPXREF_PROLE_ID", "PROLE_ID")
                            .Select("OPPXREF_ORG_ID", "ORG_ID")
                            .Select("PROLE_PERSON_ID", "PN_ID")
                            .Select("OPP_NAME", "Name")
                            .Select("OPPXREF_PN_NAME", "Person")
                            .Select("OPPXREF_ORG_NAME", "Organisation")
                            .Select("OPP_STATUS", "Status")
                            .Select("OPP_DATE_ENQ", "EnqDate")
                            .Select("OPP_PROD_INTEREST", "ProdInterest")
                            .Select("OPP_VAL_POT", "PotValue")
                            .Select("OPP_DATE_DEC")
                            .Select("OPP_SALES_TYPE")
                            .Select("uri")
                            .From(QuerySources.Opportunities);
                        break;
                    case OpportunityListMode.EndUserPerson:
                    case OpportunityListMode.EndUserRole:
                    case OpportunityListMode.EndUserOrganisation:
                        query = Query.Create()
                            .Select("OPP_ID")
                            .Select("OPPXREF_PROLE_ID", "PROLE_ID")
                            .Select("OPPXREF_ORG_ID", "ORG_ID")
                            .Select("PROLE_PERSON_ID", "PN_ID")
                            .Select("OPP_NAME", "Name")
                            .Select("OPPXREF_PN_NAME", "Person")
                            .Select("OPPXREF_ORG_NAME", "Organisation")
                            .Select("OPP_STATUS", "Status")
                            .Select("OPP_DATE_ENQ", "EnqDate")
                            .Select("OPP_PROD_INTEREST", "ProdInterest")
                            .Select("OPP_VAL_POT", "PotValue")
                            .Select("OPP_DATE_DEC")
                            .Select("OPP_SALES_TYPE")
                            .Select("uri")
                            .From(QuerySources.Opportunities);
                        break;
                }

                IQueryOrderable result = null;
                switch (this.OpportunityMode)
                {
                    case OpportunityListMode.SalesPerson: result = query.Where("PROLE_PERSON_ID", QueryConditionTypes.Equal, this.OpportunityParentId).And("OPP_SY_TYPE", QueryConditionTypes.Equal, this.OpportunitySyType); break;
                    case OpportunityListMode.EndUserPerson: result = query.Where("PROLE_PERSON_ID", QueryConditionTypes.Equal, this.OpportunityParentId).And("OPP_SY_TYPE", QueryConditionTypes.Equal, this.OpportunitySyType); break;
                    case OpportunityListMode.SalesRole: result = query.Where("OPPXREF_PROLE_ID", QueryConditionTypes.Equal, this.OpportunityParentId).And("OPP_SY_TYPE", QueryConditionTypes.Equal, this.OpportunitySyType); break;
                    case OpportunityListMode.EndUserRole: result = query.Where("OPPXREF_PROLE_ID", QueryConditionTypes.Equal, this.OpportunityParentId).And("OPP_SY_TYPE", QueryConditionTypes.Equal, this.OpportunitySyType); break;
                    case OpportunityListMode.SalesOrganisation: result = query.Where("OPPXREF_ORG_ID", QueryConditionTypes.Equal, this.OpportunityParentId).And("OPP_SY_TYPE", QueryConditionTypes.Equal, this.OpportunitySyType); break;
                    case OpportunityListMode.EndUserOrganisation: result = query.Where("OPPXREF_ORG_ID", QueryConditionTypes.Equal, this.OpportunityParentId).And("OPP_SY_TYPE", QueryConditionTypes.Equal, this.OpportunitySyType); break;
                }
                                                
                return result.OrderBy("OPP_NAME", true);
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

            //Appended personId or proleId from Person screen.
            if (this.OpportunityMode == OpportunityListMode.EndUserPerson)
            {
                this.OppListResult.CreateUrl += "&personId=" + this.OpportunityParentId;
            }

            if (this.OpportunityMode == OpportunityListMode.EndUserRole)
            {
                this.OppListResult.CreateUrl += "&proleId=" + this.OpportunityParentId;
            }            

        }

        #endregion
    }
}