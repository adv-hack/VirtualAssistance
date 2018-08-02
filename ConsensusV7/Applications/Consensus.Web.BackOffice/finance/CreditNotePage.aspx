<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="CreditNotePage.aspx.cs" Inherits="Consensus.Web.BackOffice.finance.CreditNotePage" %>
<%@ Register TagPrefix="con" TagName="CreditNoteDetails" Src="~/finance/controls/creditnotedetails.ascx" %>
<%@ Register TagPrefix="con" TagName="CreditNoteAllocation" Src="~/finance/controls/CreditNoteAllocationList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ReadModeToolbar" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="EditModeToolbar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:CreditNoteDetails runat="server" id="CreditNoteDetails" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <Pages>
             <con:TabList runat="server" EnableCreation="false" Title="Allocations" >
                <con:CreditNoteAllocation runat="server" id="CreditNoteAllocation"/>
            </con:TabList>
        </Pages>
    </con:TabControl>
</asp:Content>
<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>
