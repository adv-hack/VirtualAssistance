<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InvoiceSummary.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.InvoiceSummary" %>
    <div class="col-md-3">
         <con:TextField runat="server" ID="Currency" DataBoundValue="Currency" LabelText="Currency" IsReadOnly="True" />
    </div>
    <div class="col-md-3">
         <con:TextField runat="server" ID="NetTotal" DataBoundValue="NetTotal" LabelText="Net Total" IsReadOnly="True" TextMode="Number" />
    </div>
    <div class="col-md-3">
         <con:TextField runat="server" ID="VatTotal" DataBoundValue="VatTotal" LabelText="VAT Total" IsReadOnly="True" TextMode="Number" />
    </div>
    <div class="col-md-3">
         <con:TextField runat="server" ID="GrossTotal" DataBoundValue="GrossTotal" LabelText="Gross Total" IsReadOnly="True" TextMode="Number"/>
    </div>
