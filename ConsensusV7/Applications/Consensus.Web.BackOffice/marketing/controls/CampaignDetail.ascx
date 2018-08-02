<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CampaignDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.controls.CampaignDetail" %>

<div class="row">
    <div class="col-lg-6 consensus-column"> 
        <con:GroupBox runat="server" Title="Campaign details">
            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced" /></div>
            
            </div>

            <div class="row">
                <div class="col-md-6"><con:PopupField runat="server" ID="ManagerField" DataBoundValue="ManagerId" DataBoundText="Manager.PersonName" LabelText="Manager" PopupUrl="~/crm/popups/PersonSearch.aspx" HyperlinkUrl="~/crm/PersonPage.aspx?role={id}" /></div>
                <div class="col-md-6"><con:CheckField runat="server" ID="Current" DataBoundValue="Current" LabelText="Current" /></div>      
            </div>
            <div class="row">
                <div class="col-md-6"><con:ListField runat="server" ID="SellingCompanyName" DataBoundValue="SellingCompany.Id" LabelText="Selling Company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>
        
            </div>
        </con:GroupBox>
    </div>
    <div class="col-lg-6 consensus-column"> 
        <con:GroupBox runat="server" Title="Configuration">  
   
            <div class="row">
                <div class="col-md-6"><con:DateField runat="server" ID="StartDate" DataBoundValue="StartDate" LabelText="Start date" /></div>
                <div class="col-md-6"><con:DateField runat="server" ID="EndDate" DataBoundValue="EndDate" LabelText="End date" /></div>      
            </div>        
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="Qcode" DataBoundValue="Qcode" LabelText="Quick code" /></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="Region" DataBoundValue="Region" LabelText="Region" CodeType="CAMR" /></div>
            </div>
        </con:GroupBox>
    </div>
</div>
<%--<div class="row">
    <<div class="col-md-12"><con:TextField runat="server" ID="Notes" DataBoundValue="Notes" LabelText="Notes" TextMode="MultiLine" /></div>
</div>--%>

