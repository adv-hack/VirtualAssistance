<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.security.popups.ReportSearch" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Report Search" %>
<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
  <div class="row">
    <div class="col-sm-2"><con:TextField runat="server" TextMode="Number" ID="ReportId" LabelText="ID" IsEditable="true" /></div>
    <div class="col-sm-3"><con:TextField runat="server" ID="ReportName" LabelText="Report name" IsEditable="true" /></div>
    <div class="col-sm-3"><con:CodeField runat="server" ID="Category" LabelText="Category" CodeType="REPC" IsEditable="true" /></div>
    <div class="col-sm-2"><con:ListField runat="server" ID="Status" LabelText="Status" ValueMember="Key" DisplayMember="Value" IsEditable="true" /></div>  
    <div class="col-sm-1"><asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary" Text="Search" style="margin-top: 37px" OnClick="SearchButton_Click" /></div>
  </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
  <con:DataTable runat="server" ID="SearchResult" PageLength="10"  CanCreate="false" CanModify="false">
    <Columns>
      <con:DataTableTextColumn FieldName="REP_ID" Title="ID" />
      <con:DataTableTextColumn FieldName="REP_NAME" Title="Report name" />
      <con:DataTableTextColumn FieldName="REP_CAT" Title="Category" />
      <con:DataTableTextColumn FieldName="REP_STATUS" Title="Status" />
      <con:DataTableLinkColumn LinkHref="javascript: closePopup({ command: 'select', text: '{{REP_NAME}}', value: '{{REP_ID}}', data: { status: '{{REP_STATUS}}', category: '{{REP_CAT}}' } });" LinkText="Select" />    
    </Columns>
  </con:DataTable>
</asp:Content>
