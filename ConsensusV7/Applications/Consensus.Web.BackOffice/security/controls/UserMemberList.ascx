<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserMemberList.ascx.cs" Inherits="Consensus.Web.BackOffice.security.controls.UserMemberList" %>

<%-- The member list displays all security principals that are members of the current group --%>
<con:DataTable runat="server" ID="MemberList" Mode="Stateful" CanExport="true" CanPrint="true" CanSearch="true" CanCreate="true" CanModify="false" Url="~/genericpopup.aspx?context=security&control=principallist" >
  <Columns>
    <con:DataTableCustomColumn Title="Name">
        switch (row.PrincipalType)
        {
            case 'User': 
                var page = consensus.resolveUrl('~/security/useraccount?id=' + row.UserAccounts[0].Id);
                var link = $('<a />').attr('href', page).text(row.DisplayName);
                return link[0].outerHTML;
            case 'Group': 
                var page = consensus.resolveUrl('~/security/usergroup?id=' + row.UserGroups[0].Id);
                var link = $('<a />').attr('href', page).text(row.DisplayName);
                return link[0].outerHTML;
            default:
                return row.DisplayName;
        }
    </con:DataTableCustomColumn>
  </Columns>
</con:DataTable>