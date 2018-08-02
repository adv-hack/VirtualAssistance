<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AccountDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.AccountDetail" %>

<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Account details">
            <con:HiddenField runat="server" ID="AccountId" DataBoundValue="Id" />
            <con:TextField runat="server" ID="Name" DataBoundValue="Title" LabelText="Account Name" />
            <con:TextField runat="server" ID="ARNumber" DataBoundValue="ARNumber" LabelText="AR Number">
                <Validators>
                    <con:Validator runat="server" ClientValidationFunction="CheckARNumberIsRequired" Critical="true" ErrorMessage="This is a required field" />
                </Validators>
            </con:TextField>
            <con:CodeField runat="server" ID="Currency" DataBoundValue="CurrencyType" LabelText="Currency" CodeType="CURR" Requirement="MandatoryEnforced" />
            <con:CodeField runat="server" ID="AccountStatus" DataBoundValue="StatusCode" LabelText="Account status" CodeType="ACCST" Requirement="MandatoryEnforced" />
            <con:CodeField runat="server" ID="TypeCode" DataBoundValue="TypeCode" LabelText="Account Type" CodeType="ACCTY" />
            <con:CodeField runat="server" ID="VATCode" DataBoundValue="VatcdCode" LabelText="VAT Code" CodeType="VATCD" />
            <con:TextField runat="server" ID="VatRegNum" DataBoundValue="VatRegNum" LabelText="VAT Registration number" />
            <con:CheckField runat="server" ID="PoReq" LabelText="Purchase Order required" DataBoundValue="PoReq" />
            <con:TextField runat="server" ID="Credit" DataBoundValue="Credit" LabelText="Credit limit">
                <Validators>
                    <con:Validator runat="server" ClientValidationFunction="CheckIfValidCreditLimit" Critical="true" ErrorMessage="This is not a valid number." />
                </Validators>
            </con:TextField>
            <con:ListField runat="server" ID="SellingCompany" DataBoundValue="SellingComanpyId" DataBoundText="SellingCompany.Name" LabelText="Selling Company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" />
        </con:GroupBox>
    </div>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Account information">
            <con:TextField runat="server" ID="InvoicedValue" LabelText="Invoiced value" IsReadOnly="TrueEnforced" />
            <con:TextField runat="server" ID="PaymentTotal" LabelText="Payment total" IsReadOnly="TrueEnforced" />
            <con:TextField runat="server" ID="OutstandingBalance" LabelText="Outstanding balance" IsReadOnly="TrueEnforced" />
            <con:TextField runat="server" ID="OverdueInvoices" LabelText="Overdue invoices" IsReadOnly="TrueEnforced" />
            <con:TextField runat="server" ID="UnallocatedPaymentValue" LabelText="Unallocated payment value" IsReadOnly="TrueEnforced" />
            <con:TextField runat="server" ID="CreditAvailable" LabelText="Credit available" IsReadOnly="TrueEnforced" />
        </con:GroupBox>
    </div>
</div>

<asp:Panel runat="server" ID="PaymentPanel">
    <con:GroupBox runat="server" Title="Payment terms">
        <con:TextField runat="server" TextMode="Number" ID="PaymentDays" DataBoundValue="PaymentDays" LabelText="Payment days">
            <Validators>
                <con:Validator runat="server" ClientValidationFunction="CheckIfIntegerForPaymentDays" Critical="true" ErrorMessage="This number must be a positive integer." />
            </Validators>
        </con:TextField>
        <con:HiddenField runat="server" ID="MemPaymentDays" DataBoundValue="MemPaymentDays" />
        <con:ListField runat="server" ID="From" DataBoundValue="PaymentType" LabelText="From" ValueMember="Key" DisplayMember="Value" />
    </con:GroupBox>
</asp:Panel>

<con:Validator runat="server" ClientValidationFunction="CheckIfARNumberExist" ErrorMessage="" />
<script type="text/javascript">

    function CheckIfIntegerForPaymentDays(source, args) {
        var regExp = /^[\d]*$/;
        var paymentDays = $('#<%= this.PaymentDays.ClientID %>Field').val();
        var isValid = regExp.test(paymentDays);
        args.IsValid = isValid;
    }

    function CheckARNumberIsRequired(source, args) {
        args.IsValid = true;
        if ($('#<%= this.AccountId.ClientID %>Field').val()) {
            if (!$('#<%= this.ARNumber.ClientID %>Field').val()) {
                args.IsValid = false;
            }
        }
    }

    function CheckIfValidCreditLimit(source, args) {
        var regExp = /^[+]?([0-9]+(?:[\.][0-9]*)?|\.[0-9]+)$/;
        var creditLimit = $('#<%= this.Credit.ClientID %>Field').val();
        var isValid = regExp.test(creditLimit);
        if (!isValid) {
            args.IsValid = isValid;
            source.errormessage = "This is not a valid number.";
            source.textContent = "This is not a valid number.";
            if (!isNaN(creditLimit)) {
                if (parseFloat(creditLimit) < 0) {
                    source.errormessage = "This number must be a positive value.";
                    source.textContent = "This number must be a positive value.";
                }
            }
        }
        return isValid;
    }

    function CheckIfARNumberExist(source, args) {
        var isValidCreditLimit = CheckIfValidCreditLimit(source, args);

        if (isValidCreditLimit) {
            $('#<%= this.MemPaymentDays.ClientID %>Field').val($('#<%= this.PaymentDays.ClientID %>Field').val());

            if ($('#<%= this.AccountId.ClientID %>Field').val() || $('#<%= this.ARNumber.ClientID %>Field').val()) {
                consensus.network.send({
                    async: false,
                    method: 'post',
                    url: 'finance/Account/CheckIfARNumberExist?arNumber=' + $('#<%= this.ARNumber.ClientID %>Field').val() + '&sellingCompId=' + $('#<%= this.SellingCompany.ClientID %>Field').val() + '&accountId=' + $('#<%= this.AccountId.ClientID %>Field').val(),
                    success: function (response) {
                        if (response) {
                            args.IsValid = !response;
                            source.errormessage = "AR Number must be unique per selling company.";
                        }
                        else {
                            source.errormessage = "";
                        }
                    },
                    error: function (request) {
                    }
                });
            }
        }
    }

</script>


