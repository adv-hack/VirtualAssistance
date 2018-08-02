<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LocationPage.aspx.cs" MasterPageFile="~/assets/templates/StandardDetail.master" Inherits="Consensus.Web.BackOffice.learning.LocationPage" %>
<%@ Register TagPrefix="con" Src="~/learning/controls/LocationDetail.ascx" TagName="LocationDetail" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server" ID="TopTabControl">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:LocationDetail runat="server" ID="LocationDetail"></con:LocationDetail>
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" ID="BottomTabControl">
        <Pages>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" ShowAttachmentBookingFields="true" />
</asp:Content>


