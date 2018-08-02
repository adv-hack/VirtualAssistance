<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="SourcePage.aspx.cs" Inherits="Consensus.Web.BackOffice.marketing.SourcePage" %>
<%@ Register TagPrefix="con" TagName="SourceDetail" Src="~/marketing/controls/SourceDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="SourceStatisticsDetail" Src="~/marketing/controls/SourceStatisticsDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ID="Content3" ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:SourceDetail runat="server" id="SourceDetail" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Statistics">
                <con:SourceStatisticsDetail runat="server" id="SourceStatisticsDetail" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>