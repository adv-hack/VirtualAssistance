<%@ Page AutoEventWireup="true" CodeBehind="PackSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.documents.popups.PackSearch" Language="C#" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Pack Search" %>
<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
  <div class="row">
    <div class="col-2"><con:TextField runat="server" ID="PackName" LabelText="Name" IsEditable="true" /></div>
    <div class="col-2"><con:TextField runat="server" ID="PackType" LabelText="Type" IsEditable="true" ValueUrlParameter="PackType" ValueUrlIsEnforced="true"/>
        </div>
     <div class="col-1"><asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary" Text="Search" style="margin-top: 37px" OnClick="SearchButton_Click" /></div>
  </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
  <con:DataTable runat="server" ID="SearchResult" PageLength="10"  CanCreate="false" CanModify="false">
    <Columns>
      <con:DataTableTextColumn FieldName="PACK_NAME" Title="Name" />
      <con:DataTableTextColumn FieldName="PACKTYP_DESC" Title="Type" />
      <con:DataTableLinkColumn LinkHref="javascript:closePopup({ command: 'select', text: '{{PACK_NAME}}', value: '{{PACK_ID}}' });" LinkText="Select" />
    </Columns>
  </con:DataTable>
</asp:Content>