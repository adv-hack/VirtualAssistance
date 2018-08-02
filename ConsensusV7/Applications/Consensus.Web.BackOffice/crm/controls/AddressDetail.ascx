<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddressDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.AddressDetail" %>

<div class="row">
  <div class="col-md-12">
    <con:HiddenField ID="Id" runat="server" DataBoundValue="Id" />
    <con:TextField runat="server" ID="AddressLine1" DataBoundValue="Building" LabelText="Building" Requirement="MandatoryEnforced">
      <Addons>
        <con:AddOn Icon="search" ToolTip="Select Alternate Address" CssClass="consensus-edit-visible" />
      </Addons>
    </con:TextField>
  </div>
</div>
<div class="row"><div class="col-md-12"><con:TextField runat="server" ID="AddressLine2" DataBoundValue="Street" LabelText="Street" /></div></div>
<div class="row"><div class="col-md-12"><con:TextField runat="server" ID="AddressLine3" DataBoundValue="Area"   LabelText="Area" /></div></div>
<div class="row"><div class="col-md-12"><con:TextField runat="server" ID="Town"         DataBoundValue="Town"   LabelText="Town" /></div></div>
<div class="row">
  <div class="col-md-7"><con:TextField runat="server" ID="County"   DataBoundValue="County"   LabelText="County" /></div>
  <div class="col-md-5"><con:TextField runat="server" ID="Postcode" DataBoundValue="Postcode" LabelText="Postcode" /></div>
</div>
<div class="row">
  <div class="col-md-12"><con:ListField runat="server" ID="Countries" DataBoundValue="Country" ValueMember="Name" LabelText="Country" DisplayMember="Name"  /></div>
</div>
<div class="row">
  <div class="col-md-6"><con:TextField runat="server" ID="Phone" DataBoundValue="Phone" LabelText="Address Phone" TextMode="Phone" HyperlinkUrl="tel:{text}"/></div>
  <div class="col-md-6"><con:TextField runat="server" ID="Fax"   DataBoundValue="Fax"   LabelText="Address Fax"   TextMode="Phone" HyperlinkUrl="tel:{text}"/></div>
</div>
<div class="row">
  <div class="col-md-12"><con:TextField runat="server" ID="Email" DataBoundValue="Email" LabelText="Address Email" TextMode="Email" HyperlinkUrl="mailto:{text}"/></div>
</div>