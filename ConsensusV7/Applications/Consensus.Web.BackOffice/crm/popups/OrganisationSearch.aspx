<%@ Page AutoEventWireup="true" CodeBehind="OrganisationSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.crm.popups.OrganisationSearch" Language="C#" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Organisation Search" %>
<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
  <div class="row">
    <div class="col-3"><con:TextField runat="server" ID="OrganisationId" LabelText="ID" IsEditable="true" /></div>
    <div class="col-7"><con:TextField runat="server" ID="Name" LabelText="Name" IsEditable="true" /></div>
    <div class="col-2"><asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary" Text="Search" style="margin-top: 37px" OnClick="SearchButton_Click" /></div>
  </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
  <con:DataTable runat="server" ID="SearchResult" PageLength="10"  CanCreate="false" CanModify="false">
    <Columns>
      <con:DataTableTextColumn FieldName="ORG_ID" Title="ID" />
      <con:DataTableTextColumn FieldName="ORG_NAME" Title="Name" />
      <con:DataTableLinkColumn LinkHref="javascript: closePopup({ command: 'select', text: '{{ORG_NAME}}', value: '{{ORG_ID}}', data: { org_id: '{{ORG_ID}}', add_id: '{{ADD_ID}}', add_mailstring: '{{ADD_MAILSTRING}}', addressLine1: '{{ADD_BUILDING}}', addressLine2: '{{ADD_STREET}}', addressLine3: '{{ADD_AREA}}', town: '{{ADD_TOWN}}', county: '{{ADD_COUNTY}}', postcode: '{{ADD_POSTCODE}}', country: '{{ADD_COUNTRY}}' } });" LinkText="Select" />    </Columns>
  </con:DataTable>
</asp:Content>
