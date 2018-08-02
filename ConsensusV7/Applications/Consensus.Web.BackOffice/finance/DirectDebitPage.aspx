<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="DirectDebitPage.aspx.cs" Inherits="Consensus.Web.BackOffice.finance.DirectDebitPage" %>
<%@ Register TagPrefix="con" TagName="DirectDebitDetails" Src="~/finance/controls/directdebitdetails.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ReadModeToolbar" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="EditModeToolbar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:DirectDebitDetails runat="server" id="DirectDebitDetail" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>