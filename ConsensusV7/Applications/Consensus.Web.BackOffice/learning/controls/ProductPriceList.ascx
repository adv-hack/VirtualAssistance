<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductPriceList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.ProductPriceList" %>
<con:DataTable runat="server" ID="PriceListResult" Url="~/GenericPopup.aspx?context=learning&control=">
  <Columns>
    <con:DataTableTextColumn Title="List Name" FieldName="PL_NAME" />
    <con:DataTableDateColumn Title="Valid From" FieldName="PRS_VALID_FROM" />
    <con:DataTableDateColumn Title="Valid Until " FieldName="PRS_VALID_UNTIL" />  
    <con:DataTableTextColumn Title="Valid Date " FieldName="PRS_VALID_DATE" />
    <con:DataTableTextColumn Title="Min Qty" FieldName="PRS_QTY_MIN" />
    <con:DataTableTextColumn Title="Max Qty" FieldName="PRS_QTY_MAX" />
    <con:DataTableTextColumn Title="Start" FieldName="PRS_START" />
    <con:DataTableTextColumn Title="End" FieldName="PRS_END" />
    <con:DataTableTextColumn Title="Type" FieldName="PRS_TYPE" />
    <con:DataTableTextColumn Title="Currency" FieldName="PRS_CURR_TYPE" />
    <con:DataTableCustomColumn Title="Unit Price"  >
        var unit_price=consensus.data.getValue(row,"PRS_PRICE") || '';
        return Number(unit_price).toFixed(2);
    </con:DataTableCustomColumn>      
  </Columns>
</con:DataTable>
