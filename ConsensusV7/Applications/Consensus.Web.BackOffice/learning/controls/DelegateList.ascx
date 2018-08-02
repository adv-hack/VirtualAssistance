<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DelegateList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.DelegateList" %>
<con:DataTable runat="server" ID="DelegateListResult" CanCreate="false" CanModify="false">
  <Columns>
    <con:DataTableLinkColumn Title="Name" LinkHref="~/crm/personpage.aspx?id={{DEL_PERSON_ID}}" LinkText="{{PROLE_PN_NAME}}" />  
    <con:DataTableTextColumn Title="Status" FieldName="STATUS" />
    <con:DataTableTextColumn Title="Job Title" FieldName="PROLE_POS_TITLE" />
    <con:DataTableLinkColumn Title="Delegate Org" LinkHref="~/crm/organisationpage.aspx?id={{ORG_ID}}" LinkText="{{ORG_NAME}}" />  
    <con:DataTableTextColumn Title="Delegate Phone" FieldName="PROLE_PHONE"   />
    <con:DataTableLinkColumn Title="Delegate Email" LinkHref="mailto:{{PROLE_EMAIL}}" LinkText="{{PROLE_EMAIL}}"   />
    <con:DataTableLinkColumn Title="Booking Org" LinkHref="~/crm/organisationpage.aspx?id={{BOOK_ORG_ID}}" LinkText="{{BOOK_ORG_NAME}}" />  
    <con:DataTableTextColumn Title="Booking Ref" FieldName="DEL_BOOK_ID"   /> 
  </Columns>
</con:DataTable>




