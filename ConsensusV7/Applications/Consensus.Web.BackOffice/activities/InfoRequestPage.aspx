<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master"  AutoEventWireup="true" CodeBehind="InfoRequestPage.aspx.cs" Inherits="Consensus.Web.BackOffice.activities.InfoRequestPage" %>
<%@ Register TagPrefix="con" TagName="InfoRequestDetail" Src="~/activities/controls/InfoRequestDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server" id="TopTabControl">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:InfoRequestDetail runat="server" id="InfoRequestDetail" />
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