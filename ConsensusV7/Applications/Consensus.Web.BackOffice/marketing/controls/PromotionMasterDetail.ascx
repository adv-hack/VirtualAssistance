<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PromotionMasterDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.controls.PromotionMasterDetail" %>

<div class="row">
    <div class="col-lg-6 consensus-column"> 
        <con:GroupBox runat="server" Title="Promotion Master details">
            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:PopupField runat="server" ID="ManagerField" DataBoundValue="ManagerId" DataBoundText="Manager.PersonName" LabelText="Manager" PopupUrl="~/crm/popups/PersonSearch.aspx" HyperlinkUrl="~/crm/PersonPage.aspx?role={id}" /></div>
                <div class="col-md-6"><con:PopupField runat="server" ID="CampaignName" DataBoundValue="CmpIdId" DataBoundText="CmpId.Name" LabelText="Campaign" PopupUrl="~/marketing/popups/campaignSearch.aspx" HyperlinkUrl="~/marketing/campaignPage.aspx?id={id}" IsReadonly="True" /></div>
                
                
            </div>
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="SellingCompanyName" LabelText="Selling company" IsReadonly="True" /></div>
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
                <div class="col-md-6"><con:CodeField runat="server" ID="Region" DataBoundValue="RegionCode" LabelText="Region" CodeType="CAMR" /></div>

            </div>        
            <div class="row">
                <div class="col-md-6"><con:PopupField runat="server" ID="Event" DataBoundValue="CourseIdId" DataBoundText="CourseId.Name" LabelText="Event" PopupUrl="~/learning/popups/EventSearch.aspx" HyperlinkUrl="~/learning/EventPage.aspx?id={id}" /></div>
                <div class="col-md-6"><con:ListField runat="server" ID="Type" DataBoundValue="Type" LabelText="Type" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>    
             </div>
        </con:GroupBox>
    </div>
</div>

<%--<div class="row">
    <div class="col-md-12"><con:TextField runat="server" ID="Notes" DataBoundValue="Notes" LabelText="Notes" TextMode="MultiLine" /></div>
</div>--%>


