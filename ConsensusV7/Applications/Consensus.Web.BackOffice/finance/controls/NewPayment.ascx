<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewPayment.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.NewPayment" %>
<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Payment details">
            <div class="row">
                <div class="col-md-6"><con:DateField runat="server" ID="Date" DataBoundValue="Date" LabelText="Date" /></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="PaymentType" DataBoundValue="TypeCode" LabelText="Payment Type" CodeType="PYPAY" Requirement="MandatoryEnforced" /></div>
            </div>
            
            <div class="row">
                <div class="col-md-6">
                    <con:ListField runat="server" ID="Currency" DataBoundValue="Currency" LabelText="Currency" DisplayMember="Code" ValueMember="Code" Requirement="MandatoryEnforced">
                        <Attributes>
                            <con:ListAttribute runat="server" Name="conversion" Value="ConversionFactor" />
                            <con:ListAttribute runat="server" Name="startdate" Value="StartDate" />
                            <con:ListAttribute runat="server" Name="enddate" Value="EndDate" />
                        </Attributes>
                    </con:ListField>
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="MaxRefundAmt" LabelText="Max Refund Amount" IsReadOnly="TrueEnforced" IsHidden="True" />
                    <con:TextField runat="server" ID="PaymentAmount" DataBoundValue="Amount" LabelText="Payment Value" Requirement="MandatoryEnforced" />
                </div>
            </div>

            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="BankCharges" DataBoundValue="BankCharges" LabelText="Bank Charges" TextMode="Number" /></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="Status" DataBoundValue="StatusCode" LabelText="Status" CodeType="PAYST" Requirement="MandatoryEnforced" /></div>

            </div>

            <div class="row">
                <div class="col-md-6"><con:ListField runat="server" ID="SellingCompany" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling Company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>
            </div>

            <con:HiddenField runat="server" ID="RefundId" DataBoundValue="RefundId" />
            <con:TextField runat="server" ID="Conversion" DataBoundValue="ConversionRate" LabelText="Conversion" IsHidden="TrueEnforced" Requirement="MandatoryEnforced" />
            <con:TextField runat="server" ID="PaymentBC" DataBoundValue="AmountBC" LabelText="Payment BC" IsHidden="TrueEnforced" IsReadOnly="True" />
        </con:GroupBox>
    </div>
 
    
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Payer information">
            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="Person" DataBoundValue="CardholderRoleId" DataBoundText="CardholderRole.PersonName" LabelText="Payer" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" Requirement="MandatoryEnforced">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="org" Type="Control" Value="Organisation" />
                        </Filters>
                    </con:PopupField>
                </div>
                <div class="col-md-6"><con:PopupField runat="server" ID="Organisation" DataBoundValue="OrganisationId" DataBoundText="Organisation.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" /></div>
            </div>
            
            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="Account" DataBoundValue="AccountId" DataBoundText="Account.ARNumber" LabelText="AR number" PopupUrl="~/finance/popups/accountsearch.aspx" HyperlinkUrl="~/finance/accountpage.aspx?id={id}">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="org" Type="Control" Value="Organisation" />
                            <con:PopupFieldFilter ParameterName="person" Type="Control" Value="Person" />
                        </Filters>
                    </con:PopupField>
                </div>
            </div>
        </con:GroupBox>


        <con:GroupBox runat="server" Title="Payment information">


            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="PayRef" DataBoundValue="Reference" LabelText="Payment Reference" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="BankingRef" DataBoundValue="BankingReference" LabelText="Banking Reference" />
                </div>
            </div>

            <br /><br />
        </con:GroupBox>
    </div>
    <div class="col-md-12" style="padding-top: 20px;">
        <con:GroupBox runat="server" Title="Additional information" ID="AdditionalDetailGroup">
            <div class="row">
                <div class="col">
                    <con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name" />
                </div>
                <div class="col">
                    <con:TextField runat="server" ID="AccountNo" DataBoundValue="AccountNo" LabelText="Account Number" TextMode="Number" />
                </div>
                <div class="col">
                    <con:TextField runat="server" ID="SortCode" DataBoundValue="SortCode" LabelText="Sort Code" Requirement="MandatoryEnforced" />
                </div>
                <div class="col">
                    <con:TextField runat="server" ID="ApprovalReference" DataBoundValue="ApprovalReference" LabelText="Authorisation Code" Style="width: 30%;"  />
                </div>
                <div class="col">
                    <con:TextField runat="server" ID="ChequeNo" DataBoundValue="ChequeNo" LabelText="Cheque Number" TextMode="Number" />
                </div>
            </div>
        </con:GroupBox>
    </div>
    <con:HiddenField runat="server" ID="InvoiceId" DataBoundValue="InvoiceId" />
    <con:HiddenField runat="server" ID="MemberPeriodId" DataBoundValue="MemberPeriodId" />
    <con:HiddenField runat="server" ID="BookingId" DataBoundValue="BookingId" />
    <con:HiddenField runat="server" ID="AddressId" DataBoundValue="AddressId" />    
</div>
<asp:CustomValidator runat="server" ClientValidationFunction="validateRefundAmount" Display="None" EnableClientScript="true" ErrorMessage="" />
<script type="text/javascript">
    var payment = {
        loader: 'One moment...',
        configuration: {
            SC_USE_WORLDPAY_AUTH: null,
            SC_DATACASH: null
        },
        controls: {
            paymentType: $('#<%= this.PaymentType.ClientID %>Field'),
            paymentStatus: $('#<%= this.Status.ClientID %>Field'),
            currency: $('#<%= this.Currency.ClientID %>Field'),
            amount: $('#<%= this.PaymentAmount.ClientID %>Field'),
            amountBC: $('#<%= this.PaymentBC.ClientID %>Field'),
            conversion: $('#<%= this.Conversion.ClientID %>Field'),
            sellingCompany: $('#<%= this.SellingCompany.ClientID %>Field'),
            additionalDetailGroup: $('#<%= this.AdditionalDetailGroup.ClientID %>'),
            additionalDetailName: $('#<%= this.Name.ClientID %>'),
            additionalDetailAccount: $('#<%= this.AccountNo.ClientID %>'),
            additionalDetailSort: $('#<%= this.SortCode.ClientID %>'),
            additionalDetailCheque: $('#<%= this.ChequeNo.ClientID %>'),
            additionalDetailApproval: $('#<%= this.ApprovalReference.ClientID %>')

        },
        functions: {
            toggleFields: function () {
                var sellingCompany = payment.controls.sellingCompany.val();
                if (sellingCompany && sellingCompany.length != 0 && !payment.functions.hasConfiguration()) {
                    payment.functions.loadConfigurations();
                    return;
                }
                var useVirtualTerminal = payment.functions.useVirtualTerminal();
                var paymentType = payment.controls.paymentType.val().length > 2 ? parseInt(payment.controls.paymentType.val().substring(0, 2)) : -1;
                payment.functions.toggleField(payment.controls.additionalDetailGroup, (paymentType === 2 && !useVirtualTerminal) || paymentType === 4 || paymentType === 6 || paymentType === 7);
                payment.functions.toggleField(payment.controls.additionalDetailName, paymentType === 4 || paymentType === 6 || paymentType === 7, true);
                payment.functions.toggleField(payment.controls.additionalDetailSort, paymentType === 4 || paymentType === 6, true);
                payment.functions.toggleField(payment.controls.additionalDetailAccount, paymentType === 4 || paymentType === 6, true);
                payment.functions.toggleField(payment.controls.additionalDetailCheque, paymentType === 4 || paymentType === 7, true);
                payment.functions.toggleField(payment.controls.additionalDetailApproval, paymentType === 2 && !useVirtualTerminal, true);
            },
            toggleField: function (control, visible, mandatory) {
                control.toggle(visible).parent('.col').toggle(visible);
                if (typeof (window.ValidatorValidate) === 'function' && typeof (window.Page_Validators) != 'undefined') {
                    validator = jQuery.grep(window.Page_Validators, function (element) { return element.controltovalidate === control.attr('id') + 'Field' || element.controltovalidate === control.attr('id') + 'Value'; });
                    if (validator.length != 0) {
                        validator[0].enabled = visible && mandatory;
                        validator[0].isvalid = true;
                        window.ValidatorUpdateDisplay(validator[0]);
                    }
                }
            },
            hasConfiguration: function () {
                var result = true;
                for (var name in payment.configuration)
                    result = result && (payment.configuration[name] !== null && payment.configuration[name] !== '');
                return result;
            },
            loadConfigurations: function () {
                for (var name in payment.configuration)
                    if (payment.configuration[name] === null)
                        payment.functions.loadConfiguration(name)
            },
            loadConfiguration: function (name) {
                var sellingCompany = payment.controls.sellingCompany.val();
                if (!sellingCompany || sellingCompany.length === 0)
                    return;
                payment.configuration[name] = '';
                consensus.network.send({
                    url: '/common/sellingcompany/' + sellingCompany + '/getconfiguration',
                    data: { name: name, defaultValue: false },
                    method: 'post',
                    success: function (value) {
                        payment.configuration[name] = value;
                        payment.functions.toggleFields();
                        if (payment.functions.hasConfiguration() && typeof (payment.functions.onLoadConfiguration) === 'function')
                            payment.functions.onLoadConfiguration();
                    }
                });
            },
            clearConfiguration: function () {
                for (var name in payment.configuration)
                    payment.configuration[name] = null;
            },
            useVirtualTerminal: function () {
                var result = false;
                var sellingCompany = payment.controls.sellingCompany.val();
                if (sellingCompany && sellingCompany.length != 0) {
                    for (var name in payment.configuration)
                        result = result || (payment.configuration[name] === true);

                    var paymentType = payment.controls.paymentType.val().length > 2 ? parseInt(payment.controls.paymentType.val().substring(0, 2)) : -1;
                    result = result && paymentType === 2;
                }
                return result;
            },
            populateCurrency: function () {
                var sellingCompany = payment.controls.sellingCompany.val();
                var currencyValue = payment.controls.currency.val();
                if (!sellingCompany || sellingCompany.length === 0)
                    return;
                $('<option />').attr('selected', 'selected').text(payment.loader).appendTo(payment.controls.currency.attr('disabled', 'disabled'));
                consensus.network.send({
                    method: 'post',
                    url: 'finance/currency/FetchAllBySellingCompanyId',
                    data: {
                        sellingCompanyId: sellingCompany,
                        serialization: {
                            Include: {
                                "Finance.Currency": ["ConversionFactor", "StartDate", "Code", "EndDate"]
                            }
                        }
                    },
                    success: function (result) {
                        var today = new Date();
                        today.setHours(0, 0, 0, 0);
                        result = jQuery.grep(result, function (element) { return (!element.StartDate || element.StartDate <= today) && (!element.EndDate || element.EndDate >= today); });
                        payment.controls.currency.attr('disabled', null).find('option').remove();
                        for (var i = 0; i < result.length; i++)
                            $('<option />')
                                .attr('data-conversion', result[i].ConversionFactor)
                                .attr('data-enddate', result[i].EndDate)
                                .attr('data-startdate', result[i].StartDate)
                                .attr('selected', result[i].Code === currencyValue ? 'selected' : null)
                                .attr('value', result[i].Code)
                                .text(result[i].Code)
                                .appendTo(payment.controls.currency);
                        payment.functions.populateConversion();
                    }
                });
            },
            populateConversion: function () {
                var currency = payment.controls.currency.find('option[value="' + payment.controls.currency.val() + '"]');
                var conversion = parseFloat(currency.attr('data-conversion'));
                var amount = parseFloat(payment.controls.amount.val());
                if (payment.controls.amount.is(":hidden")) {
                    amount = parseFloat(payment.controls.refundAmount.val());
                }
                conversion = isNaN(conversion) ? 1 : conversion;
                amount = isNaN(amount) ? 0 : (amount / conversion);
                payment.controls.amountBC.val(amount.toFixed(2));
                payment.controls.conversion.val(conversion.toFixed(2));

            },
            onLoadConfiguration: null,
            updateConversion: function () {
                var currency = payment.controls.currency.find('option[value="' + payment.controls.currency.val() + '"]');
                if (parseFloat(payment.controls.conversion.val()) == 0 || isNaN(payment.controls.conversion.val())) {
                    payment.controls.conversion.val("1");                    
                }
                currency.attr('data-conversion', payment.controls.conversion.val());
                payment.functions.populateConversion();
            }
        }
    };
    $(document).ready(function () {
        payment.functions.toggleFields();
        if (!$('#<%=this.MaxRefundAmt.ClientID%>').is(":hidden")) {
            payment.functions.updateConversion();
        }
    })

    function validateRefundAmount(source, arguments) {
        //Sets Refund Id
        let params = new URLSearchParams(location.search.slice(1));
        $('#<%=this.RefundId.ClientID%>Field').val(params.get("payId"));

        //Checks whether PaymentAmount is greater than 0
        var refundAmount = $('#<%= this.PaymentAmount.ClientID %>Field').val();
        var regExp = /^[+]?([0-9]+(?:[\.][0-9]*)?|\.[0-9]+)$/;

        if (!$('#<%=this.MaxRefundAmt.ClientID%>').is(":hidden")) {
            var maximumAmount = $('#<%= this.MaxRefundAmt.ClientID %>Field').val();            
            
            if (!regExp.test(refundAmount)) {
                arguments.IsValid = false;
                source.errormessage = "Refund amount is not a valid number.";
            }
            else {
                arguments.IsValid = parseFloat(maximumAmount) >= parseFloat(refundAmount);
                if (!arguments.IsValid)
                    source.errormessage = "Refund amount cannot exceed maximum unallocated value.";
                else {
                    if (parseFloat(refundAmount) == 0) {
                        source.errormessage = "You cannot refund 0.00";
                        arguments.IsValid = false;
                    }
                }
            }
        }
        else {
            if (!regExp.test(refundAmount)) {
                arguments.IsValid = false;
                source.errormessage = "Payment value is not a valid number.";
            }
            else {
                if (parseFloat(refundAmount) == 0) {
                    source.errormessage = "You cannot take a payment of 0.00";
                    arguments.IsValid = false;
                }
                else {
                    arguments.IsValid = true;
                }
            }
        }
    }

</script>
