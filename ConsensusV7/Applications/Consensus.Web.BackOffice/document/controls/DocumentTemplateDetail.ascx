<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DocumentTemplateDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.document.controls.DocumentTemplateDetail" %>
<con:HiddenField runat="server" ID="Id" DataBoundValue="Id" />
<div class="row">
    <div class="col-md-6">
        <con:PopupField runat="server" ID="DocTemplate" LabelText="Document template" FieldText="" FieldValue="" PopupUrl="~/document/popups/documenttemplatesearch.aspx?" HyperlinkUrl="~/document/packpage.aspx?id={id}" Requirement="MandatoryEnforced" />
    </div>
    <div class="col-md=6">
        <con:CheckField runat="server" ID="EmailBody" LabelText="Email Body" />
    </div>
    <con:HiddenField runat="server" ID="WordTemplate" DataBoundValue="LitIdId" />
    <con:HiddenField runat="server" ID="SMS" DataBoundValue="SmsIdId" />
    <con:HiddenField runat="server" ID="ICalendar" DataBoundValue="IcmIdId" />
    <con:HiddenField runat="server" ID="PackId" DataBoundValue="PackIdId" />
    <con:HiddenField runat="server" ID="chkEmailBody" DataBoundValue="Seq" />

</div>

<con:Validator runat="server" ClientValidationFunction="ChangeSequenceValue" ErrorMessage="" />

<script type="text/javascript">
    function ChangeSequenceValue() {
        var state = consensus.data.getState();
        state.updateObject();
        <%--if($('#<%= this.EmailBody.ClientID %>Field').val()){
            $('#<%= this.EmailBody.ClientID %>Field').val("1");--%>
        var isEmailBody = 0;
        if ($('#Content_Content_ctl00_EmailBodyField').is(':checked')) {
            if ($('#Content_Content_ctl00_EmailBodyGroup').css('display') == 'none') {
                isEmailBody = 99;
            }
            else {
                isEmailBody = 0;
            }
            parseInt($('#<%= this.chkEmailBody.ClientID %>Field').val(isEmailBody));
        }
        else {
            isEmailBody = 99;
            parseInt($('#<%= this.chkEmailBody.ClientID %>Field').val(isEmailBody));
        }
    }

</script>



