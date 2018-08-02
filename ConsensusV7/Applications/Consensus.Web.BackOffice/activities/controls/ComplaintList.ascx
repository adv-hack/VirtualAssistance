<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ComplaintList.ascx.cs" Inherits="Consensus.Web.BackOffice.activities.controls.ComplaintList" %>

<con:DataTable runat="server" ID="ComplaintLists" Mode="Redirect"  CreateUrl="~/activities/complaints?" Url="~/activities/complaints?id={{Id}}">
    <Columns>
    <con:DataTableTextColumn Title="ID" FieldName="CMPL_ID" />
    <con:DataTableTextColumn Title="Summary" FieldName="CMPL_TITLE" />  
    <con:DataTableTextColumn Title="Status" FieldName="CMPL_STATUS_1" />
    <con:DataTableLinkColumn Title="Complainant" LinkHref="personpage.aspx?id={{PERSON_ID_COMPLAINANT}}&role={{CMPL_FROM_PROLE_ID}}" LinkText="{{FROM_PROLE_PN_NAME}}" />
    <con:DataTableLinkColumn Title="Assigned to" LinkHref="personpage.aspx?id={{PERSON_ID_ASSIGNEE}}&role={{CMPL_MGR_PROLE_ID}}" LinkText="{{MGR_PROLE_PN_NAME}}" />
    <con:DataTableLinkColumn Title="Owner" LinkHref="personpage.aspx?id={{PERSON_ID_OWNER}}&role={{CMPL_MEDTR_PROLE_ID}}" LinkText="{{MEDTR_PROLE_PN_NAME}}" /> 
    <con:DataTableDateColumn Title="Complaint date" FieldName="CMPL_DATE_OF_COMPL" /> 
    <con:DataTableDateColumn Title="Next action date" FieldName="CMPL_DATE_NEXT_ACT" />  
   </Columns>
</con:DataTable>