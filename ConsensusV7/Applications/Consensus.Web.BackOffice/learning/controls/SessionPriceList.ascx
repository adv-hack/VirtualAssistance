<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SessionPriceList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.SessionPriceList" %>
<con:DataTable runat="server" ID="SessionListResult" Mode="Stateful" Url="~/genericPopup.aspx?context=learning&control=sessionpricedetail&id={{Id}}">
  <Columns>
    <con:DataTableTextColumn Title="List Name" FieldName="PlName" />
    <con:DataTableDateColumn Title="Valid From" FieldName="ValidFrom" />
    <con:DataTableDateColumn Title="Valid Until" FieldName="ValidUntil" />  
    <con:DataTableTextColumn Title="Valid Date" FieldName="ValidDate" Visible="false" />
    <con:DataTableCustomColumn Title="Valid Date">
      var validDate = consensus.data.getValue(row, "ValidDate") || '';
      
            if (validDate == 1)
                return 'Event';
            else 
                return 'Booking';
    </con:DataTableCustomColumn>
    <con:DataTableTextColumn Title="Min Qty" FieldName="QtyMin" />
    <con:DataTableTextColumn Title="Max Qty" FieldName="QtyMax" />
    <con:DataTableTextColumn Title="Start" FieldName="StartDay" />
    <con:DataTableTextColumn Title="End" FieldName="EndDay" />
    <con:DataTableTextColumn Title="Currency" FieldName="Currency" />
    <con:DataTableTextColumn Title="Unit Price" FieldName="Price" />
  </Columns>
</con:DataTable>


