<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BookingAmountDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.BookingAmountDetail" %>

<con:HiddenField runat="server" ID="Type" DataBoundValue="Type" />
<div class="row">
  <div class="col-md-12"><con:PopupField runat="server" ID="DonationProduct" DataBoundValue="ProductId" DataBoundText="Product.Name" LabelText="Donation" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=29" HyperlinkUrl="~/learning/donationpage.aspx?id={Product.id}"  Requirement="MandatoryEnforced" IsReadOnly="False"/></div>
</div>
<div class="row">
    <div class="col-md-6"><con:ListField runat="server" ID="CostCode" DataBoundValue="CostCode" LabelText="Cost Code" ValueMember="Code" DisplayMember="Desc" /></div>
    <div class="col-md-6"><con:TextField runat="server" ID="Price" DataBoundValue="Price"  Requirement="MandatoryEnforced" LabelText="Amount" TextMode="Number"/></div>
</div> 
<div class="row">
    <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="GiftAid" ID="GiftAid" LabelText="Gift Aid" /></div>
</div> 