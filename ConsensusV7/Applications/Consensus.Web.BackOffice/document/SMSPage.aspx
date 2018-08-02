<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="SMSPage.aspx.cs" Inherits="Consensus.Web.BackOffice.document.SMSPage" %>
<%@ Register TagPrefix="con" TagName="SMSDetail" Src="~/document/controls/SMSDetail.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ReadModeToolbar" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="EditModeToolbar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server" id="TopTabControl">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:SMSDetail runat="server" id="SMSDetail" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="BottomContent" runat="server">
</asp:Content>
