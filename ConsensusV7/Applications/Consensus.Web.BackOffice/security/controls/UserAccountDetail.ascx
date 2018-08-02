<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserAccountDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.security.controls.UserAccountDetail" %>
<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Person Details">
            <con:HiddenField runat="server" ID="UserAccountId" DataBoundValue="Id" />
            <con:PopupField runat="server" ID="Person" LabelText="Person" DataBoundValue="PersonId" IsReadOnly="FalseEnforced" Requirement="MandatoryEnforced" HyperlinkUrl="~/crm/person?id={id}" DataBoundText="Person.FullName" PopupUrl="~/crm/popups/PersonSearch.aspx" />
            <con:PopupField runat="server" ID="Organisation" LabelText="Organisation" DataBoundValue="Person.PrincipalRole.OrganisationId" IsReadOnly="TrueEnforced" HyperlinkUrl="~/crm/organisation?id={id}" DataBoundText="Person.PrincipalRole.Organisation.Name" PopupUrl="~/crm/popups/OrganisationSearch.aspx" />
            <con:TextField runat="server" ID="Address" LabelText="Address" DataBoundValue="Person.PrincipalRole.Address.MailString" IsReadOnly="TrueEnforced" TextMode="MultiLine" CssClass="consensus-input noresize" />
            <con:TextField runat="server" ID="Phone" LabelText="Telephone" DataBoundValue="Person.PrincipalRole.Telephone" IsReadOnly="TrueEnforced" TextMode="Phone" HyperlinkUrl="tel:{text}" />
            <con:TextField runat="server" ID="Email" LabelText="Email" DataBoundValue="Person.PrincipalRole.Email" IsReadOnly="TrueEnforced" TextMode="Email" HyperlinkUrl="mailto:{text}" />
        </con:GroupBox>
    </div>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Login Details">
            <con:TextField runat="server" ID="Username" DataBoundValue="Username" LabelText="Username" IsReadOnly="FalseEnforced" Requirement="MandatoryEnforced" />
            <con:TextField runat="server" ID="Password" DataBoundValue="Password" LabelText="Password" IsReadOnly="FalseEnforced" Requirement="MandatoryEnforced" TextMode="Password">
                <Addons>
                    <con:AddOn Icon="unlock_2" ToolTip="Generate Secure Password" OnClick="generatePassword();" />
                </Addons>
            </con:TextField>
            <div class="row">
                <div class="col-md-6">
                    <con:ListField runat="server" ID="SellingCompany" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" ValueMember="Id" LabelText="Selling Company" IsReadOnly="FalseEnforced" Requirement="MandatoryEnforced" DisplayMember="Name" />
                </div>
                <div class="col-md-6">
                    <con:ListField runat="server" ID="LicenceType" DataBoundValue="LicenseType" LabelText="Licence type" ValueMember="Key" DisplayMember="Value" Requirement="MandatoryEnforced" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="LastLogin" LabelText="Last Logged On" IsReadOnly="TrueEnforced" TextMode="DateTime" />
                </div>
                <div class="col-md-6">
                    <con:CheckField runat="server" ID="UserBarred" LabelText="Account Status" OffColour="danger" OffText="Barred" OnColour="success" OnText="Active" />
                    <con:HiddenField runat="server" ID="Barred" DataBoundValue="Status" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:CheckField runat="server" ID="SysAdmin" DataBoundValue="SysAdmin" LabelText="System Administrator" IsReadOnly="False" />
                </div>                
            </div>
            <div class="row">
                <div class="col-md-12">
                    <con:PopupField runat="server" ID="Report" LabelText="Home page dashboard" DataBoundValue="ReportIdId" DataBoundText="ReportId.Name" PopupUrl="~/security/popups/reportsearch.aspx" />
                </div>
            </div>
        </con:GroupBox>
    </div>
</div>

<con:Validator runat="server" ClientValidationFunction="UpdateStatus" ErrorMessage="" />
<script type="text/javascript">

    function generateString(range, length) {
        var result = '';
        for (var i = 0; i < length; i++)
            result += range.substr(Math.floor(Math.random() * range.length), 1);
        return result;
    }
    function generatePassword() {

        // Generate password with 2 numbers, 2 uppercase characters and 2 lowercase characters then append any alphanumeric characters until password is 16-characters long.
        var password = generateString('0123456789', 2) + generateString('ABCDEFGHIJKLMNOPQRSTUVWXYZ', 2) + generateString('abcdefghijklmnopqrstuvwxyz', 2);
        password += generateString('0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz', 16 - password.length);

        // Randomly shuffle the characters
        var array = password.split('');
        var index = array.length;
        var temp, rand;
        while (index !== 0) {
            rand = Math.floor(Math.random() * index);
            temp = array[rand];
            index -= 1;
            array[rand] = array[index];
            array[index] = temp;
        }

        // Update the password field
        $('#<%= this.Password.ClientID %>Field').attr('type', 'text').val(array.join(''));
    }

    function UpdateStatus(source, args) {
        if ($('#<%= this.UserBarred.ClientID %>Field').is(':checked')) {
            $('#<%= this.Barred.ClientID %>Field').val(1);
        }
        else {
            $('#<%= this.Barred.ClientID %>Field').val(0);
        }
        CheckIfUsernameExist(source, args);        
    }

    function CheckIfUsernameExist(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'security/useraccount/CheckIfUsernameExist?username=' + $('#<%= this.Username.ClientID %>Field').val() + '&userId=' + $('#<%= this.UserAccountId.ClientID %>Field').val(),
            success: function (response) {
                if (response) {
                    args.IsValid = !response;
                    source.errormessage = "Username already exists.";
                }
                else {
                    source.errormessage = "";
                    CheckPoolBUserAllowed(source, args);
                }
            },
            error: function (request) {
            }
        });
    }

    function CheckPoolBUserAllowed(source, args) {
        //Checks if user account is active and License type is Pool B
        if ($('#<%= this.UserBarred.ClientID %>Field').is(':checked')) {
            if ($('#<%= this.LicenceType.ClientID %>Field :selected').val() == "1") {
                consensus.network.send({
                    async: false,
                    method: 'post',
                    url: 'security/useraccount/CheckPoolBUserAllowed?userAccountId=' + $('#<%= this.UserAccountId.ClientID %>Field').val() + '&licenseType=' + $('#<%= this.LicenceType.ClientID %>Field').val() + '&status=' + $('#<%= this.Barred.ClientID %>Field').val(),
                    success: function (response) {
                        args.IsValid = true;
                        if (!response) {
                            args.IsValid = false;
                            source.errormessage = "You do not have enough licences to create this account. Please deactivate a user account in this licence pool to allow this user account to be added.";
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
