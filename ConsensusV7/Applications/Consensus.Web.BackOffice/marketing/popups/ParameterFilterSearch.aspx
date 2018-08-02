<%@ Page AutoEventWireup="true" CodeBehind="ParameterFilterSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.crm.popups.ParameterFilterSearch" Language="C#" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Parameter Filter Search" %>
<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
  <div class="row">
    <div class="col-7"><con:TextField runat="server" ID="Field" LabelText="Field" IsEditable="true" /></div>
    <div class="col-3"><con:TextField runat="server" ID="Table" LabelText="Table" IsEditable="true" /></div>
    <div class="col-2"><asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary" Text="Search" style="margin-top: 37px" OnClick="SearchButton_Click" /></div>
  </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
  <con:DataTable runat="server" ID="SearchResult" PageLength="10"  CanCreate="false" CanModify="false">
    <Columns>
      <con:DataTableTextColumn FieldName="F_COLUMN_DESC" Title="Field" />
      <con:DataTableTextColumn FieldName="F_COLUMN_NAME" Title="Database Name" />
      <con:DataTableTextColumn FieldName="F_TABLE_DESC" Title="Table" />
      <con:DataTableLinkColumn LinkHref="javascript: closePopup({ command: 'select', text: '{{F_COLUMN_DESC}}', value: '{{F_ID}}', data: { column_name: '{{F_COLUMN_NAME}}', table_desc: '{{F_TABLE_DESC}}' } });" LinkText="Select" />    
    </Columns>
  </con:DataTable>
</asp:Content>
