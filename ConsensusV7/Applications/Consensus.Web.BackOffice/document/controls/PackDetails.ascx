<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PackDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.document.controls.PackDetails" %>
<con:HiddenField runat="server" ID="Id" DataBoundValue="Id" />
<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Pack Details">
            <div class="row">
                <div class="col-md-6">
                    <con:HiddenField runat="server" ID="PackId" DataBoundValue="Id" />
                    <con:ListField runat="server" ID="AllMergeFields" IsHidden="TrueEnforced" />
                    <con:ListField runat="server" ID="packType" DataBoundValue="PackType" LabelText="Pack Type" Requirement="MandatoryEnforced" DisplayMember="Desc" ValueMember="Type" ClientOnChange="setAttachments()" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="packName" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced" ClientOnChange="NameChanged()" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="packSendFrom" DataBoundValue="PackSenderIdId" DataBoundText="PackSenderId.PersonName" LabelText="Send From" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}"></con:PopupField>
                </div>
                <div class="col-md-6">
                    <con:ListField runat="server" ID="packOutputMethod" DataBoundValue="PackOutputQueueIdId" DataBoundText="PackOutputQueueId.Description" LabelText="Output Method" DisplayMember="Description" ValueMember="Id"></con:ListField>
                </div>
            </div>
            <div class="row">                
                <div class="col-md-6">
                    <con:ListField runat="server" ID="Status" DataBoundValue="Status" LabelText="Status">
                        <Items>
                            <asp:ListItem Text="Planning" Value="0"></asp:ListItem>
                            <asp:ListItem Text="Current" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Cancelled" Value="9"></asp:ListItem>
                        </Items>
                    </con:ListField>
                </div>
                
                <div class="col-md-6">
                    <con:ListField runat="server" ID="packSellingCompany" DataBoundValue="PackSellingCompanyIdId" DataBoundText="SellingCompany.Name" LabelText="Selling Company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:CheckField runat="server" DataBoundValue="ActPqKeep" ID="packRetainAttachments" LabelText="Retain Attachments" />
                </div>
            </div>
        </con:GroupBox>
    </div>


    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Email Options">
            <con:TextField runat="server" ID="bccEmailTo" DataBoundValue="BccEmail" LabelText="BCC Emails To" HyperlinkUrl="mailto:{text}" >
                <Validators>
                    <con:Validator runat="server" ClientValidationFunction="validateBccEmail" Critical="true" ErrorMessage="This does not appear to be a valid email address." />
                </Validators>
            </con:TextField>
            <con:TextField runat="server" ID="packMDNRespAdd" DataBoundValue="MdnEmail" LabelText="Message disposition notification response address" HyperlinkUrl="mailto:{text}" >
                <Validators>
                    <con:Validator runat="server" ClientValidationFunction="validateMdnEmail" Critical="true" ErrorMessage="This does not appear to be a valid email address." />
                </Validators>
            </con:TextField>
            <con:TextField runat="server" ID="packDSNRespAdd" DataBoundValue="DsnEmail" LabelText="Delivery status notification response address" HyperlinkUrl="mailto:{text}" >
                <Validators>
                    <con:Validator runat="server" ClientValidationFunction="validateDsnEmail" Critical="true" ErrorMessage="This does not appear to be a valid email address." />
                </Validators>
            </con:TextField>
            <con:CheckField runat="server" ID="packDeliverySuccess" LabelText="Request delivery success notification" />
            <con:CheckField runat="server" ID="packDeliveryFailure" LabelText="Request delivery failure notification" />
            <con:CheckField runat="server" ID="packDeliveryDelay" LabelText="Request delivery delay notification " />
        </con:GroupBox>
    </div>
</div>
<con:HiddenField runat="server" ID="packDeliveryOptions" DataBoundValue="DsnOptions" />
<con:HiddenField runat="server" ID="packIncludeAtchmnt" FieldValue="" />
<con:HiddenField runat="server" ID="packCategory" DataBoundValue="Category" />
<con:Validator runat="server" ClientValidationFunction="ValidateDsnOptionsAndName" ErrorMessage="" />
<%--<con:Validator runat="server" ClientValidationFunction="CheckIfNameExist" ErrorMessage="" />--%>

<script type="text/javascript">
    function ValidateDsnOptionsAndName(source, args) {
        var dsnOptions = "";
        if ($('#<%= this.packDeliverySuccess.ClientID %>Field').is(':checked'))
            dsnOptions += "S,";
        if ($('#<%= this.packDeliveryFailure.ClientID %>Field').is(':checked'))
            dsnOptions += "F,";
        if ($('#<%= this.packDeliveryDelay.ClientID %>Field').is(':checked'))
            dsnOptions += "D,";

        $('#<%= this.packDeliveryOptions.ClientID %>Field').val(dsnOptions.toUpperCase());

        this.CheckIfNameExist(source, args);
    }

    function setAttachments() {
        var packTypeValue = $('#<%= this.packType.ClientID %>Field').val();
        var test = $('#<%= this.packType.ClientID  %>Field option:selected').val();

        if ((packTypeValue == '6' || packTypeValue == "6") && test == '6') //When PackType Value is "Batch - 6 "
        {
            $('#<%= this.packCategory.ClientID %>Field').val("BATCH");
        }
        this.GetMergeFields();
    }
    
    function CheckIfNameExist(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'document/pack/CheckIfNameExist?packName=' + $('#<%= this.packName.ClientID %>Field').val() + '&packId=' + $('#<%= this.PackId.ClientID %>Field').val(),
            success: function (response) {
                if (response) {
                    args.IsValid = !response;
                    source.errormessage = "Pack name must be unique.";
                }
                else {
                    source.errormessage = "";
                }
            },
            error: function (request) {
            }
        });
    }

    function NameChanged() {
        var subjectField = $('[id$=_SubjectField]').find('input');
        var packId = $('#<%= this.PackId.ClientID %>Field').val();
        if (!packId) {            
            if (!subjectField.val()) {
               subjectField.val($('#<%= this.packName.ClientID %>Field').val());
            }
        }
    }

    function GetMergeFields() {
        $('[id$=_SubjectMerge]').find('select').empty();
        $('[id$=_BodyMerge]').find('select').empty();
        var selectedPackType = $('#<%= this.packType.ClientID %>Field').val();

        var allMergeFields = document.getElementById("<%= this.AllMergeFields.ClientID %>Field").options;       
        var addBlankEntry = true;

        for (var i = 0; i < allMergeFields.length; i++) {
            if (allMergeFields[i].text) {

                var value = allMergeFields[i].text.split("[")[1].split(",");
                var typeValue = value[1].split("]")[0].trim();

                if (selectedPackType == typeValue) {

                    //Inserts empty value for first time                    
                    if (addBlankEntry) {
                        $('[id$=_SubjectMerge]').find('select').append('<option value="' + '' + '">' + '' + '</option>');
                        $('[id$=_BodyMerge]').find('select').append('<option value="' + '' + '">' + '' + '</option>');
                    }

                    addBlankEntry = false;

                    $('[id$=_SubjectMerge]').find('select').append('<option value="' + value[0] + '">' + value[0] + '</option>');
                    $('[id$=_BodyMerge]').find('select').append('<option value="' + value[0] + '">' + value[0] + '</option>');
                }               
            }
        }  
    }
</script>
