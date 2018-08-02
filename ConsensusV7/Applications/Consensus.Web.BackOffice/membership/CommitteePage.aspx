<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CommitteePage.aspx.cs" MasterPageFile="~/assets/templates/StandardDetail.master" Inherits="Consensus.Web.BackOffice.membership.CommitteePage" %>
<%@ Register TagPrefix="con" TagName="CommitteeDetail" Src="~/membership/controls/CommitteeDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="CommitteeMemberList" Src="~/membership/controls/CommitteeMemberList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server" id="TopTabControl">
        <Pages>
            <con:TabPage runat="server" Title="Overview">      
                <con:CommitteeDetail runat="server" ID="CommitteeDetail" />         
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <Pages>            
            <con:TabList runat="server" Title="Committee members">
                <con:CommitteeMemberList  runat="server" ID="CommitteeMemberList"/>
            </con:TabList>
        </Pages>
    </con:TabControl>
</asp:content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>