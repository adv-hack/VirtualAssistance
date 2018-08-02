<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MembershipDirectDebitList.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MembershipDirectDebitList" %>
<con:DataTable runat="server" ID="MemberDirectDebitListResult" Mode="Redirect" Url="~/finance/DirectDebitPage.aspx?id={{Id}}" CreateUrl="~/finance/DirectDebitPage.aspx?memberPeriodId={{MemberPeriodId}}" CanCreate="true">
  <Columns>
    <con:DataTableLinkColumn Title="Direct Debit ID" LinkHref="~/finance/DirectDebitPage.aspx?id={{DD_ID}}" LinkText="{{DD_ID}}"/>
    <con:DataTableTextColumn Title="Name" FieldName="PROLE_PN_NAME" />
    <con:DataTableDateColumn Title="Received date" FieldName="DD_RCV_DATE"/>
    <con:DataTableDateColumn Title="Due date"  FieldName="DD_DUE_DATE"/>
    <con:DataTableDateColumn Title="End date" FieldName="DD_END_DATE"/>
    <con:DataTableTextColumn Title="Status" FieldName="DD_STATUS_TEXT"/>    
  </Columns>
</con:DataTable>