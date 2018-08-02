<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OpportunityPersonDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.sales.controls.OpportunityPersonDetail" %>

<div class="row">
  <div class="col-md-12">
      <con:PopupField runat="server" ID="Person" LabelText="Person" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/popups/personsearch.aspx?role={id}" Requirement="MandatoryEnforced">
        <Filters>
            <con:PopupFieldFilter ParameterName="org" Type="Control" Value="Organisation" />
        </Filters>
      </con:PopupField>
  </div>
</div>
<div class="row">
    <div class="col-md-12"><con:PopupField runat="server" ID="Organisation" LabelText="Organisation" DataBoundValue="OrganisationId" DataBoundText="Organisation.Name" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/popups/organisationsearch.aspx?id={id}" IsReadOnly="TrueEnforced"/></div>
</div>
<div class="row">
    <div class="col-md-6"><con:TextField runat="server" ID="Value" DataBoundValue="Value" LabelText="Value" TextMode="Number" /></div>
</div>
<div class="row">
    <div class="col-md-12"><con:ListField runat="server" DataBoundValue="PersonType" ID="PersonTypeList" LabelText="Type" />
    </div>
</div>
