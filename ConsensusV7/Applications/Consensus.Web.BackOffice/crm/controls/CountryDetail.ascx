<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CountryDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.CountryDetail" %>

<div class="row">
    <div class="col-md-6">
        <div class="row">
            <div class="col-md-12">
                <con:HiddenField runat="server" ID="CountryId" DataBoundValue="Id" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:TextField runat="server" DataBoundValue="Name" ID="Name" LabelText="Name" Requirement="MandatoryEnforced" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:TextField runat="server" DataBoundValue="CountryCode" ID="Code" LabelText="Code" Requirement="MandatoryEnforced" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:CodeField runat="server" ID="Language" DataBoundValue="Language" LabelText="Language" CodeType="LANG" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:ListField runat="server" ID="Currency" DataBoundValue="Currency" ValueMember="Currency" LabelText="Currency" DisplayMember="Currency" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:ListField runat="server" ID="Format" DataBoundValue="Format" ValueMember="Format" LabelText="Address Label Format" DisplayMember="Format" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:CodeField runat="server" ID="VatCode" DataBoundValue="VatCode" LabelText="VAT Code" CodeType="VATCD" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:CheckField runat="server" ID="PcodeLu" DataBoundValue="PcodeLu" LabelText="Post Code Lookup" />
            </div>
        </div>
    </div>
</div>
<con:Validator runat="server" ClientValidationFunction="CheckIfCountryOrCodeExist" ErrorMessage="" />

<script type="text/javascript">
    function CheckIfCountryOrCodeExist(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'contact/country/CheckIfCountryOrCodeExist?name=' + $('#<%= this.Name.ClientID %>Field').val() + '&code=' + $('#<%= this.Code.ClientID %>Field').val() + '&countryId=' + $('#<%= this.CountryId.ClientID %>Field').val(),
            success: function (response) {
                if (response.name || response.code) {
                    args.IsValid = !response.name && !response.code;
                    if (response.name && response.code) {
                        source.errormessage = "Country name and code already exists.";
                    }
                    else if (response.name) {
                        source.errormessage = "Country name already exists.";
                    }
                    else if (response.code) {
                        source.errormessage = "Code already exists.";
                    }
                    else {
                        source.errormessage = "";
                    }
                }
            },
            error: function (request) {
            }
        });
    }
</script>
