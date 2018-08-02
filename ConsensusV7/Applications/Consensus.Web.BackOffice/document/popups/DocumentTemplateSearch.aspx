
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DocumentTemplateSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.document.popups.DocumentTemplateSearch" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Document Template Search" %>

<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
    <div class="row">
        <div class="col-5">
            <con:TextField runat="server" ID="Name" LabelText="Name" IsEditable="true" />
        </div>
        <div class="col-3">
            <con:ListField runat="server" ID="DocTemplateType" LabelText="Type" IsEditable="True">
                <Items>
                    <asp:ListItem Text="Word" Value="0"></asp:ListItem>
                    <asp:ListItem Text="SMS" Value="1"></asp:ListItem>
                    <asp:ListItem Text="iCalendar" Value="2"></asp:ListItem>
                </Items>
            </con:ListField>
        </div>        
        <div class="col-4">
            <con:ListField runat="server" ID="SellingCompany" LabelText="Selling company" ValueMember="Id" DisplayMember="Name" IsEditable="true" />
        </div>
        <div class="col-1">
            <asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary" Text="Search" Style="margin-top: 37px" OnClick="SearchButton_Click" /></div>
    </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
    <con:DataTable runat="server" ID="SearchResult" PageLength="10" CanCreate="false" CanModify="false">
    <Columns>
      <con:DataTableTextColumn FieldName="Type" Title="Type" />    
      <con:DataTableTextColumn FieldName="Name" Title="Name" />      
      <con:DataTableTextColumn FieldName="SP_SELL_COMP_NAME" Title="Selling company" /> 
      <con:DataTableLinkColumn LinkHref="javascript: closePopup({ command: 'select', text: '{{Name}}', value: '{{Type}}', data: { doc_template_type: '{{Type}}',doc_template_name : '{{Name}}',doc_template_id : '{{id}}' }});" LinkText="Select" />
    </Columns>
  </con:DataTable>
</asp:Content>
