<%@ Page Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="DonationBookingPage.aspx.cs" Inherits="Consensus.Web.BackOffice.learning.DonationBookingPage" %>
<%@ Register TagPrefix="con" TagName="DonationBookingDetails" Src="~/learning/controls/DonationBookingDetails.ascx" %>
<%@ Register TagPrefix="con" TagName="DonationPaymentDetails" Src="~/learning/controls/DonationPaymentDetails.ascx" %>
<%@ Register TagPrefix="con" TagName="DonationAmountList" Src="~/learning/controls/DonationAmountList.ascx" %>
<%--<%@ Register TagPrefix="con" TagName="BookingInvoiceList" Src="~/learning/controls/BookingInvoiceList.ascx" %>--%>
<%@ Register TagPrefix="con" TagName="BookingPaymentList" Src="~/learning/controls/BookingPaymentList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:DonationBookingDetails runat="server" id="DonationBookingDetails" />
            </con:TabPage>
        </Pages>
        <Pages>
            <con:TabPage runat="server" Title="Donor details">
                <con:DonationPaymentDetails runat="server" id="DonationPaymentDetails" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <Pages>
            <con:TabList runat="server" Title="Fund allocation" EnableCreation="false">
                <con:DonationAmountList runat="server" id="DonationAmountList" />
            </con:TabList>
            <con:TabList runat="server" Title="Payments" EnableCreation="false">
                <con:BookingPaymentList runat="server" id="BookingPaymentList" />
            </con:TabList>
<%--            <con:TabList runat="server" Title="Receipts" EnableCreation="false">
                <con:BookingInvoiceList runat="server" id="BookingInvoiceList" />
            </con:TabList>--%>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" ShowAttachmentBookingFields="true" />
</asp:Content>