<%@ Page AutoEventWireup="true" CodeBehind="StepSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.crm.popups.StepSearch" Language="C#" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Parameter Filter Search" %>
<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
  <div class="row">
    <div class="col-5"><con:TextField runat="server" TextMode="Number" ID="StepId" LabelText="Step ID" IsEditable="true" /></div>
    <div class="col-5"><con:TextField runat="server" ID="Name" LabelText="Name" IsEditable="true" /></div>
  </div>
  <div class="row">
    <div class="col-5"><con:TextField runat="server" ID="Owner" LabelText="Owner surname" IsEditable="true" /></div>
    <div class="col-5"><con:TextField runat="server" ID="Desc" LabelText="Description" IsEditable="true" /></div>
    <div class="col-2"><asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary" Text="Search" style="margin-top: 37px" OnClick="SearchButton_Click" /></div>
  </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
  <con:DataTable runat="server" ID="SearchResult" PageLength="10"  CanCreate="false" CanModify="false">
    <Columns>
      <con:DataTableTextColumn FieldName="STEP_ID" Title="Step ID" />
      <con:DataTableTextColumn FieldName="STEP_NAME" Title="Name" />
      <con:DataTableTextColumn FieldName="STEP_PROLE_OWNER_NAME" Title="Owner" />
      <con:DataTableTextColumn FieldName="STEP_DESC" Title="Description" />
      <con:DataTableLinkColumn LinkHref="javascript: closePopup({ command: 'select', text: '{{STEP_NAME}}', value: '{{STEP_ID}}', data: { owner: '{{STEP_PROLE_OWNER_NAME}}', description: '{{STEP_DESC}}', link_default: '{{STEP_LINK_DEFAULT}}' } });" LinkText="Select" />    
    </Columns>
  </con:DataTable>
</asp:Content>
