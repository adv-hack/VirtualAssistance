<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.ResetPassword" %>
<div class="row">
    <div class="col-md-12">
        <con:TextField runat="server" ID="NewPassword" DataBoundValue="NewPassword" LabelText="New password" Requirement="MandatoryEnforced" ClientOnChange="clearConfirmField();" />
    </div>
    <div class="col-md-12">
        <con:TextField runat="server" ID="ConfirmPassword" LabelText="Confirm password">
            <Validators>
                <con:Validator runat="server" ClientValidationFunction="validatePasswordMatch" Critical="true" ErrorMessage="Passwords do not match" />
            </Validators>
        </con:TextField>
    </div>
</div>
<script>

    function clearConfirmField() {
        $('#' + '<%=this.ConfirmPassword.ClientID%>' + 'Field').val('');

    }

</script>
