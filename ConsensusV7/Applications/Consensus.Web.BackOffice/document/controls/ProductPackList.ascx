<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductPackList.ascx.cs" Inherits="Consensus.Web.BackOffice.document.ProductPackList" %>
<con:DataTable runat="server" ID="ProductPackListResult" Url="~/GenericPopup.aspx?context=document&control=ProductPackDetail&id={{Id}}">
  <Columns>
    <con:DataTableTextColumn Title="Type" FieldName="Type" />
    <con:DataTableTextColumn Title="Pack" FieldName="Pack" />
    <con:DataTableIconColumn  Title="Suppress" FieldName="Suppress" Width="95px" />
  </Columns>
</con:DataTable>
