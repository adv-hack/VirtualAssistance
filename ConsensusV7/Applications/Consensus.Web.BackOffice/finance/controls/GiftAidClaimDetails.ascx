<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GiftAidClaimDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.GiftAidClaimDetails" %>

<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Claim details">
            <div class="row">
              <div class="col-md-12"><con:TextField runat="server" ID="claimId" DataBoundValue="Id" LabelText="Claim ID" IsReadOnly="True" /></div>
          </div>
            <div class="row">
              <div class="col-md-12"><con:DateField runat="server" ID="claimDate" DataBoundValue="ClaimDate" LabelText="Claim date" Requirement="MandatoryEnforced" /></div>
          </div>
          <div class="row">
             <div class="col-md-6"><con:DateField runat="server" ID="donationsFrom"  LabelText="Donations from" Requirement="MandatoryEnforced" /></div>
             <div class="col-md-6"><con:DateField runat="server" ID="donationsTo"  LabelText="Donations to" Requirement="MandatoryEnforced" >
                 <Validators>
                    <con:Validator runat="server" ClientValidationFunction="validateDates" Critical="true" ErrorMessage="The date must be after the 'Donations From' date." />
                </Validators>
            </con:DateField>
             </div>              
          </div>
            <div class="row">
            <div class="col-md-6"><con:ListField runat="server" ID="SellingCompany" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>
        </div>
        </con:GroupBox>

        <con:GroupBox runat="server" Title="Submitter">
            <div class="row">
                <div class="col-md-6"><con:PopupField runat="server" ID="submitter" DataBoundValue="SubmitterId" DataBoundText="Submitter.PersonName" LabelText="Submitter" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" Requirement="MandatoryEnforced" /></div>
                <div class="col-md-6"><con:PopupField runat="server" ID="trustee" DataBoundValue="TrusteeId" DataBoundText="Trustee.PersonName" LabelText="Trustee" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" Requirement="MandatoryEnforced" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:DateField runat="server" ID="AccountingPeriodEnd" LabelText="Account period end" Requirement="MandatoryEnforced" /></div>              
            </div>
        </con:GroupBox>
    </div>

    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Claim information">
            <div class="row">
                <div class="col-md-6"><con:PopupField runat="server" ID="org" DataBoundValue="OrganisationId" DataBoundText="Organisation.Name" LabelText="Organisation Name" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" Requirement="MandatoryEnforced" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="hmrcRef" DataBoundValue="HmrcReference" LabelText="HMRC reference" Requirement="MandatoryEnforced" MaximumLength="50" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="regulatorName" DataBoundValue="RegulatorName" LabelText="Regulator name" MaximumLength="200" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="regulatorNum" DataBoundValue="RegulatorNumber" LabelText="Regulator number" MaximumLength="20" /></div>
            </div>
            <div class="row">
                <div class="col-md-4"><con:TextField TextMode="Number" runat="server" ID="adjustment" DataBoundValue="Adjustment" LabelText="Adjustment" >
                    <Validators>
                        <con:Validator runat="server" ClientValidationFunction="validateDecimal" Critical="true" ErrorMessage="" />
                    </Validators>
                </con:TextField></div>
                <div class="col-md-4"><con:CheckField runat="server" ID="process" DataBoundValue="Process" LabelText="Process" FieldValue="false" /></div>
            </div>
        </con:GroupBox>

    </div>

    <con:HiddenField runat="server" ID="datedonationFrm" DataBoundValue="DonationsFrom" />
    <con:HiddenField runat="server" ID="datedonationTo" DataBoundValue="DonationsTo" />
    <%--<con:HiddenField runat="server" ID="dateClaim" DataBoundValue="ClaimDate" />--%>
    <con:HiddenField runat="server" ID="dateAccPerEnd" DataBoundValue="AccountingPeriodEnd" /> 
</div>

<con:Validator runat="server" ClientValidationFunction="ValidateBinding" ErrorMessage="" />
<script type="text/javascript">
    <%--$(document).ready(function () {
        $('#<%= this.donationsFrom.ClientID %>Field').val('');
        $('#<%= this.donationsTo.ClientID %>Field').val('');
    });--%>
    function validateDates(source, arguments)
    {
        var fromDate = new Date($('#<%= this.donationsFrom.ClientID %>Field').val());
        var toDate = new Date($('#<%= this.donationsTo.ClientID %>Field').val());
        if(fromDate)
        arguments.IsValid = (toDate >= fromDate);
    }

    function validateDecimal(source, arguments)
    {
        var num = parseFloat($('#<%= this.adjustment.ClientID %>Field').val());
        var num = num.toFixed(2);
        if (isNaN(num)) {
            num = '';
        }
        $('#<%= this.adjustment.ClientID %>Field').val(num);
    }

    function ValidateBinding(source, arguments)
    {
        $('#<%= this.datedonationFrm.ClientID %>Field').val($('#<%= this.donationsFrom.ClientID %>Field').val());
        $('#<%= this.datedonationTo.ClientID %>Field').val($('#<%= this.donationsTo.ClientID %>Field').val());
       <%-- //$('#<%= this.dateClaim.ClientID %>Field').val($('#<%= this.claimDate.ClientID %>Field').val());--%>
        $('#<%= this.dateAccPerEnd.ClientID %>Field').val($('#<%= this.AccountingPeriodEnd.ClientID %>Field').val());
   
    }

     function OnSave(state, result, callback) {
            var hasId = typeof (state.source.Id) != 'undefined' && state.source.Id != null && state.source.Id.length != 0 && state.source.Id.toString() != '0';
            state.toggleSave(null);
            state.object = jQuery.extend(true, {}, result);
            state.updateScreen();
            state.toggleScreen(false);
            if (window.top.consensus == window.consensus && !hasId)
                window.location = window.location.toString() + (window.location.toString().indexOf('?') == -1 ? '?' : '&') + 'id=' + result.Id;
            else
                window.location.reload();
        }

        consensus.data.onsave = OnSave;
</script>