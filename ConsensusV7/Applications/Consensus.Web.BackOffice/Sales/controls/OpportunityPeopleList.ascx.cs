using Consensus.Sales;
using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.Sales.controls
{
    public partial class OpportunityPeopleList : BaseListControl
    {
        #region fields

        /// <summary>
        ///     The oppxref type to screenObjectDisplay
        /// </summary>
        private String _OppXrefType;

        /// <summary>
        ///     The oppxref Salesman to screenObjectDisplay
        /// </summary>
        private String _OppXrefSalesman;

        private OpportunitySyType _oppSyType;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the oppxref type to screenObjectDisplay
        /// </summary>
        public String OppXrefType
        {
            get { return _OppXrefType; }
            set { _OppXrefType = value; }
        }

        public OpportunitySyType OppSyType
        {
            get { return _oppSyType; }
            set { _oppSyType = value; }
        }

        /// <summary>
        ///     Gets or sets the id of the opportunity whose people are listed.
        /// </summary>
        public String OpportunityId
        {
            get;
            set;
        }


        /// <summary>
        ///    Gets or sets the oppxref salesman to screenObjectDisplay
        /// </summary>
        public String OppXrefSalesman
        {
            get { return _OppXrefSalesman; }
            set { _OppXrefSalesman = value; }
        }

        public override String DataTypeName
        {
            get { return "Person"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.OppPeopleListResult; }
        }

        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            switch (this.OppXrefSalesman)
            {
                case "1":
                    switch (this.OppSyType)
                    {
                        case OpportunitySyType.Donors:
                            this.DataTable.Url += "&OpportunityPersonType=salesperson&OpportunitySyType=Donors";
                            break;
                        case OpportunitySyType.Pledges:
                            this.DataTable.Url += "&OpportunityPersonType=salesperson&OpportunitySyType=Pledges";
                            break;
                        case OpportunitySyType.Legacies:
                            this.DataTable.Url += "&OpportunityPersonType=salesperson&OpportunitySyType=Legacies";
                            break;
                        case OpportunitySyType.GrantApplication:
                            this.DataTable.Url += "&OpportunityPersonType=salesperson&OpportunitySyType=GrantApplication";
                            break;
                        case OpportunitySyType.Opportunity:
                            this.DataTable.Url += "&OpportunityPersonType=salesperson&OpportunitySyType=Opportunity";
                            break;
                    }
                    this.DataTable.Json = "{ uri: \"sales/opportunityxref\", opportunityId: " + HttpUtility.JavaScriptStringEncode(this.OpportunityId, true) + " }";
                    break;
                case "0":
                    switch (this.OppSyType)
                    {
                        case OpportunitySyType.Donors:
                            this.DataTable.Url += "&OpportunityPersonType=person&OpportunitySyType=Donors";
                            break;
                        case OpportunitySyType.Pledges:
                            this.DataTable.Url += "&OpportunityPersonType=person&OpportunitySyType=Pledges";
                            break;
                        case OpportunitySyType.Legacies:
                            this.DataTable.Url += "&OpportunityPersonType=person&OpportunitySyType=Legacies";
                            break;
                        case OpportunitySyType.GrantApplication:
                            this.DataTable.Url += "&OpportunityPersonType=person&OpportunitySyType=GrantApplication";
                            break;
                        case OpportunitySyType.Opportunity:
                            this.DataTable.Url += "&OpportunityPersonType=person&OpportunitySyType=Opportunity";
                           break;
                    }                    
                    this.DataTable.Json = "{ uri: \"sales/opportunityxref\", opportunityId: " + HttpUtility.JavaScriptStringEncode(this.OpportunityId, true) + " }";
                    break;
            }

            this.ValueColumn.Visible = String.Equals(this.OppXrefSalesman, "1");
            this.MainSalesPersonColumn.Visible = String.Equals(this.OppXrefSalesman, "1");
        }

        #endregion

        public override Object DataSource
        {
            get
            {
                String filterColumn = null;
                String filterValue = null;

                QuerySources querysource = QuerySources.OpportunityXref;
                QueryConditionTypes filterCondition = QueryConditionTypes.Equal;

                if (this.OppXrefType != "")
                {
                    filterColumn = "OPPXREF_TYPE";
                    filterValue = OppXrefType;
                }
                else
                {
                    if (this.OppXrefSalesman == "1")
                    {
                        filterColumn = "OPPXREF_SALESMAN";
                        filterValue = "0";
                        filterCondition = QueryConditionTypes.GreaterThan;
                    }
                    else if (this.OppXrefSalesman == "0")
                    {
                        filterColumn = "OPPXREF_SALESMAN";
                        filterValue = "0";
                        filterCondition = QueryConditionTypes.Equal;
                    }
                    else
                    {
                        filterColumn = "1";
                        filterValue = "1";
                    }
                }

                return Query.Create()
                    .Select("OPPXREF_ID")
                    .Select("OPPXREF_PROLE_ID")
                    .Select("OPPXREF_ORG_ID")
                    .Select("OPPXREF_PN_ID")
                    .Select("OPPXREF_PN_NAME", "Person")
                    .Select("OPPXREF_ORG_NAME", "Organisation")
                    .Select("OPPXREF_PN_PHONE", "Telephone")
                    .Select("OPPXREF_TYPE", "Type")
                    .Select("OPPXREF_VALUE", "Value")
                    .Select("OPPXREF_SHARE", "Share")
                    .Select("OPPXREF_MAIN_SALESMAN", "MainSalesPerson")
                    .Select("PROLE_MOBILE", "Mobile")
                    .Select("PROLE_EMAIL", "Email")
                    .Select("uri")
                    .From(querysource)
                    .Where("OPPXREF_OPP_ID", QueryConditionTypes.Equal, this.OpportunityId)
                    .And(filterColumn, filterCondition, filterValue)
                    .OrderBy("OPPXREF_ORG_NAME", true);
            }
        }
    }
}

