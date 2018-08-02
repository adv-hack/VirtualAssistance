<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/assets/templates/StandardDetail.master"  CodeBehind="ConsultantSchemePage.aspx.cs" Inherits="Consensus.Web.BackOffice.membership.ConsultantSchemePage" %>

<%@ Register TagPrefix="con" TagName="ConsultantScheme" Src="~/membership/controls/ConsultantSchemeDetails.ascx" %>
<%@ Register TagPrefix="con" TagName="PricesList" Src="~/learning/controls/ProductPriceList.ascx" %>
<%@ Register TagPrefix="con" TagName="OnlineDetails" Src="~/learning/controls/productonlinedetails.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:ConsultantScheme runat="server" id="ConsultantScheme" />
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