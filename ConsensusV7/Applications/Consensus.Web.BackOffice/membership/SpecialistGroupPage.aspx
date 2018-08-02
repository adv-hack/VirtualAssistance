<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/assets/templates/StandardDetail.master" CodeBehind="SpecialistGroupPage.aspx.cs" Inherits="Consensus.Web.BackOffice.membership.SpecialistGroupPage" %>

<%@ Register TagPrefix="con" TagName="SpecialistGroupDetails" Src="~/membership/controls/SpecialistGroupDetails.ascx" %>
<%@ Register TagPrefix="con" TagName="PricesList" Src="~/learning/controls/ProductPriceList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>
<%@ Register TagPrefix="con" TagName="OnlineDetails" Src="~/learning/controls/productonlinedetails.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:SpecialistGroupDetails runat="server" id="SpecialistGroupDetails" />
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
    <con:PageFooter runat="server" />
</asp:Content>