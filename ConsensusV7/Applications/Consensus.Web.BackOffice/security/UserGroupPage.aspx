<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="UserGroupPage.aspx.cs" Inherits="Consensus.Web.BackOffice.security.UserGroupPage" %>
<%@ Register TagPrefix="con" TagName="UserGroupDetails" Src="~/security/controls/usergroupdetails.ascx" %>
<%@ Register TagPrefix="con" TagName="UserGroupList" Src="~/security/controls/usergrouplist.ascx" %>
<%@ Register TagPrefix="con" TagName="UserMemberList" Src="~/security/controls/usermemberlist.ascx" %>
<%@ Register TagPrefix="con" TagName="UserPermissionList" Src="~/security/controls/userpermissionlist.ascx" %>

<asp:Content ID="Content3" ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:UserGroupDetails runat="server" id="UserGroupDetails" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Members">
                <con:UserMemberList runat="server" id="UserMemberList" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Member Of">
                <con:UserGroupList runat="server" id="UserGroupList" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Permissions">
                <con:UserPermissionList runat="server" id="UserPermissionList" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="BottomContent" runat="server">

</asp:Content>
