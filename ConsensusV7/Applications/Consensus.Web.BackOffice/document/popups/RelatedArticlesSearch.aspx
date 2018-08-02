<%@ Page AutoEventWireup="true" CodeBehind="RelatedArticlesSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.document.popups.RelatedArticlesSearch" Language="C#" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Article Search" %>

<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
    <div class="row">
        <div class="col-6">
            <con:TextField runat="server" ID="ArticleName" LabelText="Name" IsEditable="true" />
        </div>
        <div class="col-3">
            <con:ListField runat="server" ID="Status" DataBoundValue="State" LabelText="Status" IsEditable="True">
                <Items>                    
                    <asp:ListItem Text="Planning" Value="0" />
                    <asp:ListItem Text="Current" Value="1" Selected="True" />
                    <asp:ListItem Text="Cancelled" Value="2" />
                </Items>
            </con:ListField>
        </div>
        <div class="col-3">
            <asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary" Text="Search" Style="margin-top: 37px" OnClick="SearchButton_Click" /></div>
    </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
    <con:DataTable runat="server" ID="SearchResult" PageLength="10" CanCreate="false" CanModify="false">
        <Columns>
            <con:DataTableTextColumn FieldName="ARTI_NAME" Title="Name" />
            <con:DataTableTextColumn FieldName="ARTI_STATUS" Title="Status" />
            <con:DataTableLinkColumn LinkHref="javascript:closePopup({ command: 'select', text: '{{ARTI_NAME}}', value: '{{ARTI_ID}}',data: { summary: '{{ARTI_SUMMARY}}',articleId : '{{ARTI_ID}}' }});" LinkText="Select" />
        </Columns>
    </con:DataTable>
</asp:Content>
