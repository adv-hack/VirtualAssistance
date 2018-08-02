<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OutputQueueDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.document.controls.OutputQueueDetail" %>
<div class="row">
    <con:HiddenField runat="server" ID="recordId" DataBoundValue="Id" />
    <div class="col-6"> 
      <con:GroupBox runat="server" Title="Details">
        <div class="row">
          <div class="col-4">
              <con:ListField runat="server" ID="QueueType" DataBoundValue="QueueType" LabelText="Ouput type" Requirement="MandatoryEnforced" ClientOnChange="HideFields();">
                  <Items>
                      <asp:ListItem Text="" Value="" />
                      <asp:ListItem Text="Email" Value="EMail" />
                      <asp:ListItem Text="Printer" Value="Printer" />
                      <asp:ListItem Text="SMS" Value="SMS" />
                  </Items>
              </con:ListField>
          </div>
          <div class="col-4">
              <con:ListField runat="server" ID="SendType" DataBoundValue="SendType" LabelText="Send method" IsReadOnly="True" Requirement="MandatoryEnforced">
                  <Items>
                      <asp:ListItem Text="" Value="" />
                      <asp:ListItem Text="16-Email" Value="16" />
                      <asp:ListItem Text="01-Post" Value="1" />
                      <asp:ListItem Text="30-SMS" Value="30" />
                  </Items>
              </con:ListField>
          </div>
          <div class="col-4">
            <con:CheckField runat="server" ID="SystemDefault" DataBoundValue="SystemDefault" LabelText="Default" IsReadOnly="True"/>
          </div>
        </div>
        <div class="row">
          <div class="col-12">
              <con:PopupField runat="server" ID="AdminProle" DataBoundValue="AdminProleId" LabelText="Administrator" DataBoundText="AdminProle.PersonName" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" />
          </div>
        </div>
        <div class="row">
            <div class="col-12">
                <con:TextField runat="server" TextMode="MultiLine" DataBoundValue="Description" ID="Description" LabelText="Description" Requirement="Mandatory" />
            </div>
        </div>
        <con:TextField runat="server" ID="DpmServer" DataBoundValue="DpmServer" LabelText="DPM server"/>
      </con:GroupBox>
    </div>
    <div class="col-6">
      <con:GroupBox runat="server" Title="Setup">
        <div class="row" id="divMailserver">
          <div class="col-12"><con:TextField runat="server" ID="MailServer" DataBoundValue="MailServer" LabelText="Mail server" Requirement="MandatoryEnforced"/></div>
        </div>
        <div class="row" id="divPort">
          <div class="col-4">
            <con:TextField runat="server" ID="Port" DataBoundValue="Port" LabelText="Port" TextMode="Number"/>
          </div>
          <div class="col-4">
            <con:CheckField runat="server" ID="Ssl" DataBoundValue="Ssl" LabelText="SSL" />
          </div>
          <div class="col-4">
            <con:CheckField runat="server" ID="Proxy" DataBoundValue="Proxy" LabelText="Proxy" />
          </div>
        </div>
        <div class="row" id="divCredentials">
          <div class="col-12"><con:TextField runat="server" ID="LogonId" DataBoundValue="LogonId" LabelText="Username" Requirement="MandatoryEnforced"/></div>
          <div class="col-12"><con:TextField runat="server" ID="LogonPassword" DataBoundValue="LogonPassword" LabelText="Password" Requirement="MandatoryEnforced" TextMode="Password" /></div>
        </div>
        <div class="row" id="divPrinter">
          <div class="col-12"><con:TextField runat="server" ID="PrintServer" DataBoundValue="PrintServer" LabelText="Print server" Requirement="MandatoryEnforced"/></div>
          <div class="col-12"><con:TextField runat="server" ID="PrinterNotes" DataBoundValue="PrinterNotes" LabelText="Printer share name"/></div>
        </div>
        <div class="row" id="divFrom">
          <div class="col-12"><con:TextField runat="server" ID="From" DataBoundValue="From" LabelText="From" Requirement="MandatoryEnforced"/></div>
        </div>
      </con:GroupBox>
    </div>
</div>
<asp:CustomValidator runat="server" ClientValidationFunction="ValidateDuplicateEmail" Display="None" EnableClientScript="true" ErrorMessage="There is already an Email queue" />
<asp:CustomValidator runat="server" ClientValidationFunction="ValidateDuplicatePrinter" Display="None" EnableClientScript="true" ErrorMessage="There is already a print queue with this same share name" />
<asp:CustomValidator runat="server" ClientValidationFunction="ValidateDuplicateSMS" Display="None" EnableClientScript="true" ErrorMessage="There is already a SMS queue" />
<script>

    $(document).ready(function () {
        HideFields(); 
    });

    function HideFields() {

      var QueueTypeValue = $('#<%= this.QueueType.ClientID %>Field').val();

        switch (QueueTypeValue) {
          case 'Printer':
            $('#<%= this.SendType.ClientID %>Field').val('1');
            $('#<%= this.MailServer.ClientID %>Label').text('Mail server');

            toggleValidation('<%= this.MailServer.ClientID %>', false);
            toggleValidation('<%= this.PrintServer.ClientID %>', true);
            toggleValidation('<%= this.LogonPassword.ClientID %>', false);
            toggleValidation('<%= this.LogonId.ClientID %>', false);
            toggleValidation('<%= this.From.ClientID %>', false);

            break;
          case 'EMail':
            $('#<%= this.SendType.ClientID %>Field').val('16');
            $('#<%= this.MailServer.ClientID %>Label').text('Mail server');

            toggleValidation('<%= this.MailServer.ClientID %>', true);
            toggleValidation('<%= this.PrintServer.ClientID %>', false);
            toggleValidation('<%= this.LogonId.ClientID %>', true);
            toggleValidation('<%= this.LogonPassword.ClientID %>', true);
            toggleValidation('<%= this.From.ClientID %>', false);

            break;
          case 'SMS':
            $('#<%= this.SendType.ClientID %>Field').val('30');
            $('#<%= this.MailServer.ClientID %>Label').text('Host name');

            toggleValidation('<%= this.MailServer.ClientID %>', true);
            toggleValidation('<%= this.PrintServer.ClientID %>', false);
            toggleValidation('<%= this.LogonId.ClientID %>', true);
            toggleValidation('<%= this.LogonPassword.ClientID %>', true);
            toggleValidation('<%= this.From.ClientID %>', true);

            break;
        }

      document.getElementById("divPrinter").hidden = (QueueTypeValue != 'Printer');
      document.getElementById("divFrom").hidden = (QueueTypeValue != 'SMS');
      document.getElementById("divPort").hidden = (QueueTypeValue != 'SMS');
      document.getElementById("divMailserver").hidden = (QueueTypeValue != 'EMail' && QueueTypeValue != 'SMS');
      document.getElementById("divCredentials").hidden = (QueueTypeValue != 'EMail' && QueueTypeValue != 'SMS');

        $('#<%= this.SystemDefault.ClientID %>Field').bootstrapSwitch("disabled", QueueTypeValue !== 'Printer').bootstrapSwitch("readonly", QueueTypeValue !== 'Printer');
    }
    function getPrintQueues(recordId, queueType) {
        var queues = [];
        consensus.network.send({
            async: false,
            method: 'get',
            url: '/document/outputqueue?ListsAtDepth=None&GoToDepth=Root',
            success: function (result) {
                queues = jQuery.grep(result, function (queue) { return queue.QueueType.toLowerCase() === queueType.toLowerCase() && queue.Id !== recordId });
            }
        });
        return queues;
    }
    function ValidateDuplicateEmail(source, arguments) {
        var recordId = $('#<%= this.recordId.ClientID %>Field').val();
        var queueType = $('#<%= this.QueueType.ClientID %>Field').val();
        if (queueType.toLowerCase() === 'email') {
            var queues = getPrintQueues(recordId, queueType)
            arguments.IsValid = (queues.length == 0);
        } else {
            arguments.IsValid = true;
        }
    }
    function ValidateDuplicateSMS(source, arguments) {
        var recordId = $('#<%= this.recordId.ClientID %>Field').val();
        var queueType = $('#<%= this.QueueType.ClientID %>Field').val();
        if (queueType.toLowerCase() === 'sms') {
            var queues = getPrintQueues(recordId, queueType)
            arguments.IsValid = (queues.length == 0);
        } else {
            arguments.IsValid = true;
        }
    }
    function ValidateDuplicatePrinter(source, arguments) {
        var recordId = $('#<%= this.recordId.ClientID %>Field').val();
        var queueType = $('#<%= this.QueueType.ClientID %>Field').val();
        var printServer = $('#<%= this.PrintServer.ClientID %>Field').val();
        var printerName = $('#<%= this.PrinterNotes.ClientID %>Field').val();
        if (queueType.toLowerCase() === 'printer') {
            var queues = jQuery.grep(getPrintQueues(recordId, queueType),
                function (queue)
                {
                    
                        return queue.PrintServer.toLowerCase() === printServer.toLowerCase() && queue.PrinterNotes.toLowerCase() === printerName.toLowerCase()
                });
            arguments.IsValid = (queues.length == 0);
        } else {
            arguments.IsValid = true;
        }
    }

    function toggleValidation(controlId, enabled) {
      if (typeof (window.ValidatorValidate) == 'function' && typeof (window.Page_Validators) != 'undefined') {
        for (var i = 0; i < window.Page_Validators.length; i++) {
          var validator = window.Page_Validators[i];
          if (validator.validationGroup == controlId) {
            validator.enabled = enabled;
            consensus.data.validation.check($('#' + controlId + 'Field'));
          }
        }
      }
    }
</script>