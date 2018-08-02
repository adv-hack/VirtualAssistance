<%@ Page AutoEventWireup="true" CodeBehind="AccountSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.finance.popups.AccountSearch" Language="C#" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Account Search" %>
<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
  <div class="row">
    <div class="col-2"><con:TextField runat="server" ID="ARNumber" LabelText="AR Number" IsEditable="true" /></div>
    <div class="col-2"><con:TextField runat="server" ID="AccountTitle" LabelText="Account Title" IsEditable="true" /></div>
    <div class="col-3">
        <con:PopupField runat="server" ID="OrganisationId" LabelText="Organisation" IsEditable="true" PopupUrl="~/crm/popups/organisationsearch.aspx" 
            ValueUrlParameter="orgId" ValueUrlIsEnforced="true" ValueUrlType="Consensus.Contact.Organisation" ValueUrlText="Name" />
    </div>
    <div class="col-4">
        <con:PopupField runat="server" ID="PersonId" LabelText="Person" IsEditable="true" PopupUrl="~/crm/popups/personsearch.aspx" />
    </div>
    <div class="col-1"><asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary" Text="Search" style="margin-top: 37px" OnClick="SearchButton_Click" /></div>
  </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
  <con:DataTable runat="server" ID="SearchResult" PageLength="10" CanCreate="false" CanModify="false">
    <Columns>
      <con:DataTableTextColumn FieldName="ACC_TITLE" Title="Account Title" />
      <con:DataTableTextColumn FieldName="ACC_SYSTEM_REF" Title="AR Number" />
      <con:DataTableTextColumn FieldName="ACC_STATUS" Title="Status" />
      <con:DataTableTextColumn FieldName="PROLE_PN_NAME" Title="Person" />
      <con:DataTableTextColumn FieldName="ORG_NAME" Title="Organisation" />
      <con:DataTableTextColumn FieldName="ADD_BUILDING" Title="Address" />
      <con:DataTableTextColumn FieldName="ADD_TOWN" Title="Town" /> 
      <con:DataTableTextColumn FieldName="ADD_POSTCODE" Title="Postcode" />
      <con:DataTableTextColumn FieldName="SP_SELL_COMP_NAME" Title="Selling Company" />   
      <con:DataTableLinkColumn LinkHref="javascript:closePopup({ command: 'select', text: '{{ACC_SYSTEM_REF}}', value: '{{ACC_ID}}', data: { org_id: '{{ORG_ID}}', org_name: '{{ORG_NAME}}',title: '{{ACC_TITLE}}', status: '{{ACC_STATUS}}', prole_id: '{{PROLE_ID}}', person_id: '{{PN_ID}}', person_name: '{{PROLE_PN_NAME}}', add_id: '{{ADD_ID}}', add_mailstring: '{{ADD_MAILSTRING}}', addressLine1: '{{ADD_BUILDING}}', addressLine2: '{{ADD_STREET}}', addressLine3: '{{ADD_AREA}}', town: '{{ADD_TOWN}}', county: '{{ADD_COUNTY}}', postcode: '{{ADD_POSTCODE}}', country: '{{ADD_COUNTRY}}' } });" LinkText="Select" />
    </Columns>
  </con:DataTable>
</asp:Content>