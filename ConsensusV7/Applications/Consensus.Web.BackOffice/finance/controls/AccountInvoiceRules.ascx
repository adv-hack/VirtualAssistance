<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AccountInvoiceRules.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.AccountInvoiceRules" %>

<div class="row">
    <div class="col-lg-12 consensus-column">
        <con:GroupBox runat="server" Title="Invoice Rules">
            <div class="row">
                <div class="col-md-2">
                    <con:HiddenField runat="server" ID="InvoiceRuleOffset" DataBoundValue="InvoiceRuleOffset" />
                    <con:TextField TextMode="Number" runat="server" ID="OffsetValue" LabelText="Invoice days" ClientOnChange="SetInvoiceRuleOffset();">
                        <Validators>
                            <con:Validator runat="server" ClientValidationFunction="CheckIfIntegerForOffsetValue" Critical="true" ErrorMessage="This number must be a positive integer." />
                        </Validators>
                    </con:TextField>
                </div>
                <div class="col-md-2">
                    <con:ListField runat="server" ID="BeforeAfter" LabelText="Before / After" ClientOnChange="SetInvoiceRuleOffset();">
                        <Items>
                            <asp:ListItem Text="Before" Value="-1" />
                            <asp:ListItem Text="After" Value="1" />
                        </Items>
                    </con:ListField>
                </div>
                <div class="col-md-8">
                    <con:ListField runat="server" ID="InvoiceRule" DisplayMember="Description" ValueMember="Value1" DataBoundValue="InvoiceRule" LabelText="Invoice point" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <con:CodeField runat="server" ID="InvoiceWhenStatus" DataBoundValue="InvoiceWhenStatus" LabelText="Invoice line status" CodeType="SSTAT" />
                </div>
            </div>
        </con:GroupBox>
    </div>
</div>

<script type="text/javascript">

    function CheckIfIntegerForOffsetValue(source, args) {
        var regExp = /^[\d]*$/;
        var offsetValue = $('#<%= this.OffsetValue.ClientID %>Field').val();
        var isValid = regExp.test(offsetValue);
        args.IsValid = isValid;
    }

    function SetInvoiceRuleOffset() {
        var beforeAfterSign = $('#<%= this.BeforeAfter.ClientID %>Field').val();
        var offsetValue = $('#<%= this.OffsetValue.ClientID %>Field').val();
        var invoiceRuleOffset = 0;

        invoiceRuleOffset = offsetValue * beforeAfterSign;

        $('#<%= this.InvoiceRuleOffset.ClientID %>Field').val(invoiceRuleOffset);
    }

</script>
