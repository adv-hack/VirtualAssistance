<%@ Page Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="WordTemplatePage.aspx.cs" Inherits="Consensus.Web.BackOffice.document.WordTemplatePage" %>


<%@ Register TagPrefix="con" TagName="WordTemplateDetail" Src="~/document/controls/wordtemplatedetails.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:WordTemplateDetail runat="server" ID="WordTemplateDetails" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>






<%--<asp:Content ID="Content1" ContentPlaceHolderID="ReadModeToolbar" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="EditModeToolbar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopContent" runat="server">
    <con:WordTemplateDetail runat="server" ID="WordTemplateDetails" />
</asp:Content>--%>
<%--<asp:Content ID="Content4" ContentPlaceHolderID="BottomContent" runat="server">
</asp:Content>--%>
<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>
