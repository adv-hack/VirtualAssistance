<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AccountInvoiceList.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.AccountInvoiceList" %>
<con:DataTable runat="server" ID="AccountInvoiceLists" Mode="Redirect" Url="~/finance/Invoicepage.aspx?id={{Id}}" CanCreate="false" >
    <Columns>
        <con:DataTableTextColumn Title="Invoice number" FieldName="INV_REF" />
        <con:DataTableDateColumn Title="Invoice date" FieldName="INV_DATE" />
        <con:DataTableTextColumn Title="AR number" FieldName="INV_BK_ORG_CUST_AC" />
        <con:DataTableLinkColumn Title="Contact" LinkHref="~/crm/PersonPage.aspx?id={{INV_PERSON_ID}}" LinkText="{{PROLE_PN_NAME}}" />
        <con:DataTableLinkColumn Title="Organisation" LinkHref="~/crm/organisationpage.aspx?id={{INV_ORG_ID}}" LinkText="{{INV_INV_ORG_NAME}}" />
        <con:DataTableTextColumn Title="Currency" FieldName="INV_CURRENCY_TYPE" />
        <con:DataTableTextColumn Title="Gross value" FieldName="INV_GROSS_TOTAL" />
        <con:DataTableDateColumn Title="Due date" FieldName="INV_DUE_DATE" />
        <con:DataTableTextColumn Title="Unpaid value" FieldName="INV_UNPAID_VAL" />
    </Columns>
</con:DataTable>
