<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ICalendarTemplateDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.document.controls.ICalendarTemplateDetail" %>

<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Template details">
            <con:HiddenField runat="server" ID="ICalMessageId" DataBoundValue="Id" />
            <con:ListField runat="server" ID="Type" DataBoundValue="ICalMessageTypeId" LabelText="Type" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" ClientOnChange="GetMergeFields()" />
            <con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced" ClientOnChange="NameChanged()" />
            <con:ListField runat="server" ID="Appointments" DataBoundValue="Method" LabelText="Create appointments for" ValueMember="Value" DisplayMember="Key" Requirement="MandatoryEnforced" />
            <con:ListField runat="server" ID="SellingCompany" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" />
            <con:CheckField runat="server" ID="Current" DataBoundValue="Current" LabelText="Current" />
        </con:GroupBox>
    </div>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Message content">
            <con:ListField runat="server" ID="SubjectMerge" LabelText="Subject merge fields" ClientOnChange="SubjectMergeFieldChanged()" />
            <con:TextField runat="server" ID="Subject" DataBoundValue="Subject" LabelText="Subject" TextMode="MultiLine" MaximumLength="256" />
            <con:ListField runat="server" ID="AllMergeFields" IsHidden="TrueEnforced" />
            <con:ListField runat="server" ID="LocationMerge" LabelText="Location merge fields" ClientOnChange="LocationMergeFieldChanged()" />
            <con:TextField runat="server" ID="Location" DataBoundValue="Location" LabelText="Location" TextMode="MultiLine" MaximumLength="256" />
            <con:ListField runat="server" ID="BodyMerge" LabelText="Body merge fields" ClientOnChange="BodyMergeFieldChanged()" />
            <con:TextField runat="server" ID="Body" DataBoundValue="Text" LabelText="Body" TextMode="MultiLine" />
        </con:GroupBox>
    </div>
</div>

<con:Validator runat="server" ClientValidationFunction="CheckIfNameExist" ErrorMessage="" />

<script type="text/javascript">

    function SetMaxLength() {
        $('#<%= this.Subject.ClientID %>Field').attr('maxlength', 256);
        $('#<%= this.Subject.ClientID %>Field').attr('rows', 5);
        $('#<%= this.Location.ClientID %>Field').attr('maxlength', 256);
        $('#<%= this.Location.ClientID %>Field').attr('rows', 5);
    }

    $(document).ready(function () {
        SetMaxLength();
    });

    function CheckIfNameExist(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'document/icalmessage/CheckIfNameExist?name=' + $('#<%= this.Name.ClientID %>Field').val() + '&iCalMessageId=' + $('#<%= this.ICalMessageId.ClientID %>Field').val(),
            success: function (response) {
                if (response) {
                    args.IsValid = !response;
                    source.errormessage = "Name must be unique.";
                }
                else {
                    source.errormessage = "";
                }
            },
            error: function (request) {
            }
        });
    }

    function GetMergeFields() {
        $('#<%= this.SubjectMerge.ClientID %>Field').empty();
        $('#<%= this.LocationMerge.ClientID %>Field').empty();
        $('#<%= this.BodyMerge.ClientID %>Field').empty();

        var selectedType = $('#<%= this.Type.ClientID %>Field').val();

        var allMergeFields = document.getElementById("<%= this.AllMergeFields.ClientID %>Field").options;
        var addBlankEntry = true;

        for (var i = 0; i < allMergeFields.length; i++) {
            if (allMergeFields[i].text) {
                var value = allMergeFields[i].text.split("[")[1].split(",");
                var typeValue = value[1].split("]")[0].trim();

                //Adds merge fields depending on selected type
                if (typeValue == selectedType) {

                    //Inserts empty value for first time                    
                    if (addBlankEntry) {
                        $('#<%= this.SubjectMerge.ClientID %>Field').append('<option value="' + '' + '">' + '' + '</option>');
                        $('#<%= this.LocationMerge.ClientID %>Field').append('<option value="' + '' + '">' + '' + '</option>');
                        $('#<%= this.BodyMerge.ClientID %>Field').append('<option value="' + '' + '">' + '' + '</option>');
                    }
                    addBlankEntry = false;

                    $('#<%= this.SubjectMerge.ClientID %>Field').append('<option value="' + value[0] + '">' + value[0] + '</option>');
                    $('#<%= this.LocationMerge.ClientID %>Field').append('<option value="' + value[0] + '">' + value[0] + '</option>');
                    $('#<%= this.BodyMerge.ClientID %>Field').append('<option value="' + value[0] + '">' + value[0] + '</option>');
                }
            }
        }
    }

    function NameChanged() {
        var iCalMessageId = $('#<%= this.ICalMessageId.ClientID %>Field').val();
        if (parseInt(iCalMessageId) === 0) {
            var subject = $('#<%= this.Subject.ClientID %>Field').val();
            if (!subject) {
                $('#<%= this.Subject.ClientID %>Field').val($('#<%= this.Name.ClientID %>Field').val());
            }
        }
    }

    function InsertText(originalField, mergedField, isMaxLengthCheck) {
        var cursorPos = originalField.prop('selectionStart');
        var value = originalField.val();
        var textBefore = value.substring(0, cursorPos);
        var textAfter = value.substring(cursorPos, value.length);

        var finalValue = textBefore + "[[" + mergedField.val() + "]]" + textAfter;
        var canUpdate = true;

        if (isMaxLengthCheck && finalValue.length > 256) {
            canUpdate = false;
        }

        if (canUpdate) {
            originalField.val(textBefore + "[[" + mergedField.val() + "]]" + textAfter);
            originalField.focus();
        }
    }

    function SubjectMergeFieldChanged() {
        var originalField = $('#<%= this.Subject.ClientID %>Field');
        if (originalField.val().length < 256) {
            InsertText(originalField, $('#<%= this.SubjectMerge.ClientID %>Field'), true);
        }
        $('#<%= this.SubjectMerge.ClientID %>Field').val("");
    }

    function LocationMergeFieldChanged() {
        var originalField = $('#<%= this.Location.ClientID %>Field');
        if (originalField.val().length < 256) {
            InsertText(originalField, $('#<%= this.LocationMerge.ClientID %>Field'), true);
        }
        $('#<%= this.LocationMerge.ClientID %>Field').val("");
    }

    function BodyMergeFieldChanged() {
        InsertText($('#<%= this.Body.ClientID %>Field'), $('#<%= this.BodyMerge.ClientID %>Field'), false);
        $('#<%= this.BodyMerge.ClientID %>Field').val("");
    }

</script>
