<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RoleList.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.RoleList" %>
<con:DataTable runat="server" ID="PersonRoleList" Url="~/crm/personpage.aspx?role={{Id}}&id={{PersonId}}" Mode="Redirect" CreateMode="RealTime" CreateUrl="~/GenericPopup.aspx?context=crm&control=newroledetail">
  <Columns>
    <con:DataTableTextColumn Title="Job title" FieldName="Job Title" />
    <con:DataTableLinkColumn Title="Organisation" LinkHref="organisationPage.aspx?id={{PROLE_ORG_ID}}" LinkText="{{Organisation}}" />
    <con:DataTableTextColumn Title="Address" FieldName="Address" />
    <con:DataTableLinkColumn Title="Telephone" LinkHref="tel:{{Telephone}}" LinkText="{{Telephone}}" />
    <con:DataTableLinkColumn Title="Mobile" LinkHref="tel:{{Mobile}}" LinkText="{{Mobile}}" />
    <con:DataTableLinkColumn Title="Email address" LinkHref="mailto:{{Email Address}}" LinkText="{{Email Address}}"  />  
    <con:DataTableIconColumn Title="Main role" FieldName="PROLE_PRINCIP_ROLE" />
    <con:DataTableTextColumn Title="Status" FieldName="PROLE_DIS_FLAG_DESC" />
  </Columns>
</con:DataTable>
