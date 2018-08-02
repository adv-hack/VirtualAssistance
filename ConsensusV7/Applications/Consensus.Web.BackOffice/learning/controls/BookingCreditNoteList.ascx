<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BookingCreditNoteList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.BookingCreditNoteList" %>
<con:DataTable runat="server" ID="CreditNoteList" Mode="Redirect" Url="~/finance/creditnotepage.aspx?id={{Id}}" CanCreate="false">
  <Columns>
    <con:DataTableLinkColumn Title="Credit note number" LinkHref="~/finance/creditnotepage.aspx?id={{INV_ID}}" LinkText="{{INV_REF}}"/>
    <con:DataTableDateColumn Title="Credit date" FieldName="INV_DATE" />
    <con:DataTableLinkColumn Title="Credited invoice" LinkHref="~/finance/invoicepage.aspx?id={{INV_ID2}}" LinkText="{{InvoiceReference}}"/>
    <con:DataTableTextColumn Title="AR number" FieldName="INV_BK_ORG_CUST_AC" />
    <con:DataTableLinkColumn Title="Contact" LinkHref="~/crm/personpage.aspx?id={{INV_PERSON_ID}}" LinkText="{{INV_CONTACT_NAME}}"/>
    <con:DataTableLinkColumn Title="Organisation" LinkHref="~/crm/organisationpage.aspx?id={{INV_ORG_ID}}" LinkText="{{INV_INV_ORG_NAME}}" />
    <con:DataTableTextColumn Title="Currency" FieldName="INV_CURRENCY_TYPE" />
    <con:DataTableTextColumn Title="Gross value" FieldName="INV_GROSS_TOTAL" />
  </Columns>
</con:DataTable>
