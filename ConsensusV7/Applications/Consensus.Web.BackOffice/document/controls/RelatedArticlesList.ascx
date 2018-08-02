<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RelatedArticlesList.ascx.cs" Inherits="Consensus.Web.BackOffice.document.controls.RelatedArticlesList" %>
<con:DataTable runat="server" ID="RelatedArticlesListTable" Url="~/GenericPopup.aspx?context=document&control=RelatedArticleDetail&id={{Id}}">      
    <Columns>
        <con:DataTableLinkColumn Title="Name" LinkText="{{ARTI_NAME}}" LinkHref="ArticlePage.aspx?id={{ARTIXREF_REL_ARTI_ID}}" />  
        <con:DataTableDateColumn Title="Added" FieldName="ARTIXREF_ADD_DATE" />
        <con:DataTableTextColumn Title="Summary" FieldName="ARTI_SUMMARY" />                
    </Columns>
</con:DataTable>

