<%@ Page Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="AccountPage.aspx.cs" Inherits="Consensus.Web.BackOffice.finance.AccountPage" %>

<%@ Register TagPrefix="con" TagName="AccountDetail" Src="~/finance/controls/AccountDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="AccountInvoiceRules" Src="~/finance/controls/AccountInvoiceRules.ascx" %>
<%@ Register TagPrefix="con" TagName="AccountInvoiceList" Src="~/finance/controls/AccountInvoiceList.ascx" %>
<%@ Register TagPrefix="con" TagName="BookingPaymentList" Src="~/learning/controls/BookingPaymentList.ascx" %>
<%@ Register TagPrefix="con" TagName="AccountPersonList" Src="~/finance/controls/AccountPersonList.ascx" %>
<%@ Register TagPrefix="con" TagName="AccountCreditNoteList" Src="~/learning/controls/BookingCreditNoteList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server" id="TopTabControl">
        <pages>
            <con:TabPage runat="server" Title="Overview">       
                <con:AccountDetail runat="server" ID="AccountDetail" />                      
            </con:TabPage>
            <con:TabPage runat="server" Title="Invoicing">       
                <con:AccountInvoiceRules runat="server" ID="AccountInvoiceRules" />                      
            </con:TabPage>
        </pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <pages>      
            <con:TabList runat="server" Title="Contacts and Organisations" >
                <con:AccountPersonList runat="server" id="AccountPersonList" />
            </con:TabList>
            <con:TabList runat="server" Title="Invoices" >
                <con:AccountInvoiceList runat="server" id="AccountInvoiceList" />
            </con:TabList>      
            <con:TabList runat="server" Title="Payments" EnableCreation="false">
                <con:BookingPaymentList runat="server" id="BookingPaymentList" />
            </con:TabList>     
            <con:TabList runat="server" Title="Credit notes">
                <con:AccountCreditNoteList runat="server" id="AccountCreditNoteList" />
            </con:TabList>
        </pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>