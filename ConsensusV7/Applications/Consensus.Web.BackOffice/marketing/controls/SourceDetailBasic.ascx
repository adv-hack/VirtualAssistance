<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SourceDetailBasic.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.controls.SourceDetailBasic" %>

<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Basic Details">
            <con:PopupField runat="server" ID="CampaignName" DataBoundValue="PromotionMaster.CmpIdid" DataBoundText="PromotionMaster.CmpId.Name" LabelText="Campaign name" PopupUrl="~/marketing/popups/campaignSearch.aspx" HyperlinkUrl="~/marketing/campaignPage.aspx?id={id}" IsReadonly="True" />
            <con:PopupField runat="server" ID="PromotionMasterName" DataBoundValue="PromotionMaster.Id" DataBoundText="PromotionMaster.Name" LabelText="Promotion master name" PopupUrl="~/marketing/popups/promotionSearch.aspx" HyperlinkUrl="~/marketing/promotionmasterPage.aspx?id={id}" IsReadonly="True" />


            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Source Code Name" Requirement="MandatoryEnforced" /></div>
                <div class="col-md-6"><con:TextField runat="server" ID="QCode" DataBoundValue="Qcode" LabelText="Source Quick Code" /></div>
            </div>
        </con:GroupBox>

    </div>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Breakdown">  
            <con:TextField runat="server" ID="SellingCompanyName" LabelText="Selling Company" IsReadonly="True" />          
            <div class="row">
                <div class="col-md-6"><con:DateField runat="server" ID="StartDate" DataBoundValue="StartDate" LabelText="Start Date" /></div>       
                <div class="col-md-6"><con:CheckField runat="server" ID="Current" DataBoundValue="Current" LabelText="Current" /></div>      
            </div>
            <div class="row"> 
                <div class="col-md-6"><con:CheckField runat="server" ID="WebEnabled" DataBoundValue="WebEnabled" LabelText="Web Enabled" /></div>      
                <div class="col-md-6"><con:CheckField runat="server" ID="EmailEnabled" DataBoundValue="EmailEnabled" LabelText="Email Enabled" /></div>      
            </div>     
            <div class="row">
                <div class="col-md-6"><con:CodeField runat="server" ID="Type" DataBoundValue="TypeCode" LabelText="Type" CodeType="PMTY" /></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="MediaName" DataBoundValue="MediaNameCode" LabelText="Media Name" CodeType="MDANM" /></div>
            </div>        
            <div class="row">
                <div class="col-md-6"><con:PopupField runat="server" ID="ManagerField" DataBoundValue="ManagerId" DataBoundText="Manager.PersonName" LabelText="Manager" PopupUrl="~/crm/popups/PersonSearch.aspx" HyperlinkUrl="~/crm/PersonPage.aspx?role={id}" /></div>
            </div>
        </con:GroupBox>
        <con:GroupBox runat="server" Title="Actual Values">                                                                    
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="ActualFixCost" DataBoundValue="ActualFixCost" LabelText="Actual Fixed Cost" TextMode="Number" /> <!--  ClientOnChange="changedActualCost();" -->
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="ActualVarCost" DataBoundValue="ActualVarCost" LabelText="Actual Variable Cost" TextMode="Number" /> <!-- ClientOnChange="changedActualCost();"  -->
                </div>
            </div>
        </con:GroupBox>
    </div>
</div>