<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserGroupList.ascx.cs" Inherits="Consensus.Web.BackOffice.security.controls.UserGroupList" %>

<%-- The group list displays the groups that the security principal is a member of --%>
<con:DataTable runat="server" ID="GroupList" Mode="Stateful" CanExport="true" CanPrint="true" CanSearch="true" CanCreate="true" CanModify="true" Url="~/genericpopup.aspx?context=security&control=principallist&id={{Id}}" >
  <Columns>
    <con:DataTableLinkColumn Title="Name" LinkHref="~/security/usergroup?id={{Id}}" LinkText="{{Principal.Name}}" />
  </Columns>
</con:DataTable>