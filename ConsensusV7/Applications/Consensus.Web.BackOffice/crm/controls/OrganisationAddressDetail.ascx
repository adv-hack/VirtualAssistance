<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OrganisationAddressDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.OrganisationAddressDetail" %>
<%@ Register TagPrefix="con" TagName="AddressDetail" Src="~/crm/controls/AddressDetail.ascx" %>

<con:AddressDetail runat="server" Id="AddressDetail" DataBoundObject="Address" DataBoundId="OrganisationAddress.AddressId" HideAddressContactInfo="true"/>
<div class="row">
      <div class="col-md-6"><con:CheckField runat="server" ID="Principal" DataBoundValue="Principal" LabelText="Principal" /></div>
</div>
<div class="row">
  <div class="col-md-12"><con:CodeField runat="server" ID="AddressType" DataBoundValue="TypeCode" LabelText="Address Type" CodeType="ADDT" /></div>
</div>