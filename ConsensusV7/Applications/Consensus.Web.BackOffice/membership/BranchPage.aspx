<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/assets/templates/StandardDetail.master" CodeBehind="BranchPage.aspx.cs" Inherits="Consensus.Web.BackOffice.membership.BranchPage" %>

<%@ Register TagPrefix="con" TagName="BranchDistrictList" Src="~/membership/controls/BranchDistrictList.ascx" %>
<%@ Register TagPrefix="con" TagName="BranchDetail" Src="~/membership/controls/BranchDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="CommitteeList" Src="~/membership/controls/CommitteeList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server" id="TopTabControl">
        <pages>
            <con:TabPage runat="server" Title="Overview">      
                <con:BranchDetail runat="server" ID="BranchDetail" />         
            </con:TabPage>
        </pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <pages>
            <con:TabList runat="server" Title="Districts" >
                <con:BranchDistrictList runat="server" id="BranchDistrictList" />
            </con:TabList>  
            <con:TabList runat="server" Title="Committees" >
                <con:CommitteeList runat="server" id="CommitteeList" />
            </con:TabList>  
        </pages>
    </con:TabControl>
</asp:Content>
<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>
