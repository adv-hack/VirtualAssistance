<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberDiscountDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MemberDiscountDetail" %>
<div class="row">
    <div class="col-md-6">
        <con:CodeField runat="server" ID="DisReason" DataBoundValue="DiscReason" CodeType="MLDIS" LabelText="Discount reason" Requirement="MandatoryEnforced" />
    </div>
    <div class="col-md-6">
        <con:DateField runat="server" ID="AppliesUntil" DataBoundValue="DiscRenewal" LabelText="Renewing until" />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="DisValue" DataBoundValue="Fee" LabelText="Discount value"  TextMode="Number"/>
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="DisPercent" DataBoundValue="DiscPercent" LabelText="Discount percentage" TextMode="Number"/>
    </div>
    <div class="col-md-6">
        <con:CodeField runat="server" ID="Vatcode" DataBoundValue="Vatcd" CodeType="VATCD" LabelText="VAT code" Requirement="MandatoryEnforced" />
    </div>
    <con:HiddenField runat="server" ID="Mepid" />
    <con:HiddenField runat="server" ID="FeeValue" DataBoundValue="FeeAmount"/>
    <con:HiddenField runat="server" ID="Status" DataBoundValue="Status" />
    <con:HiddenField runat="server" ID="SyType" DataBoundValue="SyType" />
</div>
<br />
<br />
<br />
<script type="text/javascript">

    $('#Content_Content_ctl00_DisValueField').click(function () {
        $('#Content_Content_ctl00_DisValueField').attr('readonly', false);
        $('#Content_Content_ctl00_DisPercentField').attr('readonly', true);
        $('#Content_Content_ctl00_DisPercentField').val(" ");

    });
    $('#Content_Content_ctl00_DisPercentField').click(function () {
        $('#Content_Content_ctl00_DisPercentField').attr('readonly', false);
        $('#Content_Content_ctl00_DisValueField').attr('readonly', true);
        $('#Content_Content_ctl00_DisValueField').val(" ");

    });
</script>

