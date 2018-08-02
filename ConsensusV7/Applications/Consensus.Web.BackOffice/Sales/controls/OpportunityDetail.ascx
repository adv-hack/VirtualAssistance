<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OpportunityDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.Sales.controls.OpportunityDetail" %>

<div class="row">
    <div class="col-md-6"> 
        <con:GroupBox runat="server" Title="Opportunity details">      
            <con:HiddenField runat="server" ID="OpportunityTypeId" DataBoundValue="SyType"/>     
          <div class="row">
              <div class="col-md-12"><con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced" /></div>
          </div>
          <div class="row">
             <div class="col-md-6"><con:CodeField runat="server" ID="Status" DataBoundValue="StatusCode" LabelText="Status" CodeType="STATU" Requirement="MandatoryEnforced" /></div>
             <div class="col-md-6"><con:CodeField runat="server" ID="Service" DataBoundValue="ServiceCode" LabelText="Opportunity type" CodeType="OPSVR"  /></div>               
          </div>
          <div class="row">
             <div class="col-md-6"><con:CodeField runat="server" ID="ProductInt" DataBoundValue="ProdInterestCode" LabelText="Group" CodeType="PRGRP"  /></div>
             <div class="col-md-6"><con:CodeField runat="server" ID="SalesType" DataBoundValue="SalesTypeCode" LabelText="Categorisation 1" CodeType="OPTYP"  /></div>               
          </div>          
           <div class="row">
             <div class="col-md-6"><con:CodeField runat="server" ID="Source" DataBoundValue="SourceCode" LabelText="Categorisation 2" CodeType="OPSOU"  /></div>
             <div class="col-md-6"><con:CodeField runat="server" ID="SearchGroup" DataBoundValue="SearchGroupCode" LabelText="Categorisation 3" CodeType="OSGRP"  /></div>               
          </div>         
           <div class="row">
             <div class="col-md-6"><con:CodeField runat="server" ID="Competition" DataBoundValue="CompetitorCode" LabelText="Competition" CodeType="COMPT"  /></div>
             <div class="col-md-6"><con:ListField runat="server" ID="SellCompName" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>
          </div> 
        </con:GroupBox>
        
        <con:GroupBox runat="server" Title="Links">
          <div class="row">
             <div class="col-md-6"><con:PopupField runat="server" ID="Course" DataBoundValue="ProductId" LabelText="Course" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=1" HyperlinkUrl="~/learning/coursepage.aspx?id={id}"/></div>
             <div class="col-md-6"><con:PopupField runat="server" ID="Event" DataBoundValue="CourseIdId" LabelText="Event" PopupUrl="~/learning/popups/eventsearch.aspx" HyperlinkUrl="~/learning/eventpage.aspx?id={id}"/></div>               
          </div>
          <div class="row">
             <div class="col-md-6"><con:PopupField runat="server" ID="Promotion" DataBoundValue="PromIdId" LabelText="Promotion" PopupUrl="~/marketing/popups/promotionsearch.aspx" HyperlinkUrl="~/marketing/sourcepage.aspx?id={id}"/></div>      
              <div class="col-md-6">
                <con:ListField runat="server" ID="CostCode" DataBoundValue="CostCode" LabelText="Cost code" ValueMember="Code" DisplayMember="Desc"/>     
          </div>
              </div>
        </con:GroupBox>
    </div>
    
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Contact information">
            
          <div class="row">
            <div class="col-md-6">
                <con:PopupField runat="server" ID="Client" DataBoundValue="ClientOppXref.RoleId" LabelText="Main contact" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" Requirement="MandatoryEnforced" >
                    <Filters>
                        <con:PopupFieldFilter ParameterName="org" Type="Control" Value="ClientOrg" />
                    </Filters>
                </con:PopupField>
            </div>
            <div class="col-md-6"><con:PopupField runat="server" ID="ClientOrg" DataBoundValue="ClientOppXref.OrganisationId" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" IsReadOnly="TrueEnforced" /></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="ClientPhone" DataBoundValue="ClientOppXref.PnPhone" LabelText="Phone" HyperlinkUrl="tel:{text}" TextMode="Phone" IsReadOnly="True"/></div>
            <div class="col-md-6"><con:PopupField runat="server" ID="SalesPerson" DataBoundValue="SalesOppXref.RoleId" LabelText="Opportunity owner" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" /></div>      
          </div>
              
          <con:HiddenField runat="server" ID="SalesPhone" DataBoundValue="SalesOppXref.PnPhone" />
          <con:PopupField runat="server" ID="SalesOrg" DataBoundValue="SalesOppXref.OrganisationId"  PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" IsHidden="TrueEnforced" />       
        </con:GroupBox>
        
        <con:GroupBox runat="server" Title="Forecast">
          <div class="row">
            <div class="col-md-6"><con:DateField runat="server" ID="DateOfEnquiry" DataBoundValue="DateEnq" LabelText="Enquiry date" /></div>
            <div class="col-md-6"><con:DateField runat="server" ID="DecisionDate" DataBoundValue="DateDec" LabelText="Decision date" /></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="ProbPurchase" DataBoundValue="ProbPurch" LabelText="Award probability %" TextMode="Number" /></div>
            <div class="col-md-6"><con:TextField runat="server" ID="ProbWinning" DataBoundValue="ProbWin" LabelText="Win probability %" TextMode="Number"/></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="Quantity" DataBoundValue="RollQty" LabelText="Quantity" TextMode="Number"/></div>
            <div class="col-md-6"><con:TextField runat="server" ID="ContractValue" DataBoundValue="ValPot" LabelText="Total value" TextMode="Number"/></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:CheckField runat="server" ID="CommittedToForecast" DataBoundValue="Commit"  LabelText="Forecast" /></div>
          </div>
          
        </con:GroupBox>
    </div>
</div>
<div class="row">
    <div class="col-md-12"><con:TextField runat="server" ID="Notes" DataBoundValue="Notes" LabelText="Notes" TextMode="MultiLine" /></div>
</div>

<script type="text/javascript">

    // When opportunity is saved, entry is created in Opportunity_Xref table
    function OnSave(state, result, callback) {
        result.ClientOppXref.OpportunityId = result.Id;

        //Checks whether Client Opportunity_Xref is already added
        var method = 'post';
        if (result.ClientOppXref.Id) {
            method = 'put';
        }

        consensus.network.send({
            method: method,
            url: result.ClientOppXref.uri,
            data: result.ClientOppXref,
            success: function (response) {

                var salesObject = consensus.data.getState().object;

                //Checks if Sales contact is selected
                if (result.SalesOppXref != null) {
                    result.SalesOppXref.OpportunityId = result.Id;
                    result.SalesOppXref.OrganisationId = result.SalesOppXref.OrganisationId;
                    if (result.SalesOppXref.Organisation != null) {
                        result.SalesOppXref.OrgName = result.SalesOppXref.Organisation.Name;
                    }
                    method = 'post';
                    if (result.SalesOppXref.Id) {
                        method = 'put';
                    }
                    createSalesOpportunityXref(result.SalesOppXref.uri, result.SalesOppXref, method, state, result, callback);
                }
                else {
                    if (salesObject.SalesOppXref != null) {
                        salesObject.SalesOppXref.uri = result.ClientOppXref.uri
                        salesObject.SalesOppXref.OpportunityId = result.Id;
                        salesObject.SalesOppXref.PersonType = "MainSalesPerson";
                        method = 'post';                        
                        createSalesOpportunityXref(salesObject.SalesOppXref.uri, salesObject.SalesOppXref, method, state, result, callback);
                    }
                    else {
                        redirect(state, result, callback);
                    }
                }
            }
        });        
    }

    function createSalesOpportunityXref(uri, data, method, state, result, callback) {
        consensus.network.send({
            method: method,
            url: uri,
            data: data,
            success: function (salesResponse) {
                redirect(state, result, callback);
            }
        });
    }

    function redirect(state, result, callback) {
        var hasId = typeof (state.source.Id) != 'undefined' && state.source.Id != null && state.source.Id.length != 0 && state.source.Id.toString() != '0';
        state.toggleSave(null);
        state.object = jQuery.extend(true, {}, result);
        state.updateScreen();
        state.toggleScreen(false);
        if (window.top.consensus == window.consensus && !hasId)
            window.location = window.location.toString() + (window.location.toString().indexOf('?') == -1 ? '?' : '&') + 'id=' + result.Id;
        else
            location.reload();
    }

    consensus.data.onsave = OnSave;

    function updateCostCode(sellingCompany, costCode) {
        var sellCompField = $('#' + sellingCompany + 'Field');
        var costCodeField = $('#' + costCode + 'Field');
        var costCodeValue = costCodeField.val();
        consensus.network.send({
            method: 'post',
            data: {
                selcoSpIdId: sellCompField.val(),
                serialization: {
                    Include: {
                        "Finance.CostCode": ["Code", "Desc"]
                    }
                }
            },
            url: 'finance/costcode/fetchAllBySelcoSpIdId',
            success: function (result) {

                // Remove the existing options
                costCodeField.find('option').remove();

                // Create the new options
                $('<option />').attr('value', '').text('').appendTo(costCodeField);
                for (var i = 0; i < result.length; i++)
                    $('<option />').attr('value', result[i].Code).text(result[i].Desc).appendTo(costCodeField);
            }
        });
    }

</script>
