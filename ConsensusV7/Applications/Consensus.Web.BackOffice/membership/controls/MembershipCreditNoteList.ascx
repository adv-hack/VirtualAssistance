<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MembershipCreditNoteList.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MembershipCreditNoteList" %>
<con:DataTable runat="server" ID="CreditNoteList" Mode="Redirect" Url="~/finance/creditnotepage.aspx?id={{Id}}" CanCreate="false">
  <Columns>
    <con:DataTableLinkColumn Title="Credit Note number" LinkHref="~/finance/creditnotepage.aspx?id={{InvoieID}}" LinkText="{{InvoiceRef}}"/>
    <con:DataTableDateColumn Title="Credit date" FieldName="INV_DATE" />
    <con:DataTableLinkColumn Title="Credited invoice" LinkHref="~/finance/invoicepage.aspx?id={{CreditedInvoiceID}}" LinkText="{{CreditedInvoiceReference}}" />
    <con:DataTableTextColumn Title="AR number" FieldName="ARNumber" />
    <con:DataTableLinkColumn Title="Contact" LinkHref="~/crm/personpage.aspx?id={{InvPersonId}}" LinkText="{{INV_CONTACT_NAME}}"/>
    <con:DataTableLinkColumn Title="Organisation" LinkHref="~/crm/organisationpage.aspx?id={{InvOrgID}}" LinkText="{{InvOrgName}}" />
    <con:DataTableTextColumn Title="Currency" FieldName="InvoiceCurrType" />
    <con:DataTableTextColumn Title="Gross value" FieldName="InvGrossTotal" />
  </Columns>
</con:DataTable>
