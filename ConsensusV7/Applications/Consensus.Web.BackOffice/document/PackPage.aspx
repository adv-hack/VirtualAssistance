<%@ Page Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="PackPage.aspx.cs" Inherits="Consensus.Web.BackOffice.document.PackPage" %>

<%@ Register TagPrefix="con" TagName="PackDetails" Src="~/document/controls/PackDetails.ascx" %>
<%@ Register TagPrefix="con" TagName="DocumentTemplateList" Src="~/document/controls/DocumentTemplateList.ascx" %>
<%@ Register TagPrefix="con" TagName="PackEmailDetail" Src="~/document/controls/PackEmailDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:PackDetails runat="server" ID="PackDetails" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Email">
                <con:PackEmailDetail runat="server" ID="PackEmailDetail" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" ID="BottomTabControl">
        <Pages>
            <con:TabList runat="server" Title="Document templates">
                <con:DocumentTemplateList runat="server" ID="DocumentTemplateList" />
            </con:TabList>
        </Pages>
    </con:TabControl>
</asp:Content>
<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>
