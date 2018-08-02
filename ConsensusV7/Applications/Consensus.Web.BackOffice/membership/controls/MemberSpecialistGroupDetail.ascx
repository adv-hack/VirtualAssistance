<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberSpecialistGroupDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MemberSpecialistGroupDetail" %>
<div class="row">
    <div class="col-md-6">
        <con:PopupField runat="server" ID="Name" LabelText="Name" DataBoundValue="ProductId" DataBoundText="Product.Name" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=16" HyperlinkUrl="~/learning/productpage.aspx?id={id}" Requirement="MandatoryEnforced" />
    </div>
    <div class="col-md-6">
        <con:DateField runat="server" ID="StartDate" DataBoundValue="Start" LabelText="Start Date" Requirement="MandatoryEnforced" />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="Fee" DataBoundValue="Fee" LabelText="Fee" Requirement="MandatoryEnforced" TextMode="Number"/>
    </div>
    <div class="col-md-6">
        <con:DateField runat="server" ID="EndDate" DataBoundValue="End" LabelText="End Date" Requirement="MandatoryEnforced" />
    </div>
    <div class="col-md-6">
        <con:CodeField runat="server" ID="Vat" DataBoundValue="Vatcd" CodeType="VATCD" LabelText="VAT Code" Requirement="MandatoryEnforced" />
    </div>

    <con:HiddenField runat="server" ID="Mepid" />
    <con:HiddenField runat="server" ID="Status" DataBoundValue="Status" />
    <con:HiddenField runat="server" ID="SyType" DataBoundValue="SyType" />
</div>
<br />
<br />
<br />
<br />
<br />
<br />

