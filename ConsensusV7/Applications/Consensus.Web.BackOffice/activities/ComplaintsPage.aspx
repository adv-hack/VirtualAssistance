<%@ Page Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="ComplaintsPage.aspx.cs" Inherits="Consensus.Web.BackOffice.activities.ComplaintsPage" %>
<%--<%@ Register TagPrefix="con" TagName="ComplaintDetail" src="~/activities/controls/ComplaintDetail.ascx" %>--%>

<%@ Register TagPrefix="con" TagName="ComplaintDetail" Src="~/activities/controls/ComplaintDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server" id="TopTabControl">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:ComplaintDetail runat="server" id="ComplaintDetails" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>
<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
     <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <Pages>            
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>