<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="CampaignPage.aspx.cs" Inherits="Consensus.Web.BackOffice.marketing.CampaignPage" %>
<%@ Register TagPrefix="con" TagName="CampaignDetail" Src="~/marketing/controls/CampaignDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="PromotionMasterList" Src="~/marketing/controls/PromotionMasterList.ascx" %>
<%@ Register TagPrefix="con" TagName="ActivityList" Src="~/crm/controls/ActivityList.ascx" %>
<%@ Register TagPrefix="con" TagName="CampaignStatisticsDetail" Src="~/marketing/controls/CampaignStatisticsDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="ReadModeToolbar" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="EditModeToolbar" runat="server">
</asp:Content>--%>

<asp:Content ID="Content3" ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:CampaignDetail runat="server" id="CampaignDetail" />
            </con:TabPage>
             <con:TabPage runat="server" Title="Statistics">
                <con:CampaignStatisticsDetail runat="server" id="CampaignStatisticsDetail" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <Pages>
            <con:TabList runat="server" Title="Promotion Masters"  EnableCreation="true">
                <con:PromotionMasterList runat="server" id="PromotionMasterList" />
            </con:TabList>
            <con:TabList runat="server" Title="Activities" EnableCreation="true">
                <con:ActivityList runat="server" id="ActivityList" />
            </con:TabList>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>

