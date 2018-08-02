<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EventProductDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.EventProductDetail" %>
<%@ Register TagPrefix="con" TagName="EventProductDetailSection" Src="~/learning/controls/EventProductDetailSection.ascx" %>
<%@ Register TagPrefix="con" TagName="EventProductPriceDetails" Src="~/learning/controls/SessionPriceList.ascx" %>

<con:TabControl runat="server">
    <Pages>
        <con:TabPage ID="EventProductSection" runat="server" Title="Details">
                <con:HiddenField runat="server" ID="EventId" DataBoundValue="SessionXrefMaster.EventId" />
                <con:EventProductDetailSection runat="server" id="EventProductDetailSection" />
        </con:TabPage>
        <con:TabPage ID="PriceSection" runat="server" Title="Prices">
                <con:EventProductPriceDetails runat="server" id="EventProductPriceDetails" DataBoundValue="EPSessionXref"/>
        </con:TabPage>
    </Pages>
</con:TabControl>

<asp:CustomValidator runat="server" ClientValidationFunction="checkExistingProducts" Display="None" EnableClientScript="true" ErrorMessage="" />
<asp:CustomValidator runat="server" ClientValidationFunction="validatePrice" Display="None" EnableClientScript="true" ErrorMessage="" />

<script type="text/javascript">
    function validatePrice(source, arguments) {
        var table = $('#<%= this.EventProductPriceDetails.ClientID%>_SessionListResult')[0];
        var showBooking = $('#<%= this.EventProductDetailSection.ClientID%>_ShowSalesField');

        if (table.rows.length == 2 && table.rows[1].cells.length==1) {
            arguments.IsValid = false;
            source.errormessage = "Please add a valid price for this session";
        }
        else if (!showBooking.prop('checked')) {
            for (var i = 1; i < table.rows.length;i++) {
                var price = table.rows[i].cells[10].innerText;
                if (price != '' && price != '0') {
                    arguments.IsValid = false;
                    source.errormessage = "Show on booking must be turned on if the product is to have a price greater than 0";
                    showBooking.bootstrapSwitch("state", true);
                    break;
                }
            }

        }        
    }

    function checkExistingProducts(source, args) {
        var productId = $('#<%= this.EventProductDetailSection.ClientID %>_ProductEventValue').val();
        var eventproductId = $('#<%= this.EventProductDetailSection.ClientID %>_IdField').val();
        consensus.network.send({
            async: false,
            method: 'post',
            data: {
                eventId: $('#<%= this.EventId.ClientID %>Field').val(),
                serialization: {
                    Include: {
                        "Learning.EventProduct": ["ProductId"]
                    }
                }
            },
            url: 'learning/eventproduct/FetchAllByEventId',
            success: function (response) {
                if (response) {
                    for (var i = 0; i < response.length; i++) {
                        if (response[i].ProductId == productId && response[i].Id != eventproductId) {
                            source.errormessage ="You can not add this product because it is already on this event";
                            args.IsValid = false;
                            break;
                        }
                    }
                }
            },
            error: function (request) {
            }
        });
    }
</script>
