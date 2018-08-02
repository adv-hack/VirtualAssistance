<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CostCodeDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.CostCodeDetails" %>
<div class="row">
    <div class="col-md-6">
        <div class="row">
            <div class="col-md-12">
                <con:HiddenField runat="server" ID="CostCodeId" DataBoundValue="Id" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:TextField runat="server" DataBoundValue="Code" ID="Code" LabelText="Cost Code" Requirement="MandatoryEnforced" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:ListField runat="server" ID="SellingCompany" DataBoundValue="SelcoSpIdId" DataBoundText="SelcoSpIdId.Name" LabelText="Selling Company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:TextField runat="server" ID="Description" DataBoundValue="Desc" LabelText="Description" TextMode="MultiLine" Requirement="MandatoryEnforced" />
            </div>
        </div>
    </div>
</div>
<con:Validator runat="server" ClientValidationFunction="CheckIfCodeExist" ErrorMessage="" />
<script type="text/javascript">
    function CheckIfCodeExist(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'finance/costcode/CheckIfCodeExist?code=' + $('#<%= this.Code.ClientID %>Field').val() + '&sellingCompId=' + $('#<%= this.SellingCompany.ClientID %>Field').val() + '&costCodeId=' + $('#<%= this.CostCodeId.ClientID %>Field').val(),
            success: function (response) {
                if (response) {
                    args.IsValid = !response;

                    source.errormessage = "Cost Code must be unique per selling company ";
                }
                else {
                    source.errormessage = "";
                }
            },
            error: function (request) {
            }
        });
    }
    
</script>
