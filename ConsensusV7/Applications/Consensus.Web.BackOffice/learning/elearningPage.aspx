<%@ Page Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master"  AutoEventWireup="true" CodeBehind="elearningPage.aspx.cs" Inherits="Consensus.Web.BackOffice.learning.elearningPage" %>
<%@ Register TagPrefix="con" TagName="ElearningDetails" Src="~/learning/controls/elearningdetails.ascx" %>
<%@ Register TagPrefix="con" TagName="PricesList" Src="~/learning/controls/ProductPriceList.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:ElearningDetails runat="server" id="ElearningDetails" />
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