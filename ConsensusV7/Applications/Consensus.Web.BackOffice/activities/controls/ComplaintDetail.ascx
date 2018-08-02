<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ComplaintDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.activities.controls.ComplaintDetail" %>

<div class="row">
    <div class="col-md-6">
    <con:GroupBox runat="server" Title="Complaint details">
      <con:TextField runat="server" ID="summary" DataBoundValue="Title" LabelText="Summary" Requirement="MandatoryEnforced" />
        <div class="row">
          <div class="col-md-6"><Con:PopupField runat="server" ID="fromProleId" DataBoundValue="FromProleIdId" DataBoundText="FromProleId.PersonName" LabelText="Complainant" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}"></Con:PopupField></div>
          <div class="col-md-6"><Con:PopupField runat="server" ID="reProleId" DataBoundValue="ReProleIdId" DataBoundText="ReProleId.PersonName" LabelText="Regarding" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}"></Con:PopupField></div>
        </div>
      <div class="row">
        <div class="col-md-6"><con:DateField runat="server" ID="complaintDate" DataBoundValue="DateOfCompl" LabelText="Complaint date" /></div>
        <div class="col-md-6"><con:DateField runat="server" ID="recdDate" DataBoundValue="DateRcvd" LabelText="Received date" /></div>
      </div>

        <div class="row">
                <div class="col-md-6"><con:CodeField runat="server" ID="complaintMethod" DataBoundValue="SchemeCode" LabelText="Complaint method" CodeType="CMPSC" /></div>
                <div class="col-md-6"><con:PopupField runat="server" ID="promotionID" DataBoundValue="PromotionIDId" DataBoundText="PromotionID.Name" LabelText="Source code" PopupUrl="~/marketing/popups/promotionsearch.aspx" HyperlinkUrl="~/marketing/sourcepage.aspx?id={id}" />
        </div>
      </div> </con:GroupBox>   
  </div>

    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Complaint management">
            <div class="row">
                <div class="col-md-6"><con:DateField runat="server" ID="nextAction" DataBoundValue="DateNextAct" LabelText="Next action" /></div>
                <div class="col-md-6"><Con:PopupField runat="server" ID="mgrProleId" DataBoundValue="MgrProleIdId" DataBoundText="MgrProleId.PersonName" LabelText="Assigned to" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}"></Con:PopupField></div>
            </div>            
            
            <div class="row">
              <div class="col-md-6"><Con:PopupField runat="server" ID="medtrProleId" DataBoundValue="MedtrProleIdId" DataBoundText="MedtrProleId.PersonName" LabelText="Owner" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}"></Con:PopupField></div>
              <div class="col-md-6"><con:CodeField runat="server" ID="status" DataBoundValue="StatusCode" LabelText="Status" CodeType="CMPS1" /></div>
            </div>

            <div class="row">
                <div class="col-md-6"><con:DateField runat="server" ID="resolutionDate" DataBoundValue="DateEnd" LabelText="Resolution date" /></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="resolution" DataBoundValue="ResolutionCode" LabelText="Resolution" CodeType="CMPS2" /></div>
            </div>

            <div class="row">
                <div class="col-md-6"><con:CodeField runat="server" ID="category" DataBoundValue="CategoryCode" LabelText="Category" CodeType="CMPT1" /></div>
            </div>


        </con:GroupBox>
    </div>
</div>

<div class="row">
    <div class="col-md-12"><con:TextField runat="server" ID="notes" DataBoundValue="Notes" LabelText="Complaint text" TextMode="MultiLine" /></div>
</div>