<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberGradeDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MemberGradeDetail" %>
<div class="row">
    <div class="col-md-6">
        <con:TextField runat="server" ID="Ref" DataBoundValue="Product.Ref" LabelText="Reference" />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="Fee" DataBoundValue="Fee" LabelText="Fee" />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="Name" DataBoundValue="Product.Name" LabelText="Name" />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="Vat" DataBoundValue="VatAmt" LabelText="VAT" />
    </div>
    <div class="col-md-6">
        <con:DateField runat="server" ID="Startdate" LabelText="Start Date" />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="Vatcode" DataBoundValue="Vatcd" LabelText="VAT Code" />
    </div>
     <div class="col-md-3">
        <con:CheckField runat="server" ID="Modified" DataBoundValue="PriceModified" LabelText="Modified" />
    </div>
    <div class="col-md-3">
        <con:CheckField runat="server" ID="Invoiced" DataBoundValue="Invoiced" LabelText="Invoiced" />
    </div>
   
</div>
