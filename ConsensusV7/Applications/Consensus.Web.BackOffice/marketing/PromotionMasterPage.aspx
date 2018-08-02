<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="PromotionMasterPage.aspx.cs" Inherits="Consensus.Web.BackOffice.marketing.PromotionMasterPage" %>
<%@ Register TagPrefix="con" TagName="PromotionMasterDetail" Src="~/marketing/controls/PromotionMasterDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="SourceList" Src="~/marketing/controls/SourceList.ascx" %>
<%@ Register TagPrefix="con" TagName="PromotionMasterStatisticsDetail" Src="~/marketing/controls/PromotionMasterStatisticsDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>


<asp:Content ID="Content3" ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:PromotionMasterDetail runat="server" id="PromotionMasterDetail" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Statistics">
                <con:PromotionMasterStatisticsDetail runat="server" id="PromotionMasterStatisticsDetail" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple">
        <Pages>
            <con:TabList runat="server" Title="Source Codes"  EnableCreation="true">
                <Content>
                    <con:SourceList runat="server" id="SourceList" />
                </Content>
            </con:TabList>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>