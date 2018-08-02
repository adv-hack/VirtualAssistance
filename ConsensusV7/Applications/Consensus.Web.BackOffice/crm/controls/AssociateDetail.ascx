<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AssociateDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.AssociateDetail" %>
<div class="row">
  <div class="col-md-12"><con:CodeField runat="server" ID="AssociateType" DataBoundValue="TypeCode" LabelText="Type" CodeType="ASSOT" Requirement="MandatoryEnforced" OnLoadDataSource="AssociateType_OnLoadDataSource" /></div>
</div>
<div class="row">
  <div class="col-md-12">
      <con:PopupField runat="server" ID="Person" LabelText="Person" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/popups/personsearch.aspx?role={id}" Requirement="MandatoryEnforced" ValueUrlParameter="person" ValueUrlIsEnforced="true" ValueUrlType="Consensus.Contact.Person" ValueUrlText="FullName">
        <Filters>
            <con:PopupFieldFilter ParameterName="org" Type="Control" Value="Organisation" />
        </Filters>
      </con:PopupField>
  </div>
</div>
<div class="row">
    <div class="col-md-12"><con:PopupField runat="server" ID="Organisation" LabelText="Organisation" DataBoundValue="OrganisationId" DataBoundText="Organisation.Name" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}"  /></div>
</div>
<div class="row">
  <div class="col-md-6"><con:DateField runat="server" DataBoundValue="StartDate" ID="StartDate" LabelText="Start Date" /></div>
  <div class="col-md-6"><con:DateField runat="server" DataBoundValue="EndDate" ID="EndDate" LabelText="End Date" /></div>
</div>
