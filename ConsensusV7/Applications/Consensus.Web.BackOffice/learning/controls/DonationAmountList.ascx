<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DonationAmountList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.DonationAmountList" %>
<con:DataTable runat="server" ID="AmountListResult" CanCreate ="false" CanModify="false" Url="~/genericPopup.aspx?context=learning&control=donationAmountdetail">
  <Columns>
    <con:DataTableLinkColumn Title="Product" LinkHref="donationpage.aspx?id={{ELEM_PROD_ID}}" LinkText="{{PROD_REF}}" />
    <con:DataTableTextColumn Title="Description" FieldName="ELEM_DESCRIPTION" />
    <con:DataTableTextColumn Title="Cost Code" FieldName="ELEM_COST_CODE" />
    <con:DataTableTextColumn Title="Amount" FieldName="ELEM_PRICE" />
    <con:DataTableIconColumn Title="Gift Aid" FieldName="ELEM_GIFT_AID" />
  </Columns>
</con:DataTable>
