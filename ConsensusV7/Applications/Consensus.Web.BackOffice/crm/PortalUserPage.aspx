<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="PortalUserPage.aspx.cs" Inherits="Consensus.Web.BackOffice.crm.PortalUserPage" %>
<%@ Register TagPrefix="con" TagName="PortalUserDetail" Src="~/crm/controls/PortalUserDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="PortalUserPortalsList" Src="~/crm/controls/PortalUserPortalList.ascx" %>
<%@ Register TagPrefix="con" TagName="PortalUserRolesList" Src="~/crm/controls/PortalUserRoleList.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server" id="TopTabControl">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <Content>
                    <con:PortalUserDetail runat="server" id="PortalUserDetail" />                     
                </Content>
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>
<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
     <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <Pages>
            <con:TabList runat="server" EnableCreation="true" Title="Portals" >
                 <Content>
                     <con:PortalUserPortalsList runat="server" id="PortalUserPortalsList" />
                 </Content>
            </con:TabList>
            <con:TabList runat="server" EnableCreation="true" Title="Portal Roles" >
                 <Content>
                     <con:PortalUserRolesList runat="server" id="PortalUserRolesList" />
                 </Content>
            </con:TabList>
        </Pages>
    </con:TabControl>
</asp:Content>
