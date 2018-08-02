<%@ Page Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="DonationPage.aspx.cs" Inherits="Consensus.Web.BackOffice.learning.DonationPage" %>
<%@ Register TagPrefix="con" TagName="DonationDetails" Src="~/learning/controls/donationdetails.ascx" %>
<%@ Register TagPrefix="con" TagName="FinanceDetails" Src="~/learning/controls/productfinancedetails.ascx" %>
<%@ Register TagPrefix="con" TagName="OnlineDetails" Src="~/learning/controls/productonlinedetails.ascx" %>
<%@ Register TagPrefix="con" TagName="PricesList" Src="~/learning/controls/ProductPriceList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:DonationDetails runat="server" id="DonationDetails" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Finance">
                <con:FinanceDetails runat="server" id="FinanceDetails" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Online">
                <con:OnlineDetails runat="server" id="OnlineDetails" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <Pages>
            <con:TabList runat="server" Title="Prices" EnableCreation="true">
                <con:PricesList runat="server" id="PricesList" />
            </con:TabList>
        </Pages>
    </con:TabControl>
</asp:Content>
<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" ShowAttachmentBookingFields="true" />
</asp:Content>
