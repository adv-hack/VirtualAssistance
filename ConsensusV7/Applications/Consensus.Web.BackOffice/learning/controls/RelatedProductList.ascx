<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RelatedProductList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.RelatedProductList" %>
<con:DataTable runat="server" ID="RelatedProductListResult" Url="~/GenericPopup.aspx?context=learning&control=relatedproductdetail&id={{Id}}">
  <Columns>
    <con:DataTableTextColumn Title="Relationship" FieldName="REL_TYPE" />
    <con:DataTableLinkColumn Title="Name" LinkHref="~/learning/productpage.aspx?id={{REL_PROD_ID}}" LinkText="{{REL_PROD_NAME}}" />  
    <con:DataTableTextColumn Title="Reference" FieldName="REL_PROD_REF" />
  </Columns>
</con:DataTable>




