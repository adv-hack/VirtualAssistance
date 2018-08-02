<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberPeriodsList.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.MemberPeriodsList" %>
<con:DataTable runat="server" ID="MemberPeriodListResult" Mode="Redirect" Url="~/membership/memberpage.aspx?id={{Id}}" CanCreate="false">
  <Columns>
    <con:DataTableTextColumn Title="Period ID" FieldName="MEP_ID" />
    <con:DataTableLinkColumn Title="Contact" LinkHref="~/crm/personpage.aspx?id={{PN_ID}}&role={{MEL_PROLE_ID}}" LinkText="{{PROLE_PN_NAME}}" />
    <con:DataTableLinkColumn Title="Organisation" LinkHref="~/crm/organisationpage.aspx?id={{MEL_ORG_ID}}" LinkText="{{ORG_NAME}}" />
    <con:DataTableLinkColumn Title="Product" LinkHref="~/membership/membershipproductpage.aspx?id={{MEP_PROD_ID}}" LinkText="{{PROD_NAME}}" />
    <con:DataTableDateColumn Title="Start date" FieldName="MEP_START" />
    <con:DataTableDateColumn Title="End date" FieldName="MEP_END" />  
    <con:DataTableTextColumn Title="Status" FieldName="MEP_STATUS" />   
  </Columns>
</con:DataTable>
 
