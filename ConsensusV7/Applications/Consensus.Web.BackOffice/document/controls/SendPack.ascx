<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SendPack.ascx.cs" Inherits="Consensus.Web.BackOffice.document.controls.SendPack" %>
<div class="row">
    <div class="col-xs-12">
        <con:ListField runat="server" ID="PackName" DataBoundValue="PackId" 
            LabelText="Pack name" DisplayMember="Text" ValueMember="Value" Requirement="MandatoryEnforced" ClientOnChange="packChanged()" />
    </div>
</div>
<div class="row">
    <div class="col-xs-6">
        <con:CheckField runat="server" ID="SendToMe" LabelText="Send to me" ClientOnChange="sendToChanged()" />
    </div>
    <div class="col-xs-6">
        <con:HiddenField runat="server" ID="SendTo" DataBoundValue="SendToProleId" />
        <con:TextField runat="server" ID="SendToPrompt" LabelText="Recipient" Enabled="false" />
        <con:HiddenField runat="server" ID="SentFrom" DataBoundValue="SendFromProleId" />
        <con:HiddenField runat="server" ID="PrintRequestType" DataBoundValue="Type" />
    </div>
</div>
<div class="row">
    <div class="col-xs-6">
        <con:ListField runat="server" ID="SendMethod" LabelText="Send method" DataBoundValue="PqSendType" ClientOnChange="sendMethodChanged()" 
            DisplayMember="Text" ValueMember="Value" Requirement="MandatoryEnforced" />
    </div>
    <div class="col-xs-6">
        <con:ListField runat="server" ID="OutputQueue" LabelText="Output queue" DataBoundValue="QueueId"  ClientOnChange="queueChanged()"
            DisplayMember="Description" ValueMember="Id" Requirement="MandatoryEnforced" />
    </div>
</div>
<script type="text/javascript">
    var me = <%= sendToJSON(true) %>;
    var standard = <%= sendToJSON(false) %>;

    function sendToChanged() {
        var sendToMe = $("#<%= SendToMe.ClientID %>Field").prop("checked");
        // If no "standard" send to role available, force send to me.
        if (!sendToMe && !standard) {
            $("#<%= SendToMe.ClientID %>Field").prop("checked", true).prop("disabled", true);
            sendToMe = true;
        }
        var sendTo = sendToMe ? me : standard;
        $("#<%= SendTo.ClientID %>Field").val(sendTo.id);
        $("#<%= SendToPrompt.ClientID %>Field").val(sendTo.name);
    }

    function packChanged() {
        // Get the queue from the pack and (if any set) use it to set the Send Method and print queue
        var $packlist = $("#<%= PackName.ClientID %>Field");
        var $queuelist = $("#<%= OutputQueue.ClientID %>Field");
                
        $fromId.val(me.id);
        $fromPrompt.val(me.name);

        var packIx = $packlist.prop("selectedIndex");
        if (packIx != null)
        {
            var $pack = $packlist.children().eq(packIx);
            
            var packQueueId = $pack.attr("queueid");
            
            if (packQueueId)
            {
                $queuelist.val(packQueueId);
                queueChanged();
            }
        }
    }

    function sendMethodChanged() {
        // fill the print queue field with the default
        showHideQueues();
        
        var $queuelist = $("#<%= OutputQueue.ClientID %>Field");
        var $visibleQueues = $queuelist.children().filter(function(ix, queue) { return $(queue).css("display") != "none"; });
        if ($visibleQueues.length == 1) {
            $queuelist.val($visibleQueues.eq(0).attr("value"));
        }
        else {
            $visibleQueues.each(function(iX, queue) {
                var $queue = $(queue);
                if ($queue.attr("defaultfortype") == "1") {
                    $queuelist.val($queue.attr("value"));
                    return false;
                }
            });
        }
    }

    function queueChanged() {
        
        var $queuelist = $("#<%= OutputQueue.ClientID %>Field");        
        var $methodlist = $("#<%= SendMethod.ClientID %>Field");        
        var queueIx = $queuelist.prop("selectedIndex");

        if (queueIx != null)
        {            
            var $queue = $queuelist.children().eq(queueIx);            
            var sendMethodNo = $queue.attr("sendtype");

            if (sendMethodNo || sendMethodNo === 0) {
                $methodlist.children().each(function(iX, method){
                    if (method.value.length >= 2 && parseInt(method.value.substring(0,2)) == parseInt(sendMethodNo)) {
                        if ($methodlist.prop("selectedIndex") != iX){
                            $methodlist.prop("selectedIndex", iX);
                            showHideQueues();
                        }
                        return false;
                    }
                });
            }
        }
    }

    function showHideQueues() {
        var $queuelist = $("#<%= OutputQueue.ClientID %>Field");      
        var $methodlist = $("#<%= SendMethod.ClientID %>Field");       
        var methodIx = $methodlist.prop("selectedIndex");
        
        if (methodIx != null)
        {
            var $method = $methodlist.children().eq(methodIx);  
            var methodId = $method.attr("value");
            var methodNo = (methodId && methodId.length >= 2) ? parseInt(methodId) : NaN;

            $queuelist.children().each(function(iX, queue) {
                var $queue = $(queue);
                var queueSendTypeNo = parseInt($queue.attr("sendtype"));
                if (isNaN(methodNo) || methodNo == queueSendTypeNo) {
                    $queue.show();
                }
                else {
                    if ($queue.prop("selected"))
                        $queuelist.val("");

                    $queue.hide();
                }
            });
        }
    }

    $(document).ready(function(){
        sendToChanged();
    });
</script>