using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Sales;
using Consensus.UserInterface;

namespace Consensus.Web.BackOffice.sales.controls
{

    public partial class OpportunityPersonDetail : BaseControl<OpportunityXref, String>
    {
        private Boolean _allowDelete = true;
        
        public override bool AllowDelete
        {
            get { return _allowDelete; }
            set { _allowDelete = value; }
        }

        public override String DataTypeName
        {
            get { return "Person"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, OpportunityXref> DataLoader
        {
            get { return OpportunityXref.FetchById; }
        }


        protected override void OnInit(EventArgs e)
        {
            switch (this.Request.QueryString["OpportunityPersonType"])
            {
                case "salesperson":
                    this.PersonTypeList.Items.Add(new ListItem("", ""));
                    switch (this.Request.QueryString["OpportunitySyType"])
                    {

                        case "Donors":                            
                            this.PersonTypeList.Items.Add(new ListItem("Relationship owner", "MainSalesPerson"));
                            this.PersonTypeList.Items.Add(new ListItem("Team member", "SalesPerson"));                                                       
                            break;
                        case "Pledges":                            
                            this.PersonTypeList.Items.Add(new ListItem("Relationship owner", "MainSalesPerson"));
                            this.PersonTypeList.Items.Add(new ListItem("Team member", "SalesPerson"));                                                      
                            break;
                        case "Legacies":                            
                            this.PersonTypeList.Items.Add(new ListItem("Legacy Manager", "MainSalesPerson"));
                            this.PersonTypeList.Items.Add(new ListItem("Team member", "SalesPerson"));                                                        
                            break;
                        case "GrantApplication":                            
                            this.PersonTypeList.Items.Add(new ListItem("Application owner", "MainSalesPerson"));
                            this.PersonTypeList.Items.Add(new ListItem("Team member", "SalesPerson"));                                                       
                            break;
                        case "Opportunity":                            
                            this.PersonTypeList.Items.Add(new ListItem("Main Sales Person", "MainSalesPerson"));
                            this.PersonTypeList.Items.Add(new ListItem("Sales Person", "SalesPerson"));                            
                            break;

                    }
                    this.PersonTypeList.Requirement = ScreenObjectRequirement.Mandatory;
                    break;
                case "person":
                    this.PersonTypeList.Items.Add(new ListItem("", "Unknown"));
                    switch (this.Request.QueryString["OpportunitySyType"])
                    {
                        case "Donors":                                                       
                            this.PersonTypeList.Items.Add(new ListItem("Main Contact", "EndUser"));
                            break;
                        case "Pledges":                                                       
                            this.PersonTypeList.Items.Add(new ListItem("Pledger", "EndUser"));
                            break;
                        case "Legacies":                                                        
                            this.PersonTypeList.Items.Add(new ListItem("Lead solicitor", "EndUser"));
                            this.PersonTypeList.Items.Add(new ListItem("Legator", "Distributor"));
                            break;
                        case "GrantApplication":                                                        
                            this.PersonTypeList.Items.Add(new ListItem("Main Contact", "EndUser"));
                            break;
                        case "Opportunity":                                                        
                            this.PersonTypeList.Items.Add(new ListItem("Distributor", "Distributor"));
                            this.PersonTypeList.Items.Add(new ListItem("End User", "EndUser"));
                            break;
                    }            
                    this.Value.Visible = false;
                    break;
            }

           

            this.Person.DataBoundValue = "RoleId";
            this.Person.DataBoundText = "Role.PersonName";

            base.OnInit(e);
        }
        protected override void PopulateControl()
        {

            base.PopulateControl();
            if (this.DataSource != null)
            {
                switch (this.Request.QueryString["OpportunityPersonType"])
                {
                    case "salesperson":
                        if (this.DataSource.PersonType.ToString() == "MainSalesPerson")
                            this.PersonTypeList.Enabled = false;
                        this.AllowDelete = this.DataSource.PersonType.ToString() != "MainSalesPerson";
                        break;
                    case "person":
                        if (this.DataSource.PersonType.ToString() == "EndUser")
                            this.PersonTypeList.Enabled = false;
                        this.AllowDelete = this.DataSource.PersonType.ToString() != "EndUser";
                        break;
                }
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

    }
}