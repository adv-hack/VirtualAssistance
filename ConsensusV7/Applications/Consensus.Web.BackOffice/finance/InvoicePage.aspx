<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="InvoicePage.aspx.cs" Inherits="Consensus.Web.BackOffice.finance.InvoicePage" %>

<%@ Register TagPrefix="con" TagName="InvoiceDetails" Src="~/finance/controls/invoicedetails.ascx" %>
<%@ Register TagPrefix="con" TagName="SOPDetails" Src="~/finance/controls/sopdetails.ascx" %>
<%@ Register TagPrefix="con" TagName="InvoiceLinesList" Src="~/finance/controls/invoicelinesList.ascx" %>
<%@ Register TagPrefix="con" TagName="InvoiceSummary" Src="~/finance/controls/invoicesummary.ascx" %>
<%@ Register TagPrefix="con" TagName="InvoiceAllocation" Src="~/finance/controls/InvoiceAllocationList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ReadModeToolbar" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="EditModeToolbar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:InvoiceDetails runat="server" ID="InvoiceDetails" />
            </con:TabPage>
            <%--            <con:TabPage runat="server" Title="SOP">
                <con:SOPDetails runat="server" id="SOPDetails" />
            </con:TabPage>--%>
        </Pages>
    </con:TabControl>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" ID="BottomTabControl">
        <Pages>
            <con:TabList runat="server" EnableCreation="true" Title="Invoice Lines">
                <con:InvoiceLinesList runat="server" ID="InvoiceLines" InvId="id" />
            </con:TabList>
            <con:TabList runat="server" Title="Allocations" EnableCreation="false">
                <con:InvoiceAllocation runat="server" ID="InvoiceAllocation" />
            </con:TabList>
        </Pages>
    </con:TabControl>
    <script type="text/javascript">
        function creditInvoice(invId) {
            consensus.network.send({
                method: 'post',
                url: 'finance/invoice/CheckIfInvoiceCredited?invId=' + invId,
                success: function (result) {
                    if (!result) {
                        swal({ title: 'Message', text: 'This invoice has already been credited.', type: 'info', showCancelButton: false, confirmButtonText: 'OK', confirmButtonClass: 'btn btn-default', buttonsStyling: false }).then(function (success) {

                        });
                    }
                    else {
                        window.top.swal.call(window.top, { title: 'Warning', text: 'Do you want to credit this invoice?', type: 'warning', showCancelButton: true, confirmButtonText: 'Yes', cancelButtonText: 'No', confirmButtonClass: 'btn btn-danger', cancelButtonClass: 'btn btn-default', buttonsStyling: false }).then(function () {
                            var state = consensus.data.getState();
                            if (!state) {
                                window.closePopup();
                            }
                            else {
                                var userloginId = $('#Content_loggedUser').val();
                                consensus.network.send({
                                    method: 'post',
                                    url: 'finance/invoice/CreditInvoice?invId=' + invId + '&userloginId=' + userloginId,
                                    success: function (result) {
                                        if (result) {
                                            window.location.href = consensus.resolveUrl('~/finance/creditnote?id=' + result["0"].Id);
                                        }
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
    <con:PageFooter runat="server" />
</asp:Content>