<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PersonList.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.PersonList" %>
<con:DataTable runat="server" ID="PersonListResult" Url="~/crm/person?id={{PersonId}}" CreateUrl="~/crm/person?" Mode="Redirect">
  <Columns>
    <con:DataTableLinkColumn Title="Name" LinkText="{{Name}}" LinkHref="~/crm/personpage.aspx?id={{PROLE_PERSON_ID}}"  />
    <con:DataTableTextColumn Title="Job title" FieldName="JobTitle" />
    <con:DataTableLinkColumn Title="Telephone" LinkHref="tel:{{Telephone}}" LinkText="{{Telephone}}" />
    <con:DataTableLinkColumn Title="Mobile" LinkHref="tel:{{Mobile}}" LinkText="{{Mobile}}" />
    <con:DataTableLinkColumn Title="Email" LinkHref="mailto:{{Email}}" LinkText="{{Email}}"  />  
  </Columns>
</con:DataTable>