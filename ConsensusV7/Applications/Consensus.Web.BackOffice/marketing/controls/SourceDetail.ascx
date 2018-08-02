<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SourceDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.controls.SourceDetail" %>

<div class="row">
    <div class="col-lg-6 consensus-column"> 
        <con:GroupBox runat="server" Title="Source code details">
            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:PopupField runat="server" ID="ManagerField" DataBoundValue="ManagerId" DataBoundText="Manager.PersonName" LabelText="Manager" PopupUrl="~/crm/popups/PersonSearch.aspx" HyperlinkUrl="~/crm/PersonPage.aspx?role={id}" /></div>
                <div class="col-md-6"><con:CheckField runat="server" ID="Current" DataBoundValue="Current" LabelText="Current" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:PopupField runat="server" ID="CampaignName" DataBoundValue="PromotionMaster.CmpIdid" DataBoundText="PromotionMaster.CmpId.Name" LabelText="Campaign" PopupUrl="~/marketing/popups/campaignSearch.aspx" HyperlinkUrl="~/marketing/campaignPage.aspx?id={id}" IsReadonly="True" /></div>       
                <div class="col-md-6"><con:PopupField runat="server" ID="PromotionMasterName" DataBoundValue="PromotionMasterId" DataBoundText="PromotionMaster.Name" LabelText="Promotion Master" PopupUrl="~/marketing/popups/promotionSearch.aspx" HyperlinkUrl="~/marketing/promotionmasterPage.aspx?id={id}" IsReadonly="True" /></div>                      
            </div>
            <div class="row"> 
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
                <div class="col-md-6"><con:CodeField runat="server" ID="MediaName" DataBoundValue="MediaNameCode" LabelText="Media name" CodeType="MDANM" /></div>
                
           </div>

            <div class="row">

                <div class="col-md-6"><con:TextField runat="server" ID="QCode" DataBoundValue="Qcode" LabelText="Quick code" /></div>
                
                <div class="col-md-6"><con:CodeField runat="server" ID="Type" DataBoundValue="TypeCode" LabelText="Type" CodeType="PMTY" /></div>
                <%--<div class="col-md-6"><con:CodeField runat="server" ID="Region" DataBoundValue="RegionCode" LabelText="Region" CodeType="CAMR" Requirement="Mandatory" /></div>--%>
            </div>        
            <div class="row">
<%--                <div class="col-md-6"><con:PopupField runat="server" ID="PopupField1" DataBoundValue="PromotionMaster.CourseIdId" DataBoundText="PromotionMaster.CourseId.Name" LabelText="Event" PopupUrl="~/learning/popups/EventSearch.aspx" HyperlinkUrl="~/learning/EventPage.aspx?id={id}" /></div>--%>
                <div class="col-md-6"><con:CodeField runat="server" ID="Channel" DataBoundValue="ChannelCode" LabelText="Channel" CodeType="CHAN" /></div>
                <div class="col-md-6"><con:CheckField runat="server" ID="EmailEnabled" DataBoundValue="EmailEnabled" LabelText="Email enabled" /></div> 
            </div>        
            <div class="row">
                <div class="col-md-6"><con:CheckField runat="server" ID="WebEnabled" DataBoundValue="WebEnabled" LabelText="Web enabled" /></div>        

            </div>
        </con:GroupBox>
    </div>
</div>
<%--<div class="row">
    <div class="col-md-12"><con:TextField runat="server" ID="Notes" DataBoundValue="Notes" LabelText="Notes" TextMode="MultiLine" /></div>
</div>--%>