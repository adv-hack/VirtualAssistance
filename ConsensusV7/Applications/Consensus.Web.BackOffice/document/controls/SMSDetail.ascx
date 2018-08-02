<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SMSDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.document.controls.SMSDetail" %>
<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Template Details">
            <con:HiddenField runat="server" ID="SMSMessageId" DataBoundValue="Id" />
            <con:ListField runat="server" ID="Type" DataBoundValue="SmsMessageTypeId" DisplayMember="Name" ValueMember="Id" LabelText="Type" Requirement="MandatoryEnforced" onchange="getMergeFields()" />
            <con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced" />
            <con:ListField runat="server" ID="SellingCompany" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" DisplayMember="Name" ValueMember="Id" LabelText="Selling company" Requirement="MandatoryEnforced" />
            <con:CheckField runat="server" ID="Status" DataBoundValue="Current" LabelText="Current" />
        </con:GroupBox>
    </div>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Message Content">
            <con:ListField runat="server" ID="MessageMerge" LabelText="Message Merge Fields" ClientOnChange="MergeFieldChanged()" ClientSideInitialise="true" />
            <con:TextField runat="server" ID="Details" TextMode="MultiLine" DataBoundValue="Text" LabelText="Details" />
            <%--<con:ListField runat="server" ID="AllMergeFields" IsHidden="TrueEnforced" />--%>
        </con:GroupBox>
    </div>
</div>
<con:Validator runat="server" ClientValidationFunction="CheckIfNameExist" ErrorMessage="" />
<script type="text/javascript">

    $(document).ready(function () {
        $('#<%= this.Name.ClientID %>Field').attr('maxlength', 40);
    });

    function CheckIfNameExist(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'document/smsmessage/CheckIfNameExist?name=' + $('#<%= this.Name.ClientID %>Field').val() + '&smsmessageId=' + $('#<%= this.SMSMessageId.ClientID %>Field').val(),
            success: function (response) {
                if (response) {
                    args.IsValid = !response;
                    source.errormessage = "Name already present.";
                }
                else {
                    source.errormessage = "";
                }
            },
            error: function (request) {
            }
        });
    }

    function getMergeFields() {
        
<%--        $('#<%= this.MessageMerge.ClientID %>Field').empty();
 
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
                        $('#<%= this.MessageMerge.ClientID %>Field').append('<option value="' + '' + '">' + '' + '</option>');
                        
                    }
                    addBlankEntry = false;

                    $('#<%= this.MessageMerge.ClientID %>Field').append('<option value="' + value[0] + '">' + value[0] + '</option>');
                    
                }
            }
        }--%>

        var selectedType = $('#<%= this.Type.ClientID %>Field').val();
        <%= this.MessageMerge.ClientID %>._populator.setParameters([{ name: "SMT_ID", value: selectedType }]);
    }

    function InsertText(originalField, mergedField) {
        var cursorPos = originalField.prop('selectionStart');
        var value = originalField.val();
        var textBefore = value.substring(0, cursorPos);
        var textAfter = value.substring(cursorPos, value.length);

        originalField.val(textBefore + "[[" + mergedField.val() + "]]" + textAfter);
        originalField.focus();
        mergedField.val("");
    }

    function MergeFieldChanged() {
        InsertText($('#<%= this.Details.ClientID %>Field'), $('#<%= this.MessageMerge.ClientID %>Field'));
         $('#<%= this.MessageMerge.ClientID %>Field').val("");
    }

</script>
