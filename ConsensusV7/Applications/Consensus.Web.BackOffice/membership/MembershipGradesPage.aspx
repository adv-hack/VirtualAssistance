<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MembershipGradesPage.aspx.cs" MasterPageFile="~/assets/templates/StandardDetail.master" Inherits="Consensus.Web.BackOffice.membership.MembershipGradesPage" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<%@ Register TagPrefix="con" TagName="MembershipGradeDetails" Src="~/membership/controls/MembershipGradesDetails.ascx" %>
<%@ Register TagPrefix="con" TagName="PricesList" Src="~/learning/controls/ProductPriceList.ascx" %>
<%@ Register TagPrefix="con" TagName="OnlineDetails" Src="~/learning/controls/productonlinedetails.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:MembershipGradeDetails runat="server" id="MembershipGradeDetails" />
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