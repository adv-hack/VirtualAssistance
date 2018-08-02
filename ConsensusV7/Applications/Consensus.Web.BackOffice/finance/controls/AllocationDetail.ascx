<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AllocationDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.AllocationDetail" %>

<div class="row">
    <con:HiddenField runat="server" ID="AllocationID" DataBoundValue="Id" />
    <con:HiddenField runat="server" ID="Currency" DataBoundValue="CurrType" />
    <con:HiddenField runat="server" ID="Refund" />
    <div class="col-md-6">
        <con:PopupField runat="server" ID="PaymentId" DataBoundValue="PayIdId" DataBoundText="PayIdId" LabelText="Payment ID" PopupUrl="~/finance/popups/paymentsearch.aspx" HyperlinkUrl="~/finance/paymentpage.aspx?id={id}" Requirement="MandatoryEnforced" />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="UnusedValue" LabelText="Unused value" DataBoundValue="PayId.UnusedVal" IsReadOnly="TrueEnforced" />
    </div>
    <div class="col-md-6">
        <con:PopupField runat="server" ID="InvId" DataBoundValue="InvIdId" DataBoundText="InvId.Reference" LabelText="Invoice number" PopupUrl="~/finance/popups/invoicesearch.aspx" HyperlinkUrl="~/finance/invoicepage.aspx?id={id}" Requirement="MandatoryEnforced" />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="UnpaidValue" DataBoundValue="InvId.UnpaidValue" LabelText="Unpaid value" IsReadOnly="TrueEnforced" />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="Value" DataBoundValue="Value" LabelText="Allocation amount" Requirement="MandatoryEnforced">
            <Validators>
                <con:Validator runat="server" ClientValidationFunction="CheckIfValidAllocationAmount" Critical="true" ErrorMessage="This is not a valid number." />
            </Validators>
        </con:TextField>
    </div>

    <% if (this.AllocationType.Equals("invoice") || (this.AllocationType.Equals("payment")))
        { %>
    <con:HiddenField runat="server" ID="ReversesPaId" DataBoundValue="ReversesPaId" LabelText="ReversesPaId" />

    <div class="col-md-6">
        <con:HiddenField runat="server" ID="Type" LabelText=" Payment Type" />
    </div>
    <% }%>

   <con:HiddenField ID="ReverseButton" runat="server" />

</div>
<con:Validator runat="server" ClientValidationFunction="CheckAmountAgainstInvoiceAndPayment" ErrorMessage="" />
<script type="text/javascript">

    function CheckIfValidAllocationAmount(source, args) {
        var regExp = /^[+-]?([0-9]+(?:[\.][0-9]*)?|\.[0-9]+)$/;
        var amount = $('#<%= this.Value.ClientID %>Field').val();
        var isValid = regExp.test(amount);
        if (amount) {            
            if (!isValid) {
                args.IsValid = isValid;
                source.errormessage = "This is not a valid number.";
                source.textContent = "This is not a valid number.";                
            }
        }
        else {
            source.errormessage = "This is a required field.";
            source.textContent = "This is a required field.";
        }
        return isValid;
    }

    function CheckAmountAgainstInvoiceAndPayment(source, args) {
        args.IsValid = true;
        var unusedValue = $("#<%=this.UnusedValue.ClientID%>Field").val();
        var unpaidValue = $("#<%=this.UnpaidValue.ClientID%>Field").val();
        var amount = $("#<%=this.Value.ClientID%>Field").val();

        if (parseFloat(amount) == 0) {
            args.IsValid = false;
            source.errormessage = "Allocation amount cannot be 0.";
        }
        else if (parseFloat(amount) < 0) {
            args.IsValid = false;
            source.errormessage = "Allocation amount cannot be negative.";
        }
        else if (parseFloat(amount) > parseFloat(unpaidValue)) {
            args.IsValid = false;
            source.errormessage = "Amount to allocate is greater than unpaid invoice value.";
        }
        else {
            if (parseFloat(amount) > parseFloat(unusedValue)) {
                args.IsValid = false;
                source.errormessage = "Amount to allocate is greater than unused payment value.";
            }
        }
    }

</script>

