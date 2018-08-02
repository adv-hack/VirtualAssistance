<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactPersonDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.ContactPersonDetail" %>


<con:PopupField runat="server" ID="Contact" DataBoundValue="RoleId" DataBoundText="Role.PersonName" LabelText="Contact" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}">
    <Validators>
        <con:Validator runat="server" ClientValidationFunction="CheckIfContactIsNullForMainContact" Critical="true" ErrorMessage="The contact should not be blank because it is main contact." />
    </Validators>
    <Filters>
        <con:PopupFieldFilter ParameterName="org" Type="Control" Value="OrgName" />
    </Filters>
</con:PopupField>

<con:PopupField runat="server" ID="OrgName" DataBoundValue="OrganisationId" DataBoundText="Organisation.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" />

<con:HiddenField runat="server" ID="AddressId" DataBoundValue="AddressId" />
<con:TextField runat="server" ID="Address" LabelText="Address" DataBoundValue="Address.MailString" IsReadOnly="TrueEnforced" TextMode="MultiLine" CssClass="consensus-input noresize">
    <Addons>
        <con:AddOn Icon="search" ToolTip="Select Alternate Address" CssClass="consensus-edit-visible" ID="AddressSearch" />
    </Addons>
</con:TextField>

<con:HiddenField runat="server" ID="AvailableContacts" />
<con:HiddenField runat="server" ID="AccountId" DataBoundValue="AccountId" />
<con:HiddenField runat="server" ID="PersonId" />
<con:HiddenField runat="server" ID="RoleId" />
<con:HiddenField runat="server" ID="AccountXRefId" />
<con:HiddenField runat="server" ID="IsMainContactOnEdit" />
<con:HiddenField runat="server" ID="canNotSaveContact" />
<con:HiddenField runat="server" ID="IsEdit" />
<con:HiddenField runat="server" ID="OrganisationId" DataBoundValue="OrganisationId" />

<div class="row">
    <div class="col-md-4">
        <con:CheckField runat="server" DataBoundValue="Main" ID="MainContact" LabelText="Main contact" />
    </div>
    <div class="col-md-4">
        <con:CheckField runat="server" DataBoundValue="Invoice" ID="Invoice" LabelText="Invoice" />
    </div>
    <div class="col-md-4">
        <con:CheckField runat="server" DataBoundValue="Statement" ID="Statement" LabelText="Statement" />
    </div>
    <div class="col-md-4">
        <con:CheckField runat="server" DataBoundValue="MustUse" ID="MustUse" LabelText="Must use" />
    </div>
</div>
<con:Validator runat="server" ClientValidationFunction="CheckIfSameContactAlreadyExists" ErrorMessage="" />
<con:Validator runat="server" ClientValidationFunction="CheckIfSameOrganisationAlreadyExists" ErrorMessage="" />
<con:Validator runat="server" ClientValidationFunction="CheckIfContactOrOrganizationExists" ErrorMessage="" />
<script type="text/javascript">

    function CheckIfContactIsNullForMainContact(source, args) {
        args.IsValid = true;
        if ($('#<%= this.canNotSaveContact.ClientID %>Field').val() == "1" && $('#<%= this.MainContact.ClientID %>Field')[0].checked == true) {
            args.IsValid = false;
        }
        return args.IsValid;
    }



    function CheckIfSameContactAlreadyExists(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'finance/Accountxref/CheckIfSameContactAlreadyExists?accountId=' + $('#<%=this.AccountId.ClientID%>Field').val() + '&roleId=' + $('#<%=this.RoleId.ClientID%>Field').val() + '&accounteexrefid=' + $('#<%=this.AccountXRefId.ClientID%>Field').val(),
            success: function (response) {
                if (response) {
                    args.IsValid = !response;
                    source.errormessage = "This contact is already associated with the account.";
                }
                else {
                    source.errormessage = "";
                }
            },
            error: function (request) {

            }
        });
    }

    function CheckIfSameOrganisationAlreadyExists(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'finance/Accountxref/CheckIfSameOrganisationAlreadyExists?accountId=' + $('#<%=this.AccountId.ClientID%>Field').val() + '&personId=' + $('#<%=this.PersonId.ClientID%>Field').val() + '&orgId=' + $('#<%=this.OrganisationId.ClientID%>Field').val() + '&accounteexrefid=' + $('#<%=this.AccountXRefId.ClientID%>Field').val(),
            success: function (response) {
                if (response) {
                    args.IsValid = !response;
                    source.errormessage = "This Organisation is already associated with the account.";
                }
                else {
                    source.errormessage = "";
                }
            },
            error: function (request) {

            }
        });
    }

    function CheckIfContactOrOrganizationExists(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'finance/Accountxref/CheckIfContactOrOrganizationExists?orgId=' + $('#<%=this.OrganisationId.ClientID%>Field').val() + '&personid=' + $('#<%=this.PersonId.ClientID%>Field').val(),
            success: function (response) {
                if (response) {
                    args.IsValid = !response;
                    source.errormessage = "At least one of Organisation or Contact must be populated. ";
                }
                else {
                    source.errormessage = "";
                }
            },
            error: function (request) {

            }
        });
    }

    addressField = function () {
        var closure = this;
        this.opening = false;
        this._addressId = $('#' + '<%=this.AddressId.ClientID%>' + 'Field');
        this._orgId = $('#' + '<%=this.OrgName.ClientID%>' + 'Value');
        this._addmailstring = $('#' + '<%=this.Address.ClientID%>' + ' textarea');
        this._updateIcon = function (icon) {
            closure._addmailstring.next('.input-group-addon').find('.glyphicon')
                .removeClass(function (index, className) {
                    return (className.match(/(^|\s)glyphicon-\S+/g) || []).join(' ');
                }).addClass(icon);
        };
        this.setAddress = function (addId, addmailstring) {
            this._addmailstring.val(addmailstring).attr('readonly', 'readonly');
            this._addressId.val(addId);
        };
        this.openPopup = function () {
            if (closure._orgId.val()) {
                closure._opening = true;
                closure._updateIcon('glyphicon-repeat glyphicon-spin');
                consensus.web.popupFrame({
                    url: consensus.resolveUrl('~/genericpopup.aspx?context=crm&control=addresslist&type=altbutton&width=1200&select=1&orgId=' + closure._orgId.val()),
                    open: function () {
                        closure._updateIcon('glyphicon-search');
                        closure._opening = false;
                    },
                    result: function (result) {
                        closure.setAddress(result.data.id, result.data.mailstring);
                    }
                });
            }
            else {
                window.top.swal.call(window.top, { title: 'Warning', text: 'You have not selected an organisation.', type: 'warning', showCancelButton: false, confirmButtonText: 'Ok', confirmButtonClass: 'btn btn-danger', buttonsStyling: false }).then(function (success) {
                });
            }
        };
        this._addmailstring.next('.input-group-addon').on('click', function () {
            if (!closure._opening)
                closure.openPopup();
        });
    };

</script>
