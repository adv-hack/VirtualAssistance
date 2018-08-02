<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BookingLineList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.BookingLineList" %>

<con:DataTable runat="server" ID="BookingLineListResult" Mode="Stateful" CanModify="false" CanCreate="false">
  <Columns>
    <con:DataTableTextColumn Title="ID"  FieldName="ELEM_ID" />
    <con:DataTableLinkColumn Title="Name" LinkHref="~/crm/person?role={{PROLE_ID}}" LinkText={{PROLE_PN_NAME}} />
    <con:DataTableTextColumn Title="Type" FieldName="ELEM_TYPE_DESC" />
    <con:DataTableTextColumn Title="Description" FieldName="ELEM_DESCRIPTION" />
    <con:DataTableTextColumn Title="Status" FieldName="ELEM_STATUS_DESC" />
    <con:DataTableTextColumn Title="Qty" FieldName="ELEM_QTY" />
    <con:DataTableTextColumn Title="Unit price" FieldName="ELEM_UNT_PRICE" />
    <con:DataTableTextColumn Title="Price" FieldName="ELEM_PRICE" />
    <con:DataTableTextColumn Title="VAT" FieldName="ELEM_VAT_AMT" />
    <con:DataTableDateColumn Title="Start" FieldName="ELEM_START_DATE" />
    <con:DataTableDateColumn Title="End" FieldName="ELEM_END_DATE" />
    <con:DataTableIconColumn Title="Main" FieldName="ELEM_MAIN_SESSION" />
    <con:DataTableIconColumn Title="Invoiced" FieldName="ELEM_INVOICED" />
  </Columns>
</con:DataTable>