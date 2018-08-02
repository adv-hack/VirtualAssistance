<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="MembershipProductPage.aspx.cs" Inherits="Consensus.Web.BackOffice.membership.MembershipProductPage" %>
<%@ Register TagPrefix="con" TagName="ProductDetails" Src="~/membership/controls/membershipproductdetails.ascx" %>
<%@ Register TagPrefix="con" TagName="MembershipPackDetails" Src="~/membership/controls/membershippackdetails.ascx" %>
<%@ Register TagPrefix="con" TagName="PricesList" Src="~/learning/controls/ProductPriceList.ascx" %>
<%@ Register TagPrefix="con" TagName="GradeList" Src="~/membership/controls/MembershipProductGradesList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>
<%@ Register TagPrefix="con" TagName="OnlineDetails" Src="~/learning/controls/productonlinedetails.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:ProductDetails runat="server" id="ProductDetails" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Packs">
                <con:MembershipPackDetails runat="server" id="PackDetails" />
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
            <con:TabList runat="server" Title="Available Grades" EnableCreation="true">
                <con:GradeList runat="server" id="GradesList" />
            </con:TabList>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>