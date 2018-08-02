<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MembershipProductSummary.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MembershipProductSummary" %>

<div class="row">
    <con:HiddenField runat="server" ID="GUID" DataBoundValue="_guid" />

    <div class="col-md-12">
        <div class="row">
            <div class="col-md-12">          
                <con:HiddenField runat="server" ID="ProductId" DataBoundValue="ProductId" />      
                <con:TextField runat="server" ID="ProductName" DataBoundValue="Name" LabelText="Product name" IsReadOnly="TrueEnforced" />
            </div>
        </div>
    </div>
    <div class="col-md-12">
        <div class="row">
            <div class="col-md-6">
                <con:HiddenField runat="server" ID="PriceListName" DataBoundValue="PriceListName" />
                <con:ListField runat="server" ID="PriceList" DataBoundValue="PriceListId" DisplayMember="Name" ValueMember="Id" LabelText="Price list" ClientOnChange="UpdatePriceListName()" IsReadOnly="TrueEnforced" />
            </div>
            <div class="col-md-6">
                <con:TextField runat="server" ID="Amount" LabelText="Amount" DataBoundValue="Amount" TextMode="Number" Requirement="MandatoryEnforced" />
            </div>
            <div class="col-md-6">
                <con:CodeField runat="server" ID="VatCode" LabelText="VAT code" CodeType="VATCD" DataBoundValue="VatCode" Requirement="MandatoryEnforced" />
            </div>
        </div>
    </div>
</div>
<asp:CustomValidator runat="server" ClientValidationFunction="ValidateAmount" Display="None" EnableClientScript="true" ErrorMessage="Negative amounts are not allowed." />
<script>


    function ValidateAmount(source, arguments) {
        var amount = $('#<%= this.Amount.ClientID %>Field').val();
        if (amount < 0) {
            arguments.IsValid = false;
        }
        else {
            arguments.IsValid = true;
        }
    }

    function UpdatePriceListName() {
        if ($('#Content_Content_ctl00_PriceListField').val()) {
            $('#<%= this.PriceListName.ClientID %>Field').val($('#<%= this.PriceList.ClientID %>Field').text().trim());
        }
        else {
            $('#<%= this.PriceListName.ClientID %>Field').val('');
        }
    }

</script>

