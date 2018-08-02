<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GiftAidClaimBatchList.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.GiftAidClaimBatchList" %>

<con:DataTable runat="server" ID="GiftAidClaimBatchListResult" Mode="Redirect" Url="~/Finance/BatchPage.aspx?id={{Id}}" CanCreate="false">
    <Columns>
        <con:DataTableTextColumn Title="Batch ID" FieldName="BAT_ID" />
        <con:DataTableDateColumn Title="Created date" FieldName="BAT_ADD_DATE" />
        <con:DataTableTextColumn Title="Batch status" FieldName="BAT_STATUS" />
        <con:DataTableDateColumn Title="Run date" FieldName="DatePortion" Visible="false" />    
        <con:DataTableTextColumn Title="Time" FieldName="TimePortion" Visible="false"/>    
        <con:DataTableCustomColumn Title="Run date" >
             var date = consensus.data.getValue(row, "DatePortion") || '';
            var time = consensus.data.getValue(row, "TimePortion") || ''; 
            return  date + ' ' + time;
        </con:DataTableCustomColumn>
    </Columns>
</con:DataTable>
