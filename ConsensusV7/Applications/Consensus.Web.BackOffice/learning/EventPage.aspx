<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="EventPage.aspx.cs" Inherits="Consensus.Web.BackOffice.learning.EventPage" %>

<%@ Register TagPrefix="con" TagName="EventDetails" Src="~/learning/controls/eventdetails.ascx" %>
<%@ Register TagPrefix="con" TagName="MainSession" Src="~/learning/controls/eventmainsessiondetails.ascx" %>
<%@ Register TagPrefix="con" TagName="SessionList" Src="~/learning/controls/sessionlist.ascx" %>
<%@ Register TagPrefix="con" TagName="PriceList" Src="~/learning/controls/productpricelist.ascx" %>
<%@ Register TagPrefix="con" TagName="EventProductList" Src="~/learning/controls/eventproductlist.ascx" %>
<%@ Register TagPrefix="con" TagName="DelegateList" Src="~/learning/controls/delegatelist.ascx" %>
<%@ Register TagPrefix="con" TagName="EventTeamList" Src="~/learning/controls/EventTeamList.ascx" %>
<%@ Register TagPrefix="con" TagName="SelectionGroupList" Src="~/learning/controls/selectiongrouplist.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Details">
                <con:EventDetails runat="server" ID="EventDetails" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Sessions">
                <con:MainSession runat="server" ID="MainSessionDetails" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>
<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" ID="BottomTabControl">
        <Pages>
            <con:TabList runat="server" Title="Main Session Prices" EnableCreation="true">
                <con:PriceList runat="server" ID="PriceList" />
            </con:TabList>
            <con:TabList runat="server" Title="Sessions" EnableCreation="true">
                <con:SessionList runat="server" ID="SessionList" />
            </con:TabList>
            <con:TabList runat="server" Title="Products" EnableCreation="true">
                <con:EventProductList runat="server" ID="EventProductList" />
            </con:TabList>
            <con:TabList runat="server" Title="Delegates" EnableCreation="false">
                <con:DelegateList runat="server" ID="DelegateList" />
            </con:TabList>
            <con:TabList runat="server" Title="Selection Groups" EnableCreation="true">
                <con:SelectionGroupList runat="server" ID="SelectionGroupList" />
            </con:TabList>
            <con:TabList runat="server" Title="Event Team" EnableCreation="true">
                <con:EventTeamList runat="server" ID="EventTeamList" />
            </con:TabList>
        </Pages>
    </con:TabControl>
</asp:Content>


<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" ShowAttachmentBookingFields="true" />
</asp:Content>
