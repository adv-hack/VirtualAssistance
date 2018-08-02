<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ActivityList.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.ActivityList" %>
<con:DataTable runat="server" ID="ActivityListResult" Mode="RealTime" Url="~/GenericPopup.aspx?context=crm&control=activitydetailbasic&id={{Id}}&buttons=30&width=1200">
  <Columns>
    <con:DataTableTextColumn Title="Type" FieldName="ACT_TYPE" />
    <con:DataTableTextColumn Title="Title" FieldName="ACT_SESSION_NAME" />
    <con:DataTableDateColumn Title="Start date" FieldName="ACT_ACTION_DATE" /> 
    <con:DataTableLinkColumn Title="Person" LinkHref="~/crm/personpage.aspx?id={{PN_ID}}&role={{PROLE_ID}}" LinkText="{{ACTXREF_PN_NAME}}" />
    <con:DataTableLinkColumn Title="Organisation" LinkHref="~/crm/organisationpage.aspx?id={{ORG_ID}}" LinkText="{{ACTXREF_ORG_NAME}}" />
    <con:DataTableTextColumn Title="Notes" FieldName="ACT_NOTE" />  
  </Columns>
</con:DataTable>
