<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DonationList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.DonationList" %>
<con:DataTable runat="server" ID="DonationListResult" Mode="Redirect"  CreateUrl="javascript:consensus.web.popupFrame({url:consensus.resolveUrl('~/GenericPopup.aspx?context=learning&control=newdonationdetails')});" Url="~/learning/donationbooking?id={{Id}}">
  <Columns>
    <con:DataTableTextColumn Title="ID" FieldName="BOOK_ID" />
    <con:DataTableLinkColumn Title="Name" LinkHref="~/learning/donation?id={{ELEM_PROD_ID}}" LinkText="{{PROD_NAME}}" />
    <con:DataTableLinkColumn Title="Ref" LinkHref="~/learning/donation?id={{ELEM_PROD_ID}}" LinkText="{{PROD_REF}}" />
    <con:DataTableDateColumn Title="Date" FieldName="BOOK_ADD_DATE" />  
    <con:DataTableTextColumn Title="Status" FieldName="ELEM_STATUS" />
    <con:DataTableLinkColumn Title="Contact" LinkHref="~/crm/personPage.aspx?id={{BOOKER_PN_ID}}" LinkText="{{BOOKER_PROLE_PN_NAME}}" />
    <con:DataTableLinkColumn Title="Donor" LinkHref="~/crm/personPage.aspx?id={{INVOICE_PN_ID}}" LinkText="{{INVOICE_PROLE_PN_NAME}}" />
    <con:DataTableTextColumn Title="Fund" FieldName="ELEM_COST_CODE" />
    <con:DataTableTextColumn Title="Amount" FieldName="ELEM_PRICE" />
    <con:DataTableIconColumn Title="Gift Aid" FieldName="ELEM_GIFT_AID" />
  </Columns>
</con:DataTable>