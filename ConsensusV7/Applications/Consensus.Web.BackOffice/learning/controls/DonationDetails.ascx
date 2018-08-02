<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DonationDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.DonationDetails" %>

<%@ Register TagPrefix="con" TagName="GenericProductDetails" Src="~/learning/controls/GenericProductDetails.ascx" %>

<div class="row">
    <div class="col-lg-6 consensus-column"> 
        <con:HiddenField runat="server" ID="SyProduct" DataBoundValue="SyProduct" />
        <con:GroupBox runat="server" Title="Basic Details">
          <con:GenericProductDetails runat="server" Id="GenericProduct" DataBoundId="Id" />
        </con:GroupBox>
    </div>
    <div class="col-lg-6 consensus-column">
        <con:GroupBox runat="server" Title="Donation details">
            <con:CheckField runat="server" ID="GiftAid" DataBoundValue="Giftaid" LabelText="Gift Aid allowed" />
            <con:CheckField runat="server" ID="CanChangeCostCode" DataBoundValue="CanChangeCostCode" LabelText="Allow fund selection" />
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="Donation1" DataBoundValue="Price" LabelText="Donation Set Price" TextMode="Number" /></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="Donation2" DataBoundValue="BlockPrice" LabelText="Donation Set Price" TextMode="Number" /></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="Donation3" DataBoundValue="SparePrice" LabelText="Donation Set Price" TextMode="Number" /></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="Donation4" DataBoundValue="CostPrice" LabelText="Donation Set Price" TextMode="Number" /></div>
          </div>
        </con:GroupBox>
    </div>
</div>