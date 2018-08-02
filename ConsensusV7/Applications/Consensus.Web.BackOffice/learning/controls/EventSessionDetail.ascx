<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EventSessionDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.EventSessionDetail" %>
<%@ Register TagPrefix="con" TagName="EventSessionDetails" Src="~/learning/controls/EventSessionDetailSection.ascx" %>
<%@ Register TagPrefix="con" TagName="LocationDetails" Src="~/learning/controls/EventSessionLocationSection.ascx" %>
<%@ Register TagPrefix="con" TagName="SessionNoteDetails" Src="~/learning/controls/EventSessionNotesSection.ascx" %>
<%@ Register TagPrefix="con" TagName="SessionPriceDetails" Src="~/learning/controls/SessionPriceList.ascx" %>

<con:TabControl runat="server">
    <Pages>
        <con:TabPage ID="SessionDetailSection" runat="server" Title="Session">
            <con:HiddenField runat="server" ID="EventId" DataBoundValue="SessionXrefMaster.EventId" />
            <con:HiddenField runat="server" ID="Type" DataBoundValue="TypeCode" />
            <con:EventSessionDetails runat="server" id="EventSessionDetails" />
        </con:TabPage>
        <con:TabPage ID="SessionLocationSection" runat="server" Title="Venue">
            <con:LocationDetails runat="server" id="LocationDetails" />
        </con:TabPage>
        <con:TabPage ID="PriceSection" runat="server" Title="Prices">
            <con:SessionPriceDetails runat="server" id="SessionPriceDetails" DataBoundValue="SessionXrefActivity" />
        </con:TabPage>
        <con:TabPage ID="SessionNotesSection" runat="server" Title="Notes">
            <con:SessionNoteDetails runat="server" id="SessionNoteDetails" />
            <con:HiddenField runat="server" Id="SessionId" DataBoundValue="Id" />
        </con:TabPage>        
    </Pages>

</con:TabControl>

<asp:CustomValidator runat="server" ClientValidationFunction="validatePrice" Display="None" EnableClientScript="true" ErrorMessage="" />
<script type="text/javascript">
    $(document).ready(function () {
        GetSessionPrices();
    });


    function validatePrice(source, arguments) {
        var table = $('#<%= this.SessionPriceDetails.ClientID%>_SessionListResult')[0];
        var showBooking = $('#<%= this.EventSessionDetails.ClientID%>_ShowOnBookingField');

        if (table.rows.length == 2 && table.rows[1].cells.length==1) {
            arguments.IsValid = false;
            source.errormessage = "Please add a valid price for this session";
        }
        else if (!showBooking.prop('checked')) {
            for (var i = 1; i < table.rows.length;i++) {
                var price = table.rows[i].cells[10].innerText;
                if (price != '' && price != '0') {
                    arguments.IsValid = false;
                    source.errormessage = "Show on booking must be turned on if the session is to have a price greater than 0";
                    showBooking.bootstrapSwitch("state", true);
                    break;
                }
            }

        }        
    }

    function GetSessionPrices() {
        consensus.network.send({
            method: 'post',
            url: 'learning/sessionxref/FetchAllBySessionId?sessionId='+  $('#<%= this.SessionId.ClientID %>Field').val(),
            success: function (result) {
                if (result.length && result.length > 0) {

                    var memProdGrades = window[$('[id$=_SessionListResult]')[0].id];
                    //var memProdGrades = window[$('[id$=SessionListResult]')];
                    //var memProdGrades = window['Content_Content_ctl01_SessionPriceDetails_SessionListResult'];
                    memProdGrades._setSourceData(result);
                    memProdGrades.reload();
                }
            }
        });
    }

</script>
