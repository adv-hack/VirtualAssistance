<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PaymentAllocationList.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.PaymentAllocationList" %>
<con:DataTable runat="server" ID="PaymentAllocation" Url="~/GenericPopup.aspx?context=finance&control=AllocationDetail&id={{Id}}&allocationType=payment" CanModify="true">
  <Columns>
    <con:DataTableTextColumn Title="Allocation ID" FieldName="PA_ID"/>
    <con:DataTableLinkColumn Title="Invoice Ref" LinkHref="~/finance/invoicepage.aspx?id={{PA_INV_ID}}" LinkText="{{PA_INV_REF}}" />
    <con:DataTableLinkColumn Title="Credit Note Ref" LinkHref="~/finance/creditnotepage.aspx?id={{PA_CREDIT_ID}}" LinkText="{{PA_CREDIT_REF}}"/>
    <con:DataTableLinkColumn Title="Payment ID" LinkHref="~/finance/paymentpage.aspx?id={{PA_PAY_ID}}" LinkText="{{PA_PAY_ID}}" />
    <con:DataTableTextColumn Title="Currency" FieldName="PA_CURR_TYPE"/>
    <con:DataTableTextColumn Title="Allocation" FieldName="PA_VALUE"/>
  </Columns>
</con:DataTable>

