<%@ Page AutoEventWireup="true" CodeBehind="TemplateSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.documents.popups.TemplateSearch" Language="C#" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Template Search" %>
<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
  <div class="row">
    <div class="col-2"><con:TextField runat="server" ID="TemplateName" LabelText="Name" IsEditable="true" /></div>
    <div class="col-2"><con:TextField runat="server" ID="TemplateType" LabelText="Type" IsEditable="true" ValueUrlParameter="TemplateType" ValueUrlIsEnforced="true"/>
        </div>
     <div class="col-1"><asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary" Text="Search" style="margin-top: 37px" OnClick="SearchButton_Click" /></div>
  </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
  <con:DataTable runat="server" ID="SearchResult" PageLength="10"  CanCreate="false" CanModify="false">
    <Columns>
      <con:DataTableTextColumn FieldName="LT_NAME" Title="Name" />
      <con:DataTableTextColumn FieldName="LTT_NAME" Title="Type" />
      <con:DataTableTextColumn FieldName="LT_FILE_NAME" Title="Document" />
      <con:DataTableLinkColumn LinkHref="javascript:closePopup({ command: 'select', text: '{{LT_NAME}}', value: '{{LT_ID}}' });" LinkText="Select" />
    </Columns>
  </con:DataTable>
</asp:Content>