<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="StepPage.aspx.cs" Inherits="Consensus.Web.BackOffice.marketing.StepPage" %>
<%@ Register TagPrefix="con" TagName="StepDetail" Src="~/marketing/controls/StepDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="StepParameterList" Src="~/marketing/controls/StepParameterList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ID="Content3" ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Step Detail">
                <con:StepDetail runat="server" ID="StepDetail" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" ID="BottomTabControl">
        <Pages>
            <con:TabList runat="server" Title="Step Parameters" EnableCreation="true">
                <con:StepParameterList runat="server" id="StepParameterList" />
            </con:TabList>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>