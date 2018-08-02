<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="UserAccountPage.aspx.cs" Inherits="Consensus.Web.BackOffice.security.UserAccountPage" %>
<%@ Register TagPrefix="con" TagName="UserAccountDetail" Src="~/security/controls/useraccountdetail.ascx" %>
<%@ Register TagPrefix="con" TagName="UserPermissionList" Src="~/security/controls/userpermissionlist.ascx" %>
<%@ Register TagPrefix="con" TagName="UserGroupList" Src="~/security/controls/usergrouplist.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
  <con:TabControl runat="server">
    <Pages>
      <con:TabPage runat="server" Title="Overview">
        <con:UserAccountDetail runat="server" id="UserDetails" />
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