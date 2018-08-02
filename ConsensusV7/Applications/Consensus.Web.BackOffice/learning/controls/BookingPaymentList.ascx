<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BookingPaymentList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.BookingPaymentList" %>

<con:DataTable runat="server" ID="PaymentListResult" Mode="Redirect" Url="~/finance/paymentpage.aspx?id={{Id}}" CreateMode="RealTime" CreateUrl="~/GenericPopup.aspx?context=finance&control=newpayment&width=1050">
    <Columns>
        <con:DataTableDateColumn Title="Date" FieldName="PAY_DATE" />
        <con:DataTableTextColumn Title="Type" FieldName="PAY_TYPE" />
        <con:DataTableTextColumn Title="AR number" FieldName="ACC_SYSTEM_REF" />
        <con:DataTableTextColumn Title="Payer" FieldName="PAY_NAME" />
        <con:DataTableTextColumn Title="Organisation" FieldName="ORG_NAME" />
        <con:DataTableTextColumn Title="Amount" FieldName="PAY_RECVD" />
        <con:DataTableTextColumn Title="Currency" FieldName="PAY_CURR_TYPE" />
        <con:DataTableLinkColumn Title="Reference" LinkHref="~/finance/PaymentPage.aspx?id={{PAY_ID}}" LinkText="{{PAY_REF}}" />
        <con:DataTableTextColumn Title="Unused value" FieldName="PAY_UNUSED_VAL" />
    </Columns>
</con:DataTable>
