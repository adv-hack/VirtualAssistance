<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ActivityTemplateDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.ActivityTemplateDetails" %>
<con:HiddenField runat="server" ID="Id" DataBoundValue="Id" />
<div class="row">
    <div class="col-6"> 
        <con:GroupBox runat="server" Title="Activity Details">
          <div class="row">
            <div class="col-md-12"><con:CodeField runat="server" ID="ActType" DataBoundValue="ActTypeCode" LabelText="Type" CodeType="ACT" Requirement="MandatoryEnforced"  /></div>          
          </div>
          <div class="row">
            <div class="col-md-12"><con:TextField runat="server" ID="ActSessionName" DataBoundValue="ActSessionName" LabelText="Name" Requirement="MandatoryEnforced" /></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="StartDay" DataBoundValue="StartDay"  Requirement="MandatoryEnforced" LabelText="Start Day" TextMode="Number"/></div>
            <div class="col-md-6"><con:TimeField runat="server" ID="StartTime" DataBoundValue="StartTime" LabelText="Start Time"/></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="EndDay" DataBoundValue="EndDay" Requirement="MandatoryEnforced" LabelText="End Day" TextMode="Number"/></div>
            <div class="col-md-6"><con:TimeField runat="server" ID="EndTime" DataBoundValue="EndTime" LabelText="End Time" /></div>
          </div>
        </con:GroupBox>
    </div>

    <div class="col-6">
        <con:GroupBox runat="server" Title="Configuration">
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="Quantity" DataBoundValue="Quantity" LabelText="Estimated Hours" TextMode="Number"/></div>
         </div>   
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="ActRevenueSplit" DataBoundValue="ActRevenueSplit" LabelText="% Revenue Split" TextMode="Number"/></div>
            <div class="col-md-6"><con:TextField runat="server" ID="ActHoursSplit" DataBoundValue="ActHoursSplit" LabelText="% Hours Split" TextMode="Number"/></div>
          </div>          
        </con:GroupBox>
    </div>
</div>
<div class="row">
  <div class="col-md-12">
    <con:TextField runat="server" ID="Notes" DataBoundValue="ActNote" LabelText="Notes" TextMode="MultiLine" />
  </div>
</div>