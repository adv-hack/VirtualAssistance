<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EventProductList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.EventProductList" %>
<con:DataTable runat="server" ID="ProductListResults" Url="~/GenericPopup.aspx?context=learning&control=eventproductdetail&width=1150&id={{Id}}">
  <Columns>
    <con:DataTableTextColumn Title="Product Name" FieldName="PROD_NAME" Visible ="true" />
    <con:DataTableTextColumn Title="Reference" FieldName="PROD_REF" Visible ="true"/>
    <con:DataTableTextColumn Title="Selection Group" FieldName="CSG_NAME" Visible ="true"/>      
    <con:DataTableTextColumn Title="Mandatory" FieldName="SXREF_MANDATORY" Visible ="true"/>
  </Columns>
</con:DataTable>

