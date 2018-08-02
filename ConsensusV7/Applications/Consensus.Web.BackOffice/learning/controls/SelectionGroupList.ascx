<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SelectionGroupList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.SelectionGroupList" %>
<con:DataTable runat="server" ID="SelectionGroupResult" Mode="RealTime" CanDelete="true" Url="~/GenericPopup.aspx?context=learning&control=" >
  <Columns>
    <con:DataTableTextColumn Title="Name" FieldName="Name" />
    <con:DataTableTextColumn Title="Description" FieldName="Description" />
    <con:DataTableTextColumn Title="Minimum" FieldName="Minimum" />
    <con:DataTableTextColumn Title="Maximum" FieldName="Maximum" />
    <con:DataTableReorderColumn Title="Order" FieldName="Order"  ModelFieldName="Order" Visible="false" />
  </Columns>
</con:DataTable>