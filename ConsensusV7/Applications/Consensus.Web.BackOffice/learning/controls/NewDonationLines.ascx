<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewDonationLines.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.NewDonationLines" %>

<con:DataTable runat="server" ID="NewDonationLineList" Mode="Stateful" Url="~/genericPopup.aspx?context=learning&control=newdonationlinedetail">
  <Columns>
    <con:DataTableTextColumn Title="Product" FieldName="Element.ProdName" />
    <con:DataTableTextColumn Title="Description" FieldName="Element.Description" />
    <con:DataTableTextColumn Title="Cost Code" FieldName="Element.CostCode" />
    <con:DataTableTextColumn Title="Amount" FieldName="Element.Price" />
    <con:DataTableIconColumn Title="Gift Aid" FieldName="Element.GiftAid" />
  </Columns>
</con:DataTable>