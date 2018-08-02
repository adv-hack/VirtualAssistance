<%@ Page Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master"  AutoEventWireup="true" CodeBehind="BookingPage.aspx.cs" Inherits="Consensus.Web.BackOffice.learning.BookingPage" %>

<%@ Register TagPrefix="con" TagName="BookingDetails" Src="~/learning/controls/BookingDetails.ascx" %>
<%@ Register TagPrefix="con" TagName="BookingInvoiceDetails" Src="~/learning/controls/BookingInvoiceDetails.ascx" %>

<%@ Register TagPrefix="con" TagName="BookingLineList" Src="~/learning/controls/BookingLineList.ascx" %>
<%@ Register TagPrefix="con" TagName="BookingInvoiceList" Src="~/learning/controls/BookingInvoiceList.ascx" %>
<%@ Register TagPrefix="con" TagName="BookingPaymentList" Src="~/learning/controls/BookingPaymentList.ascx" %>
<%@ Register TagPrefix="con" TagName="BookingCreditNoteList" Src="~/learning/controls/BookingCreditNoteList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <asp:HiddenField runat="server" ID="loggedUser" />
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:BookingDetails runat="server" id="BookingDetails" />
            </con:TabPage>
        </Pages>
        <Pages>
            <con:TabPage runat="server" Title="Billing details">
                <con:BookingInvoiceDetails runat="server" id="BookingInvoiceDetails" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <Pages>
            <con:TabList runat="server" Title="Booking Lines" EnableCreation="false">
                <con:BookingLineList runat="server" id="BookingLineList" />
            </con:TabList>
            <con:TabList runat="server" Title="Payments" EnableCreation="false">
                <con:BookingPaymentList runat="server" id="BookingPaymentList" />
            </con:TabList>
            <con:TabList runat="server" Title="Invoices" EnableCreation="false">
                <con:BookingInvoiceList runat="server" id="BookingInvoiceList" />
            </con:TabList>
            <con:Tablist runat="server" Title="Credit Notes" EnableCreation="false">
                <con:BookingCreditNoteList runat="server" id="BookingCreditNoteList" />
            </con:Tablist>
        </Pages>
    </con:TabControl>


<script type="text/javascript">
    function confirmBooking(bookId) {
        consensus.network.send({
            method: 'post',
            url: 'learning/booking/GetConfirmedEvents?bookId=' + bookId,
            success: function (result) {
                if (!result) //if null or count is 0 - event status that are not confirmed
                {
                    // call delegates if exists and confirm them
                    checkDelegatesToConfirm(bookId);
                }
                else {
                    swal({ title: 'Message', text: 'This booking cannot be confirmed until all of the events have been confirmed.', type: 'warning', showCancelButton: false, confirmButtonText: 'Ok', confirmButtonClass: 'btn btn-default', buttonsStyling: false }).then(function (success) {
                    //    //window.location.href = consensus.resolveUrl('~/crm/person?id=' + result.Id);
                    });
                }
            }
        });
    }

    function checkDelegatesToConfirm(bookId)
    {
        var approver = $('#Content_loggedUser').val()
        consensus.network.send({
            method: 'post',
            url: 'learning/learner/DelegatesToConfirm?bookId=' + bookId + '&approver=' + approver,
            success: function (result) {
                if (!result) //if null or count is 0 - event status that are not confirmed
                {
                    swal({ title: 'Message', text: 'There are no delegates to confirm.', type: 'warning', showCancelButton: false, confirmButtonText: 'Ok', confirmButtonClass: 'btn btn-default', buttonsStyling: false }).then(function (success) {

                    });
                }
                else {
                    swal({ title: 'Success', text: 'Booking successfully confirmed', type: 'warning', showCancelButton: false, confirmButtonText: 'Ok', confirmButtonClass: 'btn btn-default', buttonsStyling: false }).then(function (success) {
                        window.location.href = consensus.resolveUrl('~/learning/booking?id=' + result.BookingId);
                    });
                }
                //

            }
        });
    }

    function createInvoice(bookId,sellingCompanyId) {
        var userLoginId = $('#Content_loggedUser').val();
        consensus.network.send({
            method: 'post',
            url: 'learning/booking/GetBookingLines?bookId=' + bookId + '&userLoginId=' + userLoginId + '&sellingCompany=' + sellingCompanyId,
            success: function (result) {
                if (result && result.length > 0) //if count > 0 - Invoice is created against the same MemberPeriod
                {
                    if (result[0].InvoiceLines.length > 0) {
                        var totInvoiceLines = result[0].InvoiceLines;
                       //var newInvoicedData = result[0].InvoiceLines[0];
                        var invoicedData = Math.max.apply(Math, totInvoiceLines.map(function (o) { return o.InvoiceId; }))

                        window.location.href = consensus.resolveUrl('~/finance/invoice?id=' + invoicedData);
                    }
                }

                else {
                    // If LOC_Count = 0 then no invoice is to be created.

                    swal({ title: 'Message', text: 'The Booking is already fully invoiced.', type: 'info', showCancelButton: false, confirmButtonText: 'Ok', confirmButtonClass: 'btn btn-default', buttonsStyling: false }).then(function (success) {
                        //    //window.location.href = consensus.resolveUrl('~/crm/person?id=' + result.Id);
                    });
                }
            }
        });
    }
    
    function cancelBooking(bookId) {
        consensus.network.send({
            method: 'post',
            url: 'learning/booking/CheckIfBookingAlreadyCancelled?bookId=' + bookId,
            success: function (result) {
                if (result) {
                    swal({ title: 'Message', text: 'This booking has already been cancelled.', type: 'info', showCancelButton: false, confirmButtonText: 'OK', confirmButtonClass: 'btn btn-default', buttonsStyling: false }).then(function (success) {
                   });

                }
                else {
                    window.top.swal.call(window.top, { title: 'Are you sure', text: 'Are you sure that you want to cancel this booking?', type: 'warning', showCancelButton: true, confirmButtonText: 'Yes', cancelButtonText: 'No', confirmButtonClass: 'btn btn-danger', cancelButtonClass: 'btn btn-default', buttonsStyling: false }).then(function () {
                        var state = consensus.data.getState();
                        if (!state) {
                            window.closePopup();
                        }
                        else {
                            var userLoginId = $('#Content_loggedUser').val();
                            consensus.network.send({
                                method: 'post',
                                url: 'learning/learner/CancelBooking?bookId=' + bookId + '&userLoginId=' + userLoginId,
                                success: function () {
                                        window.location.reload();
                                }
                            });
        
                        }
                    });

                }

            }
        });       
    }


</script>
    </asp:Content>
<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" ShowAttachmentBookingFields="true" />
</asp:Content>