<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LicenseOwner.ascx.cs" Inherits="Consensus.Web.BackOffice.security.controls.LicenseOwner" %>
<div class="row">
  <div class="col-md-6">
    <con:PopupField runat="server" ID="Person"       LabelText="Person"       DataBoundValue="OwnerId"                  IsReadOnly="FalseEnforced" Requirement="MandatoryEnforced"  HyperlinkUrl="~/crm/person?id={id}" DataBoundText="Owner.Person.FullName" PopupUrl="~/crm/popups/PersonSearch.aspx"  />
    <con:PopupField runat="server" ID="Organisation" LabelText="Organisation" DataBoundValue="Owner.OrganisationId"     IsReadOnly="TrueEnforced"  HyperlinkUrl="~/crm/organisation?id={id}"  DataBoundText="Owner.Organisation.Name" PopupUrl="~/crm/popups/OrganisationSearch.aspx" />
    <con:TextField  runat="server" ID="Address"      LabelText="Address"      DataBoundValue="Owner.Address.MailString" IsReadOnly="TrueEnforced"  TextMode="MultiLine" CssClass="consensus-input noresize" />
  </div>
  <div class="col-md-6">
    <con:TextField  runat="server" ID="Phone" LabelText="Telephone" DataBoundValue="Owner.Telephone" IsReadOnly="TrueEnforced" TextMode="Phone" HyperlinkUrl="tel:{text}" />
    <con:TextField  runat="server" ID="Fax"   LabelText="Fax"       DataBoundValue="Owner.Fax"       IsReadOnly="TrueEnforced" TextMode="Phone" HyperlinkUrl="tel:{text}" />
    <con:TextField  runat="server" ID="Email" LabelText="Email"     DataBoundValue="Owner.Email"     IsReadOnly="TrueEnforced" TextMode="Email" HyperlinkUrl="mailto:{text}" />
  </div>
</div>
