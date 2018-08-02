using Consensus.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.sales.controls
{
    public partial class OpportunityGrantApplicationDetail : BaseControl<Opportunity, String>
    {
        public override string DataTypeName
        {
            get
            {
                return "Grant Application";
            }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.OpportunityTypeId.FieldValue = Convert.ToInt32(OpportunitySyType.GrantApplication).ToString();
            this.Name.FieldValue = this.DataSource.Name;
            this.Status.FieldValue = this.DataSource.StatusCode;
            this.Service.FieldValue = this.DataSource.ServiceCode;
            this.ProductInt.FieldValue = this.DataSource.ProdInterestCode;
            //this.SalesType.FieldValue = this.DataSource.SalesTypeCode;
            //this.Source.FieldValue = this.DataSource.SourceCode;
            //this.SearchGroup.FieldValue = this.DataSource.SearchGroupCode;
            this.DateOfEnquiry.FieldValue = this.DataSource.DateEnq;
            this.DecisionDate.FieldValue = this.DataSource.DateDec;
            this.CommittedToForecast.FieldValue = Convert.ToBoolean(this.DataSource.Commit);
            this.ProbPurchase.FieldValue = Convert.ToString(this.DataSource.ProbPurch);
            //this.ProbWinning.FieldValue = Convert.ToString(this.DataSource.ProbWin);
            this.ContractValue.FieldValue = Convert.ToString(this.DataSource.ValPot);
            this.Quantity.FieldValue = Convert.ToString(this.DataSource.RollQty);

            this.SalesPerson.FieldValue = this.DataSource.SalesOppXref.RoleId;
            this.SalesPerson.FieldText = this.DataSource.SalesOppXref.SalesPerson;
            this.SalesOrg.FieldValue = this.DataSource.SalesOppXref.OrganisationId;
            this.SalesPhone.FieldValue = this.DataSource.SalesOppXref.PnPhone;
            this.ClientOrg.FieldValue = this.DataSource.ClientOppXref.OrganisationId;
            this.ClientOrg.FieldText = this.DataSource.ClientOppXref.OrgName;
            this.Client.FieldValue = this.DataSource.ClientOppXref.RoleId;
            this.Client.FieldText = this.DataSource.ClientOppXref.SalesPerson;
            this.ClientPhone.FieldValue = this.DataSource.ClientOppXref.PnPhone;
            this.Notes.FieldValue = this.DataSource.Notes;
            //this.Competition.FieldValue = this.DataSource.CompetitorCode;
            //this.CostCode.FieldText = this.DataSource.CostCode;
            //this.CostCode.FieldValue = this.DataSource.CostCode;
            this.SellCompName.DataSource = Common.SellingCompany.FetchAll();
            this.SellCompName.FieldValue = this.DataSource.SellingCompany.Id;

            //this.Course.FieldText = this.DataSource.Product.Name;
            //this.Course.FieldValue = this.DataSource.Product.Id;

            //this.Event.FieldText = this.DataSource.CourseId.Name;
            //this.Event.FieldValue = this.DataSource.CourseId.Id;

            this.Promotion.FieldText = this.DataSource.PromId.Name;
            this.Promotion.FieldValue = this.DataSource.PromId.Id;

        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            if (this.DataSource.Id == null)
            {
                this.SalesPerson.FieldValue = this.CurrentSession.User.Person.PrincipalRole.Id;
                this.SalesPerson.FieldText = this.CurrentSession.User.Person.FullName;
                this.SalesOrg.FieldValue = this.CurrentSession.User.Person.PrincipalRole.OrganisationId;
                this.SalesOrg.FieldText = this.CurrentSession.User.Person.PrincipalRole.Organisation.Name;
                this.OpportunityTypeId.FieldValue = Convert.ToInt32(OpportunitySyType.GrantApplication).ToString();
            }
            //Pre-populate details from person screen
            if (String.IsNullOrEmpty(this.Request.QueryString["id"]) && !String.IsNullOrEmpty(this.Request.QueryString["personId"]))
            {
                var person = Contact.Person.FetchById(this.Request.QueryString["personId"]);
                this.Client.FieldValue = person.PrincipalRole.Id;
                this.Client.FieldText = person.FullName;
                this.ClientOrg.FieldValue = person.PrincipalRole.Organisation.Id;
                this.ClientOrg.FieldText = person.PrincipalRole.Organisation.Name;
            }

            if (String.IsNullOrEmpty(this.Request.QueryString["id"]) && !String.IsNullOrEmpty(this.Request.QueryString["proleId"]))
            {
                var role = Contact.Role.FetchById(this.Request.QueryString["proleId"]);
                this.Client.FieldValue = role.Id;
                this.Client.FieldText = role.Person.FullName;
                this.ClientOrg.FieldValue = role.OrganisationId;
                this.ClientOrg.FieldText = role.Organisation.Name;
            }

            //Pre-populate details from Organisation screen
            if (String.IsNullOrEmpty(this.Request.QueryString["id"]) && !String.IsNullOrEmpty(this.Request.QueryString["orgId"]))
            {
                var organisation = Contact.Organisation.FetchById(this.Request.QueryString["orgId"]);
                this.ClientOrg.FieldValue = organisation.Id;
                this.ClientOrg.FieldText = organisation.Name;
            }
            this.CostCode.DataSource = Finance.CostCode.FetchAll().Where(costCode => String.IsNullOrEmpty(this.DataSource.SellingCompanyId) || String.Equals(costCode.SelcoSpIdId, this.DataSource.SellingCompanyId, StringComparison.OrdinalIgnoreCase));

            if (string.IsNullOrEmpty(this.DataSource.CostCode))
                this.CostCode.FieldValue = "";


            // Selecting a person should pre-populate the organisation and the payee person
            this.Client.ClientOnChange += "if (" + this.Client.ClientID + @".getData()) {
                " + this.ClientOrg.ClientID + @".setValue(this.getData().organisation.id, this.getData().organisation.name);
                $('#" + this.ClientPhone.ClientID + @"Field').val(this.getData().telephone);
            }; ";

            // Selecting a Sales person should pre-populate the organisation and the payee person
            this.SalesPerson.ClientOnChange += "if (" + this.SalesPerson.ClientID + @".getData()) {
                " + this.SalesOrg.ClientID + @".setValue(this.getData().organisation.id, this.getData().organisation.name);               
                $('#" + this.SalesPhone.ClientID + @"Field').val(this.getData().telephone);
            }; ";

        }

        protected override void RegisterJavascript()
        {
            this.SellCompName.ClientOnChange = "updateCostCode('" + this.SellCompName.ClientID + "', '" + this.CostCode.ClientID + "');";
        }
    }
}
