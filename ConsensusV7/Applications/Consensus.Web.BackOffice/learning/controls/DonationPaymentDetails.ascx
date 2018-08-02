<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DonationPaymentDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.DonationPaymentDetails" %>

<%@ Register TagPrefix="con" TagName="InvoiceDetails" Src="~/learning/controls/InvoiceDetails.ascx" %>

<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Donor details">
            <con:InvoiceDetails runat="server" Id="InvoiceDetails"  />        
        </con:GroupBox>
    </div>
</div>